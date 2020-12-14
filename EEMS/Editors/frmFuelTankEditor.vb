Imports EEMS.SqlDBHelper

Public Class frmFuelTankEditor

    Dim Tankid As Integer = -2
    Dim add As Boolean = False
    Dim a As New Helper

    Sub New(id As Integer, add As Boolean)
        InitializeComponent()
        Me.add = add
        Tankid = id
        If add = False Then
            If id < 0 Then
                MsgBox("خطأ في رقم الخزّان.")
                Me.DialogResult = DialogResult.Ignore
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
            Dim countfound As Long = a.ExecuteScalar("select count(*) from FuelTank where tankname='" & txtname.Text.Trim & "' and ID<>" & Tankid)
            If countfound > 0 Then
                MsgBox("اسم الخزّان موجود اصلاً الرجاء اختيار اسم جديد للمتابعة.")
                Return
            End If
            a.Execute("Update FuelTank Set tankname='" & txtname.Text.Trim & "',location='" & txtLocation.Text.Trim & "',capacity=" & txtCapacity.Text.Trim & ",notes='" & txtNotes.Text.Trim & "' Where ID=" & Tankid)
        Else
            Dim countfound As Long = a.ExecuteScalar("select count(*) from FuelTank where tankname='" & txtname.Text.Trim & "'")
            If countfound > 0 Then
                MsgBox("اسم الخزّان موجود اصلاً الرجاء اختيار اسم جديد للمتابعة.")
                Return
            End If
            Dim cid As Integer = a.Execute("insert into FuelTank(tankname,location,capacity,notes) values('" & txtname.Text.Trim & "','" & txtLocation.Text.Trim & "'," & txtCapacity.Text.Trim & ",'" & txtNotes.Text.Trim & "')")
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("SELECT tankName as [اسم الخزّان],location as [الموقع],capacity as [السعة],notes as [ملاحظات] FROM FuelTank WHERE ID=" & Tankid)
            txtname.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            txtLocation.Text = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtCapacity.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtNotes.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult = DialogResult.Ignore
        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txtname.Text.Trim.Length = 0 OrElse Integer.Parse(txtCapacity.Text.Trim) < 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Ignore
    End Sub

    Private Sub txtmothername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacity.KeyPress
        a.bindNumeric(sender, e)
    End Sub
End Class
