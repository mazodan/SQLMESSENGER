Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Module AES

    'if anyone asks, i got this from the internet, I AM NOT A COMPUTER SCIENTIST TO EXPLAIN THIS CRYPTO FUNCTIONS
    Public Function AES_Encrypt(ByVal bytesToBeEncrypted As Byte(), ByVal passwordBytes As Byte()) As Byte()
        Dim encryptedBytes As Byte() = Nothing
        'salt
        Dim saltBytes As Byte() = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}

        Using ms As New MemoryStream()
            Using AES As New RijndaelManaged()
                AES.KeySize = 256
                AES.BlockSize = 128

                Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
                AES.Key = key.GetBytes(AES.KeySize / 8)
                AES.IV = key.GetBytes(AES.BlockSize / 8)

                AES.Mode = CipherMode.CBC
                Using cs = New CryptoStream(ms, AES.CreateEncryptor, CryptoStreamMode.Write)
                    cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length)
                    cs.Close()
                End Using
                encryptedBytes = ms.ToArray
            End Using
        End Using
        Return encryptedBytes
    End Function

    Public Function AES_Decrypt(ByVal bytesToBeDecrypted As Byte(), ByVal passwordBytes As Byte()) As Byte()
        Dim decryptedBytes As Byte() = Nothing
        Dim saltBytes As Byte() = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}

        Using ms As New MemoryStream()
            Using AES As New RijndaelManaged()
                AES.KeySize = 256
                AES.BlockSize = 128

                Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
                AES.Key = key.GetBytes(AES.KeySize / 8)
                AES.IV = key.GetBytes(AES.BlockSize / 8)

                AES.Mode = CipherMode.CBC

                Using cs = New CryptoStream(ms, AES.CreateDecryptor, CryptoStreamMode.Write)
                    cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length)
                    cs.Close()
                End Using
                decryptedBytes = ms.ToArray

            End Using
        End Using
        Return decryptedBytes
    End Function

    'Main function for encryptin shit
    Public Function Encrypt(ByVal text As String, ByVal pwd As String) As String
        Dim originalBytes As Byte() = Encoding.UTF8.GetBytes(text)
        Dim encryptedBytes As Byte() = Nothing
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(pwd)

        ' Hash the password with SHA256
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes)

        ' Generating salt bytes
        Dim saltBytes As Byte() = GetRandomBytes()

        ' Appending salt bytes to original bytes
        Dim bytesToBeEncrypted As Byte() = New Byte(saltBytes.Length + (originalBytes.Length - 1)) {}
        For i As Integer = 0 To saltBytes.Length - 1
            bytesToBeEncrypted(i) = saltBytes(i)
        Next
        For i As Integer = 0 To originalBytes.Length - 1
            bytesToBeEncrypted(i + saltBytes.Length) = originalBytes(i)
        Next

        encryptedBytes = AES_Encrypt(bytesToBeEncrypted, passwordBytes)

        Return Convert.ToBase64String(encryptedBytes)
    End Function

    Public Function Decrypt(ByVal decryptedText As String, ByVal pwd As String) As String
        Dim bytesToBeDecrypted As Byte() = Convert.FromBase64String(decryptedText)
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(pwd)

        ' Hash the password with SHA256
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes)

        Dim decryptedBytes As Byte() = AES_Decrypt(bytesToBeDecrypted, passwordBytes)

        ' Getting the size of salt
        Dim _saltSize As Integer = 4

        ' Removing salt bytes, retrieving original bytes
        Dim originalBytes As Byte() = New Byte(decryptedBytes.Length - _saltSize - 1) {}
        For i As Integer = _saltSize To decryptedBytes.Length - 1
            originalBytes(i - _saltSize) = decryptedBytes(i)
        Next

        Return Encoding.UTF8.GetString(originalBytes)
    End Function

    Public Function GetRandomBytes() As Byte()
        Dim _saltSize As Integer = 4
        Dim ba As Byte() = New Byte(_saltSize - 1) {}
        RNGCryptoServiceProvider.Create().GetBytes(ba)
        Return ba
    End Function
End Module
