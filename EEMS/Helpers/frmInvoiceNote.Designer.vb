﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 41)
        Me.TextBox1.MaxLength = 100
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(357, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(81, 13)
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
        Me.Button1.Location = New System.Drawing.Point(12, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(357, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "متابعة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkverbose
        '
        Me.chkverbose.AutoSize = True
        Me.chkverbose.Location = New System.Drawing.Point(222, 67)
        Me.chkverbose.Name = "chkverbose"
        Me.chkverbose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkverbose.Size = New System.Drawing.Size(147, 17)
        Me.chkverbose.TabIndex = 4
        Me.chkverbose.Text = "طباعة التأمين والمكسورات"
        Me.chkverbose.UseVisualStyleBackColor = True
        '
        'chkOrderByCust
        '
        Me.chkOrderByCust.AutoSize = True
        Me.chkOrderByCust.Location = New System.Drawing.Point(241, 90)
        Me.chkOrderByCust.Name = "chkOrderByCust"
        Me.chkOrderByCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkOrderByCust.Size = New System.Drawing.Size(128, 17)
        Me.chkOrderByCust.TabIndex = 5
        Me.chkOrderByCust.Text = "ترتيب حسب المشترك"
        Me.chkOrderByCust.UseVisualStyleBackColor = True
        '
        'chkCreditByCust
        '
        Me.chkCreditByCust.AutoSize = True
        Me.chkCreditByCust.Location = New System.Drawing.Point(167, 113)
        Me.chkCreditByCust.Name = "chkCreditByCust"
        Me.chkCreditByCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkCreditByCust.Size = New System.Drawing.Size(202, 17)
        Me.chkCreditByCust.TabIndex = 6
        Me.chkCreditByCust.Text = "جمع مكسورات الزبون من كل اشتراكاته"
        Me.chkCreditByCust.UseVisualStyleBackColor = True
        '
        'frmInvoiceNote
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 190)
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
End Class
