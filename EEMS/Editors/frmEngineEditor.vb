Imports EEMS.SqlDBHelper

Public Class frmEngineEditor

    Dim id As Integer = -2
    Dim add As Boolean = False
    Dim a As New Helper
    Sub New(id As Integer, Optional add As Boolean = False)
        InitializeComponent()
        Me.id = id
        Me.add = add
        If add = False Then
            If id < 0 Then
                MsgBox("خطأ في رقم الملف.")
                Me.DialogResult = Windows.Forms.DialogResult.Ignore
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If add = False Then
            loadData()
        Else
            Dim letters() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
            Dim lettersList As List(Of String) = letters.ToList
            a.GetData("select distinct label from Engine", "dt7")
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

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If checkEmpty() Then
            MsgBox("الرجاء التأكد من تعبئة جميع الخانات المطلوبة.")
            Return
        End If
        If add = False Then
            a.Execute("Update Engine Set ename='" & txtname.Text.Trim & "',location='" & txtaddress.Text.Trim & "',epower=" & txtpower.Text.Trim & ",company='" & txtCompany.Text.Trim & "',contactphone='" & txtphone.Text.Trim & "',repairparty='" & txtrepairer.Text.Trim & "',notes='" & txtnotes.Text.Trim & "' Where ID=" & id)
        Else
            Dim count As Integer = a.ExecuteScalar("Select count(*) from Engine e where e.ename='" & txtname.Text.Trim & "'")
            If count > 0 Then
                MsgBox("اسم المولد موجود أصلا، الرجاء إختيار اسم أخر للمتابعة")
                Return
            End If
            a.Execute("insert into Engine(ename,label,location,epower,company,contactphone,repairparty,notes) values('" & txtname.Text.Trim & "','" & cmbcode.SelectedItem.ToString.Trim & "','" & txtaddress.Text.Trim & "'," & txtpower.Text.Trim & ",'" & txtCompany.Text.Trim & "','" & txtphone.Text.Trim & "','" & txtrepairer.Text.Trim & "','" & txtnotes.Text.Trim & "')")
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub loadData()
        Try
            a.ds = New DataSet
            a.GetData("Select ename as الاسم,label as رمز,location as العنوان,epower as القوّة,company as [الماركة/الشركة],contactphone as الهاتف,repairparty as [جهة الصيانة],notes as ملاحظات FROM Engine where ID = " & id)
            txtname.Text = a.ds.Tables(0).Rows(0).Item(0).ToString
            cmbcode.Items.Add(a.ds.Tables(0).Rows(0).Item(1).ToString)
            txtaddress.Text = a.ds.Tables(0).Rows(0).Item(2).ToString
            txtpower.Text = a.ds.Tables(0).Rows(0).Item(3).ToString
            txtCompany.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
            txtphone.Text = a.ds.Tables(0).Rows(0).Item(5).ToString
            txtrepairer.Text = a.ds.Tables(0).Rows(0).Item(6).ToString
            txtnotes.Text = a.ds.Tables(0).Rows(0).Item(7).ToString

            cmbcode.SelectedIndex = 0
            cmbcode.Enabled = False
        Catch ex As Exception
            MsgBox("خطأ اثناء محاولة تحميل البيانات.")
            Me.DialogResult = Windows.Forms.DialogResult.Ignore

        End Try
    End Sub

    Private Function checkEmpty() As Boolean
        If cmbcode.SelectedIndex < 0 OrElse txtname.Text.Trim.Length = 0 OrElse txtaddress.Text.Trim.Length = 0 OrElse txtpower.Text.Trim.Length = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore

    End Sub

    Private Sub EngineEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub txtpower_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpower.KeyPress
        a.bindNumeric(sender, e)
    End Sub
End Class
