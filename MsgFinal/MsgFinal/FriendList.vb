Public Class FriendList
    Dim sortColumn As Integer = -1

    Private Sub FriendList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstVwFriends.Columns.Add("Username", 175)
        For Each x As String In getFriendsToList(getUsrID(CurUser))
            Dim lvi As New ListViewItem()
            lvi.Text = x
            lvi.SubItems.Add(x)
            lstVwFriends.Items.Add(lvi)
        Next
        lblFrCount.Text = "You have " + lstVwFriends.Items.Count.ToString + " Friend(s)"
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FriendSearch.ShowDialog()
    End Sub

    Private Sub FriendList_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainAction.Show()
    End Sub

    Private Sub lstVwFriends_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstVwFriends.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            lstVwFriends.Sorting = SortOrder.Ascending
        Else
            If lstVwFriends.Sorting = SortOrder.Ascending Then
                lstVwFriends.Sorting = SortOrder.Descending
            Else
                lstVwFriends.Sorting = SortOrder.Ascending
            End If
        End If
    End Sub
End Class