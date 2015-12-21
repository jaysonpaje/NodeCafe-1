Public Enum ActionType
    Shutdown
    Restart
    CloseSession
    OpenSession
End Enum
Public Delegate Sub Action()
Public Delegate Sub ActionStartTimer(ByVal time As DateTime)

Public Class RPCObject
    Inherits MarshalByRefObject
    Public Event ClientRegistered(ByVal host As String)
    Public AllClients As New List(Of String)
    Public AllShutdown As New Hashtable
    Public AllRestart As New Hashtable
    Public AllCloseSession As New Hashtable
    Public AllOpenSession As New Hashtable
    Public AllStartTimer As New Hashtable

    Public Sub RegisterAsClient(ByVal ip As String)
        AllClients.Add(ip)
        RaiseEvent ClientRegistered(ip)
    End Sub

    Public Sub RegisterAction(ByVal ip As String, ByVal type As ActionType, ByVal theAction As Action)
        If type = ActionType.Shutdown Then
            AllShutdown.Add(ip, theAction)
        ElseIf type = ActionType.Restart Then
            AllRestart.Add(ip, theAction)
        ElseIf type = ActionType.CloseSession Then
            AllCloseSession.Add(ip, theAction)
        ElseIf type = ActionType.OpenSession Then
            AllOpenSession.Add(ip, theAction)
        End If
    End Sub

    Public Sub RegisterStartTimer(ByVal ip As String, ByVal theaction As ActionStartTimer)
        AllStartTimer.Add(ip, theaction)
    End Sub

    Public Sub RemoteStartTimer(ByVal ip As String, ByVal time As DateTime)
        If AllStartTimer.Item(ip) IsNot Nothing Then
            CType(AllStartTimer.Item(ip), ActionStartTimer).Invoke(time)
        End If
    End Sub

    Public Sub RemoteAction(ByVal ip As String, ByVal type As ActionType)
        Dim thelist As Hashtable
        If type = ActionType.Shutdown Then
            thelist = AllShutdown
        ElseIf type = ActionType.Restart Then
            thelist = AllRestart
        ElseIf type = ActionType.CloseSession Then
            thelist = AllCloseSession
        ElseIf type = ActionType.OpenSession Then
            thelist = AllOpenSession
        End If

        If thelist.Item(ip) IsNot Nothing Then
            CType(thelist.Item(ip), Action).Invoke()
        End If
    End Sub
End Class
