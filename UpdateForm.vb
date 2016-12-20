Public Class UpdateForm

    Public SelectedId As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren = False Then
            Return
        End If

        Dim db As New BusTicketingDataContext
        Dim s As bus = db.bus.FirstOrDefault(Function(o) o.busId = SelectedId)

        If s Is Nothing Then
            MessageBox.Show("Bus Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        s.busPlateNum = maskNumber.Text
        s.busSeatAmount = comboSeat.SelectedItem.ToString()
        s.insuranceDate = CStr(Me.Calendar1.SelectionRange.Start)
        s.busRoadTax = Decimal.Parse(txtRoadTax.Text)
        s.busStatus = comboStatus.SelectedItem.ToString()

        db.SubmitChanges()

        MessageBox.Show("Update successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ResetForm()

        Me.Close()
    End Sub

    Private Sub ResetForm()

        maskNumber.Text = ""
        comboSeat.SelectedIndex = -1
        txtRoadTax.Text = ""
        comboStatus.SelectedIndex = -1


    End Sub

    Private Sub UpdateForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Calendar1.MinDate = Date.Now.ToShortDateString
        Dim db As New BusTicketingDataContext()
        Dim s As bus = db.bus.FirstOrDefault(Function(o) o.busId = SelectedId)

        If s Is Nothing Then
            MessageBox.Show("Bus Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        lblId.Text = s.busId
        maskNumber.Text = s.busPlateNum
        comboSeat.Text = s.busSeatAmount
       
        txtRoadTax.Text = s.busRoadTax

        comboStatus.Text = s.busStatus
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim db As New BusTicketingDataContext
            Dim c As bus = db.bus.FirstOrDefault(Function(o) o.busID = SelectedId)

            If c Is Nothing Then
                MessageBox.Show("Bus Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            MessageBox.Show("Confirm delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            db.bus.DeleteOnSubmit(c)
            db.SubmitChanges()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please check if the bus is on schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtRoadTax_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRoadTax.Validating
        If txtRoadTax.Text = "" Then
            err.SetError(txtRoadTax, "Please enter the Amount of Road Tax")
            e.Cancel = True
        ElseIf IsNumeric(txtRoadTax.Text) Then
            err.SetError(txtRoadTax, Nothing)
        Else
            err.SetError(txtRoadTax, "Please enter a numeric number only")
            e.Cancel = True
        End If
    End Sub

End Class