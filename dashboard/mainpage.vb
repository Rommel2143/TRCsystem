Public Class mainpage
    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_announce()
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles btn_logistics.Click

        If check_access_user("logistics") = True Then
            btn_logistics.ContextMenuStrip.Show(btn_logistics, 0, btn_logistics.Height)
        End If

    End Sub

    Private Sub UNIT1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNIT1ToolStripMenuItem.Click

    End Sub

    Private Sub btn_retainer_Click(sender As Object, e As EventArgs) Handles btn_retainer.Click
        If check_access_user("retainer") = True And check_access_pc("Retainer") = True Then
            btn_retainer.ContextMenuStrip.Show(btn_retainer, 0, btn_retainer.Height)

        End If
    End Sub

    Private Sub KittingAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KittingAreaToolStripMenuItem.Click
        display_formsub(kitting_IN)
    End Sub

    Private Sub PartsScanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsScanningToolStripMenuItem.Click
        display_formsub(parts_line)
    End Sub

    Private Sub QCScanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QCScanningToolStripMenuItem.Click
        display_formsub(qc_scanning)
    End Sub

    Private Sub ScanINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanINToolStripMenuItem.Click
        display_formsub(logistics_U1_IN)
    End Sub
End Class