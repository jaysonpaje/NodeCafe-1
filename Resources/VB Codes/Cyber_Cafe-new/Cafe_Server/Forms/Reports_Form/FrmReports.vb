Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data
Public Class FrmReports

    Private Sub FrmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New OleDbCommand
        Dim con As New OleDbConnection
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        con.ConnectionString = cnString
        con.Open()
        cmd.CommandText = sqlSTR
        cmd.Connection = con
        da.SelectCommand = cmd
        ds.Reset()
        da.Fill(ds)
        mReport = New ReportDocument()
        mReport.Load(Application.StartupPath & "\Reports\SalesReport.rpt")
        mReport.SetDataSource(ds.Tables(0))
        CrystalReportViewer1.ReportSource = mReport
        Me.MdiParent = MDIMain
    End Sub
End Class