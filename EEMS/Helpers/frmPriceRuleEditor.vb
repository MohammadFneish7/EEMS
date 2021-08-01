Imports EEMS.SqlDBHelper
Public Class frmPriceRuleEditor
    Dim ruleClosed As Boolean = False
    Public rule As String = String.Empty
    Dim a As New Helper

    Public Sub New(rule_ As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cmbeq.SelectedIndex = 0

        If Not String.IsNullOrWhiteSpace(rule_) Then
            Dim name As String = rule_.Split(":")(0)
            Dim rules As String() = rule_.Split(":")(1).Split(",")

            If rules.Count = 1 Then
                ListBox1.Items.Add(cmbeq.Items(2) & " " & rules(0) & " ل.ل")
            End If

            Dim rprice As Integer = 0
            Dim rlimit As Integer = 0
            For Each r As String In rules
                If r.Contains("<") Then
                    Dim rvalues As String() = r.Split("<")
                    rprice = Integer.Parse(rvalues(0))
                    rlimit = Integer.Parse(rvalues(1))
                    ListBox1.Items.Add(cmbeq.Items(0) & " " & rlimit & " KW = " & rprice & " ل.ل")
                Else
                    ListBox1.Items.Add(cmbeq.Items(1) & " " & rlimit & " KW = " & r & " ل.ل")
                    Exit For
                End If
            Next

            ruleClosed = True
            btnAdd.Enabled = False
            rule = rule_.Split(":")(1)
            TextBox1.Text = name
            toggleSave()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
        ruleClosed = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        rule = String.Empty
    End Sub

    Private Sub cmbeq_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbeq.SelectedValueChanged
        If ruleClosed Then
            btnAdd.Enabled = False
            Return
        Else
            btnAdd.Enabled = True
        End If

        If cmbeq.SelectedIndex = 0 Then
            txtkilolimit.Enabled = True
        ElseIf cmbeq.SelectedIndex = 1 Then
            txtkilolimit.Enabled = True
        ElseIf cmbeq.SelectedIndex = 2 Then
            txtkilolimit.Enabled = False
            If ListBox1.Items.Count <> 0 Then
                btnAdd.Enabled = False
            Else
                btnAdd.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbeq.SelectedIndex = 0 Then
            ListBox1.Items.Add(cmbeq.SelectedItem & " " & txtkilolimit.Text & " KW = " & txtKiloPrice.Text & " ل.ل")
            rule &= txtKiloPrice.Text & "<" & txtkilolimit.Text & ","
            btnSave.Enabled = False
        ElseIf cmbeq.SelectedIndex = 1 Then
            ListBox1.Items.Add(cmbeq.SelectedItem & " " & txtkilolimit.Text & " KW = " & txtKiloPrice.Text & " ل.ل")
            rule &= txtKiloPrice.Text
            ruleClosed = True
            toggleSave()
        ElseIf cmbeq.SelectedIndex = 2 Then
            ListBox1.Items.Add(cmbeq.SelectedItem & " " & txtKiloPrice.Text & " ل.ل")
            rule &= txtKiloPrice.Text
            ruleClosed = True
            toggleSave()
        End If
    End Sub

    Private Sub toggleSave()
        If ruleClosed = True And (Not TextBox1.Text Is Nothing) And TextBox1.Text.Trim.Length > 0 And TextBox1.Text.Contains(":") = False And TextBox1.Text.Contains("<") = False Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        rule = TextBox1.Text.Trim & rule
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        toggleSave()
    End Sub

    Private Sub txtkilolimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKiloPrice.KeyPress, txtkilolimit.KeyPress
        a.bindNumeric(sender, e)
    End Sub
End Class