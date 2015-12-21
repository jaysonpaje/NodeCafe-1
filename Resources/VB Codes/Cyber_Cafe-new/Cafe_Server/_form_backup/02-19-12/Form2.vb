Imports System.Net, System.Net.Sockets

Public Class frmServer2
    Dim serverSocket As Socket
    Dim clientSocket As Socket
    Dim x As Integer

    Private Sub frmServer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        serverSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim IpEndPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 8800)
        serverSocket.Bind(IpEndPoint)
        serverSocket.Listen(5)
        serverSocket.BeginAccept(New AsyncCallback(AddressOf OnAccept), Nothing)
    End Sub
    Private Sub OnAccept(ByVal ar As IAsyncResult)
        clientSocket = serverSocket.EndAccept(ar)
        serverSocket.BeginAccept(New AsyncCallback(AddressOf OnAccept), Nothing)
        AddClient(clientSocket)
    End Sub
    Delegate Sub _AddClient(ByVal client As Socket)
    Private Sub AddClient(ByVal client As Socket)

        If InvokeRequired Then
            Invoke(New _AddClient(AddressOf AddClient), client)
            Exit Sub
        End If
        Dim lvi As New ListViewItem(client.RemoteEndPoint.ToString)
        lvi.Tag = client
        lsvClients.Items.Add(lvi)
    End Sub
    Private Sub Send(ByVal msg As String, ByVal client As Socket)
        Dim i As Integer
        Try
            Dim sendBytes As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(msg)
            client.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), client)
        Catch ex As Exception
            For i = 0 To lsvClients.Items.Count - 1
                If lsvClients.Items(i).Text = client.LocalEndPoint.ToString Then
                    lsvClients.Items(i).Remove()
                End If
            Next
        End Try

    End Sub
    Private Sub OnSend(ByVal ar As IAsyncResult)
        Dim client As Socket = ar.AsyncState
        client.EndSend(ar)
    End Sub
    Private Sub SendMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendMessageToolStripMenuItem.Click
        'Send("Message from server", lsvClients.SelectedItems(0).Tag)
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If lsvClients.Items.Count > 0 Then
            Send(txtMessage.Text, lsvClients.FocusedItem.Tag)
        End If

    End Sub

    Private Sub lsvClients_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsvClients.MouseDoubleClick
        Send("Message from server", lsvClients.FocusedItem.Tag)
    End Sub

    Private Sub btn_destroy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_destroy.Click
        If lsvClients.Items.Count > 0 Then
            Send("destroy", lsvClients.FocusedItem.Tag)
        End If
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        If lsvClients.Items.Count > 0 Then
            Send("closeee", lsvClients.FocusedItem.Tag)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim y As Integer
        x += 1
        If x = 5 Then
            If lsvClients.Items.Count > 0 Then
                For y = 0 To lsvClients.Items.Count - 1
                    Send("checkkk", lsvClients.Items(y).Tag)
                Next
            End If
            x = 0
        End If
    End Sub
End Class