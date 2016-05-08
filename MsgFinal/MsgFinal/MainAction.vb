'temporary import
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class MainAction
    Dim closeState As Boolean = True


    Private Sub btnProfile_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.MouseHover
        ttProfile.Show("This contains your user information", btnProfile)
    End Sub

    Private Sub btnFriend_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFriend.MouseHover
        ttFriend.Show("This contains your Friend List", btnFriend)
    End Sub

    Private Sub btnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.Click
        Profile.ShowDialog()
    End Sub

    Private Sub MainAction_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If closeState = True Then           'will only launch if the user has not yet finished the quiz            
            If MessageBox.Show("Are you sure you want to sign out?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Form1.txtUser.Text = ""
                Form1.txtPass.Text = ""
                Form1.Show()
            Else
                e.Cancel = True             'cancels the form closing, e is event arguments
            End If
        End If
    End Sub

    
    Private Sub btnFriend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFriend.Click
        FriendList.Show()
        Me.Hide()
    End Sub

    Private Sub btnFreq_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreq.MouseHover
        ttFreq.Show("Your friend requests", btnFreq)
    End Sub

    Private Sub btnFreq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreq.Click
        FriendRequests.Show()
        Me.Hide()
    End Sub

    Private Sub MainAction_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        notifyRequest(lvNotify, btnFreq)
    End Sub

    Private Sub MainAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvNotify.View = View.Details
        lvNotify.Columns.Add("Notifications", 350)
    End Sub

    Private Sub btnCompose_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompose.MouseHover
        ttComp.Show("Compose a New Message", btnCompose)
    End Sub

    Private Sub btnCompose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompose.Click
        Dim flist As New List(Of String)
        flist = getFriendsToList(getUsrID(CurUser))
        If flist.Count > 0 Then
            Compose.ShowDialog()
        Else
            MessageBox.Show("You have no friends, go get some")
        End If
    End Sub
End Class