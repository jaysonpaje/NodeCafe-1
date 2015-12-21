Attribute VB_Name = "onTop"
Public Const HWND_BOTTOM = 1
Public Const HWND_NOTOPMOST = -2
Public Const HWND_TOP = 0
Public Const HWND_TOPMOST = -1
Public Const SWP_NOMOVE = &H2
Public Const SWP_NOSIZE = &H1


''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Declare Function GetActiveWindow Lib "user32" () As Long

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub MakeWindowAlwaysTop(hwnd As Long)
    SetWindowPos hwnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE + SWP_NOSIZE
End Sub

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub MakeWindowNotTop(hwnd As Long)
    SetWindowPos hwnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE + SWP_NOSIZE
End Sub

