Imports DevExpress.Utils.Helpers
Imports EEMS.SqlDBHelper

Public Class frmPaymentEditor

    Public payedAmmount As Integer = 0

    Dim chID As Integer = -2
    Dim regID As Integer = -2
    Dim a As New Helper
    Dim leftPayments As Long = 0
    Dim leftPaymentsdollar As Double = 0
    Dim dollarpricethen As Long = 0
    Dim dollarpricenow As Long = 0
    Dim maxPay As Integer = 0
    Dim indate As Date
    Dim collector As String = ""
    Dim clientName As String = ""

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
        dollarpricenow = SharedModule.dollarPrice

        If chid_ < 0 Then
            MsgBox("خطأ في رقم الملف.")
            Me.DialogResult = DialogResult.Ignore
        End If

    End Sub

    Private Sub togglePayOption()
        If defaultPayOption = 0 Then
            rad1.Checked = True
        ElseIf defaultPayOption = 1 Then
            rad2.Checked = True
        ElseIf defaultPayOption = 2 Then
            rad3.Checked = True
        ElseIf defaultPayOption = 3 Then
            rad4.Checked = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim thisMonthCounterRequiredValueQuery As String = "(SELECT SUM(total) FROM CounterHistory coh WHERE coh.ID =ch.ID)"
            Dim thisMonthCounterPayedValueQuery As String = "(SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.ID =ch.ID)"
            Dim thisMonthTotalRequiredValueQuery As String = "(" & thisMonthCounterRequiredValueQuery & " - " & thisMonthCounterPayedValueQuery & ") AS [باقي]"

            a.ds = New DataSet
            leftPayments = a.ExecuteScalar("SELECT " & thisMonthTotalRequiredValueQuery & " FROM CounterHistory ch WHERE ch.ID=" & chID)
            dollarpricethen = a.ExecuteScalar("SELECT dollarprice FROM CounterHistory ch WHERE ch.ID=" & chID)
            leftPaymentsdollar = leftPayments / dollarpricethen 'Convert.ToDouble(String.Format("{0:0.00}", leftPayments / dollarpricethen))
            maxPay = leftPayments
            If leftPayments = 0 Then
                MsgBox("تم تسديد كامل حساب الشهر الحالي لهذا الاشتراك.")
                Me.DialogResult = DialogResult.Ignore
            End If
            txtleftp.Text = leftPayments.ToString("N0")
            txtleftpdollar.Text = leftPaymentsdollar.ToString("N2")
            cmbcalculationmethod.Items.Add("على سعر الصرف حين تحرير الفاتورة (" + dollarpricethen.ToString("N0") + " ل.ل)")
            cmbcalculationmethod.Items.Add("على سعر الصرف اليوم (" + dollarpricenow.ToString("N0") + " ل.ل)")
            cmbcalculationmethod.SelectedIndex = 0
            cmbcurrency.SelectedIndex = 0
            txtpayment.SelectAll()
        Catch ex As Exception
            MessageBox.Show("فشل اثناء محاولة تحميل البيانات." & vbNewLine & "تم الغاء العمليّة." & vbNewLine & ex.Message, "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Ignore
        End Try

        togglePayOption()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        pay(False)
    End Sub

    Private Function checkEmpty() As Boolean
        If txtpayment.Text.Trim.Length = 0 OrElse Double.Parse(txtpayment.Text) = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress
        If cmbcurrency.SelectedIndex = 0 Then
            a.bindNumeric(sender, e)
        Else
            a.bindDouble(sender, e)
        End If
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


            payedAmmount = 0
            Dim ActualPayedAmmount As Integer = 0
            Dim payedAmmountDollar As Double = 0
            Dim payedAmmountCalculationExplain = ""

            If cmbcurrency.SelectedIndex = 0 Then
                If cmbcalculationmethod.SelectedIndex = 0 Then
                    payedAmmount = Integer.Parse(txtpayment.Text.Trim)
                    ActualPayedAmmount = payedAmmount
                    payedAmmountCalculationExplain = $"{payedAmmount} > {maxPay}"
                Else
                    ActualPayedAmmount = Integer.Parse(txtpayment.Text.Trim)
                    payedAmmount = (ActualPayedAmmount / dollarpricenow) * dollarpricethen
                    payedAmmount += SharedModule.getRoundThousand(payedAmmount)
                    payedAmmountCalculationExplain = $"({ActualPayedAmmount}/{dollarpricenow})*{dollarpricethen}={payedAmmount} > {maxPay}"
                End If
            Else
                payedAmmountDollar = Double.Parse(txtpayment.Text.Trim)
                payedAmmount = payedAmmountDollar * dollarpricethen
                payedAmmount += SharedModule.getRoundThousand(payedAmmount)
                payedAmmountCalculationExplain = $"{payedAmmountDollar}*{dollarpricethen}={payedAmmount} > {maxPay}"
                ActualPayedAmmount = payedAmmount
            End If

            If payedAmmount > maxPay Then
                MsgBox("لا يمكن ان تتخطّى قيمة الدفعة اجماي المبلغ الباقي المطلوب." & $"{vbNewLine}{payedAmmountCalculationExplain}")
                Return
            End If

            If txtCollector.Text.Trim.Length = 0 And rad1.Checked = False Then
                MsgBox("لا يمكن اضافة دفعة بدون اسم الجابي الا اذا كانت طبيعة الدفعة تسديد مباشر.")
                Return
            End If

            If dtp.Value > Date.Now Then
                MsgBox("لا يمكن ادخال الدفعة بتاريخ مستقبلي.")
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

            Dim note As String
            If cmbcurrency.SelectedIndex = 1 Then
                note = $"تم تحويل الدفعة الى صندوق الدولار بقيمة {payedAmmountDollar.ToString("#,##0.##")} دولار على سعر صرف {dollarpricethen.ToString("N0")}"
                If Not String.IsNullOrEmpty(txtnotes.Text) Then
                    note = note & " / " & txtnotes.Text.Trim
                End If
            Else
                If cmbcalculationmethod.SelectedIndex = 1 Then
                    note = $"قبض {ActualPayedAmmount.ToString("N2")} ل.ل على سعر صرف {dollarpricenow.ToString("N0")} تم تدويرها الى {payedAmmount.ToString("N2")} ل.ل على سعر صرف {dollarpricethen.ToString("N0")}"
                    If Not String.IsNullOrEmpty(txtnotes.Text) Then
                        note = note & " / " & txtnotes.Text.Trim
                    End If
                Else
                    note = txtnotes.Text.Trim
                End If
            End If

            Dim payid As Integer = a.Execute("insert into Payment(counterhistoryid,pdate,pvalue,notes,collector) values(" & chID & ",'" & dtp.Value & "'," & payedAmmount & ",'" & note & "','" & collecname & "')")
            a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & dtp.Value.ToShortDateString & "','" & intitle & "'," & payedAmmount & ",'" & name & "','" & "اشتراك رقم " & regsid & "','py" & payid & "')")
            If ActualPayedAmmount - payedAmmount <> 0 Then
                a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & dtp.Value.ToShortDateString & "','فرق سعر صرف دولار من قبض الفاتورة'," & (ActualPayedAmmount - payedAmmount) & ",'" & name & "','" & "اشتراك رقم " & regsid & "','py" & payid & "')")
            End If

            If cmbcurrency.SelectedIndex = 1 Then
                a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & dtp.Value.ToShortDateString & "','ليرة الى دولار'," & -payedAmmount & ",'','على سعر صرف " & dollarpricethen.ToString("N2") & "','py" & payid & "')")
                a.Execute("insert into Expenditure(expdate,title,amount_dollar,currency,party,detail,paymentRef) values('" & dtp.Value.ToShortDateString & "','ليرة الى دولار'," & payedAmmountDollar & ",1,'','على سعر صرف " & dollarpricethen.ToString("N2") & "','py" & payid & "')")
            End If

            Try
                If rad1.Checked Then
                    defaultPayOption = 0
                ElseIf rad2.Checked Then
                    defaultPayOption = 1
                ElseIf rad3.Checked Then
                    defaultPayOption = 2
                ElseIf rad4.Checked Then
                    defaultPayOption = 3
                End If

                a.ExecuteNoReturn("delete from DefinedKeys where reference='settings_1'")
                a.ExecuteNoReturn("insert into DefinedKeys (dkey,title,reference) values('defaultPayOption','" & defaultPayOption & "','settings_1')")
            Catch ex As Exception

            End Try

            If printInvoice Then
                Dim invoiceDate As String = dtp.Value.ToString
                Dim paymentAmmount As String = Convert.ToInt32(txtpayment.Text).ToString("N0")
                Dim registrationId As String = regID
                Dim reportViewer As New XtraReportViewer("ايصال  قبض", "وصلنا من السيّد/ة " &
                                                    clientName & " المحترم/ة  بتاريخ " & invoiceDate &
                                                    " مبلغ وقدره " & paymentAmmount & " ل.ل عن الاشتراك رقم " &
                                                    registrationId & ".", "", "")
                reportViewer.ShowDialog()
            End If

            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
            Me.DialogResult = DialogResult.Ignore
        End Try
    End Sub

    Private Sub cmbcurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcurrency.SelectedIndexChanged
        If cmbcurrency.SelectedIndex = 0 Then
            Label11.Text = "ل.ل"
            cmbcalculationmethod.Enabled = True
        Else
            Label11.Text = "$"
            cmbcalculationmethod.SelectedIndex = 0
            cmbcalculationmethod.Enabled = False
        End If
    End Sub

End Class