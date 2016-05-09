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

        Dim c As Integer = ntfc.Items.Count
        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            Dim lvi As New ListViewItem()
            lvi.Text = getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString()) + " Has sent you a Message"
            lvi.SubItems.Add(getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString()) + " Has sent you a Message")
            ntfc.Items.Add(lvi)
            ntfc.Items(c).ForeColor = Color.Green
            ntfc.Items(c).Font = New Font(ntfc.Items(x).Font, FontStyle.Bold)
            alrt.BackColor = Color.FromArgb(255, 255, 79, 83)
            c += 1
        Next
    End Sub

    Sub AddMessageToListview(ByVal lv As ListView)
        conn.Open()
        Dim query As String = "select id,subject,senderID,receiverID,sendDate,markedread from message where receiverID=" + getUsrID(CurUser) + " order by sendDate ASC"
        Dim comm As New MySqlCommand(query, conn)
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()
        adpt.Fill(dset, "message")
        conn.Close()

        lv.Items.Clear()
        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            Dim checkL As String = "✓"

            If dset.Tables(0).Rows(x)(5).ToString = 0 Then
                checkL = "✓"
            Else
                checkL = " "
            End If

            Dim r() As String = {dset.Tables(0).Rows(x)(1).ToString, getUsernameFromID(dset.Tables(0).Rows(x)(2).ToString), getUsernameFromID(dset.Tables(0).Rows(x)(3).ToString), dset.Tables(0).Rows(x)(4).ToString, checkL}
            lv.Items.Add(dset.Tables(0).Rows(x)(0).ToString).SubItems.AddRange(r)
            If checkL = "✓" Then
                lv.Items(x).Font = New Font(MessageContent.Font, FontStyle.Bold)
            End If
        Next
    End Sub

    Sub viewMessage(ByVal lv As RichTextBox, ByVal pw As String, ByVal id As String)
        conn.Open()
        Dim query As String = "select message from message where id=@id"
        Dim comm As New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@id", id)
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()
        adpt.Fill(dset, "message")
        conn.Close()

        lv.Rtf = Decrypt(dset.Tables(0).Rows(0)(0).ToString, pw)
    End Sub

    Sub markRead(ByVal id As String)
        conn.Open()
        Dim query As String = "update message set markedread=1 where id=" + id + ""
        Dim comm As New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub searchMessages(ByVal search As String, ByVal lv As ListView)
        conn.Open()
        Dim query As String = "select id,subject,senderID,receiverID,sendDate,markedread from message where receiverID=" + getUsrID(CurUser) + " and subject LIKE @search order by sendDate ASC"
        Dim comm As New MySqlCommand(query, conn)
        search = String.Format("%{0}%", search)
        comm.Parameters.AddWithValue("@search", search)
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()
        adpt.Fill(dset, "message")
        conn.Close()

        lv.Items.Clear()
        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            Dim checkL As String = "✓"

            If dset.Tables(0).Rows(x)(5).ToString = 0 Then
                checkL = "✓"
            Else
                checkL = " "
            End If

            Dim r() As String = {dset.Tables(0).Rows(x)(1).ToString, getUsernameFromID(dset.Tables(0).Rows(x)(2).ToString), getUsernameFromID(dset.Tables(0).Rows(x)(3).ToString), dset.Tables(0).Rows(x)(4).ToString, checkL}
            lv.Items.Add(dset.Tables(0).Rows(x)(0).ToString).SubItems.AddRange(r)
            If checkL = "✓" Then
                lv.Items(x).Font = New Font(MessageContent.Font, FontStyle.Bold)
            End If
        Next
    End Sub

    'Convert.ToString(dtpBday.Value.Date)

    Sub searchByDate(ByVal dt As String, ByVal lv As ListView)
        conn.Open()
        Dim query As String = "select id,subject,senderID,receiverID,sendDate,markedread from message where receiverID=" + getUsrID(CurUser) + " and sendDate=@date order by sendDate ASC"
        Dim comm As New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@date", dt).MySqlDbType = MySqlDbType.Date
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()
        adpt.Fill(dset, "message")
        conn.Close()

        lv.Items.Clear()
        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            Dim checkL As String = "✓"

            If dset.Tables(0).Rows(x)(5).ToString = 0 Then
                checkL = "✓"
            Else
                checkL = " "
            End If

            Dim r() As String = {dset.Tables(0).Rows(x)(1).ToString, getUsernameFromID(dset.Tables(0).Rows(x)(2).ToString), getUsernameFromID(dset.Tables(0).Rows(x)(3).ToString), dset.Tables(0).Rows(x)(4).ToString, checkL}
            lv.Items.Add(dset.Tables(0).Rows(x)(0).ToString).SubItems.AddRange(r)
            If checkL = "✓" Then
                lv.Items(x).Font = New Font(MessageContent.Font, FontStyle.Bold)
            End If
        Next
    End Sub

    Sub DeleteMessage(ByVal id As String)
        conn.Open()
        Dim query As String = "delete from message where id=" + id + ""
        Dim comm As New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()

    End Sub
End Module
