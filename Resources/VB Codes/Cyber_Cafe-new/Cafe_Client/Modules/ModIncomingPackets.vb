Imports System.Diagnostics
Imports System.Net, System.Net.Sockets
Imports System.Text.UnicodeEncoding
Module ModIncomingPackets
    Public Sub check_msg(ByVal msg As String, ByVal client As Socket)
        Dim _arSplit
        _arSplit = Split(msg, "À€")
        Select Case _arSplit(8)
            Case 79 'server request to refresh the client
                client.Close()
                clientSocket.Close()
                frmClient.Timer2.Enabled = False
            Case 80 'client data has been load
                _setTime = Split(_arSplit(3), "/")(0) 'get the fix time
                'MsgBox(_arSplit(3) & " - " & Split(_arSplit(3), "/")(0) & " - " & Split(_arSplit(3), "/")(1))
                x = Split(_arSplit(3), "/")(1)
                frmClient.Timer2.Enabled = True
                Call writeFileStrData(_setTime, Application.StartupPath & "\settime.ini", , "Unicode")
            Case 81 'save client, meaning its been save so that it can load again
                frmClient.Timer2.Enabled = False
                x = 0
                Call writeFileStrData(0, Application.StartupPath & "\settime.ini", , "Unicode")
                Call writeFileStrData(x, Application.StartupPath & "\time.ini", , "Unicode")
                frmClient.Hide()
                frmBG.Show()
            Case 82 'extend time
                _setTime = _arSplit(3) 'get the fix time
                Call writeFileStrData(_setTime, Application.StartupPath & "\settime.ini", , "Unicode")
            Case 83 'resume
                'frmClient.Timer2.Enabled = True
                frmClient.Show()
                getSetTime()
                frmClient.Timer2.Start()
                frmBG.Close()
            Case 84 'client_resume_dc
                x = _arSplit(0)
                getSetTime()
                'frmClient.Timer2.Enabled = True
                frmClient.Timer2.Start()
                frmClient.Show()
                frmBG.Close()
            Case 85 'pause
                'frmClient.Timer2.Enabled = False
                frmClient.Hide()
                frmBG.Show()
                frmClient.Timer2.Stop()
            Case 87 ' start
                frmClient.lblprice.Text = 0
                _setTime = _arSplit(3) 'get the fix time
                Call writeFileStrData(_setTime, Application.StartupPath & "\settime.ini", , "Unicode")
                frmBG.Close()
                'frmClient.Timer2.Enabled = True
                frmClient.Timer2.Start()
                frmClient.Show()
            Case 99 'restart
                frmClient.Timer2.Stop()
                System.Diagnostics.Process.Start("Shutdown", "/r /t 1")
            Case 100 'shutdown
                frmClient.Timer2.Stop()
                System.Diagnostics.Process.Start("Shutdown", "/s /t 1")
            Case 64 ' stop
                frmClient.Timer2.Enabled = False
                'frmClient.Timer2.Start()
                x = 0
                frmClient.lblprice.Text = 0
                Call writeFileStrData(0, Application.StartupPath & "\settime.ini", , "Unicode")
                Call writeFileStrData(x, Application.StartupPath & "\time.ini", , "Unicode")
                frmClient.Hide()
                frmBG.Show()
            Case 102
                Call destroy_all()
            Case 103 ' request recon
                recon_confirm(client)
            Case 205 'request handshake
                'verify the handshake
                If descrypt(_arSplit(9)) = "cyber_cafebychoi_and_nico" Then
                    '_mPass = _arSplit(1)
                    '  MsgBox(_mPass)
                    If Not settings() Then
                        Call writeFileStrData(_arSplit(10) & "::" & _arSplit(1), Application.StartupPath & "\Config.ini", , "Unicode")
                    Else
                        'MsgBox("E")
                        Call writeFileStrData(_arSplit(10) & ":" & server_ipAddress.ToString & ":" & _arSplit(1), Application.StartupPath & "\Config.ini", , "Unicode")
                    End If
                    handshake_confirm(client)
                End If
            Case 206 ' get rates
                Dim x As Integer
                Dim _xsplit
                _xsplit = Split(_arSplit(9), ",")
                For x = 0 To UBound(_xsplit)
                    If InStr(_xsplit(x), ":") > 0 Then
                        ReDim Preserve _rates(Split(_xsplit(x), ":")(0))
                        _rates(Split(_xsplit(x), ":")(0)) = Split(_xsplit(x), ":")(1)
                    Else
                        AmtinHr = _rates(Split(_xsplit(x - 1), ":")(0))
                        IsDisc = _xsplit(x)
                    End If
                Next
            Case Else
                MsgBox(msg)
        End Select

    End Sub
    Sub destroy_all()
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcesses()
        For Each myProcess In myProcesses
            If kill_list(myProcess.ProcessName) Then
                myProcess.Kill()
            End If
        Next
    End Sub
    Function kill_list(ByVal process As String) As Boolean
        Dim list As String
        Dim k, i
        list = ("chrome,firefox,notepad,msword,opera,warcraftIII")
        k = Split(list, ",")
        For i = 0 To UBound(k) - 1
            If UCase(k(i)) = UCase(process) Then
                Return True
            End If
        Next
    End Function

End Module
