Public Class FriendList

    Private Sub FriendList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstVwFriends.Columns.Add("Username", 175)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FriendSearch.ShowDialog()
    End Sub
End Class