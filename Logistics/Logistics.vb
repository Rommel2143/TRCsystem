Public Class Logistics
    Private Sub Logistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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



    Private Sub OUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem.Click

    End Sub

    Private Sub INToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem.Click
        show_form(logistics_IN)
    End Sub
End Class