<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_dash
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
        welcomelabel = New Label()
        read_btn = New Button()
        update_btn = New Button()
        create_btn = New Button()
        del_btn = New Button()
        logoutbutton = New Button()
        SuspendLayout()
        ' 
        ' welcomelabel
        ' 
        welcomelabel.AutoSize = True
        welcomelabel.Font = New Font("Microsoft Sans Serif", 150F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        welcomelabel.Location = New Point(498, 25)
        welcomelabel.Name = "welcomelabel"
        welcomelabel.Size = New Size(992, 226)
        welcomelabel.TabIndex = 0
        welcomelabel.Text = "Welcome!"
        ' 
        ' read_btn
        ' 
        read_btn.BackColor = Color.DeepSkyBlue
        read_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        read_btn.Location = New Point(573, 300)
        read_btn.Name = "read_btn"
        read_btn.Size = New Size(370, 430)
        read_btn.TabIndex = 1
        read_btn.Text = "Read / View Items"
        read_btn.UseVisualStyleBackColor = False
        ' 
        ' update_btn
        ' 
        update_btn.BackColor = Color.Coral
        update_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        update_btn.Location = New Point(972, 300)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(370, 430)
        update_btn.TabIndex = 2
        update_btn.Text = "Update Item"
        update_btn.UseVisualStyleBackColor = False
        ' 
        ' create_btn
        ' 
        create_btn.BackColor = Color.LightGreen
        create_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        create_btn.Location = New Point(181, 300)
        create_btn.Name = "create_btn"
        create_btn.Size = New Size(370, 430)
        create_btn.TabIndex = 3
        create_btn.Text = "Create Item"
        create_btn.UseVisualStyleBackColor = False
        ' 
        ' del_btn
        ' 
        del_btn.BackColor = Color.Firebrick
        del_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        del_btn.Location = New Point(1367, 300)
        del_btn.Name = "del_btn"
        del_btn.Size = New Size(370, 430)
        del_btn.TabIndex = 4
        del_btn.Text = "Delete Item"
        del_btn.UseVisualStyleBackColor = False
        ' 
        ' logoutbutton
        ' 
        logoutbutton.BackColor = SystemColors.ActiveBorder
        logoutbutton.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutbutton.Location = New Point(341, 848)
        logoutbutton.Name = "logoutbutton"
        logoutbutton.Size = New Size(1284, 123)
        logoutbutton.TabIndex = 5
        logoutbutton.Text = "Log Out"
        logoutbutton.UseVisualStyleBackColor = False
        ' 
        ' main_dash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(1904, 1041)
        Controls.Add(logoutbutton)
        Controls.Add(del_btn)
        Controls.Add(create_btn)
        Controls.Add(update_btn)
        Controls.Add(read_btn)
        Controls.Add(welcomelabel)
        Name = "main_dash"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents welcomelabel As Label
    Friend WithEvents read_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents create_btn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents logoutbutton As Button
End Class
