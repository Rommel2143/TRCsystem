Public Class sub_frame
    Private Sub sub_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_formsub(mainpage)
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        If client.user_idno = "" Then
            display_formsub(New Login)
        Else
            If btn_profile.ContextMenuStrip IsNot Nothing Then
                btn_profile.ContextMenuStrip.Show(btn_profile, 0, btn_profile.Height)

                btn_administrator.Visible = admin_check()

            End If
            End If

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        logout_user()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_administrator.Click
        display_formsub(admin_acess)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        display_formsub(mainpage)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class