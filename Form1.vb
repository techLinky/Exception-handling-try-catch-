Public Class Form1
    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim strNumber As String
        strNumber = txtInput.Text

        Try
            Dim NumericValue As Double
            NumericValue = CDbl(strNumber)

            MsgBox("You entered a valid number" & NumericValue)

        Catch
            MsgBox(" Error: " & strNumber & (" Is not a number "))


        End Try

    End Sub
End Class
