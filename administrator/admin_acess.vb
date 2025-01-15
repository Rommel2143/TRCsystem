Public Class admin_acess
    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub

    Private Sub display_access(newForm As Form)

        ' Add the new form to Panel1
        With newForm
            .TopLevel = False
            panel1.Controls.Add(newForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        display_access(add_user)
    End Sub
End Class