Public Enum ClientState
    Closed
    Opened
End Enum
Public Class TheClient
    Protected _startTime As DateTime
    Protected _state As ClientState
    Protected _ip As String
    Public Shared AllClients As Hashtable = New Hashtable


    Public Sub New(ByVal ip As String)
        _ip = ip
        AllClients.Add(ip, Me)
    End Sub
    Public Property IP() As String
        Get
            Return _ip
        End Get
        Set(ByVal value As String)
            _ip = value
        End Set
    End Property

    Public Property State() As ClientState
        Get
            Return _state
        End Get
        Set(ByVal value As ClientState)
            _state = value
        End Set
    End Property

    Public Property StartTime() As DateTime
        Get
            Return _startTime
        End Get
        Set(ByVal value As DateTime)
            _startTime = value
        End Set
    End Property

    Public Shared Function CurrentTime() As DateTime
        Return Now
    End Function

    Public Function UsedMinute() As Long
        Return DateDiff(DateInterval.Minute, _startTime, CurrentTime())
    End Function
End Class
