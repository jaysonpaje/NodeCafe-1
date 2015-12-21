<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetTime_Multiple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSetTime_Multiple))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_IN = New System.Windows.Forms.Button()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.btn_OUT = New System.Windows.Forms.Button()
        Me.chbox5 = New System.Windows.Forms.CheckBox()
        Me.chbox4 = New System.Windows.Forms.CheckBox()
        Me.btn_pause = New System.Windows.Forms.Button()
        Me.btn_resume = New System.Windows.Forms.Button()
        Me.chckpaid = New System.Windows.Forms.CheckBox()
        Me.txthr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmin = New System.Windows.Forms.TextBox()
        Me.chbox2 = New System.Windows.Forms.CheckBox()
        Me.chbox3 = New System.Windows.Forms.CheckBox()
        Me.chbox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ball_stop.ico")
        '
        'btn_IN
        '
        Me.btn_IN.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IN.Image = Global.Cafe_Server.My.Resources.Resources.BTN
        Me.btn_IN.Location = New System.Drawing.Point(156, 167)
        Me.btn_IN.Name = "btn_IN"
        Me.btn_IN.Size = New System.Drawing.Size(83, 50)
        Me.btn_IN.TabIndex = 6
        Me.btn_IN.Text = "Start Time"
        Me.btn_IN.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.White
        Me.txtamount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(249, 132)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(81, 26)
        Me.txtamount.TabIndex = 5
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_OUT
        '
        Me.btn_OUT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OUT.Image = Global.Cafe_Server.My.Resources.Resources.BTN
        Me.btn_OUT.Location = New System.Drawing.Point(245, 167)
        Me.btn_OUT.Name = "btn_OUT"
        Me.btn_OUT.Size = New System.Drawing.Size(85, 50)
        Me.btn_OUT.TabIndex = 7
        Me.btn_OUT.Text = "End Time"
        Me.btn_OUT.UseVisualStyleBackColor = True
        '
        'chbox5
        '
        Me.chbox5.AutoSize = True
        Me.chbox5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbox5.ForeColor = System.Drawing.Color.Red
        Me.chbox5.Location = New System.Drawing.Point(18, 121)
        Me.chbox5.Name = "chbox5"
        Me.chbox5.Size = New System.Drawing.Size(67, 22)
        Me.chbox5.TabIndex = 4
        Me.chbox5.Text = "3 Hrs"
        Me.chbox5.UseVisualStyleBackColor = True
        '
        'chbox4
        '
        Me.chbox4.AutoSize = True
        Me.chbox4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbox4.ForeColor = System.Drawing.Color.Red
        Me.chbox4.Location = New System.Drawing.Point(18, 97)
        Me.chbox4.Name = "chbox4"
        Me.chbox4.Size = New System.Drawing.Size(67, 22)
        Me.chbox4.TabIndex = 3
        Me.chbox4.Text = "2 Hrs"
        Me.chbox4.UseVisualStyleBackColor = True
        '
        'btn_pause
        '
        Me.btn_pause.BackgroundImage = Global.Cafe_Server.My.Resources.Resources.BTN
        Me.btn_pause.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pause.Location = New System.Drawing.Point(156, 217)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(83, 52)
        Me.btn_pause.TabIndex = 14
        Me.btn_pause.Text = "Pause Time"
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'btn_resume
        '
        Me.btn_resume.BackgroundImage = Global.Cafe_Server.My.Resources.Resources.BTN
        Me.btn_resume.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resume.Location = New System.Drawing.Point(245, 217)
        Me.btn_resume.Name = "btn_resume"
        Me.btn_resume.Size = New System.Drawing.Size(85, 52)
        Me.btn_resume.TabIndex = 13
        Me.btn_resume.Text = "Resume Time"
        Me.btn_resume.UseVisualStyleBackColor = True
        '
        'chckpaid
        '
        Me.chckpaid.AutoSize = True
        Me.chckpaid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckpaid.ForeColor = System.Drawing.Color.White
        Me.chckpaid.Location = New System.Drawing.Point(153, 136)
        Me.chckpaid.Name = "chckpaid"
        Me.chckpaid.Size = New System.Drawing.Size(94, 19)
        Me.chckpaid.TabIndex = 4
        Me.chckpaid.Text = "Check if paid"
        Me.chckpaid.UseVisualStyleBackColor = True
        '
        'txthr
        '
        Me.txthr.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthr.Location = New System.Drawing.Point(236, 66)
        Me.txthr.MaxLength = 2
        Me.txthr.Name = "txthr"
        Me.txthr.Size = New System.Drawing.Size(94, 31)
        Me.txthr.TabIndex = 2
        Me.txthr.Text = "0"
        Me.txthr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(182, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(166, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minutes :"
        '
        'txtmin
        '
        Me.txtmin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmin.Location = New System.Drawing.Point(236, 99)
        Me.txtmin.MaxLength = 2
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(94, 31)
        Me.txtmin.TabIndex = 3
        Me.txtmin.Text = "0"
        Me.txtmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chbox2
        '
        Me.chbox2.AutoSize = True
        Me.chbox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbox2.ForeColor = System.Drawing.Color.Red
        Me.chbox2.Location = New System.Drawing.Point(18, 49)
        Me.chbox2.Name = "chbox2"
        Me.chbox2.Size = New System.Drawing.Size(110, 22)
        Me.chbox2.TabIndex = 1
        Me.chbox2.Text = "30 Minutes"
        Me.chbox2.UseVisualStyleBackColor = True
        '
        'chbox3
        '
        Me.chbox3.AutoSize = True
        Me.chbox3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbox3.ForeColor = System.Drawing.Color.Red
        Me.chbox3.Location = New System.Drawing.Point(18, 73)
        Me.chbox3.Name = "chbox3"
        Me.chbox3.Size = New System.Drawing.Size(59, 22)
        Me.chbox3.TabIndex = 2
        Me.chbox3.Text = "1 Hr"
        Me.chbox3.UseVisualStyleBackColor = True
        '
        'chbox1
        '
        Me.chbox1.AutoSize = True
        Me.chbox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbox1.ForeColor = System.Drawing.Color.Red
        Me.chbox1.Location = New System.Drawing.Point(18, 26)
        Me.chbox1.Name = "chbox1"
        Me.chbox1.Size = New System.Drawing.Size(110, 22)
        Me.chbox1.TabIndex = 0
        Me.chbox1.Text = "15 Minutes"
        Me.chbox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbox5)
        Me.GroupBox3.Controls.Add(Me.chbox4)
        Me.GroupBox3.Controls.Add(Me.chbox3)
        Me.GroupBox3.Controls.Add(Me.chbox2)
        Me.GroupBox3.Controls.Add(Me.chbox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(0, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 174)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quick Access"
        '
        'btnclose
        '
        Me.btnclose.ImageIndex = 0
        Me.btnclose.ImageList = Me.ImageList1
        Me.btnclose.Location = New System.Drawing.Point(280, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(50, 48)
        Me.btnclose.TabIndex = 24
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnclose)
        Me.GroupBox4.Controls.Add(Me.btn_resume)
        Me.GroupBox4.Controls.Add(Me.btn_pause)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.btn_IN)
        Me.GroupBox4.Controls.Add(Me.txtamount)
        Me.GroupBox4.Controls.Add(Me.btn_OUT)
        Me.GroupBox4.Controls.Add(Me.chckpaid)
        Me.GroupBox4.Controls.Add(Me.txthr)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtmin)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(337, 277)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'FrmSetTime_Multiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cafe_Server.My.Resources.Resources.frmIN
        Me.ClientSize = New System.Drawing.Size(353, 289)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmSetTime_Multiple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple - Set Time"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btn_IN As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents btn_OUT As System.Windows.Forms.Button
    Friend WithEvents chbox5 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox4 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_pause As System.Windows.Forms.Button
    Friend WithEvents btn_resume As System.Windows.Forms.Button
    Friend WithEvents chckpaid As System.Windows.Forms.CheckBox
    Friend WithEvents txthr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmin As System.Windows.Forms.TextBox
    Friend WithEvents chbox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox3 As System.Windows.Forms.CheckBox
    Friend WithEvents chbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
