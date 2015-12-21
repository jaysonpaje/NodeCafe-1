Public Class FrmLoadTimeClients
    Dim _tmpID As Integer
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLoadTimeClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _tmpID = btn_store.Find(AddressOf search_2).Index
        sqlSTR = "SELECT tbl_IN_clients.in_id, tbl_clients.client_name, tbl_SAVE_LOAD_clients.client_name, tbl_SAVE_LOAD_clients.elapse_time, tbl_SAVE_LOAD_clients.elapse_time, tbl_clients.pc_no " & _
                 "FROM (((tbl_IN_clients " & _
                 "INNER JOIN tbl_clients ON (tbl_IN_clients.pc_no = tbl_clients.pc_no) ) " & _
                 "INNER JOIN tbl_SAVE_LOAD_clients ON (tbl_IN_clients.in_id = tbl_SAVE_LOAD_clients.in_id) )) " & _
                 "WHERE tbl_SAVE_LOAD_clients.load_status = no"
        FillListView(lvLoadClients, ExecuteSQLQuery(sqlSTR))
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If lvLoadClients.Items.Count > 0 Then
            If lvLoadClients.SelectedItems.Count > 0 Then
                'MsgBox(lvLoadClients.FocusedItem.SubItems(5).Text)
                ' MsgBox(lvLoadClients.FocusedItem.SubItems(3).Text & " " & lvLoadClients.FocusedItem.SubItems(4).Text)
                If MsgBox("Are you sure you want to load this data ??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sqlSTR = "UPDATE tbl_IN_clients SET status=1, pc_no =" & _tmpID & " WHERE in_id =" & lvLoadClients.FocusedItem.Text
                    ExecuteSQLQuery(sqlSTR)
                    sqlSTR = "UPDATE tbl_SAVE_LOAD_clients SET load_status = yes, pc_no=" & _tmpID & ", status=0 " & _
                             "WHERE in_id=" & lvLoadClients.FocusedItem.Text
                    ExecuteSQLQuery(sqlSTR)
                    _secs(_tmpID) = lvLoadClients.FocusedItem.SubItems(4).Text
                    _setLoad(_tmpID, lvLoadClients.FocusedItem.Text)
                End If
                Me.Close()
            Else
                MsgBox("No selected item", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub lvLoadClients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLoadClients.SelectedIndexChanged

    End Sub
End Class