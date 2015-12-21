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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPcNum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblset = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Black
        Me.lblTimer.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(38, 77)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(195, 59)
        Me.lblTimer.TabIndex = 1
        Me.lblTimer.Text = "00:00:00"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(77, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Connect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(30, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(62, 256)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(193, 36)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Timer Show"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PC"
        '
        'lblPcNum
        '
        Me.lblPcNum.AutoSize = True
        Me.lblPcNum.BackColor = System.Drawing.Color.Black
        Me.lblPcNum.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPcNum.ForeColor = System.Drawing.Color.White
        Me.lblPcNum.Location = New System.Drawing.Point(210, 19)
        Me.lblPcNum.Name = "lblPcNum"
        Me.lblPcNum.Size = New System.Drawing.Size(45, 36)
        Me.lblPcNum.TabIndex = 7
        Me.lblPcNum.Text = "01"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Tan
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Set Time :"
        '
        'lblset
        '
        Me.lblset.AutoSize = True
        Me.lblset.BackColor = System.Drawing.Color.Black
        Me.lblset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblset.Location = New System.Drawing.Point(112, 139)
        Me.lblset.Name = "lblset"
        Me.lblset.Size = New System.Drawing.Size(0, 14)
        Me.lblset.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Tan
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Price :"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.Blue
        Me.lblprice.Location = New System.Drawing.Point(112, 161)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(0, 15)
        Me.lblprice.TabIndex = 11
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape2, Me.OvalShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(280, 202)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Black
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.BorderColor = System.Drawing.Color.Black
        Me.OvalShape1.BorderWidth = 6
        Me.OvalShape1.Location = New System.Drawing.Point(158, 6)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(110, 62)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.Color.Black
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.BorderColor = System.Drawing.Color.Maroon
        Me.OvalShape2.BorderWidth = 5
        Me.OvalShape2.Location = New System.Drawing.Point(158, 6)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(110, 62)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.CornerRadius = 20
        Me.RectangleShape1.FillColor = System.Drawing.Color.Maroon
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Black
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(4, 44)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(269, 144)
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(280, 202)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPcNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClient"
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPcNum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblset As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
