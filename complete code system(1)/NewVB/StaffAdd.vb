Public Class StaffAdd
    Public selectID As String

    Private Sub StaffAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Staffs
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)
        'Dim id = rs.Count.ToString("ST000")
        Dim id As String = ""
        For Each z In rs
            id = z.staffID
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
        lblID.Text = id
        'lblID.Text = rs.Count.ToString("ST000")
        rbdMale.Checked = True
        ResetForm()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.ValidateChildren = False Then
            Return
        End If

        Dim db As New BusTicketingDataContext
        Dim s As New Staff

        Dim id As String = lblID.Text
        Dim ic As String = mskIC.Text
        Dim name As String = txtName.Text
        Dim phnum As String = mskPhNum.Text
        Dim email As String = txtEmail.Text
            Dim position As String = cboPosition.Text
            Dim status As String = cboStatus.Text
        Dim password As String = txtPass.Text

        If rbdMale.Checked = True Then
            s.staffGender = "Male"
        ElseIf rbdFemale.Checked = True Then
            s.staffGender = "Female"
        End If

        s.staffID = id
        s.staffName = name
        s.staffEmail = email
        s.password = password
        s.staffIC = ic
        s.staffPhNum = phnum
        s.staffPosition = position
        s.staffStatus = status

        db.Staffs.InsertOnSubmit(s)
        db.SubmitChanges()
        MessageBox.Show(id & " Add successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetForm()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Staffs
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)
        'Dim id = rs.Count.ToString("ST000")
        Dim id As String = ""
        For Each z In rs
            id = z.staffID
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
        lblID.Text = id
        'lblID.Text = rs.Count.ToString("ST000")
        rbdMale.Checked = True

        txtEmail.Text = ""
        mskIC.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        mskPhNum.Text = ""
        cboPosition.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        rbdMale.Checked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ResetForm()
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Staffs
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)
        'Dim id = rs.Count.ToString("ST000")
        Dim id As String = ""
        For Each z In rs
            id = z.staffID
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
        lblID.Text = id
        'lblID.Text = rs.Count.ToString("ST000")
        rbdMale.Checked = True

        txtEmail.Text = ""
        mskIC.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        mskPhNum.Text = ""
        cboPosition.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        rbdMale.Checked = True
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

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Char.IsLetter(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
                MessageBox.Show("You can only key in letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        If Me.ValidateChildren = False Then
            Return
        End If

        Dim db As New BusTicketingDataContext
        Dim s As New Staff

        Dim id As String = lblID.Text
        Dim ic As String = mskIC.Text
        Dim name As String = txtName.Text
        Dim phnum As String = mskPhNum.Text
        Dim email As String = txtEmail.Text
        Dim position As String = cboPosition.Text
        Dim status As String = cboStatus.Text
        Dim password As String = txtPass.Text

        If rbdMale.Checked = True Then
            s.staffGender = "Male"
        ElseIf rbdFemale.Checked = True Then
            s.staffGender = "Female"
        End If

        s.staffID = id
        s.staffName = name
        s.staffEmail = email
        s.password = password
        s.staffIC = ic
        s.staffPhNum = phnum
        s.staffPosition = position
        s.staffStatus = status

        db.Staffs.InsertOnSubmit(s)
        db.SubmitChanges()
        MessageBox.Show(id & " Add successful", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ResetForm()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim db As New BusTicketingDataContext
        Dim rs = From a In db.Staffs
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectID)
        'Dim id = rs.Count.ToString("ST000")
        Dim id As String = ""
        For Each z In rs
            id = z.staffID
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
        lblID.Text = id
        'lblID.Text = rs.Count.ToString("ST000")
        rbdMale.Checked = True

        txtEmail.Text = ""
        mskIC.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        mskPhNum.Text = ""
        cboPosition.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        rbdMale.Checked = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
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