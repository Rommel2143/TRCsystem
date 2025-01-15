Imports MySql.Data.MySqlClient
Public Class Login
    Dim pass As String




    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_user.Focus()
        lbl_pcinfo.Text = "Secure Access: " & client.PC_name
        lbl_pcinfo.Left = (panel_login.Width - lbl_pcinfo.Width) \ 2


    End Sub


    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub


    Private Sub txt_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            entry_login()
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        entry_login()
    End Sub

    Private Sub entry_login()
        Dim messageLabel As New Label()
        If getinfo(txt_user.Text) And txt_pass.Text = user_pass Then
            If user_icon = "" Then
                sub_frame.btn_profile.Image = CType(My.Resources.ResourceManager.GetObject("user_1"), Image)
            Else
                sub_frame.btn_profile.Image = CType(My.Resources.ResourceManager.GetObject(user_icon), Image)
            End If


            display_form(sub_frame)

            Me.Close()

        Else

            messageLabel.Text = "Invalid user credentials."
            messageLabel.Font = New Font("Segoe UI", 11)
            messageLabel.ForeColor = Color.Red
            messageLabel.AutoSize = True

            messageLabel.Location = New Point(275, 345)
            messageLabel.TextAlign = ContentAlignment.MiddleCenter
            panel_login.Controls.Add(messageLabel)
            txt_pass.Clear()
            txt_user.Clear()
        End If
    End Sub


    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        display_form(New request_account)
    End Sub
End Class