<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logistics))
        Me.menustrip = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemUpdaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuggestionBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustrip
        '
        Me.menustrip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.btn_user, Me.SectionToolStripMenuItem})
        Me.menustrip.Location = New System.Drawing.Point(0, 0)
        Me.menustrip.Name = "menustrip"
        Me.menustrip.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.menustrip.Size = New System.Drawing.Size(1168, 34)
        Me.menustrip.TabIndex = 1
        Me.menustrip.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'btn_user
        '
        Me.btn_user.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_user.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.SystemUpdaterToolStripMenuItem, Me.SuggestionBoxToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.btn_user.Image = CType(resources.GetObject("btn_user.Image"), System.Drawing.Image)
        Me.btn_user.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(117, 28)
        Me.btn_user.Text = "Hello, User"
        Me.btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.ProfileToolStripMenuItem.Image = CType(resources.GetObject("ProfileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProfileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.ProfileToolStripMenuItem.Text = "Profile Settings"
        '
        'SystemUpdaterToolStripMenuItem
        '
        Me.SystemUpdaterToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemUpdaterToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.SystemUpdaterToolStripMenuItem.Image = CType(resources.GetObject("SystemUpdaterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemUpdaterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SystemUpdaterToolStripMenuItem.Name = "SystemUpdaterToolStripMenuItem"
        Me.SystemUpdaterToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SystemUpdaterToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.SystemUpdaterToolStripMenuItem.Text = "System Updater"
        '
        'SuggestionBoxToolStripMenuItem
        '
        Me.SuggestionBoxToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuggestionBoxToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.SuggestionBoxToolStripMenuItem.Image = CType(resources.GetObject("SuggestionBoxToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuggestionBoxToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SuggestionBoxToolStripMenuItem.Name = "SuggestionBoxToolStripMenuItem"
        Me.SuggestionBoxToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SuggestionBoxToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.SuggestionBoxToolStripMenuItem.Text = "Suggestion Box"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'SectionToolStripMenuItem
        '
        Me.SectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogisticsToolStripMenuItem})
        Me.SectionToolStripMenuItem.Name = "SectionToolStripMenuItem"
        Me.SectionToolStripMenuItem.Size = New System.Drawing.Size(70, 28)
        Me.SectionToolStripMenuItem.Text = "Section"
        '
        'LogisticsToolStripMenuItem
        '
        Me.LogisticsToolStripMenuItem.Name = "LogisticsToolStripMenuItem"
        Me.LogisticsToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LogisticsToolStripMenuItem.Text = "Logistics"
        '
        'Logistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 733)
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
    Friend WithEvents btn_user As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemUpdaterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuggestionBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogisticsToolStripMenuItem As ToolStripMenuItem
End Class
