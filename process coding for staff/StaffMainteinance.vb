Public Class StaffMainteinance
    Public Property HeaderText As String

    Private Sub StaffMainteinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Staffs

        db.SubmitChanges()
        list()
    End Sub

    Public Sub list()
        Dim search As String = txtSearch.Text()
        Dim db As New BusTicketingDataContext
        Dim rs = From s In db.Staffs
                 Where s.staffName.Contains(search)
                 Select s.staffID, s.staffName, s.staffGender, s.staffIC, s.staffPhNum, s.staffEmail, s.staffPosition, s.staffStatus


        dgv.DataSource = rs

        For Each column As DataGridViewColumn In dgv.Columns
            If column.Index = 0 Then
                column.HeaderText = String.Concat("ID")
            ElseIf column.Index = 1 Then
                column.HeaderText = String.Concat("Name")
            ElseIf column.Index = 2 Then
                column.HeaderText = String.Concat("Gender")
            ElseIf column.Index = 3 Then
                column.HeaderText = String.Concat("IC")
            ElseIf column.Index = 4 Then
                column.HeaderText = String.Concat("Phone Number")
            ElseIf column.Index = 5 Then
                column.HeaderText = String.Concat("E-mail")
            ElseIf column.Index = 6 Then
                column.HeaderText = String.Concat("Position")
            ElseIf column.Index = 7 Then
                column.HeaderText = String.Concat("Ststus")
            End If
        Next
    End Sub

    Private Sub dgv_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            StaffUpdate.selectID = id
            StaffUpdate.ShowDialog(Me)
            list()
        End If


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        list()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        StaffAdd.ShowDialog(Me)
        list()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Double click the data to update or delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        StaffAdd.ShowDialog(Me)
        list()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
