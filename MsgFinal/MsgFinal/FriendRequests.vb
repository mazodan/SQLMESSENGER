Public Class FriendRequests

    Dim selectedUser As String = ""

    Private Sub FriendRequests_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstVwFriendREQ.View = View.Details
        lstVwFriendREQ.Columns.Add("Pending Friends", 180)
        PlaceFriendRequestshere(lstVwFriendREQ)
        lblFrCount.Text = "You have " + lstVwFriendREQ.Items.Count.ToString + " Request(s)"
    End Sub

    Private Sub FriendRequests_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainAction.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If selectedUser <> "" Then
            ConfirmFReq(getUsrID(selectedUser))
            PlaceFriendRequestshere(lstVwFriendREQ)
        End If
    End Sub

    Private Sub lstVwFriendREQ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVwFriendREQ.SelectedIndexChanged
        'selectedUser = lstVwFriendREQ.SelectedItems(lstVwFriendREQ.SelectedIndices.ToString).Text
        If lstVwFriendREQ.SelectedItems.Count > 0 Then
            selectedUser = lstVwFriendREQ.FocusedItem.Text
        End If
    End Sub
End Class