Imports EEMS.SqlDBHelper
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine.SCRCollection
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module SharedModule

    Public ENGINE_CHOOSER As Integer = 0
    Public COLLECTOR_CHOOSER As Integer = 1
    Public CLIENT_CHOOSER As Integer = 2
    Public BOX_CHOOSER As Integer = 3
    Public COUNTER_ACTIVE_CHOOSER As Integer = 4
    Public COUNTER_NOT_ACTIVE_CHOOSER As Integer = 5
    Public PACKAGE_CHOOSER As Integer = 6
    Public REGISTRATION_CHOOSER As Integer = 7
    Public BULK_DISCOUNT_CHOOSER As Integer = 8
    Public ITEM_CHOOSER As Integer = 9
    Public TANK_CHOOSER As Integer = 10

    Public currentUser As User
    Public orgname As String = "Organization Name"
    Public invoiceYOffset = 0
    Public invoiceXOffset = 0
    Public dollarPrice = 0
    Public roundToThousand As Integer = 0 '0 round to 1000, 1 ceil, 2 dont rount
    Public defaultPayOption As Integer = 0
    Public mainColor As Integer = Color.White.ToArgb()
    Public isPaymentVerified As Boolean = True

    Public Sub cloneTable(ByRef table1 As DataTable, ByRef table2 As DataTable)
        For i As Int32 = 0 To table2.Rows.Count - 1
            table1.Rows.Add()
            table1.Rows(i).ItemArray = table2(i).ItemArray
        Next
    End Sub

    Public Function getArabicMonth(i As Integer) As String
        Dim months As String() = New String() {"ك٢‬", "شباط", "أذار", "نيسان", "أيّار", "حزيران", "تموز", "آب", "أيلول", "ت١", "ت٢‬", "ك١"}
        Return months(i - 1)
    End Function

    Public Sub loadSettings()
        Dim a As New Helper
        a.ds = New DataSet
        a.GetData("select dkey,title from DefinedKeys where reference='settings'")
        For Each dr As DataRow In a.ds.Tables(0).Rows
            If dr.Item(0).ToString.Trim.ToLower.Equals("orgname") Then
                orgname = dr.Item(1).ToString.Trim.ToLower
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("invoiceyoffset") Then
                invoiceYOffset = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("invoicexoffset") Then
                invoiceXOffset = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("roundtothousand") Then
                roundToThousand = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("defaultPayOption") Then
                defaultPayOption = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("dollarprice") Then
                dollarPrice = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("maincolor") Then
                mainColor = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            End If
        Next
    End Sub

    Public Function getLastCounterHistoryInsertDate() As Integer()
        Dim a As New Helper
        a.ds = New DataSet
        a.GetData("select IsNull(Max(ch.cyear),0) as lastYear, IsNull(Max(ch.cmonth),0) AS lastMonth from CounterHistory ch where ch.cyear = (select IsNull(Max(ch2.cyear),0) from CounterHistory ch2)")
        Dim LastInsertDate As Integer() = {a.ds.Tables(0).Rows(0).Item(0), a.ds.Tables(0).Rows(0).Item(1)}
        Return LastInsertDate
    End Function

    Public Function getLastCounterHistoryInsertDate(regid As Integer) As Integer()
        Dim a As New Helper
        a.ds = New DataSet
        a.GetData("select IsNull(Max(ch.cyear),0) as lastYear, IsNull(Max(ch.cmonth),0) AS lastMonth from CounterHistory ch where ch.regid=" & regid & " and ch.cyear = (select IsNull(Max(ch2.cyear),0) from CounterHistory ch2 where ch2.regid=" & regid & ")")
        Dim LastInsertDate As Integer() = {a.ds.Tables(0).Rows(0).Item(0), a.ds.Tables(0).Rows(0).Item(1)}
        Return LastInsertDate
    End Function

    Public Sub addButtonToGridView(gridControl As GridControl, gridView As GridView, caption As String, iconImage As Bitmap, index As Int32, colMaxWidth As Integer, eventHandler As ButtonPressedEventHandler)
        Dim col As New GridColumn
        col.Caption = caption
        col.VisibleIndex = index
        col.UnboundType = DevExpress.Data.UnboundColumnType.Object
        col.MaxWidth = colMaxWidth
        col.OptionsFilter.AllowFilter = False
        Dim repButton As New RepositoryItemButtonEdit
        repButton.ButtonsStyle = BorderStyles.HotFlat
        repButton.Buttons(0).ImageOptions.Image = iconImage
        repButton.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
        AddHandler repButton.ButtonPressed, eventHandler

        repButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        gridControl.RepositoryItems.Add(repButton)
        col.ColumnEdit = repButton
        col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        col.Visible = True
        gridView.Columns.Insert(index, col)
    End Sub

    Public Sub disableGridView(gridView As GridView, exceptionList As List(Of Integer))
        For Each col As GridColumn In gridView.Columns
            If Not exceptionList.Contains(gridView.Columns.IndexOf(col)) Then
                col.OptionsColumn.AllowEdit = False
            End If
        Next
    End Sub

    Public Function getRoundThousand(ByVal i As Integer) As Integer
        If roundToThousand = 2 Then
            Return 0
        End If

        If (i Mod 1000) = 1000 Or (i Mod 1000) = 0 Then
            Return 0
        End If

        If roundToThousand = 0 Then
            Return 1000 - (i Mod 1000)
        End If

        If (i Mod 1000) < 500 Then
            Return -(i Mod 1000)
        Else
            Return 1000 - (i Mod 1000)
        End If
    End Function

    Public Function getBit(b As Boolean) As Integer
        If b = False Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Public Function getBit(b As String) As Integer
        If b.ToUpper.Trim = "FALSE" OrElse b.ToUpper.Trim = "0" Then
            Return 0
        Else
            Return 1
        End If
    End Function

End Module
