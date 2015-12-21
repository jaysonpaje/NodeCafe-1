<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBG
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MyLabel1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtrepass = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpIP = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.grpLogin.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpIP.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'MyLabel1
        '
        Me.MyLabel1.AutoSize = True
        Me.MyLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MyLabel1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.MyLabel1.Location = New System.Drawing.Point(73, 150)
        Me.MyLabel1.Name = "MyLabel1"
        Me.MyLabel1.Size = New System.Drawing.Size(1163, 44)
        Me.MyLabel1.TabIndex = 4
        Me.MyLabel1.Text = "To use this computer please ask for assistance from the operator"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'grpLogin
        '
        Me.grpLogin.BackColor = System.Drawing.Color.White
        Me.grpLogin.Controls.Add(Me.GroupBox2)
        Me.grpLogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLogin.Location = New System.Drawing.Point(65, 253)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(395, 128)
        Me.grpLogin.TabIndex = 5
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        Me.grpLogin.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtrepass)
        Me.GroupBox2.Controls.Add(Me.txtpass)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 83)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'txtrepass
        '
        Me.txtrepass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepass.Location = New System.Drawing.Point(145, 40)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepass.Size = New System.Drawing.Size(190, 22)
        Me.txtrepass.TabIndex = 1
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(145, 15)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(190, 22)
        Me.txtpass.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Re-type Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Password :"
        '
        'grpIP
        '
        Me.grpIP.BackColor = System.Drawing.Color.White
        Me.grpIP.Controls.Add(Me.Label4)
        Me.grpIP.Controls.Add(Me.GroupBox3)
        Me.grpIP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIP.Location = New System.Drawing.Point(191, 485)
        Me.grpIP.Name = "grpIP"
        Me.grpIP.Size = New System.Drawing.Size(312, 149)
        Me.grpIP.TabIndex = 6
        Me.grpIP.TabStop = False
        Me.grpIP.Text = "Server IP Address"
        Me.grpIP.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 42)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Note : If your using it as standalone, just " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "input " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your loop back ip address w" & _
            "hich is 127.0.0.1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtip)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 56)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        '
        'txtip
        '
        Me.txtip.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtip.Location = New System.Drawing.Point(38, 19)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(250, 22)
        Me.txtip.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IP :"
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.BackColor = System.Drawing.Color.Transparent
        Me.lblc.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.ForeColor = System.Drawing.Color.Yellow
        Me.lblc.Location = New System.Drawing.Point(12, 78)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(1182, 64)
        Me.lblc.TabIndex = 7
        Me.lblc.Text = "Press ""1"" to Enter Password, Press ""2"" to change server IP ADDRESS, press ""T"" to " & _
            "deactivate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the desktop blocker"
        '
        'frmBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cafe_Client.My.Resources.Resources.mainBG
        Me.ClientSize = New System.Drawing.Size(1300, 768)
        Me.Controls.Add(Me.lblc)
        Me.Controls.Add(Me.grpIP)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.MyLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBG"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpLogin.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpIP.ResumeLayout(False)
        Me.grpIP.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MyLabel1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents grpLogin As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtrepass As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpIP As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
