Public Class FrmExtend
    Dim x As Integer
    Dim _tmpHr, _tmpHr1, _tmpHr2 As Double
    Dim _tmpMin, _tmpMin1, _tmpMin2 As Double
    Dim _tmpTotal1, _tmpTotal2 As Double
    Dim amountTopayHR As Double
    Dim amount, amount1, amount2 As Double
    Dim _tmpINpayment As Double
    Dim _paid As String
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _hrs(x) = ((_secs(x) - _secs(x) Mod 3600 Mod 60) _
                            - (_secs(x) Mod 3600 - _secs(x) Mod 3600 Mod 60)) / 3600
        _mins(x) = (_secs(x) Mod 3600 - _secs(x) Mod 3600 Mod 60) / 60
        txtelapse.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                                         _hrs(x), _mins(x), _secs(x) Mod 60)
    End Sub

    Private Sub FrmExtend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get time
        amountTopayHR = 0
        rbExtend.Checked = False
        rbChange.Checked = False
        x = btn_store.Find(AddressOf search_2).Index
        sqlSTR = "SELECT * FROM tbl_IN_clients WHERE pc_no =" & x & " ORDER BY time_in DESC"
        ExecuteSQLQuery(sqlSTR)
        If sqlDr.Read Then
            txtin_id.Text = sqlDr("in_id")
            txthr.Text = sqlDr("Time_HR")
            txtmin.Text = sqlDr("Time_MIN")
            _tmpINpayment = sqlDr("IN_Payment")
            _tmpHr = txthr.Text
            _tmpMin = txtmin.Text
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If rbExtend.Checked Then 'extend time
            If Int(txthr.Text) = 0 And Int(txtmin.Text) = 0 Then 'check if extend is > 1
                MsgBox("Cannot Set Extend Time in ZERO !!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                'this can be simplified using array loop =))
                _tmpTotal1 = ((Int(_tmpHr + txthr.Text) * 3600) + Int(_tmpMin + txtmin.Text) * 60)
                _tmpHr1 = ((_tmpTotal1 - _tmpTotal1 Mod 3600 Mod 60) _
                        - (_tmpTotal1 Mod 3600 - _tmpTotal1 Mod 3600 Mod 60)) / 3600
                _tmpMin1 = (_tmpTotal1 Mod 3600 - _tmpTotal1 Mod 3600 Mod 60) / 60
                'MsgBox(txthr.Text & " " & txtmin.Text)
                ' MsgBox(_tmpSetTime_(x))
                _tmpSetTime_(x) += Int(txthr.Text * 3600) + Int(txtmin.Text * 60) 're-assign so that it can detect the timeout 
                'MsgBox(_tmpSetTime_(x))
                amount1 = _checkHr(_tmpHr1) + _mRates(_tmpMin1) 'total payment

                'get the exact amount to be added so that we can query the remaining balance
                _tmpTotal2 = (Int(_tmpHr * 3600) + Int(_tmpMin * 60))
                _tmpHr2 = ((_tmpTotal2 - _tmpTotal2 Mod 3600 Mod 60) _
                       - (_tmpTotal2 Mod 3600 - _tmpTotal2 Mod 3600 Mod 60)) / 3600
                _tmpMin2 = (_tmpTotal2 Mod 3600 - _tmpTotal2 Mod 3600 Mod 60) / 60
                amount2 = _checkHr(_tmpHr2) + _mRates(_tmpMin2) 'total payment
                'MsgBox(amount1 & " " & amount2)
                If amount1 > amount2 Then
                    amount = amount1 - amount2
                ElseIf amount1 = amount2 Then
                    amount = 0
                Else
                    amount = txtamount.Text
                End If
                'MsgBox(amount1 - amount & " " & amount1)
                sqlSTR = "UPDATE tbl_IN_clients SET time_hr =" & _tmpHr1 & "," & _
                         "time_min=" & _tmpMin1 & "," & _
                         "time_out=" & "time_in" & "," & _
                         "total_payment =" & IIf(chckpaid.Checked, amount1 - amount, amount1) & _
                         " WHERE in_id =" & txtin_id.Text
                ExecuteSQLQuery(sqlSTR)

                If chckpaid.Checked Then
                    _paid = "yes"
                    'show unpaid amount
                    If _tmpINpayment = 0 Then
                        lblUnpaidT(x).Text = amount1 - amount
                    End If
                    _bolPaid(x) = True
                Else
                    _paid = "no"
                    lblUnpaidT(x).Text = Int(lblUnpaidT(x).Text) + amount
                End If
                'insert data to extend time
                sqlSTR = "INSERT INTO tbl_EXTEND_time ( in_id, extend_hr, extend_min, extend_payment,paid ) " & _
                         "VALUES (" & txtin_id.Text & "," & txthr.Text & "," & _
                                     txtmin.Text & "," & amount & "," & _paid & ")"
                ExecuteSQLQuery(sqlSTR)
            End If
        ElseIf rbChange.Checked Then 'change time
            If Int((txthr.Text * 3600) + (txtmin.Text * 60)) < Int(_secs(x)) Then
                MsgBox("Cannot Set less than the running time", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf Int((txthr.Text * 3600) + (txtmin.Text * 60)) >= Int((_tmpHr * 3600) + Int(_tmpMin * 60)) Then
                MsgBox("Cannot Re-set the time, Set Time is either HIGHER or EQUAL the current set time, go to EXTEND TIME to change !!", MsgBoxStyle.Information)
                Exit Sub
            Else
                sqlSTR = "UPDATE tbl_IN_clients SET time_hr =" & txthr.Text & "," & _
                         "time_min=" & txtmin.Text & "," & _
                         "time_out=" & "time_in" & "," & _
                         "total_payment = " & txtamount.Text & _
                         " WHERE in_id =" & txtin_id.Text
                ExecuteSQLQuery(sqlSTR)
                _tmpSetTime_(x) = (txthr.Text * 3600) + (txtmin.Text * 60) 're-assign so that it can detect the timeout 
            End If
        Else ' no selected
            MsgBox("Cannot save, choose from Extend Time or Change Time ", MsgBoxStyle.Information)
            Exit Sub
        End If
        send_extend_time(btn(x).Tag, _tmpSetTime_(x))
        Me.Close()
    End Sub

    Private Sub rbExtend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExtend.CheckedChanged
        txthr.Text = 0
        txtmin.Text = 0
    End Sub

    Private Sub txthr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthr.TextChanged
        txthr.Text = str_Filter(txthr, 48, 57, 0, 0)
        If txtmin.Text.ToString = "" Then
            txtamount.Text = _checkHr(txthr.Text)
        Else
            txtamount.Text = _checkHr(txthr.Text) + _mRates(txtmin.Text)
        End If
        'If txthr.Text = 0 Then
        '    txtamount.Text = 0
        '    amountTopayHR = 0
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
        ' amountTopayMin = _mRates(txtmin.Text)
        'txtamount.Text = amountTopayHR + amountTopayMin
        '
        'this can be simplified using array loop =))
        _tmpTotal1 = ((Int(_tmpHr + txthr.Text) * 3600) + Int(_tmpMin + txtmin.Text) * 60)
        _tmpHr1 = ((_tmpTotal1 - _tmpTotal1 Mod 3600 Mod 60) _
                - (_tmpTotal1 Mod 3600 - _tmpTotal1 Mod 3600 Mod 60)) / 3600
        _tmpMin1 = (_tmpTotal1 Mod 3600 - _tmpTotal1 Mod 3600 Mod 60) / 60
        ' _tmpSetTime_(x) += Int(txthr.Text * 3600) + Int(txtmin.Text * 60) 're-assign so that it can detect the timeout 
        amount1 = _checkHr(_tmpHr1) + _mRates(_tmpMin1) 'total payment

        'get the exact amount to be added so that we can query the remaining balance
        _tmpTotal2 = (Int(_tmpHr * 3600) + Int(_tmpMin * 60))
        _tmpHr2 = ((_tmpTotal2 - _tmpTotal2 Mod 3600 Mod 60) _
               - (_tmpTotal2 Mod 3600 - _tmpTotal2 Mod 3600 Mod 60)) / 3600
        _tmpMin2 = (_tmpTotal2 Mod 3600 - _tmpTotal2 Mod 3600 Mod 60) / 60
        amount2 = _checkHr(_tmpHr2) + _mRates(_tmpMin2) 'total payment
        'MsgBox(amount1 & " " & amount2)
        If amount1 > amount2 Then
            amount = amount1 - amount2
        ElseIf amount1 = amount2 Then
            amount = 0
        Else
            amount = txtamount.Text
        End If
        txtamount.Text = amount
    End Sub

    Private Sub rbChange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbChange.CheckedChanged
        txthr.Text = _tmpHr
        txtmin.Text = _tmpMin
    End Sub
    Private Function _checkHr(ByVal hr As Double) As Double
        '  MsgBox(hr)
        If hr = 1 Then
            amountTopayHR = AmtinHr
        ElseIf hr = 2 Then
            amountTopayHR = (AmtinHr * 2 - IsDisc).ToString
        ElseIf hr = 3 Then
            amountTopayHR = (AmtinHr * 3 - IsDisc).ToString
        ElseIf hr = 4 Then
            amountTopayHR = (AmtinHr * 4 - (IsDisc * 2)).ToString
        Else
            amountTopayHR = 0
        End If
        If Val(hr) > 4 Then
            If Val(hr) Mod 2 = 0 Then
                amountTopayHR = Val(hr) / 2 * (hr * 2 - IsDisc)
            Else
                amountTopayHR = (Math.Floor(Val(hr) / 2) * (AmtinHr * 2 - IsDisc)) + AmtinHr
                'amountTopayHR = amountTopayHR + AmtinHr
            End If
        End If
        Return amountTopayHR
    End Function
End Class