Imports EEMS.SqlDBHelper

Public Class frmPackage

    Dim a As New Helper
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()
        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData, True, Nothing)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New frmPackageEditor(0, True)
        Dim dr As DialogResult = frm.ShowDialog
        If dr = Windows.Forms.DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT ID as المعرّف,title as عنوان,ampere as امبير,fee as [اشتراك شهري],insurance as [مبلغ التأمين],kilowattprice as [سعر الكيلو وات],notes as ملاحظات FROM Package")
        bs.DataSource = a.ds.Tables(0)
        dgvData.DataSource = bs
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.ColumnIndex = 0 Then
            If dgvData.SelectedRows.Count > 0 Then
                Dim frm As New frmPackageEditor(dgvData.SelectedRows(0).Cells(1).Value)
                Dim dr As DialogResult = frm.ShowDialog
                If dr = Windows.Forms.DialogResult.OK Then
                    loadData()
                End If
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr = Windows.Forms.DialogResult.Yes Then
                Dim listToRemove As DataGridViewSelectedRowCollection = dgvData.SelectedRows
                For Each row As DataGridViewRow In dgvData.SelectedRows
                    a.Execute("DELETE FROM Package Where ID=" & row.Cells(1).Value.ToString)
                Next
                For Each i As DataGridViewRow In listToRemove
                    dgvData.Rows.Remove(i)
                Next
            End If
        Catch ex As Exception
            MsgBox("لا يمكنك حذف هذه الاسطر حسث ان هناك معلومات تفصيليّة مهمّة مرتبطة بها." & vbNewLine & "يجب ازالة كل البيانات المرتبطة بهذه الاسطر واعادة المحاولة.")
        End Try
    End Sub

    Private Sub dgvData_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvData.CellPainting
        If (e.RowIndex < 0) Then
            Return
        End If

        If (e.ColumnIndex = 0) Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim w As Integer = My.Resources.Pencil16.Width
            Dim h As Integer = My.Resources.Pencil16.Height
            Dim x As Integer = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
            Dim y As Integer = e.CellBounds.Top + (e.CellBounds.Height - h) / 2
            e.Graphics.DrawImage(My.Resources.Pencil16, New Rectangle(x, y, w, h))
            e.Handled = True
        End If
    End Sub

    Private Sub Package_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
