Public Class frmTokenizer

    Public tokenAccepted As Boolean = False
    Dim token As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim.ToUpper.Equals(token.Trim.ToUpper) Then
            tokenAccepted = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("تذكرة غير صحيحة")
        End If
    End Sub

    Private Sub frmTokenGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = SqlDBHelper.Helper.GenerateHash(Date.Now.Millisecond).Substring(0, 10).ToUpper
        token = SqlDBHelper.Helper.GenerateHash(TextBox2.Text.ToUpper & "ADMIN").Substring(0, 10).ToUpper
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F12 Then
            Dim frm As New frmAdminTokenGenerator
            frm.ShowDialog()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.F12 Then
            Dim frm As New frmAdminTokenGenerator
            frm.ShowDialog()
        End If
    End Sub
End Class