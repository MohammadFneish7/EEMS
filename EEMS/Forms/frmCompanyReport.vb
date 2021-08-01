Imports EEMS.SqlDBHelper

Public Class frmCompanyReport

    Dim a As New Helper
    Dim dt, dtEngineLoad, dtEnginAmpere, dtGeneralReport, dtItems, dtFuelConsumption, dtMaintainance, dtExpenditureAll, dtExpenditureNegatives, dtExpenditurePositives, dtAmpere, dtAmperePerEngine, dtWorkingHours, dtEngineEfficiency As New DataTable

    Dim ds As New DataSetGeneralReport

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()
    End Sub

    Private Function getNewRegs() As Long
        Dim newReg As Long = a.ExecuteScalar("SELECT COUNT(*) FROM Registration WHERE DatePart(""yyyy"",registrationdate)=" & dtp1.Value.Year & " AND DatePart(""m"",registrationdate)=" & dtp1.Value.Month)
        btnNewReg.Text = "اشتراكات جديدة" & vbNewLine & vbNewLine & newReg.ToString("N0")
        Return newReg
    End Function

    Private Function getInactiveRegs() As Long
        Dim inactiveReg As Long = a.ExecuteScalar("SELECT COUNT(*) FROM Registration WHERE DatePart(""yyyy"",enddate)=" & dtp1.Value.Year & " AND DatePart(""m"",enddate)=" & dtp1.Value.Month & " and active=0")
        btnInactiveReg.Text = "اشتراكات منتهية" & vbNewLine & vbNewLine & inactiveReg.ToString("N0")
        Return inactiveReg
    End Function

    Private Function getActiveRegs() As Long
        Dim activeReg As Long = a.ExecuteScalar("SELECT COUNT(*) FROM Registration WHERE active=1")
        btnActive.Text = "اجمالي اشتراكات فاعلة" & vbNewLine & vbNewLine & activeReg.ToString("N0")
        Return activeReg
    End Function

    Private Function getWorkingHours() As Long
        Dim workHours As Long = a.ExecuteScalar("SELECT IsNull(MAX(workinghours),0) FROM EngineWorkingHours w WHERE w.cyear=" & dtp1.Value.Year & " AND w.cmonth=" & dtp1.Value.Month)
        btnSupplyHours.Text = "ساعات التغذية" & vbNewLine & vbNewLine & workHours.ToString("N0")
        Return workHours
    End Function

    Private Function getSellKW() As Long
        Dim sellKW As Long = a.ExecuteScalar("SELECT IsNull(SUM(coh.currentvalue-coh.previousvalue),0) FROM CounterHistory coh WHERE coh.cyear=" & dtp1.Value.Year & " AND coh.cmonth=" & dtp1.Value.Month)
        btnSellKW.Text = "مبيع كيلوات" & vbNewLine & vbNewLine & sellKW.ToString("N0") & " KW"
        Return sellKW
    End Function

    Private Function getTotalKW() As Long
        Dim totalKW As Long = a.ExecuteScalar("SELECT IsNull(SUM([kilowattprice]),0) FROM CounterHistory coh WHERE coh.cyear=" & dtp1.Value.Year & " AND coh.cmonth=" & dtp1.Value.Month)
        btnTotalKW.Text = "اجمالي كيلوات" & vbNewLine & vbNewLine & totalKW.ToString("N0") & " ل.ل"
        Return totalKW
    End Function

    Private Function getTotalFee() As Long
        Dim totalFee As Long = a.ExecuteScalar("SELECT IsNull(SUM(monthlyFee),0) FROM CounterHistory coh WHERE coh.cyear=" & dtp1.Value.Year & " AND coh.cmonth=" & dtp1.Value.Month)
        btnTotalFee.Text = "اجمالي رسوم اشتراكات" & vbNewLine & vbNewLine & totalFee.ToString("N0") & " ل.ل"
        Return totalFee
    End Function

    Private Function getTotalRound() As Long
        Dim totalRound As Long = a.ExecuteScalar("SELECT IsNull(SUM(roundvalue),0) FROM CounterHistory coh WHERE coh.cyear=" & dtp1.Value.Year & " AND coh.cmonth=" & dtp1.Value.Month)
        btnTotalRound.Text = "اجمالي تدوير" & vbNewLine & vbNewLine & totalRound.ToString("N0") & " ل.ل"
        Return totalRound
    End Function

    Private Function getTotalDiscount() As Long
        Dim totalDiscount As Long = a.ExecuteScalar("SELECT IsNull(SUM(discount),0) FROM CounterHistory coh WHERE coh.cyear=" & dtp1.Value.Year & " AND coh.cmonth=" & dtp1.Value.Month)
        btntotalDiscount.Text = "اجمالي حسومات" & vbNewLine & vbNewLine & totalDiscount.ToString("N0") & " ل.ل"
        Return totalDiscount
    End Function

    Private Function getNumberOfInvoices() As Long
        Dim totalNumberOfInvoices As Long = a.ExecuteScalar("SELECT IsNull(count(coh.id),0) FROM CounterHistory coh WHERE coh.cyear=" & dtp1.Value.Year & " AND coh.cmonth=" & dtp1.Value.Month)
        btnNumberOfInvoices.Text = "عدد الفواتير" & vbNewLine & vbNewLine & totalNumberOfInvoices.ToString("N0")
        Return totalNumberOfInvoices
    End Function

    Private Function getValueOfInvoices(totalKW As Long, totalFee As Long, totalRound As Long, totalDiscount As Long) As Long
        Dim totalValueOfInvoices As Long = totalKW + totalFee + totalRound - totalDiscount
        btnTotalInvoicesValue.Text = "قيمة الفواتير" & vbNewLine & vbNewLine & totalValueOfInvoices.ToString("N0") & " ل.ل"
        Return totalValueOfInvoices
    End Function

    Private Function getPaidValueOfInvoices() As Long
        Dim totalPaidValueOfInvoices As Long = a.ExecuteScalar("select IsNull(sum(Cast(p.pvalue AS BIGINT)),0) as summation from CounterHistory ch inner join Payment p on ch.ID=p.counterhistoryid WHERE ch.cyear=" & dtp1.Value.Year & " AND ch.cmonth=" & dtp1.Value.Month)
        btnTotalPaidValueOfInvoices.Text = "قيمة المقبوض من الفواتير" & vbNewLine & vbNewLine & totalPaidValueOfInvoices.ToString("N0") & " ل.ل"
        Return totalPaidValueOfInvoices
    End Function

    Private Function getRemValueOfInvoices(totalValueOfInvoices As Long, totalPaidValueOfInvoices As Long) As Long
        Dim totalRemValueOfInvoices As Long = totalValueOfInvoices - totalPaidValueOfInvoices
        btnTotalRemValueOfInvoices.Text = "باقي غير مقبوض من الفواتير" & vbNewLine & vbNewLine & totalRemValueOfInvoices.ToString("N0") & " ل.ل"
        Return totalRemValueOfInvoices
    End Function

    Private Function getTotalValueOfInvoicesTillNow() As Int64
        Dim totalValueOfInvoicesTillNow As Int64 = a.ExecuteScalarAsObject("select IsNull(sum(Cast(ch.total as BIGINT)),0)  as summation from CounterHistory ch  where ch.cyear < " & dtp1.Value.Year & " OR (ch.cmonth <= " & dtp1.Value.Month & " and ch.cyear = " & dtp1.Value.Year & ")")
        btnTotalInvoicesTillNow.Text = "اجمالي قيمة الفواتير حتى تاريخه" & vbNewLine & vbNewLine & totalValueOfInvoicesTillNow.ToString("N0") & " ل.ل"
        Return totalValueOfInvoicesTillNow
    End Function

    Private Function getTotalPaidValueOfInvoicesTillNow() As Long
        Dim totalPaidValueOfInvoicesTillNow As Long = a.ExecuteScalar("select IsNull(sum(Cast(p.pvalue AS BIGINT)),0) as summation from CounterHistory ch join Payment p on ch.ID = p.counterhistoryid where ch.cyear < " & dtp1.Value.Year & " OR (ch.cmonth < " & dtp1.Value.Month & " and ch.cyear = " & dtp1.Value.Year & ")")
        btnTotalPaidInvoicesTillNow.Text = "اجمالي قبض فواتير حتى تاريخه" & vbNewLine & vbNewLine & totalPaidValueOfInvoicesTillNow.ToString("N0") & " ل.ل"
        Return totalPaidValueOfInvoicesTillNow
    End Function

    Private Function getTotalRemValueOfInvoicesTillNow(totalValueOfInvoicesTillNow As Int64, totalPaidValueOfInvoicesTillNow As Long) As Long
        Dim totalRemValueOfInvoicesTillNow As Int64 = totalValueOfInvoicesTillNow - totalPaidValueOfInvoicesTillNow
        btnTotalRemInvoicesTillNow.Text = "اجمالي غير مقبوض فواتير حتى تاريخه" & vbNewLine & vbNewLine & totalRemValueOfInvoicesTillNow.ToString("N0") & " ل.ل"
        Return totalRemValueOfInvoicesTillNow
    End Function

    Private Function getTotalCreditValueTillNow(totalRemValueOfInvoicesTillNow As Int64, totalRemValueOfInvoices As Long) As Long
        Dim totalCreditValue As Int64 = totalRemValueOfInvoicesTillNow - totalRemValueOfInvoices
        btnTotalCredit.Text = "اجمالي كسورات الاشهر السابقة" & vbNewLine & vbNewLine & totalCreditValue.ToString("N0") & " ل.ل"
        Return totalCreditValue
    End Function

    Private Function getTotalFuelPurhasesLetersValue() As Long
        Dim totalPurchaseLiterValue As Long = a.ExecuteScalar("select ISNUll(SUM(fp.pricetotal),0) as total FROM FuelPurchases fp WHERE MONTH(fp.indate) = " & dtp1.Value.Month & " AND YEAR(fp.indate) = " & dtp1.Value.Year)
        btnTotalFuelLeter.Text = "اجمالي شراء محروقات / ليتر" & vbNewLine & vbNewLine & totalPurchaseLiterValue.ToString("N0") & " ليتر"
        Return totalPurchaseLiterValue
    End Function

    Private Function getTotalFuelPurhasesPriceValue() As Long
        Dim totalPurchasePriceValue As Long = a.ExecuteScalar("select ISNUll(SUM(fp.quantity),0) as total FROM FuelPurchases fp WHERE MONTH(fp.indate) = " & dtp1.Value.Month & " AND YEAR(fp.indate) = " & dtp1.Value.Year)
        btnTotalFuelPrice.Text = "اجمالي شراء محروقات / سعر" & vbNewLine & vbNewLine & totalPurchasePriceValue.ToString("N0") & " ل.ل"
        Return totalPurchasePriceValue
    End Function

    Private Function getTotalMaintainanceValue() As Long
        Dim totalMaintainancePriceValue As Long = a.ExecuteScalar("select ISNUll(SUM(m.pricetotal),0) as total FROM Maintenance m WHERE MONTH(m.indate) = " & dtp1.Value.Month & " AND YEAR(m.indate) = " & dtp1.Value.Year)
        btnTotalMaintainance.Text = "اجمالي صيانة + غيار زيت" & vbNewLine & vbNewLine & totalMaintainancePriceValue.ToString("N0") & " ل.ل"
        Return totalMaintainancePriceValue
    End Function

    Private Function getTotalPurhasesValue() As Long
        Dim totalPurchaseValue As Long = a.ExecuteScalar("select ISNUll(SUM(p.pricetotal),0) as total from Purchases p WHERE MONTH(p.indate) = " & dtp1.Value.Month & " AND YEAR(p.indate) = " & dtp1.Value.Year)
        btnTotalPurchases.Text = "اجمالي شراء أصناف" & vbNewLine & vbNewLine & totalPurchaseValue.ToString("N0") & " ل.ل"
        Return totalPurchaseValue
    End Function

    Private Function getTotalFuelConsumptionValue() As Long
        Dim totalFuelConsumptionValue As Long = a.ExecuteScalar("select ISNUll(SUM(fc.quantity),0)  FROM FuelConsumption fc Join Engine e ON fc.engineid=e.ID  WHERE MONTH(fc.outdate) = " & dtp1.Value.Month & " AND YEAR(fc.outdate) = " & dtp1.Value.Year)
        btnTotalFuelConsumption.Text = "إجمالي إستهلاك محروقات / ليتر" & vbNewLine & vbNewLine & totalFuelConsumptionValue.ToString("N0") & " ليتر"
        Return totalFuelConsumptionValue
    End Function

    Private Function getTotalInvoiceIn() As Long
        Dim totalInvoiceIn As Long = a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure ex where (ex.title='قبض' OR ex.title like '%قبض جباية%' OR ex.title='قبض مباشر') and DatePart(""yyyy"",ex.expdate)=" & dtp1.Value.Year & " AND DatePart(""m"",ex.expdate)=" & dtp1.Value.Month)
        btnIn.Text = "قبض فواتير" & vbNewLine & vbNewLine & totalInvoiceIn.ToString("N0") & " ل.ل"
        Return totalInvoiceIn
    End Function

    Private Function getTotalcredit() As Long
        Dim totalcredit As Long = a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure ex where (ex.title like '%قبض مكسورات%') and DatePart(""yyyy"",ex.expdate)=" & dtp1.Value.Year & " AND DatePart(""m"",ex.expdate)=" & dtp1.Value.Month)
        btnTotalCreditIn.Text = "قبض مكسورات" & vbNewLine & vbNewLine & totalcredit.ToString("N0") & " ل.ل"
        Return totalcredit
    End Function

    Private Function getTotalInsuranceIn() As Long
        Dim totalInsuranceIn As Long = a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure ex where ex.title='قبض تأمين' and DatePart(""yyyy"",ex.expdate)=" & dtp1.Value.Year & " AND DatePart(""m"",ex.expdate)=" & dtp1.Value.Month)
        btnInsuranceIn.Text = "قبض تأمين" & vbNewLine & vbNewLine & totalInsuranceIn.ToString("N0") & " ل.ل"
        Return totalInsuranceIn
    End Function

    Private Function getTotalInsuranceOut() As Long
        Dim totalInsuranceOut As Long = a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure ex where ex.title='استرداد تأمين' and DatePart(""yyyy"",ex.expdate)=" & dtp1.Value.Year & " AND DatePart(""m"",ex.expdate)=" & dtp1.Value.Month)
        btnInsuranceOut.Text = "استرداد تأمين" & vbNewLine & vbNewLine & totalInsuranceOut.ToString("N0") & " ل.ل"
        Return totalInsuranceOut
    End Function

    Private Function getTotalOtherIn(totalInvoiceIn As Long, totalcredit As Long, totalInsuranceIn As Long) As Long
        Dim totalOtherIn As Long = (a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure ex where ex.amount>0 AND DatePart(""yyyy"",ex.expdate)=" & dtp1.Value.Year & " AND DatePart(""m"",ex.expdate)=" & dtp1.Value.Month) - totalInvoiceIn - totalcredit - totalInsuranceIn)
        btnOtherIn.Text = "مداخيل اخرى" & vbNewLine & vbNewLine & totalOtherIn.ToString("N0") & " ل.ل"
        Return totalOtherIn
    End Function

    Private Function getTotalOtherOut(totalInsuranceOut As Long) As Long
        Dim totalOtherOut As Long = a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure ex where ex.amount<0 AND DatePart(""yyyy"",ex.expdate)=" & dtp1.Value.Year & " AND DatePart(""m"",ex.expdate)=" & dtp1.Value.Month) - totalInsuranceOut
        btnTotalOut.Text = "مصاريف اخرى" & vbNewLine & vbNewLine & totalOtherOut.ToString("N0") & " ل.ل"
        Return totalOtherOut
    End Function

    Private Function getPerviousMonthNet() As Long
        Dim latMonthDate As Date = dtp1.Value
        Dim perviousMonthNet As Long = a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure ex where DatePart(""yyyy"",ex.expdate)<" & latMonthDate.Year & "  OR (DatePart(""yyyy"",ex.expdate)=" & latMonthDate.Year & " AND DatePart(""m"",ex.expdate)<" & latMonthDate.Month & ")")
        btnPrevNet.Text = "صندوق الشهر الماضي" & vbNewLine & vbNewLine & perviousMonthNet.ToString("N0") & " ل.ل"
        Return perviousMonthNet
    End Function

    Private Function getAllNet() As Long
        Dim AllNet As Long = a.ExecuteScalar("SELECT IsNull(SUM(CAST(amount AS BIGINT)),0) FROM Expenditure")
        btnALLNet.Text = "صندوق تراكمي" & vbNewLine & vbNewLine & AllNet.ToString("N0") & " ل.ل"
        Return AllNet
    End Function

    Private Function getCurrentMonthNet(totalInvoiceIn As Long, totalcredit As Long, totalOtherIn As Long, totalInsuranceIn As Long, totalOtherOut As Long, totalInsuranceOut As Long) As Long
        Dim currentMonthNet As Long = totalInvoiceIn + totalcredit + totalOtherIn + totalInsuranceIn + totalOtherOut + totalInsuranceOut
        btnTotal.Text = "رصيد إجمالي" & vbNewLine & vbNewLine & currentMonthNet.ToString("N0") & " ل.ل"
        Return currentMonthNet
    End Function

    Private Sub loadCollectersReport()
        a.ds = New DataSet
        a.GetData(getCollectersReportQuery1(), "dt6")
        dt.Clear()
        dt.Merge(a.ds.Tables("dt6"))

        Dim dtcol2 As New DataTable
        a.GetData(getCollectersReportQuery2(), "dt14")
        dtcol2.Merge(a.ds.Tables("dt14"))

        If dtcol2.Rows.Count > 0 Then
            Dim dr As DataRow = dt.NewRow
            For i As Integer = 0 To dt.Columns.Count - 1 Step 1
                dr.Item(i) = dtcol2.Rows(0).Item(i)
            Next
            dt.Rows.Add(dr)
        End If
    End Sub

    Private Sub loadEnginesReport()
        a.ds = New DataSet
        a.GetData("select e.ename as [المولّد], count(r.active) as [عدد المشتركين] from Engine e, ElectricBox eb,ECounter ec, Registration r, Package p where eb.engineid=e.id and ec.boxid=eb.id and r.counterid = ec.id and r.packageid=p.id and r.active=1 group by e.ename", "dt8")
        dtEnginAmpere.Clear()
        dtEnginAmpere = New DataTable
        dtEnginAmpere.Merge(a.ds.Tables("dt8"))
        dtEnginAmpere.Columns.Add("اجمالي امبير")
        Dim ii As Long = 20
        For Each row As DataRow In dtEnginAmpere.Rows
            a.GetData("select sum(p.ampere) from Engine e, ElectricBox eb,ECounter ec, Registration r, Package p where eb.engineid=e.id and ec.boxid=eb.id and r.counterid = ec.id and r.packageid=p.id and r.active=1 and e.ename ='" & row.Item(0) & "' ", "dt" & ii)
            row.Item(2) = a.ds.Tables("dt" & ii).Rows(0).Item(0)
            ii = ii + 1
        Next
    End Sub

    Private Sub loadGeneralReport()
        a.GetData("SELECT r.ID as [المعرّف],r.active as مفعّل,en.ename as [الموتور],b.location as [عنوان العلبة],c.clientname as [المشترك], c.phone as [هاتف], c.mobile as [خلوي], p.title as [نوع الاشتراك], p.ampere as [أمبير]," &
                       " cl.fullname as [الجابي],b.code as [رمز العلبة],ec.code as [الرمز في العلبة],(b.code + ec.code) as [رمز مفتاح]," &
                       " IsNull(Max(ch.currentvalue),0) as [مجموع كيلوات (كيلو)]," &
                       " IsNull(Sum((ch.kilowattprice) + ch.roundvalue),0) as [اجمالي كيلوات + تدوير ل.ل]," &
                       " IsNull(sum(Cast(ch.monthlyfee AS BIGINT)),0) as [اجمالي رسوم ل.ل]," &
                       " IsNull(SUM(total + discount),0) as [اجمالي مطلوب ل.ل]," &
                       " IsNull(SUM(discount),0) as [اجمالي حسومات ل.ل]," &
                       " IsNull(SUM(total),0) as [صافي ل.ل]," &
                       " (SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.regid=r.ID) AS [اجمالي مدفوع ل.ل]," &
                       " (IsNull(SUM(total),0) - (SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.regid=r.ID )) AS [باقي ل.ل]," &
                       " r.insurance as [له تأمين ل.ل]" &
                       " FROM Registration r,Client c,ElectricBox b,ECounter ec,CounterHistory ch,Package p,Engine en,Collector cl,ArabicMonth ar " &
                       " WHERE r.packageid = p.ID And ch.cmonth = ar.ID And r.counterid = ec.ID And ec.boxid = b.ID And r.clientid = c.ID And ch.regid = r.ID And b.engineid = en.ID And b.collectorid = cl.ID" &
                       " GROUP BY r.ID,r.active,en.ename,b.location,c.clientname, c.phone, c.mobile,p.title, p.ampere,cl.fullname,b.code,ec.code,r.insurance,(b.code + ec.code)", "dt1")
        dtGeneralReport.Clear()
        dtGeneralReport.Merge(a.ds.Tables("dt1"))
    End Sub

    Private Sub loadItemsReport()
        a.ds = New DataSet
        a.GetData("select i.itemname as [الصنف], ISNUll(SUM(p.quantity),0) as [الكمية], ISNUll(SUM(p.pricetotal),0) as [اجمالي سعر ل.ل] From Purchases p JOIN Items i ON p.itemid = i.ID WHERE MONTH(p.indate) = " & dtp1.Value.Month & " AND YEAR(p.indate) = " & dtp1.Value.Year & " Group By i.itemname", "dt7")
        dtItems.Clear()
        dtItems.Merge(a.ds.Tables("dt7"))

        Dim sumQ, sumP As Long
        sumP = 0
        sumQ = 0
        For Each row As DataRow In dtItems.Rows
            sumQ = sumQ + row.Item(1)
            sumP = sumP + row.Item(2)
        Next
        Dim dr As DataRow = dtItems.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = sumQ
        dr.Item(2) = sumP
        dtItems.Rows.Add(dr)
    End Sub

    Private Sub loadFuelConsumptionReport()
        a.ds = New DataSet
        a.GetData("select e.ename as [اسم المولد], ISNUll(SUM(fc.quantity),0) as [الكمية] FROM FuelConsumption fc Join Engine e ON fc.engineid=e.ID  WHERE MONTH(fc.outdate) = " & dtp1.Value.Month & " AND YEAR(fc.outdate) = " & dtp1.Value.Year & " Group By e.ename", "dt8")
        dtFuelConsumption.Clear()
        dtFuelConsumption.Merge(a.ds.Tables("dt8"))

        Dim sumQ As Long
        sumQ = 0
        For Each row As DataRow In dtFuelConsumption.Rows
            sumQ = sumQ + row.Item(1)
        Next
        Dim dr As DataRow = dtFuelConsumption.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = sumQ
        dtFuelConsumption.Rows.Add(dr)
    End Sub

    Private Sub loadMaintainanceReport()
        a.ds = New DataSet
        a.GetData("select e.ename as [اسم المولد], m.mainaction as [نوع العمل], ISNUll(SUM(m.pricetotal),0) as [اجمالي سعر ل.ل] FROM Maintenance m Join Engine e ON m.engineid=e.ID  WHERE MONTH(m.indate) = " & dtp1.Value.Month & " AND YEAR(m.indate) = " & dtp1.Value.Year & " Group By m.mainaction ,e.ename", "dt9")
        dtMaintainance.Clear()
        dtMaintainance.Merge(a.ds.Tables("dt9"))

        Dim sumP As Long
        sumP = 0
        For Each row As DataRow In dtMaintainance.Rows
            sumP = sumP + row.Item(2)
        Next
        Dim dr As DataRow = dtMaintainance.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = ""
        dr.Item(2) = sumP
        dtMaintainance.Rows.Add(dr)
    End Sub

    Private Sub loadExpenditureAllReport()
        a.ds = New DataSet
        a.GetData("select e.title as [العنوان], ISNUll(SUM(e.amount),0) as [اجمالي ل.ل] FROM Expenditure e WHERE MONTH(e.expdate) = " & dtp1.Value.Month & " AND YEAR(e.expdate) = " & dtp1.Value.Year & " Group By e.title", "dt10")
        dtExpenditureAll.Clear()
        dtExpenditureAll.Merge(a.ds.Tables("dt10"))

        Dim sumP As Long
        sumP = 0
        For Each row As DataRow In dtExpenditureAll.Rows
            sumP = sumP + row.Item(1)
        Next
        Dim dr As DataRow = dtExpenditureAll.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = sumP
        dtExpenditureAll.Rows.Add(dr)
    End Sub

    Private Sub loadExpenditurePositivesReport()
        a.ds = New DataSet
        a.GetData("select e.title as [العنوان], ISNUll(SUM(e.amount),0) as [اجمالي ل.ل] FROM Expenditure e WHERE e.amount>0 AND MONTH(e.expdate) = " & dtp1.Value.Month & " AND YEAR(e.expdate) = " & dtp1.Value.Year & " Group By e.title", "dt12")
        dtExpenditurePositives.Clear()
        dtExpenditurePositives.Merge(a.ds.Tables("dt12"))

        Dim sumP As Long
        sumP = 0
        For Each row As DataRow In dtExpenditurePositives.Rows
            sumP = sumP + row.Item(1)
        Next
        Dim dr As DataRow = dtExpenditurePositives.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = sumP
        dtExpenditurePositives.Rows.Add(dr)
    End Sub

    Private Sub loadExpenditureNegativesReport(Optional ByVal asAbsolute As Boolean = False)
        a.ds = New DataSet

        If asAbsolute Then
            a.GetData("select e.title as [العنوان], ABS(ISNUll(SUM(e.amount),0)) as [اجمالي ل.ل] FROM Expenditure e WHERE e.amount<0 AND MONTH(e.expdate) = " & dtp1.Value.Month & " AND YEAR(e.expdate) = " & dtp1.Value.Year & " Group By e.title", "dt13")
        Else
            a.GetData("select e.title as [العنوان], ISNUll(SUM(e.amount),0) as [اجمالي ل.ل] FROM Expenditure e WHERE e.amount<0 AND MONTH(e.expdate) = " & dtp1.Value.Month & " AND YEAR(e.expdate) = " & dtp1.Value.Year & " Group By e.title", "dt13")
        End If

        dtExpenditureNegatives.Clear()
        dtExpenditureNegatives.Merge(a.ds.Tables("dt13"))

        Dim sumP As Long
        sumP = 0
        For Each row As DataRow In dtExpenditureNegatives.Rows
            sumP = sumP + row.Item(1)
        Next
        Dim dr As DataRow = dtExpenditureNegatives.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = sumP
        dtExpenditureNegatives.Rows.Add(dr)
    End Sub

    Private Sub loadWorkingHoursReport()
        a.ds = New DataSet
        a.GetData("SELECT e.ename as [المولّد],IsNull(SUM(w.workinghours),0) as [ساعات التغذية] FROM Engine e,EngineWorkingHours w where w.engineid=e.ID AND cmonth=" & dtp1.Value.Month & " AND cyear=" & dtp1.Value.Year & " Group By ename", "dt15")
        dtWorkingHours.Clear()
        dtWorkingHours.Merge(a.ds.Tables("dt15"))

        Dim sumP As Long
        sumP = 0
        For Each row As DataRow In dtWorkingHours.Rows
            sumP = sumP + row.Item(1)
        Next
        Dim dr As DataRow = dtWorkingHours.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = sumP
        dtWorkingHours.Rows.Add(dr)
    End Sub

    Private Sub loadAmpereReport()
        a.ds = New DataSet
        a.GetData("SELECT p.title as [أمبير], COUNT(r.packageid)  as [عدد الإشتراكات] FROM Package p,Registration r WHERE r.packageid=p.ID  and r.registrationdate<= '" & New Date(dtp1.Value.Year, dtp1.Value.Month, System.DateTime.DaysInMonth(dtp1.Value.Year, dtp1.Value.Month)).ToShortDateString & "' and r.active=1 Group By p.title, p.ampere Order By p.ampere Asc", "dt16")
        dtAmpere.Clear()
        dtAmpere.Merge(a.ds.Tables("dt16"))

        Dim sumP As Long
        sumP = 0
        For Each row As DataRow In dtAmpere.Rows
            sumP = sumP + row.Item(1)
        Next
        Dim dr As DataRow = dtAmpere.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(1) = sumP
        dtAmpere.Rows.Add(dr)
    End Sub

    Private Sub loadAmperePerEngineReport()
        a.ds = New DataSet
        a.GetData("SELECT e.ename as [المولّد], p.title as [أمبير], COUNT(r.packageid) as [عدد الإشتراكات] FROM Package p,Registration r,Engine e,ElectricBox eb,Ecounter ec WHERE r.active=1 and r.packageid=p.ID and r.counterid = ec.id and ec.boxid = eb.id and eb.engineid = e.id and r.registrationdate<= '" & New Date(dtp1.Value.Year, dtp1.Value.Month, System.DateTime.DaysInMonth(dtp1.Value.Year, dtp1.Value.Month)).ToShortDateString & "' Group By e.ename, p.title, p.ampere Order By e.ename, p.ampere", "dt17")
        dtAmperePerEngine.Clear()
        dtAmperePerEngine.Merge(a.ds.Tables("dt17"))

        Dim sumP As Long
        sumP = 0
        For Each row As DataRow In dtAmperePerEngine.Rows
            sumP = sumP + row.Item(2)
        Next
        Dim dr As DataRow = dtAmperePerEngine.NewRow
        dr.Item(0) = "إجمالي"
        dr.Item(2) = sumP
        dtAmperePerEngine.Rows.Add(dr)
    End Sub

    Private Sub loadEngineEfficiencyALLReport()
        a.ds = New DataSet
        a.GetData("Select A as [اسم المولّد], KW as [مجموع كيلوات KW], KWP as [إجمالي كيلوات ل.ل], MF as [إجمالي رسوم ل.ل], DIS as [إجمالي حسومات ل.ل], RND as [إجمالي تدوير ل.ل], totalInvoice as [اجمالي قيمة الفواتير ل.ل], fcQuantity as [استهلاك وقود / ليتر],maintain as [اجمالي صيانة + غيار زيت ل.ل]  From (" &
                    " (select e1.ename as 'A', ISNUll(SUM(fc.quantity),0) as fcQuantity, ISNUll(SUM(m.pricetotal),0) as maintain" &
                    " FROM Engine e1" &
                    " left outer Join FuelConsumption fc on fc.engineid = e1.id " &
                    " left outer Join Maintenance m on  m.engineid = e1.id " &
                    " Group By e1.ename) t1" &
                    " Left outer Join" &
                    " (select e2.ename as 'B', ISNUll(SUM(ch2.currentvalue - ch2.previousvalue),0) as KW, ISNUll(SUM(kilowattprice),0) as KWP, ISNUll(SUM(ch2.monthlyfee),0) as MF, ISNUll(SUM(ch2.discount),0) as DIS, ISNUll(SUM(ch2.roundvalue),0) as RND, ISNUll(SUM(ch2.total),0) as totalInvoice" &
                    " FROM Engine e2" &
                    " Left Join ElectricBox eb2 On eb2.engineid = e2.id" &
                    " 		Left join ECounter ec2 on ec2.boxid = eb2.ID" &
                    " 				Left join Registration r2 on r2.counterid=ec2.ID" &
                    " 					Left join CounterHistory ch2 on ch2.regid = r2.id" &
                    " Group By e2.ename) t2" &
                    " On t1.A = t2.B)", "dt18")

        dtEngineEfficiency.Clear()
        dtEngineEfficiency.Merge(a.ds.Tables("dt18"))
    End Sub

    Private Sub loadEngineLoadReport()
        a.ds = New DataSet
        a.GetData("Select Distinct A AS [المولد],C AS [عدد المشتركين],D AS [إجمالي أمبير], sumFC/countMonths AS [معدل محروفات شهري / لتر] FROM( Select A,Count(B) as countMonths,C,D,SUM(E) as sumFC FROM ( select e.ename AS A, CONCAT(DATEPART(MONTH,fc.outdate),'/',DATEPART(YEAR,fc.outdate)) AS B,Count(r.id) AS C, IsNull(SUM(p.ampere),0) AS D, ISNULL(fc.quantity,0) AS E From Engine e full outer  Join FuelConsumption fc on fc.engineid=e.ID full outer Join ElectricBox eb on eb.engineid=e.ID full outer Join ECounter ec on ec.boxid=eb.ID full outer Join Registration r on r.counterid=ec.ID full outer Join Package p on r.packageid=p.ID Where r.active = 1 group by e.ename, CONCAT(DATEPART(MONTH,fc.outdate),'/',DATEPART(YEAR,fc.outdate)), fc.quantity  ) AS t1 Group by A,C,D ) AS t2 Union Select 'المجموع',SUM(C),SUM(D), SUM(sumFC/countMonths) FROM( Select A,Count(B) as countMonths,C,D,SUM(E) as sumFC FROM ( select e.ename AS A, CONCAT(DATEPART(MONTH,fc.outdate),'/',DATEPART(YEAR,fc.outdate)) AS B,Count(r.id) AS C, IsNull(SUM(p.ampere),0) AS D, ISNULL(fc.quantity,0) AS E From Engine e full outer  Join FuelConsumption fc on fc.engineid=e.ID full outer Join ElectricBox eb on eb.engineid=e.ID full outer Join ECounter ec on ec.boxid=eb.ID full outer Join Registration r on r.counterid=ec.ID full outer Join Package p on r.packageid=p.ID Where r.active = 1 group by e.ename, CONCAT(DATEPART(MONTH,fc.outdate),'/',DATEPART(YEAR,fc.outdate)), fc.quantity  ) AS t1 Group by A,C,D ) AS t3 Order By C ", "dt26")
        dtEngineLoad.Clear()
        dtEngineLoad.Merge(a.ds.Tables("dt26"))
    End Sub

    Private Sub loadEngineEfficiencyByMonthReport()
        a.ds = New DataSet
        a.GetData(" Select A as [اسم المولّد], KW as [مجموع كيلوات KW], KWP as [إجمالي كيلوات ل.ل], MF as [إجمالي رسوم ل.ل], DIS as [إجمالي حسومات ل.ل], RND as [إجمالي تدوير ل.ل], D as [اجمالي قيمة الفواتير ل.ل], B as [استهلاك وقود / ليتر], C as [اجمالي صيانة + غيار زيت ل.ل] FROM ( " &
                        " 		(Select engine1 as A, fcQuantity3 as B, maintotal3 as C FROM ( " &
                        "  " &
                        " 			(Select Engine as engine1, fcQuantity2 as fcQuantity3 From " &
                        " 				( " &
                        " 					select e.ename as Engine, 0 as fcQuantity2 FROM Engine e where e.id not in  " &
                        " 						(select e.id from Engine e Join FuelConsumption fc on e.id = fc.engineid where MONTH(fc.outdate) = " & dtp1.Value.Month & " AND YEAR(fc.outdate) = " & dtp1.Value.Year & " ) " &
                        " 					Union " &
                        " 					select e.ename, ISNUll(SUM(fc.quantity),0)  " &
                        " 					FROM Engine e Join FuelConsumption fc on e.id = fc.engineid " &
                        " 					where MONTH(fc.outdate) = " & dtp1.Value.Month & " AND YEAR(fc.outdate) = " & dtp1.Value.Year & " " &
                        " 					Group By e.ename  " &
                        " 				) t0  " &
                        " 			) t1 " &
                        "  " &
                        " 		JOIN " &
                        "  " &
                        " 			(Select Engine2 as engine3, MainTotal2 as maintotal3 From " &
                        " 				( " &
                        " 					select e.ename as Engine2, 0 as MainTotal2 FROM Engine e where e.id not in (select e.id from Engine e Join Maintenance m on e.id = m.engineid where MONTH(m.indate) = " & dtp1.Value.Month & " AND YEAR(m.indate) = " & dtp1.Value.Year & " ) " &
                        " 					Union " &
                        " 					select e.ename, ISNUll(SUM(m.pricetotal),0)  " &
                        " 					FROM Engine e Join Maintenance m on e.id = m.engineid " &
                        " 					where MONTH(m.indate) = " & dtp1.Value.Month & " AND YEAR(m.indate) = " & dtp1.Value.Year & " " &
                        " 					Group By e.ename  " &
                        " 				) t2 " &
                        " 			) t4 " &
                        "  " &
                        " 		ON t1.engine1 = t4.engine3) " &
                        "  " &
                        " 		) tfinal1 " &
                        "  " &
                        " JOIN " &
                        "  " &
                        " 	( " &
                        " 		select e.ename as Enginex, 0 as KW, 0 as KWP, 0 as MF, 0 as DIS, 0 as RND, 0 as D FROM Engine e where e.id not in (select e.id from Engine e Left Join ElectricBox eb On eb.engineid = e.id Left join ECounter ec on ec.boxid = eb.ID Left join Registration r on r.counterid=ec.ID Left join CounterHistory ch on ch.regid = r.id Where ch.cmonth = " & dtp1.Value.Month & " AND ch.cyear = " & dtp1.Value.Year & " ) " &
                        " 		Union " &
                        " 		select e.ename, ISNUll(SUM(ch.currentvalue - ch.previousvalue),0) as totalkw, ISNUll(SUM(kilowattprice),0) as totalkwP, ISNUll(sum(Cast(ch.monthlyfee AS BIGINT)),0) as totalMF, ISNUll(SUM(ch.discount),0) as totalDis, ISNUll(SUM(ch.roundvalue),0) as totalRnd, ISNUll(sum(Cast(ch.total AS BIGINT)),0) as totalInvoice " &
                        " 		FROM Engine e " &
                        " 		Left Join ElectricBox eb On eb.engineid = e.id " &
                        " 				Left join ECounter ec on ec.boxid = eb.ID " &
                        " 						Left join Registration r on r.counterid=ec.ID " &
                        " 							Left join CounterHistory ch on ch.regid = r.id " &
                        " 		Where ch.cmonth = " & dtp1.Value.Month & " AND ch.cyear = " & dtp1.Value.Year & " " &
                        " 		Group By e.ename " &
                        " 	) tfinal2 " &
                        "  " &
                        " ON tfinal1.A = tfinal2.Enginex) ", "dt18")

        dtEngineEfficiency.Clear()
        dtEngineEfficiency.Merge(a.ds.Tables("dt18"))
    End Sub

    Private Sub loadExcellReport()

        'excelldt = New DataTable
        'excelldt.Columns.Add("كشف شهري")
        'excelldt.Columns.Add(txtfrom.Value)
        'excelldt.Columns.Add("")
        'Dim r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19 As DataRow

        'r1 = excelldt.NewRow
        'r1.Item(0) = "اشتراكات جديدة"
        'r1.Item(1) = newReg
        'r2 = excelldt.NewRow
        'r2.Item(0) = "اشتراكات منتهية"
        'r2.Item(1) = inactiveReg
        'r3 = excelldt.NewRow
        'r3.Item(0) = "اجمالي اشتراكات فاعلة"
        'r3.Item(1) = activeReg
        'r4 = excelldt.NewRow
        'r4.Item(0) = "ساعات التغذية"
        'r4.Item(1) = workHours
        'r5 = excelldt.NewRow
        'r5.Item(0) = "مبيع كيلوات"
        'r5.Item(1) = sellKW
        'r6 = excelldt.NewRow
        'r6.Item(0) = "اجمالي كيلوات"
        'r6.Item(1) = totalKW
        'r7 = excelldt.NewRow
        'r7.Item(0) = "اجمالي رسوم اشتراكات"
        'r7.Item(1) = totalFee
        'r8 = excelldt.NewRow
        'r8.Item(0) = "اجمالي تدوير"
        'r8.Item(1) = totalRound
        'r9 = excelldt.NewRow
        'r9.Item(0) = "اجمالي حسومات"
        'r9.Item(1) = totalDiscount
        'r10 = excelldt.NewRow
        'r10.Item(0) = "قبض فواتير"
        'r10.Item(1) = totalInvoiceIn
        'r11 = excelldt.NewRow
        'r11.Item(0) = "قبض مكسورات"
        'r11.Item(1) = totalcredit
        'r12 = excelldt.NewRow
        'r12.Item(0) = "قبض تأمين"
        'r12.Item(1) = totalInsuranceIn
        'r13 = excelldt.NewRow
        'r13.Item(0) = "استرداد تأمين"
        'r13.Item(1) = totalInsuranceOut
        'r14 = excelldt.NewRow
        'r14.Item(0) = "مداخيل اخرى"
        'r14.Item(1) = totalOtherIn
        'r15 = excelldt.NewRow
        'r15.Item(0) = "مصاريف اخرى"
        'r15.Item(1) = totalOtherOut
        'r16 = excelldt.NewRow
        'r16.Item(0) = "رصيد صندوق"
        'r16.Item(1) = currentMonthNet
        'r17 = excelldt.NewRow
        'r18 = excelldt.NewRow
        'r19 = excelldt.NewRow
        'r19.Item(0) = "الجابي"
        'r19.Item(1) = "اجمالي جباية"

        'excelldt.Rows.Add(r1)
        'excelldt.Rows.Add(r2)
        'excelldt.Rows.Add(r3)
        'excelldt.Rows.Add(r4)
        'excelldt.Rows.Add(r5)
        'excelldt.Rows.Add(r6)
        'excelldt.Rows.Add(r7)
        'excelldt.Rows.Add(r8)
        'excelldt.Rows.Add(r9)
        'excelldt.Rows.Add(r10)
        'excelldt.Rows.Add(r11)
        'excelldt.Rows.Add(r12)
        'excelldt.Rows.Add(r13)
        'excelldt.Rows.Add(r14)
        'excelldt.Rows.Add(r15)
        'excelldt.Rows.Add(r16)
        'excelldt.Rows.Add(r17)
        'excelldt.Rows.Add(r18)
        'excelldt.Rows.Add(r19)
    End Sub



    Private Sub loadData()
        dt = New DataTable
        dtEnginAmpere = New DataTable
        dtGeneralReport = New DataTable
        a.ds = New DataSet

        Dim newReg As Long = getNewRegs()
        Dim inactiveReg As Long = getInactiveRegs()
        Dim activeReg As Long = getActiveRegs()
        Dim workHours As Long = getWorkingHours()
        Dim sellKW As Long = getSellKW()
        Dim totalKW As Long = getTotalKW()
        Dim totalFee As Long = getTotalFee()
        Dim totalRound As Long = getTotalRound()
        Dim totalDiscount As Long = getTotalDiscount()
        Dim totalNumberOfInvoices As Long = getNumberOfInvoices()
        Dim totalValueOfInvoices As Long = getValueOfInvoices(totalKW, totalFee, totalRound, totalDiscount)
        Dim totalPaidValueOfInvoices As Long = getPaidValueOfInvoices()
        Dim totalRemValueOfInvoices As Long = getRemValueOfInvoices(totalValueOfInvoices, totalPaidValueOfInvoices)
        Dim totalValueOfInvoicesTillNow As Int64 = getTotalValueOfInvoicesTillNow()
        Dim totalPaidValueOfInvoicesTillNow As Long = getTotalPaidValueOfInvoicesTillNow()
        Dim totalRemValueOfInvoicesTillNow As Int64 = getTotalRemValueOfInvoicesTillNow(totalValueOfInvoicesTillNow, totalPaidValueOfInvoicesTillNow)
        Dim totalCreditValueTillNow As Int64 = getTotalCreditValueTillNow(totalRemValueOfInvoicesTillNow, totalRemValueOfInvoices)
        Dim totalPurchaseValue As Long = getTotalPurhasesValue()
        Dim totalFuelLiter As Long = getTotalFuelPurhasesLetersValue()
        Dim totalFuelPrice As Long = getTotalFuelPurhasesPriceValue()
        Dim totalFuelConsumptionValue As Long = getTotalFuelConsumptionValue()
        Dim totalMaintainanceValue As Long = getTotalMaintainanceValue()

        Dim totalInvoiceIn As Long = getTotalInvoiceIn()
        Dim totalcredit As Long = getTotalcredit()
        Dim totalInsuranceIn As Long = getTotalInsuranceIn()
        Dim totalInsuranceOut As Long = getTotalInsuranceOut()
        Dim totalOtherIn As Long = getTotalOtherIn(totalInvoiceIn, totalcredit, totalInsuranceIn)
        Dim totalOtherOut As Long = getTotalOtherOut(totalInsuranceOut)
        Dim perviousMonthNet As Long = getPerviousMonthNet()
        Dim AllNet As Long = getAllNet()
        Dim currentMonthNet As Long = getCurrentMonthNet(totalInvoiceIn, totalcredit, totalOtherIn, totalInsuranceIn, totalOtherOut, totalInsuranceOut)

        ds.Clear()
        ds = New DataSetGeneralReport
        Dim dr As DataRow = ds.dtGeneral.NewRow
        dr.ItemArray = New Object() {getArabicMonth(dtp1.Value.Month) & " / " & dtp1.Value.Year, newReg, inactiveReg, activeReg, workHours, sellKW, totalKW, totalFee, totalRound, totalDiscount, totalNumberOfInvoices, totalValueOfInvoices, totalPaidValueOfInvoices, totalRemValueOfInvoices, totalValueOfInvoicesTillNow, totalPaidValueOfInvoicesTillNow, totalRemValueOfInvoicesTillNow, totalCreditValueTillNow, totalPurchaseValue, totalFuelLiter, totalFuelPrice, totalFuelConsumptionValue, totalMaintainanceValue, totalInvoiceIn, totalcredit, totalInsuranceIn, totalOtherIn, Math.Abs(totalOtherOut), Math.Abs(totalInsuranceOut), currentMonthNet, perviousMonthNet, AllNet}
        ds.dtGeneral.Rows.Add(dr)

    End Sub

    Public Sub showMonthlyReport()
        loadExpenditurePositivesReport()
        loadExpenditureNegativesReport(True)
        loadItemsReport()
        loadFuelConsumptionReport()
        loadMaintainanceReport()
        loadAmpereReport()
        loadAmperePerEngineReport()
        loadWorkingHoursReport()
        loadEngineEfficiencyByMonthReport()

        cloneTable(ds.dtExpenditurePos, dtExpenditurePositives)
        cloneTable(ds.dtExpenditureNeg, dtExpenditureNegatives)
        cloneTable(ds.dtItems, dtItems)
        cloneTable(ds.dtFuelConsumption, dtFuelConsumption)
        cloneTable(ds.dtMaintainance, dtMaintainance)
        cloneTable(ds.dtAmpere, dtAmpere)
        cloneTable(ds.dtAmperePerEngine, dtAmperePerEngine)
        cloneTable(ds.dtWorkingHours, dtWorkingHours)
        cloneTable(ds.dtEngineEfficiency, dtEngineEfficiency)

        Dim frmRV As New frmMonthlyReportViewer(ds)
        frmRV.ShowDialog()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadData()
    End Sub

    Private Sub CompanyReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Function getCollectersReportQuery1() As String
        Dim query As String = " SELECT A AS [الجابي], " &
                                " 	ISNULL(B,0) as [اجمالي فواتير], " &
                                " 	ISNULL(E,0) as [تجميع فواتير], " &
                                " 	ISNULL(C,0) as [اجمالي مطلوب ل.ل], " &
                                " 	ISNULL(F,0) as [تجميع ل.ل], " &
                                " 	ISNULL((C - F),0) as [باقي ل.ل] " &
                                " FROM " &
                                " 	(Select cl.fullname AS A, " &
                                " 		Count(ch.ID) as B, " &
                                " 		sum(Cast(ch.total AS BIGINT)) as C " &
                                " 		FROM  ElectricBox b JOIN Collector cl   " &
                                " 			ON b.collectorid=cl.id JOIN ECounter ec  " &
                                " 			ON ec.boxid=b.ID JOIN Registration r  " &
                                " 			ON r.counterid=ec.ID JOIN CounterHistory ch  " &
                                " 			ON ch.regid=r.id " &
                                "       WHERE  ch.cmonth=" & dtp1.Value.Month & " and ch.cyear=" & dtp1.Value.Year & "" &
                                " 		Group by cl.fullname " &
                                " 	) t1  " &
                                " LEFT JOIN " &
                                " 	(Select  cl.fullname AS D, " &
                                " 		Count(Distinct p.counterhistoryid) as E, " &
                                " 		SUM(pvalue) as F " &
                                " 		FROM  ElectricBox b JOIN Collector cl   " &
                                " 			ON b.collectorid=cl.id JOIN ECounter ec  " &
                                " 			ON ec.boxid=b.ID JOIN Registration r  " &
                                " 			ON r.counterid=ec.ID JOIN CounterHistory ch  " &
                                " 			ON ch.regid=r.id JOIN Payment p  " &
                                " 			ON p.counterhistoryid = ch.ID  " &
                                " 	 " &
                                "       WHERE  ch.cmonth=" & dtp1.Value.Month & " and ch.cyear=" & dtp1.Value.Year & "" &
                                " 		Group by cl.fullname " &
                                " 	) t2  " &
                                " ON t1.A = t2.D "
        Return query
    End Function

    Private Function getCollectersReportQuery2() As String
        Dim query As String = "SELECT 'اجمالي', " &
                                " 	ISNULL(SUM(B),0), " &
                                " 	ISNULL(SUM(E),0), " &
                                " 	ISNULL(SUM(C),0), " &
                                " 	ISNULL(SUM(F),0), " &
                                " 	ISNULL(SUM(C - F),0) " &
                                " FROM " &
                                " 	(Select cl.fullname AS A, " &
                                " 		Count(ch.ID) as B, " &
                                " 		sum(Cast(ch.total AS BIGINT)) as C " &
                                " 		FROM  ElectricBox b JOIN Collector cl   " &
                                " 			ON b.collectorid=cl.id JOIN ECounter ec  " &
                                " 			ON ec.boxid=b.ID JOIN Registration r  " &
                                " 			ON r.counterid=ec.ID JOIN CounterHistory ch  " &
                                " 			ON ch.regid=r.id " &
                                "       WHERE  ch.cmonth=" & dtp1.Value.Month & " and ch.cyear=" & dtp1.Value.Year & "" &
                                " 		Group by cl.fullname " &
                                " 	) t1  " &
                                " LEFT JOIN " &
                                " 	(Select  cl.fullname AS D, " &
                                " 		Count(Distinct p.counterhistoryid) as E, " &
                                " 		SUM(pvalue) as F " &
                                " 		FROM  ElectricBox b JOIN Collector cl   " &
                                " 			ON b.collectorid=cl.id JOIN ECounter ec  " &
                                " 			ON ec.boxid=b.ID JOIN Registration r  " &
                                " 			ON r.counterid=ec.ID JOIN CounterHistory ch  " &
                                " 			ON ch.regid=r.id JOIN Payment p  " &
                                " 			ON p.counterhistoryid = ch.ID  " &
                                " 	 " &
                                "       WHERE  ch.cmonth=" & dtp1.Value.Month & " and ch.cyear=" & dtp1.Value.Year & "" &
                                " 		Group by cl.fullname " &
                                " 	) t2  " &
                                " ON t1.A = t2.D "
        Return query
    End Function


    Private Sub BtnCollectersReport_Click(sender As Object, e As EventArgs) Handles BtnCollectersReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadCollectersReport()
            Dim frm As New frmDataViewer("تقرير الجبات", dt, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            showMonthlyReport()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadEnginesReport()
            Dim frm As New frmDataViewer("تقرير المولدات", dtEnginAmpere, False)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            Dim frm As New frmInsuranceReport
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadGeneralReport()
            Dim frm As New frmDataViewer("كشف عام تفصيلي", dtGeneralReport, False)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            Dim Month As Int16 = dtp1.Value.Month
            Dim Year As Int16 = dtp1.Value.Year
            Dim ac As New Helper
            ac.ds = New DataSet
            ac.GetData(frmInvoice.getInvoiceQuery(Month, Year, True), "dti")
            Dim frm As New frmDataViewer("كشف الفواتير + المكسورات", ac.ds.Tables("dti"), False)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnItemsReport_Click(sender As Object, e As EventArgs) Handles btnItemsReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadItemsReport()
            Dim frm As New frmDataViewer("كشف أصناف تفصيلي", dtItems, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnFuelConsumptionReport_Click(sender As Object, e As EventArgs) Handles btnFuelConsumptionReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadFuelConsumptionReport()
            Dim frm As New frmDataViewer("كشف محروقات حسب المولّد", dtFuelConsumption, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnMaintainanceReport_Click(sender As Object, e As EventArgs) Handles btnMaintainanceReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadMaintainanceReport()
            Dim frm As New frmDataViewer("كشف صيانة حسب المولّد", dtMaintainance, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnExpenditureAllReport_Click(sender As Object, e As EventArgs) Handles btnExpenditureAllReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadExpenditureAllReport()
            Dim frm As New frmDataViewer("كشف صندوق تفصيلي", dtExpenditureAll, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadEngineLoadReport()
            Dim frm As New frmDataViewer("كشف عبئ المولّد", dtEngineLoad, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnExpenditurePosReport_Click(sender As Object, e As EventArgs) Handles btnExpenditurePosReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadExpenditurePositivesReport()
            Dim frm As New frmDataViewer("كشف مداخيل تفصيلي", dtExpenditurePositives, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnExpenditureNegReport_Click(sender As Object, e As EventArgs) Handles btnExpenditureNegReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadExpenditureNegativesReport()
            Dim frm As New frmDataViewer("كشف مصاريف تفصيلي", dtExpenditureNegatives, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnAmpereReport_Click(sender As Object, e As EventArgs) Handles btnAmpereReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadAmpereReport()
            Dim frm As New frmDataViewer("كشف توزع الأمبيراج", dtAmpere, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnAmperePerEngineReport_Click(sender As Object, e As EventArgs) Handles btnAmperePerEngineReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadAmperePerEngineReport()
            Dim frm As New frmDataViewer("كشف توزّع الأمبيراج حسب المولّد", dtAmperePerEngine, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnWorkingHours_Click(sender As Object, e As EventArgs) Handles btnWorkingHours.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadWorkingHoursReport()
            Dim frm As New frmDataViewer("كشف ساعات التغذية", dtWorkingHours, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnEngineEfficiencyReport_Click(sender As Object, e As EventArgs) Handles btnEngineEfficiencyReport.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadEngineEfficiencyByMonthReport()
            Dim frm As New frmDataViewer("كشف فعاليّة المولّد", dtEngineEfficiency, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            loadEngineEfficiencyALLReport()
            Dim frm As New frmDataViewer("كشف فعاليّة المولّد", dtEngineEfficiency, True)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub btnTotalPurchases_Click(sender As Object, e As EventArgs) Handles btnTotalCredit.Click, btnTotalRound.Click, btnTotalRemValueOfInvoices.Click, btnTotalRemInvoicesTillNow.Click, btnTotalPurchases.Click, btnTotalPaidValueOfInvoices.Click, btnTotalPaidInvoicesTillNow.Click, btnTotalMaintainance.Click, btnTotalKW.Click, btnTotalInvoicesValue.Click, btnTotalInvoicesTillNow.Click, btnTotalFuelPrice.Click, btnTotalFuelLeter.Click, btnTotalFee.Click, btntotalDiscount.Click, btnSupplyHours.Click, btnSellKW.Click, btnNumberOfInvoices.Click, btnNewReg.Click, btnInactiveReg.Click, btnActive.Click
        My.Computer.Clipboard.SetText(CType(sender, Button).Text)
        MsgBox("تم نسخ القيمة الى لوحة النسخ.")
    End Sub

    Private Sub btnTotalFuelConsumption_Click(sender As Object, e As EventArgs) Handles btnTotalFuelConsumption.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try

            Dim ac As New Helper
            ac.ds = New DataSet
            ac.GetData("select cname as [المشترك],cphone as [هاتف], cmobile as [خلوي], Count(rid) as [عدد الإشتراكات], Sum(sumKilo) as [مجموع كيلوات (كيلو)], Sum(sumKiloAndRound) as [اجمالي كيلوات + تدوير ل.ل], Sum(netFees) as [اجمالي رسوم ل.ل], Sum(netRequired) as [اجمالي مطلوب ل.ل],
                        Sum(netDiscount) as [اجمالي حسومات ل.ل], Sum(netNet) as [صافي ل.ل], Sum(totalPaid) as  [اجمالي مدفوع ل.ل], Sum(totalRem) as  [باقي ل.ل], IsNull(Sum(cInsurance),0) as [له تأمين ل.ل]  from (
                        SELECT r.id as rid,c.id as cid, c.clientname as cname, c.phone as cphone, c.mobile as cmobile,
                            IsNull(Max(ch.currentvalue),0) as sumKilo, 
                            IsNull(Sum((ch.kilowattprice) + ch.roundvalue),0) as sumKiloAndRound,
                            IsNull(sum(Cast(ch.monthlyfee AS BIGINT)),0) as netFees, 
                            IsNull(SUM(total + discount),0) as netRequired, 
                            IsNull(SUM(discount),0) as netDiscount, 
                            IsNull(SUM(total),0) as netNet,
                            (SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.regid=r.ID) AS totalPaid, 
                            IsNull(SUM(total),0) - (SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.regid=r.ID) AS totalRem, 
                            r.insurance as cInsurance

	                         from CounterHistory ch join Registration r  on ch.regid = r.id join Client c on r.clientid=c.ID
	                         group by r.ID,c.id, r.insurance,c.clientname, c.phone, c.mobile
                        ) as innertable group by innertable.cid, cname,cphone,cmobile")
            Dim frm As New frmDataViewer("كشف عام حسب الزبون", ac.ds.Tables(0), False)
            frm.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    'Private Sub btnClientsCreditDetails_Click(sender As Object, e As EventArgs) Handles btnClientsCreditDetails.Click
    '    If Not currentUser.hasPermision("clients") Then
    '        MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Return
    '    End If
    '    If Not currentUser.hasPermision("reportview") Then
    '        MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Return
    '    End If
    '    Dim frm As New frmClientsCreditDetails
    '    frm.ShowDialog()
    'End Sub

    Private Sub btnPaymentsByTime_Click(sender As Object, e As EventArgs) Handles btnPaymentsByTime.Click
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmCurrentPayments
        frm.ShowDialog()
    End Sub
End Class