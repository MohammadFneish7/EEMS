<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
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
        Me.DetailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PrintDate1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.title1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.OrgName1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.detial1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.note1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.other1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DetailBand1
        '
        Me.DetailBand1.HeightF = 0.0!
        Me.DetailBand1.KeepTogether = True
        Me.DetailBand1.Name = "DetailBand1"
        Me.DetailBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.DetailBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PrintDate1, Me.title1, Me.Picture1, Me.OrgName1, Me.Text22, Me.Text23})
        Me.ReportHeaderBand1.HeightF = 114.0!
        Me.ReportHeaderBand1.KeepTogether = True
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        Me.ReportHeaderBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PrintDate1
        '
        Me.PrintDate1.BackColor = System.Drawing.Color.White
        Me.PrintDate1.BorderColor = System.Drawing.Color.Black
        Me.PrintDate1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PrintDate1.BorderWidth = 1.0!
        Me.PrintDate1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.PrintDate1.ForeColor = System.Drawing.Color.Black
        Me.PrintDate1.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 33.33333!)
        Me.PrintDate1.Name = "PrintDate1"
        Me.PrintDate1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PrintDate1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.PrintDate1.SizeF = New System.Drawing.SizeF(83.33334!, 15.34722!)
        Me.PrintDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'title1
        '
        Me.title1.BackColor = System.Drawing.Color.White
        Me.title1.BorderColor = System.Drawing.Color.Black
        Me.title1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.title1.BorderWidth = 1.0!
        Me.title1.CanGrow = False
        Me.title1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "title")})
        Me.title1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.title1.ForeColor = System.Drawing.Color.Black
        Me.title1.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 25.0!)
        Me.title1.Name = "title1"
        Me.title1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.title1.SizeF = New System.Drawing.SizeF(177.3611!, 25.0!)
        Me.title1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.White
        Me.Picture1.BorderColor = System.Drawing.Color.Black
        Me.Picture1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Picture1.BorderWidth = 1.0!
        Me.Picture1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Picture1.ForeColor = System.Drawing.Color.Black
        Me.Picture1.LocationFloat = New DevExpress.Utils.PointFloat(708.3333!, 16.66667!)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Picture1.SizeF = New System.Drawing.SizeF(53.33333!, 47.43056!)
        '
        'OrgName1
        '
        Me.OrgName1.BackColor = System.Drawing.Color.White
        Me.OrgName1.BorderColor = System.Drawing.Color.Black
        Me.OrgName1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.OrgName1.BorderWidth = 1.0!
        Me.OrgName1.CanGrow = False
        Me.OrgName1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrgName")})
        Me.OrgName1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.OrgName1.ForeColor = System.Drawing.Color.Black
        Me.OrgName1.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 50.0!)
        Me.OrgName1.Name = "OrgName1"
        Me.OrgName1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.OrgName1.SizeF = New System.Drawing.SizeF(138.5417!, 15.34722!)
        Me.OrgName1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Text22
        '
        Me.Text22.BackColor = System.Drawing.Color.White
        Me.Text22.BorderColor = System.Drawing.Color.Black
        Me.Text22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text22.BorderWidth = 1.0!
        Me.Text22.CanGrow = False
        Me.Text22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Text22.ForeColor = System.Drawing.Color.Black
        Me.Text22.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 33.33333!)
        Me.Text22.Name = "Text22"
        Me.Text22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text22.SizeF = New System.Drawing.SizeF(138.5417!, 15.34722!)
        Me.Text22.Text = "إدارة مولّدات الكهرباء"
        Me.Text22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Text23
        '
        Me.Text23.BackColor = System.Drawing.Color.White
        Me.Text23.BorderColor = System.Drawing.Color.Black
        Me.Text23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text23.BorderWidth = 1.0!
        Me.Text23.CanGrow = False
        Me.Text23.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Text23.ForeColor = System.Drawing.Color.Black
        Me.Text23.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 33.33333!)
        Me.Text23.Name = "Text23"
        Me.Text23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text23.SizeF = New System.Drawing.SizeF(88.54166!, 15.34722!)
        Me.Text23.Text = "التاريخ:"
        Me.Text23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.detial1, Me.note1, Me.other1})
        Me.PageHeaderBand1.HeightF = 245.0!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        Me.PageHeaderBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'detial1
        '
        Me.detial1.BackColor = System.Drawing.Color.White
        Me.detial1.BorderColor = System.Drawing.Color.Black
        Me.detial1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.detial1.BorderWidth = 1.0!
        Me.detial1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "detial")})
        Me.detial1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.detial1.ForeColor = System.Drawing.Color.Black
        Me.detial1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 25.0!)
        Me.detial1.Name = "detial1"
        Me.detial1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.detial1.SizeF = New System.Drawing.SizeF(725.0!, 50.0!)
        Me.detial1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'note1
        '
        Me.note1.BackColor = System.Drawing.Color.White
        Me.note1.BorderColor = System.Drawing.Color.Black
        Me.note1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.note1.BorderWidth = 1.0!
        Me.note1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "note")})
        Me.note1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.note1.ForeColor = System.Drawing.Color.Black
        Me.note1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 91.66666!)
        Me.note1.Name = "note1"
        Me.note1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.note1.SizeF = New System.Drawing.SizeF(725.0!, 50.0!)
        Me.note1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'other1
        '
        Me.other1.BackColor = System.Drawing.Color.White
        Me.other1.BorderColor = System.Drawing.Color.Black
        Me.other1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.other1.BorderWidth = 1.0!
        Me.other1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "other")})
        Me.other1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.other1.ForeColor = System.Drawing.Color.Black
        Me.other1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 158.3333!)
        Me.other1.Name = "other1"
        Me.other1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.other1.SizeF = New System.Drawing.SizeF(725.0!, 50.0!)
        Me.other1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportFooterBand1
        '
        Me.ReportFooterBand1.HeightF = 0.0!
        Me.ReportFooterBand1.KeepTogether = True
        Me.ReportFooterBand1.Name = "ReportFooterBand1"
        Me.ReportFooterBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text5, Me.Text6})
        Me.PageFooterBand1.HeightF = 54.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        Me.PageFooterBand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooterBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text5
        '
        Me.Text5.BackColor = System.Drawing.Color.White
        Me.Text5.BorderColor = System.Drawing.Color.Black
        Me.Text5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text5.BorderWidth = 1.0!
        Me.Text5.CanGrow = False
        Me.Text5.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Text5.ForeColor = System.Drawing.Color.Black
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(250.0!, 8.333333!)
        Me.Text5.Name = "Text5"
        Me.Text5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text5.SizeF = New System.Drawing.SizeF(129.7917!, 16.66667!)
        Me.Text5.Text = "الختم/التوقيع:"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text6
        '
        Me.Text6.BackColor = System.Drawing.Color.White
        Me.Text6.BorderColor = System.Drawing.Color.Black
        Me.Text6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text6.BorderWidth = 1.0!
        Me.Text6.CanGrow = False
        Me.Text6.Font = New System.Drawing.Font("Arial", 10.0!)
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
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailBand1, Me.ReportHeaderBand1, Me.PageHeaderBand1, Me.ReportFooterBand1, Me.PageFooterBand1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 583
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A5
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents DetailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PrintDate1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents title1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Picture1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents OrgName1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents detial1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents note1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents other1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Text5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
