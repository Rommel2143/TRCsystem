Imports MySql.Data.MySqlClient
Public Class add_kitting_item
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try


            con.Close()
            con.Open()
            Dim query As String = "INSERT INTO `denso_kitting_masterlist`(`partno`, `type`) VALUES ('" & txtqr.Text.Trim & "','" & cmb_type.Text.Substring(0, 1) & "')"
            Dim insert As New MySqlCommand(query, con)
            insert.ExecuteNonQuery()
            show_error("Item Saved!", 0)
            txtqr.Clear()
            reload_data()
        Catch ex As Exception
            show_error(ex.Message, 0)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub add_kitting_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_data()
    End Sub

    Private Sub reload_data()
        ' Reload data into the DataGridView
        reload("SELECT id, partno, 
                 CASE 
                    WHEN type = 1 THEN 'BEZEL'
                    WHEN type = 2 THEN 'RETAINER'
                    WHEN type = 3 THEN 'TAPE'
                    ELSE 'UNKNOWN'
                 END AS partname 
            FROM denso_kitting_masterlist", datagrid_kitting)

        datagrid_kitting.Columns("id").Visible = False
        ' Add an image button column for the delete functionality
        Dim editbutton As New DataGridViewImageColumn()

        editbutton.Image = My.Resources.trash ' Use your resource image
        editbutton.Name = "Edit"
        editbutton.HeaderText = "Action"
        editbutton.ToolTipText = "Click to edit"
        editbutton.ImageLayout = DataGridViewImageCellLayout.Zoom

        ' Ensure the column is added only once
        If datagrid_kitting.Columns("Edit") Is Nothing Then
            datagrid_kitting.Columns.Add(editbutton)
        End If
    End Sub

    Private Sub datagrid_kitting_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_kitting.CellContentClick
        If e.ColumnIndex = datagrid_kitting.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            Dim id As String = datagrid_kitting.Rows(e.RowIndex).Cells("id").Value.ToString()
            Dim partno As String = datagrid_kitting.Rows(e.RowIndex).Cells("partno").Value.ToString()
            If MessageBox.Show($"Are you sure you want to delete: {partno}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Close()
                con.Open()
                Dim query As String = "DELETE FROM `denso_kitting_masterlist` WHERE id='" & id & "'"
                Dim insert As New MySqlCommand(query, con)
                insert.ExecuteNonQuery()
                show_error("Item Deleted", 0)
                reload_data()
            End If
        End If
    End Sub
End Class