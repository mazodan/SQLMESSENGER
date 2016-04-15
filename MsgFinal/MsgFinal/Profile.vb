Public Class Profile

    Private Sub Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class