Public Class Form1
    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        Dim n As Integer = 1
        Dim sum As Integer = 0


        n = Integer.Parse(txt_n.Text)


        For i As Integer = 1 To n
            sum = sum + i
        Next

        txt_ans.Text = sum.ToString()

    End Sub
End Class
