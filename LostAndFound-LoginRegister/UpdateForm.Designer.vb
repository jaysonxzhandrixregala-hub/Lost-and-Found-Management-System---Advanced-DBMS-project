<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        itemName_Box = New TextBox()
        cmb_createId = New ComboBox()
        updateBtn = New Button()
        CloseBtn = New Button()
        locationBox = New TextBox()
        descBox = New TextBox()
        Label3 = New Label()
        datelabel = New Label()
        lfllabel = New Label()
        categorylabel = New Label()
        descriptionlabel = New Label()
        Label2 = New Label()
        selectitemidlabel = New Label()
        cmbCategory = New ComboBox()
        dtp_update = New DateTimePicker()
        cmbStatus = New ComboBox()
        SearchBtn = New Button()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Coral
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1264, 100)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 86)
        Label1.TabIndex = 0
        Label1.Text = "UPDATE "
        ' 
        ' itemName_Box
        ' 
        itemName_Box.Anchor = AnchorStyles.None
        itemName_Box.Font = New Font("Segoe UI", 12F)
        itemName_Box.Location = New Point(406, 191)
        itemName_Box.Name = "itemName_Box"
        itemName_Box.Size = New Size(427, 29)
        itemName_Box.TabIndex = 1
        ' 
        ' cmb_createId
        ' 
        cmb_createId.Anchor = AnchorStyles.None
        cmb_createId.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_createId.Font = New Font("Segoe UI", 12F)
        cmb_createId.FormattingEnabled = True
        cmb_createId.Location = New Point(406, 143)
        cmb_createId.Name = "cmb_createId"
        cmb_createId.Size = New Size(427, 29)
        cmb_createId.TabIndex = 2
        ' 
        ' updateBtn
        ' 
        updateBtn.Anchor = AnchorStyles.Bottom
        updateBtn.BackColor = Color.Coral
        updateBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateBtn.Location = New Point(479, 515)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(280, 45)
        updateBtn.TabIndex = 3
        updateBtn.Text = "UPDATE"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' CloseBtn
        ' 
        CloseBtn.Anchor = AnchorStyles.Bottom
        CloseBtn.BackColor = SystemColors.ActiveBorder
        CloseBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseBtn.Location = New Point(479, 566)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(280, 45)
        CloseBtn.TabIndex = 4
        CloseBtn.Text = "Close"
        CloseBtn.UseVisualStyleBackColor = False
        ' 
        ' locationBox
        ' 
        locationBox.Anchor = AnchorStyles.None
        locationBox.Font = New Font("Segoe UI", 12F)
        locationBox.Location = New Point(406, 238)
        locationBox.Name = "locationBox"
        locationBox.Size = New Size(427, 29)
        locationBox.TabIndex = 5
        ' 
        ' descBox
        ' 
        descBox.Anchor = AnchorStyles.None
        descBox.Font = New Font("Segoe UI", 12F)
        descBox.Location = New Point(406, 287)
        descBox.Name = "descBox"
        descBox.Size = New Size(427, 29)
        descBox.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(345, 442)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 21)
        Label3.TabIndex = 19
        Label3.Text = "Status:"
        ' 
        ' datelabel
        ' 
        datelabel.Anchor = AnchorStyles.None
        datelabel.AutoSize = True
        datelabel.Font = New Font("Segoe UI", 12F)
        datelabel.Location = New Point(355, 394)
        datelabel.Name = "datelabel"
        datelabel.Size = New Size(45, 21)
        datelabel.TabIndex = 18
        datelabel.Text = "Date:"
        ' 
        ' lfllabel
        ' 
        lfllabel.Anchor = AnchorStyles.None
        lfllabel.AutoSize = True
        lfllabel.Font = New Font("Segoe UI", 12F)
        lfllabel.Location = New Point(245, 241)
        lfllabel.Name = "lfllabel"
        lfllabel.Size = New Size(155, 21)
        lfllabel.TabIndex = 17
        lfllabel.Text = "Location Found/Lost:"
        ' 
        ' categorylabel
        ' 
        categorylabel.Anchor = AnchorStyles.None
        categorylabel.AutoSize = True
        categorylabel.Font = New Font("Segoe UI", 12F)
        categorylabel.Location = New Point(324, 341)
        categorylabel.Name = "categorylabel"
        categorylabel.Size = New Size(76, 21)
        categorylabel.TabIndex = 16
        categorylabel.Text = "Category:"
        ' 
        ' descriptionlabel
        ' 
        descriptionlabel.Anchor = AnchorStyles.None
        descriptionlabel.AutoSize = True
        descriptionlabel.Font = New Font("Segoe UI", 12F)
        descriptionlabel.Location = New Point(308, 290)
        descriptionlabel.Name = "descriptionlabel"
        descriptionlabel.Size = New Size(92, 21)
        descriptionlabel.TabIndex = 15
        descriptionlabel.Text = "Description:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(310, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 21)
        Label2.TabIndex = 14
        Label2.Text = "Item Name:"
        ' 
        ' selectitemidlabel
        ' 
        selectitemidlabel.Anchor = AnchorStyles.None
        selectitemidlabel.AutoSize = True
        selectitemidlabel.Font = New Font("Segoe UI", 12F)
        selectitemidlabel.Location = New Point(292, 146)
        selectitemidlabel.Name = "selectitemidlabel"
        selectitemidlabel.Size = New Size(108, 21)
        selectitemidlabel.TabIndex = 13
        selectitemidlabel.Text = "Select Item ID:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Anchor = AnchorStyles.None
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Segoe UI", 12F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Electronics & Gadgets", "IDs, Wallets & Cards", "Keys & Access", "Bags & Luggage", "Apparel & Eyewear", "Jewelry & Keepsakes", "Drinkware & Containers", "Books & Stationery", "Sports & Outdoor", "Perishables & Medical"})
        cmbCategory.Location = New Point(406, 338)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(427, 29)
        cmbCategory.TabIndex = 20
        ' 
        ' dtp_update
        ' 
        dtp_update.Anchor = AnchorStyles.None
        dtp_update.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtp_update.Location = New Point(406, 388)
        dtp_update.Name = "dtp_update"
        dtp_update.Size = New Size(427, 29)
        dtp_update.TabIndex = 21
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.None
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Font = New Font("Segoe UI", 12F)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Lost", "Found"})
        cmbStatus.Location = New Point(406, 439)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(427, 29)
        cmbStatus.TabIndex = 22
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Anchor = AnchorStyles.None
        SearchBtn.BackColor = Color.Coral
        SearchBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SearchBtn.Location = New Point(839, 133)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(108, 45)
        SearchBtn.TabIndex = 23
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' UpdateForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(1264, 681)
        Controls.Add(SearchBtn)
        Controls.Add(cmbStatus)
        Controls.Add(dtp_update)
        Controls.Add(cmbCategory)
        Controls.Add(Label3)
        Controls.Add(datelabel)
        Controls.Add(lfllabel)
        Controls.Add(categorylabel)
        Controls.Add(descriptionlabel)
        Controls.Add(Label2)
        Controls.Add(selectitemidlabel)
        Controls.Add(descBox)
        Controls.Add(locationBox)
        Controls.Add(CloseBtn)
        Controls.Add(updateBtn)
        Controls.Add(cmb_createId)
        Controls.Add(itemName_Box)
        Controls.Add(FlowLayoutPanel1)
        MinimumSize = New Size(1024, 576)
        Name = "UpdateForm"
        Text = "UpdateForm"
        WindowState = FormWindowState.Maximized
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents itemName_Box As TextBox
    Friend WithEvents cmb_createId As ComboBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents locationBox As TextBox
    Friend WithEvents descBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents datelabel As Label
    Friend WithEvents lfllabel As Label
    Friend WithEvents categorylabel As Label
    Friend WithEvents descriptionlabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents selectitemidlabel As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents dtp_update As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents SearchBtn As Button
End Class
