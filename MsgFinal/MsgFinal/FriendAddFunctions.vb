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
        Dim query As String = "select * from status where sender=@send and receiver=@rcv"
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
            MessageBox.Show("Friend already sent a request, Confirm or Reject the request")
            Return True
        Else
            Return False
        End If

    End Function

    'get datagrid view of friends list to exclude that are already friends with that user
    Function getFriendsToList(ByVal user As String) As List(Of String)
        Dim friendList As New List(Of String)
        conn.Open()
        Dim query As String = "select friendID from friends where userID=@uid"
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
        Dim query As String = "insert into status (status_name,sender,receiver) values ('frd_req'," + getUsrID(CurUser) + "," + getUsrID(frd) + ")"
        Dim comm As New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("You have sent a Friend Request")
    End Sub
End Module
