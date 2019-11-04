<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataViewer
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
        Me.btnExportExcell = New System.Windows.Forms.Button()
        Me.dgvData1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnShowPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportExcell
        '
        Me.btnExportExcell.Image = Global.EEMS.My.Resources.Resources.xls
        Me.btnExportExcell.Location = New System.Drawing.Point(12, 106)
        Me.btnExportExcell.Name = "btnExportExcell"
        Me.btnExportExcell.Size = New System.Drawing.Size(102, 33)
        Me.btnExportExcell.TabIndex = 4
        Me.btnExportExcell.Text = "تصدير اكسل"
        Me.btnExportExcell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportExcell.UseVisualStyleBackColor = True
        '
        'dgvData1
        '
        Me.dgvData1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData1.Location = New System.Drawing.Point(12, 145)
        Me.dgvData1.MainView = Me.GridView1
        Me.dgvData1.Name = "dgvData1"
        Me.dgvData1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvData1.Size = New System.Drawing.Size(1102, 412)
        Me.dgvData1.TabIndex = 39
        Me.dgvData1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.LightCyan
        Me.GridView1.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.LightCyan
        Me.GridView1.GridControl = Me.dgvData1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnShowPrint
        '
        Me.btnShowPrint.Image = Global.EEMS.My.Resources.Resources.printer16
        Me.btnShowPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowPrint.Location = New System.Drawing.Point(120, 106)
        Me.btnShowPrint.Name = "btnShowPrint"
        Me.btnShowPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowPrint.Size = New System.Drawing.Size(135, 33)
        Me.btnShowPrint.TabIndex = 40
        Me.btnShowPrint.Text = "عرض وطباعة"
        Me.btnShowPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnShowPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(432, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(588, 33)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "تقرير"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(1128, 100)
        Me.Panel1.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.EEMS.My.Resources.Resources.icon__4_
        Me.PictureBox1.Location = New System.Drawing.Point(1031, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmDataViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 569)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnShowPrint)
        Me.Controls.Add(Me.dgvData1)
        Me.Controls.Add(Me.btnExportExcell)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDataViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDataViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExportExcell As System.Windows.Forms.Button
    Friend WithEvents dgvData1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnShowPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
