﻿Imports EEMS.SqlDBHelper
Imports System.Threading
Imports System.Globalization

Public Class frmFuelConsumption

    Dim a As New Helper
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim fromDate As Date = New Date(Date.Today.Year, Date.Today.Month, 1)
        Dim toDate As Date = New Date(Date.Today.Year, Date.Today.Month, System.DateTime.DaysInMonth(Date.Today.Year, Date.Today.Month))
        dtp1.Value = fromDate
        dtp2.Value = toDate

        loadData()

        Dim exceptionList As New List(Of Integer)
        disableGridView(GridView1, exceptionList)

        Try
            GridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            GridView1.Columns(0).SummaryItem.DisplayFormat = "{0} أسطر"
        Catch ex As Exception
        End Try

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New frmFuelConsumptionEditor
        Dim dr As DialogResult = frm.ShowDialog
        If dr =DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        If chkSelectAll.Checked Then
            a.GetData("SELECT fc.ID as [المعرف],outdate as [تاريخ الاستهلاك],tankname as [اسم الخزّان],quantity as [الكمّية],detioration as [للتلف؟],ename as [اسم المحرّك],partyname as [الجهة],partyPhone as [هاتف الجهة],fc.notes as [ملاحظات] FROM FuelConsumption fc join FuelTank ft on fc.tankid = ft.id join Engine e on fc.engineid = e.id  ORDER BY outdate DESC")
        Else
            a.GetData("SELECT fc.ID as [المعرف],outdate as [تاريخ الاستهلاك],tankname as [اسم الخزّان],quantity as [الكمّية],detioration as [للتلف؟],ename as [اسم المحرّك],partyname as [الجهة],partyPhone as [هاتف الجهة],fc.notes as [ملاحظات] FROM FuelConsumption fc join FuelTank ft on fc.tankid = ft.id join Engine e on fc.engineid = e.id  where outdate >='" & dtp1.Value.ToShortDateString & "' and outdate <='" & dtp2.Value.ToShortDateString & "' ORDER BY outdate DESC")
        End If

        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs
        GridView1.Columns(1).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        GridView1.Columns(1).DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr =DialogResult.Yes Then
                Dim todeleteIds As String = "("
                For Each row As Integer In GridView1.GetSelectedRows
                    todeleteIds = todeleteIds & GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString & ","
                Next
                If todeleteIds.Length > 1 Then
                    todeleteIds = todeleteIds.Remove(todeleteIds.Length - 1, 1)
                    todeleteIds = todeleteIds & ")"
                    a.Execute("DELETE FROM FuelConsumption Where ID in " & todeleteIds)
                End If

                GridView1.DeleteSelectedRows()
            End If
        Catch ex As Exception
            MsgBox("لا يمكنك حذف هذه الاسطر حسث ان هناك معلومات تفصيليّة مهمّة مرتبطة بها." & vbNewLine & "يجب ازالة كل البيانات المرتبطة بهذه الاسطر واعادة المحاولة.")
        End Try
    End Sub

    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frmexport As New frmCustomExportHandler(dgvData1)
        frmexport.ShowDialog()
    End Sub

    Private Sub Consumption_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub


    Private Sub btnShowPrint_Click(sender As Object, e As EventArgs) Handles btnShowPrint.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Try
            Dim customPrinter As New frmCustomPrinterHandler(Me.Text.Trim, dgvData1, New Integer() {-1})
            customPrinter.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If chkSelectAll.Checked = False Then
            If dtp2.Value.CompareTo(dtp1.Value) = -1 Then
                MsgBox("يجب ان يكون التاريخ الثاني أكبر أو يساوي التاريخ الأوّل.")
                Return
            End If
        End If

        loadData()
    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked Then
            dtp1.Enabled = False
            dtp2.Enabled = False
            Label2.Enabled = False
            Label4.Enabled = False
        Else
            dtp1.Enabled = True
            dtp2.Enabled = True
            Label2.Enabled = True
            Label4.Enabled = True
        End If
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {3}
        If indecies.Contains(index) Then
            'e.DisplayText = e.Value & " ل.ل"

            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            e.Column.DisplayFormat.FormatString = "N0"
        ElseIf index = 0 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub
End Class
