Imports EEMS.SqlDBHelper

Public Class frmCurrentPayments

    Dim a As New Helper
    Dim paymentbs As New BindingSource
    Private Sub frmCurrentPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        a.ds = New DataSet
        'a.GetData("SELECT DISTINCT Convert(varchar(24),pdate,113) as [تواريخ الدفعات] FROM Payment", "dt1")
        a.GetData("SELECT DISTINCT pdate as [تواريخ الدفعات] FROM Payment ORDER BY pdate DESC", "dt1")
        dgvData1.DataSource = a.ds.Tables("dt1")
        GridView1.Columns(0).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        GridView1.Columns(0).DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"

        a.GetData("SELECT r.ID as [المعرّف],ch.ID as [معرّف القيمة],r.active as مفعّل,en.ename as [الموتور],b.code as [رمز العلبة],b.location as [عنوان العلبة],c.clientname as [المشترك],p.ampere as [أمبير],ec.code as [الرمز في العلبة],cl.fullname as [الجابي],(ar.caption + '-' +  CAST(ch.cyear as nvarchar(50))) as [شهر],pay.pdate as [تاريخ الدفعة],pay.pvalue as [الدفعة] FROM Registration r,Client c,ElectricBox b,ECounter ec,CounterHistory ch,Package p,Engine en,Collector cl,ArabicMonth ar,Payment pay WHERE r.packageid = p.ID and ch.cmonth=ar.ID and r.counterid = ec.ID and ec.boxid = b.ID and r.clientid = c.ID and ch.regid = r.ID and b.engineid=en.ID and b.collectorid=cl.ID and pay.counterhistoryid=ch.ID", "dt2")
        paymentbs.DataSource = a.ds.Tables("dt2")
        DataGridView2.DataSource = paymentbs

        Dim exceptionList As New List(Of Integer)
        disableGridView(GridView1, exceptionList)

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = DataGridView2.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(DataGridView2, True, Nothing)
        End If
    End Sub


    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        Try
            Dim ee As New ExcelExporter
            Dim dt As New DataTable
            a.ds.Tables("dt2").DefaultView.RowFilter = paymentbs.Filter
            dt = a.ds.Tables("dt2").DefaultView.ToTable
            If ee.ExportDataToExcell(dt) Then
                MsgBox("تمت عمليّة التصدير بنجاح")
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            'MsgBox(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(0)).GetType().FullName)
            paymentbs.Filter = "[تاريخ الدفعة] = '" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(0)) & "'"
        Catch ex As Exception

        End Try
    End Sub
End Class