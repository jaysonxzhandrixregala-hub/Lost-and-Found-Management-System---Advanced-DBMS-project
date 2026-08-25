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
        PanelLoginCard = New Panel()
        chkShowPw = New CheckBox()
        devBtn = New Button()
        tipShowPass = New ToolTip(components)
        PanelLoginCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 45F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.White
        Label1.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label1.Location = New Point(272, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 81)
        Label1.TabIndex = 0
        Label1.Text = "Log In"
        ' 
        ' usrBox
        ' 
        usrBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        usrBox.BackColor = Color.SteelBlue
        usrBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usrBox.ForeColor = Color.White
        usrBox.Location = New Point(174, 209)
        usrBox.Name = "usrBox"
        usrBox.Size = New Size(414, 43)
        usrBox.TabIndex = 1
        ' 
        ' loginbtn
        ' 
        loginbtn.Anchor = AnchorStyles.Bottom
        loginbtn.BackColor = Color.DodgerBlue
        loginbtn.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.ForeColor = Color.White
        loginbtn.Location = New Point(264, 379)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(242, 45)
        loginbtn.TabIndex = 2
        loginbtn.Text = "Log In"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(209, 455)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 30)
        Label2.TabIndex = 3
        Label2.Text = "Don't have an account?"
        ' 
        ' registryLink
        ' 
        registryLink.Anchor = AnchorStyles.Bottom
        registryLink.AutoSize = True
        registryLink.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        registryLink.ForeColor = Color.FromArgb(CByte(59), CByte(54), CByte(75))
        registryLink.LinkColor = Color.DodgerBlue
        registryLink.Location = New Point(452, 455)
        registryLink.Name = "registryLink"
        registryLink.Size = New Size(77, 30)
        registryLink.TabIndex = 4
        registryLink.TabStop = True
        registryLink.Text = "Sign In"
        ' 
        ' passwordBox
        ' 
        passwordBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        passwordBox.BackColor = Color.SteelBlue
        passwordBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.ForeColor = Color.White
        passwordBox.Location = New Point(174, 299)
        passwordBox.Name = "passwordBox"
        passwordBox.PasswordChar = "•"c
        passwordBox.Size = New Size(414, 43)
        passwordBox.TabIndex = 6
        ' 
        ' PanelLoginCard
        ' 
        PanelLoginCard.Anchor = AnchorStyles.None
        PanelLoginCard.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(150))
        PanelLoginCard.BackgroundImageLayout = ImageLayout.Stretch
        PanelLoginCard.Controls.Add(chkShowPw)
        PanelLoginCard.Controls.Add(loginbtn)
        PanelLoginCard.Controls.Add(devBtn)
        PanelLoginCard.Controls.Add(Label1)
        PanelLoginCard.Controls.Add(passwordBox)
        PanelLoginCard.Controls.Add(usrBox)
        PanelLoginCard.Controls.Add(Label2)
        PanelLoginCard.Controls.Add(registryLink)
        PanelLoginCard.Location = New Point(302, 8)
        PanelLoginCard.Name = "PanelLoginCard"
        PanelLoginCard.Size = New Size(764, 598)
        PanelLoginCard.TabIndex = 5
        ' 
        ' chkShowPw
        ' 
        chkShowPw.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkShowPw.AutoSize = True
        chkShowPw.FlatStyle = FlatStyle.Flat
        chkShowPw.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkShowPw.Location = New Point(562, 308)
        chkShowPw.Margin = New Padding(2, 2, 2, 2)
        chkShowPw.Name = "chkShowPw"
        chkShowPw.Size = New Size(12, 11)
        chkShowPw.TabIndex = 8
        chkShowPw.UseVisualStyleBackColor = True
        ' 
        ' devBtn
        ' 
        devBtn.Anchor = AnchorStyles.Left
        devBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        devBtn.ForeColor = SystemColors.ControlText
        devBtn.Location = New Point(174, 383)
        devBtn.Margin = New Padding(2, 2, 2, 2)
        devBtn.Name = "devBtn"
        devBtn.Size = New Size(66, 41)
        devBtn.TabIndex = 7
        devBtn.Text = "dev"
        devBtn.UseVisualStyleBackColor = True
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        CausesValidation = False
        ClientSize = New Size(1329, 614)
        Controls.Add(PanelLoginCard)
        MinimumSize = New Size(901, 448)
        Name = "loginForm"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        PanelLoginCard.ResumeLayout(False)
        PanelLoginCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usrBox As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents registryLink As LinkLabel
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents PanelLoginCard As Panel
    Friend WithEvents devBtn As Button
    Friend WithEvents chkShowPw As CheckBox
    Friend WithEvents tipShowPass As ToolTip

End Class
