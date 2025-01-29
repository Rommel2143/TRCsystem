Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class parts_line
    Private Sub parts_line_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_line()
    End Sub
    Private Sub load_line()
        Try
            con.Close()
            con.Open()
            Dim query As String = "SELECT line FROM denso_line"
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            While dr.Read = True
                addobject_line(flow1, dr.GetString("line"), "")
            End While
        Catch ex As Exception

        End Try
    End Sub
    ' Event handler for when a child panel is clicked
    Public Sub ChildPanel_Click(sender As Object, e As EventArgs)
        ' Cast the sender to a Guna2Panel
        Dim clickedPanel As Guna2Panel = TryCast(sender, Guna2Panel)

        If clickedPanel IsNot Nothing Then
            ' Retrieve the line name from the first label in the panel
            Dim lineNameLabel As Label = TryCast(clickedPanel.Controls(0), Label)
            If lineNameLabel IsNot Nothing Then
                Dim lineName As String = lineNameLabel.Text

                ' Perform an action based on the clicked panel
                MessageBox.Show($"You clicked on: {lineName}", "Panel Clicked")
            End If
        End If
    End Sub


    Private Sub flow1_Paint(sender As Object, e As PaintEventArgs) Handles flow1.Paint

    End Sub
End Class