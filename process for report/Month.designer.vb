<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Month
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Month))
        Me.btnMonthbus = New System.Windows.Forms.Button()
        Me.btnMonthticket = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.PreMonthticket = New System.Windows.Forms.PrintPreviewDialog()
        Me.DocMonthticket = New System.Drawing.Printing.PrintDocument()
        Me.PreMonthbus = New System.Windows.Forms.PrintPreviewDialog()
        Me.DocMonthbus = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btnMonthbus
        '
        Me.btnMonthbus.Image = Global.NewVB.My.Resources.Resources.monthBusSchedulingReport
        Me.btnMonthbus.Location = New System.Drawing.Point(208, 12)
        Me.btnMonthbus.Name = "btnMonthbus"
        Me.btnMonthbus.Size = New System.Drawing.Size(190, 188)
        Me.btnMonthbus.TabIndex = 5
        Me.btnMonthbus.UseVisualStyleBackColor = True
        '
        'btnMonthticket
        '
        Me.btnMonthticket.Image = Global.NewVB.My.Resources.Resources.monthTicketSellingReport
        Me.btnMonthticket.Location = New System.Drawing.Point(12, 12)
        Me.btnMonthticket.Name = "btnMonthticket"
        Me.btnMonthticket.Size = New System.Drawing.Size(190, 188)
        Me.btnMonthticket.TabIndex = 4
        Me.btnMonthticket.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(504, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Month:"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboMonth.Location = New System.Drawing.Point(458, 13)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboMonth.TabIndex = 10
        '
        'PreMonthticket
        '
        Me.PreMonthticket.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreMonthticket.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreMonthticket.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreMonthticket.Enabled = True
        Me.PreMonthticket.Icon = CType(resources.GetObject("PreMonthticket.Icon"), System.Drawing.Icon)
        Me.PreMonthticket.Name = "PreStaff"
        Me.PreMonthticket.Visible = False
        '
        'DocMonthticket
        '
        '
        'PreMonthbus
        '
        Me.PreMonthbus.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreMonthbus.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreMonthbus.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreMonthbus.Enabled = True
        Me.PreMonthbus.Icon = CType(resources.GetObject("PreMonthbus.Icon"), System.Drawing.Icon)
        Me.PreMonthbus.Name = "PreSchedule"
        Me.PreMonthbus.Visible = False
        '
        'DocMonthbus
        '
        '
        'Month
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(586, 221)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMonthbus)
        Me.Controls.Add(Me.btnMonthticket)
        Me.Name = "Month"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMonthbus As System.Windows.Forms.Button
    Friend WithEvents btnMonthticket As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents PreMonthticket As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DocMonthticket As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreMonthbus As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DocMonthbus As System.Drawing.Printing.PrintDocument
End Class
