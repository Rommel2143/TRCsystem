Imports MySql.Data.MySqlClient
Public Class parts_line_scan
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtqr.Clear()
            txtqr.Focus()
        End If
    End Sub


    Private Sub loadparts(line As String, type As Integer)
        Try
            reload("SELECT  FROM `denso_line_boxes` WHERE line='" & line & "' and type= " & type & "", datagrid_bezel)


        Catch ex As Exception


        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub saveparts(qrcode As String)





    End Sub



End Class