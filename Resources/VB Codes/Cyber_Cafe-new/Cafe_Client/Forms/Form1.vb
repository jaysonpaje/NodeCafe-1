Imports System.Net, System.Net.Sockets
Imports System.Text.ASCIIEncoding
Public Class frmClient
    Dim client As Socket
    Dim host As String = "127.0.0.1"
    Dim port As Integer = "6969"
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        client = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim IP As IPAddress = IPAddress.Parse(host)
        Dim xIpEndPoint As IPEndPoint = New IPEndPoint(IP, port)
        client.BeginConnect(xIpEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)
        btnConnect.Enabled = False
    End Sub

    Private Sub OnConnect(ByVal ar As IAsyncResult)
        Try
            client.EndConnect(ar)
            MessageBox.Show("Connected")
        Catch ex As Exception
            MsgBox(ex.ToString)
            'btnConnect.Enabled = True
        End Try
        
    End Sub
    Private Sub OnSend(ByVal ar As IAsyncResult)
        client.EndSend(ar)
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim bytes As Byte() = ASCII.GetBytes(txtMessage.Text)
        client.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), client)
    End Sub

    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class