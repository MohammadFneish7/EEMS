Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports EEMS.SqlDBHelper

Public Class frmClientsCreditDetails

    Dim a As New Helper

    Sub New()

        InitializeComponent()

        loadData()

        Try
            GridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            GridView1.Columns(0).SummaryItem.DisplayFormat = "{0} أسطر"
        Catch ex As Exception
        End Try

        addButtonToGridView(dgvData1, GridView1, "إضافة دفعة", My.Resources.payment, 0, 50, AddressOf buttonEditPressed)
        Dim exceptionList As New List(Of Integer)
        exceptionList.Add(0)
        disableGridView(GridView1, exceptionList)

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If

    End Sub

    Public Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT ch.ID as [معرّف القيمة],r.ID as [معرّف الاشتراك],cl.clientname as [إسم المشترك], cl.phone as [هاتف], cl.mobile as [خلوي],(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))) as [شهر],ch.monthlyfee as [رسم اشتراك],(ch.currentvalue-ch.previousvalue) as [فرق عداد],ch.kilowattprice as [سعر الكيلو],((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue as [مطلوب كيلو],total+discount as [المجموع],ch.discount as [حسم],total as [مطلوب], ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [مدفوع], total-ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [باقي] " &
            " FROM (CounterHistory ch left join Payment p on p.counterhistoryid=ch.ID) join Registration r on ch.regid = r.ID join ArabicMonth ar on ch.cmonth=ar.ID join Client cl on cl.id=r.clientid" &
            " group by ch.ID,r.ID,cl.clientname, cl.phone, cl.mobile,(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))),ch.monthlyfee,(ch.currentvalue-ch.previousvalue),ch.kilowattprice,((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue,total+discount,ch.discount,ch.total having (total-ISNULL(sum(Cast(p.pvalue AS BIGINT)),0))>0 order by r.ID,cl.clientname", "dt2")
        dgvData1.DataSource = a.ds.Tables("dt2")


        For Each GridColumn As GridColumn In GridView1.Columns
            If GridColumn.ColumnType.ToString.Contains("Int") Then
                GridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridColumn.DisplayFormat.FormatString = "n0"
            End If
        Next
    End Sub

    Private Sub buttonEditPressed(sender As Object, e As EventArgs)
        If Not currentUser.hasPermision("addpayment") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If GridView1.GetSelectedRows.Count > 0 Then
            Try
                Try
                    a.ds.Tables("dt6").Clear()
                Catch ex As Exception

                End Try

                a.GetData("Select fullname from collector c, Registration r, ElectricBox b,Ecounter ec where c.id=b.collectorid and b.id=ec.boxid and r.counterid=ec.id and r.id=" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2)), "dt6")
                Dim frm As New frmPaymentEditor(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(1)), Date.Now, a.ds.Tables("dt6").Rows(0).Item(0).ToString.Trim, GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(3)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(4)))
                Dim dr As DialogResult = frm.ShowDialog
                If dr = System.Windows.Forms.DialogResult.OK Then
                    Dim amount As Integer = frm.payedAmmount
                    GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(12), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(12)) + amount)
                    GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(13), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(13)) - amount)
                    'loadData()
                End If
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try

        End If
    End Sub

    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frmexport As New frmCustomExportHandler(dgvData1, New Integer() {0})
        frmexport.ShowDialog()
    End Sub

    Private Sub btnShowPrint_Click(sender As Object, e As EventArgs) Handles btnShowPrint.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Try
            Dim customPrinter As New frmCustomPrinterHandler(Me.Text.Trim, dgvData1, New Integer() {0})
            customPrinter.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub


End Class