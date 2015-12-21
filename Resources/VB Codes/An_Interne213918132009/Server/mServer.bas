Attribute VB_Name = "mServer"
Public db As ADODB.Connection

Public Sub Send_Data(Index As Integer, szMsg As String)
   On Error Resume Next

   Server.WinsockSubServer(Index).SendData szMsg
End Sub

Public Function Check_User_Password(intIndex As Integer, cDataReceived As String)
On Error GoTo err_Check_User_Password

    Dim strArray() As String
    Dim adoUserDetail As ADODB.Recordset
    
    Dim UserCode As String
    Dim TotalAmount As Currency
    Dim LeftAmount As Currency
    Dim TotalHour As Date
    Dim LeftHour As Date
    
    Set adoUserDetail = New ADODB.Recordset
    
    strArray = Split(cDataReceived, "--")
    
    With adoUserDetail
        .Open "SELECT * FROM [Users Details] " _
                & "WHERE UserCode = '" & strArray(1) & "' AND Password = '" & strArray(2) & "'", db, adOpenStatic, adLockOptimistic
              
        UserCode = !UserCode
        TotalAmount = !LeftAmount
        LeftAmount = !LeftAmount
        TotalHour = Format(DateAdd("n", !LeftHour, "00:00"), "h:m") 'LeftHour means the remaining hour left for the first or next login
        LeftHour = Format(DateAdd("n", !LeftHour, "00:00"), "h:m")
        
        If .RecordCount = 0 Then
            Server.lblStatus = "Invalid User or Password."
            Send_Data intIndex, INVALID_USER_PASSWORD
            DoEvents
        ElseIf ((!UsedAmount) >= CDate(!TotalAmount)) = True Then
            Server.lblStatus = "You do not have enough money left in your account."
            Send_Data intIndex, MESSAGES & Chr(1) & "You do not have enough money left in your account."
            DoEvents
        Else
            Unload Login
            Server.lblStatus = UserCode & " " & "Login Successfully."
            
            'Send_Data WinsockIndex, INTERNET_RECORD, UserCode | TotalHour -- UsedHour -- LeftHour -- RunningTime
            Send_Data intIndex, INTERNET_RECORD & Chr(1) & UserCode & "|" & CStr(Format(TotalHour, "h:m")) & "--" & "0.00" _
                        & "--" & CStr(Format(LeftHour, "h:m")) & "--" & 0
            DoEvents
            Update_Listview_Record strArray(0) & "--" & !UserCode & "--" _
                        & TotalAmount & "--" & "0.00" & "--" & LeftAmount & "--" _
                        & TotalHour & "--" & "0:00" & "--" & LeftHour & "--" & Now() & "--" _
                        & !Plan & "--" & !TimePlanID
            .Close
        End If
    End With
    
    Exit Function
    
err_Check_User_Password:
    If Err.Number = 3075 Then
            Server.lblStatus = "Invalid User or Password."
            Send_Data intIndex, INVALID_USER_PASSWORD
            DoEvents
    ElseIf Err.Number <> 0 Then
        Server.lblStatus = Err.Number & "-" & Err.Description & " Check_User_Password procedure call"
    End If
End Function

Public Sub Update_Listview_Record(cDataReceived As String)
On Error GoTo err_Update_Listview_Record

    Dim strArray() As String
    Dim intIndex As Integer
    
    
    strArray = Split(cDataReceived, "--")
    
    intIndex = Server.lvOnline.FindItem(strArray(0)).Index
   
    With Server.lvOnline.ListItems(intIndex)
   
        .SubItems(1) = strArray(1) 'User Code
        .SubItems(2) = Format(strArray(2), "##,##0.00") 'Total Amount
        .SubItems(3) = Format(strArray(3), "##,##0.00") 'Used Amount
        .SubItems(4) = Format(strArray(4), "##,##0.00") 'Left Amount
        .SubItems(5) = Format(strArray(5), "hh:mm") 'Total Hour
        .SubItems(6) = Format(strArray(6), "hh:mm") 'Used Hour
        .SubItems(7) = Format(strArray(7), "hh:mm") 'Left Hour
        .SubItems(8) = strArray(8) 'Time In
        .SubItems(9) = strArray(9) 'Time Plan
        .SubItems(10) = strArray(10) 'Time Plan ID
    End With
    
    Exit Sub
    
err_Update_Listview_Record:
    lblStatus = Err.Number & "-" & Err.Description & " Update_Listview_Record procedure call"
End Sub

Public Function ChargePerHour(TimePlanID As Integer)
On Error GoTo err_ChargePerHour

'   adoTimePlan.Open "SELECT * FROM [Time Plan Query]
'   WHERE TimePlanID=" & lvOnline.ListItems(intIndex).SubItems(13) & " AND
'   From<=#9:26:00 AM# AND To>=#9:26:00 AM#", db, adOpenStatic, adLockOptimistic

    Dim adoTimePlan As ADODB.Recordset
    
    Set adoTimePlan = New ADODB.Recordset
    
    With adoTimePlan
        adoTimePlan.Open "SELECT * FROM [Time Plan Query] " _
            & "WHERE TimePlanID=" & TimePlanID & " AND " _
            & "[From]<=#" & Time() & "# AND [To]>=#" & Time() & "#", db, adOpenStatic, adLockOptimistic
        
        If .RecordCount > 0 Then
            ChargePerHour = !Amount
        Else
            ChargePerHour = 15
        End If
        
        .Close
    End With
    
    Exit Function
    
err_ChargePerHour:
    lblStatus = Err.Number & "-" & Err.Description & " Received_Data procedure call"
End Function

'Function that return the value of a certain field
Public Function getValueAt(ByVal srcSQL As String, ByVal whichField As String) As String
    Dim RS As New Recordset
    
    RS.CursorLocation = adUseClient
    RS.Open srcSQL, db, adOpenStatic, adLockReadOnly
    If RS.RecordCount > 0 Then getValueAt = RS.Fields(whichField)
    
    Set RS = Nothing
End Function
