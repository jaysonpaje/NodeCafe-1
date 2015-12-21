<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaveTimeClients
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtlimit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtend = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtclient_c = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtclient_a = New System.Windows.Forms.TextBox()
        Me.txtclient_n = New System.Windows.Forms.TextBox()
        Me.txtstart = New System.Windows.Forms.TextBox()
        Me.txtpcname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PC Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtlimit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtend)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtclient_c)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtclient_a)
        Me.GroupBox1.Controls.Add(Me.txtclient_n)
        Me.GroupBox1.Controls.Add(Me.txtstart)
        Me.GroupBox1.Controls.Add(Me.txtpcname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 209)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtlimit
        '
        Me.txtlimit.BackColor = System.Drawing.Color.White
        Me.txtlimit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlimit.ForeColor = System.Drawing.Color.Black
        Me.txtlimit.Location = New System.Drawing.Point(284, 13)
        Me.txtlimit.Name = "txtlimit"
        Me.txtlimit.ReadOnly = True
        Me.txtlimit.Size = New System.Drawing.Size(75, 22)
        Me.txtlimit.TabIndex = 401
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(201, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Time Limit :"
        '
        'txtend
        '
        Me.txtend.BackColor = System.Drawing.Color.White
        Me.txtend.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtend.ForeColor = System.Drawing.Color.Black
        Me.txtend.Location = New System.Drawing.Point(285, 37)
        Me.txtend.Name = "txtend"
        Me.txtend.ReadOnly = True
        Me.txtend.Size = New System.Drawing.Size(75, 22)
        Me.txtend.TabIndex = 403
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(207, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Time End :"
        '
        'txtclient_c
        '
        Me.txtclient_c.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclient_c.Location = New System.Drawing.Point(110, 159)
        Me.txtclient_c.Name = "txtclient_c"
        Me.txtclient_c.Size = New System.Drawing.Size(212, 22)
        Me.txtclient_c.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contact # :"
        '
        'txtclient_a
        '
        Me.txtclient_a.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclient_a.Location = New System.Drawing.Point(110, 86)
        Me.txtclient_a.Multiline = True
        Me.txtclient_a.Name = "txtclient_a"
        Me.txtclient_a.Size = New System.Drawing.Size(279, 70)
        Me.txtclient_a.TabIndex = 2
        '
        'txtclient_n
        '
        Me.txtclient_n.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclient_n.Location = New System.Drawing.Point(110, 62)
        Me.txtclient_n.Name = "txtclient_n"
        Me.txtclient_n.Size = New System.Drawing.Size(279, 22)
        Me.txtclient_n.TabIndex = 1
        '
        'txtstart
        '
        Me.txtstart.BackColor = System.Drawing.Color.White
        Me.txtstart.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstart.ForeColor = System.Drawing.Color.Black
        Me.txtstart.Location = New System.Drawing.Point(110, 38)
        Me.txtstart.Name = "txtstart"
        Me.txtstart.ReadOnly = True
        Me.txtstart.Size = New System.Drawing.Size(75, 22)
        Me.txtstart.TabIndex = 402
        '
        'txtpcname
        '
        Me.txtpcname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpcname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpcname.Location = New System.Drawing.Point(110, 14)
        Me.txtpcname.Name = "txtpcname"
        Me.txtpcname.ReadOnly = True
        Me.txtpcname.Size = New System.Drawing.Size(75, 22)
        Me.txtpcname.TabIndex = 400
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Client Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Client Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time Start :"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 220)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 29)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(93, 220)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmSaveTimeClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSaveTimeClients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save Clients Time"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtclient_c As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtclient_a As System.Windows.Forms.TextBox
    Friend WithEvents txtclient_n As System.Windows.Forms.TextBox
    Friend WithEvents txtstart As System.Windows.Forms.TextBox
    Friend WithEvents txtpcname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlimit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtend As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
