Imports System.Net, System.Net.Sockets
Imports System.Text.UnicodeEncoding
Public Class frmClient2
    
    Dim connected As Boolean
    Dim i As Integer
    ' Dim cSocket As Socket
    Dim bytes As Byte() = New Byte(0) {}
    Dim clientSocket As Socket
    Dim byteData(2024) As Byte
    Dim ipAddress As IPAddress = ipAddress.Parse("127.0.0.1")
    Dim ipEndPoint As IPEndPoint = New IPEndPoint(ipAddress, 8800)
    Dim conCounter As Integer = 0
    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            'Dim client As Socket = ar.AsyncState
            'client.EndReceive(ar)
            clientSocket.EndReceive(ar)
            Dim bytesRec As Byte() = byteData
            Dim message As String = System.Text.UnicodeEncoding.Unicode.GetString(bytesRec)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
            Call check_msg(message)

        Catch ex As Exception
            clientSocket.Close()
            connected = False
            Debug.Print("On receive")
            'MsgBox("On receive : " & ex.ToString)
        End Try
    End Sub
    Private Sub OnConnect(ByVal ar As IAsyncResult)
        Try
            'Timer2.Enabled = True
            clientSocket.EndConnect(ar)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
            connected = True
            settings()
            If conCounter = 0 Then
                header = "05"
            End If
            conCounter += 1

        Catch ex As Exception
            clientSocket.Close()
            connected = False
            header = "06"
            'MsgBox("On Connect : " & ex.ToString)
        End Try
    End Sub

    Private Sub frmClient2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connected = False
        'Button3_Click(0, AcceptButton)
        ' Timer2.Enabled = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 1
        If i = 3 Then
            'MsgBox(i)
            If connected = False Then
                Try

                    clientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                    clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)

                    'clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)

                Catch ex As Exception
                    connected = False
                    MsgBox(ex.ToString)
                End Try
            End If
            i = 0
        End If
    End Sub
    Private Sub OnSend(ByVal ar As IAsyncResult)
        Try
            clientSocket.EndSend(ar)
        Catch ex As Exception
            clientSocket.Close()
            MsgBox("On send : " & ex.ToString)
        End Try

    End Sub
    Public Sub testzz()
        'Timer2.Enabled = True
        'Button3.PerformClick()
        ' Button3_Click(0, AcceptButton)
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'test(cSocket)
        'Dim bytes As Byte() = ASCII.GetBytes("cyber_cafe10zÀ€b1xÀ€`hw4_À€le")
        'cSocket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), clientSocket)
        Try
            Dim bytes As Byte() = Unicode.GetBytes("À€À€5À€3À€14À€À€9À€1À€9123À€444")
            clientSocket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), Nothing)
        Catch ex As Exception
            clientSocket.Close()
            MsgBox("button : " & ex.ToString)
        End Try
        
    End Sub
    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'FrmTimer.Show()
        Call check_msg("1À€À€5À€3À€14À€À€9À€1À€87À€0À€64À€0À€206À€32À€")
    End Sub
End Class