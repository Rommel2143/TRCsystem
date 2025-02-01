Imports MySql.Data.MySqlClient
Public Class qc_scanning
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub qc_scanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        con.Open()
        Dim query As String = "SELECT `remarks` FROM `trc_device` WHERE PCname='" & PC_name & "'"
        Dim selectline As New MySqlCommand(query, con)
        dr = selectline.ExecuteReader
        If dr.Read = True Then
            lbl_line.Text = dr.GetString("remarks")
            reload("SELECT `qrcode`, `qty`,`timein` FROM `denso_line_traceability` WHERE datein=CURDATE()", datagrid_bezel)
        End If
    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                ' Insert into denso_line_boxes
                Dim insertQuery As String = "INSERT INTO `denso_line_traceability`(`qrcode`, `qty`, `line`, `bezel`, `retainer`, `tape`, `timein`, `datein`, `userin`) VALUES ('" & txtqr.Text & "','" & txtqty.Text & "','" & lbl_line.Text & "',1,2,3,CURTIME(),CURDATE(),'" & user_idno & "')"
                Using cmd As New MySqlCommand(insertQuery, con)
                    cmd.ExecuteNonQuery()
                    reload("SELECT `qrcode`, `qty`,`timein` FROM `denso_line_traceability` WHERE datein=CURDATE()", datagrid_bezel)
                End Using
            Catch ex As MySqlException When ex.Number = 1062
                show_error("Duplicate entry detected", 2)

            Catch ex As Exception
                show_error($"Error on saving: {ex.Message}", 1)

            Finally
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub
End Class