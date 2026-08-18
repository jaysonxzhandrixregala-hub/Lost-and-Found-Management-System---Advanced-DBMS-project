<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deletion_window
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
        deleteitemlabel = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        deletion_btn = New Button()
        cancelbutton = New Button()
        Panel2 = New Panel()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        statuslabel = New Label()
        datelabel = New Label()
        locationlabel = New Label()
        categorylabel = New Label()
        descriptionlabel = New Label()
        itemnamelabel = New Label()
        iteminfolabel = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(deleteitemlabel)
        Panel1.Location = New Point(0, -5)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2727, 315)
        Panel1.TabIndex = 0
        ' 
        ' deleteitemlabel
        ' 
        deleteitemlabel.AutoSize = True
        deleteitemlabel.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deleteitemlabel.Location = New Point(970, 55)
        deleteitemlabel.Margin = New Padding(4, 0, 4, 0)
        deleteitemlabel.Name = "deleteitemlabel"
        deleteitemlabel.Size = New Size(927, 191)
        deleteitemlabel.TabIndex = 1
        deleteitemlabel.Text = "DELETE ITEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(827, 387)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 60)
        Label1.TabIndex = 1
        Label1.Text = "Select Item ID:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(1137, 382)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(771, 65)
        TextBox1.TabIndex = 2
        ' 
        ' deletion_btn
        ' 
        deletion_btn.BackColor = Color.Firebrick
        deletion_btn.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deletion_btn.Location = New Point(1061, 1580)
        deletion_btn.Margin = New Padding(4, 5, 4, 5)
        deletion_btn.Name = "deletion_btn"
        deletion_btn.Size = New Size(310, 92)
        deletion_btn.TabIndex = 3
        deletion_btn.Text = "Delete"
        deletion_btn.UseVisualStyleBackColor = False
        ' 
        ' cancelbutton
        ' 
        cancelbutton.BackColor = SystemColors.ActiveBorder
        cancelbutton.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancelbutton.Location = New Point(1600, 1580)
        cancelbutton.Margin = New Padding(4, 5, 4, 5)
        cancelbutton.Name = "cancelbutton"
        cancelbutton.Size = New Size(310, 92)
        cancelbutton.TabIndex = 4
        cancelbutton.Text = "Cancel"
        cancelbutton.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(statuslabel)
        Panel2.Controls.Add(datelabel)
        Panel2.Controls.Add(locationlabel)
        Panel2.Controls.Add(categorylabel)
        Panel2.Controls.Add(descriptionlabel)
        Panel2.Controls.Add(itemnamelabel)
        Panel2.Controls.Add(iteminfolabel)
        Panel2.Location = New Point(690, 523)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1394, 1003)
        Panel2.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(390, 847)
        TextBox7.Margin = New Padding(4, 5, 4, 5)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(794, 65)
        TextBox7.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(390, 693)
        TextBox6.Margin = New Padding(4, 5, 4, 5)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(794, 65)
        TextBox6.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(390, 555)
        TextBox5.Margin = New Padding(4, 5, 4, 5)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(794, 65)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(390, 422)
        TextBox4.Margin = New Padding(4, 5, 4, 5)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(794, 65)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(390, 295)
        TextBox3.Margin = New Padding(4, 5, 4, 5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(794, 65)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(390, 150)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(794, 65)
        TextBox2.TabIndex = 7
        ' 
        ' statuslabel
        ' 
        statuslabel.AutoSize = True
        statuslabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statuslabel.Location = New Point(211, 847)
        statuslabel.Margin = New Padding(4, 0, 4, 0)
        statuslabel.Name = "statuslabel"
        statuslabel.Size = New Size(153, 60)
        statuslabel.TabIndex = 6
        statuslabel.Text = "Status:"
        ' 
        ' datelabel
        ' 
        datelabel.AutoSize = True
        datelabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datelabel.Location = New Point(236, 698)
        datelabel.Margin = New Padding(4, 0, 4, 0)
        datelabel.Name = "datelabel"
        datelabel.Size = New Size(126, 60)
        datelabel.TabIndex = 5
        datelabel.Text = "Date:"
        ' 
        ' locationlabel
        ' 
        locationlabel.AutoSize = True
        locationlabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        locationlabel.Location = New Point(156, 565)
        locationlabel.Margin = New Padding(4, 0, 4, 0)
        locationlabel.Name = "locationlabel"
        locationlabel.Size = New Size(201, 60)
        locationlabel.TabIndex = 4
        locationlabel.Text = "Location:"
        ' 
        ' categorylabel
        ' 
        categorylabel.AutoSize = True
        categorylabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categorylabel.Location = New Point(156, 427)
        categorylabel.Margin = New Padding(4, 0, 4, 0)
        categorylabel.Name = "categorylabel"
        categorylabel.Size = New Size(210, 60)
        categorylabel.TabIndex = 3
        categorylabel.Text = "Category:"
        ' 
        ' descriptionlabel
        ' 
        descriptionlabel.AutoSize = True
        descriptionlabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        descriptionlabel.Location = New Point(116, 305)
        descriptionlabel.Margin = New Padding(4, 0, 4, 0)
        descriptionlabel.Name = "descriptionlabel"
        descriptionlabel.Size = New Size(257, 60)
        descriptionlabel.TabIndex = 2
        descriptionlabel.Text = "Description:"
        ' 
        ' itemnamelabel
        ' 
        itemnamelabel.AutoSize = True
        itemnamelabel.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        itemnamelabel.Location = New Point(117, 160)
        itemnamelabel.Margin = New Padding(4, 0, 4, 0)
        itemnamelabel.Name = "itemnamelabel"
        itemnamelabel.Size = New Size(251, 60)
        itemnamelabel.TabIndex = 1
        itemnamelabel.Text = "Item Name:"
        ' 
        ' iteminfolabel
        ' 
        iteminfolabel.AutoSize = True
        iteminfolabel.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        iteminfolabel.ForeColor = Color.MediumBlue
        iteminfolabel.Location = New Point(46, 25)
        iteminfolabel.Margin = New Padding(4, 0, 4, 0)
        iteminfolabel.Name = "iteminfolabel"
        iteminfolabel.Size = New Size(328, 55)
        iteminfolabel.TabIndex = 0
        iteminfolabel.Text = "Item Information"
        ' 
        ' deletion_window
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(2720, 1735)
        Controls.Add(Panel2)
        Controls.Add(cancelbutton)
        Controls.Add(deletion_btn)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "deletion_window"
        Text = "Form7"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents deleteitemlabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents deletion_btn As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents categorylabel As Label
    Friend WithEvents descriptionlabel As Label
    Friend WithEvents itemnamelabel As Label
    Friend WithEvents iteminfolabel As Label
    Friend WithEvents statuslabel As Label
    Friend WithEvents datelabel As Label
    Friend WithEvents locationlabel As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
