<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageList
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
        Me.lbMessageName = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnForward = New System.Windows.Forms.Button
        Me.btnReply = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbMessageName
        '
        Me.lbMessageName.AutoSize = True
        Me.lbMessageName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMessageName.Location = New System.Drawing.Point(12, 9)
        Me.lbMessageName.Name = "lbMessageName"
        Me.lbMessageName.Size = New System.Drawing.Size(71, 30)
        Me.lbMessageName.TabIndex = 3
        Me.lbMessageName.Text = "Inbox"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 42)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(471, 219)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(489, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 30)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search by Text"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(494, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(121, 22)
        Me.txtSearch.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Search Message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.BackgroundImage = Global.MsgFinal.My.Resources.Resources.transfer
        Me.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnForward.Location = New System.Drawing.Point(385, 267)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(46, 44)
        Me.btnForward.TabIndex = 15
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnReply
        '
        Me.btnReply.BackgroundImage = Global.MsgFinal.My.Resources.Resources.reply
        Me.btnReply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReply.Location = New System.Drawing.Point(333, 267)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(46, 44)
        Me.btnReply.TabIndex = 10
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.MsgFinal.My.Resources.Resources.delete_forever1
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Location = New System.Drawing.Point(437, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(46, 44)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(494, 162)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 22)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(489, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 30)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Search by Date"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(494, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Search Message"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MessageList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 323)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lbMessageName)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MessageList"
        Me.Text = "MessageList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbMessageName As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReply As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
