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
        createitembutton = New Button()
        rvitemsbutton = New Button()
        updateitembutton = New Button()
        deleteitembutton = New Button()
        logoutbutton = New Button()
        SuspendLayout()
        ' 
        ' welcomelabel
        ' 
        welcomelabel.AutoSize = True
        welcomelabel.Font = New Font("Microsoft Sans Serif", 150F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        welcomelabel.Location = New Point(531, 19)
        welcomelabel.Name = "welcomelabel"
        welcomelabel.Size = New Size(992, 226)
        welcomelabel.TabIndex = 0
        welcomelabel.Text = "Welcome!"
        ' 
        ' createitembutton
        ' 
        createitembutton.BackColor = Color.DeepSkyBlue
        createitembutton.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        createitembutton.Location = New Point(573, 300)
        createitembutton.Name = "createitembutton"
        createitembutton.Size = New Size(370, 430)
        createitembutton.TabIndex = 1
        createitembutton.Text = "Create Item"
        createitembutton.UseVisualStyleBackColor = False
        ' 
        ' rvitemsbutton
        ' 
        rvitemsbutton.BackColor = Color.Coral
        rvitemsbutton.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rvitemsbutton.Location = New Point(972, 300)
        rvitemsbutton.Name = "rvitemsbutton"
        rvitemsbutton.Size = New Size(370, 430)
        rvitemsbutton.TabIndex = 2
        rvitemsbutton.Text = "Read/ View Items"
        rvitemsbutton.UseVisualStyleBackColor = False
        ' 
        ' updateitembutton
        ' 
        updateitembutton.BackColor = Color.LightGreen
        updateitembutton.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        updateitembutton.Location = New Point(181, 300)
        updateitembutton.Name = "updateitembutton"
        updateitembutton.Size = New Size(370, 430)
        updateitembutton.TabIndex = 3
        updateitembutton.Text = "Update Item"
        updateitembutton.UseVisualStyleBackColor = False
        ' 
        ' deleteitembutton
        ' 
        deleteitembutton.BackColor = Color.Firebrick
        deleteitembutton.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deleteitembutton.Location = New Point(1367, 300)
        deleteitembutton.Name = "deleteitembutton"
        deleteitembutton.Size = New Size(370, 430)
        deleteitembutton.TabIndex = 4
        deleteitembutton.Text = "Delete Item"
        deleteitembutton.UseVisualStyleBackColor = False
        ' 
        ' logoutbutton
        ' 
        logoutbutton.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutbutton.Location = New Point(749, 853)
        logoutbutton.Name = "logoutbutton"
        logoutbutton.Size = New Size(440, 99)
        logoutbutton.TabIndex = 5
        logoutbutton.Text = "Log Out"
        logoutbutton.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(logoutbutton)
        Controls.Add(deleteitembutton)
        Controls.Add(updateitembutton)
        Controls.Add(rvitemsbutton)
        Controls.Add(createitembutton)
        Controls.Add(welcomelabel)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents welcomelabel As Label
    Friend WithEvents createitembutton As Button
    Friend WithEvents rvitemsbutton As Button
    Friend WithEvents updateitembutton As Button
    Friend WithEvents deleteitembutton As Button
    Friend WithEvents logoutbutton As Button
End Class
