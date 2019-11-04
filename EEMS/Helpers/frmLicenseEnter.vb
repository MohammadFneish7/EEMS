Imports EEMS.SqlDBHelper

Public Class frmLicenseEnter

    Dim lcs, serial As String
    Dim a As New Helper

    Public Sub New(license As String, serial As String)
        InitializeComponent()
        lcs = license
        Me.serial = serial
        TextBox1.Text = serial
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lcs = TextBox2.Text.Trim Then
            a.writeLicense(lcs)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("الرخصة غير صالحة الرجاء التواصل مع مع المنتج لشراء رخصة جديدة." & vbNewLine & "للتواصل والاستفسار: 70434962")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLower(e.KeyChar) Then
            TextBox2.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

End Class