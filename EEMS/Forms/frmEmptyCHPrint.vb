Public Class frmEmptyCHPrint

    Dim a As New SqlDBHelper.Helper
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            a.ds = New DataSet
            a.GetData("Select id, fullname from collector", "dt1")
            Dim dr1 As DataRow = a.ds.Tables("dt1").NewRow
            dr1.ItemArray = New Object() {-1, "الجميع"}
            a.ds.Tables("dt1").Rows.InsertAt(dr1, 0)
            cmbCollector.DataSource = a.ds.Tables("dt1")
            cmbCollector.DisplayMember = "fullname"
            cmbCollector.ValueMember = "id"

            a.GetData("Select id, ename from Engine", "dt2")
            Dim dr2 As DataRow = a.ds.Tables("dt2").NewRow
            dr2.ItemArray = New Object() {-1, "الجميع"}
            a.ds.Tables("dt2").Rows.InsertAt(dr2, 0)
            cmbEngine.DataSource = a.ds.Tables("dt2")
            cmbEngine.DisplayMember = "ename"
            cmbEngine.ValueMember = "id"

            For Each row As DataRow In a.ds.Tables(0).Rows
                cmbCollector.Items.Add(row.Item(0).ToString)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowPrint_Click(sender As Object, e As EventArgs) Handles btnShowPrint.Click
        Try
            If cmbCollector.SelectedIndex = -1 Or cmbEngine.SelectedIndex = -1 Then
                MsgBox("الرجاء التأكد من اختيار الجابي والمولد للمتابعة.")
                Return
            End If

            Dim Year As Int16 = dtp.Value.Year
            Dim Month As Int16 = dtp.Value.Month

            a.ds = New DataSet

            Dim query As String = "SELECT en.ename as [الموتور],c.clientname as [المشترك],b.code as [رمز العلبة],b.location as [عنوان العلبة]," & _
                        "	p.ampere as [أمبير],ec.serial as [رقم العداد],ec.code as [الرمز في العلبة]," & _
                        "	IsNull((Select MAX(chh.currentvalue) From CounterHistory chh Where chh.regid = r.ID),0) AS [القيمة السابقة],'' as [القيمة الحاليّة],'" & CType(cmbCollector.SelectedItem, DataRowView).Item(1).ToString.Trim & "' as [الجابي]" & _
                        " FROM Registration r JOIN Client c ON r.clientid = c.ID" & _
                        "	JOIN ECounter ec ON r.counterid = ec.ID JOIN ElectricBox b ON ec.boxid=b.id JOIN Engine en ON b.engineid=en.id" & _
                        "	JOIN Collector cl ON b.collectorid=cl.id JOIN Package p ON r.packageid=p.id RIGHT JOIN CounterHistory ch ON r.counterid=ch.id" & _
                        " WHERE (DatePart(yyyy, r.registrationdate) < " & Year & " Or (DatePart(m, r.registrationdate) <= " & Month & " And DatePart(yyyy, r.registrationdate) = " & Year & "))" & _
                        " and r.ID not in (Select regID from CounterHistory where cmonth = " & Month & " and cyear = " & Year & ")"

            If cmbEngine.SelectedIndex > 0 Then
                query = query & " and en.id = " & cmbEngine.SelectedValue
            End If

            If cmbCollector.SelectedIndex > 0 Then
                query = query & " and cl.id = " & cmbCollector.SelectedValue
            End If

            query = query & " order by en.ename, b.code"

            a.GetData(query, "EmptyCHDT")
            Dim rprt As New frmReportViewer(a.ds.Tables(0))
            rprt.ShowDialog()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("فشل اثناء محاولة تحميل البيانات." & vbNewLine & ex.Message, "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class