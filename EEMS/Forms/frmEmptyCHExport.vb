Public Class frmEmptyCHExport

    Dim a As New SqlDBHelper.Helper

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim Year As Int16 = dtp.Value.Year
            Dim Month As Int16 = dtp.Value.Month

            a.ds = New DataSet

            Dim boxQuery As String = If(chkShowBoxID.Checked, "b.ID as [معرّف العلبة]", "b.code as [رمز العلبة]")

            Dim query As String = "SELECT r.ID as [رمز اللإشتراك],en.ename as [المولد],c.clientname as [المشترك]," & boxQuery & ",b.location as [عنوان العلبة]," &
                        "	p.ampere as [أمبير],ec.serial as [رقم العداد],ec.code as [الرمز في العلبة],'" & $"{Month}-{Year}" & "' as [عن شهر], " &
                        "	IsNull((Select MAX(chh.currentvalue) From CounterHistory chh Where chh.regid = r.ID),0) AS [القيمة السابقة],'' as [القيمة الحاليّة]" &
                        " FROM Registration r JOIN Client c ON r.clientid = c.ID" &
                        "	JOIN ECounter ec ON r.counterid = ec.ID JOIN ElectricBox b ON ec.boxid=b.id JOIN Engine en ON b.engineid=en.id" &
                        "	JOIN Collector cl ON b.collectorid=cl.id JOIN Package p ON r.packageid=p.id LEFT OUTER JOIN CounterHistory ch ON r.counterid=ch.id" &
                        " WHERE (DatePart(yyyy, r.registrationdate) < " & Year & " Or (DatePart(m, r.registrationdate) <= " & Month & " And DatePart(yyyy, r.registrationdate) = " & Year & "))" &
                        " and r.ID not in (Select regID from CounterHistory where cmonth = " & Month & " and cyear = " & Year & ")"

            If Not CheckBox1.Checked Then
                query += " and r.active=1"
            End If

            query = query & " order by en.ename, " & If(chkShowBoxID.Checked, "b.id", "b.code") & ""

            a.GetData(query, "EmptyCHDT")
            Dim ex As New ExcelExporter()
            ex.ExportDataToExcell(a.ds.Tables("EmptyCHDT"), "CH")
            MessageBox.Show("تمت العمليّة بنجاح")
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("فشل اثناء محاولة تحميل البيانات." & vbNewLine & ex.Message, "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class