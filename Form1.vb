Public Class frmReservations

    Dim intNumNights As Integer
    Dim strNumNights As String
    Dim decTotalCost As Decimal
    Const costPerNight As Decimal = 79D
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCostValueDisplay.Text = ""
        txtNumberOfNights.Text = ""
        txtNumberOfNights.Focus()
    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        strNumNights = txtNumberOfNights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCost = intNumNights * costPerNight
        lblCostValueDisplay.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub txtNumberOfNights_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfNights.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCostValueDisplay.Text = ""
        txtNumberOfNights.Text = ""
        txtNumberOfNights.Focus()
    End Sub
End Class
