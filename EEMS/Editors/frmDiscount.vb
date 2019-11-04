Imports EEMS.SqlDBHelper

Public Class frmDiscount

    Dim a As New Helper

    Sub New(req As Integer, discount As Integer)
        InitializeComponent()
        txtRequired.Text = req
        txtDiscount.Text = discount
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Integer.Parse(txtRequired.Text) <> 0 And (Integer.Parse(txtRequired.Text) < Integer.Parse(txtDiscount.Text)) Then
                MsgBox("قيمة الحسم يجب ان تكون اكبر او تساوي المبلغ المطلوب.")
                Return
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub
End Class