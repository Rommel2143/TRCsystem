Imports MySql.Data.MySqlClient
Module SnackbarModule

    Public Sub show_error(text As String, sound As Integer)

        ShowSnackbar(text)
        Select Case sound
            Case 0

            Case 1
                My.Computer.Audio.Play(My.Resources.errorsound, AudioPlayMode.Background)
            Case 2
                My.Computer.Audio.Play(My.Resources.duplicate, AudioPlayMode.Background)
        End Select

    End Sub




    Private Sub ShowSnackbar(message As String)
        ' Create a new Form to act as the snackbar
        Dim snackbarForm As New Form()

        ' Set basic properties
        snackbarForm.FormBorderStyle = FormBorderStyle.None
        snackbarForm.StartPosition = FormStartPosition.Manual
        snackbarForm.BackColor = Color.FromArgb(60, 63, 65) ' Dark background
        snackbarForm.ForeColor = Color.White ' White text
        snackbarForm.Height = 40 ' Set the height of the snackbar
        snackbarForm.Width = Screen.PrimaryScreen.Bounds.Width ' Set the width to screen width
        snackbarForm.TopMost = True ' Ensure it's on top
        snackbarForm.ShowInTaskbar = False

        ' Set the position at the top of the screen (90 pixels from the top)
        snackbarForm.Location = New Point(0, 90)

        ' Add a label to display the message
        Dim messageLabel As New Label()
        messageLabel.Text = message
        messageLabel.Font = New Font("Segoe UI", 10)
        messageLabel.ForeColor = Color.White
        messageLabel.AutoSize = False
        messageLabel.TextAlign = ContentAlignment.MiddleCenter
        messageLabel.Dock = DockStyle.Fill
        snackbarForm.Controls.Add(messageLabel)

        snackbarForm.Show()

        ' Set up a timer to close the snackbar after a few seconds
        Dim closeTimer As New Timer()
        AddHandler closeTimer.Tick, Sub(sender, e)
                                        For i As Integer = 10 To 0 Step -1
                                            snackbarForm.Opacity = i / 10.0
                                            Threading.Thread.Sleep(30)
                                        Next
                                        snackbarForm.Close()
                                        closeTimer.Stop()
                                    End Sub
        closeTimer.Interval = 3000
        closeTimer.Start()
    End Sub

    Private Sub announcement_bar(message As String)
        ' Create a new Form to act as the snackbar
        Dim snackbarForm As New Form()

        ' Set basic properties
        snackbarForm.FormBorderStyle = FormBorderStyle.None
        snackbarForm.StartPosition = FormStartPosition.Manual
        snackbarForm.BackColor = Color.FromArgb(1, 101, 225) ' Dark background
        snackbarForm.ForeColor = Color.White ' White text
        snackbarForm.Height = 30 ' Increased height to accommodate icon
        snackbarForm.Width = Screen.PrimaryScreen.Bounds.Width ' Set the width to screen width
        snackbarForm.TopMost = True ' Ensure it's on top
        snackbarForm.ShowInTaskbar = False

        ' Set the position at the top of the screen (90 pixels from the top)
        snackbarForm.Location = New Point(0, 80)

        ' Create a Panel to group the icon and message
        Dim roamingPanel As New Panel()
        roamingPanel.AutoSize = True
        roamingPanel.Location = New Point(snackbarForm.Width, 5) ' Start from the right edge
        snackbarForm.Controls.Add(roamingPanel)

        ' Add an icon (optional: adjust size to fit within snackbar height)
        Dim iconPictureBox As New PictureBox()
        iconPictureBox.Image = My.Resources.annouce_1 ' Replace with your icon resource
        iconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        iconPictureBox.Size = New Size(32, 32) ' Icon size
        iconPictureBox.Location = New Point(0, 0) ' Align at the start of the panel
        roamingPanel.Controls.Add(iconPictureBox)

        ' Add a label to display the message
        Dim messageLabel As New Label()
        messageLabel.Text = message
        messageLabel.Font = New Font("Segoe UI", 12)
        messageLabel.ForeColor = Color.White
        messageLabel.AutoSize = True
        messageLabel.Location = New Point(iconPictureBox.Width + 10, 4) ' Position next to the icon
        roamingPanel.Controls.Add(messageLabel)

        ' Add a close button
        Dim closeButton As New Button()
        closeButton.Text = "X"
        closeButton.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        closeButton.ForeColor = Color.White
        closeButton.BackColor = Color.FromArgb(1, 101, 225)
        closeButton.FlatStyle = FlatStyle.Flat
        closeButton.FlatAppearance.BorderSize = 0
        closeButton.Size = New Size(30, 30)
        closeButton.Location = New Point(snackbarForm.Width - 40, 5) ' Position close to the right edge
        AddHandler closeButton.Click, Sub(sender, e)
                                          snackbarForm.Close()
                                      End Sub
        snackbarForm.Controls.Add(closeButton)

        ' Create a Timer to move the panel
        Dim moveTimer As New Timer()
        moveTimer.Interval = 30 ' Set the interval for smooth animation
        AddHandler moveTimer.Tick, Sub(sender, e)
                                       roamingPanel.Left -= 3 ' Move the panel to the left
                                       ' If the panel moves out of bounds, reset its position
                                       If roamingPanel.Right < 0 Then
                                           roamingPanel.Left = snackbarForm.Width - 30
                                       End If
                                   End Sub

        ' Start the Timer
        moveTimer.Start()

        ' Show the form
        snackbarForm.Show()
    End Sub


    Public Sub get_announce()

        Dim query As String = "SELECT `announcement` FROM `trc_annoucement` WHERE date_exp > CURDATE() and level = 3"
        con.Close()
        con.Open()
        Dim getstring As New MySqlCommand(query, con)
        dr = getstring.ExecuteReader()
        If dr.Read = True Then
            announcement_bar(dr.GetString(0))
        End If
    End Sub


End Module
