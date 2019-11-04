Imports System.Globalization
Imports System.Threading

Public Class frmLogin

    Dim a As New SqlDBHelper.Helper
    Dim cryptMaker As New CryptoSys

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Text = My.Settings.lastuser
        Version.Text = String.Format("v {0}", My.Application.Info.Version.ToString)
    End Sub


    Private Sub runMain(username As String)

        Dim CultureAR = CultureInfo.CreateSpecificCulture("ar-AR")
        'CultureInfo. = CultureAR
        CultureInfo.DefaultThreadCurrentUICulture = CultureAR
        Thread.CurrentThread.CurrentUICulture = CultureAR

        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", "sShortDate", "M/d/yyyy")

        'For Each Formattt As String In (New DateTimePicker).Value.GetDateTimeFormats(CultureInfo.GetCultureInfo("ar-LB"))
        '    Console.WriteLine(Formattt)
        'Next
        Dim mainform As New frmMain(username, txtpassword.Text)
        txtpassword.Text = String.Empty
        mainform.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles btnok.Click
        a.ds = New DataSet
        If a.ExecuteScalar("select count(*) from users where username='" & txtusername.Text.Trim.ToLower & "' and pass='" & cryptMaker.GetHash(txtpassword.Text) & "'") > 0 Then
            My.Settings.lastuser = txtusername.Text.Trim
            Me.Hide()
            runMain(txtusername.Text.Trim)
        Else
            MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtpassword.SelectAll()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmAbout.ShowDialog()
    End Sub
End Class
