<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCounterHistoryEditDialog
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
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNew
        '
        Me.txtNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNew.Location = New System.Drawing.Point(12, 71)
        Me.txtNew.MaxLength = 50
        Me.txtNew.Name = "txtNew"
        Me.txtNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNew.Size = New System.Drawing.Size(197, 20)
        Me.txtNew.TabIndex = 0
        Me.txtNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOld
        '
        Me.txtOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOld.Location = New System.Drawing.Point(12, 25)
        Me.txtOld.MaxLength = 50
        Me.txtOld.Name = "txtOld"
        Me.txtOld.ReadOnly = True
        Me.txtOld.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOld.Size = New System.Drawing.Size(197, 20)
        Me.txtOld.TabIndex = 1
        Me.txtOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "القيمة السابقة:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "القيمة الحاليّة:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCounterHistoryEditDialog
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 158)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.txtNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCounterHistoryEditDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعديل قيمة العداد"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
