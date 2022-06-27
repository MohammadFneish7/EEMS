Public Class User
    Private username As String
    Private password As String
    Private isAdminUser As Boolean
    Private roles As New List(Of String)
    Dim a As New SqlDBHelper.Helper

    Sub New(username_ As String, password_ As String)
        If username_.ToLower.Equals("admin") Then
            isAdminUser = True
        End If
        username = username_
        password = password_
        loadPermisions()
    End Sub

    Public Function getUsername() As String
        Return username
    End Function

    Public Function getPassword() As String
        Return password
    End Function

    Public Function isAdmin() As Boolean
        Return isAdminUser
    End Function

    Private Sub loadPermisions()
        a.ds = New DataSet
        a.GetData("select rolename from userroles where username='" & username & "'", "dt1")
        For Each row As DataRow In a.ds.Tables("dt1").Rows
            roles.Add(row.Item(0).ToString.Trim.ToLower)
        Next
    End Sub

    Public Function hasPermision(ByVal requiredRole As String) As Boolean
        If isAdmin() Then
            Return True
        End If
        If roles.Contains(requiredRole.Trim.ToLower) Then
            Return True
        End If
        Return False
    End Function


End Class
