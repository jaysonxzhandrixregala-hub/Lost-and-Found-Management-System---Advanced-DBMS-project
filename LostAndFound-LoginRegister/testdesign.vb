Imports System.Data.DataTable
Imports System.Drawing
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports DotNetEnv

Public Class testdesign

    Private client As MongoClient
    Private database As IMongoDatabase

    ' Form Window Dragging Logic
    Private isDraggingWindow As Boolean = False
    Private cursorOffsetPoint As Point
    Private formLocationPoint As Point

    Private Sub testdesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    ' Mouse Event Handlers for Moving Frameless Form
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles uiPanelHeader.MouseDown, Me.MouseDown
        If e.Button = MouseButtons.Left Then
            isDraggingWindow = True
            cursorOffsetPoint = Cursor.Position
            formLocationPoint = Me.Location
        End If
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles uiPanelHeader.MouseMove, Me.MouseMove
        If isDraggingWindow Then
            Dim diff As Point = Point.Subtract(Cursor.Position, New Size(cursorOffsetPoint))
            Me.Location = Point.Add(formLocationPoint, New Size(diff))
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles uiPanelHeader.MouseUp, Me.MouseUp
        isDraggingWindow = False
    End Sub

End Class