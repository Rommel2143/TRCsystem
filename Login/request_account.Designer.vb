<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class request_account
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_request = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_section = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_last = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_middle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_first = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_idno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chk_agree = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_request
        '
        Me.btn_request.BorderRadius = 3
        Me.btn_request.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_request.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_request.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_request.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_request.Enabled = False
        Me.btn_request.FillColor = System.Drawing.Color.MidnightBlue
        Me.btn_request.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_request.ForeColor = System.Drawing.Color.White
        Me.btn_request.Location = New System.Drawing.Point(82, 408)
        Me.btn_request.Name = "btn_request"
        Me.btn_request.Size = New System.Drawing.Size(129, 45)
        Me.btn_request.TabIndex = 21
        Me.btn_request.Text = "Request Account"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(58, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(58, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Lastname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(58, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Middle initial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(58, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Firstname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "IDno"
        '
        'cmb_section
        '
        Me.cmb_section.BackColor = System.Drawing.Color.Transparent
        Me.cmb_section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_section.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_section.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_section.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_section.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_section.ItemHeight = 30
        Me.cmb_section.Location = New System.Drawing.Point(61, 310)
        Me.cmb_section.Name = "cmb_section"
        Me.cmb_section.Size = New System.Drawing.Size(187, 36)
        Me.cmb_section.TabIndex = 15
        '
        'txt_last
        '
        Me.txt_last.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_last.DefaultText = ""
        Me.txt_last.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_last.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_last.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_last.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_last.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_last.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_last.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_last.Location = New System.Drawing.Point(61, 233)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_last.PlaceholderText = "..."
        Me.txt_last.SelectedText = ""
        Me.txt_last.Size = New System.Drawing.Size(187, 36)
        Me.txt_last.TabIndex = 14
        '
        'txt_middle
        '
        Me.txt_middle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_middle.DefaultText = ""
        Me.txt_middle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_middle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_middle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_middle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_middle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_middle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_middle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_middle.Location = New System.Drawing.Point(61, 169)
        Me.txt_middle.Name = "txt_middle"
        Me.txt_middle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_middle.PlaceholderText = "..."
        Me.txt_middle.SelectedText = ""
        Me.txt_middle.Size = New System.Drawing.Size(187, 36)
        Me.txt_middle.TabIndex = 13
        '
        'txt_first
        '
        Me.txt_first.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_first.DefaultText = ""
        Me.txt_first.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_first.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_first.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_first.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_first.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_first.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_first.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_first.Location = New System.Drawing.Point(61, 108)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_first.PlaceholderText = "..."
        Me.txt_first.SelectedText = ""
        Me.txt_first.Size = New System.Drawing.Size(187, 36)
        Me.txt_first.TabIndex = 12
        '
        'txt_idno
        '
        Me.txt_idno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_idno.DefaultText = ""
        Me.txt_idno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_idno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_idno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_idno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_idno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_idno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_idno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_idno.Location = New System.Drawing.Point(61, 34)
        Me.txt_idno.Name = "txt_idno"
        Me.txt_idno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_idno.PlaceholderText = "..."
        Me.txt_idno.SelectedText = ""
        Me.txt_idno.Size = New System.Drawing.Size(187, 36)
        Me.txt_idno.TabIndex = 11
        '
        'chk_agree
        '
        Me.chk_agree.AutoSize = True
        Me.chk_agree.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_agree.CheckedState.BorderRadius = 0
        Me.chk_agree.CheckedState.BorderThickness = 0
        Me.chk_agree.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_agree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_agree.Location = New System.Drawing.Point(61, 367)
        Me.chk_agree.Name = "chk_agree"
        Me.chk_agree.Size = New System.Drawing.Size(29, 17)
        Me.chk_agree.TabIndex = 23
        Me.chk_agree.Text = "."
        Me.chk_agree.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_agree.UncheckedState.BorderRadius = 3
        Me.chk_agree.UncheckedState.BorderThickness = 1
        Me.chk_agree.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(79, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "I agree to Terms and Conditions"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.chk_agree)
        Me.Guna2Panel1.Controls.Add(Me.btn_request)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.cmb_section)
        Me.Guna2Panel1.Controls.Add(Me.txt_last)
        Me.Guna2Panel1.Controls.Add(Me.txt_middle)
        Me.Guna2Panel1.Controls.Add(Me.txt_first)
        Me.Guna2Panel1.Controls.Add(Me.txt_idno)
        Me.Guna2Panel1.Location = New System.Drawing.Point(159, 59)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(306, 478)
        Me.Guna2Panel1.TabIndex = 25
        '
        'request_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 570)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "request_account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "request_account"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_request As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_section As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_last As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_middle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_first As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_idno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chk_agree As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
