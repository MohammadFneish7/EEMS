Imports EEMS.SqlDBHelper

Public Class frmNotes

    Dim a As New Helper
    Dim noteID As Integer = -1
    Sub New(id As Integer)
        InitializeComponent()
        ComboBox1.SelectedIndex = 0
        noteID = id
    End Sub
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today
        txtHours.Text = Date.Now.ToString("HH")
        txtMinutes.Text = Date.Now.ToString("mm")
        If noteID > -1 Then
            Try
                a.ds = New DataSet
                a.GetData("select * from Notes where ID = " & noteID)
                DateTimePicker1.Value = a.ds.Tables(0).Rows(0).Item(1)
                txtHours.Value = Integer.Parse(Date.Parse(a.ds.Tables(0).Rows(0).Item(2).ToString).Hour)
                txtMinutes.Value = Integer.Parse(Date.Parse(a.ds.Tables(0).Rows(0).Item(2).ToString).Minute)
                ComboBox1.SelectedItem = a.ds.Tables(0).Rows(0).Item(3).ToString
                TextBox1.Text = a.ds.Tables(0).Rows(0).Item(4).ToString
            Catch ex As Exception
                MsgBox("فشلت العمليّة" & vbNewLine & ex.Message)
            End Try
        End If
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Or TextBox1.Text.Trim.Length = 0 Then
            MsgBox("تأكد من ملئ جميع الخانات المرمّزة بالأحمر للمتابعة.")
        Else
            Dim time As New DateTime
            Dim dtime As String = DateTimePicker1.Value.ToShortDateString & " " & txtHours.Value.ToString & ":" & txtMinutes.Value.ToString
            time = Date.Parse(dtime)
            Try
                If noteID = -1 Then
                    a.Execute("INSERT INTO Notes(ExpiryDate,ExpiryTime,nstatus,NoteDetail,username) values('" & DateTimePicker1.Value & "','" & time & "','" & ComboBox1.SelectedItem & "','" & TextBox1.Text & "','" & SharedModule.currentUser.getUsername.Trim.ToLower & "')")
                Else
                    a.Execute("update Notes set ExpiryDate='" & DateTimePicker1.Value & "',ExpiryTime='" & time & "',nstatus='" & ComboBox1.SelectedItem & "',NoteDetail='" & TextBox1.Text & "' where ID = " & noteID)
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgBox("فشلت العمليّة" & vbNewLine & "تفصيل المذكّرة لا يمكن ان يحتوي على رموز خاصّة.")
            End Try

        End If
    End Sub

    Private Sub frmNotes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub
End Class