Public Class deletion_window

    Private Sub deletion_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlDeletionCard.Left = (Me.ClientSize.Width - PnlDeletionCard.Width) / 2
        PnlDeletionCard.Top = (Me.ClientSize.Height - PnlDeletionCard.Height) / 2
    End Sub

    Private Sub deletebutton_Click(sender As Object, e As EventArgs) Handles deletion_btn.Click

        'messagebox shows of action completion before below

        main_dash.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class