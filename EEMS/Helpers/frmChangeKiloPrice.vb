Imports EEMS.SqlDBHelper

Public Class frmChangeKiloPrice

    Dim a As New Helper

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '////////////////////////////Below are not related code just for test ////////////////////////////
        'a.ds = New DataSet
        'a.GetDataFromMsAccess("select id from Registration")
        'a.ExecuteToMsAccess("delete from payment")
        'a.ExecuteToMsAccess("delete from CounterHistory where cmonth=3")
        'For Each row As DataRow In a.ds.Tables(0).Rows
        '    a.ExecuteToMsAccess("Insert into CounterHistory(cmonth,cyear,regid,monthlyfee,kilowattprice,previousvalue,currentvalue,notes) VALUES(3,2017," & row.Item(0).ToString & ",10000,300,0,10000,'nothing')")
        'Next
        'MsgBox("Done")
        '//////////////////////////////////////////////////////////////////////////////////////////////////

        If Not String.IsNullOrWhiteSpace(txtkiloprice.Text) > 0 And (CheckBox1.Checked Or Not String.IsNullOrWhiteSpace(txtpackid.Text)) Then
            Dim conditionQuery As String = " ID in (select ch.ID from CounterHistory ch join Registration r on ch.regid = r.ID join Package p on r.packageid = p.ID where  cmonth=" & DateTimePicker1.Value.Month & " and cyear=" & DateTimePicker1.Value.Year & " and p.ID = " & txtpackid.Text & ")"
            If CheckBox1.Checked Then
                conditionQuery = " cmonth=" & DateTimePicker1.Value.Month & " and cyear=" & DateTimePicker1.Value.Year
            End If
            a.Execute("Update CounterHistory set kilowattprice=" & txtkiloprice.Text.Trim & " where " & conditionQuery)
            a.Execute("Update CounterHistory set roundvalue=IIF((1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000))=1000,0,(1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000))) where " & conditionQuery)

            MsgBox("تم تعديل سعر الكيلوات.")
        Else
            MsgBox("الرجاء تعبئة كل الخانات المطلوبة للمتابعة.")
        End If
    End Sub

    Private Sub txtkiloprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkiloprice.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub frmChangeKiloPrice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub txtpackid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtpackid.DoubleClick
        Dim frm1 As New frmChooser(PACKAGE_CHOOSER)
        If frm1.ShowDialog() = DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                txtpackid.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtpackampere.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
            End If
        End If
    End Sub

    Private Sub txtpackid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpackid.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtpackid_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpackid.Clear()
            txtpackid.Enabled = False
            txtpackampere.Clear()
            txtpackampere.Enabled = False
        Else
            txtpackid.Enabled = True
            txtpackampere.Enabled = True
        End If
    End Sub
End Class