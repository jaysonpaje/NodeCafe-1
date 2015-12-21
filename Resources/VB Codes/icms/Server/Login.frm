VERSION 5.00
Begin VB.Form Login 
   BackColor       =   &H80000001&
   BorderStyle     =   0  'None
   Caption         =   "Login"
   ClientHeight    =   2460
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4425
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2460
   ScaleWidth      =   4425
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtUser 
      Appearance      =   0  'Flat
      BackColor       =   &H00800000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   345
      Left            =   1950
      TabIndex        =   0
      Top             =   570
      Width           =   1875
   End
   Begin VB.TextBox txtPassword 
      Appearance      =   0  'Flat
      BackColor       =   &H00800000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   345
      IMEMode         =   3  'DISABLE
      Left            =   1950
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   1050
      Width           =   1875
   End
   Begin VB.Shape Shape6 
      BorderColor     =   &H80000004&
      Height          =   405
      Left            =   1920
      Top             =   1020
      Width           =   1935
   End
   Begin VB.Shape Shape5 
      BorderColor     =   &H80000004&
      Height          =   405
      Left            =   1920
      Top             =   540
      Width           =   1935
   End
   Begin VB.Shape Shape4 
      BorderColor     =   &H8000000D&
      Height          =   375
      Left            =   2310
      Top             =   1590
      Width           =   1185
   End
   Begin VB.Shape Shape3 
      BorderColor     =   &H8000000D&
      Height          =   375
      Left            =   900
      Top             =   1590
      Width           =   1185
   End
   Begin VB.Label lblCancel 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H80000008&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Cancel"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000009&
      Height          =   315
      Left            =   2340
      TabIndex        =   5
      Top             =   1620
      Width           =   1125
   End
   Begin VB.Label lblOK 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H80000008&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "OK"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000009&
      Height          =   315
      Left            =   930
      TabIndex        =   4
      Top             =   1620
      Width           =   1125
   End
   Begin VB.Shape Shape2 
      BorderColor     =   &H80000009&
      FillColor       =   &H80000001&
      Height          =   2415
      Left            =   30
      Top             =   30
      Width           =   4365
   End
   Begin VB.Label lblUser 
      BackColor       =   &H8000000A&
      BackStyle       =   0  'Transparent
      Caption         =   "User Code:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   375
      Left            =   480
      TabIndex        =   3
      Top             =   570
      Width           =   1425
   End
   Begin VB.Label lblPassword 
      BackColor       =   &H8000000A&
      BackStyle       =   0  'Transparent
      Caption         =   "Password:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   375
      Left            =   480
      TabIndex        =   2
      Top             =   1050
      Width           =   1425
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H80000001&
      BackStyle       =   1  'Opaque
      BorderColor     =   &H80000002&
      FillColor       =   &H00808080&
      Height          =   1875
      Left            =   360
      Shape           =   4  'Rounded Rectangle
      Top             =   240
      Width           =   3675
   End
End
Attribute VB_Name = "Login"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MMForm As Boolean

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
    If MMForm = True Then Exit Sub
    MMForm = True
    lblOK.BackColor = &H80000008
    lblCancel.BackColor = &H80000008
    lblCancel.FontSize = 10
    lblOK.FontSize = 10
End Sub

Private Sub lblCancel_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
    lblCancel.BackColor = &HFF8080
    lblCancel.FontSize = 12
End Sub

Private Sub lblCancel_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
    MMForm = False
    If Button = 1 Then Exit Sub
    lblOK.BackColor = &H80000008
    lblCancel.BackColor = &HFF0000
End Sub

Private Sub lblOK_Click()
    Dim i As Integer
    
    If txtUser = "" Or txtPassword = "" Then
        MsgBox "Please enter User Code and Password.", vbInformation
        Exit Sub
    End If
    
    Check_User_Password Server.RetrieveUser(Server.lvOnline.SelectedItem), _
            Server.lvOnline.SelectedItem & "--" & txtUser.Text & "--" & txtPassword.Text
End Sub

Private Sub lblCancel_Click()
    Unload Me
End Sub

Private Sub lblOK_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
    lblOK.BackColor = &HFF8080
    lblOK.FontSize = 12
End Sub

Private Sub lblOK_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
    MMForm = False
    If Button = 1 Then Exit Sub
    lblOK.BackColor = &HFF0000
    lblCancel.BackColor = &H80000008
End Sub

Private Sub txtPassword_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then lblOK_Click: KeyAscii = 0
End Sub

Private Sub txtUser_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then
        SendKeys "{TAB}"
    End If
End Sub
