Imports System.Threading
Public Class FrmSetTime
    Public tmp_HRS As Integer
    Public tmp_MINS As Integer
    Dim amountTopayHR As Double
    Private Sub FrmSetTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txthr.Focus()

        txthr.Text = 0
        txtmin.Text = 0
        txtamount.Text = 0
        chckpaid.Checked = False
        chbox1.Checked = False
        chbox2.Checked = False
        chbox3.Checked = False
        chbox4.Checked = False
        chbox5.Checked = False
        Labelpc.Text = pc_name
        Me.Height = 335
        Me.Width = 367
        '_tmpID = btn_store.Find(AddressOf search_2).Index
        'lblPayment
    End Sub

    Private Sub btn_IN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN.Click
        Dim _paidamnt As Integer
        Try
            If btn(btn_store.Find(AddressOf search_2).Index).Tag.ToString <> "" Then
                timestart = DateTime.Now
                If Int(txthr.Text) > 0 Or Int(txtmin.Text) > 0 Then
                    tmp_HRS = Val(txthr.Text)
                    tmp_MINS = Val(txtmin.Text)
                    If chckpaid.Checked Then
                        _paidamnt = txtamount.Text
                        _bolPaid(btn_store.Find(AddressOf search_2).Index) = True
                    Else
                        _paidamnt = 0
                        _bolPaid(btn_store.Find(AddressOf search_2).Index) = False
                    End If
                End If
                lblUnpaidT(btn_store.Find(AddressOf search_2).Index).Text = 0
                timeend = DateTime.Now.AddHours(txthr.Text).AddMinutes(txtmin.Text)

                If Val(txthr.Text) = 0 And Val(txtmin.Text) = 0 Then
                    lblOutT(btn_store.Find(AddressOf search_2).Index).Text = ""
                Else
                    lblOutT(btn_store.Find(AddressOf search_2).Index).Text = timeend.ToString("hh:mm" & " " & "tt")
                End If
                _setTime(btn_store.Find(AddressOf search_2).Index, Now, btn(btn_store.Find(AddressOf search_2).Index).Tag, _paidamnt, tmp_HRS, tmp_MINS, txtamount.Text)
                'MsgBox(lblOutT)
                amountTopayHR = 0
                Me.Close()
            End If
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            MsgBox("Client is not yet Starting", MsgBoxStyle.Exclamation)
            Me.Close()
        End Try
    End Sub

    Private Sub btn_pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pause.Click
        _setPause(btn_store.Find(AddressOf search_2).Index)
    End Sub

    Public Sub btn_resume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_resume.Click
        Try
            If Not (m_ThreadList(btn_store.Find(AddressOf search_2).Index).IsAlive) Then 'server or client disconnected
                Dim objThreadClass As New clsThread(btn_store.Find(AddressOf search_2).Index, frmBG)
                Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
                objNewThread.IsBackground = True
                btn(btn_store.Find(AddressOf search_2).Index).ImageIndex = 2
                sqlSTR = "SELECT * FROM tbl_IN_clients " & _
                         "INNER JOIN tbl_PAUSE_clients ON tbl_IN_clients.in_id = tbl_PAUSE_clients.in_id " & _
                         "WHERE pc_no=" & btn_store.Find(AddressOf search_2).Index & " ORDER BY time_in DESC"
                ExecuteSQLQuery(sqlSTR)
                If sqlDr.Read Then
                    If _secs(sqlDr("pc_no")) = 0 Then
                        _secs(sqlDr("pc_no")) = sqlDr("elapse_time")
                    End If
                    client_resume_dc(btn(btn_store.Find(AddressOf search_2).Index).Tag, _secs(sqlDr("pc_no")))
                    objNewThread.Start()
                    m_ThreadList.Item(btn_store.Find(AddressOf search_2).Index) = objNewThread
                    sqlSTR = "UPDATE tbl_IN_clients SET status = 1 WHERE in_id =" & sqlDr(0)
                    ExecuteSQLQuery(sqlSTR)
                Else
                    MsgBox("Resume button : " & "No record")
                End If
            Else 'for pause, server is not closed
                _setResume(btn_store.Find(AddressOf search_2).Index)
                MsgBox("Pause")
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Client can't be resume, because it's not been started !", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub btn_OUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OUT.Click
        Try
            If chckpaid.Checked Then
                'sqlSTR = "SELECT Amounts FROM Rates WHERE PerMinutes= " & _mins(ThreadIndex)
                'ExecuteSQLQuery(sqlSTR)
                'If sqlDr.Read Then
                '    AmtinMin(ThreadIndex) = sqlDr("Amounts")

                '    lblPayment(ThreadIndex).Text = AmtinHr(ThreadIndex) + AmtinMin(ThreadIndex)
                'End If
            End If
            If MsgBox("Are you sure you want to set this time out", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                _setOut(btn_store.Find(AddressOf search_2).Index, True, IIf(chckpaid.Checked = True, txtamount.Text, lblPayment(btn_store.Find(AddressOf search_2).Index).Text))
                'elpsedT(_tmpID).Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                '                   0, _
                '                   0, _
                '                    0)
                'lblInT(_tmpID).Text = ""
                'lblOutT(_tmpID).Text = ""
                ' lblUnpaidT(_tmpID).Text = 0
                ' lblPayment(_tmpID).Text = 0
            End If
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            _setResume(btn_store.Find(AddressOf search_2).Index)
            _setOut(btn_store.Find(AddressOf search_2).Index, True, IIf(chckpaid.Checked = True, txtamount.Text, lblPayment(btn_store.Find(AddressOf search_2).Index).Text))
        End Try
        Me.Close()
    End Sub

    Private Sub txthr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthr.TextChanged
        txthr.Text = str_Filter(txthr, 48, 57, 0, 0)
        If txthr.Text = "" Then txthr.Text = 0
        If txtmin.Text.ToString = "" Then
            txtamount.Text = _checkHr(txthr.Text)
        Else
            txtamount.Text = _checkHr(txthr.Text) + _mRates(txtmin.Text)
        End If
        'txtamount.Text = _checkHr(txthr.Text) + _mRates(txtmin.Text)
        'If txthr.Text = 0 Then
        '    txtamount.Text = 0

        'ElseIf String.IsNullOrEmpty(txthr.Text) Then
        '    txthr.Text = 0
        '    amountTopayHR = 0
        '    txtamount.Text = amountTopayHR + amountTopayMin
        'ElseIf txthr.Text = 1 Then
        '    amountTopayHR = AmtinHr
        '    txtamount.Text = amountTopayHR
        'ElseIf txthr.Text = 2 Then
        '    amountTopayHR = (AmtinHr * 2 - IsDisc).ToString
        '    txtamount.Text = amountTopayHR
        'ElseIf txthr.Text = 3 Then
        '    amountTopayHR = (AmtinHr * 3 - IsDisc).ToString
        '    txtamount.Text = amountTopayHR
        'ElseIf txthr.Text = 4 Then
        '    amountTopayHR = (AmtinHr * 4 - (IsDisc * 2)).ToString
        '    txtamount.Text = amountTopayHR
        'End If

        'If Val(txthr.Text) > 4 Then
        '    If Val(txthr.Text) Mod 2 = 0 Then
        '        amountTopayHR = Val(txthr.Text) / 2 * (AmtinHr * 2 - IsDisc)
        '        txtamount.Text = amountTopayHR
        '    Else

        '        amountTopayHR = Math.Floor(Val(txthr.Text) / 2) * (AmtinHr * 2 - IsDisc)
        '        amountTopayHR = amountTopayHR + AmtinHr
        '        txtamount.Text = amountTopayHR
        '    End If
        'End If

    End Sub

    Private Sub txtmin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmin.TextChanged
        'txtmin.Text = str_Filter(txtmin, 48, 57, 0, 0)
        txtmin.Text = str_Filter(txtmin, 48, 57, 0, 0)
        If txtmin.Text = "" Then txtmin.Text = 0
        If Int(txtmin.Text) <> 0 Then
            txtamount.Text = _checkHr(txthr.Text) + _mRates(txtmin.Text)
        Else
            txtamount.Text = _checkHr(txthr.Text)
        End If

        'Dim tmp_amnt As Double
        'sqlSTR = "SELECT * FROM Rates WHERE PerMinutes=" & txtmin.Text
        'ExecuteSQLQuery(sqlSTR)
        'If sqlDr.Read Then
        '    tmp_amnt = sqlDr("Amounts")
        '    amountTopayMin = tmp_amnt
        '    txtamount.Text = amountTopayHR + amountTopayMin
        'Else
        '    txtamount.Text = amountTopayHR
        '    'If txtmin.Text = 0 Then
        '    '    txtamount.Text = 0
        '    'ElseIf String.IsNullOrEmpty(txtmin.Text) Then
        '    '    txtmin.Text = 0
        '    '    amountTopayMin = 0
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 5 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 10 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 15 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 20 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 25 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 30 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 35 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 40 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 45 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 50 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text >= 55 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'ElseIf txtmin.Text = 60 Then
        '    '    amountTopayMin = tmp_amnt
        '    '    txtamount.Text = amountTopayHR + amountTopayMin
        '    'End If
        'End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        txthr.Text = 0
        txtmin.Text = 0
        Me.Close()
    End Sub

    Private Sub chbox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbox1.CheckedChanged
        If chbox1.Checked Then
            checkbox_uncheck(True, False, False, False, False)
            txthr.Text = 0
            txtmin.Text = 15
        Else
            txtmin.Text = 0
        End If
    End Sub

    Private Sub chbox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbox2.CheckedChanged
        If chbox2.Checked Then
            checkbox_uncheck(False, True, False, False, False)
            txthr.Text = 0
            txtmin.Text = 30
        Else
            txtmin.Text = 0
        End If
    End Sub

    Private Sub chbox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbox3.CheckedChanged
        If chbox3.Checked Then
            checkbox_uncheck(False, False, True, False, False)
            txthr.Text = 1
            txtmin.Text = 0
        Else
            txthr.Text = 0
        End If
    End Sub

    Private Sub chbox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbox4.CheckedChanged
        If chbox4.Checked Then
            checkbox_uncheck(False, False, False, True, False)
            txthr.Text = 2
            txtmin.Text = 0
        Else
            txthr.Text = 0
        End If
    End Sub

    Private Sub chbox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbox5.CheckedChanged
        If chbox5.Checked Then
            checkbox_uncheck(False, False, False, False, True)
            txthr.Text = 3
            txtmin.Text = 0
        Else
            txthr.Text = 0
        End If
    End Sub
    Private Sub checkbox_uncheck(ByVal chb1 As Boolean, ByVal chb2 As Boolean, ByVal chb3 As Boolean, ByVal chb4 As Boolean, ByVal chb5 As Boolean)
        chbox1.Checked = chb1
        chbox2.Checked = chb2
        chbox3.Checked = chb3
        chbox4.Checked = chb4
        chbox5.Checked = chb5
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim x As Integer
        x = btn_store.Find(AddressOf search_2).Index
        _hrs(x) = ((_secs(x) - _secs(x) Mod 3600 Mod 60) _
                            - (_secs(x) Mod 3600 - _secs(x) Mod 3600 Mod 60)) / 3600
        _mins(x) = (_secs(x) Mod 3600 - _secs(x) Mod 3600 Mod 60) / 60
        txtelapse.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                                         _hrs(x), _mins(x), _secs(x) Mod 60)
    End Sub
    'Private Function _checkHr(ByVal hr As Double) As Double
    '    '  MsgBox(hr)
    '    If hr = 1 Then
    '        amountTopayHR = AmtinHr
    '    ElseIf hr = 2 Then
    '        amountTopayHR = (AmtinHr * 2 - IsDisc).ToString
    '    ElseIf hr = 3 Then
    '        amountTopayHR = (AmtinHr * 3 - IsDisc).ToString
    '    ElseIf hr = 4 Then
    '        amountTopayHR = (AmtinHr * 4 - (IsDisc * 2)).ToString
    '    Else
    '        amountTopayHR = 0
    '    End If
    '    If Val(hr) > 4 Then
    '        If Val(hr) Mod 2 = 0 Then
    '            amountTopayHR = Val(hr) / 2 * (hr * 2 - IsDisc)
    '        Else
    '            amountTopayHR = (Math.Floor(Val(hr) / 2) * (AmtinHr * 2 - IsDisc)) + AmtinHr
    '            'amountTopayHR = amountTopayHR + AmtinHr
    '        End If
    '    End If
    '    Return amountTopayHR
    'End Function

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        txtamount.Text = str_Filter(txtamount, 48, 57, 0, 0)
        If txtamount.Text = "" Then txtamount.Text = 0
    End Sub
End Class