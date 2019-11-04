Public Class frmUsersManagement

    Dim a As New SqlDBHelper.Helper
    Dim bs As New BindingSource
    Dim cryptMaker As New CryptoSys

    Private Sub frmUsersManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Public Sub loaddata()
        a.ds = New DataSet
        a.GetData("select username as [اسم المستخدم], pass [بصمة كلمة المرور] from users where username<>'admin'", "dt1")
        bs.DataSource = a.ds.Tables("dt1")
        DataGridView1.DataSource = bs
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ml As New frmGeneralPerposeInput("اختر اسم للمستخدم", "الاسم")
        Dim ended As Boolean = False
        While Not ended
            Dim d As DialogResult = ml.ShowDialog()
            If d = Windows.Forms.DialogResult.OK Then
                If ml.PasswordTextBox.Text.Trim.Length > 4 Then
                    Dim found As Int16 = a.ExecuteScalar("select count(*) from users where username='" & ml.PasswordTextBox.Text.Trim.ToLower & "'")
                    If found > 0 Then
                        MsgBox("اسم المستخدم موجود اساساً الرجاء اختيار اسم اخر.")
                    Else
                        a.Execute("INSERT INTO Users VALUES ('" & ml.PasswordTextBox.Text.Trim.ToLower & "','" & cryptMaker.GetHash("123456789") & "')")
                        MsgBox("تم اضافة المستخدم بنجاح.")
                        loaddata()
                        ended = True
                    End If
                Else
                    MsgBox("يجب ان يكون اسم المستخدم اطول من 4 خانات.")
                End If
            Else
                ended = True
            End If
        End While
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim d As DialogResult = MessageBox.Show("هل انت متأكد من حذف المستخدم؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If d = Windows.Forms.DialogResult.Yes Then
                a.Execute("delete from userroles where username='" & DataGridView1.SelectedRows(0).Cells(0).Value.ToString.Trim.ToLower & "'")
                a.Execute("delete from notes where username='" & DataGridView1.SelectedRows(0).Cells(0).Value.ToString.Trim.ToLower & "'")
                a.Execute("delete from users where username='" & DataGridView1.SelectedRows(0).Cells(0).Value.ToString.Trim.ToLower & "'")
                MsgBox("تمت العمليّة بنجاح.")
                loaddata()
            End If
        Else
            MsgBox("اختر مستخدم من الجدول أوّلاً.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim d As DialogResult = MessageBox.Show("هل انت متأكد من تصفير كلمة المرور؟" & vbNewLine & "كلمة المرور عند التصفير: 123456789", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If d = Windows.Forms.DialogResult.Yes Then
                a.Execute("update users set pass='" & cryptMaker.GetHash("123456789") & "' where username='" & DataGridView1.SelectedRows(0).Cells(0).Value.ToString.Trim.ToLower & "'")
                MsgBox("تمت العمليّة بنجاح.")
                loaddata()
            End If
        Else
            MsgBox("اختر مستخدم من الجدول أوّلاً.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim frm As New frmEditPermissions(DataGridView1.SelectedRows(0).Cells(0).Value.ToString.Trim.ToLower)
            frm.ShowDialog()
        Else
            MsgBox("اختر مستخدم من الجدول أوّلاً.")
        End If
    End Sub
End Class