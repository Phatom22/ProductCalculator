Public Class Form1
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim Price As Decimal
        Dim items As Integer
        Dim Total As Decimal
        Dim CusName As String

        CusName = txtCusName.Text
        Price = txtPrice.Text
        items = txtQuantity.Text
        Total = Price * items

        MsgBox("hi " & CusName & " your total price is " & Total & " Rands")
    End Sub
End Class
