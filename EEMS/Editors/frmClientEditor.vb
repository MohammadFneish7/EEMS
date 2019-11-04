Imports EEMS.SqlDBHelper

Public Class frmClientEditor

    Dim clientid As Integer = -2
    Dim add As Boolean = False
    Dim a As New Helper

    Sub New(cid As Integer, add As Boolean)
        InitializeComponent()
        Me.add = add
        clientid = cid
        If add = False Then
            If cid < 0 Then
                MsgBox("خطأ في رقم المشترك.")
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
            a.Execute("Update Client Set clientname='" & txtname.Text.Trim & "',clientnickname='" & txtnickname.Text.Trim & "',clientmothername='" & txtmothername.Text.Trim & "',caddress='" & txtaddress.Text.Trim & "',phone='" & txtphone.Text.Trim & "',mobile='" & txtmobile.Text.Trim & "' Where ID=" & clientid)
        Else
            Dim count As Integer = a.ExecuteScalar("Select count(*) from Client e where e.clientname='" & txtname.Text.Trim & "'")
            If count > 0 Then
                MsgBox("اسم المشترك موجود أصلا، الرجاء إختيار اسم أخر للمتابعة")
                Return
            End If
            Dim cid As Integer = a.Execute("insert into Client(clientname,clientnickname,clientmothername,caddress,phone,mobile) values('" & txtname.Text.Trim & "','" & txtnickname.Text.Trim & "','" & txtmothername.Text.Trim & "','" & txtaddress.Text.Trim & "','" & txtphone.Text.Trim & "','" & txtmobile.Text.Trim & "')")
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("SELECT c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي] FROM Client c WHERE c.ID=" & clientid)
            txtname.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            txtnickname.Text = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtmothername.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtaddress.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            txtphone.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
            txtmobile.Text = a.ds.Tables(0).Rows(0).Item(5).ToString
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txtname.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
    End Sub

End Class
