Public Class ErrorDialog

    Public Shared Sub showDlg(ByVal e As Exception)
        Dim f As New ErrorDialog
        f.txterrorTitle.Text = e.Message
        f.txterror.Text = e.StackTrace
        f.txterror.Select(0, 0)
        f.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(txterrorTitle.Text & vbNewLine & txterror.Text)
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class