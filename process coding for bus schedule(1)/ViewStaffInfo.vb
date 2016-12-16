Public Class ViewStaffInfo

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ViewStaffInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Staffs
                 Select s.staffID, s.staffName, s.staffIC, s.staffGender, s.staffPhNum, s.staffEmail, s.staffPosition, s.staffStatus
                 Where staffPosition = "Driver"
        dgvStaff.DataSource = rs
    End Sub

End Class