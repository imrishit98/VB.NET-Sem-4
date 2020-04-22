Public Class VBForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_hello.Click

    End Sub

    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        Dim x = "Hello World"
        Dim temp = "goodbye world."
        lbl_hello.Text = temp
        If pb_main.Value >= 100 Then
            pb_main.Value = 0
        End If
        pb_main.Value += 10
    End Sub
End Class
