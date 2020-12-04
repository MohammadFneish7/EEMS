Imports EEMS.SqlDBHelper

Public Class frmChooser

    Dim bs As New BindingSource
    Dim options As Integer
    Dim recievedParam As Integer = 0
    Dim a As New Helper

    Sub New(_options As Integer, Optional ByVal param As Integer = 0)
        options = _options
        recievedParam = param
        InitializeComponent()
    End Sub
    Private Sub frmChooseClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvData.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvData, True, Nothing)
        End If
        a.ds = New DataSet
        If options = ENGINE_CHOOSER Then
            Me.Text = "اختيار المولّد"
            Me.GroupBox1.Text = "اختر المولّد"
            a.GetData("Select ID as المعرّف,label as الرمز,ename as الاسم,location as العنوان,epower as القوّة,company as [الماركة/الشركة],contactphone as الهاتف,repairparty as [جهة الصيانة],notes as ملاحظات FROM Engine")
        ElseIf options = COLLECTOR_CHOOSER Then
            Me.Text = "اختيار الجابي"
            Me.GroupBox1.Text = "اختر الجابي"
            a.GetData("Select ID as المعرّف,fullname as [الاسم الثلاثي],caddress as العنوان,phone as الهاتف,mobile as الخليوي,notes as ملاحظات FROM Collector")
        ElseIf options = CLIENT_CHOOSER Then
            Me.Text = "اختيار المشترك"
            Me.GroupBox1.Text = "اختر المشترك"
            a.GetData("SELECT ID as [معرّف المشترك],clientname as [الاسم الثلاثي],clientnickname AS [اللقب],clientmothername AS [اسم الام],caddress AS [العنوان],phone AS [الهاتف],mobile AS [الخليوي] FROM Client")
        ElseIf options = BOX_CHOOSER Then
            Me.Text = "اختيار العلبة"
            Me.GroupBox1.Text = "اختر العلبة"
            a.GetData("Select b.ID as المعرّف,code as الرمز,b.location as العنوان,fullname as [اسم الجابي],ename as [اسم المحرّك],b.notes as ملاحظات FROM ElectricBox b,Engine e,Collector c where b.engineid = e.id and b.collectorid=c.id")
        ElseIf options = COUNTER_ACTIVE_CHOOSER Then
            Me.Text = "اختيار العدّاد"
            Me.GroupBox1.Text = "اختر العدّاد"
            a.GetData("SELECT c.ID as المعرّف,c.serial as [رقم العداد],c.code as [الرمز في العلبة],b.code as [رمز العلبة],b.location as [عنوان العلبة],active as [مفعّل], currentvalue as [القيمة الحاليّة], c.notes as ملاحظات FROM ECounter c,ElectricBox b where c.boxid = b.id")
        ElseIf options = COUNTER_NOT_ACTIVE_CHOOSER Then
            Me.Text = "اختيار العدّاد الشاغر"
            Me.GroupBox1.Text = "اختر عدّاد من العدّادات الشاغرة ادناه"
            a.GetData("SELECT c.ID as المعرّف,c.serial as [رقم العداد],c.code as [الرمز في العلبة],b.code as [رمز العلبة],b.location as [عنوان العلبة],active as [مفعّل], currentvalue as [القيمة الحاليّة],c.notes as ملاحظات FROM ECounter c,ElectricBox b where c.boxid = b.id AND c.active = 0")
        ElseIf options = PACKAGE_CHOOSER Then
            Me.Text = "اختيار الاشتراك"
            Me.GroupBox1.Text = "اختر الاشتراك"
            a.GetData("SELECT ID as المعرّف,title as امبير,fee as [اشتراك شهري],insurance as [مبلغ التأمين],kilowattprice as [سعر الكيلو وات] FROM Package")
        ElseIf options = REGISTRATION_CHOOSER Then
            Me.Text = "اختيار الاشتراك"
            Me.GroupBox1.Text = "اختر الاشتراك"
            a.GetData("Select r.ID as [المعرّف],c.clientname as [اسم المشترك],p.ampere as [اشتراك امبير],r.active as [مفعّل],r.insurance as [مبلغ التأمين] from Package p JOIN Registration r ON r.packageid=p.ID  JOIN Client c ON r.clientid=c.id order by r.active")
        ElseIf options = BULK_DISCOUNT_CHOOSER Then
            Me.Text = "اختيار اللائحة"
            Me.GroupBox1.Text = "اختر اللائحة"
            a.GetData("Select title as [اسم اللائحة] from DefinedKeys where reference = 'discoutSelections'")
        ElseIf options = ITEM_CHOOSER Then
            Me.Text = "اختيار الصنف"
            Me.GroupBox1.Text = "اختر الصنف"
            a.GetData("SELECT i.ID as [المعرّف], i.itemname as [الصنف]," & _
                     " ((SELECT isnull(sum(p.quantity),0) from purchases p where p.itemid = i.id) - (SELECT isnull(sum(c.quantity),0) from consumption c where c.itemid = i.id)) as [باقي في المخزن]," & _
                     " i.quantityThreshold as [عتبة الكمّيّة] from Items i ")
        ElseIf options = TANK_CHOOSER Then
            Me.Text = "اختيار الخزّان"
            Me.GroupBox1.Text = "اختر الخزّان"
            a.GetData("SELECT ft.ID as [المعرف],tankName as [اسم الخزّان],location as [الموقع],capacity as [السعة], " & _
                    " ((SELECT isnull(sum(fp.quantity),0) from fuelpurchases fp where fp.tankid = ft.id) " & _
                    " - (SELECT isnull(sum(fc.quantity),0) from  fuelconsumption fc where fc.tankid = ft.id)) as [باقي في الخزّان / لتر], " & _
                    "  ft.Notes as [ملاحظات] FROM FuelTank ft ")
        End If
        bs.DataSource = a.ds.Tables(0)
        dgvData.DataSource = bs
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If options = ENGINE_CHOOSER Then
                bs.Filter = "الاسم LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = COLLECTOR_CHOOSER Then
                bs.Filter = "[الاسم الثلاثي] LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = CLIENT_CHOOSER Then
                bs.Filter = "[الاسم الثلاثي] LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = BOX_CHOOSER Then
                bs.Filter = "الرمز LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = COUNTER_ACTIVE_CHOOSER Then
                bs.Filter = "[رمز العلبة] LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = COUNTER_NOT_ACTIVE_CHOOSER Then
                bs.Filter = "[رمز العلبة] LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = PACKAGE_CHOOSER Then
                bs.Filter = "امبير LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = REGISTRATION_CHOOSER Then
                bs.Filter = "[اسم المشترك] LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = BULK_DISCOUNT_CHOOSER Then
                bs.Filter = "[اسم اللائحة] LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = ITEM_CHOOSER Then
                bs.Filter = "[اسم الصنف] LIKE '%" & TextBox1.Text & "%'"
            ElseIf options = TANK_CHOOSER Then
                bs.Filter = "[اسم الخزّان] LIKE '%" & TextBox1.Text & "%'"
            End If
        Catch ex As Exception
            bs.RemoveFilter()
            TextBox1.Clear()
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult =DialogResult.OK
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseDoubleClick
        Me.DialogResult =DialogResult.OK
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles dgvData.KeyPress
        If AscW(e.KeyChar) = 13 Then
            Me.DialogResult =DialogResult.OK
        End If
    End Sub

    Private Sub frmChooser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub
End Class