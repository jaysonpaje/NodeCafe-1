Public Class FrmCleanDatabase
    Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
        If MsgBox("Do you realy want to clean this Database ??", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If chckTime.Checked And chckPrice.Checked Then
                delete("tbl_IN_clients,tbl_OUT_clients,tbl_PAUSE_clients,tbl_RESUME_clients,Rates")
            ElseIf chckTime.Checked Then
                delete("tbl_IN_clients,tbl_OUT_clients,tbl_PAUSE_clients,tbl_RESUME_clients")
            ElseIf chckPrice.Checked Then
                delete("Rates")
            Else
                MsgBox("Cannot clean without a selected checkbox", MsgBoxStyle.Information)
                Exit Sub
            End If
            MsgBox("Records has succesfully cleaned !!!", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub delete(ByVal str As String)
        Dim z As Integer
        Dim b
        b = Split(str, ",")
        For z = 0 To UBound(b)
            sqlSTR = "DELETE FROM " & b(z)
            ExecuteSQLQuery(sqlSTR)
        Next
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class