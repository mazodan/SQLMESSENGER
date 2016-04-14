Public Class MainAction

    Private Sub btnProfile_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.MouseHover
        ttProfile.Show("This contains your user information", btnProfile)
    End Sub

    Private Sub btnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.Click
        Profile.ShowDialog()
    End Sub
End Class