Public Class frmValidityRenual

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim md As Short = ((DateTimePicker1.Value.Year - Now.Year) * 12) + DateTimePicker1.Value.Month - Now.Month
        If md <= 0 Then
            MsgBox("يجب اختيار تاريخ بعد اليوم بشهر على الأقل")
        Else
            Dim vc As New ValidityChecher
            vc.writeTimeValidity(DateTimePicker1.Value)
            MsgBox("تمت العملية بنجاح")
            Me.Dispose()
        End If
    End Sub
End Class