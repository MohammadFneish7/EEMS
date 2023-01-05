Imports EEMS.SqlDBHelper

Public Class frmFuelPurchaseEditor

    Dim a As New Helper

    Private Sub ClientEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If checkEmpty() Then
            MsgBox("الرجاء التأكد من تعبئة جميع الخانات المطلوبة.")
            Return
        End If

        If Integer.Parse(txtQuantity.Text.Trim) <= 0 Then
            MsgBox("لا يمكن شراء كمّيّة صفر من الصنف.")
            Return
        End If

        If Integer.Parse(txtQuantity.Text.Trim) > (Integer.Parse(txtTankCapacity.Text.Trim) - Integer.Parse(txtTankRem.Text.Trim)) Then
            MsgBox("الكمّيّة المطلوب شراؤها أكبر من السعة المتبقّية من سعة الخزّان الاجماليّة.")
            Return
        End If

        If chkmigratetodollarbox.Checked Then
            If String.IsNullOrEmpty(txtdollarprice.Text) OrElse Double.Parse(txtdollarprice.Text) <= 0 Then
                MsgBox("الرجاء تحديد سعر الصرف للتحويل الى صندوق الدولار.")
                Return
            End If
            If String.IsNullOrEmpty(txtpaymentdollar.Text) OrElse Double.Parse(txtpaymentdollar.Text) <= 0 Then
                MsgBox("الرجاء تحديد القيمة بالدولار للتحويل الى صندوق الدولار.")
                Return
            End If
            If Not verifyPaymentEquality() Then
                MsgBox("الرجاء التأكد من أن القيمة بالليرة تساوي القيمة بالدولار ضرب سعر الصرف.")
                Return
            End If
        End If

        a.ds = New DataSet
        Dim purid As Integer = a.Execute("insert into FuelPurchases(indate,brand,tankid,quantity,pricetotal,partyname,partyPhone,notes) values('" & txtOutDate.Value & "','" & txtBrand.Text.Trim & "'," & txtTankID.Text.Trim & "," & txtQuantity.Text.Trim & "," & txtpricetotal.Text.Trim & ",'" & txtParty.Text.Trim & "','" & txtPartyPhone.Text.Trim & "','" & txtNotes.Text.Trim & "')")
        a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & txtOutDate.Value.ToShortDateString & "','شراء محروقات',-" & txtpricetotal.Text.Trim & ",'" & txtParty.Text.Trim & "','" & "شراء " & txtQuantity.Text.Trim & " لتر محروقات " & txtBrand.Text.Trim & "','fp" & purid & "')")

        Dim payedAmmount = Integer.Parse(txtpricetotal.Text.Trim) + SharedModule.getRoundThousand(Integer.Parse(txtpricetotal.Text.Trim))
        If chkmigratetodollarbox.Checked Then
            a.Execute("insert into Expenditure(expdate,title,amount,party,detail,paymentRef) values('" & txtOutDate.Value.ToShortDateString & "','دولار الى ليرة'," & payedAmmount & ",'','على سعر صرف " & Double.Parse(txtdollarprice.Text).ToString("#,##0.##") & "','fupid" & purid & "')")
            a.Execute("insert into Expenditure(expdate,title,amount_dollar,currency,party,detail,paymentRef) values('" & txtOutDate.Value.ToShortDateString & "','دولار الى ليرة'," & -txtpaymentdollar.Text.Trim & ",1,'','على سعر صرف " & Double.Parse(txtdollarprice.Text).ToString("#,##0.##") & "','fupid" & purid & "')")
        End If

        Me.DialogResult = DialogResult.OK
    End Sub


    Private Function checkEmpty() As Boolean
        If txtOutDate.Text.Trim.Length = 0 OrElse txtTankID.Text.Trim.Length = 0 OrElse txtQuantity.Text.Trim.Length = 0 OrElse txtpricetotal.Text.Trim.Length = 0 OrElse Integer.Parse(txtQuantity.Text.Trim) <= 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Ignore
    End Sub

    Private Sub txtItemID_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTankID.MouseDoubleClick
        Dim frm1 As New frmChooser(TANK_CHOOSER)
        If frm1.ShowDialog() = DialogResult.OK Then
            If frm1.dgvData.SelectedRows.Count > 0 Then
                txtTankID.Text = frm1.dgvData.SelectedRows(0).Cells(0).Value.ToString
                txtTankName.Text = frm1.dgvData.SelectedRows(0).Cells(1).Value.ToString
                txtTankCapacity.Text = frm1.dgvData.SelectedRows(0).Cells(3).Value.ToString
                txtTankRem.Text = frm1.dgvData.SelectedRows(0).Cells(4).Value.ToString
                txtQuantity.Select()
            End If
        End If
    End Sub

    Private Sub txtItemID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTankID.KeyPress
        If AscW(e.KeyChar) = 32 Then
            txtItemID_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress, txtpricetotal.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub frmFuelPurchaseEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdollarprice.Text = SharedModule.dollarPrice
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpricetotal.KeyPress, txtdollarprice.KeyPress
        a.bindNumeric(sender, e)
    End Sub

    Private Sub txtpaymentdollar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaymentdollar.KeyPress
        a.bindDouble(sender, e)
    End Sub

    Private Function verifyPaymentEquality() As Boolean
        Try
            If Math.Abs(Integer.Parse(txtpricetotal.Text) - Double.Parse(txtpaymentdollar.Text * txtdollarprice.Text)) < 1000 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub txtpaymentdollar_TextChanged(sender As Object, e As EventArgs) Handles txtpaymentdollar.TextChanged, txtpricetotal.TextChanged, txtdollarprice.TextChanged
        RemoveHandler txtpricetotal.TextChanged, AddressOf txtpaymentdollar_TextChanged
        RemoveHandler txtdollarprice.TextChanged, AddressOf txtpaymentdollar_TextChanged
        RemoveHandler txtpaymentdollar.TextChanged, AddressOf txtpaymentdollar_TextChanged

        Try
            If sender Is txtpricetotal Then
                txtpaymentdollar.Text = Double.Parse(txtpricetotal.Text / txtdollarprice.Text).ToString("0.##")
            Else
                If sender Is txtdollarprice Then
                    txtpaymentdollar.Text = Double.Parse(txtpricetotal.Text / txtdollarprice.Text).ToString("0.##")
                ElseIf sender Is txtpaymentdollar Then
                    txtdollarprice.Text = CType(Double.Parse(txtpricetotal.Text / txtpaymentdollar.Text).ToString(), Integer)
                End If

                txtpricetotal.Text = Integer.Parse(txtpricetotal.Text.Trim) + SharedModule.getRoundThousand(Integer.Parse(txtpricetotal.Text.Trim))
            End If
        Catch ex As Exception

        Finally
            AddHandler txtpricetotal.TextChanged, AddressOf txtpaymentdollar_TextChanged
            AddHandler txtdollarprice.TextChanged, AddressOf txtpaymentdollar_TextChanged
            AddHandler txtpaymentdollar.TextChanged, AddressOf txtpaymentdollar_TextChanged
        End Try
    End Sub
    Private Sub chkmigratetodollarbox_CheckedChanged(sender As Object, e As EventArgs) Handles chkmigratetodollarbox.CheckedChanged
        If chkmigratetodollarbox.Checked Then
            txtdollarprice.Enabled = True
            txtpaymentdollar.Enabled = True
        Else
            txtdollarprice.Enabled = False
            txtpaymentdollar.Enabled = False
        End If
    End Sub

    Private Sub txtpayment_Leave(sender As Object, e As EventArgs) Handles txtpricetotal.Leave
        Try
            If chkmigratetodollarbox.Checked Then
                txtpricetotal.Text = Integer.Parse(txtpricetotal.Text.Trim) + SharedModule.getRoundThousand(Integer.Parse(txtpricetotal.Text.Trim))
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
