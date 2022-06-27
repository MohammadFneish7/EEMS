Imports EEMS.SqlDBHelper

Public Class frmRegistrationEditor
    Dim regid As Integer = -2
    Dim clientid As Integer = -2
    Dim add As Boolean = False
    Dim active As Boolean = False
    Dim a As New Helper
    Dim counterid As Integer
    Dim paidInsurenceAmount As Integer = 0

    Sub New(rid As Integer, cid As Integer, add As Boolean)
        InitializeComponent()
        Me.regid = rid
        Me.add = add
        clientid = cid
        If add = False Then
            If rid < 0 Then
                MsgBox("خطأ في رقم الملف.")
                Me.DialogResult =DialogResult.Ignore
            End If
            If cid < 0 Then
                MsgBox("خطأ في رقم المشترك.")
                Me.DialogResult =DialogResult.Ignore
            End If
        Else
            btnMoveInsurance.Enabled = False
            btnPrint.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If add = False Then
            loadData()
            chknewclient.Enabled = False
            txtClientid.Enabled = False
            txtCounterid.Enabled = False
            'txtinitialvalue.ReadOnly = True
            'txtinitialvalue.BackColor = Color.FromArgb(224, 224, 224)
            txtname.Enabled = False
            txtcurrentcounterval.ReadOnly = True
            txtcurrentcounterval.BackColor = Color.FromArgb(224, 224, 224)
        Else
            txtregdate.Text = Date.Today
            btnEndReg.Enabled = False
            btnAllowInsuranceEdit.Enabled = False
            txtpaidinsurance.ReadOnly = False
            txtpaidinsurance.BackColor = Color.FromArgb(192, 255, 192)
        End If

        If Not chkActive.Checked Then
            chknewclient.Enabled = False
            txtClientid.Enabled = False
            btnsave.Enabled = False
            btnEndReg.Enabled = False
            txtpackid.Enabled = False
            txtnotes.ReadOnly = True
            txtnotes.BackColor = Color.FromArgb(224, 224, 224)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If checkEmpty() Then
            MsgBox("الرجاء التأكد من تعبئة جميع الخانات المطلوبة.")
            Return
        End If
        If Not isInsuranceValid() Then
            MsgBox("يجب ان لا تتعدّى قيمة التأمين المدفوعة قيمة التأمين على الاشتراك.")
            Return
        End If
        a.ds = New DataSet

        If add = False Then
            If chkActive.Checked <> active Then
                If active = True And chkActive.Checked = False Then
                    a.Execute("Update Client Set clientname='" & txtname.Text.Trim & "',clientnickname='" & txtnickname.Text.Trim & "',clientmothername='" & txtmothername.Text.Trim & "',caddress='" & txtaddress.Text.Trim & "',phone='" & txtphone.Text.Trim & "',mobile='" & txtmobile.Text.Trim & "' Where ID=" & clientid)
                    a.Execute("update Registration set active = 0,notes='" & txtnotes.Text.Trim & "',insurance=" & txtpaidinsurance.Text.Trim & ",packageid=" & txtpackid.Text.Trim & " where ID=" & regid)
                    a.Execute("update ECounter set active = 0 where ID =" & counterid)
                ElseIf active = False And chkActive.Checked = True Then
                    a.GetData("Select active from ECounter where ID=" & Integer.Parse(txtCounterid.Text.Trim), "dt2")
                    If Boolean.Parse(a.ds.Tables("dt2").Rows(0).Item(0).ToString) = False Then
                        a.Execute("Update Client Set clientname='" & txtname.Text.Trim & "',clientnickname='" & txtnickname.Text.Trim & "',clientmothername='" & txtmothername.Text.Trim & "',caddress='" & txtaddress.Text.Trim & "',phone='" & txtphone.Text.Trim & "',mobile='" & txtmobile.Text.Trim & "' Where ID=" & clientid)
                        a.Execute("update Registration set active= 1,notes='" & txtnotes.Text.Trim & "',insurance=" & txtpaidinsurance.Text.Trim & ",packageid=" & txtpackid.Text.Trim & " where ID=" & regid)
                        a.Execute("update ECounter set active = 1 where ID=" & Integer.Parse(txtCounterid.Text.Trim))
                    Else
                        MsgBox("لا يمكنك تفعيل هذا الاشتراك على العدّاد الذي اخترته لانه محجوز من قبل مشترك آخر")
                        Return
                    End If
                End If
            Else
                a.Execute("Update Client Set clientname='" & txtname.Text.Trim & "',clientnickname='" & txtnickname.Text.Trim & "',clientmothername='" & txtmothername.Text.Trim & "',caddress='" & txtaddress.Text.Trim & "',phone='" & txtphone.Text.Trim & "',mobile='" & txtmobile.Text.Trim & "' Where ID=" & clientid)
                a.Execute("update Registration set notes='" & txtnotes.Text.Trim & "',insurance=" & txtpaidinsurance.Text.Trim & ",packageid=" & txtpackid.Text.Trim & " where ID=" & regid)
            End If
            If counterid <> Integer.Parse(txtCounterid.Text.Trim) Then
                If active Then
                    a.Execute("update ECounter set active = 0 where ID=" & counterid)
                End If
                If chkActive.Checked = True Then
                    a.Execute("update ECounter set active = 1 where ID=" & Integer.Parse(txtCounterid.Text.Trim))
                End If
            End If
        Else
            If txtcurrentcounterval.Text.Trim.Length = 0 Then
                txtcurrentcounterval.Text = "0"
            Else
                If Not txtcurrentcounterval.Text.Trim.Equals("0") Then
                    Dim dlg As New CustomMsgDialog("إنتبه", "العداد الذي قمت بإختياره مستعمل ولذلك قيمة الحاليّة أكبر من صفر مما يعني أن المشترك الجديد سيتابع استخدامه من القيمة القديمة." & vbNewLine & vbNewLine & "إنقر على ’كلا‘ للعودة وتعديل القيمة يدوياً أو على ’نعم‘ للمتابعة.", 10)
                    If dlg.ShowDialog <>DialogResult.Yes Then
                        Return
                    End If
                End If

            End If


            If chknewclient.Checked Then
                Dim cid As Integer = a.Execute("insert into Client(clientname,clientnickname,clientmothername,caddress,phone,mobile) values('" & txtname.Text.Trim & "','" & txtnickname.Text.Trim & "','" & txtmothername.Text.Trim & "','" & txtaddress.Text.Trim & "','" & txtphone.Text.Trim & "','" & txtmobile.Text.Trim & "')")
                regid = a.Execute("insert into Registration(clientid,registrationdate,packageid,counterid,notes,active,insurance) values(" & cid & ",'" & Date.Today & "'," & txtpackid.Text.Trim & "," & txtCounterid.Text.Trim & ",'" & txtnotes.Text.Trim & "',1," & txtpaidinsurance.Text.Trim & ")")
            Else
                regid = a.Execute("insert into Registration(clientid,registrationdate,packageid,counterid,notes,active,insurance) values(" & txtClientid.Text.Trim & ",'" & Date.Today & "'," & txtpackid.Text.Trim & "," & txtCounterid.Text.Trim & ",'" & txtnotes.Text.Trim & "',1," & txtpaidinsurance.Text.Trim & ")")
            End If

            If Not txtcurrentcounterval.Text.Trim.Equals("0") Then
                a.Execute("insert into CounterHistory(cmonth,cyear,regid,previousvalue,currentvalue) Values(1,2000," & regid & "," & txtcurrentcounterval.Text.Trim & "," & txtcurrentcounterval.Text.Trim & ")")
            End If

            a.Execute("update ECounter set active = 1,currentvalue=" & txtcurrentcounterval.Text.Trim & " where ID=" & Integer.Parse(txtCounterid.Text.Trim))
        End If

        Dim currentinsurence As Integer = 0
        If txtpaidinsurance.Text.Trim.Length > 0 Then
            currentinsurence = txtpaidinsurance.Text.Trim
        End If
        Dim tinsertInsure As Integer = currentinsurence - paidInsurenceAmount
        Dim title As String = "قبض تأمين"
        If tinsertInsure < 0 Then
            title = "استرداد تأمين"
        End If
        If tinsertInsure <> 0 Then
            a.Execute("insert into Expenditure(expdate,title,amount,party,detail) values('" & Date.Now & "','" & title & "'," & tinsertInsure & ",'" & txtname.Text.Trim & "','" & "اشتراك رقم " & regid & "')")
        End If

        If chkprintreport.Checked Then
            If Not currentUser.hasPermision("dataexport") Then
                MessageBox.Show("ليس لديك صلاحيّة لطباعة وصل تأمين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim reportViewer As New XtraReportViewer("وصل تأمين", "بموجب هذا الوصل يستطيع السيّد/ة " & txtname.Text & " المحترم/ة تحصيل مبلغ التأمين وقدره " & txtpaidinsurance.Text.Trim & " ل.ل وذلك بعد انهاء الاشتراك رقم: " & regid, "", "")
                reportViewer.ShowDialog()
            End If
        End If


        Me.DialogResult =DialogResult.OK
    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("SELECT c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي],r.registrationdate as [تاريخ الاشتراك],p.ID as [معرّف النوع],p.ampere as [أمبير],p.fee as [رسم الاشتراك],p.insurance as [مبلغ التأمين],p.kilowattprice as [سعر الكيلوات],b.code as [رمز العلبة],b.location as [عنوان العلبة],ec.ID as[معرّف العدّاد],ec.serial as[رمز العدّاد],ec.code as [الرمز في العلبة],r.notes AS [ملاحظات],r.active,r.clientid,r.enddate,r.insurance,ec.currentvalue FROM Registration r,Client c,ElectricBox b,ECounter ec,Package p WHERE r.packageid = p.ID and r.counterid = ec.ID and ec.boxid = b.ID and c.id=r.clientid and r.id=" & regid)
            txtname.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            txtnickname.Text = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtmothername.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtaddress.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            txtphone.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
            txtmobile.Text = a.ds.Tables(0).Rows(0).Item(5).ToString
            txtregdate.Text = Date.Parse(a.ds.Tables(0).Rows(0).Item(6).ToString).ToShortDateString
            txtpackid.Text = a.ds.Tables(0).Rows(0).Item(7).ToString
            txtpackampere.Text = a.ds.Tables(0).Rows(0).Item(8).ToString
            txtpackfee.Text = a.ds.Tables(0).Rows(0).Item(9).ToString
            txtpackinsurence.Text = a.ds.Tables(0).Rows(0).Item(10).ToString
            txtpackkiloprice.Text = a.ds.Tables(0).Rows(0).Item(11).ToString
            txtboxcode.Text = a.ds.Tables(0).Rows(0).Item(12).ToString
            txtboxlocation.Text = a.ds.Tables(0).Rows(0).Item(13).ToString
            txtCounterid.Text = a.ds.Tables(0).Rows(0).Item(14).ToString
            counterid = Integer.Parse(txtCounterid.Text)
            txtcounterserial.Text = a.ds.Tables(0).Rows(0).Item(15).ToString
            txtcountercode.Text = a.ds.Tables(0).Rows(0).Item(16).ToString
            txtnotes.Text = a.ds.Tables(0).Rows(0).Item(17).ToString
            chkActive.Checked = Boolean.Parse(a.ds.Tables(0).Rows(0).Item(18).ToString)
            txtClientid.Text = a.ds.Tables(0).Rows(0).Item(19).ToString
            txtpaidinsurance.Text = a.ds.Tables(0).Rows(0).Item(21).ToString
            paidInsurenceAmount = txtpaidinsurance.Text
            txtcurrentcounterval.Text = a.ds.Tables(0).Rows(0).Item(22).ToString
            Try
                txtregenddate.Text = Date.Parse(a.ds.Tables(0).Rows(0).Item(20).ToString).ToShortDateString
            Catch ex As Exception
            End Try

            active = chkActive.Checked
            If Not active Then
                chkActive.Text = "غير مفعّل"
                chkActive.BackColor = Color.FromArgb(255, 192, 192)
            End If
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult =DialogResult.Ignore
        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txtname.Text.Trim.Length = 0 OrElse txtCounterid.Text.Trim.Length = 0 OrElse txtpackid.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult =DialogResult.Ignore
    End Sub

    Private Sub txtcounterid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCounterid.DoubleClick
        Dim frm1 As New frmChooser(COUNTER_NOT_ACTIVE_CHOOSER)
        If frm1.ShowDialog() =DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                txtCounterid.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtcounterserial.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtcountercode.Text = frm1.dgvData.SelectedRows(0).Cells(2).Value.ToString
                txtboxcode.Text = frm1.dgvData.SelectedRows(0).Cells(3).Value.ToString
                txtboxlocation.Text = frm1.dgvData.SelectedRows(0).Cells(4).Value.ToString
                txtcurrentcounterval.Text = frm1.dgvData.SelectedRows(0).Cells(6).Value.ToString
                chkActive.Checked = True
                'Try
                '    Dim counterLatestVal As Integer = a.ExecuteScalar("select max(currentvalue) from CounterHistory c,Registration r where r.counterid = " & Integer.Parse(txtCounterid.Text.Trim) & " and r.ID=c.regid")
                '    txtinitialvalue.Text = counterLatestVal
                'Catch ex As Exception
                '    txtinitialvalue.Text = 0
                'End Try

            End If
        End If
    End Sub

    Private Sub txtCounterid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCounterid.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtcounterid_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtpackid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtpackid.DoubleClick
        Dim frm1 As New frmChooser(PACKAGE_CHOOSER)
        If frm1.ShowDialog() =DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                txtpackid.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtpackampere.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtpackfee.Text = frm1.dgvData.SelectedRows(0).Cells(2).Value.ToString
                txtpackinsurence.Text = frm1.dgvData.SelectedRows(0).Cells(3).Value.ToString
                txtpackkiloprice.Text = frm1.dgvData.SelectedRows(0).Cells(4).Value.ToString
            End If
        End If
    End Sub

    Private Sub txtpackid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpackid.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtpackid_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtClientid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtClientid.MouseDoubleClick
        Dim frm1 As New frmChooser(CLIENT_CHOOSER)
        If frm1.ShowDialog() =DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                'Dim count As Integer = a.ExecuteScalar("select count(r.ID) from Registration r,Client c where r.clientid = c.ID and r.active=1 and c.ID = " & frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString)
                'If count = 0 Then
                txtClientid.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtname.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtnickname.Text = frm1.dgvData.SelectedRows(0).Cells(2).Value.ToString
                txtmothername.Text = frm1.dgvData.SelectedRows(0).Cells(3).Value.ToString
                txtaddress.Text = frm1.dgvData.SelectedRows(0).Cells(4).Value.ToString
                txtphone.Text = frm1.dgvData.SelectedRows(0).Cells(5).Value.ToString
                txtmobile.Text = frm1.dgvData.SelectedRows(0).Cells(6).Value.ToString
                'Else
                '    MsgBox("لا يمكن اختيار هذا المشترك لأن لديه اشتراك جاري باسمه.")
                'End If
            End If
        End If
    End Sub

    Private Sub txtClientid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClientid.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtClientid_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtinitialvalue_KeyPress(sender As Object, e As KeyPressEventArgs)
        a.bindNumeric(sender, e)
    End Sub

    Private Sub chknewclient_CheckedChanged(sender As Object, e As EventArgs) Handles chknewclient.CheckedChanged
        If chknewclient.Checked Then
            txtClientid.Enabled = False
            txtname.ReadOnly = False
            txtnickname.ReadOnly = False
            txtmothername.ReadOnly = False
            txtaddress.ReadOnly = False
            txtphone.ReadOnly = False
            txtmobile.ReadOnly = False
            txtname.BackColor = Color.White
            txtnickname.BackColor = Color.White
            txtmothername.BackColor = Color.White
            txtaddress.BackColor = Color.White
            txtphone.BackColor = Color.White
            txtmobile.BackColor = Color.White
        Else
            txtClientid.Enabled = True
            txtname.ReadOnly = True
            txtnickname.ReadOnly = True
            txtmothername.ReadOnly = True
            txtaddress.ReadOnly = True
            txtphone.ReadOnly = True
            txtmobile.ReadOnly = True
            txtname.BackColor = Color.FromArgb(224, 224, 224)
            txtnickname.BackColor = Color.FromArgb(224, 224, 224)
            txtmothername.BackColor = Color.FromArgb(224, 224, 224)
            txtaddress.BackColor = Color.FromArgb(224, 224, 224)
            txtphone.BackColor = Color.FromArgb(224, 224, 224)
            txtmobile.BackColor = Color.FromArgb(224, 224, 224)

        End If
        txtClientid.Clear()
        txtname.Clear()
        txtnickname.Clear()
        txtmothername.Clear()
        txtaddress.Clear()
        txtmobile.Clear()
        txtphone.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEndReg.Click
        Dim dr As DialogResult = MessageBox.Show("في حال الغاء الاشتراك الحالي لن تتمكّن من اعادة تفعيله." & vbNewLine & "هل انت متأكّد من انك تريد المتابعة؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr =DialogResult.Yes Then
            a.Execute("Update Client Set clientname='" & txtname.Text.Trim & "',clientnickname='" & txtnickname.Text.Trim & "',clientmothername='" & txtmothername.Text.Trim & "',caddress='" & txtaddress.Text.Trim & "',phone='" & txtphone.Text.Trim & "',mobile='" & txtmobile.Text.Trim & "' Where ID=" & clientid)
            a.Execute("update Registration set active=0,notes='" & txtnotes.Text.Trim & "',enddate='" & Date.Today & "' where ID=" & regid)
            a.Execute("update ECounter set active = 0 where ID=" & counterid)
            Me.DialogResult =DialogResult.OK
        End If
    End Sub

    Private Sub txtpackinsurence_TextChanged(sender As Object, e As EventArgs) Handles txtpackinsurence.TextChanged
        If txtpackinsurence.Text.Trim.Length > 0 Then
            txtpaidinsurance.Enabled = True
        Else
            txtpaidinsurance.Enabled = False
        End If
    End Sub

    Private Function isInsuranceValid() As Boolean
        If txtpackinsurence.Text.Trim.Length > 0 And txtpaidinsurance.Text.Trim.Length > 0 Then
            If Integer.Parse(txtpaidinsurance.Text) > Integer.Parse(txtpackinsurence.Text) Then
                Return False
            End If
        End If
        If txtpaidinsurance.Text.Trim.Length = 0 Then
            txtpaidinsurance.Text = 0
        End If
        Return True
    End Function

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnUpdateInsurance.Click
        If Not isInsuranceValid() Then
            MsgBox("يجب ان لا تتعدّى قيمة التأمين المدفوعة قيمة التأمين على الاشتراك.")
            Return
        End If
        Try

            a.Execute("update Registration set insurance=" & txtpaidinsurance.Text.Trim & " where ID=" & regid)
            Dim currentinsurence As Integer = 0
            If txtpaidinsurance.Text.Trim.Length > 0 Then
                currentinsurence = txtpaidinsurance.Text.Trim
            End If
            Dim tinsertInsure As Integer = currentinsurence - paidInsurenceAmount
            Dim title As String = "قبض تأمين"
            If tinsertInsure < 0 Then
                title = "استرداد تأمين"
            End If
            If tinsertInsure <> 0 Then
                a.Execute("insert into Expenditure(expdate,title,amount,party,detail) values('" & Date.Now & "','" & title & "'," & tinsertInsure & ",'" & txtname.Text.Trim & "','" & "اشتراك رقم " & regid & "')")
            End If
            btnAllowInsuranceEdit.Enabled = True
            txtpaidinsurance.ReadOnly = True
            txtpaidinsurance.BackColor = Color.FromArgb(224, 224, 224)
            btnUpdateInsurance.Enabled = False
            paidInsurenceAmount = txtpaidinsurance.Text.Trim
            'Me.DialogResult =DialogResult.Cancel
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim reportViewer As New XtraReportViewer("وصل تأمين", "بموجب هذا الوصل يستطيع السيّد/ة " & txtname.Text & " المحترم/ة تحصيل مبلغ التأمين وقدره " & txtpaidinsurance.Text.Trim & " ل.ل وذلك بعد انهاء الاشتراك رقم: " & regid, "", "")
        reportViewer.ShowDialog()
    End Sub

    Private Sub RegistrationEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub txtpaidinsurance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaidinsurance.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMoveInsurance.Click
        If paidInsurenceAmount > 0 Then
            Dim frm As New frmChooser(SharedModule.REGISTRATION_CHOOSER)
            If frm.ShowDialog() =DialogResult.OK Then
                If frm.dgvData.SelectedRows.Count > 0 Then
                    Try
                        Dim inToMoveID As Integer = frm.dgvData.SelectedRows(0).Cells(0).Value.ToString
                        a.ExecuteNoReturn("Update registration set insurance=(insurance + " & paidInsurenceAmount & ") where id =" & inToMoveID)
                        a.ExecuteNoReturn("Update registration set insurance=0 where id=" & regid)
                        txtpaidinsurance.Text = 0
                        txtpaidinsurance.Enabled = False
                        btnMoveInsurance.Enabled = False
                        MsgBox("تم نقل مبلغ التأمين بنجاح.")
                    Catch ex As Exception
                        ErrorDialog.showDlg(ex)
                    End Try

                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAllowInsuranceEdit.Click
        btnAllowInsuranceEdit.Enabled = False
        txtpaidinsurance.ReadOnly = False
        txtpaidinsurance.BackColor = Color.FromArgb(192, 255, 192)
        btnUpdateInsurance.Enabled = True
    End Sub

    Private Sub txtcurrentcounterval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcurrentcounterval.KeyPress
        a.bindNumeric(sender, e)
    End Sub
End Class
