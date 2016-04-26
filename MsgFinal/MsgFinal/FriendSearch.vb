Public Class FriendSearch

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Fsearch(txtSearch.Text, dgv_FR)
    End Sub

    Private Sub dgv_FR_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_FR.CellClick
        txtSearch.Text = dgv_FR.SelectedCells(0).Value.ToString
    End Sub
End Class