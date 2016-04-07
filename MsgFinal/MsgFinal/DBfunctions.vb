Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module DBfunctions
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")

    Function checkUser(ByVal text As String, ByVal caseSensitive As Boolean) As String
        Try
            conn.Open()
        Catch ex As MySqlException
            Return "ERROR"
        End Try

        Dim query As String
        If caseSensitive = True Then
            query = "select * from user where username = @user"
        Else
            query = "select * from user where binary username = @user"
        End If


        Dim comm As MySqlCommand = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", text)

        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim rCount As Integer = dset.Tables("user").Rows.Count
        conn.Close()
        If rCount = 1 Then
            Return "UserExists"
        Else
            Return "UserAvailable"
        End If
    End Function

    Sub RegisterUser(ByVal user As String, ByVal pw As String, ByVal fname As String, ByVal lname As String, ByVal add As String, ByVal gender As String _
                     , ByVal country As String, ByVal bday As String, ByVal sq As String, ByVal sa As String)
        Try
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return
        End Try

        sa = Encrypt(sa, user)

        Dim query As String = "insert into user (username,FirstName,LastName,address,gender,country,birthday,secQuestion,secAnswer) " + _
        "values (@user,@fname,@lname,@add,@gender,@country,@bday,@secQ,@secA)"
        Dim comm As MySqlCommand = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", user)
        comm.Parameters.AddWithValue("@fname", fname)
        comm.Parameters.AddWithValue("@lname", lname)
        comm.Parameters.AddWithValue("@add", add)
        comm.Parameters.AddWithValue("@gender", gender)
        comm.Parameters.AddWithValue("@country", country)
        comm.Parameters.Add("@bday", bday).MySqlDbType = MySqlDbType.Date
        'this shit aint depreciated, i want specific values kthnx

        comm.Parameters.AddWithValue("@secQ", sq)
        comm.Parameters.AddWithValue("@secA", sa)


        Try
            comm.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return
        End Try
        'retrival of userID
        query = "select * from user where username = @User"
        comm = New MySqlCommand(query, conn)
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
        'Inserting the password in another database for security
        InsertPasswordData(uID, pw)



        MessageBox.Show("USER IS NOW REGISTERED, YOU MAY NOW LOGIN")
    End Sub

    Sub InsertPasswordData(ByVal uid As String, ByVal pass As String)
        Dim conn2 As MySqlConnection = New MySqlConnection("server=localhost;Database=passwords;User ID=root;Password=root")
        conn2.Open()
        Dim query As String = "insert into Password (UID,hashSalt) values (@uid,@hash)"
        Dim comm As MySqlCommand = New MySqlCommand(query, conn2)
        comm.Parameters.AddWithValue("@uid", uid)
        comm.Parameters.AddWithValue("@hash", CreateHash(pass))
        comm.ExecuteNonQuery()
        conn2.Close()
    End Sub
End Module
