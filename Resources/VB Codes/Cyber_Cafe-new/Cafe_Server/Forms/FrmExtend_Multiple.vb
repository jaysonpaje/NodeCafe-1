Public Class FrmExtend_Multiple
    Dim _tmpIndex As Integer
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim xtmp As Integer
        For Each item In frmBG.clientPanel.Controls
            If TypeOf item Is Panel Then
                For Each panelitems In item.controls
                    If TypeOf panelitems Is GroupBox Then
                        For Each GroupBoxItems In panelitems.controls
                            If TypeOf GroupBoxItems Is CheckBox Then
                                If GroupBoxItems.checked Then
                                    _tmpIndex = GroupBoxItems.tag
                                    If rbExtend.Checked Then 'extend
                                        If xtmp > 0 And _tmpSetTime_(_tmpIndex) <> xtmp Then

                                        End If
                                    ElseIf rbChange.Checked Then

                                    Else

                                    End If

                                    xtmp = _tmpSetTime_(_tmpIndex)
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub FrmExtend_Multiple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each item In frmBG.clientPanel.Controls
            If TypeOf item Is Panel Then
                For Each panelitems In item.controls
                    If TypeOf panelitems Is GroupBox Then
                        For Each GroupBoxItems In panelitems.controls
                            If TypeOf GroupBoxItems Is CheckBox Then
                                If GroupBoxItems.checked Then
                                    _tmpIndex = GroupBoxItems.tag
                                    Exit Sub
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _hrs(_tmpIndex) = ((_secs(_tmpIndex) - _secs(_tmpIndex) Mod 3600 Mod 60) _
                            - (_secs(_tmpIndex) Mod 3600 - _secs(_tmpIndex) Mod 3600 Mod 60)) / 3600
        _mins(_tmpIndex) = (_secs(_tmpIndex) Mod 3600 - _secs(_tmpIndex) Mod 3600 Mod 60) / 60
        txtelapse.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                                         _hrs(_tmpIndex), _mins(_tmpIndex), _secs(_tmpIndex) Mod 60)
    End Sub
End Class