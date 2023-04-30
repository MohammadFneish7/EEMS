Public Class frmInvoiceNote
    Public verbose As Boolean = False
    Public dollarprice As Boolean = False
    Public dollartotal As Boolean = False
    Public alltodollar As Boolean = False
    Public addkilo As Boolean = False
    Public adddiscount As Boolean = False
    Public creditsindollar As Boolean = False
    Public hideWhatsappWindow As Boolean = True
    Public roundTotalDollar As Boolean = True

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblcount.Text = TextBox1.Text.Length
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If chkverbose.Checked Then
            verbose = True
        End If
        If chkdollarprice.Checked Then
            dollarprice = True
        End If
        If chkdollartotal.Checked Then
            dollartotal = True
        End If
        If chkalltodollar.Checked Then
            alltodollar = True
        End If
        If chkaddkilo.Checked Then
            addkilo = True
        End If
        If chkadddiscount.Checked Then
            adddiscount = True
        End If
        If chkcreditsindollar.Checked Then
            creditsindollar = True
        End If
        If chkroundtotal.Checked Then
            roundTotalDollar = True
        End If
        TextBox1.Text = If(String.IsNullOrEmpty(TextBox1.Text), "", TextBox1.Text.Replace(vbNewLine, " "))
        Me.DialogResult =DialogResult.OK
    End Sub

    Private Sub chkalltodollar_CheckedChanged(sender As Object, e As EventArgs) Handles chkalltodollar.CheckedChanged
        If chkalltodollar.Checked Then
            chkdollartotal.Checked = True
            chkdollartotal.Enabled = False
            chkcreditsindollar.Checked = True
            chkcreditsindollar.Enabled = False
        Else
            chkdollartotal.Checked = False
            chkdollartotal.Enabled = True
            chkcreditsindollar.Checked = False
            chkcreditsindollar.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F12 Then
            hideWhatsappWindow = False
            Label1.ForeColor = Color.Green
        End If
    End Sub
End Class