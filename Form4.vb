Public Class Changepass

    Private Sub Changepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Hide()
        Label3.Hide()
        Button2.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Button3.Hide()
        TextBox1.Hide()
        Label1.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TextBox1.Text = My.Settings.password Then
                Button3.Hide()
                TextBox2.Show()
                TextBox3.Show()
                Label2.Show()
                Label3.Show()
                Button2.Show()
                TextBox1.Clear()

            Else
                MessageBox.Show("Incorrect Password")
                TextBox1.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        CTI.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            If TextBox2.Text = TextBox3.Text Then
                My.Settings.password = TextBox2.Text
                MessageBox.Show("Your password was successfully changed")
                Me.Close()
                CTI.Show()
                CTI.Button1.Hide()
                CTI.Button2.Hide()
            Else
                MessageBox.Show("Password entries did not match")
                TextBox2.Clear()
                TextBox3.Clear()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label2.Hide()
        Label3.Hide()
        Button2.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Label1.Show()
        TextBox1.Show()
        Button3.Show()
        Button4.Hide()

    End Sub
End Class