<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServer2
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
        Me.lsvClients = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.cmlsvClient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SendMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSend = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btn_destroy = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmlsvClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvClients
        '
        Me.lsvClients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvClients.FullRowSelect = True
        Me.lsvClients.GridLines = True
        Me.lsvClients.Location = New System.Drawing.Point(25, 12)
        Me.lsvClients.Name = "lsvClients"
        Me.lsvClients.Size = New System.Drawing.Size(223, 181)
        Me.lsvClients.TabIndex = 0
        Me.lsvClients.UseCompatibleStateImageBehavior = False
        Me.lsvClients.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP"
        Me.ColumnHeader1.Width = 160
        '
        'cmlsvClient
        '
        Me.cmlsvClient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendMessageToolStripMenuItem})
        Me.cmlsvClient.Name = "cmlsvClient"
        Me.cmlsvClient.Size = New System.Drawing.Size(150, 26)
        '
        'SendMessageToolStripMenuItem
        '
        Me.SendMessageToolStripMenuItem.Name = "SendMessageToolStripMenuItem"
        Me.SendMessageToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SendMessageToolStripMenuItem.Text = "Send Message"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(25, 199)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(139, 201)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(100, 20)
        Me.txtMessage.TabIndex = 2
        '
        'btn_destroy
        '
        Me.btn_destroy.Location = New System.Drawing.Point(25, 228)
        Me.btn_destroy.Name = "btn_destroy"
        Me.btn_destroy.Size = New System.Drawing.Size(75, 23)
        Me.btn_destroy.TabIndex = 4
        Me.btn_destroy.Text = "Destroy"
        Me.btn_destroy.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(25, 256)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "Send Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmServer2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 334)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btn_destroy)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lsvClients)
        Me.Name = "frmServer2"
        Me.Text = "Form2"
        Me.cmlsvClient.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvClients As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmlsvClient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SendMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btn_destroy As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
