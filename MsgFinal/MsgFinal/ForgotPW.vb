Public Class ForgotPW

    Private Sub txtSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If checkUser(txtUsername.Text, False) = "UserExists" Then
            ChangePW.lblUser.Text = txtUsername.Text
            ChangePW.Show()
        Else
            MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class