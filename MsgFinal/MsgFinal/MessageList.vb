Public Class MessageList

    Private Sub MessageList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvMessageBox.Columns.Add("Subject", 250)
        lvMessageBox.Columns.Add("Sender", 75)
        lvMessageBox.Columns.Add("Receiver", 75)
        lvMessageBox.Columns.Add("Date Sent", 65)
        lvMessageBox.Columns.Add("Marked as Read", 100)

        'add contents of message, inbox is first
        'Dim r() As String = {"SENDER", "RECEIVER", "00-00-00", "CHECK"}
        'lvMessageBox.Items.Add("TEST SUBJECT").SubItems.AddRange(r)
    End Sub
End Class