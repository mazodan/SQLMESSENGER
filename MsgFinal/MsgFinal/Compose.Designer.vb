<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compose))
        Me.cmbFriends = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rtfMessage = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tsMain = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmbFontSize = New System.Windows.Forms.ToolStripComboBox
        Me.cmbFont = New System.Windows.Forms.ToolStripComboBox
        Me.cdColors = New System.Windows.Forms.ColorDialog
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.btnBold = New System.Windows.Forms.ToolStripButton
        Me.btnItalic = New System.Windows.Forms.ToolStripButton
        Me.btnUnderline = New System.Windows.Forms.ToolStripButton
        Me.btnStrikeThrough = New System.Windows.Forms.ToolStripButton
        Me.btnCut = New System.Windows.Forms.ToolStripButton
        Me.btnCopy = New System.Windows.Forms.ToolStripButton
        Me.btnPaste = New System.Windows.Forms.ToolStripButton
        Me.btnSelectAll = New System.Windows.Forms.ToolStripButton
        Me.btnLeftAlign = New System.Windows.Forms.ToolStripButton
        Me.btnCenter = New System.Windows.Forms.ToolStripButton
        Me.btnRight = New System.Windows.Forms.ToolStripButton
        Me.btnPic = New System.Windows.Forms.ToolStripButton
        Me.btnColor = New System.Windows.Forms.ToolStripButton
        Me.pbPhoto = New System.Windows.Forms.PictureBox
        Me.tsMain.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbFriends
        '
        Me.cmbFriends.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFriends.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFriends.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFriends.FormattingEnabled = True
        Me.cmbFriends.Location = New System.Drawing.Point(41, 6)
        Me.cmbFriends.Name = "cmbFriends"
        Me.cmbFriends.Size = New System.Drawing.Size(231, 21)
        Me.cmbFriends.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To:"
        '
        'rtfMessage
        '
        Me.rtfMessage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfMessage.Location = New System.Drawing.Point(12, 89)
        Me.rtfMessage.Name = "rtfMessage"
        Me.rtfMessage.Size = New System.Drawing.Size(740, 294)
        Me.rtfMessage.TabIndex = 2
        Me.rtfMessage.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Message:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBold, Me.btnItalic, Me.btnUnderline, Me.btnStrikeThrough, Me.ToolStripSeparator1, Me.btnCut, Me.btnCopy, Me.btnPaste, Me.btnSelectAll, Me.cmbFontSize, Me.cmbFont, Me.btnLeftAlign, Me.btnCenter, Me.btnRight, Me.btnPic, Me.btnColor})
        Me.tsMain.Location = New System.Drawing.Point(12, 61)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(482, 25)
        Me.tsMain.TabIndex = 5
        Me.tsMain.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmbFontSize
        '
        Me.cmbFontSize.AutoSize = False
        Me.cmbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
        Me.cmbFontSize.Name = "cmbFontSize"
        Me.cmbFontSize.Size = New System.Drawing.Size(40, 23)
        Me.cmbFontSize.Text = "11"
        Me.cmbFontSize.ToolTipText = "Font Size"
        '
        'cmbFont
        '
        Me.cmbFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFont.Items.AddRange(New Object() {"Arial", "Calibri", "Cambria", "Comic Sans MS", "Consolas", "Courier New", "Georgia", "Impact", "Palatino Linotype", "Segoe UI", "Times New Roman", "Trebuchet MS", "Verdana"})
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(130, 25)
        Me.cmbFont.ToolTipText = "Font"
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'btnBold
        '
        Me.btnBold.CheckOnClick = True
        Me.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnBold.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBold.Image = CType(resources.GetObject("btnBold.Image"), System.Drawing.Image)
        Me.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(23, 22)
        Me.btnBold.Text = "B"
        Me.btnBold.ToolTipText = "Bold"
        '
        'btnItalic
        '
        Me.btnItalic.CheckOnClick = True
        Me.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnItalic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalic.Image = CType(resources.GetObject("btnItalic.Image"), System.Drawing.Image)
        Me.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(23, 22)
        Me.btnItalic.Text = "I"
        Me.btnItalic.ToolTipText = "Italic"
        '
        'btnUnderline
        '
        Me.btnUnderline.CheckOnClick = True
        Me.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUnderline.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnderline.Image = CType(resources.GetObject("btnUnderline.Image"), System.Drawing.Image)
        Me.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(23, 22)
        Me.btnUnderline.Text = "U"
        Me.btnUnderline.ToolTipText = "Underline"
        '
        'btnStrikeThrough
        '
        Me.btnStrikeThrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnStrikeThrough.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrikeThrough.Image = CType(resources.GetObject("btnStrikeThrough.Image"), System.Drawing.Image)
        Me.btnStrikeThrough.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStrikeThrough.Name = "btnStrikeThrough"
        Me.btnStrikeThrough.Size = New System.Drawing.Size(23, 22)
        Me.btnStrikeThrough.Text = "S"
        Me.btnStrikeThrough.ToolTipText = "Strikeout"
        '
        'btnCut
        '
        Me.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCut.Image = Global.MsgFinal.My.Resources.Resources.edit_cut_icon
        Me.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(23, 22)
        Me.btnCut.Text = "Cut"
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = Global.MsgFinal.My.Resources.Resources.copy
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "Copy"
        '
        'btnPaste
        '
        Me.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaste.Image = Global.MsgFinal.My.Resources.Resources.paste
        Me.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(23, 22)
        Me.btnPaste.Text = "Paste"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSelectAll.Image = Global.MsgFinal.My.Resources.Resources.edit_select_all
        Me.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(23, 22)
        Me.btnSelectAll.Text = "Select All"
        '
        'btnLeftAlign
        '
        Me.btnLeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLeftAlign.Image = Global.MsgFinal.My.Resources.Resources.align_left
        Me.btnLeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLeftAlign.Name = "btnLeftAlign"
        Me.btnLeftAlign.Size = New System.Drawing.Size(23, 22)
        Me.btnLeftAlign.ToolTipText = "Left Align"
        '
        'btnCenter
        '
        Me.btnCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCenter.Image = Global.MsgFinal.My.Resources.Resources.alignment_27939_960_720
        Me.btnCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(23, 22)
        Me.btnCenter.ToolTipText = "Center Align"
        '
        'btnRight
        '
        Me.btnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRight.Image = Global.MsgFinal.My.Resources.Resources.align_right
        Me.btnRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(23, 22)
        Me.btnRight.ToolTipText = "Right Align"
        '
        'btnPic
        '
        Me.btnPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPic.Image = CType(resources.GetObject("btnPic.Image"), System.Drawing.Image)
        Me.btnPic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPic.Name = "btnPic"
        Me.btnPic.Size = New System.Drawing.Size(23, 22)
        Me.btnPic.ToolTipText = "Input Photo"
        '
        'btnColor
        '
        Me.btnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnColor.Image = Global.MsgFinal.My.Resources.Resources.logo_design_color_wheel
        Me.btnColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(23, 22)
        Me.btnColor.ToolTipText = "Paint"
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(677, 12)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(75, 71)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 6
        Me.pbPhoto.TabStop = False
        '
        'Compose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 424)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rtfMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFriends)
        Me.Name = "Compose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compose"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbFriends As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtfMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSelectAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnStrikeThrough As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbFontSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbFont As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnLeftAlign As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCenter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents cdColors As System.Windows.Forms.ColorDialog
    Friend WithEvents btnColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPic As System.Windows.Forms.ToolStripButton
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox
End Class
