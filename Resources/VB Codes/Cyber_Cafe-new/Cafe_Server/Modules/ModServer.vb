Imports System.Threading
Imports System.Net, System.Net.Sockets
Module ModServer
    Public Sub _setTime(ByVal Index As Integer, ByVal datenow As Date, ByVal client As Socket, ByVal PaidAmt As Double, ByVal Time_to_Cnsm_HR As Double, ByVal Time_to_Cnsm_MIN As Double, ByVal total_payment As Double)
        Dim objThreadClass As New clsThread(Index, frmBG)
        Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
        If m_ThreadList(Index) Is Nothing Then
            _tmpSetTime_(Index) = (Time_to_Cnsm_HR * 3600) + (Time_to_Cnsm_MIN * 60) 'set the counter time, reason, need to know if the client is already times up
            ' MsgBox(_tmpSetTime_(Index))
            objNewThread.IsBackground = True
            objNewThread.Start()
            btn(Index).ImageIndex = 2
            m_ThreadList.Item(Index) = objNewThread
            'setup the time start for thread
            lblInT(Index).Text = Now.ToShortTimeString
            '
            lblPayment(Index).Text = 0
            'SAVE DATA
            sqlSTR = "INSERT INTO tbl_IN_clients (pc_no, time_in, time_limit, time_out, status,IN_payment,Time_HR,Time_Min, total_payment, Date_IN) " & _
                     "VALUES (" & Index & ",'" & Now & "','" & datenow & "','" & datenow.AddSeconds(_tmpSetTime_(Index)) & "', " & 1 & "," & PaidAmt & "," & _
                                Time_to_Cnsm_HR & "," & Time_to_Cnsm_MIN & "," & total_payment & ",'" & Format(Now, "MM/dd/yyyy") & "')"
            ExecuteSQLQuery(sqlSTR)
            client_start(client, _tmpSetTime_(Index))
        Else
            MsgBox("Cannot start because it's still active ", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Public Sub _setOut(ByVal Index As Integer, ByVal sendToClient As Boolean, ByVal amnt As Double)
        Dim tmp_id As Integer
        Dim tmp_Payment As Double
        On Error Resume Next
        If Not m_ThreadList(Index) Is Nothing Then
            'If CType(m_ThreadList(Index), Thread).IsAlive Then
            ' m_ThreadList(Index).start()
            m_ThreadList(Index).abort()
            'End If
            m_ThreadList(Index) = Nothing
            _elapseTime(Index) = ""
            btn(Index).ImageIndex = 1
            sqlSTR = "SELECT  * " & _
                 "FROM tbl_SAVE_LOAD_clients " & _
                 "INNER JOIN tbl_IN_clients ON  tbl_SAVE_LOAD_clients.in_id = tbl_IN_clients.in_id " & _
                 "WHERE tbl_IN_clients.pc_no = " & Index & " And tbl_SAVE_LOAD_clients.status = 0 "
            ExecuteSQLQuery(sqlSTR)
            If sqlDr.Read Then

            Else
                sqlSTR = "SELECT * FROM " & _
                         "tbl_IN_clients " & _
                         "LEFT JOIN tbl_SAVE_LOAD_clients ON tbl_IN_clients.in_id = tbl_SAVE_LOAD_clients.in_id " & _
                         "WHERE tbl_IN_clients.pc_no=" & Index & " ORDER BY time_in DESC "
                ExecuteSQLQuery(sqlSTR)
                If sqlDr.Read Then

                End If
            End If
            tmp_id = sqlDr("tbl_IN_clients.in_id")
            tmp_Payment = sqlDr("In_payment")
            ' MsgBox(tmp_id & " " & tmp_Payment)
            If sqlDr("tbl_IN_clients.status") <> 2 Then 'find if its already pause
                sqlSTR = "INSERT INTO tbl_PAUSE_clients (in_id, pause_date, elapse_time) " & _
                    "VALUES (" & tmp_id & ",'" & Now & "'," & _secs(Index) & ")"
                ExecuteSQLQuery(sqlSTR)
            End If
            sqlSTR = "UPDATE tbl_IN_clients SET status = 0 WHERE in_id =" & tmp_id
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "INSERT INTO tbl_OUT_clients ( in_id, amnt_paid, time_out )" & _
                     "VALUES (" & tmp_id & "," & amnt & ",'" & Now & "')"
            ExecuteSQLQuery(sqlSTR)

            'End If
            _start(Index) = 0
            _secs(Index) = 0
            _mins(Index) = 0
            _hrs(Index) = 0
            _notify(Index) = False
            _tmpSetTime_(Index) = 0
            AmtinHrs(Index) = 0
            'lblUnpaidT(Index).Text = 0
            If sendToClient Then 'if it need to send to the client, because client can send a request set Time out on the server
                'if that happen there's no need to send to that the client is been Set to time out
                client_stop(btn(Index).Tag)
            End If
            'delete data if there is on the save load table
            sqlSTR = "DELETE FROM tbl_SAVE_LOAD_clients WHERE pc_no =" & Index & " AND status=0"
            ExecuteSQLQuery(sqlSTR)
        Else
            MsgBox("Client is not running", MsgBoxStyle.Critical)
        End If

    End Sub
    Public Sub _setPause(ByVal Index As Integer)
        Try
            If CType(m_ThreadList(Index), Thread).IsAlive Then
                Dim i As Integer
                _start(Index) = 0
                m_ThreadList(Index).Suspend()
                btn(Index).ImageIndex = 3
                sqlSTR = "SELECT * FROM tbl_IN_clients WHERE pc_no=" & Index & " ORDER BY time_in DESC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDr.Read Then
                    i = sqlDr(0)
                    sqlSTR = "UPDATE tbl_IN_clients SET status = 2 WHERE in_id =" & i
                    ExecuteSQLQuery(sqlSTR)
                    sqlSTR = "INSERT INTO tbl_PAUSE_clients (in_id, pause_date, elapse_time) " & _
                             "VALUES (" & i & ",'" & Now & "'," & _secs(Index) & ")"
                    ExecuteSQLQuery(sqlSTR)
                End If
                client_pause(btn(Index).Tag)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Client is not running, pause time", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub _setResume(ByVal Index As Integer)
        Try
            Dim i As Integer
            'started by the server
            'MsgBox(CType(m_ThreadList(Index), Thread).IsAlive)
            client_resume(btn(Index).Tag)
            m_ThreadList(Index).Resume()
            btn(Index).ImageIndex = 2

            sqlSTR = "SELECT * FROM tbl_IN_clients " & _
                     "INNER JOIN tbl_PAUSE_clients ON tbl_IN_clients.in_id = tbl_PAUSE_clients.in_id " & _
                     "WHERE pc_no=" & Index & " ORDER BY time_in, pause_date DESC"
            'MsgBox(sqlSTR)
            ExecuteSQLQuery(sqlSTR)

            If sqlDr.Read Then
                i = sqlDr("tbl_IN_clients.in_id")
                sqlSTR = "SELECT * FROM tbl_PAUSE_clients WHERE in_id =" & i & " ORDER BY pause_date DESC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDr.Read Then
                    sqlSTR = "INSERT INTO tbl_RESUME_clients (pause_id, resume_date) " & _
                             "VALUES(" & sqlDr(0) & ",'" & Now & "')"
                    ExecuteSQLQuery(sqlSTR)
                End If
                sqlSTR = "UPDATE tbl_IN_clients SET status = 1 WHERE in_id =" & i
                ExecuteSQLQuery(sqlSTR)
            End If
        Catch ex As Exception
            MsgBox("Module: ModeServer , Function : _setResume " & vbCrLf & ex.ToString)
        End Try

    End Sub
    Public Sub _setDc(ByVal Index As Integer)
        Try
            'started by the server
            Dim i As Integer
            If Not m_ThreadList(Index) Is Nothing Then
                m_ThreadList(Index).abort()
                m_ThreadList(Index) = Nothing
            End If
            btn(Index).ImageIndex = 0
            MsgBox("setDC")
            sqlSTR = "SELECT * FROM tbl_IN_clients WHERE pc_no=" & Index & " ORDER BY time_in DESC"
            ExecuteSQLQuery(sqlSTR)

            'set as pause
            If sqlDr.Read Then
                If sqlDr("status") = 1 Then
                    i = sqlDr(0)
                    '_dTime = sqlDr("time_in")
                    '_sTime = _sTime.Add(DateAndTime.Now.Subtract(_dTime))
                    '_tTime = (_sTime.Hours * 3600) + (_sTime.Minutes * 60)
                    sqlSTR = "INSERT INTO tbl_PAUSE_clients (in_id, pause_date, elapse_time) " & _
                             "VALUES (" & i & ",'" & Now & "'," & _secs(Index) & ")"
                    ExecuteSQLQuery(sqlSTR)
                    sqlSTR = "UPDATE tbl_IN_clients SET status = 4 WHERE in_id =" & i
                    ExecuteSQLQuery(sqlSTR)
                End If
            End If
        Catch ex As Exception
            MsgBox("Module: ModeServer , Function : _setDc " & vbCrLf & ex.ToString)
        End Try
    End Sub
    'for load
    Public Sub _setLoad(ByVal index As Integer, ByVal tmpinid As Integer)
        Dim objThreadClass As New clsThread(index, frmBG)
        Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
        If m_ThreadList(index) Is Nothing Then
            sqlSTR = "SELECT * FROM tbl_IN_clients WHERE in_id =" & tmpinid
            ExecuteSQLQuery(sqlSTR)
            If sqlDr.Read Then
                ' MsgBox(sqlDr("time_hr"))
                _tmpSetTime_(index) = Int((sqlDr("time_hr")) * 3600) + Int((sqlDr("time_min")) * 60) 'set the counter time, reason, need to know if the client is already times up
                lblInT(index).Text = Format(sqlDr("time_in"), "hh:mm tt")
                lblPayment(index).Text = 0
                elpsedT(index).Text = Format(_secs(index), "hh:mm")
            End If
            'MsgBox(_tmpSetTime_(index))
            objNewThread.IsBackground = True
            objNewThread.Start()
            btn(index).ImageIndex = 2
            m_ThreadList.Item(index) = objNewThread
            client_load(btn(index).Tag, _tmpSetTime_(index), _secs(index))
        End If
    End Sub
End Module
