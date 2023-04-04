Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmDataViewer

    Dim table As DataTable
    Dim lastIsTotal As Boolean

    Sub New(title As String, dt As DataTable, lastIsTotal As Boolean)
        Me.lastIsTotal = lastIsTotal
        ' This call is required by the designer.
        InitializeComponent()
        table = dt
        Try
            Me.Text = title
            Label1.Text = title
            dgvData1.DataSource = dt
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
            Me.Close()
        End Try

        ' Add any initialization after the InitializeComponent() call.
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

        For Each GridColumn As GridColumn In GridView1.Columns
            If GridColumn.ColumnType.ToString.Contains("Int") Then
                GridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridColumn.DisplayFormat.FormatString = "n0"
            ElseIf GridColumn.ColumnType.ToString.Contains("Decimal") Then
                GridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridColumn.DisplayFormat.FormatString = "#,##0.##"
            End If
        Next

    End Sub

    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        Dim frmexport As New frmCustomExportHandler(dgvData1)
        frmexport.ShowDialog()
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

    Private Sub GridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Try
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            If lastIsTotal And GridView1.GetDataSourceRowIndex(e.RowHandle) = GridView1.RowCount - 1 AndAlso GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(0)) <> Nothing AndAlso GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(0)).Equals("إجمالي") Then
                e.Appearance.FontStyleDelta = FontStyle.Bold
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class