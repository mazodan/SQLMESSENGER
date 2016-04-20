<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAdd = New System.Windows.Forms.TextBox
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpBday = New System.Windows.Forms.DateTimePicker
        Me.btnEProfile = New System.Windows.Forms.Button
        Me.btnUPD = New System.Windows.Forms.Button
        Me.btnCPic = New System.Windows.Forms.Button
        Me.pboxProfile = New System.Windows.Forms.PictureBox
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FIrst Name"
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(191, 28)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(100, 22)
        Me.txtFname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(361, 28)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(100, 22)
        Me.txtLname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(180, 62)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(281, 20)
        Me.txtAdd.TabIndex = 6
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(177, 96)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(77, 21)
        Me.cmbGender.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Country"
        '
        'txtCountry
        '
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(314, 96)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(147, 22)
        Me.txtCountry.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Birthday"
        '
        'dtpBday
        '
        Me.dtpBday.Location = New System.Drawing.Point(261, 124)
        Me.dtpBday.Name = "dtpBday"
        Me.dtpBday.Size = New System.Drawing.Size(200, 20)
        Me.dtpBday.TabIndex = 13
        '
        'btnEProfile
        '
        Me.btnEProfile.Location = New System.Drawing.Point(325, 154)
        Me.btnEProfile.Name = "btnEProfile"
        Me.btnEProfile.Size = New System.Drawing.Size(75, 23)
        Me.btnEProfile.TabIndex = 14
        Me.btnEProfile.Text = "Edit Profile"
        Me.btnEProfile.UseVisualStyleBackColor = True
        '
        'btnUPD
        '
        Me.btnUPD.Location = New System.Drawing.Point(406, 154)
        Me.btnUPD.Name = "btnUPD"
        Me.btnUPD.Size = New System.Drawing.Size(75, 23)
        Me.btnUPD.TabIndex = 15
        Me.btnUPD.Text = "Update"
        Me.btnUPD.UseVisualStyleBackColor = True
        Me.btnUPD.Visible = False
        '
        'btnCPic
        '
        Me.btnCPic.Location = New System.Drawing.Point(21, 109)
        Me.btnCPic.Name = "btnCPic"
        Me.btnCPic.Size = New System.Drawing.Size(88, 23)
        Me.btnCPic.TabIndex = 16
        Me.btnCPic.Text = "Change Photo"
        Me.btnCPic.UseVisualStyleBackColor = True
        '
        'pboxProfile
        '
        Me.pboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pboxProfile.Location = New System.Drawing.Point(12, 12)
        Me.pboxProfile.Name = "pboxProfile"
        Me.pboxProfile.Size = New System.Drawing.Size(108, 91)
        Me.pboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProfile.TabIndex = 0
        Me.pboxProfile.TabStop = False
        '
        'OFD
        '
        Me.OFD.Filter = "Jpeg Image|*.jpg|PNG image|*.png"
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 189)
        Me.Controls.Add(Me.btnCPic)
        Me.Controls.Add(Me.btnUPD)
        Me.Controls.Add(Me.btnEProfile)
        Me.Controls.Add(Me.dtpBday)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pboxProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxProfile As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpBday As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnEProfile As System.Windows.Forms.Button
    Friend WithEvents btnUPD As System.Windows.Forms.Button
    Friend WithEvents btnCPic As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
End Class
