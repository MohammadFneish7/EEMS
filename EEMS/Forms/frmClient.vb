﻿Imports EEMS.SqlDBHelper
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class frmClient

    Public a As New Helper
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()

        addButtonToGridView(dgvData1, GridView1, "كشف عام", My.Resources.chart, 0, 70, AddressOf buttonReportPressed)
        addButtonToGridView(dgvData1, GridView1, "تعديل", My.Resources.Pencil16, 0, 50, AddressOf buttonEditPressed)
        Dim exceptionList As New List(Of Integer)
        exceptionList.Add(0)
        exceptionList.Add(1)
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
        Dim frm As New frmClientEditor(0, True)
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = Windows.Forms.DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT c.ID as [معرّف المشترك],c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي] FROM Client c")
        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = -1
        Dim undoIfError As Boolean = False
        Try
            Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr = Windows.Forms.DialogResult.Yes Then
                Dim listToRemove As Integer() = GridView1.GetSelectedRows
                For Each row As Integer In listToRemove
                    a.Execute("DELETE FROM Client Where ID=" & GridView1.GetRowCellValue(row, GridView1.Columns(2)).ToString)
                Next

                GridView1.DeleteSelectedRows()
            End If
        Catch ex As Exception
            MsgBox("لا يمكنك حذف هذه الاسطر حسث ان هناك معلومات تفصيليّة مهمّة مرتبطة بها." & vbNewLine & "يجب ازالة كل البيانات المرتبطة بهذه الاسطر واعادة المحاولة.")
            loadData()
        End Try
    End Sub

    Private Sub Client_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub buttonEditPressed(sender As Object, e As ButtonPressedEventArgs)
        If GridView1.GetSelectedRows.Count > 0 Then
            Dim frm As New frmClientEditor(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2)), False)
            Dim dr As DialogResult = frm.ShowDialog()
            If dr = Windows.Forms.DialogResult.OK Then
                loadData()
            End If
        End If
    End Sub

    Private Sub buttonReportPressed(sender As Object, e As ButtonPressedEventArgs)
        If GridView1.GetSelectedRows.Count > 0 Then
            Dim frm As New frmClientReport(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(3)))
            Dim dr As DialogResult = frm.ShowDialog
            If dr = Windows.Forms.DialogResult.OK Then
                loadData()
            End If
        End If
    End Sub

    Private Sub btnShowPrint_Click(sender As Object, e As EventArgs) Handles btnShowPrint.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Try
            Dim customPrinter As New frmCustomPrinterHandler(Me.Text.Trim, dgvData1, New Integer() {0, 1})
            customPrinter.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        If index = 2 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub

    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frmexport As New frmCustomExportHandler(dgvData1, New Integer() {0, 1})
        frmexport.ShowDialog()
    End Sub
End Class