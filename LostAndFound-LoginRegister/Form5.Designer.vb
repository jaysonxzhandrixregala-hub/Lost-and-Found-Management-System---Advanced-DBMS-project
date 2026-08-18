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
        Panel1 = New Panel()
        rvitemslabel = New Label()
        searchlabel = New Label()
        TextBox1 = New TextBox()
        searchbutton = New Button()
        viewClose_btn = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(rvitemslabel)
        Panel1.Location = New Point(-4, -20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1912, 205)
        Panel1.TabIndex = 0
        ' 
        ' rvitemslabel
        ' 
        rvitemslabel.AutoSize = True
        rvitemslabel.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rvitemslabel.Location = New Point(531, 49)
        rvitemslabel.Name = "rvitemslabel"
        rvitemslabel.Size = New Size(923, 128)
        rvitemslabel.TabIndex = 0
        rvitemslabel.Text = "READ / VIEW ITEMS"
        ' 
        ' searchlabel
        ' 
        searchlabel.AutoSize = True
        searchlabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchlabel.Location = New Point(546, 247)
        searchlabel.Name = "searchlabel"
        searchlabel.Size = New Size(107, 40)
        searchlabel.TabIndex = 1
        searchlabel.Text = "Search:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(705, 244)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(414, 46)
        TextBox1.TabIndex = 2
        ' 
        ' searchbutton
        ' 
        searchbutton.BackColor = SystemColors.ActiveBorder
        searchbutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchbutton.Location = New Point(1160, 242)
        searchbutton.Name = "searchbutton"
        searchbutton.Size = New Size(234, 51)
        searchbutton.TabIndex = 3
        searchbutton.Text = "Search"
        searchbutton.UseVisualStyleBackColor = False
        ' 
        ' viewClose_btn
        ' 
        viewClose_btn.BackColor = SystemColors.ActiveBorder
        viewClose_btn.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        viewClose_btn.Location = New Point(1149, 908)
        viewClose_btn.Name = "viewClose_btn"
        viewClose_btn.Size = New Size(234, 61)
        viewClose_btn.TabIndex = 5
        viewClose_btn.Text = "Close"
        viewClose_btn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(555, 364)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(839, 500)
        DataGridView1.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Item Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 180
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Category"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Location"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Date"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 120
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Status"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 120
        ' 
        ' view_window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(1904, 1041)
        Controls.Add(DataGridView1)
        Controls.Add(viewClose_btn)
        Controls.Add(searchbutton)
        Controls.Add(TextBox1)
        Controls.Add(searchlabel)
        Controls.Add(Panel1)
        Name = "view_window"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rvitemslabel As Label
    Friend WithEvents searchlabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents searchbutton As Button
    Friend WithEvents viewClose_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
