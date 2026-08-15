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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Label1 = New Label()
        usrBox = New TextBox()
        loginbtn = New Button()
        Label2 = New Label()
        registryLink = New LinkLabel()
        Panel1 = New Panel()
        passwordBox = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label1.Location = New Point(1236, 170)
        Label1.Name = "Label1"
        Label1.Size = New Size(333, 133)
        Label1.TabIndex = 0
        Label1.Text = "Log In"
        ' 
        ' usrBox
        ' 
        usrBox.BackColor = Color.SteelBlue
        usrBox.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
<<<<<<< HEAD
        usrBox.ForeColor = SystemColors.InactiveCaptionText
=======
        usrBox.ForeColor = SystemColors.ScrollBar
>>>>>>> origin/master
        usrBox.Location = New Point(1250, 371)
        usrBox.Name = "usrBox"
        usrBox.Size = New Size(293, 33)
        usrBox.TabIndex = 1
        usrBox.Text = "Username"
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.DodgerBlue
        loginbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.ForeColor = Color.White
        loginbtn.Location = New Point(1327, 526)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(137, 33)
        loginbtn.TabIndex = 2
        loginbtn.Text = "Log In"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1282, 606)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 21)
        Label2.TabIndex = 3
        Label2.Text = "Don't have an account?"
        ' 
        ' registryLink
        ' 
        registryLink.AutoSize = True
        registryLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        registryLink.ForeColor = Color.FromArgb(CByte(59), CByte(54), CByte(75))
        registryLink.LinkColor = Color.DodgerBlue
        registryLink.Location = New Point(1449, 606)
        registryLink.Name = "registryLink"
        registryLink.Size = New Size(58, 21)
        registryLink.TabIndex = 4
        registryLink.TabStop = True
        registryLink.Text = "Sign In"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(-1, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(961, 1058)
        Panel1.TabIndex = 5
        ' 
        ' passwordBox
        ' 
        passwordBox.BackColor = Color.SteelBlue
        passwordBox.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.ForeColor = Color.DarkGray
        passwordBox.Location = New Point(1250, 447)
        passwordBox.Name = "passwordBox"
        passwordBox.Size = New Size(293, 33)
        passwordBox.TabIndex = 6
        passwordBox.Text = "Password"
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(150))
        CausesValidation = False
        ClientSize = New Size(1811, 901)
        Controls.Add(passwordBox)
        Controls.Add(Panel1)
        Controls.Add(registryLink)
        Controls.Add(Label2)
        Controls.Add(loginbtn)
        Controls.Add(usrBox)
        Controls.Add(Label1)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents passwordBox As TextBox

End Class
