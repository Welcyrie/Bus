Public Class StaffUpdate
    Public selectID As String

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim db As New BusTicketingDataContext
            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)

            If s Is Nothing Then
                MessageBox.Show("ID Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            db.Staffs.DeleteOnSubmit(s)
            db.SubmitChanges()
            MessageBox.Show(s.staffID & " Delete successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("The Driver is on Schedule, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ''validation
        'Dim ci As String = If(mskIC.MaskCompleted, mskIC.Text, "")
        'Dim ph As String = If(mskPhNum.MaskCompleted, mskPhNum.Text, "")

        'If txtName.Text = "" Then
        '    MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtName.Focus()
        'ElseIf txtName.TextLength() < 3 Then
        '    MessageBox.Show("Your name must be more than 3 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtName.Focus()

        'ElseIf ci = "" Then
        '    MessageBox.Show("Please enter IC number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    mskIC.Focus()

        'ElseIf ph = "" Then
        '    MessageBox.Show("Please enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    mskPhNum.Focus()

        'ElseIf txtEmail.Text = "" Then
        '    MessageBox.Show("Please enter E-mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtEmail.Focus()
        'ElseIf txtEmail.TextLength() < 12 Then
        '    MessageBox.Show("Your E-mail cannot less than 14 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtEmail.Focus()

        'ElseIf txtPass.Text = "" Then
        '    MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtPass.Focus()
        'ElseIf txtPass.TextLength() < 6 Then
        '    MessageBox.Show("Your Password cannot less than 6 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtPass.Focus()

        'ElseIf cboPosition.SelectedIndex = -1 Then
        '    MessageBox.Show("Please choose Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    cboPosition.Focus()

        'ElseIf cboStatus.SelectedIndex = -1 Then
        '    MessageBox.Show("Please choose Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    cboStatus.Focus()

        'Else
        '    'end validation
        If Me.ValidateChildren = False Then
            Return
        End If
        Dim db As New BusTicketingDataContext
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)

        If rbdMale.Checked = True Then
            s.staffGender = "Male"
        ElseIf rbdFemale.Checked = True Then
            s.staffGender = "Female"
        End If

        s.staffID = lblID.Text
        s.staffName = txtName.Text
        s.staffEmail = txtEmail.Text
        s.password = txtPass.Text
        s.staffIC = mskIC.Text
        s.staffPhNum = mskPhNum.Text
        s.staffPosition = cboPosition.Text
        s.staffStatus = cboStatus.Text

        db.SubmitChanges()
        MessageBox.Show(s.staffID & " Update successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        'End If
    End Sub

    Private Sub StaffUpdate_Load(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()

        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Staffs

        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)

        If s Is Nothing Then
            MessageBox.Show("Staff Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        lblID.Text = s.staffID
        txtName.Text = s.staffName
        mskIC.Text = s.staffIC
        mskPhNum.Text = s.staffPhNum
        txtEmail.Text = s.staffEmail
        cboPosition.Text = s.staffPosition
        cboStatus.Text = s.staffStatus
        txtPass.Text = s.password

        Select Case s.staffGender
            Case "Female" : rbdFemale.Checked = True
            Case "Male" : rbdMale.Checked = True
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ResetForm()
        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Staffs

        txtEmail.Text = ""
        mskIC.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        mskPhNum.Text = ""
        cboPosition.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        lblID.Text = rs.Count.ToString("ST000")
        rbdMale.Checked = True
    End Sub
   
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If Me.ValidateChildren = False Then
            Return
        End If

            Dim db As New BusTicketingDataContext
            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)

            If rbdMale.Checked = True Then
                s.staffGender = "Male"
            ElseIf rbdFemale.Checked = True Then
                s.staffGender = "Female"
            End If

            s.staffID = lblID.Text
            s.staffName = txtName.Text
            s.staffEmail = txtEmail.Text
            s.password = txtPass.Text
            s.staffIC = mskIC.Text
            s.staffPhNum = mskPhNum.Text
            s.staffPosition = cboPosition.Text
            s.staffStatus = cboStatus.Text

            db.SubmitChanges()
            MessageBox.Show(s.staffID & " Update successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim db As New BusTicketingDataContext
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)

        If s Is Nothing Then
            MessageBox.Show("Staff Not Find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        db.Staffs.DeleteOnSubmit(s)
        db.SubmitChanges()
        MessageBox.Show(s.staffID & " Delete successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Char.IsLetter(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
                MessageBox.Show("Please use only character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Focus()
            End If
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
                MessageBox.Show("You can only key in letter and number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Focus()
            End If
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

    Private Sub mskPhNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskPhNum.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
                MessageBox.Show("You can only key in number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mskPhNum.Focus()
            End If
        End If
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        If txtName.Text = "" Then
            err.SetError(txtName, "Please enter the name.")
            e.Cancel = True
        ElseIf txtName.Text.Length < 3 Then
            err.SetError(txtName, "Name must be more than 3 character.")
            e.Cancel = True
        Else
            err.SetError(txtName, Nothing)
        End If
    End Sub

    Private Sub mskIC_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskIC.Validating
        Dim ci As String = If(mskIC.MaskCompleted, mskIC.Text, "")
        If ci.Length < 14 Then
            err.SetError(mskIC, "Please enter IC number correctly")
            e.Cancel = True
        Else
            err.SetError(mskIC, Nothing)
        End If
    End Sub

    Private Sub mskPhNum_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskPhNum.Validating
        Dim ph As String = If(mskPhNum.MaskCompleted, mskPhNum.Text, "")
        If ph.Length < 11 Then
            err.SetError(mskPhNum, "Please enter phone number correctly")
            e.Cancel = True
        Else
            err.SetError(mskPhNum, Nothing)
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If txtEmail.Text = "" Then
            err.SetError(txtEmail, "Please enter e-mail")
            e.Cancel = True
        ElseIf txtEmail.TextLength < 12 Then
            err.SetError(txtEmail, "Your e-mail should be more than 12 character")
            e.Cancel = True
        Else
            err.SetError(txtEmail, Nothing)
        End If
    End Sub

    Private Sub txtPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPass.Validating
        If txtPass.Text = "" Then
            err.SetError(txtPass, "Please enter password.")
            e.Cancel = True
        ElseIf txtPass.TextLength < 6 Then
            err.SetError(txtPass, "Your password should be more than 5 character")
            e.Cancel = True
        Else
            err.SetError(txtPass, Nothing)
        End If
    End Sub

    Private Sub cboPosition_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboPosition.Validating
        If cboPosition.SelectedIndex = -1 Then
            err.SetError(cboPosition, "Please select Staff position.")
            e.Cancel = True
        Else
            err.SetError(cboPosition, Nothing)
        End If
    End Sub

    Private Sub cboStatus_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboStatus.Validating
        If cboStatus.SelectedIndex = -1 Then
            err.SetError(cboStatus, "Please select staff status.")
            e.Cancel = True
        Else
            err.SetError(cboStatus, Nothing)
        End If
    End Sub
End Class