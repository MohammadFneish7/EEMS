Public Class CustomMsgDialog

    Dim optionselected As Boolean = False
    Dim readTimeHere As Int16 = 0

    Sub New(title As String, msg As String, Optional readTime As Int16 = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = title
        Label1.Text = msg

        If readTime > 0 Then
            readTimeHere = readTime
            Timer1.Enabled = True
            lbl1.Text = readTimeHere
        Else
            lbl1.Visible = False
            lbl2.Visible = False
            btnYes.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        optionselected = True
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        optionselected = True
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub CustomMsgDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not optionselected Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If readTimeHere = 0 Then
            lbl1.Visible = False
            lbl2.Visible = False
            Timer1.Enabled = False
            Return
        End If
        readTimeHere = readTimeHere - 1
        lbl1.Text = readTimeHere
        If readTimeHere = 0 Then
            btnYes.Enabled = True
        End If
    End Sub
End Class