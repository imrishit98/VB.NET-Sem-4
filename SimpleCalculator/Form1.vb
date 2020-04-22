'Author: Rishit Patel
'Date :  24 January, 2020
'Description: Simple Calculator
Public Class Simple_Calculator
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        val1.Clear()
        val2.Clear()
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        lbl_oprand.Text = "+"
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        lbl_oprand.Text = "-"
    End Sub

    Private Sub multiplication_Click(sender As Object, e As EventArgs) Handles multiplication.Click
        lbl_oprand.Text = "*"
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        lbl_oprand.Text = "/"
    End Sub

    Private Sub expo_Click(sender As Object, e As EventArgs) Handles expo.Click
        lbl_oprand.Text = "^"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstVal As Decimal = 0
        Dim secondVal As Decimal = 0
        Dim theAns As Decimal = 0

        If IsNumeric(val1.Text) Then
            firstVal = Decimal.Parse(val1.Text)
        End If

        If IsNumeric(val2.Text) Then
            secondVal = Decimal.Parse(val2.Text)
        End If

        If lbl_oprand.Text = "+" Then
            theAns = firstVal + secondVal
            theAns = Math.Round(theAns, 14)
        End If

        If lbl_oprand.Text = "-" Then
            theAns = firstVal - secondVal
            theAns = Math.Round(theAns, 14)
        End If

        If lbl_oprand.Text = "*" Then
            theAns = firstVal * secondVal
            theAns = Math.Round(theAns, 14)
        End If

        If lbl_oprand.Text = "/" Then
            theAns = firstVal / secondVal
            theAns = Math.Round(theAns, 14)
        End If

        If lbl_oprand.Text = "^" Then
            theAns = firstVal ^ secondVal
            theAns = Math.Round(theAns, 14)
        End If

        lbl_answer.Text = theAns.ToString()
    End Sub

    Private Sub angle_val_TextChanged(sender As Object, e As EventArgs) Handles angle_val.TextChanged
        Dim the_angle As Decimal = 0
        If IsNumeric(angle_val.Text) Then
            the_angle = Decimal.Parse(angle_val.Text)
        End If

        If choose_tan.SelectedItem = "sin" Then
            Dim the_sinAns As Decimal = 0
            the_sinAns = Math.Sin(the_angle * (Math.PI / 180))
            the_sinAns = Math.Round(the_sinAns, 10)
            lbl_tan_ans.Text = "sin" + the_angle.ToString() + "° is " + the_sinAns.ToString()
        End If

        If choose_tan.SelectedItem = "tan" Then
            Dim the_tanAns As Decimal = 0
            the_tanAns = Math.Tan(the_angle * (Math.PI / 180))
            the_tanAns = Math.Round(the_tanAns, 10)
            lbl_tan_ans.Text = "tan" + the_angle.ToString() + "° is " + the_tanAns.ToString()
        End If

        If choose_tan.SelectedItem = "cos" Then
            Dim the_cosAns As Decimal = 0
            the_cosAns = Math.Cos(the_angle * (Math.PI / 180))
            the_cosAns = Math.Round(the_cosAns, 10)
            lbl_tan_ans.Text = "cos" + the_angle.ToString() + "° is " + the_cosAns.ToString()
        End If
    End Sub
End Class
