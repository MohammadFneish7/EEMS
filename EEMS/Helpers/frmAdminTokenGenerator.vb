Public Class frmAdminTokenGenerator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text.Trim.ToUpper.Trim.Equals("MOHAMMADFNEISH") Then
            Dim token As String = SqlDBHelper.Helper.GenerateHash(TextBox3.Text.Trim.ToUpper & "ADMIN")
            TextBox1.Text = token.Trim.ToUpper.Substring(0, 10)
        Else
            MsgBox("كلمة المرور غير صحيحية")
        End If
    End Sub

End Class