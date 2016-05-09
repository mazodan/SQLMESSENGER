Public Class MessageList

    Private Sub MessageList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvMessageBox.Items.Clear()
        lvMessageBox.Columns.Add("ID", 30)
        lvMessageBox.Columns.Add("Subject", 250)
        lvMessageBox.Columns.Add("Sender", 75)
        lvMessageBox.Columns.Add("Receiver", 75)
        lvMessageBox.Columns.Add("Date Sent", 65)
        lvMessageBox.Columns.Add("Unread", 100)

    End Sub


    Private Sub lvMessageBox_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMessageBox.ItemActivate

        viewMessage(MessageContent.rtfInfo, lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(2).Text + CurUser, lvMessageBox.FocusedItem.Text)
        If lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(5).Text = "✓" Then
            markRead(lvMessageBox.FocusedItem.Text)
        End If
        MessageContent.Text = lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(1).Text
        MessageContent.lblSubj.Text = lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(1).Text
        MessageContent.lblSend.Text = lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(2).Text
        MessageContent.Show()
        Me.Hide()
    End Sub


    Private Sub MessageList_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        AddMessageToListview(lvMessageBox)
    End Sub

    Private Sub MessageList_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainAction.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        searchMessages(txtSearch.Text, lvMessageBox)
    End Sub

    Private Sub btnDSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDSearch.Click
        searchByDate(Convert.ToString(dtpDate.Value.Date), lvMessageBox)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvMessageBox.SelectedItems.Count > 0 Then
            DeleteMessage(lvMessageBox.FocusedItem.Text)
            AddMessageToListview(lvMessageBox)
        End If
    End Sub
End Class