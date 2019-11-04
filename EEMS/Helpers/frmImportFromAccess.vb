Public Class frmImportFromAccess

    Dim accessHelper As MSAccessDBHelper.Helper
    Dim sqlHelper As New SqlDBHelper.Helper

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim.Length = 0 Then
            MsgBox("الرجاء ادخال مسار قاعدة بيانات الأكسس.")
            Return
        End If
        Try
            accessHelper = New MSAccessDBHelper.Helper(TextBox1.Text.Trim)
            sqlHelper.ds = New DataSet

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from Engine")
            insetdata("Engine", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from EngineWorkingHours")
            insetdata("EngineWorkingHours", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from Collector")
            insetdata("Collector", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from ElectricBox")
            insetdata("ElectricBox", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from Client")
            insetdata("Client", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from Package")
            insetdata("Package", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from ECounter")
            insetdata("ECounter", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from Expenditure")
            insetdata("Expenditure", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from Registration")
            insetdata("Registration", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from CounterHistory")
            insetdata("CounterHistory", accessHelper.ds.Tables(0))

            accessHelper.ds = New DataSet
            accessHelper.GetData("Select * from Payment")
            insetdata("Payment", accessHelper.ds.Tables(0))

            MsgBox("تمت العمليّة بنجاح")
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
        End Try

    End Sub

    Public Sub insetdata(tablename As String, dt As DataTable)
        Dim values As String = ""
        Dim fields As String = ""
        Dim skipLast As Integer = 0
        For i As Int16 = 0 To dt.Columns.Count - 1 Step 1
            Dim col As String = dt.Columns(i).Caption
            If col = "power" Then
                col = "epower"
            ElseIf col = "address" Then
                col = "caddress"
            ElseIf col = "round" Then
                col = "roundvalue"
            ElseIf col = "total" Then
                skipLast = 1
                Continue For
            End If
            fields = fields & col & ","
        Next
        If fields.Length > 0 Then
            fields = fields.Substring(0, fields.Length - 1)

            Dim counter As Integer = 0
            Dim index As Integer = 0
            Dim lastindex As Integer = 0
            For Each row As DataRow In dt.Rows
                Dim array As Object() = row.ItemArray
                index = index + 1
                values = values & "("
                For i As Int16 = 0 To array.Length - 1 - skipLast Step 1
                    values = values & "@p" & counter & ","
                    counter = counter + 1
                Next
                values = values.Substring(0, values.Length - 1)
                values = values & "),"

                If counter >= 190 Then

                    values = values.Substring(0, values.Length - 1)
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.CommandText = "insert into " & tablename & "(" & fields & ") values " & values & ";"
                    If Not tablename.ToUpper = "ENGINEWORKINGHOURS" Then
                        cmd.CommandText = "SET IDENTITY_INSERT dbo." & tablename & " ON;" & cmd.CommandText
                    End If

                    Dim counter2 As Integer = 0
                    For j As Int16 = lastindex To index - 1 Step 1
                        Dim darray As Object() = dt.Rows(j).ItemArray
                        For i As Int16 = 0 To darray.Length - 1 - skipLast Step 1
                            cmd.Parameters.AddWithValue("@p" & counter2, darray(i))
                            counter2 = counter2 + 1
                        Next
                    Next
                    values = ""
                    lastindex = index
                    counter = 0
                    Console.WriteLine(tablename)
                    sqlHelper.ExecuteNoReturn(cmd)

                End If
            Next


            If counter > 0 Then

                values = values.Substring(0, values.Length - 1)
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandText = "insert into " & tablename & "(" & fields & ") values " & values & ";"
                If Not tablename.ToUpper = "ENGINEWORKINGHOURS" Then
                    cmd.CommandText = "SET IDENTITY_INSERT dbo." & tablename & " ON;" & cmd.CommandText
                End If

                Dim counter2 As Integer = 0
                For j As Int16 = lastindex To index - 1 Step 1
                    Dim darray As Object() = dt.Rows(j).ItemArray
                    For i As Int16 = 0 To darray.Length - 1 - skipLast Step 1
                        cmd.Parameters.AddWithValue("@p" & counter2, darray(i))
                        counter2 = counter2 + 1
                    Next
                Next
                values = ""
                lastindex = index
                counter = 0
                Console.WriteLine(tablename)
                sqlHelper.ExecuteNoReturn(cmd)

            End If
        End If

    End Sub
End Class