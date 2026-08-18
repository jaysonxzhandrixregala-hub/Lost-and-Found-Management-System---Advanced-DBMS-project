<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        addItem_btn = New Button()
        view_btn = New Button()
        upd_btn = New Button()
        del_btn = New Button()
        logoutbutton = New Button()
        SuspendLayout()
        ' 
        ' welcomelabel
        ' 
        welcomelabel.AutoSize = True
        welcomelabel.Font = New Font("Microsoft Sans Serif", 150F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        welcomelabel.Location = New Point(711, 42)
        welcomelabel.Margin = New Padding(4, 0, 4, 0)
        welcomelabel.Name = "welcomelabel"
        welcomelabel.Size = New Size(1485, 340)
        welcomelabel.TabIndex = 0
        welcomelabel.Text = "Welcome!"
        ' 
        ' addItem_btn
        ' 
        addItem_btn.BackColor = Color.DeepSkyBlue
        addItem_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        addItem_btn.Location = New Point(819, 500)
        addItem_btn.Margin = New Padding(4, 5, 4, 5)
        addItem_btn.Name = "addItem_btn"
        addItem_btn.Size = New Size(529, 717)
        addItem_btn.TabIndex = 1
        addItem_btn.Text = "Add Lost Items"
        addItem_btn.UseVisualStyleBackColor = False
        ' 
        ' view_btn
        ' 
        view_btn.BackColor = Color.Coral
        view_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        view_btn.Location = New Point(1389, 500)
        view_btn.Margin = New Padding(4, 5, 4, 5)
        view_btn.Name = "view_btn"
        view_btn.Size = New Size(529, 717)
        view_btn.TabIndex = 2
        view_btn.Text = "View Items"
        view_btn.UseVisualStyleBackColor = False
        ' 
        ' upd_btn
        ' 
        upd_btn.BackColor = Color.LightGreen
        upd_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        upd_btn.Location = New Point(259, 500)
        upd_btn.Margin = New Padding(4, 5, 4, 5)
        upd_btn.Name = "upd_btn"
        upd_btn.Size = New Size(529, 717)
        upd_btn.TabIndex = 3
        upd_btn.Text = "Update Item"
        upd_btn.UseVisualStyleBackColor = False
        ' 
        ' del_btn
        ' 
        del_btn.BackColor = Color.Firebrick
        del_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        del_btn.Location = New Point(1953, 500)
        del_btn.Margin = New Padding(4, 5, 4, 5)
        del_btn.Name = "del_btn"
        del_btn.Size = New Size(529, 717)
        del_btn.TabIndex = 4
        del_btn.Text = "Delete Item"
        del_btn.UseVisualStyleBackColor = False
        ' 
        ' logoutbutton
        ' 
        logoutbutton.BackColor = SystemColors.ActiveBorder
        logoutbutton.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutbutton.Location = New Point(487, 1413)
        logoutbutton.Margin = New Padding(4, 5, 4, 5)
        logoutbutton.Name = "logoutbutton"
        logoutbutton.Size = New Size(1834, 205)
        logoutbutton.TabIndex = 5
        logoutbutton.Text = "Log Out"
        logoutbutton.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(2720, 1735)
        Controls.Add(logoutbutton)
        Controls.Add(del_btn)
        Controls.Add(upd_btn)
        Controls.Add(view_btn)
        Controls.Add(addItem_btn)
        Controls.Add(welcomelabel)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents welcomelabel As Label
    Friend WithEvents addItem_btn As Button
    Friend WithEvents view_btn As Button
    Friend WithEvents upd_btn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents logoutbutton As Button
End Class
