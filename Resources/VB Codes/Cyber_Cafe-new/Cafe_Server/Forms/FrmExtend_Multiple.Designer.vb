<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExtend_Multiple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExtend_Multiple))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chckpaid = New System.Windows.Forms.CheckBox()
        Me.rbChange = New System.Windows.Forms.RadioButton()
        Me.rbExtend = New System.Windows.Forms.RadioButton()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txthr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtelapse = New System.Windows.Forms.TextBox()
        Me.txtmin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblpc = New System.Windows.Forms.Label()
        Me.Labelpc = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtin_id = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chckpaid)
        Me.GroupBox2.Controls.Add(Me.rbChange)
        Me.GroupBox2.Controls.Add(Me.rbExtend)
        Me.GroupBox2.Controls.Add(Me.txtamount)
        Me.GroupBox2.Controls.Add(Me.txthr)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtelapse)
        Me.GroupBox2.Controls.Add(Me.txtmin)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 195)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'chckpaid
        '
        Me.chckpaid.AutoSize = True
        Me.chckpaid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckpaid.ForeColor = System.Drawing.Color.White
        Me.chckpaid.Location = New System.Drawing.Point(20, 153)
        Me.chckpaid.Name = "chckpaid"
        Me.chckpaid.Size = New System.Drawing.Size(94, 19)
        Me.chckpaid.TabIndex = 17
        Me.chckpaid.Text = "Check if paid"
        Me.chckpaid.UseVisualStyleBackColor = True
        '
        'rbChange
        '
        Me.rbChange.AutoSize = True
        Me.rbChange.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbChange.ForeColor = System.Drawing.Color.White
        Me.rbChange.Location = New System.Drawing.Point(160, 16)
        Me.rbChange.Name = "rbChange"
        Me.rbChange.Size = New System.Drawing.Size(107, 20)
        Me.rbChange.TabIndex = 16
        Me.rbChange.TabStop = True
        Me.rbChange.Text = "Change Time"
        Me.rbChange.UseVisualStyleBackColor = True
        '
        'rbExtend
        '
        Me.rbExtend.AutoSize = True
        Me.rbExtend.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExtend.ForeColor = System.Drawing.Color.White
        Me.rbExtend.Location = New System.Drawing.Point(25, 16)
        Me.rbExtend.Name = "rbExtend"
        Me.rbExtend.Size = New System.Drawing.Size(103, 20)
        Me.rbExtend.TabIndex = 15
        Me.rbExtend.TabStop = True
        Me.rbExtend.Text = "Extend Time"
        Me.rbExtend.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.White
        Me.txtamount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(120, 149)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(81, 26)
        Me.txtamount.TabIndex = 14
        Me.txtamount.Text = "0"
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txthr
        '
        Me.txthr.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthr.Location = New System.Drawing.Point(120, 83)
        Me.txthr.MaxLength = 2
        Me.txthr.Name = "txthr"
        Me.txthr.Size = New System.Drawing.Size(94, 31)
        Me.txthr.TabIndex = 2
        Me.txthr.Text = "0"
        Me.txthr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Elapse Time :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours :"
        '
        'txtelapse
        '
        Me.txtelapse.BackColor = System.Drawing.Color.White
        Me.txtelapse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtelapse.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelapse.ForeColor = System.Drawing.Color.Red
        Me.txtelapse.Location = New System.Drawing.Point(120, 47)
        Me.txtelapse.Multiline = True
        Me.txtelapse.Name = "txtelapse"
        Me.txtelapse.ReadOnly = True
        Me.txtelapse.Size = New System.Drawing.Size(122, 35)
        Me.txtelapse.TabIndex = 12
        Me.txtelapse.Text = "00:00:00"
        Me.txtelapse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmin
        '
        Me.txtmin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmin.Location = New System.Drawing.Point(120, 116)
        Me.txtmin.MaxLength = 2
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(94, 31)
        Me.txtmin.TabIndex = 3
        Me.txtmin.Text = "0"
        Me.txtmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minutes :"
        '
        'btnclose
        '
        Me.btnclose.ImageIndex = 0
        Me.btnclose.ImageList = Me.ImageList1
        Me.btnclose.Location = New System.Drawing.Point(260, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(52, 51)
        Me.btnclose.TabIndex = 29
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ball_stop.ico")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(19, 264)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 33)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblpc
        '
        Me.lblpc.AutoSize = True
        Me.lblpc.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpc.ForeColor = System.Drawing.Color.White
        Me.lblpc.Location = New System.Drawing.Point(3, 14)
        Me.lblpc.Name = "lblpc"
        Me.lblpc.Size = New System.Drawing.Size(90, 23)
        Me.lblpc.TabIndex = 12
        Me.lblpc.Text = "PC Name :"
        '
        'Labelpc
        '
        Me.Labelpc.AutoSize = True
        Me.Labelpc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpc.ForeColor = System.Drawing.Color.Red
        Me.Labelpc.Location = New System.Drawing.Point(83, 16)
        Me.Labelpc.Name = "Labelpc"
        Me.Labelpc.Size = New System.Drawing.Size(0, 18)
        Me.Labelpc.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Labelpc)
        Me.GroupBox1.Controls.Add(Me.lblpc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 43)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'txtin_id
        '
        Me.txtin_id.Location = New System.Drawing.Point(154, 264)
        Me.txtin_id.Name = "txtin_id"
        Me.txtin_id.Size = New System.Drawing.Size(100, 20)
        Me.txtin_id.TabIndex = 31
        Me.txtin_id.Visible = False
        '
        'FrmExtend_Multiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cafe_Server.My.Resources.Resources.frmIN
        Me.ClientSize = New System.Drawing.Size(323, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtin_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmExtend_Multiple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Extend Time"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chckpaid As System.Windows.Forms.CheckBox
    Friend WithEvents rbChange As System.Windows.Forms.RadioButton
    Friend WithEvents rbExtend As System.Windows.Forms.RadioButton
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txthr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtelapse As System.Windows.Forms.TextBox
    Friend WithEvents txtmin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblpc As System.Windows.Forms.Label
    Friend WithEvents Labelpc As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtin_id As System.Windows.Forms.TextBox
End Class
