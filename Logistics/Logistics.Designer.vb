<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.menustrip = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustrip
        '
        Me.menustrip.BackColor = System.Drawing.Color.White
        Me.menustrip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.SectionToolStripMenuItem})
        Me.menustrip.Location = New System.Drawing.Point(0, 0)
        Me.menustrip.Name = "menustrip"
        Me.menustrip.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.menustrip.Size = New System.Drawing.Size(1168, 30)
        Me.menustrip.TabIndex = 1
        Me.menustrip.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'SectionToolStripMenuItem
        '
        Me.SectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogisticsToolStripMenuItem, Me.OUTToolStripMenuItem})
        Me.SectionToolStripMenuItem.Name = "SectionToolStripMenuItem"
        Me.SectionToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.SectionToolStripMenuItem.Text = "Scanning"
        '
        'LogisticsToolStripMenuItem
        '
        Me.LogisticsToolStripMenuItem.Name = "LogisticsToolStripMenuItem"
        Me.LogisticsToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LogisticsToolStripMenuItem.Text = "IN"
        '
        'OUTToolStripMenuItem
        '
        Me.OUTToolStripMenuItem.Name = "OUTToolStripMenuItem"
        Me.OUTToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.OUTToolStripMenuItem.Text = "OUT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1168, 703)
        Me.Panel1.TabIndex = 2
        '
        'Logistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.menustrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Logistics"
        Me.Text = "Logistics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menustrip.ResumeLayout(False)
        Me.menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menustrip As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
