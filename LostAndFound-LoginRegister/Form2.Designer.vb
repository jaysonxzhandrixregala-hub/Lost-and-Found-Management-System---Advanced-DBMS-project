<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registryForm))
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
        chkRegPass = New CheckBox()
        tipPw = New ToolTip(components)
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' registry_lbl
        ' 
        registry_lbl.AutoSize = True
        registry_lbl.Font = New Font("Segoe UI Semibold", 72F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        registry_lbl.ForeColor = Color.White
        registry_lbl.Location = New Point(34, 35)
        registry_lbl.Name = "registry_lbl"
        registry_lbl.Size = New Size(1238, 191)
        registry_lbl.TabIndex = 0
        registry_lbl.Text = "Registration Form"
        ' 
        ' fnameBox
        ' 
        fnameBox.BackColor = Color.SteelBlue
        fnameBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fnameBox.ForeColor = Color.White
        fnameBox.Location = New Point(276, 368)
        fnameBox.Margin = New Padding(3, 2, 3, 2)
        fnameBox.Name = "fnameBox"
        fnameBox.Size = New Size(367, 61)
        fnameBox.TabIndex = 1
        ' 
        ' lnameBox
        ' 
        lnameBox.BackColor = Color.SteelBlue
        lnameBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnameBox.ForeColor = Color.White
        lnameBox.Location = New Point(673, 368)
        lnameBox.Margin = New Padding(3, 2, 3, 2)
        lnameBox.Name = "lnameBox"
        lnameBox.Size = New Size(367, 61)
        lnameBox.TabIndex = 2
        ' 
        ' usernameBox
        ' 
        usernameBox.BackColor = Color.SteelBlue
        usernameBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameBox.ForeColor = Color.White
        usernameBox.Location = New Point(276, 515)
        usernameBox.Margin = New Padding(3, 2, 3, 2)
        usernameBox.Name = "usernameBox"
        usernameBox.Size = New Size(764, 61)
        usernameBox.TabIndex = 3
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.SteelBlue
        emailBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailBox.ForeColor = Color.White
        emailBox.Location = New Point(276, 658)
        emailBox.Margin = New Padding(3, 2, 3, 2)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(764, 61)
        emailBox.TabIndex = 5
        ' 
        ' passwordBox
        ' 
        passwordBox.BackColor = Color.SteelBlue
        passwordBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.ForeColor = Color.White
        passwordBox.Location = New Point(276, 793)
        passwordBox.Margin = New Padding(3, 2, 3, 2)
        passwordBox.Name = "passwordBox"
        passwordBox.PasswordChar = "•"c
        passwordBox.Size = New Size(764, 61)
        passwordBox.TabIndex = 6
        ' 
        ' register_button
        ' 
        register_button.BackColor = Color.DodgerBlue
        register_button.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        register_button.Location = New Point(723, 960)
        register_button.Margin = New Padding(3, 2, 3, 2)
        register_button.Name = "register_button"
        register_button.Size = New Size(319, 77)
        register_button.TabIndex = 7
        register_button.Text = "Register"
        register_button.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(276, 947)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 45)
        Label1.TabIndex = 8
        Label1.Text = "Already have an account?"
        ' 
        ' loginlink
        ' 
        loginlink.AutoSize = True
        loginlink.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginlink.ForeColor = Color.Transparent
        loginlink.LinkColor = Color.DodgerBlue
        loginlink.Location = New Point(534, 992)
        loginlink.Name = "loginlink"
        loginlink.Size = New Size(109, 45)
        loginlink.TabIndex = 9
        loginlink.TabStop = True
        loginlink.Text = "Log In"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(150))
        Panel1.Controls.Add(chkRegPass)
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
        Panel1.Location = New Point(806, 168)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1237, 1378)
        Panel1.TabIndex = 10
        ' 
        ' chkRegPass
        ' 
        chkRegPass.AutoSize = True
        chkRegPass.FlatStyle = FlatStyle.Popup
        chkRegPass.Location = New Point(1000, 809)
        chkRegPass.Name = "chkRegPass"
        chkRegPass.Size = New Size(18, 17)
        chkRegPass.TabIndex = 10
        chkRegPass.UseVisualStyleBackColor = True
        ' 
        ' registryForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(2720, 1735)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents chkRegPass As CheckBox
    Friend WithEvents tipPw As ToolTip
End Class
