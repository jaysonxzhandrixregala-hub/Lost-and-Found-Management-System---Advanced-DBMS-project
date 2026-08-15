<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        rvitemslabel = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(rvitemslabel)
        Panel1.Location = New Point(-4, -20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1912, 207)
        Panel1.TabIndex = 0
        ' 
        ' rvitemslabel
        ' 
        rvitemslabel.AutoSize = True
        rvitemslabel.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rvitemslabel.Location = New Point(550, 56)
        rvitemslabel.Name = "rvitemslabel"
        rvitemslabel.Size = New Size(923, 128)
        rvitemslabel.TabIndex = 0
        rvitemslabel.Text = "READ / VIEW ITEMS"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rvitemslabel As Label
End Class
