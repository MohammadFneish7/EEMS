<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePass
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePass))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtoldpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.SLADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthenticationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.SLADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthenticationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtoldpass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtConfirm)
        Me.GroupBox1.Controls.Add(Me.btnChange)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(321, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اختر كلمة مرور جديدة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "كلمة المرور الحاليّة:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "كلمة المرور الجديدة:"
        '
        'txtoldpass
        '
        Me.txtoldpass.Location = New System.Drawing.Point(15, 38)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.Size = New System.Drawing.Size(192, 20)
        Me.txtoldpass.TabIndex = 0
        Me.txtoldpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtoldpass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "تأكيد كلمة المرور:"
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(15, 90)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(192, 20)
        Me.txtConfirm.TabIndex = 2
        Me.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.Location = New System.Drawing.Point(15, 116)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(192, 23)
        Me.btnChange.TabIndex = 3
        Me.btnChange.Text = "موافق"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(15, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'AuthenticationBindingSource
        '
        Me.AuthenticationBindingSource.DataSource = Me.SLADataSetBindingSource
        '
        'frmChangePass
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 179)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تغيير كلمة المرور"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SLADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthenticationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents SLADataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuthenticationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtoldpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
