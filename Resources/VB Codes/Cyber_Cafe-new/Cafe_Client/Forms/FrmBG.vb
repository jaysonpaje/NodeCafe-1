Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class frmBG
    Dim btn1_Click As Boolean

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        TopMost = True
        Me.WindowState = FormWindowState.Maximized
        If Me.WindowState <> FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "explorer" Then
                'selProcess.Kill()
                Exit For
            End If
        Next
    End Sub

    Private Sub frmBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 49 Then ' 1
            Timer1.Enabled = False
            grpLogin.Visible = True
            txtpass.Focus()
        End If
        If e.KeyCode = 50 Then ' 2
            Timer1.Enabled = False
            txtip.Focus()
            grpIP.Visible = True
        End If
        If e.KeyCode = 84 Then Me.Close()
        If e.KeyCode = 17 Or e.KeyCode = 18 Or e.KeyCode = 46 Then
            grpLogin.Visible = False
            grpIP.Visible = False
            Timer1.Enabled = True
        ElseIf e.KeyCode = 27 Then
            grpIP.Visible = False
            grpLogin.Visible = False
        End If
    End Sub
    Private Sub frmClient2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MyLabel1.Parent = PictureBox1
        Timer1.Start()
        Timer2.Start()
        MyLabel1.BackColor = Color.Transparent
        MyLabel1.Top = Me.Height / 2

        lblc.BackColor = Color.Transparent
        lblc.Top = (Me.Height / 2) - 150

        btn1_Click = False

        grpLogin.Left = Me.Width - grpLogin.Width
        grpLogin.Top = Me.Top / 2

        grpIP.Left = Me.Width - grpIP.Width
        grpIP.Top = Me.Top / 2
        If Not settings() Then
            If MsgBox("No ip address has been set, do you want set a server IP?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                grpIP.Visible = True

            End If
        Else
            'If server_ipAddress.ToString Then

            'End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = True
        If MyLabel1.ForeColor = Color.Maroon Then
            MyLabel1.ForeColor = Color.Red
        ElseIf MyLabel1.ForeColor = Color.Red Then
            MyLabel1.ForeColor = Color.Maroon
        End If
    End Sub


    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Enabled = False
    End Sub

    Private Sub btnLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtpass.Text <> txtrepass.Text Then
            MsgBox("Password and retype password doesn't match", MsgBoxStyle.Information)
            Exit Sub
        End If
        'MsgBox(_mPass)
        If txtpass.Text = _mPass And txtrepass.Text = _mPass Then
            If MsgBox("Are you really sure you want to exit the system", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                End
            End If
        Else
            MsgBox("Incorrect Password", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grpLogin.Visible = False
        Me.Focus()
    End Sub


    Private Sub btnIPCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grpIP.Visible = False
        Me.Focus()
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = 17 Or e.KeyCode = 18 Or e.KeyCode = 46 Then
            grpLogin.Visible = False
            grpIP.Visible = False
            Timer1.Enabled = True
            Me.Focus()
        ElseIf e.KeyCode = 13 Then
            If txtpass.Text <> txtrepass.Text Then
                MsgBox("Password and retype password doesn't match", MsgBoxStyle.Information)
                Exit Sub
            End If
            'MsgBox(_mPass)
            If txtpass.Text = _mPass And txtrepass.Text = _mPass Then
                If MsgBox("Are you really sure you want to exit the system", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    End
                End If
            Else
                MsgBox("Incorrect Password", MsgBoxStyle.Information)
            End If
        ElseIf e.KeyCode = 27 Then
            grpLogin.Visible = False
            Me.Focus()
        End If
    End Sub

    Private Sub txtrepass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrepass.KeyDown
        If e.KeyCode = 17 Or e.KeyCode = 18 Or e.KeyCode = 46 Then
            grpLogin.Visible = False
            grpIP.Visible = False
            Me.Focus()
            Timer1.Enabled = True
        ElseIf e.KeyCode = 13 Then
            If txtpass.Text <> txtrepass.Text Then
                MsgBox("Password and retype password doesn't match", MsgBoxStyle.Information)
                Exit Sub
            End If
            'MsgBox(_mPass)
            If txtpass.Text = _mPass And txtrepass.Text = _mPass Then
                If MsgBox("Are you really sure you want to exit the system", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    End
                End If
            Else
                MsgBox("Incorrect Password", MsgBoxStyle.Information)
            End If
        ElseIf e.KeyCode = 27 Then
            grpLogin.Visible = False
            Me.Focus()
        End If
    End Sub

    Private Sub txtip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtip.KeyDown
        If e.KeyCode = 17 Or e.KeyCode = 18 Or e.KeyCode = 46 Then
            grpLogin.Visible = False
            grpIP.Visible = False
            Me.Focus()
            Timer1.Enabled = True

        ElseIf e.KeyCode = 13 Then
            Call writeFileStrData(_pcno & ":" & txtip.Text & ":" & _mPass, Application.StartupPath & "\config.ini", , "Unicode")
            settings()
            grpIP.Visible = False
            Me.Focus()
        ElseIf e.KeyCode = 27 Then
            grpIP.Visible = False
            Me.Focus()
        End If
    End Sub

    Private Sub grpIP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grpIP.KeyDown
        If e.KeyCode = 17 Or e.KeyCode = 18 Or e.KeyCode = 46 Then
            grpLogin.Visible = False
            grpIP.Visible = False
            Me.Focus()
            Timer1.Enabled = True
        ElseIf e.KeyCode = 27 Then
            grpIP.Visible = False
            Me.Focus()
        End If
    End Sub


    Private Sub txtip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtip.TextChanged

    End Sub
End Class