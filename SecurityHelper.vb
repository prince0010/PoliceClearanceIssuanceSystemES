Imports System.Security.Cryptography
Imports System.Security.Policy
Imports System.Text

Public Class SecurityHelper

    Public Shared Function GenerateSalt() As String
        Dim rng As New RNGCryptoServiceProvider()
        Dim buff(15) As Byte
        rng.GetBytes(buff)
        Return Convert.ToBase64String(buff)
    End Function

    Public Shared Function HashPassword(password As String, salt As String) As String
        Dim saltedpassword As String = password & salt
        Dim saltedPasswordBytes() As Byte = Encoding.UTF8.GetBytes(saltedpassword)
        Dim sha256 As New SHA256Managed()
        Dim hashBytes() As Byte = sha256.ComputeHash(saltedPasswordBytes)
        Return Convert.ToBase64String(hashBytes)
    End Function

    Public Shared Function VerifyPassword(password As String, salt As String, hashedPassword As String) As Boolean
        Dim saltedPassword As String = password & salt
        Dim saltedPasswordBytes() As Byte = Encoding.UTF8.GetBytes(saltedPassword)
        Dim sha256 As New SHA256Managed()
        Dim hashBytes() As Byte = sha256.ComputeHash(saltedPasswordBytes)
        Dim hash As String = Convert.ToBase64String(hashBytes)
        Return hash = hashedPassword
    End Function

End Class