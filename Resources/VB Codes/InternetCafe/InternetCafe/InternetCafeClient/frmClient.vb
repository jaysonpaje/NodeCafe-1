Imports System.Runtime.Remoting
Imports System.Net

Public Class frmClient
    Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Dim remoteObj As InternetCafeRPC.RPCObject

    Dim startTime As DateTime
    Dim currentTime As DateTime

    Dim lock As New frmScreenLock

    Dim locked As Boolean = True

    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        MoveToRightBottom()

        CloseSession()
        'startCounter(Now)

        GetRemoteObject()
        Register()


    End Sub

    Private Sub MoveToRightBottom()
        'Move the client form to the right and bottom of the screen
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
        Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height
    End Sub

    Private Sub timerCounter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCounter.Tick
        'Calculate and run time on the client every minute
        If locked = True Then Return

        currentTime = DateAdd(DateInterval.Second, 1, currentTime)
        Dim usedTime As Long
        usedTime = DateDiff(DateInterval.Minute, startTime, currentTime)

        txtUsedTime.Text = usedTime.ToString
        Me.Text = usedTime.ToString & " Minutes Used"

        txtCurrentTime.Text = String.Format("{0:hh:mm:ss tt}", currentTime)

    End Sub

    Public Sub startCounter(ByVal time As DateTime)

        startTime = time
        txtStartTime.Text = String.Format("{0:hh:mm:ss tt}", startTime)
        currentTime = time
        txtCurrentTime.Text = String.Format("{0:hh:mm:ss tt}", currentTime)

        timerCounter.Interval = 1000
        timerCounter.Enabled = True
        txtUsedTime.Text = "0"
        Me.Text = "0 Minutes Used"
        OpenSession()
    End Sub

    Public Sub CloseSession()
        locked = True

        lock.Show()
        Me.Hide()
        'lock.TopMost = True
        apiBlockInput(1)
    End Sub
    Public Sub OpenSession()
        locked = False
        lock.Hide()
        Me.Show()
        apiBlockInput(0)

    End Sub

    Private Sub btnCloseSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseSession.Click
        CloseSession()

    End Sub


    Private Sub frmClient_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True 'disable closing form / application by user
    End Sub

    Public Sub GetRemoteObject()
        RemotingConfiguration.Configure("InternetCafeClient.exe.config", False)
        remoteObj = CType(Activator.GetObject(GetType(InternetCafeRPC.RPCObject), My.Settings.RemoteURI), InternetCafeRPC.RPCObject)
    End Sub

    Public Sub Register()
        Dim ip As String = GetIP()
        remoteObj.RegisterAsClient(ip)
        remoteObj.RegisterStartTimer(ip, New InternetCafeRPC.ActionStartTimer(AddressOf startCounter))
        remoteObj.RegisterAction(ip, InternetCafeRPC.ActionType.Shutdown, New InternetCafeRPC.Action(AddressOf ShutDown))
        remoteObj.RegisterAction(ip, InternetCafeRPC.ActionType.Restart, New InternetCafeRPC.Action(AddressOf Restart))
        remoteObj.RegisterAction(ip, InternetCafeRPC.ActionType.CloseSession, New InternetCafeRPC.Action(AddressOf CloseSession))
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Public Sub ShutDown()

        Shell("shutdown -s -f -t 0")

    End Sub

    Public Sub Restart()

        Shell("shutdown -r -f -t 0")

    End Sub

    Public Function GetIP() As String
        Dim ip As String
        ip = Dns.Resolve(Dns.GetHostName).AddressList(0).ToString()
        Return ip
    End Function

    Private Sub frmClient_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Application.Exit()
    End Sub
End Class
