Imports MongoDB.Driver
Imports MongoDB.Bson
Imports DotNetEnv

Public Class create_window

    Private client As MongoClient
    Private database As IMongoDatabase

    Private Sub create_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Env.Load()
        Dim mongoUri = Environment.GetEnvironmentVariable("MONGODB_URI")
        client = New MongoClient(mongoUri)
        database = client.GetDatabase("lost_and_foundDB")

    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click

        'messagebox shows of action completion before below

        main_dash.Show() 'or show view window to show newly added item. This is unlikely unless introduced a sorting display feature.
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'must be a combobox
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        'We could have three comboboxes lined up horizontally for month, day, and year.
        'Or a calender thing?
        'Come on, we can do better than a textbox.
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        'combobox. Either 3 or 2 items of Lost, Found, and Idle.
        'Idle just means the item has been found, but no owner came to get it back.
        'But idk if I will add this. Feels like an optional thing but at the same time not.
    End Sub
End Class