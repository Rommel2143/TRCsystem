Imports MySql.Data.MySqlClient
Public Class request_account
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        terms.ShowDialog()
        terms.BringToFront()
    End Sub

    Private Sub request_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_display("SELECT CONCAT(id, ': ', section_name) AS display_value FROM trc_section", cmb_section)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_request.Click
        Try
            If String.IsNullOrWhiteSpace(txt_idno.Text) OrElse String.IsNullOrWhiteSpace(txt_first.Text) OrElse String.IsNullOrWhiteSpace(txt_last.Text) OrElse String.IsNullOrWhiteSpace(cmb_section.Text) Then
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim sectionValue As String = cmb_section.Text.Split(":"c)(0).Trim()
            con.Close()
            con.Open()

            Dim query As String = "INSERT INTO `trc_user`(`IDno`, `firstname`, `middle`, `last`, `section`, `password`, `level`, `icon`) VALUES (@IDno, @FirstName, @Middle, @Last, @Section, NULL, @Level, @Icon)"
            Using insertdata As New MySqlCommand(query, con)
                insertdata.Parameters.AddWithValue("@IDno", txt_idno.Text.Trim())
                insertdata.Parameters.AddWithValue("@FirstName", txt_first.Text.Trim())
                insertdata.Parameters.AddWithValue("@Middle", If(String.IsNullOrWhiteSpace(txt_middle.Text), DBNull.Value, txt_middle.Text.Trim()))
                insertdata.Parameters.AddWithValue("@Last", txt_last.Text.Trim())
                insertdata.Parameters.AddWithValue("@Section", sectionValue)
                insertdata.Parameters.AddWithValue("@Level", 2) ' Assuming level is always 1 as per your original code
                insertdata.Parameters.AddWithValue("@Icon", "user_1") ' Assuming empty string for the icon

                insertdata.ExecuteNonQuery()
            End Using
            ClearFields()
            MessageBox.Show("Please wait while reviewing your account. or call IT(702)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            MessageBox.Show("An error occurred while adding the user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        txt_idno.Clear()
        txt_first.Clear()
        txt_middle.Clear()
        txt_last.Clear()
        cmb_section.SelectedIndex = -1 ' Resets the combo box
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_agree.CheckedChanged
        If chk_agree.Checked = True Then
            btn_request.Enabled = True
        Else
            btn_request.Enabled = False
        End If
    End Sub
End Class