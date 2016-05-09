<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outbox
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
        Me.btnDSearch = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvMessageBox = New System.Windows.Forms.ListView
        Me.lbMessageName = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnDSearch
        '
        Me.btnDSearch.Location = New System.Drawing.Point(494, 190)
        Me.btnDSearch.Name = "btnDSearch"
        Me.btnDSearch.Size = New System.Drawing.Size(121, 23)
        Me.btnDSearch.TabIndex = 27
        Me.btnDSearch.Text = "Search Message"
        Me.btnDSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(489, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 30)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Search by Date"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(494, 162)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(209, 20)
        Me.dtpDate.TabIndex = 25
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(494, 103)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(121, 23)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search Message"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(494, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(182, 20)
        Me.txtSearch.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(489, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Search by Subject"
        '
        'lvMessageBox
        '
        Me.lvMessageBox.Location = New System.Drawing.Point(12, 42)
        Me.lvMessageBox.Name = "lvMessageBox"
        Me.lvMessageBox.Size = New System.Drawing.Size(471, 219)
        Me.lvMessageBox.TabIndex = 20
        Me.lvMessageBox.UseCompatibleStateImageBehavior = False
        Me.lvMessageBox.View = System.Windows.Forms.View.Details
        '
        'lbMessageName
        '
        Me.lbMessageName.AutoSize = True
        Me.lbMessageName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMessageName.Location = New System.Drawing.Point(12, 9)
        Me.lbMessageName.Name = "lbMessageName"
        Me.lbMessageName.Size = New System.Drawing.Size(88, 30)
        Me.lbMessageName.TabIndex = 19
        Me.lbMessageName.Text = "Outbox"
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.MsgFinal.My.Resources.Resources.delete_forever1
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Location = New System.Drawing.Point(437, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(46, 44)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Outbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 323)
        Me.Controls.Add(Me.btnDSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lvMessageBox)
        Me.Controls.Add(Me.lbMessageName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Outbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDSearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lvMessageBox As System.Windows.Forms.ListView
    Friend WithEvents lbMessageName As System.Windows.Forms.Label
End Class
