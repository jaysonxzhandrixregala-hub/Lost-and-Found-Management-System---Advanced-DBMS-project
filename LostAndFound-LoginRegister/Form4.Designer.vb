<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_window
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
        createitemlabel = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        itemName_Box = New TextBox()
        Label2 = New Label()
        descBox = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        locationBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        save_btn = New Button()
        clearbutton = New Button()
        cmbCategory = New ComboBox()
        cmbStatus = New ComboBox()
        datePicker = New DateTimePicker()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' createitemlabel
        ' 
        createitemlabel.Anchor = AnchorStyles.Top
        createitemlabel.AutoSize = True
        createitemlabel.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        createitemlabel.Location = New Point(894, 65)
        createitemlabel.Name = "createitemlabel"
        createitemlabel.Size = New Size(631, 128)
        createitemlabel.TabIndex = 0
        createitemlabel.Text = "CREATE ITEM"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.LightGreen
        Panel1.Controls.Add(createitemlabel)
        Panel1.Location = New Point(-9, -37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2344, 221)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(696, 259)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 40)
        Label1.TabIndex = 2
        Label1.Text = "Item Name:"
        ' 
        ' itemName_Box
        ' 
        itemName_Box.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        itemName_Box.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        itemName_Box.Location = New Point(902, 256)
        itemName_Box.Name = "itemName_Box"
        itemName_Box.Size = New Size(657, 46)
        itemName_Box.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(695, 361)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 40)
        Label2.TabIndex = 4
        Label2.Text = "Description:"
        ' 
        ' descBox
        ' 
        descBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        descBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        descBox.Location = New Point(902, 361)
        descBox.Name = "descBox"
        descBox.Size = New Size(657, 46)
        descBox.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(723, 464)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 40)
        Label3.TabIndex = 6
        Label3.Text = "Category:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(578, 574)
        Label4.Name = "Label4"
        Label4.Size = New Size(284, 40)
        Label4.TabIndex = 8
        Label4.Text = "Location Found/Lost:"
        ' 
        ' locationBox
        ' 
        locationBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        locationBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        locationBox.Location = New Point(902, 574)
        locationBox.Name = "locationBox"
        locationBox.Size = New Size(657, 43)
        locationBox.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(779, 682)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 40)
        Label5.TabIndex = 10
        Label5.Text = "Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(762, 802)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 40)
        Label6.TabIndex = 12
        Label6.Text = "Status:"
        ' 
        ' save_btn
        ' 
        save_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        save_btn.BackColor = Color.PaleGreen
        save_btn.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        save_btn.Location = New Point(925, 925)
        save_btn.Name = "save_btn"
        save_btn.Size = New Size(234, 56)
        save_btn.TabIndex = 14
        save_btn.Text = "Save"
        save_btn.UseVisualStyleBackColor = False
        ' 
        ' clearbutton
        ' 
        clearbutton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        clearbutton.BackColor = SystemColors.ActiveBorder
        clearbutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clearbutton.Location = New Point(1242, 925)
        clearbutton.Name = "clearbutton"
        clearbutton.Size = New Size(234, 56)
        clearbutton.TabIndex = 15
        clearbutton.Text = "Clear"
        clearbutton.UseVisualStyleBackColor = False
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Segoe UI", 21.75F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Valuable", "Non-Valuable", "Perishable"})
        cmbCategory.Location = New Point(902, 463)
        cmbCategory.Margin = New Padding(2, 2, 2, 2)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(657, 48)
        cmbCategory.TabIndex = 16
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbStatus.Font = New Font("Segoe UI", 21.75F)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Lost", "Found", "Unclaimed"})
        cmbStatus.Location = New Point(902, 802)
        cmbStatus.Margin = New Padding(2, 2, 2, 2)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(657, 48)
        cmbStatus.TabIndex = 17
        ' 
        ' datePicker
        ' 
        datePicker.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        datePicker.Font = New Font("Segoe UI", 21.75F)
        datePicker.Location = New Point(902, 679)
        datePicker.Margin = New Padding(2, 2, 2, 2)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(657, 46)
        datePicker.TabIndex = 18
        datePicker.Value = New Date(2026, 8, 19, 15, 32, 18, 0)
        ' 
        ' create_window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(1347, 637)
        Controls.Add(datePicker)
        Controls.Add(cmbStatus)
        Controls.Add(cmbCategory)
        Controls.Add(clearbutton)
        Controls.Add(save_btn)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(locationBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(descBox)
        Controls.Add(Label2)
        Controls.Add(itemName_Box)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        MinimumSize = New Size(901, 448)
        Name = "create_window"
        Text = "Form4"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents createitemlabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents itemName_Box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents descBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents locationBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents clearbutton As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents datePicker As DateTimePicker
End Class
