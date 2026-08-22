Imports MongoDB.Driver
Imports MongoDB.Bson
Imports DotNetEnv
Imports System.Runtime.InteropServices

Public Class loginForm

    Private client As MongoClient
    Private database As IMongoDatabase

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As String) As IntPtr
    End Function

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Env.Load()
        Dim mongoUri As String = Environment.GetEnvironmentVariable("MONGODB_URI")

        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")

        SendMessage(usrBox.Handle, EM_SETCUEBANNER, New IntPtr(1), "Username")
        SendMessage(passwordBox.Handle, EM_SETCUEBANNER, New IntPtr(1), "Password")

        tipShowPass.SetToolTip(chkShowPw, "Show Password?")

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

        'basic input validation, check if all fields are empty
        If String.IsNullOrWhiteSpace(usrBox.Text) OrElse
           String.IsNullOrWhiteSpace(passwordBox.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If usrBox.Text = "Username" OrElse
            passwordBox.Text = "Password" Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim usersColl = database.GetCollection(Of BsonDocument)("users")

        Dim filter As New BsonDocument From {
            {"auth.username", usrBox.Text},
            {"auth.password", passwordBox.Text}
        }

        Dim user = usersColl.Find(filter).FirstOrDefault

        If user IsNot Nothing Then
            UserSession.CurrentUserId = user("_id").AsString
            main_dash.Show()
            Hide()
        Else
            MessageBox.Show("Invalid Email Or Password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub registry_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registryLink.LinkClicked
        'clear the fields before leaving
        usrBox.Text = Nothing
        passwordBox.Text = Nothing
        chkShowPw.Checked = False

        registryForm.Show()
        Me.Hide()
    End Sub

    Private Sub devBtn_Click(sender As Object, e As EventArgs) Handles devBtn.Click
        'This is temporary. Will be taken out after production.
        UserSession.CurrentUserId = "USR01"

        main_dash.Show()
        Me.Hide()
    End Sub

    Private Sub chkShowPw_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPw.CheckedChanged
        If chkShowPw.Checked Then
            'remove masking to show plain text
            passwordBox.PasswordChar = ControlChars.NullChar
        Else
            passwordBox.PasswordChar = "•"c
        End If
    End Sub
End Class
