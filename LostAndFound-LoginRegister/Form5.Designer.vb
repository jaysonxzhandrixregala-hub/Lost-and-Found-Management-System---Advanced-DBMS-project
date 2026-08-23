<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_window
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        rvitemslabel = New Label()
        searchlabel = New Label()
        TextBox1 = New TextBox()
        searchbutton = New Button()
        viewClose_btn = New Button()
        dgvLnf = New DataGridView()
        UserSessionBindingSource = New BindingSource(components)
        TLP_datagrid = New TableLayoutPanel()
        refreshBtn = New Button()
        Panel1.SuspendLayout()
        CType(dgvLnf, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserSessionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        TLP_datagrid.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(rvitemslabel)
        Panel1.Location = New Point(-6, -33)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2731, 342)
        Panel1.TabIndex = 0
        ' 
        ' rvitemslabel
        ' 
        rvitemslabel.Anchor = AnchorStyles.Top
        rvitemslabel.AutoSize = True
        rvitemslabel.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rvitemslabel.Location = New Point(759, 82)
        rvitemslabel.Margin = New Padding(4, 0, 4, 0)
        rvitemslabel.Name = "rvitemslabel"
        rvitemslabel.Size = New Size(1383, 191)
        rvitemslabel.TabIndex = 0
        rvitemslabel.Text = "READ / VIEW ITEMS"
        ' 
        ' searchlabel
        ' 
        searchlabel.Anchor = AnchorStyles.Top
        searchlabel.AutoSize = True
        searchlabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchlabel.Location = New Point(780, 412)
        searchlabel.Margin = New Padding(4, 0, 4, 0)
        searchlabel.Name = "searchlabel"
        searchlabel.Size = New Size(163, 60)
        searchlabel.TabIndex = 1
        searchlabel.Text = "Search:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(1007, 407)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(590, 65)
        TextBox1.TabIndex = 2
        ' 
        ' searchbutton
        ' 
        searchbutton.Anchor = AnchorStyles.Top
        searchbutton.BackColor = SystemColors.ActiveBorder
        searchbutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchbutton.Location = New Point(1657, 403)
        searchbutton.Margin = New Padding(4, 5, 4, 5)
        searchbutton.Name = "searchbutton"
        searchbutton.Size = New Size(334, 85)
        searchbutton.TabIndex = 3
        searchbutton.Text = "Search"
        searchbutton.UseVisualStyleBackColor = False
        ' 
        ' viewClose_btn
        ' 
        viewClose_btn.Anchor = AnchorStyles.Bottom
        viewClose_btn.BackColor = SystemColors.ActiveBorder
        viewClose_btn.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        viewClose_btn.Location = New Point(1641, 1513)
        viewClose_btn.Margin = New Padding(4, 5, 4, 5)
        viewClose_btn.Name = "viewClose_btn"
        viewClose_btn.Size = New Size(334, 102)
        viewClose_btn.TabIndex = 5
        viewClose_btn.Text = "Close"
        viewClose_btn.UseVisualStyleBackColor = False
        ' 
        ' dgvLnf
        ' 
        dgvLnf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLnf.Location = New Point(4, 5)
        dgvLnf.Margin = New Padding(4, 5, 4, 5)
        dgvLnf.Name = "dgvLnf"
        dgvLnf.RowHeadersWidth = 62
        dgvLnf.Size = New Size(1199, 833)
        dgvLnf.TabIndex = 6
        ' 
        ' UserSessionBindingSource
        ' 
        UserSessionBindingSource.DataSource = GetType(UserSession)
        ' 
        ' TLP_datagrid
        ' 
        TLP_datagrid.Anchor = AnchorStyles.None
        TLP_datagrid.ColumnCount = 1
        TLP_datagrid.ColumnStyles.Add(New ColumnStyle())
        TLP_datagrid.Controls.Add(dgvLnf, 0, 0)
        TLP_datagrid.Location = New Point(801, 615)
        TLP_datagrid.Name = "TLP_datagrid"
        TLP_datagrid.RowCount = 1
        TLP_datagrid.RowStyles.Add(New RowStyle())
        TLP_datagrid.Size = New Size(1199, 833)
        TLP_datagrid.TabIndex = 7
        ' 
        ' refreshBtn
        ' 
        refreshBtn.Anchor = AnchorStyles.Top
        refreshBtn.BackColor = SystemColors.ActiveBorder
        refreshBtn.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        refreshBtn.Location = New Point(1883, 498)
        refreshBtn.Margin = New Padding(4, 5, 4, 5)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(108, 109)
        refreshBtn.TabIndex = 8
        refreshBtn.Text = "🔄"
        refreshBtn.UseVisualStyleBackColor = False
        ' 
        ' view_window
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(2720, 1735)
        Controls.Add(refreshBtn)
        Controls.Add(TLP_datagrid)
        Controls.Add(viewClose_btn)
        Controls.Add(searchbutton)
        Controls.Add(TextBox1)
        Controls.Add(searchlabel)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(1280, 720)
        Name = "view_window"
        Text = "Form5"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvLnf, ComponentModel.ISupportInitialize).EndInit()
        CType(UserSessionBindingSource, ComponentModel.ISupportInitialize).EndInit()
        TLP_datagrid.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rvitemslabel As Label
    Friend WithEvents searchlabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents searchbutton As Button
    Friend WithEvents viewClose_btn As Button
    Friend WithEvents dgvLnf As DataGridView
    Friend WithEvents UserSessionBindingSource As BindingSource
    Friend WithEvents TLP_datagrid As TableLayoutPanel
    Friend WithEvents refreshBtn As Button
End Class
