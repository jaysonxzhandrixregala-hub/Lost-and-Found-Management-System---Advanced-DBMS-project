<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox6 = New TextBox()
        savebutton = New Button()
        clearbutton = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' createitemlabel
        ' 
        createitemlabel.AutoSize = True
        createitemlabel.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        createitemlabel.Location = New Point(682, 65)
        createitemlabel.Name = "createitemlabel"
        createitemlabel.Size = New Size(631, 128)
        createitemlabel.TabIndex = 0
        createitemlabel.Text = "CREATE ITEM"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGreen
        Panel1.Controls.Add(createitemlabel)
        Panel1.Location = New Point(-9, -37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1920, 221)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(569, 251)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 40)
        Label1.TabIndex = 2
        Label1.Text = "Item Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(775, 248)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(657, 46)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(568, 353)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 40)
        Label2.TabIndex = 4
        Label2.Text = "Description:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(775, 353)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(657, 46)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(596, 456)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 40)
        Label3.TabIndex = 6
        Label3.Text = "Category:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(775, 456)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(657, 46)
        TextBox3.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(451, 565)
        Label4.Name = "Label4"
        Label4.Size = New Size(284, 40)
        Label4.TabIndex = 8
        Label4.Text = "Location Found/Lost:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(775, 565)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(657, 43)
        TextBox4.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(652, 673)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 40)
        Label5.TabIndex = 10
        Label5.Text = "Date:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(775, 673)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(657, 46)
        TextBox5.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(635, 794)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 40)
        Label6.TabIndex = 12
        Label6.Text = "Status:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(775, 791)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(657, 46)
        TextBox6.TabIndex = 13
        ' 
        ' savebutton
        ' 
        savebutton.BackColor = Color.PaleGreen
        savebutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        savebutton.Location = New Point(798, 916)
        savebutton.Name = "savebutton"
        savebutton.Size = New Size(234, 56)
        savebutton.TabIndex = 14
        savebutton.Text = "Save"
        savebutton.UseVisualStyleBackColor = False
        ' 
        ' clearbutton
        ' 
        clearbutton.BackColor = SystemColors.ActiveBorder
        clearbutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clearbutton.Location = New Point(1115, 916)
        clearbutton.Name = "clearbutton"
        clearbutton.Size = New Size(234, 56)
        clearbutton.TabIndex = 15
        clearbutton.Text = "Clear"
        clearbutton.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(1904, 1041)
        Controls.Add(clearbutton)
        Controls.Add(savebutton)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents createitemlabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents savebutton As Button
    Friend WithEvents clearbutton As Button
End Class
