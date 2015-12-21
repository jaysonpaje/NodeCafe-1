Public Class FrmClientList

    Private Sub FrmClientList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillListView(lvclientlist, ExecuteSQLQuery("SELECT pc_no, ip_address FROM tbl_clients"))
    End Sub

    Private Sub lvclientlist_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvclientlist.MouseDoubleClick
        If lvclientlist.Items.Count > 0 Then
            FrmClientListdtl.txtid.Text = lvclientlist.FocusedItem.Text
            FrmClientListdtl.txtip.Text = lvclientlist.FocusedItem.SubItems(1).Text
            FrmClientListdtl.ShowDialog()
        End If
    End Sub

    Private Sub lvclientlist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvclientlist.SelectedIndexChanged

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim _x As Integer
        If MsgBox("Refreshing the client will make some data loss, make sure all clients is not yet running or has not been set in time ", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For _x = 1 To 30
                If Not btn(_x).Tag Is Nothing Then
                    client_refresh(btn(_x).Tag)
                End If
            Next
        End If
    End Sub
End Class