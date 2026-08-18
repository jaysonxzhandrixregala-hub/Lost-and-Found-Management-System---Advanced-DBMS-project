Public Class create_window

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click

        'messagebox shows of action completion before below

        main_dash.Show() 'or show view window to show newly added item. This is unlikely unless introduced a sorting display feature.
        Me.Hide()
    End Sub
End Class