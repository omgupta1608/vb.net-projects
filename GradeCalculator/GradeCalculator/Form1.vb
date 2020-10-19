Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mark As Integer
        mark = Marks.Text
        Select Case mark
            Case 0 To 39
                Output.Text = " Roll No " + RollNo.Text + ", " + Name.Text + " got failed in " + Subject.Text + "."
            Case 40 To 59
                Output.Text = " Roll No " + RollNo.Text + ", " + Name.Text + " got grade C in " + Subject.Text + "."
            Case 60 To 74
                Output.Text = " Roll No " + RollNo.Text + ", " + Name.Text + " got grade B in " + Subject.Text + "."
            Case 75 To 89
                Output.Text = " Roll No " + RollNo.Text + ", " + Name.Text + " got grade A in " + Subject.Text + "."
            Case 90 To 100
                Output.Text = " Roll No " + RollNo.Text + ", " + Name.Text + " got grade O in " + Subject.Text + "."
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RollNo.Text = ""
        Name.Text = ""
        Subject.Text = ""
        Marks.Text = ""
        Output.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
