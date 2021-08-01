Imports System.Data.OleDb
Imports EEMS.SqlDBHelper

Public Class frmExcelImporter

    Dim des As String
    Dim dt As New DataTable
    Dim total As Integer = 100
    Dim a As New Helper("Server=DESKTOP-O3TSL14;Database=EEMS1;Persist Security Info=True;Integrated Security=true;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx"
        OpenFileDialog1.Title = "اختر ملف"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            des = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dt = New DataTable

        Dim sSheetName As String = Nothing
        Dim sConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & des & ";Extended Properties=""Excel 12.0;HDR=No;IMEX=1"""
        Dim dtTablesList As DataTable
        Dim oleExcelCommand As OleDbCommand
        Dim oleExcelReader As OleDbDataReader
        Dim oleExcelConnection As OleDbConnection = New OleDbConnection(sConnection)

        Try
            oleExcelConnection.Open()

            dtTablesList = oleExcelConnection.GetSchema("Tables")

            If dtTablesList.Rows.Count > 0 Then
                sSheetName = dtTablesList.Rows(0)("TABLE_NAME").ToString
            End If

            dtTablesList.Clear()
            dtTablesList.Dispose()

            If sSheetName <> "" Then

                oleExcelCommand = oleExcelConnection.CreateCommand()
                oleExcelCommand.CommandText = "Select * From [" & TextBox2.Text & "$]"
                oleExcelCommand.CommandType = CommandType.Text

                oleExcelReader = oleExcelCommand.ExecuteReader

                Dim nOutputRow As Integer = 0

                oleExcelReader.Read()
                Dim colsCount As Int16 = oleExcelReader.FieldCount
                Dim cols(colsCount - 1) As Object
                oleExcelReader.GetValues(cols)

                For Each o As Object In cols
                    dt.Columns.Add(o.ToString)
                Next

                While oleExcelReader.Read
                    Dim s(colsCount - 1) As Object
                    oleExcelReader.GetValues(s)
                    Dim row As DataRow = dt.NewRow
                    For i As Int16 = 0 To colsCount - 1 Step 1
                        row.Item(i) = s(i)
                    Next
                    dt.Rows.Add(row)
                End While

                'Delete Empty Rows
                Dim rowsToDelete As New List(Of DataRow)
                For Each row As DataRow In dt.Rows
                    Dim empty As Boolean = True
                    For i As Integer = 0 To row.ItemArray.Count - 1
                        If row.Item(i).ToString.Trim.Length > 0 Then
                            empty = False
                            Exit For
                        End If
                    Next
                    If empty Then
                        rowsToDelete.Add(row)
                    End If
                Next
                For Each r2d As DataRow In rowsToDelete
                    dt.Rows.Remove(r2d)
                Next

                'Delete Empty Columns
                Dim colsToDelete As New List(Of DataColumn)
                For Each col As DataColumn In dt.Columns
                    Dim empty As Boolean = True
                    For Each row As DataRow In dt.Rows
                        If row.Item(dt.Columns.IndexOf(col)).ToString.Trim.Length > 0 Then
                            empty = False
                            Exit For
                        End If
                    Next
                    If empty Then
                        colsToDelete.Add(col)
                    End If
                Next
                For Each c2d As DataColumn In colsToDelete
                    dt.Columns.Remove(c2d)
                Next

                oleExcelReader.Close()
                DataGridView1.DataSource = dt
                Label4.Text = DataGridView1.RowCount
            End If

            oleExcelConnection.Close()
        Catch ex As Exception
            ErrorDialog.showDlg(ex)
            Try
                oleExcelConnection.Close()
            Catch ex1 As Exception

            End Try
        End Try

    End Sub

    Private Sub ExcellImporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = DataGridView1.GetType()
            Dim pi As System.Reflection.PropertyInfo
            pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(DataGridView1, True, Nothing)
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = False
        Button2.Enabled = False
        txtDate.Enabled = False
        Button3.Enabled = False
        TextBox2.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    'Private Function getECounterBySerial(counters As List(Of Counter), name As String) As Counter
    '    For Each counter As Counter In counters
    '        If counter.serial.Trim = name.Trim Then
    '            Return counter
    '        End If
    '    Next
    '    Return Nothing
    'End Function

    'Private Function getPackID(packs As List(Of Pack), ampere As String) As Integer
    '    For Each package As Pack In packs
    '        If package.ampere.Trim = ampere.Trim Then
    '            Return package.id
    '        End If
    '    Next
    '    Return -1
    'End Function

    'Private Function getMotorID(motors As List(Of motor), name As String) As Integer
    '    For Each motor As motor In motors
    '        If motor.name.Trim = name.Trim Then
    '            Return motor.id
    '        End If
    '    Next
    '    Return -1
    'End Function

    'Private Function getCollectorID(collectors As List(Of Collecter), name As String) As Integer
    '    For Each collector As Collecter In collectors
    '        If collector.name.Trim = name.Trim Then
    '            Return collector.id
    '        End If
    '    Next
    '    Return -1
    'End Function

    Public Shared Function FromExcelSerialDate(ByVal SerialDate As Integer) As DateTime
        If SerialDate > 59 Then SerialDate -= 1 ''// Excel/Lotus 2/29/1900 bug
        Return New DateTime(1899, 12, 31).AddDays(SerialDate)
    End Function


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'Dim motors As IEnumerable(Of String) = From row In dt.AsEnumerable Select row.Field(Of String)(DataGridView1.Columns(0).Name) Distinct
        'Dim collectors As IEnumerable(Of String) = From row In dt.AsEnumerable Select row.Field(Of String)(DataGridView1.Columns(6).Name) Distinct
        'Dim clients As IEnumerable(Of String) = From row In dt.AsEnumerable Select row.Field(Of String)(DataGridView1.Columns(3).Name) Distinct
        'Dim boxCodes As IEnumerable(Of String) = From row In dt.AsEnumerable Select row.Field(Of String)(DataGridView1.Columns(1).Name) Distinct

        a.ds = New DataSet

        Dim gen As New Generator(1, TXTID.Text.Trim, TXTlETTER.Text.Trim)
        Dim datevalue As String()
        Dim cserials As New List(Of String)
        Dim count As Int32 = 0
        For Each row As DataRow In dt.Rows
            count += 1
            If count = 1 And CheckBox1.Checked Then
                Continue For
            End If
            If row.Item(1).ToString.Trim.Length = 0 Then
                count -= 1
                Continue For
            End If
            Dim name As String, phone As String, regdate As Date, boxcode As String, location As String, value As Int32, ampere As Int32, fee As Int32
            boxcode = row.Item(1).ToString.Trim
            Dim note As String = row.Item(6).ToString.Trim.Split(" ")(0)
            If note.Trim.Length > 0 And Not note.Equals("مفصول") Then
                name = row.Item(2).ToString.Trim + "-" + note
            Else
                name = row.Item(2).ToString.Trim
            End If

            fee = Integer.Parse(row.Item(3).ToString.Trim)
            ampere = Integer.Parse(row.Item(4).ToString.Trim)
            value = Integer.Parse(row.Item(5).ToString.Trim)
            location = row.Item(7).ToString.Trim
            phone = row.Item(8).ToString.Trim

            If row.Item(9).ToString.Trim.Length = 0 Then
                datevalue = "1/1/2018".Split("/")
                regdate = New Date(datevalue(2), datevalue(0), datevalue(1))
            Else
                Try
                    Dim dateserial As Int32 = Integer.Parse(row.Item(9).ToString.Trim)
                    regdate = FromExcelSerialDate(dateserial).Date
                Catch ex As Exception
                    Try
                        datevalue = row.Item(9).ToString.Trim.Split("/")
                        regdate = New Date(datevalue(2), datevalue(0), datevalue(1))
                    Catch ex2 As Exception
                        datevalue = "1/1/2018".Split("/")
                        regdate = New Date(datevalue(2), datevalue(0), datevalue(1))
                    End Try
                End Try
            End If

            gen.parseRecordForClient(name, phone, regdate, boxcode, location, value, ampere, fee)

        Next

        Dim prev As Counter = Nothing
        For Each c As Counter In gen.counters
            If prev Is Nothing Then
                Continue For
            End If
            If c.serial.Equals(prev.serial) Then
                MsgBox(c.serial)
            End If
        Next

        total = gen.clients.Count
        Dim insertedBoxesCodes As New List(Of String)
        For Each cl As ClientInfo In gen.clients
            BackgroundWorker1.ReportProgress(1)

            cl.id = a.Execute("Insert into Client(clientname,phone) values('" & cl.name & "','" & cl.phone & "')")
            If Not insertedBoxesCodes.Contains(cl.box.code) Then
                cl.box.id = a.ExecuteTEST("Insert into electricbox(code,location,collectorid,engineid) values('" & cl.box.code & "','" & cl.box.location & "'," & gen.collecterid & "," & gen.engineid & ")", cl.id)
                insertedBoxesCodes.Add(cl.box.code)
            End If

            Dim active As Int16 = 1
            If cl.pack.fee = 0 Then
                active = 0
                For Each p As Pack In gen.packs
                    If p.ampere = cl.pack.ampere Then
                        cl.pack.id = p.id
                    End If
                Next
            End If
            cl.counter.id = a.Execute("insert into ecounter(serial,code,boxid,active) values('" & cl.counter.serial & "','" & cl.counter.code & "','" & cl.box.id & "'," & active & ")")
            If active = 0 Then
                cl.regid = a.Execute("insert into registration(clientid,registrationdate,packageid,counterid,active,initialcountervalue,enddate,insurance)" & _
                                 " values(" & cl.id & ",'" & cl.regdate.ToShortDateString & "'," & cl.pack.id & "," & cl.counter.id & "," & active & "," & 0 & ",'" & Date.Today.ToShortDateString & "'," & 0 & ")")
            Else
                cl.regid = a.Execute("insert into registration(clientid,registrationdate,packageid,counterid,active,initialcountervalue,insurance)" & _
                                 " values(" & cl.id & ",'" & cl.regdate.ToShortDateString & "'," & cl.pack.id & "," & cl.counter.id & "," & active & "," & 0 & "," & 0 & ")")
            End If
            a.ExecuteNoReturn("insert into counterhistory (cmonth,cyear,regid,monthlyfee,kilowattprice,previousvalue,currentvalue,roundvalue)" &
                              " values(" & txtDate.Value.Month & "," & txtDate.Value.Year & "," & cl.regid & "," & 0 & "," & 0 & "," & 0 & "," & cl.counter.value & "," & 0 & ")")
        Next

        MsgBox("Records parsed: " & count)

        'Dim collectors As New List(Of Collecter)
        'Dim motors As New List(Of motor)
        'Dim boxes As New List(Of Box)
        'Dim regs As New List(Of Register)
        'Dim packs As New List(Of Pack)
        'Dim regtable As New Hashtable


        'For Each row As DataRow In dt.Rows
        '    If (row.Item(8).Equals("1825 2486")) Then
        '        Console.WriteLine()
        '    End If

        '    Dim motExist As Boolean = False
        '    For Each motor As motor In motors
        '        If motor.name = row.Item(0).ToString Then
        '            motExist = True
        '            Exit For
        '        End If
        '    Next
        '    If Not motExist Then
        '        motors.Add(New motor(-1, row.Item(0).ToString))
        '    End If

        '    Dim packExist As Boolean = False
        '    For Each package As Pack In packs
        '        If package.ampere = row.Item(4).ToString Then
        '            packExist = True
        '            Exit For
        '        End If
        '    Next
        '    If Not packExist Then
        '        packs.Add(New Pack(-1, row.Item(4).ToString))
        '    End If

        '    Dim colExist As Boolean = False
        '    For Each collecter As Collecter In collectors
        '        If collecter.name = row.Item(6).ToString Then
        '            colExist = True
        '            Exit For
        '        End If
        '    Next
        '    If Not colExist Then
        '        collectors.Add(New Collecter(-1, row.Item(6).ToString))
        '    End If

        '    Dim boxExist As Boolean = False
        '    Dim box As Box = Nothing
        '    For Each b As Box In boxes
        '        If b.code = row.Item(1).ToString Then
        '            box = b
        '            boxExist = True
        '            Exit For
        '        End If
        '    Next
        '    Dim active As Boolean = True
        '    If Not row.Item(7).ToString.StartsWith("ن") Then
        '        active = False
        '    End If

        '    If Not boxExist Then
        '        box = New Box(-1, row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(6).ToString)
        '        boxes.Add(box)
        '    End If

        '    box.counters.Add(New Counter(-1, row.Item(5).ToString, row.Item(8).ToString, active))

        '    Dim rcounterval As Integer = 0
        '    Dim rinsurence As Integer = 0
        '    Dim rcredit As Integer = 0

        '    Try
        '        rcounterval = Integer.Parse(row.Item(9).ToString)
        '    Catch ex As Exception
        '    End Try
        '    Try
        '        rinsurence = Integer.Parse(row.Item(10).ToString)
        '    Catch ex As Exception
        '    End Try
        '    Try
        '        rcredit = Integer.Parse(row.Item(11).ToString)
        '    Catch ex As Exception
        '    End Try

        '    Dim client As New Register(row.Item(3).ToString, row.Item(4).ToString, row.Item(7).ToString, rcounterval, rinsurence, rcredit, New Counter(-1, row.Item(5).ToString, row.Item(8).ToString, active))
        '    regs.Add(client)
        '    regtable.Add(row.Item(8), client)
        'Next

        'total = motors.Count + collectors.Count + boxes.Count + regs.Count + packs.Count
        'Dim mid, colid, packid, boid, countid, cliid, rid, chid As Integer
        'mid = 0
        'colid = 0
        'packid = 0
        'boid = 0
        'countid = 0
        'cliid = 0
        'rid = 0
        'chid = 0

        'For Each motor As motor In motors
        '    BackgroundWorker1.ReportProgress(1)
        '    If motor.name.Trim.Length > 0 Then
        '        a.ExecuteNoReturn("insert into Engine(ename) values('" & motor.name & "')")
        '        mid += 1
        '        motor.id = mid
        '    End If
        'Next

        'For Each collecter As Collecter In collectors
        '    BackgroundWorker1.ReportProgress(1)
        '    If collecter.name.Trim.Length > 0 Then
        '        a.ExecuteNoReturn("insert into Collector(fullname) values('" & collecter.name & "')")
        '        colid += 1
        '        collecter.id = colid
        '    End If
        'Next

        'For Each package As Pack In packs
        '    BackgroundWorker1.ReportProgress(1)
        '    If package.ampere.Trim.Length > 0 Then
        '        a.ExecuteNoReturn("insert into Package(ampere) values(" & package.ampere & ")")
        '        packid += 1
        '        package.id = packid
        '    End If
        'Next

        'For Each box As Box In boxes
        '    BackgroundWorker1.ReportProgress(1)
        '    If box.code.Trim.Length > 0 Then
        '        a.ExecuteNoReturn("insert into ElectricBox(code,location,engineid,collectorid) values('" & box.code & "','" & box.address & "','" & getMotorID(motors, box.motor) & "','" & getCollectorID(collectors, box.collector) & "')")
        '        boid += 1
        '        box.id = boid
        '        For Each counter As Counter In box.counters
        '            If counter.code.Trim.Length > 0 Then
        '                a.ExecuteNoReturn("insert into ECounter(serial,code,boxid,active) values('" & counter.serial & "','" & counter.code & "'," & box.id & "," & getBit(counter.active) & ")")
        '                countid += 1
        '                counter.id = countid
        '                CType(regtable(counter.serial), Register).conter.id = counter.id
        '                'For Each reg As Register In regs
        '                '    If reg.conter.serial.Trim = counter.serial.Trim Then
        '                '        reg.conter.id = counter.id
        '                '    End If
        '                'Next
        '            End If
        '        Next
        '    End If
        'Next
        'Dim d As New Date(2017, 1, 1)
        'For Each client As Register In regtable.Values
        '    BackgroundWorker1.ReportProgress(1)
        '    If client.name.Trim.Length > 0 Then
        '        a.ExecuteNoReturn("insert into Client(clientname) values('" & client.name & "')")
        '        cliid += 1
        '        client.cliendid = cliid
        '        Dim regid As Integer
        '        If client.active.StartsWith("ن") Then
        '            a.ExecuteNoReturn("insert into Registration(clientid,registrationdate,packageid,counterid,active,initialcountervalue,insurance) values(" & client.cliendid & _
        '                                                       "," & d.Date & "," & getPackID(packs, client.ampere) & "," & client.conter.id & ", 1,0," & client.insurence & ")")
        '            rid += 1
        '            regid = rid
        '        Else
        '            a.ExecuteNoReturn("insert into Registration(clientid,registrationdate,packageid,counterid,active,enddate,initialcountervalue,insurance) values(" & client.cliendid & _
        '                                                                          "," & d.Date & "," & getPackID(packs, client.ampere) & "," & client.conter.id & ", 0," & Date.Today & ",0," & client.insurence & ")")
        '            rid += 1
        '            regid = rid
        '        End If
        '        a.ExecuteNoReturn("insert into CounterHistory(cmonth,cyear,regid,previousvalue,currentvalue,monthlyfee) Values(1,2015," & regid & ",0,0," & client.credit & ")")
        '        a.ExecuteNoReturn("insert into CounterHistory(cmonth,cyear,regid,previousvalue,currentvalue) Values(" & txtDate.Value.Month & "," & txtDate.Value.Year & "," & regid & ",0," & client.counterval & ")")
        '    End If
        'Next


        'MsgBox("motors: " & motors.Count & vbNewLine & "collectors: " & collectors.Count & vbNewLine & "boxes: " & boxes.Count & vbNewLine & "registrations: " & regs.Count)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Button1.Enabled = True
        Button2.Enabled = True
        txtDate.Enabled = True
        Button3.Enabled = True
        TextBox2.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Maximum = total
        ProgressBar1.Value += 1
    End Sub

    Private Sub ExcellImporter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If a.cn.State = ConnectionState.Open Then
            Try
                a.cn.Close()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
            End Try
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        a.ExecuteNoReturn("update registration set insurance=0")
        Dim cserials As New List(Of String)
        For Each row As DataRow In dt.Rows
            Do While cserials.Contains(row.Item(8))
                row.Item(8) = "0" & row.Item(8)
            Loop
            cserials.Add(row.Item(8))
        Next

        Dim i As Integer = 0
        For Each row As DataRow In dt.Rows
            i += 1
            Dim rcredit As Integer = 0
            Dim serial As String
            rcredit = Integer.Parse(row.Item(10).ToString)
            serial = row.Item(8).ToString
            If rcredit > 0 Then
                Dim sql As String = "update registration set insurance =" & rcredit & " where counterid = (select ID from ECounter e where e.serial ='" & serial & "' )"
                a.ExecuteNoReturn(sql)
                Console.WriteLine(i)
            End If
        Next
    End Sub
End Class



Public Class ClientInfo
    Public id As Int32
    Public regid As Int32
    Public name As String
    Public phone As String
    Public regdate As Date
    Public box As Box
    Public counter As Counter
    Public pack As Pack

    Sub New(id As Int32, name As String, phone As String, regdate As Date, box As Box, counter As Counter, pack As Pack)
        Me.id = id
        Me.name = name
        Me.phone = phone
        Me.regdate = regdate
        Me.box = box
        Me.counter = counter
        Me.pack = pack
    End Sub
End Class

Public Class Box
    Public id As Int32
    Public code As String
    Public location As String
    Public countersList As New List(Of Counter)
    Public lastCounterCode As Char = "A"
    Public isinserted As Boolean = False

    Sub New(id As Int32, code As String, location As String)
        Me.id = id
        Me.code = code
        Me.location = location
    End Sub

End Class

Public Class Counter
    Public id As Int32
    Public boxid As Int32
    Public code As String
    Public serial As String
    Public value As Int32

    Sub New(id As Int32, boxid As Int32, code As String, serial As String, value As Int32)
        Me.id = id
        Me.boxid = boxid
        Me.code = code
        Me.serial = serial
        Me.value = value
    End Sub

End Class

Public Class Pack
    Public id As Int32
    Public ampere As Int32
    Public fee As Int32
    Sub New(id As Int32, ampere As Int32, fee As Int32)
        Me.id = id
        Me.ampere = ampere
        Me.fee = fee
    End Sub
End Class

Public Class Generator
    Public boxes As New List(Of Box)
    Public counters As New List(Of Counter)
    Public clients As New List(Of ClientInfo)
    Public packs As New List(Of Pack)

    Dim maxboxid As Int32 = 0
    Dim maxcounterid As Int32 = 0
    Dim maxclientid As Int32 = 0

    Public collecterid As Int32 = 1
    Public engineid As Int32 = 1
    Public enginecode As String = "A"

    Sub New(collecterid As Int32, engineid As Int32, enginecode As String)
        Me.collecterid = collecterid
        Me.engineid = engineid
        Me.enginecode = enginecode
    End Sub


    Public Function getBox(code As String, location As String) As Box
        For Each Box As Box In boxes
            If Box.code.Trim.Trim.ToUpper.Equals(enginecode & "-" & code.Trim.ToUpper) Then
                Return Box
            End If
        Next
        Dim newbox As New Box(maxboxid + 1, enginecode & "-" & code.Trim.ToUpper, location.Trim.ToUpper)
        boxes.Add(newbox)
        maxboxid = maxboxid + 1
        Return newbox
    End Function

    Public Function getCounter(boxcode As String, value As Int32) As Counter
        Dim foundBox As Box = Nothing
        For Each Box As Box In boxes
            If Box.code.Trim.Trim.ToUpper.Equals(enginecode & "-" & boxcode.Trim.ToUpper) Then
                foundBox = Box
            End If
        Next
        maxcounterid = maxcounterid + 1
        Dim counter As New Counter(maxcounterid, foundBox.id, foundBox.lastCounterCode.ToString, DateTime.Now.Ticks, value)
        counters.Add(counter)
        foundBox.countersList.Add(counter)
        foundBox.lastCounterCode = Chr(Asc(foundBox.lastCounterCode) + 1)
        Return counter
    End Function

    Public Function getPack(ampere As Int32, fee As Int32) As Pack
        If fee = 0 Then
            Return New Pack(13, ampere, 0)
        End If
        If packs.Count = 0 Then
            packs.Add(New Pack(1, 5, 15000))
            packs.Add(New Pack(3, 5, 10000))
            packs.Add(New Pack(4, 10, 20000))
            packs.Add(New Pack(5, 10, 15000))
            packs.Add(New Pack(6, 15, 25000))
            packs.Add(New Pack(7, 15, 20000))
            packs.Add(New Pack(8, 20, 30000))
            packs.Add(New Pack(9, 20, 25000))
            packs.Add(New Pack(10, 30, 60000))
            packs.Add(New Pack(11, 30, 40000))
            packs.Add(New Pack(12, 25, 35000))
            packs.Add(New Pack(13, 25, 30000))
        End If
        For Each p As Pack In packs
            If p.ampere = ampere And p.fee = fee Then
                Return p
            End If
        Next
        Return Nothing
    End Function

    Public Sub parseRecordForClient(name As String, phone As String, regdate As Date, boxcode As String, location As String, value As Int32, ampere As Int32, fee As Int32)
        Dim box As Box = getBox(boxcode, location)
        Dim counter As Counter = getCounter(boxcode, value)
        Dim pack As Pack = getPack(ampere, fee)
        maxclientid = maxclientid + 1
        Dim client As New ClientInfo(maxclientid, name.ToUpper.Trim, phone.Trim, regdate, box, counter, pack)
        clients.Add(client)
    End Sub
End Class
