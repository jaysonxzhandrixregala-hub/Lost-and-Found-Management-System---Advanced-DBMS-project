<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        usrBox = New TextBox()
        loginbtn = New Button()
        Label2 = New Label()
        registryLink = New LinkLabel()
        passwordBox = New TextBox()
        Panel1 = New Panel()
        devBtn = New Button()
        chkShowPw = New CheckBox()
        tipShowPass = New ToolTip(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label1.Location = New Point(1766, 247)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(497, 199)
        Label1.TabIndex = 0
        Label1.Text = "Log In"
        ' 
        ' usrBox
        ' 
        usrBox.BackColor = Color.SteelBlue
        usrBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usrBox.ForeColor = Color.White
        usrBox.Location = New Point(1711, 583)
        usrBox.Margin = New Padding(4, 5, 4, 5)
        usrBox.Name = "usrBox"
        usrBox.Size = New Size(590, 61)
        usrBox.TabIndex = 1
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.DodgerBlue
        loginbtn.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.ForeColor = Color.White
        loginbtn.Location = New Point(1854, 903)
        loginbtn.Margin = New Padding(4, 5, 4, 5)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(346, 75)
        loginbtn.TabIndex = 2
        loginbtn.Text = "Log In"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1766, 1062)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(350, 45)
        Label2.TabIndex = 3
        Label2.Text = "Don't have an account?"
        ' 
        ' registryLink
        ' 
        registryLink.AutoSize = True
        registryLink.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        registryLink.ForeColor = Color.FromArgb(CByte(59), CByte(54), CByte(75))
        registryLink.LinkColor = Color.DodgerBlue
        registryLink.Location = New Point(2110, 1062)
        registryLink.Margin = New Padding(4, 0, 4, 0)
        registryLink.Name = "registryLink"
        registryLink.Size = New Size(118, 45)
        registryLink.TabIndex = 4
        registryLink.TabStop = True
        registryLink.Text = "Sign In"
        ' 
        ' passwordBox
        ' 
        passwordBox.BackColor = Color.SteelBlue
        passwordBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.ForeColor = Color.White
        passwordBox.Location = New Point(1711, 733)
        passwordBox.Margin = New Padding(4, 5, 4, 5)
        passwordBox.Name = "passwordBox"
        passwordBox.PasswordChar = "•"c
        passwordBox.Size = New Size(590, 61)
        passwordBox.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(-1, -5)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1373, 1763)
        Panel1.TabIndex = 5
        ' 
        ' devBtn
        ' 
        devBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        devBtn.ForeColor = SystemColors.ControlText
        devBtn.Location = New Point(1720, 908)
        devBtn.Name = "devBtn"
        devBtn.Size = New Size(94, 68)
        devBtn.TabIndex = 7
        devBtn.Text = "dev"
        devBtn.UseVisualStyleBackColor = True
        ' 
        ' chkShowPw
        ' 
        chkShowPw.AutoSize = True
        chkShowPw.FlatStyle = FlatStyle.Flat
        chkShowPw.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkShowPw.Location = New Point(2267, 747)
        chkShowPw.Name = "chkShowPw"
        chkShowPw.Size = New Size(17, 16)
        chkShowPw.TabIndex = 8
        chkShowPw.UseVisualStyleBackColor = True
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(150))
        CausesValidation = False
        ClientSize = New Size(2587, 1502)
        Controls.Add(chkShowPw)
        Controls.Add(devBtn)
        Controls.Add(passwordBox)
        Controls.Add(Panel1)
        Controls.Add(registryLink)
        Controls.Add(Label2)
        Controls.Add(loginbtn)
        Controls.Add(usrBox)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "loginForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usrBox As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents registryLink As LinkLabel
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents devBtn As Button
    Friend WithEvents chkShowPw As CheckBox
    Friend WithEvents tipShowPass As ToolTip

End Class
