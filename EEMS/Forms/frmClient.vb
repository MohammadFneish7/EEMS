Imports EEMS.SqlDBHelper
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid

Public Class frmClient

    Public a As New Helper
    Dim bs As New BindingSource
    Dim creditedClientIds As New List(Of Integer)

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
        If dr = DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT c.ID as [معرّف المشترك],c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي] FROM Client c")
        a.GetData("select cid
                from (
	                SELECT r.id as rid,c.id as cid, c.clientname as cname, c.phone as cphone, c.mobile as cmobile, IsNull(SUM(total),0) - (SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh left outer JOIN Payment pyy on pyy.counterhistoryid=coh.ID WHERE coh.regid=r.ID) AS totalRem
	                from CounterHistory ch join Registration r  on ch.regid = r.id join Client c on r.clientid=c.ID
	                group by r.ID,c.id, r.insurance,c.clientname, c.phone, c.mobile
                ) as innertable 
                group by innertable.cid, cname,cphone,cmobile
                having Sum(totalRem)>0", "dt_creditedClients")

        creditedClientIds = New List(Of Integer)
        For Each r As DataRow In a.ds.Tables("dt_creditedClients").Rows
            creditedClientIds.Add(Integer.Parse(r.Item(0)))
        Next

        a.ds.Tables(0).Columns.Add("مديون؟", True.GetType())

        For Each r As DataRow In a.ds.Tables(0).Rows
            r.Item(a.ds.Tables(0).Columns.Count - 1) = creditedClientIds.Contains(Integer.Parse(r.Item(0)))
        Next
        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = -1
        Dim undoIfError As Boolean = False
        Try
            Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr = DialogResult.Yes Then
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
            If dr = DialogResult.OK Then
                loadData()
            End If
        End If
    End Sub

    Private Sub buttonReportPressed(sender As Object, e As ButtonPressedEventArgs)
        If GridView1.GetSelectedRows.Count > 0 Then
            Dim frm As New frmClientReport(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(3)))
            Dim dr As DialogResult = frm.ShowDialog
            If dr = DialogResult.OK Then
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

    Private Sub GridView1_RowCellStyle(sender As Object, e As Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If e.RowHandle >= 0 Then
            If GridView1.IsRowSelected(e.RowHandle) Then
                e.Appearance.BackColor = Color.FromArgb(245, 245, 245)
            Else
                If creditedClientIds.Contains(Integer.Parse(GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(2)))) Then
                    e.Appearance.BackColor = Color.FromArgb(255, 200, 200)
                End If
            End If
        End If
    End Sub
End Class
