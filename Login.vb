Public Class Login

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ForgetPassword.ShowDialog(Me)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUser.Text
        Dim pass As String = txtPassword.Text
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Staffs
        Dim validate As Boolean = False

        Dim rs2 = From b In db.Admins

        If txtPassword.Text = "" And txtUser.Text = "" Then
            MessageBox.Show("User name and password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please input user password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtUser.Text = "" Then
            MessageBox.Show("Please input user password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            For Each item In rs
                If txtUser.Text = item.staffID And txtPassword.Text = item.password Then
                    MainMenu.btnReport.Visible = False
                    MainMenu.btnStaff.Visible = False
                    validate = True
                    MessageBox.Show("Login successful and you logged in as Staff", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetform()
                    MainMenu.Show()

                End If
            Next

           
            For Each item In rs2
                If txtUser.Text = item.adminID And txtPassword.Text = item.adminPass Then
                    MainMenu.btnReport.Visible = True
                    MainMenu.btnStaff.Visible = True
                    validate = True
                    MessageBox.Show("Login successful and you logged in as Admin", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetform()
                    MainMenu.Show()

                End If
            Next

            If validate = False Then
                MessageBox.Show("Username and password is incorrect", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                validate = False
            End If

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub resetform()
        txtPassword.Text = ""
        txtUser.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
                MessageBox.Show("You can only key in letter and number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
            End If
        End If
    End Sub
End Class