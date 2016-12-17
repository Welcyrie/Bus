<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnTicket = New System.Windows.Forms.Button()
        Me.btnRoute = New System.Windows.Forms.Button()
        Me.btnBus = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(580, 587)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 24)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MingLiU", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 100)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Welcome To FTR Main Menu!!!!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NewVB.My.Resources.Resources.FTR_bus
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = Global.NewVB.My.Resources.Resources.generateReport
        Me.btnReport.Location = New System.Drawing.Point(452, 408)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(203, 173)
        Me.btnReport.TabIndex = 6
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnSchedule
        '
        Me.btnSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.Image = Global.NewVB.My.Resources.Resources.busScheduling
        Me.btnSchedule.Location = New System.Drawing.Point(13, 408)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(203, 173)
        Me.btnSchedule.TabIndex = 4
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'btnTicket
        '
        Me.btnTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicket.Image = Global.NewVB.My.Resources.Resources.ticketpurchase
        Me.btnTicket.Location = New System.Drawing.Point(232, 408)
        Me.btnTicket.Name = "btnTicket"
        Me.btnTicket.Size = New System.Drawing.Size(203, 173)
        Me.btnTicket.TabIndex = 5
        Me.btnTicket.UseVisualStyleBackColor = True
        '
        'btnRoute
        '
        Me.btnRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoute.Image = Global.NewVB.My.Resources.Resources.routeMainteinance
        Me.btnRoute.Location = New System.Drawing.Point(232, 217)
        Me.btnRoute.Name = "btnRoute"
        Me.btnRoute.Size = New System.Drawing.Size(203, 173)
        Me.btnRoute.TabIndex = 2
        Me.btnRoute.UseVisualStyleBackColor = True
        '
        'btnBus
        '
        Me.btnBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBus.Image = Global.NewVB.My.Resources.Resources.busMainteinance
        Me.btnBus.Location = New System.Drawing.Point(13, 217)
        Me.btnBus.Name = "btnBus"
        Me.btnBus.Size = New System.Drawing.Size(203, 173)
        Me.btnBus.TabIndex = 1
        Me.btnBus.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Image = Global.NewVB.My.Resources.Resources.staffMainteinance
        Me.btnStaff.Location = New System.Drawing.Point(452, 217)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(203, 173)
        Me.btnStaff.TabIndex = 3
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 619)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.btnTicket)
        Me.Controls.Add(Me.btnRoute)
        Me.Controls.Add(Me.btnBus)
        Me.Controls.Add(Me.btnStaff)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
    Friend WithEvents btnTicket As System.Windows.Forms.Button
    Friend WithEvents btnRoute As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnBus As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
