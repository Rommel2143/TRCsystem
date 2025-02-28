Imports MySql.Data.MySqlClient

Module system_module

    Public Function connection() As MySqlConnection
        Return New MySqlConnection("server=PTI-027s;user id=Inventory;password=inventory123@;database=trcsystem")
        'Return New MySqlConnection("server=localhost;user id=root;password=;database=trcsystem")
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


    Public Sub reload(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            dt = New DataTable()
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Using loadSql As New MySqlCommand(sql, con)
                Using da As New MySqlDataAdapter(loadSql)
                    da.Fill(dt)
                    dtg.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            show_error("Unable to load data: " & ex.Message, 0)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub



End Module
