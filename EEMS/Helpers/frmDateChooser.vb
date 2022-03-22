Public Class frmDateChooser
    Private Sub Chkall_CheckedChanged(sender As Object, e As EventArgs) Handles chkall.CheckedChanged
        If chkall.Checked Then
            dtp0.Enabled = False
            dtp1.Enabled = False
        Else
            dtp0.Enabled = True
            dtp1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = DialogResult.OK
    End Sub
End Class