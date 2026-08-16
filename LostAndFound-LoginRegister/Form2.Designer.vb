<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registryForm
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
        registry_lbl = New Label()
        fnameBox = New TextBox()
        lnameBox = New TextBox()
        usernameBox = New TextBox()
        emailBox = New TextBox()
        passwordBox = New TextBox()
        register_button = New Button()
        Label1 = New Label()
        loginlink = New LinkLabel()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' registry_lbl
        ' 
        registry_lbl.AutoSize = True
        registry_lbl.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        registry_lbl.ForeColor = Color.White
        registry_lbl.Location = New Point(24, 21)
        registry_lbl.Margin = New Padding(2, 0, 2, 0)
        registry_lbl.Name = "registry_lbl"
        registry_lbl.Size = New Size(826, 128)
        registry_lbl.TabIndex = 0
        registry_lbl.Text = "Registration Form"
        ' 
        ' fnameBox
        ' 
        fnameBox.BackColor = Color.SteelBlue
        fnameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fnameBox.ForeColor = SystemColors.ScrollBar
        fnameBox.Location = New Point(193, 221)
        fnameBox.Margin = New Padding(2, 1, 2, 1)
        fnameBox.Name = "fnameBox"
        fnameBox.Size = New Size(258, 29)
        fnameBox.TabIndex = 1
        fnameBox.Text = "First Name"
        ' 
        ' lnameBox
        ' 
        lnameBox.BackColor = Color.SteelBlue
        lnameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnameBox.ForeColor = SystemColors.ScrollBar
        lnameBox.Location = New Point(471, 221)
        lnameBox.Margin = New Padding(2, 1, 2, 1)
        lnameBox.Name = "lnameBox"
        lnameBox.Size = New Size(258, 29)
        lnameBox.TabIndex = 2
        lnameBox.Text = "Last Name"
        ' 
        ' usernameBox
        ' 
        usernameBox.BackColor = Color.SteelBlue
        usernameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameBox.ForeColor = SystemColors.ScrollBar
        usernameBox.Location = New Point(193, 309)
        usernameBox.Margin = New Padding(2, 1, 2, 1)
        usernameBox.Name = "usernameBox"
        usernameBox.Size = New Size(536, 29)
        usernameBox.TabIndex = 3
        usernameBox.Text = "Username"
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.SteelBlue
        emailBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailBox.ForeColor = SystemColors.ScrollBar
        emailBox.Location = New Point(193, 388)
        emailBox.Margin = New Padding(2, 1, 2, 1)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(536, 29)
        emailBox.TabIndex = 5
        emailBox.Text = "Email"
        ' 
        ' passwordBox
        ' 
        passwordBox.BackColor = Color.SteelBlue
        passwordBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.ForeColor = SystemColors.ScrollBar
        passwordBox.Location = New Point(193, 476)
        passwordBox.Margin = New Padding(2, 1, 2, 1)
        passwordBox.Name = "passwordBox"
        passwordBox.Size = New Size(536, 29)
        passwordBox.TabIndex = 6
        passwordBox.Text = "Password"
        ' 
        ' register_button
        ' 
        register_button.BackColor = Color.DodgerBlue
        register_button.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        register_button.Location = New Point(579, 567)
        register_button.Margin = New Padding(2, 1, 2, 1)
        register_button.Name = "register_button"
        register_button.Size = New Size(150, 34)
        register_button.TabIndex = 7
        register_button.Text = "Register"
        register_button.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(203, 701)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 21)
        Label1.TabIndex = 8
        Label1.Text = "Already have an account?"
        ' 
        ' loginlink
        ' 
        loginlink.AutoSize = True
        loginlink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginlink.ForeColor = Color.White
        loginlink.LinkColor = Color.DodgerBlue
        loginlink.Location = New Point(383, 701)
        loginlink.Margin = New Padding(2, 0, 2, 0)
        loginlink.Name = "loginlink"
        loginlink.Size = New Size(53, 21)
        loginlink.TabIndex = 9
        loginlink.TabStop = True
        loginlink.Text = "Log In"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(150))
        Panel1.Controls.Add(registry_lbl)
        Panel1.Controls.Add(loginlink)
        Panel1.Controls.Add(fnameBox)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lnameBox)
        Panel1.Controls.Add(register_button)
        Panel1.Controls.Add(usernameBox)
        Panel1.Controls.Add(passwordBox)
        Panel1.Controls.Add(emailBox)
        Panel1.ForeColor = Color.Transparent
        Panel1.Location = New Point(564, 101)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(866, 827)
        Panel1.TabIndex = 10
        ' 
        ' registryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Margin = New Padding(2, 1, 2, 1)
        Name = "registryForm"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents registry_lbl As Label
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents lnameBox As TextBox
    Friend WithEvents usernameBox As TextBox
    Friend WithEvents emailBox As TextBox
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents register_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents loginlink As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registryForm
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
        registry_lbl = New Label()
        fnameBox = New TextBox()
        lnameBox = New TextBox()
        usernameBox = New TextBox()
        emailBox = New TextBox()
        passwordBox = New TextBox()
        register_button = New Button()
        Label1 = New Label()
        loginlink = New LinkLabel()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' registry_lbl
        ' 
        registry_lbl.AutoSize = True
        registry_lbl.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        registry_lbl.ForeColor = Color.White
        registry_lbl.Location = New Point(24, 21)
        registry_lbl.Margin = New Padding(2, 0, 2, 0)
        registry_lbl.Name = "registry_lbl"
        registry_lbl.Size = New Size(826, 128)
        registry_lbl.TabIndex = 0
        registry_lbl.Text = "Registration Form"
        ' 
        ' fnameBox
        ' 
        fnameBox.BackColor = Color.SteelBlue
        fnameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fnameBox.ForeColor = SystemColors.ScrollBar
        fnameBox.Location = New Point(193, 221)
        fnameBox.Margin = New Padding(2, 1, 2, 1)
        fnameBox.Name = "fnameBox"
        fnameBox.Size = New Size(258, 29)
        fnameBox.TabIndex = 1
        fnameBox.Text = "First Name"
        ' 
        ' lnameBox
        ' 
        lnameBox.BackColor = Color.SteelBlue
        lnameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnameBox.ForeColor = SystemColors.ScrollBar
        lnameBox.Location = New Point(471, 221)
        lnameBox.Margin = New Padding(2, 1, 2, 1)
        lnameBox.Name = "lnameBox"
        lnameBox.Size = New Size(258, 29)
        lnameBox.TabIndex = 2
        lnameBox.Text = "Last Name"
        ' 
        ' usernameBox
        ' 
        usernameBox.BackColor = Color.SteelBlue
        usernameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameBox.ForeColor = SystemColors.ScrollBar
        usernameBox.Location = New Point(193, 309)
        usernameBox.Margin = New Padding(2, 1, 2, 1)
        usernameBox.Name = "usernameBox"
        usernameBox.Size = New Size(536, 29)
        usernameBox.TabIndex = 3
        usernameBox.Text = "Username"
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.SteelBlue
        emailBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailBox.ForeColor = SystemColors.ScrollBar
        emailBox.Location = New Point(193, 388)
        emailBox.Margin = New Padding(2, 1, 2, 1)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(536, 29)
        emailBox.TabIndex = 5
        emailBox.Text = "Email"
        ' 
        ' passwordBox
        ' 
        passwordBox.BackColor = Color.SteelBlue
        passwordBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.ForeColor = SystemColors.ScrollBar
        passwordBox.Location = New Point(193, 476)
        passwordBox.Margin = New Padding(2, 1, 2, 1)
        passwordBox.Name = "passwordBox"
        passwordBox.Size = New Size(536, 29)
        passwordBox.TabIndex = 6
        passwordBox.Text = "Password"
        ' 
        ' register_button
        ' 
        register_button.BackColor = Color.DodgerBlue
        register_button.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        register_button.Location = New Point(579, 567)
        register_button.Margin = New Padding(2, 1, 2, 1)
        register_button.Name = "register_button"
        register_button.Size = New Size(150, 34)
        register_button.TabIndex = 7
        register_button.Text = "Register"
        register_button.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(203, 701)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 21)
        Label1.TabIndex = 8
        Label1.Text = "Already have an account?"
        ' 
        ' loginlink
        ' 
        loginlink.AutoSize = True
        loginlink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginlink.ForeColor = Color.White
        loginlink.LinkColor = Color.DodgerBlue
        loginlink.Location = New Point(383, 701)
        loginlink.Margin = New Padding(2, 0, 2, 0)
        loginlink.Name = "loginlink"
        loginlink.Size = New Size(53, 21)
        loginlink.TabIndex = 9
        loginlink.TabStop = True
        loginlink.Text = "Log In"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(150))
        Panel1.Controls.Add(registry_lbl)
        Panel1.Controls.Add(loginlink)
        Panel1.Controls.Add(fnameBox)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lnameBox)
        Panel1.Controls.Add(register_button)
        Panel1.Controls.Add(usernameBox)
        Panel1.Controls.Add(passwordBox)
        Panel1.Controls.Add(emailBox)
        Panel1.ForeColor = Color.Transparent
        Panel1.Location = New Point(564, 101)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(866, 827)
        Panel1.TabIndex = 10
        ' 
        ' registryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Margin = New Padding(2, 1, 2, 1)
        Name = "registryForm"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents registry_lbl As Label
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents lnameBox As TextBox
    Friend WithEvents usernameBox As TextBox
    Friend WithEvents emailBox As TextBox
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents register_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents loginlink As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class
>>>>>>> 6daa593922f2f4b28e5eab698b0a084c6d11ffe8
