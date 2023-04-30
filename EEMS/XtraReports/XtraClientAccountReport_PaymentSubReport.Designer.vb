<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraClientAccountReport_PaymentSubReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.DetailArea1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.pID1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.counterhistoryid1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pvalue1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.notes1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pdate1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line3 = New DevExpress.XtraReports.UI.XRLine()
        Me.formonth1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeaderArea1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.ReportHeaderSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.ReportHeaderSection2 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterArea1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.ReportFooterSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Sumofpvalue1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterSection2 = New DevExpress.XtraReports.UI.SubBand()
        Me.Line4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line6 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line7 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line8 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line9 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line10 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Box1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.SharedTotalPaid = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DataSetInvoices1 = New EEMS.DataSetInvoices()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DetailArea1
        '
        Me.DetailArea1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pID1, Me.counterhistoryid1, Me.pvalue1, Me.notes1, Me.pdate1, Me.Line3, Me.formonth1})
        Me.DetailArea1.HeightF = 22.0!
        Me.DetailArea1.KeepTogether = True
        Me.DetailArea1.Name = "DetailArea1"
        Me.DetailArea1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.DetailArea1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pID1
        '
        Me.pID1.BackColor = System.Drawing.Color.Transparent
        Me.pID1.BorderColor = System.Drawing.Color.Black
        Me.pID1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pID1.BorderWidth = 1.0!
        Me.pID1.CanGrow = False
        Me.pID1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[paymentdt].[pID]")})
        Me.pID1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.pID1.ForeColor = System.Drawing.Color.Black
        Me.pID1.LocationFloat = New DevExpress.Utils.PointFloat(666.6667!, 4.166667!)
        Me.pID1.Name = "pID1"
        Me.pID1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pID1.SizeF = New System.Drawing.SizeF(100.0!, 15.34722!)
        Me.pID1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'counterhistoryid1
        '
        Me.counterhistoryid1.BackColor = System.Drawing.Color.Transparent
        Me.counterhistoryid1.BorderColor = System.Drawing.Color.Black
        Me.counterhistoryid1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.counterhistoryid1.BorderWidth = 1.0!
        Me.counterhistoryid1.CanGrow = False
        Me.counterhistoryid1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[paymentdt].[counterhistoryid]")})
        Me.counterhistoryid1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.counterhistoryid1.ForeColor = System.Drawing.Color.Black
        Me.counterhistoryid1.LocationFloat = New DevExpress.Utils.PointFloat(558.3333!, 4.166667!)
        Me.counterhistoryid1.Name = "counterhistoryid1"
        Me.counterhistoryid1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.counterhistoryid1.SizeF = New System.Drawing.SizeF(104.8611!, 15.34722!)
        Me.counterhistoryid1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'pvalue1
        '
        Me.pvalue1.BackColor = System.Drawing.Color.Transparent
        Me.pvalue1.BorderColor = System.Drawing.Color.Black
        Me.pvalue1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pvalue1.BorderWidth = 1.0!
        Me.pvalue1.CanGrow = False
        Me.pvalue1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[paymentdt].[pvalue]")})
        Me.pvalue1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.pvalue1.ForeColor = System.Drawing.Color.Black
        Me.pvalue1.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 4.166667!)
        Me.pvalue1.Name = "pvalue1"
        Me.pvalue1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pvalue1.SizeF = New System.Drawing.SizeF(104.375!, 15.34722!)
        Me.pvalue1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.pvalue1.TextFormatString = "{0:N0}"
        '
        'notes1
        '
        Me.notes1.BackColor = System.Drawing.Color.Transparent
        Me.notes1.BorderColor = System.Drawing.Color.Black
        Me.notes1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.notes1.BorderWidth = 1.0!
        Me.notes1.CanGrow = False
        Me.notes1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[paymentdt].[notes]")})
        Me.notes1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.notes1.ForeColor = System.Drawing.Color.Black
        Me.notes1.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 4.166667!)
        Me.notes1.Name = "notes1"
        Me.notes1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.notes1.SizeF = New System.Drawing.SizeF(150.0!, 15.34722!)
        Me.notes1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'pdate1
        '
        Me.pdate1.BackColor = System.Drawing.Color.Transparent
        Me.pdate1.BorderColor = System.Drawing.Color.Black
        Me.pdate1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pdate1.BorderWidth = 1.0!
        Me.pdate1.CanGrow = False
        Me.pdate1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[paymentdt].[pdate]")})
        Me.pdate1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.pdate1.ForeColor = System.Drawing.Color.Black
        Me.pdate1.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 4.166667!)
        Me.pdate1.Name = "pdate1"
        Me.pdate1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pdate1.SizeF = New System.Drawing.SizeF(155.2083!, 15.34722!)
        Me.pdate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.BorderColor = System.Drawing.Color.Silver
        Me.Line3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line3.BorderWidth = 1.0!
        Me.Line3.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line3.ForeColor = System.Drawing.Color.Silver
        Me.Line3.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 22.77778!)
        Me.Line3.Name = "Line3"
        Me.Line3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line3.SizeF = New System.Drawing.SizeF(758.3333!, 2.0!)
        Me.Line3.StylePriority.UseBorders = False
        '
        'formonth1
        '
        Me.formonth1.BackColor = System.Drawing.Color.Transparent
        Me.formonth1.BorderColor = System.Drawing.Color.Black
        Me.formonth1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.formonth1.BorderWidth = 1.0!
        Me.formonth1.CanGrow = False
        Me.formonth1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[paymentdt].[formonth]")})
        Me.formonth1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.formonth1.ForeColor = System.Drawing.Color.Black
        Me.formonth1.LocationFloat = New DevExpress.Utils.PointFloat(433.3333!, 4.166667!)
        Me.formonth1.Name = "formonth1"
        Me.formonth1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.formonth1.SizeF = New System.Drawing.SizeF(125.0!, 15.34722!)
        Me.formonth1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportHeaderArea1
        '
        Me.ReportHeaderArea1.HeightF = 0!
        Me.ReportHeaderArea1.Name = "ReportHeaderArea1"
        Me.ReportHeaderArea1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderArea1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.ReportHeaderSection1, Me.ReportHeaderSection2})
        Me.ReportHeaderArea1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.HeightF = 15.0!
        Me.ReportHeaderSection1.KeepTogether = True
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeaderSection2
        '
        Me.ReportHeaderSection2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text1, Me.Text2, Me.Text4, Me.Text5, Me.Line2, Me.Line1, Me.Text3, Me.Text7})
        Me.ReportHeaderSection2.HeightF = 29.0!
        Me.ReportHeaderSection2.KeepTogether = True
        Me.ReportHeaderSection2.Name = "ReportHeaderSection2"
        Me.ReportHeaderSection2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.Transparent
        Me.Text1.BorderColor = System.Drawing.Color.Black
        Me.Text1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text1.BorderWidth = 1.0!
        Me.Text1.CanGrow = False
        Me.Text1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 8.333333!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(150.0!, 15.34722!)
        Me.Text1.Text = "ملاحظات"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text2
        '
        Me.Text2.BackColor = System.Drawing.Color.Transparent
        Me.Text2.BorderColor = System.Drawing.Color.Black
        Me.Text2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text2.BorderWidth = 1.0!
        Me.Text2.CanGrow = False
        Me.Text2.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text2.ForeColor = System.Drawing.Color.Black
        Me.Text2.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 8.333333!)
        Me.Text2.Name = "Text2"
        Me.Text2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text2.SizeF = New System.Drawing.SizeF(108.3333!, 15.34722!)
        Me.Text2.Text = "المبلغ المدفوع"
        Me.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text4
        '
        Me.Text4.BackColor = System.Drawing.Color.Transparent
        Me.Text4.BorderColor = System.Drawing.Color.Black
        Me.Text4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text4.BorderWidth = 1.0!
        Me.Text4.CanGrow = False
        Me.Text4.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text4.ForeColor = System.Drawing.Color.Black
        Me.Text4.LocationFloat = New DevExpress.Utils.PointFloat(558.3333!, 8.333333!)
        Me.Text4.Name = "Text4"
        Me.Text4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text4.SizeF = New System.Drawing.SizeF(108.3333!, 15.34722!)
        Me.Text4.Text = "معرّف الصرف"
        Me.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text5
        '
        Me.Text5.BackColor = System.Drawing.Color.Transparent
        Me.Text5.BorderColor = System.Drawing.Color.Black
        Me.Text5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text5.BorderWidth = 1.0!
        Me.Text5.CanGrow = False
        Me.Text5.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text5.ForeColor = System.Drawing.Color.Black
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(666.6667!, 8.333333!)
        Me.Text5.Name = "Text5"
        Me.Text5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text5.SizeF = New System.Drawing.SizeF(100.0!, 15.34722!)
        Me.Text5.Text = "معرّف الدفعة"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Transparent
        Me.Line2.BorderColor = System.Drawing.Color.Silver
        Me.Line2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line2.BorderWidth = 1.0!
        Me.Line2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line2.ForeColor = System.Drawing.Color.Silver
        Me.Line2.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 3.472222!)
        Me.Line2.Name = "Line2"
        Me.Line2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line2.SizeF = New System.Drawing.SizeF(758.3333!, 2.0!)
        Me.Line2.StylePriority.UseBorders = False
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Transparent
        Me.Line1.BorderColor = System.Drawing.Color.Silver
        Me.Line1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Line1.BorderWidth = 1.0!
        Me.Line1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line1.ForeColor = System.Drawing.Color.Silver
        Me.Line1.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 29.09722!)
        Me.Line1.Name = "Line1"
        Me.Line1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line1.SizeF = New System.Drawing.SizeF(758.3333!, 2.0!)
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.Transparent
        Me.Text3.BorderColor = System.Drawing.Color.Black
        Me.Text3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text3.BorderWidth = 1.0!
        Me.Text3.CanGrow = False
        Me.Text3.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text3.ForeColor = System.Drawing.Color.Black
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 8.333333!)
        Me.Text3.Name = "Text3"
        Me.Text3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text3.SizeF = New System.Drawing.SizeF(158.3333!, 15.34722!)
        Me.Text3.Text = "تاريخ الدفعة"
        Me.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text7
        '
        Me.Text7.BackColor = System.Drawing.Color.Transparent
        Me.Text7.BorderColor = System.Drawing.Color.Black
        Me.Text7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text7.BorderWidth = 1.0!
        Me.Text7.CanGrow = False
        Me.Text7.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text7.ForeColor = System.Drawing.Color.Black
        Me.Text7.LocationFloat = New DevExpress.Utils.PointFloat(433.3333!, 8.333333!)
        Me.Text7.Name = "Text7"
        Me.Text7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text7.SizeF = New System.Drawing.SizeF(125.0!, 15.34722!)
        Me.Text7.Text = "عن شهر"
        Me.Text7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportFooterArea1
        '
        Me.ReportFooterArea1.HeightF = 0!
        Me.ReportFooterArea1.Name = "ReportFooterArea1"
        Me.ReportFooterArea1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterArea1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.ReportFooterSection1, Me.ReportFooterSection2})
        Me.ReportFooterArea1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Sumofpvalue1, Me.Text9, Me.Text6})
        Me.ReportFooterSection1.HeightF = 43.0!
        Me.ReportFooterSection1.KeepTogether = True
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        Me.ReportFooterSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Sumofpvalue1
        '
        Me.Sumofpvalue1.BackColor = System.Drawing.Color.Transparent
        Me.Sumofpvalue1.BorderColor = System.Drawing.Color.Black
        Me.Sumofpvalue1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Sumofpvalue1.BorderWidth = 1.0!
        Me.Sumofpvalue1.CanGrow = False
        Me.Sumofpvalue1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([pvalue])")})
        Me.Sumofpvalue1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Sumofpvalue1.ForeColor = System.Drawing.Color.Black
        Me.Sumofpvalue1.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 12.84722!)
        Me.Sumofpvalue1.Name = "Sumofpvalue1"
        Me.Sumofpvalue1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Sumofpvalue1.SizeF = New System.Drawing.SizeF(116.6667!, 15.97222!)
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.Sumofpvalue1.Summary = XrSummary1
        Me.Sumofpvalue1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Sumofpvalue1.TextFormatString = "{0:N0}"
        '
        'Text9
        '
        Me.Text9.BackColor = System.Drawing.Color.Transparent
        Me.Text9.BorderColor = System.Drawing.Color.Black
        Me.Text9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text9.BorderWidth = 1.0!
        Me.Text9.CanGrow = False
        Me.Text9.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Text9.ForeColor = System.Drawing.Color.Black
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 13.88889!)
        Me.Text9.Name = "Text9"
        Me.Text9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text9.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text9.SizeF = New System.Drawing.SizeF(98.33334!, 13.88889!)
        Me.Text9.Text = "اجمالي المدفوعات:"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text6
        '
        Me.Text6.BackColor = System.Drawing.Color.Transparent
        Me.Text6.BorderColor = System.Drawing.Color.Black
        Me.Text6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text6.BorderWidth = 1.0!
        Me.Text6.CanGrow = False
        Me.Text6.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text6.ForeColor = System.Drawing.Color.Black
        Me.Text6.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 13.19444!)
        Me.Text6.Name = "Text6"
        Me.Text6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text6.SizeF = New System.Drawing.SizeF(25.0!, 15.34722!)
        Me.Text6.Text = "ل.ل"
        Me.Text6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportFooterSection2
        '
        Me.ReportFooterSection2.HeightF = 0!
        Me.ReportFooterSection2.KeepTogether = True
        Me.ReportFooterSection2.Name = "ReportFooterSection2"
        Me.ReportFooterSection2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Line4
        '
        Me.Line4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line4.EndBand = Me.DetailArea1
        Me.Line4.EndPointFloat = New DevExpress.Utils.PointFloat(665.625!, 22.22222!)
        Me.Line4.ForeColor = System.Drawing.Color.Silver
        Me.Line4.Name = "Line4"
        Me.Line4.StartBand = Me.ReportHeaderSection2
        Me.Line4.StartPointFloat = New DevExpress.Utils.PointFloat(665.625!, 4.166667!)
        Me.Line4.WidthF = 1.0!
        '
        'Line5
        '
        Me.Line5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line5.EndBand = Me.DetailArea1
        Me.Line5.EndPointFloat = New DevExpress.Utils.PointFloat(433.3333!, 22.22222!)
        Me.Line5.ForeColor = System.Drawing.Color.Silver
        Me.Line5.Name = "Line5"
        Me.Line5.StartBand = Me.ReportHeaderSection2
        Me.Line5.StartPointFloat = New DevExpress.Utils.PointFloat(433.3333!, 4.166667!)
        Me.Line5.WidthF = 1.0!
        '
        'Line6
        '
        Me.Line6.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line6.EndBand = Me.DetailArea1
        Me.Line6.EndPointFloat = New DevExpress.Utils.PointFloat(275.0!, 22.22222!)
        Me.Line6.ForeColor = System.Drawing.Color.Silver
        Me.Line6.Name = "Line6"
        Me.Line6.StartBand = Me.ReportHeaderSection2
        Me.Line6.StartPointFloat = New DevExpress.Utils.PointFloat(275.0!, 4.166667!)
        Me.Line6.WidthF = 1.0!
        '
        'Line7
        '
        Me.Line7.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line7.EndBand = Me.DetailArea1
        Me.Line7.EndPointFloat = New DevExpress.Utils.PointFloat(125.0!, 22.22222!)
        Me.Line7.ForeColor = System.Drawing.Color.Silver
        Me.Line7.Name = "Line7"
        Me.Line7.StartBand = Me.ReportHeaderSection2
        Me.Line7.StartPointFloat = New DevExpress.Utils.PointFloat(125.0!, 4.166667!)
        Me.Line7.WidthF = 1.0!
        '
        'Line8
        '
        Me.Line8.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line8.EndBand = Me.DetailArea1
        Me.Line8.EndPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 22.22222!)
        Me.Line8.ForeColor = System.Drawing.Color.Silver
        Me.Line8.Name = "Line8"
        Me.Line8.StartBand = Me.ReportHeaderSection2
        Me.Line8.StartPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 4.166667!)
        Me.Line8.WidthF = 1.0!
        '
        'Line9
        '
        Me.Line9.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line9.EndBand = Me.DetailArea1
        Me.Line9.EndPointFloat = New DevExpress.Utils.PointFloat(766.6667!, 22.22222!)
        Me.Line9.ForeColor = System.Drawing.Color.Silver
        Me.Line9.Name = "Line9"
        Me.Line9.StartBand = Me.ReportHeaderSection2
        Me.Line9.StartPointFloat = New DevExpress.Utils.PointFloat(766.6667!, 4.166667!)
        Me.Line9.WidthF = 1.0!
        '
        'Line10
        '
        Me.Line10.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line10.EndBand = Me.DetailArea1
        Me.Line10.EndPointFloat = New DevExpress.Utils.PointFloat(558.3333!, 22.22222!)
        Me.Line10.ForeColor = System.Drawing.Color.Silver
        Me.Line10.Name = "Line10"
        Me.Line10.StartBand = Me.ReportHeaderSection2
        Me.Line10.StartPointFloat = New DevExpress.Utils.PointFloat(558.3333!, 4.166667!)
        Me.Line10.WidthF = 1.0!
        '
        'Box1
        '
        Me.Box1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Box1.BorderColor = System.Drawing.Color.Silver
        Me.Box1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Box1.EndBand = Me.ReportFooterSection1
        Me.Box1.EndPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 33.33333!)
        Me.Box1.Name = "Box1"
        Me.Box1.StartBand = Me.ReportFooterSection1
        Me.Box1.StartPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 8.333333!)
        Me.Box1.WidthF = 273.9583!
        '
        'SharedTotalPaid
        '
        Me.SharedTotalPaid.Expression = "Iif(True, '#NOT_SUPPORTED#', 'WhilePrintingRecords;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shared numberVar paymentTota" &
    "l := Sum ({paymentdt.pvalue});" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "paymentTotal')"
        Me.SharedTotalPaid.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.SharedTotalPaid.Name = "SharedTotalPaid"
        '
        'DataSetInvoices1
        '
        Me.DataSetInvoices1.DataSetName = "DataSetInvoices"
        Me.DataSetInvoices1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XtraClientAccountReport_PaymentSubReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailArea1, Me.ReportHeaderArea1, Me.ReportFooterArea1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SharedTotalPaid})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetInvoices1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Box1})
        Me.DataMember = "paymentdt"
        Me.DataSource = Me.DataSetInvoices1
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 0, 100, 100)
        Me.Version = "21.2"
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents DetailArea1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents pID1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents counterhistoryid1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pvalue1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents notes1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pdate1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents formonth1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeaderArea1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportHeaderSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents ReportHeaderSection2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Text3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooterArea1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents ReportFooterSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Sumofpvalue1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooterSection2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Line4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line6 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line7 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line8 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line9 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line10 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Box1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents SharedTotalPaid As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DataSetInvoices1 As DataSetInvoices
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
