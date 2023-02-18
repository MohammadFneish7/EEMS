<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceNote))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkverbose = New System.Windows.Forms.CheckBox()
        Me.chkOrderByCust = New System.Windows.Forms.CheckBox()
        Me.chkCreditByCust = New System.Windows.Forms.CheckBox()
        Me.chkdollarprice = New System.Windows.Forms.CheckBox()
        Me.chkdollartotal = New System.Windows.Forms.CheckBox()
        Me.chkalltodollar = New System.Windows.Forms.CheckBox()
        Me.chkaddkilo = New System.Windows.Forms.CheckBox()
        Me.chkadddiscount = New System.Windows.Forms.CheckBox()
        Me.chkcreditsindollar = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 41)
        Me.TextBox1.MaxLength = 150
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(357, 43)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ملاحظة الفواتير:"
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Location = New System.Drawing.Point(12, 16)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(13, 13)
        Me.lblcount.TabIndex = 2
        Me.lblcount.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(357, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "متابعة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkverbose
        '
        Me.chkverbose.AutoSize = True
        Me.chkverbose.Location = New System.Drawing.Point(221, 159)
        Me.chkverbose.Name = "chkverbose"
        Me.chkverbose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkverbose.Size = New System.Drawing.Size(146, 17)
        Me.chkverbose.TabIndex = 4
        Me.chkverbose.Text = "إضافة التأمين والمكسورات"
        Me.chkverbose.UseVisualStyleBackColor = True
        '
        'chkOrderByCust
        '
        Me.chkOrderByCust.AutoSize = True
        Me.chkOrderByCust.Location = New System.Drawing.Point(249, 90)
        Me.chkOrderByCust.Name = "chkOrderByCust"
        Me.chkOrderByCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkOrderByCust.Size = New System.Drawing.Size(118, 17)
        Me.chkOrderByCust.TabIndex = 5
        Me.chkOrderByCust.Text = "ترتيب حسب المشترك"
        Me.chkOrderByCust.UseVisualStyleBackColor = True
        '
        'chkCreditByCust
        '
        Me.chkCreditByCust.AutoSize = True
        Me.chkCreditByCust.Location = New System.Drawing.Point(166, 182)
        Me.chkCreditByCust.Name = "chkCreditByCust"
        Me.chkCreditByCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkCreditByCust.Size = New System.Drawing.Size(201, 17)
        Me.chkCreditByCust.TabIndex = 6
        Me.chkCreditByCust.Text = "جمع مكسورات الزبون من كل اشتراكاته"
        Me.chkCreditByCust.UseVisualStyleBackColor = True
        '
        'chkdollarprice
        '
        Me.chkdollarprice.AutoSize = True
        Me.chkdollarprice.BackColor = System.Drawing.Color.White
        Me.chkdollarprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkdollarprice.Location = New System.Drawing.Point(233, 205)
        Me.chkdollarprice.Name = "chkdollarprice"
        Me.chkdollarprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkdollarprice.Size = New System.Drawing.Size(134, 17)
        Me.chkdollarprice.TabIndex = 7
        Me.chkdollarprice.Text = "إضافة سعر صرف الدولار"
        Me.chkdollarprice.UseVisualStyleBackColor = False
        '
        'chkdollartotal
        '
        Me.chkdollartotal.AutoSize = True
        Me.chkdollartotal.BackColor = System.Drawing.Color.White
        Me.chkdollartotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkdollartotal.Location = New System.Drawing.Point(238, 251)
        Me.chkdollartotal.Name = "chkdollartotal"
        Me.chkdollartotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkdollartotal.Size = New System.Drawing.Size(129, 17)
        Me.chkdollartotal.TabIndex = 8
        Me.chkdollartotal.Text = "إضافة المجموع بالدولار"
        Me.chkdollartotal.UseVisualStyleBackColor = False
        '
        'chkalltodollar
        '
        Me.chkalltodollar.AutoSize = True
        Me.chkalltodollar.BackColor = System.Drawing.Color.White
        Me.chkalltodollar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkalltodollar.Location = New System.Drawing.Point(93, 274)
        Me.chkalltodollar.Name = "chkalltodollar"
        Me.chkalltodollar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkalltodollar.Size = New System.Drawing.Size(274, 17)
        Me.chkalltodollar.TabIndex = 9
        Me.chkalltodollar.Text = "تحويل كامل الفاتورة الى دولار على سعر صرف الفاتورة"
        Me.chkalltodollar.UseVisualStyleBackColor = False
        '
        'chkaddkilo
        '
        Me.chkaddkilo.AutoSize = True
        Me.chkaddkilo.Location = New System.Drawing.Point(250, 113)
        Me.chkaddkilo.Name = "chkaddkilo"
        Me.chkaddkilo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkaddkilo.Size = New System.Drawing.Size(117, 17)
        Me.chkaddkilo.TabIndex = 10
        Me.chkaddkilo.Text = "إضافة سعر الكيلوات"
        Me.chkaddkilo.UseVisualStyleBackColor = True
        '
        'chkadddiscount
        '
        Me.chkadddiscount.AutoSize = True
        Me.chkadddiscount.Location = New System.Drawing.Point(260, 136)
        Me.chkadddiscount.Name = "chkadddiscount"
        Me.chkadddiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkadddiscount.Size = New System.Drawing.Size(107, 17)
        Me.chkadddiscount.TabIndex = 11
        Me.chkadddiscount.Text = "إضافة قيمة الحسم"
        Me.chkadddiscount.UseVisualStyleBackColor = True
        '
        'chkcreditsindollar
        '
        Me.chkcreditsindollar.AutoSize = True
        Me.chkcreditsindollar.BackColor = System.Drawing.Color.White
        Me.chkcreditsindollar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkcreditsindollar.Location = New System.Drawing.Point(97, 228)
        Me.chkcreditsindollar.Name = "chkcreditsindollar"
        Me.chkcreditsindollar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkcreditsindollar.Size = New System.Drawing.Size(270, 17)
        Me.chkcreditsindollar.TabIndex = 12
        Me.chkcreditsindollar.Text = "إحتساب المكسورات بالدولار بحسب سعر صرف كل شهر"
        Me.chkcreditsindollar.UseVisualStyleBackColor = False
        '
        'frmInvoiceNote
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 358)
        Me.Controls.Add(Me.chkcreditsindollar)
        Me.Controls.Add(Me.chkadddiscount)
        Me.Controls.Add(Me.chkaddkilo)
        Me.Controls.Add(Me.chkalltodollar)
        Me.Controls.Add(Me.chkdollartotal)
        Me.Controls.Add(Me.chkdollarprice)
        Me.Controls.Add(Me.chkCreditByCust)
        Me.Controls.Add(Me.chkOrderByCust)
        Me.Controls.Add(Me.chkverbose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoiceNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة ملاحظة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkverbose As System.Windows.Forms.CheckBox
    Friend WithEvents chkOrderByCust As CheckBox
    Friend WithEvents chkCreditByCust As CheckBox
    Friend WithEvents chkdollarprice As CheckBox
    Friend WithEvents chkdollartotal As CheckBox
    Friend WithEvents chkalltodollar As CheckBox
    Friend WithEvents chkaddkilo As CheckBox
    Friend WithEvents chkadddiscount As CheckBox
    Friend WithEvents chkcreditsindollar As CheckBox
End Class
