Imports CrystalDecisions.CrystalReports.Engine
Imports EEMS.SqlDBHelper
Imports CrystalDecisions.CrystalReports.Engine.SCRCollection
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Linq
Imports System.Reflection

Public Class frmReportViewer

    Dim ds As New DataSetInvoices
    Dim isClientReport As Boolean = False
    Dim isGeneralReport As Boolean = False
    Dim isCreditsReport As Boolean = False
    Dim isEmptyChReport As Boolean = False
    Dim verbose As Boolean = False

    Sub New(ByVal dt As DataTable, note As String, verbose As Boolean)
        'InitializeComponent()
        For i As Int32 = 0 To dt.Rows.Count - 1
            ds.invoicesdt.Rows.Add()
            ds.invoicesdt.Rows(i).ItemArray = dt(i).ItemArray
        Next
        For Each row As DataRow In ds.invoicesdt.Rows
            If note.Trim.Length > 0 Then
                row.Item(15) = note
            Else
                row.Item(15) = ""
            End If
            row.Item(27) = SharedModule.dollarPrice
        Next
        Me.verbose = verbose

        InitializeComponent()
    End Sub

    Sub New(regid As Integer)


        Dim a As New Helper

        a.ds = New DataSet
        a.GetData("SELECT c.ID as [معرّف المشترك],c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي] FROM Client c join Registration r on r.clientid=c.ID and r.id=" & regid)
        cloneTable(ds.clientdt, a.ds.Tables(0))

        a.ds = New DataSet
        a.GetData("SELECT r.ID as [معرّف الاشتراك],r.clientid as [معرّف المشترك],r.active as مفعّل,registrationdate as [تاريخ الاشتراك],enddate as [تاريخ انهاء الاشتراك],p.ampere as [أمبير],b.code as [رمز العلبة],b.location as [عنوان العلبة],ec.serial as[رمز العدّاد],ec.code as [الرمز في العلبة],r.insurance as [تأمين],r.notes AS [ملاحظات] FROM Registration r,Client c,ElectricBox b,ECounter ec,Package p WHERE r.packageid = p.ID and r.counterid = ec.ID and ec.boxid = b.ID and r.clientid = c.ID and r.ID=" & regid & " order By r.active")
        cloneTable(ds.registrationdt, a.ds.Tables(0))

        a.ds = New DataSet
        a.GetData("SELECT ch.ID as [معرّف القيمة],r.ID as [معرّف الاشتراك],(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))) as [شهر],ch.monthlyfee as [رسم اشتراك],(ch.currentvalue-ch.previousvalue) as [فرق عداد],ch.kilowattprice as [سعر الكيلو],((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue as [مطلوب كيلو],total+discount as [المجموع],ch.discount as [حسم],total as [مطلوب], ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [مدفوع], total-ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [باقي],ch.notes as [ملاحظات]  " &
                    " FROM (CounterHistory ch left join Payment p on p.counterhistoryid=ch.ID) join Registration r on ch.regid = r.ID join ArabicMonth ar on ch.cmonth=ar.ID where r.id=" & regid &
                    " group by ch.ID,r.ID,(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))),ch.monthlyfee,(ch.currentvalue-ch.previousvalue),ch.kilowattprice,((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue,total+discount,ch.discount,ch.total,ch.notes")
        cloneTable(ds.creditdt, a.ds.Tables(0))
        '"SELECT ch.ID as [معرّف القيمة],r.ID as [معرّف الاشتراك],(ar.caption + '-' + Cast(ch.cyear as nvarchar(50))) as [شهر],ch.monthlyfee as [رسم اشتراك],(ch.currentvalue-ch.previousvalue) as [فرق عداد],ch.kilowattprice as [سعر الكيلو],(ch.currentvalue-ch.previousvalue)*ch.kilowattprice as [مطلوب كيلو],total+discount as [المجموع],ch.discount as [حسم],total as [مطلوب], ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [مدفوع], total-ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [باقي],ch.notes as [ملاحظات] FROM Registration r,CounterHistory ch,ArabicMonth ar WHERE ch.cmonth=ar.ID and ch.regid = r.ID and total>0 and r.ID=" & regid

        a.ds = New DataSet
        a.GetData("SELECT p.ID as [معرّف الدفعة],p.counterhistoryid as [معرّف القيمة],(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))) as [شهر],p.pdate as [تاريخ الدفعة],p.pvalue as [قيمة الدفعة],p.notes as [ملاحظات] FROM Payment p,CounterHistory ch,Registration r, ArabicMonth ar WHERE p.counterhistoryid=ch.ID and ch.regid=r.ID and ch.cmonth=ar.ID and r.ID=" & regid & " order by p.pdate asc")
        cloneTable(ds.paymentdt, a.ds.Tables(0))

        isClientReport = True

        InitializeComponent()
    End Sub

    'Sub New(collectorID As Int32)
    '    InitializeComponent()

    '    Dim a As New Helper

    '    a.ds = New DataSet
    '    a.GetData("Select * ,'' as crnotes FROM ( SELECT c.clientname as [المشترك],p.ampere as [أمبير], IsNull(Max(ch.currentvalue),0) as [مجموع كيلوات], IsNull(Sum(((ch.currentvalue - ch.previousvalue) * ch.kilowattprice) + ch.roundvalue),0) as [اجمالي كيلوات + تدوير], IsNull(sum(Cast(ch.monthlyfee AS BIGINT)),0) as [اجمالي رسوم], IsNull(SUM(total + discount),0) as [اجمالي مطلوب], IsNull(SUM(discount),0) as [اجمالي حسومات], IsNull(SUM(total),0) as [صافي],(SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.regid=r.ID) AS [اجمالي مدفوع], (IsNull(SUM(total),0) - (SELECT IsNull(Sum(pyy.pvalue),0) FROM CounterHistory coh,Payment pyy WHERE pyy.counterhistoryid=coh.ID and coh.regid=r.ID )) AS rem, r.insurance as [له تأمين] FROM Registration r,Client c,ElectricBox b,ECounter ec,CounterHistory ch,Package p,Engine en,Collector cl,ArabicMonth ar  WHERE r.packageid = p.ID And ch.cmonth = ar.ID And r.counterid = ec.ID And ec.boxid = b.ID And r.clientid = c.ID And ch.regid = r.ID And b.engineid = en.ID And b.collectorid = cl.ID and cl.ID = " & collectorID & " GROUP BY r.ID, r.insurance, c.clientname,p.ampere ) as innerTable where rem > 0 ORDER BY [المشترك]")
    '    cloneTable(ds.creditsdt, a.ds.Tables(0))

    '    isCreditsReport = True
    'End Sub

    Sub New(dtc As DataTable)

        Dim a As New Helper
        If dtc.TableName.Equals("EmptyCHDT") Then
            cloneTable(ds.emptyCounterHistdt, dtc)
            isEmptyChReport = True
        Else
            cloneTable(ds.creditsdt, dtc)
            isCreditsReport = True
        End If

        InitializeComponent()
    End Sub

    Public Sub New(title As String, detials As String, notes As String, other As String)

        isGeneralReport = True
        Dim r As DataRow = ds.general.NewRow
        r.Item(0) = title
        r.Item(1) = detials
        r.Item(2) = notes
        r.Item(3) = other
        ds.general.Rows.Add(r)

        InitializeComponent()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim dr As DataRow = ds.OrgInfodt.NewOrgInfodtRow
        dr.ItemArray = New Object() {orgname, Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().FullName).FullName, "Logo/logo.jpg")}
        ds.OrgInfodt.Rows.Add(dr)

        Dim rptDoc As ReportClass = Nothing

        If isGeneralReport Then
            rptDoc = New GeneralReport
        ElseIf isEmptyChReport Then
            rptDoc = New emptyCouterHistory
        ElseIf isClientReport Then
            rptDoc = New ClientAccountReport
        ElseIf isCreditsReport Then
            rptDoc = New ClientsCreditsReport
        ElseIf verbose Then
            rptDoc = New Invoices
            Dim enumerator As SCRCollectionEnumerator = CType(rptDoc, Invoices).Section3.ReportObjects.GetEnumerator
            SharedModule.moveCRObjectsOnYAxis(enumerator, invoiceYOffset)
            enumerator.Reset()
            SharedModule.moveCRObjectsOnXAxis(enumerator, invoiceXOffset)
        ElseIf Not verbose Then
            rptDoc = New InvoicesWithoutCredit
            Dim enumerator As SCRCollectionEnumerator = CType(rptDoc, InvoicesWithoutCredit).Section3.ReportObjects.GetEnumerator
            SharedModule.moveCRObjectsOnYAxis(enumerator, invoiceYOffset)
            enumerator.Reset()
            SharedModule.moveCRObjectsOnXAxis(enumerator, invoiceXOffset)
        End If

        rptDoc.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rptDoc

    End Sub

    Public Sub cloneTable(ByRef table1 As DataTable, ByRef table2 As DataTable)
        For i As Int32 = 0 To table2.Rows.Count - 1
            table1.Rows.Add()
            table1.Rows(i).ItemArray = table2(i).ItemArray
        Next
    End Sub

End Class