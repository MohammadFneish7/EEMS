Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel
Imports EEMS.SqlDBHelper
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Runtime.InteropServices

Public Class frmCounterHistory

    Dim a As New Helper
    Dim month As Integer = Date.Today.Month
    Dim year As Integer = Date.Today.Year
    Dim bs As New BindingSource
    Dim edited As Boolean = False
    Dim allowMoveToNextRow As Boolean = True
    Dim dicAvgs As Dictionary(Of Int32, Int32)
    Dim errorRowsRegIds As New List(Of Integer)
    Dim gva As New GridViewAppearances(GridView1)

    Declare Function GetWindowThreadProcessId Lib "user32.dll" (hWnd As Integer, ByRef lpdwProcessId As Integer) As Long

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'loadData()

        'Try
        '    GridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        '    GridView1.Columns(0).SummaryItem.DisplayFormat = "{0} أسطر"
        'Catch ex As Exception
        'End Try
        dicAvgs = getClientExpenditureAverages()

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvData1.Enabled = True
        month = DateTimePicker1.Value.Month
        year = DateTimePicker1.Value.Year
        loadData(Nothing)
    End Sub

    Private Sub loadData(sender As Object, Optional ByVal supressWarn As Boolean = False)
        errorRowsRegIds.Clear()
        Try
            GridView1.ShowLoadingPanel()

            If sender Is Nothing And Not supressWarn Then
                Dim prevMonth As Date = DateTimePicker1.Value.AddMonths(-1)
                Dim countRemainingRecordsInPastMonths As Integer = a.ExecuteScalar("SELECT Count(r.ID)" &
                            " FROM Registration r JOIN Client c ON r.clientid = c.ID" &
                            "	JOIN ECounter ec ON r.counterid = ec.ID JOIN ElectricBox b ON ec.boxid=b.id JOIN Engine en ON b.engineid=en.id" &
                            "	JOIN Collector cl ON b.collectorid=cl.id JOIN Package p ON r.packageid=p.id left outer JOIN CounterHistory ch ON r.counterid=ch.id" &
                            " WHERE (DatePart(yyyy, r.registrationdate) < " & year & " Or (DatePart(m, r.registrationdate) <= " & month & " And DatePart(yyyy, r.registrationdate) = " & month & "))" &
                            " and r.active=1 and r.ID not in (Select regID from CounterHistory where cyear > " & prevMonth.Year & " OR (cmonth >= " & prevMonth.Month & " and cyear = " & prevMonth.Year & "))")

                If countRemainingRecordsInPastMonths > 0 Then
                    Dim frmMsgDialog As New CustomMsgDialog("انتبه", "يجب اتمام ادخال " & countRemainingRecordsInPastMonths & " عداد عن شهر " & getArabicMonth(prevMonth.Month) & " للمتابعة" & vbNewLine & "هل تريد المتابعة رغم ذلك؟")
                    If frmMsgDialog.ShowDialog() <> System.Windows.Forms.DialogResult.Yes Then
                        Return
                    End If

                End If
            End If

            GridView1.Columns.Clear()

            Dim activeConstraint As String = " and r.active = 1 "
            If chkShowNonActive.Checked Then
                activeConstraint = String.Empty
            End If

            dgvData1.DataSource = Nothing
            a.ds = New DataSet

            Dim boxQuery As String = If(chkShowBoxID.Checked, "b.ID as [معرّف العلبة]", "b.code as [رمز العلبة]")

            a.GetData("SELECT Distinct r.ID as [المعرّف],r.active as مفعّل,en.ename as [الموتور]," & boxQuery & ",b.location as [عنوان العلبة]," &
                        "	c.clientname as [المشترك],p.title as [أمبير],ec.serial as [رقم العداد],ec.code as [الرمز في العلبة],cl.fullname as [الجابي]," &
                        "	p.fee as [اشتراك شهري],ch.priceRule as [نظام الشطور]," &
                        "	IsNull((Select MAX(chh.currentvalue) From CounterHistory chh Where chh.regid = r.ID),0) AS [القيمة السابقة]," &
                        "   '' as [القيمة الحاليّة],'' as ملاحظات " &
                        " FROM Registration r JOIN Client c ON r.clientid = c.ID" &
                        "	JOIN ECounter ec ON r.counterid = ec.ID JOIN ElectricBox b ON ec.boxid=b.id JOIN Engine en ON b.engineid=en.id" &
                        "	JOIN Collector cl ON b.collectorid=cl.id JOIN Package p ON r.packageid=p.id left outer JOIN CounterHistory ch ON r.counterid=ch.id" &
                        " WHERE (DatePart(yyyy, r.registrationdate) < " & year & " Or (DatePart(m, r.registrationdate) <= " & month & " And DatePart(yyyy, r.registrationdate) = " & year & "))" & activeConstraint &
                        " and r.ID not in (Select regID from CounterHistory where cyear > " & year & " OR (cmonth >= " & month & " and cyear = " & year & "))" &
                        " order by en.ename, " & If(chkShowBoxID.Checked, "b.id", "b.code") & "")

            bs.DataSource = a.ds.Tables(0)
            dgvData1.DataSource = bs

            For Each col As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
                If GridView1.Columns.IndexOf(col) < 13 Then
                    col.OptionsColumn.AllowEdit = False
                Else
                    col.OptionsColumn.AllowEdit = True
                    col.AppearanceCell.BackColor = Color.FromArgb(192, 255, 192)
                End If
            Next

            Try
                GridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridView1.Columns(0).SummaryItem.DisplayFormat = "{0} أسطر"
            Catch ex As Exception
            End Try

            If GridView1.RowCount > 0 Then
                btnimport.Enabled = True
            Else
                btnimport.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("فشل اثناء محاولة تحميل البيانات." & vbNewLine & ex.Message, "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            GridView1.HideLoadingPanel()
        End Try
    End Sub

    Private Function getClientExpenditureAverages() As Dictionary(Of Int32, Int32)
        Dim dic As New Dictionary(Of Int32, Int32)
        a.ds = New DataSet
        a.GetData(" Select ch.regid, AVG(ch.currentvalue-ch.previousvalue) avrg from CounterHistory ch group by ch.regid", "dtavgs")
        For Each row As DataRow In a.ds.Tables("dtavgs").Rows
            dic.Add(row.Item(0), row.Item(1))
        Next
        Return dic
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        GridView1.ClearColumnsFilter()
        GridView1.ApplyFindFilter("")
        errorRowsRegIds.Clear()
        Dim sqlQueries As New List(Of String)


        Try
            Dim regid As String
            Dim prevVal As String
            Dim curVal As String
            Dim avgval As Integer
            Dim countErrors As Integer = 0
            Dim hasData As Boolean = False

            For i As Int32 = 0 To GridView1.RowCount - 1
                regid = GridView1.GetRowCellValue(i, GridView1.Columns(0)).ToString
                prevVal = GridView1.GetRowCellValue(i, GridView1.Columns(12)).ToString
                curVal = GridView1.GetRowCellValue(i, GridView1.Columns(13)).ToString
                If Not dicAvgs.TryGetValue(regid, avgval) Then
                    avgval = 300
                End If
                'If avgval = 0 Then
                '    avgval = 300
                'End If
                If curVal.ToString.Trim.Length > 0 Then
                    hasData = True
                    If Integer.Parse(curVal.ToString.Trim) > 0 Then
                        If (curVal - prevVal) >= avgval + 50 Then
                            countErrors = countErrors + 1
                            errorRowsRegIds.Add(regid)
                        End If
                    End If
                End If
            Next
            If Not hasData Then
                Return
            End If
            If countErrors > 0 Then
                Dim msgdialog As New CustomMsgDialog("انتبه", "هنالك " & countErrors & " قيمة تفوق معدّل الصرف الطبيعي لأصحابها." & vbNewLine & "هل تريد المتاربع رغم ذلك؟", 5)
                If msgdialog.ShowDialog <> System.Windows.Forms.DialogResult.Yes Then
                    GridView1.LayoutChanged()
                    Return
                End If
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
            Return
        End Try


        Try
            Dim regid As String
            Dim fee As String
            Dim priceRule As String
            Dim prevVal As String
            Dim curVal As String
            Dim note As String
            For i As Int32 = 0 To GridView1.RowCount - 1
                regid = GridView1.GetRowCellValue(i, GridView1.Columns(0)).ToString
                fee = GridView1.GetRowCellValue(i, GridView1.Columns(10)).ToString
                priceRule = GridView1.GetRowCellValue(i, GridView1.Columns(11)).ToString
                prevVal = GridView1.GetRowCellValue(i, GridView1.Columns(12)).ToString
                curVal = GridView1.GetRowCellValue(i, GridView1.Columns(13)).ToString
                note = GridView1.GetRowCellValue(i, GridView1.Columns(14)).ToString
                If curVal.ToString.Trim.Length > 0 Then
                    If Integer.Parse(curVal.ToString.Trim) > 0 Then
                        If (curVal - prevVal) >= 0 Then
                            Dim totalKilo As Long = SharedModule.getKiloPriceBasedOnPriceRule(curVal - prevVal, priceRule)
                            Dim j As Integer = fee + totalKilo
                            j = getRoundThousand(j)
                            sqlQueries.Add("Insert into CounterHistory(cmonth,cyear,regid,monthlyfee,kilowattprice,previousvalue,currentvalue,notes,roundvalue,priceRule) VALUES(" & month & "," & year & "," & regid.ToString & "," & fee.ToString & "," & totalKilo.ToString & "," & prevVal.ToString & "," & curVal.ToString & ",'" & note.ToString & "'," & j & ",'" & priceRule & "')")
                            sqlQueries.Add("UPDATE ECounter SET currentvalue = " & curVal.ToString & " WHERE ID = (SELECT ec.id FROM ECounter ec JOIN Registration r ON r.counterid = ec.ID WHERE r.ID = " & regid.ToString & ")")
                        End If
                    End If
                End If
            Next

            Dim result As Boolean = a.ExecuteInTransaction(sqlQueries)
            If result = True Then
                edited = False
                loadData(btnsave)
                MsgBox("تمت العمليّة بنجاح.")
            Else
                ErrorDialog.showDlg(New Exception("فشل اثناء محاولة حفظ البيانات." & vbNewLine & "تم الغاء العمليّة." & vbNewLine))
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.Year >= Date.Today.Year And DateTimePicker1.Value.Month > Date.Today.Month Then
            MsgBox("لا يمكنك تعديل بيانات تاريخ في المستقبل.")
            DateTimePicker1.Value = Date.Today
        End If
        'Dim LastInsertDate As Integer() = getLastCounterHistoryInsertDate()
        'If DateTimePicker1.Value.Year < LastInsertDate(0) Or (DateTimePicker1.Value.Year = LastInsertDate(0) And DateTimePicker1.Value.Month < LastInsertDate(1)) Then
        '    MsgBox("لا يمكنك تعديل قيمة العداد لشهر ماضي تم ادخال عداداته.")
        '    Return
        'End If
    End Sub

    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frmexport As New frmCustomExportHandler(dgvData1)
        frmexport.ShowDialog()
    End Sub

    Private Sub CounterHistory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If edited Then
            If MessageBox.Show("تأكد من حفظ البيانات قبل الخروج" & vbNewLine & "هل انت متأكد من المغادرة؟", "EEMS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If

        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        checkCellValue()
    End Sub

    Private Sub checkCellValue()
        allowMoveToNextRow = True

        If GridView1.FocusedColumn.AbsoluteIndex = 13 Then
            Dim editor As TextEdit = CType(GridView1.ActiveEditor, TextEdit)
            Try
                If Not editor Is Nothing Then
                    Dim val As String = editor.EditValue
                    If val.Length > 0 Then
                        If Not IsNumeric(val) Then
                            allowMoveToNextRow = False
                            MsgBox("الرجاء ادخال رقم صحيح.")
                            editor.EditValue = String.Empty
                            'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, Nothing)
                        ElseIf val.ToString.Trim.Length > 0 Then
                            If Integer.Parse(val) < Integer.Parse(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(12)).ToString) Then
                                allowMoveToNextRow = False
                                MsgBox("لا يمكن ان تكون القيمة الحاليّة اصغر من القيمة السابقة.")
                                editor.EditValue = String.Empty
                                'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.FocusedColumn, Nothing)
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                allowMoveToNextRow = False
                editor.EditValue = String.Empty
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        edited = True
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmEmptyCHPrint
        frm.ShowDialog()
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {6, 10, 11, 12, 13}
        If indecies.Contains(index) Then
            'e.DisplayText = e.Value & " ل.ل"

            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            e.Column.DisplayFormat.FormatString = "N0"
        ElseIf index = 1 Or index = 3 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub

    Private Sub dgvData1_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles dgvData1.ProcessGridKey
        If e.KeyCode = Keys.Enter Then
            checkCellValue()
            If allowMoveToNextRow = True Then
                GridView1.FocusedRowHandle = GridView1.FocusedRowHandle + 1
            End If
        End If
    End Sub


    Private Sub GridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Try
            If e.RowHandle >= 0 Then
                If errorRowsRegIds.Contains(GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(0))) Then
                    e.Appearance.BackColor = Color.Pink
                    e.HighPriority = True
                Else
                    e.Appearance.BackColor = gva.Row.BackColor
                    e.HighPriority = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmEmptyCHExport
        frm.ShowDialog()
    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnimport.Click

        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx"
        OpenFileDialog1.Title = "اختر مكان حفظ الملف وإسمه"
        OpenFileDialog1.Multiselect = False

        Dim application As Excel.Application = Nothing
        Dim workbook As Excel.Workbook = Nothing
        Try
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                application = New Excel.Application()
                workbook = application.Workbooks.Open(OpenFileDialog1.FileName)
                Dim worksheet As Excel.Worksheet = workbook.Sheets("CH")

                Dim usedRange = worksheet.UsedRange
                Dim usedRangeAs2DArray As Object(,) = usedRange.Value2

                Dim tempRegID As Integer
                Dim tempDate As DateTime
                Dim tempValue As Integer

                For row As Integer = 2 To usedRangeAs2DArray.GetUpperBound(0)
                    Try
                        tempRegID = usedRangeAs2DArray.GetValue(row, 1)
                        tempDate = DateTime.FromOADate(usedRangeAs2DArray.GetValue(row, 9))
                        tempValue = usedRangeAs2DArray.GetValue(row, 11)
                    Catch ex As Exception
                        Throw New Exception($"فشل في قراءة السطر رقم {row} من ملف الإكسل", ex)
                    End Try

                    If Not (tempDate.Month = DateTimePicker1.Value.Month And tempDate.Year = DateTimePicker1.Value.Year) Then
                        MessageBox.Show($"خطأ: القيم الواردة في ملف الإكسل تتبع لشهر {tempDate.ToString("MM-yyyy")} وليس لشهر {DateTimePicker1.Value.ToString("MM-yyyy")}. سيتم الغاء العمليّة وسحب التعديلات.")
                        loadData(Nothing, True)
                        Return
                    End If
                    For i As Int32 = 0 To GridView1.RowCount - 1
                        Dim gridRegid As Integer = GridView1.GetRowCellValue(i, GridView1.Columns(0))
                        If gridRegid = tempRegID Then
                            If tempValue > 0 Then
                                If GridView1.GetRowCellValue(i, GridView1.Columns(12)) > tempValue Then
                                    MessageBox.Show($"خطأ: قيمة العداد الحاليّة الواردة من ملف الإكسل للإشتراك {gridRegid} أصغر من القيمة السابقة الموجودة في البرنامج. سيتم الغاء العمليّة وسحب التعديلات.")
                                    loadData(Nothing, True)
                                    Return
                                End If
                                GridView1.SetRowCellValue(i, GridView1.Columns(13), tempValue)
                                Exit For
                            End If
                        End If
                    Next
                Next

                MessageBox.Show("تمت العمليّة بنجاح")
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        Finally
            Try
                Dim pid As Integer = -1
                GetWindowThreadProcessId(application.Hwnd, pid)
                'workbook.Close()
                application.Quit()
                Marshal.ReleaseComObject(application)
                If pid > -1 Then
                    Dim aProcess As System.Diagnostics.Process
                    aProcess = System.Diagnostics.Process.GetProcessById(pid)
                    aProcess.Kill()
                End If
            Catch ex As Exception
            End Try
        End Try


    End Sub
End Class
