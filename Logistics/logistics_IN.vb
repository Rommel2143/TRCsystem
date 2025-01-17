Imports MySql.Data.MySqlClient
Public Class logistics_IN
    Private Sub logistics_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Insert_U1(txtqr.Text.Trim, txt_batch.Text.Trim) Then
                LoadRecords()
            Else

            End If
            txtqr.Clear()
            txtqr.Focus()
        End If
    End Sub

    Private Sub txt_batch_TextChanged(sender As Object, e As EventArgs) Handles txt_batch.TextChanged
        If txt_batch.Text.Trim = "" Then
            txtqr.Enabled = False
        Else
            LoadRecords()
            txtqr.Enabled = True
        End If
    End Sub

    Private Sub LoadRecords()
        ' Load all records into DataGridView
        reload("SELECT `id`, `qrcode`, `partcode`, `lotnumber`, `supplier`, `qty`, `remarks` FROM `logistics_u1` WHERE batch = '" & txt_batch.Text & "' AND datein = CURDATE()", datagrid1)

        Try
            ' Define query for grouped data
            Dim query As String = "
            SELECT 
                l1.partcode, 
                lm.partname, 
                SUM(l1.qty) AS totalqty 
            FROM 
                logistics_u1 l1
            JOIN 
                logistics_masterlist lm 
            ON 
                lm.partcode = l1.partcode 
            WHERE 
                batch = @batch 
                AND datein = CURDATE()
            GROUP BY 
                l1.partcode;"

            ' Prepare MySQL command with parameters
            Using selectgroup As New MySqlCommand(query, con)
                selectgroup.Parameters.AddWithValue("@batch", txt_batch.Text)

                ' Ensure the connection is open
                If con.State <> ConnectionState.Open Then con.Open()

                ' Execute query and read results
                Using dr As MySqlDataReader = selectgroup.ExecuteReader()
                    ' Clear existing controls in the FlowLayoutPanel
                    flow1.Controls.Clear()

                    ' Loop through query results
                    Do While dr.Read()
                        Dim pname As String = dr.GetString("partname")
                        Dim pcode As String = dr.GetString("partcode")
                        Dim totalqty As Integer = dr.GetInt32("totalqty")

                        ' Add dynamically created objects to the FlowLayoutPanel
                        addobject_group(flow1, pname, pcode, totalqty)
                    Loop
                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors and provide feedback
            MessageBox.Show("Error loading grouped records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

End Class