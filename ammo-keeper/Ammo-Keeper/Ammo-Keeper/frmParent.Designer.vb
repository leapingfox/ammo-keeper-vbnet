<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParent
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParent))
        Me.mnuParent = New System.Windows.Forms.MenuStrip()
        Me.FjfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveWindowLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreWindowLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadingActiveReloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadingLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadingRecipesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MangerAmmoInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerComponentInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LabelGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ApplicationBackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationBugReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ApplicationGithubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReloadingCostCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblopensourceinfo = New System.Windows.Forms.Label()
        Me.linklabelmit = New System.Windows.Forms.LinkLabel()
        Me.lblwebsite = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuParent.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuParent
        '
        Me.mnuParent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FjfToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuParent.Location = New System.Drawing.Point(0, 0)
        Me.mnuParent.Name = "mnuParent"
        Me.mnuParent.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuParent.Size = New System.Drawing.Size(1445, 24)
        Me.mnuParent.TabIndex = 0
        Me.mnuParent.Text = "mnuParent"
        '
        'FjfToolStripMenuItem
        '
        Me.FjfToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveWindowLayoutToolStripMenuItem, Me.RestoreWindowLayoutToolStripMenuItem, Me.ToolStripSeparator2, Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FjfToolStripMenuItem.Name = "FjfToolStripMenuItem"
        Me.FjfToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FjfToolStripMenuItem.Text = "File"
        '
        'SaveWindowLayoutToolStripMenuItem
        '
        Me.SaveWindowLayoutToolStripMenuItem.Name = "SaveWindowLayoutToolStripMenuItem"
        Me.SaveWindowLayoutToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SaveWindowLayoutToolStripMenuItem.Text = "Save Window Layout"
        Me.SaveWindowLayoutToolStripMenuItem.ToolTipText = "saves current window layout"
        '
        'RestoreWindowLayoutToolStripMenuItem
        '
        Me.RestoreWindowLayoutToolStripMenuItem.Name = "RestoreWindowLayoutToolStripMenuItem"
        Me.RestoreWindowLayoutToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.RestoreWindowLayoutToolStripMenuItem.Text = "Restore Window Layout"
        Me.RestoreWindowLayoutToolStripMenuItem.ToolTipText = "restores saved window layout"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(214, 6)
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ImportToolStripMenuItem.Text = "Import - Ammo Keeper .db"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ExportToolStripMenuItem.Text = "Export - Ammo Keeper .db"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadingActiveReloaderToolStripMenuItem, Me.ReloadingCostCalculatorToolStripMenuItem, Me.ReloadingLogToolStripMenuItem, Me.ReloadingRecipesToolStripMenuItem, Me.ToolStripSeparator3, Me.MangerAmmoInventoryToolStripMenuItem, Me.ManagerComponentInventoryToolStripMenuItem, Me.ToolStripSeparator4, Me.LabelGeneratorToolStripMenuItem, Me.ToolStripSeparator5, Me.ApplicationBackupDatabaseToolStripMenuItem, Me.ApplicationLogToolStripMenuItem, Me.ApplicationSettingsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ReloadingActiveReloaderToolStripMenuItem
        '
        Me.ReloadingActiveReloaderToolStripMenuItem.Image = CType(resources.GetObject("ReloadingActiveReloaderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReloadingActiveReloaderToolStripMenuItem.Name = "ReloadingActiveReloaderToolStripMenuItem"
        Me.ReloadingActiveReloaderToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ReloadingActiveReloaderToolStripMenuItem.Text = "Reloading - Active Reloader"
        '
        'ReloadingLogToolStripMenuItem
        '
        Me.ReloadingLogToolStripMenuItem.Name = "ReloadingLogToolStripMenuItem"
        Me.ReloadingLogToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ReloadingLogToolStripMenuItem.Text = "Reloading - Log Notes"
        '
        'ReloadingRecipesToolStripMenuItem
        '
        Me.ReloadingRecipesToolStripMenuItem.Name = "ReloadingRecipesToolStripMenuItem"
        Me.ReloadingRecipesToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ReloadingRecipesToolStripMenuItem.Text = "Reloading - Recipes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(246, 6)
        '
        'MangerAmmoInventoryToolStripMenuItem
        '
        Me.MangerAmmoInventoryToolStripMenuItem.Name = "MangerAmmoInventoryToolStripMenuItem"
        Me.MangerAmmoInventoryToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.MangerAmmoInventoryToolStripMenuItem.Text = "Manger - Ammo Inventory"
        '
        'ManagerComponentInventoryToolStripMenuItem
        '
        Me.ManagerComponentInventoryToolStripMenuItem.Name = "ManagerComponentInventoryToolStripMenuItem"
        Me.ManagerComponentInventoryToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ManagerComponentInventoryToolStripMenuItem.Text = "Manager - Component Inventory"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(246, 6)
        '
        'LabelGeneratorToolStripMenuItem
        '
        Me.LabelGeneratorToolStripMenuItem.Name = "LabelGeneratorToolStripMenuItem"
        Me.LabelGeneratorToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.LabelGeneratorToolStripMenuItem.Text = "Generator - Label && QR Creator"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(246, 6)
        '
        'ApplicationBackupDatabaseToolStripMenuItem
        '
        Me.ApplicationBackupDatabaseToolStripMenuItem.Name = "ApplicationBackupDatabaseToolStripMenuItem"
        Me.ApplicationBackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ApplicationBackupDatabaseToolStripMenuItem.Text = "Application - Backup Database"
        '
        'ApplicationLogToolStripMenuItem
        '
        Me.ApplicationLogToolStripMenuItem.Name = "ApplicationLogToolStripMenuItem"
        Me.ApplicationLogToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ApplicationLogToolStripMenuItem.Text = "Application - Log"
        '
        'ApplicationSettingsToolStripMenuItem
        '
        Me.ApplicationSettingsToolStripMenuItem.Name = "ApplicationSettingsToolStripMenuItem"
        Me.ApplicationSettingsToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ApplicationSettingsToolStripMenuItem.Text = "Application - Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationBugReportingToolStripMenuItem, Me.ApplicationHelpToolStripMenuItem, Me.ToolStripSeparator6, Me.ApplicationGithubToolStripMenuItem, Me.ToolStripSeparator7, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ApplicationBugReportingToolStripMenuItem
        '
        Me.ApplicationBugReportingToolStripMenuItem.Name = "ApplicationBugReportingToolStripMenuItem"
        Me.ApplicationBugReportingToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ApplicationBugReportingToolStripMenuItem.Text = "Application - Bug Reporting"
        '
        'ApplicationHelpToolStripMenuItem
        '
        Me.ApplicationHelpToolStripMenuItem.Name = "ApplicationHelpToolStripMenuItem"
        Me.ApplicationHelpToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ApplicationHelpToolStripMenuItem.Text = "Application - Help"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(219, 6)
        '
        'ApplicationGithubToolStripMenuItem
        '
        Me.ApplicationGithubToolStripMenuItem.Name = "ApplicationGithubToolStripMenuItem"
        Me.ApplicationGithubToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ApplicationGithubToolStripMenuItem.Text = "Github - Source Files"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(219, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ReloadingCostCalculatorToolStripMenuItem
        '
        Me.ReloadingCostCalculatorToolStripMenuItem.Image = CType(resources.GetObject("ReloadingCostCalculatorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReloadingCostCalculatorToolStripMenuItem.Name = "ReloadingCostCalculatorToolStripMenuItem"
        Me.ReloadingCostCalculatorToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ReloadingCostCalculatorToolStripMenuItem.Text = "Reloading - Cost Calculator"
        '
        'lblopensourceinfo
        '
        Me.lblopensourceinfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblopensourceinfo.AutoSize = True
        Me.lblopensourceinfo.BackColor = System.Drawing.Color.Transparent
        Me.lblopensourceinfo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblopensourceinfo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblopensourceinfo.Location = New System.Drawing.Point(1105, 823)
        Me.lblopensourceinfo.Name = "lblopensourceinfo"
        Me.lblopensourceinfo.Size = New System.Drawing.Size(149, 13)
        Me.lblopensourceinfo.TabIndex = 2
        Me.lblopensourceinfo.Text = "SPDX-License-Identifier: MIT"
        '
        'linklabelmit
        '
        Me.linklabelmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linklabelmit.AutoSize = True
        Me.linklabelmit.BackColor = System.Drawing.Color.Transparent
        Me.linklabelmit.Location = New System.Drawing.Point(1251, 823)
        Me.linklabelmit.Name = "linklabelmit"
        Me.linklabelmit.Size = New System.Drawing.Size(194, 13)
        Me.linklabelmit.TabIndex = 3
        Me.linklabelmit.TabStop = True
        Me.linklabelmit.Text = "https://opensource.org/licenses/MIT"
        '
        'lblwebsite
        '
        Me.lblwebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblwebsite.AutoSize = True
        Me.lblwebsite.BackColor = System.Drawing.Color.Transparent
        Me.lblwebsite.Location = New System.Drawing.Point(1205, 810)
        Me.lblwebsite.Name = "lblwebsite"
        Me.lblwebsite.Size = New System.Drawing.Size(49, 13)
        Me.lblwebsite.TabIndex = 4
        Me.lblwebsite.Text = "Website"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(1251, 810)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://leapingfox.project"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 841)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1445, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'frmParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1445, 863)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblwebsite)
        Me.Controls.Add(Me.linklabelmit)
        Me.Controls.Add(Me.lblopensourceinfo)
        Me.Controls.Add(Me.mnuParent)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuParent
        Me.Name = "frmParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ammo Keeper"
        Me.mnuParent.ResumeLayout(False)
        Me.mnuParent.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuParent As MenuStrip
    Friend WithEvents FjfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadingActiveReloaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadingLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadingRecipesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MangerAmmoInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagerComponentInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents LabelGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ApplicationLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationBackupDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationBugReportingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationGithubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents SaveWindowLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreWindowLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ReloadingCostCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblopensourceinfo As Label
    Friend WithEvents linklabelmit As LinkLabel
    Friend WithEvents lblwebsite As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
