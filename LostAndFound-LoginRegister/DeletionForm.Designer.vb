<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletionForm
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
        Label1 = New Label()
        SearchBtn = New Button()
        cmbStatus = New ComboBox()
        dtp_update = New DateTimePicker()
        cmbCategory = New ComboBox()
        Label3 = New Label()
        datelabel = New Label()
        lfllabel = New Label()
        categorylabel = New Label()
        descriptionlabel = New Label()
        Label2 = New Label()
        selectitemidlabel = New Label()
        descBox = New TextBox()
        locationBox = New TextBox()
        CloseBtn = New Button()
        updateBtn = New Button()
        cmb_createId = New ComboBox()
        itemName_Box = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1264, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 86)
        Label1.TabIndex = 1
        Label1.Text = "DELETE"
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Anchor = AnchorStyles.None
        SearchBtn.BackColor = Color.Firebrick
        SearchBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SearchBtn.Location = New Point(850, 143)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(108, 45)
        SearchBtn.TabIndex = 40
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.None
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Font = New Font("Segoe UI", 12F)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Lost", "Found"})
        cmbStatus.Location = New Point(417, 449)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(427, 29)
        cmbStatus.TabIndex = 39
        ' 
        ' dtp_update
        ' 
        dtp_update.Anchor = AnchorStyles.None
        dtp_update.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtp_update.Location = New Point(417, 398)
        dtp_update.Name = "dtp_update"
        dtp_update.Size = New Size(427, 29)
        dtp_update.TabIndex = 38
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Anchor = AnchorStyles.None
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Segoe UI", 12F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Electronics & Gadgets", "IDs, Wallets & Cards", "Keys & Access", "Bags & Luggage", "Apparel & Eyewear", "Jewelry & Keepsakes", "Drinkware & Containers", "Books & Stationery", "Sports & Outdoor", "Perishables & Medical"})
        cmbCategory.Location = New Point(417, 348)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(427, 29)
        cmbCategory.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(356, 452)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 21)
        Label3.TabIndex = 36
        Label3.Text = "Status:"
        ' 
        ' datelabel
        ' 
        datelabel.Anchor = AnchorStyles.None
        datelabel.AutoSize = True
        datelabel.Font = New Font("Segoe UI", 12F)
        datelabel.Location = New Point(366, 404)
        datelabel.Name = "datelabel"
        datelabel.Size = New Size(45, 21)
        datelabel.TabIndex = 35
        datelabel.Text = "Date:"
        ' 
        ' lfllabel
        ' 
        lfllabel.Anchor = AnchorStyles.None
        lfllabel.AutoSize = True
        lfllabel.Font = New Font("Segoe UI", 12F)
        lfllabel.Location = New Point(256, 251)
        lfllabel.Name = "lfllabel"
        lfllabel.Size = New Size(155, 21)
        lfllabel.TabIndex = 34
        lfllabel.Text = "Location Found/Lost:"
        ' 
        ' categorylabel
        ' 
        categorylabel.Anchor = AnchorStyles.None
        categorylabel.AutoSize = True
        categorylabel.Font = New Font("Segoe UI", 12F)
        categorylabel.Location = New Point(335, 351)
        categorylabel.Name = "categorylabel"
        categorylabel.Size = New Size(76, 21)
        categorylabel.TabIndex = 33
        categorylabel.Text = "Category:"
        ' 
        ' descriptionlabel
        ' 
        descriptionlabel.Anchor = AnchorStyles.None
        descriptionlabel.AutoSize = True
        descriptionlabel.Font = New Font("Segoe UI", 12F)
        descriptionlabel.Location = New Point(319, 300)
        descriptionlabel.Name = "descriptionlabel"
        descriptionlabel.Size = New Size(92, 21)
        descriptionlabel.TabIndex = 32
        descriptionlabel.Text = "Description:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(321, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 21)
        Label2.TabIndex = 31
        Label2.Text = "Item Name:"
        ' 
        ' selectitemidlabel
        ' 
        selectitemidlabel.Anchor = AnchorStyles.None
        selectitemidlabel.AutoSize = True
        selectitemidlabel.Font = New Font("Segoe UI", 12F)
        selectitemidlabel.Location = New Point(303, 156)
        selectitemidlabel.Name = "selectitemidlabel"
        selectitemidlabel.Size = New Size(108, 21)
        selectitemidlabel.TabIndex = 30
        selectitemidlabel.Text = "Select Item ID:"
        ' 
        ' descBox
        ' 
        descBox.Anchor = AnchorStyles.None
        descBox.Font = New Font("Segoe UI", 12F)
        descBox.Location = New Point(417, 297)
        descBox.Name = "descBox"
        descBox.Size = New Size(427, 29)
        descBox.TabIndex = 29
        ' 
        ' locationBox
        ' 
        locationBox.Anchor = AnchorStyles.None
        locationBox.Font = New Font("Segoe UI", 12F)
        locationBox.Location = New Point(417, 248)
        locationBox.Name = "locationBox"
        locationBox.Size = New Size(427, 29)
        locationBox.TabIndex = 28
        ' 
        ' CloseBtn
        ' 
        CloseBtn.Anchor = AnchorStyles.Bottom
        CloseBtn.BackColor = SystemColors.ActiveBorder
        CloseBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseBtn.Location = New Point(490, 576)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(280, 45)
        CloseBtn.TabIndex = 27
        CloseBtn.Text = "Close"
        CloseBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.Anchor = AnchorStyles.Bottom
        updateBtn.BackColor = Color.Firebrick
        updateBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateBtn.Location = New Point(490, 525)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(280, 45)
        updateBtn.TabIndex = 26
        updateBtn.Text = "UPDATE"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' cmb_createId
        ' 
        cmb_createId.Anchor = AnchorStyles.None
        cmb_createId.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_createId.Font = New Font("Segoe UI", 12F)
        cmb_createId.FormattingEnabled = True
        cmb_createId.Location = New Point(417, 153)
        cmb_createId.Name = "cmb_createId"
        cmb_createId.Size = New Size(427, 29)
        cmb_createId.TabIndex = 25
        ' 
        ' itemName_Box
        ' 
        itemName_Box.Anchor = AnchorStyles.None
        itemName_Box.Font = New Font("Segoe UI", 12F)
        itemName_Box.Location = New Point(417, 201)
        itemName_Box.Name = "itemName_Box"
        itemName_Box.Size = New Size(427, 29)
        itemName_Box.TabIndex = 24
        ' 
        ' DeletionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
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
        Controls.Add(Panel1)
        MinimumSize = New Size(1024, 576)
        Name = "DeletionForm"
        Text = "DeletionForm"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtp_update As DateTimePicker
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents datelabel As Label
    Friend WithEvents lfllabel As Label
    Friend WithEvents categorylabel As Label
    Friend WithEvents descriptionlabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents selectitemidlabel As Label
    Friend WithEvents descBox As TextBox
    Friend WithEvents locationBox As TextBox
    Friend WithEvents CloseBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents cmb_createId As ComboBox
    Friend WithEvents itemName_Box As TextBox
End Class
