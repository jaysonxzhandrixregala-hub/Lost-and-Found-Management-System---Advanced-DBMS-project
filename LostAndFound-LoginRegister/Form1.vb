Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class loginForm

    Private client As MongoClient
    Private database As IMongoDatabase

    Dim usr_oneClick As Boolean = True
    Dim pwd_oneClick As Boolean = True

    Private Sub registry_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registryLink.LinkClicked
        registryForm.Show()
        Me.Hide()
    End Sub

    Private Sub usrBox_Click(sender As Object, e As EventArgs) Handles usrBox.Click
        If usr_oneClick = True Then
            usrBox.Text = Nothing
            usr_oneClick = False
        End If
    End Sub

    Private Sub passwordBox_Click(sender As Object, e As EventArgs) Handles passwordBox.Click
        If pwd_oneClick = True Then
            passwordBox.ForeColor = Color.Black
            passwordBox.Text = Nothing
            pwd_oneClick = False
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        client = New MongoClient("mongodb+srv://lostandfound:lost_found123@cluster0.7iovwjg.mongodb.net/") 'connection string from cluster
        database = client.GetDatabase("lost_and_foundDB")
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

        Dim login = database.GetCollection(Of BsonDocument)("LoginInfo")

        Dim filter As New BsonDocument From {
            {"username", usrBox.Text.Trim()},
            {"password", passwordBox.Text} 'hash this shit
        }

        Dim user = login.Find(filter).FirstOrDefault()

        If user IsNot Nothing Then
            Form3.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Email Or Password")
        End If
    End Sub
End Class
