Attribute VB_Name = "mouseTrap"
Declare Function ClipCursor Lib "user32" _
    (lpRect As Any) As Long

Type Rect
    left As Long
    top As Long
    right As Long
    bottom As Long
End Type

Public Function LetMouseGo(Frm2LetMouseGo As Object)
    Dim erg As Long
    Dim NewRect As Rect

    With NewRect
        .left = 0&
        .top = 0&
        .right = Screen.Width / Screen.TwipsPerPixelX
        .bottom = Screen.Height / Screen.TwipsPerPixelY
    End With

    erg& = ClipCursor(NewRect)
    'Be Sure To Add
    '
    ' Private Sub Form_Unload(Cancel As Integer)
    ' LetMouseGo Me
    ' End Sub
    '
    'To The Form That You Trap Incase They Ctrl-alt-Del Or X
    'Out Of The Program, Otherwise, There Mouse Will Still Be
    'Trapped In The Form Square!!
End Function



Public Function TrapMouse(Frm2MouseTrap As Object)

    Dim X As Long, y As Long, erg As Long
    Dim NewRect As Rect
    X& = Screen.TwipsPerPixelX
    y& = Screen.TwipsPerPixelY

    With NewRect
      .left = (Screen.Width / 2 - Frm2MouseTrap.Width / 2) / X&
      .top = (Screen.Height / 2 - Frm2MouseTrap.Height / 2) / y&
      .right = .left + (Frm2MouseTrap.Width) / X&
      .bottom = .top + (Frm2MouseTrap.Height) / y&
    End With

    erg& = ClipCursor(NewRect)
End Function



