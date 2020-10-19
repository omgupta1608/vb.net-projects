Public Class Form1

    Private Sub Start_Click(sender As System.Object, e As System.EventArgs) Handles Start.Click
        Dim i, j, n As Integer
        For i = 1 To 5
            For j = 1 To i
                Label1.Text = j & " "
            Next
            Label1.Text += Environment.NewLine
        Next

    End Sub
End Class
