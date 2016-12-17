<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RouteUpdate
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
        Me.cboEP = New System.Windows.Forms.ComboBox()
        Me.cboSP = New System.Windows.Forms.ComboBox()
        Me.txtRoute = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtBusFare = New System.Windows.Forms.TextBox()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEP
        '
        Me.cboEP.FormattingEnabled = True
        Me.cboEP.Items.AddRange(New Object() {"Kuala Lumpur", "Perak", "Melaka", "Johor", "Selangor", "Pulau Pinang", "Negeri Sembilan", "Terengganu", "Pahang", "Kedah", "Kelantan"})
        Me.cboEP.Location = New System.Drawing.Point(104, 82)
        Me.cboEP.Name = "cboEP"
        Me.cboEP.Size = New System.Drawing.Size(121, 21)
        Me.cboEP.TabIndex = 17
        '
        'cboSP
        '
        Me.cboSP.FormattingEnabled = True
        Me.cboSP.Items.AddRange(New Object() {"Kuala Lumpur", "Perak", "Melaka", "Johor", "Selangor", "Pulau Pinang", "Negeri Sembilan", "Terengganu", "Pahang", "Kedah", "Kelantan"})
        Me.cboSP.Location = New System.Drawing.Point(104, 55)
        Me.cboSP.Name = "cboSP"
        Me.cboSP.Size = New System.Drawing.Size(121, 21)
        Me.cboSP.TabIndex = 16
        '
        'txtRoute
        '
        Me.txtRoute.Enabled = False
        Me.txtRoute.Location = New System.Drawing.Point(104, 29)
        Me.txtRoute.Name = "txtRoute"
        Me.txtRoute.Size = New System.Drawing.Size(121, 20)
        Me.txtRoute.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "End Point:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Start Point:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Route ID:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdate.Location = New System.Drawing.Point(21, 147)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.CausesValidation = False
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(183, 147)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.CausesValidation = False
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Location = New System.Drawing.Point(102, 147)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Bus Fare(RM) : "
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'txtBusFare
        '
        Me.txtBusFare.Location = New System.Drawing.Point(104, 112)
        Me.txtBusFare.Name = "txtBusFare"
        Me.txtBusFare.Size = New System.Drawing.Size(121, 20)
        Me.txtBusFare.TabIndex = 34
        '
        'RouteUpdate
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(270, 195)
        Me.Controls.Add(Me.txtBusFare)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboEP)
        Me.Controls.Add(Me.cboSP)
        Me.Controls.Add(Me.txtRoute)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RouteUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Route"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEP As System.Windows.Forms.ComboBox
    Friend WithEvents cboSP As System.Windows.Forms.ComboBox
    Friend WithEvents txtRoute As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtBusFare As System.Windows.Forms.TextBox
End Class
