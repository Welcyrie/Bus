Public Class RouteUpdate

    Public SelectedId As String


    Private Sub Reset()

        txtBusFare.Text = ""
        cboSP.SelectedIndex = -1
        cboEP.SelectedIndex = -1
        err.Clear()
    End Sub

    Private Sub frmUpdate_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Reset()
        Dim db As New BusTicketingDataContext()
        Dim c As Route = db.Routes.FirstOrDefault(Function(o) o.routeID = SelectedId)

        If c Is Nothing Then
            MessageBox.Show("Route Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        txtRoute.Text = c.routeID
        txtBusFare.Text = c.routeBusFare

        cboSP.Text = c.routeStartPoint
        cboEP.Text = c.routeEndPoint



    End Sub

    

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If Me.ValidateChildren = False Then
            Return
        End If

        Dim db As New BusTicketingDataContext
        Dim s As Route = db.Routes.FirstOrDefault(Function(o) o.routeID = SelectedId)

        If s Is Nothing Then
            MessageBox.Show("Route Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        

            s.routeID = txtRoute.Text
            s.routeStartPoint = cboSP.Text
            s.routeEndPoint = cboEP.Text
            s.routeBusFare = Decimal.Parse(txtBusFare.Text)

            db.SubmitChanges()

            MessageBox.Show("Update successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim db As New BusTicketingDataContext
            Dim r As Route = db.Routes.FirstOrDefault(Function(o) o.routeID = SelectedId)

            If r Is Nothing Then
                MessageBox.Show("Route Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            db.Routes.DeleteOnSubmit(r)
            db.SubmitChanges()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please check if the route used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboSP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboSP.Validating


        If cboSP.Text = "" Then
            err.SetError(cboSP, "Please select a Start Point")
            e.Cancel = True

        ElseIf cboSP.Text = cboEP.Text Then
            err.SetError(cboSP, "Start Point and End Point Cannot be same")
            e.Cancel = True

        Else
            err.SetError(cboSP, Nothing)
        End If

    End Sub

    Private Sub cboEP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboEP.Validating


        If cboEP.Text = "" Then
            err.SetError(cboEP, "Please select a End Point")
            e.Cancel = True

        ElseIf cboEP.Text = cboSP.Text Then
            err.SetError(cboEP, "End Point and Start Point Cannot be same")
            e.Cancel = True
        Else
            err.SetError(cboEP, Nothing)
        End If

    End Sub

    Private Sub txtBusFare_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

        Try
            If txtBusFare.Text = "" Then
                err.SetError(txtBusFare, "Please enter Bus Fare")
                e.Cancel = True

            ElseIf IsNumeric(txtBusFare.Text) = False Then
                err.SetError(txtBusFare, "Please enter Digit")
                e.Cancel = True
            Else
                err.SetError(txtBusFare, Nothing)
            End If
        Catch ex As Exception
            err.SetError(txtBusFare, "Please enter digit and . only")
            e.Cancel = True
        End Try
    End Sub

End Class