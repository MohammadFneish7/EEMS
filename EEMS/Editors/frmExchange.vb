Imports DevExpress.Utils.Helpers
Imports EEMS.SqlDBHelper

Public Class frmExchange
    ReadOnly a As New Helper

    Sub New()
        InitializeComponent()
        txtdollarprice.Text = SharedModule.dollarPrice
        cmbtype.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        pay(False)
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress, txtdollarprice.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub txtpaymentdollar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaymentdollar.KeyPress
        a.bindDouble(sender, e)
    End Sub

    Private Sub textChanged(sender As Object, e As EventArgs) Handles txtpaymentdollar.TextChanged, txtpayment.TextChanged, txtdollarprice.TextChanged
        Try
            If Not verifyPaymentEquality() Then
                txtpaymentdollar.BackColor = Color.FromArgb(255, 192, 192)
                lbldollar.BackColor = Color.FromArgb(255, 192, 192)
                txtdollarprice.BackColor = Color.FromArgb(255, 192, 192)
                txtpayment.BackColor = Color.FromArgb(255, 192, 192)
                lbllira.BackColor = Color.FromArgb(255, 192, 192)
            Else
                txtpaymentdollar.BackColor = Color.FromArgb(192, 255, 192)
                lbldollar.BackColor = Color.FromArgb(192, 255, 192)
                txtdollarprice.BackColor = Color.FromArgb(192, 255, 192)
                txtpayment.BackColor = Color.FromArgb(192, 255, 192)
                lbllira.BackColor = Color.FromArgb(192, 255, 192)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub calc(sender As Object)
        Try
            If sender Is txtpayment Then
                txtpayment.Text = CType(Double.Parse(txtpaymentdollar.Text * txtdollarprice.Text).ToString(), Integer)
            ElseIf sender Is txtdollarprice Then
                txtdollarprice.Text = CType(Double.Parse(txtpayment.Text / txtpaymentdollar.Text).ToString(), Integer)
            ElseIf sender Is txtpaymentdollar Then
                txtpaymentdollar.Text = Double.Parse(txtpayment.Text / txtdollarprice.Text).ToString("0.##")
            End If
            txtpayment.Text = Integer.Parse(txtpayment.Text.Trim) + SharedModule.getRoundThousand(Integer.Parse(txtpayment.Text.Trim))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PaymentEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Function verifyPaymentEquality() As Boolean
        Try
            If Math.Abs(Double.Parse(txtpayment.Text) - Double.Parse(txtpaymentdollar.Text * txtdollarprice.Text)) < 1000 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub pay(printInvoice As Boolean)
        Try

            If String.IsNullOrEmpty(txtdollarprice.Text) OrElse Double.Parse(txtdollarprice.Text) <= 0 Then
                MsgBox("الرجاء تحديد سعر الصرف.")
                Return
            End If

            If String.IsNullOrEmpty(txtpaymentdollar.Text) OrElse Double.Parse(txtpaymentdollar.Text) <= 0 Then
                MsgBox("الرجاء تحديد القيمة بالدولار.")
                Return
            End If

            If String.IsNullOrEmpty(txtpayment.Text) OrElse Double.Parse(txtpayment.Text) <= 0 Then
                MsgBox("الرجاء تحديد القيمة بالليرة.")
                Return
            End If

            If Not verifyPaymentEquality() Then
                MsgBox("الرجاء التأكد من أن القيمة بالليرة تساوي القيمة بالدولار ضرب سعر الصرف.")
                Return
            End If

            Dim sign As Integer = -1
            If cmbtype.SelectedIndex > 0 Then
                sign = 1
            End If

            Dim payedAmmount = Long.Parse(txtpayment.Text.Trim) + SharedModule.getRoundThousand(Long.Parse(txtpayment.Text.Trim))

            a.Execute("insert into Expenditure(expdate,title,amount,party,detail) values('" & DateTime.Now.ToShortDateString & "','" & cmbtype.SelectedItem & "'," & (sign * payedAmmount) & ",'','على سعر صرف " & Double.Parse(txtdollarprice.Text).ToString("#,##0.##") & "')")
            a.Execute("insert into Expenditure(expdate,title,amount_dollar,currency,party,detail) values('" & DateTime.Now.ToShortDateString & "','" & cmbtype.SelectedItem & "'," & (-1 * sign * txtpaymentdollar.Text.Trim) & ",1,'','على سعر صرف " & Double.Parse(txtdollarprice.Text).ToString("#,##0.##") & "')")

            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
            Me.DialogResult = DialogResult.Ignore
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calc(txtpayment)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        calc(txtdollarprice)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        calc(txtpaymentdollar)
    End Sub
End Class
