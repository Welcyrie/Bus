Public Class BusSchedule
    Private Sub BusSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        loadRoute()
        loadDriver()
        loadBus()
        calendar1.MinDate = Date.Now.ToShortDateString()
    End Sub

    Private Sub loadRoute()
        Dim db As New BusTicketingDataContext

        Dim route = From r In db.Routes
                    Select r.routeID

        cboRoute.DataSource = {""}.Concat(route).ToArray()
    End Sub

    Private Sub loadDriver()

        Dim db As New BusTicketingDataContext
        Dim rs = From b In db.Staffs
                 Where b.staffPosition = "Driver"
                 Select b.staffID

        cboStaff.DataSource = {""}.Concat(rs).ToArray()
    End Sub

    Private Sub loadBus()
        Dim db As New BusTicketingDataContext

        Dim bus = From b In db.bus
                  Where b.busStatus = "on"
                  Select b.busID

        cboBus.DataSource = {""}.Concat(bus).ToArray()
    End Sub

    Private Sub BindData()
        Dim id As String = ""
        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Bus_Schedulings
                Join a In db.Routes On s.routeID Equals a.routeID
                Join b In db.bus On s.busID Equals b.busID
               Select s.bsDate, s.bsTime, a.routeStartPoint, a.routeEndPoint, a.routeBusFare,
               s.bsSeatAvailable, b.busSeatAmount, s.bsID, b.busPlateNum

        bsDGV.DataSource = rs
        For i As Integer = 0 To rs.Count - 1
            Dim Seat As Integer = CInt(bsDGV.Rows(i).Cells(5).Value)
            If Seat > 0 Then
                bsDGV.Rows(i).DefaultCellStyle.BackColor = Color.Green
            Else
                bsDGV.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next

        Try
            For Each z In rs
                id = z.bsID
            Next
            Dim id1 As String = id.ToCharArray(0, 2)
            Dim id2 As Integer = CInt(id.Substring(2))
            id2 += 1
            Dim id3 As String = CStr(id2)
            For r = 0 To 3

                If id3.Length < 1 Then
                    id3 = "0" & id3
                ElseIf id3.Length < 2 Then
                    id3 = "0" & id3
                ElseIf id3.Length < 3 Then
                    id3 = "0" & id3
                End If
            Next

            id = id1 & id3

            lblBsID.Text = id
        Catch ex As Exception
            lblBsID.Text = "BS001"
        End Try

        
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.ValidateChildren = False Then
            Return
        End If

            Dim bsID As String = lblBsID.Text
            Dim routeID As String = cboRoute.SelectedItem.ToString
            Dim busID As String = cboBus.SelectedItem.ToString
            Dim driverID As String = cboStaff.SelectedItem.ToString
            Dim ScheduleDate As String = lblDate.Text
            Dim ScheduleTime As String = mskTime.Text
        Dim number As String = mskSeat.Text

        Dim db As New BusTicketingDataContext
            Dim bs As New Bus_Scheduling

            bs.bsID = bsID
            bs.routeID = routeID
            bs.busID = busID
            bs.staffID = driverID
            bs.bsDate = ScheduleDate
            bs.bsTime = ScheduleTime
            bs.bsSeatAvailable = number

            db.Bus_Schedulings.InsertOnSubmit(bs)
            db.SubmitChanges()
            MessageBox.Show(" Insert successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BindData()
        clearAll()
        btnAdd.Enabled = False
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


    Private Sub cboBus_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboBus.Validating
        If cboBus.SelectedItem = "" Then
            err.SetError(cboBus, "Please select the bus")
            e.Cancel = True
        Else
            err.SetError(cboBus, Nothing)
            mskSeat.Enabled = True
        End If
    End Sub

    Private Sub cboRoute_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboRoute.Validating
        If cboRoute.SelectedItem = "" Then
            err.SetError(cboRoute, "Please select the route")
            e.Cancel = True
        Else
            err.SetError(cboRoute, Nothing)
        End If
    End Sub

    Private Sub cboStaff_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboStaff.Validating
        If cboStaff.SelectedItem = "" Then
            err.SetError(cboStaff, "Please select the driver")
            e.Cancel = True
        Else
            err.SetError(cboStaff, Nothing)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearAll()
    End Sub

    Private Sub clearAll()
        mskSeat.Clear()
        mskSeat.Enabled = False
        cboBus.SelectedIndex = "0"
        cboRoute.SelectedIndex = "0"
        cboStaff.SelectedIndex = "0"
        lblDate.Text = ""
        mskTime.Clear()
    End Sub

    Private Sub bsDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles bsDGV.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(bsDGV.Rows(i).Cells(7).Value)
            Dim oldDate As DateTime = DateTime.Parse(bsDGV.Rows(i).Cells(0).Value)
            If oldDate < DateTime.Now Then
                MessageBox.Show("The bus schedule cannot be update after current date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf oldDate > DateTime.Now Then
                MaintainSchedule.selectedID = id
                MaintainSchedule.ShowDialog(Me)
                BindData()
            End If
        End If
    End Sub

    Private Sub calendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar1.DateChanged
        lblDate.Text = calendar1.SelectionRange.Start.ToShortDateString
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        clearAll()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        MessageBox.Show("Please fill in all the information in order to add new Schedule", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        MessageBox.Show("Double click the data to update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub mskSeat_Validating1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskSeat.Validating
        Dim db As New BusTicketingDataContext
        Dim rs = From b In db.bus
                 Where b.busID = cboBus.Text

        If mskSeat.Text = "" Then
            mskSeat.Text = "00"
            'err.SetError(mskSeat, "Please enter seat number")
            'e.Cancel = True
        End If

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
            btnAdd.Enabled = True
        Else
            err.SetError(mskSeat, "Please enter numeric number only")
            e.Cancel = True
        End If
    End Sub

    Private Sub bsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bsDGV.CellContentClick

    End Sub


End Class