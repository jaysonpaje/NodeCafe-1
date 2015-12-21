Public Class FrmTimer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        x += 1
        Label1.Text = x
    End Sub

    Private Sub FrmTimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox("here")
        'Timer1.Start()
    End Sub
End Class