Imports System.Net, System.Net.Sockets
Imports System.IO
Module ModProcedure
    Dim dataBytes() As Byte
    Dim openedFileStream As System.IO.Stream
    Dim tmpStr As String

    Public Sub getTime()
        Try
            frmClient.OpenFileDialog1.FileName = Application.StartupPath & "\time.ini"
            openedFileStream = frmClient.OpenFileDialog1.OpenFile()

            ReDim dataBytes(openedFileStream.Length - 1) 'Init 
            openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
            openedFileStream.Close()
            _seconds = System.Text.Encoding.Unicode.GetString(dataBytes)
        Catch ex As Exception
            _seconds = 0
        End Try
        'MsgBox(_pcno)
    End Sub
    Public Function settings() As Boolean
        Try
            frmClient.OpenFileDialog1.FileName = Application.StartupPath & "\Config.ini"
            openedFileStream = frmClient.OpenFileDialog1.OpenFile()
            'End With
            ReDim dataBytes(openedFileStream.Length - 1) 'Init 
            openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
            openedFileStream.Close()
            tmpStr = System.Text.Encoding.Unicode.GetString(dataBytes)
            _pcno = Split(tmpStr, ":")(0)
            server_ipAddress = IPAddress.Parse(Split(tmpStr, ":")(1))
            ipEndPoint = New IPEndPoint(server_ipAddress, 8800)
            settings = True
            frmClient.lblPcNum.Text = _pcno
            _mPass = Split(tmpStr, ":")(2)
        Catch ex As Exception
            'MsgBox(ex.ToString)
            settings = False
        End Try
        
    End Function
    Public Sub getSetTime()
        frmClient.OpenFileDialog1.FileName = Application.StartupPath & "\settime.ini"
        openedFileStream = frmClient.OpenFileDialog1.OpenFile()
        'End With

        ReDim dataBytes(openedFileStream.Length - 1) 'Init 
        openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
        openedFileStream.Close()
        tmpStr = System.Text.Encoding.Unicode.GetString(dataBytes)
        _setTime = Val(tmpStr(0))
    End Sub
    Public Sub writeFileStrData(ByVal MyData As Object, ByVal filePath As String, Optional ByVal transType As String = "", Optional ByVal dataEncoding As String = "")

        Dim Str As String
        Dim fs As FileStream
        Dim tempBytes() As Byte

        tempBytes = Nothing

        If transType = "" Then
            transType = "Append" 'Set default 
        End If

        If dataEncoding = "" Then
            dataEncoding = "ANSI"
        End If

        Try
            Str = CType(MyData, String)
            'Str = CType(Split(MyData, "-")(0) & Chr(10) & Chr(13) & Split(MyData, "-")(1), String)
            'MsgBox(Str)
            If dataEncoding = "ANSI" Then
                tempBytes = System.Text.Encoding.Default.GetBytes(Str)
            ElseIf dataEncoding = "Unicode" Then
                tempBytes = System.Text.Encoding.Unicode.GetBytes(Str)
            End If

            fs = New FileStream(filePath, FileMode.Create, FileAccess.Write)
            If transType = "Append" Then
                fs.Seek(0, SeekOrigin.End)
            ElseIf transType = "Overwrite" Then
                fs.Seek(0, SeekOrigin.Begin)
            End If

            fs.Write(tempBytes, 0, tempBytes.Length)
            fs.Close()
        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
End Module
