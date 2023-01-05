Imports DevExpress.Utils.Helpers
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
        txtdollarprice.Text = SharedModule.dollarPrice

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
            maxPay = leftPayments
            If leftPayments = 0 Then
                MsgBox("تم تسديد كامل حساب الشهر الحالي لهذا الاشتراك.")
                Me.DialogResult = DialogResult.Ignore
            End If
            txtleftp.Text = leftPayments.ToString("N0")
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
        If txtpayment.Text.Trim.Length = 0 OrElse Integer.Parse(txtpayment.Text) = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Ignore

    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress, txtdollarprice.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub txtpaymentdollar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaymentdollar.KeyPress
        a.bindDouble(sender, e)
    End Sub

    Private Function verifyPaymentEquality() As Boolean
        Try
            If Math.Abs(Integer.Parse(txtpayment.Text) - Double.Parse(txtpaymentdollar.Text * txtdollarprice.Text)) < 1000 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub txtpaymentdollar_TextChanged(sender As Object, e As EventArgs) Handles txtpaymentdollar.TextChanged, txtpayment.TextChanged, txtdollarprice.TextChanged
        RemoveHandler txtpayment.TextChanged, AddressOf txtpaymentdollar_TextChanged
        RemoveHandler txtdollarprice.TextChanged, AddressOf txtpaymentdollar_TextChanged
        RemoveHandler txtpaymentdollar.TextChanged, AddressOf txtpaymentdollar_TextChanged

        Try
            If sender Is txtpayment Then
                txtpaymentdollar.Text = Double.Parse(txtpayment.Text / txtdollarprice.Text).ToString("0.##")
            Else
                If sender Is txtdollarprice Then
                    txtpaymentdollar.Text = Double.Parse(txtpayment.Text / txtdollarprice.Text).ToString("0.##")
                ElseIf sender Is txtpaymentdollar Then
                    txtdollarprice.Text = CType(Double.Parse(txtpayment.Text / txtpaymentdollar.Text).ToString(), Integer)
                End If

                txtpayment.Text = Integer.Parse(txtpayment.Text.Trim) + SharedModule.getRoundThousand(Integer.Parse(txtpayment.Text.Trim))
            End If
        Catch ex As Exception

        Finally
            AddHandler txtpayment.TextChanged, AddressOf txtpaymentdollar_TextChanged
            AddHandler txtdollarprice.TextChanged, AddressOf txtpaymentdollar_TextChanged
            AddHandler txtpaymentdollar.TextChanged, AddressOf txtpaymentdollar_TextChanged
        End Try
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

            If chkmigratetodollarbox.Checked Then
                payedAmmount = Integer.Parse(txtpayment.Text.Trim) + SharedModule.getRoundThousand(Integer.Parse(txtpayment.Text.Trim))
            Else
                payedAmmount = Integer.Parse(txtpayment.Text.Trim)
            End If


            If payedAmmount > maxPay Then
                MsgBox("لا يمكن ان تتخطّى قيمة الدفعة اجماي المبلغ الباقي المطلوب.")
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

            If chkmigratetodollarbox.Checked Then
                If String.IsNullOrEmpty(txtdollarprice.Text) OrElse Double.Parse(txtdollarprice.Text) <= 0 Then
                    MsgBox("الرجاء تحديد سعر الصرف للتحويل الى صندوق الدولار.")
                    Return
                End If
                If String.IsNullOrEmpty(txtpaymentdollar.Text) OrElse Double.Parse(txtpaymentdollar.Text) <= 0 Then
                    MsgBox("الرجاء تحديد القيمة بالدولار للتحويل الى صندوق الدولار.")
                    Return
                End If
                If Not verifyPaymentEquality() Then
                    MsgBox("الرجاء التأكد من أن القيمة بالليرة تساوي القيمة بالدولار ضرب سعر الصرف.")
                    Return
                End If
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

            Dim payid As Integer = a.Execute("insert into Payment(counterhistoryid,pdate,pvalue,notes,collector) values(" & chID & ",'" & dtp.Value & "'," & payedAmmount & ",'" & txtnotes.Text.Trim & "','" & collecname & "')")
            a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & dtp.Value.ToShortDateString & "','" & intitle & "'," & payedAmmount & ",'" & name & "','" & "اشتراك رقم " & regsid & "','py" & payid & "')")
            If chkmigratetodollarbox.Checked Then
                a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & dtp.Value.ToShortDateString & "','ليرة الى دولار'," & -payedAmmount & ",'','على سعر صرف " & Double.Parse(txtdollarprice.Text).ToString("#,##0.##") & "','py" & payid & "')")
                a.Execute("insert into Expenditure(expdate,title,amount_dollar,currency,party,detail,paymentRef) values('" & dtp.Value.ToShortDateString & "','ليرة الى دولار'," & txtpaymentdollar.Text.Trim & ",1,'','على سعر صرف " & Double.Parse(txtdollarprice.Text).ToString("#,##0.##") & "','py" & payid & "')")
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

    Private Sub chkmigratetodollarbox_CheckedChanged(sender As Object, e As EventArgs) Handles chkmigratetodollarbox.CheckedChanged
        If chkmigratetodollarbox.Checked Then
            txtdollarprice.Enabled = True
            txtpaymentdollar.Enabled = True
        Else
            txtdollarprice.Enabled = False
            txtpaymentdollar.Enabled = False
        End If
    End Sub

    Private Sub txtpayment_Leave(sender As Object, e As EventArgs) Handles txtpayment.Leave
        Try
            If chkmigratetodollarbox.Checked Then
                txtpayment.Text = Integer.Parse(txtpayment.Text.Trim) + SharedModule.getRoundThousand(Integer.Parse(txtpayment.Text.Trim))
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
