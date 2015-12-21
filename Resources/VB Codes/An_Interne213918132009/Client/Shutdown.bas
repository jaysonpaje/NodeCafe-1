Attribute VB_Name = "Shutdown"
'Api function and the constants required for ExitWindowsEx
Declare Function ExitWindowsEx& Lib "user32" (ByVal uFlags As Long, ByVal dwReserved As Long)
Public Const EWX_FORCE = 4
Public Const EWX_LOGOFF = 0
Public Const EWX_REBOOT = 2
Public Const EWX_SHUTDOWN = 1


