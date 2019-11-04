Public Class frmChangePass

    Private password As String = Nothing
    Dim cryptMaker As New CryptoSys
    Dim a As New SqlDBHelper.Helper

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            If Not txtoldpass.Text.Equals(SharedModule.currentUser.getPassword) Then
                MessageBox.Show("كلمة المرور الحاليّة غير صحيحة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If txtPassword.Text.Trim.Length < 6 Then
                MessageBox.Show("كلمة المرور يجب ان تتكوّن من 6 خانات على الأقل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If Not txtPassword.Text.Equals(txtConfirm.Text) Then
                MessageBox.Show("كلمة المرور غير مطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            password = cryptMaker.GetHash(txtPassword.Text)

            a.Execute("update users set pass='" & password & "' where username='" & SharedModule.currentUser.getUsername & "'")
            MessageBox.Show("تم تغيير كلمة المرور بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class