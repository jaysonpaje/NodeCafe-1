<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.StatStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsTimer = New System.Windows.Forms.ToolStrip
        Me.Button1 = New System.Windows.Forms.Button
        Me.panelTimer = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btn_IN5 = New System.Windows.Forms.Button
        Me.btn_IN4 = New System.Windows.Forms.Button
        Me.btn_IN3 = New System.Windows.Forms.Button
        Me.btn_IN2 = New System.Windows.Forms.Button
        Me.btn_IN1 = New System.Windows.Forms.Button
        Me.btn_OUT = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_IN = New System.Windows.Forms.Button
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.chckpaid = New System.Windows.Forms.CheckBox
        Me.txtmin = New System.Windows.Forms.TextBox
        Me.txthr = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_pause = New System.Windows.Forms.Button
        Me.btn_resume = New System.Windows.Forms.Button
        Me.txtelapse = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblpc = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtend = New System.Windows.Forms.TextBox
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatStrip.SuspendLayout()
        Me.panelTimer.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator4, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintSetupToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(143, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintSetupToolStripMenuItem.Text = "Print Setup"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator6, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator7, Me.SelectAllToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(39, 20)
        Me.EditMenu.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(161, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(161, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(632, 43)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 40)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'StatStrip
        '
        Me.StatStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatStrip.Location = New System.Drawing.Point(0, 637)
        Me.StatStrip.Name = "StatStrip"
        Me.StatStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatStrip.TabIndex = 7
        Me.StatStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'tsTimer
        '
        Me.tsTimer.AutoSize = False
        Me.tsTimer.Dock = System.Windows.Forms.DockStyle.Right
        Me.tsTimer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsTimer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsTimer.Location = New System.Drawing.Point(400, 67)
        Me.tsTimer.Name = "tsTimer"
        Me.tsTimer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsTimer.Size = New System.Drawing.Size(232, 570)
        Me.tsTimer.TabIndex = 9
        Me.tsTimer.Text = "ToolStrip1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panelTimer
        '
        Me.panelTimer.Controls.Add(Me.GroupBox4)
        Me.panelTimer.Controls.Add(Me.GroupBox2)
        Me.panelTimer.Controls.Add(Me.GroupBox1)
        Me.panelTimer.Location = New System.Drawing.Point(400, 44)
        Me.panelTimer.Name = "panelTimer"
        Me.panelTimer.Size = New System.Drawing.Size(232, 567)
        Me.panelTimer.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.btn_OUT)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.btn_IN)
        Me.GroupBox4.Controls.Add(Me.txtamount)
        Me.GroupBox4.Controls.Add(Me.chckpaid)
        Me.GroupBox4.Controls.Add(Me.txtmin)
        Me.GroupBox4.Controls.Add(Me.txthr)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 143)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 371)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtend)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.btn_IN5)
        Me.GroupBox5.Controls.Add(Me.btn_IN4)
        Me.GroupBox5.Controls.Add(Me.btn_IN3)
        Me.GroupBox5.Controls.Add(Me.btn_IN2)
        Me.GroupBox5.Controls.Add(Me.btn_IN1)
        Me.GroupBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 169)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(212, 179)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Quick Access"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Red
        Me.TextBox5.Location = New System.Drawing.Point(100, 145)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 19)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "3 Hours"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Red
        Me.TextBox4.Location = New System.Drawing.Point(100, 116)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "2 Hours"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Red
        Me.TextBox3.Location = New System.Drawing.Point(100, 87)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 19)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "1 Hour"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Red
        Me.TextBox2.Location = New System.Drawing.Point(100, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 19)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "30 Minutes"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(100, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "15 Minutes"
        '
        'btn_IN5
        '
        Me.btn_IN5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IN5.Location = New System.Drawing.Point(6, 143)
        Me.btn_IN5.Name = "btn_IN5"
        Me.btn_IN5.Size = New System.Drawing.Size(75, 23)
        Me.btn_IN5.TabIndex = 4
        Me.btn_IN5.Text = "SET"
        Me.btn_IN5.UseVisualStyleBackColor = True
        '
        'btn_IN4
        '
        Me.btn_IN4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IN4.Location = New System.Drawing.Point(6, 114)
        Me.btn_IN4.Name = "btn_IN4"
        Me.btn_IN4.Size = New System.Drawing.Size(75, 23)
        Me.btn_IN4.TabIndex = 3
        Me.btn_IN4.Text = "SET"
        Me.btn_IN4.UseVisualStyleBackColor = True
        '
        'btn_IN3
        '
        Me.btn_IN3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IN3.Location = New System.Drawing.Point(6, 85)
        Me.btn_IN3.Name = "btn_IN3"
        Me.btn_IN3.Size = New System.Drawing.Size(75, 23)
        Me.btn_IN3.TabIndex = 2
        Me.btn_IN3.Text = "SET"
        Me.btn_IN3.UseVisualStyleBackColor = True
        '
        'btn_IN2
        '
        Me.btn_IN2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IN2.Location = New System.Drawing.Point(6, 56)
        Me.btn_IN2.Name = "btn_IN2"
        Me.btn_IN2.Size = New System.Drawing.Size(75, 23)
        Me.btn_IN2.TabIndex = 1
        Me.btn_IN2.Text = "SET"
        Me.btn_IN2.UseVisualStyleBackColor = True
        '
        'btn_IN1
        '
        Me.btn_IN1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IN1.Location = New System.Drawing.Point(6, 27)
        Me.btn_IN1.Name = "btn_IN1"
        Me.btn_IN1.Size = New System.Drawing.Size(75, 23)
        Me.btn_IN1.TabIndex = 0
        Me.btn_IN1.Text = "SET"
        Me.btn_IN1.UseVisualStyleBackColor = True
        '
        'btn_OUT
        '
        Me.btn_OUT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OUT.Location = New System.Drawing.Point(121, 128)
        Me.btn_OUT.Name = "btn_OUT"
        Me.btn_OUT.Size = New System.Drawing.Size(85, 29)
        Me.btn_OUT.TabIndex = 7
        Me.btn_OUT.Text = "Time OUT"
        Me.btn_OUT.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(7, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 11)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'btn_IN
        '
        Me.btn_IN.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IN.Location = New System.Drawing.Point(21, 128)
        Me.btn_IN.Name = "btn_IN"
        Me.btn_IN.Size = New System.Drawing.Size(83, 29)
        Me.btn_IN.TabIndex = 6
        Me.btn_IN.Text = "Time IN"
        Me.btn_IN.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.White
        Me.txtamount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(76, 65)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(62, 26)
        Me.txtamount.TabIndex = 5
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chckpaid
        '
        Me.chckpaid.AutoSize = True
        Me.chckpaid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckpaid.Location = New System.Drawing.Point(64, 94)
        Me.chckpaid.Name = "chckpaid"
        Me.chckpaid.Size = New System.Drawing.Size(94, 19)
        Me.chckpaid.TabIndex = 4
        Me.chckpaid.Text = "Check if paid"
        Me.chckpaid.UseVisualStyleBackColor = True
        '
        'txtmin
        '
        Me.txtmin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmin.Location = New System.Drawing.Point(113, 29)
        Me.txtmin.MaxLength = 2
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(62, 31)
        Me.txtmin.TabIndex = 3
        Me.txtmin.Text = "0"
        Me.txtmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txthr
        '
        Me.txthr.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthr.Location = New System.Drawing.Point(42, 29)
        Me.txthr.MaxLength = 2
        Me.txthr.Name = "txthr"
        Me.txthr.Size = New System.Drawing.Size(62, 31)
        Me.txthr.TabIndex = 2
        Me.txthr.Text = "0"
        Me.txthr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minutes "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_pause)
        Me.GroupBox2.Controls.Add(Me.btn_resume)
        Me.GroupBox2.Controls.Add(Me.txtelapse)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 82)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'btn_pause
        '
        Me.btn_pause.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pause.Location = New System.Drawing.Point(129, 19)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(86, 23)
        Me.btn_pause.TabIndex = 14
        Me.btn_pause.Text = "Pause Time"
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'btn_resume
        '
        Me.btn_resume.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resume.Location = New System.Drawing.Point(129, 46)
        Me.btn_resume.Name = "btn_resume"
        Me.btn_resume.Size = New System.Drawing.Size(86, 23)
        Me.btn_resume.TabIndex = 13
        Me.btn_resume.Text = "Resume Time"
        Me.btn_resume.UseVisualStyleBackColor = True
        '
        'txtelapse
        '
        Me.txtelapse.BackColor = System.Drawing.Color.White
        Me.txtelapse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtelapse.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelapse.ForeColor = System.Drawing.Color.Red
        Me.txtelapse.Location = New System.Drawing.Point(7, 19)
        Me.txtelapse.Multiline = True
        Me.txtelapse.Name = "txtelapse"
        Me.txtelapse.ReadOnly = True
        Me.txtelapse.Size = New System.Drawing.Size(119, 50)
        Me.txtelapse.TabIndex = 12
        Me.txtelapse.Text = "00:00"
        Me.txtelapse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblpc)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 43)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'lblpc
        '
        Me.lblpc.AutoSize = True
        Me.lblpc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpc.Location = New System.Drawing.Point(6, 16)
        Me.lblpc.Name = "lblpc"
        Me.lblpc.Size = New System.Drawing.Size(78, 19)
        Me.lblpc.TabIndex = 12
        Me.lblpc.Text = "PC Name :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(214, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtend
        '
        Me.txtend.Location = New System.Drawing.Point(100, -2)
        Me.txtend.Name = "txtend"
        Me.txtend.Size = New System.Drawing.Size(100, 26)
        Me.txtend.TabIndex = 17
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 659)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.panelTimer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tsTimer)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatStrip.ResumeLayout(False)
        Me.StatStrip.PerformLayout()
        Me.panelTimer.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTimer As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents panelTimer As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblpc As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtelapse As System.Windows.Forms.TextBox
    Friend WithEvents btn_pause As System.Windows.Forms.Button
    Friend WithEvents btn_resume As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmin As System.Windows.Forms.TextBox
    Friend WithEvents txthr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents chckpaid As System.Windows.Forms.CheckBox
    Friend WithEvents btn_OUT As System.Windows.Forms.Button
    Friend WithEvents btn_IN As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_IN4 As System.Windows.Forms.Button
    Friend WithEvents btn_IN3 As System.Windows.Forms.Button
    Friend WithEvents btn_IN2 As System.Windows.Forms.Button
    Friend WithEvents btn_IN1 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_IN5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtend As System.Windows.Forms.TextBox

End Class
