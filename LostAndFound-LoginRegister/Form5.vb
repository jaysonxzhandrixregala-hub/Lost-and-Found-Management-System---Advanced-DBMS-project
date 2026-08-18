Public Class view_window

    Private Sub viewClose_btn_Click(sender As Object, e As EventArgs) Handles viewClose_btn.Click
        main_dash.Show()
        Me.Hide()
    End Sub
End Class