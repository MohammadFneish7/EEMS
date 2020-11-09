Imports EEMS.SqlDBHelper

Public Class frmECounterEditor
    Dim id As Integer = -2
    Dim add As Boolean = False
    Dim a As New Helper
    Dim counterCurrentVal As Integer = 0

    Dim letters() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim values() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim lettersList As List(Of String) = letters.ToList

    Sub New(id As Integer, add As Boolean, currentvalue As Integer)
        InitializeComponent()
        Me.id = id
        Me.add = add
        counterCurrentVal = currentvalue
        If add = False Then
            If id < 0 Then
                MsgBox("خطأ في رقم الملف.")
                Me.DialogResult = DialogResult.Ignore
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If add = False Then
            loadData()
            'txtBoxID.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If checkEmpty() Then
            MsgBox("الرجاء التأكد من تعبئة جميع الخانات المطلوبة.")
            Return
        Else
            a.ds = New DataSet
            If add Then
                Dim count As Integer = a.ExecuteScalar("Select count(*) from ECounter e where e.serial='" & txtserial.Text.Trim & "'")
                If count > 0 Then
                    MsgBox("رقم العداد موجود أصلا، الرجاء إدخال رقم أخر للمتابعة")
                    Return
                End If
                a.GetData("select * from ECounter c where c.boxid=" & txtBoxID.Text.Trim & " and c.code='" & cmbcode.SelectedItem.ToString & "'")
            Else
                a.GetData("select * from ECounter c where c.boxid=" & txtBoxID.Text.Trim & " and c.code='" & cmbcode.SelectedItem.ToString & "' and c.ID <>" & id)
            End If
            If a.ds.Tables(0).Rows.Count > 0 Then
                MsgBox(" محجوز من قبل عداد آخر في نفس العلبة" & cmbcode.SelectedItem.ToString & "الرمز " & vbNewLine & "الرجاء اختيار رمز آخر.")
                Return
            End If
        End If
        If add = False Then
            a.Execute("Update ECounter Set serial='" & txtserial.Text.Trim & "',code='" & cmbcode.SelectedItem & "',boxid=" & txtBoxID.Text.Trim & ",currentvalue=" & txtcurrentval.Text.Trim & ",active=" & getBit(chkactive.Checked) & ",notes='" & txtnotes.Text.Trim & "' Where ID=" & id)
        Else
            Dim iid As Integer = a.Execute("insert into ECounter(serial,code,boxid,active,currentvalue,notes) values('" & txtserial.Text.Trim & "','" & cmbcode.SelectedItem & "'," & txtBoxID.Text.Trim & "," & getBit(chkactive.Checked) & "," & txtcurrentval.Text.Trim & ",'" & txtnotes.Text.Trim & "')")
        End If

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("SELECT b.ID as [معرّف العلبة],b.code as [رمز العلبة],c.serial as [رقم العداد],c.code as [الرمز في العلبة],active as [مفعّل], isNull(c.currentvalue,0),c.notes as ملاحظات FROM ECounter c,ElectricBox b where c.boxid = b.id and c.ID= " & id)
            txtBoxID.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            txtBoxCode.Text = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtserial.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            cmbcode.Items.Add(a.ds.Tables(0).Rows(0).Item(3).ToString)
            cmbcode.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            chkactive.Checked = Boolean.Parse(a.ds.Tables(0).Rows(0).Item(4).ToString)
            chknotactive.Checked = Not Boolean.Parse(a.ds.Tables(0).Rows(0).Item(4).ToString)
            txtcurrentval.Text = a.ds.Tables(0).Rows(0).Item(5).ToString
            txtnotes.Text = a.ds.Tables(0).Rows(0).Item(6).ToString
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult = DialogResult.Ignore

        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txtserial.Text.Trim.Length = 0 OrElse cmbcode.SelectedIndex = -1 OrElse txtBoxID.Text.Trim.Length = 0 OrElse txtcurrentval.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Ignore

    End Sub


    Private Sub txtBoxID_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtBoxID.DoubleClick
        Dim frm1 As New frmChooser(BOX_CHOOSER)
        If frm1.ShowDialog() = DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                txtBoxID.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtBoxCode.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtBoxCode.Select()
            End If
        End If
    End Sub


    Private Sub txtBoxID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxID.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtBoxID_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        a.bindNumeric(sender, e)
    End Sub

    Private Sub ECounterEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub txtBoxID_TextChanged(sender As Object, e As EventArgs) Handles txtBoxID.TextChanged
        If txtBoxID.Text.Trim.Length > 0 Then
            Try
                Dim bid As Integer = txtBoxID.Text.Trim
                If add = True Then
                    a.ds = New DataSet
                End If
                a.GetData("select distinct code from ECounter where boxid = " & bid, "dt7")
                Dim usedLetters As New List(Of String)
                For Each row As DataRow In a.ds.Tables("dt7").Rows
                    usedLetters.Add(row.Item(0))
                Next
                cmbcode.Items.Clear()

                For Each s As String In lettersList
                    If usedLetters.IndexOf(s.ToUpper.Trim) = -1 Then
                        cmbcode.Items.Add(s.Trim.ToUpper)
                    End If
                Next
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("هل انت متأكد من اصدار سيريال جديد للعداد؟", "EEMS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.OK Then
            txtserial.Text = DateTime.Now.Ticks
        End If

    End Sub

    Private Sub txtcurrentval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcurrentval.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub btneditval_Click(sender As Object, e As EventArgs) Handles btneditval.Click
        Dim tok As New frmTokenizer
        If tok.ShowDialog = DialogResult.OK Then
            If tok.tokenAccepted Then
                txtcurrentval.Enabled = True
                btneditval.Enabled = False
            End If
        End If
    End Sub
End Class
