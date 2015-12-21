Imports System.Threading
Public Class FrmSaveTimeClients
    Dim _tmpID, _tmpInID As Integer
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        sqlSTR = "INSERT INTO tbl_SAVE_LOAD_clients ( in_id, client_name, client_address, client_contact, load_status, c_date, elapse_time, pc_no ) " & _
                 "VALUES(" & _tmpInID & ",'" & txtclient_n.Text & "','" & txtclient_a.Text & "','" & txtclient_c.Text & "',no,'" & Now & "'," & _secs(_tmpID) & "," & _tmpID & ")"
        ExecuteSQLQuery(sqlSTR)
        sqlSTR = "UPDATE tbl_IN_clients SET status=0 WHERE in_id =" & _tmpInID
        ExecuteSQLQuery(sqlSTR)
        m_ThreadList(_tmpID).abort()
        m_ThreadList(_tmpID) = Nothing
        _elapseTime(_tmpID) = ""
        btn(_tmpID).ImageIndex = 1
        _start(_tmpID) = 0
        _secs(_tmpID) = 0
        _mins(_tmpID) = 0
        _hrs(_tmpID) = 0
        _notify(_tmpID) = False
        _tmpSetTime_(_tmpID) = 0
        AmtinHrs(_tmpID) = 0
        lblUnpaidT(_tmpID).Text = 0
        client_save(btn(_tmpID).Tag)
        Me.Close()
    End Sub

    Private Sub FrmSaveTimeClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpcname.Text = pc_name
        _tmpID = btn_store.Find(AddressOf search_2).Index
        sqlSTR = "SELECT * FROM tbl_IN_clients WHERE pc_no =" & _tmpID & " ORDER BY time_in DESC"
        ExecuteSQLQuery(sqlSTR)
        If sqlDr.Read Then
            _tmpInID = sqlDr("in_id")
            txtstart.Text = Format(sqlDr("time_in"), "hh:mm tt")
            txtlimit.Text = Format(sqlDr("time_limit"), "hh:mm tt")
            txtend.Text = Format(sqlDr("time_out"), "hh:mm tt")
        End If
    End Sub
End Class