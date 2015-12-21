VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Begin VB.Form Client 
   BackColor       =   &H80000007&
   BorderStyle     =   0  'None
   Caption         =   "Client"
   ClientHeight    =   11520
   ClientLeft      =   105
   ClientTop       =   105
   ClientWidth     =   15360
   Icon            =   "Client.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   11520
   ScaleWidth      =   15360
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Frame Frame1 
      BackColor       =   &H80000007&
      Height          =   9255
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   12015
      Begin VB.TextBox txtCompName 
         Height          =   375
         Left            =   510
         TabIndex        =   19
         Top             =   480
         Visible         =   0   'False
         Width           =   2175
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Connect"
         Height          =   375
         Left            =   2640
         TabIndex        =   18
         Top             =   480
         Visible         =   0   'False
         Width           =   1095
      End
      Begin VB.TextBox txtIPADDRESS 
         Height          =   375
         Left            =   5760
         TabIndex        =   8
         Top             =   5700
         Width           =   1095
      End
      Begin VB.CommandButton CmdOKAdmin 
         Caption         =   "OK"
         Height          =   495
         Left            =   5850
         TabIndex        =   7
         Top             =   6930
         Width           =   1785
      End
      Begin VB.CommandButton CmdExit 
         Caption         =   "Exit"
         Height          =   495
         Left            =   3900
         TabIndex        =   6
         Top             =   6960
         Width           =   1785
      End
      Begin VB.CommandButton CmdRestart 
         Caption         =   "Restart"
         Height          =   495
         Left            =   3900
         TabIndex        =   5
         Top             =   6270
         Width           =   1785
      End
      Begin VB.CommandButton CmdShutdown 
         Caption         =   "Shutdown"
         Height          =   495
         Left            =   5850
         TabIndex        =   4
         Top             =   6270
         Width           =   1785
      End
      Begin VB.Timer Timer1 
         Interval        =   1000
         Left            =   1590
         Top             =   4650
      End
      Begin VB.CommandButton CmdOK 
         Caption         =   "OK"
         Height          =   435
         Left            =   4950
         TabIndex        =   3
         Top             =   4350
         Width           =   1905
      End
      Begin VB.TextBox txtPassword 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         IMEMode         =   3  'DISABLE
         Left            =   5460
         PasswordChar    =   "*"
         TabIndex        =   2
         Top             =   3870
         Width           =   1875
      End
      Begin VB.TextBox txtUser 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Left            =   5460
         TabIndex        =   1
         Top             =   3390
         Width           =   1875
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "jaYPee will never be the same. whew! kewl!"
         ForeColor       =   &H8000000D&
         Height          =   375
         Left            =   4080
         TabIndex        =   20
         Top             =   3000
         Width           =   3255
      End
      Begin VB.Label lblStatus 
         Height          =   255
         Left            =   4320
         TabIndex        =   17
         Top             =   8580
         Width           =   3735
      End
      Begin VB.Label lblAdmin 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "Administrator's Option"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   315
         Left            =   3990
         TabIndex        =   16
         Top             =   5220
         Width           =   3435
      End
      Begin VB.Label lblIPADDRESS 
         Caption         =   "IP Address:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   4620
         TabIndex        =   15
         Top             =   5700
         Width           =   1125
      End
      Begin VB.Label lblTime 
         Alignment       =   2  'Center
         BackColor       =   &H80000012&
         BackStyle       =   0  'Transparent
         Caption         =   "00:00:00 AM"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000D&
         Height          =   315
         Left            =   4665
         TabIndex        =   14
         Top             =   2595
         Width           =   2445
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H80000012&
         BackStyle       =   0  'Transparent
         Caption         =   "The current time is"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000D&
         Height          =   375
         Left            =   4950
         TabIndex        =   13
         Top             =   2220
         Width           =   1935
      End
      Begin VB.Label lblAnimate 
         BackStyle       =   0  'Transparent
         ForeColor       =   &H80000001&
         Height          =   315
         Left            =   4320
         TabIndex        =   12
         Top             =   3030
         Width           =   3195
      End
      Begin VB.Label lblComputerName 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   5010
         TabIndex        =   11
         Top             =   7500
         Width           =   1905
      End
      Begin VB.Label lblUser 
         BackStyle       =   0  'Transparent
         Caption         =   "User"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000002&
         Height          =   375
         Left            =   4080
         TabIndex        =   10
         Top             =   3420
         Width           =   1275
      End
      Begin VB.Label lblPassword 
         BackStyle       =   0  'Transparent
         Caption         =   "Password"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000002&
         Height          =   375
         Left            =   4080
         TabIndex        =   9
         Top             =   3900
         Width           =   1275
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H80000001&
         BorderColor     =   &H80000002&
         Height          =   1875
         Left            =   3870
         Shape           =   4  'Rounded Rectangle
         Top             =   2970
         Width           =   3675
      End
      Begin VB.Shape Shape2 
         BorderColor     =   &H80000002&
         BorderWidth     =   2
         Height          =   2955
         Left            =   3480
         Shape           =   4  'Rounded Rectangle
         Top             =   5040
         Width           =   4515
      End
      Begin VB.Image Image1 
         Height          =   8580
         Left            =   240
         Picture         =   "Client.frx":0442
         Stretch         =   -1  'True
         Top             =   360
         Width           =   11430
      End
   End
   Begin MSWinsockLib.Winsock WinSockClient 
      Left            =   2760
      Top             =   120
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
      RemotePort      =   2400
   End
End
Attribute VB_Name = "Client"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function GetComputerName Lib "kernel32" Alias "GetComputerNameA" _
        (ByVal lpBuffer As String, nSize As Long) As Long
Private Declare Function ExitWindowsEx Lib "user32" _
        (ByVal uFlags As Long, ByVal dwReserved As Long) As Long

Dim cBuffer As String * 255
Dim strIPADDRESS As String

Function ComputerName() As String
   Call GetComputerName(cBuffer, 255)
   ComputerName = left$(cBuffer, InStr(cBuffer, Chr$(0)) - 1)
End Function

Private Sub Connect()
    On Error GoTo err_Connect:
    
    While WinSockClient.State <> sckClosed
        WinSockClient.Close
        DoEvents
    Wend
    
    WinSockClient.RemoteHost = strIPADDRESS '"127.0.0.1"
    WinSockClient.Connect
    
    Do Until WinSockClient.State = 7
        ' 0 is closed, 9 is error
        If WinSockClient.State = 0 Or WinSockClient.State = 9 Then
            lblStatus = "Error in connecting!, Winsock Error"
            ' there was an error, so let's leave
            Exit Sub
        End If
        DoEvents  'don't freeze the system!
    Loop
    
    If WinSockClient.State = 7 Then lblStatus = "connected..."
    
    ' "log-in":
    Send_Data COMMAND_CONNECT & Chr(1) & txtCompName.Text
    DoEvents
    
exit_err_Connect:
    Exit Sub
    
err_Connect:
    If Err = 10055 Then
        Resume exit_err_Connect
    Else
        lblStatus = Err.Number & "-" & Err.Description & " Connect procedure call"
    End If
End Sub

Public Sub Send_Data(cString As String)
   On Error Resume Next

   WinSockClient.SendData cString
End Sub

Private Sub CmdOK_Click()
    strpassword = txtPassword.Text
    txtPassword = ""
    If txtUser = "" Or strpassword = "" Then Exit Sub
    If txtUser = "admin" And strpassword = "jaypee" Then
        Show_Control True
    Else
        Send_Data LOG_IN & Chr(1) & txtCompName.Text & "--" & txtUser.Text & "--" & strpassword
        DoEvents
    End If
End Sub

Private Sub CmdOKAdmin_Click()
    On Error GoTo CmdOKAdmin_Click
    
    strIPADDRESS = txtIPADDRESS
    
    Open "serverip" For Output As #1
        Write #1, strIPADDRESS
    Close #1
    
    Open "serverip" For Input As #1
        Input #1, strIPADDRESS
        strIPADDRESS = strIPADDRESS
    Close #1
    
    WinSockClient.Close
    
    Show_Control False
    
    Exit Sub
    
CmdOKAdmin_Click:
    lblStatus = Err.Number & "-" & Err.Description & " CmdOKAdmin_Click procedure call"
End Sub

Private Sub Command2_Click()
    If WinSockClient.State <> sckConnected Then Connect
End Sub

Private Sub Form_Load()
    On Error GoTo err_Form_Load
    
    If App.PrevInstance Then
       End
    End If

    CenterControl Me.Frame1
       
    'this will lock the task manager and prevent ctrl+alt+del
'    Open "C:\Windows\system32\taskmgr.exe" For Random Lock Read As #2

'    Disabletaskmanager
    
    'this will disable alt+tab, ctrl+esc
'    hhkLowLevelKybd = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, App.hInstance, 0)

'    DisableCtrlAltDelete (True)
'    MakeWindowAlwaysTop Me.hwnd
'    TrapMouse Me
       
    Show_Control False
    
    Get_IPADDRESS
    DoEvents
    txtIPADDRESS.Text = strIPADDRESS
    
    txtCompName.Text = ComputerName()
    DoEvents
    Connect
    
    Exit Sub
    
err_Form_Load:
    lblStatus = Err.Number & "-" & Err.Description & " Form_Load procedure call"
End Sub

Private Sub Get_IPADDRESS()
    On Error GoTo err_Get_IPADDRESS
    
    Open "serverip" For Input As #1
        Input #1, strIPADDRESS
        strIPADDRESS = strIPADDRESS
    Close #1
    
    Exit Sub
    
err_Get_IPADDRESS:
    lblStatus = Err.Number & "-" & Err.Description & " Get_IPADDRESS procedure call"
End Sub

Private Sub Form_Resize()
    CenterControl Me.Frame1
End Sub

Private Sub Form_Unload(Cancel As Integer)
    'Call DisableCtrlAltDelete(False)
    LetMouseGo Me
End Sub

Private Sub Timer1_Timer()
    A = Hour(Now)
    If A > 12 Then
        tStr = "PM"
    Else
        tStr = "AM"
    End If

    Me.lblTime.Caption = A & ":" & Format(Minute(Now), "00") & ":" & Format(Second(Now), "00") & " " & tStr
      
    If WinSockClient.State <> sckConnected Then
        'If txtIPADDRESS.Text = "" Then
        '    Get_IPADDRESS
        '    txtIPADDRESS.Text = strIPADDRESS
        'End If
        
        connectstat = WinSockClient.State
        lblStatus = "Disconnected from server..."
        Connect
    End If
End Sub

Private Sub txtPassword_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then CmdOK_Click: KeyAscii = 0
End Sub

Private Sub WinSockClient_Close1()
    Me.WinSockClient.Close
    Unload frmTime
    Unload frmBanUser
    Me.Show
End Sub

Private Sub WinSockClient_DataArrival(ByVal bytesTotal As Long)
   Dim cDataReceived As String
   
   On Error Resume Next

   WinSockClient.GetData cDataReceived
   Received_Data cDataReceived
End Sub

Private Sub WinSockClient_Error(ByVal Number As Integer, Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, CancelDisplay As Boolean)
    lblStatus = "Winsock Error: " & Number & " " & Description
End Sub

Public Sub Received_Data(cDataReceived As String)
    Dim cCommandCode As String
    Dim strArray() As String
    
    On Error GoTo err_Received_Data
    
    cCommandCode = left(cDataReceived, 3) ' Let's get the first char
    cDataReceived = Mid(cDataReceived, 5)      ' Then cut it off
    
    Select Case cCommandCode   ' Check what it is
        Case INVALID_USER_PASSWORD
            lblStatus.Caption = "Invalid User or Password."
        
        Case MESSAGES
            'lblStatus.Caption = "You do not have enough money left in your account."
            lblStatus.Caption = cDataReceived
            
        Case INTERNET_RECORD
            strArray = Split(cDataReceived, "|")
            lblStatus = "Login Successfully."
            Me.Hide
            txtUser.Text = strArray(0)
            frmTime.Show
            Load frmBanUser
            frmTime.lblInternet_Record.Caption = strArray(1)
            
        Case EXIT_CLIENT
            CmdExit_Click
            
        Case FILL_LISTVIEW_AGAIN
            
            strArray = Split(frmTime.lblInternet_Record, "--")
            
            TotalHour = strArray(0)
            UsedHour = strArray(1)
            LeftHour = strArray(2)
            RunningTime = strArray(3)
            
            Client.Send_Data FILL_LISTVIEW_AGAIN & Chr(1) & txtCompName & "--" & _
                    strLastUser & "--" & TotalHour & "--" & UsedHour & "--" & LeftHour & "--" & RunningTime
            DoEvents
        Case SPECIAL_COMMAND
            Client.Send_Data LOG_OUT & Chr(1) & txtCompName.Text & "--" & strLastUser
            DoEvents
            
            Select Case cDataReceived
            Case "Force_Logout"
'                Send_Data UPDATE_LISTVIEW & Chr(1) & txtCompName.Text & _
                    "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "--" & ""
'                DoEvents
                Unload frmTime
                Me.Show
            Case "Restart"
                CmdRestart_Click
            Case "Shutdown"
                CmdShutdown_Click
            End Select
    End Select
        
    Exit Sub
    
err_Received_Data:
    lblStatus = Err.Number & "-" & Err.Description & " Received_Data procedure call"
End Sub

Private Sub CmdExit_Click()
    Send_Data EXIT_CLIENT & Chr(1) & txtCompName.Text
    DoEvents
   
    Call ExitWindowsEx(EWX_SHUTDOWN, 0)
    Unload Me
  
    Unload frmBanUser
    End
End Sub

Private Sub CmdRestart_Click()
    Send_Data EXIT_CLIENT & Chr(1) & txtCompName.Text
    DoEvents
    Unload Me
    ExitWindowsEx 4 + 2, 0
End Sub

Private Sub CmdShutdown_Click()
    Send_Data EXIT_CLIENT & Chr(1) & txtCompName.Text
    DoEvents
    Unload Me
    ExitWindowsEx 4 + 1, 0
End Sub

Private Sub CenterControl(Ctrl As Control)
    Ctrl.left = (Me.ScaleWidth - Ctrl.Width) \ 2
    Ctrl.top = (Me.ScaleHeight - Ctrl.Height) \ 2
End Sub

Private Sub Show_Control(bVal As Boolean)
    lblAdmin.Visible = bVal
    lblIPADDRESS.Visible = bVal
    txtIPADDRESS.Visible = bVal
    CmdRestart.Visible = bVal
    CmdShutdown.Visible = bVal
    CmdExit.Visible = bVal
    CmdOKAdmin.Visible = bVal
    Shape2.Visible = bVal
End Sub

