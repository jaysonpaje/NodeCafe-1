Attribute VB_Name = "PassGen"
Option Explicit

Public Enum CKeyType
 Alphabetic = 0
 Numeric = 1
 Special_Characters = 2
End Enum

Private NumIDUniques As Integer

Public Function GenerateUsersPasswords(List As ListView, NumPasswords As Long, Mask As String, TimePlanID As Integer, Optional ClearList As Boolean = True, Optional GenerateCustomKey As Boolean = False, Optional KeyMask As String, Optional KeyType As CKeyType)
    Dim i As Integer
    Dim j As Integer
    Dim z As Integer
    Dim tmpMask As String
    Dim hMask As String

    Dim db As ADODB.Connection
    Dim rstUser As ADODB.Recordset
    Dim rstUserDetail As ADODB.Recordset
    
    Set db = New ADODB.Connection
    
    db.CursorLocation = adUseClient
    db.Open "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\Internet Record.mdb;Jet OLEDB:Database Password=jaypee;"

    Set rstUser = New ADODB.Recordset
    rstUser.Open "SELECT * From [Users] Where [UserCode] = '0'", db, adOpenStatic, adLockOptimistic

    Set rstUserDetail = New ADODB.Recordset
    rstUserDetail.Open "SELECT * From [Details] Where [UserCode] = '0'", db, adOpenStatic, adLockOptimistic

    'Good idea to clear list so we dont get some kind of
    'overflow error
'    If ClearList Then List.Clear
    
    'How many passwords were the same?
    NumIDUniques = 0
    
    'Get a random seed value
    Randomize
    
    'How many passwords do we want to create?
    For j = 0 To NumPasswords - 1
        'Reset this to "" or it will double like, Password1Password2
        'we want Password1
        '        Password2
        hMask = vbNullString
        'Step through every character in the string
        For i = 1 To (Len(Mask))
            'We step through the characters according to where we are in the loop
            tmpMask$ = Mid$(Mask, i, 1)
            'If the character is "#" then we want a random number
            If tmpMask$ = "#" Then
                 'Create a random number
                 tmpMask$ = CInt(Rnd * 9)
                 'Add to our hold mask(just a temp string)
                 hMask$ = hMask$ & tmpMask$
                'If the character is "X" then we want a random character
            ElseIf tmpMask$ = "X" Then
                 'Create a random character
                 tmpMask$ = Chr((Int((90 - 65 + 1) * Rnd + 65)))
                 'Add to our hold mask
                 hMask$ = hMask$ & tmpMask$
                'New the Special Characters
            ElseIf tmpMask$ = "O" Then
                 'Create a random "Special" Character
                 'Will range from 91 to 255
                 tmpMask$ = Chr((Int((255 - 91 + 1) * Rnd + 91)))
                 'Add to our hold mask
                 hMask$ = hMask$ & tmpMask$
                'If custom key then
            ElseIf tmpMask$ = KeyMask Then
                'scan for the key mask
                If GenerateCustomKey Then
                    'and change it to the selected type(Same use as above)
                    If KeyType = Alphabetic Then
                        tmpMask$ = Chr((Int((90 - 65 + 1) * Rnd + 65)))
                    ElseIf KeyType = Numeric Then
                        tmpMask$ = CInt(Rnd * 9)
                    ElseIf KeyType = Special_Characters Then
                        tmpMask$ = Chr((Int((255 - 91 + 1) * Rnd + 91)))
                    End If
                    'Add to our hold mask
                    hMask$ = hMask$ & tmpMask$
                End If
            Else
            'If another character "-" "CDKEY" whatever ignore it
            tmpMask$ = tmpMask$
            'Just add it to our hold mask
            hMask$ = hMask$ & tmpMask$
            End If
        Next i
        'After the loop has went through every character our hold mask
        'should now contain our full password so add it the list
        
        'UPDATED - NOW WE ONLY ADD THE PASSWORD IF IT IS UNIQUE.
        
        'START FROM 0 TO OUR CURRENT INDEX AND MAKE SURE IT IS UNIQUE.
        For z = 1 To j
'            On Error Resume Next
            If hMask$ <> CStr(List.ListItems(z)) Then
                'Its unique keep it the same
                hMask$ = hMask$
            Else
                'Not unique make it null ""
                hMask$ = ""
            End If
        Next z
        Dim strArray() As String
        
        strArray = Split(hMask$, "-")
        
        'If the mask was unique and not null we add it
        If hMask$ <> "" Then
            List.ListItems.Add , , strArray(0)
            List.ListItems(z).SubItems(1) = strArray(1)
            
            With rstUser
                .AddNew
                
                !UserCode = strArray(0)
                !Password = strArray(1)
                !TimePlanID = TimePlanID
                .Update
            End With
                
            With rstUserDetail
                .AddNew
                
                !UserCode = strArray(0)
                !TotalAmount = Server.txtAmount.Text
                !TotalHour = Server.txtHours.Text & ":00"
                
                .Update
            End With
        Else
            NumIDUniques = NumIDUniques + 1
        End If
    Next j
End Function

'Kinda long function name but I want it to be easy to understand
Public Property Get GetNumberOfIdenticalUniques() As String
    'Must be called after GeneratePasswords()
    If NumIDUniques = 0 Then GetNumberOfIdenticalUniques = "0": Exit Property
    GetNumberOfIdenticalUniques = CStr(NumIDUniques)
End Property

