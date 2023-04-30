<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraGeneralMonthlyReport_EngineEfficiencyReport
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
        Me.Area3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.Line6 = New DevExpress.XtraReports.UI.XRLine()
        Me.ename1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.totalInvoices1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fuelConsuption1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.maintainace1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.kw1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.kwp1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.mf1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.dis1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rnd1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.Section1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeaderSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line8 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.Text7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area4 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Section4 = New DevExpress.XtraReports.UI.SubBand()
        Me.ReportFooterSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Line13 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line12 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line11 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line10 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line9 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line7 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.DataSetGeneralReport1 = New EEMS.DataSetGeneralReport()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DataSetGeneralReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Area3
        '
        Me.Area3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Line6, Me.ename1, Me.totalInvoices1, Me.fuelConsuption1, Me.maintainace1, Me.kw1, Me.kwp1, Me.mf1, Me.dis1, Me.rnd1})
        Me.Area3.HeightF = 27.08333!
        Me.Area3.KeepTogether = True
        Me.Area3.Name = "Area3"
        Me.Area3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.Color.Transparent
        Me.Line6.BorderColor = System.Drawing.Color.Silver
        Me.Line6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line6.BorderWidth = 1.0!
        Me.Line6.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line6.ForeColor = System.Drawing.Color.Silver
        Me.Line6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 25.0!)
        Me.Line6.Name = "Line6"
        Me.Line6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line6.SizeF = New System.Drawing.SizeF(769.0!, 2.083334!)
        Me.Line6.StylePriority.UseBorders = False
        '
        'ename1
        '
        Me.ename1.BackColor = System.Drawing.Color.Transparent
        Me.ename1.BorderColor = System.Drawing.Color.Black
        Me.ename1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ename1.BorderWidth = 1.0!
        Me.ename1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ename]")})
        Me.ename1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.ename1.ForeColor = System.Drawing.Color.Black
        Me.ename1.LocationFloat = New DevExpress.Utils.PointFloat(677.3611!, 3.472201!)
        Me.ename1.Name = "ename1"
        Me.ename1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ename1.SizeF = New System.Drawing.SizeF(82.38904!, 18.75!)
        Me.ename1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'totalInvoices1
        '
        Me.totalInvoices1.BackColor = System.Drawing.Color.Transparent
        Me.totalInvoices1.BorderColor = System.Drawing.Color.Black
        Me.totalInvoices1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.totalInvoices1.BorderWidth = 1.0!
        Me.totalInvoices1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[totalInvoices]")})
        Me.totalInvoices1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.totalInvoices1.ForeColor = System.Drawing.Color.Black
        Me.totalInvoices1.LocationFloat = New DevExpress.Utils.PointFloat(188.5417!, 3.472222!)
        Me.totalInvoices1.Name = "totalInvoices1"
        Me.totalInvoices1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalInvoices1.SizeF = New System.Drawing.SizeF(96.875!, 18.75!)
        Me.totalInvoices1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.totalInvoices1.TextFormatString = "{0:N0}"
        '
        'fuelConsuption1
        '
        Me.fuelConsuption1.BackColor = System.Drawing.Color.Transparent
        Me.fuelConsuption1.BorderColor = System.Drawing.Color.Black
        Me.fuelConsuption1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.fuelConsuption1.BorderWidth = 1.0!
        Me.fuelConsuption1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fuelConsuption]")})
        Me.fuelConsuption1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.fuelConsuption1.ForeColor = System.Drawing.Color.Black
        Me.fuelConsuption1.LocationFloat = New DevExpress.Utils.PointFloat(108.3333!, 3.472222!)
        Me.fuelConsuption1.Name = "fuelConsuption1"
        Me.fuelConsuption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fuelConsuption1.SizeF = New System.Drawing.SizeF(71.875!, 18.75!)
        Me.fuelConsuption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.fuelConsuption1.TextFormatString = "{0:N0}"
        '
        'maintainace1
        '
        Me.maintainace1.BackColor = System.Drawing.Color.Transparent
        Me.maintainace1.BorderColor = System.Drawing.Color.Black
        Me.maintainace1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.maintainace1.BorderWidth = 1.0!
        Me.maintainace1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[maintainace]")})
        Me.maintainace1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.maintainace1.ForeColor = System.Drawing.Color.Black
        Me.maintainace1.LocationFloat = New DevExpress.Utils.PointFloat(4.166667!, 3.472222!)
        Me.maintainace1.Name = "maintainace1"
        Me.maintainace1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.maintainace1.SizeF = New System.Drawing.SizeF(95.83334!, 18.75!)
        Me.maintainace1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.maintainace1.TextFormatString = "{0:N0}"
        '
        'kw1
        '
        Me.kw1.BackColor = System.Drawing.Color.Transparent
        Me.kw1.BorderColor = System.Drawing.Color.Black
        Me.kw1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.kw1.BorderWidth = 1.0!
        Me.kw1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[kw]")})
        Me.kw1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.kw1.ForeColor = System.Drawing.Color.Black
        Me.kw1.LocationFloat = New DevExpress.Utils.PointFloat(595.3889!, 3.472201!)
        Me.kw1.Name = "kw1"
        Me.kw1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.kw1.SizeF = New System.Drawing.SizeF(73.84717!, 18.75!)
        Me.kw1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.kw1.TextFormatString = "{0:N0}"
        '
        'kwp1
        '
        Me.kwp1.BackColor = System.Drawing.Color.Transparent
        Me.kwp1.BorderColor = System.Drawing.Color.Black
        Me.kwp1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.kwp1.BorderWidth = 1.0!
        Me.kwp1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[kwp]")})
        Me.kwp1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.kwp1.ForeColor = System.Drawing.Color.Black
        Me.kwp1.LocationFloat = New DevExpress.Utils.PointFloat(515.625!, 3.472265!)
        Me.kwp1.Name = "kwp1"
        Me.kwp1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.kwp1.SizeF = New System.Drawing.SizeF(64.58337!, 18.75!)
        Me.kwp1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.kwp1.TextFormatString = "{0:N0}"
        '
        'mf1
        '
        Me.mf1.BackColor = System.Drawing.Color.Transparent
        Me.mf1.BorderColor = System.Drawing.Color.Black
        Me.mf1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.mf1.BorderWidth = 1.0!
        Me.mf1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[mf]")})
        Me.mf1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.mf1.ForeColor = System.Drawing.Color.Black
        Me.mf1.LocationFloat = New DevExpress.Utils.PointFloat(435.4167!, 3.472222!)
        Me.mf1.Name = "mf1"
        Me.mf1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.mf1.SizeF = New System.Drawing.SizeF(75.0!, 18.75!)
        Me.mf1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.mf1.TextFormatString = "{0:N0}"
        '
        'dis1
        '
        Me.dis1.BackColor = System.Drawing.Color.Transparent
        Me.dis1.BorderColor = System.Drawing.Color.Black
        Me.dis1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.dis1.BorderWidth = 1.0!
        Me.dis1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[dis]")})
        Me.dis1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.dis1.ForeColor = System.Drawing.Color.Black
        Me.dis1.LocationFloat = New DevExpress.Utils.PointFloat(366.6667!, 3.472222!)
        Me.dis1.Name = "dis1"
        Me.dis1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dis1.SizeF = New System.Drawing.SizeF(64.58334!, 18.75!)
        Me.dis1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.dis1.TextFormatString = "{0:N0}"
        '
        'rnd1
        '
        Me.rnd1.BackColor = System.Drawing.Color.Transparent
        Me.rnd1.BorderColor = System.Drawing.Color.Black
        Me.rnd1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.rnd1.BorderWidth = 1.0!
        Me.rnd1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rnd]")})
        Me.rnd1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.rnd1.ForeColor = System.Drawing.Color.Black
        Me.rnd1.LocationFloat = New DevExpress.Utils.PointFloat(288.1945!, 3.472222!)
        Me.rnd1.Name = "rnd1"
        Me.rnd1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.rnd1.SizeF = New System.Drawing.SizeF(72.91666!, 18.75!)
        Me.rnd1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.rnd1.TextFormatString = "{0:N0}"
        '
        'Area1
        '
        Me.Area1.HeightF = 0!
        Me.Area1.Name = "Area1"
        Me.Area1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.Section1, Me.ReportHeaderSection1})
        Me.Area1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Section1
        '
        Me.Section1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text4})
        Me.Section1.HeightF = 38.0!
        Me.Section1.KeepTogether = True
        Me.Section1.Name = "Section1"
        Me.Section1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Section1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text4
        '
        Me.Text4.BackColor = System.Drawing.Color.Transparent
        Me.Text4.BorderColor = System.Drawing.Color.Silver
        Me.Text4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Text4.BorderWidth = 1.0!
        Me.Text4.CanGrow = False
        Me.Text4.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text4.ForeColor = System.Drawing.Color.Black
        Me.Text4.LocationFloat = New DevExpress.Utils.PointFloat(595.3889!, 2.777778!)
        Me.Text4.Name = "Text4"
        Me.Text4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text4.SizeF = New System.Drawing.SizeF(173.6111!, 20.83333!)
        Me.Text4.Text = "كشف فعاليّة المولّد"
        Me.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text13, Me.Text11, Me.Text8, Me.Text6, Me.Text5, Me.Text2, Me.Text1, Me.Text9, Me.Line8, Me.Line1, Me.Text7})
        Me.ReportHeaderSection1.HeightF = 25.0!
        Me.ReportHeaderSection1.KeepTogether = True
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text13
        '
        Me.Text13.BackColor = System.Drawing.Color.Transparent
        Me.Text13.BorderColor = System.Drawing.Color.Black
        Me.Text13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text13.BorderWidth = 1.0!
        Me.Text13.CanGrow = False
        Me.Text13.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text13.ForeColor = System.Drawing.Color.Black
        Me.Text13.LocationFloat = New DevExpress.Utils.PointFloat(283.3333!, 3.472222!)
        Me.Text13.Name = "Text13"
        Me.Text13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text13.SizeF = New System.Drawing.SizeF(75.0!, 18.75!)
        Me.Text13.Text = "تدوير ل.ل"
        Me.Text13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text11
        '
        Me.Text11.BackColor = System.Drawing.Color.Transparent
        Me.Text11.BorderColor = System.Drawing.Color.Black
        Me.Text11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text11.BorderWidth = 1.0!
        Me.Text11.CanGrow = False
        Me.Text11.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text11.ForeColor = System.Drawing.Color.Black
        Me.Text11.LocationFloat = New DevExpress.Utils.PointFloat(364.5833!, 3.472222!)
        Me.Text11.Name = "Text11"
        Me.Text11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text11.SizeF = New System.Drawing.SizeF(62.5!, 18.75!)
        Me.Text11.Text = "حسومات ل.ل"
        Me.Text11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text8
        '
        Me.Text8.BackColor = System.Drawing.Color.Transparent
        Me.Text8.BorderColor = System.Drawing.Color.Black
        Me.Text8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text8.BorderWidth = 1.0!
        Me.Text8.CanGrow = False
        Me.Text8.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text8.ForeColor = System.Drawing.Color.Black
        Me.Text8.LocationFloat = New DevExpress.Utils.PointFloat(433.3333!, 3.472222!)
        Me.Text8.Name = "Text8"
        Me.Text8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text8.SizeF = New System.Drawing.SizeF(77.08334!, 18.75!)
        Me.Text8.Text = "رسوم ل.ل"
        Me.Text8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text6.LocationFloat = New DevExpress.Utils.PointFloat(516.6667!, 3.472265!)
        Me.Text6.Name = "Text6"
        Me.Text6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text6.SizeF = New System.Drawing.SizeF(63.54163!, 18.75!)
        Me.Text6.Text = "كيلوات ل.ل"
        Me.Text6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(595.3889!, 3.472233!)
        Me.Text5.Name = "Text5"
        Me.Text5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text5.SizeF = New System.Drawing.SizeF(73.84717!, 18.75!)
        Me.Text5.Text = "كيلوات KW"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text2.LocationFloat = New DevExpress.Utils.PointFloat(4.166667!, 3.472222!)
        Me.Text2.Name = "Text2"
        Me.Text2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text2.SizeF = New System.Drawing.SizeF(95.83334!, 18.75!)
        Me.Text2.Text = "صيانة ل.ل"
        Me.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(677.3611!, 3.472265!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(84.47235!, 18.75!)
        Me.Text1.Text = "المولّد"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text9
        '
        Me.Text9.BackColor = System.Drawing.Color.Transparent
        Me.Text9.BorderColor = System.Drawing.Color.Black
        Me.Text9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text9.BorderWidth = 1.0!
        Me.Text9.CanGrow = False
        Me.Text9.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text9.ForeColor = System.Drawing.Color.Black
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(108.3333!, 3.472222!)
        Me.Text9.Name = "Text9"
        Me.Text9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text9.SizeF = New System.Drawing.SizeF(71.875!, 18.75!)
        Me.Text9.Text = "وقود لتر"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line8
        '
        Me.Line8.BackColor = System.Drawing.Color.Transparent
        Me.Line8.BorderColor = System.Drawing.Color.Silver
        Me.Line8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line8.BorderWidth = 1.0!
        Me.Line8.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line8.ForeColor = System.Drawing.Color.Silver
        Me.Line8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Line8.Name = "Line8"
        Me.Line8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line8.SizeF = New System.Drawing.SizeF(769.0!, 2.083333!)
        Me.Line8.StylePriority.UseBorders = False
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Transparent
        Me.Line1.BorderColor = System.Drawing.Color.Silver
        Me.Line1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line1.BorderWidth = 1.0!
        Me.Line1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line1.ForeColor = System.Drawing.Color.Silver
        Me.Line1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.91667!)
        Me.Line1.Name = "Line1"
        Me.Line1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line1.SizeF = New System.Drawing.SizeF(769.0!, 2.083334!)
        Me.Line1.StylePriority.UseBorders = False
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
        Me.Text7.LocationFloat = New DevExpress.Utils.PointFloat(187.5!, 3.472222!)
        Me.Text7.Name = "Text7"
        Me.Text7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text7.SizeF = New System.Drawing.SizeF(95.83334!, 18.75!)
        Me.Text7.Text = "مجموع فواتير ل.ل"
        Me.Text7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Area4
        '
        Me.Area4.HeightF = 0!
        Me.Area4.Name = "Area4"
        Me.Area4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area4.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.Section4, Me.ReportFooterSection1})
        Me.Area4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Section4
        '
        Me.Section4.HeightF = 0!
        Me.Section4.KeepTogether = True
        Me.Section4.Name = "Section4"
        Me.Section4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Section4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.HeightF = 0!
        Me.ReportFooterSection1.KeepTogether = True
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        Me.ReportFooterSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Line13
        '
        Me.Line13.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line13.EndBand = Me.Area3
        Me.Line13.EndPointFloat = New DevExpress.Utils.PointFloat(584.2084!, 27.01389!)
        Me.Line13.ForeColor = System.Drawing.Color.Silver
        Me.Line13.Name = "Line13"
        Me.Line13.StartBand = Me.ReportHeaderSection1
        Me.Line13.StartPointFloat = New DevExpress.Utils.PointFloat(584.2084!, 0!)
        Me.Line13.WidthF = 1.0!
        '
        'Line12
        '
        Me.Line12.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line12.EndBand = Me.Area3
        Me.Line12.EndPointFloat = New DevExpress.Utils.PointFloat(508.3333!, 27.01389!)
        Me.Line12.ForeColor = System.Drawing.Color.Silver
        Me.Line12.Name = "Line12"
        Me.Line12.StartBand = Me.ReportHeaderSection1
        Me.Line12.StartPointFloat = New DevExpress.Utils.PointFloat(508.3333!, 0!)
        Me.Line12.WidthF = 1.0!
        '
        'Line11
        '
        Me.Line11.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line11.EndBand = Me.Area3
        Me.Line11.EndPointFloat = New DevExpress.Utils.PointFloat(429.1667!, 27.01389!)
        Me.Line11.ForeColor = System.Drawing.Color.Silver
        Me.Line11.Name = "Line11"
        Me.Line11.StartBand = Me.ReportHeaderSection1
        Me.Line11.StartPointFloat = New DevExpress.Utils.PointFloat(429.1667!, 0!)
        Me.Line11.WidthF = 1.0!
        '
        'Line10
        '
        Me.Line10.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line10.EndBand = Me.Area3
        Me.Line10.EndPointFloat = New DevExpress.Utils.PointFloat(361.1111!, 27.01389!)
        Me.Line10.ForeColor = System.Drawing.Color.Silver
        Me.Line10.Name = "Line10"
        Me.Line10.StartBand = Me.ReportHeaderSection1
        Me.Line10.StartPointFloat = New DevExpress.Utils.PointFloat(361.1111!, 0!)
        Me.Line10.WidthF = 1.0!
        '
        'Line9
        '
        Me.Line9.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line9.EndBand = Me.Area3
        Me.Line9.EndPointFloat = New DevExpress.Utils.PointFloat(283.3333!, 27.01389!)
        Me.Line9.ForeColor = System.Drawing.Color.Silver
        Me.Line9.Name = "Line9"
        Me.Line9.StartBand = Me.ReportHeaderSection1
        Me.Line9.StartPointFloat = New DevExpress.Utils.PointFloat(283.3333!, 0!)
        Me.Line9.WidthF = 1.0!
        '
        'Line7
        '
        Me.Line7.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line7.EndBand = Me.Area3
        Me.Line7.EndPointFloat = New DevExpress.Utils.PointFloat(102.7778!, 27.01389!)
        Me.Line7.ForeColor = System.Drawing.Color.Silver
        Me.Line7.Name = "Line7"
        Me.Line7.StartBand = Me.ReportHeaderSection1
        Me.Line7.StartPointFloat = New DevExpress.Utils.PointFloat(102.7778!, 0!)
        Me.Line7.WidthF = 1.0!
        '
        'Line4
        '
        Me.Line4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line4.EndBand = Me.Area3
        Me.Line4.EndPointFloat = New DevExpress.Utils.PointFloat(0.6944444!, 27.08333!)
        Me.Line4.ForeColor = System.Drawing.Color.Silver
        Me.Line4.Name = "Line4"
        Me.Line4.StartBand = Me.ReportHeaderSection1
        Me.Line4.StartPointFloat = New DevExpress.Utils.PointFloat(0.6944444!, 0!)
        Me.Line4.WidthF = 1.0!
        '
        'Line3
        '
        Me.Line3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line3.EndBand = Me.Area3
        Me.Line3.EndPointFloat = New DevExpress.Utils.PointFloat(768.0!, 27.08!)
        Me.Line3.ForeColor = System.Drawing.Color.Silver
        Me.Line3.Name = "Line3"
        Me.Line3.StartBand = Me.ReportHeaderSection1
        Me.Line3.StartPointFloat = New DevExpress.Utils.PointFloat(768.0!, 0!)
        Me.Line3.WidthF = 1.0!
        '
        'Line2
        '
        Me.Line2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line2.EndBand = Me.Area3
        Me.Line2.EndPointFloat = New DevExpress.Utils.PointFloat(673.2361!, 27.01389!)
        Me.Line2.ForeColor = System.Drawing.Color.Silver
        Me.Line2.Name = "Line2"
        Me.Line2.StartBand = Me.ReportHeaderSection1
        Me.Line2.StartPointFloat = New DevExpress.Utils.PointFloat(673.2361!, 0!)
        Me.Line2.WidthF = 1.0!
        '
        'Line5
        '
        Me.Line5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line5.EndBand = Me.Area3
        Me.Line5.EndPointFloat = New DevExpress.Utils.PointFloat(183.3333!, 27.01389!)
        Me.Line5.ForeColor = System.Drawing.Color.Silver
        Me.Line5.Name = "Line5"
        Me.Line5.StartBand = Me.ReportHeaderSection1
        Me.Line5.StartPointFloat = New DevExpress.Utils.PointFloat(183.3333!, 0!)
        Me.Line5.WidthF = 1.0!
        '
        'DataSetGeneralReport1
        '
        Me.DataSetGeneralReport1.DataSetName = "DataSetGeneralReport"
        Me.DataSetGeneralReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XtraGeneralMonthlyReport_EngineEfficiencyReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Area3, Me.Area1, Me.Area4, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetGeneralReport1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.Line13, Me.Line12, Me.Line11, Me.Line10, Me.Line9, Me.Line7, Me.Line4, Me.Line3, Me.Line2, Me.Line5})
        Me.DataMember = "dtEngineEfficiency"
        Me.DataSource = Me.DataSetGeneralReport1
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 0, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "21.2"
        CType(Me.DataSetGeneralReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Area3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Line6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ename1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalInvoices1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fuelConsuption1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents maintainace1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents kw1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents kwp1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents mf1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dis1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents rnd1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Section1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeaderSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Text7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area4 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Section4 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents ReportFooterSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Line13 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line12 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line11 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line10 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line9 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line7 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents DataSetGeneralReport1 As DataSetGeneralReport
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
