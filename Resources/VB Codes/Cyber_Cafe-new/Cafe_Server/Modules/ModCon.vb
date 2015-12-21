Imports System.Data.OleDb

Module ModCon
    Public Const cnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=../debug/database/Cyber_Cafe.mdb"
    Public sqlSTR As String
    Public sqlDr As OleDbDataReader
    Public sqlDS As New DataSet
    Public Function checkDatabase() As Boolean
        Try
            Dim sqlCon As New OleDbConnection
            sqlCon.ConnectionString = cnString
            sqlCon.Open()
            checkDatabase = True
            sqlCon.Close()
        Catch ex As Exception
            checkDatabase = False
        End Try
    End Function
    Public Function ExecuteSQLQuery(ByVal SQLQuery As String)
        Try
            Dim sqlCon As New OleDbConnection(cnString)
            Dim sqlCmd As New OleDbCommand(SQLQuery, sqlCon)
            Dim oledbda As New OleDbDataAdapter(sqlCmd)
            sqlCon.Open()
            sqlDr = sqlCmd.ExecuteReader()
            Return sqlDr
            sqlCon.Close()
        Catch ex As Exception
            MsgBox("Error Database: " & ex.Message)
        End Try
        Return True
    End Function
End Module
