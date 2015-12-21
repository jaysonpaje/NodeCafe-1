<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportDate
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(180, 74)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 28)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date To :"
        '
        'dtfrom
        '
        Me.dtfrom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Location = New System.Drawing.Point(129, 17)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(210, 22)
        Me.dtfrom.TabIndex = 3
        '
        'dtto
        '
        Me.dtto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Location = New System.Drawing.Point(129, 46)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(210, 22)
        Me.dtto.TabIndex = 4
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(264, 74)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 28)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'FrmReportDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 116)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmReportDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
