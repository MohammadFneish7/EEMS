Imports EEMS.SqlDBHelper

Public Class frmChangeDollarPrice

    Dim a As New Helper

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not String.IsNullOrWhiteSpace(txtdollarprice.Text) Then

            If txtdollarprice.Text < 0 Then
                MsgBox("الرجاء ادخال قيمة ايجابية")
                Return
            End If

            Dim conditionQuery As String = " cmonth=" & DateTimePicker1.Value.Month & " and cyear=" & DateTimePicker1.Value.Year

            a.Execute("Update CounterHistory set dollarPrice=" & txtdollarprice.Text.Trim & " where " & conditionQuery)

            MsgBox("تم تعديل سعر صرف الدولار.")
        Else
            MsgBox("الرجاء تعبئة كل الخانات المطلوبة للمتابعة.")
        End If
    End Sub

    Private Sub txtkiloprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdollarprice.KeyPress
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