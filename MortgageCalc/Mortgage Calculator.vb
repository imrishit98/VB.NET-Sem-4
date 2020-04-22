'Author: Rishit Patel
'Date :  14 January, 2020
'Description: Mortgage Calculator

Public Class mortgageCalc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim M As Decimal = 0
        Dim P As Decimal = 0
        Dim r As Decimal = 0
        Dim n As Decimal = 0

        'M Is your monthly payment.
        'P Is your principal.
        'r Is your monthly interest rate, calculated by dividing your annual interest rate by 12.
        'n Is your number of payments (the number of months you will be paying the loan)

        If IsNumeric(txt_P.Text) Then
            P = Decimal.Parse(txt_P.Text)
        End If

        If IsNumeric(txt_r.Text) Then
            r = Decimal.Parse(txt_r.Text)
            r = (r / 100) / 12

        End If

        If IsNumeric(txt_n.Text) Then
            n = Decimal.Parse(txt_n.Text)
        End If

        If IsNumeric(txt_M.Text) Then
            M = Decimal.Parse(txt_M.Text)
        End If

        If P <> 0 AndAlso n <> 0 AndAlso r <> 0 Then
            M = P * ((r * (1 + r) ^ n) / ((1 + r) ^ n - 1))
            M = Math.Round(M, 2)
        End If

        If M <> 0 AndAlso n <> 0 AndAlso r <> 0 Then
            P = M * (((1 + r) ^ n - 1) / (r * (1 + r) ^ n))
            P = Math.Round(P, 2)
        End If

        txt_P.Text = P.ToString()
        txt_r.Text = r.ToString()
        txt_n.Text = n.ToString()
        txt_M.Text = M.ToString()
    End Sub
End Class
