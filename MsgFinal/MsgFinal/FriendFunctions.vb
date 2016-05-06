Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module FriendFunctions
    Dim conn As New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")

    Sub notifyRequest(ByVal ntfc As ListView, ByVal alertbtn As Button)
        REM codes go here when i think of something or i stop procastinating
        conn.Open()
        Dim query As String = "select userID from friends where pending=1 and friendID=" + getUsrID(CurUser) + ""
        Dim comm As New MySqlCommand(query, conn)
        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()

        adpt.Fill(dset, "friends")
        conn.Close()

        ntfc.Items.Clear()

        For x As Integer = 0 To (dset.Tables(0).Rows.Count - 1)
            Dim lvi As New ListViewItem()
            lvi.Text = getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString()) + " Has sent you a Friend Request"
            lvi.SubItems.Add(getUsernameFromID(dset.Tables(0).Rows(x).Item(0).ToString()) + " Has sent you a Friend Request")
            ntfc.Items.Add(lvi)
            ntfc.Items(x).ForeColor = Color.Red
            ntfc.Items(x).Font = New Font(ntfc.Items(x).Font, FontStyle.Bold)
            alertbtn.BackColor = Color.FromArgb(255, 255, 79, 83)
        Next


    End Sub
End Module
