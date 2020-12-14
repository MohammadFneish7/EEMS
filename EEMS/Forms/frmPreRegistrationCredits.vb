Imports DevExpress.XtraEditors.Controls
Imports EEMS.SqlDBHelper

Public Class frmPreRegistrationCredits

    Dim a As New Helper
    Dim bs As New BindingSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()

        addButtonToGridView(dgvData1, GridView1, "تعديل", My.Resources.Pencil16, 0, 50, AddressOf buttonReportPressed)
        Dim exceptionList As New List(Of Integer)
        exceptionList.Add(0)

        Try
            GridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            GridView1.Columns(0).SummaryItem.DisplayFormat = "{0} أسطر"
        Catch ex As Exception
        End Try

        For Each col As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            If GridView1.Columns.IndexOf(col) = 17 Then
                col.AppearanceCell.BackColor = Color.FromArgb(192, 255, 192)
            End If
        Next

        disableGridView(GridView1, exceptionList)
        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData1, True, Nothing)
        End If
    End Sub

    Private Sub loadData()
        a.ds = New DataSet
        a.GetData("SELECT r.ID as [معرّف الاشتراك],r.clientid as [معرّف المشترك],r.active as مفعّل,c.clientname as [الاسم الثلاثي],c.clientnickname AS [اللقب],c.clientmothername AS [اسم الام],c.caddress AS [العنوان],c.phone AS [الهاتف],c.mobile AS [الخليوي],registrationdate as [تاريخ الاشتراك],enddate as [تاريخ انهاء الاشتراك],p.title as [أمبير],b.code as [رمز العلبة],b.location as [عنوان العلبة],ec.serial as[رمز العدّاد],ec.code as [الرمز في العلبة], ISNULL((select ch.monthlyfee from CounterHistory ch where ch.cmonth=(DATEPART(""m"",DATEADD(MONTH, -1, r.registrationdate))) and ch.cyear=(DATEPART(""yyyy"",DATEADD(MONTH, -1, r.registrationdate))) and ch.regid=r.ID),0) as [كسر ما قبل البرنامج ل.ل] FROM Registration r join Client c on r.clientid = c.ID join ECounter ec on r.counterid = ec.ID join ElectricBox b on ec.boxid = b.ID join Package p on r.packageid = p.ID order By r.active")
        bs.DataSource = a.ds.Tables(0)
        dgvData1.DataSource = bs
    End Sub

    Private Sub frmPreRegistrationCredits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonReportPressed(sender As Object, e As ButtonPressedEventArgs)
        Try
            If GridView1.GetSelectedRows.Count > 0 Then
                Dim frm As New frmGeneralPerposeInput("", "", True)
                frm.PasswordTextBox.MaxLength = 9
                frm.PasswordTextBox.Text = GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(17)).ToString()
                Dim dr As DialogResult = frm.ShowDialog
                If dr = DialogResult.OK Then
                    Dim result As Integer = 0
                    Dim regDate As DateTime = GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(10))
                    regDate = regDate.AddMonths(-1)

                    If Integer.TryParse(frm.PasswordTextBox.Text.Trim(), result) Then
                        Try
                            a.ds.Tables("dt2").Clear()
                        Catch ex As Exception
                        End Try
                        a.GetData("select ID from CounterHistory where cmonth=" & regDate.Month & " and cyear=" & regDate.Year, "dt2")
                        If a.ds.Tables("dt2").Rows.Count > 0 Then
                            Dim chID As Integer = a.ds.Tables("dt2").Rows(0).Item(0)
                            a.ExecuteNoReturn("update CounterHistory set monthlyfee=" & result & " where ID=" & chID)
                        Else
                            a.ExecuteNoReturn("insert into CounterHistory (cmonth, cyear, regid, monthlyfee, kilowattprice, previousvalue, currentvalue, roundvalue, discount) values (" & regDate.Month & "," & regDate.Year & "," & GridView1.GetRowCellValue(GridView1.GetSelectedRows(0), GridView1.Columns(1)) & "," & result & ",0,0,0,0,0)")
                        End If
                    End If
                End If
                loadData()
            End If

        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

    End Sub

    Private Sub btnShowPrint_Click(sender As Object, e As EventArgs) Handles btnShowPrint.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Try
            Dim customPrinter As New frmCustomPrinterHandler(Me.Text.Trim, dgvData1, New Integer() {0})
            customPrinter.ShowDialog()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim index As Int16 = GridView1.Columns.IndexOf(e.Column)
        Dim indecies As Int16() = {17}
        If indecies.Contains(index) Then
            e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            e.Column.DisplayFormat.FormatString = "N0"
            e.Column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub

    Private Sub btnExportExcell_Click(sender As Object, e As EventArgs) Handles btnExportExcell.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frmexport As New frmCustomExportHandler(dgvData1, New Integer() {0})
        frmexport.ShowDialog()
    End Sub
End Class