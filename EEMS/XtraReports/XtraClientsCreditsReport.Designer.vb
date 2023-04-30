<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraClientsCreditsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraClientsCreditsReport))
        Me.Area3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.client1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ampere1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.netvalue1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.netpaid1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.netremainder1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.notes1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.insurance1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line27 = New DevExpress.XtraReports.UI.XRLine()
        Me.Area1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PrintDate1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Text13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Text22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area2 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area4 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Area5 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.PageNumber1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Line15 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line20 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line21 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line22 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line23 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line24 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Box2 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.DataSetInvoices1 = New EEMS.DataSetInvoices()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Area3
        '
        Me.Area3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.client1, Me.ampere1, Me.netvalue1, Me.netpaid1, Me.netremainder1, Me.notes1, Me.insurance1, Me.Line27})
        Me.Area3.HeightF = 27.0!
        Me.Area3.KeepTogether = True
        Me.Area3.Name = "Area3"
        Me.Area3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'client1
        '
        Me.client1.BackColor = System.Drawing.Color.Transparent
        Me.client1.BorderColor = System.Drawing.Color.Black
        Me.client1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.client1.BorderWidth = 1.0!
        Me.client1.CanGrow = False
        Me.client1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[client]")})
        Me.client1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.client1.ForeColor = System.Drawing.Color.Black
        Me.client1.LocationFloat = New DevExpress.Utils.PointFloat(592.3334!, 8.333333!)
        Me.client1.Name = "client1"
        Me.client1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.client1.SizeF = New System.Drawing.SizeF(205.6247!, 15.34722!)
        Me.client1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ampere1
        '
        Me.ampere1.BackColor = System.Drawing.Color.Transparent
        Me.ampere1.BorderColor = System.Drawing.Color.Black
        Me.ampere1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ampere1.BorderWidth = 1.0!
        Me.ampere1.CanGrow = False
        Me.ampere1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ampere]")})
        Me.ampere1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.ampere1.ForeColor = System.Drawing.Color.Black
        Me.ampere1.LocationFloat = New DevExpress.Utils.PointFloat(506.3333!, 8.333333!)
        Me.ampere1.Name = "ampere1"
        Me.ampere1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ampere1.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.ampere1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'netvalue1
        '
        Me.netvalue1.BackColor = System.Drawing.Color.Transparent
        Me.netvalue1.BorderColor = System.Drawing.Color.Black
        Me.netvalue1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.netvalue1.BorderWidth = 1.0!
        Me.netvalue1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[netvalue]")})
        Me.netvalue1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.netvalue1.ForeColor = System.Drawing.Color.Black
        Me.netvalue1.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 8.333333!)
        Me.netvalue1.Name = "netvalue1"
        Me.netvalue1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.netvalue1.SizeF = New System.Drawing.SizeF(95.83334!, 15.34722!)
        Me.netvalue1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.netvalue1.TextFormatString = "{0:N0}"
        '
        'netpaid1
        '
        Me.netpaid1.BackColor = System.Drawing.Color.Transparent
        Me.netpaid1.BorderColor = System.Drawing.Color.Black
        Me.netpaid1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.netpaid1.BorderWidth = 1.0!
        Me.netpaid1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[netpaid]")})
        Me.netpaid1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.netpaid1.ForeColor = System.Drawing.Color.Black
        Me.netpaid1.LocationFloat = New DevExpress.Utils.PointFloat(316.6667!, 8.333333!)
        Me.netpaid1.Name = "netpaid1"
        Me.netpaid1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.netpaid1.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.netpaid1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.netpaid1.TextFormatString = "{0:N0}"
        '
        'netremainder1
        '
        Me.netremainder1.BackColor = System.Drawing.Color.Transparent
        Me.netremainder1.BorderColor = System.Drawing.Color.Black
        Me.netremainder1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.netremainder1.BorderWidth = 1.0!
        Me.netremainder1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[netremainder]")})
        Me.netremainder1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.netremainder1.ForeColor = System.Drawing.Color.Black
        Me.netremainder1.LocationFloat = New DevExpress.Utils.PointFloat(233.3333!, 8.333333!)
        Me.netremainder1.Name = "netremainder1"
        Me.netremainder1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.netremainder1.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.netremainder1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.netremainder1.TextFormatString = "{0:N0}"
        '
        'notes1
        '
        Me.notes1.BackColor = System.Drawing.Color.Transparent
        Me.notes1.BorderColor = System.Drawing.Color.Black
        Me.notes1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.notes1.BorderWidth = 1.0!
        Me.notes1.CanGrow = False
        Me.notes1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[notes]")})
        Me.notes1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.notes1.ForeColor = System.Drawing.Color.Black
        Me.notes1.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 8.333333!)
        Me.notes1.Name = "notes1"
        Me.notes1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.notes1.SizeF = New System.Drawing.SizeF(140.9722!, 15.34722!)
        Me.notes1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'insurance1
        '
        Me.insurance1.BackColor = System.Drawing.Color.Transparent
        Me.insurance1.BorderColor = System.Drawing.Color.Black
        Me.insurance1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.insurance1.BorderWidth = 1.0!
        Me.insurance1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[insurance]")})
        Me.insurance1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.insurance1.ForeColor = System.Drawing.Color.Black
        Me.insurance1.LocationFloat = New DevExpress.Utils.PointFloat(158.3333!, 8.333333!)
        Me.insurance1.Name = "insurance1"
        Me.insurance1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.insurance1.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.insurance1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.insurance1.TextFormatString = "{0:N0}"
        '
        'Line27
        '
        Me.Line27.BackColor = System.Drawing.Color.Transparent
        Me.Line27.BorderColor = System.Drawing.Color.Black
        Me.Line27.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Line27.BorderWidth = 1.0!
        Me.Line27.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Line27.ForeColor = System.Drawing.Color.Black
        Me.Line27.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 1.666673!)
        Me.Line27.Name = "Line27"
        Me.Line27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line27.SizeF = New System.Drawing.SizeF(794.6248!, 2.083333!)
        '
        'Area1
        '
        Me.Area1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.PrintDate1, Me.Text13, Me.Picture1, Me.Text22, Me.Text3})
        Me.Area1.HeightF = 75.0!
        Me.Area1.KeepTogether = True
        Me.Area1.Name = "Area1"
        Me.Area1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrgInfodt].[OrgName]")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(592.3334!, 48.68056!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(138.5417!, 15.41665!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'PrintDate1
        '
        Me.PrintDate1.BackColor = System.Drawing.Color.Transparent
        Me.PrintDate1.BorderColor = System.Drawing.Color.Black
        Me.PrintDate1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PrintDate1.BorderWidth = 1.0!
        Me.PrintDate1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.PrintDate1.ForeColor = System.Drawing.Color.Black
        Me.PrintDate1.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 33.33333!)
        Me.PrintDate1.Name = "PrintDate1"
        Me.PrintDate1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PrintDate1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.PrintDate1.SizeF = New System.Drawing.SizeF(91.36112!, 15.34722!)
        Me.PrintDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.PrintDate1.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'Text13
        '
        Me.Text13.BackColor = System.Drawing.Color.Transparent
        Me.Text13.BorderColor = System.Drawing.Color.Black
        Me.Text13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text13.BorderWidth = 1.0!
        Me.Text13.CanGrow = False
        Me.Text13.Font = New DevExpress.Drawing.DXFont("Arial", 14.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text13.ForeColor = System.Drawing.Color.Black
        Me.Text13.LocationFloat = New DevExpress.Utils.PointFloat(298.5833!, 16.66667!)
        Me.Text13.Name = "Text13"
        Me.Text13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text13.SizeF = New System.Drawing.SizeF(233.3333!, 33.33333!)
        Me.Text13.StylePriority.UseTextAlignment = False
        Me.Text13.Text = "كشف مكسورات الزبائن"
        Me.Text13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.Transparent
        Me.Picture1.BorderColor = System.Drawing.Color.Black
        Me.Picture1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Picture1.BorderWidth = 1.0!
        Me.Picture1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.Picture1.ForeColor = System.Drawing.Color.Black
        Me.Picture1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("Picture1.ImageSource"))
        Me.Picture1.LocationFloat = New DevExpress.Utils.PointFloat(750.6667!, 16.66667!)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Picture1.SizeF = New System.Drawing.SizeF(53.33333!, 47.43056!)
        Me.Picture1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'Text22
        '
        Me.Text22.BackColor = System.Drawing.Color.Transparent
        Me.Text22.BorderColor = System.Drawing.Color.Black
        Me.Text22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text22.BorderWidth = 1.0!
        Me.Text22.CanGrow = False
        Me.Text22.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.Text22.ForeColor = System.Drawing.Color.Black
        Me.Text22.LocationFloat = New DevExpress.Utils.PointFloat(592.3334!, 33.33333!)
        Me.Text22.Name = "Text22"
        Me.Text22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text22.SizeF = New System.Drawing.SizeF(138.5417!, 15.34722!)
        Me.Text22.Text = "إدارة مولّدات الكهرباء"
        Me.Text22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.Transparent
        Me.Text3.BorderColor = System.Drawing.Color.Black
        Me.Text3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text3.BorderWidth = 1.0!
        Me.Text3.CanGrow = False
        Me.Text3.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Text3.ForeColor = System.Drawing.Color.Black
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(108.0278!, 33.33333!)
        Me.Text3.Name = "Text3"
        Me.Text3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text3.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text3.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text3.StylePriority.UseTextAlignment = False
        Me.Text3.Text = "التاريخ:"
        Me.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Area2
        '
        Me.Area2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text1, Me.Text2, Me.Text8, Me.Text9, Me.Text10, Me.Text11, Me.Text12})
        Me.Area2.HeightF = 65.0!
        Me.Area2.Name = "Area2"
        Me.Area2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(592.3334!, 41.66667!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(205.6247!, 15.34722!)
        Me.Text1.Text = "إسم المشترك"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        Me.Text2.LocationFloat = New DevExpress.Utils.PointFloat(506.3333!, 41.66667!)
        Me.Text2.Name = "Text2"
        Me.Text2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text2.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.Text2.Text = "نوع الإشتراك"
        Me.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text8
        '
        Me.Text8.BackColor = System.Drawing.Color.Transparent
        Me.Text8.BorderColor = System.Drawing.Color.Black
        Me.Text8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text8.BorderWidth = 1.0!
        Me.Text8.CanGrow = False
        Me.Text8.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text8.ForeColor = System.Drawing.Color.Black
        Me.Text8.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 41.66667!)
        Me.Text8.Name = "Text8"
        Me.Text8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text8.SizeF = New System.Drawing.SizeF(95.83334!, 15.34722!)
        Me.Text8.Text = "إجمالي فواتير ل.ل"
        Me.Text8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(316.6667!, 41.66667!)
        Me.Text9.Name = "Text9"
        Me.Text9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text9.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.Text9.Text = "مدفوع ل.ل"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text10
        '
        Me.Text10.BackColor = System.Drawing.Color.Transparent
        Me.Text10.BorderColor = System.Drawing.Color.Black
        Me.Text10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text10.BorderWidth = 1.0!
        Me.Text10.CanGrow = False
        Me.Text10.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text10.ForeColor = System.Drawing.Color.Black
        Me.Text10.LocationFloat = New DevExpress.Utils.PointFloat(241.6667!, 41.66667!)
        Me.Text10.Name = "Text10"
        Me.Text10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text10.SizeF = New System.Drawing.SizeF(66.66666!, 15.34722!)
        Me.Text10.Text = "باقي ل.ل"
        Me.Text10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Text11.LocationFloat = New DevExpress.Utils.PointFloat(158.3333!, 41.66667!)
        Me.Text11.Name = "Text11"
        Me.Text11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text11.SizeF = New System.Drawing.SizeF(75.0!, 15.34722!)
        Me.Text11.Text = "تأمين ل.ل"
        Me.Text11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text12
        '
        Me.Text12.BackColor = System.Drawing.Color.Transparent
        Me.Text12.BorderColor = System.Drawing.Color.Black
        Me.Text12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text12.BorderWidth = 1.0!
        Me.Text12.CanGrow = False
        Me.Text12.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Text12.ForeColor = System.Drawing.Color.Black
        Me.Text12.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 41.66667!)
        Me.Text12.Name = "Text12"
        Me.Text12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text12.SizeF = New System.Drawing.SizeF(141.6667!, 15.34722!)
        Me.Text12.Text = "ملاحظات"
        Me.Text12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.PageNumber1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.PageNumber1.ForeColor = System.Drawing.Color.Black
        Me.PageNumber1.LocationFloat = New DevExpress.Utils.PointFloat(383.3333!, 22.65278!)
        Me.PageNumber1.Name = "PageNumber1"
        Me.PageNumber1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PageNumber1.PageInfo = DevExpress.XtraPrinting.PageInfo.Number
        Me.PageNumber1.SizeF = New System.Drawing.SizeF(91.66666!, 15.34722!)
        Me.PageNumber1.StylePriority.UseTextAlignment = False
        Me.PageNumber1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Line15
        '
        Me.Line15.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line15.EndBand = Me.Area3
        Me.Line15.EndPointFloat = New DevExpress.Utils.PointFloat(586.3334!, 26.38889!)
        Me.Line15.ForeColor = System.Drawing.Color.Black
        Me.Line15.Name = "Line15"
        Me.Line15.StartBand = Me.Area2
        Me.Line15.StartPointFloat = New DevExpress.Utils.PointFloat(586.3334!, 36.11111!)
        Me.Line15.WidthF = 1.0!
        '
        'Line20
        '
        Me.Line20.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line20.EndBand = Me.Area3
        Me.Line20.EndPointFloat = New DevExpress.Utils.PointFloat(501.3333!, 26.38889!)
        Me.Line20.ForeColor = System.Drawing.Color.Black
        Me.Line20.Name = "Line20"
        Me.Line20.StartBand = Me.Area2
        Me.Line20.StartPointFloat = New DevExpress.Utils.PointFloat(501.3333!, 36.11111!)
        Me.Line20.WidthF = 1.0!
        '
        'Line21
        '
        Me.Line21.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line21.EndBand = Me.Area3
        Me.Line21.EndPointFloat = New DevExpress.Utils.PointFloat(397.2222!, 26.38889!)
        Me.Line21.ForeColor = System.Drawing.Color.Black
        Me.Line21.Name = "Line21"
        Me.Line21.StartBand = Me.Area2
        Me.Line21.StartPointFloat = New DevExpress.Utils.PointFloat(397.2222!, 36.11111!)
        Me.Line21.WidthF = 1.0!
        '
        'Line22
        '
        Me.Line22.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line22.EndBand = Me.Area3
        Me.Line22.EndPointFloat = New DevExpress.Utils.PointFloat(314.5833!, 26.38889!)
        Me.Line22.ForeColor = System.Drawing.Color.Black
        Me.Line22.Name = "Line22"
        Me.Line22.StartBand = Me.Area2
        Me.Line22.StartPointFloat = New DevExpress.Utils.PointFloat(314.5833!, 36.11111!)
        Me.Line22.WidthF = 1.0!
        '
        'Line23
        '
        Me.Line23.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line23.EndBand = Me.Area3
        Me.Line23.EndPointFloat = New DevExpress.Utils.PointFloat(231.9444!, 26.38889!)
        Me.Line23.ForeColor = System.Drawing.Color.Black
        Me.Line23.Name = "Line23"
        Me.Line23.StartBand = Me.Area2
        Me.Line23.StartPointFloat = New DevExpress.Utils.PointFloat(231.9444!, 36.11111!)
        Me.Line23.WidthF = 1.0!
        '
        'Line24
        '
        Me.Line24.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line24.EndBand = Me.Area3
        Me.Line24.EndPointFloat = New DevExpress.Utils.PointFloat(157.6389!, 26.38889!)
        Me.Line24.ForeColor = System.Drawing.Color.Black
        Me.Line24.Name = "Line24"
        Me.Line24.StartBand = Me.Area2
        Me.Line24.StartPointFloat = New DevExpress.Utils.PointFloat(157.6389!, 36.11111!)
        Me.Line24.WidthF = 1.0!
        '
        'Box2
        '
        Me.Box2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Box2.BorderWidth = 1.0!
        Me.Box2.EndBand = Me.Area4
        Me.Box2.EndPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 0!)
        Me.Box2.Name = "Box2"
        Me.Box2.StartBand = Me.Area2
        Me.Box2.StartPointFloat = New DevExpress.Utils.PointFloat(8.333333!, 35.41667!)
        Me.Box2.WidthF = 795.6666!
        '
        'DataSetInvoices1
        '
        Me.DataSetInvoices1.DataSetName = "DataSetInvoices"
        Me.DataSetInvoices1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'XtraClientsCreditsReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Area3, Me.Area1, Me.Area2, Me.Area4, Me.Area5, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetInvoices1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.Line15, Me.Line20, Me.Line21, Me.Line22, Me.Line23, Me.Line24, Me.Box2})
        Me.DataMember = "creditsdt"
        Me.DataSource = Me.DataSetInvoices1
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 1, 25, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "21.2"
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Area3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents client1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ampere1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents netvalue1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents netpaid1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents netremainder1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents notes1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents insurance1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Line27 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Area1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PrintDate1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Text13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Picture1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Text22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area2 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area4 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Area5 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PageNumber1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Line15 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line20 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line21 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line22 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line23 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Line24 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Box2 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents DataSetInvoices1 As DataSetInvoices
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
