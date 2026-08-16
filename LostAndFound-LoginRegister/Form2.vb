<<<<<<< HEAD
﻿Imports MongoDB.Driver
Imports MongoDB.Bson
Imports DotNetEnv

Public Class registryForm

    Private client As MongoClient
    Private database As IMongoDatabase

    Private fnameClick As Boolean = True
    Private lnameClick As Boolean = True
    Private usernameClick As Boolean = True
    Private emailClick As Boolean = True
    Private passwordClick As Boolean = True


    Private Sub registryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Env.Load()
        Dim mongoUri As String = Environment.GetEnvironmentVariable("MONGODB_URI")

        If String.IsNullOrEmpty(mongoUri) Then
            MessageBox.Show("Error: MONGODB_URI could not be loaded from .env!")
            Exit Sub
        End If

        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")
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

            Dim register = database.GetCollection(Of BsonDocument)("RegistrationInfo")
            Dim login = database.GetCollection(Of BsonDocument)("LoginInfo")

            Dim user_reg As New BsonDocument From {
                {"fname", fnameBox.Text.Trim()}, '.Trim() removes whitespaces in text.
                {"mname", lnameBox.Text.Trim()}
            }

            Dim user_log As New BsonDocument From {
                {"username", usernameBox.Text},
                {"email", emailBox.Text},
                {"password", passwordBox.Text} 'I'll hash this tomorrow
            }

            register.InsertOne(user_reg)
            login.InsertOne(user_log)


            loginForm.Show()
            Me.Hide()


        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    'go to login form
    Private Sub loginlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginlink.LinkClicked
        loginForm.Show()
        Me.Hide()
    End Sub

    'textbox labels
    Private Sub fnameBox_Click(sender As Object, e As EventArgs) Handles fnameBox.Click
        If fnameClick = True Then
            fnameBox.Text = Nothing
            fnameBox.ForeColor = Color.Black
            fnameClick = False
        End If
    End Sub

    Private Sub lnameBox_Click(sender As Object, e As EventArgs) Handles lnameBox.Click
        If lnameClick = True Then
            lnameBox.Text = Nothing
            lnameBox.ForeColor = Color.Black
            lnameClick = False
        End If
    End Sub

    Private Sub usernameBox_Click(sender As Object, e As EventArgs) Handles usernameBox.Click
        If usernameClick = True Then
            usernameBox.Text = Nothing
            usernameBox.ForeColor = Color.Black
            usernameClick = False
        End If
    End Sub

    Private Sub emailBox_Click(sender As Object, e As EventArgs) Handles emailBox.Click
        If emailClick = True Then
            emailBox.Text = Nothing
            emailBox.ForeColor = Color.Black
            emailClick = False
        End If
    End Sub

    Private Sub passwordBox_Click(sender As Object, e As EventArgs) Handles passwordBox.Click
        If passwordClick = True Then
            passwordBox.Text = Nothing
            passwordBox.ForeColor = Color.Black
            passwordClick = False
        End If
    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    'End Sub
=======
﻿Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class registryForm

    Private client As MongoClient
    Private database As IMongoDatabase

    Private fnameClick As Boolean = True
    Private lnameClick As Boolean = True
    Private usernameClick As Boolean = True
    Private emailClick As Boolean = True
    Private passwordClick As Boolean = True


    Private Sub registryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        client = New MongoClient("/Users/jumong/Desktop/Lost-and-Found-Management-System---Advanced-DBMS-project-master/.env")
        database = client.GetDatabase("lost_and_foundDB")
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

            Dim register = database.GetCollection(Of BsonDocument)("RegistrationInfo")
            Dim login = database.GetCollection(Of BsonDocument)("LoginInfo")

            Dim user_reg As New BsonDocument From {
                {"fname", fnameBox.Text.Trim()}, '.Trim() removes whitespaces in text.
                {"mname", lnameBox.Text.Trim()}
            }

            Dim user_log As New BsonDocument From {
                {"username", usernameBox.Text},
                {"email", emailBox.Text},
                {"password", passwordBox.Text} 'I'll hash this tomorrow
            }

            register.InsertOne(user_reg)
            login.InsertOne(user_log)


            loginForm.Show()
            Me.Hide()


        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    'go to login form
    Private Sub loginlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginlink.LinkClicked
        loginForm.Show()
        Me.Hide()
    End Sub

    'textbox labels
    Private Sub fnameBox_Click(sender As Object, e As EventArgs) Handles fnameBox.Click
        If fnameClick = True Then
            fnameBox.Text = Nothing
            fnameBox.ForeColor = Color.Black
            fnameClick = False
        End If
    End Sub

    Private Sub lnameBox_Click(sender As Object, e As EventArgs) Handles lnameBox.Click
        If lnameClick = True Then
            lnameBox.Text = Nothing
            lnameBox.ForeColor = Color.Black
            lnameClick = False
        End If
    End Sub

    Private Sub usernameBox_Click(sender As Object, e As EventArgs) Handles usernameBox.Click
        If usernameClick = True Then
            usernameBox.Text = Nothing
            usernameBox.ForeColor = Color.Black
            usernameClick = False
        End If
    End Sub

    Private Sub emailBox_Click(sender As Object, e As EventArgs) Handles emailBox.Click
        If emailClick = True Then
            emailBox.Text = Nothing
            emailBox.ForeColor = Color.Black
            emailClick = False
        End If
    End Sub

    Private Sub passwordBox_Click(sender As Object, e As EventArgs) Handles passwordBox.Click
        If passwordClick = True Then
            passwordBox.Text = Nothing
            passwordBox.ForeColor = Color.Black
            passwordClick = False
        End If
    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    'End Sub
>>>>>>> 6daa593922f2f4b28e5eab698b0a084c6d11ffe8
End Class