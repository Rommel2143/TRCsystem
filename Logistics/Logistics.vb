Public Class Logistics
    Private Sub Logistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyBaseToolStripMenuItem.Click
        show_form(logistics_IN)
    End Sub
    Public Sub show_form(newForm As Form)

        ' Add the new form to Panel1
        With newForm
            .TopLevel = False
            Panel1.Controls.Add(newForm)
            .BringToFront()
            .Show()
        End With

    End Sub
End Class