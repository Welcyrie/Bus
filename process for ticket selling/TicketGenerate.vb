Imports System.Text

Public Class TicketGenerate

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TicketGenerate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GeneratePayID()
        btnAdd.Enabled = False
        lblDate.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub GeneratePayID()
        Dim id As String = ""
        Dim db As New BusTicketingDataContext
        Dim rs = From p In db.payments

        Try
            For Each z In rs
                id = z.payID
            Next
            Dim id1 As String = id.ToCharArray(0, 1)
            Dim id2 As Integer = CInt(id.Substring(1))
            id2 += 1
            Dim id3 As String = CStr(id2)
            For r = 0 To 10

                If id3.Length < 6 Then
                    id3 = "0" & id3

                End If
            Next

            id = id1 & id3

            lblPayID.Text = id
        Catch ex As Exception
            lblPayID.Text = "P000001"
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            Dim PayID As String = lblPayID.Text
            Dim price As String = lblPrice.Text
            Dim PayDate As String = lblDate.Text
            Dim ticketId As String = lblTicketID.Text
            Dim bsId As String = lblTicketID.Text.ToCharArray(0, 5)
            Dim Seat As String = lblSeatNumber.Text

            Dim characterToRemove As String = "RM"
            Dim cleanString As String = Replace(price, characterToRemove, "")
            Dim newPrice As Decimal = Decimal.Parse(cleanString)

            Dim db As New BusTicketingDataContext
            Dim p As New payment
            Dim t As New Ticket

            t.ticketID = ticketId
            t.seatNumber = Seat
            t.bsID = bsId
            t.payID = PayID
            p.payID = PayID
            p.payAmount = newPrice
            p.payDate = PayDate

            db.Tickets.InsertOnSubmit(t)
            db.payments.InsertOnSubmit(p)
            db.SubmitChanges()
            UpdateSeat()
            MessageBox.Show(" Update successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(" Unable to update data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateSeat()
        Dim id As String = ""
        id = lblTicketID.Text
        Dim id1 As String = id.ToCharArray(0, 5)

        Dim db As New BusTicketingDataContext
        Dim bs As Bus_Scheduling = db.Bus_Schedulings.FirstOrDefault(Function(o) o.bsID = id1)

        If bs Is Nothing Then
            MessageBox.Show("Bus Schedule Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        bs.bsSeatAvailable -= 1
        db.SubmitChanges()

    End Sub


    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage

        Dim fontBody As New Font("Consolas", 12)


        Dim body As New StringBuilder()

        body.AppendLine(lblSchedule.Text)
        body.AppendLine(lblPrice.Text)
        body.AppendLine("")
        body.AppendLine("Seat number : " + lblSeatNumber.Text)

        With e.Graphics
            .DrawImage(My.Resources.FTR_bus, 0, 0, 200, 200)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 300, 50)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
        btnAdd.Enabled = True
    End Sub

    Private Sub TicketGenerate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class