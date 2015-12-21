Module ModEncDec
    Dim dec, enc As String
    Public Function encrypt(ByVal data As String)
        Dim i As Integer
        'MsgBox(Mid(data, 1, 1))
        enc = ""
        For i = 1 To Len(data)
            enc &= Chr(Asc(Mid(data, i, 1)) + 1)
        Next
        'MsgBox(enc)
        Return enc
    End Function

    Public Function descrypt(ByVal data As String)
        Dim i As Integer
        'MsgBox(Mid(data, 1, 1))
        dec = ""
        For i = 1 To Len(data)
            dec &= Chr(Asc(Mid(data, i, 1)) - 1)
        Next
        'MsgBox(enc)
        Return dec

    End Function
End Module
