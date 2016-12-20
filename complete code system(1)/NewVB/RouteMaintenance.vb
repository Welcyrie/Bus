Public Class RouteMaintenance


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click     
        RouteAdd.ShowDialog()
        BindData()

    End Sub

    Private Sub RouteMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()

    End Sub


    Private Sub BindData()

        Dim SP As String = cboSP.Text
        Dim EP As String = cboEP.Text
        Dim db As New BusTicketingDataContext
        Dim rs = From r In db.Routes
                 Where
                (r.routeStartPoint.Contains(SP) And r.routeEndPoint.Contains(EP))
                 Select r.routeID, r.routeStartPoint, r.routeEndPoint, r.routeBusFare

 

        dgv.DataSource = rs


        For Each column As DataGridViewColumn In dgv.Columns
            If column.Index = 0 Then
                column.HeaderText = String.Concat("Route ID")
            ElseIf column.Index = 1 Then
                column.HeaderText = String.Concat("Start Point")
            ElseIf column.Index = 2 Then
                column.HeaderText = String.Concat("End Point")
            ElseIf column.Index = 3 Then
                column.HeaderText = String.Concat("Bus Fare")

            End If
        Next

    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            RouteUpdate.SelectedId = id
            RouteUpdate.ShowDialog(Me)
            BindData()
        End If
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        BindData()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        RouteAdd.ShowDialog()
    End Sub

    Private Sub UpdaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cboSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSP.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub cboEP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEP.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cboSP.SelectedIndex = -1
        cboEP.SelectedIndex = -1
        BindData()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        MessageBox.Show("Double click the data to update or delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class