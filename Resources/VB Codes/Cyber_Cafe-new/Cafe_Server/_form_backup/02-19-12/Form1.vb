Imports System.Net
Imports System.Net.Sockets
Public Class frmServer
    Dim server As Socket
    Dim client As Socket
    Dim bytes As Byte() = New Byte(1023) {}
    Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        server = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim xEndpoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 6969)
        server.Bind(xEndpoint)
        server.Listen(2)
        server.BeginAccept(New AsyncCallback(AddressOf OnAccept), server)
    End Sub
    Private Sub OnAccept(ByVal ar As IAsyncResult)
        client = server.EndAccept(ar)
        client.BeginReceive(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnRecieve), client)
    End Sub
    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            client = ar.AsyncState
            client.BeginReceive(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnRecieve), client)
            Dim message As String = System.Text.ASCIIEncoding.ASCII.GetString(bytes)
            'client.Close()
            MsgBox(message, , "SERVER")
        Catch ex As Exception
            'MsgBox("A")
            'server.Listen(2)
            client.Close()
            server.BeginAccept(New AsyncCallback(AddressOf OnAccept), server)
        End Try

    End Sub
    Private Sub OnDisconnect()
        'client
        client.Close()
    End Sub

    Private Sub btn_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click

    End Sub
End Class