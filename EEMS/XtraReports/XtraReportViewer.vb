Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraReports.UI
Imports EEMS.SqlDBHelper

Public Class XtraReportViewer
    Dim ds As New DataSetInvoices
    Dim dsgr As DataSetGeneralReport
    Dim isClientReport As Boolean = False
    Dim isGeneralReport As Boolean = False
    Dim isCreditsReport As Boolean = False
    Dim isEmptyChReport As Boolean = False
    Dim isMonthlyReport As Boolean = False
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
        Next
        Me.verbose = verbose

        InitializeComponent()
    End Sub

    Sub New(regid As Integer, Optional checkAll As Boolean = True, Optional fromd As DateTime = Nothing, Optional tod As DateTime = Nothing)


        Dim a As New Helper

        a.ds = New DataSet
        a.GetData("SELECT c.ID as [معرّف المشترك],c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي] FROM Client c join Registration r on r.clientid=c.ID and r.id=" & regid)
        cloneTable(ds.clientdt, a.ds.Tables(0))

        a.ds = New DataSet
        a.GetData("SELECT r.ID as [معرّف الاشتراك],r.clientid as [معرّف المشترك],r.active as مفعّل,registrationdate as [تاريخ الاشتراك],enddate as [تاريخ انهاء الاشتراك],p.ampere as [أمبير],b.code as [رمز العلبة],b.location as [عنوان العلبة],ec.serial as[رمز العدّاد],ec.code as [الرمز في العلبة],r.insurance as [تأمين],r.notes AS [ملاحظات] FROM Registration r,Client c,ElectricBox b,ECounter ec,Package p WHERE r.packageid = p.ID and r.counterid = ec.ID and ec.boxid = b.ID and r.clientid = c.ID and r.ID=" & regid & " order By r.active")
        cloneTable(ds.registrationdt, a.ds.Tables(0))

        Dim dateConstraint As String = String.Empty
        If Not checkAll Then
            dateConstraint = " and (ch.cyear>" & fromd.Year & " or (ch.cyear=" & fromd.Year & " and ch.cmonth>=" & fromd.Month & ")) and (ch.cyear<" & tod.Year & " or (ch.cyear=" & tod.Year & " and ch.cmonth<=" & tod.Month & "))"
        End If
        a.ds = New DataSet
        a.GetData("SELECT ch.ID as [معرّف القيمة],r.ID as [معرّف الاشتراك],(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))) as [شهر],ch.monthlyfee as [رسم اشتراك],(ch.currentvalue-ch.previousvalue) as [فرق عداد],ch.kilowattprice as [سعر الكيلو],((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue as [مطلوب كيلو],total+discount as [المجموع],ch.discount as [حسم],total as [مطلوب], ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [مدفوع], total-ISNULL(sum(Cast(p.pvalue AS BIGINT)),0) as [باقي],ch.notes as [ملاحظات]  " &
                    " FROM (CounterHistory ch left join Payment p on p.counterhistoryid=ch.ID) join Registration r on ch.regid = r.ID join ArabicMonth ar on ch.cmonth=ar.ID where r.id=" & regid & dateConstraint &
                    " group by ch.ID,r.ID,(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))),ch.monthlyfee,(ch.currentvalue-ch.previousvalue),ch.kilowattprice,((ch.currentvalue-ch.previousvalue)*ch.kilowattprice)+roundvalue,total+discount,ch.discount,ch.total,ch.notes")
        cloneTable(ds.creditdt, a.ds.Tables(0))

        Dim chIds As New List(Of String)
        For Each item As DataRow In a.ds.Tables(0).Rows
            chIds.Add(item.Item(0).ToString())
        Next
        Dim idConstraint As String = String.Empty
        If chIds.Count > 0 Then
            idConstraint = " and p.counterhistoryid in (" & String.Join(",", chIds) & ") "
        End If

        a.ds = New DataSet
        a.GetData("SELECT p.ID as [معرّف الدفعة],p.counterhistoryid as [معرّف القيمة],(ar.caption + '-' + CAST(ch.cyear as nvarchar(50))) as [شهر],p.pdate as [تاريخ الدفعة],p.pvalue as [قيمة الدفعة],p.notes as [ملاحظات] FROM Payment p,CounterHistory ch,Registration r, ArabicMonth ar WHERE p.counterhistoryid=ch.ID and ch.regid=r.ID and ch.cmonth=ar.ID and r.ID=" & regid & idConstraint & " order by p.pdate asc")
        cloneTable(ds.paymentdt, a.ds.Tables(0))

        isClientReport = True

        InitializeComponent()
    End Sub

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

    Sub New(ByRef dsgr As DataSetGeneralReport)
        Me.isMonthlyReport = True
        Me.dsgr = dsgr
        InitializeComponent()
    End Sub

    Public Sub cloneTable(ByRef table1 As DataTable, ByRef table2 As DataTable)
        For i As Int32 = 0 To table2.Rows.Count - 1
            table1.Rows.Add()
            table1.Rows(i).ItemArray = table2(i).ItemArray
        Next
    End Sub

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs) Handles DocumentViewer1.Load
        Dim dr As DataRow = ds.OrgInfodt.NewOrgInfodtRow
        dr.ItemArray = New Object() {orgname, "", "", ""}
        ds.OrgInfodt.Rows.Add(dr)

        Dim rptDoc As XtraReport = Nothing

        If isGeneralReport Then
            rptDoc = New XtraGeneralReport
        ElseIf isEmptyChReport Then
            rptDoc = New XtraEmptyCouterHistoryReport
        ElseIf isClientReport Then
            rptDoc = New XtraClientAccountReport
        ElseIf isCreditsReport Then
            rptDoc = New XtraClientsCreditsReport
        ElseIf verbose Then
            rptDoc = New XtraInvoicesReport
            MoveElements(rptDoc)
        ElseIf isMonthlyReport Then
            rptDoc = New XtraGeneralMonthlyReport
            rptDoc.DataSource = dsgr
            Dim drgr As DataRow = dsgr.OrgInfodt.NewOrgInfodtRow
            drgr.ItemArray = New Object() {orgname, "", ""}
            dsgr.OrgInfodt.Rows.Add(drgr)
            For Each subreport As XRSubreport In rptDoc.AllControls(Of XRSubreport)
                CType(subreport.ReportSource, XtraReport).DataSource = dsgr
            Next
        ElseIf Not verbose Then
            rptDoc = New XtraInvoicesWithoutCreditReport
            MoveElements(rptDoc)
        End If

        If Not isMonthlyReport Then
            rptDoc.DataSource = ds
            For Each subreport As XRSubreport In rptDoc.AllControls(Of XRSubreport)
                CType(subreport.ReportSource, XtraReport).DataSource = ds
            Next
        End If

        DocumentViewer1.DocumentSource = rptDoc

    End Sub

    Private Sub MoveElements(ByRef rptDoc As XtraReport)
        For Each cont As XRControl In rptDoc.AllControls(Of XRControl)
            If TypeOf cont Is XRCrossBandBox Then
                Dim box As XRCrossBandBox = CType(cont, XRCrossBandBox)
                box.StartPointF = New PointF(box.StartPointF.X + invoiceXOffset, box.StartPointF.Y + invoiceYOffset)
                box.EndPointF = New PointF(box.EndPointF.X, box.EndPointF.Y + invoiceYOffset)
            Else
                cont.LocationF = New PointF(cont.LocationF.X + invoiceXOffset, cont.LocationF.Y + invoiceYOffset)
            End If
        Next
    End Sub
End Class