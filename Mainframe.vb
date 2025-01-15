Imports Guna.UI2.WinForms
Imports System.Threading
Public Class Mainframe

    Private Sub Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If checkping() Then
            If getPCinfo(client.PC_name) Then

                display_form(New Login)


            Else

                display_form(Register_PC)

            End If

        Else
            show_error("Unable to connect to server. Please restart your device or call IT (702)", 0)
            display_form(reconnect)
        End If



    End Sub


End Class
