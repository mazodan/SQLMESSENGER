﻿Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module DBfunctions
    Public CurUser As String
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;Database=messengerdata;User ID=root;Password=root")

    Function checkUser(ByVal text As String, ByVal caseInsensitive As Boolean) As String
        Try
            conn.Open()
        Catch ex As MySqlException
            Return "ERROR"
        End Try

        Dim query As String
        If caseInsensitive = True Then
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

        Dim mstream As New System.IO.MemoryStream
        My.Resources._default.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        Dim query As String = "insert into user (username,FirstName,LastName,address,gender,country,birthday,secQuestion,secAnswer,photo) " + _
        "values (@user,@fname,@lname,@add,@gender,@country,@bday,@secQ,@secA,@photo)"
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
        comm.Parameters.AddWithValue("@photo", arrImage)

        Try
            comm.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return
        End Try
        'retrival of userID
        conn.Close()

        Dim uID As String = getUsrID(user)

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

    Function CheckPassword(ByVal uid As String, ByVal pass As String) As Boolean
        Dim conn2 As MySqlConnection = New MySqlConnection("server=localhost;Database=passwords;User ID=root;Password=root")
        conn2.Open()
        Dim query As String = "select * from Password where UID = @uid"
        Dim comm As MySqlCommand = New MySqlCommand(query, conn2)
        comm.Parameters.AddWithValue("@uid", uid)

        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim hashedPW As String = dset.Tables(0).Rows(0).Item(1).ToString
        Return ValidatePassword(pass, hashedPW)

        conn2.Close()
    End Function

    Function checkLogin(ByVal username As String, ByVal pass As String) As Boolean
        Dim usr_conf As Boolean
        Dim pw_conf As Boolean

        Try
            conn.Open()
        Catch ex As MySqlException
            conn.Close()
            Return "ERROR"
        End Try

        Dim query As String
        query = "select * from user where binary username = @user"

        Dim comm As MySqlCommand = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", username)

        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim rCount As Integer = dset.Tables("user").Rows.Count

        If rCount = 1 Then
            usr_conf = True
        Else
            conn.Close()
            Return False
        End If

        query = "select * from user where username = @User"
        comm = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", username)
        adapt = New MySqlDataAdapter(comm)
        dset = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim uID As String = dset.Tables(0).Rows(0).Item(0).ToString
        conn.Close()

        If CheckPassword(uID, pass) = True Then
            pw_conf = True
        Else
            conn.Close()
            Return False
        End If

        If usr_conf = True And pw_conf = True Then
            conn.Close()
            Return True
        End If
    End Function

    Function getUsrID(ByVal username As String) As String
        conn.Open()
        Dim comm As MySqlCommand

        Dim query As String = "select * from user where username = @User"
        comm = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@user", username)
        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        Return dset.Tables(0).Rows(0).Item(0).ToString
    End Function

    Function getUsernameFromID(ByVal ID As String) As String
        conn.Open()
        Dim comm As MySqlCommand

        Dim query As String = "select username from user where userID = @ID"
        comm = New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@ID", ID)
        Dim adapt As MySqlDataAdapter = New MySqlDataAdapter(comm)
        Dim dset As DataSet = New DataSet()

        Try
            adapt.Fill(dset, "user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        Return dset.Tables(0).Rows(0).Item(0).ToString
    End Function



    Sub Fsearch(ByVal fr As String, ByVal dgv As DataGridView)
        Dim query As String = "SELECT username FROM user WHERE username LIKE @param LIMIT 20"
        Dim sTerm As String = String.Format("%{0}%", fr)
        conn.Open()
        Dim comm As New MySqlCommand(query, conn)
        comm.Parameters.AddWithValue("@param", sTerm)

        Dim adpt As New MySqlDataAdapter(comm)
        Dim dset As New DataSet()
        adpt.Fill(dset, "user")
        dgv.DataSource = dset.Tables("user").DefaultView
        conn.Close()
    End Sub


End Module
