Imports System.Windows.Forms.DataVisualization.Charting

Public Class ChartBuilder

    Public Function createUniqueSeriesChartImage(ByVal seriesTitle As String, ByVal xValues As List(Of String), ByVal yValues As List(Of Integer), ByVal style As SeriesChartType, ByVal chartPalette As ChartColorPalette, labelColor As Color, ByVal size As Size) As Image
        Dim chartNew As New Chart
        Dim series As New Series(seriesTitle)
        series.ChartType = style
        series.BorderWidth = 3
        series.LabelForeColor = labelColor
        series.IsValueShownAsLabel = True
        chartNew.Series.Add(series)
        chartNew.Palette = chartPalette

        Dim lgnd1 As New Legend
        lgnd1.Docking = Docking.Right
        chartNew.Legends.Add(lgnd1)


        Dim chartArea As New ChartArea
        Dim area3D As New ChartArea3DStyle(chartArea)
        area3D.Rotation = 0
        chartNew.ChartAreas.Add(chartArea)


        Dim yAxis As New Axis(chartArea, AxisName.Y)
        Dim xAxis As New Axis(chartArea, AxisName.X)

        With chartNew.ChartAreas(0)
            .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
            .AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.Dot
        End With

        chartNew.Series(seriesTitle).Points.DataBindXY(xValues, yValues)

        chartNew.Size = size

        Dim chartImgBitmap As New Bitmap(size.Width, size.Height)
        chartNew.DrawToBitmap(chartImgBitmap, New Rectangle(0, 0, size.Width, size.Height))
        chartNew.Dispose()

        Return chartImgBitmap
    End Function

End Class
