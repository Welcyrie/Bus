<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Year
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Year))
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DocYearticket = New System.Drawing.Printing.PrintDocument()
        Me.PreYearticket = New System.Windows.Forms.PrintPreviewDialog()
        Me.DocYearbus = New System.Drawing.Printing.PrintDocument()
        Me.PreYearbus = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnYearbus = New System.Windows.Forms.Button()
        Me.btnYearticket = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2014", "2015", "2016"})
        Me.cboYear.Location = New System.Drawing.Point(449, 13)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Year:"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(495, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DocYearticket
        '
        '
        'PreYearticket
        '
        Me.PreYearticket.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreYearticket.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreYearticket.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreYearticket.Enabled = True
        Me.PreYearticket.Icon = CType(resources.GetObject("PreYearticket.Icon"), System.Drawing.Icon)
        Me.PreYearticket.Name = "PreBus"
        Me.PreYearticket.Visible = False
        '
        'DocYearbus
        '
        '
        'PreYearbus
        '
        Me.PreYearbus.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreYearbus.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreYearbus.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreYearbus.Enabled = True
        Me.PreYearbus.Icon = CType(resources.GetObject("PreYearbus.Icon"), System.Drawing.Icon)
        Me.PreYearbus.Name = "PreRoute"
        Me.PreYearbus.Visible = False
        '
        'btnYearbus
        '
        Me.btnYearbus.Image = Global.NewVB.My.Resources.Resources.yearBusSchedulingReport
        Me.btnYearbus.Location = New System.Drawing.Point(207, 12)
        Me.btnYearbus.Name = "btnYearbus"
        Me.btnYearbus.Size = New System.Drawing.Size(190, 188)
        Me.btnYearbus.TabIndex = 4
        Me.btnYearbus.UseVisualStyleBackColor = True
        '
        'btnYearticket
        '
        Me.btnYearticket.Image = Global.NewVB.My.Resources.Resources.yearTicketSellingReport
        Me.btnYearticket.Location = New System.Drawing.Point(11, 12)
        Me.btnYearticket.Name = "btnYearticket"
        Me.btnYearticket.Size = New System.Drawing.Size(190, 188)
        Me.btnYearticket.TabIndex = 3
        Me.btnYearticket.UseVisualStyleBackColor = True
        '
        'Year
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(578, 220)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.btnYearbus)
        Me.Controls.Add(Me.btnYearticket)
        Me.Name = "Year"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnYearbus As System.Windows.Forms.Button
    Friend WithEvents btnYearticket As System.Windows.Forms.Button
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DocYearticket As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreYearticket As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DocYearbus As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreYearbus As System.Windows.Forms.PrintPreviewDialog
End Class
