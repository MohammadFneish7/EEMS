<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorDialog))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txterrorTitle = New System.Windows.Forms.Label()
        Me.txterror = New System.Windows.Forms.TextBox()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EEMS.My.Resources.Resources._001_bug
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txterrorTitle
        '
        Me.txterrorTitle.Location = New System.Drawing.Point(96, 9)
        Me.txterrorTitle.Name = "txterrorTitle"
        Me.txterrorTitle.Size = New System.Drawing.Size(245, 50)
        Me.txterrorTitle.TabIndex = 4
        Me.txterrorTitle.Text = "Msg"
        '
        'txterror
        '
        Me.txterror.BackColor = System.Drawing.Color.White
        Me.txterror.Location = New System.Drawing.Point(12, 65)
        Me.txterror.Multiline = True
        Me.txterror.Name = "txterror"
        Me.txterror.ReadOnly = True
        Me.txterror.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txterror.Size = New System.Drawing.Size(329, 155)
        Me.txterror.TabIndex = 6
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(12, 226)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 7
        Me.btnYes.Text = "خروج"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.EEMS.My.Resources.Resources.Action_New
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(93, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "نسخ"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorDialog
        '
        Me.AcceptButton = Me.btnYes
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.txterror)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txterrorTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ErrorDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "خطأ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txterrorTitle As System.Windows.Forms.Label
    Friend WithEvents txterror As System.Windows.Forms.TextBox
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
