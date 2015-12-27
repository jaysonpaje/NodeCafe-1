<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.NodeCafe = New NodeCafe.NSTheme()
        Me.NsTextBox1 = New NodeCafe.NSTextBox()
        Me.NsTrackBar1 = New NodeCafe.NSTrackBar()
        Me.NsvScrollBar1 = New NodeCafe.NSVScrollBar()
        Me.NodeCafe.SuspendLayout()
        Me.SuspendLayout()
        '
        'NodeCafe
        '
        Me.NodeCafe.AccentOffset = 42
        Me.NodeCafe.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NodeCafe.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NodeCafe.Colors = New NodeCafe.Bloom(-1) {}
        Me.NodeCafe.Controls.Add(Me.NsvScrollBar1)
        Me.NodeCafe.Controls.Add(Me.NsTrackBar1)
        Me.NodeCafe.Controls.Add(Me.NsTextBox1)
        Me.NodeCafe.Customization = ""
        Me.NodeCafe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NodeCafe.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NodeCafe.Image = Nothing
        Me.NodeCafe.Location = New System.Drawing.Point(0, 0)
        Me.NodeCafe.Movable = True
        Me.NodeCafe.Name = "NodeCafe"
        Me.NodeCafe.NoRounding = False
        Me.NodeCafe.Sizable = True
        Me.NodeCafe.Size = New System.Drawing.Size(284, 261)
        Me.NodeCafe.SmartBounds = True
        Me.NodeCafe.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NodeCafe.TabIndex = 0
        Me.NodeCafe.Text = "NodeCafe"
        Me.NodeCafe.TransparencyKey = System.Drawing.Color.Empty
        Me.NodeCafe.Transparent = False
        '
        'NsTextBox1
        '
        Me.NsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox1.Location = New System.Drawing.Point(98, 115)
        Me.NsTextBox1.MaxLength = 32767
        Me.NsTextBox1.Multiline = False
        Me.NsTextBox1.Name = "NsTextBox1"
        Me.NsTextBox1.ReadOnly = False
        Me.NsTextBox1.Size = New System.Drawing.Size(124, 73)
        Me.NsTextBox1.TabIndex = 0
        Me.NsTextBox1.Text = "NsTextBox1"
        Me.NsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox1.UseSystemPasswordChar = False
        '
        'NsTrackBar1
        '
        Me.NsTrackBar1.Location = New System.Drawing.Point(55, 81)
        Me.NsTrackBar1.Maximum = 10
        Me.NsTrackBar1.Minimum = 0
        Me.NsTrackBar1.Name = "NsTrackBar1"
        Me.NsTrackBar1.Size = New System.Drawing.Size(75, 23)
        Me.NsTrackBar1.TabIndex = 1
        Me.NsTrackBar1.Text = "NsTrackBar1"
        Me.NsTrackBar1.Value = 0
        '
        'NsvScrollBar1
        '
        Me.NsvScrollBar1._Percent = 0R
        Me.NsvScrollBar1.LargeChange = 10
        Me.NsvScrollBar1.Location = New System.Drawing.Point(241, 115)
        Me.NsvScrollBar1.Maximum = 100
        Me.NsvScrollBar1.Minimum = 0
        Me.NsvScrollBar1.Name = "NsvScrollBar1"
        Me.NsvScrollBar1.Size = New System.Drawing.Size(20, 115)
        Me.NsvScrollBar1.SmallChange = 1
        Me.NsvScrollBar1.TabIndex = 2
        Me.NsvScrollBar1.Text = "NsvScrollBar1"
        Me.NsvScrollBar1.Value = 0
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.NodeCafe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NodeCafe"
        Me.NodeCafe.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NodeCafe As NSTheme
    Friend WithEvents NsTextBox1 As NSTextBox
    Friend WithEvents NsvScrollBar1 As NSVScrollBar
    Friend WithEvents NsTrackBar1 As NSTrackBar
End Class
