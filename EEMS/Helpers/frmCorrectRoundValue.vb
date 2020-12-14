Public Class frmCorrectRoundValue

    Dim a As New SqlDBHelper.Helper

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim whereClause As String = " where cmonth=" & dtp.Value.Month & " AND cyear=" & dtp.Value.Year
            If chkall.Checked Then
                whereClause = String.Empty
            End If
            Dim query As String = String.Empty
            If cmbtype.SelectedIndex = 0 Then
                query = "Update CounterHistory set roundvalue=IIF((1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000))=1000,0,(1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000)))" & whereClause
            ElseIf cmbtype.SelectedIndex = 1 Then
                query = "Update CounterHistory set roundvalue=IIF((1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000))=1000,0,IIF((([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000) < 500, -(([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000),1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000)))" & whereClause
            ElseIf cmbtype.SelectedIndex = 2 Then
                query = "Update CounterHistory set roundvalue=0" & whereClause
            End If
            a.Execute(query)
            MsgBox("تمت العمليّة بنجاح")
            DialogResult = DialogResult.OK
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub frmCorrectRoundValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbtype.SelectedIndex = 0
    End Sub

    Private Sub chkall_CheckedChanged(sender As Object, e As EventArgs) Handles chkall.CheckedChanged
        If chkall.Checked Then
            dtp.Enabled = False
        Else
            dtp.Enabled = True
        End If
    End Sub
End Class