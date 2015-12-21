<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
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
        Me.btnCloseSession = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtStartTime = New System.Windows.Forms.TextBox
        Me.txtCurrentTime = New System.Windows.Forms.TextBox
        Me.txtUsedTime = New System.Windows.Forms.TextBox
        Me.timerCounter = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnCloseSession
        '
        Me.btnCloseSession.Location = New System.Drawing.Point(15, 84)
        Me.btnCloseSession.Name = "btnCloseSession"
        Me.btnCloseSession.Size = New System.Drawing.Size(150, 23)
        Me.btnCloseSession.TabIndex = 0
        Me.btnCloseSession.Text = "Close Session"
        Me.btnCloseSession.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Used Minutes:"
        '
        'txtStartTime
        '
        Me.txtStartTime.Location = New System.Drawing.Point(88, 6)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.ReadOnly = True
        Me.txtStartTime.Size = New System.Drawing.Size(77, 20)
        Me.txtStartTime.TabIndex = 4
        Me.txtStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentTime
        '
        Me.txtCurrentTime.Location = New System.Drawing.Point(88, 32)
        Me.txtCurrentTime.Name = "txtCurrentTime"
        Me.txtCurrentTime.ReadOnly = True
        Me.txtCurrentTime.Size = New System.Drawing.Size(77, 20)
        Me.txtCurrentTime.TabIndex = 5
        Me.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsedTime
        '
        Me.txtUsedTime.Location = New System.Drawing.Point(88, 58)
        Me.txtUsedTime.Name = "txtUsedTime"
        Me.txtUsedTime.ReadOnly = True
        Me.txtUsedTime.Size = New System.Drawing.Size(77, 20)
        Me.txtUsedTime.TabIndex = 6
        Me.txtUsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timerCounter
        '
        Me.timerCounter.Enabled = True
        Me.timerCounter.Interval = 1000
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(177, 117)
        Me.Controls.Add(Me.txtUsedTime)
        Me.Controls.Add(Me.txtCurrentTime)
        Me.Controls.Add(Me.txtStartTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCloseSession)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCloseSession As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStartTime As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentTime As System.Windows.Forms.TextBox
    Friend WithEvents txtUsedTime As System.Windows.Forms.TextBox
    Friend WithEvents timerCounter As System.Windows.Forms.Timer

End Class
