Imports EEMS.SqlDBHelper

Public Class frmGeneralSettings

    Dim a As New Helper
    Dim selectionKeyReference As String = "settings"

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        cmblang.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
        ' Add any initialization after the InitializeComponent() call.
        a.ds = New DataSet
        a.GetData("select dkey,title from DefinedKeys where reference='" & selectionKeyReference.ToLower & "'")
        For Each dr As DataRow In a.ds.Tables(0).Rows
            If dr.Item(0).ToString.Trim.ToLower.Equals("orgname") Then
                txtname.Text = dr.Item(1).ToString.Trim.ToLower
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("note1") Then
                txtnote1.Text = dr.Item(1).ToString.Trim.ToLower
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("note2") Then
                txtnote2.Text = dr.Item(1).ToString.Trim.ToLower
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("note3") Then
                txtnote3.Text = dr.Item(1).ToString.Trim.ToLower
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("invoiceyoffset") Then
                NumericUpDown1.Value = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("invoicexoffset") Then
                NumericUpDown2.Value = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("dollarprice") Then
                numDollar.Value = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            ElseIf dr.Item(0).ToString.Trim.ToLower.Equals("roundtothousand") Then
                ComboBox1.SelectedIndex = Integer.Parse(dr.Item(1).ToString.Trim.ToLower)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtname.Text.Trim.Length = 0 Then
                MsgBox("الرجاء التأكد من ادخال اسم للمؤسسة.")
                Return
            End If

            a.ExecuteNoReturn("delete from DefinedKeys where reference='" & selectionKeyReference.ToLower & "'")
            a.ExecuteNoReturn("insert into DefinedKeys (dkey,title,reference) values('orgname','" & txtname.Text.Trim & "','" & selectionKeyReference.ToLower & "'), " &
                              "('invoiceyoffset','" & NumericUpDown1.Value & "','" & selectionKeyReference.ToLower & "'), " &
                              "('invoicexoffset','" & NumericUpDown2.Value & "','" & selectionKeyReference.ToLower & "'), " &
                              "('dollarprice','" & numDollar.Value & "','" & selectionKeyReference.ToLower & "'), " &
                              "('roundToThousand','" & ComboBox1.SelectedIndex & "','" & selectionKeyReference.ToLower & "'), " &
                              "('note1','" & txtnote1.Text.Trim & "','" & selectionKeyReference.ToLower & "'), " &
                              "('note2','" & txtnote2.Text.Trim & "','" & selectionKeyReference.ToLower & "'), " &
                              "('note3','" & txtnote3.Text.Trim & "','" & selectionKeyReference.ToLower & "') ")

            orgname = txtname.Text.Trim
            invoiceYOffset = NumericUpDown1.Value
            invoiceXOffset = NumericUpDown2.Value
            dollarPrice = numDollar.Value
            roundToThousand = ComboBox1.SelectedIndex

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Dispose()
    End Sub

End Class