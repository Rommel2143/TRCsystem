﻿Public Class mainpage
    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_announce()
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles btn_logistics.Click

        If btn_logistics.ContextMenuStrip IsNot Nothing Then
            btn_logistics.ContextMenuStrip.Show(btn_logistics, 0, btn_logistics.Height)
        End If

    End Sub

    Private Sub UNIT1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNIT1ToolStripMenuItem.Click
        display_formsub(Logistics)
    End Sub
End Class