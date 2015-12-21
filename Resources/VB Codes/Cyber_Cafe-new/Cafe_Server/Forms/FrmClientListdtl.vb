Public Class FrmClientListdtl

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sqlSTR = "UPDATE tbl_clients SET ip_address ='" & txtip.Text & "' WHERE pc_no=" & txtid.Text
        ExecuteSQLQuery(sqlSTR)
        MsgBox("Record has been updated", MsgBoxStyle.Information)
        FillListView(FrmClientList.lvclientlist, ExecuteSQLQuery("SELECT pc_no, ip_address FROM tbl_clients"))
    End Sub
End Class