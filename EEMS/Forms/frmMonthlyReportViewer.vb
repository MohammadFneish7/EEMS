Imports CrystalDecisions.CrystalReports.Engine
Imports EEMS.SqlDBHelper

Public Class frmMonthlyReportViewer

    Dim ds As DataSetGeneralReport

    Sub New(ByRef dsgr As DataSetGeneralReport)

        Me.ds = dsgr

        InitializeComponent()
    End Sub

   
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim dr As DataRow = ds.OrgInfodt.NewOrgInfodtRow
        dr.ItemArray = New Object() {orgname, ""}
        ds.OrgInfodt.Rows.Add(dr)

        Dim rptDoc As New GeneralMonthlyReport

        rptDoc.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rptDoc

    End Sub



End Class