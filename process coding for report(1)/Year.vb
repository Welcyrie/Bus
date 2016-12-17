Imports System.Text
Public Class Year

    Private Sub btnBusReport_Click(sender As Object, e As EventArgs) Handles btnYearticket.Click
        If cboYear.Text = "" Then
            MessageBox.Show("Please select the year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            PreYearticket.Document = DocYearticket
            PreYearticket.ShowDialog(Me)
        End If
    End Sub

    Private Sub DocBus_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DocYearticket.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim FontBody As New Font("Consolas", 10)
        Dim Footer As New Font("Consolas", 10)

        Dim header As String = "Yearly Ticket Selling Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine, DateTime.Now)
        Dim body As New StringBuilder()
        Dim foot As String = "Yearly Ticket Selling Report"
        body.AppendLine(vbTab & "No Ticket ID" & vbTab & "Bus Seat Number" & vbTab & "Date" & vbTab & vbTab & vbTab & "Time")
        body.AppendLine(vbTab & "-- ---------" & vbTab & "---------------" & vbTab & "----" & vbTab & vbTab & vbTab & "----")

        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Tickets
                 Join b In db.Bus_Schedulings On a.bsID Equals b.bsID
                 Where b.bsDate.Year = cboYear.Text
                 Select a.ticketID, a.seatNumber, b.bsDate, b.bsTime

        Dim cnt As Integer = 0
        Dim col(3) As String
        For Each item In rs
            cnt += 1
            col(0) = item.ticketID
            col(1) = item.seatNumber
            col(2) = item.bsDate
            col(3) = item.bsTime
            body.AppendFormat(vbTab & "{0,2} {1,5}" & vbTab & "{2,-20}" & vbTab & "{3,-20}" & vbTab & "{4,-15}" & vbNewLine, cnt, col(0), col(1), col(2), col(3))
        Next

        body.AppendLine()
        body.AppendFormat(vbTab & "{0,2} record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.FTR_bus, 300, 0, 200, 200)
            .DrawString(header, fontHeader, Brushes.Blue, 170, 190)
            .DrawString(subHeader, fontHeader, Brushes.Black, 150, 230)
            .DrawString(body.ToString(), FontBody, Brushes.Black, 0, 300)
            .DrawString(foot.ToString(), Footer, Brushes.Black, 45, 1000)
        End With
    End Sub

    Private Sub DocRoute_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DocYearbus.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim FontBody As New Font("Consolas", 10)
        Dim Footer As New Font("Consolas", 10)

        Dim header As String = "Yearly Bus Schedule Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine, DateTime.Now)
        Dim body As New StringBuilder()
        Dim foot As String = "Yearly Bus Schedule Report"
        body.AppendLine(vbTab & "No Bus ID" & "  Bus Schedule ID" & "  Staff ID" & "  Date  " & vbTab & "Time" & "  Route Start point" & "  Route End Point")
        body.AppendLine(vbTab & "-- ------" & "  ---------------" & "  --------" & "  ----  " & vbTab & "----" & "  ----------------" & "  ---------------")

        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Routes
                 Join b In db.Bus_Schedulings On a.routeID Equals b.routeID
                 Where b.bsDate.Year = cboYear.Text
                 Select b.staffID, b.busID, b.bsID, b.bsTime, b.bsDate, a.routeStartPoint, a.routeEndPoint

        Dim cnt As Integer = 0
        Dim col(7) As String
        For Each item In rs
            cnt += 1
            col(0) = item.busID
            col(1) = item.bsID
            col(2) = item.staffID
            col(3) = item.bsDate
            col(4) = item.bsTime
            col(5) = item.routeStartPoint
            col(6) = item.routeEndPoint
            body.AppendFormat(vbTab & "{0,2} {1,5}" & "{2,8}" & "{3,18}" & "{4,12}" & vbTab & "{5,2}" & "  {6,5}" & "{7,5}" & vbNewLine, cnt, col(0), col(1), col(2), col(3), col(4), col(5), col(6))
        Next

        body.AppendLine()
        body.AppendFormat(vbTab & "{0,2} record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.FTR_bus, 300, 0, 200, 200)
            .DrawString(header, fontHeader, Brushes.Blue, 170, 190)
            .DrawString(subHeader, fontHeader, Brushes.Black, 150, 230)
            .DrawString(body.ToString(), FontBody, Brushes.Black, 0, 300)
            .DrawString(foot.ToString(), Footer, Brushes.Black, 45, 1000)
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnYearbus_Click(sender As Object, e As EventArgs) Handles btnYearbus.Click
        If cboYear.Text = "" Then
            MessageBox.Show("Please select the year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else        
            PreYearbus.Document = DocYearbus
            PreYearbus.ShowDialog(Me)
        End If
    End Sub
End Class