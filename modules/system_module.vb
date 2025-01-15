Imports MySql.Data.MySqlClient

Module system_module

    Public Function connection() As MySqlConnection
        'Return New MySqlConnection("server=PTI-027s;user id=Inventory;password=inventory123@;database=trcsystem")
        Return New MySqlConnection("server=localhost;user id=momel;password=Magnaye2143@#;database=trcsystem")
    End Function
    Public con As MySqlConnection = connection()
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable

    Public Sub display_form(newForm As Form)

        ' Add the new form to Panel1
        With newForm

            .TopLevel = False
            Mainframe.Panel1.Controls.Add(newForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Public Sub display_formsub(newForm As Form)

        ' Add the new form to Panel1
        With newForm
            .TopLevel = False
            sub_frame.Panel1.Controls.Add(newForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Public Sub cmb_display(query As String, cmb As ComboBox)
        Try
            ' Establish MySQL connection
            con.Close()
            con.Open()
            ' Execute the query
            Using cmd As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Clear the ComboBox items
                    cmb.Items.Clear()

                    ' Loop through the query results and add them to the ComboBox
                    While reader.Read()
                        cmb.Items.Add(reader.GetString(0)) ' Assuming the first column is the desired data
                    End While

                    ' Optionally set the first item as selected

                End Using
            End Using

        Catch ex As Exception
            ' Handle errors (e.g., display an error message)
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            con.Close()
            con.Open()
            Dim loadqsl As New MySqlCommand(sql, con)
            da.SelectCommand = loadqsl
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            show_error("Unable to load data.", 0)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub



End Module
