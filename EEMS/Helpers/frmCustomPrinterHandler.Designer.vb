<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomPrinterHandler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomPrinterHandler))
        Me.dgv = New DevExpress.XtraGrid.GridControl()
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmbPaperSize = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbOrientation = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRowsOption = New System.Windows.Forms.ComboBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.Location = New System.Drawing.Point(9, 123)
        Me.dgv.MainView = Me.gv
        Me.dgv.Name = "dgv"
        Me.dgv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2})
        Me.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv.Size = New System.Drawing.Size(350, 260)
        Me.dgv.TabIndex = 42
        Me.dgv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.LightCyan
        Me.gv.GridControl = Me.dgv
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv.OptionsCustomization.AllowColumnMoving = False
        Me.gv.OptionsCustomization.AllowGroup = False
        Me.gv.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv.OptionsCustomization.AllowQuickHideColumns = False
        Me.gv.OptionsMenu.EnableColumnMenu = False
        Me.gv.OptionsMenu.EnableGroupPanelMenu = False
        Me.gv.OptionsPrint.EnableAppearanceOddRow = True
        Me.gv.OptionsSelection.MultiSelect = True
        Me.gv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(9, 16)
        Me.txtTitle.MaxLength = 25
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTitle.Size = New System.Drawing.Size(272, 20)
        Me.txtTitle.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "عنوان التقرير:"
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.EEMS.My.Resources.Resources.printer
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(9, 389)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPrint.Size = New System.Drawing.Size(350, 37)
        Me.btnPrint.TabIndex = 47
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cmbPaperSize
        '
        Me.cmbPaperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaperSize.FormattingEnabled = True
        Me.cmbPaperSize.Location = New System.Drawing.Point(9, 42)
        Me.cmbPaperSize.Name = "cmbPaperSize"
        Me.cmbPaperSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPaperSize.Size = New System.Drawing.Size(272, 21)
        Me.cmbPaperSize.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "حجم الصفحة:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "نوع الطباعة:"
        '
        'cmbOrientation
        '
        Me.cmbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrientation.FormattingEnabled = True
        Me.cmbOrientation.Items.AddRange(New Object() {"عامودي", "أفقي"})
        Me.cmbOrientation.Location = New System.Drawing.Point(9, 69)
        Me.cmbOrientation.Name = "cmbOrientation"
        Me.cmbOrientation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbOrientation.Size = New System.Drawing.Size(272, 21)
        Me.cmbOrientation.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "أسطر الطباعة:"
        '
        'cmbRowsOption
        '
        Me.cmbRowsOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRowsOption.FormattingEnabled = True
        Me.cmbRowsOption.Items.AddRange(New Object() {"كل الأسطر", "المحدّد فقط"})
        Me.cmbRowsOption.Location = New System.Drawing.Point(9, 96)
        Me.cmbRowsOption.Name = "cmbRowsOption"
        Me.cmbRowsOption.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRowsOption.Size = New System.Drawing.Size(272, 21)
        Me.cmbRowsOption.TabIndex = 53
        '
        'frmCustomPrinterHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 438)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbRowsOption)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbOrientation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbPaperSize)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomPrinterHandler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طباعة مخصصة"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmbPaperSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbOrientation As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbRowsOption As System.Windows.Forms.ComboBox
End Class
