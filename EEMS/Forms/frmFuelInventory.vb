Imports EEMS.SqlDBHelper
Imports DevExpress.XtraEditors.Controls

Public Class frmFuelInventory

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTanks.Click
        If Not currentUser.hasPermision("FuelTanksManagement") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmFuelTanks
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT ft.ID as [المعرف],tankName as [اسم الخزّان],location as [الموقع],capacity as [السعة], " & _
                    " ((SELECT isnull(sum(fp.quantity),0) from fuelpurchases fp where fp.tankid = ft.id) " & _
                    " - (SELECT isnull(sum(fc.quantity),0) from  fuelconsumption fc where fc.tankid = ft.id)) as [باقي في الخزّان / لتر], " & _
                    "  ft.Notes as [ملاحظات] FROM FuelTank ft ")
        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs
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

    Private Sub btnPurchases_Click(sender As Object, e As EventArgs) Handles btnPurchases.Click
        If Not currentUser.hasPermision("FuelPurchaseManagement") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmFuelPurchase
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub btnConsumptions_Click(sender As Object, e As EventArgs) Handles btnConsumptions.Click
        If Not currentUser.hasPermision("FuelConsumeManagement") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmFuelConsumption
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {3, 4}
        If indecies.Contains(index) Then
            'e.DisplayText = e.Value & " ل.ل"

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
