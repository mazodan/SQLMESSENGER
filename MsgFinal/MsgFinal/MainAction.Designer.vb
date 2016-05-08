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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ttProfile = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttFriend = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttFreq = New System.Windows.Forms.ToolTip(Me.components)
        Me.lvNotify = New System.Windows.Forms.ListView
        Me.ttComp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCompose = New System.Windows.Forms.Button
        Me.btnFreq = New System.Windows.Forms.Button
        Me.btnFriend = New System.Windows.Forms.Button
        Me.btnProfile = New System.Windows.Forms.Button
        Me.SuspendLayout()
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
        'ttFriend
        '
        Me.ttFriend.ToolTipTitle = "Friend"
        '
        'ttFreq
        '
        Me.ttFreq.ToolTipTitle = "Friend Request"
        '
        'lvNotify
        '
        Me.lvNotify.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvNotify.Location = New System.Drawing.Point(198, 75)
        Me.lvNotify.Name = "lvNotify"
        Me.lvNotify.Size = New System.Drawing.Size(356, 179)
        Me.lvNotify.TabIndex = 5
        Me.lvNotify.UseCompatibleStateImageBehavior = False
        Me.lvNotify.View = System.Windows.Forms.View.Details
        '
        'ttComp
        '
        Me.ttComp.ToolTipTitle = "Compose"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.MsgFinal.My.Resources.Resources.outbox
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Location = New System.Drawing.Point(116, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 44)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MsgFinal.My.Resources.Resources.inbox
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Location = New System.Drawing.Point(64, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCompose
        '
        Me.btnCompose.BackgroundImage = Global.MsgFinal.My.Resources.Resources.comment_plus_outline
        Me.btnCompose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCompose.Location = New System.Drawing.Point(12, 12)
        Me.btnCompose.Name = "btnCompose"
        Me.btnCompose.Size = New System.Drawing.Size(46, 44)
        Me.btnCompose.TabIndex = 6
        Me.btnCompose.UseVisualStyleBackColor = True
        '
        'btnFreq
        '
        Me.btnFreq.BackgroundImage = Global.MsgFinal.My.Resources.Resources.account_alert
        Me.btnFreq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFreq.Location = New System.Drawing.Point(404, 12)
        Me.btnFreq.Name = "btnFreq"
        Me.btnFreq.Size = New System.Drawing.Size(46, 44)
        Me.btnFreq.TabIndex = 4
        Me.btnFreq.UseVisualStyleBackColor = True
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
        'MainAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 266)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCompose)
        Me.Controls.Add(Me.lvNotify)
        Me.Controls.Add(Me.btnFreq)
        Me.Controls.Add(Me.btnFriend)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainAction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents ttProfile As System.Windows.Forms.ToolTip
    Friend WithEvents btnFriend As System.Windows.Forms.Button
    Friend WithEvents ttFriend As System.Windows.Forms.ToolTip
    Friend WithEvents btnFreq As System.Windows.Forms.Button
    Friend WithEvents ttFreq As System.Windows.Forms.ToolTip
    Friend WithEvents lvNotify As System.Windows.Forms.ListView
    Friend WithEvents btnCompose As System.Windows.Forms.Button
    Friend WithEvents ttComp As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
