Imports System.Globalization

Public Class ValidityChecher

    Dim a As New SqlDBHelper.Helper
    Sub New()
        a.ds = New DataSet
        Dim count = a.ExecuteScalar("select count(dkey) from DefinedKeys where reference='general' and title='validity'")

        If count = 0 Then
            writeTimeValidity(New DateTime(2019, 6, 1).Date)
        End If
    End Sub

    Public Sub writeTimeValidity(d As Date)
        Try
            Dim cryptosys As New CryptoSys
            Dim validity As String = cryptosys.AES_Encrypt(Format(d, "dd/MM/yyyy HH:mm:ss"), "yamahdi2018")
            a.Execute("delete from DefinedKeys where title='validity' and reference='general'")
            a.Execute("insert into DefinedKeys values('validity','" & validity & "','general')")
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
            Environment.Exit(1)
        End Try
    End Sub

    Public Function readTimeValidity() As Date
        Dim cryptosys As New CryptoSys

        a.ds = New DataSet
        a.GetData("select dkey from DefinedKeys where reference='general' and title='validity'")
        Dim validity As String = Nothing
        If a.ds.Tables(0).Rows.Count > 0 Then
            validity = a.ds.Tables(0).Rows(0).Item(0)
        End If

        If (Not validity Is Nothing) And validity.Trim.Length > 0 Then

            Try
                Dim validityClear As String = cryptosys.AES_Decrypt(validity, "yamahdi2018")
                Dim dt As DateTime = DateTime.ParseExact(validityClear, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                Return dt.Date
            Catch ex As Exception
                writeTimeValidity(Date.Now)
                Return Date.Now
            End Try
        End If

        writeTimeValidity(Date.Now)
        Return Date.Now
    End Function

    Public Function checkValidity() As Integer
        Dim validDate As Date = readTimeValidity()
        Dim span = validDate - Date.Today

        Return span.TotalDays
    End Function

End Class
