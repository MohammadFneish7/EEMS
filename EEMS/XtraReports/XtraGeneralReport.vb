Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraReports.UI

Public Class XtraGeneralReport
    Private Sub Picture1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Picture1.BeforePrint
        CType(sender, XRPictureBox).ImageUrl = Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().FullName).FullName, "Logo\logo.jpg")
    End Sub
End Class