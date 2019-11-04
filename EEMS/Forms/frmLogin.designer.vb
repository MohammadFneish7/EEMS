<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(12, 175)
        Me.btnok.Name = "btnok"
        Me.btnok.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnok.Size = New System.Drawing.Size(250, 36)
        Me.btnok.TabIndex = 11
        Me.btnok.Text = "موافق"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(11, 132)
        Me.txtpassword.MaxLength = 50
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpassword.Size = New System.Drawing.Size(240, 20)
        Me.txtpassword.TabIndex = 10
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(11, 75)
        Me.txtusername.MaxLength = 25
        Me.txtusername.Name = "txtusername"
        Me.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtusername.Size = New System.Drawing.Size(240, 20)
        Me.txtusername.TabIndex = 8
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(9, 109)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PasswordLabel.Size = New System.Drawing.Size(242, 23)
        Me.PasswordLabel.TabIndex = 9
        Me.PasswordLabel.Text = "كلمة المرور"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(9, 52)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UsernameLabel.Size = New System.Drawing.Size(242, 23)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "المستخدم"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.EEMS.My.Resources.Resources.man
        Me.LogoPictureBox.Location = New System.Drawing.Point(257, 55)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(97, 97)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(268, 175)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnclose.Size = New System.Drawing.Size(86, 36)
        Me.btnclose.TabIndex = 14
        Me.btnclose.Text = "خروج"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 35)
        Me.Panel1.TabIndex = 15
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(150, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "MDev Technologies 70494362"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightYellow
        Me.Label1.Image = Global.EEMS.My.Resources.Resources.icon_16_39
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(177, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "      برنامج ادارة مولّدات الكهرباء"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Yellow
        Me.Version.Location = New System.Drawing.Point(257, 152)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(97, 20)
        Me.Version.TabIndex = 16
        Me.Version.Text = "v {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnok
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(366, 221)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صفحة الدخول"
        Me.TopMost = True
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label

End Class
