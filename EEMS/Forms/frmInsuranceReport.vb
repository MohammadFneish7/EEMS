Imports EEMS.SqlDBHelper

Public Class frmInsuranceReport
    Dim a As New Helper
    Dim bs1, bs2 As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        a.ds = New DataSet
        a.GetData("select convert(varchar(50),p.ampere) as [امبير],count(p.ampere) as [عدد],sum(r.insurance) as [قيمة] from Package p join Registration r on r.packageid = p.ID  where r.insurance<>0  group by p.ampere  union select 'اجمالي',count(p.ampere),sum(r.insurance) from Package p join Registration r on r.packageid = p.ID where r.insurance<>0", "dt1")
        a.GetData("select convert(varchar(50),p.ampere) as [امبير],count(p.ampere) as [عدد],sum(p.insurance) as [قيمة] from Package p join Registration r on r.packageid = p.ID  where r.active=1 and r.insurance=0 group by p.ampere union select 'اجمالي',count(p.ampere),sum(p.insurance) from Package p join Registration r on r.packageid = p.ID  where r.active=1 and r.insurance=0", "dt2")
        bs1.DataSource = a.ds.Tables("dt1")
        bs2.DataSource = a.ds.Tables("dt2")
        dgv1.DataSource = bs1
        dgv2.DataSource = bs2

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgv1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgv1, True, Nothing)
        End If


        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgv2.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgv2, True, Nothing)
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
            a.ds.Tables(0).DefaultView.RowFilter = bs1.Filter
            dt = a.ds.Tables(0).DefaultView.ToTable
            If ee.ExportDataToExcell(dt) Then
                MsgBox("تمت عمليّة التصدير بنجاح")
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            Dim ee As New ExcelExporter
            Dim dt As New Data.DataTable
            a.ds.Tables(0).DefaultView.RowFilter = bs2.Filter
            dt = a.ds.Tables(0).DefaultView.ToTable
            If ee.ExportDataToExcell(dt) Then
                MsgBox("تمت عمليّة التصدير بنجاح")
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub
End Class