<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmptyCHPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmptyCHPrint))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCollector = New System.Windows.Forms.ComboBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnShowPrint = New System.Windows.Forms.Button()
        Me.cmbEngine = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الجابي:"
        '
        'cmbCollector
        '
        Me.cmbCollector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCollector.FormattingEnabled = True
        Me.cmbCollector.Location = New System.Drawing.Point(12, 39)
        Me.cmbCollector.Name = "cmbCollector"
        Me.cmbCollector.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCollector.Size = New System.Drawing.Size(241, 21)
        Me.cmbCollector.TabIndex = 1
        '
        'dtp
        '
        Me.dtp.CustomFormat = "MM/yyyy"
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(12, 66)
        Me.dtp.Name = "dtp"
        Me.dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtp.RightToLeftLayout = True
        Me.dtp.Size = New System.Drawing.Size(241, 20)
        Me.dtp.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "الشهر:"
        '
        'btnShowPrint
        '
        Me.btnShowPrint.Image = Global.EEMS.My.Resources.Resources.printer16
        Me.btnShowPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowPrint.Location = New System.Drawing.Point(12, 116)
        Me.btnShowPrint.Name = "btnShowPrint"
        Me.btnShowPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowPrint.Size = New System.Drawing.Size(241, 29)
        Me.btnShowPrint.TabIndex = 37
        Me.btnShowPrint.Text = "طباعة"
        Me.btnShowPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnShowPrint.UseVisualStyleBackColor = True
        '
        'cmbEngine
        '
        Me.cmbEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEngine.FormattingEnabled = True
        Me.cmbEngine.Location = New System.Drawing.Point(12, 12)
        Me.cmbEngine.Name = "cmbEngine"
        Me.cmbEngine.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbEngine.Size = New System.Drawing.Size(241, 21)
        Me.cmbEngine.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "المولّد:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(100, 92)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(153, 17)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "ترتيب حسب اسم المشترك"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmEmptyCHPrint
        '
        Me.AcceptButton = Me.btnShowPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 157)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmbEngine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShowPrint)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCollector)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEmptyCHPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طباعة نموذج ادخال العدّادات"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCollector As System.Windows.Forms.ComboBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnShowPrint As System.Windows.Forms.Button
    Friend WithEvents cmbEngine As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
