

Public Class RatesList
    Dim isChk As Boolean
    Private Sub RatesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillListView(ListRate, ExecuteSQLQuery("select * from Rates ORDER BY PerMinutes ASC"))
        FillListView(listDisc, ExecuteSQLQuery("select * from Misc"))
        txtChngeRate.Enabled = False
        txtChngeRateTime.Enabled = False
        btnAdd.Text = "Add"
        btnEdit.Text = "Edit"
    End Sub




    Private Sub OpenRecordset()
        Throw New NotImplementedException
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnEdit.Text = "Edit"
            btnAdd.Text = "Save"
            txtChngeRate.Enabled = True
            txtChngeRateTime.Enabled = True
        Else
            sqlSTR = "INSERT INTO Rates (PerMinutes, Amounts) " & _
             "VALUES (" & txtChngeRateTime.Text & "," & txtChngeRate.Text & ")"
            ExecuteSQLQuery(sqlSTR)

            FillListView(ListRate, ExecuteSQLQuery("select * from Rates  ORDER BY PerMinutes ASC"))

            txtChngeRate.Enabled = False
            txtChngeRateTime.Enabled = False
            btnAdd.Text = "Add"
        End If
        
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ' If MsgBox("Do you want to Edit the item selected?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        If btnEdit.Text = "Edit" Then
            btnAdd.Text = "Add"
            btnEdit.Text = "Save"
            txtChngeRate.Enabled = True
            txtChngeRateTime.Enabled = True
        Else

            sqlSTR = "UPDATE Rates SET Amounts='" & txtChngeRate.Text & "' WHERE Id =" & ListRate.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Update Successful!")
            FillListView(ListRate, ExecuteSQLQuery("SELECT * FROM Rates ORDER BY PerMinutes ASC"))
            btnEdit.Text = "Edit"
            txtChngeRate.Enabled = False
            txtChngeRateTime.Enabled = False
        End If
        ' End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Do you want to delete the item selected?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sqlSTR = "Delete from Rates where Id = " & ListRate.FocusedItem.Text
            ExecuteSQLQuery(sqlSTR)
            MsgBox("Delete Successful")
            FillListView(ListRate, ExecuteSQLQuery("SELECT * FROM Rates ORDER BY PerMinutes ASC"))

        End If
    End Sub

    Private Sub ListRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListRate.SelectedIndexChanged
        txtChngeRateTime.Text = ListRate.FocusedItem.SubItems(1).Text
        txtChngeRate.Text = ListRate.FocusedItem.SubItems(2).Text
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MsgBox("Do you want to Update the Discount?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            sqlSTR = "UPDATE Misc SET HrDeduct='" & Val(tbHRdisc.Text) & "',MinDeduct='" & Val(tbMINdisc.Text) & "' WHERE Id =1"
            ExecuteSQLQuery(sqlSTR)

            MsgBox("Update Successful!")
            FillListView(listDisc, ExecuteSQLQuery("select * from Misc"))
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
