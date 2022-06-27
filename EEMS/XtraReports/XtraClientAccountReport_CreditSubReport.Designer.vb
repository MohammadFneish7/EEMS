<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraClientAccountReport_CreditSubReport
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
        Me.DetailArea1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.chID1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.month1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.total1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fee1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.counterdiff1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.kilowattprice1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.requiredkilo1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.discount1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.required1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paid1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.remained1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeaderArea1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.ReportHeaderSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.ReportHeaderSection2 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line4 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line3 = New DevExpress.XtraReports.UI.XRLine()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterArea1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.ReportFooterSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SharedtotalCredit_1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterSection2 = New DevExpress.XtraReports.UI.SubBand()
        Me.Line2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line6 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line7 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line8 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line9 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line10 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line11 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line12 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line13 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line14 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line15 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Box1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.SharedtotalCredit = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DataSetInvoices1 = New EEMS.DataSetInvoices()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DetailArea1
        '
        Me.DetailArea1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.chID1, Me.month1, Me.total1, Me.fee1, Me.counterdiff1, Me.kilowattprice1, Me.requiredkilo1, Me.Line1, Me.discount1, Me.required1, Me.paid1, Me.remained1})
        Me.DetailArea1.HeightF = 23.0!
        Me.DetailArea1.KeepTogether = True
        Me.DetailArea1.Name = "DetailArea1"
        Me.DetailArea1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.DetailArea1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'chID1
        '
        Me.chID1.BackColor = System.Drawing.Color.Transparent
        Me.chID1.BorderColor = System.Drawing.Color.Black
        Me.chID1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.chID1.BorderWidth = 1.0!
        Me.chID1.CanGrow = False
        Me.chID1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[chID]")})
        Me.chID1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.chID1.ForeColor = System.Drawing.Color.Black
        Me.chID1.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 0.06944445!)
        Me.chID1.Name = "chID1"
        Me.chID1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.chID1.SizeF = New System.Drawing.SizeF(66.66666!, 22.84722!)
        Me.chID1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'month1
        '
        Me.month1.BackColor = System.Drawing.Color.Transparent
        Me.month1.BorderColor = System.Drawing.Color.Black
        Me.month1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.month1.BorderWidth = 1.0!
        Me.month1.CanGrow = False
        Me.month1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[month]")})
        Me.month1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.month1.ForeColor = System.Drawing.Color.Black
        Me.month1.LocationFloat = New DevExpress.Utils.PointFloat(625.0!, 0.06944445!)
        Me.month1.Name = "month1"
        Me.month1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.month1.SizeF = New System.Drawing.SizeF(75.0!, 22.84722!)
        Me.month1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'total1
        '
        Me.total1.BackColor = System.Drawing.Color.Transparent
        Me.total1.BorderColor = System.Drawing.Color.Black
        Me.total1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.total1.BorderWidth = 1.0!
        Me.total1.CanGrow = False
        Me.total1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[total]")})
        Me.total1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.total1.ForeColor = System.Drawing.Color.Black
        Me.total1.LocationFloat = New DevExpress.Utils.PointFloat(258.3333!, 0.06944445!)
        Me.total1.Name = "total1"
        Me.total1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.total1.SizeF = New System.Drawing.SizeF(83.33334!, 22.84722!)
        Me.total1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'fee1
        '
        Me.fee1.BackColor = System.Drawing.Color.Transparent
        Me.fee1.BorderColor = System.Drawing.Color.Black
        Me.fee1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.fee1.BorderWidth = 1.0!
        Me.fee1.CanGrow = False
        Me.fee1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[fee]")})
        Me.fee1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.fee1.ForeColor = System.Drawing.Color.Black
        Me.fee1.LocationFloat = New DevExpress.Utils.PointFloat(558.3333!, 0.06944445!)
        Me.fee1.Name = "fee1"
        Me.fee1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fee1.SizeF = New System.Drawing.SizeF(66.66666!, 22.84722!)
        Me.fee1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'counterdiff1
        '
        Me.counterdiff1.BackColor = System.Drawing.Color.Transparent
        Me.counterdiff1.BorderColor = System.Drawing.Color.Black
        Me.counterdiff1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.counterdiff1.BorderWidth = 1.0!
        Me.counterdiff1.CanGrow = False
        Me.counterdiff1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[counterdiff]")})
        Me.counterdiff1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.counterdiff1.ForeColor = System.Drawing.Color.Black
        Me.counterdiff1.LocationFloat = New DevExpress.Utils.PointFloat(483.3333!, 0.06944445!)
        Me.counterdiff1.Name = "counterdiff1"
        Me.counterdiff1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.counterdiff1.SizeF = New System.Drawing.SizeF(77.08334!, 22.84722!)
        Me.counterdiff1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'kilowattprice1
        '
        Me.kilowattprice1.BackColor = System.Drawing.Color.Transparent
        Me.kilowattprice1.BorderColor = System.Drawing.Color.Black
        Me.kilowattprice1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.kilowattprice1.BorderWidth = 1.0!
        Me.kilowattprice1.CanGrow = False
        Me.kilowattprice1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[kilowattprice]")})
        Me.kilowattprice1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.kilowattprice1.ForeColor = System.Drawing.Color.Black
        Me.kilowattprice1.LocationFloat = New DevExpress.Utils.PointFloat(416.6667!, 0.06944445!)
        Me.kilowattprice1.Name = "kilowattprice1"
        Me.kilowattprice1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.kilowattprice1.SizeF = New System.Drawing.SizeF(66.66666!, 22.84722!)
        Me.kilowattprice1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'requiredkilo1
        '
        Me.requiredkilo1.BackColor = System.Drawing.Color.Transparent
        Me.requiredkilo1.BorderColor = System.Drawing.Color.Black
        Me.requiredkilo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.requiredkilo1.BorderWidth = 1.0!
        Me.requiredkilo1.CanGrow = False
        Me.requiredkilo1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[requiredkilo]")})
        Me.requiredkilo1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.requiredkilo1.ForeColor = System.Drawing.Color.Black
        Me.requiredkilo1.LocationFloat = New DevExpress.Utils.PointFloat(341.6667!, 0.06944445!)
        Me.requiredkilo1.Name = "requiredkilo1"
        Me.requiredkilo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.requiredkilo1.SizeF = New System.Drawing.SizeF(77.08334!, 22.84722!)
        Me.requiredkilo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Transparent
        Me.Line1.BorderColor = System.Drawing.Color.Silver
        Me.Line1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line1.BorderWidth = 1.0!
        Me.Line1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line1.ForeColor = System.Drawing.Color.Silver
        Me.Line1.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 22.91667!)
        Me.Line1.Name = "Line1"
        Me.Line1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line1.SizeF = New System.Drawing.SizeF(758.3333!, 2.0!)
        Me.Line1.StylePriority.UseBorders = False
        '
        'discount1
        '
        Me.discount1.BackColor = System.Drawing.Color.Transparent
        Me.discount1.BorderColor = System.Drawing.Color.Black
        Me.discount1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.discount1.BorderWidth = 1.0!
        Me.discount1.CanGrow = False
        Me.discount1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[discount]")})
        Me.discount1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.discount1.ForeColor = System.Drawing.Color.Black
        Me.discount1.LocationFloat = New DevExpress.Utils.PointFloat(195.8333!, 0.06944445!)
        Me.discount1.Name = "discount1"
        Me.discount1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.discount1.SizeF = New System.Drawing.SizeF(62.5!, 22.84722!)
        Me.discount1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'required1
        '
        Me.required1.BackColor = System.Drawing.Color.Transparent
        Me.required1.BorderColor = System.Drawing.Color.Black
        Me.required1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.required1.BorderWidth = 1.0!
        Me.required1.CanGrow = False
        Me.required1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[required]")})
        Me.required1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.required1.ForeColor = System.Drawing.Color.Black
        Me.required1.LocationFloat = New DevExpress.Utils.PointFloat(133.3333!, 0.06944445!)
        Me.required1.Name = "required1"
        Me.required1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.required1.SizeF = New System.Drawing.SizeF(62.5!, 22.84722!)
        Me.required1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'paid1
        '
        Me.paid1.BackColor = System.Drawing.Color.Transparent
        Me.paid1.BorderColor = System.Drawing.Color.Black
        Me.paid1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.paid1.BorderWidth = 1.0!
        Me.paid1.CanGrow = False
        Me.paid1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[paid]")})
        Me.paid1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.paid1.ForeColor = System.Drawing.Color.Black
        Me.paid1.LocationFloat = New DevExpress.Utils.PointFloat(70.83334!, 0.06944445!)
        Me.paid1.Name = "paid1"
        Me.paid1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.paid1.SizeF = New System.Drawing.SizeF(62.5!, 22.84722!)
        Me.paid1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'remained1
        '
        Me.remained1.BackColor = System.Drawing.Color.Transparent
        Me.remained1.BorderColor = System.Drawing.Color.Black
        Me.remained1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.remained1.BorderWidth = 1.0!
        Me.remained1.CanGrow = False
        Me.remained1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[creditdt].[remained]")})
        Me.remained1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.remained1.ForeColor = System.Drawing.Color.Black
        Me.remained1.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 0.06944445!)
        Me.remained1.Name = "remained1"
        Me.remained1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.remained1.SizeF = New System.Drawing.SizeF(62.5!, 22.84722!)
        Me.remained1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.ReportHeaderSection2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text2, Me.Text6, Me.Text8, Me.Line4, Me.Line3, Me.Text3, Me.Text4, Me.Text5, Me.Text7, Me.Text11, Me.Text12, Me.Text13, Me.Text14})
        Me.ReportHeaderSection2.HeightF = 29.0!
        Me.ReportHeaderSection2.KeepTogether = True
        Me.ReportHeaderSection2.Name = "ReportHeaderSection2"
        Me.ReportHeaderSection2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text2
        '
        Me.Text2.BackColor = System.Drawing.Color.Transparent
        Me.Text2.BorderColor = System.Drawing.Color.Black
        Me.Text2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text2.BorderWidth = 1.0!
        Me.Text2.CanGrow = False
        Me.Text2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text2.ForeColor = System.Drawing.Color.Black
        Me.Text2.LocationFloat = New DevExpress.Utils.PointFloat(258.3333!, 8.333333!)
        Me.Text2.Name = "Text2"
        Me.Text2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text2.SizeF = New System.Drawing.SizeF(83.33334!, 15.34722!)
        Me.Text2.Text = "المجموع"
        Me.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text6
        '
        Me.Text6.BackColor = System.Drawing.Color.Transparent
        Me.Text6.BorderColor = System.Drawing.Color.Black
        Me.Text6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text6.BorderWidth = 1.0!
        Me.Text6.CanGrow = False
        Me.Text6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text6.ForeColor = System.Drawing.Color.Black
        Me.Text6.LocationFloat = New DevExpress.Utils.PointFloat(625.0!, 8.333333!)
        Me.Text6.Name = "Text6"
        Me.Text6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text6.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.Text6.Text = "الشهر"
        Me.Text6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text8
        '
        Me.Text8.BackColor = System.Drawing.Color.Transparent
        Me.Text8.BorderColor = System.Drawing.Color.Black
        Me.Text8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text8.BorderWidth = 1.0!
        Me.Text8.CanGrow = False
        Me.Text8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text8.ForeColor = System.Drawing.Color.Black
        Me.Text8.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 8.333333!)
        Me.Text8.Name = "Text8"
        Me.Text8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text8.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text8.Text = "رمز الصرف"
        Me.Text8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Transparent
        Me.Line4.BorderColor = System.Drawing.Color.Silver
        Me.Line4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line4.BorderWidth = 1.0!
        Me.Line4.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line4.ForeColor = System.Drawing.Color.Silver
        Me.Line4.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 0!)
        Me.Line4.Name = "Line4"
        Me.Line4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line4.SizeF = New System.Drawing.SizeF(758.3333!, 2.0!)
        Me.Line4.StylePriority.UseBorders = False
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.BorderColor = System.Drawing.Color.Silver
        Me.Line3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line3.BorderWidth = 1.0!
        Me.Line3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line3.ForeColor = System.Drawing.Color.Silver
        Me.Line3.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 29.16667!)
        Me.Line3.Name = "Line3"
        Me.Line3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line3.SizeF = New System.Drawing.SizeF(758.3333!, 2.0!)
        Me.Line3.StylePriority.UseBorders = False
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.Transparent
        Me.Text3.BorderColor = System.Drawing.Color.Black
        Me.Text3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text3.BorderWidth = 1.0!
        Me.Text3.CanGrow = False
        Me.Text3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text3.ForeColor = System.Drawing.Color.Black
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(558.3333!, 8.333333!)
        Me.Text3.Name = "Text3"
        Me.Text3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text3.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text3.Text = "رسم اشتراك"
        Me.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text4
        '
        Me.Text4.BackColor = System.Drawing.Color.Transparent
        Me.Text4.BorderColor = System.Drawing.Color.Black
        Me.Text4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text4.BorderWidth = 1.0!
        Me.Text4.CanGrow = False
        Me.Text4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text4.ForeColor = System.Drawing.Color.Black
        Me.Text4.LocationFloat = New DevExpress.Utils.PointFloat(483.3333!, 8.333333!)
        Me.Text4.Name = "Text4"
        Me.Text4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text4.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.Text4.Text = "فارق عداد"
        Me.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text5
        '
        Me.Text5.BackColor = System.Drawing.Color.Transparent
        Me.Text5.BorderColor = System.Drawing.Color.Black
        Me.Text5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text5.BorderWidth = 1.0!
        Me.Text5.CanGrow = False
        Me.Text5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text5.ForeColor = System.Drawing.Color.Black
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(416.6667!, 8.333333!)
        Me.Text5.Name = "Text5"
        Me.Text5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text5.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text5.Text = "سعر الكيلوات"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text7
        '
        Me.Text7.BackColor = System.Drawing.Color.Transparent
        Me.Text7.BorderColor = System.Drawing.Color.Black
        Me.Text7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text7.BorderWidth = 1.0!
        Me.Text7.CanGrow = False
        Me.Text7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text7.ForeColor = System.Drawing.Color.Black
        Me.Text7.LocationFloat = New DevExpress.Utils.PointFloat(341.6667!, 8.333333!)
        Me.Text7.Name = "Text7"
        Me.Text7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text7.SizeF = New System.Drawing.SizeF(77.08334!, 15.34722!)
        Me.Text7.Text = "مطلوب كيلوات"
        Me.Text7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text11
        '
        Me.Text11.BackColor = System.Drawing.Color.Transparent
        Me.Text11.BorderColor = System.Drawing.Color.Black
        Me.Text11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text11.BorderWidth = 1.0!
        Me.Text11.CanGrow = False
        Me.Text11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text11.ForeColor = System.Drawing.Color.Black
        Me.Text11.LocationFloat = New DevExpress.Utils.PointFloat(195.8333!, 8.333333!)
        Me.Text11.Name = "Text11"
        Me.Text11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text11.SizeF = New System.Drawing.SizeF(62.5!, 15.34722!)
        Me.Text11.Text = "حسم"
        Me.Text11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text12
        '
        Me.Text12.BackColor = System.Drawing.Color.Transparent
        Me.Text12.BorderColor = System.Drawing.Color.Black
        Me.Text12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text12.BorderWidth = 1.0!
        Me.Text12.CanGrow = False
        Me.Text12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text12.ForeColor = System.Drawing.Color.Black
        Me.Text12.LocationFloat = New DevExpress.Utils.PointFloat(133.3333!, 8.333333!)
        Me.Text12.Name = "Text12"
        Me.Text12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text12.SizeF = New System.Drawing.SizeF(62.5!, 15.34722!)
        Me.Text12.Text = "إجمالي"
        Me.Text12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text13
        '
        Me.Text13.BackColor = System.Drawing.Color.Transparent
        Me.Text13.BorderColor = System.Drawing.Color.Black
        Me.Text13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text13.BorderWidth = 1.0!
        Me.Text13.CanGrow = False
        Me.Text13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text13.ForeColor = System.Drawing.Color.Black
        Me.Text13.LocationFloat = New DevExpress.Utils.PointFloat(70.83334!, 8.333333!)
        Me.Text13.Name = "Text13"
        Me.Text13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text13.SizeF = New System.Drawing.SizeF(62.5!, 15.34722!)
        Me.Text13.Text = "مدفوع"
        Me.Text13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text14
        '
        Me.Text14.BackColor = System.Drawing.Color.Transparent
        Me.Text14.BorderColor = System.Drawing.Color.Black
        Me.Text14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text14.BorderWidth = 1.0!
        Me.Text14.CanGrow = False
        Me.Text14.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text14.ForeColor = System.Drawing.Color.Black
        Me.Text14.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 8.333333!)
        Me.Text14.Name = "Text14"
        Me.Text14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text14.SizeF = New System.Drawing.SizeF(62.5!, 15.34722!)
        Me.Text14.Text = "باقي"
        Me.Text14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.ReportFooterSection1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text9, Me.Text1, Me.SharedtotalCredit_1})
        Me.ReportFooterSection1.HeightF = 40.0!
        Me.ReportFooterSection1.KeepTogether = True
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        Me.ReportFooterSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text9
        '
        Me.Text9.BackColor = System.Drawing.Color.Transparent
        Me.Text9.BorderColor = System.Drawing.Color.Black
        Me.Text9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text9.BorderWidth = 1.0!
        Me.Text9.CanGrow = False
        Me.Text9.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Text9.ForeColor = System.Drawing.Color.Black
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 14.23611!)
        Me.Text9.Name = "Text9"
        Me.Text9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text9.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text9.SizeF = New System.Drawing.SizeF(98.33334!, 15.34722!)
        Me.Text9.Text = "اجمالي المستحقّات:"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.Transparent
        Me.Text1.BorderColor = System.Drawing.Color.Black
        Me.Text1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text1.BorderWidth = 1.0!
        Me.Text1.CanGrow = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 14.23611!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(25.0!, 15.34722!)
        Me.Text1.Text = "ل.ل"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'SharedtotalCredit_1
        '
        Me.SharedtotalCredit_1.BackColor = System.Drawing.Color.Transparent
        Me.SharedtotalCredit_1.BorderColor = System.Drawing.Color.Black
        Me.SharedtotalCredit_1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.SharedtotalCredit_1.BorderWidth = 1.0!
        Me.SharedtotalCredit_1.CanGrow = False
        Me.SharedtotalCredit_1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "WidthF", "SUM([creditdt].[re])"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([total])")})
        Me.SharedtotalCredit_1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SharedtotalCredit_1.ForeColor = System.Drawing.Color.Black
        Me.SharedtotalCredit_1.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 13.54167!)
        Me.SharedtotalCredit_1.Name = "SharedtotalCredit_1"
        Me.SharedtotalCredit_1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SharedtotalCredit_1.SizeF = New System.Drawing.SizeF(123.9583!, 16.66667!)
        Me.SharedtotalCredit_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooterSection2
        '
        Me.ReportFooterSection2.HeightF = 0!
        Me.ReportFooterSection2.KeepTogether = True
        Me.ReportFooterSection2.Name = "ReportFooterSection2"
        Me.ReportFooterSection2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Line2
        '
        Me.Line2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line2.EndBand = Me.DetailArea1
        Me.Line2.EndPointFloat = New DevExpress.Utils.PointFloat(766.6667!, 23.95833!)
        Me.Line2.ForeColor = System.Drawing.Color.Silver
        Me.Line2.Name = "Line2"
        Me.Line2.StartBand = Me.ReportHeaderSection2
        Me.Line2.StartPointFloat = New DevExpress.Utils.PointFloat(766.6667!, 0!)
        Me.Line2.WidthF = 1.0!
        '
        'Line6
        '
        Me.Line6.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line6.EndBand = Me.DetailArea1
        Me.Line6.EndPointFloat = New DevExpress.Utils.PointFloat(625.0!, 23.95833!)
        Me.Line6.ForeColor = System.Drawing.Color.Silver
        Me.Line6.Name = "Line6"
        Me.Line6.StartBand = Me.ReportHeaderSection2
        Me.Line6.StartPointFloat = New DevExpress.Utils.PointFloat(625.0!, 0!)
        Me.Line6.WidthF = 1.0!
        '
        'Line7
        '
        Me.Line7.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line7.EndBand = Me.DetailArea1
        Me.Line7.EndPointFloat = New DevExpress.Utils.PointFloat(558.3333!, 23.95833!)
        Me.Line7.ForeColor = System.Drawing.Color.Silver
        Me.Line7.Name = "Line7"
        Me.Line7.StartBand = Me.ReportHeaderSection2
        Me.Line7.StartPointFloat = New DevExpress.Utils.PointFloat(558.3333!, 0!)
        Me.Line7.WidthF = 1.0!
        '
        'Line8
        '
        Me.Line8.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line8.EndBand = Me.DetailArea1
        Me.Line8.EndPointFloat = New DevExpress.Utils.PointFloat(483.3333!, 23.95833!)
        Me.Line8.ForeColor = System.Drawing.Color.Silver
        Me.Line8.Name = "Line8"
        Me.Line8.StartBand = Me.ReportHeaderSection2
        Me.Line8.StartPointFloat = New DevExpress.Utils.PointFloat(483.3333!, 0!)
        Me.Line8.WidthF = 1.0!
        '
        'Line9
        '
        Me.Line9.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line9.EndBand = Me.DetailArea1
        Me.Line9.EndPointFloat = New DevExpress.Utils.PointFloat(417.3611!, 23.95833!)
        Me.Line9.ForeColor = System.Drawing.Color.Silver
        Me.Line9.Name = "Line9"
        Me.Line9.StartBand = Me.ReportHeaderSection2
        Me.Line9.StartPointFloat = New DevExpress.Utils.PointFloat(417.3611!, 0!)
        Me.Line9.WidthF = 1.0!
        '
        'Line10
        '
        Me.Line10.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line10.EndBand = Me.DetailArea1
        Me.Line10.EndPointFloat = New DevExpress.Utils.PointFloat(341.6667!, 23.95833!)
        Me.Line10.ForeColor = System.Drawing.Color.Silver
        Me.Line10.Name = "Line10"
        Me.Line10.StartBand = Me.ReportHeaderSection2
        Me.Line10.StartPointFloat = New DevExpress.Utils.PointFloat(341.6667!, 0!)
        Me.Line10.WidthF = 1.0!
        '
        'Line11
        '
        Me.Line11.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line11.EndBand = Me.DetailArea1
        Me.Line11.EndPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 23.95833!)
        Me.Line11.ForeColor = System.Drawing.Color.Silver
        Me.Line11.Name = "Line11"
        Me.Line11.StartBand = Me.ReportHeaderSection2
        Me.Line11.StartPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 0!)
        Me.Line11.WidthF = 1.0!
        '
        'Line12
        '
        Me.Line12.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line12.EndBand = Me.DetailArea1
        Me.Line12.EndPointFloat = New DevExpress.Utils.PointFloat(258.3333!, 23.95833!)
        Me.Line12.ForeColor = System.Drawing.Color.Silver
        Me.Line12.Name = "Line12"
        Me.Line12.StartBand = Me.ReportHeaderSection2
        Me.Line12.StartPointFloat = New DevExpress.Utils.PointFloat(258.3333!, 0!)
        Me.Line12.WidthF = 1.0!
        '
        'Line13
        '
        Me.Line13.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line13.EndBand = Me.DetailArea1
        Me.Line13.EndPointFloat = New DevExpress.Utils.PointFloat(195.1389!, 23.95833!)
        Me.Line13.ForeColor = System.Drawing.Color.Silver
        Me.Line13.Name = "Line13"
        Me.Line13.StartBand = Me.ReportHeaderSection2
        Me.Line13.StartPointFloat = New DevExpress.Utils.PointFloat(195.1389!, 0!)
        Me.Line13.WidthF = 1.0!
        '
        'Line14
        '
        Me.Line14.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line14.EndBand = Me.DetailArea1
        Me.Line14.EndPointFloat = New DevExpress.Utils.PointFloat(133.3333!, 23.95833!)
        Me.Line14.ForeColor = System.Drawing.Color.Silver
        Me.Line14.Name = "Line14"
        Me.Line14.StartBand = Me.ReportHeaderSection2
        Me.Line14.StartPointFloat = New DevExpress.Utils.PointFloat(133.3333!, 0!)
        Me.Line14.WidthF = 1.0!
        '
        'Line15
        '
        Me.Line15.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line15.EndBand = Me.DetailArea1
        Me.Line15.EndPointFloat = New DevExpress.Utils.PointFloat(70.83334!, 23.95833!)
        Me.Line15.ForeColor = System.Drawing.Color.Silver
        Me.Line15.Name = "Line15"
        Me.Line15.StartBand = Me.ReportHeaderSection2
        Me.Line15.StartPointFloat = New DevExpress.Utils.PointFloat(70.83334!, 0!)
        Me.Line15.WidthF = 1.0!
        '
        'Line5
        '
        Me.Line5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line5.EndBand = Me.DetailArea1
        Me.Line5.EndPointFloat = New DevExpress.Utils.PointFloat(700.0!, 23.95833!)
        Me.Line5.ForeColor = System.Drawing.Color.Silver
        Me.Line5.Name = "Line5"
        Me.Line5.StartBand = Me.ReportHeaderSection2
        Me.Line5.StartPointFloat = New DevExpress.Utils.PointFloat(700.0!, 0!)
        Me.Line5.WidthF = 1.0!
        '
        'Box1
        '
        Me.Box1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Box1.BorderColor = System.Drawing.Color.Silver
        Me.Box1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Box1.EndBand = Me.ReportFooterSection1
        Me.Box1.EndPointFloat = New DevExpress.Utils.PointFloat(9.375!, 33.68056!)
        Me.Box1.Name = "Box1"
        Me.Box1.StartBand = Me.ReportFooterSection1
        Me.Box1.StartPointFloat = New DevExpress.Utils.PointFloat(9.375!, 8.680555!)
        Me.Box1.WidthF = 273.9583!
        '
        'SharedtotalCredit
        '
        Me.SharedtotalCredit.Expression = "Iif(True, '#NOT_SUPPORTED#', 'WhilePrintingRecords;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shared numberVar creditTotal" &
    " := Sum ({creditdt.required});" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "creditTotal')"
        Me.SharedtotalCredit.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.SharedtotalCredit.Name = "SharedtotalCredit"
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
        'XtraClientAccountReport_CreditSubReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailArea1, Me.ReportHeaderArea1, Me.ReportFooterArea1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SharedtotalCredit})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetInvoices1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.Line2, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line5, Me.Box1})
        Me.DataMember = "creditdt"
        Me.DataSource = Me.DataSetInvoices1
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 100, 100)
        Me.Version = "21.2"
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents DetailArea1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents chID1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents month1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents total1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fee1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents counterdiff1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents kilowattprice1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents requiredkilo1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents discount1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents required1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paid1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents remained1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeaderArea1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportHeaderSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents ReportHeaderSection2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Text3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooterArea1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents ReportFooterSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SharedtotalCredit_1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooterSection2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Line2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line6 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line7 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line8 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line9 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line10 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line11 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line12 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line13 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line14 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line15 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Box1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents SharedtotalCredit As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DataSetInvoices1 As DataSetInvoices
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
