Imports System.Windows.Forms
'Imports System.Net, System.Net.Sockets
Imports System.Threading
Public Class MDIMain
    Dim tim As Integer = 0
    Dim min As Integer = 0
    Dim hr As Integer = 0
    Dim tmp_time As String
    Dim amt_to_pay As Integer = 0
    Dim amt_hr As Integer = 0
    Dim disc As Integer = 1
    Dim x As Integer = 0


    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 40
            m_ThreadList.Add(Nothing)
        Next
        checkDatabase()
        frmBG.MdiParent = Me
        frmBG.WindowState = FormWindowState.Maximized
        frmBG.Show()

    End Sub
    ''
    
    '''
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Send("1À€À€5À€3À€14À€À€9À€1À€922À€0À€64À€0À€206À€32À€", btn(btn_store.Find(AddressOf search_2).Index).Tag)
        notify_Msg(btn(btn_store.Find(AddressOf search_2).Index).Tag)
    End Sub


    Public Sub updateT()

    End Sub
   

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'lblInT(1).Text = "A"
        sqlSTR = "SELECT * FROM tbl_IN_clients WHERE status = 4"
        ExecuteSQLQuery(sqlSTR)
        While sqlDr.Read
            'MsgBox(sqlDr("status"))
            lblInT(sqlDr("pc_no")).Text = Format(sqlDr("time_in"), "hh:mm tt").ToString
        End While
    End Sub

    Private Sub btnEditRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRates.Click
        RatesList.ShowDialog()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnMult_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult_Open.Click
        Dim item As Object
        Dim panelitems As Object
        Dim GroupBoxItems As Object

        ''  For All controls
        For Each item In frmBG.clientPanel.Controls
            If TypeOf item Is Panel Then
                For Each panelitems In item.controls
                    If TypeOf panelitems Is GroupBox Then
                        For Each GroupBoxItems In panelitems.controls
                            If TypeOf GroupBoxItems Is CheckBox Then
                                If GroupBoxItems.checked Then
                                    FrmSetTime_Multiple.ShowDialog()
                                    Exit Sub
                                End If

                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnMult_Ext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult_Ext.Click
        Dim _tmpIndex As Integer
        For Each item In frmBG.clientPanel.Controls
            If TypeOf item Is Panel Then
                For Each panelitems In item.controls
                    If TypeOf panelitems Is GroupBox Then
                        For Each GroupBoxItems In panelitems.controls
                            If TypeOf GroupBoxItems Is CheckBox Then
                                If GroupBoxItems.checked Then
                                    _tmpIndex = GroupBoxItems.tag
                                    If _tmpSetTime_(_tmpIndex) > 0 Then
                                        FrmExtend_Multiple.ShowDialog()
                                        Exit Sub
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ClientListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientListToolStripMenuItem.Click
        FrmClientList.ShowDialog()
    End Sub

    Private Sub BackUpUtilityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpUtilityToolStripMenuItem.Click
        FrmBackupUtility.ShowDialog()
    End Sub

    Private Sub MasterPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterPasswordToolStripMenuItem.Click
        FrmMaster_Password.ShowDialog()
    End Sub

    Private Sub ClientListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientListToolStripMenuItem1.Click
        FrmClientList.ShowDialog()
    End Sub

    Private Sub PrintReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportsToolStripMenuItem.Click
        FrmReportDate.ShowDialog()
    End Sub

    Private Sub CleanDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanDatabaseToolStripMenuItem.Click
        FrmCleanDatabase.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.ShowDialog()
    End Sub
End Class
