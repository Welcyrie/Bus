Public Class ViewBusInfo

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ViewBusInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New BusTicketingDataContext
        Dim rs = From b In db.bus
                 Select b.busID, b.busPlateNum, b.busSeatAmount, b.insuranceDate, b.busRoadTax, b.busStatus
                 Where busStatus = "on"

        dgvBus.DataSource = rs
    End Sub
End Class