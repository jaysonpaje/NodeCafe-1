Imports System.Runtime.Remoting
Public Class frmServer
    Dim remoteObj As InternetCafeRPC.RPCObject
    Dim curClientIP As String = ""
    Public Sub GetRemoteObject()
        RemotingConfiguration.Configure("InternetCafeServer.exe.config", False)
        remoteObj = CType(Activator.GetObject(GetType(InternetCafeRPC.RPCObject), "tcp://localhost:5747/RemoteObj"), InternetCafeRPC.RPCObject)
    End Sub
    Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetRemoteObject()
        AddHandler remoteObj.ClientRegistered, AddressOf remoteObj_ClientRegistered

    End Sub

    Public Sub remoteObj_ClientRegistered(ByVal ip As String)
        Dim Client As New TheClient(ip)
        Client.State = ClientState.Closed
        RenderClient()
    End Sub

    Private Sub btnOpenSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenSession.Click
        If curClientIP = "" Then Return
        remoteObj.RemoteStartTimer(curClientIP, Now)
        CType(TheClient.AllClients.Item(curClientIP), TheClient).StartTime = Now
        CType(TheClient.AllClients.Item(curClientIP), TheClient).State = ClientState.Opened

        RenderClient()
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        remoteObj.RemoteAction(curClientIP, InternetCafeRPC.ActionType.Shutdown)
    End Sub

    Public Sub RenderClient()
        If TheClient.AllClients.Count > 0 Then
            lvwClients.Items.Clear()

            For Each client As DictionaryEntry In TheClient.AllClients
                Dim tmp As TheClient = CType(client.Value, TheClient)
                Dim imgIndx As Integer
                If (tmp.State = ClientState.Opened) Then
                    imgIndx = 0
                Else
                    imgIndx = 1
                End If
                lvwClients.Items.Add(tmp.IP, tmp.IP, imgIndx)


            Next
        End If


    End Sub

    Private Sub lvwClients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwClients.SelectedIndexChanged
        If lvwClients.SelectedItems.Count > 0 Then
            curClientIP = lvwClients.SelectedItems(0).Text
            TimerCounter_Tick(Nothing, Nothing)
        End If

    End Sub

    Private Sub TimerCounter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCounter.Tick
        If curClientIP <> "" Then
            Dim client As TheClient
            client = TheClient.AllClients.Item(curClientIP)

            If client.State = ClientState.Closed Then
                txtState.Text = "Closed"
                Return
            Else
                txtState.Text = "Opened"
                txtCurrentTime.Text = String.Format("{0:hh:mm:ss tt}", TheClient.CurrentTime())
                txtStartTime.Text = String.Format("{0:hh:mm:ss tt}", client.StartTime)
                txtMinuteUsed.Text = client.UsedMinute().ToString()
            End If



        End If
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        remoteObj.RemoteAction(curClientIP, InternetCafeRPC.ActionType.Restart)
    End Sub

    Private Sub btnCloseSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseSession.Click
        Dim useTime As Long = CType(TheClient.AllClients.Item(curClientIP), TheClient).UsedMinute

        txtTotalPrice.Text = (Long.Parse(txtUnitPrice.Text) / 60) * useTime

        CType(TheClient.AllClients.Item(curClientIP), TheClient).State = ClientState.Closed
        remoteObj.RemoteAction(curClientIP, InternetCafeRPC.ActionType.CloseSession)

        RenderClient()
    End Sub
End Class
