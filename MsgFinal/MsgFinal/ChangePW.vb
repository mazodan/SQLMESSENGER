Public Class ChangePW

    Private Sub ChangePW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PresentSecretQuestion(lblUser.Text, txtSQ)
    End Sub

    Private Sub btnChangePW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePW.Click
        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is TextBox = True Then
                If ctl.Text = "" Then
                    MessageBox.Show("Fill up all forms")
                    Return
                End If
            End If
        Next

        If txtNPW.Text.Length < 8 Then
            MessageBox.Show("Password should be 8 or more characters")
            Return
        End If

        If ComparePassword(txtAns.Text, lblUser.Text) = True Then
            'change password
            UpdateData(lblUser.Text, txtNPW.Text)
            MessageBox.Show("Your password is Updated")
            Me.Close()
        Else
            MessageBox.Show("Your answer is Incorrect")
        End If
    End Sub
End Class