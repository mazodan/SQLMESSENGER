Public Class Outbox

    Private Sub Outbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvMessageBox.Items.Clear()
        lvMessageBox.Columns.Add("ID", 30)
        lvMessageBox.Columns.Add("Subject", 250)
        lvMessageBox.Columns.Add("Sender", 75)
        lvMessageBox.Columns.Add("Receiver", 75)
        lvMessageBox.Columns.Add("Date Sent", 75)
    End Sub

    Private Sub Outbox_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        AddMessageToListview(lvMessageBox, True)
    End Sub

    Private Sub Outbox_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainAction.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        searchMessages(txtSearch.Text, lvMessageBox, True)
    End Sub

    Private Sub btnDSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDSearch.Click

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvMessageBox.SelectedItems.Count > 0 Then
            DeleteMessage(lvMessageBox.FocusedItem.Text, True)
            AddMessageToListview(lvMessageBox, True)
        End If
    End Sub

    Private Sub lvMessageBox_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMessageBox.ItemActivate


        viewMessage(MessageContent.rtfInfo, CurUser + lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(3).Text, lvMessageBox.FocusedItem.Text, True)
        MessageContent.Text = lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(1).Text
        MessageContent.lblSubj.Text = lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(1).Text
        MessageContent.lblSend.Text = lvMessageBox.Items.Item(lvMessageBox.FocusedItem.Index).SubItems.Item(2).Text
        MessageContent.btnForward.Visible = False
        MessageContent.btnReply.Visible = False
        MessageContent.bool = False
        MessageContent.Show()
        Me.Hide()
    End Sub
End Class