Public Class main_dash
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    'window calling
    Private Sub create_btn_Click(sender As Object, e As EventArgs) Handles create_btn.Click
        create_window.Show()
        Me.Hide() 'we could also not?
    End Sub

    Private Sub read_btn_Click(sender As Object, e As EventArgs) Handles read_btn.Click
        view_window.Show()
        Me.Hide()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        update_window.Show()
        Me.Hide()
    End Sub

    Private Sub del_btn_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        deletion_window.Show()
        Me.Hide()
    End Sub

    'logout
    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Exit()
    End Sub

End Class