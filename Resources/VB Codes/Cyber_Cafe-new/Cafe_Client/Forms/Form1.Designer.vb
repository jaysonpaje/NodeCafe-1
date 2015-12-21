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
        Me.btnConnect = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(195, 88)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(18, 84)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(100, 20)
        Me.txtMessage.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(192, 143)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "frmClient"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button

End Class
