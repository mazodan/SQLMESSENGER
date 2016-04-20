'temporary import
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class MainAction
    Dim closeState As Boolean = True


    Private Sub btnProfile_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.MouseHover
        ttProfile.Show("This contains your user information", btnProfile)
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

End Class