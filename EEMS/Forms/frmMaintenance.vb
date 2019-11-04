Imports EEMS.SqlDBHelper
Imports DevExpress.XtraEditors.Controls

Public Class frmMaintenance

    Dim a As New Helper
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()

        Dim exceptionList As New List(Of Integer)
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
        Dim frm As New frmMaintenanceEditor
        Dim dr As DialogResult = frm.ShowDialog
        If dr = Windows.Forms.DialogResult.OK Then
            loadData()
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT m.ID as [المعرّف],m.indate as [التاريخ],m.mainaction as [نوع العمل],e.ename as [اسم المولّد],m.actiondetails as [تفصيل العمل],m.bycontract as [عبر عقد صيانة],m.pricetotal as [تكلفة العمل ل.ل],m.partyname as [الجهة],m.partyPhone as [هاتف الجهة],m.notes as [ملاحظات] FROM Maintenance m join Engine e on m.engineid = e.id")
        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If Not currentUser.hasPermision("deleteMaintenance") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr = Windows.Forms.DialogResult.Yes Then
                Dim todeleteIds As String = "("
                Dim todeleteIdsstr As String = "('"
                For Each row As Integer In GridView1.GetSelectedRows
                    todeleteIds = todeleteIds & GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString & ","
                    todeleteIdsstr = todeleteIdsstr & "mc" & GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString & "','"
                Next
                If todeleteIds.Length > 1 Then
                    todeleteIds = todeleteIds.Remove(todeleteIds.Length - 1, 1)
                    todeleteIdsstr = todeleteIdsstr.Remove(todeleteIdsstr.Length - 2, 2)
                    todeleteIds = todeleteIds & ")"
                    todeleteIdsstr = todeleteIdsstr & ")"
                    a.Execute("DELETE FROM Maintenance Where ID in " & todeleteIds)
                    a.Execute("DELETE FROM Expenditure Where paymentRef in " & todeleteIdsstr)
                End If

                GridView1.DeleteSelectedRows()
            End If
        Catch ex As Exception
            MsgBox("لا يمكنك حذف هذه الاسطر حسث ان هناك معلومات تفصيليّة مهمّة مرتبطة بها." & vbNewLine & "يجب ازالة كل البيانات المرتبطة بهذه الاسطر واعادة المحاولة.")
        End Try
    End Sub

    Private Sub Engine_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            Dim customPrinter As New frmCustomPrinterHandler(Me.Text.Trim, dgvData1, New Integer() {-1})
            customPrinter.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {6}
        If indecies.Contains(index) Then
            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            e.Column.DisplayFormat.FormatString = "N0"
        ElseIf index = 0 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
End Class
