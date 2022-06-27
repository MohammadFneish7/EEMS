<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraEmptyCouterHistoryReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraEmptyCouterHistoryReport))
        Me.Area3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.motor1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.cname1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.boxcode1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.boxlocation1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ampere1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.countercode1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lastvalue1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.newvalue1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line3 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line4 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line5 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line6 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line7 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line8 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line9 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line10 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line11 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line38 = New DevExpress.XtraReports.UI.XRLine()
        Me.Area1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PrintDate1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Text22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Text23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.collector1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area2 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line12 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line13 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line14 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line15 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line16 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line19 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line20 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line21 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line25 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line26 = New DevExpress.XtraReports.UI.XRLine()
        Me.Area4 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Area5 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.PageNumber1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSetInvoices1 = New EEMS.DataSetInvoices()
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Area3
        '
        Me.Area3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.motor1, Me.cname1, Me.boxcode1, Me.boxlocation1, Me.ampere1, Me.countercode1, Me.lastvalue1, Me.newvalue1, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line38})
        Me.Area3.HeightF = 19.79167!
        Me.Area3.KeepTogether = True
        Me.Area3.Name = "Area3"
        Me.Area3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'motor1
        '
        Me.motor1.BackColor = System.Drawing.Color.Transparent
        Me.motor1.BorderColor = System.Drawing.Color.Black
        Me.motor1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.motor1.BorderWidth = 1.0!
        Me.motor1.CanGrow = False
        Me.motor1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[motor]")})
        Me.motor1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.motor1.ForeColor = System.Drawing.Color.Black
        Me.motor1.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 3.472201!)
        Me.motor1.Name = "motor1"
        Me.motor1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.motor1.SizeF = New System.Drawing.SizeF(110.875!, 15.34722!)
        Me.motor1.StylePriority.UseBorders = False
        Me.motor1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'cname1
        '
        Me.cname1.BackColor = System.Drawing.Color.Transparent
        Me.cname1.BorderColor = System.Drawing.Color.Black
        Me.cname1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.cname1.BorderWidth = 1.0!
        Me.cname1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cname]")})
        Me.cname1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cname1.ForeColor = System.Drawing.Color.Black
        Me.cname1.LocationFloat = New DevExpress.Utils.PointFloat(516.6667!, 3.472222!)
        Me.cname1.Name = "cname1"
        Me.cname1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cname1.SizeF = New System.Drawing.SizeF(166.6667!, 15.34722!)
        Me.cname1.StylePriority.UseBorders = False
        Me.cname1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'boxcode1
        '
        Me.boxcode1.BackColor = System.Drawing.Color.Transparent
        Me.boxcode1.BorderColor = System.Drawing.Color.Black
        Me.boxcode1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.boxcode1.BorderWidth = 1.0!
        Me.boxcode1.CanGrow = False
        Me.boxcode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[boxcode]")})
        Me.boxcode1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.boxcode1.ForeColor = System.Drawing.Color.Black
        Me.boxcode1.LocationFloat = New DevExpress.Utils.PointFloat(452.0833!, 3.472233!)
        Me.boxcode1.Name = "boxcode1"
        Me.boxcode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.boxcode1.SizeF = New System.Drawing.SizeF(62.58664!, 15.34722!)
        Me.boxcode1.StylePriority.UseBorders = False
        Me.boxcode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'boxlocation1
        '
        Me.boxlocation1.BackColor = System.Drawing.Color.Transparent
        Me.boxlocation1.BorderColor = System.Drawing.Color.Black
        Me.boxlocation1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.boxlocation1.BorderWidth = 1.0!
        Me.boxlocation1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[boxlocation]")})
        Me.boxlocation1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.boxlocation1.ForeColor = System.Drawing.Color.Black
        Me.boxlocation1.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 3.472222!)
        Me.boxlocation1.Name = "boxlocation1"
        Me.boxlocation1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.boxlocation1.SizeF = New System.Drawing.SizeF(142.7083!, 15.34722!)
        Me.boxlocation1.StylePriority.UseBorders = False
        Me.boxlocation1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ampere1
        '
        Me.ampere1.BackColor = System.Drawing.Color.Transparent
        Me.ampere1.BorderColor = System.Drawing.Color.Black
        Me.ampere1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ampere1.BorderWidth = 1.0!
        Me.ampere1.CanGrow = False
        Me.ampere1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ampere]")})
        Me.ampere1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ampere1.ForeColor = System.Drawing.Color.Black
        Me.ampere1.LocationFloat = New DevExpress.Utils.PointFloat(233.3333!, 3.472222!)
        Me.ampere1.Name = "ampere1"
        Me.ampere1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ampere1.SizeF = New System.Drawing.SizeF(55.20833!, 15.34722!)
        Me.ampere1.StylePriority.UseBorders = False
        Me.ampere1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'countercode1
        '
        Me.countercode1.BackColor = System.Drawing.Color.Transparent
        Me.countercode1.BorderColor = System.Drawing.Color.Black
        Me.countercode1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.countercode1.BorderWidth = 1.0!
        Me.countercode1.CanGrow = False
        Me.countercode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[countercode]")})
        Me.countercode1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.countercode1.ForeColor = System.Drawing.Color.Black
        Me.countercode1.LocationFloat = New DevExpress.Utils.PointFloat(166.6667!, 3.472222!)
        Me.countercode1.Name = "countercode1"
        Me.countercode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.countercode1.SizeF = New System.Drawing.SizeF(55.20833!, 15.34722!)
        Me.countercode1.StylePriority.UseBorders = False
        Me.countercode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lastvalue1
        '
        Me.lastvalue1.BackColor = System.Drawing.Color.Transparent
        Me.lastvalue1.BorderColor = System.Drawing.Color.Black
        Me.lastvalue1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lastvalue1.BorderWidth = 1.0!
        Me.lastvalue1.CanGrow = False
        Me.lastvalue1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[lastvalue]")})
        Me.lastvalue1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lastvalue1.ForeColor = System.Drawing.Color.Black
        Me.lastvalue1.LocationFloat = New DevExpress.Utils.PointFloat(83.33334!, 3.472222!)
        Me.lastvalue1.Name = "lastvalue1"
        Me.lastvalue1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lastvalue1.SizeF = New System.Drawing.SizeF(71.875!, 15.34722!)
        Me.lastvalue1.StylePriority.UseBorders = False
        Me.lastvalue1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'newvalue1
        '
        Me.newvalue1.BackColor = System.Drawing.Color.Transparent
        Me.newvalue1.BorderColor = System.Drawing.Color.Black
        Me.newvalue1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.newvalue1.BorderWidth = 1.0!
        Me.newvalue1.CanGrow = False
        Me.newvalue1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[newvalue]")})
        Me.newvalue1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.newvalue1.ForeColor = System.Drawing.Color.Black
        Me.newvalue1.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 3.472233!)
        Me.newvalue1.Name = "newvalue1"
        Me.newvalue1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.newvalue1.SizeF = New System.Drawing.SizeF(58.33334!, 15.34722!)
        Me.newvalue1.StylePriority.UseBorders = False
        Me.newvalue1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.BorderColor = System.Drawing.Color.Silver
        Me.Line3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line3.BorderWidth = 1.0!
        Me.Line3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line3.ForeColor = System.Drawing.Color.Silver
        Me.Line3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line3.LocationFloat = New DevExpress.Utils.PointFloat(79.17!, 0!)
        Me.Line3.Name = "Line3"
        Me.Line3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line3.SizeF = New System.Drawing.SizeF(2.083336!, 19.79167!)
        Me.Line3.StylePriority.UseBorders = False
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Transparent
        Me.Line4.BorderColor = System.Drawing.Color.Silver
        Me.Line4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line4.BorderWidth = 1.0!
        Me.Line4.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line4.ForeColor = System.Drawing.Color.Silver
        Me.Line4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line4.LocationFloat = New DevExpress.Utils.PointFloat(161.46!, 0!)
        Me.Line4.Name = "Line4"
        Me.Line4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line4.SizeF = New System.Drawing.SizeF(2.083344!, 19.79167!)
        Me.Line4.StylePriority.UseBorders = False
        '
        'Line5
        '
        Me.Line5.BackColor = System.Drawing.Color.Transparent
        Me.Line5.BorderColor = System.Drawing.Color.Silver
        Me.Line5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line5.BorderWidth = 1.0!
        Me.Line5.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line5.ForeColor = System.Drawing.Color.Silver
        Me.Line5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line5.LocationFloat = New DevExpress.Utils.PointFloat(225.0!, 0!)
        Me.Line5.Name = "Line5"
        Me.Line5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line5.SizeF = New System.Drawing.SizeF(2.083328!, 19.79167!)
        Me.Line5.StylePriority.UseBorders = False
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.Color.Transparent
        Me.Line6.BorderColor = System.Drawing.Color.Silver
        Me.Line6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line6.BorderWidth = 1.0!
        Me.Line6.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line6.ForeColor = System.Drawing.Color.Silver
        Me.Line6.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line6.LocationFloat = New DevExpress.Utils.PointFloat(291.67!, 0!)
        Me.Line6.Name = "Line6"
        Me.Line6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line6.SizeF = New System.Drawing.SizeF(2.083344!, 19.79167!)
        Me.Line6.StylePriority.UseBorders = False
        '
        'Line7
        '
        Me.Line7.BackColor = System.Drawing.Color.Transparent
        Me.Line7.BorderColor = System.Drawing.Color.Silver
        Me.Line7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line7.BorderWidth = 1.0!
        Me.Line7.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line7.ForeColor = System.Drawing.Color.Silver
        Me.Line7.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line7.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0!)
        Me.Line7.Name = "Line7"
        Me.Line7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line7.SizeF = New System.Drawing.SizeF(2.083344!, 19.79167!)
        Me.Line7.StylePriority.UseBorders = False
        '
        'Line8
        '
        Me.Line8.BackColor = System.Drawing.Color.Transparent
        Me.Line8.BorderColor = System.Drawing.Color.Silver
        Me.Line8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line8.BorderWidth = 1.0!
        Me.Line8.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line8.ForeColor = System.Drawing.Color.Silver
        Me.Line8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line8.LocationFloat = New DevExpress.Utils.PointFloat(514.67!, 0!)
        Me.Line8.Name = "Line8"
        Me.Line8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line8.SizeF = New System.Drawing.SizeF(2.083313!, 19.79167!)
        Me.Line8.StylePriority.UseBorders = False
        '
        'Line9
        '
        Me.Line9.BackColor = System.Drawing.Color.Transparent
        Me.Line9.BorderColor = System.Drawing.Color.Silver
        Me.Line9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line9.BorderWidth = 1.0!
        Me.Line9.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line9.ForeColor = System.Drawing.Color.Silver
        Me.Line9.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line9.LocationFloat = New DevExpress.Utils.PointFloat(691.67!, 0!)
        Me.Line9.Name = "Line9"
        Me.Line9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line9.SizeF = New System.Drawing.SizeF(2.083313!, 19.79167!)
        Me.Line9.StylePriority.UseBorders = False
        '
        'Line10
        '
        Me.Line10.BackColor = System.Drawing.Color.Transparent
        Me.Line10.BorderColor = System.Drawing.Color.Silver
        Me.Line10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line10.BorderWidth = 1.0!
        Me.Line10.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line10.ForeColor = System.Drawing.Color.Silver
        Me.Line10.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line10.LocationFloat = New DevExpress.Utils.PointFloat(813.9999!, 0!)
        Me.Line10.Name = "Line10"
        Me.Line10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line10.SizeF = New System.Drawing.SizeF(2.083313!, 18.81943!)
        Me.Line10.StylePriority.UseBorders = False
        '
        'Line11
        '
        Me.Line11.BackColor = System.Drawing.Color.Transparent
        Me.Line11.BorderColor = System.Drawing.Color.Silver
        Me.Line11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line11.BorderWidth = 1.0!
        Me.Line11.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line11.ForeColor = System.Drawing.Color.Silver
        Me.Line11.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line11.LocationFloat = New DevExpress.Utils.PointFloat(8.33!, 0!)
        Me.Line11.Name = "Line11"
        Me.Line11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line11.SizeF = New System.Drawing.SizeF(2.083334!, 19.79167!)
        Me.Line11.StylePriority.UseBorders = False
        '
        'Line38
        '
        Me.Line38.BackColor = System.Drawing.Color.Transparent
        Me.Line38.BorderColor = System.Drawing.Color.Silver
        Me.Line38.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line38.BorderWidth = 1.0!
        Me.Line38.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line38.ForeColor = System.Drawing.Color.Silver
        Me.Line38.LocationFloat = New DevExpress.Utils.PointFloat(9.375!, 0!)
        Me.Line38.Name = "Line38"
        Me.Line38.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line38.SizeF = New System.Drawing.SizeF(804.625!, 2.083333!)
        Me.Line38.StylePriority.UseBorders = False
        '
        'Area1
        '
        Me.Area1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.PrintDate1, Me.Text22, Me.Text1, Me.Picture1, Me.Text23, Me.Text2, Me.collector1})
        Me.Area1.HeightF = 135.0!
        Me.Area1.KeepTogether = True
        Me.Area1.Name = "Area1"
        Me.Area1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrgInfodt].[OrgName]")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(591.6667!, 48.68056!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(138.5417!, 15.41668!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'PrintDate1
        '
        Me.PrintDate1.BackColor = System.Drawing.Color.Transparent
        Me.PrintDate1.BorderColor = System.Drawing.Color.Black
        Me.PrintDate1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PrintDate1.BorderWidth = 1.0!
        Me.PrintDate1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.PrintDate1.ForeColor = System.Drawing.Color.Black
        Me.PrintDate1.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 41.66667!)
        Me.PrintDate1.Name = "PrintDate1"
        Me.PrintDate1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PrintDate1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.PrintDate1.SizeF = New System.Drawing.SizeF(91.66666!, 15.34722!)
        Me.PrintDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.PrintDate1.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'Text22
        '
        Me.Text22.BackColor = System.Drawing.Color.Transparent
        Me.Text22.BorderColor = System.Drawing.Color.Black
        Me.Text22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text22.BorderWidth = 1.0!
        Me.Text22.CanGrow = False
        Me.Text22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Text22.ForeColor = System.Drawing.Color.Black
        Me.Text22.LocationFloat = New DevExpress.Utils.PointFloat(591.6667!, 33.33333!)
        Me.Text22.Name = "Text22"
        Me.Text22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text22.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text22.SizeF = New System.Drawing.SizeF(138.5417!, 15.34722!)
        Me.Text22.StylePriority.UseTextAlignment = False
        Me.Text22.Text = "إدارة مولّدات الكهرباء"
        Me.Text22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.Transparent
        Me.Text1.BorderColor = System.Drawing.Color.Black
        Me.Text1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text1.BorderWidth = 1.0!
        Me.Text1.CanGrow = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(334.6667!, 25.0!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(163.125!, 25.0!)
        Me.Text1.Text = "نموذج ادخال العدّادات"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.Transparent
        Me.Picture1.BorderColor = System.Drawing.Color.Black
        Me.Picture1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Picture1.BorderWidth = 1.0!
        Me.Picture1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Picture1.ForeColor = System.Drawing.Color.Black
        Me.Picture1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("Picture1.ImageSource"))
        Me.Picture1.LocationFloat = New DevExpress.Utils.PointFloat(750.0!, 16.66667!)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Picture1.SizeF = New System.Drawing.SizeF(53.33333!, 47.43056!)
        Me.Picture1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'Text23
        '
        Me.Text23.BackColor = System.Drawing.Color.Transparent
        Me.Text23.BorderColor = System.Drawing.Color.Black
        Me.Text23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text23.BorderWidth = 1.0!
        Me.Text23.CanGrow = False
        Me.Text23.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Text23.ForeColor = System.Drawing.Color.Black
        Me.Text23.LocationFloat = New DevExpress.Utils.PointFloat(108.3333!, 41.66667!)
        Me.Text23.Name = "Text23"
        Me.Text23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text23.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text23.SizeF = New System.Drawing.SizeF(88.54166!, 15.34722!)
        Me.Text23.StylePriority.UseTextAlignment = False
        Me.Text23.Text = "التاريخ:"
        Me.Text23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        Me.Text2.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 108.3333!)
        Me.Text2.Name = "Text2"
        Me.Text2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text2.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text2.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text2.StylePriority.UseTextAlignment = False
        Me.Text2.Text = "الجابي:"
        Me.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'collector1
        '
        Me.collector1.BackColor = System.Drawing.Color.Transparent
        Me.collector1.BorderColor = System.Drawing.Color.Black
        Me.collector1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.collector1.BorderWidth = 1.0!
        Me.collector1.CanGrow = False
        Me.collector1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[collector]")})
        Me.collector1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.collector1.ForeColor = System.Drawing.Color.Black
        Me.collector1.LocationFloat = New DevExpress.Utils.PointFloat(466.6667!, 108.3333!)
        Me.collector1.Name = "collector1"
        Me.collector1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.collector1.SizeF = New System.Drawing.SizeF(230.2083!, 20.83334!)
        Me.collector1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Area2
        '
        Me.Area2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text3, Me.Text4, Me.Text5, Me.Text6, Me.Text7, Me.Text8, Me.Text9, Me.Text10, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line19, Me.Line20, Me.Line21, Me.Line25, Me.Line26})
        Me.Area2.HeightF = 33.40279!
        Me.Area2.Name = "Area2"
        Me.Area2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 16.66667!)
        Me.Text3.Name = "Text3"
        Me.Text3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text3.SizeF = New System.Drawing.SizeF(110.875!, 15.34722!)
        Me.Text3.StylePriority.UseBorders = False
        Me.Text3.Text = "المولّد"
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
        Me.Text4.LocationFloat = New DevExpress.Utils.PointFloat(516.6667!, 16.66667!)
        Me.Text4.Name = "Text4"
        Me.Text4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text4.SizeF = New System.Drawing.SizeF(166.6667!, 15.34722!)
        Me.Text4.StylePriority.UseBorders = False
        Me.Text4.Text = "اسم المشترك"
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
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 16.66667!)
        Me.Text5.Name = "Text5"
        Me.Text5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text5.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text5.StylePriority.UseBorders = False
        Me.Text5.Text = "رمز العلبة"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text6.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 16.66667!)
        Me.Text6.Name = "Text6"
        Me.Text6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text6.SizeF = New System.Drawing.SizeF(142.7083!, 15.34722!)
        Me.Text6.StylePriority.UseBorders = False
        Me.Text6.Text = "عنوان العلبة"
        Me.Text6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text7.LocationFloat = New DevExpress.Utils.PointFloat(233.3333!, 16.66667!)
        Me.Text7.Name = "Text7"
        Me.Text7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text7.SizeF = New System.Drawing.SizeF(55.20833!, 15.34722!)
        Me.Text7.StylePriority.UseBorders = False
        Me.Text7.Text = "امبير"
        Me.Text7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text8.LocationFloat = New DevExpress.Utils.PointFloat(166.6667!, 16.66667!)
        Me.Text8.Name = "Text8"
        Me.Text8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text8.SizeF = New System.Drawing.SizeF(55.20833!, 15.34722!)
        Me.Text8.StylePriority.UseBorders = False
        Me.Text8.Text = "رمز العدّاد"
        Me.Text8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text9
        '
        Me.Text9.BackColor = System.Drawing.Color.Transparent
        Me.Text9.BorderColor = System.Drawing.Color.Black
        Me.Text9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text9.BorderWidth = 1.0!
        Me.Text9.CanGrow = False
        Me.Text9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text9.ForeColor = System.Drawing.Color.Black
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(83.33334!, 16.66667!)
        Me.Text9.Name = "Text9"
        Me.Text9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text9.SizeF = New System.Drawing.SizeF(71.875!, 15.34722!)
        Me.Text9.StylePriority.UseBorders = False
        Me.Text9.Text = "القيمة السابقة"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text10
        '
        Me.Text10.BackColor = System.Drawing.Color.Transparent
        Me.Text10.BorderColor = System.Drawing.Color.Black
        Me.Text10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text10.BorderWidth = 1.0!
        Me.Text10.CanGrow = False
        Me.Text10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text10.ForeColor = System.Drawing.Color.Black
        Me.Text10.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 16.66667!)
        Me.Text10.Name = "Text10"
        Me.Text10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text10.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text10.StylePriority.UseBorders = False
        Me.Text10.Text = "القيمة الحاليّة"
        Me.Text10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line12
        '
        Me.Line12.BackColor = System.Drawing.Color.Transparent
        Me.Line12.BorderColor = System.Drawing.Color.Silver
        Me.Line12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line12.BorderWidth = 1.0!
        Me.Line12.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line12.ForeColor = System.Drawing.Color.Silver
        Me.Line12.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line12.LocationFloat = New DevExpress.Utils.PointFloat(691.6667!, 8.333333!)
        Me.Line12.Name = "Line12"
        Me.Line12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line12.SizeF = New System.Drawing.SizeF(2.083313!, 25.06945!)
        Me.Line12.StylePriority.UseBorders = False
        '
        'Line13
        '
        Me.Line13.BackColor = System.Drawing.Color.Transparent
        Me.Line13.BorderColor = System.Drawing.Color.Silver
        Me.Line13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line13.BorderWidth = 1.0!
        Me.Line13.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line13.ForeColor = System.Drawing.Color.Silver
        Me.Line13.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line13.LocationFloat = New DevExpress.Utils.PointFloat(514.6667!, 8.333333!)
        Me.Line13.Name = "Line13"
        Me.Line13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line13.SizeF = New System.Drawing.SizeF(2.0!, 24.93056!)
        Me.Line13.StylePriority.UseBorders = False
        '
        'Line14
        '
        Me.Line14.BackColor = System.Drawing.Color.Transparent
        Me.Line14.BorderColor = System.Drawing.Color.Silver
        Me.Line14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line14.BorderWidth = 1.0!
        Me.Line14.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line14.ForeColor = System.Drawing.Color.Silver
        Me.Line14.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line14.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 8.333333!)
        Me.Line14.Name = "Line14"
        Me.Line14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line14.SizeF = New System.Drawing.SizeF(2.083344!, 25.06945!)
        Me.Line14.StylePriority.UseBorders = False
        '
        'Line15
        '
        Me.Line15.BackColor = System.Drawing.Color.Transparent
        Me.Line15.BorderColor = System.Drawing.Color.Silver
        Me.Line15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line15.BorderWidth = 1.0!
        Me.Line15.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line15.ForeColor = System.Drawing.Color.Silver
        Me.Line15.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line15.LocationFloat = New DevExpress.Utils.PointFloat(291.6667!, 8.333333!)
        Me.Line15.Name = "Line15"
        Me.Line15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line15.SizeF = New System.Drawing.SizeF(2.083344!, 25.06945!)
        Me.Line15.StylePriority.UseBorders = False
        '
        'Line16
        '
        Me.Line16.BackColor = System.Drawing.Color.Transparent
        Me.Line16.BorderColor = System.Drawing.Color.Silver
        Me.Line16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line16.BorderWidth = 1.0!
        Me.Line16.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line16.ForeColor = System.Drawing.Color.Silver
        Me.Line16.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line16.LocationFloat = New DevExpress.Utils.PointFloat(225.0!, 8.333333!)
        Me.Line16.Name = "Line16"
        Me.Line16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line16.SizeF = New System.Drawing.SizeF(2.083328!, 25.06945!)
        Me.Line16.StylePriority.UseBorders = False
        '
        'Line19
        '
        Me.Line19.BackColor = System.Drawing.Color.Transparent
        Me.Line19.BorderColor = System.Drawing.Color.Silver
        Me.Line19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line19.BorderWidth = 1.0!
        Me.Line19.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line19.ForeColor = System.Drawing.Color.Silver
        Me.Line19.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line19.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 8.333333!)
        Me.Line19.Name = "Line19"
        Me.Line19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line19.SizeF = New System.Drawing.SizeF(2.083334!, 25.06945!)
        Me.Line19.StylePriority.UseBorders = False
        '
        'Line20
        '
        Me.Line20.BackColor = System.Drawing.Color.Transparent
        Me.Line20.BorderColor = System.Drawing.Color.Silver
        Me.Line20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line20.BorderWidth = 1.0!
        Me.Line20.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line20.ForeColor = System.Drawing.Color.Silver
        Me.Line20.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 7.361126!)
        Me.Line20.Name = "Line20"
        Me.Line20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line20.SizeF = New System.Drawing.SizeF(805.6667!, 2.083333!)
        Me.Line20.StylePriority.UseBorders = False
        '
        'Line21
        '
        Me.Line21.BackColor = System.Drawing.Color.Transparent
        Me.Line21.BorderColor = System.Drawing.Color.Silver
        Me.Line21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line21.BorderWidth = 1.0!
        Me.Line21.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line21.ForeColor = System.Drawing.Color.Silver
        Me.Line21.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line21.LocationFloat = New DevExpress.Utils.PointFloat(813.9999!, 8.333333!)
        Me.Line21.Name = "Line21"
        Me.Line21.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line21.SizeF = New System.Drawing.SizeF(2.083313!, 25.06945!)
        Me.Line21.StylePriority.UseBorders = False
        '
        'Line25
        '
        Me.Line25.BackColor = System.Drawing.Color.Transparent
        Me.Line25.BorderColor = System.Drawing.Color.Silver
        Me.Line25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line25.BorderWidth = 1.0!
        Me.Line25.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line25.ForeColor = System.Drawing.Color.Silver
        Me.Line25.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line25.LocationFloat = New DevExpress.Utils.PointFloat(79.16666!, 8.402793!)
        Me.Line25.Name = "Line25"
        Me.Line25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line25.SizeF = New System.Drawing.SizeF(2.083336!, 25.0!)
        Me.Line25.StylePriority.UseBorders = False
        '
        'Line26
        '
        Me.Line26.BackColor = System.Drawing.Color.Transparent
        Me.Line26.BorderColor = System.Drawing.Color.Silver
        Me.Line26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Line26.BorderWidth = 1.0!
        Me.Line26.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line26.ForeColor = System.Drawing.Color.Silver
        Me.Line26.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line26.LocationFloat = New DevExpress.Utils.PointFloat(161.4583!, 8.402793!)
        Me.Line26.Name = "Line26"
        Me.Line26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line26.SizeF = New System.Drawing.SizeF(2.083344!, 24.99999!)
        Me.Line26.StylePriority.UseBorders = False
        '
        'Area4
        '
        Me.Area4.HeightF = 0!
        Me.Area4.KeepTogether = True
        Me.Area4.Name = "Area4"
        Me.Area4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Area5
        '
        Me.Area5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PageNumber1})
        Me.Area5.HeightF = 48.0!
        Me.Area5.Name = "Area5"
        Me.Area5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageNumber1
        '
        Me.PageNumber1.BackColor = System.Drawing.Color.Transparent
        Me.PageNumber1.BorderColor = System.Drawing.Color.Black
        Me.PageNumber1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageNumber1.BorderWidth = 1.0!
        Me.PageNumber1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.PageNumber1.ForeColor = System.Drawing.Color.Black
        Me.PageNumber1.LocationFloat = New DevExpress.Utils.PointFloat(341.6667!, 25.0!)
        Me.PageNumber1.Name = "PageNumber1"
        Me.PageNumber1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PageNumber1.PageInfo = DevExpress.XtraPrinting.PageInfo.Number
        Me.PageNumber1.SizeF = New System.Drawing.SizeF(65.97222!, 15.34722!)
        Me.PageNumber1.StylePriority.UseTextAlignment = False
        Me.PageNumber1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 25.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 25.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'DataSetInvoices1
        '
        Me.DataSetInvoices1.DataSetName = "DataSetInvoices"
        Me.DataSetInvoices1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XtraEmptyCouterHistoryReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Area3, Me.Area1, Me.Area2, Me.Area4, Me.Area5, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetInvoices1})
        Me.DataMember = "emptyCounterHistdt"
        Me.DataSource = Me.DataSetInvoices1
        Me.Margins = New System.Drawing.Printing.Margins(0, 1, 25, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "21.2"
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Area3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents motor1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cname1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents boxcode1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents boxlocation1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ampere1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents countercode1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lastvalue1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents newvalue1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line11 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line38 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Area1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PrintDate1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Text22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Picture1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Text23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents collector1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area2 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Text3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line12 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line14 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line15 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line16 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line19 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line20 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line21 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line25 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Line26 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Area4 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Area5 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PageNumber1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DataSetInvoices1 As DataSetInvoices
End Class
