Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel
Imports System.Data.OleDb

Public Class ExcelExporter

    Dim oExcel As Excel.Application
    Dim oBook As Excel.Workbook
    Dim oSheet1 As Excel.Worksheet
    Dim dt As New System.Data.DataTable

    Public Shared Function ExportXtraGridToXlsx(grid As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx"
        SaveFileDialog1.Title = "اختر مكان حفظ الملف وإسمه"
        Dim des As String

        Try
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                des = SaveFileDialog1.FileName

                grid.ExportToXlsx(des)
                Return True
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

        Return False
    End Function

    Public Function ExportDataToExcell(dt As System.Data.DataTable, Optional ByVal sheetName As String = "") As Boolean

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MsgBox("لا يوجد معلومات لتصديرها.")
            Return False
        End If

        Me.dt.Merge(dt)

        Try
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oBook.Worksheets.Add()
            oSheet1 = oBook.Worksheets(1)
            If sheetName.Trim.Length > 0 Then
                oSheet1.Name = sheetName
            End If

            oExcel.DefaultSheetDirection = Int(Excel.Constants.xlRTL)

            For Each sheet As Excel.Worksheet In oBook.Worksheets
                sheet.DisplayRightToLeft = True
            Next

            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx"
            SaveFileDialog1.Title = "اختر مكان حفظ الملف وإسمه"
            Dim des As String
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    des = SaveFileDialog1.FileName
                    startExport(des)
                Catch ex As Exception
                    ErrorDialog.showDlg(ex)
                End Try
            Else
                Return False
            End If

        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        Finally
            Try
                For Each sheet As Excel.Worksheet In oBook.Worksheets
                    release(sheet)
                Next
                oBook.Close(False, Type.Missing, Type.Missing)
                release(oBook)
                oExcel.Quit()
                release(oExcel)
                GC.Collect()
            Catch ex As Exception
            End Try
        End Try

        Return True
    End Function

    Private Sub startExport(filename As String)

        Try
            Dim sheetIndex As Integer = 1

            If dt.Rows.Count > 0 Then
                ' On Error Resume Next
                Dim col, row As Integer
                ' Copy the DataTable to an object array
                Dim rawData(dt.Rows.Count, dt.Columns.Count - 1) As Object
                ' Copy the column names to the first row of the object array
                For col = 0 To dt.Columns.Count - 1
                    rawData(0, col) = dt.Columns(col).ColumnName.ToUpper
                Next
                ' Copy the values to the object array
                For col = 0 To dt.Columns.Count - 1
                    For row = 0 To dt.Rows.Count - 1
                        rawData(row + 1, col) = dt.Rows(row).ItemArray(col)
                    Next
                Next
                ' Calculate the final column letter
                Dim finalColLetter As String = String.Empty
                finalColLetter = ExcelColName(dt.Columns.Count)
                Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, dt.Rows.Count + 1)

                oBook.Worksheets(sheetIndex).Range(excelRange, Type.Missing).Value2 = rawData
                oBook.Worksheets(sheetIndex).Range(excelRange).Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                sheetIndex += 1
            Else
                oBook.Sheets(oBook.Sheets(sheetIndex).Name).Delete()
            End If

            For colsnum = 1 To dt.Columns.Count Step 1
                oSheet1.Cells(1, colsnum).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
                oSheet1.Cells(1, colsnum).font.bold = True
            Next

            For Each osheet As Excel.Worksheet In oBook.Worksheets
                osheet.Cells().EntireColumn.AutoFit()
                osheet.Cells().HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Next

            oBook.SaveAs(filename, XlFileFormat.xlWorkbookDefault, Type.Missing, _
                     Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, _
                     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Function ExcelColName(ByVal Col As Integer) As String
        If Col < 0 And Col > 256 Then
            MsgBox("Invalid Argument", MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End If
        Dim i As Int16
        Dim r As Int16
        Dim S As String
        If Col <= 26 Then
            S = Chr(Col + 64)
        Else
            r = Col Mod 26
            i = System.Math.Floor(Col / 26)
            If r = 0 Then
                r = 26
                i = i - 1
            End If
            S = Chr(i + 64) & Chr(r + 64)
        End If
        ExcelColName = S
    End Function

    Private Sub release(o As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(o)
            o = Nothing
        Catch ex As Exception
            o = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
