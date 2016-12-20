Public Class ViewRouteInfo

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ViewRouteInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New BusTicketingDataContext
        Dim rs = From r In db.Routes
                 Select r.routeID, r.routeStartPoint, r.routeEndPoint, r.routeBusFare
        dgvRoute.DataSource = rs

    End Sub
End Class