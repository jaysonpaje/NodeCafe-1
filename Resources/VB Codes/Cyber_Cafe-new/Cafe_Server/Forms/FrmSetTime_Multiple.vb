Imports System.Threading
Public Class FrmSetTime_Multiple

    Dim tmp_HRS As Double
    Dim tmp_MINS As Double
    Dim _tmpIndex As Integer
    Dim amountTopayHR As Double
    'Dim item As Object
    'Dim panelitems As Object
    'Dim GroupBoxItems As Object
    Private Sub btn_IN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IN.Click
        Dim _paidamnt As Integer
        For Each item In frmBG.clientPanel.Controls
            If TypeOf item Is Panel Then
                For Each panelitems In item.controls
                    If TypeOf panelitems Is GroupBox Then
                        For Each GroupBoxItems In panelitems.controls
                            If TypeOf GroupBoxItems Is CheckBox Then
                                If GroupBoxItems.checked Then
                                    _tmpIndex = GroupBoxItems.tag
                                    If btn(_tmpIndex).Tag.ToString <> "" Then
                                        timestart = DateTime.Now
                                        If Int(txthr.Text) > 0 Or Int(txtmin.Text) > 0 Then
                                            tmp_HRS = Val(txthr.Text)
                                            tmp_MINS = Val(txtmin.Text)
                                            If chckpaid.Checked Then
                                                _paidamnt = txtamount.Text
                                                _bolPaid(_tmpIndex) = True
                                            Else
                                                _paidamnt = 0
                                                _bolPaid(_tmpIndex) = False
                                            End If
                                        End If
                                        timeend = DateTime.Now.AddHours(txthr.Text).AddMinutes(txtmin.Text)
                                        If Val(txthr.Text) = 0 And Val(txtmin.Text) = 0 Then
                                            lblOutT(_tmpIndex).Text = ""
                                        Else
                                            lblOutT(_tmpIndex).Text = timeend.ToString("hh:mm" & " " & "tt")
                                        End If
                                        _setTime(_tmpIndex, Now, btn(_tmpIndex).Tag, _paidamnt, tmp_HRS, tmp_MINS, txtamount.Text)
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
        Me.Close()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
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
        'End If
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

    Private Sub btn_OUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OUT.Click
        Try
            If MsgBox("Are you sure you want to set this time out", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each item In frmBG.clientPanel.Controls
                    If TypeOf item Is Panel Then
                        For Each panelitems In item.controls
                            If TypeOf panelitems Is GroupBox Then
                                For Each GroupBoxItems In panelitems.controls
                                    If TypeOf GroupBoxItems Is CheckBox Then
                                        If GroupBoxItems.checked Then
                                            _tmpIndex = GroupBoxItems.tag
                                            _setOut(_tmpIndex, True, lblPayment(_tmpIndex).Text)
                                            elpsedT(_tmpIndex).Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                                                               0, _
                                                               0, _
                                                                0)
                                            lblInT(_tmpIndex).Text = ""
                                            lblOutT(_tmpIndex).Text = ""
                                            ' lblUnpaidT(_tmpIndex).Text = 0
                                            ' lblPayment(_tmpIndex).Text = 0
                                        End If
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Catch ex As Exception
            For Each item In frmBG.clientPanel.Controls
                If TypeOf item Is Panel Then
                    For Each panelitems In item.controls
                        If TypeOf panelitems Is GroupBox Then
                            For Each GroupBoxItems In panelitems.controls
                                If TypeOf GroupBoxItems Is CheckBox Then
                                    If GroupBoxItems.checked Then
                                        _setResume(_tmpIndex)
                                        _setOut(_tmpIndex, True, lblPayment(_tmpIndex).Text)
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End Try
        Me.Close()
    End Sub

    Private Sub btn_pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pause.Click
        For Each item In frmBG.clientPanel.Controls
            If TypeOf item Is Panel Then
                For Each panelitems In item.controls
                    If TypeOf panelitems Is GroupBox Then
                        For Each GroupBoxItems In panelitems.controls
                            If TypeOf GroupBoxItems Is CheckBox Then
                                If GroupBoxItems.checked Then
                                    _tmpIndex = GroupBoxItems.tag
                                    _setPause(_tmpIndex)
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btn_resume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_resume.Click
        Try
            For Each item In frmBG.clientPanel.Controls
                If TypeOf item Is Panel Then
                    For Each panelitems In item.controls
                        If TypeOf panelitems Is GroupBox Then
                            For Each GroupBoxItems In panelitems.controls
                                If TypeOf GroupBoxItems Is CheckBox Then
                                    If GroupBoxItems.checked Then
                                        _tmpIndex = GroupBoxItems.tag
                                        If Not (m_ThreadList(_tmpIndex).IsAlive) Then 'disconnected
                                            Dim objThreadClass As New clsThread(_tmpIndex, frmBG)
                                            Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
                                            objNewThread.IsBackground = True
                                            btn(_tmpIndex).ImageIndex = 2
                                            sqlSTR = "SELECT * FROM tbl_IN_clients " & _
                                                     "INNER JOIN tbl_PAUSE_clients ON tbl_IN_clients.in_id = tbl_PAUSE_clients.in_id " & _
                                                     "WHERE pc_no=" & _tmpIndex & " ORDER BY time_in DESC"
                                            ExecuteSQLQuery(sqlSTR)
                                            If sqlDr.Read Then
                                                If _secs(sqlDr("pc_no")) = 0 Then
                                                    _secs(sqlDr("pc_no")) = sqlDr("elapse_time")
                                                End If
                                                client_resume_dc(btn(_tmpIndex).Tag, _secs(sqlDr("pc_no")))
                                                objNewThread.Start()
                                                m_ThreadList.Item(_tmpIndex) = objNewThread
                                                sqlSTR = "UPDATE tbl_IN_clients SET status = 1 WHERE in_id =" & sqlDr(0)
                                                ExecuteSQLQuery(sqlSTR)
                                            Else
                                                MsgBox("Resume button : " & "No record")
                                            End If
                                        Else 'for pause
                                            _setResume(_tmpIndex)
                                        End If
                                        '
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            
        Catch ex As Exception
            MsgBox("Client can't be resume, because it's not been started !", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        txtamount.Text = str_Filter(txtamount, 48, 57, 0, 0)
        If txtamount.Text = "" Then txtamount.Text = 0
    End Sub
End Class