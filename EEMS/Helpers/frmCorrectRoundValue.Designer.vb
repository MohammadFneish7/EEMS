<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorrectRoundValue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorrectRoundValue))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.chkall = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "عن شهر:"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(92, 29)
        Me.dtp.Name = "dtp"
        Me.dtp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtp.RightToLeftLayout = True
        Me.dtp.Size = New System.Drawing.Size(120, 20)
        Me.dtp.TabIndex = 1
        '
        'chkall
        '
        Me.chkall.AutoSize = True
        Me.chkall.Enabled = False
        Me.chkall.Location = New System.Drawing.Point(12, 31)
        Me.chkall.Name = "chkall"
        Me.chkall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkall.Size = New System.Drawing.Size(74, 17)
        Me.chkall.TabIndex = 2
        Me.chkall.Text = "كل الأشهر"
        Me.chkall.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "طريقة الاحتساب:"
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"تدوير الى الأعلى", "تدوير نسبي", "عدم تدوير"})
        Me.cmbtype.Location = New System.Drawing.Point(12, 58)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbtype.Size = New System.Drawing.Size(200, 21)
        Me.cmbtype.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Image = Global.EEMS.My.Resources.Resources.State_Validation_Valid
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(12, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(200, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "تصحيح"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCorrectRoundValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 130)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkall)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCorrectRoundValue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تصحيح كسر الألف"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents chkall As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbtype As ComboBox
    Friend WithEvents Button1 As Button
End Class
