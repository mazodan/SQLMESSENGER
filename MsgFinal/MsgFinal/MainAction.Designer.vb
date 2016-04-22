<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainAction
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
        Me.components = New System.ComponentModel.Container
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ttProfile = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFriend = New System.Windows.Forms.Button
        Me.btnProfile = New System.Windows.Forms.Button
        Me.ttFriend = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Items.AddRange(New Object() {"You Have 2 unread messages", "you have 10 friend requests", "You are now friends with xxxseglordszzz"})
        Me.ListBox1.Location = New System.Drawing.Point(198, 75)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(356, 174)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Notifications"
        '
        'ttProfile
        '
        Me.ttProfile.ToolTipTitle = "Profile"
        '
        'btnFriend
        '
        Me.btnFriend.BackgroundImage = Global.MsgFinal.My.Resources.Resources.account_multiple
        Me.btnFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFriend.Location = New System.Drawing.Point(456, 12)
        Me.btnFriend.Name = "btnFriend"
        Me.btnFriend.Size = New System.Drawing.Size(46, 44)
        Me.btnFriend.TabIndex = 3
        Me.btnFriend.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.BackgroundImage = Global.MsgFinal.My.Resources.Resources.account_card_details
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProfile.Location = New System.Drawing.Point(508, 12)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(46, 44)
        Me.btnProfile.TabIndex = 2
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'ttFriend
        '
        Me.ttFriend.ToolTipTitle = "Friend"
        '
        'MainAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 266)
        Me.Controls.Add(Me.btnFriend)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "MainAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainAction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents ttProfile As System.Windows.Forms.ToolTip
    Friend WithEvents btnFriend As System.Windows.Forms.Button
    Friend WithEvents ttFriend As System.Windows.Forms.ToolTip
End Class
