<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateWindow
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
        cmbStatus = New ComboBox()
        dtp_delete = New DateTimePicker()
        cmbCategory = New ComboBox()
        Label3 = New Label()
        datelabel = New Label()
        lfllabel = New Label()
        categorylabel = New Label()
        descriptionlabel = New Label()
        Label2 = New Label()
        descBox = New TextBox()
        locationBox = New TextBox()
        CloseBtn = New Button()
        saveBtn = New Button()
        itemName_Box = New TextBox()
        clearbutton = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGreen
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
        Label1.Size = New Size(249, 86)
        Label1.TabIndex = 2
        Label1.Text = "CREATE"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.None
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Font = New Font("Segoe UI", 12F)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Lost", "Found"})
        cmbStatus.Location = New Point(420, 422)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(427, 29)
        cmbStatus.TabIndex = 36
        ' 
        ' dtp_delete
        ' 
        dtp_delete.Anchor = AnchorStyles.None
        dtp_delete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtp_delete.Location = New Point(420, 371)
        dtp_delete.Name = "dtp_delete"
        dtp_delete.Size = New Size(427, 29)
        dtp_delete.TabIndex = 35
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Anchor = AnchorStyles.None
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Segoe UI", 12F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Electronics & Gadgets", "IDs, Wallets & Cards", "Keys & Access", "Bags & Luggage", "Apparel & Eyewear", "Jewelry & Keepsakes", "Drinkware & Containers", "Books & Stationery", "Sports & Outdoor", "Perishables & Medical"})
        cmbCategory.Location = New Point(420, 321)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(427, 29)
        cmbCategory.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(359, 425)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 21)
        Label3.TabIndex = 33
        Label3.Text = "Status:"
        ' 
        ' datelabel
        ' 
        datelabel.Anchor = AnchorStyles.None
        datelabel.AutoSize = True
        datelabel.Font = New Font("Segoe UI", 12F)
        datelabel.Location = New Point(369, 377)
        datelabel.Name = "datelabel"
        datelabel.Size = New Size(45, 21)
        datelabel.TabIndex = 32
        datelabel.Text = "Date:"
        ' 
        ' lfllabel
        ' 
        lfllabel.Anchor = AnchorStyles.None
        lfllabel.AutoSize = True
        lfllabel.Font = New Font("Segoe UI", 12F)
        lfllabel.Location = New Point(259, 224)
        lfllabel.Name = "lfllabel"
        lfllabel.Size = New Size(155, 21)
        lfllabel.TabIndex = 31
        lfllabel.Text = "Location Found/Lost:"
        ' 
        ' categorylabel
        ' 
        categorylabel.Anchor = AnchorStyles.None
        categorylabel.AutoSize = True
        categorylabel.Font = New Font("Segoe UI", 12F)
        categorylabel.Location = New Point(338, 324)
        categorylabel.Name = "categorylabel"
        categorylabel.Size = New Size(76, 21)
        categorylabel.TabIndex = 30
        categorylabel.Text = "Category:"
        ' 
        ' descriptionlabel
        ' 
        descriptionlabel.Anchor = AnchorStyles.None
        descriptionlabel.AutoSize = True
        descriptionlabel.Font = New Font("Segoe UI", 12F)
        descriptionlabel.Location = New Point(322, 273)
        descriptionlabel.Name = "descriptionlabel"
        descriptionlabel.Size = New Size(92, 21)
        descriptionlabel.TabIndex = 29
        descriptionlabel.Text = "Description:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(324, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 21)
        Label2.TabIndex = 28
        Label2.Text = "Item Name:"
        ' 
        ' descBox
        ' 
        descBox.Anchor = AnchorStyles.None
        descBox.Font = New Font("Segoe UI", 12F)
        descBox.Location = New Point(420, 270)
        descBox.Name = "descBox"
        descBox.Size = New Size(427, 29)
        descBox.TabIndex = 27
        ' 
        ' locationBox
        ' 
        locationBox.Anchor = AnchorStyles.None
        locationBox.Font = New Font("Segoe UI", 12F)
        locationBox.Location = New Point(420, 221)
        locationBox.Name = "locationBox"
        locationBox.Size = New Size(427, 29)
        locationBox.TabIndex = 26
        ' 
        ' CloseBtn
        ' 
        CloseBtn.Anchor = AnchorStyles.Bottom
        CloseBtn.BackColor = SystemColors.ActiveBorder
        CloseBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseBtn.Location = New Point(493, 549)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(280, 45)
        CloseBtn.TabIndex = 25
        CloseBtn.Text = "Close"
        CloseBtn.UseVisualStyleBackColor = False
        ' 
        ' saveBtn
        ' 
        saveBtn.Anchor = AnchorStyles.Bottom
        saveBtn.BackColor = Color.LightGreen
        saveBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        saveBtn.Location = New Point(493, 498)
        saveBtn.Name = "saveBtn"
        saveBtn.Size = New Size(280, 45)
        saveBtn.TabIndex = 24
        saveBtn.Text = "SAVE"
        saveBtn.UseVisualStyleBackColor = False
        ' 
        ' itemName_Box
        ' 
        itemName_Box.Anchor = AnchorStyles.None
        itemName_Box.Font = New Font("Segoe UI", 12F)
        itemName_Box.Location = New Point(420, 174)
        itemName_Box.Name = "itemName_Box"
        itemName_Box.Size = New Size(427, 29)
        itemName_Box.TabIndex = 23
        ' 
        ' clearbutton
        ' 
        clearbutton.Anchor = AnchorStyles.None
        clearbutton.BackColor = SystemColors.ActiveBorder
        clearbutton.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clearbutton.Location = New Point(864, 289)
        clearbutton.Name = "clearbutton"
        clearbutton.Size = New Size(80, 45)
        clearbutton.TabIndex = 37
        clearbutton.Text = "Clear"
        clearbutton.UseVisualStyleBackColor = False
        ' 
        ' CreateWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(1264, 681)
        Controls.Add(clearbutton)
        Controls.Add(cmbStatus)
        Controls.Add(dtp_delete)
        Controls.Add(cmbCategory)
        Controls.Add(Label3)
        Controls.Add(datelabel)
        Controls.Add(lfllabel)
        Controls.Add(categorylabel)
        Controls.Add(descriptionlabel)
        Controls.Add(Label2)
        Controls.Add(descBox)
        Controls.Add(locationBox)
        Controls.Add(CloseBtn)
        Controls.Add(saveBtn)
        Controls.Add(itemName_Box)
        Controls.Add(Panel1)
        MinimumSize = New Size(1024, 576)
        Name = "CreateWindow"
        Text = "CreateWindow"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtp_delete As DateTimePicker
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents datelabel As Label
    Friend WithEvents lfllabel As Label
    Friend WithEvents categorylabel As Label
    Friend WithEvents descriptionlabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents descBox As TextBox
    Friend WithEvents locationBox As TextBox
    Friend WithEvents CloseBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents itemName_Box As TextBox
    Friend WithEvents clearbutton As Button
End Class
