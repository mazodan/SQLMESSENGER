Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module MessagesModule
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")
    Sub sendMessage(ByVal subject As String, ByVal receiver As String, ByVal message As RichTextBox)
        conn.Open()
        Dim query As String = "insert into message (senderID, receiverID, sendDate, sentTime, message, markedread, subject) values (@send,@rcv,CURDATE(),CURTIME(),@msg,@mr,@subj)"
        Dim comm As New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@send", Convert.ToInt32(getUsrID(CurUser)))
        comm.Parameters.AddWithValue("@rcv", Convert.ToInt32(getUsrID(receiver)))
        comm.Parameters.AddWithValue("@msg", Encrypt(message.Rtf, CurUser + receiver))
        comm.Parameters.AddWithValue("@mr", 0)
        comm.Parameters.AddWithValue("@subj", subject)
        comm.ExecuteNonQuery()
        'for user's outbox
        query = "insert into outbox (senderID, receiverID, sendDate, sentTime, message, subject) values (@send,@rcv,CURDATE(),CURTIME(),@msg,@subj)"
        comm = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@send", Convert.ToInt32(getUsrID(CurUser)))
        comm.Parameters.AddWithValue("@rcv", Convert.ToInt32(getUsrID(receiver)))
        comm.Parameters.AddWithValue("@msg", Encrypt(message.Rtf, CurUser + receiver))
        comm.Parameters.AddWithValue("@mr", 0)
        comm.Parameters.AddWithValue("@subj", subject)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Message sent")

    End Sub

    Sub MessageNotification(ByVal ntfc As ListView, ByVal alrt As Button)
        conn.Open()
        Dim query As String = "select DISTINCT senderID from message where markedread=0 and receiverID=" + getUsrID(CurUser) + ""
        Dim comm As New MySqlCommand(query, conn)
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()
        adpt.Fill(dset, "message")
        conn.Close()


        alrt.UseVisualStyleBackColor = True

        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            Dim lvi As New ListViewItem()
            lvi.Text = getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString()) + " Has sent you a Message"
            lvi.SubItems.Add(getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString()) + " Has sent you a Message")
            ntfc.Items.Add(lvi)
            ntfc.Items(x).ForeColor = Color.Green
            ntfc.Items(x).Font = New Font(ntfc.Items(x).Font, FontStyle.Bold)
            alrt.BackColor = Color.FromArgb(255, 255, 79, 83)
        Next
    End Sub

    Sub AddMessageToListview(ByVal lv As ListView)

    End Sub
End Module
