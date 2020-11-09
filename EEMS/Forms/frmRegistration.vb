Imports EEMS.SqlDBHelper
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Public Class frmRegistration

    Dim a As New Helper
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()

        addButtonToGridView(dgvData1, GridView1, "تعديل", My.Resources.Pencil16, 0, 50, AddressOf buttonReportPressed)
        Dim exceptionList As New List(Of Integer)
        exceptionList.Add(0)

        Try
            GridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            GridView1.Columns(0).SummaryItem.DisplayFormat = "{0} أسطر"
        Catch ex As Exception
        End Try

        disableGridView(GridView1, exceptionList)
        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New frmRegistrationEditor(0, 0, True)
        Dim dr As DialogResult = frm.ShowDialog()
        If dr =DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT r.ID as [معرّف الاشتراك],r.clientid as [معرّف المشترك],r.active as مفعّل,c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي],registrationdate as [تاريخ الاشتراك],enddate as [تاريخ انهاء الاشتراك],p.ampere as [أمبير],b.code as [رمز العلبة],b.location as [عنوان العلبة],ec.serial as[رمز العدّاد],ec.code as [الرمز في العلبة],r.insurance as [تأمين],r.notes AS [ملاحظات] FROM Registration r,Client c,ElectricBox b,ECounter ec,Package p WHERE r.packageid = p.ID and r.counterid = ec.ID and ec.boxid = b.ID and r.clientid = c.ID order By r.active")
        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs
    End Sub

    Private Sub buttonReportPressed(sender As Object, e As ButtonPressedEventArgs)
        If GridView1.GetSelectedRows.Count > 0 Then
            Dim frm As New frmRegistrationEditor(GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(1)), GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(2)), False)
            Dim dr As DialogResult = frm.ShowDialog
            If dr =DialogResult.OK Then
                loadData()
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = -1
        Dim undoIfError As Boolean = False
        Dim queries As New List(Of String)
        Try
            Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr =DialogResult.Yes Then
                Dim listToRemove As Integer() = GridView1.GetSelectedRows
                For Each row As Integer In listToRemove
                    undoIfError = False
                    id = Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(1)).ToString)
                    If Boolean.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(3)).ToString) = True Then
                        queries.Add("update ECounter set active = 0 where ID in (Select counterid from Registration where ID =" & id & ")")
                        undoIfError = True
                    End If
                    If a.ExecuteScalar("select max(cyear) from counterhistory where regid=" & id) = 2000 Then
                        queries.Add("DELETE FROM counterhistory where regid=" & id)
                    End If
                    queries.Add("DELETE FROM Registration Where ID=" & id)
                Next
                If a.ExecuteInTransaction(queries) Then
                    GridView1.DeleteSelectedRows()
                Else
                    MsgBox("لا يمكنك حذف هذه الاسطر حسث ان هناك معلومات تفصيليّة مهمّة مرتبطة بها." & vbNewLine & "يجب ازالة كل البيانات المرتبطة بهذه الاسطر واعادة المحاولة.")
                End If

            End If
        Catch ex As Exception
            'If undoIfError Then
            '    a.Execute("update ECounter set active = 1 where ID in (Select counterid from Registration where ID =" & id & ")")
            'End If
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            Dim customPrinter As New frmCustomPrinterHandler(Me.Text.Trim, dgvData1, New Integer() {0})
            customPrinter.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {12, 17}
        If indecies.Contains(index) Then
            'e.DisplayText = e.Value & " ل.ل"

            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            e.Column.DisplayFormat.FormatString = "N0"
        ElseIf index = 1 OrElse index = 2 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
End Class
