''' <summary>
''' Sample Login screen page
''' </summary>
''' <remarks>by, Akhilesh B Chandran
''' akhileshbc @ VBForums</remarks>
Public Class Form2
    Dim bolExit As Boolean = False  '~~~ Used to detect whether the form is being closed only after entering the correct password and not by pressing "Alt" + "F4"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtPwd.Text.Trim.ToLower = "abc" Then        '~~~ Check if the password is correct
            bolExit = True                          '~~~ If so, we got the green signal to close the form :-)
            MessageBox.Show("You are lucky !!!", "Success")
            Me.Close()                              '~~~ Close it
        Else                                            '~~~ Otherwise, display a message
            MessageBox.Show("Nah! Nah! Nah!... You are not supposed to continue using this PC..!", "Wrong Password !!! ")
        End If
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bolExit = False Then     '~~~ When closing the form, checks whether it is being closed by "Alt" + "F4" or by entering the correct password.
            e.Cancel = True         '~~~ If the closing is done without entering the correct password, then prevent the form from being closed
        End If
    End Sub
End Class