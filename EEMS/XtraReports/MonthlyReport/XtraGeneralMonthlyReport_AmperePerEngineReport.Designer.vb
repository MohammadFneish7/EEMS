<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraGeneralMonthlyReport_AmperePerEngineReport
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
        Me.title1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.count1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.Section1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeaderSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line8 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.Text7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area4 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Section4 = New DevExpress.XtraReports.UI.SubBand()
        Me.ReportFooterSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Line4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.DataSetGeneralReport1 = New EEMS.DataSetGeneralReport()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DataSetGeneralReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Area3
        '
        Me.Area3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Line6, Me.ename1, Me.title1, Me.count1, Me.Text10})
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
        Me.Line6.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line6.ForeColor = System.Drawing.Color.Silver
        Me.Line6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 25.0!)
        Me.Line6.Name = "Line6"
        Me.Line6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line6.SizeF = New System.Drawing.SizeF(768.9999!, 2.083334!)
        Me.Line6.StylePriority.UseBorders = False
        '
        'ename1
        '
        Me.ename1.BackColor = System.Drawing.Color.Transparent
        Me.ename1.BorderColor = System.Drawing.Color.Black
        Me.ename1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ename1.BorderWidth = 1.0!
        Me.ename1.CanGrow = False
        Me.ename1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ename]")})
        Me.ename1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ename1.ForeColor = System.Drawing.Color.Black
        Me.ename1.LocationFloat = New DevExpress.Utils.PointFloat(516.6667!, 3.472265!)
        Me.ename1.Name = "ename1"
        Me.ename1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ename1.SizeF = New System.Drawing.SizeF(246.7917!, 18.75!)
        Me.ename1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'title1
        '
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.BorderColor = System.Drawing.Color.Black
        Me.title1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.title1.BorderWidth = 1.0!
        Me.title1.CanGrow = False
        Me.title1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[title]")})
        Me.title1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.title1.ForeColor = System.Drawing.Color.Black
        Me.title1.LocationFloat = New DevExpress.Utils.PointFloat(291.6667!, 3.472222!)
        Me.title1.Name = "title1"
        Me.title1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.title1.SizeF = New System.Drawing.SizeF(208.3333!, 18.75!)
        Me.title1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'count1
        '
        Me.count1.BackColor = System.Drawing.Color.Transparent
        Me.count1.BorderColor = System.Drawing.Color.Black
        Me.count1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.count1.BorderWidth = 1.0!
        Me.count1.CanGrow = False
        Me.count1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[count]")})
        Me.count1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.count1.ForeColor = System.Drawing.Color.Black
        Me.count1.LocationFloat = New DevExpress.Utils.PointFloat(41.66667!, 3.472222!)
        Me.count1.Name = "count1"
        Me.count1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.count1.SizeF = New System.Drawing.SizeF(233.3333!, 18.75!)
        Me.count1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text10
        '
        Me.Text10.BackColor = System.Drawing.Color.Transparent
        Me.Text10.BorderColor = System.Drawing.Color.Black
        Me.Text10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text10.BorderWidth = 1.0!
        Me.Text10.CanGrow = False
        Me.Text10.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Text10.ForeColor = System.Drawing.Color.Black
        Me.Text10.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 3.472222!)
        Me.Text10.Name = "Text10"
        Me.Text10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text10.SizeF = New System.Drawing.SizeF(25.0!, 18.75!)
        Me.Text10.StylePriority.UseTextAlignment = False
        Me.Text10.Text = "AU"
        Me.Text10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.Text4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Text4.ForeColor = System.Drawing.Color.Black
        Me.Text4.LocationFloat = New DevExpress.Utils.PointFloat(580.8056!, 2.777778!)
        Me.Text4.Name = "Text4"
        Me.Text4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text4.SizeF = New System.Drawing.SizeF(188.1944!, 20.83333!)
        Me.Text4.Text = "أنواع الإشتراكات حسب المولّد"
        Me.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text1, Me.Text9, Me.Line8, Me.Line1, Me.Text7})
        Me.ReportHeaderSection1.HeightF = 25.0!
        Me.ReportHeaderSection1.KeepTogether = True
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.Transparent
        Me.Text1.BorderColor = System.Drawing.Color.Black
        Me.Text1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text1.BorderWidth = 1.0!
        Me.Text1.CanGrow = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(516.6667!, 3.472265!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(246.7917!, 18.75!)
        Me.Text1.Text = "المولّد"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Text9
        '
        Me.Text9.BackColor = System.Drawing.Color.Transparent
        Me.Text9.BorderColor = System.Drawing.Color.Black
        Me.Text9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text9.BorderWidth = 1.0!
        Me.Text9.CanGrow = False
        Me.Text9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Text9.ForeColor = System.Drawing.Color.Black
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 3.472222!)
        Me.Text9.Name = "Text9"
        Me.Text9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text9.SizeF = New System.Drawing.SizeF(266.6667!, 18.75!)
        Me.Text9.Text = "عدد الإشتراكات"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Line8
        '
        Me.Line8.BackColor = System.Drawing.Color.Transparent
        Me.Line8.BorderColor = System.Drawing.Color.Silver
        Me.Line8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line8.BorderWidth = 1.0!
        Me.Line8.Font = New System.Drawing.Font("Times New Roman", 9.75!)
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
        Me.Line1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
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
        Me.Text7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Text7.ForeColor = System.Drawing.Color.Black
        Me.Text7.LocationFloat = New DevExpress.Utils.PointFloat(291.6667!, 3.472222!)
        Me.Text7.Name = "Text7"
        Me.Text7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text7.SizeF = New System.Drawing.SizeF(208.3333!, 18.75!)
        Me.Text7.Text = "نوع الإشتراك"
        Me.Text7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        'Line2
        '
        Me.Line2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line2.EndBand = Me.Area3
        Me.Line2.EndPointFloat = New DevExpress.Utils.PointFloat(508.3333!, 27.08333!)
        Me.Line2.ForeColor = System.Drawing.Color.Silver
        Me.Line2.Name = "Line2"
        Me.Line2.StartBand = Me.ReportHeaderSection1
        Me.Line2.StartPointFloat = New DevExpress.Utils.PointFloat(508.3333!, 0!)
        Me.Line2.WidthF = 1.0!
        '
        'Line5
        '
        Me.Line5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line5.EndBand = Me.Area3
        Me.Line5.EndPointFloat = New DevExpress.Utils.PointFloat(283.3333!, 27.08333!)
        Me.Line5.ForeColor = System.Drawing.Color.Silver
        Me.Line5.Name = "Line5"
        Me.Line5.StartBand = Me.ReportHeaderSection1
        Me.Line5.StartPointFloat = New DevExpress.Utils.PointFloat(283.3333!, 0!)
        Me.Line5.WidthF = 1.0!
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine1.EndBand = Me.Area3
        Me.XrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(768.0!, 25.08!)
        Me.XrCrossBandLine1.ForeColor = System.Drawing.Color.Silver
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Me.ReportHeaderSection1
        Me.XrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(768.0!, 0!)
        Me.XrCrossBandLine1.WidthF = 1.0!
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
        'XtraGeneralMonthlyReport_AmperePerEngineReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Area3, Me.Area1, Me.Area4, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetGeneralReport1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine1, Me.Line4, Me.Line2, Me.Line5})
        Me.DataMember = "dtAmperePerEngine"
        Me.DataSource = Me.DataSetGeneralReport1
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 100, 100)
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
    Friend WithEvents title1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents count1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Section1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeaderSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Text7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area4 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Section4 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents ReportFooterSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Line4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents DataSetGeneralReport1 As DataSetGeneralReport
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
