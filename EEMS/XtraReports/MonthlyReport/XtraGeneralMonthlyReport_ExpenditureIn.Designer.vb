<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraGeneralMonthlyReport_ExpenditureIn
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
        Me.title1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.total1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line6 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportHeaderArea1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.ReportHeaderSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeaderSection2 = New DevExpress.XtraReports.UI.SubBand()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line8 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooterArea1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.ReportFooterSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.ReportFooterSection2 = New DevExpress.XtraReports.UI.SubBand()
        Me.Line5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line9 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line10 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.DataSetGeneralReport1 = New EEMS.DataSetGeneralReport()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DataSetGeneralReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DetailArea1
        '
        Me.DetailArea1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.title1, Me.total1, Me.Text4, Me.Line6})
        Me.DetailArea1.HeightF = 28.0!
        Me.DetailArea1.KeepTogether = True
        Me.DetailArea1.Name = "DetailArea1"
        Me.DetailArea1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.DetailArea1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'title1
        '
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.BorderColor = System.Drawing.Color.Black
        Me.title1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.title1.BorderWidth = 1.0!
        Me.title1.CanGrow = False
        Me.title1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[title]")})
        Me.title1.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!)
        Me.title1.ForeColor = System.Drawing.Color.Black
        Me.title1.LocationFloat = New DevExpress.Utils.PointFloat(459.375!, 4.166667!)
        Me.title1.Name = "title1"
        Me.title1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.title1.SizeF = New System.Drawing.SizeF(303.0417!, 18.75!)
        Me.title1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'total1
        '
        Me.total1.BackColor = System.Drawing.Color.Transparent
        Me.total1.BorderColor = System.Drawing.Color.Black
        Me.total1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.total1.BorderWidth = 1.0!
        Me.total1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total]")})
        Me.total1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.total1.ForeColor = System.Drawing.Color.Black
        Me.total1.LocationFloat = New DevExpress.Utils.PointFloat(41.66667!, 4.166667!)
        Me.total1.Name = "total1"
        Me.total1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.total1.SizeF = New System.Drawing.SizeF(392.7083!, 18.75!)
        Me.total1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.total1.TextFormatString = "{0:N0}"
        '
        'Text4
        '
        Me.Text4.BackColor = System.Drawing.Color.Transparent
        Me.Text4.BorderColor = System.Drawing.Color.Black
        Me.Text4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text4.BorderWidth = 1.0!
        Me.Text4.CanGrow = False
        Me.Text4.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Text4.ForeColor = System.Drawing.Color.Black
        Me.Text4.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 4.166667!)
        Me.Text4.Name = "Text4"
        Me.Text4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text4.SizeF = New System.Drawing.SizeF(25.0!, 18.75!)
        Me.Text4.Text = "ل.ل"
        Me.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.Color.Transparent
        Me.Line6.BorderColor = System.Drawing.Color.Silver
        Me.Line6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line6.BorderWidth = 1.0!
        Me.Line6.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line6.ForeColor = System.Drawing.Color.Silver
        Me.Line6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 25.90667!)
        Me.Line6.Name = "Line6"
        Me.Line6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line6.SizeF = New System.Drawing.SizeF(769.0!, 2.083334!)
        Me.Line6.StylePriority.UseBorders = False
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
        Me.ReportHeaderSection1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text3})
        Me.ReportHeaderSection1.HeightF = 38.0!
        Me.ReportHeaderSection1.KeepTogether = True
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.Transparent
        Me.Text3.BorderColor = System.Drawing.Color.Silver
        Me.Text3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Text3.BorderWidth = 1.0!
        Me.Text3.CanGrow = False
        Me.Text3.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text3.ForeColor = System.Drawing.Color.Black
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(637.4028!, 2.777778!)
        Me.Text3.Name = "Text3"
        Me.Text3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text3.SizeF = New System.Drawing.SizeF(131.5972!, 20.83333!)
        Me.Text3.Text = "تفصيل الدخل بالليرة"
        Me.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportHeaderSection2
        '
        Me.ReportHeaderSection2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text1, Me.Text2, Me.Line1, Me.Line8})
        Me.ReportHeaderSection2.HeightF = 25.0!
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
        Me.Text1.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(459.375!, 3.472265!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(303.0417!, 18.75!)
        Me.Text1.Text = "العنوان"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Text2
        '
        Me.Text2.BackColor = System.Drawing.Color.Transparent
        Me.Text2.BorderColor = System.Drawing.Color.Black
        Me.Text2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text2.BorderWidth = 1.0!
        Me.Text2.CanGrow = False
        Me.Text2.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text2.ForeColor = System.Drawing.Color.Black
        Me.Text2.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 3.472217!)
        Me.Text2.Name = "Text2"
        Me.Text2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text2.SizeF = New System.Drawing.SizeF(426.0417!, 18.75!)
        Me.Text2.Text = "القيمة"
        Me.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        Me.ReportFooterSection1.HeightF = 0!
        Me.ReportFooterSection1.KeepTogether = True
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        Me.ReportFooterSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooterSection2
        '
        Me.ReportFooterSection2.HeightF = 0!
        Me.ReportFooterSection2.KeepTogether = True
        Me.ReportFooterSection2.Name = "ReportFooterSection2"
        Me.ReportFooterSection2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Line5
        '
        Me.Line5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line5.EndBand = Me.DetailArea1
        Me.Line5.EndPointFloat = New DevExpress.Utils.PointFloat(442.0!, 28.97223!)
        Me.Line5.ForeColor = System.Drawing.Color.Silver
        Me.Line5.Name = "Line5"
        Me.Line5.StartBand = Me.ReportHeaderSection2
        Me.Line5.StartPointFloat = New DevExpress.Utils.PointFloat(442.0!, 0!)
        Me.Line5.WidthF = 1.0!
        '
        'Line9
        '
        Me.Line9.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line9.EndBand = Me.DetailArea1
        Me.Line9.EndPointFloat = New DevExpress.Utils.PointFloat(768.0!, 27.99!)
        Me.Line9.ForeColor = System.Drawing.Color.Silver
        Me.Line9.Name = "Line9"
        Me.Line9.StartBand = Me.ReportHeaderSection2
        Me.Line9.StartPointFloat = New DevExpress.Utils.PointFloat(768.0!, 0!)
        Me.Line9.WidthF = 1.0!
        '
        'Line10
        '
        Me.Line10.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line10.EndBand = Me.DetailArea1
        Me.Line10.EndPointFloat = New DevExpress.Utils.PointFloat(0.6944444!, 28.90278!)
        Me.Line10.ForeColor = System.Drawing.Color.Silver
        Me.Line10.Name = "Line10"
        Me.Line10.StartBand = Me.ReportHeaderSection2
        Me.Line10.StartPointFloat = New DevExpress.Utils.PointFloat(0.6944444!, 0!)
        Me.Line10.WidthF = 1.0!
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
        'XtraGeneralMonthlyReport_ExpenditureIn
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailArea1, Me.ReportHeaderArea1, Me.ReportFooterArea1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetGeneralReport1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.Line5, Me.Line9, Me.Line10})
        Me.DataMember = "dtExpenditurePos"
        Me.DataSource = Me.DataSetGeneralReport1
        Me.Margins = New DevExpress.Drawing.DXMargins(0!, 0!, 100.0!, 100.0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "22.2"
        CType(Me.DataSetGeneralReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents DetailArea1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents title1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents total1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportHeaderArea1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportHeaderSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeaderSection2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportFooterArea1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents ReportFooterSection1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents ReportFooterSection2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents Line5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line9 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line10 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents DataSetGeneralReport1 As DataSetGeneralReport
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
