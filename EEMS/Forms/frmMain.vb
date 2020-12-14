Imports EEMS.SqlDBHelper
Imports DevExpress.XtraCharts

Public Class frmMain

    Dim a As New Helper
    Dim dtNotes As New DataTable
    Dim username As String

    Sub New(user As String, ByVal pass As String)
        InitializeComponent()
        loadSettings()
        username = user
        SharedModule.currentUser = New User(username, pass)
        Me.Text = Me.Text & " : " & user

        'TODO: This line of code loads data into the 'EEMSDataSet.Engine' table. You can move, or remove it, as needed.
        'Me.EngineTableAdapter.Fill(Me.EEMSDataSet.Engine)
        a.ds = New DataSet
        Try
            readNotes()
            'TableLayoutPanel1.RowStyles.Clear()
            'For i As Int16 = 0 To TableLayoutPanel1.RowCount - 1
            '    Dim trs As New RowStyle()
            '    trs.SizeType = SizeType.Percent
            '    trs.Height = CSng(100 / TableLayoutPanel1.RowCount)
            '    TableLayoutPanel1.ColumnStyles.Add(trs)
            'Next
            TableLayoutPanel2.ColumnStyles.Clear()
            For i As Int16 = 0 To TableLayoutPanel2.ColumnCount - 1
                Dim tcs As New ColumnStyle()
                tcs.SizeType = SizeType.Percent
                tcs.Width = CSng(100 / TableLayoutPanel2.ColumnCount)
                TableLayoutPanel2.ColumnStyles.Add(tcs)
            Next
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

        Try
            fillChart1()
            fillChart2()
            fillChart3()
            fillStats()

        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

        Try
            a.ExecuteNoReturn("delete from logset where indate < '" & Date.Now.AddMonths(-1).ToShortDateString & "'")
            a.ExecuteNoReturn("delete from ChangeLog where EventDate < '" & Date.Now.AddMonths(-1).ToShortDateString & "'")
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub readNotes()
        Try
            ListView1.Items.Clear()
            a.ds = New DataSet
            a.GetData("select * from Notes where username='" & SharedModule.currentUser.getUsername.Trim.ToLower & "'")
            dtNotes.Clear()
            dtNotes.Merge(a.ds.Tables(0))
            Dim itemText As String = ""
            For Each row As DataRow In dtNotes.Rows
                Dim d As String = row.Item(4).ToString
                If d.Length > 40 Then
                    d = d.Substring(0, 40) & "..."
                End If
                Dim lvi As New ListViewItem

                lvi.SubItems.Add(row.Item(0))
                Dim dtime As DateTime = Date.Parse(row.Item(1).ToString) + TimeSpan.Parse(row.Item(2).ToString)
                lvi.SubItems.Add(dtime)
                lvi.SubItems.Add(d)
                lvi.SubItems.Add(row.Item(3).ToString)

                If row.Item(3).ToString = "مجمّدة" Then
                    lvi.ForeColor = Color.Red
                    lvi.ImageIndex = 1
                Else
                    lvi.ForeColor = Color.ForestGreen
                    lvi.ImageIndex = 0
                End If
                ListView1.Items.Add(lvi)

            Next
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub checkNotesExpiry()
        Dim reread As Boolean = False
        For Each row As ListViewItem In ListView1.Items
            If (Date.Parse(row.SubItems(2).Text) <= Date.Now) And row.ImageIndex <> 1 Then
                Timer1.Enabled = False
                reread = True
                Dim mp As Media.SoundPlayer = Nothing
                Try
                    mp = New Media.SoundPlayer(My.Resources.notification)
                    mp.PlayLooping()
                Catch ex As Exception
                End Try
               
                MessageBox.Show(row.SubItems(3).Text, "مذكّرة", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Try
                    mp.Stop()
                Catch ex As Exception
                End Try

                a.Execute("update Notes set nstatus='مجمّدة' where ID=" & row.SubItems(1).Text)
            End If
        Next
        If reread Then
            readNotes()
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        checkNotesExpiry()
    End Sub

    Private Sub fillStats()
        a.ds = New DataSet
        Dim newReg As Integer = a.ExecuteScalar("SELECT COUNT(*) FROM Registration WHERE DatePart(""yyyy"",registrationdate)=" & txtMonth.Value.Year & " AND DatePart(""m"",registrationdate)=" & txtMonth.Value.Month)
        Label1.Text = newReg.ToString("N0")
        Dim inactiveReg As Integer = a.ExecuteScalar("SELECT COUNT(*) FROM Registration WHERE DatePart(""yyyy"",enddate)=" & txtMonth.Value.Year & " AND DatePart(""m"",enddate)=" & txtMonth.Value.Month & " and active=0")
        Label6.Text = inactiveReg.ToString("N0")
        Dim workHours As Integer = a.ExecuteScalar("SELECT IsNull(MAX(workinghours),0) FROM EngineWorkingHours w WHERE w.cyear=" & txtMonth.Value.Year & " AND w.cmonth=" & txtMonth.Value.Month)
        Label8.Text = workHours.ToString("N0")
        Dim sellKW As Integer = a.ExecuteScalar("SELECT IsNull(SUM(coh.currentvalue-coh.previousvalue),0) FROM CounterHistory coh WHERE coh.cyear=" & txtMonth.Value.Year & " AND coh.cmonth=" & txtMonth.Value.Month)
        Label10.Text = sellKW.ToString("N0")
    End Sub

    Private Sub fillChart1()
        Dim xvalues2 As New List(Of String)
        Dim yvalues2 As New List(Of Integer)
        a.GetData("SELECT e.ename,IsNull(SUM(w.workinghours),0) FROM Engine e,EngineWorkingHours w where w.engineid=e.ID AND cmonth=" & txtMonth.Value.Month & " AND cyear=" & txtMonth.Value.Year & " Group By ename", "dt3")
        For Each row As DataRow In a.ds.Tables("dt3").Rows
            xvalues2.Add(row.Item(0).ToString)
            yvalues2.Add(row.Item(1).ToString)
        Next
        ChartControl1.Series(0).Points.Clear()
        For i As Int16 = 0 To xvalues2.Count - 1
            ChartControl1.Series(0).Points.AddPoint(xvalues2(i), yvalues2(i))
        Next


    End Sub

    Private Sub fillChart2()
        Dim activeReg As Integer = a.ExecuteScalar("SELECT COUNT(ID) FROM Registration r WHERE active=1 and r.registrationdate<= '" & New Date(txtMonth.Value.Year, txtMonth.Value.Month, System.DateTime.DaysInMonth(txtMonth.Value.Year, txtMonth.Value.Month)).ToShortDateString & "'")
        Dim inactiveReg As Integer = a.ExecuteScalar("SELECT COUNT(*) FROM Registration WHERE DatePart(""yyyy"",enddate)=" & txtMonth.Value.Year & " AND DatePart(""m"",enddate)=" & txtMonth.Value.Month & " and active=0")
        Dim xvalues As New List(Of String)
        xvalues.AddRange({"اشتراك مفعّل", "اشتراك غير مفعّل"})
        Dim yvalues As New List(Of Integer)
        yvalues.AddRange({activeReg, inactiveReg})
        ChartControl3.Series(0).Points.Clear()
        For i As Int16 = 0 To xvalues.Count - 1
            ChartControl3.Series(0).Points.AddPoint(xvalues(i), yvalues(i))
        Next
        'PictureBox2.Image = New ChartBuilder().createUniqueSeriesChartImage("a", xvalues, yvalues, DataVisualization.Charting.SeriesChartType.Pie, DataVisualization.Charting.ChartColorPalette.Pastel, Color.Black, PictureBox2.Size)
    End Sub

    Private Sub fillChart3()
        Dim xvalues1 As New List(Of String)
        Dim yvalues1 As New List(Of Integer)
        a.GetData("SELECT p.title, COUNT(r.packageid) FROM Package p,Registration r WHERE r.packageid=p.ID  and r.active=1 and r.registrationdate<= '" & New Date(txtMonth.Value.Year, txtMonth.Value.Month, System.DateTime.DaysInMonth(txtMonth.Value.Year, txtMonth.Value.Month)).ToShortDateString & "' Group By p.title", "dt2")
        For Each row As DataRow In a.ds.Tables("dt2").Rows
            xvalues1.Add("أمبير " + row.Item(0).ToString)
            yvalues1.Add(row.Item(1).ToString)
        Next
        ChartControl4.Series(0).Points.Clear()
        For i As Int16 = 0 To xvalues1.Count - 1
            ChartControl4.Series(0).Points.AddPoint(xvalues1(i), yvalues1(i))
        Next
        'PictureBox3.Image = New ChartBuilder().createUniqueSeriesChartImage("a", xvalues1, yvalues1, DataVisualization.Charting.SeriesChartType.Pie, DataVisualization.Charting.ChartColorPalette.BrightPastel, Color.White, PictureBox3.Size)
    End Sub
    Private Sub btnNewReg_Click(sender As Object, e As EventArgs) Handles btnNewReg.Click
        If Not currentUser.hasPermision("engines") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmEngine
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not currentUser.hasPermision("eboxs") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmElectricBox
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not currentUser.hasPermision("ecounters") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmECounter
        frm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not currentUser.hasPermision("collectors") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmCollector
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not currentUser.hasPermision("packages") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmPackage
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not currentUser.hasPermision("clients") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmClient
        frm.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not currentUser.hasPermision("registrations") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmRegistration
        frm.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Not currentUser.hasPermision("workinghours") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmEngineWorkingHours
        frm.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Not currentUser.hasPermision("countershistory") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmCounterHistory
        frm.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Not currentUser.hasPermision("invoicesview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmInvoice
        frm.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not currentUser.hasPermision("ledger") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmExpenditure
        frm.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not isPaymentVerified Then
            MsgBox("لا يمكنك استخدام الكشف العام قبل تجديد عقد الصيانة")
            Return
        End If
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmCompanyReport
        frm.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If frmLogin.Visible = False Then
            frmLogin.Close()
        End If
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim frm As New frmNotes(ListView1.SelectedItems(0).SubItems(1).Text)
            If frm.ShowDialog =DialogResult.OK Then
                readNotes()
            End If
        End If
    End Sub

    Private Sub تعديلسعرالكيلواتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلسعرالكيلواتToolStripMenuItem.Click
        If Not currentUser.hasPermision("packagePriceEdit") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmChangeKiloPrice
        frm.ShowDialog()
    End Sub

    Private Sub استيرادمناكسيلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استيرادمناكسيلToolStripMenuItem.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmExcelImporter
        frm.ShowDialog()
    End Sub

    Private Sub تصحيحكسرالألفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تصحيحكسرالألفToolStripMenuItem.Click
        If Not currentUser.hasPermision("correctRoundvalue") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmCorrectRoundValue
        frm.ShowDialog()
    End Sub

    Private Sub إستيرادمنAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إستيرادمنAccessToolStripMenuItem.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmImportFromAccess
        frm.ShowDialog()
    End Sub

    Private Sub إستيرادمنAccessToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles إستيرادمنAccessToolStripMenuItem1.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            a.ExecuteNoReturn("Declare @collectorname varchar(50) Declare MYCURSOR Cursor LOCAL STATIC READ_ONLY FORWARD_ONLY FOR SELECT DISTINCT fullname FROM collector OPEN MYCURSOR FETCH NEXT FROM MYCURSOR INTO @collectorname WHILE @@FETCH_STATUS = 0 BEGIN FETCH NEXT FROM MYCURSOR INTO @collectorname UPDATE payment set collector = @collectorname from counterhistory ch,Registration r,ECounter ec,ElectricBox b,Collector c where payment.counterhistoryid=ch.id AND ch.regid=r.ID and r.counterid=ec.id and ec.boxid=b.id and b.collectorid=c.id and c.fullname= @collectorname; END CLOSE MYCURSOR DEALLOCATE MYCURSOR")
            MsgBox("تمت العمليّة بنجاح")
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint, Panel4.Paint, Panel3.Paint, Panel2.Paint, Panel1.Paint
        MyBase.OnPaint(e)
        Dim bc As Color = Color.FromArgb(160, 160, 160)
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, bc, 1, ButtonBorderStyle.Solid, bc, 1, ButtonBorderStyle.Solid, bc, 1, ButtonBorderStyle.Solid, bc, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm As New frmNotes(-1)
        If frm.ShowDialog() =DialogResult.OK Then
            readNotes()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Dim toRemove As New List(Of ListViewItem)
            For Each li As ListViewItem In ListView1.CheckedItems
                Dim selID As Integer = Integer.Parse(li.SubItems(1).Text)
                a.Execute("delete from Notes where ID=" & selID)
                toRemove.Add(li)
            Next
            For Each item As ListViewItem In toRemove
                ListView1.Items.Remove(item)
            Next
            readNotes()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        a.ds = New DataSet
        Try
            fillChart1()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
        a.ds = New DataSet
        Try
            fillChart2()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
        a.ds = New DataSet
        Try
            fillChart3()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
        Try
            fillStats()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try
    End Sub

    Private Sub خروجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles خروجToolStripMenuItem.Click
        frmLogin.Visible = True
        Me.Close()
    End Sub

    Private Sub المولداتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المولداتToolStripMenuItem.Click
        btnNewReg_Click(sender, e)
    End Sub

    Private Sub علبالكهرباءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles علبالكهرباءToolStripMenuItem.Click
        Button1_Click(sender, e)
    End Sub

    Private Sub عداداتالكهرباءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عداداتالكهرباءToolStripMenuItem.Click
        Button2_Click(sender, e)
    End Sub

    Private Sub ملفالجباتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ملفالجباتToolStripMenuItem.Click
        Button5_Click(sender, e)
    End Sub

    Private Sub انواعالاشتراكاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles انواعالاشتراكاتToolStripMenuItem.Click
        Button4_Click(sender, e)
    End Sub

    Private Sub ملفالزبائنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ملفالزبائنToolStripMenuItem.Click
        Button3_Click(sender, e)
    End Sub

    Private Sub الاشتراكاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الاشتراكاتToolStripMenuItem.Click
        Button11_Click(sender, e)
    End Sub

    Private Sub ساعاتالتغذيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ساعاتالتغذيةToolStripMenuItem.Click
        Button10_Click(sender, e)
    End Sub

    Private Sub ادخالالعداداتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ادخالالعداداتToolStripMenuItem.Click
        Button7_Click(sender, e)
    End Sub

    Private Sub كشفالفواتيرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles كشفالفواتيرToolStripMenuItem.Click
        Button9_Click(sender, e)
    End Sub

    Private Sub حسابالمؤسسةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حسابالمؤسسةToolStripMenuItem.Click
        Button8_Click(sender, e)
    End Sub

    Private Sub الكشفالعامToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الكشفالعامToolStripMenuItem.Click
        Button6_Click(sender, e)
    End Sub

    Private Sub حولالبرنامجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حولالبرنامجToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub أخذنسخةاحتياطيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles أخذنسخةاحتياطيةToolStripMenuItem.Click
        If Not currentUser.hasPermision("backup") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim dlg As New FolderBrowserDialog
        If dlg.ShowDialog =DialogResult.OK Then

            Dim backupQuery As String = "DECLARE @name VARCHAR(50) " & _
                                   " DECLARE @path VARCHAR(256) " & _
                                   " DECLARE @fileName VARCHAR(256) " & _
                                   " DECLARE @fileDate VARCHAR(20) " & _
                                   " " & _
                                   " SET @path = '" & dlg.SelectedPath & "\' " & _
                                   " " & _
                                   " SELECT @fileDate = CONVERT(VARCHAR(20),GETDATE(),112) " & _
                                   " " & _
                                   " DECLARE db_cursor CURSOR READ_ONLY FOR  " & _
                                   " Select Name" & _
                                   " FROM master.dbo.sysdatabases " & _
                                   " WHERE name IN ('EEMS')" & _
                                   " " & _
                                   " OPEN db_cursor   " & _
                                   " FETCH NEXT FROM db_cursor INTO @name   " & _
                                   " " & _
                                   " WHILE @@FETCH_STATUS = 0   " & _
                                   " BEGIN   " & _
                                   "    SET @fileName = @path + @name + '_' + @fileDate + '.BAK'  " & _
                                   "    BACKUP DATABASE @name TO DISK = @fileName  " & _
                                   " " & _
                                   "    FETCH NEXT FROM db_cursor INTO @name   " & _
                                   "                 End" & _
                                   " " & _
                                   " " & _
                                   " CLOSE db_cursor " & _
                                   " DEALLOCATE db_cursor"
            Try
                a.Execute(backupQuery)
                MsgBox("تمت العمليّة بنجاح")
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If

    End Sub


    Private Sub إضافةحسملمجموعةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةحسملمجموعةToolStripMenuItem.Click
        If Not currentUser.hasPermision("adddiscount") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmDiscountHandler
        frm.ShowDialog()
    End Sub

    Private Sub تغييركلمةالمرورToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تغييركلمةالمرورToolStripMenuItem.Click
        Dim frm As New frmChangePass
        frm.ShowDialog()
    End Sub

    Private Sub btnEditUsers_Click(sender As Object, e As EventArgs) Handles btnEditUsers.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmUsersManagement
        frm.ShowDialog()
    End Sub

    Private Sub إغلاقToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إغلاقToolStripMenuItem.Click
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub إعداداتعامةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إعداداتعامةToolStripMenuItem.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmGeneralSettings
        frm.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Not currentUser.hasPermision("inventoryManagement") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmItemsInventory
        frm.ShowDialog()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Not currentUser.hasPermision("FuelManagement") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmFuelInventory
        frm.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not currentUser.hasPermision("MaintenanceManagement") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmMaintenance
        frm.ShowDialog()
    End Sub

    Private Sub tmsLog_Click(sender As Object, e As EventArgs) Handles tmsLog.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        a.ds = New DataSet
        a.GetData("SELECT Top 10000 ID as [المعرّف],indate as [التاريخ],querystr as [التعديل],actiontype as [نوع التعديل],username as [المستخدم] FROM LogSet")

        Dim frm As New frmDataViewer("سجل التغيير", a.ds.Tables(0), False)
        frm.ShowDialog()
    End Sub

    Private Sub SQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLToolStripMenuItem.Click
        Dim tok As New frmTokenizer
        If tok.ShowDialog =DialogResult.OK Then
            If tok.tokenAccepted Then
                Dim frm As New frmSqlExecuter
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub tsmiInventory_Click(sender As Object, e As EventArgs) Handles tsmiInventory.Click
        Button12.PerformClick()
    End Sub

    Private Sub tsmiFuel_Click(sender As Object, e As EventArgs) Handles tsmiFuel.Click
        Button13.PerformClick()
    End Sub

    Private Sub tsmiMaintainance_Click(sender As Object, e As EventArgs) Handles tsmiMaintainance.Click
        Button14.PerformClick()
    End Sub

    Private Sub tmsClientAccountReport_Click(sender As Object, e As EventArgs) Handles tmsClientAccountReport.Click
        If Not currentUser.hasPermision("clients") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If Not currentUser.hasPermision("reportview") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm1 As New frmChooser(CLIENT_CHOOSER)
        If frm1.ShowDialog() =DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                Dim frm As New frmClientReport(frm1.dgvData.SelectedRows(0).Cells(0).Value, frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString)
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub tmsClientCreditDet_Click(sender As Object, e As EventArgs) Handles tmsClientCreditDet.Click
        If Not currentUser.hasPermision("clients") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frm As New frmClientsCreditDetails
        frm.ShowDialog()
    End Sub

    Private Sub طباعةالفواتيرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةالفواتيرToolStripMenuItem.Click
        If Not currentUser.hasPermision("invoicesprint") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frmdtp As New frmDateSelector
        If frmdtp.ShowDialog =DialogResult.OK Then
            Dim frmInvoicenote As New frmInvoiceNote
            Dim Month As Integer = frmdtp.dtp.Value.Month
            Dim Year As Integer = frmdtp.dtp.Value.Year
            Dim ar As New Helper
            ar.ds = New DataSet
            ar.GetData(frmInvoice.getInvoiceQueryForReport(False, Nothing, Month, Year, True), "dt")
            If ar.ds.Tables(0).Rows.Count = 0 Then
                MsgBox("لا يوجد فواتير لهذا الشهر لطباعتها")
                Return
            End If
            If frmInvoicenote.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim frm As New frmReportViewer(ar.ds.Tables("dt"), frmInvoicenote.TextBox1.Text.Trim, frmInvoicenote.verbose)
                frm.ShowDialog()
            End If
        End If

    End Sub

    Private Sub طباعةنموذجإدخالالعداداتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةنموذجإدخالالعداداتToolStripMenuItem.Click
        If Not currentUser.hasPermision("dataexport") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Dim frm As New frmEmptyCHPrint
        frm.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim validityChecker As New ValidityChecher
        Dim diff As Short = validityChecker.checkValidity
        If diff < 30 And diff > 0 Then
            If diff = 1 Then
                lblPayment.Text = "باقي يوم واحد على انتهاء عقد الصيانة."
            ElseIf diff < 11 Then
                lblPayment.Text = "باقي " & diff & " ايام " & "على انتهاء عقد الصيانة."
            ElseIf diff >= 11 Then
                lblPayment.Text = "باقي " & diff & " يوماً " & "عاى انتهاء عقد الصيانة."
            End If
            lblPayment.Visible = True
            MsgBox("الرجاء التواصل مع شركة الصيانة لتجديد عقد الصيانة خلال شهر كحد أقصى كي لا تخسر خدماتك المهمة")
        ElseIf diff <= 0 Then
            isPaymentVerified = False
            lblPayment.Text = "لقد انتهى عقد الصيانة، سيتم منعك عن بعض الخدمات الى حين التجديد"
            lblPayment.Visible = True
            MsgBox("لقد انتهى عقد الصيانة، سيتم منعك عن بعض الخدمات الى حين التجديد")
        End If
    End Sub

    Private Sub تجديدالخدمةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تجديدالخدمةToolStripMenuItem.Click
        Dim tok As New frmTokenizer
        If tok.ShowDialog =DialogResult.OK Then
            If tok.tokenAccepted Then
                Dim frm As New frmValidityRenual
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub اعادةتوليفالمصنعToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اعادةتوليفالمصنعToolStripMenuItem.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim tok As New frmTokenizer
        If tok.ShowDialog = DialogResult.OK Then
            If Not tok.tokenAccepted Then
                Return
            End If
        End If

        Dim msgdialog As New CustomMsgDialog("انتبه", "عند اعادة توليف المصنع ستفقد كامل البيانات، لذا ننصحك بأخذ نسخة احتياطيّة قبل المتابعة." & vbNewLine & vbNewLine & "هل أنت متأكد من أنك تريد المتابعة؟", 5)
        If msgdialog.ShowDialog = DialogResult.Yes Then
            Dim errorMsg As String = Nothing
            If (a.ExecuteInTransaction({
                                   "ALTER TABLE EngineWorkingHours DROP CONSTRAINT fk_EngineWorkingHours",
                                   "ALTER TABLE ElectricBox DROP CONSTRAINT fk_ElectricBoxEngine",
                                   "ALTER TABLE ElectricBox DROP CONSTRAINT fk_ElectricBoxCollector",
                                   "ALTER TABLE ECounter DROP CONSTRAINT fk_ECounterElectricBox",
                                   "ALTER TABLE Registration DROP CONSTRAINT fk_RegistrationECounter",
                                   "ALTER TABLE Registration DROP CONSTRAINT fk_RegistrationPackage",
                                   "ALTER TABLE Registration DROP CONSTRAINT fk_RegistrationClient",
                                   "ALTER TABLE CounterHistory DROP CONSTRAINT fk_CounterHistoryRegistration",
                                   "ALTER TABLE CounterHistory DROP CONSTRAINT fk_CounterHistoryArabicMonth",
                                   "ALTER TABLE Payment DROP CONSTRAINT fk_PaymentCounterHistory",
                                   "ALTER TABLE UserRoles DROP CONSTRAINT fk_UserRolesUsers",
                                   "ALTER TABLE UserRoles DROP CONSTRAINT fk_UserRolesRoles",
                                   "ALTER TABLE Purchases DROP CONSTRAINT fk_PurchasesItems",
                                   "ALTER TABLE Consumption DROP CONSTRAINT fk_ConsumptionItems",
                                   "ALTER TABLE FuelPurchases DROP CONSTRAINT fk_FuelPurchasesFuelTank",
                                   "ALTER TABLE FuelConsumption DROP CONSTRAINT fk_FuelConsumptionFuelTank",
                                   "ALTER TABLE FuelConsumption DROP CONSTRAINT fk_FuelConsumptionEngine",
                                   "ALTER TABLE Maintenance DROP CONSTRAINT fk_Maintenance",
                                   "TRUNCATE TABLE Client", "TRUNCATE TABLE Registration",
                                   "TRUNCATE TABLE Package", "TRUNCATE TABLE ECounter",
                                   "TRUNCATE TABLE ElectricBox", "TRUNCATE TABLE Collector",
                                   "TRUNCATE TABLE FuelPurchases", "TRUNCATE TABLE FuelConsumption",
                                   "TRUNCATE TABLE FuelTank", "TRUNCATE TABLE Maintenance",
                                   "TRUNCATE TABLE EngineWorkingHours", "TRUNCATE TABLE Engine",
                                   "TRUNCATE TABLE Payment", "TRUNCATE TABLE CounterHistory",
                                   "TRUNCATE TABLE Items", "TRUNCATE TABLE Consumption",
                                   "TRUNCATE TABLE Purchases", "TRUNCATE TABLE LogSet",
                                   "TRUNCATE TABLE ChangeLog", "TRUNCATE TABLE CounterHistory",
                                   "TRUNCATE TABLE Expenditure",
                                   "ALTER TABLE EngineWorkingHours ADD CONSTRAINT fk_EngineWorkingHours FOREIGN KEY (engineid) REFERENCES Engine(ID)",
                                   "ALTER TABLE ElectricBox ADD CONSTRAINT fk_ElectricBoxEngine FOREIGN KEY (engineid) REFERENCES Engine(ID)",
                                   "ALTER TABLE ElectricBox ADD CONSTRAINT fk_ElectricBoxCollector FOREIGN KEY (collectorid) REFERENCES Collector(ID)",
                                   "ALTER TABLE ECounter ADD CONSTRAINT fk_ECounterElectricBox FOREIGN KEY (boxid) REFERENCES ElectricBox(ID)",
                                   "ALTER TABLE Registration ADD CONSTRAINT fk_RegistrationECounter FOREIGN KEY (counterid) REFERENCES ECounter(ID)",
                                   "ALTER TABLE Registration ADD CONSTRAINT fk_RegistrationPackage FOREIGN KEY (packageid) REFERENCES Package(ID)",
                                   "ALTER TABLE Registration ADD CONSTRAINT fk_RegistrationClient FOREIGN KEY (clientid) REFERENCES Client(ID)",
                                   "ALTER TABLE CounterHistory ADD CONSTRAINT fk_CounterHistoryRegistration FOREIGN KEY (regid) REFERENCES Registration(ID)",
                                   "ALTER TABLE CounterHistory ADD CONSTRAINT fk_CounterHistoryArabicMonth FOREIGN KEY (cmonth) REFERENCES ArabicMonth(ID)",
                                   "ALTER TABLE Payment ADD CONSTRAINT fk_PaymentCounterHistory FOREIGN KEY (counterhistoryid) REFERENCES CounterHistory(ID)",
                                   "ALTER TABLE UserRoles ADD CONSTRAINT fk_UserRolesUsers FOREIGN KEY (username) REFERENCES Users(username)",
                                   "ALTER TABLE UserRoles ADD CONSTRAINT fk_UserRolesRoles FOREIGN KEY (rolename) REFERENCES Roles(rolename)",
                                   "ALTER TABLE Purchases ADD CONSTRAINT fk_PurchasesItems FOREIGN KEY (itemid) REFERENCES Items(ID)",
                                   "ALTER TABLE Consumption ADD CONSTRAINT fk_ConsumptionItems FOREIGN KEY (itemid) REFERENCES Items(ID)",
                                   "ALTER TABLE FuelPurchases ADD CONSTRAINT fk_FuelPurchasesFuelTank FOREIGN KEY (tankid) REFERENCES FuelTank(ID)",
                                   "ALTER TABLE FuelConsumption ADD CONSTRAINT fk_FuelConsumptionFuelTank FOREIGN KEY (tankid) REFERENCES FuelTank(ID)",
                                   "ALTER TABLE FuelConsumption ADD CONSTRAINT fk_FuelConsumptionEngine FOREIGN KEY (engineid) REFERENCES Engine(ID)",
                                   "ALTER TABLE Maintenance ADD CONSTRAINT fk_Maintenance FOREIGN KEY (engineid) REFERENCES Engine(ID)"
                                   }.ToList(), errorMsg)) Then
                MessageBox.Show("تمت العمليّة بنجاح، سيتم اغلاق البرنامج.")
                Application.Restart()
            Else
                MessageBox.Show("فشلت محاولة اعادة توليف المصنع" & vbNewLine & vbNewLine & errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub كسرواتماقبلالبرنامجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles كسرواتماقبلالبرنامجToolStripMenuItem.Click
        If Not currentUser.hasPermision("admin") Then
            MessageBox.Show("ليس لديك صلاحيّة للمتابعة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim frm As New frmPreRegistrationCredits
        frm.ShowDialog()

    End Sub
End Class