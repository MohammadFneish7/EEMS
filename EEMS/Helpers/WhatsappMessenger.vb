Imports DevExpress.CodeParser
Imports DevExpress.Mvvm
Imports OpenQA.Selenium
Imports WhatsappAgent

Public Class WhatsappMessenger

    Public Shared isOpen As Boolean = False

    Private messages_ As List(Of WAMessage)
    Private WithEvents Messagner_ As Messegner
    Private logoutWhenDone_ As Boolean
    Private starttime As DateTime
    Private a As New SqlDBHelper.Helper
    Private failed As Integer = 0
    Private hideWAWindow As Boolean

    Sub New(Messages As List(Of WAMessage), hideWindow As Boolean,
            Optional ByVal logoutWhenDone As Boolean = False)
        InitializeComponent()
        messages_ = Messages
        hideWAWindow = hideWindow
        ProgressBar1.Maximum = messages_.Count
        lblprog.Text = "0/" & messages_.Count
        BackgroundWorker1.RunWorkerAsync()
        logoutWhenDone_ = logoutWhenDone
        starttime = DateTime.Now
        Timer1.Start()
    End Sub

    Private Sub Messegner_OnDisposed() Handles Messagner_.OnDisposed
        TextBox1.Invoke(Sub() TextBox1.AppendLine("تم اغلاق المُتصفّح"))
    End Sub

    Private Sub Messegner_OnQRReady(qrbmp As Image) Handles Messagner_.OnQRReady
        pbox.Image = qrbmp
        Panel1.Invoke(Sub() Panel1.Visible = True)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Messagner_ = New Messegner(hideWindow:=hideWAWindow)
            Messagner_?.Login(200)
        Catch ex As Exception
            BackgroundWorker1.ReportProgress(0, "فشلت عمليّة تسجيل الدخول." & vbNewLine & ex.Message)
            Return
        Finally
            Panel1.Invoke(Sub() Panel1.Visible = False)
        End Try

        Dim count As Integer = 0
        Dim browserClosed As Boolean = False
        For Each msg As WAMessage In messages_
            Try
                If Messagner_?.IsDisposed Then
                    Throw New NoSuchWindowException()
                End If
                BackgroundWorker1.ReportProgress(count, "جاري ارسال فاتورة '" & msg.Username & "' (" + msg.Mobile + ")...")
                If Debugger.IsAttached Then
                    msg.Mobile = "81184149"
                End If
                Messagner_?.SendMessage(msg.Mobile, msg.Message, load_timeout:=60, ticks_timeout:=60, wait_after_send:=2)
                count += 1
                BackgroundWorker1.ReportProgress(count, "")
                Try
                    a.ExecuteNoReturn($"update CounterHistory set whatsappmsgsent=1 where ID={msg.Id}")
                Catch ex As Exception

                End Try
            Catch ex As Exception
                failed += 1
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
                If logoutWhenDone_ Then
                    BackgroundWorker1.ReportProgress(count, "جاري تسجيل الخروج...")
                    Messagner_?.Logout()
                End If
            Catch ex As Exception

            Finally
                BackgroundWorker1.ReportProgress(count, "انتهت عمليّة الارسال")
            End Try
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Value = e.ProgressPercentage
        lblprog.Text = "تم: " & e.ProgressPercentage & "، فشل: " & failed & "، اجمالي: " & messages_.Count
        TextBox1.AppendLine(e.UserState)
    End Sub

    Private Sub WhatsappMessenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isOpen = True
        TextBox1.Select(0, 0)
    End Sub

    Private Sub WhatsappMessenger_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isOpen = False
    End Sub

    Private Sub WhatsappMessenger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Messagner_?.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim passedts = DateTime.Now - starttime
        lbltime.Text = parseTime01(passedts.Hours) & ":" & parseTime01(passedts.Minutes) & ":" & parseTime01(passedts.Seconds)
    End Sub

    Private Function parseTime01(comp As Integer) As String
        If comp < 10 Then
            Return "0" & comp
        End If
        Return comp
    End Function

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            Timer1.Stop()
        Catch ex As Exception

        End Try
    End Sub
End Class