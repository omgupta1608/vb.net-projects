Public Class Form1


    Dim num1, num2 As Integer


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label4.Text = num1 + num2
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label4.Text = num1 - num2
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
