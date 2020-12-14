Imports EEMS.SqlDBHelper

Public Class frmCollectorEditor
    Dim id As Integer = -2
    Dim add As Boolean = False
    Dim a As New Helper
    Sub New(id As Integer, Optional add As Boolean = False)
        InitializeComponent()
        Me.id = id
        Me.add = add
        If add = False Then
            If id < 0 Then
                MsgBox("خطأ في رقم الملف.")
                Me.DialogResult = DialogResult.Ignore
            End If
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
        If add = False Then
            a.Execute("Update Collector Set fullname='" & txtname.Text.Trim & "',caddress='" & txtaddress.Text.Trim & "',phone='" & txtphone.Text.Trim & "',mobile='" & txtmobile.Text.Trim & "',notes='" & txtnotes.Text.Trim & "' Where ID=" & id)
        Else
            Dim count As Long = a.ExecuteScalar("Select count(*) from Collector e where e.fullname='" & txtname.Text.Trim & "'")
            If count > 0 Then
                MsgBox("اسم الجابي موجود أصلا، الرجاء إختيار اسم أخر للمتابعة")
                Return
            End If
            a.Execute("insert into Collector(fullname,caddress,phone,mobile,notes) values('" & txtname.Text.Trim & "','" & txtaddress.Text.Trim & "','" & txtphone.Text.Trim & "','" & txtmobile.Text.Trim & "','" & txtnotes.Text.Trim & "')")
        End If

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("Select fullname as الاسم,caddress as العنوان,phone as الهاتف,mobile as الخليوي,notes as ملاحظات FROM Collector where ID = " & id)
            txtname.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            txtaddress.Text = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtphone.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtmobile.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            txtnotes.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult = DialogResult.Ignore

        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txtname.Text.Trim.Length = 0 OrElse txtaddress.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Ignore

    End Sub

    Private Sub CollectorEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub
End Class
