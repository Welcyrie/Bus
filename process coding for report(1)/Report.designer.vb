<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnYesr = New System.Windows.Forms.Button()
        Me.btnMonth = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnRoute = New System.Windows.Forms.Button()
        Me.DocStaff = New System.Drawing.Printing.PrintDocument()
        Me.PreStaff = New System.Windows.Forms.PrintPreviewDialog()
        Me.DocRoute = New System.Drawing.Printing.PrintDocument()
        Me.PreRoute = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(599, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnYesr
        '
        Me.btnYesr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYesr.Image = Global.NewVB.My.Resources.Resources.yearlyReport
        Me.btnYesr.Location = New System.Drawing.Point(12, 12)
        Me.btnYesr.Name = "btnYesr"
        Me.btnYesr.Size = New System.Drawing.Size(161, 169)
        Me.btnYesr.TabIndex = 5
        Me.btnYesr.UseVisualStyleBackColor = True
        '
        'btnMonth
        '
        Me.btnMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonth.Image = Global.NewVB.My.Resources.Resources.monthlyReport
        Me.btnMonth.Location = New System.Drawing.Point(179, 12)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(161, 169)
        Me.btnMonth.TabIndex = 6
        Me.btnMonth.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Image = Global.NewVB.My.Resources.Resources.staffReport
        Me.btnStaff.Location = New System.Drawing.Point(346, 12)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(161, 169)
        Me.btnStaff.TabIndex = 7
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnRoute
        '
        Me.btnRoute.Image = Global.NewVB.My.Resources.Resources.routeReport
        Me.btnRoute.Location = New System.Drawing.Point(513, 12)
        Me.btnRoute.Name = "btnRoute"
        Me.btnRoute.Size = New System.Drawing.Size(161, 169)
        Me.btnRoute.TabIndex = 8
        Me.btnRoute.UseVisualStyleBackColor = True
        '
        'PreStaff
        '
        Me.PreStaff.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreStaff.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreStaff.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreStaff.Enabled = True
        Me.PreStaff.Icon = CType(resources.GetObject("PreStaff.Icon"), System.Drawing.Icon)
        Me.PreStaff.Name = "PreStaff"
        Me.PreStaff.Visible = False
        '
        'PreRoute
        '
        Me.PreRoute.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreRoute.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreRoute.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreRoute.Enabled = True
        Me.PreRoute.Icon = CType(resources.GetObject("PreRoute.Icon"), System.Drawing.Icon)
        Me.PreRoute.Name = "PrintPreviewDialog1"
        Me.PreRoute.Visible = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(690, 229)
        Me.Controls.Add(Me.btnRoute)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnMonth)
        Me.Controls.Add(Me.btnYesr)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnYesr As System.Windows.Forms.Button
    Friend WithEvents btnMonth As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnRoute As System.Windows.Forms.Button
    Friend WithEvents DocStaff As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreStaff As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DocRoute As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreRoute As System.Windows.Forms.PrintPreviewDialog
End Class
