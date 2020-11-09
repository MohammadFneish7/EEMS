Imports EEMS.SqlDBHelper

Public Class frmPackageEditor

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
                Me.DialogResult =DialogResult.Ignore
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
        'If Not a.isDouble(txtampere.Text) Then
        '    MsgBox("قيمة الأمبير غير صحيحة")
        '    Return
        'End If
        If add = False Then
            a.Execute("Update Package Set title='" & txttitle.Text.Trim & "', ampere=" & txtampere.Text.Trim & ",fee=" & txtfee.Text.Trim & ",insurance=" & txtinsurance.Text.Trim & ",kilowattprice=" & txtkiloprice.Text.Trim & ",notes='" & txtnotes.Text.Trim & "' Where ID=" & id)
        Else
            Dim count As Integer = a.ExecuteScalar("Select count(*) from Package e where e.title='" & txttitle.Text.Trim & "'")
            If count > 0 Then
                MsgBox("عنوان الاشتراك موجود أصلا، الرجاء إختيار عنوان أخر للمتابعة")
                Return
            End If
            a.Execute("insert into Package(title,ampere,fee,insurance,kilowattprice,notes) values('" & txttitle.Text.Trim & "'," & txtampere.Text.Trim & "," & txtfee.Text.Trim & "," & txtinsurance.Text.Trim & "," & txtkiloprice.Text.Trim & ",'" & txtnotes.Text.Trim & "')")
        End If

        Me.DialogResult =DialogResult.OK

    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("SELECT title, ampere as امبير,fee as [اشتراك شهري],insurance as [مبلغ التأمين],kilowattprice as [سعر الكيلو وات],notes as ملاحظات FROM Package where ID =" & id)
            txttitle.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            txtampere.Text = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtfee.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtinsurance.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            txtkiloprice.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
            txtnotes.Text = a.ds.Tables(0).Rows(0).Item(5).ToString
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult =DialogResult.Ignore

        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txttitle.Text.Trim.Length = 0 OrElse txtampere.Text.Trim.Length = 0 OrElse txtfee.Text.Trim.Length = 0 OrElse txtinsurance.Text.Trim.Length = 0 OrElse txtkiloprice.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult =DialogResult.Ignore
    End Sub


    Private Sub txtname_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtinsurance.KeyPress, txtkiloprice.KeyPress, txtfee.KeyPress, txtampere.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub PackageEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub
End Class
