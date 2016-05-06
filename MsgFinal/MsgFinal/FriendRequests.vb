Public Class FriendRequests
    Dim sortColumn As Integer = -1
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
            selectedUser = ""
        End If
    End Sub

    Private Sub lstVwFriendREQ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVwFriendREQ.SelectedIndexChanged
        'selectedUser = lstVwFriendREQ.SelectedItems(lstVwFriendREQ.SelectedIndices.ToString).Text
        If lstVwFriendREQ.SelectedItems.Count > 0 Then
            selectedUser = lstVwFriendREQ.FocusedItem.Text
        End If
    End Sub

    Private Sub lstVwFriendREQ_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstVwFriendREQ.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            lstVwFriendREQ.Sorting = SortOrder.Ascending
        Else
            If lstVwFriendREQ.Sorting = SortOrder.Ascending Then
                lstVwFriendREQ.Sorting = SortOrder.Descending
            Else
                lstVwFriendREQ.Sorting = SortOrder.Ascending
            End If
        End If
    End Sub
End Class