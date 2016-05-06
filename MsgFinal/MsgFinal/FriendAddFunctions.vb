Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module FriendAddFunctions
    Dim sendrID As Integer
    Dim rcvrID As Integer

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")

    'check if friend already requested, or inverse
    Function verifyRequestByOtherParty(ByVal frd As String, ByVal inverse As Boolean) As Boolean
        sendrID = getUsrID(CurUser)
        rcvrID = getUsrID(frd)
        conn.Open()
        Dim query As String = "select * from friends where userID=@send and friendID=@rcv and pending=1"
        Dim comm As New MySqlCommand(query, conn)
        If inverse = False Then
            comm.Parameters.AddWithValue("@send", rcvrID)
            comm.Parameters.AddWithValue("@rcv", sendrID)
        Else
            comm.Parameters.AddWithValue("@send", sendrID)
            comm.Parameters.AddWithValue("@rcv", rcvrID)
        End If

        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()

        adpt.Fill(dset, "status")
        conn.Close()

        If dset.Tables(0).Rows.Count = 1 Then
            MessageBox.Show("You or Your Friend already sent a request, Confirm or Reject the request")
            Return True
        Else
            Return False
        End If

    End Function

    'get datagrid view of friends list to exclude that are already friends with that user
    Function getFriendsToList(ByVal user As String) As List(Of String)
        Dim friendList As New List(Of String)
        conn.Open()
        Dim query As String = "select friendID from friends where userID=@uid and pending=0"
        Dim comm As New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@uid", user)
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()

        adpt.Fill(dset, "friends")
        conn.Close()

        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            friendList.Add(getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString))
        Next

        Return friendList
    End Function


    Sub addFriendRequest(ByVal frd As String)
        conn.Open()
        Dim query As String = "insert into friends (userID,friendID,pending) values (" + getUsrID(CurUser) + "," + getUsrID(frd) + ",1)"
        Dim comm As New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("You have sent a Friend Request")
    End Sub

    Sub PlaceFriendRequestshere(ByVal lv As ListView)
        conn.Open()
        Dim query As String = "select userID from friends where pending=1 and friendID=" + getUsrID(CurUser) + ""
        Dim comm As New MySqlCommand(query, conn)
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()

        adpt.Fill(dset, "friends")
        conn.Close()

        lv.Items.Clear()

        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            Dim lvi As New ListViewItem()
            lvi.Text = getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString())
            lvi.SubItems.Add(getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString()))
            lv.Items.Add(lvi)
        Next
    End Sub

    Sub ConfirmFReq(ByVal requester As String)
        conn.Open()
        Dim query As String = "update friends set pending=0 where userID=@reqsender and friendID=@receiver"
        Dim comm As New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@reqsender", requester)
        comm.Parameters.AddWithValue("@receiver", getUsrID(CurUser))
        comm.ExecuteNonQuery()
        query = "insert into friends (userID,friendID,pending) values (@curUser,@requester,0)"
        comm = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@curUser", getUsrID(CurUser))
        comm.Parameters.AddWithValue("@requester", requester)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Friend Request is Confirmed")
        REM add notification inbox to requester after message is complete, hell yeah
    End Sub
End Module
