
Imports System.IO

Public Class FrmBackupUtility

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnopen1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopen1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnopen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopen2.Click
        SaveFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtsourcedb.Text = OpenFileDialog1.FileName
    End Sub
    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        txtdestination.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        If txtsourcedb.Text = "" Or txtdestination.Text = "" Then
            MsgBox("Enter source amd destination path!", MsgBoxStyle.Information, "Back Up Utility")
        Else
            System.IO.File.Copy(txtsourcedb.Text, txtdestination.Text)
            MsgBox("Backup Success !!!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub FrmBackupUtility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsourcedb.Text = Application.StartupPath & "\" & "database\Cyber_Cafe.mdb"
        txtdestination.Text = Application.StartupPath & "\" & "Backup_Database\" & "backup_" & Format(Now, "MM-dd-yy") & "@" & Format(Now, "hhmmsstt") & ".mdb"
    End Sub
End Class