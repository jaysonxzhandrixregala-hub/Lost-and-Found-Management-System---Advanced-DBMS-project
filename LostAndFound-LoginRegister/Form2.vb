Imports MongoDB.Driver
Imports MongoDB.Bson
Imports DotNetEnv
Imports System.Runtime.InteropServices

Public Class registryForm

    Private client As MongoClient
    Private database As IMongoDatabase

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As String) As IntPtr
    End Function

    'prevents duplication of unique id
    Private Function GetNextSequence(db As IMongoDatabase, sequenceName As String) As Long
        Dim counters = db.GetCollection(Of BsonDocument)("userId_counters")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("_id", sequenceName)
        Dim update = Builders(Of BsonDocument).Update.Inc(Of Long)("seq", 1)

        Dim options = New FindOneAndUpdateOptions(Of BsonDocument) With {
        .ReturnDocument = ReturnDocument.After,
        .IsUpsert = True
    }

        Dim result = counters.FindOneAndUpdate(filter, update, options)
        Return result("seq").AsInt64
    End Function

    Private Sub registryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Env.Load()
        Dim mongoUri As String = Environment.GetEnvironmentVariable("MONGODB_URI")

        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")

        SendMessage(fnameBox.Handle, EM_SETCUEBANNER, New IntPtr(1), "First Name")
        SendMessage(lnameBox.Handle, EM_SETCUEBANNER, New IntPtr(1), "Last Name")
        SendMessage(usernameBox.Handle, EM_SETCUEBANNER, New IntPtr(1), "Username")
        SendMessage(emailBox.Handle, EM_SETCUEBANNER, New IntPtr(1), "john@example.com")
        SendMessage(passwordBox.Handle, EM_SETCUEBANNER, New IntPtr(1), "Password")

        tipPw.SetToolTip(chkRegPass, "Show Password?")

    End Sub

    'register button
    Private Sub register_button_Click(sender As Object, e As EventArgs) Handles register_button.Click
        'basic input validation, checks if the fields are empty
        If String.IsNullOrWhiteSpace(fnameBox.Text) OrElse
            String.IsNullOrWhiteSpace(lnameBox.Text) OrElse
            String.IsNullOrWhiteSpace(usernameBox.Text) OrElse
            String.IsNullOrWhiteSpace(emailBox.Text) OrElse
            String.IsNullOrWhiteSpace(passwordBox.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'fix the hole where the text label for the textboxes also serves as a input from the user
        If fnameBox.Text = "First Name" OrElse
            lnameBox.Text = "Last Name" OrElse
            usernameBox.Text = "Username" OrElse
            emailBox.Text = "Email" OrElse
            passwordBox.Text = "Password" Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'prompt user confirmation
        Dim confirm_data As DialogResult = MessageBox.Show(
            "Are you sure all details are correct?",
            "Confirmation Registration",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm_data <> DialogResult.Yes Then Exit Sub

        'below this line will not run if you click 'No' on the messagebox confirmation
        '------------------------------------------------------------------------

        Try

            Dim usersColl = database.GetCollection(Of BsonDocument)("users")

            Dim nextNum As Long = GetNextSequence(database, "userId")
            UserSession.CurrentUserId = $"USR{nextNum:D2}"

            Dim user As New BsonDocument From {
                {"_id", UserSession.CurrentUserId},
                {"auth", New BsonDocument From {
                {"username", usernameBox.Text},
                {"email", emailBox.Text},
                {"password", passwordBox.Text}
            }},
                {"profile", New BsonDocument From {
                {"firstName", fnameBox.Text},
                {"lastName", lnameBox.Text}
            }},
                {"createdAt", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}
            }

            usersColl.InsertOne(user)

            MessageBox.Show("Registration complete. You can now log in.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loginForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    'go to login form
    Private Sub loginlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginlink.LinkClicked
        'clears the fields before leaving
        fnameBox.Text = Nothing
        lnameBox.Text = Nothing
        usernameBox.Text = Nothing
        emailBox.Text = Nothing
        passwordBox.Text = Nothing

        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub chkRegPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegPass.CheckedChanged
        If chkRegPass.Checked Then
            'remove masking to show plain text
            passwordBox.PasswordChar = ControlChars.NullChar
        Else
            passwordBox.PasswordChar = "•"c
        End If
    End Sub
End Class
