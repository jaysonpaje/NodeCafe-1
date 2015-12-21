<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RatesList
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
        Me.ListRate = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtChngeRate = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtChngeRateTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.tbHRdisc = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbMINdisc = New System.Windows.Forms.TextBox()
        Me.listDisc = New System.Windows.Forms.ListView()
        Me.idk = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Hour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Minute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Rate"
        '
        'ListRate
        '
        Me.ListRate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Time, Me.Price})
        Me.ListRate.FullRowSelect = True
        Me.ListRate.GridLines = True
        Me.ListRate.Location = New System.Drawing.Point(6, 19)
        Me.ListRate.Name = "ListRate"
        Me.ListRate.Size = New System.Drawing.Size(241, 441)
        Me.ListRate.TabIndex = 2
        Me.ListRate.UseCompatibleStateImageBehavior = False
        Me.ListRate.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 1
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 103
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 86
        '
        'txtChngeRate
        '
        Me.txtChngeRate.Enabled = False
        Me.txtChngeRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChngeRate.Location = New System.Drawing.Point(82, 68)
        Me.txtChngeRate.Name = "txtChngeRate"
        Me.txtChngeRate.Size = New System.Drawing.Size(100, 31)
        Me.txtChngeRate.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(94, 118)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtChngeRateTime
        '
        Me.txtChngeRateTime.Enabled = False
        Me.txtChngeRateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChngeRateTime.Location = New System.Drawing.Point(82, 34)
        Me.txtChngeRateTime.Name = "txtChngeRateTime"
        Me.txtChngeRateTime.Size = New System.Drawing.Size(100, 31)
        Me.txtChngeRateTime.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rates"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(94, 176)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(94, 147)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'tbHRdisc
        '
        Me.tbHRdisc.Location = New System.Drawing.Point(65, 98)
        Me.tbHRdisc.Name = "tbHRdisc"
        Me.tbHRdisc.Size = New System.Drawing.Size(100, 20)
        Me.tbHRdisc.TabIndex = 11
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(65, 146)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'tbMINdisc
        '
        Me.tbMINdisc.Location = New System.Drawing.Point(65, 123)
        Me.tbMINdisc.Name = "tbMINdisc"
        Me.tbMINdisc.Size = New System.Drawing.Size(100, 20)
        Me.tbMINdisc.TabIndex = 15
        '
        'listDisc
        '
        Me.listDisc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idk, Me.Hour, Me.Minute})
        Me.listDisc.Location = New System.Drawing.Point(65, 19)
        Me.listDisc.Name = "listDisc"
        Me.listDisc.Size = New System.Drawing.Size(134, 73)
        Me.listDisc.TabIndex = 16
        Me.listDisc.UseCompatibleStateImageBehavior = False
        Me.listDisc.View = System.Windows.Forms.View.Details
        '
        'idk
        '
        Me.idk.Text = "id"
        Me.idk.Width = 1
        '
        'Hour
        '
        Me.Hour.Text = "Hour"
        '
        'Minute
        '
        Me.Minute.Text = "Min"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DiscHR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "DiscMIN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ListRate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 476)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtChngeRate)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.txtChngeRateTime)
        Me.GroupBox3.Controls.Add(Me.btnDel)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(266, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 253)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listDisc)
        Me.GroupBox2.Controls.Add(Me.tbHRdisc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbMINdisc)
        Me.GroupBox2.Location = New System.Drawing.Point(265, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 192)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discount"
        '
        'RatesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 530)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RatesList"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListRate As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents Price As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtChngeRate As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtChngeRateTime As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents tbHRdisc As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents tbMINdisc As System.Windows.Forms.TextBox
    Friend WithEvents listDisc As System.Windows.Forms.ListView
    Friend WithEvents idk As System.Windows.Forms.ColumnHeader
    Friend WithEvents Hour As System.Windows.Forms.ColumnHeader
    Friend WithEvents Minute As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
