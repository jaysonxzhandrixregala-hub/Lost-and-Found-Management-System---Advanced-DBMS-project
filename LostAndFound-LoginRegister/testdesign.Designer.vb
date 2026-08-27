<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class testdesign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.uiPanelHeader = New System.Windows.Forms.Panel()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.viewClose_btn = New System.Windows.Forms.Button()
        Me.uiLabelSubtitle = New System.Windows.Forms.Label()
        Me.uiLabelTitle = New System.Windows.Forms.Label()
        Me.uiPanelGrid = New System.Windows.Forms.Panel()
        Me.dgvLnf = New System.Windows.Forms.DataGridView()
        Me.uiPanelHeader.SuspendLayout()
        Me.uiPanelGrid.SuspendLayout()
        CType(Me.dgvLnf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' uiPanelHeader
        '
        Me.uiPanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.uiPanelHeader.Controls.Add(Me.refreshBtn)
        Me.uiPanelHeader.Controls.Add(Me.viewClose_btn)
        Me.uiPanelHeader.Controls.Add(Me.uiLabelSubtitle)
        Me.uiPanelHeader.Controls.Add(Me.uiLabelTitle)
        Me.uiPanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.uiPanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.uiPanelHeader.Name = "uiPanelHeader"
        Me.uiPanelHeader.Size = New System.Drawing.Size(1920, 110)
        Me.uiPanelHeader.TabIndex = 0
        '
        ' refreshBtn
        '
        Me.refreshBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.FlatAppearance.BorderSize = 0
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.refreshBtn.ForeColor = System.Drawing.Color.White
        Me.refreshBtn.Location = New System.Drawing.Point(1705, 38)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(130, 42)
        Me.refreshBtn.TabIndex = 3
        Me.refreshBtn.Text = "↻ Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = False
        '
        ' viewClose_btn
        '
        Me.viewClose_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewClose_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewClose_btn.FlatAppearance.BorderSize = 0
        Me.viewClose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewClose_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.viewClose_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.viewClose_btn.Location = New System.Drawing.Point(1860, 20)
        Me.viewClose_btn.Name = "viewClose_btn"
        Me.viewClose_btn.Size = New System.Drawing.Size(35, 35)
        Me.viewClose_btn.TabIndex = 0
        Me.viewClose_btn.Text = "✕"
        Me.viewClose_btn.UseVisualStyleBackColor = True
        '
        ' uiLabelSubtitle
        '
        Me.uiLabelSubtitle.AutoSize = True
        Me.uiLabelSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.uiLabelSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.uiLabelSubtitle.Location = New System.Drawing.Point(40, 65)
        Me.uiLabelSubtitle.Name = "uiLabelSubtitle"
        Me.uiLabelSubtitle.Size = New System.Drawing.Size(262, 19)
        Me.uiLabelSubtitle.TabIndex = 2
        Me.uiLabelSubtitle.Text = "Manage and track lost and found items"
        '
        ' uiLabelTitle
        '
        Me.uiLabelTitle.AutoSize = True
        Me.uiLabelTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.uiLabelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.uiLabelTitle.Location = New System.Drawing.Point(36, 22)
        Me.uiLabelTitle.Name = "uiLabelTitle"
        Me.uiLabelTitle.Size = New System.Drawing.Size(315, 40)
        Me.uiLabelTitle.TabIndex = 1
        Me.uiLabelTitle.Text = "Lost & Found Registry"
        '
        ' uiPanelGrid
        '
        Me.uiPanelGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uiPanelGrid.BackColor = System.Drawing.Color.White
        Me.uiPanelGrid.Controls.Add(Me.dgvLnf)
        Me.uiPanelGrid.Location = New System.Drawing.Point(40, 130)
        Me.uiPanelGrid.Name = "uiPanelGrid"
        Me.uiPanelGrid.Padding = New System.Windows.Forms.Padding(1)
        Me.uiPanelGrid.Size = New System.Drawing.Size(1840, 900)
        Me.uiPanelGrid.TabIndex = 1
        '
        ' dgvLnf
        '
        Me.dgvLnf.AllowUserToAddRows = False
        Me.dgvLnf.AllowUserToDeleteRows = False
        Me.dgvLnf.AllowUserToResizeRows = False
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.dgvLnf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
        Me.dgvLnf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLnf.BackgroundColor = System.Drawing.Color.White
        Me.dgvLnf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLnf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvLnf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLnf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
        Me.dgvLnf.ColumnHeadersHeight = 48
        Me.dgvLnf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        dataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLnf.DefaultCellStyle = dataGridViewCellStyle3
        Me.dgvLnf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLnf.EnableHeadersVisualStyles = False
        Me.dgvLnf.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvLnf.Location = New System.Drawing.Point(1, 1)
        Me.dgvLnf.MultiSelect = False
        Me.dgvLnf.Name = "dgvLnf"
        Me.dgvLnf.ReadOnly = True
        Me.dgvLnf.RowHeadersVisible = False
        Me.dgvLnf.RowTemplate.Height = 45
        Me.dgvLnf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLnf.Size = New System.Drawing.Size(1838, 898)
        Me.dgvLnf.TabIndex = 0
        '
        ' testdesign
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.uiPanelGrid)
        Me.Controls.Add(Me.uiPanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "testdesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "testdesign"
        Me.uiPanelHeader.ResumeLayout(False)
        Me.uiPanelHeader.PerformLayout()
        Me.uiPanelGrid.ResumeLayout(False)
        CType(Me.dgvLnf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uiPanelHeader As System.Windows.Forms.Panel
    Friend WithEvents uiLabelTitle As System.Windows.Forms.Label
    Friend WithEvents uiLabelSubtitle As System.Windows.Forms.Label
    Friend WithEvents viewClose_btn As System.Windows.Forms.Button
    Friend WithEvents refreshBtn As System.Windows.Forms.Button
    Friend WithEvents uiPanelGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvLnf As System.Windows.Forms.DataGridView
End Class