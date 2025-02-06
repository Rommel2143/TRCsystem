Imports MySql.Data.MySqlClient

Module client
    'USER ///////////////////////////////
    Public Property user_idno As String
    Public Property user_first As String
    Public Property user_middle As String
    Public Property user_last As String
    Public Property user_pass As String
    Public Property user_level As Integer
    Public Property user_icon As String

    'Device /////////////////////////////////////
    Public Property PC_name As String = Environment.MachineName
    Public Property PC_location As String = Nothing

    Public Function checkping() As Boolean
        Try
            con.Close()
            con.Open() ' Attempt to open the connection
            Return True ' Connection succeeded

        Catch ex As Exception

            Return False
        End Try
    End Function

    Public Function check_access_user(column As String) As Boolean
        Dim query As String = "SELECT " & column & " FROM trc_user WHERE IDno = @idno"

        Try
            con.Close()
            con.Open()
            Using getdata As New MySqlCommand(query, con)
                getdata.Parameters.AddWithValue("@idno", user_idno)

                Using reader As MySqlDataReader = getdata.ExecuteReader()
                    If reader.Read() Then
                        If reader.GetBoolean(0) Then
                            Return True ' User has access
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving access: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        ' Show error message only when access is denied
        show_error("You don't have access to this feature. Please contact IT support if needed.", 0)
        Return False
    End Function

    Public Function check_access_pc(location As String) As Boolean
        Dim query As String = "SELECT id FROM trc_device WHERE PCname = '" & PC_name & "' and location='" & location & "'"

        Try
            con.Close()
            con.Open()
            Using getdata As New MySqlCommand(query, con)

                Using reader As MySqlDataReader = getdata.ExecuteReader()

                    Return reader.HasRows

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving access: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        ' Show error message only when access is denied
        show_error("Your PC don't have access to this feature. Please contact IT support if needed.", 0)
        Return False
    End Function

    Public Sub logout_user()
        user_idno = ""
        user_first = ""
        user_last = ""
        user_level = 0
        user_middle = ""
        user_pass = ""
        sub_frame.btn_profile.Image = My.Resources.user_0
        display_form(New Login)
    End Sub
    ' Method to retrieve user info based on ID number
    Public Function getinfo(idno As String) As Boolean

        Dim idwithA As String = "A" & idno & "A"
        Dim idwithoutA As String = idno.TrimStart("A"c).TrimEnd("A"c)
        Dim idwithoutasmall As String = idno.TrimStart("a"c).TrimEnd("a"c)

        con.Close()
        con.Open()

        Dim query As String = "SELECT * FROM trc_user WHERE IDno = @idwithoutA OR IDno = @idwithA OR IDno = @idwithoutasmall"

        Try
            con.Close()
            con.Open()
            Using getdata As New MySqlCommand(query, con)
                ' Add parameter to prevent SQL injection
                With getdata
                    .Parameters.AddWithValue("@idwithA", idwithA)
                    .Parameters.AddWithValue("@idwithoutA", idwithoutA)
                    .Parameters.AddWithValue("@idwithoutasmall", idwithoutasmall)
                End With
                ' Execute the query
                Using reader As MySqlDataReader = getdata.ExecuteReader()
                    If reader.Read() Then
                        ' Set properties based on the retrieved values
                        user_idno = reader("idno").ToString()
                        user_first = reader("firstname").ToString()
                        user_middle = reader("middle").ToString()
                        user_last = reader("last").ToString()
                        user_pass = reader("password").ToString()
                        user_level = Convert.ToInt32(reader("level"))
                        user_icon = reader.GetString("icon")
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that occur during the database operation
            MessageBox.Show($"Error retrieving user info: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Ensure the connection is closed after the operation
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function


    Public Function getPCinfo(pcname As String) As Boolean
        Try
            con.Close()
            con.Open()
            Dim query As String = "SELECT location FROM `trc_device` WHERE PCname=@pcname"
            Dim getPCloc As New MySqlCommand(query, con)
            getPCloc.Parameters.AddWithValue("@pcname", pcname)
            dr = getPCloc.ExecuteReader()

            If dr.Read() Then

                client.PC_location = dr.GetString("location")
                Return True
            Else
                show_error("No Record for this device.", 0)
                Return False
            End If

        Catch ex As Exception
            show_error("Device Problem: " & ex.Message, 0)
            Return False
        Finally
            con.Close()
        End Try
    End Function


End Module
