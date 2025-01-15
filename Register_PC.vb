Imports MySql.Data.MySqlClient
Public Class Register_PC
    Private Sub Register_PC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpcname.Text = client.PC_name
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If txtuser.Text = "PTRCI" And txtpassword.Text = "redhorsE143" Then
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("INSERT INTO `trc_device`(`PCname`, `location`) VALUES ('" & client.PC_name & "','" & cmb_loc.Text & "')", con)
            dr = cmdselect.ExecuteReader
            Mainframe.Panel1.Controls.Clear()
            display_form(New Login)

        Else
            MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class