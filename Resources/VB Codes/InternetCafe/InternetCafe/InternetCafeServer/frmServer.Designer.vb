<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServer
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServer))
        Me.lvwClients = New System.Windows.Forms.ListView
        Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
        Me.btnShutdown = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtMinuteUsed = New System.Windows.Forms.TextBox
        Me.txtCurrentTime = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtStartTime = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnOpenSession = New System.Windows.Forms.Button
        Me.btnCloseSession = New System.Windows.Forms.Button
        Me.btnRestart = New System.Windows.Forms.Button
        Me.TimerCounter = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwClients
        '
        Me.lvwClients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwClients.LargeImageList = Me.lstImg
        Me.lvwClients.Location = New System.Drawing.Point(0, 7)
        Me.lvwClients.Name = "lvwClients"
        Me.lvwClients.Size = New System.Drawing.Size(474, 408)
        Me.lvwClients.TabIndex = 0
        Me.lvwClients.UseCompatibleStateImageBehavior = False
        '
        'lstImg
        '
        Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
        Me.lstImg.Images.SetKeyName(0, "1355933096_preferences-desktop-display.png")
        Me.lstImg.Images.SetKeyName(1, "1355933096_preferences-desktop-display2.png")
        '
        'btnShutdown
        '
        Me.btnShutdown.Location = New System.Drawing.Point(16, 206)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(184, 38)
        Me.btnShutdown.TabIndex = 1
        Me.btnShutdown.Text = "Shutdown"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtMinuteUsed)
        Me.Panel1.Controls.Add(Me.txtCurrentTime)
        Me.Panel1.Controls.Add(Me.txtState)
        Me.Panel1.Controls.Add(Me.txtStartTime)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(481, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 113)
        Me.Panel1.TabIndex = 2
        '
        'txtMinuteUsed
        '
        Me.txtMinuteUsed.Location = New System.Drawing.Point(121, 81)
        Me.txtMinuteUsed.Name = "txtMinuteUsed"
        Me.txtMinuteUsed.ReadOnly = True
        Me.txtMinuteUsed.Size = New System.Drawing.Size(91, 22)
        Me.txtMinuteUsed.TabIndex = 1
        Me.txtMinuteUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentTime
        '
        Me.txtCurrentTime.Location = New System.Drawing.Point(121, 55)
        Me.txtCurrentTime.Name = "txtCurrentTime"
        Me.txtCurrentTime.ReadOnly = True
        Me.txtCurrentTime.Size = New System.Drawing.Size(91, 22)
        Me.txtCurrentTime.TabIndex = 1
        Me.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(121, 3)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(91, 22)
        Me.txtState.TabIndex = 1
        Me.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartTime
        '
        Me.txtStartTime.Location = New System.Drawing.Point(121, 29)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.ReadOnly = True
        Me.txtStartTime.Size = New System.Drawing.Size(91, 22)
        Me.txtStartTime.TabIndex = 1
        Me.txtStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Minutes Used:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "State:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Time:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btnOpenSession)
        Me.Panel2.Controls.Add(Me.btnCloseSession)
        Me.Panel2.Controls.Add(Me.btnRestart)
        Me.Panel2.Controls.Add(Me.btnShutdown)
        Me.Panel2.Location = New System.Drawing.Point(480, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 292)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 109)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(18, 76)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(160, 20)
        Me.txtTotalPrice.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total Price (Riel)"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(16, 36)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(162, 20)
        Me.txtUnitPrice.TabIndex = 2
        Me.txtUnitPrice.Text = "1500"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Price Per Hour (Riel)"
        '
        'btnOpenSession
        '
        Me.btnOpenSession.Location = New System.Drawing.Point(16, 3)
        Me.btnOpenSession.Name = "btnOpenSession"
        Me.btnOpenSession.Size = New System.Drawing.Size(184, 38)
        Me.btnOpenSession.TabIndex = 1
        Me.btnOpenSession.Text = "Open Session"
        Me.btnOpenSession.UseVisualStyleBackColor = True
        '
        'btnCloseSession
        '
        Me.btnCloseSession.Location = New System.Drawing.Point(16, 47)
        Me.btnCloseSession.Name = "btnCloseSession"
        Me.btnCloseSession.Size = New System.Drawing.Size(184, 38)
        Me.btnCloseSession.TabIndex = 1
        Me.btnCloseSession.Text = "Close Session and Charge"
        Me.btnCloseSession.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(16, 250)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(184, 38)
        Me.btnRestart.TabIndex = 1
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'TimerCounter
        '
        Me.TimerCounter.Enabled = True
        Me.TimerCounter.Interval = 1000
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 423)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvwClients)
        Me.Name = "frmServer"
        Me.Text = "Internet Cafe Server"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwClients As System.Windows.Forms.ListView
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMinuteUsed As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentTime As System.Windows.Forms.TextBox
    Friend WithEvents txtStartTime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnOpenSession As System.Windows.Forms.Button
    Friend WithEvents btnCloseSession As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstImg As System.Windows.Forms.ImageList
    Friend WithEvents TimerCounter As System.Windows.Forms.Timer

End Class
