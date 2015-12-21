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
        Me.btn_start = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(335, 29)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start Server"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 262)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "frmServer"
        Me.Text = "Server"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_start As System.Windows.Forms.Button
End Class
