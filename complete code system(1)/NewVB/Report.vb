Imports System.Text
Public Class Report
    
    Private Sub btnYesr_Click(sender As Object, e As EventArgs) Handles btnYesr.Click
        Year.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        Month.ShowDialog(Me)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        PreStaff.Document = DocStaff
        PreStaff.ShowDialog(Me)
    End Sub


    Private Sub DocStaff_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DocStaff.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim FontBody As New Font("Consolas", 10)
        Dim Footer As New Font("Consolas", 10)

        Dim header As String = "Staff Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine, DateTime.Now)
        Dim body As New StringBuilder()
        Dim foot As String = "Staff Report"
        body.AppendLine(vbTab & "No Staff ID" & vbTab & "Staff Name" & vbTab & "Staff Gender" & vbTab & "Staff Phone Number" & vbTab & "Staff Position")
        body.AppendLine(vbTab & "-- --------" & vbTab & "----------" & vbTab & "------------" & vbTab & "------------------" & vbTab & "--------------")

        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Staffs

        Dim cnt As Integer = 0
        Dim col(4) As String
        For Each item In rs
            cnt += 1
            col(0) = item.staffID
            col(1) = item.staffName
            col(2) = item.staffGender
            col(3) = item.staffPhNum
            col(4) = item.staffPosition
            body.AppendFormat(vbTab & "{0,2} {1,5}" & vbTab & "{2,-20}" & vbTab & "{3,-13}" & vbTab & "{4,-20}" & vbTab & "{5,-15}" & vbNewLine, cnt, col(0), col(1), col(2), col(3), col(4))
        Next

        body.AppendLine()
        body.AppendFormat(vbTab & "{0,2} record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.FTR_bus, 300, 0, 200, 200)
            .DrawString(header, fontHeader, Brushes.Blue, 300, 190)
            .DrawString(subHeader, fontHeader, Brushes.Black, 150, 230)
            .DrawString(body.ToString(), FontBody, Brushes.Black, 0, 300)
            .DrawString(foot.ToString(), Footer, Brushes.Black, 45, 1000)
        End With
    End Sub

    Private Sub btnRoute_Click(sender As Object, e As EventArgs) Handles btnRoute.Click
        PreRoute.Document = DocRoute
        PreRoute.ShowDialog(Me)
    End Sub


    Private Sub DocRoute_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DocRoute.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim FontBody As New Font("Consolas", 10)
        Dim Footer As New Font("Consolas", 10)

        Dim header As String = "Route Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine, DateTime.Now)
        Dim body As New StringBuilder()
        Dim foot As String = "Route Report"
        body.AppendLine(vbTab & "No Route ID" & vbTab & "Route Start Point" & vbTab & "Route End Point" & vbTab & "Bus  Fare")
        body.AppendLine(vbTab & "-- --------" & vbTab & "-----------------" & vbTab & "---------------" & vbTab & "---------")

        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Routes

        Dim cnt As Integer = 0
        Dim col(3) As String
        For Each item In rs
            cnt += 1
            col(0) = item.routeID
            col(1) = item.routeStartPoint
            col(2) = item.routeEndPoint
            col(3) = item.routeBusFare
            body.AppendFormat(vbTab & "{0,2} {1,5}" & vbTab & "{2,-20}" & vbTab & "{3,-13}" & vbTab & "{4,-20}" & vbNewLine, cnt, col(0), col(1), col(2), col(3))
        Next

        body.AppendLine()
        body.AppendFormat(vbTab & "{0,2} record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.FTR_bus, 300, 0, 200, 200)
            .DrawString(header, fontHeader, Brushes.Blue, 300, 190)
            .DrawString(subHeader, fontHeader, Brushes.Black, 150, 230)
            .DrawString(body.ToString(), FontBody, Brushes.Black, 0, 300)
            .DrawString(foot.ToString(), Footer, Brushes.Black, 45, 1000)
        End With
    End Sub

End Class