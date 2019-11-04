Imports EEMS.SqlDBHelper

Public Class frmItemEditor

    Dim Itemid As Integer = -2
    Dim add As Boolean = False
    Dim a As New Helper

    Sub New(id As Integer, add As Boolean)
        InitializeComponent()
        Me.add = add
        Itemid = id
        If add = False Then
            If id < 0 Then
                MsgBox("خطأ في رقم الصنف.")
                Me.DialogResult = Windows.Forms.DialogResult.Ignore
            End If
        End If
    End Sub

    Private Sub ClientEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If add = False Then
            loadData()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If checkEmpty() Then
            MsgBox("الرجاء التأكد من تعبئة جميع الخانات المطلوبة.")
            Return
        End If
        a.ds = New DataSet
        If add = False Then
            Dim countfound As Int32 = a.ExecuteScalar("select count(*) from Items where itemname='" & txtname.Text.Trim & "' and ID<>" & Itemid)
            If countfound > 0 Then
                MsgBox("اسم الصنف موجود اصلاً الرجاء اختيار اسم جديد للمتابعة.")
                Return
            End If
            a.Execute("Update Items Set itemname='" & txtname.Text.Trim & "',unit='" & cmbUnit.SelectedItem.ToString.Trim & "',quantityThreshold=" & txtThreshold.Text.Trim & ",properties='" & txtProperties.Text.Trim & "',notes='" & txtNotes.Text.Trim & "' Where ID=" & Itemid)
        Else
            Dim countfound As Int32 = a.ExecuteScalar("select count(*) from Items where itemname='" & txtname.Text.Trim & "'")
            If countfound > 0 Then
                MsgBox("اسم الصنف موجود اصلاً الرجاء اختيار اسم جديد للمتابعة.")
                Return
            End If
            Dim cid As Integer = a.Execute("insert into Items(itemname,unit,quantityThreshold,properties,notes) values('" & txtname.Text.Trim & "','" & cmbUnit.SelectedItem.ToString.Trim & "'," & txtThreshold.Text.Trim & ",'" & txtProperties.Text.Trim & "','" & txtNotes.Text.Trim & "')")
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("SELECT [itemname] as [اسم الصنف],[unit] as [وحدة القياس],[quantityThreshold] as [عتبة الكمّيّة],[properties] as [خصائص],[notes] as [ملاحظات] FROM Items WHERE ID=" & Itemid)
            txtname.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            cmbUnit.SelectedItem = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtThreshold.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtProperties.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            txtNotes.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txtname.Text.Trim.Length = 0 OrElse cmbUnit.SelectedIndex = -1 OrElse txtThreshold.Text.Trim.Length = 0 OrElse Integer.Parse(txtThreshold.Text.Trim) < 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
    End Sub

    Private Sub txtmothername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtThreshold.KeyPress
        a.bindNumeric(sender, e)
    End Sub
End Class
