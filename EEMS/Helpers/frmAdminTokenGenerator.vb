Public Class frmAdminTokenGenerator
    Dim CustomPass As String

    Sub New(pass As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CustomPass = pass
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text.Trim().Equals(CustomPass, StringComparison.InvariantCultureIgnoreCase) Then
            Dim token As String = SqlDBHelper.Helper.GenerateHash(TextBox3.Text.Trim.ToUpper & "ADMIN")
            TextBox1.Text = token.Trim.ToUpper.Substring(0, 10)
        Else
            MsgBox("كلمة المرور غير صحيحية")
        End If
    End Sub

End Class