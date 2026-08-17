<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        selectitemidlabel = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        descriptionlabel = New Label()
        TextBox3 = New TextBox()
        categorylabel = New Label()
        TextBox4 = New TextBox()
        lfllabel = New Label()
        TextBox5 = New TextBox()
        datelabel = New Label()
        TextBox6 = New TextBox()
        Label3 = New Label()
        TextBox7 = New TextBox()
        updatebutton = New Button()
        clearbutton = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Coral
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-5, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1914, 189)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(663, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(652, 128)
        Label1.TabIndex = 1
        Label1.Text = "UPDATE ITEM"
        ' 
        ' selectitemidlabel
        ' 
        selectitemidlabel.AutoSize = True
        selectitemidlabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectitemidlabel.Location = New Point(541, 245)
        selectitemidlabel.Name = "selectitemidlabel"
        selectitemidlabel.Size = New Size(200, 40)
        selectitemidlabel.TabIndex = 1
        selectitemidlabel.Text = "Select Item ID:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(778, 239)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(631, 46)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(575, 332)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 40)
        Label2.TabIndex = 3
        Label2.Text = "Item Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(778, 329)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(631, 46)
        TextBox2.TabIndex = 4
        ' 
        ' descriptionlabel
        ' 
        descriptionlabel.AutoSize = True
        descriptionlabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        descriptionlabel.Location = New Point(574, 430)
        descriptionlabel.Name = "descriptionlabel"
        descriptionlabel.Size = New Size(167, 40)
        descriptionlabel.TabIndex = 5
        descriptionlabel.Text = "Description:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(778, 424)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(631, 46)
        TextBox3.TabIndex = 6
        ' 
        ' categorylabel
        ' 
        categorylabel.AutoSize = True
        categorylabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categorylabel.Location = New Point(602, 527)
        categorylabel.Name = "categorylabel"
        categorylabel.Size = New Size(139, 40)
        categorylabel.TabIndex = 7
        categorylabel.Text = "Category:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(778, 524)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(631, 46)
        TextBox4.TabIndex = 8
        ' 
        ' lfllabel
        ' 
        lfllabel.AutoSize = True
        lfllabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lfllabel.Location = New Point(457, 629)
        lfllabel.Name = "lfllabel"
        lfllabel.Size = New Size(284, 40)
        lfllabel.TabIndex = 9
        lfllabel.Text = "Location Found/Lost:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(778, 626)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(631, 46)
        TextBox5.TabIndex = 10
        ' 
        ' datelabel
        ' 
        datelabel.AutoSize = True
        datelabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datelabel.Location = New Point(658, 731)
        datelabel.Name = "datelabel"
        datelabel.Size = New Size(83, 40)
        datelabel.TabIndex = 11
        datelabel.Text = "Date:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(778, 728)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(631, 46)
        TextBox6.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(641, 833)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 40)
        Label3.TabIndex = 12
        Label3.Text = "Status:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(778, 830)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(631, 46)
        TextBox7.TabIndex = 13
        ' 
        ' updatebutton
        ' 
        updatebutton.BackColor = Color.Coral
        updatebutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        updatebutton.Location = New Point(756, 939)
        updatebutton.Name = "updatebutton"
        updatebutton.Size = New Size(244, 53)
        updatebutton.TabIndex = 14
        updatebutton.Text = "Update"
        updatebutton.UseVisualStyleBackColor = False
        ' 
        ' clearbutton
        ' 
        clearbutton.BackColor = SystemColors.ActiveBorder
        clearbutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clearbutton.Location = New Point(1076, 939)
        clearbutton.Name = "clearbutton"
        clearbutton.Size = New Size(244, 53)
        clearbutton.TabIndex = 15
        clearbutton.Text = "Clear"
        clearbutton.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(1904, 1041)
        Controls.Add(clearbutton)
        Controls.Add(updatebutton)
        Controls.Add(TextBox7)
        Controls.Add(Label3)
        Controls.Add(TextBox6)
        Controls.Add(datelabel)
        Controls.Add(TextBox5)
        Controls.Add(lfllabel)
        Controls.Add(TextBox4)
        Controls.Add(categorylabel)
        Controls.Add(TextBox3)
        Controls.Add(descriptionlabel)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(selectitemidlabel)
        Controls.Add(Panel1)
        Name = "Form6"
        Text = "Form6"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents selectitemidlabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents descriptionlabel As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents categorylabel As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lfllabel As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents datelabel As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents updatebutton As Button
    Friend WithEvents clearbutton As Button
End Class
