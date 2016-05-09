Public Class MessageContent

    Private Sub btnReply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReply.Click
        Compose.rtfMessage.Clear()
        Compose.cmbFriends.Items.Clear()
        Compose.cmbFriends.Items.Add(lblSend.Text)
        Compose.cmbFriends.Text = lblSend.Text
        Compose.txtSubject.Text = "RE: " + lblSubj.Text
        Compose.ShowDialog()
    End Sub

    Private Sub MessageContent_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MessageList.Show()
    End Sub
End Class