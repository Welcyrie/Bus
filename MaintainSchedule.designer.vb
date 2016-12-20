<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblbsID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskSeat = New System.Windows.Forms.MaskedTextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnViewStaff = New System.Windows.Forms.Button()
        Me.btnViewBus = New System.Windows.Forms.Button()
        Me.btnViewRoute = New System.Windows.Forms.Button()
        Me.mskTime = New System.Windows.Forms.MaskedTextBox()
        Me.cboStaff = New System.Windows.Forms.ComboBox()
        Me.cboBus = New System.Windows.Forms.ComboBox()
        Me.cboRoute = New System.Windows.Forms.ComboBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule ID : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Driver  ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(486, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Time : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Seat Available : "
        '
        'lblbsID
        '
        Me.lblbsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblbsID.Location = New System.Drawing.Point(101, 20)
        Me.lblbsID.Name = "lblbsID"
        Me.lblbsID.Size = New System.Drawing.Size(100, 23)
        Me.lblbsID.TabIndex = 0
        Me.lblbsID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Route ID : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bus ID : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskSeat)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnViewStaff)
        Me.GroupBox1.Controls.Add(Me.btnViewBus)
        Me.GroupBox1.Controls.Add(Me.btnViewRoute)
        Me.GroupBox1.Controls.Add(Me.mskTime)
        Me.GroupBox1.Controls.Add(Me.cboStaff)
        Me.GroupBox1.Controls.Add(Me.cboBus)
        Me.GroupBox1.Controls.Add(Me.cboRoute)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblbsID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 323)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintain"
        '
        'mskSeat
        '
        Me.mskSeat.Location = New System.Drawing.Point(101, 175)
        Me.mskSeat.Mask = "00"
        Me.mskSeat.Name = "mskSeat"
        Me.mskSeat.Size = New System.Drawing.Size(100, 20)
        Me.mskSeat.TabIndex = 24
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Location = New System.Drawing.Point(380, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDate.TabIndex = 23
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(338, 52)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(111, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 55)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(9, 247)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 55)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnViewStaff
        '
        Me.btnViewStaff.Location = New System.Drawing.Point(231, 122)
        Me.btnViewStaff.Name = "btnViewStaff"
        Me.btnViewStaff.Size = New System.Drawing.Size(75, 23)
        Me.btnViewStaff.TabIndex = 17
        Me.btnViewStaff.Text = "View Driver"
        Me.btnViewStaff.UseVisualStyleBackColor = True
        '
        'btnViewBus
        '
        Me.btnViewBus.Location = New System.Drawing.Point(231, 87)
        Me.btnViewBus.Name = "btnViewBus"
        Me.btnViewBus.Size = New System.Drawing.Size(75, 23)
        Me.btnViewBus.TabIndex = 16
        Me.btnViewBus.Text = "View Bus"
        Me.btnViewBus.UseVisualStyleBackColor = True
        '
        'btnViewRoute
        '
        Me.btnViewRoute.Location = New System.Drawing.Point(231, 54)
        Me.btnViewRoute.Name = "btnViewRoute"
        Me.btnViewRoute.Size = New System.Drawing.Size(75, 23)
        Me.btnViewRoute.TabIndex = 15
        Me.btnViewRoute.Text = "View Route"
        Me.btnViewRoute.UseVisualStyleBackColor = True
        '
        'mskTime
        '
        Me.mskTime.Location = New System.Drawing.Point(531, 22)
        Me.mskTime.Mask = "00:00"
        Me.mskTime.Name = "mskTime"
        Me.mskTime.Size = New System.Drawing.Size(100, 20)
        Me.mskTime.TabIndex = 6
        Me.mskTime.ValidatingType = GetType(Date)
        '
        'cboStaff
        '
        Me.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Location = New System.Drawing.Point(101, 124)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(100, 21)
        Me.cboStaff.TabIndex = 3
        '
        'cboBus
        '
        Me.cboBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBus.FormattingEnabled = True
        Me.cboBus.Location = New System.Drawing.Point(101, 89)
        Me.cboBus.Name = "cboBus"
        Me.cboBus.Size = New System.Drawing.Size(100, 21)
        Me.cboBus.TabIndex = 2
        '
        'cboRoute
        '
        Me.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoute.FormattingEnabled = True
        Me.cboRoute.Location = New System.Drawing.Point(101, 56)
        Me.cboRoute.Name = "cboRoute"
        Me.cboRoute.Size = New System.Drawing.Size(100, 21)
        Me.cboRoute.TabIndex = 1
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'MaintainSchedule
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(669, 347)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MaintainSchedule"
        Me.Text = "Bus Schedule Maintain"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblbsID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnViewStaff As System.Windows.Forms.Button
    Friend WithEvents btnViewBus As System.Windows.Forms.Button
    Friend WithEvents btnViewRoute As System.Windows.Forms.Button
    Friend WithEvents mskTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
    Friend WithEvents cboBus As System.Windows.Forms.ComboBox
    Friend WithEvents cboRoute As System.Windows.Forms.ComboBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents mskSeat As System.Windows.Forms.MaskedTextBox
End Class
