Module LoginFunctions
    Sub TrapUserName(ByVal textbx As TextBox, ByVal warn As Label)
        If textbx.Text.Length < 7 And textbx.Text.Length > 0 Then
            warn.Visible = True
            textbx.BackColor = Color.DarkSalmon
            warn.Text = "USERNAME MUST HAVE 8-20 CHARACTERS"
            textbx.Tag = "Invalid"
        Else
            If checkValidity(textbx.Text) = True Then
                'check if username is taken
                If checkUser(textbx.Text, False) = "UserAvailable" And textbx.Text.Length > 0 Then
                    warn.Visible = True
                    warn.Text = "USERNAME IS AVAILABLE"
                    textbx.Tag = "Valid"
                    textbx.BackColor = Color.Lime
                ElseIf checkUser(textbx.Text, False) = "UserExists" Then
                    warn.Text = "USERNAME IS TAKEN, CHOOSE ANOTHER"
                    textbx.Tag = "Invalid"
                ElseIf checkUser(textbx.Text, False) = "ERROR" Then
                    warn.Text = "Connection to database lost"
                End If
            Else
                warn.Text = "No Special Characters in username except underscore"
                textbx.BackColor = Color.DarkSalmon
                textbx.Tag = "Invalid"
            End If
        End If
    End Sub

    Sub TrapPassword(ByRef textbx As TextBox, ByVal warn As Label)
        If textbx.Text.Length < 7 And textbx.Text.Length > 0 Then
            warn.Visible = True
            textbx.BackColor = Color.DarkSalmon
            warn.Text = "PASSWORD MUST HAVE 8-20 CHARACTERS"
            textbx.Tag = "Invalid"
        ElseIf textbx.Text.Length > 7 Then
            textbx.Tag = "Valid"
            textbx.BackColor = Color.Lime
            warn.Visible = False
        End If
    End Sub

    Sub confirmPassword(ByVal textbx As TextBox, ByVal textbx2 As TextBox, ByVal warn As Label)
        If textbx.Text <> textbx2.Text Then
            textbx.BackColor = Color.DarkSalmon
            warn.Visible = True
            warn.Text = "PASSWORDS DO NOT MATCH"
            textbx.Tag = "Invalid"
        Else
            textbx.BackColor = Color.Lime
            warn.Visible = True
            warn.Text = "PASSWORDS MATCH"
            textbx.Tag = "Valid"
        End If

    End Sub

    'check if valid input
    Sub InputCheck(ByVal text As TextBox)
        If text.Text.Length > 0 Then
            text.Tag = "Valid"
        Else
            text.Tag = "Invalid"
        End If
    End Sub


End Module
