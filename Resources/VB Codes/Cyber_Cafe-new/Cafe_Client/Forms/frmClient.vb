Imports System.Net, System.Net.Sockets
Imports System.Text.UnicodeEncoding
Public Class frmClient
    Dim connected As Boolean
    Dim i As Integer
    ' Dim cSocket As Socket
    Dim bytes As Byte() = New Byte(0) {}

    Dim byteData(2024) As Byte
    'Dim ipAddress As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim conCounter As Integer = 0
    Dim timeCounter As Double
    Public Function ScreenResolutionX() As String
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Return intX
    End Function


    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            'clientSocket.EndReceive(ar)
            Dim client As Socket = ar.AsyncState
            Dim bytesRec As Byte() = byteData
            Dim message As String = System.Text.UnicodeEncoding.Unicode.GetString(bytesRec)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
            Call Read(message, clientSocket)

        Catch ex As Exception
            clientSocket.Close()
            connected = False
            'Debug.Print("On receive")
            'MsgBox("On receive : " & ex.ToString)
        End Try
    End Sub
    Delegate Sub _Read(ByVal msg As String, ByVal client As Socket)
    Private Sub Read(ByVal msg As String, ByVal client As Socket)
        Dim arg(1)
        arg(0) = msg
        arg(1) = client
        If InvokeRequired Then
            Invoke(New _Read(AddressOf Read), arg)
            Exit Sub
        End If
        Call check_msg(msg, client)
    End Sub
    Private Sub OnConnect(ByVal ar As IAsyncResult)
        Try
            'Timer2.Enabled = True
            clientSocket.EndConnect(ar)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
            connected = True
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

        lblTimer.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                    0, _
                    0, _
                     0)
        frmBG.Show()
        connected = False

        Dim x As Integer
        x = Val(ScreenResolutionX())
        Me.Location = New Point(x - 285, 0)

        myIP = Dns.GetHostAddresses(Dns.GetHostName())
        If InStr(myIP(1).ToString, ".") > 0 Then
            If InStr(myIP(1).ToString, ":") > 0 Then
                Dim xsplit1, xsplit2
                xsplit1 = Split(myIP(1).ToString, ":")
                xsplit2 = Split(xsplit1(3).ToString, "%")
                _ipAddress = Trim(xsplit2(0).ToString)
                ' MsgBox(x_split(3))
            Else
                _ipAddress = Trim(myIP(1).ToString)
            End If
            '
        ElseIf InStr(myIP(2).ToString, ".") > 0 Then
            _ipAddress = Trim(myIP(2).ToString)
        Else
            'use loop back
            _ipAddress = "127.0.0.1"
        End If

        'lblPcNum.Text = _pcno
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
                    clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), clientSocket)

                    'clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)

                Catch ex As Exception
                    connected = False
                    'MsgBox("frmClient timer1 : " & ex.ToString)
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
            Dim bytes As Byte() = Unicode.GetBytes("À€À€5À€3À€142À€À€sendmessage29À€1À€9123À€444")
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
        'Call check_msg("1À€À€5À€3À€14À€À€9À€1À€87À€0À€64À€0À€206À€32À€")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        x += 1
        _hrs = ((x - x Mod 3600 Mod 60) _
                    - (x Mod 3600 - x Mod 3600 Mod 60)) / 3600
        _mins = (x Mod 3600 - x Mod 3600 Mod 60) / 60
        lblTimer.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _
                                         _hrs, _mins, x Mod 60)

        If (x Mod 60) = 0 Then
            Call writeFileStrData(x, Application.StartupPath & "\time.ini", , "Unicode")
            amountTopayMin = _rates(_mins)
            amountTopayHR = _checkHr(_hrs)
            lblprice.Text = amountTopayHR + amountTopayMin
        End If
        _hrs = ((_setTime - _setTime Mod 3600 Mod 60) _
            - (_setTime Mod 3600 - _setTime Mod 3600 Mod 60)) / 3600
        _mins = (_setTime Mod 3600 - _setTime Mod 3600 Mod 60) / 60
        lblset.Text = String.Format("{0:D2}:{1:D2}", _
                                         _hrs, _mins)
        If x >= _setTime Then

        End If
        '_setTime - x
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTimer.Click
        'amountTopayMin = tmp_amnt
        'txtamount.Text = amountTopayHR + amountTopayMin
    End Sub
    Private Function _checkHr(ByVal hr As Double) As Double
        If hr = 1 Then
            amountTopayHR = AmtinHr
        ElseIf hr = 2 Then
            amountTopayHR = (AmtinHr * 2 - IsDisc).ToString
        ElseIf hr = 3 Then
            amountTopayHR = (AmtinHr * 3 - IsDisc).ToString
        ElseIf hr = 4 Then
            amountTopayHR = (AmtinHr * 4 - (IsDisc * 2)).ToString
        End If
        If Val(hr) > 4 Then
            If Val(hr) Mod 2 = 0 Then
                amountTopayHR = Val(hr) / 2 * (hr * 2 - IsDisc)
            Else
                amountTopayHR = (Math.Floor(Val(hr) / 2) * (AmtinHr * 2 - IsDisc)) + AmtinHr
                'amountTopayHR = amountTopayHR + AmtinHr
            End If
        End If
        Return amountTopayHR
    End Function
End Class