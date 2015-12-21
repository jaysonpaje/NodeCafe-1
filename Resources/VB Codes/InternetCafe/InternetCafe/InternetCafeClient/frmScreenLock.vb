Public Class frmScreenLock
    'Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Private Sub frmScreenLock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.TopMost = True 'make the form on the top of any other window
        'apiBlockInput(1) 'lock all input mouse and keyboard
        'System.Threading.Thread.Sleep(30000)
        'apiBlockInput(0)
    End Sub

    Private Sub frmScreenLock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        e.Handled = False
    End Sub

    Private Sub frmScreenLock_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class