Imports EEMS.SqlDBHelper

Public Class frmEngineWorkingHours

    Dim month As Integer = Date.Today.Month
    Dim year As Integer = Date.Today.Year
    Dim a As New Helper
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()
        Dim disabledCellStyle, enabledCellStyle As New DataGridViewCellStyle
        disabledCellStyle.BackColor = Color.LightGray
        enabledCellStyle.BackColor = Color.FromArgb(192, 255, 192)

        For Each col As DataGridViewColumn In dgvData.Columns
            If dgvData.Columns.IndexOf(col) < 7 Then
                col.ReadOnly = True
                col.DefaultCellStyle = disabledCellStyle
            End If
        Next
        dgvData.Columns(7).DefaultCellStyle = enabledCellStyle

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData, True, Nothing)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        month = DateTimePicker1.Value.Month
        year = DateTimePicker1.Value.Year
        loadData()
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT e.ID as المعرّف,ename as الاسم,location as العنوان,epower as القوّة,company as [الماركة/الشركة],contactphone as الهاتف,repairparty as [جهة الصيانة],workinghours as [ساعات العمل],w.notes as ملاحظات  FROM Engine e,EngineWorkingHours w WHERE w.engineid = e.id and w.cmonth =" & month & " and w.cyear=" & year & _
                              " UNION SELECT e.ID as المعرّف,ename as الاسم,location as العنوان,epower as القوّة,company as [الماركة/الشركة],contactphone as الهاتف,repairparty as [جهة الصيانة],'0' as [ساعات العمل], '' as ملاحظات  FROM Engine e where e.ID NOT IN " & _
                              "(SELECT e.ID  FROM Engine e,EngineWorkingHours w WHERE w.engineid = e.id and w.cmonth =" & month & " and w.cyear=" & year & ")")
        bs.DataSource = a.ds.Tables(0)
        dgvData.DataSource = bs
    End Sub

    Private Sub dgvData_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvData.CellValidating
        If e.ColumnIndex = 7 Then
            If Not IsNumeric(e.FormattedValue) Then
                MsgBox("الرجاء ادخال رقم صحيح.")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        For Each row As DataGridViewRow In dgvData.Rows
            If Not IsNumeric(row.Cells(7).Value.ToString.Trim) Then
                MsgBox("الرجاء ادخال رقم صحيح في جميع خانات ساعات العمل.")
                Return
            End If
        Next
        For Each row As DataGridViewRow In dgvData.Rows
            Try
                a.Execute("Insert into EngineWorkingHours(engineid,cmonth,cyear,workinghours,notes) VALUES(" & row.Cells(0).Value.ToString & "," & month & "," & year & "," & row.Cells(7).Value.ToString & ",'" & row.Cells(8).Value.ToString & "')")
            Catch ex As Exception
                a.Execute("UPDATE EngineWorkingHours SET workinghours = " & row.Cells(7).Value.ToString & ",notes = '" & row.Cells(8).Value.ToString & "' WHERE engineid = " & row.Cells(0).Value.ToString & " and cmonth = " & month & " and cyear = " & year)
            End Try
        Next
        MsgBox("تمت العمليّة بنجاح.")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.Year >= Date.Today.Year And DateTimePicker1.Value.Month > Date.Today.Month Then
            MsgBox("لا يمكنك تعديل بيانات تاريخ في المستقبل.")
            DateTimePicker1.Value = Date.Today
        End If
    End Sub

    Private Sub EngineWorkingHours_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
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
        Try
            Dim ee As New ExcelExporter
            Dim dt As New Data.DataTable
            a.ds.Tables(0).DefaultView.RowFilter = bs.Filter
            dt = a.ds.Tables(0).DefaultView.ToTable
            If ee.ExportDataToExcell(dt) Then
                MsgBox("تمت عمليّة التصدير بنجاح")
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub
End Class
