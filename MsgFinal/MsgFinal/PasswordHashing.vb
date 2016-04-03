' 
' Password Hashing With PBKDF2 (http://crackstation.net/hashing-security.htm).
' Copyright (c) 2013, Taylor Hornby
' All rights reserved.
'
' Redistribution and use in source and binary forms, with or without 
' modification, are permitted provided that the following conditions are met:
'
' 1. Redistributions of source code must retain the above copyright notice, 
' this list of conditions and the following disclaimer.
'
' 2. Redistributions in binary form must reproduce the above copyright notice,
' this list of conditions and the following disclaimer in the documentation 
' and/or other materials provided with the distribution.
'
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
' IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
' ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE 
' LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
' CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
' SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
' INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
' CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
' ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
' POSSIBILITY OF SUCH DAMAGE.
'



Imports System
Imports System.Text
Imports System.Security.Cryptography


Module PasswordHashing
    Public Const SALT_BYTE_SIZE As Integer = 24
    Public Const HASH_BYTE_SIZE As Integer = 24
    Public Const PBKDF2_ITERATIONS As Integer = 1000

    Public Const ITERATION_INDEX As Integer = 0
    Public Const SALT_INDEX As Integer = 1
    Public Const PBKDF2_INDEX As Integer = 2

    Public Function CreateHash(ByVal password As String) As String
        'random salt generation
        Dim csprng As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(SALT_BYTE_SIZE) {}
        csprng.GetBytes(salt)

        'hash the password
        Dim hash As Byte() = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE)
        Return PBKDF2_ITERATIONS & ":" & Convert.ToBase64String(salt) & ":" & Convert.ToBase64String(hash)
    End Function

    Public Function ValidatePassword(ByVal password As String, ByVal correctHash As String) As Boolean
        Dim delimiter As Char() = {":"c}
        Dim split As String() = correctHash.Split(delimiter)
        Dim iterations As Integer = Int32.Parse(split(ITERATION_INDEX))
        Dim salt As Byte() = Convert.FromBase64String(split(SALT_INDEX))
        Dim hash As Byte() = Convert.FromBase64String(split(PBKDF2_INDEX))

        Dim testhash As Byte() = PBKDF2(password, salt, iterations, hash.Length)
        Return SlowEquals(hash, testhash)
    End Function

    Private Function SlowEquals(ByVal a As Byte(), ByVal b As Byte()) As Boolean
        'convert this part of the c# code
        Dim diff As UInteger = CUInt(a.Length) Xor CUInt(b.Length)
        Dim i As Integer = 0
        While i < a.Length AndAlso i < b.Length
            diff = diff Or CUInt(a(i) Xor b(i))
            i += 1
        End While
        Return diff = 0
    End Function

    Private Function PBKDF2(ByVal password As String, ByVal salt As Byte(), ByVal iterations As Integer, ByVal outputBytes As Integer) As Byte()
        Dim publicKeyDerivation As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, salt)
        publicKeyDerivation.IterationCount = iterations
        Return publicKeyDerivation.GetBytes(outputBytes)
    End Function
End Module
