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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' welcomelabel
        ' 
        welcomelabel.Anchor = AnchorStyles.Top
        welcomelabel.AutoSize = True
        welcomelabel.Font = New Font("Microsoft Sans Serif", 150F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        welcomelabel.Location = New Point(711, 42)
        welcomelabel.Margin = New Padding(4, 0, 4, 0)
        welcomelabel.Name = "welcomelabel"
        welcomelabel.Size = New Size(1485, 340)
        welcomelabel.TabIndex = 0
        welcomelabel.Text = "Welcome!"
        ' 
        ' read_btn
        ' 
        read_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        read_btn.BackColor = Color.DeepSkyBlue
        read_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        read_btn.Location = New Point(526, 5)
        read_btn.Margin = New Padding(4, 5, 4, 5)
        read_btn.Name = "read_btn"
        read_btn.Size = New Size(514, 707)
        read_btn.TabIndex = 1
        read_btn.Text = "Read / View Items"
        read_btn.UseVisualStyleBackColor = False
        ' 
        ' update_btn
        ' 
        update_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        update_btn.BackColor = Color.Coral
        update_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        update_btn.Location = New Point(1048, 5)
        update_btn.Margin = New Padding(4, 5, 4, 5)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(514, 707)
        update_btn.TabIndex = 2
        update_btn.Text = "Update Item"
        update_btn.UseVisualStyleBackColor = False
        ' 
        ' create_btn
        ' 
        create_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        create_btn.BackColor = Color.LightGreen
        create_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        create_btn.Location = New Point(4, 5)
        create_btn.Margin = New Padding(4, 5, 4, 5)
        create_btn.Name = "create_btn"
        create_btn.Size = New Size(514, 707)
        create_btn.TabIndex = 3
        create_btn.Text = "Create Item"
        create_btn.UseVisualStyleBackColor = False
        ' 
        ' del_btn
        ' 
        del_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        del_btn.BackColor = Color.Firebrick
        del_btn.Font = New Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        del_btn.Location = New Point(1570, 5)
        del_btn.Margin = New Padding(4, 5, 4, 5)
        del_btn.Name = "del_btn"
        del_btn.Size = New Size(514, 707)
        del_btn.TabIndex = 4
        del_btn.Text = "Delete Item"
        del_btn.UseVisualStyleBackColor = False
        ' 
        ' logoutbutton
        ' 
        logoutbutton.Anchor = AnchorStyles.Bottom
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
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(create_btn, 0, 0)
        TableLayoutPanel1.Controls.Add(read_btn, 1, 0)
        TableLayoutPanel1.Controls.Add(del_btn, 3, 0)
        TableLayoutPanel1.Controls.Add(update_btn, 2, 0)
        TableLayoutPanel1.Location = New Point(386, 460)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(2088, 717)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' main_dash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(2720, 1735)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(logoutbutton)
        Controls.Add(welcomelabel)
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(1280, 720)
        Name = "main_dash"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents welcomelabel As Label
    Friend WithEvents read_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents create_btn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents logoutbutton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
