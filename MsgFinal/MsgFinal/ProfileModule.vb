Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Module ProfileModule
    

    Sub LoadProfileData(ByVal fname As TextBox, ByVal lname As TextBox, ByVal address As TextBox, ByVal gender As ComboBox, _
                        ByVal country As TextBox, ByVal bday As DateTimePicker, ByVal pics As PictureBox)
        Dim conn As New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")
        conn.Open()
        Dim query As String = "select * from user where username='" & CurUser & "'"

        Dim com As New MySqlCommand(query, conn)
        Dim dr As MySqlDataReader = com.ExecuteReader

        If Not dr Is Nothing Then
            dr.Read()
            fname.Text = dr("FirstName").ToString
            lname.Text = dr("LastName").ToString
            address.Text = dr("address").ToString
            gender.Text = dr("gender").ToString
            country.Text = dr("country").ToString
            Dim tempdate As Date = dr("birthday")
            bday.Value = tempdate
            Dim data As Byte() = DirectCast(dr("photo"), Byte())
            Dim ms As New System.IO.MemoryStream(data)
            pics.Image = Image.FromStream(ms)
            ms.Close()
        End If

    End Sub
End Module
