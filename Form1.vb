Public Class Form1
    Dim diffDate As TimeSpan
    Dim enddate As DateTime
    Dim startdate As DateTime
    Dim btime As TimeSpan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startdate = Now
        Timer1.Start()
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
    Private Sub Timer1_tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        enddate = DateTime.Now
        diffDate = btime + (enddate - startdate)
        Label1.Text = (diffDate.ToString("hh\:mm\:ss"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Timer1.Enabled Then
            Timer1.Stop()
            btime = diffDate
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        Else
            Timer1.Start()
            startdate = Now
        End If
    End Sub
End Class