Attribute VB_Name = "disable"
Option Explicit

Public Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (Destination As Any, Source As Any, ByVal Length As Long)
Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer
Public Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Long, ByVal lpfn As Long, ByVal hmod As Long, ByVal dwThreadId As Long) As Long
Public Declare Function CallNextHookEx Lib "user32" (ByVal hHook As Long, ByVal nCode As Long, ByVal wParam As Long, lParam As Any) As Long
Public Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Long) As Long
Public Const HC_ACTION = 0
Public Const WM_KEYDOWN = &H100
Public Const WM_KEYUP = &H101
Public Const WM_SYSKEYDOWN = &H104
Public Const WM_SYSKEYUP = &H105
Public Const VK_TAB = &H9
Public Const VK_CONTROL = &H11
Public Const VK_ESCAPE = &H1B
Public Const VK_STARTKEY = &H5B


Public Const WH_KEYBOARD_LL = 13
Public Const LLKHF_ALTDOWN = &H20

Public Type KBDLLHOOKSTRUCT
    vkCode As Long
    scanCode As Long
    flags As Long
    time As Long
    dwExtraInfo As Long
End Type

Dim p As KBDLLHOOKSTRUCT

Function LowLevelKeyboardProc(ByVal nCode As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
   Dim fEatKeystroke As Boolean
   
   If (nCode = HC_ACTION) Then
      If wParam = WM_KEYDOWN Or wParam = WM_SYSKEYDOWN Or wParam = WM_KEYUP Or wParam = WM_SYSKEYUP Then
         CopyMemory p, ByVal lParam, Len(p)
         fEatKeystroke = _
            ((p.vkCode = VK_TAB) And ((p.flags And LLKHF_ALTDOWN) <> 0)) Or _
            ((p.vkCode = VK_ESCAPE) And ((p.flags And LLKHF_ALTDOWN) <> 0)) Or _
            ((p.vkCode = VK_ESCAPE) And ((GetKeyState(VK_CONTROL) And &H8000) <> 0)) Or _
            p.vkCode = VK_STARTKEY
            
        End If
    End If
    
    If fEatKeystroke Then
        LowLevelKeyboardProc = -1
    Else
        LowLevelKeyboardProc = CallNextHookEx(0, nCode, wParam, ByVal lParam)
    End If
End Function

'this is an old source to disable ctrl+alt+del w/c doesn't work in winxp

'Public Declare Function SystemParametersInfo Lib _
"user32" Alias "SystemParametersInfoA" (ByVal uAction _
As Long, ByVal uParam As Long, ByVal lpvParam As Any, _
ByVal fuWinIni As Long) As Long

'Sub DisableCtrlAltDelete(bDisabled As Boolean)
'    Dim x As Long
'    x = SystemParametersInfo(97, bDisabled, CStr(1), 0)
'End Sub
