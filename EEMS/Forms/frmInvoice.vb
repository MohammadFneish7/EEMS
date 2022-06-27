Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel
Imports EEMS.SqlDBHelper
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid


Public Class frmInvoice

    Dim inTime As Date
    Dim a As New Helper
    Dim month As Integer = Date.Today.Month
    Dim year As Integer = Date.Today.Year
    Dim disabledCellStyle, enabledCellStyle As New DataGridViewCellStyle
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        loadData()

        Try
            GridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            GridView1.Columns(0).SummaryItem.DisplayFormat = "{0} أسطر"
        Catch ex As Exception
        End Try

        addButtonToGridView(dgvData1, GridView1, "اضافة دفعة", My.Resources.payment, 0, 50, AddressOf btnPayPressed)
        Dim exceptionList As New List(Of Integer)
        exceptionList.Add(0)
        disableGridView(GridView1, exceptionList)

        inTime = Date.Now

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        month = DateTimePicker1.Value.Month
        year = DateTimePicker1.Value.Year
        loadData()
    End Sub

    Private Sub loadData()
        Try
            calculateStats()
            a.ds = New DataSet
            a.GetData(getInvoiceQuery(month, year, False), "dti")
            bs.DataSource = a.ds.Tables(0)
            dgvData1.DataSource = bs

        Catch ex As Exception
            MessageBox.Show("فشل اثناء محاولة تحميل البيانات." & vbNewLine & ex.Message, "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub calculateStats()
        Try
            Dim soldkilo As Integer = a.ExecuteScalar("SELECT IsNull(SUM((Cast(ch.currentvalue AS BIGINT)-Cast(ch.previousvalue AS BIGINT))),0) As exp1 FROM Registration r,CounterHistory ch WHERE ch.regid = r.ID and ch.cmonth =" & month & " and ch.cyear=" & year)
            Dim kiloprofit As Integer = a.ExecuteScalar("SELECT IsNull(SUM(((Cast(ch.currentvalue AS BIGINT)-Cast(ch.previousvalue AS BIGINT))*Cast(ch.kilowattprice AS BIGINT))+Cast(roundvalue AS BIGINT)),0) As exp1 FROM Registration r,CounterHistory ch WHERE ch.regid = r.ID and ch.cmonth =" & month & " and ch.cyear=" & year)
            Dim fees As Integer = a.ExecuteScalar("SELECT IsNull(sum(Cast(ch.monthlyfee AS BIGINT)),0) As exp1 FROM Registration r,CounterHistory ch WHERE ch.regid = r.ID and ch.cmonth =" & month & " and ch.cyear=" & year)
            Dim workinghours As Integer = a.ExecuteScalar("SELECT IsNull(MAX(workinghours),0) FROM EngineWorkingHours WHERE cmonth =" & month & " and cyear=" & year)
            lblsoldKilo.Text = soldkilo.ToString("N0")
            lblkilopayments.Text = kiloprofit.ToString("N0")
            lblfees.Text = fees.ToString("N0")
            lblWorkingHours.Text = workinghours.ToString("N0")
        Catch ex As Exception
            lblsoldKilo.Text = 0
            lblkilopayments.Text = 0
            lblfees.Text = 0
            lblWorkingHours.Text = 0
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.Year >= Date.Today.Year And DateTimePicker1.Value.Month > Date.Today.Month Then
            MsgBox("لا يمكنك تعديل بيانات تاريخ في المستقبل.")
            DateTimePicker1.Value = Date.Today
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

    Private Sub btnInvoicesReportPressed(sender As Object, e As EventArgs) Handles btnInvoicesReport.Click
        If Not currentUser.hasPermision("invoicesprint") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If GridView1.GetSelectedRows.Count > 0 Then
            Dim frmInvoicenote As New frmInvoiceNote
            If frmInvoicenote.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                month = DateTimePicker1.Value.Month
                year = DateTimePicker1.Value.Year
                Dim ar As New Helper
                ar.ds = New DataSet
                ar.GetData(getInvoiceQueryForReport(True, GridView1, month, year, True, frmInvoicenote.chkOrderByCust.Checked, frmInvoicenote.chkCreditByCust.Checked), "dt")
                Dim frm As New XtraReportViewer(ar.ds.Tables("dt"), frmInvoicenote.TextBox1.Text.Trim, frmInvoicenote.verbose)
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnPayPressed(sender As Object, e As ButtonPressedEventArgs)
        If Not currentUser.hasPermision("addpayment") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If GridView1.GetSelectedRows.Count > 0 Then
            Dim frm As New frmPaymentEditor(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2)), inTime, GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(8)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(6)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(1)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(15)))
            Dim dr As DialogResult = frm.ShowDialog
            If dr = System.Windows.Forms.DialogResult.OK Then
                Dim amount As Integer = frm.payedAmmount
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(23), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(23)) + amount)
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(24), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(24)) - amount)
                'Dim payed As Integer = frm.payedAmmount
                'For Each row As DataRow In a.ds.Tables("dti").Rows
                '    If row.Item(0).ToString.Equals(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(1))) Then
                '        row.Item(23) = Integer.Parse(row.Item(23)) + payed
                '        row.Item(24) = Integer.Parse(row.Item(24)) + payed
                '        GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(23), Integer.Parse(row.Item(23)) + payed)
                '        GridView1.SetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(24), Integer.Parse(row.Item(24)) + payed)
                '        Exit For
                '    End If
                'Next
                'loadData()
            End If
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmCurrentPayments
        frm.ShowDialog()
    End Sub

    Private Sub Invoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub dgvData_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Clicks <> 2 Then
            Return
        End If

        If Not currentUser.hasPermision("counterhistoryedit") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim LastInsertDate As Integer() = getLastCounterHistoryInsertDate(Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(1)).ToString))
        If DateTimePicker1.Value.Year < LastInsertDate(0) Or (DateTimePicker1.Value.Year = LastInsertDate(0) And DateTimePicker1.Value.Month < LastInsertDate(1)) Then
            MsgBox("لا يمكنك تعديل قيمة العداد لهذا الشهر لأنه تم ادخال عداد الشهر الذي يليه.")
            Return
        End If
        If GridView1.Columns.IndexOf(e.Column) < 0 OrElse e.RowHandle < 0 Then
            Return
        End If
        Dim CounterHistoryEditDialog As New frmCounterHistoryEditDialog(Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(11))), Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(12))))
        Dim dr As DialogResult = CounterHistoryEditDialog.ShowDialog
        If dr = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim oldVal As Integer = Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(11)))
                Dim newVal As Integer = CounterHistoryEditDialog.txtNew.Text.Trim
                Dim kwPice As Integer = Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(19)))
                Dim fee As Integer = Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(17)))
                Dim round As Integer = getRoundThousand(((newVal - oldVal) * kwPice) + fee)
                a.ExecuteNoReturn("update CounterHistory set currentvalue=" & newVal & ", roundvalue=" & round & " where ID=" & Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2))))
                a.ExecuteNoReturn("update ECounter set currentvalue=" & newVal & " where id in (select ec.id from ECounter ec join Registration r on r.counterid = ec.id where r.id=" & Integer.Parse(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(1))) & " and r.active=1)")
                loadData()
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
            Dim customPrinter As New frmCustomPrinterHandler(Me.Text.Trim, dgvData1, New Integer() {0})
            customPrinter.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub


    Public Function getInvoiceQuery(m As Int16, y As Int16, withCredits As Boolean, Optional forReport As Boolean = False) As String
        Dim d As New Date(y, m, 1)
        d = d.AddMonths(1)

        Dim whereInSelected As String = String.Empty
        If forReport Then
            whereInSelected = " AND r.ID in ("
            For Each row As Integer In GridView1.GetSelectedRows
                whereInSelected = whereInSelected & Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(1)).ToString) & ","
            Next
            If whereInSelected.Equals(" AND r.ID in (") Then
                whereInSelected = String.Empty
            Else
                whereInSelected = whereInSelected.Substring(0, whereInSelected.Length - 1) & ") "
            End If
        End If

        Dim q1 As String = "SELECT r.ID AS [المعرّف], " &
                            "ch.ID AS [معرّف القيمة], " &
                            " r.active AS مفعّل, en.ename AS [الموتور], " &
                            " b.location AS [عنوان العلبة], " &
                            " c.clientname AS [المشترك], " &
                            " p.title AS [أمبير], " &
                            " cl.fullname AS [الجابي], " &
                            " b.code AS [رمز العلبة], " &
                            " ec.code AS [الرمز في العلبة]," &
                            " ch.previousvalue AS [القيمة السابقة KW], " &
                            " ch.currentvalue AS [القيمة الحاليّة KW], " &
                            " r.insurance AS [تأمين ل.ل], "

        Dim q2 As String = " (SELECT " &
                            "(SELECT SUM(total) FROM CounterHistory coh WHERE coh.regid = r.ID " &
                            " AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & "))) " &
                            " - " &
                            " (SELECT ISNULL(SUM(pyy.pvalue),  0) " &
                            " FROM CounterHistory coh JOIN Payment pyy on pyy.counterhistoryid = coh.ID WHERE coh.regid = r.ID " &
                            " AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & "))) " &
                            " ) AS [مكسورات ل.ل], "

        'Dim q2 As String = " (SELECT SUM(total) - ISNULL(SUM(pyy.pvalue),  0) FROM CounterHistory coh LEFT OUTER JOIN Payment pyy on pyy.counterhistoryid = coh.ID" & _
        '                    " WHERE coh.regid = r.ID AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & "))) AS [مكسورات], "

        Dim q3 As String = " ch.notes AS [ملاحظات], ar.caption  + '-' + CAST(ch.cyear AS nvarchar(10))  AS [شهر], " &
                            " (b.code + ec.code) AS [رمز مفتاح], " &
                            " ch.monthlyfee AS [رسم اشتراك ل.ل], " &
                            " (ch.currentvalue-ch.previousvalue) AS [فرق عداد KW], " &
                            " ch.kilowattprice AS [سعر الكيلو ل.ل], " &
                            " (((ch.currentvalue - ch.previousvalue) * ch.kilowattprice) + roundvalue) AS [مطلوب كيلو ل.ل], " &
                            " total + discount AS [المجموع ل.ل], " &
                            " discount AS [حسم ل.ل], " &
                            " ISNULL(SUM(pyy.pvalue), 0)  AS [مدفوع ل.ل], " &
                            " total - ISNULL(SUM(pyy.pvalue), 0) AS [باقي ل.ل] " &
                        " FROM Registration r" &
                            " INNER JOIN Client c on r.clientid = c.ID" &
                            " INNER JOIN Package p on r.packageid = p.ID" &
                            " INNER JOIN (CounterHistory ch INNER JOIN ArabicMonth ar on ch.cmonth = ar.id LEFT OUTER JOIN Payment pyy on pyy.counterhistoryid = ch.ID) on r.ID = ch.regid " &
                            " INNER JOIN (ECounter ec INNER JOIN (ElectricBox b INNER JOIN Engine en on b.engineid = en.ID INNER JOIN Collector cl on b.collectorid = cl.ID) on ec.boxid = b.ID) on r.counterid = ec.ID" &
                        " WHERE  ch.cmonth = " & m & " and ch.cyear= " & y & " AND r.registrationdate < '" & d.ToShortDateString & "' " & whereInSelected &
                        " GROUP BY r.ID, ch.ID, r.active, en.ename, b.location, c.clientname, p.title, cl.fullname, b.code, ec.code, ch.previousvalue, " &
                                " ch.currentvalue, r.insurance, ch.notes, ar.caption, ch.cyear, ch.monthlyfee, ch.kilowattprice, ch.roundvalue, ch.total, ch.discount" &
                        " ORDER BY cl.fullname, b.code, ec.code"
        If withCredits Then
            Return q1 + q2 + q3
        Else
            Return q1 + q3
        End If

    End Function

    Public Shared Function getInvoiceQueryForReport(selectedOnly As Boolean, GridView1 As GridView, m As Int16, y As Int16, withCredits As Boolean, Optional ByVal orderByCust As Boolean = False, Optional ByVal creditsByCust As Boolean = False) As String
        Dim d As New Date(y, m, 1)
        d = d.AddMonths(1)


        Dim whereInSelected As String = String.Empty

        If selectedOnly Then
            whereInSelected = " AND r.ID in ("

            For Each row As Integer In GridView1.GetSelectedRows
                whereInSelected = whereInSelected & Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(1)).ToString) & ","
            Next
            If whereInSelected.Equals(" AND r.ID in (") Then
                whereInSelected = String.Empty
            Else
                whereInSelected = whereInSelected.Substring(0, whereInSelected.Length - 1) & ") "
            End If
        End If


        Dim q1 As String = "SELECT r.ID AS [المعرّف], " &
                            "ch.ID AS [معرّف القيمة], " &
                            " r.active AS مفعّل, en.ename AS [الموتور], " &
                            " b.code AS [رمز العلبة], " &
                            " b.location AS [عنوان العلبة], " &
                            " c.clientname AS [المشترك], " &
                            " c.mobile AS [رقم الهاتف], " &
                            " p.title AS [أمبير], " &
                            " ec.code AS [الرمز في العلبة]," &
                            " cl.fullname AS [الجابي], " &
                            " ch.previousvalue AS [القيمة السابقة], " &
                            " ch.currentvalue AS [القيمة الحاليّة], " &
                            " r.insurance AS [تأمين], "

        Dim q2 As String = " (SELECT " &
                           "(SELECT SUM(total) FROM CounterHistory coh WHERE coh.regid = r.ID " &
                           " AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & "))) " &
                           " - " &
                           " (SELECT ISNULL(SUM(pyy.pvalue),  0) " &
                           " FROM CounterHistory coh JOIN Payment pyy on pyy.counterhistoryid = coh.ID WHERE coh.regid = r.ID " &
                           " AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & "))) " &
                           " ) AS [مكسورات], "

        If creditsByCust Then
            q2 = "(Select (SELECT ISNULL(SUM(coh.total),  0) FROM Client cli Join Registration reg on reg.clientid=cli.id Join CounterHistory coh on coh.regid = reg.ID Where cli.id=c.id AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & "))) - (SELECT ISNULL(SUM(pay.pvalue),  0) FROM Client cli Join Registration reg on reg.clientid=cli.id Join CounterHistory coh on coh.regid = reg.ID JOIN Payment pay on pay.counterhistoryid = coh.ID Where cli.id=c.id AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & ")))) AS [مكسورات],"
            'q2 = " (SELECT " &
            '    " (SELECT ISNULL(SUM(coh.total),  0)-ISNULL(SUM(pay.pvalue),  0) FROM Client cli Join Registration reg on reg.clientid=cli.id Join CounterHistory coh on coh.regid = reg.ID " &
            '               " LEFT OUTER JOIN Payment pay on pay.counterhistoryid = coh.ID Where cli.id=c.id AND (coh.cyear < " & y & " OR (coh.cmonth < " & m & " and coh.cyear = " & y & "))) " &
            '               " ) AS [مكسورات], "
        End If

        Dim q3 As String = " ch.notes AS [ملاحظات], ar.caption  + '-' + CAST(ch.cyear AS nvarchar(10))  AS [شهر], " &
                            " (b.code + ec.code) AS [رمز مفتاح], " &
                            " ch.monthlyfee AS [رسم اشتراك], " &
                            " (ch.currentvalue-ch.previousvalue) AS [فرق عداد], " &
                            " ch.kilowattprice AS [سعر الكيلو], " &
                            " (((ch.currentvalue - ch.previousvalue) * ch.kilowattprice) + roundvalue) AS [مطلوب كيلو], " &
                            " total AS [المجموع], " &
                            " discount AS [حسم], " &
                            " ISNULL(SUM(pyy.pvalue), 0)  AS [مدفوع], " &
                            " total - ISNULL(SUM(pyy.pvalue), 0) AS [باقي], " &
                            " ec.serial AS [سيريال العداد], " &
                            " ch.dollarPrice AS [سعر الصرف], " &
                            " Format(ch.totaldollar,'N2') AS [مجموع دولار] " &
                        " FROM Registration r" &
                            " INNER JOIN Client c on r.clientid = c.ID" &
                            " INNER JOIN Package p on r.packageid = p.ID" &
                            " INNER JOIN (CounterHistory ch INNER JOIN ArabicMonth ar on ch.cmonth = ar.id LEFT OUTER JOIN Payment pyy on pyy.counterhistoryid = ch.ID) on r.ID = ch.regid " &
                            " INNER JOIN (ECounter ec INNER JOIN (ElectricBox b INNER JOIN Engine en on b.engineid = en.ID INNER JOIN Collector cl on b.collectorid = cl.ID) on ec.boxid = b.ID) on r.counterid = ec.ID" &
                        " WHERE  ch.cmonth = " & m & " and ch.cyear= " & y & " AND r.registrationdate < '" & d.ToShortDateString & "' " & whereInSelected &
                        " GROUP BY r.ID, ch.ID, c.id, r.active, en.ename, b.location, c.clientname, c.mobile, p.title, cl.fullname, b.code, ec.code, ch.previousvalue, " &
                                " ch.currentvalue, r.insurance, ch.notes, ar.caption, ch.cyear, ch.monthlyfee, ch.kilowattprice, ch.roundvalue, ch.total, ch.discount, ec.serial, ch.dollarPrice,ch.totaldollar"
        If orderByCust Then
            q3 += " ORDER BY c.clientname"
        Else
            q3 += " ORDER BY cl.fullname, b.code, ec.code"
        End If
        If withCredits Then
            Return q1 + q2 + q3
        Else
            Return q1 + q3
        End If

    End Function

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {7, 11, 12, 13, 17, 18, 19, 20, 21, 22, 23, 24}
        If indecies.Contains(index) Then
            'e.DisplayText = e.Value & " ل.ل"
            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            e.Column.DisplayFormat.FormatString = "N0"
        ElseIf index = 1 OrElse index = 2 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isPaymentVerified Then
            GridView1.OptionsSelection.MultiSelect = False
        End If
    End Sub
End Class
