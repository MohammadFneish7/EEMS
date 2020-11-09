Imports EEMS.SqlDBHelper

Public NotInheritable Class frmSplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Dim a As New Helper
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        Dim serial As String = a.GetHDDId
        Dim hash As String = SqlDBHelper.Helper.GenerateHash(serial & "yamahdi2017license")
        Dim lcs1 As String = hash.Substring(0, 5)
        Dim lcs2 As String = hash.Substring(5, 5)
        Dim lcs3 As String = hash.Substring(10, 5)
        Dim lcs4 As String = hash.Substring(15, 5)
        Dim lcs5 As String = hash.Substring(20, 5)
        Dim license As String = lcs1 + "-" + lcs2 + "-" + lcs3 + "-" + lcs4 + "-" + lcs5
        If a.verifyLicense(license) Then
            frmLogin.Show()
            Me.Close()
        Else
            Dim frm As New frmLicenseEnter(license, serial)

            If frm.ShowDialog =DialogResult.OK Then
                frmLogin.Show()
                Me.Close()
            Else
                Me.Close()
            End If
        End If
    End Sub

End Class
