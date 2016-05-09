<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FriendRequests
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
        Me.lstVwFriendREQ = New System.Windows.Forms.ListView
        Me.lblFrCount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstVwFriendREQ
        '
        Me.lstVwFriendREQ.Location = New System.Drawing.Point(17, 67)
        Me.lstVwFriendREQ.MultiSelect = False
        Me.lstVwFriendREQ.Name = "lstVwFriendREQ"
        Me.lstVwFriendREQ.Size = New System.Drawing.Size(184, 154)
        Me.lstVwFriendREQ.TabIndex = 9
        Me.lstVwFriendREQ.UseCompatibleStateImageBehavior = False
        Me.lstVwFriendREQ.View = System.Windows.Forms.View.Details
        '
        'lblFrCount
        '
        Me.lblFrCount.AutoSize = True
        Me.lblFrCount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrCount.ForeColor = System.Drawing.Color.Lime
        Me.lblFrCount.Location = New System.Drawing.Point(12, 39)
        Me.lblFrCount.Name = "lblFrCount"
        Me.lblFrCount.Size = New System.Drawing.Size(207, 25)
        Me.lblFrCount.TabIndex = 8
        Me.lblFrCount.Text = "You have X Request(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Friend Requests"
        '
        'btnRemove
        '
        Me.btnRemove.BackgroundImage = Global.MsgFinal.My.Resources.Resources.account_remove
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemove.Location = New System.Drawing.Point(155, 227)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(46, 44)
        Me.btnRemove.TabIndex = 11
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.MsgFinal.My.Resources.Resources.account_plus
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Location = New System.Drawing.Point(103, 227)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(46, 44)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'FriendRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 288)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstVwFriendREQ)
        Me.Controls.Add(Me.lblFrCount)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FriendRequests"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Friend Requests"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstVwFriendREQ As System.Windows.Forms.ListView
    Friend WithEvents lblFrCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
