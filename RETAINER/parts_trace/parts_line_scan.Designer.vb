<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parts_line_scan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(parts_line_scan))
        Me.lbl_line = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.datagrid_bezel = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtqr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.datagrid_bezel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_line
        '
        Me.lbl_line.AutoSize = True
        Me.lbl_line.Location = New System.Drawing.Point(43, 25)
        Me.lbl_line.Name = "lbl_line"
        Me.lbl_line.Size = New System.Drawing.Size(31, 13)
        Me.lbl_line.TabIndex = 0
        Me.lbl_line.Text = "LINE"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.datagrid_bezel)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtqr)
        Me.Guna2Panel1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.Location = New System.Drawing.Point(46, 86)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 12
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(366, 478)
        Me.Guna2Panel1.TabIndex = 207
        '
        'datagrid_bezel
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.datagrid_bezel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_bezel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_bezel.ColumnHeadersHeight = 4
        Me.datagrid_bezel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_bezel.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_bezel.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_bezel.Location = New System.Drawing.Point(36, 90)
        Me.datagrid_bezel.Name = "datagrid_bezel"
        Me.datagrid_bezel.RowHeadersVisible = False
        Me.datagrid_bezel.Size = New System.Drawing.Size(295, 358)
        Me.datagrid_bezel.TabIndex = 207
        Me.datagrid_bezel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_bezel.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid_bezel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid_bezel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid_bezel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid_bezel.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_bezel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_bezel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_bezel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid_bezel.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_bezel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_bezel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_bezel.ThemeStyle.HeaderStyle.Height = 4
        Me.datagrid_bezel.ThemeStyle.ReadOnly = False
        Me.datagrid_bezel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_bezel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_bezel.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_bezel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_bezel.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid_bezel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_bezel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "BEZEL"
        '
        'txtqr
        '
        Me.txtqr.BorderRadius = 3
        Me.txtqr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqr.DefaultText = ""
        Me.txtqr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtqr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtqr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtqr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr.IconLeft = CType(resources.GetObject("txtqr.IconLeft"), System.Drawing.Image)
        Me.txtqr.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtqr.Location = New System.Drawing.Point(36, 48)
        Me.txtqr.Name = "txtqr"
        Me.txtqr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqr.PlaceholderText = "Scan QR..."
        Me.txtqr.SelectedText = ""
        Me.txtqr.Size = New System.Drawing.Size(295, 36)
        Me.txtqr.TabIndex = 203
        '
        'parts_line_scan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 624)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.lbl_line)
        Me.Name = "parts_line_scan"
        Me.Text = "parts_line_scan"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.datagrid_bezel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_line As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtqr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents datagrid_bezel As Guna.UI2.WinForms.Guna2DataGridView
End Class
