Imports EEMS.SqlDBHelper
Imports System.Threading
Imports System.Globalization
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmExpenditure

    Dim a As New Helper
    Dim bs As New BindingSource
    Dim gridFormatRule As New GridFormatRule()

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
            GridView1.Columns(4).MaxWidth = 50
        Catch ex As Exception
        End Try

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If

        createGridFormatRule()


    End Sub

    Private Sub createGridFormatRule()

        Dim formatConditionRuleIconSet As New FormatConditionRuleIconSet()
        formatConditionRuleIconSet.IconSet = New FormatConditionIconSet()
        Dim iconSet As FormatConditionIconSet = formatConditionRuleIconSet.IconSet
        Dim icon1 As New FormatConditionIconSetIcon()
        Dim icon2 As New FormatConditionIconSetIcon()

        'Choose predefined icons.
        icon1.PredefinedName = "Arrows3_1.png"
        icon2.PredefinedName = "Arrows3_3.png"

        'Specify the type of threshold values.
        iconSet.ValueType = FormatConditionValueType.Number

        'Define ranges to which icons are applied by setting threshold values.
        icon1.Value = 0 ' target range: 67% <= value
        icon1.ValueComparison = FormatConditionComparisonType.GreaterOrEqual
        icon2.Value = -100000000000000000 ' target range: 33% <= value < 67%
        icon2.ValueComparison = FormatConditionComparisonType.GreaterOrEqual

        'Add icons to the icon set.
        iconSet.Icons.Add(icon1)
        iconSet.Icons.Add(icon2)

        'Specify the rule type.
        gridFormatRule.Rule = formatConditionRuleIconSet

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New frmExpenditureEditor(True)
        Dim dr As DialogResult = frm.ShowDialog
        If dr = DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        If chkSelectAll.Checked Then
            a.GetData("Select ID as المعرّف,expdate as [التاريخ],title as العنوان,IIF(currency=0, amount, amount_dollar) as [القيمة],IIF(currency=0, 'ل.ل', '$') as [العُملة],party as الجهة,detail as تفصيل,paymentRef as [مرجعيّة فاتورة] FROM Expenditure ORDER BY expdate DESC")
        Else
            a.GetData("Select ID as المعرّف,expdate as [التاريخ],title as العنوان,IIF(currency=0, amount, amount_dollar) as [القيمة],IIF(currency=0, 'ل.ل', '$') as [العُملة],party as الجهة,detail as تفصيل,paymentRef as [مرجعيّة فاتورة] FROM Expenditure e where e.expdate >='" & dtp1.Value.ToShortDateString & "' and e.expdate <='" & dtp2.Value.ToShortDateString & "' ORDER BY expdate DESC")
        End If

        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs

        'Specify the column to which formatting is applied.
        gridFormatRule.Column = GridView1.Columns(3)
        'Add the formatting rule to the GridView.
        GridView1.FormatRules.Add(gridFormatRule)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmExpenditureEditor(False)
        Dim dr As DialogResult = frm.ShowDialog
        If dr = DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim CompanyRepor As New frmCompanyReport
        CompanyRepor.ShowDialog()
    End Sub

    Private Sub btnExchange_Click(sender As Object, e As EventArgs) Handles btnExchange.Click
        Dim frm As New frmExchange()
        Dim dr As DialogResult = frm.ShowDialog
        If dr = DialogResult.OK Then
            loadData()
        End If
    End Sub


    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frmexport As New frmCustomExportHandler(dgvData1)
        frmexport.ShowDialog()
    End Sub

    Private Sub Expenditure_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub


    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = 46 Then
            Dim tok As New frmTokenizer(SharedModule.currentUser.getUsername())
            If tok.ShowDialog = DialogResult.OK Then
                If Not tok.tokenAccepted Then
                    Return
                End If
            Else
                Return
            End If

            Try
                Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dr = DialogResult.Yes Then
                    Dim todeleteIds As String = "("
                    For Each row As Integer In GridView1.GetSelectedRows
                        todeleteIds = todeleteIds & GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString & ","
                    Next
                    If todeleteIds.Length > 1 Then
                        todeleteIds = todeleteIds.Remove(todeleteIds.Length - 1, 1)
                        todeleteIds = todeleteIds & ")"
                        a.Execute("DELETE FROM Expenditure Where ID in " & todeleteIds)
                    End If

                    GridView1.DeleteSelectedRows()
                End If
            Catch ex As Exception
                MsgBox("لا يمكنك حذف هذه الاسطر حسث ان هناك معلومات تفصيليّة مهمّة مرتبطة بها." & vbNewLine & "يجب ازالة كل البيانات المرتبطة بهذه الاسطر واعادة المحاولة.")
            End Try

        End If
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Dim sum As Long = 0
        Dim sum_dollar As Decimal = 0
        For Each row As Integer In GridView1.GetSelectedRows
            If GridView1.GetRowCellValue(row, GridView1.Columns(4)).ToString() = "$" Then
                sum_dollar = sum_dollar + Decimal.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(3)).ToString)
            Else
                sum = sum + Decimal.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(3)).ToString)
            End If
        Next
        Dim count As Integer = GridView1.GetSelectedRows.Count
        lblCount.Text = count.ToString("N0")
        lblSum.Text = sum.ToString("N0") & " ل.ل / " & sum_dollar.ToString("#,##0.##") & " $"
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
        If index = 3 Then
            'e.DisplayText = e.Value & " ل.ل"
            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            e.Column.DisplayFormat.FormatString = "#,##0.##"
        ElseIf index = 0 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If e.RowHandle >= 0 Then
            If GridView1.IsRowSelected(e.RowHandle) Then
                e.Appearance.BackColor = Color.FromArgb(245, 245, 245)
            Else
                If e.Column.AbsoluteIndex = 4 Then
                    If GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(4)) = "$" Then
                        e.Appearance.BackColor = Color.LightGreen
                    Else
                        e.Appearance.BackColor = Color.FromArgb(140, 245, 255)
                    End If
                Else
                    If GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(3)) < 0 Then
                        e.Appearance.BackColor = Color.FromArgb(255, 192, 192)
                    Else
                        e.Appearance.BackColor = Color.FromArgb(192, 255, 192)
                    End If
                End If
            End If
        End If



    End Sub
End Class
