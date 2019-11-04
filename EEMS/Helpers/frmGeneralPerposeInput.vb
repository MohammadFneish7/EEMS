Public Class frmGeneralPerposeInput
    Dim a As New SqlDBHelper.Helper
    Dim numeric As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        PasswordTextBox.BackColor = Color.White
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(title As String, msg As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = title
        Me.PasswordLabel.Text = msg
        Me.PasswordTextBox.PasswordChar = ""
        PasswordTextBox.BackColor = Color.White
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(title As String, msg As String, bindNumberic As Boolean)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = title
        Me.PasswordLabel.Text = msg
        Me.PasswordTextBox.PasswordChar = ""
        numeric = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If numeric Then
            a.bindNumeric(sender, e)
        End If

    End Sub
End Class
