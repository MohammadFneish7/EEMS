Public Class frmInvoiceNote
    Public verbose As Boolean = False
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblcount.Text = TextBox1.Text.Length
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If chkverbose.Checked Then
            verbose = True
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class