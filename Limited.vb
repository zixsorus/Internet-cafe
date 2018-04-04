Public Class Limited

   
   

    'I have 4 textboxes Hours, Minutes,Seconds,Milliseconds. 
    'When textboxes values are set the count down begins. Thanks in advanced...
    Dim dtFuture As New DateTime

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        TextBox1.Text = "0" : TextBox2.Text = "0" : TextBox3.Text = "0" : TextBox4.Text = "000"

        Button2.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()


    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Interval <> 100 Then Timer1.Interval = 100
        If DateTime.Now > dtFuture Then
            TextBox5.Text = "blast off"
            screenblock2.Show()

            Timer1.Stop()



        Else
            Dim foo As New TimeSpan
            foo = dtFuture - DateTime.Now
            TextBox5.Text = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", _
                                          foo.Hours, foo.Minutes, foo.Seconds, foo.Milliseconds)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label8.Text = TimeOfDay

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim h, m, s, ms As Integer
        If Not Integer.TryParse(TextBox1.Text, h) OrElse _
            Not Integer.TryParse(TextBox2.Text, m) OrElse _
            Not Integer.TryParse(TextBox3.Text, s) OrElse _
            Not Integer.TryParse(TextBox4.Text, ms) Then
            'bad input data
            Exit Sub
        End If
        dtFuture = DateTime.Now.AddHours(h).AddMinutes(m).AddSeconds(s).AddMilliseconds(ms)
        Timer1.Interval = 1
        Timer1.Start()
        Button1.Hide()
        Button3.Hide()
        Button4.Hide()
        Button2.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        screenblock2.Show()

    End Sub
  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CTI.Show()
        CTI.Button1.Hide()
        CTI.Button2.Hide()
        Me.Close()

    End Sub

   

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Label8.Show()
        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox5.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Hide()

    End Sub
End Class