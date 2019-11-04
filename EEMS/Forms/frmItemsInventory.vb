Imports EEMS.SqlDBHelper
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class frmItemsInventory

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        If Not currentUser.hasPermision("itemsManagment") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmItems
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("select distinct i.itemname as [الصنف]," & _
                     " (SELECT isnull(sum(p.quantity),0) from purchases p where p.itemid = i.id) as [شراء]," & _
                     " (SELECT isnull(sum(c.quantity),0) from consumption c where c.itemid = i.id)  as [استهلاك]," & _
                     " ((SELECT isnull(sum(p.quantity),0) from purchases p where p.itemid = i.id) - (SELECT isnull(sum(c.quantity),0) from consumption c where c.itemid = i.id)) as [باقي في المخزن]," & _
                     " i.quantityThreshold as [عتبة الكمّيّة] from Items i ")
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
        If Not currentUser.hasPermision("itemsPurchaseManagment") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmItemsPurchase
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub btnConsumptions_Click(sender As Object, e As EventArgs) Handles btnConsumptions.Click
        If Not currentUser.hasPermision("itemsConsumeManagment") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmItemsConsumption
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If e.RowHandle >= 0 Then
            If GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(3)) < GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns(4)) Then
                e.Appearance.ForeColor = Color.Red
            Else
                e.Appearance.ForeColor = Color.Green
            End If
        End If
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {2, 3, 4}
        If indecies.Contains(index) Then
            'e.DisplayText = e.Value & " ل.ل"

            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            e.Column.DisplayFormat.FormatString = "N0"
        ElseIf index = 1 Then
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub

    Private Sub GridView1_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        If e.RowHandle >= 0 Then
            If e.Column.FieldName = "باقي في المخزن" Then
                If e.CellValue < GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("عتبة الكمّيّة")) Then
                    e.Graphics.DrawImage(My.Resources.iconsetredtoblack4_16x16, e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height)
                Else
                    e.Graphics.DrawImage(My.Resources.iconsetsigns3_16x16, e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height)
                End If
            End If
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
