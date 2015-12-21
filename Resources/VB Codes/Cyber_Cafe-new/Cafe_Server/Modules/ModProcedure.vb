Imports System.Data.OleDb
Module ModProcedure
    Dim Delimeter As String
    Public Sub form_show(ByVal frm As Form, ByVal x As Integer, ByVal y As Integer)
        frm.Top = x
        frm.Left = y
        frm.ShowDialog()

    End Sub

    Public Sub FillListView(ByRef lvList As ListView, ByRef myData As OleDbDataReader)
        Dim itmListItem As ListViewItem


        Dim strValue As String
        lvList.Items.Clear()
        Do While myData.Read
            itmListItem = New ListViewItem()
            strValue = IIf(myData.IsDBNull(0), "", myData.GetValue(0))
            itmListItem.Text = strValue

            For shtCntr = 1 To myData.FieldCount() - 1
                If myData.IsDBNull(shtCntr) Then
                    itmListItem.SubItems.Add("")
                Else
                    itmListItem.SubItems.Add(myData.GetValue(shtCntr))
                End If
            Next shtCntr

            lvList.Items.Add(itmListItem)
        Loop
    End Sub

    Public Function str_Filter(ByVal Text As TextBox, ByVal ascKey1 As Integer, ByVal ascKey2 As Integer, ByVal ascKey3 As Integer, ByVal N_Repeat As Integer)
        On Error Resume Next
        '-----function dump all strings except

        Dim X As Long
        Dim intStr As String
        Dim NumberToRepeatCharacter As Integer

        'MsgBox(Chr(Asc(Text.Text)))
        'MsgBox(Asc(Text.Text))
        For X = 1 To Len(Text.Text)         'asckey1                                asckey2                              asckey3
            If Asc(Mid((Text.Text), X, 1)) >= ascKey1 And Asc(Mid((Text.Text), X, 1)) <= ascKey2 Or Asc(Mid(Text.Text, X, 1)) = ascKey3 Then
            Else
                Delimeter = Chr(Asc(Mid(Text.Text, X, 1)))
                'MsgBox(Delimeter)
            End If
        Next
        intStr = ""
        For X = 1 To Len(Text.Text)
            If N_Repeat > 0 Then
                If Asc(Mid(Text.Text, X, 1)) = ascKey3 Then
                    If NumberToRepeatCharacter >= N_Repeat Then
                        SendKeys.Send("{END}")
                        Exit For
                    End If
                    NumberToRepeatCharacter = NumberToRepeatCharacter + 1
                End If
            End If
            'If NumberToRepeatCharacter <> N_Repeat Then
            If Mid(Text.Text, X, 1) <> Delimeter Then
                intStr = intStr & Mid(Text.Text, X, 1)
                'NumberToRepeatCharacter = NumberToRepeatCharacter + 1
            Else
                'can be uncomment if you want
                'SendKeys.Send("{END}")
            End If
            ' Else
            ' SendKeys.Send("{END}")
            ' End If

            'NumberToRepeatCharacter = X
        Next
        'MsgBox(NumberToRepeatCharacter)
        str_Filter = intStr
    End Function
    Public Function _checkHr(ByVal hr As Double) As Double
        '  MsgBox(hr)
        Dim amountTopayHR As Integer
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
End Module
