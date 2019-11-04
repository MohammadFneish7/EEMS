Public Class frmEditPermissions

    Dim a As New SqlDBHelper.Helper
    Dim username As String
    Dim definedRoles As New List(Of role)

    Sub New(username As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.username = username
        a.ds = New DataSet
        a.GetData("select distinct caption [الصلاحيات] from roles", "dt0")
        a.GetData("select ur.rolename, r.caption from userroles as ur join roles as r on r.rolename = ur.rolename where username='" & username.Trim.ToLower & "'", "dt1")
        dgvData1.DataSource = a.ds.Tables("dt0")
        'GridView1.Columns(0).Visible = False
        disableGridView(GridView1, New List(Of Integer))

        For Each row As DataRow In a.ds.Tables("dt1").Rows
            definedRoles.Add(New role(row.Item(0).ToString.Trim, row.Item(1).ToString.Trim))
        Next

        Dim i As Int32 = 0
        For i = 0 To GridView1.RowCount - 1
            For Each role As role In definedRoles
                If role.rolecaption.Equals(GridView1.GetDataRow(i).Item(0).ToString) Then
                    GridView1.SelectRow(i)
                End If
            Next
        Next
    End Sub

    Class role
        Sub New(name As String, caption As String)
            rolename = name
            rolecaption = caption
        End Sub
        Public rolename As String
        Public rolecaption As String
    End Class

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        a.Execute("delete from userroles where username ='" & username.Trim.ToLower & "'")
        a.GetData("select rolename, caption from roles", "dt3")
        Dim values As String = String.Empty
        For Each row As Integer In GridView1.GetSelectedRows
            For Each dr As DataRow In a.ds.Tables("dt3").Rows
                If dr.Item(1).ToString.Trim.ToLower.Equals(GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString.Trim.ToLower) Then
                    values = values & "('" & username.Trim.ToLower & "','" & dr.Item(0).ToString & "'),"
                    Exit For
                End If
            Next
        Next
        If Not values.Equals(String.Empty) Then
            values = values.Substring(0, values.Length - 1)
            a.Execute("insert into userroles values " & values)
        End If
        Me.Close()
    End Sub
End Class