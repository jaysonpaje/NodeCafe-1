Imports System.Net, System.Net.Sockets
Imports System.Text.UnicodeEncoding
Module ModPackets
    Public Sub execute_Msg(ByVal msg As String)
        Try
            Dim bytes As Byte() = Unicode.GetBytes(msg)
            clientSocket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), Nothing)
        Catch ex As Exception
            MsgBox("Client is not yet ready")
        End Try
    End Sub
    Private Sub OnSend(ByVal ar As IAsyncResult)
        ' Dim client As Socket = ar.AsyncState
        ' client.EndSend(ar)
        clientSocket.EndSend(ar)
    End Sub
    Public Sub recon_confirm(ByVal client As Socket) '94 reconfirm
        settings()
        getTime()
        _packets_msg = Nothing
        _packets_msg = header & "À€À€" & _pcno & "À€" & _seconds & "À€19bÀ€À€9À€1À€94À€" & x & "À€91À€04À€64À€07À€208À€39À€"
        execute_Msg(_packets_msg)
        'send_message(client)
    End Sub
    Public Sub handshake_confirm(ByVal client As Socket) '93 for handshake
        settings()
        _packets_msg = Nothing
        _packets_msg = header & "À€À€" & _pcno & "À€9À€14À€À€9À€1À€93À€" & encrypt(_ipAddress) & "À€94À€09À€64À€08À€206À€85À€"
        execute_Msg(_packets_msg)
        'send_message(client)
    End Sub
    Public Sub send_time_out(ByVal client As Socket) '92 send time out request
        _packets_msg = Nothing
        _packets_msg = header & "À€À€" & _pcno & "À€9À€14À€À€9À€1À€92À€À€94À€09À€64À€08À€206À€85À€"
        execute_Msg(_packets_msg)
    End Sub
    Public Sub test(ByVal client As Socket)
        _packets_msg = header & "À€À€15À€3À€14À€À€9À€1À€11À€" & encrypt("127.0.0.1") & "À€94À€10À€64À€0À€208À€32À€"
        execute_Msg(_packets_msg)
    End Sub
    Public Sub send_message(ByVal client As Socket)
        _packets_msg = "1À€À€5À€3À€14À€À€9À€1À€2052À€testmessage1À€À€5À€3À€14À€À€9À€1À€205À€"
        execute_Msg(_packets_msg)
    End Sub
End Module
