Public Class CTI

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
    End Sub

    Private Sub CTI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label5.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button7.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If TextBox1.Text = My.Settings.password Then
                Button1.Show()
                Button2.Show()
                Button5.Show()
                TextBox1.Clear()

            Else
                MessageBox.Show("Incorrect Password")
                TextBox1.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        open.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Limited.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Changepass.show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Hide()
        Button3.Show()
        Button4.Show()
        Button5.Hide()
        Button6.Hide()
        Button7.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label5.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Show()
        Button7.Hide()

    End Sub
End Class
