Imports EEMS.SqlDBHelper

Public Class frmElectricBoxEditor
    Dim id As Integer = -2
    Dim add As Boolean = False
    Dim a As New Helper
    Dim letters() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim values() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim lettersList As List(Of String) = letters.ToList


    Sub New(id As Integer, Optional add As Boolean = False)
        InitializeComponent()
        Me.id = id
        Me.add = add
        If add = False Then
            txtEngine.Enabled = False
            txtengineid.Enabled = False
            txtenginename.Enabled = False
            txtcode.Width = txtaddress.Width
            txtcode.Enabled = False
            If id < 0 Then
                MsgBox("خطأ في رقم الملف.")
                Me.DialogResult = DialogResult.Ignore
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If add = False Then
            loadData()
        Else
            'a.ds = New DataSet
            'a.GetData("Select eb.id,label from ElectricBox eb inner join engine e on eb.engineid=e.id")
            'For Each row As DataRow In a.ds.Tables(0).Rows
            '    Dim s As Int32 = row.Item(0).ToString
            '    Dim s2 As String = row.Item(1).ToString
            '    Dim i As Int32 = lettersList.IndexOf(s2)
            '    values(i) = values(i) + 1

            '    a.Execute("update electricbox set code ='" & s2 & "-" & values(i) & "' where id=" & row.Item(0))
            'Next

            a.ds = New DataSet
            a.GetData("Select distinct code from ElectricBox")
            For Each row As DataRow In a.ds.Tables(0).Rows
                Try
                    Dim s As String = row.Item(0).ToString
                    Dim i As Integer = lettersList.IndexOf(s.Substring(0, 1).Trim.ToUpper)
                    If i > -1 Then
                        Dim val As Integer = Integer.Parse(s.Substring(2, s.Length - 2))
                        If val > values(i) Then
                            values(i) = val
                        End If
                    End If
                Catch ex As Exception
                    ErrorDialog.showDlg(ex)
                End Try
            Next
        End If

        'Dim disabledCellStyle As New DataGridViewCellStyle
        'disabledCellStyle.BackColor = Color.LightGray

        'For Each col As DataGridViewColumn In dgvdata.Columns
        '    If dgvdata.Columns.IndexOf(col) <> 3 Then
        '        col.ReadOnly = True
        '        col.DefaultCellStyle = disabledCellStyle
        '    End If
        'Next

        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = dgvdata.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvdata, True, Nothing)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If checkEmpty() Then
            MsgBox("الرجاء التأكد من تعبئة جميع الخانات المطلوبة.")
            Return
        End If
        If add = False Then
            a.Execute("Update ElectricBox Set code='" & txtEngine.Text.Trim & "-" & txtcode.Text.Trim & "',location='" & txtaddress.Text.Trim & "',collectorid='" & txtcollectorid.Text.Trim & "',engineid='" & txtengineid.Text.Trim & "',notes='" & txtnotes.Text.Trim & "' Where ID=" & id)
            For Each row As DataGridViewRow In dgvdata.Rows
                a.Execute("Update ECounter set active = " & getBit(row.Cells(3).Value.ToString) & " where ID=" & row.Cells(0).Value.ToString)
            Next
        Else
            a.ds = New DataSet
            Dim i As Long = a.ExecuteScalar("select count(id) from electricbox where code='" & txtEngine.Text.Trim & "-" & txtcode.Text.Trim & "'")
            If i > 0 Then
                MsgBox("رمز العلبة الذي تم اختياره موجود اصلا.")
                Return
            End If
            a.Execute("insert into ElectricBox(code,location,collectorid,engineid,notes) values('" & txtEngine.Text.Trim & "-" & txtcode.Text.Trim & "','" & txtaddress.Text.Trim & "','" & txtcollectorid.Text.Trim & "','" & txtengineid.Text.Trim & "','" & txtnotes.Text.Trim & "')")
        End If

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("Select code as الرمز,b.location as العنوان,collectorid as [معرّف الجابي],fullname as [اسم الجابي],engineid as [معرّف المحرّك],ename as [اسم المحرّك],b.notes as ملاحظات FROM ElectricBox b,Engine e,Collector c where b.engineid = e.id and b.collectorid=c.id and b.ID = " & id)
            txtcode.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            txtaddress.Text = a.ds.Tables(0).Rows(0).Item(1).ToString
            txtcollectorid.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtcollectorname.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            txtengineid.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
            txtenginename.Text = a.ds.Tables(0).Rows(0).Item(5).ToString
            txtnotes.Text = a.ds.Tables(0).Rows(0).Item(6).ToString
            a.GetData("SELECT ID as المعرّف,serial as [رقم العداد],code as [الرمز في العلبة],active as [مفعّل],notes as ملاحظات FROM ECounter where boxid=" & id, "dt2")
            dgvdata.DataSource = a.ds.Tables("dt2")
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            ErrorDialog.showDlg(ex)
            Me.DialogResult = DialogResult.Ignore

        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If txtcode.Text.Trim.Length = 0 OrElse txtaddress.Text.Trim.Length = 0 OrElse txtcollectorid.Text.Trim.Length = 0 OrElse txtengineid.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Ignore

    End Sub


    Private Sub txtcollectorid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcollectorid.MouseDoubleClick
        Dim frm1 As New frmChooser(COLLECTOR_CHOOSER)
        If frm1.ShowDialog() = DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                txtcollectorid.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtcollectorname.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtcollectorname.Select()
            End If
        End If
    End Sub

    Private Sub txtengineid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtengineid.MouseDoubleClick
        Dim frm1 As New frmChooser(ENGINE_CHOOSER)
        If frm1.ShowDialog() = DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                txtengineid.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtEngine.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtenginename.Text = frm1.dgvData.SelectedRows(0).Cells(2).Value.ToString
                txtcode.Enabled = True
                txtcode.Select()
                Try
                    Dim i As Integer = lettersList.IndexOf(txtEngine.Text.Trim)
                    If i > -1 Then
                        lblletter.Text = letters(i) & values(i)
                    End If
                Catch ex As Exception
                    lblletter.ResetText()
                End Try
            End If
        End If
    End Sub

    Private Sub txtcollectorid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcollectorid.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtcollectorid_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtengineid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtengineid.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtengineid_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub ElectricBoxEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub txtcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcode.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub txtEngine_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtEngine.MouseDoubleClick
        txtengineid_MouseDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub txtEngine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEngine.KeyPress
        txtengineid_MouseDoubleClick(Nothing, Nothing)
    End Sub
End Class
