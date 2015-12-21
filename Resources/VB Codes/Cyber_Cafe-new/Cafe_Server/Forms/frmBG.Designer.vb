<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBG))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_CMenuS_rightclick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimitedTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtendTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopAndSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.clientPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_OMenuS_rightclick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UncheckAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_CMenuS_rightclick.SuspendLayout()
        Me.btn_OMenuS_rightclick.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "OFF.PNG")
        Me.ImageList1.Images.SetKeyName(1, "STANDBY.PNG")
        Me.ImageList1.Images.SetKeyName(2, "ON.png")
        Me.ImageList1.Images.SetKeyName(3, "PAUSE.png")
        Me.ImageList1.Images.SetKeyName(4, "DC.png")
        Me.ImageList1.Images.SetKeyName(5, "GB.png")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 761)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btn_CMenuS_rightclick
        '
        Me.btn_CMenuS_rightclick.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CMenuS_rightclick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetTimeToolStripMenuItem, Me.PauseTimeToolStripMenuItem, Me.ResumeTimeToolStripMenuItem, Me.EndTimeToolStripMenuItem, Me.ToolStripSeparator2, Me.RestartToolStripMenuItem, Me.ShutdownClientToolStripMenuItem, Me.ToolStripSeparator1, Me.SSToolStripMenuItem, Me.ToolStripSeparator3})
        Me.btn_CMenuS_rightclick.Name = "btn_CMenuS_rightclick"
        Me.btn_CMenuS_rightclick.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.btn_CMenuS_rightclick.Size = New System.Drawing.Size(166, 198)
        '
        'SetTimeToolStripMenuItem
        '
        Me.SetTimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimitedTimeToolStripMenuItem, Me.ExtendTimeToolStripMenuItem})
        Me.SetTimeToolStripMenuItem.Name = "SetTimeToolStripMenuItem"
        Me.SetTimeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SetTimeToolStripMenuItem.Text = "&SetTime"
        '
        'LimitedTimeToolStripMenuItem
        '
        Me.LimitedTimeToolStripMenuItem.Name = "LimitedTimeToolStripMenuItem"
        Me.LimitedTimeToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.LimitedTimeToolStripMenuItem.Text = "Limited Time"
        '
        'ExtendTimeToolStripMenuItem
        '
        Me.ExtendTimeToolStripMenuItem.Name = "ExtendTimeToolStripMenuItem"
        Me.ExtendTimeToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ExtendTimeToolStripMenuItem.Text = "Extend Time"
        '
        'PauseTimeToolStripMenuItem
        '
        Me.PauseTimeToolStripMenuItem.Name = "PauseTimeToolStripMenuItem"
        Me.PauseTimeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PauseTimeToolStripMenuItem.Text = "Pause Time"
        '
        'ResumeTimeToolStripMenuItem
        '
        Me.ResumeTimeToolStripMenuItem.Name = "ResumeTimeToolStripMenuItem"
        Me.ResumeTimeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ResumeTimeToolStripMenuItem.Text = "R&esume Time"
        '
        'EndTimeToolStripMenuItem
        '
        Me.EndTimeToolStripMenuItem.Name = "EndTimeToolStripMenuItem"
        Me.EndTimeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EndTimeToolStripMenuItem.Text = "End Time"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(162, 6)
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RestartToolStripMenuItem.Text = "&Restart Client"
        '
        'ShutdownClientToolStripMenuItem
        '
        Me.ShutdownClientToolStripMenuItem.Name = "ShutdownClientToolStripMenuItem"
        Me.ShutdownClientToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ShutdownClientToolStripMenuItem.Text = "Shutdown Client"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'SSToolStripMenuItem
        '
        Me.SSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopAndSaveToolStripMenuItem, Me.LoadSaveToolStripMenuItem})
        Me.SSToolStripMenuItem.Name = "SSToolStripMenuItem"
        Me.SSToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SSToolStripMenuItem.Text = "Stop / Load"
        '
        'StopAndSaveToolStripMenuItem
        '
        Me.StopAndSaveToolStripMenuItem.Name = "StopAndSaveToolStripMenuItem"
        Me.StopAndSaveToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.StopAndSaveToolStripMenuItem.Text = "Stop and Save"
        '
        'LoadSaveToolStripMenuItem
        '
        Me.LoadSaveToolStripMenuItem.Name = "LoadSaveToolStripMenuItem"
        Me.LoadSaveToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.LoadSaveToolStripMenuItem.Text = "Load Save"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(162, 6)
        '
        'clientPanel
        '
        Me.clientPanel.AutoScroll = True
        Me.clientPanel.AutoScrollMargin = New System.Drawing.Size(50, 50)
        Me.clientPanel.AutoScrollMinSize = New System.Drawing.Size(3, 3)
        Me.clientPanel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clientPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.clientPanel.Location = New System.Drawing.Point(0, 0)
        Me.clientPanel.Margin = New System.Windows.Forms.Padding(10)
        Me.clientPanel.Name = "clientPanel"
        Me.clientPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.clientPanel.Size = New System.Drawing.Size(1258, 234)
        Me.clientPanel.TabIndex = 4
        '
        'btn_OMenuS_rightclick
        '
        Me.btn_OMenuS_rightclick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UncheckAllToolStripMenuItem, Me.RestartAllToolStripMenuItem, Me.ShutdownAllToolStripMenuItem})
        Me.btn_OMenuS_rightclick.Name = "btn_OMenuS_rightclick"
        Me.btn_OMenuS_rightclick.Size = New System.Drawing.Size(146, 70)
        '
        'UncheckAllToolStripMenuItem
        '
        Me.UncheckAllToolStripMenuItem.Name = "UncheckAllToolStripMenuItem"
        Me.UncheckAllToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.UncheckAllToolStripMenuItem.Text = "Uncheck All"
        '
        'RestartAllToolStripMenuItem
        '
        Me.RestartAllToolStripMenuItem.Name = "RestartAllToolStripMenuItem"
        Me.RestartAllToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RestartAllToolStripMenuItem.Text = "Restart All"
        '
        'ShutdownAllToolStripMenuItem
        '
        Me.ShutdownAllToolStripMenuItem.Name = "ShutdownAllToolStripMenuItem"
        Me.ShutdownAllToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ShutdownAllToolStripMenuItem.Text = "Shutdown All"
        '
        'frmBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clientPanel)
        Me.Name = "frmBG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.btn_CMenuS_rightclick.ResumeLayout(False)
        Me.btn_OMenuS_rightclick.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_CMenuS_rightclick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SetTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimitedTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtendTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutdownClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clientPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btn_OMenuS_rightclick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UncheckAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutdownAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopAndSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
