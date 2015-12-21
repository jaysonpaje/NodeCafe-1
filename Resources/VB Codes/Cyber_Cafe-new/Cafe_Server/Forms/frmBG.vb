Imports System.Threading
Imports System.Net, System.Net.Sockets

Public Class frmBG
    Dim _tRates(0) As Integer
    Dim _tCount As Integer

    Dim bytes As Byte() = New Byte(1023) {}
    Dim top_ As Integer = 5
    Dim left_ As Integer = 0
    Dim multiselect As Boolean = False
    Public sSocket, cSocket As Socket

    Dim rList As String

    Dim amountTopayHR As Double
    Dim _amntUnpaid As Double

    Dim _mPass As String

    Private Sub frmBG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim FontName As String = "Tahoma"
        Dim FontSize As Integer = 10
        Dim FS As New Font(FontName, FontSize, FontStyle.Bold)
        'Label1.Font = FS
        With clientPanel
            .Height = Me.Height
            .Width = Me.Width
            .Top = Me.Top + MDIMain.StatStrip.Height + 30
            .Left = Me.Left + 6
        End With
        left_ = (200 / (Me.Width / 200)) * 2
        For x = 1 To 30
            pnl(x) = New System.Windows.Forms.Panel
            btn(x) = New System.Windows.Forms.Button()
            lblIn(x) = New System.Windows.Forms.Label()
            lblOut(x) = New System.Windows.Forms.Label()
            lblInT(x) = New System.Windows.Forms.Label()
            lblOutT(x) = New System.Windows.Forms.Label()
            lblelpsed(x) = New System.Windows.Forms.Label()
            elpsedT(x) = New System.Windows.Forms.Label()
            lblPay(x) = New System.Windows.Forms.Label()
            lblPayment(x) = New System.Windows.Forms.Label()
            lblUnpaid(x) = New System.Windows.Forms.Label()
            lblUnpaidT(x) = New System.Windows.Forms.Label()
            grp(x) = New System.Windows.Forms.GroupBox
            chcbx(x) = New System.Windows.Forms.CheckBox
            btn(x).Height = 85
            btn(x).Width = 78
            If (left_ + 207) >= Me.Width Then
                left_ = (205 / (Me.Width / 205)) * 2
                top_ += pnl(x).Height
            End If
            'time in label
            lblIn(x).Text = "Time In :"
            lblIn(x).Left = btn(x).Right + 22
            lblIn(x).Top = btn(x).Top + 10
            lblIn(x).Width = 48
            lblIn(x).Height = 17
            lblIn(x).BackColor = Color.Transparent
            'timeIN running time
            lblInT(x).BackColor = Color.AliceBlue
            lblInT(x).Left = lblIn(x).Left + 49
            lblInT(x).Top = lblIn(x).Top
            lblInT(x).Width = 55
            lblInT(x).Height = 16
            lblInT(x).Text = "" 'TimeOfDay.ToString("hh:mm tt") 'Format("HH:mm", TimeOfDay)
            'time out label
            lblOut(x).Text = "Time Out :"
            lblOut(x).Left = btn(x).Right + 14
            lblOut(x).Top = lblIn(x).Top + 20
            lblOut(x).Width = 57
            lblOut(x).Height = 17
            lblOut(x).BackColor = Color.Transparent
            'timeOUT Running time
            lblOutT(x).BackColor = Color.AliceBlue
            lblOutT(x).Left = lblOut(x).Left + 57
            lblOutT(x).Top = lblOut(x).Top - 1
            lblOutT(x).Width = 55
            lblOutT(x).Height = 16
            lblOutT(x).Text = "" 'TimeOfDay.ToString("hh:mm tt") 'Format("HH:mm", TimeOfDay)
            'elapse time label
            lblelpsed(x).Width = 70
            lblelpsed(x).Left = btn(x).Right + 1 '80
            lblelpsed(x).Top = lblOut(x).Top + 20
            lblelpsed(x).Height = 17
            lblelpsed(x).Text = "Elapse Time:"
            lblelpsed(x).BackColor = Color.Transparent
            'elapse time running time
            elpsedT(x).Left = elpsedT(x).Left + 149
            elpsedT(x).Top = lblelpsed(x).Top - 2
            elpsedT(x).Height = 16
            elpsedT(x).Width = 55
            elpsedT(x).BackColor = Color.AliceBlue
            'payment label
            lblPay(x).Width = 55
            lblPay(x).Left = btn(x).Right + 15 '80
            lblPay(x).Top = lblelpsed(x).Top + 20
            lblPay(x).Height = 17
            lblPay(x).Text = "Payment : "
            lblPay(x).BackColor = Color.Transparent
            'amount to pay
            lblPayment(x).Left = lblPayment(x).Left + 149
            lblPayment(x).Top = lblPay(x).Top - 3
            lblPayment(x).Height = 16
            lblPayment(x).Width = 55
            lblPayment(x).BackColor = Color.AliceBlue
            'unpaid label
            lblUnpaid(x).Width = 50
            lblUnpaid(x).Left = btn(x).Right + 21
            lblUnpaid(x).Top = lblPay(x).Top + 18
            lblUnpaid(x).Height = 17
            lblUnpaid(x).Text = "Unpaid :"
            lblUnpaid(x).BackColor = Color.Transparent
            'amount unpaid
            lblUnpaidT(x).Left = lblUnpaidT(x).Left + 149
            lblUnpaidT(x).Top = lblUnpaid(x).Top - 2
            lblUnpaidT(x).Height = 16
            lblUnpaidT(x).Width = 55
            lblUnpaidT(x).BackColor = Color.AliceBlue
            '--
            btn(x).TextAlign = ContentAlignment.BottomCenter
            btn(x).TextImageRelation = TextImageRelation.ImageAboveText
            btn(x).UseVisualStyleBackColor = True
            btn(x).ImageList = ImageList1
            btn(x).ImageIndex = 0
            btn(x).ForeColor = Color.Red
            btn(x).Font = FS
            btn(x).TextAlign = ContentAlignment.BottomCenter
            'panel settings
            pnl(x).Height = 106
            pnl(x).Width = 215
            pnl(x).BackColor = Color.Chocolate
            pnl(x).Top = top_
            pnl(x).Left = left_
            'group settings
            grp(x).Top = 0
            grp(x).Height = 106
            grp(x).Width = 210
            'grp(x).BackColor = Color.Blue
            btn(x).Top = grp(x).Top + 8
            btn(x).Left = 2
            btn(x).Text = "PC " & x.ToString
            'checkbox
            chcbx(x).Left = 80
            chcbx(x).Top = grp(x).Top + 5
            chcbx(x).BackColor = Color.Transparent
            'group add controls
            grp(x).Controls.Add(btn(x))
            grp(x).Controls.Add(lblIn(x))
            grp(x).Controls.Add(lblOut(x))
            grp(x).Controls.Add(lblInT(x))
            grp(x).Controls.Add(lblOutT(x))
            grp(x).Controls.Add(chcbx(x))
            grp(x).Controls.Add(lblelpsed(x))
            grp(x).Controls.Add(elpsedT(x))
            grp(x).Controls.Add(lblPay(x))
            grp(x).Controls.Add(lblPayment(x))
            grp(x).Controls.Add(lblUnpaid(x))
            grp(x).Controls.Add(lblUnpaidT(x))
            grp(x).BackgroundImage = ImageList1.Images(5)

            pnl(x).BackColor = Color.Transparent
            pnl(x).Controls.Add(grp(x))
            clientPanel.Controls.Add(pnl(x))
            'clientPanel.Controls.Add(grp(x))
            left_ += 207
            btn_store.Add(New Store(btn(x).Text, x))
            'set it up to nothing
            btn(x).Tag = Nothing
            AddHandler btn(x).KeyUp, AddressOf _keyup
            AddHandler btn(x).KeyDown, AddressOf _keydown
            AddHandler btn(x).MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf _MouseDown)
        Next
        'get per hour
        sqlSTR = "SELECT Amounts FROM Rates ORDER BY ID DESC"
        ExecuteSQLQuery(sqlSTR)
        If sqlDr.Read Then
            AmtinHr = sqlDr("Amounts")
        End If

        sqlSTR = "Select HrDeduct From Misc Where id=1"
        ExecuteSQLQuery(sqlSTR)
        If sqlDr.Read Then
            IsDisc = Val(sqlDr("HrDeduct"))
        End If

        _RatesTable()
        ExecuteSQLQuery("SELECT * FROM tbl_master_password")
        If sqlDr.Read Then
            _mPass = sqlDr("client_password")
        End If
        Timer1.Enabled = True
        FrmAbout.ShowDialog()
        Try
            sSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim IpEndPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 8800)
            'MsgBox(sSocket.Blocking)
            'sSocket.Blocking = False
            If Not sSocket.IsBound Then
                sSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, True)
                sSocket.Bind(IpEndPoint)
                sSocket.Listen(40)
                sSocket.BeginAccept(New AsyncCallback(AddressOf OnAccept), Nothing)
            End If
        Catch ex As Exception

            'sSocket.Shutdown(SocketShutdown.Receive)
            sSocket.Close()
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub OnAccept(ByVal ar As IAsyncResult)

        cSocket = sSocket.EndAccept(ar)
        sSocket.BeginAccept(New AsyncCallback(AddressOf OnAccept), Nothing)
        cSocket.BeginReceive(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnRecieve), cSocket)
        AddClient(cSocket)

    End Sub
    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            cSocket = ar.AsyncState
            cSocket.EndReceive(ar)
            Dim _msg As String = System.Text.UnicodeEncoding.Unicode.GetString(bytes)
            receivePackets(_msg, cSocket)
            cSocket.BeginReceive(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnRecieve), cSocket)
        Catch ex As Exception
            'MsgBox(ex.ToString)
            For i = 1 To 30
                If btn(i).Tag Is cSocket Then
                    _setDc(i)
                    Exit For
                End If
            Next
            cSocket.Close()
            sSocket.BeginAccept(New AsyncCallback(AddressOf OnAccept), Nothing)
        End Try
    End Sub
    Private Sub AddClient(ByVal client As Socket)
        Dim str_ip As String
        Dim x As Integer
        Dim _pcno As Integer
        'do handshake 
        _amntUnpaid = 0
        str_ip = Split(client.RemoteEndPoint.ToString, ":")(0)
        ExecuteSQLQuery("SELECT * FROM tbl_clients WHERE IP_Address ='" & str_ip & "'")
        If Not sqlDr.Read Then
            'if record is not existed
            For x = 1 To 30
                ExecuteSQLQuery("SELECT * FROM tbl_clients WHERE pc_no =" & x)
                If Not sqlDr.Read Then
                    _pcno = x
                    ExecuteSQLQuery("INSERT INTO Tbl_clients ( Pc_No, Client_Name,  ip_address ) " & _
                                    "VALUES(" & x & ", " _
                                   & "'" & "PC " & _pcno & "', " _
                                   & "'" & str_ip & "')")
                    btn(x).ImageIndex = 1
                    btn(x).Tag = client
                    chcbx(x).Tag = x
                    Exit For
                End If
            Next
            request_handshake(_mPass, client, _pcno)
        Else
            'if its already in the database
            'check if the pc has not been logged out
            'purpose: accidentally turn off computer
            'browout, etc..
            _pcno = sqlDr(0)
            request_handshake(_mPass, client, _pcno)
            sqlSTR = "Select SUM(extend_payment) AS unpaid, IN_payment, total_payment " & _
                     "FROM (tbl_IN_clients " & _
                     "LEFT JOIN tbl_EXTEND_time ON ((tbl_IN_clients.in_id = tbl_EXTEND_time.in_id) AND (tbl_EXTEND_time.paid=no)) ) " & _
                     "WHERE pc_no =" & _pcno & _
                     " GROUP by tbl_extend_time.in_id, IN_payment, total_payment, time_in " & _
                     " ORDER BY time_in DESC"
            ExecuteSQLQuery(sqlSTR)
            If sqlDr.Read Then
                If sqlDr("IN_payment") > 0 Then
                    _bolPaid(_pcno) = True
                    _amntUnpaid = 0
                    If sqlDr("unpaid").ToString <> Nothing Then
                        _amntUnpaid += sqlDr("unpaid")
                    End If
                Else
                    _bolPaid(_pcno) = False
                    _amntUnpaid = sqlDr("total_payment")
                    'redundant must do something about this later =)), this can be added on the tbl_IN_clients
                    sqlSTR = "SELECT * FROM tbl_in_clients WHERE pc_no =" & _pcno & " ORDER BY time_in DESC"
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDr.Read Then
                        sqlSTR = "SELECT * FROM tbl_EXTEND_time WHERE in_id =" & sqlDr("in_id") & " AND paid=yes "
                        ExecuteSQLQuery(sqlSTR)
                        If sqlDr.Read Then
                            _bolPaid(_pcno) = True
                        End If
                    End If
                End If
            End If
            sqlSTR = "SELECT * " & _
                     "FROM ((tbl_IN_clients " & _
                     "LEFT JOIN tbl_OUT_clients ON (tbl_IN_clients.in_id = tbl_OUT_clients.in_id) ) " & _
                     "LEFT JOIN tbl_PAUSE_clients ON (tbl_IN_clients.in_id = tbl_PAUSE_clients.in_id) ) " & _
                     "WHERE pc_no =" & _pcno & _
                     " ORDER BY time_in DESC "
            ExecuteSQLQuery(sqlSTR)
            btn(_pcno).Tag = client
            chcbx(_pcno).Tag = _pcno
            'MsgBox(sqlDr.Item("status"))
            If sqlDr.Read Then
                ' MsgBox("A")
                If sqlDr("tbl_OUT_clients.in_id").ToString <> "" Then
                    btn(_pcno).ImageIndex = 1
                Else
                    ''for disconnected pc or improper shutdown
                    Dim objThreadClass As New clsThread(_pcno, Me)
                    Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
                    m_ThreadList.Item(_pcno) = objNewThread
                    Select Case sqlDr.Item("status")
                        Case 0
                            btn(_pcno).ImageIndex = 1
                            m_ThreadList.Item(_pcno) = Nothing
                        Case 1 'if it's still active
                            requestRecon(client)
                            _tmpSetTime_(_pcno) = (sqlDr.Item("Time_HR") * 3600) + (sqlDr.Item("Time_MIN") * 60) 'set the counter time, reason, need to know if the client is already times up
                            Read(Format(sqlDr("time_in"), "hh:mm tt").ToString & "," & Format(sqlDr("tbl_IN_clients.time_out"), "hh:mm tt").ToString, _pcno)
                            'MsgBox(sqlDr("time_out"))
                            'lblOutT(_pcno).Text = Format(sqlDr("tbl_IN_clients.time_out"), "hh:mm tt").ToString
                        Case 2 'pause
                            _secs(_pcno) = sqlDr("elapse_time")
                            btn(_pcno).ImageIndex = 3
                            Read(Format(sqlDr("time_in"), "hh:mm tt").ToString & "," & Format(sqlDr("tbl_IN_clients.time_out"), "hh:mm tt"), _pcno)
                        Case 4 'dc
                            btn(_pcno).ImageIndex = 4
                            Read(Format(sqlDr("time_in"), "hh:mm tt").ToString & "," & Format(sqlDr("tbl_IN_clients.time_out"), "hh:mm tt"), _pcno)
                    End Select
                End If
            Else
                ' MsgBox("else")
                btn(_pcno).ImageIndex = 1
            End If
        End If
        sendRates(client, rList)
    End Sub
    Delegate Sub _Read(ByVal _timein As String, ByVal _pcno As Integer)
    Private Sub Read(ByVal _timein As String, ByVal _pcno As Integer)
        Dim args(1)
        'MsgBox(_timein)
        args(0) = _timein
        args(1) = _pcno

        If Me.InvokeRequired Then
            Me.Invoke(New _Read(AddressOf Read), args)
            Exit Sub
        End If
        lblInT(_pcno).Text = Split(_timein, ",")(0)
        lblOutT(_pcno).Text = Split(_timein, ",")(1)
        lblUnpaidT(_pcno).Text = _amntUnpaid
        If _secs(_pcno) > 0 Then
            '_tmpHr1 = ((_tmpTotal1 - _tmpTotal1 Mod 3600 Mod 60) _
            '            - (_tmpTotal1 Mod 3600 - _tmpTotal1 Mod 3600 Mod 60)) / 3600

            '(_tmpTotal1 Mod 3600 - _tmpTotal1 Mod 3600 Mod 60) / 60
            lblPayment(_pcno).Text = _checkHr(((_secs(_pcno) - _secs(_pcno) Mod 3600 Mod 60) _
                                     - (_secs(_pcno) Mod 3600 - _secs(_pcno) Mod 3600 Mod 60)) / 3600) + _mRates((_secs(_pcno) Mod 3600 - _secs(_pcno) Mod 3600 Mod 60) / 60)
        End If
        'lblPayment(_pcno).Text = 0
        'btn(_pcno).ImageIndex = 4
    End Sub
    Public Sub receivePackets(ByVal pData As String, ByVal client As Socket)
        Dim _arSplit
        _arSplit = Split(pData, "À€")

        Select Case _arSplit(8)
            Case 99 'request from the client to be recognize 

            Case 98 'the request was succesfuly decrypted and read

            Case 97

            Case 96 'disconnection was sent before the error begins
                'MsgBox("dc")
            Case 95 'total closure of the system, meaning all process has been closed

            Case 94 'response to requestRecon
                'MsgBox(_arSplit(3))
                If (_arSplit(0) = "05") Then
                    'dc
                    'MsgBox("dc receive packets")
                    btn(_arSplit(2)).ImageIndex = 4
                    _secs(_arSplit(2)) = _arSplit(3)
                    _mins(_arSplit(2)) = (_secs(_arSplit(2)) - (_secs(_arSplit(2)) Mod 60)) / 60
                Else
                    'continues
                    ' MsgBox("CONTINUES")
                    Dim objThreadClass As New clsThread(_arSplit(2), Me)
                    Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
                    
                    If _arSplit(9) > 0 Then 'check if timer in the clients is running
                        btn(_arSplit(2)).ImageIndex = 2
                        _secs(_arSplit(2)) = _arSplit(9)
                        objNewThread.IsBackground = True
                        objNewThread.Start()
                        m_ThreadList.Item(_arSplit(2)) = objNewThread
                    Else 'meaning to say that the client timer is not running 
                        'so set it to dc
                        'purpose: server and client has been restarted,
                        'and the client can't find the server and client timer is not running
                        ' MsgBox("client timer is not running dc")
                        btn(_arSplit(2)).ImageIndex = 4
                        'get the stored seconds in client
                        _secs(_arSplit(2)) = _arSplit(3)
                    End If
                    _mins(_arSplit(2)) = (_secs(_arSplit(2)) - (_secs(_arSplit(2)) Mod 60)) / 60 'TO DO: redundant do someting about this
                End If
            Case 93 'handshake confirm
                'MsgBox("handshake confirm")
                'MsgBox(decrypt(_arSplit(9)) & " " & Split(client.RemoteEndPoint.ToString, ":")(0))
                If decrypt(_arSplit(9)) = Split(client.RemoteEndPoint.ToString, ":")(0) Then
                    'btn(_arSplit(2)).ImageIndex = 1
                Else 'doesnt match
                    'MsgBox("TEST")
                    'MsgBox(decrypt(_arSplit(9)))
                    'MsgBox Split(client.RemoteEndPoint.ToString, ":")(0)
                    btn(_arSplit(2)).ImageIndex = 0 '
                    Exit Sub
                    'MsgBox("not match")
                End If
            Case 92 'set time out client suggest
                _setOut(_arSplit(2), False, lblPayment(_arSplit(2)).Text)
            Case Else
                MsgBox(pData)
        End Select
        'MsgBox(pData)
    End Sub

    Private Sub _keyup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = 17 Then
            multiselect = False
        End If
    End Sub
    Private Sub _keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 17 Then
            multiselect = True
        End If
    End Sub
    Private Sub _MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        'check if it's allow to access the button
        pc_name = sender.text
        If Not btn(btn_store.Find(AddressOf search_2).Index).Tag Is Nothing Then
            If e.Button = Windows.Forms.MouseButtons.Left Then 'user left click
                If multiselect Then
                    _btnClick(_prevIndex) = 0
                    _prevIndex = 0
                    If chcbx(btn_store.Find(AddressOf search_2).Index).Checked Then
                        chcbx(btn_store.Find(AddressOf search_2).Index).Checked = False
                    Else
                        chcbx(btn_store.Find(AddressOf search_2).Index).Checked = True
                    End If
                Else
                    _btnClick(btn_store.Find(AddressOf search_2).Index) += 1
                End If

                If _prevIndex > 0 Then
                    If _prevIndex = btn_store.Find(AddressOf search_2).Index Then
                        If _btnClick(btn_store.Find(AddressOf search_2).Index) >= 2 Then
                            _btnClick(btn_store.Find(AddressOf search_2).Index) = 0
                            'form_show(FrmSetTime, pnl(btn_store.Find(AddressOf search_2).Index).Top, pnl(btn_store.Find(AddressOf search_2).Index).Left)
                            form_show(FrmSetTime, pnl(btn_store.Find(AddressOf search_2).Index).Location.X, pnl(btn_store.Find(AddressOf search_2).Index).Location.Y)
                        End If
                    Else
                        _btnClick(_prevIndex) = 0
                    End If
                End If
                _prevIndex = btn_store.Find(AddressOf search_2).Index
            Else 'user right click
                _btnClick(_prevIndex) = 0
                _prevIndex = 0
                check_availability(btn_store.Find(AddressOf search_2).Index)
                btn_CMenuS_rightclick.Show(Me, New Point(pnl(btn_store.Find(AddressOf search_2).Index).Location.X + e.Location.X, pnl(btn_store.Find(AddressOf search_2).Index).Location.Y + e.Location.Y))
            End If
        End If

    End Sub
    Public Sub ReceiveDcClient(ByVal ThreadIndex As Integer, ByVal Counter As Integer)
        MsgBox(ThreadIndex & " " & Counter)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        global_timer += 1
    End Sub

    Private Sub LimitedTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimitedTimeToolStripMenuItem.Click
        FrmSetTime.ShowDialog()
    End Sub
    Private Sub check_availability(ByVal index As Integer)
        If btn(index).ImageIndex = 1 Then 'standby
            SetTimeToolStripMenuItem.Enabled = True
            LimitedTimeToolStripMenuItem.Enabled = True
            PauseTimeToolStripMenuItem.Enabled = False
            ResumeTimeToolStripMenuItem.Enabled = False
            EndTimeToolStripMenuItem.Enabled = False
            ExtendTimeToolStripMenuItem.Enabled = False
            RestartToolStripMenuItem.Enabled = True
            ShutdownClientToolStripMenuItem.Enabled = True

            SSToolStripMenuItem.Enabled = True
            StopAndSaveToolStripMenuItem.Enabled = False
            LoadSaveToolStripMenuItem.Enabled = True
        ElseIf btn(index).ImageIndex = 2 Then 'used
            SetTimeToolStripMenuItem.Enabled = True
            LimitedTimeToolStripMenuItem.Enabled = False
            PauseTimeToolStripMenuItem.Enabled = True
            ResumeTimeToolStripMenuItem.Enabled = False
            EndTimeToolStripMenuItem.Enabled = True
            ExtendTimeToolStripMenuItem.Enabled = IIf(_tmpSetTime_(index) > 0, True, False)
            RestartToolStripMenuItem.Enabled = True
            ShutdownClientToolStripMenuItem.Enabled = True

            SSToolStripMenuItem.Enabled = True
            StopAndSaveToolStripMenuItem.Enabled = IIf(_tmpSetTime_(index) > 0, True, False)
            LoadSaveToolStripMenuItem.Enabled = False
        ElseIf btn(index).ImageIndex = 3 Then 'pause
            SetTimeToolStripMenuItem.Enabled = False
            LimitedTimeToolStripMenuItem.Enabled = False
            PauseTimeToolStripMenuItem.Enabled = False
            ResumeTimeToolStripMenuItem.Enabled = True
            EndTimeToolStripMenuItem.Enabled = True
            ExtendTimeToolStripMenuItem.Enabled = IIf(_tmpSetTime_(index) > 0, True, False)
            RestartToolStripMenuItem.Enabled = True
            ShutdownClientToolStripMenuItem.Enabled = True

            SSToolStripMenuItem.Enabled = True
            StopAndSaveToolStripMenuItem.Enabled = IIf(_tmpSetTime_(index) > 0, True, False)
            LoadSaveToolStripMenuItem.Enabled = False
        ElseIf btn(index).ImageIndex = 4 Then 'dc
            SetTimeToolStripMenuItem.Enabled = False
            PauseTimeToolStripMenuItem.Enabled = False
            ResumeTimeToolStripMenuItem.Enabled = True
            EndTimeToolStripMenuItem.Enabled = True
            ExtendTimeToolStripMenuItem.Enabled = IIf(_tmpSetTime_(index) > 0, True, False)
            RestartToolStripMenuItem.Enabled = True
            ShutdownClientToolStripMenuItem.Enabled = True

            SSToolStripMenuItem.Enabled = True
            StopAndSaveToolStripMenuItem.Enabled = IIf(_tmpSetTime_(index) > 0, True, False)
            LoadSaveToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub PauseTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseTimeToolStripMenuItem.Click
        _setPause(btn_store.Find(AddressOf search_2).Index)
    End Sub

    Private Sub EndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndTimeToolStripMenuItem.Click
        'FrmSetTime.btn_OUT_Click(0, AcceptButton)
        Dim _tmpID As Integer
        _tmpID = btn_store.Find(AddressOf search_2).Index
        If MsgBox("Are you sure you want to set this time out", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            _setOut(_tmpID, True, Int(lblPayment(_tmpID).Text))
            'elpsedT(_tmpID).Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
            '                   0, _
            '                   0, _
            '                    0)
            ' lblInT(_tmpID).Text = ""
            'lblOutT(_tmpID).Text = ""
            ' lblUnpaidT(_tmpID).Text = 0
            '  lblPayment(_tmpID).Text = 0
        End If
    End Sub

    Private Sub ResumeTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeTimeToolStripMenuItem.Click
        FrmSetTime.btn_resume_Click(0, AcceptButton)
    End Sub
    Public Sub ReceiveThreadMessage(ByVal ThreadIndex As Integer, ByVal Counter As Integer)
        If _start(ThreadIndex) >= 1 Then
            _secs(ThreadIndex) += 1
            _hrs(ThreadIndex) = ((_secs(ThreadIndex) - _secs(ThreadIndex) Mod 3600 Mod 60) _
                                - (_secs(ThreadIndex) Mod 3600 - _secs(ThreadIndex) Mod 3600 Mod 60)) / 3600
            _mins(ThreadIndex) = (_secs(ThreadIndex) Mod 3600 - _secs(ThreadIndex) Mod 3600 Mod 60) / 60
            ' when 1 hr occur or first time to run of the system
            'check run purpose:
            'to get the disconnected, pause when improper shutdown occur or power failure occur
            If _mins(ThreadIndex) Mod 60 = 0 Or Not _checkRun(ThreadIndex) Then
                AmtinHrs(ThreadIndex) = _checkHr(_hrs(ThreadIndex))
            End If
            ' when 1 min occur or first time to run of the system
            If _secs(ThreadIndex) Mod 60 = 0 Or Not _checkRun(ThreadIndex) Then
                lblPayment(ThreadIndex).Text = AmtinHrs(ThreadIndex) + _MinsRatesQuery(_mins(ThreadIndex))
                _checkRun(ThreadIndex) = True
                If Not _bolPaid(ThreadIndex) Then 'check if already paid or not
                    lblUnpaidT(ThreadIndex).Text = lblPayment(ThreadIndex).Text
                End If
            End If
            
            elpsedT(ThreadIndex).Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                                             _hrs(ThreadIndex), _mins(ThreadIndex), _secs(ThreadIndex) Mod 60)
            ''check if client is already time
            'check if open time or limited
            If _tmpSetTime_(ThreadIndex) > 0 Then 'limited
                If _secs(ThreadIndex) >= _tmpSetTime_(ThreadIndex) Then
                    _setOut(ThreadIndex, True, lblPayment(ThreadIndex).Text)
                End If
            End If
            
        End If
        _start(ThreadIndex) += 1
    End Sub
    Private Sub _RatesTable()
        sqlSTR = "SELECT * FROM Rates ORDER BY PerMinutes ASC"
        ExecuteSQLQuery(sqlSTR)
        Do While sqlDr.Read
            _tCount += 1
            ReDim Preserve _tRates(_tCount), _mRates(_tCount)
            _tRates(_tCount) = sqlDr("PerMinutes")
            _mRates(_tRates(_tCount)) = sqlDr("Amounts")
            rList += sqlDr("PerMinutes") & ":" & sqlDr("Amounts") & ","
        Loop
        rList += "" & IsDisc

    End Sub
    Private Function _MinsRatesQuery(ByVal _minsUsed As Integer) As Integer
        _MinsRatesQuery = _mRates(_minsUsed)
        Return _MinsRatesQuery
    End Function


    Private Sub clientPanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles clientPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then 'user left click
            btn_OMenuS_rightclick.Show(Me, e.X, e.Y)
        End If
    End Sub

    Private Sub RestartAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartAllToolStripMenuItem.Click
        Dim x As Integer
        If MsgBox("Are you sure you want to RESTART ALL clients ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For x = 1 To 30
                If Not btn(x).Tag Is Nothing Then
                    client_restart(btn(x).Tag)
                End If
            Next
        End If
    End Sub

    Private Sub ShutdownAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownAllToolStripMenuItem.Click
        Dim x As Integer
        If MsgBox("Are you sure want to SHUTDOWN ALL clients ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For x = 1 To 30
                If Not btn(x).Tag Is Nothing Then
                    client_shutdown(btn(x).Tag)
                End If
            Next
        End If
    End Sub

    Private Sub UncheckAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UncheckAllToolStripMenuItem.Click
        For Each item In Me.clientPanel.Controls
            If TypeOf item Is Panel Then
                For Each panelitems In item.controls
                    If TypeOf panelitems Is GroupBox Then
                        For Each GroupBoxItems In panelitems.controls
                            If TypeOf GroupBoxItems Is CheckBox Then
                                If GroupBoxItems.checked Then GroupBoxItems.checked = False
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ExtendTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtendTimeToolStripMenuItem.Click
        FrmExtend.ShowDialog()
    End Sub

    Private Sub StopAndSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopAndSaveToolStripMenuItem.Click
        FrmSaveTimeClients.ShowDialog()
    End Sub

    Private Sub LoadSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadSaveToolStripMenuItem.Click
        FrmLoadTimeClients.ShowDialog()
    End Sub


    Private Sub clientPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles clientPanel.Paint

    End Sub

    Private Sub TransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        If MsgBox("Are you sure you want to RESTART the selected clients ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ' For x = 1 To 30
            If Not btn(btn_store.Find(AddressOf search_2).Index).Tag Is Nothing Then
                client_restart(btn(btn_store.Find(AddressOf search_2).Index).Tag)
            End If
            'Next
        End If
    End Sub

    Private Sub ShutdownClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownClientToolStripMenuItem.Click
        If MsgBox("Are you sure you want to SHUTDOWN the selected clients ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ' For x = 1 To 30
            If Not btn(btn_store.Find(AddressOf search_2).Index).Tag Is Nothing Then
                client_shutdown(btn(btn_store.Find(AddressOf search_2).Index).Tag)
            End If
            'Next
        End If
    End Sub
End Class