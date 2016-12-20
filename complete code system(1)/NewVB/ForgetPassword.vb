Public Class ForgetPassword
    Public pass As String

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Staffs
        Dim rs2 = From b In db.Admins

        For Each item In rs
            If txtUser.Text = item.staffID And mskIC.Text = item.staffIC Then
                lblShow.Text = item.password
            End If
        Next

        For Each item In rs2
            If txtUser.Text = item.adminID Then
                lblShow.Text = item.adminPass
            End If
        Next

        btnOk.Enabled = True

        If txtUser.Text = "" Then
            MessageBox.Show("Please input user id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mskIC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskIC.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
                MessageBox.Show("You can only key in number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mskIC.Focus()
            End If
        End If
    End Sub

    Private Sub ForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOk.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class