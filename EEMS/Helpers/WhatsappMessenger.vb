Imports DevExpress.CodeParser
Imports OpenQA.Selenium
Imports WhatsappAgent

Public Class WhatsappMessenger

    Public Shared isOpen As Boolean = False

    Private messages_ As List(Of WAMessage)
    Private Messagner As Messegner
    Sub New(Messages As List(Of WAMessage))

        ' This call is required by the designer.
        InitializeComponent()
        messages_ = Messages
        ProgressBar1.Maximum = messages_.Count
        lblprog.Text = "0/" & messages_.Count
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Messagner = New Messegner()
        Catch ex As Exception
            BackgroundWorker1.ReportProgress(0, "فشلت عمليّة الارسال، تم اغلاق المُتصفّح." & vbNewLine & ex.Message)
            Return
        End Try


        Dim count As Integer = 0
        Dim browserClosed As Boolean = False
        For Each msg As WAMessage In messages_
            Try
                BackgroundWorker1.ReportProgress(count, "جاري ارسال فاتورة '" & msg.Username & "' (" + msg.Mobile + ")...")
                Messagner.SendMessage(msg.Mobile, msg.Message)
                count += 1
                BackgroundWorker1.ReportProgress(count, "")
            Catch ex As Exception
                If TypeOf ex Is NoSuchWindowException Then
                    BackgroundWorker1.ReportProgress(count, "فشلت عمليّة الارسال، تم اغلاق المُتصفّح.")
                    browserClosed = True
                    Exit For
                Else
                    count += 1
                    BackgroundWorker1.ReportProgress(count, "فشلت عمليّة الارسال، السبب: " & ex.Message)
                End If
            End Try
        Next

        If Not browserClosed Then
            Try
                BackgroundWorker1.ReportProgress(count, "جاري تسجيل الخروج...")
                Messagner.Logout()
            Catch ex As Exception

            Finally
                BackgroundWorker1.ReportProgress(count, "تمّت العمليّة بنجاح.")
            End Try
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Value = e.ProgressPercentage
        lblprog.Text = e.ProgressPercentage & "/" & messages_.Count
        TextBox1.Text &= e.UserState
    End Sub

    Private Sub WhatsappMessenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isOpen = True
    End Sub

    Private Sub WhatsappMessenger_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isOpen = False
    End Sub

    Private Sub WhatsappMessenger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Messagner.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class