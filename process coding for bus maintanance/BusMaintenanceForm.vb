Public Class BusMaintenanceForm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Me.ValidateChildren = False Then
            Return
        End If

        Try
            Dim db As New BusTicketingDataContext
            Dim s As New bus
            ' Dim BusID = lblBusId.Text

            s.busID = lblBusId.Text
            s.busPlateNum = maskNumber.Text
            s.busSeatAmount = comboSeat.SelectedItem.ToString()
            s.insuranceDate = CStr(Me.Calendar1.SelectionRange.Start)
            s.busRoadTax = Decimal.Parse(txtRoad.Text)
            s.busStatus = comboStatus.SelectedItem.ToString()

            db.bus.InsertOnSubmit(s)
            db.SubmitChanges()
            'MessageBox.Show(lblBusId.Text & " Insert successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetForm()

            BindData()
        Catch ex As Exception
            MessageBox.Show("Please enter the required information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ResetForm()

        maskNumber.Text = ""
        comboSeat.SelectedIndex = -1
        txtRoad.Text = ""
        comboStatus.SelectedIndex = -1
        generate_ID()

    End Sub

    Private Sub BindData()

        Dim busId As String = lblBusId.Text


        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Bus

        dgv.DataSource = rs

    End Sub


    Private Sub maskNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles maskNumber.Validating

        Dim number As String = If(maskNumber.MaskCompleted, maskNumber.Text, "")

        If number = "" Then
            err.SetError(maskNumber, "Please enter a valid " & number)
            e.Cancel = True
        Else
            err.SetError(maskNumber, Nothing)
        End If

    End Sub

    Private Sub txtRoad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If txtRoad.Text = "" Then
            err.SetError(txtRoad, "Please enter the Amount of Road Tax")
            e.Cancel = True
        ElseIf IsNumeric(txtRoad.Text) Then
            err.SetError(txtRoad, Nothing)
        Else
            err.SetError(txtRoad, "Please enter a numeric number only")
            e.Cancel = True
        End If
    End Sub

    Private Sub BusMaintenanceForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        generate_ID()
        Calendar1.MinDate = Date.Now.ToShortDateString
        BindData()

    End Sub

    Private Sub generate_ID()
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.bus

        'Dim id = rs.Count.ToString("ST000")
        Dim id As String = ""
        For Each z In rs
            id = z.busId
        Next
        Dim id1 As String = id.ToCharArray(0, 2)
        Dim id2 As Integer = CInt(id.Substring(2))
        id2 += 1
        Dim id3 As String = CStr(id2)
        For r = 0 To 2
            If id3.Length <> 3 Then
                id3 = "0" & id3
            End If
        Next

        id = id1 & id3
        lblBusId.Text = id
        'lblID.Text = rs.Count.ToString("ST000")


    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            UpdateForm.SelectedId = id
            UpdateForm.ShowDialog(Me)

            BindData()

        End If
    End Sub


    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        MessageBox.Show("Double click the data to update or delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtRoad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoad.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
                MessageBox.Show("You can only key in number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
