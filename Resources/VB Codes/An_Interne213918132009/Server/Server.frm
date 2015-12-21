VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form Server 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Server"
   ClientHeight    =   7725
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   14895
   Icon            =   "Server.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   7725
   ScaleWidth      =   14895
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame frmTick 
      BackColor       =   &H00FF8080&
      BorderStyle     =   0  'None
      Caption         =   "News:"
      Height          =   975
      Left            =   0
      TabIndex        =   8
      Top             =   0
      Width           =   14895
      Begin VB.Label lblTicker 
         BackStyle       =   0  'Transparent
         Caption         =   "3JNet Cafe Manager"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   24
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00E0E0E0&
         Height          =   615
         Index           =   0
         Left            =   300
         TabIndex        =   9
         Top             =   150
         Width           =   9255
         WordWrap        =   -1  'True
      End
   End
   Begin VB.Frame frmShortcuts 
      BackColor       =   &H00404040&
      BorderStyle     =   0  'None
      Height          =   4095
      Left            =   120
      TabIndex        =   1
      Top             =   1560
      Width           =   2535
      Begin VB.Label lblAdmin 
         BackStyle       =   0  'Transparent
         Caption         =   "Admin"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   255
         Left            =   720
         MouseIcon       =   "Server.frx":0442
         MousePointer    =   99  'Custom
         TabIndex        =   7
         Tag             =   "4"
         ToolTipText     =   "press CTRL + u"
         Top             =   2520
         Width           =   3855
      End
      Begin VB.Label lblTicket 
         BackStyle       =   0  'Transparent
         Caption         =   "Ticket/Coupon"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   255
         Left            =   720
         MouseIcon       =   "Server.frx":074C
         MousePointer    =   99  'Custom
         TabIndex        =   6
         Tag             =   "3"
         ToolTipText     =   "press CTRL + e"
         Top             =   2040
         Width           =   3735
      End
      Begin VB.Label lblReports 
         BackStyle       =   0  'Transparent
         Caption         =   "Reports"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   255
         Left            =   720
         MouseIcon       =   "Server.frx":0A56
         MousePointer    =   99  'Custom
         TabIndex        =   5
         Tag             =   "2"
         ToolTipText     =   "press CTRL + i"
         Top             =   1560
         Width           =   3855
      End
      Begin VB.Label lblUsersRates 
         BackStyle       =   0  'Transparent
         Caption         =   "Users/Rates"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   255
         Left            =   720
         MouseIcon       =   "Server.frx":0D60
         MousePointer    =   99  'Custom
         TabIndex        =   4
         Tag             =   "1"
         ToolTipText     =   "press CTRL + p"
         Top             =   1080
         Width           =   3855
      End
      Begin VB.Label lblOnline 
         BackStyle       =   0  'Transparent
         Caption         =   "Online"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   255
         Left            =   720
         MouseIcon       =   "Server.frx":106A
         MousePointer    =   99  'Custom
         TabIndex        =   3
         Tag             =   "0"
         ToolTipText     =   "press CTRL + d"
         Top             =   600
         Width           =   3855
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "3JNet Cafe"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00E0E0E0&
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   120
         Width           =   3015
      End
      Begin VB.Image Image2 
         Height          =   480
         Index           =   0
         Left            =   120
         MouseIcon       =   "Server.frx":1374
         MousePointer    =   99  'Custom
         Picture         =   "Server.frx":167E
         ToolTipText     =   "Create a new Delivery Order"
         Top             =   480
         Width           =   480
      End
      Begin VB.Image Image2 
         Height          =   480
         Index           =   1
         Left            =   120
         MouseIcon       =   "Server.frx":2348
         MousePointer    =   99  'Custom
         Picture         =   "Server.frx":2652
         ToolTipText     =   "Create a new Purchase Order"
         Top             =   960
         Width           =   480
      End
      Begin VB.Image Image2 
         Height          =   480
         Index           =   2
         Left            =   120
         MouseIcon       =   "Server.frx":331C
         MousePointer    =   99  'Custom
         Picture         =   "Server.frx":3626
         ToolTipText     =   "Check stock level by browsing the Inventory"
         Top             =   1440
         Width           =   480
      End
      Begin VB.Image Image2 
         Height          =   480
         Index           =   3
         Left            =   120
         MouseIcon       =   "Server.frx":42F0
         MousePointer    =   99  'Custom
         Picture         =   "Server.frx":45FA
         ToolTipText     =   "See who your colleagues are"
         Top             =   1920
         Width           =   480
      End
      Begin VB.Image Image2 
         Height          =   480
         Index           =   4
         Left            =   120
         MouseIcon       =   "Server.frx":52C4
         MousePointer    =   99  'Custom
         Picture         =   "Server.frx":55CE
         ToolTipText     =   "Control users allowed to access this system"
         Top             =   2400
         Width           =   480
      End
   End
   Begin MSWinsockLib.Winsock WinsockSubServer 
      Index           =   0
      Left            =   6600
      Top             =   10560
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
   Begin MSWinsockLib.Winsock WinsockServer 
      Left            =   6120
      Top             =   10560
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
      LocalPort       =   2400
   End
   Begin VB.Frame fraOnline 
      Caption         =   "Online"
      Height          =   5895
      Left            =   3000
      TabIndex        =   11
      Top             =   1200
      Width           =   11655
      Begin MSComctlLib.ListView lvOnline 
         Height          =   5475
         Left            =   120
         TabIndex        =   12
         Top             =   240
         Width           =   11415
         _ExtentX        =   20135
         _ExtentY        =   9657
         LabelEdit       =   1
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         HotTracking     =   -1  'True
         HoverSelection  =   -1  'True
         TextBackground  =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483643
         BorderStyle     =   1
         Appearance      =   0
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         NumItems        =   0
      End
   End
   Begin VB.Frame fraUsersRates 
      Caption         =   "Users/Rates"
      Height          =   5895
      Left            =   3000
      TabIndex        =   13
      Top             =   1200
      Width           =   11655
      Begin VB.ComboBox cboTimePlan 
         DataField       =   "TimePlanID"
         Height          =   315
         Left            =   1200
         TabIndex        =   50
         Top             =   1440
         Width           =   1815
      End
      Begin MSComctlLib.ListView lvUsers 
         Height          =   4815
         Left            =   3240
         TabIndex        =   49
         Top             =   840
         Width           =   8295
         _ExtentX        =   14631
         _ExtentY        =   8493
         View            =   3
         LabelEdit       =   1
         MultiSelect     =   -1  'True
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483643
         BorderStyle     =   1
         Appearance      =   1
         NumItems        =   7
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "User Code"
            Object.Width           =   1764
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            SubItemIndex    =   1
            Text            =   "Total Amount"
            Object.Width           =   2117
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            SubItemIndex    =   2
            Text            =   "Amount Used"
            Object.Width           =   2117
         EndProperty
         BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            SubItemIndex    =   3
            Text            =   "Amount Left"
            Object.Width           =   2117
         EndProperty
         BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            SubItemIndex    =   4
            Text            =   "Total Hour"
            Object.Width           =   1764
         EndProperty
         BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            SubItemIndex    =   5
            Text            =   "Hour Used"
            Object.Width           =   1764
         EndProperty
         BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            SubItemIndex    =   6
            Text            =   "Hour Left"
            Object.Width           =   1764
         EndProperty
      End
      Begin VB.Frame fraCtrl 
         Height          =   735
         Left            =   240
         TabIndex        =   43
         Top             =   3840
         Width           =   2775
         Begin VB.CommandButton cmdEdit 
            Caption         =   "&Edit"
            Height          =   300
            Left            =   915
            TabIndex        =   48
            Top             =   240
            Width           =   855
         End
         Begin VB.CommandButton cmdAdd 
            Caption         =   "&Add"
            Height          =   300
            Left            =   120
            TabIndex        =   47
            Top             =   240
            Width           =   855
         End
         Begin VB.CommandButton cmdDelete 
            Caption         =   "&Delete"
            Height          =   300
            Left            =   1800
            TabIndex        =   46
            Top             =   240
            Width           =   855
         End
         Begin VB.CommandButton cmdCancel 
            Caption         =   "&Cancel"
            Height          =   300
            Left            =   915
            TabIndex        =   45
            Top             =   240
            Visible         =   0   'False
            Width           =   855
         End
         Begin VB.CommandButton cmdUpdate 
            Caption         =   "&Update"
            Height          =   300
            Left            =   120
            TabIndex        =   44
            Top             =   240
            Visible         =   0   'False
            Width           =   855
         End
      End
      Begin VB.TextBox txtFields 
         DataField       =   "UserCode"
         Height          =   285
         Index           =   0
         Left            =   1200
         TabIndex        =   17
         Top             =   480
         Width           =   1815
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Name"
         Height          =   285
         Index           =   1
         Left            =   1200
         TabIndex        =   16
         Top             =   795
         Width           =   1815
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Password"
         Height          =   285
         Index           =   2
         Left            =   1200
         TabIndex        =   15
         Top             =   1125
         Width           =   1815
      End
      Begin VB.TextBox txtSearch 
         Height          =   285
         Left            =   4800
         TabIndex        =   14
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label Label1 
         Caption         =   "Time Plan"
         Height          =   255
         Left            =   360
         TabIndex        =   51
         Top             =   1440
         Width           =   735
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         Caption         =   "UserCode:"
         Height          =   255
         Index           =   0
         Left            =   240
         TabIndex        =   21
         Top             =   480
         Width           =   855
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         Caption         =   "Name:"
         Height          =   255
         Index           =   1
         Left            =   240
         TabIndex        =   20
         Top             =   795
         Width           =   855
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         Caption         =   "Password:"
         Height          =   255
         Index           =   2
         Left            =   240
         TabIndex        =   19
         Top             =   1125
         Width           =   855
      End
      Begin VB.Label Label2 
         Caption         =   "Search UserCode:"
         Height          =   255
         Index           =   0
         Left            =   3360
         TabIndex        =   18
         Top             =   480
         Width           =   1335
      End
   End
   Begin VB.Frame fraTicket 
      Caption         =   "Ticket/Coupon"
      Height          =   5895
      Left            =   3000
      TabIndex        =   22
      Top             =   1200
      Width           =   11655
      Begin VB.ComboBox cboGenTimePlan 
         Height          =   315
         Left            =   5160
         TabIndex        =   52
         Top             =   960
         Width           =   1575
      End
      Begin VB.CommandButton cmdGen 
         Caption         =   "Generate"
         Height          =   375
         Left            =   4680
         TabIndex        =   32
         Top             =   2760
         Width           =   1455
      End
      Begin VB.Frame Frame1 
         Height          =   2415
         Left            =   6840
         TabIndex        =   27
         Top             =   360
         Width           =   2415
         Begin VB.TextBox txtNumPass 
            Height          =   285
            Left            =   960
            TabIndex        =   28
            Text            =   "25"
            Top             =   960
            Width           =   495
         End
         Begin VB.Label Label2 
            BackStyle       =   0  'Transparent
            Caption         =   "Passwords To Generate"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   210
            Index           =   1
            Left            =   120
            TabIndex        =   31
            Top             =   600
            Width           =   2130
         End
         Begin VB.Label Label4 
            BackStyle       =   0  'Transparent
            Caption         =   "Duplicated Passwords"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   210
            Left            =   120
            TabIndex        =   30
            Top             =   1560
            Width           =   2130
         End
         Begin VB.Label lblDupes 
            Alignment       =   2  'Center
            BackStyle       =   0  'Transparent
            Caption         =   "0"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   210
            Left            =   705
            TabIndex        =   29
            Top             =   1800
            Width           =   1050
         End
      End
      Begin VB.TextBox txtPrefix 
         Height          =   405
         Left            =   5160
         TabIndex        =   25
         Top             =   480
         Width           =   975
      End
      Begin VB.TextBox txtAmount 
         Height          =   405
         Left            =   5160
         TabIndex        =   24
         Top             =   1680
         Width           =   975
      End
      Begin VB.TextBox txtHours 
         Height          =   405
         Left            =   5160
         TabIndex        =   23
         Top             =   2160
         Width           =   975
      End
      Begin MSComctlLib.ListView lvGen 
         Height          =   5535
         Left            =   240
         TabIndex        =   26
         Top             =   360
         Width           =   3855
         _ExtentX        =   6800
         _ExtentY        =   9763
         View            =   3
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483643
         BorderStyle     =   1
         Appearance      =   1
         NumItems        =   2
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "UserCode"
            Object.Width           =   2540
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Password"
            Object.Width           =   2540
         EndProperty
      End
      Begin VB.Label Label8 
         Alignment       =   1  'Right Justify
         Caption         =   "Time Plan:"
         Height          =   375
         Left            =   4200
         TabIndex        =   53
         Top             =   960
         Width           =   855
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         Caption         =   "Prefix:"
         Height          =   255
         Left            =   4440
         TabIndex        =   35
         Top             =   600
         Width           =   615
      End
      Begin VB.Label Label5 
         Alignment       =   1  'Right Justify
         Caption         =   "Amount:"
         Height          =   255
         Left            =   4440
         TabIndex        =   34
         Top             =   1800
         Width           =   615
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         Caption         =   "Hour(s):"
         Height          =   255
         Left            =   4440
         TabIndex        =   33
         Top             =   2280
         Width           =   615
      End
   End
   Begin VB.Frame fraReports 
      Caption         =   "Reports"
      Height          =   5895
      Left            =   3000
      TabIndex        =   36
      Top             =   1200
      Width           =   11655
      Begin VB.CommandButton CmdPrintPreview 
         Caption         =   "Print Preview"
         Height          =   315
         Left            =   5880
         TabIndex        =   41
         Top             =   360
         Width           =   1215
      End
      Begin VB.CommandButton CmdDisplayReport 
         Caption         =   "Display Report"
         Height          =   315
         Left            =   4230
         TabIndex        =   40
         Top             =   360
         Width           =   1425
      End
      Begin VB.TextBox BegDate 
         Height          =   315
         Left            =   1560
         TabIndex        =   39
         Top             =   360
         Width           =   1245
      End
      Begin VB.ComboBox cboCategory 
         Height          =   315
         ItemData        =   "Server.frx":6298
         Left            =   240
         List            =   "Server.frx":62AB
         TabIndex        =   38
         Top             =   360
         Width           =   1215
      End
      Begin VB.TextBox EndDate 
         Height          =   315
         Left            =   2910
         TabIndex        =   37
         Top             =   360
         Visible         =   0   'False
         Width           =   1245
      End
      Begin MSDataGridLib.DataGrid grdReport 
         Height          =   4815
         Left            =   240
         TabIndex        =   42
         Top             =   840
         Width           =   11175
         _ExtentX        =   19711
         _ExtentY        =   8493
         _Version        =   393216
         HeadLines       =   1
         RowHeight       =   15
         BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ColumnCount     =   2
         BeginProperty Column00 
            DataField       =   ""
            Caption         =   ""
            BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
               Type            =   0
               Format          =   ""
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1033
               SubFormatType   =   0
            EndProperty
         EndProperty
         BeginProperty Column01 
            DataField       =   ""
            Caption         =   ""
            BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
               Type            =   0
               Format          =   ""
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1033
               SubFormatType   =   0
            EndProperty
         EndProperty
         SplitCount      =   1
         BeginProperty Split0 
            BeginProperty Column00 
            EndProperty
            BeginProperty Column01 
            EndProperty
         EndProperty
      End
   End
   Begin VB.Shape bgWelcome 
      BackColor       =   &H00404040&
      BackStyle       =   1  'Opaque
      BorderStyle     =   0  'Transparent
      Height          =   6135
      Left            =   0
      Top             =   960
      Width           =   2895
   End
   Begin VB.Label lblWelcome 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   240
      TabIndex        =   10
      Top             =   1200
      Width           =   3135
   End
   Begin VB.Label lblStatus 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   2400
      TabIndex        =   0
      Top             =   7200
      Width           =   10815
   End
   Begin VB.Menu mnuPopup 
      Caption         =   "Popup"
      Visible         =   0   'False
      Begin VB.Menu mnu_Unlimited 
         Caption         =   "Unlimited"
      End
      Begin VB.Menu mnuLogin 
         Caption         =   "Login"
      End
      Begin VB.Menu mnuForceLogout 
         Caption         =   "Force Logout"
      End
      Begin VB.Menu mnuExit_Client 
         Caption         =   "Exit Client"
      End
      Begin VB.Menu mnuRestart 
         Caption         =   "Restart"
      End
      Begin VB.Menu mnuShutdown 
         Caption         =   "Shutdown"
      End
   End
End
Attribute VB_Name = "Server"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'Dim db As ADODB.Connection
Dim WithEvents adoPrimaryRS As ADODB.Recordset
Attribute adoPrimaryRS.VB_VarHelpID = -1
'Dim adoPrimaryRS As ADODB.Recordset
Dim rstReport As New ADODB.Recordset
Dim rstTimePlan As ADODB.Recordset
Dim mbChangedByCode As Boolean
Dim mvBookMark As Variant
Dim mbEditFlag As Boolean
Dim mbAddNewFlag As Boolean
Dim mbDataChanged As Boolean

' We'll limit it to 21 users at a time! ;)
Dim users(0 To 20) As String

Private Sub cboCategory_Click()
    Select Case cboCategory.ListIndex
    Case 0
        BegDate = Date
        EndDate.Visible = False
    Case 1, 2
        BegDate = Date
        EndDate.Visible = True
        EndDate = Date
    Case 3
        EndDate.Visible = False
        BegDate = Format(Date, "yyyy")
    Case 4
        EndDate.Visible = False
        BegDate = "0001"
    End Select
End Sub

Private Sub formatgrid()
    Dim MyFormat As StdDataFormat
    
    Set MyFormat = New StdDataFormat
    MyFormat.Format = "0.00"
    Set grdReport.Columns(4).DataFormat = MyFormat
End Sub

Private Sub cboTimePlan_Click()
On Error GoTo err_cboTimePlan_Click

    rstTimePlan.Find "[Plan]='" & cboTimePlan.Text & "'", , , 1
    
    cboTimePlan.Tag = rstTimePlan!TimePlanID
    
    Exit Sub

err_cboTimePlan_Click:
    MsgBox "Error #: " & Err.Number & " " & Err.Description
End Sub

Private Sub CmdDisplayReport_Click()
On Error GoTo err_CmdDisplayReport_Click
    
    Dim strQuery As String
    Dim strWhere As String
    
    Dim rstReport As ADODB.Recordset

    Set rstReport = New ADODB.Recordset
    
    Select Case cboCategory.ListIndex
    Case 0
        strQuery = "Format([DateTimeLogin], 'm/d/yyyy') = #" & BegDate & "#"
        rstReport.Open "SELECT * From [Login History Query] Where " & strQuery, db, adOpenStatic, adLockOptimistic
    Case 1, 2
        strQuery = "Format([DateTimeLogin], 'm/d/yyyy') Between #" & BegDate & "# And #" & EndDate & "#"
        rstReport.Open "SELECT * FROM [Login History Query] Where " & strQuery, db, adOpenStatic, adLockOptimistic
    Case 3
        strQuery = "Format([DateTimeLogin],'yyyy') = " & BegDate & ""
        rstReport.Open "SELECT * FROM [Login History Query] Where " & strQuery, db, adOpenStatic, adLockOptimistic
    Case 4
        strQuery = "UserCode = '" & BegDate & "'"
        rstReport.Open "SELECT * FROM [Login History Query] Where " & strQuery, db, adOpenStatic, adLockOptimistic
    End Select
       
    Set grdReport.DataSource = rstReport
    
    formatgrid
        
exit_err_CmdDisplayReport_Click:
    Exit Sub
    
err_CmdDisplayReport_Click:
    MsgBox "Please check your search box", vbInformation
    Resume exit_err_CmdDisplayReport_Click
End Sub

Private Sub cmdGen_Click()
On Error GoTo err_cmdGen_Click

    Dim rstPrefix As ADODB.Recordset
    Dim TimePlanID As Integer
    
    If MsgBox("Are you sure you want to generate new username and password?", vbInformation + vbYesNo) = vbNo Then Exit Sub
    
    lvGen.ListItems.Clear
    
    Set rstPrefix = New ADODB.Recordset

    If txtPrefix = "" Or txtAmount = "" Or txtHours = "" Then
        MsgBox "All fields are required."
        
        Exit Sub
    End If
    
    db.BeginTrans
    
    With rstPrefix
        .Open "SELECT * From [Prefix] Where [Prefix] = '" & txtPrefix & "'", db, adOpenStatic, adLockOptimistic
    
        If .RecordCount > 0 Then MsgBox "Prefix already exists. Please choice another.", vbInformation: Exit Sub
        
        .AddNew
        !Prefix = txtPrefix.Text
        .Update
    End With
    
    TimePlanID = getValueAt("SELECT * FROM [Time Plan] WHERE Plan = '" & cboGenTimePlan.Text & "'", "TimePlanID")
    
    'Generate the passwords
    GenerateUsersPasswords lvGen, CLng(txtNumPass), txtPrefix & "XXXXX-#####", TimePlanID, False
    lblDupes.Caption = GetNumberOfIdenticalUniques
    
    db.CommitTrans
    
    Exit Sub
    
err_cmdGen_Click:
    db.RollbackTrans
    
    MsgBox "Error #: " & Err.Number & " " & Err.Description
End Sub

Private Sub CmdPrintPreview_Click()
On Error GoTo err_CmdPrintPreview_Click

    Dim q As Integer
    Dim intCtrl As Integer
    Dim x As Integer
    Dim z As Integer
    
    If cboCategory.ListIndex = 4 Then Exit Sub
    
    Report_Proc
    
    x = 0
    q = 0
    z = 0

    With rptICMS
    .Hide
    Set .DataSource = rstReport
    .DataMember = ""
    With .Sections("Section1").Controls
        For intCtrl = 1 To .Count
            If TypeOf .Item(intCtrl) Is RptLabel Then
                .Item(intCtrl).Caption = rstReport.Fields(q).Name & " :"
                q = q + 1
            End If
                
            If TypeOf .Item(intCtrl) Is RptTextBox Then
                .Item(intCtrl).DataMember = ""
                .Item(intCtrl).DataField = rstReport(z).Name
                z = z + 1
            End If
        
        Next intCtrl
    End With
    .Refresh
    .Show
    End With
    rstReport.ActiveConnection = Nothing
    rstReport.Close
    
    Exit Sub

err_CmdPrintPreview_Click:
    lblStatus = Err.Number & "-" & Err.Description & " CmdPrintPreview_Click procedure call"
End Sub

Private Sub Report_Proc()
On Error GoTo err_Report_Proc

    Dim cn As New ADODB.Connection
    Dim cmd As New ADODB.Command
    Dim strQuery As String
    
    cn.Open "Provider=Microsoft.Jet.OLEDB.4.0;" & _
            "Data Source=" & App.Path & "\Internet Record.mdb;Jet OLEDB:Database Password=jaypee;"
    
    Select Case cboCategory.ListIndex
    Case 0
        strQuery = "Format([DateTimeLogin], 'm/d/yyyy') = #" & BegDate & "#"
        strQuery = "SELECT * From [Login History Query] Where " & strQuery
    Case 1, 2
        strQuery = "Format([DateTimeLogin], 'm/d/yyyy') Between #" & BegDate & "# And #" & EndDate & "#"
        strQuery = "SELECT * FROM [Login History Query] Where " & strQuery
    Case 3
        strQuery = "Format([DateTimeLogin],'yyyy') = " & BegDate & ""
        strQuery = "SELECT * FROM [Login History Query] Where " & strQuery
    End Select
    
    With cmd
        .ActiveConnection = cn
        .CommandType = adCmdText
        
        '.CommandText = "Select usercode, name, datetimelogin, datetimelogout, amount from [login history query]"
        .CommandText = strQuery
        .Execute
    End With
    
    With rstReport
        .ActiveConnection = cn
        .CursorLocation = adUseClient
        .Open cmd
    End With
    
    Exit Sub

err_Report_Proc:
    lblStatus = Err.Number & "-" & Err.Description & " Report_Proc procedure call"
End Sub

Private Sub Form_Load()
On Error GoTo err_Form_Load

    If App.PrevInstance Then
       End
    End If
    
    Set db = New ADODB.Connection
    
    db.CursorLocation = adUseClient
    db.Open "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\Internet Record.mdb;Jet OLEDB:Database Password=jaypee;"

    Set rstTimePlan = New ADODB.Recordset
    rstTimePlan.Open "SELECT * From [Time Plan]", db, adOpenStatic, adLockOptimistic

    Fill_Listview

    WinsockServer.Listen  ' make it listen
    
'    Connect_Users
       
    BegDate = Date
    Me.cboCategory.ListIndex = 0
        
    With rstTimePlan
        If .RecordCount > 0 Then
            .MoveFirst
            Do Until .EOF
                cboTimePlan.AddItem !Plan
                cboGenTimePlan.AddItem !Plan
                
                .MoveNext
            Loop
        End If
    End With
    
    Exit Sub

err_Form_Load:
    lblStatus = Err.Number & "-" & Err.Description & " Form_Load procedure call"
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If MsgBox("Are you sure you want to quit?", vbInformation + vbYesNo) = vbNo Then
        Cancel = True
    End If
End Sub

Public Function RetrieveUser(UserName As String) As Integer
    Dim x As Integer
   
    ' Count through the users
    For x = 0 To 100
        
        'Check username to see if it is the right one
        If users(x) = UserName Then
        
            'Ok, this is our man, so let's return his
            ' winsock index
            RetrieveUser = x
            Exit Function
        End If
    Next x
    RetrieveUser = -1
End Function

Private Sub Image2_Click(Index As Integer)
    Select Case Index
    Case 0
        lblOnline_Click
    Case 1
        lblUsersRates_Click
        
        lvUsers.ListItems.Clear
        Connect_Users
    Case 2
        lblReports_Click
    Case 3
        lblTicket_Click
    End Select
End Sub

Private Sub lblOnline_Click()
    fraOnline.ZOrder 0
End Sub

Private Sub lblReports_Click()
    fraReports.ZOrder 0
End Sub

Private Sub lblTicket_Click()
    fraTicket.ZOrder 0
End Sub

Private Sub lblUsersRates_Click()
    fraUsersRates.ZOrder 0

    lvUsers.ListItems.Clear
    Connect_Users
End Sub

Private Sub lvOnline_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
    lvOnline.SelectedItem = lvOnline.HitTest(x, Y)
    
    If lvOnline.SelectedItem Is Nothing Then Exit Sub
    
    If Button = vbRightButton Then
        PopupMenu mnuPopup
    End If
End Sub

Private Sub lvUsers_Click()
    txtSearch.Text = lvUsers.SelectedItem
End Sub

Private Sub mnu_Unlimited_Click()
'    Server.lblStatus = !Name & " " & "Login Successfully."
    Send_Data RetrieveUser(Server.lvOnline.SelectedItem), INTERNET_RECORD & Chr(1) & "UNLIMITED" & "|" & "<>" & "--" & 0 _
                & "--" & "<>" & "--" & 0 & "--" & "UNLI"
    DoEvents
    Update_Listview_Record Server.lvOnline.SelectedItem & "--" & "UNLIMITED" & "--" _
                & "0.00" & "--" & "0.00" & "--" & "0.00" & "--" _
                & "0.00" & "--" & "0.00" & "--" & "0.00" & "--" & Now() & "--" & 0
End Sub

Private Sub mnuExit_Client_Click()
    Dim User As String
    
    If lvOnline.SelectedItem.SubItems(1) <> "" Then
        MsgBox "Can't exit client program. Logout first and try again.", vbInformation
        Exit Sub
    End If
       
    User = RetrieveUser(lvOnline.SelectedItem)
    
    Send_Data CInt(User), EXIT_CLIENT
    DoEvents
End Sub

Private Sub mnuForceLogout_Click()
    Dim User As String
    
    If lvOnline.SelectedItem.SubItems(1) = _
            "" Then Exit Sub
    
    User = RetrieveUser(lvOnline.SelectedItem)
    
    Send_Data CInt(User), SPECIAL_COMMAND & Chr(1) & "Force_Logout"
    DoEvents
End Sub

Private Sub mnuLogin_Click()
    If lvOnline.SelectedItem.SubItems(1) <> "" Then Exit Sub
    Login.Show 1
End Sub

Private Sub mnuRestart_Click()
    Dim User As String
    
    If lvOnline.SelectedItem.SubItems(1) <> _
            "" Then Exit Sub
    
    User = RetrieveUser(lvOnline.SelectedItem)
    
    Send_Data CInt(User), SPECIAL_COMMAND & Chr(1) & "Restart"
    DoEvents
End Sub

Private Sub mnuShutdown_Click()
    Dim User As String
    
    If lvOnline.SelectedItem.SubItems(1) <> _
            "" Then Exit Sub
            
    User = RetrieveUser(lvOnline.SelectedItem)
    
    Send_Data CInt(User), SPECIAL_COMMAND & Chr(1) & "Shutdown"
    DoEvents
End Sub

Private Sub txtSearch_Change()
On Error GoTo err_txtSearch_Change

    With adoPrimaryRS
        .Filter = "[UserCode] = '" & Me.txtSearch & "'"
    
        If .RecordCount > 0 Then
            txtFields(0).Text = !UserCode
            txtFields(1).Text = IIf(IsNull(!Name) Or !Name = "", !UserCode, !Name)
            txtFields(2).Text = !Password
            rstTimePlan.Find "[TimePlanID]='" & !TimePlanID & "'", , , 1
            cboTimePlan.Text = rstTimePlan!Plan
        Else
            txtFields(0).Text = ""
            txtFields(1).Text = ""
            txtFields(2).Text = ""
            cboTimePlan.Text = ""
        End If
    End With
    
    Exit Sub
    
err_txtSearch_Change:
    lblStatus = Err.Number & "-" & Err.Description & " txtSearch_Change procedure call"
End Sub

Private Sub WinsockSubServer_Close(Index As Integer)
    On Error GoTo err_WinsockSubServer_Close
    
    ' Let's cycle through the list, looking for their
    ' name
    Dim x As Integer
    Dim intIndex As Integer
    
    For x = 0 To lvOnline.ListItems.Count - 1
    
        ' Check to see if it matches
        If lvOnline.ListItems(x + 1) = users(Index) Then
        
            'saved data before removing from the listview
            intIndex = lvOnline.FindItem(users(Index)).Index
            Save_Data lvOnline.ListItems(intIndex).SubItems(1), lvOnline.ListItems(intIndex).SubItems(10), lvOnline.ListItems(intIndex).SubItems(9)
            DoEvents
            
            ' It matches, so let's remove it from the
            ' list and the array
            users(Index) = ""
            lvOnline.ListItems.Remove x + 1
            WinsockSubServer(x).Close
            
            Exit For
        End If
    Next x
    
    Exit Sub
    
err_WinsockSubServer_Close:
    lblStatus = Err.Number & "-" & Err.Description & " WinsockSubServer_Close procedure call"
End Sub

Private Sub WinsockSubServer_DataArrival(Index As Integer, ByVal bytesTotal As Long)
    Dim cString As String
    
    On Error Resume Next
    
    WinsockSubServer(Index).GetData cString
    Call Received_Data(Index, cString)
End Sub

Private Sub WinsockSubServer_Error(Index As Integer, ByVal Number As Integer, Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, CancelDisplay As Boolean)
    
    ' This inserts the error message at the "cursor"
    lblStatus = "WinsockSubServer(" & Index & ") - " & Number & " - " & Description & vbCrLf
    
    ' Close it =)
    WinsockSubServer(Index).Close
    
End Sub

Private Sub WinsockServer_ConnectionRequest(ByVal requestID As Long)
    On Error GoTo err_WinsockServer_ConnectionRequest
    Dim Index As Integer
    
    Index = FindOpenWinsock
    
    ' Accept the request using the created winsock
    WinsockSubServer(Index).Accept requestID
    
    Exit Sub
    
err_WinsockServer_ConnectionRequest:
    lblStatus = Err.Number & "-" & Err.Description & " WinsockServer_ConnectionRequest procedure call"
End Sub

Private Function FindOpenWinsock()
'Static LocalPorts As Integer  ' Static keeps the
                              ' variable's state
    On Error GoTo err_FindOpenWinsock
    Dim x As Integer
    
    For x = 0 To WinsockSubServer.UBound
        If WinsockSubServer(x).State = 0 Then
            
            ' We found one that's state is 0, which
            '  means "closed", so let's use it
            FindOpenWinsock = x
            
            ' make sure to leave function
            Exit Function
        End If
    Next x

    '  OK, none are open so let's make one
    Load WinsockSubServer(WinsockSubServer.UBound + 1)
    
    '  Let's make sure we don't get conflicting local ports
    'LocalPorts = LocalPorts + 1
    'WinsockSubServer(WinsockSubServer.UBound).LocalPort = WinsockSubServer(WinsockSubServer.UBound).LocalPort + LocalPorts
    
    '  and then let's return it's index value
    FindOpenWinsock = WinsockSubServer.UBound
    
    Exit Function
    
err_FindOpenWinsock:
    lblStatus = Err.Number & "-" & Err.Description & " FindOpenWinsock procedure call"
End Function

Private Sub Fill_Listview()
On Error GoTo err_Fill_Listview
    
'    Dim adoComputersRS As ADODB.Recordset
'    Dim I As Integer
    
    With lvOnline
        .ColumnHeaders.Add , , "Computer Name"
        .ColumnHeaders.Add , , "User Code", , lvwColumnCenter
        .ColumnHeaders.Add , , "Total Amount", , lvwColumnCenter
        .ColumnHeaders.Add , , "Used Amount", , lvwColumnCenter
        .ColumnHeaders.Add , , "Left Amount", , lvwColumnCenter
        .ColumnHeaders.Add , , "Total Hour", , lvwColumnCenter
        .ColumnHeaders.Add , , "Used Hour", , lvwColumnCenter
        .ColumnHeaders.Add , , "Left Hour", , lvwColumnCenter
        .ColumnHeaders.Add , , "Time In", , lvwColumnCenter
        .ColumnHeaders.Add , , "Time Plan", , lvwColumnCenter
        .ColumnHeaders.Add , , "Time Plan ID", 0, lvwColumnCenter
        .ColumnHeaders.Add , , "Comp ID", 0, lvwColumnCenter
    
        ' Set View property to Report.
        lvOnline.View = lvwReport
        lvOnline.FullRowSelect = True
    End With
    
'    Set adoComputersRS = New ADODB.Recordset
'
'    With adoComputersRS
'        .Open "Select * From Computers Order by ComputerName ASC", db, adOpenStatic, adLockOptimistic
'
'        For I = 1 To .RecordCount
'            lvOnline.ListItems.Add , , !ComputerName
'            lvUsers.ListItems(I).SubItems(11) = !ComputerID
'        Next I
'
'        .Close
'    End With
    
    Exit Sub
    
err_Fill_Listview:
    lblStatus = Err.Number & "-" & Err.Description & " Fill_Listview procedure call"
End Sub

Private Sub Received_Data(Index As Integer, cDataReceived As String)
On Error GoTo err_Received_Data

    Dim cCommandCode As String
    Dim strArray() As String
    Dim itmFound As ListItem
    Dim intSelectedOption As Variant
    Dim x As Variant
    
    Dim CompName As String
    Dim UserCode As String
    Dim intIndex As Integer
    Dim TimePlanID As Integer
    Dim RunningTime As Integer
    Dim curChargePerHour As Currency
    Dim TotalAmount As Currency
    Dim UsedAmount As Currency
    Dim LeftAmount As Currency
    Dim TotalHour As Date
    Dim UsedHour As Date
    Dim LeftHour As Date
    Dim TimeIn As Date
    Dim TimePlan As String
    Dim TotalHourTemp As Date
    Dim curChargePerMin As Currency
    
    ' Our format for our messages is this:
    ' cCommandCode & chr(1) & <info>
    If InStr(1, cDataReceived, Chr(1)) <> 4 Then
    ' If the 4th char isn't chr(1), we know we have a prob
    
        MsgBox "Unknown Data Format: " & vbCrLf & _
                cDataReceived, vbCritical, "Error receiving"
        ' Make sure to leave the sub so it doesn't
        ' try to process the invalid info!
        Exit Sub
    End If
    
    'Retrieve First Character
    cCommandCode = Left(cDataReceived, 3)
  
    'Make sure to trim it, and chr(1), off
    cDataReceived = Mid(cDataReceived, 5)
    
    ' Check what it is, without regard to case
    Select Case cCommandCode
        
        'This is their "login" key
        Case COMMAND_CONNECT
            intSelectedOption = lvwText
            
            Set itmFound = lvOnline. _
                FindItem(cDataReceived, intSelectedOption, , lvwPartial)
        
            For x = 0 To 20
                If cDataReceived = users(x) Then users(x) = ""
            Next x
            
            Dim itmX
            'Add their name to the array
            users(Index) = cDataReceived
            If itmFound Is Nothing Then  ' If no match, inform user and exit.
                Set itmX = lvOnline.ListItems. _
                    Add(, , cDataReceived)
            End If
        Case LOG_IN
            strArray = Split(cDataReceived, "--")
            
            UserCode = strArray(1)
            
            If isLogin(UserCode) = True Then
                Send_Data Index, MESSAGES & Chr(1) & "Sorry you cannot login at the same time."
                DoEvents
                Exit Sub
            End If
            
            Check_User_Password Index, cDataReceived
        Case UPDATE_LISTVIEW
            Dim UserCodeTemp As String
            
            strArray = Split(cDataReceived, "--")

            CompName = strArray(0)
            UserCode = strArray(1)
            RunningTime = strArray(3)
            
            intIndex = lvOnline.FindItem(CompName).Index
            
            UserCodeTemp = lvOnline.ListItems(intIndex).SubItems(1)
            
            If UserCodeTemp = "" Then 'UserCode is empty so fail it again including the other date. This could cause from server error
'                if me.WinsockSubServer(intindex).State =
                Send_Data Index, FILL_LISTVIEW_AGAIN
                
                DoEvents
                
                Exit Sub
            End If
            
            TimePlanID = lvOnline.ListItems(intIndex).SubItems(10)

            If UserCode = "" Then 'May be empty because only computer name is updated...
                Update_Listview_Record cDataReceived
            ElseIf UserCode = "UNLIMITED" Then
                curChargePerHour = ChargePerHour(TimePlanID)
                
                With lvOnline.ListItems(intIndex)
                    TotalAmount = .SubItems(2)
                    UsedAmount = RunningTime * (curChargePerHour / 60)
                    LeftAmount = .SubItems(4)
                    TotalHour = .SubItems(5)
                    UsedHour = Format(DateAdd("n", RunningTime, "00:00"), "HH:mm")
                    LeftHour = .SubItems(7)
                    TimeIn = .SubItems(8)
                    TimePlan = .SubItems(9)
                    TimePlanID = .SubItems(10)
                    
                    cDataReceived = CompName & "--" & UserCode & "--" & _
                            TotalAmount & "--" & UsedAmount & "--" & _
                            LeftAmount & "--" & TotalHour & "--" & UsedHour & "--" & _
                            LeftHour & "--" & TimeIn & "--" & TimePlan & "--" & TimePlanID
                        
                    Update_Listview_Record cDataReceived
                
                'Saves the record...basi mag brownout...weeeee
'                Save_Data strArray(1), lvOnline.ListItems(intIndex).SubItems(10), lvOnline.ListItems(intIndex).SubItems(9)
                End With
            Else
                With lvOnline.ListItems(intIndex)
                    curChargePerHour = ChargePerHour(TimePlanID)
                    
                    TotalAmount = .SubItems(2)
                    TotalHour = .SubItems(5)
                    TimeIn = .SubItems(8)
                    TimePlan = .SubItems(9)
                    
                    curChargePerMin = curChargePerHour / 60
                    
                    TotalHourTemp = TotalAmount / curChargePerMin
                    TotalHourTemp = Format(DateAdd("n", TotalHourTemp, "00:00"), "h:m")
                    
                    If TotalHour = TotalHourTemp Then
                    
                        UsedAmount = RunningTime * curChargePerMin
                        LeftAmount = TotalAmount - UsedAmount
                        UsedHour = Format(DateAdd("n", RunningTime, "00:00"), "HH:mm")
                        LeftHour = CDate(TotalHour) - CDate(UsedHour)
                                                        
                        cDataReceived = CompName & "--" & UserCode & "--" & _
                                TotalAmount & "--" & UsedAmount & "--" & _
                                LeftAmount & "--" & TotalHour & "--" & UsedHour & "--" & _
                                Format(CDate(LeftHour), "hh:mm") & "--" & TimeIn & "--" & TimePlan & "--" & TimePlanID

                        Update_Listview_Record cDataReceived
                        
                        'Saves the record...basi mag brownout...weeeee
                        Save_Data UserCode, curChargePerMin, TimeIn
                    Else 'If Charge Per Minute change
                        UsedAmount = RunningTime * (curChargePerHour / 60)
                        LeftAmount = TotalAmount - UsedAmount
                        UsedHour = Format(DateAdd("n", RunningTime, "00:00"), "HH:mm")
                        LeftHour = CDate(TotalHour) - CDate(UsedHour)
                                                        
                        cDataReceived = CompName & "--" & UserCode & "--" & _
                                TotalAmount & "--" & UsedAmount & "--" & _
                                LeftAmount & "--" & TotalHour & "--" & UsedHour & "--" & _
                                Format(CDate(LeftHour), "hh:mm") & "--" & TimeIn & "--" & TimePlan & "--" & TimePlanID

                        Update_Listview_Record cDataReceived
                        
                        'Saves the record...basi mag brownout...weeeee
                        Save_Data UserCode, UsedAmount, TimeIn
                        
                        Send_Data intIndex, INTERNET_RECORD & Chr(1) & UserCode & "|" & CStr(Format(TotalHour, "h:m")) & "--" & "0.00" _
                            & "--" & CStr(Format(LeftHour, "h:m")) & "--" & 0
                        DoEvents

                    End If
                End With
            End If
        Case FILL_LISTVIEW_AGAIN
            Update_Listview_Again cDataReceived
        Case LOG_OUT
            strArray = Split(cDataReceived, "--")
            
            CompName = strArray(0)
            UserCode = strArray(1)
            
            intIndex = lvOnline.FindItem(CompName).Index
            
            UsedAmount = lvOnline.ListItems(intIndex).SubItems(3)
            TimeIn = lvOnline.ListItems(intIndex).SubItems(8)
            
            Save_Data UserCode, UsedAmount, TimeIn, True
            
            Update_Listview_Record CompName & _
            "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & "" & "--" & ""

            DoEvents
        Case EXIT_CLIENT
            lvOnline.ListItems.Remove lvOnline.FindItem(cDataReceived).Index
            WinsockSubServer(Index).Close
    End Select
    
    Exit Sub
    
err_Received_Data:
    lblStatus = Err.Number & "-" & Err.Description & " Received_Data procedure call"
End Sub

Private Sub Save_Data(UserCode As String, UsedAmount As Currency, DateTimeLogin As Date, Optional SaveHistory As Boolean = False)
On Error GoTo err_Save_Data
    Dim RunningTime As Integer
    
'    If RunningTime < 1 Then Exit Sub
    
    Dim adoUsersRS As ADODB.Recordset
    
    Set adoUsersRS = New ADODB.Recordset
    
    With adoUsersRS
    
        adoUsersRS.Open "SELECT * FROM [Users] " _
                & "WHERE UserCode = '" & UserCode & "'", db, adOpenStatic, adLockOptimistic
                        
        If .RecordCount > 0 Then
'            !UsedHour = DateAdd("n", RunningTime, !UsedHour)
            !UsedAmount = !UsedAmount + UsedAmount
            .Update
            .Close
        End If
    End With
    
    If SaveHistory = False Then Exit Sub
    
    Dim adoHistoryRS As ADODB.Recordset
    
    Set adoHistoryRS = New ADODB.Recordset
    
    With adoHistoryRS
        adoHistoryRS.Open "Select * From[Login History]", db, adOpenStatic, adLockOptimistic
        
        .AddNew
        !UserCode = UserCode
        !DateTimeLogin = DateTimeLogin
        !DateTimeLogout = Now()
        !Amount = UsedAmount 'RunningTime / 3
        
        .Update
        .Close
    End With
    
    Exit Sub
    
err_Save_Data:
    lblStatus = Err.Number & "-" & Err.Description & " Save_Data procedure call"
End Sub

Private Sub Connect_Users()
On Error GoTo err_Connect_Users

    Dim MyFormat As StdDataFormat
        
    Set adoPrimaryRS = New ADODB.Recordset
    
    adoPrimaryRS.Open "Select * From Users Order by UserCode", db, adOpenStatic, adLockOptimistic
        
    Dim adoDetailRS As ADODB.Recordset
    
    Set adoDetailRS = New ADODB.Recordset
    
    With adoDetailRS
        .Open "Select * From [Users Details] Order by UserCode", db, adOpenStatic, adLockOptimistic

        .MoveFirst
        
        If .RecordCount < 1 Then Exit Sub
        
        Dim i As Integer
        
        For i = 1 To .RecordCount
            lvUsers.ListItems.Add , , !UserCode
            lvUsers.ListItems(i).SubItems(1) = !TotalAmount
            lvUsers.ListItems(i).SubItems(2) = !UsedAmount
            lvUsers.ListItems(i).SubItems(3) = !LeftAmount
            lvUsers.ListItems(i).SubItems(4) = !TotalHour
            lvUsers.ListItems(i).SubItems(5) = Format(!UsedHour, "Short Time")
            lvUsers.ListItems(i).SubItems(6) = !LeftHour
            
            .MoveNext
        Next i
        
        .Close
    End With
    
    Exit Sub
    
err_Connect_Users:
    lblStatus = Err.Number & "-" & Err.Description & " Connect_Users procedure call"
End Sub

Private Sub cmdAdd_Click()
  On Error GoTo AddErr
  With adoPrimaryRS
    If Not (.BOF And .EOF) Then
      mvBookMark = .Bookmark
    End If
    .AddNew
'    lblRecord.Caption = "Add record"
    mbAddNewFlag = True
    SetButtons False
  End With

  Exit Sub
AddErr:
  MsgBox Err.Description
End Sub

Private Sub cmdDelete_Click()
    On Error GoTo DeleteErr
        
    If MsgBox("Are you sure you want to delete this record?", vbInformation + vbYesNo) = vbYes Then
        With adoPrimaryRS
            .Delete
            .MoveNext
        If .EOF Then .MoveLast
        End With
    End If
    
    Exit Sub
DeleteErr:
    MsgBox Err.Description
End Sub

Private Sub cmdEdit_Click()
  On Error GoTo EditErr

  SetButtons False

  Exit Sub

EditErr:
  MsgBox Err.Description
End Sub

Private Sub cmdCancel_Click()
  On Error Resume Next

  SetButtons True
  mbEditFlag = False
  mbAddNewFlag = False
  adoPrimaryRS.CancelUpdate
  If mvBookMark > 0 Then
    adoPrimaryRS.Bookmark = mvBookMark
  Else
    adoPrimaryRS.MoveFirst
  End If
  mbDataChanged = False

End Sub

Private Sub cmdUpdate_Click()
    On Error GoTo UpdateErr

    SetButtons True
    
    With adoPrimaryRS
        !UserCode = txtFields(0).Text
        !Name = txtFields(1).Text
        !Password = txtFields(2).Text
        !TimePlanID = cboTimePlan.Tag
    
        adoPrimaryRS.Update
    End With
    
    Exit Sub
UpdateErr:
    MsgBox Err.Description
End Sub

Private Sub SetButtons(bVal As Boolean)
  cmdAdd.Visible = bVal
  cmdEdit.Visible = bVal
  cmdUpdate.Visible = Not bVal
  cmdCancel.Visible = Not bVal
  cmdDelete.Visible = bVal
End Sub

Private Function isLogin(cDataReceived As String) As Boolean
    Dim intSelectedOption
    Dim itmFound
    
    intSelectedOption = lvwSubItem
    
    Set itmFound = lvOnline. _
        FindItem(cDataReceived, intSelectedOption, , lvwPartial)
        
    If itmFound Is Nothing Then   ' If not match, inform user and exit.
        isLogin = False
    Else
        isLogin = True
    End If
End Function

Private Sub Update_Listview_Again(cDataReceived As String)
    Dim adoUsersRS As ADODB.Recordset
    Dim strArray() As String
    Dim CompName As String
    Dim UserCode As String
    Dim TimePlanID As Integer
    Dim TimePlan As String
    Dim intIndex As Integer
    Dim curChargePerHour As Currency
    Dim curChargePerMin As Currency
    Dim TotalAmount As Currency
    Dim UsedAmount As Currency
    Dim LeftAmount As Currency
    Dim TotalHour As Date
    Dim UsedHour As Date
    Dim LeftHour As Date
    Dim RunningTime As Integer
    Dim TimeIn  As Date
    
    strArray = Split(cDataReceived, "--")
    
    CompName = strArray(0)
    UserCode = strArray(1)
    RunningTime = strArray(5)
    
    Set adoUsersRS = New ADODB.Recordset

    With adoUsersRS
        .Open "Select * From [Users Details] Where UserCode = '" & UserCode & "'", db, adOpenStatic, adLockOptimistic
        
        If .RecordCount > 0 Then
            TimePlanID = !TimePlanID
            TimePlan = !Plan
        End If
        .Close
    End With
    
    intIndex = lvOnline.FindItem(CompName).Index
    
    curChargePerHour = ChargePerHour(TimePlanID)
    curChargePerMin = curChargePerHour / 60
    
    TotalAmount = Minute(strArray(2)) * curChargePerMin
    UsedAmount = RunningTime * curChargePerMin
    LeftAmount = TotalAmount - UsedAmount
    TotalHour = strArray(2)
    UsedHour = strArray(3)
    LeftHour = strArray(4)
    TimeIn = Now() - CDate(UsedHour)
    
    cDataReceived = CompName & "--" & UserCode & "--" & _
            TotalAmount & "--" & UsedAmount & "--" & _
            LeftAmount & "--" & TotalHour & "--" & UsedHour & "--" & _
            LeftHour & "--" & TimeIn & "--" & TimePlan & "--" & TimePlanID
    
    Update_Listview_Record cDataReceived
End Sub


