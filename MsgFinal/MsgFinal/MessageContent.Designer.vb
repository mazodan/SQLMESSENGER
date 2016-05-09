<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageContent
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnForward = New System.Windows.Forms.Button
        Me.btnReply = New System.Windows.Forms.Button
        Me.rtfInfo = New System.Windows.Forms.RichTextBox
        Me.lblSend = New System.Windows.Forms.Label
        Me.lblSubj = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject:"
        '
        'btnForward
        '
        Me.btnForward.BackgroundImage = Global.MsgFinal.My.Resources.Resources.transfer
        Me.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnForward.Location = New System.Drawing.Point(707, 356)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(46, 44)
        Me.btnForward.TabIndex = 16
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnReply
        '
        Me.btnReply.BackgroundImage = Global.MsgFinal.My.Resources.Resources.reply
        Me.btnReply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReply.Location = New System.Drawing.Point(655, 356)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(46, 44)
        Me.btnReply.TabIndex = 17
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'rtfInfo
        '
        Me.rtfInfo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfInfo.Location = New System.Drawing.Point(16, 56)
        Me.rtfInfo.Name = "rtfInfo"
        Me.rtfInfo.ReadOnly = True
        Me.rtfInfo.Size = New System.Drawing.Size(740, 294)
        Me.rtfInfo.TabIndex = 18
        Me.rtfInfo.Text = ""
        '
        'lblSend
        '
        Me.lblSend.AutoSize = True
        Me.lblSend.Location = New System.Drawing.Point(66, 13)
        Me.lblSend.Name = "lblSend"
        Me.lblSend.Size = New System.Drawing.Size(40, 13)
        Me.lblSend.TabIndex = 19
        Me.lblSend.Text = "Label3"
        '
        'lblSubj
        '
        Me.lblSubj.AutoSize = True
        Me.lblSubj.Location = New System.Drawing.Point(66, 37)
        Me.lblSubj.Name = "lblSubj"
        Me.lblSubj.Size = New System.Drawing.Size(40, 13)
        Me.lblSubj.TabIndex = 20
        Me.lblSubj.Text = "Label4"
        '
        'MessageContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 407)
        Me.Controls.Add(Me.lblSubj)
        Me.Controls.Add(Me.lblSend)
        Me.Controls.Add(Me.rtfInfo)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MessageContent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageContent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents btnReply As System.Windows.Forms.Button
    Friend WithEvents rtfInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents lblSend As System.Windows.Forms.Label
    Friend WithEvents lblSubj As System.Windows.Forms.Label
End Class
