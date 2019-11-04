Imports EEMS.SqlDBHelper

Public Class frmDiscountHandler

    Dim a As New Helper
    Dim selectionKeyReference As String = "discoutSelections"
    Dim selectedids As New List(Of Int32)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        loadData()
        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If
        'addCheckBoxToGridView(dgvData1, GridView1, "اضافة دفعة", 0, 50, AddressOf itemCheckSelected)

        'Me.RightToLeft = Windows.Forms.RightToLeft.Yes
        'Me.RightToLeftLayout = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub loadData()
        selectedids.Clear()
        Dim d As Date = DateTimePicker1.Value
        Dim y As Int16 = DateTimePicker1.Value.Year
        Dim m As Int16 = DateTimePicker1.Value.Month


        Dim q1 As String = "SELECT r.ID AS [المعرّف], " & _
                    "ch.ID AS [معرّف القيمة], " & _
                    " r.active AS مفعّل, en.ename AS [الموتور], " & _
                    " b.location AS [عنوان العلبة], " & _
                    " c.clientname AS [المشترك], " & _
                    " p.ampere AS [أمبير], " & _
                    " cl.fullname AS [الجابي], " & _
                    " b.code AS [رمز العلبة], " & _
                    " ec.code AS [الرمز في العلبة]," & _
                    " ch.previousvalue AS [القيمة السابقة], " & _
                    " ch.currentvalue AS [القيمة الحاليّة], " & _
                    " r.insurance AS [تأمين], "

        Dim q3 As String = " ch.notes AS [ملاحظات], ar.caption  + '-' + CAST(ch.cyear AS nvarchar(10))  AS [شهر], " & _
                            " (b.code + ec.code) AS [رمز مفتاح], " & _
                            " ch.monthlyfee AS [رسم اشتراك], " & _
                            " (ch.currentvalue-ch.previousvalue) AS [فرق عداد], " & _
                            " ch.kilowattprice AS [سعر الكيلو], " & _
                            " (((ch.currentvalue - ch.previousvalue) * ch.kilowattprice) + roundvalue) AS [مطلوب كيلو], " & _
                            " total + discount AS [المجموع], " & _
                            " discount AS [حسم], " & _
                            " ISNULL(SUM(pyy.pvalue), 0)  AS [مدفوع], " & _
                            " total - ISNULL(SUM(pyy.pvalue), 0) AS [باقي] " & _
                        " FROM Registration r" & _
                            " INNER JOIN Client c on r.clientid = c.ID" & _
                            " INNER JOIN Package p on r.packageid = p.ID" & _
                            " INNER JOIN (CounterHistory ch INNER JOIN ArabicMonth ar on ch.cmonth = ar.id LEFT OUTER JOIN Payment pyy on pyy.counterhistoryid = ch.ID) on r.ID = ch.regid " & _
                            " INNER JOIN (ECounter ec INNER JOIN (ElectricBox b INNER JOIN Engine en on b.engineid = en.ID INNER JOIN Collector cl on b.collectorid = cl.ID) on ec.boxid = b.ID) on r.counterid = ec.ID" & _
                            " WHERE  ch.cmonth = " & m & " and ch.cyear= " & y & " AND r.registrationdate < '" & d.ToShortDateString & "' " & _
                            " GROUP BY r.ID, ch.ID, r.active, en.ename, b.location, c.clientname, p.ampere, cl.fullname, b.code, ec.code, ch.previousvalue, " & _
                            " ch.currentvalue, r.insurance, ch.notes, ar.caption, ch.cyear, ch.monthlyfee, ch.kilowattprice, ch.roundvalue, ch.total, ch.discount" & _
                        " ORDER BY cl.fullname, b.code, ec.code"

        a.ds = New DataSet
        a.GetData(q1 + q3, "dti")
        dgvData1.DataSource = a.ds.Tables("dti")
        Dim exceptionList As New List(Of Integer)
        disableGridView(GridView1, exceptionList)

    End Sub

    Public Sub itemCheckSelected()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If GridView1.GetSelectedRows.Count = 0 Then
            MsgBox("يجب تحديد اسطر اولاً")
            Return
        End If

        Dim ml As New frmGeneralPerposeInput("اختر اسم لللائحة", "الاسم")
        Dim d As DialogResult = ml.ShowDialog()
        If d = Windows.Forms.DialogResult.OK Then
            If ml.PasswordTextBox.Text.Trim.Length > 0 Then
                a.ds = New DataSet
                Dim countFound As Int16 = a.ExecuteScalar("select count(*) from DefinedKeys where reference='" & selectionKeyReference.ToLower & "' and title ='" & ml.PasswordTextBox.Text.Trim.ToLower & "'")
                If countFound > 0 Then
                    MsgBox("اسم اللائحة موجود اساساً, الرجاء اختيار اسم اخر")
                    Return
                End If
                'Dim ids As New List(Of Int16)
                'For Each row As Integer In GridView1.GetSelectedRows
                '    ids.Add(Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString))
                'Next

                a.ExecuteNoReturn("insert into DefinedKeys (dkey,title,reference) values('" & String.Join(",", selectedids.ToArray) & "','" & ml.PasswordTextBox.Text.Trim.ToLower & "','" & selectionKeyReference.ToLower & "')")
                MsgBox("تمت العمليّة بنجاح")
            Else
                MsgBox("تأكد من ادخال اسم لللائحة اولاً")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim frm As New frmChooser(BULK_DISCOUNT_CHOOSER)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If frm.dgvData.SelectedRows.Count > 0 Then

                    Dim title As String = frm.dgvData.SelectedRows(0).Cells(0).Value.ToString.Trim().ToLower
                    a.ds = New DataSet
                    a.GetData("select Dkey from DefinedKeys where reference='" & selectionKeyReference.ToLower & "' and title ='" & title & "'")
                    Dim ids As String() = a.ds.Tables(0).Rows(0).Item(0).ToString.Split(",")
                    If GridView1.RowCount > 0 Then
                        For i As Integer = 0 To GridView1.RowCount - 1
                            If ids.Contains(GridView1.GetRowCellValue(i, GridView1.Columns(0)).ToString) Then
                                GridView1.SelectRow(i)
                            Else
                                GridView1.UnselectRow(i)
                            End If
                        Next
                    End If

                End If

            End If
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim frm As New frmChooser(BULK_DISCOUNT_CHOOSER)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If frm.dgvData.SelectedRows.Count > 0 Then
                    Dim title As String = frm.dgvData.SelectedRows(0).Cells(0).Value.ToString.Trim().ToLower
                    a.ExecuteNoReturn("delete from DefinedKeys where reference='" & selectionKeyReference.ToLower & "' and title ='" & title & "'")
                End If
            End If
            MsgBox("تمت العمليّة بنجاح")
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not currentUser.hasPermision("adddiscount") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Try

            If GridView1.GetSelectedRows.Count = 0 Then
                MsgBox("يجب تحديد اسطر اولاً")
                Return
            End If

            Dim dr As DialogResult = MessageBox.Show("تنبيه: أنت تقوم بإضافة حسم كلي لأكثر من زبون." & vbNewLine & "هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr <> Windows.Forms.DialogResult.Yes Then
                Return
            End If

            GridView1.ClearColumnsFilter()

            Dim queries As New List(Of String)
            Dim chId As Integer = 0
            Dim discount As Integer = 0
            For Each row As Integer In GridView1.GetSelectedRows
                chId = Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(1)))
                discount = Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(20))) - Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(22)))
                queries.Add("update CounterHistory set discount=" & discount & " where ID =" & chId & "")
            Next

            Dim result As Boolean = a.ExecuteInTransaction(queries)
            If result = True Then
                MsgBox("تمت العمليّة بنجاح")
            Else
                MsgBox("فشلت عملية التعديل، تم الغاء التعديلات")
            End If

            loadData()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        For Each row As Integer In GridView1.GetSelectedRows
            If Not selectedids.Contains(Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString)) Then
                selectedids.Add(Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(0)).ToString))
            End If
        Next

        Dim i As Int32 = 0
        For i = 0 To GridView1.RowCount - 1
            If Not GridView1.IsRowSelected(i) And selectedids.IndexOf(GridView1.GetDataRow(i).Item(0)) > -1 Then
                selectedids.Remove(GridView1.GetDataRow(i).Item(0))
            End If
        Next
    End Sub

    Private Sub GridView1_ColumnFilterChanged(sender As Object, e As EventArgs) Handles GridView1.ColumnFilterChanged
        Dim i As Int32 = 0
        For i = 0 To GridView1.RowCount - 1
            If selectedids.IndexOf(GridView1.GetDataRow(i).Item(0)) > -1 Then
                GridView1.SelectRow(i)
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not currentUser.hasPermision("adddiscount") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Try

            If GridView1.GetSelectedRows.Count = 0 Then
                MsgBox("يجب تحديد اسطر اولاً")
                Return
            End If

            Dim discount As Integer = 0

            Dim ml As New frmGeneralPerposeInput("ادخل قيمة الحسم", "القيمة", True)
            Dim d As DialogResult = ml.ShowDialog()
            If d = Windows.Forms.DialogResult.OK Then
                If ml.PasswordTextBox.Text.Trim.Length > 0 Then
                    discount = ml.PasswordTextBox.Text.Trim
                Else
                    Return
                End If
            Else
                Return
            End If

            GridView1.ClearColumnsFilter()

            Dim chIds As String = ""
            For Each row As Integer In GridView1.GetSelectedRows
                chIds = chIds & GridView1.GetRowCellValue(row, GridView1.Columns(1)).ToString & ","
                If Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(21)).ToString) + discount > Integer.Parse(GridView1.GetRowCellValue(row, GridView1.Columns(23)).ToString) Then
                    MsgBox("لا يمكن تعميم هذا الحسم على الاشتراكات التي تم اختيارها لأن البعض منها لديه باقي اقل من الحسم المطلوب.")
                    Return
                End If
            Next
            chIds = chIds.Substring(0, chIds.Length - 1)
            a.ExecuteNoReturn("update CounterHistory set discount=discount + " & discount & " where ID in (" & chIds & ")")
            MsgBox("تمت العمليّة بنجاح")
            loadData()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub
End Class