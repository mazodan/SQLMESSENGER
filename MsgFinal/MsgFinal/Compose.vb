'temp import
'MESSAGE ENCRYPTION IS A SUCCESS
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Compose
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")
    Private Sub Compose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each elm As String In getFriendsToList(getUsrID(CurUser))
            cmbFriends.Items.Add(elm)
        Next

        'conn.Open()
        'Dim query As String = "select message from message where id=3"
        'Dim comm As New MySqlCommand(query, conn)
        'Dim dr As MySqlDataReader = comm.ExecuteReader()
        'dr.Read()
        'Me.rtfMessage.Rtf = Decrypt(dr.GetString(0), "HELLO")
        'conn.Close()

        'cmbFont.SelectedItem = cmbFont.FindString("Segoe UI").ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn.Open()
        Dim query As String = "insert into message (message) values ('" + Encrypt(Me.rtfMessage.Rtf, "HELLO") + "')"
        Dim comm As New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Code execution success")
    End Sub

   
    Private Sub btnCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCut.Click
        rtfMessage.Cut()
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        rtfMessage.Copy()
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        rtfMessage.Paste()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        rtfMessage.SelectAll()
    End Sub



   
    Private Sub btnBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold.Click
        Dim curStyle As FontStyle = rtfMessage.SelectionFont.Style

        If rtfMessage.SelectionFont.Bold = False Then
            curStyle += FontStyle.Bold
        Else
            curStyle -= FontStyle.Bold
        End If

        rtfMessage.SelectionFont = New Font(rtfMessage.SelectionFont, curStyle)
    End Sub

    Private Sub btnItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItalic.Click
        Dim curStyle As FontStyle = rtfMessage.SelectionFont.Style

        If rtfMessage.SelectionFont.Italic = False Then
            curStyle += FontStyle.Italic
        Else
            curStyle -= FontStyle.Italic
        End If

        rtfMessage.SelectionFont = New Font(rtfMessage.SelectionFont, curStyle)
    End Sub

    Private Sub btnUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnderline.Click
        Dim curStyle As FontStyle = rtfMessage.SelectionFont.Style

        If rtfMessage.SelectionFont.Underline = False Then
            curStyle += FontStyle.Underline
        Else
            curStyle -= FontStyle.Underline
        End If

        rtfMessage.SelectionFont = New Font(rtfMessage.SelectionFont, curStyle)
    End Sub

    Private Sub btnStrikeThrough_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrikeThrough.Click
        Dim curStyle As FontStyle = rtfMessage.SelectionFont.Style

        If rtfMessage.SelectionFont.Strikeout = False Then
            curStyle += FontStyle.Strikeout
        Else
            curStyle -= FontStyle.Strikeout
        End If

        rtfMessage.SelectionFont = New Font(rtfMessage.SelectionFont, curStyle)
    End Sub

    Private Sub cmbFontSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFontSize.TextChanged
        Dim newsize As Single = Convert.ToSingle(Val(cmbFontSize.Text))
        If newsize > 0 Then
            rtfMessage.SelectionFont = New Font(rtfMessage.SelectionFont.FontFamily, newsize)
        End If

    End Sub

    Private Sub cmbFont_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFont.TextChanged

        Try
            Dim curStyle As FontStyle = rtfMessage.SelectionFont.Style
            'in case user enters unknown font
            Dim newFont As New FontFamily(cmbFont.Text)
            rtfMessage.SelectionFont = New Font(newFont, rtfMessage.SelectionFont.Size, curStyle)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub btnLeftAlign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeftAlign.Click
        rtfMessage.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub btnCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCenter.Click
        rtfMessage.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        rtfMessage.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        cdColors.FullOpen = False
        cdColors.ShowDialog()
        rtfMessage.SelectionColor = cdColors.Color
    End Sub

    Private Sub btnPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPic.Click
        MessageBox.Show("Resize your photo in Paint or Photoshop before importing, Attempting to resize photo here will result in bad quality images.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ofd.Filter = "Image Files|*.jpg;*.gif;*.png;"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image = Image.FromFile(ofd.FileName)
            Clipboard.SetImage(img)
            rtfMessage.Paste()
        End If
    End Sub
End Class