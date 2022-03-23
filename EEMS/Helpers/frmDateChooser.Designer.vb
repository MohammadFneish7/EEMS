<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateChooser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDateChooser))
        Me.chkall = New System.Windows.Forms.CheckBox()
        Me.dtp0 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkall
        '
        Me.chkall.AutoSize = True
        Me.chkall.Checked = True
        Me.chkall.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkall.Location = New System.Drawing.Point(172, 12)
        Me.chkall.Name = "chkall"
        Me.chkall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkall.Size = New System.Drawing.Size(72, 17)
        Me.chkall.TabIndex = 5
        Me.chkall.Text = "كل الأشهر"
        Me.chkall.UseVisualStyleBackColor = True
        '
        'dtp0
        '
        Me.dtp0.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp0.Location = New System.Drawing.Point(12, 43)
        Me.dtp0.Name = "dtp0"
        Me.dtp0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtp0.RightToLeftLayout = True
        Me.dtp0.Size = New System.Drawing.Size(232, 20)
        Me.dtp0.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "من شهر:"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(12, 69)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtp1.RightToLeftLayout = True
        Me.dtp1.Size = New System.Drawing.Size(232, 20)
        Me.dtp1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "الى شهر:"
        '
        'Button1
        '
        Me.Button1.Image = Global.EEMS.My.Resources.Resources.State_Validation_Valid
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(12, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(232, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "موافق"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDateChooser
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 141)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkall)
        Me.Controls.Add(Me.dtp0)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDateChooser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اختيار التاريخ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkall As CheckBox
    Friend WithEvents dtp0 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
