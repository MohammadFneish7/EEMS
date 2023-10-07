<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraGeneralReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraGeneralReport))
        Me.Area3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.Area1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PrintDate1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.title1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Text22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area2 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.detial1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.note1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.other1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Area4 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Area5 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSetInvoices1 = New EEMS.DataSetInvoices()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Area3
        '
        Me.Area3.HeightF = 0!
        Me.Area3.KeepTogether = True
        Me.Area3.Name = "Area3"
        Me.Area3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Area1
        '
        Me.Area1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.PrintDate1, Me.title1, Me.Picture1, Me.Text22, Me.Text23})
        Me.Area1.HeightF = 114.0!
        Me.Area1.KeepTogether = True
        Me.Area1.Name = "Area1"
        Me.Area1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.PrintDate1.SizeF = New System.Drawing.SizeF(108.3333!, 15.34722!)
        Me.PrintDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.PrintDate1.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'title1
        '
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.BorderColor = System.Drawing.Color.Black
        Me.title1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.title1.BorderWidth = 1.0!
        Me.title1.CanGrow = False
        Me.title1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[title]")})
        Me.title1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.title1.ForeColor = System.Drawing.Color.Black
        Me.title1.LocationFloat = New DevExpress.Utils.PointFloat(334.375!, 23.68056!)
        Me.title1.Name = "title1"
        Me.title1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.title1.SizeF = New System.Drawing.SizeF(177.3611!, 25.0!)
        Me.title1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.Picture1.LocationFloat = New DevExpress.Utils.PointFloat(744.7917!, 25.0!)
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
        Me.Text22.LocationFloat = New DevExpress.Utils.PointFloat(586.4583!, 41.66667!)
        Me.Text22.Name = "Text22"
        Me.Text22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text22.SizeF = New System.Drawing.SizeF(138.5417!, 15.34722!)
        Me.Text22.Text = "إدارة مولّدات الكهرباء"
        Me.Text22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Text23
        '
        Me.Text23.BackColor = System.Drawing.Color.Transparent
        Me.Text23.BorderColor = System.Drawing.Color.Black
        Me.Text23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text23.BorderWidth = 1.0!
        Me.Text23.CanGrow = False
        Me.Text23.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Text23.ForeColor = System.Drawing.Color.Black
        Me.Text23.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 33.33333!)
        Me.Text23.Name = "Text23"
        Me.Text23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text23.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text23.SizeF = New System.Drawing.SizeF(63.54167!, 15.34722!)
        Me.Text23.StylePriority.UseTextAlignment = False
        Me.Text23.Text = "التاريخ:"
        Me.Text23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Area2
        '
        Me.Area2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.detial1, Me.note1, Me.other1})
        Me.Area2.HeightF = 245.0!
        Me.Area2.Name = "Area2"
        Me.Area2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'detial1
        '
        Me.detial1.BackColor = System.Drawing.Color.Transparent
        Me.detial1.BorderColor = System.Drawing.Color.Black
        Me.detial1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.detial1.BorderWidth = 1.0!
        Me.detial1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[detial]")})
        Me.detial1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.0!)
        Me.detial1.ForeColor = System.Drawing.Color.Black
        Me.detial1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 25.0!)
        Me.detial1.Multiline = True
        Me.detial1.Name = "detial1"
        Me.detial1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.detial1.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.detial1.SizeF = New System.Drawing.SizeF(773.1249!, 50.0!)
        Me.detial1.StylePriority.UseTextAlignment = False
        Me.detial1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'note1
        '
        Me.note1.BackColor = System.Drawing.Color.Transparent
        Me.note1.BorderColor = System.Drawing.Color.Black
        Me.note1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.note1.BorderWidth = 1.0!
        Me.note1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[note]")})
        Me.note1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.0!)
        Me.note1.ForeColor = System.Drawing.Color.Black
        Me.note1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 91.66666!)
        Me.note1.Multiline = True
        Me.note1.Name = "note1"
        Me.note1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.note1.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.note1.SizeF = New System.Drawing.SizeF(773.1249!, 49.99999!)
        Me.note1.StylePriority.UseTextAlignment = False
        Me.note1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'other1
        '
        Me.other1.BackColor = System.Drawing.Color.Transparent
        Me.other1.BorderColor = System.Drawing.Color.Black
        Me.other1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.other1.BorderWidth = 1.0!
        Me.other1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[other]")})
        Me.other1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.0!)
        Me.other1.ForeColor = System.Drawing.Color.Black
        Me.other1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 158.3333!)
        Me.other1.Multiline = True
        Me.other1.Name = "other1"
        Me.other1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.other1.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.other1.SizeF = New System.Drawing.SizeF(773.1249!, 50.0!)
        Me.other1.StylePriority.UseTextAlignment = False
        Me.other1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.Area5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text5, Me.Text6})
        Me.Area5.HeightF = 54.0!
        Me.Area5.Name = "Area5"
        Me.Area5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text5
        '
        Me.Text5.BackColor = System.Drawing.Color.Transparent
        Me.Text5.BorderColor = System.Drawing.Color.Black
        Me.Text5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text5.BorderWidth = 1.0!
        Me.Text5.CanGrow = False
        Me.Text5.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!)
        Me.Text5.ForeColor = System.Drawing.Color.Black
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(250.0!, 8.333333!)
        Me.Text5.Name = "Text5"
        Me.Text5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text5.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.Text5.SizeF = New System.Drawing.SizeF(129.7917!, 16.66667!)
        Me.Text5.StylePriority.UseTextAlignment = False
        Me.Text5.Text = "الختم/التوقيع:"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text6
        '
        Me.Text6.BackColor = System.Drawing.Color.Transparent
        Me.Text6.BorderColor = System.Drawing.Color.Black
        Me.Text6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text6.BorderWidth = 1.0!
        Me.Text6.CanGrow = False
        Me.Text6.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.Text6.ForeColor = System.Drawing.Color.Black
        Me.Text6.LocationFloat = New DevExpress.Utils.PointFloat(33.33333!, 8.333333!)
        Me.Text6.Name = "Text6"
        Me.Text6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text6.SizeF = New System.Drawing.SizeF(208.3333!, 16.66667!)
        Me.Text6.Text = "............................................................."
        Me.Text6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrgInfodt].[OrgName]")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(586.4583!, 57.01389!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(138.5417!, 15.41666!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XtraGeneralReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Area3, Me.Area1, Me.Area2, Me.Area4, Me.Area5, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSetInvoices1})
        Me.DataMember = "general"
        Me.DataSource = Me.DataSetInvoices1
        Me.Landscape = True
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 0, 25, 25)
        Me.PageHeight = 583
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A5
        Me.Version = "21.2"
        CType(Me.DataSetInvoices1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Area3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Area1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PrintDate1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents title1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Picture1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Text22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area2 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents detial1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents note1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents other1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Area4 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Area5 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Text5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataSetInvoices1 As DataSetInvoices
End Class
