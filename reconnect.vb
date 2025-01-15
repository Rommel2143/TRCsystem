Public Class reconnect
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If checkping() Then
            If getPCinfo(client.PC_name) Then

                display_form(Login)
            Else

                display_form(Register_PC)

            End If

        Else
            show_error("Unable to connect to server. Please restart your device or call IT (702)", 0)

        End If
    End Sub
End Class