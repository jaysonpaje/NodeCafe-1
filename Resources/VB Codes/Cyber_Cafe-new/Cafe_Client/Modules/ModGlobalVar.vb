Imports System.Net, System.Net.Sockets
Module ModGlobalVar
    Public _packets_msg As String
    Public x As Integer
    Public header As String = "05"
    Public _pcno As String
    Public clientSocket As Socket
    Public _seconds As Long
    Public _tmpsecsNow, _tmpsecs As Long
    Public _hrs, _mins As Integer

    Public myIP

    Public _ipAddress As String

    Public _setTime As Double
    Public _rates(0)
    Public IsDisc As Integer
    Public amountTopayMin, amountTopayHR, AmtinHr As Double
    Public server_ipAddress As IPAddress = IPAddress.Parse("127.0.0.1") 'by default
    Public ipEndPoint As IPEndPoint '= New IPEndPoint(server_ipAddress, 8800)
    Public _mPass As String
End Module
