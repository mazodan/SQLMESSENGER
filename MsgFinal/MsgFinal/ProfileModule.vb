Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Module ProfileModule
    
    Dim conn As New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")

    Sub LoadProfileData(ByVal fname As TextBox, ByVal lname As TextBox, ByVal address As TextBox, ByVal gender As ComboBox, _
                        ByVal country As TextBox, ByVal bday As DateTimePicker, ByVal pics As PictureBox)

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
        conn.Close()

    End Sub

    Sub updateProfile(ByVal fname As TextBox, ByVal lname As TextBox, ByVal address As TextBox, ByVal gender As ComboBox, _
                        ByVal country As TextBox, ByVal bday As DateTimePicker)
        conn.Open()
        Dim query As String = "update user set FirstName=@fname,LastName=@lname,address=@add,gender=@gender,country=@ctry,birthday=@bday where username='" & CurUser & "'"
        Dim comm As New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@fname", fname.Text)
        comm.Parameters.AddWithValue("@lname", lname.Text)
        comm.Parameters.AddWithValue("@add", address.Text)
        comm.Parameters.AddWithValue("@gender", gender.Text)
        comm.Parameters.AddWithValue("@ctry", country.Text)
        comm.Parameters.Add("@bday", Convert.ToString(bday.Value.Date)).MySqlDbType = MySqlDbType.Date

        Try
            comm.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return
        End Try

        MessageBox.Show("Profile is updated")
        conn.Close()
    End Sub

    Sub insertImage(ByVal pics As PictureBox)
        Dim mstream As New System.IO.MemoryStream
        pics.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        conn.Open()
        Dim query As String = "update user set photo=@photo where username='" & CurUser & "'"
        Dim com As New MySqlCommand(query, conn)
        com.Parameters.AddWithValue("@photo", arrImage)
        com.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Profile Photo is updated")
    End Sub
End Module
