Public Class TicketSelling

    Public busScheduleID As String

    Private Sub TicketSelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        calender1.MinDate = Date.Now.ToShortDateString()
    End Sub

    Private Sub BindData()

        Dim From As String = txtFrom.Text
        Dim Destination As String = txtTo.Text
        Dim ChooseDate As Date = calender1.SelectionRange.Start.ToShortDateString

        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Bus_Schedulings
                 Join a In db.Routes On s.routeID Equals a.routeID
                 Join b In db.Bus On s.busID Equals b.busID
                Select s.bsDate, s.bsTime, a.routeStartPoint, a.routeEndPoint, a.routeBusFare, s.bsSeatAvailable, b.busSeatAmount, s.bsID, b.busPlateNum
                Where routeStartPoint.Contains(From) And routeEndPoint.Contains(Destination) And
                bsDate.Equals(ChooseDate)

        dgv.DataSource = rs
        lblCount.Text = rs.Count.ToString("0 schedule(s)")

        For i As Integer = 0 To rs.Count - 1
            Dim Seat As Integer = CInt(dgv.Rows(i).Cells(5).Value)
            If Seat > 0 Then
                dgv.Rows(i).DefaultCellStyle.BackColor = Color.Green
            Else
                dgv.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub txtFrom_TextChanged(sender As Object, e As EventArgs) Handles txtFrom.TextChanged
        BindData()
    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged
        BindData()
    End Sub

    Private Sub calender1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calender1.DateChanged
        lblDate.Text = calender1.SelectionRange.Start.ToShortDateString
        BindData()
    End Sub


    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(7).Value)
            Dim Seat As Integer = CInt(dgv.Rows(i).Cells(5).Value)
            Dim TotalSeat As Integer = CInt(dgv.Rows(i).Cells(6).Value)
            Dim Departure As String = CStr(dgv.Rows(i).Cells(2).Value)
            Dim Destination As String = CStr(dgv.Rows(i).Cells(3).Value)
            Dim BsDate As Date = CDate(dgv.Rows(i).Cells(0).Value)
            Dim BsTime As String = CStr(dgv.Rows(i).Cells(1).Value)
            Dim Price As String = CStr(dgv.Rows(i).Cells(4).Value)

            If (Seat > 0) Then
                busScheduleID = id
                Dim SeatNumber As Integer = TotalSeat - Seat + 1
                lblTicketID.Text = id + "T0" + SeatNumber.ToString("00")
                lblSeatNumber.Text = SeatNumber
                lblBusSchedule.Text = "From " + Departure + "To  " + Destination + vbNewLine + BsDate + "-------" + BsTime
                lblPayment.Text = "RM" + Price
                TicketGenerate.lblPrice.Text = "RM" + Price
                TicketGenerate.lblSchedule.Text = "From " + Departure + "To  " + Destination + vbNewLine + BsDate + "-------" + BsTime
                TicketGenerate.lblSeatNumber.Text = SeatNumber
                TicketGenerate.lblTicketID.Text = id + "T0" + SeatNumber.ToString("00")

            Else
                MessageBox.Show("Schedule Full. Please select other schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearAll()
    End Sub

    Private Sub clearAll()
        lblBusSchedule.Text = ""
        lblPayment.Text = ""
        lblSeatNumber.Text = ""
        lblTicketID.Text = ""
        txtFrom.Text = ""
        txtTo.Text = ""
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If lblBusSchedule.Text = "" Then
            MessageBox.Show("Please select schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TicketGenerate.ShowDialog(Me)
            clearAll()
            BindData()
        End If
        
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        clearAll()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SelectTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectTicketToolStripMenuItem.Click
        MessageBox.Show("Double click the schedule to select the schedule.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class