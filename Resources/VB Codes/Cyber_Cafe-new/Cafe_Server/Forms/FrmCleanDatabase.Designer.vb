<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCleanDatabase
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
        Me.chckTime = New System.Windows.Forms.CheckBox()
        Me.chckPrice = New System.Windows.Forms.CheckBox()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chckTime
        '
        Me.chckTime.AutoSize = True
        Me.chckTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckTime.Location = New System.Drawing.Point(22, 19)
        Me.chckTime.Name = "chckTime"
        Me.chckTime.Size = New System.Drawing.Size(152, 20)
        Me.chckTime.TabIndex = 0
        Me.chckTime.Text = "Clean Time Records"
        Me.chckTime.UseVisualStyleBackColor = True
        '
        'chckPrice
        '
        Me.chckPrice.AutoSize = True
        Me.chckPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckPrice.Location = New System.Drawing.Point(22, 42)
        Me.chckPrice.Name = "chckPrice"
        Me.chckPrice.Size = New System.Drawing.Size(155, 20)
        Me.chckPrice.TabIndex = 2
        Me.chckPrice.Text = "Clean Price Records"
        Me.chckPrice.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClean.Location = New System.Drawing.Point(21, 70)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 28)
        Me.btnClean.TabIndex = 3
        Me.btnClean.Text = "&Clean"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(102, 70)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmCleanDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 120)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.chckPrice)
        Me.Controls.Add(Me.chckTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCleanDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clean Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chckTime As System.Windows.Forms.CheckBox
    Friend WithEvents chckPrice As System.Windows.Forms.CheckBox
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
