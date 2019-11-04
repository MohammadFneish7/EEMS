Public Class frmSqlExecuter

    Dim a As New SqlDBHelper.Helper
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Try
            a.ds = New DataSet
            dgvData1.DataSource = Nothing
            If chkisScalar.Checked Then
                MsgBox(a.ExecuteScalarAsObject(txtSQL.Text.Trim))
            Else
                If txtSQL.Text.Trim.ToUpper.StartsWith("SELECT") Then
                    a.GetData(txtSQL.Text.Trim)
                    dgvData1.DataSource = a.ds.Tables(0)
                Else
                    a.ExecuteNoReturn(txtSQL.Text.Trim)
                End If
                MsgBox("Done!!")
            End If

        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnShowPrint_Click(sender As Object, e As EventArgs) Handles btnShowPrint.Click
        Try
            GridView1.ShowPrintPreview()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub SqlExecuter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class