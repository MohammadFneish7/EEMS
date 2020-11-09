Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCustomExportHandler

    Dim dgvData1 As GridControl
    Dim excludedColumnsIndexes As Integer()
    Dim gridview As GridView
    Dim printAllRows As Boolean = True
    Dim defaultExclusions As Integer() = New Integer() {-1}

    Sub New(dgvData1 As GridControl)
        InitializeComponent()
        init(dgvData1, defaultExclusions)
    End Sub

    Sub New(dgvData1 As GridControl, excludedColumnsIndexes As Integer())
        InitializeComponent()
        init(dgvData1, excludedColumnsIndexes)
    End Sub

    Private Sub init(dgvData1 As GridControl, excludedColumnsIndexes As Integer())
        Me.dgvData1 = dgvData1
        Me.excludedColumnsIndexes = excludedColumnsIndexes
        Me.gridview = CType(dgvData1.MainView, GridView)
        Me.gridview.OptionsPrint.UsePrintStyles = False

        Dim dt As New DataTable
        dt.Columns.Add("حقول الطباعة")

        For i As Integer = 0 To gridview.Columns.Count - 1 Step 1
            gridview.Columns(i).OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False

            If Not excludedColumnsIndexes.Contains(i) Then
                Dim dr As DataRow = dt.NewRow()
                dr.Item(0) = gridview.Columns(i).ToString.Replace("{", "").Replace("}", "").Trim
                dt.Rows.Add(dr)
            End If
        Next
        cmbRowsOption.SelectedIndex = 0

        Me.dgv.DataSource = dt
        Me.gv.SelectAll()
        disableGridView(gv, New List(Of Integer))
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            If gv.SelectedRowsCount = 0 Then
                MsgBox("الرجاء إختيار حقول للتصدير")
                Return
            End If

            If printAllRows Then
                If gridview.RowCount = 0 Then
                    MsgBox("لا يوجد أي سطر للتصدير")
                    Return
                End If
                gridview.OptionsPrint.PrintSelectedRowsOnly = False
            Else
                If gridview.SelectedRowsCount = 0 Then
                    MsgBox("لا يوجد أي سطر محدد للتصدير")
                    Return
                End If
                gridview.OptionsPrint.PrintSelectedRowsOnly = True
            End If

            Dim found As Boolean = False
            For i As Integer = 0 To gridview.Columns.Count - 1 Step 1
                found = False
                For Each row As Integer In gv.GetSelectedRows
                    If gridview.Columns(i).ToString.Replace("{", "").Replace("}", "").ToLower.Trim.Equals(gv.GetRowCellValue(row, gv.Columns(0)).ToString.Trim.ToLower) Then
                        gridview.Columns(i).OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True
                        found = True
                        Exit For
                    End If
                Next
                If Not found Then
                    gridview.Columns(i).OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False
                End If
            Next
            If ExcelExporter.ExportXtraGridToXlsx(gridview) Then
                Me.DialogResult =DialogResult.OK
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

    End Sub

    Private Sub cmbRowsOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRowsOption.SelectedIndexChanged
        If cmbRowsOption.SelectedIndex = 0 Then
            printAllRows = True
        Else
            printAllRows = False
        End If
    End Sub
End Class