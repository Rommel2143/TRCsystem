Imports MySql.Data.MySqlClient
Public Class add_user
    Private Sub add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadusers()
        cmb_display("SELECT CONCAT(id, ': ', section_name) AS display_value FROM trc_section", cmb_section)
    End Sub

    Private Sub loadusers()
        reload("SELECT `id`, `IDno`, CONCAT(`last`, ', ', `firstname`) as Fullname, `section`, `level`,retainer, logistics, ITadmin FROM `trc_user` ORDER BY last ASC", datagrid_user)
        If datagrid_user.Columns.Contains("id") Then
            datagrid_user.Columns("id").Visible = False
        End If

        For Each colName As String In {"retainer", "logistics", "ITadmin"}
            If datagrid_user.Columns.Contains(colName) Then
                Dim chkColumn As New DataGridViewCheckBoxColumn()
                With chkColumn
                    .HeaderText = colName
                    .Name = colName
                    .DataPropertyName = colName
                    .TrueValue = 1
                    .FalseValue = 0
                    .ThreeState = False
                End With

                ' Replace existing column with CheckBox column
                Dim index As Integer = datagrid_user.Columns(colName).Index
                datagrid_user.Columns.Remove(colName)
                datagrid_user.Columns.Insert(index, chkColumn)
            End If
        Next
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
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
                insertdata.Parameters.AddWithValue("@Level", 1) ' Assuming level is always 1 as per your original code
                insertdata.Parameters.AddWithValue("@Icon", String.Empty) ' Assuming empty string for the icon

                insertdata.ExecuteNonQuery()
            End Using
            ClearFields()
            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reload("SELECT `id`, `IDno`, CONCAT(`last`, ', ', `firstname`) as Fullname, `section`, `level` FROM `trc_user` ORDER BY last ASC", datagrid_user)
            If datagrid_user.Columns.Contains("id") Then
                datagrid_user.Columns("id").Visible = False
            End If
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



    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            reload("SELECT `id`, `IDno`, CONCAT(`last`, ', ', `firstname`) as Fullname, `section`, `level` FROM `trc_user` ORDER BY last ASC", datagrid_user)
        Else
            reload("SELECT `id`, `IDno`, CONCAT(`last`, ', ', `firstname`) as Fullname, `section`, `level` FROM `trc_user` WHERE `firstname` REGEXP '" & txt_search.Text & "' OR `last` REGEXP '" & txt_search.Text & "' OR `IDno` REGEXP '" & txt_search.Text & "' ORDER BY last ASC", datagrid_user)
        End If

        ' Hide the "id" column after reloading the data
        If datagrid_user.Columns.Contains("id") Then
            datagrid_user.Columns("id").Visible = False
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        panel_user.Visible = True
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        panel_user.Visible = False
    End Sub

    Private Sub panel_user_Paint(sender As Object, e As PaintEventArgs) Handles panel_user.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            For Each row As DataGridViewRow In datagrid_user.Rows
                If Not row.IsNewRow Then
                    Dim id As Integer = Convert.ToInt32(row.Cells("id").Value)
                    Dim retainer As Integer = If(Convert.ToBoolean(row.Cells("retainer").Value), 1, 0)
                    Dim logistics As Integer = If(Convert.ToBoolean(row.Cells("logistics").Value), 1, 0)
                    Dim ITadmin As Integer = If(Convert.ToBoolean(row.Cells("ITadmin").Value), 1, 0)

                    Dim query As String = "UPDATE trc_user SET retainer=@retainer, logistics=@logistics, ITadmin=@ITadmin WHERE id=@id"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@retainer", retainer)
                        cmd.Parameters.AddWithValue("@logistics", logistics)
                        cmd.Parameters.AddWithValue("@ITadmin", ITadmin)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            show_error("Changes saved successfully!", 0)
        Catch ex As Exception
            show_error("Error saving changes: " & ex.Message, 0)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub datagrid_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_user.CellContentClick

    End Sub
End Class