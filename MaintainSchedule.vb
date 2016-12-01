Public Class MaintainSchedule
    Public selectedID As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub loadRoute()
        Dim db As New BusTicketingDataContext

        Dim route = From r In db.Routes
                    Select r.routeID

        cboRoute.DataSource = {""}.Concat(route).ToArray()
    End Sub

    Private Sub loadDriver()
        Dim db As New BusTicketingDataContext

        Dim staff = From s In db.Staffs
                    Select s.staffID

        cboStaff.DataSource = {""}.Concat(staff).ToArray()
    End Sub

    Private Sub loadBus()
        Dim db As New BusTicketingDataContext

        Dim bus = From b In db.Bus
                  Select b.busID

        cboBus.DataSource = {""}.Concat(bus).ToArray()
    End Sub

    Private Sub lblDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If lblDate.Text = "" Then
            err.SetError(lblDate, "Please enter a valid Date")
            e.Cancel = True
        Else
            err.SetError(lblDate, Nothing)
        End If
    End Sub

    Private Sub mskTime_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskTime.Validating
        Dim value As String = mskTime.Text.Replace(":", "").Trim
        If value = String.Empty Then
            e.Cancel = True
            err.SetError(mskTime, "Please enter a valid time")
        Else

            If value.Length = 4 Then


                Dim hour As Integer
                Dim minute As Integer
                If Integer.TryParse(value.Substring(0, 2), hour) = False Then
                    e.Cancel = True
                    err.SetError(mskTime, "Please enter a valid time")
                ElseIf hour < 0 Or hour > 23 Then
                    e.Cancel = True
                    err.SetError(mskTime, "Please enter a valid time")
                ElseIf Integer.TryParse(value.Substring(2, 2), minute) = False Then
                    e.Cancel = True
                    err.SetError(mskTime, "Please enter a valid time")
                    Return
                ElseIf minute < 0 OrElse minute > 59 Then
                    e.Cancel = True
                    err.SetError(mskTime, "Please enter a valid time")
                Else
                    err.SetError(mskTime, Nothing)
                End If
            Else
                e.Cancel = True
                err.SetError(mskTime, "Please enter a valid time")
            End If
        End If
    End Sub

    Private Sub MaintainSchedule_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        loadRoute()
        loadDriver()
        loadBus()

        Dim db As New BusTicketingDataContext
        Dim bs As Bus_Scheduling = db.Bus_Schedulings.FirstOrDefault(Function(o) o.bsID = selectedID)

        If bs Is Nothing Then
            MessageBox.Show("Bus Schedule Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        lblbsID.Text = bs.bsID
        cboRoute.SelectedItem = bs.routeID
        cboBus.SelectedItem = bs.busID
        cboStaff.SelectedItem = bs.staffID
        lblDate.Text = bs.bsDate
        mskTime.Text = bs.bsTime
        mskSeat.Text = bs.bsSeatAvailable

    End Sub

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    Dim db As New BusTicketingDataContext
    '    Dim bs As Bus_Scheduling = db.Bus_Schedulings.FirstOrDefault(Function(o) o.bsID = selectedID)

    '    If bs Is Nothing Then
    '        MessageBox.Show("Bus Schedule Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Me.Close()
    '        Return
    '    End If
    '    MessageBox.Show("Confirm Delete", "Delete Schedule?", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    db.Bus_Schedulings.DeleteOnSubmit(bs)
    '    db.SubmitChanges()
    '    MessageBox.Show("Bus schedule deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Me.Close()
    'End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren = False Then
            Return
        End If

        Dim db As New BusTicketingDataContext
        Dim bs As Bus_Scheduling = db.Bus_Schedulings.FirstOrDefault(Function(o) o.bsID = selectedID)

        If bs Is Nothing Then
            MessageBox.Show("Bus Schedule Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        bs.bsID = selectedID
        bs.routeID = cboRoute.SelectedItem.ToString
        bs.busID = cboBus.SelectedItem.ToString
        bs.staffID = cboStaff.SelectedItem.ToString
        bs.bsDate = lblDate.Text
        bs.bsTime = mskTime.Text
        bs.bsSeatAvailable = mskSeat.Text

        db.SubmitChanges()

        MessageBox.Show("Update successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MaintainSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar1.MinDate = Date.Now.ToShortDateString()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        lblDate.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString
    End Sub


    Private Sub mskSeat_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskSeat.Validating
        Dim db As New BusTicketingDataContext
        Dim rs = From b In db.bus
                 Where b.busID = cboBus.Text

        Dim seat As Integer = Integer.Parse(mskSeat.Text)
        Dim TotalSeat As Integer = Integer.Parse(rs.First.busSeatAmount)

        If seat > TotalSeat Then
            err.SetError(mskSeat, "Invalid number，Please check the bus seat amount")
            e.Cancel = True
        ElseIf mskSeat.TextLength < 2 Then
            err.SetError(mskSeat, "Please enter seat number")
            e.Cancel = True
        ElseIf IsNumeric(mskSeat.Text) Then
            err.SetError(mskSeat, Nothing)
        Else
            err.SetError(mskSeat, "Please enter numeric number only")
            e.Cancel = True
        End If
    End Sub
End Class