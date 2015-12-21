Public Class FrmReportDate

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Report As New FrmReports
        sqlSTR = "SELECT * FROM tbl_IN_clients where Date_IN>=#" & Format(dtfrom.Value, "MM/dd/yyyy") & "# AND Date_IN <=#" & Format(dtto.Value, "MM/dd/yyyy") & "#"
        Report.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class