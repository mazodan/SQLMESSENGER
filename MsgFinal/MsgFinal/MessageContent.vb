Public Class MessageContent

    Private Sub btnReply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReply.Click
        Compose.rtfMessage.Text = ""
        Compose.cmbFriends.Items.Clear()
        Compose.cmbFriends.Items.Add(lblSend.Text)
        Compose.cmbFriends.Text = lblSend.Text
        Compose.txtSubject.Text = "RE: " + lblSubj.Text
        Compose.ShowDialog()
    End Sub

    Private Sub MessageContent_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MessageList.Show()
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        Compose.rtfMessage.Text = ""
        Compose.cmbFriends.Items.Clear()
        For Each elm As String In getFriendsToList(getUsrID(CurUser))
            Compose.cmbFriends.Items.Add(elm)
        Next
        Compose.rtfMessage.Rtf = rtfInfo.Rtf
        Compose.txtSubject.Text = "FW: " + lblSubj.Text
        Compose.ShowDialog()
    End Sub
End Class