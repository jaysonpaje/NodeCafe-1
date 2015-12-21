VERSION 5.00
Begin VB.Form frmBanUser 
   Caption         =   "Form1"
   ClientHeight    =   870
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3150
   LinkTopic       =   "Form1"
   ScaleHeight     =   870
   ScaleWidth      =   3150
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   100
      Left            =   0
      Top             =   0
   End
   Begin VB.TextBox Text1 
      Enabled         =   0   'False
      Height          =   615
      Left            =   30
      MultiLine       =   -1  'True
      TabIndex        =   0
      Top             =   105
      Width           =   2985
   End
End
Attribute VB_Name = "frmBanUser"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
    Hide_Program
    SetRegValue HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "I-Client", "" & App.Path & "\" & App.EXEName & ".exe"
End Sub

Private Sub Form_Unload(Cancel As Integer)
    SetRegValue HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "I-Client", "" & App.Path & "\" & App.EXEName & ".exe"
End Sub

Private Sub Timer1_Timer()
    FillTexBox Text1
    Text1.Text = LCase(Text1.Text)
    va = 0
    va = InStr(1, Text1.Text, "sex", 0)
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "nude", 0)
    End If
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "nudity", 0)
    End If
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "xxx", 0)
    End If
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "erotic", 0)
    End If
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "hardcore", 0)
    End If
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "porn", 0)
    End If
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "lesbi", 0)
    End If
    
    If va = 0 Then
        va = InStr(1, Text1.Text, "gay", 0)
    End If
    
    If va <> 0 Then
    'SendKeys "%{F4}", True
    'MsgBox "porn site detected"
    
    Client.Send_Data LOG_OUT & Chr(1) & Client.txtCompName & "--" & strLastUser
    DoEvents
    Client.Send_Data UPDATE_LISTVIEW & Chr(1) & Client.txtCompName & _
                "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "--" & ""
    DoEvents
    
    Client.lblStatus = "porn site detected. NBI will arrive soon..."
    Unload Me
    Unload frmTime
    'DisableCtrlAltDelete (True)
    MakeWindowAlwaysTop Me.hwnd
    TrapMouse Me
    Client.Show
    
    End If
    SetRegValue HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "I-Client", "" & App.Path & "\" & App.EXEName & ".exe"
End Sub

