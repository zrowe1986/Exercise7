Public Class Exercise7

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        Dim Name, FirstName, LastName As String
        Dim n As Integer

        Name = txtFullName.Text
        n = Name.IndexOf(" ")

        If n < 0 Then
            MessageBox.Show("Enter a first and last name separated by a space.")
            Return
        End If

        FirstName = Name.Substring(0, n)
        LastName = Name.Substring(n + 1)

        With lstResults.Items
            .Clear()
            .Add("Your First Name is " & FirstName)
            .Add("Your Last Name is " & LastName)
            .Add("Your First Initial is " & FirstName.Substring(0, 1))
            .Add("The length of your Name is " & Name.Length & " letters")
        End With
    End Sub

    Private Sub btnCurrency_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        Dim number As Decimal
        number = CDec(txtNumber.Text)
        lblCurrency.Text = FormatCurrency(number, 2)
    End Sub

    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        Dim number As Decimal
        number = CDec(txtNumber.Text)
        lblPercent.Text = FormatPercent(number, 2)
    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        Dim number As Decimal
        number = CDec(txtNumber.Text)
        lblNumber.Text = FormatNumber(number, 1)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Clear()
        txtNumber.Clear()
        lstResults.Items.Clear()
        lblCurrency.Text = ""
        lblPercent.Text = ""
        lblNumber.Text = ""
        txtFullName.Focus()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

End Class