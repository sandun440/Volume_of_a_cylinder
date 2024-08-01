Public Class Form1
    Dim r As Single
    Dim h As Single
    Dim V As Single
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        r = txtRadius.Text
        h = txtHeight.Text
        V = (22 / 7) * r * r * h
        txtVolume.Text = V

    End Sub

    Private Sub btnClearall_Click(sender As Object, e As EventArgs) Handles btnClearall.Click
        txtRadius.Text = ""
        txtHeight.Text = ""
        txtVolume.Text = ""
        txtRadius.Focus()
    End Sub
End Class
