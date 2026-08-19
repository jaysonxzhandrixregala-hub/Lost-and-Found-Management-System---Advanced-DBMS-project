Imports MongoDB.Driver
Imports MongoDB.Bson
Imports DotNetEnv

Public Class create_window

    Private client As MongoClient
    Private database As IMongoDatabase

    'prevents duplication of unique id
    Private Function GetNextSequence(db As IMongoDatabase, sequenceName As String) As Long
        Dim counters = db.GetCollection(Of BsonDocument)("counters")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("_id", sequenceName)
        Dim update = Builders(Of BsonDocument).Update.Inc(Of Long)("seq", 1)

        Dim options = New FindOneAndUpdateOptions(Of BsonDocument) With {
        .ReturnDocument = ReturnDocument.After,
        .IsUpsert = True
    }

        Dim result = counters.FindOneAndUpdate(filter, update, options)
        Return result("seq").AsInt64
    End Function

    Private Sub create_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Env.Load()
        Dim mongoUri = Environment.GetEnvironmentVariable("MONGODB_URI")
        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")

    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click

        'basic input validation, checks if the fields are empty
        If String.IsNullOrWhiteSpace(itemName_Box.Text) OrElse
            String.IsNullOrWhiteSpace(descBox.Text) OrElse
            String.IsNullOrWhiteSpace(locationBox.Text) OrElse
            cmbCategory.SelectedIndex = -1 OrElse
            cmbStatus.SelectedIndex = -1 Then

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

        Try
            Dim create = database.GetCollection(Of BsonDocument)("createInfo")

            Dim nextNum As Long = GetNextSequence(database, "createInfo_id")
            Dim lnfId As String = $"lnf_{nextNum:D4}" 'formats with leading zeros 'lnf_0001'

            Dim category As String = cmbCategory.Text
            Dim status As String = cmbStatus.Text
            Dim item_date As String = datePicker.Value.Date

            Dim itemInfo As New BsonDocument From {
                {"_id", lnfId},
                {"item name", itemName_Box.Text},
                {"description", descBox.Text},
                {"category", category},
                {"location_found/lost", locationBox.Text},
                {"date", item_date},
                {"status", status}
            }

            create.InsertOne(itemInfo)
            MessageBox.Show($"Added item ""{itemName_Box.Text}"" to database as '{status}'." & Environment.NewLine & "Click OK to go back to dashboard.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'clears the fields for next action
            itemName_Box.Text = Nothing
            descBox.Text = Nothing
            cmbCategory.Text = Nothing
            locationBox.Text = Nothing
            cmbStatus.Text = Nothing

            main_dash.Show()
            Me.Hide()


        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'clears the fields
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        itemName_Box.Text = Nothing
        descBox.Text = Nothing
        cmbCategory.Text = Nothing
        locationBox.Text = Nothing
        cmbStatus.Text = Nothing
    End Sub
End Class