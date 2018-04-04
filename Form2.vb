Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class screenblock1
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("Nice Try!  You must log on with a password.", "Security")
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TopMost = True
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
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "war3" Then
                'selprocess.close()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "ran" Then
                'selprocess.close()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "gta_sa" Then
                'selprocess.close()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "PlantsVsZombies" Then
                'selprocess.kill()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "GarenaMessenger" Then
                'selprocess.close()
                Exit For
            End If
        Next
        For Each selprocess As Process In Process.GetProcesses
            If selprocess.ProcessName = "SpecialForce" Then
                selprocess.Kill()
                Exit For
            End If
        Next
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Alt + Keys.Tab Then
            MessageBox.Show("Nice Try!  You must log on with a password.", "Security")
            e.Handled = True
        End If

        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("Nice Try!  You must log on with a password.", "Security")
            e.Handled = True
        End If

        If e.KeyData = Keys.Alt + Keys.S Then
            If TextBox1.Text = My.Settings.password Then
                'Timer1.Stop()
                'Hide()
                'Process.Start("explorer.exe")
                open.Show()
                open.Button4.Show()


                Close()
            Else
                MessageBox.Show("Password incorrect!")
                TextBox1.Clear()
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub screenblock1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = open.Label4.Text
        Label5.Text = open.Label6.Text
    End Sub
End Class
