Public Class MessageList

    Private Sub MessageList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvMessageBox.Items.Clear()
        lvMessageBox.Columns.Add("ID", 30)
        lvMessageBox.Columns.Add("Subject", 250)
        lvMessageBox.Columns.Add("Sender", 75)
        lvMessageBox.Columns.Add("Receiver", 75)
        lvMessageBox.Columns.Add("Date Sent", 65)
        lvMessageBox.Columns.Add("Unread", 100)

        'add contents of message, inbox is first
        'Dim r() As String = {"SENDER", "RECEIVER", "00-00-00", "CHECK"}
        'lvMessageBox.Items.Add("TEST SUBJECT").SubItems.AddRange(r)

        AddMessageToListview(lvMessageBox)
    End Sub


    Private Sub lvMessageBox_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMessageBox.ItemActivate
        MessageBox.Show(lvMessageBox.FocusedItem.Text)
        viewMessage(MessageContent.rtfInfo, lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(2).Text + CurUser, lvMessageBox.FocusedItem.Text)
        MessageContent.ShowDialog()
        'for subitems
        'MessageBox.Show(lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(1).Text)
    End Sub
End Class