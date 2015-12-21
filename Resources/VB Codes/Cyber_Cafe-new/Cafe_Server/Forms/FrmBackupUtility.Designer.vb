<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackupUtility
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
        Me.txtsourcedb = New System.Windows.Forms.TextBox()
        Me.txtdestination = New System.Windows.Forms.TextBox()
        Me.btnopen1 = New System.Windows.Forms.Button()
        Me.btnopen2 = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Database :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination Source :"
        '
        'txtsourcedb
        '
        Me.txtsourcedb.BackColor = System.Drawing.Color.White
        Me.txtsourcedb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsourcedb.Location = New System.Drawing.Point(144, 10)
        Me.txtsourcedb.Multiline = True
        Me.txtsourcedb.Name = "txtsourcedb"
        Me.txtsourcedb.ReadOnly = True
        Me.txtsourcedb.Size = New System.Drawing.Size(285, 28)
        Me.txtsourcedb.TabIndex = 2
        '
        'txtdestination
        '
        Me.txtdestination.BackColor = System.Drawing.Color.White
        Me.txtdestination.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestination.Location = New System.Drawing.Point(144, 42)
        Me.txtdestination.Multiline = True
        Me.txtdestination.Name = "txtdestination"
        Me.txtdestination.ReadOnly = True
        Me.txtdestination.Size = New System.Drawing.Size(285, 28)
        Me.txtdestination.TabIndex = 3
        '
        'btnopen1
        '
        Me.btnopen1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen1.Location = New System.Drawing.Point(432, 12)
        Me.btnopen1.Name = "btnopen1"
        Me.btnopen1.Size = New System.Drawing.Size(47, 23)
        Me.btnopen1.TabIndex = 4
        Me.btnopen1.Text = "Open"
        Me.btnopen1.UseVisualStyleBackColor = True
        '
        'btnopen2
        '
        Me.btnopen2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen2.Location = New System.Drawing.Point(432, 43)
        Me.btnopen2.Name = "btnopen2"
        Me.btnopen2.Size = New System.Drawing.Size(47, 23)
        Me.btnopen2.TabIndex = 5
        Me.btnopen2.Text = "Open"
        Me.btnopen2.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(274, 80)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 27)
        Me.btnBackup.TabIndex = 6
        Me.btnBackup.Text = "Back Up"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(355, 80)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 27)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Database Files(*.mdb)|*.mdb"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmBackupUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 119)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnopen2)
        Me.Controls.Add(Me.btnopen1)
        Me.Controls.Add(Me.txtdestination)
        Me.Controls.Add(Me.txtsourcedb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBackupUtility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Back up Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsourcedb As System.Windows.Forms.TextBox
    Friend WithEvents txtdestination As System.Windows.Forms.TextBox
    Friend WithEvents btnopen1 As System.Windows.Forms.Button
    Friend WithEvents btnopen2 As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
