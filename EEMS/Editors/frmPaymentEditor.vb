Imports EEMS.SqlDBHelper

Public Class frmPaymentEditor

    Dim chID As Integer = -2
    Dim regID As Integer = -2
    Dim a As New Helper
    Dim leftPayments As Long = 0
    Dim maxPay As Integer = 0
    Dim indate As Date
    Dim collector As String = ""
    Dim clientName As String = ""
    Public payedAmmount As Integer = 0

    Sub New(chid_ As Integer, inDate As Date, collector As String, clientName_ As String, regID_ As Integer, forMonth As String)
        InitializeComponent()

        Me.chID = chid_
        Me.indate = inDate
        Me.collector = collector
        Me.regID = regID_
        Me.clientName = clientName_
        Me.dtp.Value = inDate

        txtCollector.Text = collector.Trim
        txtClientName.Text = clientName_
        txtMonth.Text = forMonth

        If chid_ < 0 Then
            MsgBox("خطأ في رقم الملف.")
            Me.DialogResult =DialogResult.Ignore
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim thisMonthCounterRequiredValueQuery As String = "(SELECT SUM(total) FROM CounterHistory coh WHERE coh.ID =ch.ID)"
            Dim thisMonthCounterPayedValueQuery As String = "(SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.ID =ch.ID)"
            Dim thisMonthTotalRequiredValueQuery As String = "(" & thisMonthCounterRequiredValueQuery & " - " & thisMonthCounterPayedValueQuery & ") AS [باقي]"

            a.ds = New DataSet
            leftPayments = a.ExecuteScalar("SELECT " & thisMonthTotalRequiredValueQuery & " FROM CounterHistory ch WHERE ch.ID=" & chID)
            maxPay = leftPayments
            If leftPayments = 0 Then
                MsgBox("تم تسديد كامل حساب الشهر الحالي لهذا الاشتراك.")
                Me.DialogResult =DialogResult.Ignore
            End If
            txtleftp.Text = leftPayments.ToString("N0")
            txtpayment.SelectAll()
        Catch ex As Exception
            MessageBox.Show("فشل اثناء محاولة تحميل البيانات." & vbNewLine & "تم الغاء العمليّة." & vbNewLine & ex.Message, "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult =DialogResult.Ignore
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        pay(False)
    End Sub


    Private Function checkEmpty() As Boolean
        If txtpayment.Text.Trim.Length = 0 OrElse Integer.Parse(txtpayment.Text) = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        Me.DialogResult =DialogResult.Ignore

    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub PaymentEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pay(True)
    End Sub

    Private Sub pay(printInvoice As Boolean)
        Try
            If checkEmpty() Then
                MsgBox("الرجاء اضافة دفعة اكبر من 0 ل.ل")
                Return
            End If

            If Integer.Parse(txtpayment.Text.Trim) > maxPay Then
                MsgBox("لا يمكن ان تتخطّى قيمة الدفعة اجماي المبلغ الباقي المطلوب.")
                Return
            End If

            If txtCollector.Text.Trim.Length = 0 And RadioButton2.Checked = False Then
                MsgBox("لا يمكن اضافة دفعة بدون اسم الجابي الا اذا كانت طبيعة الدفعة تسديد مباشر.")
                Return
            End If

            Dim name As String = "Unkown"
            Dim regsid As Integer = -1
            Try
                a.ds = New DataSet
                a.GetData("Select c.clientname,r.id from Client c,Registration r,CounterHistory ch where ch.regid=r.ID and r.clientid=c.ID and ch.ID = " & chID)
                name = a.ds.Tables(0).Rows(0).Item(0).ToString.Trim
                regsid = a.ds.Tables(0).Rows(0).Item(1).ToString.Trim
            Catch ex As Exception

            End Try

            Dim intitle As String = "قبض"
            Dim isJebaya As Boolean = False
            Dim collecname As String = "قبض مباشر"

            For Each control As Control In GroupBox2.Controls
                If TypeOf control Is RadioButton Then
                    Dim rb As RadioButton = control
                    If rb.Checked Then
                        intitle = rb.Text.Trim
                        If rb.Text.Contains("جباية") Then
                            isJebaya = True
                            collecname = txtCollector.Text.Trim
                            intitle = intitle + " : " + collecname
                        End If
                        Exit For
                    End If
                End If
            Next


            Dim payid As Integer = a.Execute("insert into Payment(counterhistoryid,pdate,pvalue,notes,collector) values(" & chID & ",'" & dtp.Value & "'," & txtpayment.Text.Trim & ",'" & txtnotes.Text.Trim & "','" & collecname & "')")
            a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & Date.Now.ToShortDateString & "','" & intitle & "'," & txtpayment.Text.Trim & ",'" & name & "','" & "اشتراك رقم " & regsid & "','py" & payid & "')")
            payedAmmount = Integer.Parse(txtpayment.Text.Trim)

            If printInvoice Then
                Dim frm As New frmReportViewer(regID)
                frm.ShowDialog()
            End If

            Me.DialogResult =DialogResult.OK
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
            Me.DialogResult =DialogResult.Ignore
        End Try
    End Sub
End Class
