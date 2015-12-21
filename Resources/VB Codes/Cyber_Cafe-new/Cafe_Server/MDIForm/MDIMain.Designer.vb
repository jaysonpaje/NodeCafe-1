<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Me.StatStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditRates = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnMult_Ext = New System.Windows.Forms.Button()
        Me.btnMult_Open = New System.Windows.Forms.Button()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpUtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatStrip
        '
        Me.StatStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatStrip.Location = New System.Drawing.Point(0, 637)
        Me.StatStrip.Name = "StatStrip"
        Me.StatStrip.Size = New System.Drawing.Size(471, 22)
        Me.StatStrip.TabIndex = 7
        Me.StatStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(545, 611)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "send"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnEditRates
        '
        Me.btnEditRates.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRates.Location = New System.Drawing.Point(155, 24)
        Me.btnEditRates.Name = "btnEditRates"
        Me.btnEditRates.Size = New System.Drawing.Size(65, 47)
        Me.btnEditRates.TabIndex = 15
        Me.btnEditRates.Text = "Edit Rates"
        Me.btnEditRates.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "clock_48.png")
        '
        'btnMult_Ext
        '
        Me.btnMult_Ext.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult_Ext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMult_Ext.ImageIndex = 0
        Me.btnMult_Ext.ImageList = Me.ImageList1
        Me.btnMult_Ext.Location = New System.Drawing.Point(488, 239)
        Me.btnMult_Ext.Name = "btnMult_Ext"
        Me.btnMult_Ext.Size = New System.Drawing.Size(132, 47)
        Me.btnMult_Ext.TabIndex = 18
        Me.btnMult_Ext.Text = "Multiple Extend"
        Me.btnMult_Ext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMult_Ext.UseVisualStyleBackColor = True
        Me.btnMult_Ext.Visible = False
        '
        'btnMult_Open
        '
        Me.btnMult_Open.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMult_Open.ImageIndex = 0
        Me.btnMult_Open.ImageList = Me.ImageList1
        Me.btnMult_Open.Location = New System.Drawing.Point(17, 24)
        Me.btnMult_Open.Name = "btnMult_Open"
        Me.btnMult_Open.Size = New System.Drawing.Size(132, 47)
        Me.btnMult_Open.TabIndex = 17
        Me.btnMult_Open.Text = "Multiple Open / Set Time"
        Me.btnMult_Open.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMult_Open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMult_Open.UseVisualStyleBackColor = True
        '
        'ToolStrip
        '
        Me.ToolStrip.BackgroundImage = Global.Cafe_Server.My.Resources.Resources.bgctr
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(471, 53)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 50)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackgroundImage = Global.Cafe_Server.My.Resources.Resources.bgupp
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.ReportsToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(471, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientListToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClientListToolStripMenuItem
        '
        Me.ClientListToolStripMenuItem.Name = "ClientListToolStripMenuItem"
        Me.ClientListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientListToolStripMenuItem.Text = "Client List"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientListToolStripMenuItem1, Me.BackUpUtilityToolStripMenuItem, Me.CleanDatabaseToolStripMenuItem, Me.MasterPasswordToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'ClientListToolStripMenuItem1
        '
        Me.ClientListToolStripMenuItem1.Name = "ClientListToolStripMenuItem1"
        Me.ClientListToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ClientListToolStripMenuItem1.Text = "Client List"
        '
        'BackUpUtilityToolStripMenuItem
        '
        Me.BackUpUtilityToolStripMenuItem.Name = "BackUpUtilityToolStripMenuItem"
        Me.BackUpUtilityToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BackUpUtilityToolStripMenuItem.Text = "Back-Up Utility"
        '
        'CleanDatabaseToolStripMenuItem
        '
        Me.CleanDatabaseToolStripMenuItem.Name = "CleanDatabaseToolStripMenuItem"
        Me.CleanDatabaseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CleanDatabaseToolStripMenuItem.Text = "Clean Database"
        '
        'MasterPasswordToolStripMenuItem
        '
        Me.MasterPasswordToolStripMenuItem.Name = "MasterPasswordToolStripMenuItem"
        Me.MasterPasswordToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MasterPasswordToolStripMenuItem.Text = "Master Password"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'PrintReportsToolStripMenuItem
        '
        Me.PrintReportsToolStripMenuItem.Name = "PrintReportsToolStripMenuItem"
        Me.PrintReportsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PrintReportsToolStripMenuItem.Text = "Print Reports"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 659)
        Me.Controls.Add(Me.btnMult_Ext)
        Me.Controls.Add(Me.btnMult_Open)
        Me.Controls.Add(Me.btnEditRates)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatStrip.ResumeLayout(False)
        Me.StatStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEditRates As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMult_Open As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnMult_Ext As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpUtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CleanDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
