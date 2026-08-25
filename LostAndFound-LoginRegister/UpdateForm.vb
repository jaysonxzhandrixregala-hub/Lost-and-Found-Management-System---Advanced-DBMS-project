Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DotNetEnv
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class UpdateForm

    Private client As MongoClient
    Private database As IMongoDatabase

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Env.Load()
        Dim mongoUri As String = Environment.GetEnvironmentVariable("MONGODB_URI")

        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")

        LoadDataToCmb()
    End Sub

    Public Sub LoadDataToCmb()
        Dim create_collection = database.GetCollection(Of BsonDocument)("createInfo")

        ' Fetch all documents from the collection
        Dim documents = create_collection.Find(FilterDefinition(Of BsonDocument).Empty).ToList()

        ' For Loop to populate cmb_createId rows
        For Each doc As BsonDocument In documents

            Dim id As String = If(doc.Contains("_id"), doc("_id").ToString(), "")

            cmb_createId.Items.Add(id)
        Next
    End Sub

    Public Sub LoadDataToFields(selectedId As String)
        If String.IsNullOrWhiteSpace(selectedId) Then
            MessageBox.Show("Please select or enter an ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim create_collection = database.GetCollection(Of BsonDocument)("createInfo")
        Dim document As BsonDocument = Nothing
        Dim cleanId As String = selectedId.Trim()

        ' 1. Try matching as ObjectId
        Dim objId As ObjectId
        If ObjectId.TryParse(cleanId, objId) Then
            Dim filterObj = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", objId)
            document = create_collection.Find(filterObj).FirstOrDefault()
        End If

        ' 2. Fallback: Try matching as String (if _id was stored as a string in MongoDB)
        If document Is Nothing Then
            Dim filterStr = Builders(Of BsonDocument).Filter.Eq(Of String)("_id", cleanId)
            document = create_collection.Find(filterStr).FirstOrDefault()
        End If

        ' 3. Alert if document is not found
        If document Is Nothing Then
            MessageBox.Show($"No record found matching ID: {cleanId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Safe extraction helper to handle missing fields and BsonNull
        Dim SafeString = Function(key As String) As String
                             If document.Contains(key) AndAlso Not document(key).IsBsonNull Then
                                 Return document(key).ToString()
                             End If
                             Return ""
                         End Function

        ' Populate Form Controls
        itemName_Box.Text = SafeString("item name")
        descBox.Text = SafeString("description")
        locationBox.Text = SafeString("location_found/lost")
        cmbCategory.Text = SafeString("category")
        cmbStatus.Text = SafeString("status")

        ' Handle Date Field safely
        If document.Contains("date") AndAlso Not document("date").IsBsonNull Then
            Try
                dtp_update.Value = document("date").ToUniversalTime().ToLocalTime()
            Catch
                dtp_update.Value = DateTime.Now
            End Try
        Else
            dtp_update.Value = DateTime.Now
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        LoadDataToFields(cmb_createId.Text)
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim selectedId As String = cmb_createId.Text.Trim()

        If String.IsNullOrWhiteSpace(selectedId) Then
            MessageBox.Show("Please select or enter an ID to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim create_coll = database.GetCollection(Of BsonDocument)("createInfo")

        ' Build filter
        Dim filter As FilterDefinition(Of BsonDocument)
        Dim objId As ObjectId
        If ObjectId.TryParse(selectedId, objId) Then
            filter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", objId)
        Else
            filter = Builders(Of BsonDocument).Filter.Eq(Of String)("_id", selectedId)
        End If

        ' Build update definition using BsonDocument $set operator
        Dim updateDef As New BsonDocument("$set", New BsonDocument From {
        {"item name", itemName_Box.Text},
        {"description", descBox.Text},
        {"category", cmbCategory.Text},
        {"location_found/lost", locationBox.Text},
        {"date", dtp_update.Value},
        {"status", cmbStatus.Text}
    })

        ' Execute update
        Dim updateResult = create_coll.UpdateOne(filter, updateDef)

        If updateResult.ModifiedCount > 0 Then
            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf updateResult.MatchedCount > 0 Then
            MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No matching record found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        itemName_Box.Text = Nothing
        descBox.Text = Nothing
        locationBox.Text = Nothing
        cmbCategory.Text = Nothing
        cmbStatus.Text = Nothing
        cmb_createId.Text = Nothing
        main_dash.Show()
        Me.Hide()
    End Sub

End Class