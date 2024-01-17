Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String
        grade = ComboBox1.Text

        Select Case grade
            Case "A"
                TextBox1.Text = "High Distinction"
            Case "A-"
                TextBox1.Text = "Distinction"

            Case "B"
                TextBox1.Text = "Credit"
            Case "C"
                TextBox1.Text = "Pass"

            Case "D"
                TextBox1.Text = "Fail"
            Case Else
                TextBox1.Text = "Fail"




        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
