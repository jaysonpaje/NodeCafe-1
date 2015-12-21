<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster_Password
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.txtrenewpass = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.grpOldPrev = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtreoldpass = New System.Windows.Forms.TextBox()
        Me.txtoldpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpOldPrev.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Re - Type Password :"
        '
        'txtnewpass
        '
        Me.txtnewpass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpass.Location = New System.Drawing.Point(156, 21)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(187, 22)
        Me.txtnewpass.TabIndex = 2
        '
        'txtrenewpass
        '
        Me.txtrenewpass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrenewpass.Location = New System.Drawing.Point(157, 46)
        Me.txtrenewpass.Name = "txtrenewpass"
        Me.txtrenewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrenewpass.Size = New System.Drawing.Size(186, 22)
        Me.txtrenewpass.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(222, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(303, 198)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 28)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "&Cancel"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'grpOldPrev
        '
        Me.grpOldPrev.Controls.Add(Me.GroupBox2)
        Me.grpOldPrev.Controls.Add(Me.GroupBox1)
        Me.grpOldPrev.Location = New System.Drawing.Point(9, 2)
        Me.grpOldPrev.Name = "grpOldPrev"
        Me.grpOldPrev.Size = New System.Drawing.Size(369, 190)
        Me.grpOldPrev.TabIndex = 6
        Me.grpOldPrev.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtrenewpass)
        Me.GroupBox2.Controls.Add(Me.txtnewpass)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 83)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtreoldpass)
        Me.GroupBox1.Controls.Add(Me.txtoldpass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Old Password"
        '
        'txtreoldpass
        '
        Me.txtreoldpass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreoldpass.Location = New System.Drawing.Point(157, 47)
        Me.txtreoldpass.Name = "txtreoldpass"
        Me.txtreoldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtreoldpass.Size = New System.Drawing.Size(186, 22)
        Me.txtreoldpass.TabIndex = 5
        '
        'txtoldpass
        '
        Me.txtoldpass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpass.Location = New System.Drawing.Point(156, 21)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpass.Size = New System.Drawing.Size(187, 22)
        Me.txtoldpass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Re-type Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(47, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Old Password :"
        '
        'FrmMaster_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.grpOldPrev)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "FrmMaster_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Password"
        Me.grpOldPrev.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents txtrenewpass As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents grpOldPrev As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtreoldpass As System.Windows.Forms.TextBox
    Friend WithEvents txtoldpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
