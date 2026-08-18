Public Class update_window
    Private Sub updwin_btn_Click(sender As Object, e As EventArgs) Handles updwin_btn.Click

        'messagebox shows of action completion before below

        main_dash.Show() 'or show the view windows directly to show the updated data
        Me.Hide()
    End Sub
End Class