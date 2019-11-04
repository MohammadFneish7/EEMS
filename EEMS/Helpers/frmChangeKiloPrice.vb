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

        If txtkiloprice.Text.Trim.Length > 0 Then
            a.Execute("Update CounterHistory set kilowattprice=" & txtkiloprice.Text.Trim & " where cmonth=" & DateTimePicker1.Value.Month & " and cyear=" & DateTimePicker1.Value.Year)
            a.Execute("Update CounterHistory set roundvalue=IIF((1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000))=1000,0,(1000 - (([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))) % 1000))) where cmonth=" & DateTimePicker1.Value.Month & " and cyear=" & DateTimePicker1.Value.Year)

            MsgBox("تم تعديل سعر الكيلوات.")
        Else
            MsgBox("الرجاء ادخال سعر جديد للكيلوات للمتابعة.")
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

End Class