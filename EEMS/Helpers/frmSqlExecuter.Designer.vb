<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSqlExecuter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSqlExecuter))
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvData1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnShowPrint = New System.Windows.Forms.Button()
        Me.chkisScalar = New System.Windows.Forms.CheckBox()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSQL
        '
        Me.txtSQL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQL.Location = New System.Drawing.Point(12, 33)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(937, 148)
        Me.txtSQL.TabIndex = 0
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Image = Global.EEMS.My.Resources.Resources.State_Validation_Valid
        Me.btnExecute.Location = New System.Drawing.Point(12, 187)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(781, 42)
        Me.btnExecute.TabIndex = 1
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExecute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SQL Query:"
        '
        'dgvData1
        '
        Me.dgvData1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData1.Location = New System.Drawing.Point(12, 235)
        Me.dgvData1.MainView = Me.GridView1
        Me.dgvData1.Name = "dgvData1"
        Me.dgvData1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2})
        Me.dgvData1.Size = New System.Drawing.Size(937, 357)
        Me.dgvData1.TabIndex = 40
        Me.dgvData1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.LightCyan
        Me.GridView1.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.LightCyan
        Me.GridView1.GridControl = Me.dgvData1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'btnShowPrint
        '
        Me.btnShowPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowPrint.Image = Global.EEMS.My.Resources.Resources.printer16
        Me.btnShowPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowPrint.Location = New System.Drawing.Point(799, 187)
        Me.btnShowPrint.Name = "btnShowPrint"
        Me.btnShowPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowPrint.Size = New System.Drawing.Size(150, 42)
        Me.btnShowPrint.TabIndex = 41
        Me.btnShowPrint.Text = "Print"
        Me.btnShowPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnShowPrint.UseVisualStyleBackColor = True
        '
        'chkisScalar
        '
        Me.chkisScalar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkisScalar.AutoSize = True
        Me.chkisScalar.Location = New System.Drawing.Point(894, 10)
        Me.chkisScalar.Name = "chkisScalar"
        Me.chkisScalar.Size = New System.Drawing.Size(55, 17)
        Me.chkisScalar.TabIndex = 42
        Me.chkisScalar.Text = "Scalar"
        Me.chkisScalar.UseVisualStyleBackColor = True
        '
        'SqlExecuter
        '
        Me.AcceptButton = Me.btnExecute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 604)
        Me.Controls.Add(Me.chkisScalar)
        Me.Controls.Add(Me.btnShowPrint)
        Me.Controls.Add(Me.dgvData1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtSQL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SqlExecuter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SqlExecuter"
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvData1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnShowPrint As System.Windows.Forms.Button
    Friend WithEvents chkisScalar As System.Windows.Forms.CheckBox
End Class
