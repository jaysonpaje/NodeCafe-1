Imports System.Net, System.Net.Sockets
Imports System.Text.UnicodeEncoding
Public Class frmClient2
    Dim clientSocket As Socket
    Dim byteData(2024) As Byte
    Dim ipAddress As IPAddress = ipAddress.Parse("127.0.0.1")
    Dim ipEndPoint As IPEndPoint = New IPEndPoint(IPAddress, 8800)
    Dim i As Integer
    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            Dim client As Socket = ar.AsyncState
            client.EndReceive(ar)
            Dim bytesRec As Byte() = byteData
            Dim message As String = System.Text.UnicodeEncoding.Unicode.GetString(bytesRec)
            Read(message)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
        Catch ex As Exception
            clientSocket.Close()
            connected = False
        End Try
    End Sub
    Private Sub OnConnect(ByVal ar As IAsyncResult)
        Try
            clientSocket.EndConnect(ar)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
            connected = True
        Catch ex As Exception
            clientSocket.Close()
            connected = False
            'MsgBox(ex.ToString)
        End Try
        
    End Sub

    Delegate Sub _Read(ByVal msg As String)
    Private Sub Read(ByVal msg As String)
        If InvokeRequired Then
            Invoke(New _Read(AddressOf Read), msg)
            Exit Sub
        End If
        Call check_msg(Trim(msg))
        'Button1_Click(1, AcceptButton)
        'RichTextBox1.Text &= msg

    End Sub

    Private Sub frmClient2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim bytes As Byte() = ASCII.GetBytes("closing")
            clientSocket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), clientSocket)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub frmClient2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connected = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 1
        If i = 3 Then
            'MsgBox(i)
            If connected = False Then
                '    Try

                clientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), clientSocket)
                'clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing )

                '    Catch ex As Exception
                '    connected = False
                '    MsgBox(ex.ToString)
                'End Try
            End If
            i = 0
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bytes As Byte() = ASCII.GetBytes("cyber_cafe10zÀ€b1xÀ€`hw4_À€le")
        clientSocket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), clientSocket)
    End Sub
    Private Sub OnSend(ByVal ar As IAsyncResult)
        clientSocket.EndSend(ar)
    End Sub
End Class