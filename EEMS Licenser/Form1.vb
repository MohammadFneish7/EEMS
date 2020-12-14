Imports System.Text
Imports System.Security.Cryptography

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim serial As String = TextBox1.Text.Trim
        Dim hash As String = GenerateHash(serial & "yamahdi2017license")
        Dim lcs1 As String = hash.Substring(0, 5)
        Dim lcs2 As String = hash.Substring(5, 5)
        Dim lcs3 As String = hash.Substring(10, 5)
        Dim lcs4 As String = hash.Substring(15, 5)
        Dim lcs5 As String = hash.Substring(20, 5)
        Dim license As String = lcs1 + "-" + lcs2 + "-" + lcs3 + "-" + lcs4 + "-" + lcs5
        TextBox2.Text = license
    End Sub

    Public Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Dim sb As New StringBuilder(ByteHash.Length * 2)
        For Each b As Byte In ByteHash
            sb.Append(Conversion.Hex(b))
        Next
        Return sb.ToString
    End Function

End Class
