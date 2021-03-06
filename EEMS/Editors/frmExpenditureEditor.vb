﻿Imports EEMS.SqlDBHelper
Imports System.Threading
Imports System.Globalization

Public Class frmExpenditureEditor
    Dim out As Boolean = False
    Dim a As New Helper
    Dim keywords As New List(Of String)

    Sub New(out As Boolean)

        InitializeComponent()


        a.ds = New DataSet

        keywords.Clear()
        keywords.Add("قبض")
        keywords.Add("قبض جباية")
        keywords.Add("قبض مباشر")
        keywords.Add("قبض مكسورات")
        keywords.Add("قبض مكسورات جباية")
        keywords.Add("قبض مكسورات مباشر")
        keywords.Add("قبض تأمين")
        keywords.Add("استرداد تأمين")
        keywords.Add("شراء أصناف")
        keywords.Add("شراء محروقات")
        keywords.Add("صيانة")

        Dim keywordstr As String = "''"
        For Each item As String In keywords
            keywordstr = keywordstr & "'" & item & "',"
        Next
        If keywordstr.Trim.Length > 2 Then
            keywordstr = keywordstr.Substring(0, keywordstr.Length - 1)
        End If

        Me.out = out
        If out = False Then
            Me.Text = "اضافة مدخول"
            a.GetData("select distinct title from Expenditure e where e.title not in (" & keywordstr & ") and e.amount>0")
        Else
            a.GetData("select distinct title from Expenditure e where e.title not in (" & keywordstr & ") and e.amount<0")
        End If



       
        For Each r As DataRow In a.ds.Tables(0).Rows
            txttitle.Items.Add(r.Item(0).ToString.Trim)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.Value = Date.Today
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If checkEmpty() Then
            MsgBox("الرجاء التأكد من تعبئة جميع الخانات المطلوبة.")
            Return
        End If
        If Integer.Parse(txtvalue.Text.Trim) <= 0 Then
            MsgBox("الرجاء التأكد من أن قيمة المبلغ اكبر من صفر.")
            Return
        End If

        If Not txttitle.SelectedItem Is Nothing Then
            If keywords.Contains(txttitle.SelectedItem.ToString.Trim) Then
                MsgBox("لا يمكنك استخدام هذا العنوان لأنه يمثّل رمز مفتاح.")
                Return
            End If
        ElseIf Not txttitle.Text Is Nothing Then
            If keywords.Contains(txttitle.Text.ToString.Trim) Then
                MsgBox("لا يمكنك استخدام هذا العنوان لأنه يمثّل رمز مفتاح.")
                Return
            End If
        End If


        If out = False Then
            a.Execute("insert into Expenditure(expdate,title,amount,party,detail) values('" & txtdate.Value & "','" & txttitle.Text.Trim & "'," & txtvalue.Text.Trim & ",'" & txtparty.Text.Trim & "','" & txtdetails.Text.Trim & "')")
        Else
            a.Execute("insert into Expenditure(expdate,title,amount,party,detail) values('" & txtdate.Value & "','" & txttitle.Text.Trim & "',-" & txtvalue.Text.Trim & ",'" & txtparty.Text.Trim & "','" & txtdetails.Text.Trim & "')")
        End If

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Function checkEmpty() As Boolean
        If txtdate.Text.Trim.Length = 0 OrElse txttitle.Text.Trim.Length = 0 OrElse txtvalue.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Ignore

    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalue.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub ExpenditureEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub
End Class
