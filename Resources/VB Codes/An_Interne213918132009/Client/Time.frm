VERSION 5.00
Begin VB.Form frmTime 
   BackColor       =   &H80000001&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   270
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4200
   LinkTopic       =   "Form1"
   ScaleHeight     =   270
   ScaleWidth      =   4200
   ShowInTaskbar   =   0   'False
   Begin VB.Timer Timer1 
      Interval        =   60000
      Left            =   2880
      Top             =   0
   End
   Begin VB.Shape Shape2 
      BorderColor     =   &H80000005&
      Height          =   225
      Left            =   30
      Top             =   30
      Width           =   3405
   End
   Begin VB.Shape Shape1 
      BorderColor     =   &H80000005&
      Height          =   225
      Left            =   3510
      Top             =   30
      Width           =   675
   End
   Begin VB.Label lblLogout 
      Alignment       =   2  'Center
      BackColor       =   &H00FF0000&
      Caption         =   "Logout"
      ForeColor       =   &H8000000E&
      Height          =   225
      Left            =   3540
      TabIndex        =   1
      Top             =   30
      Width           =   675
   End
   Begin VB.Label lblInternet_Record 
      BackColor       =   &H8000000D&
      ForeColor       =   &H8000000E&
      Height          =   225
      Left            =   60
      TabIndex        =   0
      ToolTipText     =   "Limit--Used--Left--Running Time--Name"
      Top             =   30
      Width           =   3345
   End
End
Attribute VB_Name = "frmTime"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Sub ReleaseCapture Lib "user32" ()
Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Integer, ByVal lParam As Long) As Long

Dim StartTime As Date
Dim RunningTime As Integer

Private Sub lblInternet_Record_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    FormDrag Me: Me.MousePointer = 0
End Sub

Private Sub lblInternet_Record_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    lblLogout.BackColor = &HFF0000
End Sub

Public Sub lblLogout_Click()
    If MsgBox("Are you sure you want to log out?", vbInformation + vbYesNo) = vbYes Then
'        Client.Send_Data LOG_OUT & Chr(1) & Client.txtCompName & "--" & strLastUser
'        DoEvents
'        Client.Send_Data UPDATE_LISTVIEW & Chr(1) & Client.txtCompName & _
'                "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "--" & ""
'        DoEvents
'        Client.lblStatus = "Logout successfully..."
'        Unload frmBanUser
'        Unload Me
'        Client.Show
        Logout
    End If
End Sub

Private Sub Form_Load()
    Dim r As Rect
    
    RunningTime = 0
    strLastUser = Client.txtUser
    
    StartTime = time
    SetWindowPos Me.hwnd, HWND_TOPMOST, Me.left / 15, _
        Me.top / 15, Me.Width / 15, _
        Me.Height / 15, SWP_NOACTIVATE Or SWP_SHOWWINDOW
    Me.Move Me.left, r.top
    Me.Move (Screen.Width - Me.Width) / 2
End Sub

Private Sub Form_Unload(Cancel As Integer)
    'DisableCtrlAltDelete (True)
    MakeWindowAlwaysTop Me.hwnd
    TrapMouse Me
End Sub

Private Sub lblLogout_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    lblLogout.BackColor = &HFF8080
End Sub

Private Sub lblLogout_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    If Button = 1 Then Exit Sub
    lblLogout.BackColor = &HFFC0C0
End Sub

Private Sub Timer1_Timer()
    Dim strArray() As String
    Dim intMin_Used As Integer
    
    RunningTime = RunningTime + 1
    
    strArray = Split(lblInternet_Record, "--")
    
    UsedHour = strArray(1) + CDate("00:01")
    If strLastUser = "UNLI" Then
        LeftHour = 0
        GoSub Send
    Else
        LeftHour = CDate(strArray(0)) - CDate(UsedHour)
    End If
    
    If (CDate(UsedHour) >= CDate(strArray(0))) = True Then
        Logout
        Exit Sub
    End If

Send:
    Client.Send_Data UPDATE_LISTVIEW & Chr(1) & Client.txtCompName & "--" & _
                    strLastUser & "--" & UsedHour & "--" & RunningTime
    DoEvents
    lblInternet_Record = strArray(0) & "--" & Format(UsedHour, "hh:mm") & "--" & Format(LeftHour, "hh:mm") _
                    & "--" & RunningTime
End Sub

Private Sub Logout()
    Client.Send_Data LOG_OUT & Chr(1) & Client.txtCompName.Text & "--" & strLastUser
    DoEvents
'    Client.Send_Data UPDATE_LISTVIEW & Chr(1) & Client.txtCompName.Text & _
            "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "--" & ""
    DoEvents
    Client.lblStatus = "Logout successfully..."
    Unload frmBanUser
    Unload frmTime
    Client.Show
End Sub

Public Function FormDrag(TheForm As Form)
    ReleaseCapture
    SendMessage TheForm.hwnd, &HA1, 2, 0&
'Allows form to be able to be moved elsewhere instead of its titlebar
End Function

