Public Class Profile
    Dim updateProgress As Boolean = False
    Private Sub Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadProfile()
    End Sub

    Private Sub btnEProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEProfile.Click
        If updateProgress = False Then
            updateProgress = True
            btnUPD.Visible = True
            For Each ctl As Control In Me.Controls
                If TypeOf (ctl) Is TextBox = True Then
                    TryCast(ctl, TextBox).ReadOnly = False
                ElseIf TypeOf (ctl) Is ComboBox Then
                    TryCast(ctl, ComboBox).DropDownStyle = ComboBoxStyle.DropDownList
                ElseIf TypeOf (ctl) Is DateTimePicker = True Then
                    ctl.Enabled = True
                End If
            Next
        Else

        End If
    End Sub

    Private Sub btnUPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPD.Click
        Try
            updateProfile(txtFname, txtLname, txtAdd, cmbGender, txtCountry, dtpBday)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LoadProfile()
        updateProgress = False
        btnUPD.Visible = False
    End Sub

    Sub LoadProfile()
        LoadProfileData(txtFname, txtLname, txtAdd, cmbGender, txtCountry, dtpBday, pboxProfile)

        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is TextBox = True Then
                TryCast(ctl, TextBox).ReadOnly = True
            ElseIf TypeOf (ctl) Is ComboBox Then
                TryCast(ctl, ComboBox).DropDownStyle = ComboBoxStyle.DropDownList
            ElseIf TypeOf (ctl) Is DateTimePicker = True Then
                ctl.Enabled = False
            End If
        Next
    End Sub

    Private Sub btnCPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCPic.Click
        If MessageBox.Show("Do you want to change your Profile Photo", "Profile Photo Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                pboxProfile.Image = New Bitmap(OFD.FileName)
                insertImage(pboxProfile)
            End If
        End If
    End Sub
End Class