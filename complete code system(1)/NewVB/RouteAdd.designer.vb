<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RouteAdd
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEP = New System.Windows.Forms.ComboBox()
        Me.cboSP = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtRoute = New System.Windows.Forms.Label()
        Me.txtBusFare = New System.Windows.Forms.TextBox()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Bus Fare(RM) : "
        '
        'cboEP
        '
        Me.cboEP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEP.FormattingEnabled = True
        Me.cboEP.Items.AddRange(New Object() {"Kuala Lumpur", "Perak", "Melaka", "Johor", "Selangor", "Pulau Pinang", "Negeri Sembilan", "Terengganu", "Pahang", "Kedah", "Kelantan"})
        Me.cboEP.Location = New System.Drawing.Point(90, 78)
        Me.cboEP.Name = "cboEP"
        Me.cboEP.Size = New System.Drawing.Size(121, 21)
        Me.cboEP.TabIndex = 31
        '
        'cboSP
        '
        Me.cboSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSP.FormattingEnabled = True
        Me.cboSP.Items.AddRange(New Object() {"Kuala Lumpur", "Perak", "Melaka", "Johor", "Selangor", "Pulau Pinang", "Negeri Sembilan", "Terengganu", "Pahang", "Kedah", "Kelantan"})
        Me.cboSP.Location = New System.Drawing.Point(90, 51)
        Me.cboSP.Name = "cboSP"
        Me.cboSP.Size = New System.Drawing.Size(121, 21)
        Me.cboSP.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "End Point:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Start Point:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Route ID:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(136, 140)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(55, 140)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 35
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'txtRoute
        '
        Me.txtRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute.Location = New System.Drawing.Point(91, 23)
        Me.txtRoute.Name = "txtRoute"
        Me.txtRoute.Size = New System.Drawing.Size(120, 23)
        Me.txtRoute.TabIndex = 36
        Me.txtRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBusFare
        '
        Me.txtBusFare.Location = New System.Drawing.Point(90, 105)
        Me.txtBusFare.Name = "txtBusFare"
        Me.txtBusFare.Size = New System.Drawing.Size(121, 20)
        Me.txtBusFare.TabIndex = 33
        '
        'RouteAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(248, 183)
        Me.Controls.Add(Me.txtRoute)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBusFare)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboEP)
        Me.Controls.Add(Me.cboSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RouteAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Route"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboEP As System.Windows.Forms.ComboBox
    Friend WithEvents cboSP As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtRoute As System.Windows.Forms.Label
    Friend WithEvents txtBusFare As System.Windows.Forms.TextBox
End Class
