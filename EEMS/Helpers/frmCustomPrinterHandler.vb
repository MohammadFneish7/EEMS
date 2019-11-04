Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCustomPrinterHandler

    Dim title As String
    Dim dgvData1 As GridControl
    Dim excludedColumnsIndexes As Integer()
    Dim gridview As GridView
    Dim printAllRows As Boolean = True
    Dim printPortrait As Boolean = True

    Sub New(title As String, dgvData1 As GridControl, excludedColumnsIndexes As Integer())
        InitializeComponent()

        Me.title = title
        Me.dgvData1 = dgvData1
        Me.excludedColumnsIndexes = excludedColumnsIndexes
        Me.txtTitle.Text = title.Trim
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
        cmbOrientation.SelectedIndex = 0
        cmbRowsOption.SelectedIndex = 0

        cmbPaperSize.DataSource = [Enum].GetValues(GetType(System.Drawing.Printing.PaperKind))
        cmbPaperSize.SelectedItem = System.Drawing.Printing.PaperKind.A4

        Me.dgv.DataSource = dt
        Me.gv.SelectAll()
        disableGridView(gv, New List(Of Integer))
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            If gv.SelectedRowsCount = 0 Then
                MsgBox("الرجاء إختيار حقول للطباعة")
                Return
            End If

            If txtTitle.Text.Trim.Length = 0 Then
                MsgBox("يجب اختيار عنوان للتقرير للمتابعة")
                Return
            End If

            If printAllRows Then
                If gridview.RowCount = 0 Then
                    MsgBox("لا يوجد أي سطر للطباعة")
                    Return
                End If
                gridview.OptionsPrint.PrintSelectedRowsOnly = False
            Else
                If gridview.SelectedRowsCount = 0 Then
                    MsgBox("لا يوجد أي سطر محدد للطباعة")
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

            Dim customPrinter As New XtraGridCustomPrinter(txtTitle.Text.Trim, dgvData1, Not printPortrait, cmbPaperSize.SelectedItem)
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

    End Sub

    Private Sub cmbOrientation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrientation.SelectedIndexChanged
        If cmbOrientation.SelectedIndex = 0 Then
            printPortrait = True
        Else
            printPortrait = False
        End If
    End Sub

    Private Sub cmbRowsOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRowsOption.SelectedIndexChanged
        If cmbRowsOption.SelectedIndex = 0 Then
            printAllRows = True
        Else
            printAllRows = False
        End If
    End Sub
End Class