''' <summary>
''' This is a part of the example usage. Click on the button to display the ScreenLocking facility.
''' </summary>
''' <remarks>by, Akhilesh B Chandran</remarks>
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '~~~ Calling it and passing the name of the form to be displayed
        Dim myObj As abcLockScreen = New abcLockScreen
        myObj.LockSystemAndShow(Form2)
    End Sub
End Class
