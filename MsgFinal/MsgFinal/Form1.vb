Imports System.Text.RegularExpressions
Public Class Form1

    Sub rx()
        'today i learned, regex is awesome
        Dim regex As Regex = New Regex("\s")
        Dim match As Match = regex.Match(TextBox1.Text)
        If match.Success Then
            MessageBox.Show("you got a space in dat ass")
        Else
            MessageBox.Show("FuckYea")
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Register.Show()
    End Sub

    Private Sub btnForgotPw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForgotPw.Click
        ForgotPW.Show()
    End Sub
End Class
