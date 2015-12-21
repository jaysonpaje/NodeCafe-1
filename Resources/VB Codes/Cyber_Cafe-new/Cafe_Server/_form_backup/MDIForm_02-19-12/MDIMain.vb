Imports System.Windows.Forms
Imports System.Threading
Public Class MDIMain
    Dim tim As Integer = 0
    Dim min As Integer = 0
    Dim hr As Integer = 0
    Dim tmp_time As String
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 30
            m_ThreadList.Add(Nothing)
        Next
        checkDatabase()
        With tsTimer
            panelTimer.Top = .Top - 15
            panelTimer.Left = .Left
        End With
        frmBG.MdiParent = Me
        frmBG.WindowState = FormWindowState.Maximized
        frmBG.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Send("NICO", btn(btn_store.Find(AddressOf search_2).Index).Tag)
    End Sub

    Private Sub btn_IN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN1.Click
        Try
            If btn(btn_store.Find(AddressOf search_2).Index).Tag.ToString <> "" Then
                _setTime(btn_store.Find(AddressOf search_2).Index, Now, btn(btn_store.Find(AddressOf search_2).Index).Tag)
                ' Me.txtend.Text = Format("hh:mm", DateTime.Now) - (900 / 60)
            End If
        Catch ex As Exception
            MsgBox("Client is not yet Starting", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btn_OUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OUT.Click
        Try
            If MsgBox("Are you sure you want to set this time out", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                _setOut(btn_store.Find(AddressOf search_2).Index)
            End If
        Catch ex As Exception
            _setResume(btn_store.Find(AddressOf search_2).Index)
            _setOut(btn_store.Find(AddressOf search_2).Index)
            'MsgBox("Time OUT : " & ex.ToString)
        End Try
    End Sub

    Private Sub btn_pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pause.Click
        _setPause(btn_store.Find(AddressOf search_2).Index)
    End Sub

    Private Sub btn_resume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_resume.Click
        '_setTime(btn_store.Find(AddressOf search_2).Index, 1800, btn(btn_store.Find(AddressOf search_2).Index).Tag)
        Try
            'MsgBox(m_ThreadList(btn_store.Find(AddressOf search_2).Index).IsAlive)
            If Not (m_ThreadList(btn_store.Find(AddressOf search_2).Index).IsAlive) Then
                Dim objThreadClass As New clsThread(btn_store.Find(AddressOf search_2).Index, Me)
                Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
                objNewThread.IsBackground = True
                objNewThread.Start()
                btn(btn_store.Find(AddressOf search_2).Index).ImageIndex = 2
                m_ThreadList.Item(btn_store.Find(AddressOf search_2).Index) = objNewThread
                'sqlSTR = "SELECT * FROM tbl_IN_clients WHERE pc_no=" & btn_store.Find(AddressOf search_2).Index & _
                '          " AND format(time_in,'MM/dd/yyyy') ='" & Format(Now, "MM/dd/yyyy") & "' ORDER BY time_in DESC"
                sqlSTR = "SELECT * FROM tbl_IN_clients " & _
                         "INNER JOIN tbl_PAUSE_clients ON tbl_IN_clients.in_id = tbl_PAUSE_clients.in_id " & _
                         "WHERE pc_no=" & btn_store.Find(AddressOf search_2).Index & _
                          " AND format(time_in,'MM/dd/yyyy') ='" & Format(Now, "MM/dd/yyyy") & "' ORDER BY time_in, pause_time DESC"
                ExecuteSQLQuery(sqlSTR)

                If sqlDr.Read Then
                    MsgBox("resume1")
                    'sqlSTR = "UPDATE tbl_IN_clients SET status = 1 WHERE in_id =" & sqlDr(0)
                    'ExecuteSQLQuery(sqlSTR)
                    '
                End If
            Else
                _setResume(btn_store.Find(AddressOf search_2).Index)
            End If
        Catch ex As Exception
            MsgBox("Client can't be resume, because it's not been started !", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btn_IN2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN2.Click
        Try
            If btn(btn_store.Find(AddressOf search_2).Index).Tag.ToString <> "" Then
                _setTime(btn_store.Find(AddressOf search_2).Index, Now, btn(btn_store.Find(AddressOf search_2).Index).Tag)
            End If
        Catch ex As Exception
            MsgBox("Client is not yet Starting", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btn_IN3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN3.Click
        Try
            If btn(btn_store.Find(AddressOf search_2).Index).Tag.ToString <> "" Then
                _setTime(btn_store.Find(AddressOf search_2).Index, Now, btn(btn_store.Find(AddressOf search_2).Index).Tag)
            End If
        Catch ex As Exception
            MsgBox("Client is not yet Starting", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btn_IN4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN4.Click
        Try
            If btn(btn_store.Find(AddressOf search_2).Index).Tag.ToString <> "" Then
                _setTime(btn_store.Find(AddressOf search_2).Index, Now, btn(btn_store.Find(AddressOf search_2).Index).Tag)
            End If
        Catch ex As Exception
            MsgBox("Client is not yet Starting", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btn_IN5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN5.Click
        Try
            If btn(btn_store.Find(AddressOf search_2).Index).Tag.ToString <> "" Then
                _setTime(btn_store.Find(AddressOf search_2).Index, Now, btn(btn_store.Find(AddressOf search_2).Index).Tag)
            End If
        Catch ex As Exception
            MsgBox("Client is not yet Starting", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub ReceiveThreadMessage(ByVal ThreadIndex As Integer, ByVal Counter As Integer)
        'MsgBox(ThreadIndex)
        'pc 1 = 1
        'pc 2= 2
        'pc 3= 3
        _secs(ThreadIndex) += 1
        ' MsgBox(_secs(ThreadIndex))
        If (_secs(ThreadIndex) Mod 60) = 0 Then
            _mins(ThreadIndex) += 1
            '_secs(ThreadIndex) = 0
        End If
        If _mins(ThreadIndex) >= 60 Then
            _hrs(ThreadIndex) += 1
            _mins(ThreadIndex) = 0
        End If
        If _hrs(ThreadIndex) <= 9 Then
            If _mins(ThreadIndex) <= 9 Then
                _elapseTime(ThreadIndex) = "0" & _hrs(ThreadIndex) & ":" & "0" & _mins(ThreadIndex)
            Else
                _elapseTime(ThreadIndex) = "0" & _hrs(ThreadIndex) & ":" & _mins(ThreadIndex)
            End If
        Else
            If _mins(ThreadIndex) <= 9 Then
                _elapseTime(ThreadIndex) = _hrs(ThreadIndex) & ":" & "0" & _mins(ThreadIndex)
            Else
                _elapseTime(ThreadIndex) = _hrs(ThreadIndex) & ":" & _mins(ThreadIndex)
            End If
        End If
        ' send notification to clients
        ' five minutes
        'MsgBox(_secs(ThreadIndex))
        If btn_store.Find(AddressOf search_2).Index = ThreadIndex Then
            txtelapse.Text = _elapseTime(ThreadIndex)
        End If
        If _timeSet(ThreadIndex) <= _secs(ThreadIndex) Then
            'send notification
            If _notify(ThreadIndex) = False Then
                'MsgBox("send notify")
                notify_Msg(btn(btn_store.Find(AddressOf search_2).Index).Tag)
                _notify(ThreadIndex) = True
            Else
                If (_timeSet(ThreadIndex) + 302) = _secs(ThreadIndex) Then
                    client_close(btn(btn_store.Find(AddressOf search_2).Index).Tag)
                    _setOut(ThreadIndex)
                End If
            End If
        End If
    End Sub

    Private Sub txtmin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmin.TextChanged
        txtmin.Text = str_Filter(txtmin, 48, 57, 0, 5)
    End Sub


    Private Sub txthr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthr.TextChanged
        txthr.Text = str_Filter(txthr, 48, 57, 0, 5)
    End Sub

    Private Sub btn_IN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN.Click
        Try
            Dim hrs, mins As Double
            If btn(btn_store.Find(AddressOf search_2).Index).Tag.ToString <> "" Then
                hrs = CDbl(txthr.Text * 3600)
                mins = CDbl(txtmin.Text * 60)
                _setTime(btn_store.Find(AddressOf search_2).Index, Now, btn(btn_store.Find(AddressOf search_2).Index).Tag)
            End If
        Catch ex As Exception
            MsgBox("Client is not yet Starting", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class
