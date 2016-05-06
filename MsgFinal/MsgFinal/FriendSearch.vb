Public Class FriendSearch

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Fsearch(txtSearch.Text, dgv_FR)

    End Sub

    Private Sub dgv_FR_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_FR.CellClick
        txtSearch.Text = dgv_FR.SelectedCells(0).Value.ToString
    End Sub

    Private Sub btnSReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSReq.Click
        If CurUser = txtSearch.Text Then
            MessageBox.Show("You cannot friend yourself")
        Else
            If checkUser(txtSearch.Text, False) = "UserExists" Then
                MessageBox.Show("User Exists")
                If verifyRequestByOtherParty(txtSearch.Text, False) = False Then
                    If verifyRequestByOtherParty(txtSearch.Text, True) = False Then
                        Dim friendList As List(Of String) = getFriendsToList(getUsrID(CurUser))
                        For Each frd As String In friendList
                            For x As Integer = 0 To (dgv_FR.Rows.Count - 1)
                                If dgv_FR.Item(0, x).ToString = frd Then
                                    dgv_FR.Rows.RemoveAt(x)
                                End If
                            Next
                        Next
                        If friendList.Contains(txtSearch.Text) = False Then
                            'continue
                            addFriendRequest(txtSearch.Text)

                        Else
                            'user is already friends, cannot send request
                            MessageBox.Show("You are already Friends")
                        End If

                    End If
                    'nested if else
                Else
                    'do nothing
                End If
            Else
                MessageBox.Show("Unknown user or wrong spelling")
            End If
        End If
        
    End Sub
End Class