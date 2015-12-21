Imports System.Net, System.Net.Sockets
Module ModPackets
    Public Sub execute_Msg(ByVal msg As String, ByVal client As Socket)
        Try
            Dim sendBytes As Byte() = System.Text.UnicodeEncoding.Unicode.GetBytes(msg)
            client.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), client)
        Catch ex As Exception
            MsgBox("Module: ModPackets, function: execute_msg " & vbCrLf & ex.ToString)
            'MsgBox("Client is not yet ready")
        End Try
    End Sub
    Private Sub OnSend(ByVal ar As IAsyncResult)
        Dim client As Socket = ar.AsyncState
        client.EndSend(ar)
    End Sub
    Public Sub client_load(ByVal client As Socket, ByVal _timeSet As Double, ByVal _elapseTime As Double) '80
        _packet_msg = "1À€À€5À€" & _timeSet & "/" & _elapseTime & "À€14À€À€9À€1À€80À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub notify_Msg(ByVal client As Socket) '99
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€99À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_pause(ByVal client As Socket) '85
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€85À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_resume_dc(ByVal client As Socket, ByVal dcsec As Long) '84
        _packet_msg = dcsec & "À€À€5À€3À€14À€À€9À€1À€84À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_resume(ByVal client As Socket) '83
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€83À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub

    Public Sub client_start(ByVal client As Socket, ByVal seconds As Double) '87
        _packet_msg = "1À€À€5À€" & seconds & "À€14À€À€9À€1À€87À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_stop(ByVal client As Socket) '64
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€64À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_restart(ByVal client As Socket) '99
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€99À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_shutdown(ByVal client As Socket) '100
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€100À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub send_extend_time(ByVal client As Socket, ByVal seconds As Double) '82
        _packet_msg = "1À€À€5À€" & seconds & "À€14À€À€9À€1À€82À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_save(ByVal client As Socket) '81
        _packet_msg = "1À€À€5À€À€14À€À€9À€1À€81À€0À€64À€0À€202À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub client_refresh(ByVal client As Socket) '79
        _packet_msg = "1À€À€5À€À€14À€À€9À€1À€79À€0À€64À€0À€202À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub send_message(ByVal client As Socket)
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€2052À€testmessage1À€À€5À€3À€14À€À€9À€1À€205À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub request_handshake(ByVal c_pass As String, ByVal client As Socket, ByVal no As Integer)
        'MsgBox("request")
        _packet_msg = "1À€" & c_pass & "À€5À€3À€14À€À€9À€1À€205À€" & encrypt("cyber_cafebychoi_and_nico") & "À€" & no & "À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
    Public Sub requestRecon(ByVal client As Socket)
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€103À€0À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub

    Public Sub sendRates(ByVal client As Socket, ByVal rList As String)
        _packet_msg = "1À€À€5À€3À€14À€À€9À€1À€206À€" & rList & "À€64À€0À€206À€32À€"
        execute_Msg(_packet_msg, client)
    End Sub
End Module
