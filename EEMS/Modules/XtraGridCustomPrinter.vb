Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid

Public Class XtraGridCustomPrinter

    Dim title As String = "العنوان"

    Sub New(title As String, dgvData1 As GridControl, isLandscape As Boolean, paperkind As System.Drawing.Printing.PaperKind)

        Me.title = title

        Dim ps As New PrintingSystem()
        Dim pcl As New PrintableComponentLink(ps)


        ps.Links.Add(pcl)
        pcl.Component = dgvData1
        pcl.PaperKind = paperkind

        AddHandler pcl.CreateReportHeaderArea, AddressOf Link_CreateReportHeaderArea
        AddHandler pcl.CreateMarginalFooterArea, AddressOf Link_CreateMarginalFooterArea
        pcl.Landscape = True
        pcl.Margins.Bottom = 40
        pcl.Margins.Top = 20
        pcl.Margins.Left = 10
        pcl.Margins.Right = 10
        CType(pcl.PageHeaderFooter, PageHeaderFooter).Header.Content.Clear()

        If isLandscape Then
            pcl.Landscape = True
        Else
            pcl.Landscape = False
        End If

        pcl.CreateDocument()
        pcl.ShowPreviewDialog()
    End Sub

    Sub Link_CreateReportHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)


        Dim dateBrick1 As New TextBrick
        dateBrick1.Text = ":التاريخ"
        dateBrick1.BackColor = Color.Transparent
        dateBrick1.Rect = New Rectangle(120, 50, 60, 50)
        dateBrick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
        dateBrick1.BorderWidth = 0

        Dim dateBrick As New TextBrick
        dateBrick.Text = Format(Date.Now, "dd-MMM-yyyy")
        dateBrick.BackColor = Color.Transparent
        dateBrick.Rect = New Rectangle(10, 50, 100, 50)
        dateBrick.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
        dateBrick.BorderWidth = 0

        Dim titleBrick As New TextBrick
        titleBrick.Text = title
        titleBrick.BackColor = Color.Transparent
        titleBrick.Font = New Font("Arial", 16, FontStyle.Bold)
        titleBrick.Rect = New Rectangle(0, 15, e.Graph.ClientPageSize.Width, 150)
        titleBrick.HorzAlignment = DevExpress.Utils.HorzAlignment.Center
        titleBrick.BorderWidth = 0

        Dim imgBrick As New ImageBrick
        imgBrick.Image = My.Resources.cedar
        imgBrick.BorderWidth = 0
        imgBrick.Rect = New Rectangle(e.Graph.ClientPageSize.Width - 70, 30, 64, 55)
        imgBrick.ImageAlignment = ImageAlignment.MiddleCenter

        Dim imtitle1 As New TextBrick
        imtitle1.Text = orgname
        imtitle1.BackColor = Color.Transparent
        imtitle1.Rect = New Rectangle(e.Graph.ClientPageSize.Width - 200, 70, 120, 15)
        imtitle1.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
        imtitle1.BorderWidth = 0

        Dim imtitle2 As New TextBrick
        imtitle2.Text = "إدارة مولّدات الكهرباء"
        imtitle2.BackColor = Color.Transparent
        imtitle2.Rect = New Rectangle(e.Graph.ClientPageSize.Width - 200, 50, 120, 15)
        imtitle2.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
        imtitle2.BorderWidth = 0

        e.Graph.DrawBrick(dateBrick1)
        e.Graph.DrawBrick(dateBrick)
        e.Graph.DrawBrick(titleBrick)
        e.Graph.DrawBrick(imgBrick)
        e.Graph.DrawBrick(imtitle1)
        e.Graph.DrawBrick(imtitle2)
        'e.Graph.DrawImage(My.Resources.cedar, New Rectangle(100, 50, 64, 64))
    End Sub

    Sub Link_CreateMarginalFooterArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        Dim pnumBrick2 As PageInfoBrick = e.Graph.DrawPageInfo(PageInfo.Number, "", Color.Black, _
           New RectangleF(0, 10, 50, 20), DevExpress.XtraPrinting.BorderSide.None)
        pnumBrick2.LineAlignment = BrickAlignment.Near
        pnumBrick2.Alignment = BrickAlignment.Near
        pnumBrick2.AutoWidth = True
        pnumBrick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
        pnumBrick2.VertAlignment = DevExpress.Utils.VertAlignment.Center
    End Sub
End Class
