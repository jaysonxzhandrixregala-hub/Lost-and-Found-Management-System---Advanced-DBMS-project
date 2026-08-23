Imports System.Data.DataTable
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports DotNetEnv
Public Class view_window

    Private client As MongoClient
    Private database As IMongoDatabase

    Private Sub view_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Env.Load()
        Dim mongoUri As String = Environment.GetEnvironmentVariable("MONGODB_URI")

        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")

        SetupGridColumns()
        LoadDataToGrid()

    End Sub

    Private Sub SetupGridColumns()
        dgvLnf.Columns.Clear()
        dgvLnf.Columns.Add("colID", "ID")
        dgvLnf.Columns.Add("colItemName", "Item Name")
        dgvLnf.Columns.Add("colDescription", "Description")
        dgvLnf.Columns.Add("colCategory", "Category")
        dgvLnf.Columns.Add("colLoc", "Location")
        dgvLnf.Columns.Add("colDate", "Date")
        dgvLnf.Columns.Add("colStatus", "Status")
    End Sub

    Public Sub LoadDataToGrid()
        Dim create_collection = database.GetCollection(Of BsonDocument)("createInfo")

        ' Clear existing rows to handle refresh without duplicating
        dgvLnf.Rows.Clear()

        ' Fetch all documents from the collection
        Dim documents = create_collection.Find(FilterDefinition(Of BsonDocument).Empty).ToList()

        ' For Loop to populate DataGridView rows
        For Each doc As BsonDocument In documents

            Dim id As String = If(doc.Contains("_id"), doc("_id").ToString(), "")
            Dim itemName As String = If(doc.Contains("item name"), doc("item name").AsString, "")
            Dim desc As String = If(doc.Contains("description"), doc("description").AsString, "")
            Dim category As String = If(doc.Contains("category"), doc("category").AsString, "")
            Dim loc As String = If(doc.Contains("location_found/lost"), doc("location_found/lost").AsString, "")
            Dim itemDate As String = If(doc.Contains("Date"), doc("Date").AsString, "")
            Dim itemStatus As String = If(doc.Contains("status"), doc("status").AsString, "")

            dgvLnf.Rows.Add(id, itemName, desc, category, loc, itemDate, itemStatus)
        Next
    End Sub

    Private Sub viewClose_btn_Click(sender As Object, e As EventArgs) Handles viewClose_btn.Click
        main_dash.Show()
        Me.Hide()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        LoadDataToGrid()
    End Sub
End Class