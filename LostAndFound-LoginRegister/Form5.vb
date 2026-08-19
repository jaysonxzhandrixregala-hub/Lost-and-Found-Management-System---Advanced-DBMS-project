Imports System.Data.DataTable
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports DotNetEnv
Public Class view_window
    Dim table As New DataTable("Lost and Found Table")

    Private client As MongoClient
    Private database As IMongoDatabase

    Private Sub view_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Env.Load()
        Dim mongoUri As String = Environment.GetEnvironmentVariable("MONGODB_URI")

        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")

        Dim create_collection = database.GetCollection(Of BsonDocument)("createInfo")

        ' Example A: Fetching a single document into a variable
        Dim singleRecord As BsonDocument = create_collection.Find(New BsonDocument()).FirstOrDefault()
        table.Rows.Add(singleRecord)

        'If singleRecord IsNot Nothing Then
        '    ' Print the whole document to the console
        '    Console.WriteLine("Found record: " & singleRecord.ToJson())

        '    ' Extract a specific field into a string variable
        '    ' Dim nameVariable As String = singleRecord("name").AsString
        'Else
        '    Console.WriteLine("No data found.")
        'End If

    End Sub

    Private Sub viewClose_btn_Click(sender As Object, e As EventArgs) Handles viewClose_btn.Click
        main_dash.Show()
        Me.Hide()
    End Sub

End Class