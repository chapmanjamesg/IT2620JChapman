Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblClickMessage.Click

    End Sub

    Private Sub btnImageOne_Click(sender As Object, e As EventArgs) Handles btnImageOne.Click
        lblClickMessage.Text = "One"
    End Sub

    Private Sub btnImageTwo_Click(sender As Object, e As EventArgs) Handles btnImageTwo.Click
        lblClickMessage.Text = "Two"
    End Sub

    Private Sub btnImageThree_Click(sender As Object, e As EventArgs) Handles btnImageThree.Click
        lblClickMessage.Text = "Three"
    End Sub

    Private Sub btnImageFour_Click(sender As Object, e As EventArgs) Handles btnImageFour.Click
        lblClickMessage.Text = "Four"
    End Sub

    Private Sub btnImageFive_Click(sender As Object, e As EventArgs) Handles btnImageFive.Click
        lblClickMessage.Text = "Five"
    End Sub
End Class
