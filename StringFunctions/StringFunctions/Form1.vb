Public Class Form1
    Dim Str1 As String
    Dim Str2 As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
                Output.Text = UCase(TextBox1.Text) & " " & UCase(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Output.Text = LCase(TextBox1.Text) & " " & LCase(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Output.Text = StrReverse(TextBox1.Text) & " " & StrReverse(TextBox2.Text)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Output.Text = TextBox1.Text & TextBox2.Text
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Output.Text = "Size of 1st String: " & TextBox1.Text.Length() & " Size of 2nd String: " & TextBox2.Text.Length()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Output.Text = ""

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        End
    End Sub
End Class
