Public Class JokeandPunchline
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Setup.Click
        lblMessage.Text = "What is the advantage of living in Switzerland?"
    End Sub

    Private Sub Punchline_Click(sender As Object, e As EventArgs) Handles Punchline.Click
        lblMessage.Text = "Well, the flag is a big plus!"
    End Sub
End Class
