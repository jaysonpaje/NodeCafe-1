Public Class FrmMaster_Password

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtoldpass.Text <> txtreoldpass.Text Then
            MsgBox("Old Password and Retype Old Password doesn't match ", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtnewpass.Text <> txtrenewpass.Text Then
            MsgBox("New password and Retype new password doesn't match", MsgBoxStyle.Information)
            Exit Sub
        End If
        'check if there's a record
        sqlSTR = "SELECT * FROM tbl_master_password"
        ExecuteSQLQuery(sqlSTR)
        If sqlDr.Read Then
            sqlSTR = "SELECT * FROM tbl_master_password WHERE client_password ='" & txtoldpass.Text & "'"
            ExecuteSQLQuery(sqlSTR)
            If sqlDr.Read Then
                sqlSTR = "UPDATE tbl_master_password SET client_password ='" & txtnewpass.Text & "'"
                ExecuteSQLQuery(sqlSTR)
            Else
                MsgBox("Incorrect Master Password", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            'if no data then insert new password
            sqlSTR = "INSERT INTO tbl_master_password (client_password) values('" & txtnewpass.Text & "')"
            ExecuteSQLQuery(sqlSTR)
        End If
        MsgBox("New master password has been set", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub FrmMaster_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnewpass.Text = ""
        txtrenewpass.Text = ""
        txtoldpass.Text = ""
        txtreoldpass.Text = ""
    End Sub


    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class