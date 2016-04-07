Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module PasswordChangeFunctions
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")

    Sub PresentSecretQuestion(ByVal username As String, ByVal txtbox As TextBox)
        Try
            conn.Open()
        Catch ex As MySqlException
            Return
        End Try

        Dim query As String = "select secQuestion from user where username = @user"
        Dim comm As MySqlCommand = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", username)

        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        txtbox.Text = dset.Tables(0).Rows(0).Item(0).ToString
        conn.Close()
    End Sub

    Function ComparePassword(ByVal answer As String, ByVal username As String) As Boolean
        Try
            conn.Open()
        Catch ex As MySqlException
            Exit Function
        End Try

        Dim query As String = "select secAnswer from user where username = @user"
        Dim comm As MySqlCommand = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", username)

        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        If answer.ToLower = Decrypt(dset.Tables(0).Rows(0).Item(0).ToString, username).ToLower Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub UpdateData(ByVal user As String, ByVal pass As String)
        conn.Open()
        'retrival of userID
        Dim query As String = "select * from user where username = @User"
        Dim comm As MySqlCommand = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", user)
        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim uID As String = dset.Tables(0).Rows(0).Item(0).ToString
        conn.Close()
        Dim conn2 As MySqlConnection = New MySqlConnection("server=localhost;Database=passwords;User ID=root;Password=root")
        conn2.Open()
        query = "update Password set hashSalt=@hash where UID=@uid"
        comm = New MySqlCommand(query, conn2)
        comm.Parameters.AddWithValue("@uid", uID)
        comm.Parameters.AddWithValue("@hash", CreateHash(pass))
        comm.ExecuteNonQuery()
        conn2.Close()
    End Sub
End Module
