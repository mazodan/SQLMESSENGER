Public Class Register

    Private Sub txtUser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.Enter
        TrapUserName(txtUser, lblWarning)
    End Sub

    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged
        TrapUserName(txtUser, lblWarning)
    End Sub

    Private Sub txtUser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.Leave
        If txtUser.Tag = "Valid" Then
            txtUser.BackColor = Color.White
            lblWarning.Visible = False
        End If
    End Sub

    Private Sub txtUser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPass_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.Enter
        TrapPassword(txtPass, lblWarning)
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        TrapPassword(txtPass, lblWarning)
    End Sub

    Private Sub txtPass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.Leave
        If txtPass.Tag = "Valid" Then
            txtPass.BackColor = Color.White
            lblWarning.Visible = False
        End If
    End Sub

    Private Sub txtPass2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass2.Enter
        confirmPassword(txtPass2, txtPass, lblWarning)
    End Sub

    Private Sub txtPass2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass2.TextChanged
        confirmPassword(txtPass2, txtPass, lblWarning)
    End Sub

    Private Sub txtPass2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass2.Leave
        If txtPass2.Tag = "Valid" Then
            txtPass2.BackColor = Color.White
            lblWarning.Visible = False
        End If
    End Sub

    Private Sub txtFname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFname.TextChanged
        InputCheck(txtFname)
    End Sub

    Private Sub txtLname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLname.TextChanged
        InputCheck(txtLname)
    End Sub

    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        InputCheck(txtAdd)
    End Sub

    Private Sub cmbCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCountry.SelectedIndexChanged
        If cmbCountry.Text.Length > 0 Then
            cmbCountry.Tag = "Valid"
        Else
            cmbCountry.Tag = "Invalid"
        End If
    End Sub

    Private Sub txtSQ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSQ.TextChanged
        InputCheck(txtSQ)
    End Sub

    Private Sub txtSA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSA.TextChanged
        InputCheck(txtSA)
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim c As Integer = 0
        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is TextBox = True Or TypeOf (ctl) Is ComboBox = True Then
                If ctl.Tag = "Invalid" Then
                    MessageBox.Show("Fill up all forms")
                    Exit For
                Else
                    c += 1
                End If
            End If
        Next
        'ALWAYS RETURN TRUE, REGISTER THE USER
        If c = 9 Then
            Dim gender As String
            If rdoMale.Checked = True Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            RegisterUser(txtUser.Text, txtPass.Text, txtFname.Text, txtLname.Text, txtAdd.Text, gender, cmbCountry.Text, Convert.ToString(dtpBday.Value.Date), txtSQ.Text, txtSA.Text)
        End If
        Me.Close()
    End Sub
End Class