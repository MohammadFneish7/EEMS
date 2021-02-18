Imports EEMS.SqlDBHelper

Public Class frmClientReport

    Dim regbs, credbs, paybs As New BindingSource
    Dim cid As Integer = -1
    Dim clientname As String
    Dim a As New Helper
    'Dim sumremain, sumrequired, sumpayed As Integer
    Dim regInfos As New Hashtable

    Sub New(cid As Integer, clientname_ As String)

        InitializeComponent()

        clientname = clientname_
        Me.cid = cid
        If cid < 0 Then
            MsgBox("خطأ في رقم المشترك.")
            Me.DialogResult =DialogResult.Ignore
        End If
        txtName.Text = clientname_

    End Sub

    Private Sub loadData()
        regInfos.Clear()
        a.ds = New DataSet
        a.GetData("SELECT r.ID as [معرّف الاشتراك],r.clientid as [معرّف المشترك],r.active as مفعّل,registrationdate as [تاريخ الاشتراك],enddate as [تاريخ انهاء الاشتراك],p.ampere as [أمبير],b.code as [رمز العلبة],b.location as [عنوان العلبة],ec.serial as[رمز العدّاد],ec.code as [الرمز في العلبة],r.notes AS [ملاحظات] FROM Registration r,Client c,ElectricBox b,ECounter ec,Package p WHERE r.packageid = p.ID and r.counterid = ec.ID and ec.boxid = b.ID and r.clientid = c.ID and r.clientid=" & cid & " order By r.active", "dt1")
        regbs.DataSource = a.ds.Tables("dt1")
        dgvRegistration.DataSource = regbs

        a.GetData("SELECT ch.ID as [معرّف القيمة],r.ID as [معرّف الاشتراك],(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))) as [شهر],ch.monthlyfee as [رسم اشتراك ل.ل],(ch.currentvalue-ch.previousvalue) as [فرق عداد (كيلو)],ch.kilowattprice as [سعر الكيلو ل.ل],((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue as [مطلوب كيلو ل.ل],total+discount as [المجموع ل.ل],ch.discount as [حسم ل.ل],total as [مطلوب ل.ل], ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [مدفوع ل.ل], total-ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [باقي ل.ل] " &
                    " FROM (CounterHistory ch left join Payment p on p.counterhistoryid=ch.ID) join Registration r on ch.regid = r.ID join ArabicMonth ar on ch.cmonth=ar.ID where r.clientid=" & cid &
                    " group by ch.ID,r.ID,(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))),ch.monthlyfee,(ch.currentvalue-ch.previousvalue),ch.kilowattprice,((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue,total+discount,ch.discount,ch.total", "dt2")
        credbs.DataSource = a.ds.Tables("dt2")

        dgvCredits.DataSource = credbs
        dgvCredits.Columns("رسم اشتراك ل.ل").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("فرق عداد (كيلو)").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("سعر الكيلو ل.ل").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("مطلوب كيلو ل.ل").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("المجموع ل.ل").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("حسم ل.ل").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("مطلوب ل.ل").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("مدفوع ل.ل").DefaultCellStyle.Format = "N0"
        dgvCredits.Columns("باقي ل.ل").DefaultCellStyle.Format = "N0"

        'sumrequired = 0
        'sumpayed = 0

        For Each row As DataRow In a.ds.Tables("dt2").Rows
            Dim ri As RegInfo
            If regInfos.ContainsKey(Integer.Parse(row.Item(1).ToString)) Then
                ri = regInfos.Item(Integer.Parse(row.Item(1).ToString))
                ri.sumcredit += Integer.Parse(row.Item(9).ToString)
            Else
                ri = New RegInfo
                ri.sumcredit = Integer.Parse(row.Item(9).ToString)
                regInfos.Add(Integer.Parse(row.Item(1).ToString), ri)
            End If
            ri.remaining = ri.sumcredit - ri.sumpayed
        Next

        a.GetData("SELECT r.ID as [معرّف الاشتراك],p.ID as [معرّف الدفعة],p.counterhistoryid as [معرّف القيمة],p.pdate as [تاريخ الدفعة],p.pvalue as [قيمة الدفعة ل.ل],p.notes as [ملاحظات] FROM Payment p,CounterHistory ch,Registration r WHERE p.counterhistoryid=ch.ID and ch.regid=r.ID and r.clientid=" & cid, "dt3")
        paybs.DataSource = a.ds.Tables("dt3")
        dgvPayments.DataSource = paybs
        dgvPayments.Columns("قيمة الدفعة ل.ل").DefaultCellStyle.Format = "N0"


        For Each row As DataRow In a.ds.Tables("dt3").Rows
            Dim ri As RegInfo
            If regInfos.ContainsKey(Integer.Parse(row.Item(0).ToString)) Then
                ri = regInfos.Item(Integer.Parse(row.Item(0).ToString))
                ri.sumpayed += Integer.Parse(row.Item(4).ToString)
            Else
                ri = New RegInfo
                ri.sumpayed = Integer.Parse(row.Item(4).ToString)
                regInfos.Add(Integer.Parse(row.Item(0).ToString), ri)
            End If
            ri.remaining = ri.sumcredit - ri.sumpayed
        Next

        'For Each row As DataRow In a.ds.Tables("dt3").Rows
        '    Try
        '        sumpayed += Integer.Parse(row.Item(4).ToString)
        '    Catch ex As Exception
        '    End Try
        'Next

        'sumremain = sumrequired - sumpayed

        dgvRegistration_SelectionChanged(Nothing, Nothing)

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvRegistration.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvRegistration, True, Nothing)
        End If

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvCredits.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvCredits, True, Nothing)
        End If

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvPayments.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvPayments, True, Nothing)
        End If
    End Sub

    Private Sub dgvRegistration_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRegistration.SelectionChanged
        If dgvRegistration.SelectedRows.Count > 0 Then
            btnPrint.Enabled = True
            credbs.Filter = "[معرّف الاشتراك] = " & dgvRegistration.SelectedRows(0).Cells(0).Value.ToString
            'Dim sumrequired As Integer = 0
            'For Each row As DataGridViewRow In dgvCredits.Rows
            '    Try
            '        sumrequired += Integer.Parse(row.Cells(9).Value.ToString)
            '    Catch ex As Exception
            '    End Try
            'Next
            Dim ri As RegInfo = regInfos.Item(Integer.Parse(dgvRegistration.SelectedRows(0).Cells(0).Value.ToString))
            If IsNothing(ri) Then
                ri = New RegInfo
            End If

            Dim sumrequiredstr As String = ri.sumcredit.ToString("N0")
            Dim sumpayedstr As String = ri.sumpayed.ToString("N0")
            Dim sumremainstr As String = ri.remaining.ToString("N0")

            lblhrid.Text = "معرّف الاشتراك" & vbNewLine & dgvRegistration.SelectedRows(0).Cells(0).Value.ToString
            lblhcredit.Text = "مطلوب" & vbNewLine & sumrequiredstr & " ل.ل"
            lblhpayed.Text = "مدفوع" & vbNewLine & sumpayedstr & " ل.ل"
            lblhrem.Text = "باقي" & vbNewLine & sumremainstr & " ل.ل"

            'lbl1.Text = "اجمالي المطلوب = " & ri.sumcredit.ToString("N0") & " | اجمالي المدفوع = " & ri.sumpayed.ToString("N0") & " | الباقي = " & ri.remaining.ToString("N0")
            lbl2.Text = "إجمالي مطلوب = " & ri.sumcredit.ToString("N0") & " ل.ل"
        Else
            btnPrint.Enabled = False
        End If
    End Sub

    Private Sub dgvCredits_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCredits.SelectionChanged
        If dgvCredits.SelectedRows.Count > 0 Then
            paybs.Filter = "[معرّف القيمة] = " & dgvCredits.SelectedRows(0).Cells(0).Value.ToString
            Dim sumpayed As Integer = 0
            For Each row As DataGridViewRow In dgvPayments.Rows
                Try
                    sumpayed += Integer.Parse(row.Cells(4).Value.ToString)
                Catch ex As Exception
                End Try
            Next
            lbl3.Text = "المجموع = " & sumpayed.ToString("N0") & " ل.ل"
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmReportViewer(Integer.Parse(dgvRegistration.SelectedRows(0).Cells(0).Value.ToString))
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not currentUser.hasPermision("addpayment") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If dgvCredits.SelectedRows.Count > 0 Then
            Try
                Try
                    a.ds.Tables("dt6")?.Clear()
                Catch ex As Exception

                End Try

                a.GetData("Select fullname from collector c, Registration r, ElectricBox b,Ecounter ec where c.id=b.collectorid and b.id=ec.boxid and r.counterid=ec.id and r.id=" & dgvCredits.SelectedRows(0).Cells(1).Value, "dt6")
                Dim frm As New frmPaymentEditor(dgvCredits.SelectedRows(0).Cells(0).Value, Date.Now, a.ds.Tables("dt6").Rows(0).Item(0).ToString.Trim, clientname, dgvCredits.SelectedRows(0).Cells(1).Value, dgvCredits.SelectedRows(0).Cells(3).Value.ToString)
                Dim dr As DialogResult = frm.ShowDialog
                If dr = System.Windows.Forms.DialogResult.OK Then
                    loadData()
                End If
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If dgvPayments.SelectedRows.Count > 0 Then
            Dim ri As RegInfo = regInfos.Item(Integer.Parse(dgvRegistration.SelectedRows(0).Cells(0).Value.ToString))
            Dim sumrequiredstr As String = ri.sumcredit.ToString("N0")
            Dim sumpayedstr As String = ri.sumpayed.ToString("N0")
            Dim sumremainstr As String = ri.remaining.ToString("N0")

            Dim reportViewer As New frmReportViewer("ايصال  قبض", "وصلنا من السيّد/ة " & _
                                                    clientname & " المحترم/ة  بتاريخ " & dgvPayments.SelectedRows(0).Cells(3).Value.ToString & _
                                                    " مبلغ وقدره " & dgvPayments.SelectedRows(0).Cells(4).Value.ToString & " ل.ل عن الاشتراك رقم " & _
                                                    dgvRegistration.SelectedRows(0).Cells(0).Value & ".", "تفصيل الاشتراك حتى تاريخ الايصال: " & _
                                                    vbNewLine & vbNewLine & "● اجمالي مطلوب = " & sumrequiredstr & " ل.ل" & vbNewLine & _
                                                    "● اجمالي مدفوع = " & sumpayedstr & " ل.ل" & vbNewLine & "● اجمالي باقي = " & sumremainstr & " ل.ل", "")
            reportViewer.ShowDialog()
        End If
    End Sub

    Private Sub ClientReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub dgvCredits_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCredits.CellDoubleClick
        If Not currentUser.hasPermision("adddiscount") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then
            Return
        End If
        Dim frmDiscount As New frmDiscount(dgvCredits.SelectedRows(0).Cells(9).Value, dgvCredits.SelectedRows(0).Cells(8).Value)
        Dim dr As DialogResult = frmDiscount.ShowDialog
        If dr = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim dis As Integer = frmDiscount.txtDiscount.Text
                a.ExecuteNoReturn("update CounterHistory set discount=" & dis & " where ID=" & dgvCredits.SelectedRows(0).Cells(0).Value)
                loadData()
                dgvRegistration_SelectionChanged(sender, e)
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub


    Private Sub dgvPayments_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPayments.KeyDown

        If e.KeyCode = 46 Then
            If Not currentUser.hasPermision("deletepayment") Then
                MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return
            End If
            'Dim ml As New MasterLogin
            'Dim d As DialogResult = ml.ShowDialog()
            'If d =DialogResult.OK Then
            '    If Not ml.PasswordTextBox.Text.Trim.ToUpper.Equals("ADMINUNLOCK") Then
            '        MsgBox("invalid password")
            '        Return
            '    End If
            'Else
            '    Return
            'End If
            Try
                Dim dr As DialogResult = MessageBox.Show("تنبيه: ان حذف اي سطر قد يؤدي الى فقدان المعلومات المرتبطة به." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dr =DialogResult.Yes Then
                    If MsgBox("ملاحظة: سوف يتم حذف الدفعة من حساب المؤسّسة ايضاً." & vbNewLine & "هل تريد المتابعة؟", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Return
                    End If
                    Dim listToRemove As DataGridViewSelectedRowCollection = dgvPayments.SelectedRows
                    Dim todeleteIds As String = "("
                    Dim todeleteIdsstr As String = "('"
                    For Each row As DataGridViewRow In dgvPayments.SelectedRows
                        todeleteIds = todeleteIds & row.Cells(1).Value.ToString & ","
                        todeleteIdsstr = todeleteIdsstr & "py" & row.Cells(1).Value.ToString & "','"
                    Next
                    If todeleteIds.Length > 1 Then
                        todeleteIds = todeleteIds.Remove(todeleteIds.Length - 1, 1)
                        todeleteIdsstr = todeleteIdsstr.Remove(todeleteIdsstr.Length - 2, 2)
                        todeleteIds = todeleteIds & ")"
                        todeleteIdsstr = todeleteIdsstr & ")"
                        a.Execute("DELETE FROM Payment Where ID in " & todeleteIds)
                        a.Execute("DELETE FROM Expenditure Where paymentRef in " & todeleteIdsstr)
                        For Each i As DataGridViewRow In listToRemove
                            dgvPayments.Rows.Remove(i)
                        Next
                    End If
                    loadData()
                End If
            Catch ex As Exception
                MsgBox("لا يمكنك حذف هذه الاسطر حسث ان هناك معلومات تفصيليّة مهمّة مرتبطة بها." & vbNewLine & "يجب ازالة كل البيانات المرتبطة بهذه الاسطر واعادة المحاولة.")
            End Try
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtName_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        loadData()
    End Sub

    Private Sub txtName_DoubleClick(sender As Object, e As EventArgs) Handles txtName.DoubleClick
        Dim frm1 As New frmChooser(CLIENT_CHOOSER)
        If frm1.ShowDialog() =DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                cid = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                clientname = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtName.Text = clientname
                txtName.Select()
            End If
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            txtName_DoubleClick(Nothing, Nothing)
            e.Handled = False
        End If
    End Sub

    Private Sub dgvCredits_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvCredits.RowPrePaint
        Dim dgvrow As DataGridViewRow = dgvCredits.Rows(e.RowIndex)
        If dgvrow.Cells("باقي ل.ل").Value > 0 Then
            dgvrow.DefaultCellStyle.BackColor = Color.LightPink
        Else
            dgvrow.DefaultCellStyle.BackColor = Color.GreenYellow
        End If
    End Sub
End Class

Class RegInfo
    Public sumcredit As Integer = 0
    Public sumpayed As Integer = 0
    Public remaining As Integer = 0
End Class