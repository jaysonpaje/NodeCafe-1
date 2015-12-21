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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBG))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.clientPanel = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "unused.ico")
        Me.ImageList1.Images.SetKeyName(1, "green.JPG")
        Me.ImageList1.Images.SetKeyName(2, "Red.bmp")
        Me.ImageList1.Images.SetKeyName(3, "stop.png")
        Me.ImageList1.Images.SetKeyName(4, "pause.ico")
        '
        'clientPanel
        '
        Me.clientPanel.BackColor = System.Drawing.SystemColors.Window
        Me.clientPanel.Location = New System.Drawing.Point(1, 1)
        Me.clientPanel.Name = "clientPanel"
        Me.clientPanel.Size = New System.Drawing.Size(1274, 250)
        Me.clientPanel.TabIndex = 4
        '
        'frmBG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 796)
        Me.ControlBox = False
        Me.Controls.Add(Me.clientPanel)
        Me.Name = "frmBG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents clientPanel As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
