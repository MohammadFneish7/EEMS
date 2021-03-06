Imports System.Text
Imports System.Security.Cryptography
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient

Namespace SqlDBHelper

    Public Class Helper


        Public cn As New SqlClient.SqlConnection
        Public ds As New DataSet
        Dim daSQL As SqlClient.SqlDataAdapter
        Dim cm As CurrencyManager
        Dim constring As String


        Public Sub New()
            Try
                '"Server=DESKTOP-O3TSL14;Database=EEMS;Persist Security Info=True;Integrated Security=true;"
                'constring = System.IO.File.ReadAllText(".\SQLConnection.config").Trim
                constring = My.Settings.EEMSConnectionString
                SetMsSqlServerConnection()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
                Environment.Exit(1)
            End Try
        End Sub

        Public Sub New(conStr As String)
            Try
                constring = conStr.Trim
                SetMsSqlServerConnection()
            Catch ex As Exception
                ErrorDialog.showDlg(ex)
                Environment.Exit(1)
            End Try
        End Sub

        Public Sub SetMsSqlServerConnection()
            cn = New SqlClient.SqlConnection
            cn.ConnectionString = constring
            cn.Open()
        End Sub

        Public Function Execute(ByVal strSQL As String) As Integer
            Dim cmd As SqlClient.SqlCommand
            Dim id As Integer

            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                cn.Open()
            End If
            cmd = New SqlClient.SqlCommand(strSQL, cn)
            cmd.ExecuteNonQuery()
            Try
                id = New SqlClient.SqlCommand("SELECT @@IDENTITY;", cn).ExecuteScalar()
            Catch ex As Exception

            End Try

            cmd.Dispose()
            log(strSQL)
            cn.Close()
            Return id
        End Function

        Public Function ExecuteInTransaction(ByVal strSQL As List(Of String), Optional ByRef errorMsg As String = Nothing) As Boolean
            Dim transaction As SqlTransaction = Nothing

            Try
                SetMsSqlServerConnection()
                If cn.State = ConnectionState.Closed Then
                    cn = New SqlClient.SqlConnection
                    cn.ConnectionString = constring
                    cn.Open()
                End If

                transaction = cn.BeginTransaction()
                Dim logQuery As String

                For Each sqlQuery As String In strSQL
                    Using cmd As New SqlCommand(sqlQuery, cn, transaction)
                        cmd.ExecuteNonQuery()
                    End Using

                    logQuery = "Insert Into LogSet(querystr,actiontype,username) Values (@Query,'" & sqlQuery.Trim.Substring(0, 1).ToUpper & "','" & currentUser.getUsername & "')"
                    Using cmd As New SqlCommand(logQuery, cn, transaction)
                        cmd.Parameters.Add("@Query", SqlDbType.VarChar, 1000).Value = sqlQuery.Trim
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                transaction.Commit()

            Catch ex As Exception
                errorMsg = ex.Message
                Try
                    If Not transaction Is Nothing Then
                        transaction.Rollback()
                    End If
                Catch ex1 As Exception
                End Try
                Return False
            Finally
                Try
                    cn.Close()
                Catch ex As Exception
                End Try
            End Try

            Return True
        End Function

        Public Function ExecuteTEST(ByVal strSQL As String, count As Int32) As Integer
            Dim cmd As SqlClient.SqlCommand
            Dim id As Integer

            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                cn.Open()
            End If
            cmd = New SqlClient.SqlCommand(strSQL, cn)
            cmd.ExecuteNonQuery()
            Try
                id = New SqlClient.SqlCommand("SELECT @@IDENTITY;", cn).ExecuteScalar()
            Catch ex As Exception

            End Try

            cmd.Dispose()
            cn.Close()

            Return id
        End Function

        Public Sub ExecuteNoReturn(ByVal strSQL As String)
            Dim cmd As SqlClient.SqlCommand

            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                cn.Open()
            End If
            cmd = New SqlClient.SqlCommand(strSQL, cn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            log(strSQL)
            cn.Close()

        End Sub

        Public Sub ExecuteNoReturn(ByVal cmd As SqlClient.SqlCommand)

            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                cn.Open()
            End If
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            log(cmd.CommandText)
            cn.Close()
        End Sub

        Public Function ExecuteScalar(ByVal strSQL As String) As Long
            Dim cmd As SqlClient.SqlCommand
            Dim val As Long
            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                cn.Open()
            End If
            cmd = New SqlClient.SqlCommand(strSQL, cn)
            cmd.ExecuteNonQuery()
            val = cmd.ExecuteScalar()
            cmd.Dispose()
            cn.Close()

            Return val
        End Function

        Public Function ExecuteScalarAsObject(ByVal strSQL As String) As Object
            Dim cmd As SqlClient.SqlCommand
            Dim val As Object = Nothing

            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                cn.Open()
            End If
            cmd = New SqlClient.SqlCommand(strSQL, cn)
            cmd.ExecuteNonQuery()
            val = cmd.ExecuteScalar()
            cmd.Dispose()
            cn.Close()

            Return val
        End Function

        Private Sub log(query As String)
            Dim logQuery As String = "Insert Into LogSet(querystr,actiontype,username) Values (@Query,'" & query.Trim.Substring(0, 1).ToUpper & "','" & currentUser.getUsername & "')"
            Dim cmd As SqlClient.SqlCommand

            Try

                SetMsSqlServerConnection()
                If cn.State = ConnectionState.Closed Then
                    cn = New SqlClient.SqlConnection
                    cn.ConnectionString = constring
                    cn.Open()
                End If

                cmd = New SqlClient.SqlCommand(logQuery, cn)
                cmd.Parameters.Add("@Query", SqlDbType.VarChar, 1000).Value = query.Trim
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        Public Sub GetData(ByVal strSQL As String, Optional ByVal strDataTableName As String = "dt")
            'My.Computer.Clipboard.SetText(strSQL)
            'MsgBox("queryCopied")
            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                Try
                    cn.Open()
                Catch ex As Exception

                End Try
            End If

            Dim da As New SqlClient.SqlDataAdapter

            da.SelectCommand = New SqlClient.SqlCommand(strSQL, cn)
            da.Fill(ds, strDataTableName)

            cn.Close()
        End Sub

        Public Sub GetData(ByVal strSQL As String, ByVal strDataTab As DataTable)

            SetMsSqlServerConnection()
            If cn.State = ConnectionState.Closed Then
                cn = New SqlClient.SqlConnection
                cn.ConnectionString = constring
                Try
                    cn.Open()
                Catch ex As Exception

                End Try
            End If

            Dim da As New SqlClient.SqlDataAdapter

            da.SelectCommand = New SqlClient.SqlCommand(strSQL, cn)
            da.Fill(strDataTab)

            cn.Close()

        End Sub

        Public Sub bindNumeric(sender As Object, e As KeyPressEventArgs)

            If (Not AscW(e.KeyChar) = 8) And (Not IsNumeric(e.KeyChar)) Then
                e.Handled = True
            End If
        End Sub


        Public Function isDouble(ByVal s As String) As Boolean
            Try
                Double.Parse(s)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

#Region "BindingControles"

        Public Sub bindingTextBox(ByVal TextBoxName As System.Windows.Forms.TextBox, ByVal bs As BindingSource, ByVal strColumn As String)

            Dim b As Binding

            Try
                b = New Binding("Text", bs, strColumn, True)
                TextBoxName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub


        Public Sub bindingLabel(ByVal LabelName As System.Windows.Forms.Label, ByVal bs As BindingSource, ByVal strColumn As String)

            Dim b As Binding

            Try
                b = New Binding("Text", bs, strColumn)
                LabelName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub

        Public Sub bindingDataGridColumn(ByVal dg As System.Windows.Forms.DataGridView, ByVal bs As BindingSource, ByVal strColumn As String)

            Dim b As Binding
            Dim cmb As New DataGridViewComboBoxColumn()



            Try
                b = New Binding("Text", bs, strColumn)

                ' dg.DataGridViewControlCollection()

                '  dg.DataBindings.Item(intColumnIndex).DataSource = ds.Tables("").Columns("")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub

        Public Sub bindingComboBoxValue(ByRef ComboBoxName As System.Windows.Forms.ComboBox, ByRef bs As BindingSource, ByVal strColumn As String)
            Dim b As Binding
            Try
                b = New Binding("SelectedValue", ds, strColumn)
                ComboBoxName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        Public Sub bindingComboBoxItem(ByRef ComboBoxName As System.Windows.Forms.ComboBox, ByRef bs As BindingSource, ByVal strColumn As String)
            Dim b As Binding
            Try
                b = New Binding("SelectedItem", ds, strColumn)
                ComboBoxName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub
        Public Sub bindingComboBoxText(ByRef ComboBoxName As System.Windows.Forms.ComboBox, ByRef bs As BindingSource, ByVal strColumn As String)
            Dim b As Binding
            Try
                b = New Binding("SelectedText", ds, strColumn)
                ComboBoxName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub
        Public Sub bindingCheckBox(ByVal CheckBoxName As System.Windows.Forms.CheckBox, ByVal ds As BindingSource, ByVal strColumn As String)

            Dim b As Binding
            Try
                b = New Binding("Checked", ds, strColumn)
                CheckBoxName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub
        Public Sub bindingRadioButton(ByVal CheckBoxName As System.Windows.Forms.RadioButton, ByVal ds As BindingSource, ByVal strColumn As String)

            Dim b As Binding
            Try
                b = New Binding("Checked", ds, strColumn, True)
                CheckBoxName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub
        Public Sub bindingNumericUpDown(ByVal NumericUpDownName As System.Windows.Forms.NumericUpDown, ByVal bs As BindingSource, ByVal strColumn As String)

            Dim b As Binding
            Try
                b = New Binding("Value", bs, strColumn, True)
                NumericUpDownName.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub

        Public Sub bindingDateTimePicker(ByVal dateTimePicker As System.Windows.Forms.DateTimePicker, ByVal bs As BindingSource, ByVal strColumn As String)

            Dim b As Binding
            Try
                b = New Binding("Value", bs, strColumn, True)
                dateTimePicker.DataBindings.Add(b)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub

#End Region

#Region "Email"
        Public Sub SendEmail()
            Dim client As New System.Net.Mail.SmtpClient
            Dim message As New System.Net.Mail.MailMessage
            client.Credentials = New System.Net.NetworkCredential("VOTRE_EMAIL_ICI", "VOTRE_MOT_DE_PASSE_ICI")

            Try

                client.Port = 25 'définition du port 
                client.Host = "smtp.live.com" 'définition du serveur smtp
                client.EnableSsl = True
                message.From = New System.Net.Mail.MailAddress("ADRESSE_DE_LEMETTEUR_ICI")
                message.To.Add("ADRESSE_DU_DESTINATAIRE_ICI")

                Dim item As New System.Net.Mail.Attachment("LIEN_DE_LA_PIECE_JOINTE_EVENTUELLE_ICI")
                message.Attachments.Add(item) 'ajout de la pièce jointe au message

                message.Subject = "SUJET_DU_MESSAGE_ICI"
                message.Body = "CONTENU_DU_MESSAGE_ICI"

                client.Send(message) 'envoi du mail
            Catch ex As Exception
                'TODO traiter les erreurs
            End Try
        End Sub
#End Region

#Region "Licence"
        Public Function GetMotherBoardID() As String

            Dim wmi As Object = GetObject("WinMgmts:")
            Dim serial_numbers As String = ""
            Dim mother_boards As Object = wmi.InstancesOf("Win32_BaseBoard")

            For Each board As Object In mother_boards
                serial_numbers &= ", " & board.SerialNumber
            Next board

            If serial_numbers.Length > 0 Then
                serial_numbers = serial_numbers.Substring(2)
            End If

            Return serial_numbers

        End Function

        Public Function GetCpuID() As String

            Dim computer As String = "."
            Dim cpu_ids As String = ""

            Dim wmi As Object = GetObject("winmgmts:" & _
                "{impersonationLevel=impersonate}!\\" & _
                computer & "\root\cimv2")
            Dim processors As Object = wmi.ExecQuery("Select * from Win32_Processor")


            For Each cpu As Object In processors
                cpu_ids = cpu_ids & ", " & cpu.ProcessorId
            Next cpu

            If cpu_ids.Length > 0 Then
                cpu_ids = cpu_ids.Substring(2)
            End If

            Return cpu_ids

        End Function

        Public Function GetHDDId() As String
            Dim fileSystemObject As Object
            Dim drive As Object
            Dim driveName As String

            fileSystemObject = CreateObject("Scripting.FileSystemObject")
            driveName = "C:\"
            drive = fileSystemObject.GetDrive(fileSystemObject.GetDriveName(fileSystemObject.GetAbsolutePathName(driveName)))

            Return (drive.SerialNumber.ToString())
        End Function


        Public Shared Function GenerateHash(ByVal SourceText As String) As String
            'Create an encoding object to ensure the encoding standard for the source text
            Dim Ue As New UnicodeEncoding()
            'Retrieve a byte array based on the source text
            Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
            'Instantiate an MD5 Provider object
            Dim Md5 As New MD5CryptoServiceProvider()
            'Compute the hash value from the source
            Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
            'And convert it to String format for return
            Dim sb As New StringBuilder(ByteHash.Length * 2)
            For Each b As Byte In ByteHash
                sb.Append(Conversion.Hex(b))
            Next
            Return sb.ToString
        End Function


        Public Sub writeLicense(lcs As String)
            System.IO.File.WriteAllText(".\eems.lcs", lcs)
        End Sub

        Public Function verifyLicense(lcs As String) As Boolean
            If System.IO.File.Exists(".\eems.lcs") = False Then
                Return False
            End If

            Dim strSerial As String = System.IO.File.ReadAllText(".\eems.lcs")
            If lcs = strSerial Then
                Return True
            Else
                Return False
            End If
        End Function



#End Region
    End Class
End Namespace

