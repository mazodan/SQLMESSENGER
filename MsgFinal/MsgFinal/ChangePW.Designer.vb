<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePW
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
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSQ = New System.Windows.Forms.TextBox
        Me.txtAns = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnChangePW = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNPW = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblUser.Location = New System.Drawing.Point(112, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(109, 25)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome:"
        '
        'txtSQ
        '
        Me.txtSQ.BackColor = System.Drawing.Color.White
        Me.txtSQ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQ.Location = New System.Drawing.Point(17, 37)
        Me.txtSQ.Multiline = True
        Me.txtSQ.Name = "txtSQ"
        Me.txtSQ.ReadOnly = True
        Me.txtSQ.Size = New System.Drawing.Size(463, 52)
        Me.txtSQ.TabIndex = 3
        '
        'txtAns
        '
        Me.txtAns.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAns.Location = New System.Drawing.Point(96, 103)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(384, 29)
        Me.txtAns.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Answer:"
        '
        'btnChangePW
        '
        Me.btnChangePW.Location = New System.Drawing.Point(367, 190)
        Me.btnChangePW.Name = "btnChangePW"
        Me.btnChangePW.Size = New System.Drawing.Size(113, 23)
        Me.btnChangePW.TabIndex = 6
        Me.btnChangePW.Text = "Change Password"
        Me.btnChangePW.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "New Password"
        '
        'txtNPW
        '
        Me.txtNPW.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNPW.Location = New System.Drawing.Point(12, 184)
        Me.txtNPW.Name = "txtNPW"
        Me.txtNPW.Size = New System.Drawing.Size(349, 29)
        Me.txtNPW.TabIndex = 7
        Me.txtNPW.UseSystemPasswordChar = True
        '
        'ChangePW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 225)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNPW)
        Me.Controls.Add(Me.btnChangePW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.txtSQ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSQ As System.Windows.Forms.TextBox
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChangePW As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNPW As System.Windows.Forms.TextBox
End Class
