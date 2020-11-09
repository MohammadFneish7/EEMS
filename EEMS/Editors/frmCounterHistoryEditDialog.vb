Imports EEMS.SqlDBHelper

Public Class frmCounterHistoryEditDialog

    Dim a As New Helper
    Dim oldv, newv As Integer
    Sub New(old As Integer, newv As Integer)
        InitializeComponent()
        Me.oldv = old
        Me.newv = newv
        txtNew.Text = newv
        txtOld.Text = oldv
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Integer.Parse(txtNew.Text) - Integer.Parse(txtOld.Text) < 0 Then
                MsgBox("لا يمكن ان تكون قيمة العداد الحاليّة اقل من القيمة السابقة.")
            Else
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNew.KeyPress
        a.bindNumeric(sender, e)
    End Sub
End Class