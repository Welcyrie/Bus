
Public Class RouteAdd
    Public exist As Boolean = True
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Me.ValidateChildren = False Then
            Return
        End If

        Dim id As String = txtRoute.Text
        Dim busFare As Decimal = Decimal.Parse(txtBusFare.Text)
        Dim SP As String = cboSP.Text
        Dim EP As String = cboEP.Text



        Dim db As New BusTicketingDataContext
        Dim s As New Route

        existed(SP, EP)

        If exist = True Then
            MessageBox.Show("Route existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            s.routeID = id
            s.routeStartPoint = SP
            s.routeEndPoint = EP
            s.routeBusFare = busFare

            db.Routes.InsertOnSubmit(s)
            db.SubmitChanges()
            MessageBox.Show(id & " Insert successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
            insertNew()
        End If
    End Sub

    Private Sub existed(sp As String, ep As String)
        Dim db As New BusTicketingDataContext
        Dim rs2 = From i In db.Routes
                  Where i.routeStartPoint = sp And i.routeEndPoint = ep
                  Select i.routeID

        If rs2.Count = 0 Then
            exist = False
        Else
            exist = True
        End If
    End Sub

    Private Sub Reset()
        txtBusFare.Text = ""
        cboSP.SelectedIndex = -1
        cboEP.SelectedIndex = -1
        err.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub


    Private Sub RouteAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        err.Clear()
        insertNew()

    End Sub

    Private Function IsDuplicated(sp As String, ep As String) As Boolean

        Dim db As New BusTicketingDataContext

        Return db.Routes.Any(Function(o) o.routeStartPoint = sp & o.routeEndPoint = ep)

    End Function




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

    Private Sub txtBusFare_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBusFare.Validating

        Try
            If txtBusFare.Text = "" Then
                err.SetError(txtBusFare, "Please enter Bus Fare")
                e.Cancel = True
            ElseIf IsNumeric(txtBusFare.Text) = False Then
                err.SetError(txtBusFare, "Please enter digit")
                e.Cancel = True
            Else
                err.SetError(txtBusFare, Nothing)
            End If
        Catch ex As Exception
            err.SetError(txtBusFare, "Please enter digit and . only")
        End Try
    End Sub

    Private Sub insertNew()
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Routes

        Dim id As String = ""
        For Each z In rs
            id = z.routeID
        Next
        Dim id1 As String = id.ToCharArray(0, 2)
        Dim id2 As Integer = CInt(id.Substring(2))
        id2 += 1
        Dim id3 As String = CStr(id2)
        For r = 0 To 2

            If id3.Length < 1 Then
                id3 = "0" & id3
            ElseIf id3.Length < 2 Then
                id3 = "0" & id3
            End If
        Next

        id = id1 & id3

        txtRoute.Text = id

    End Sub

    Private Sub cboSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSP.SelectedIndexChanged

    End Sub
End Class