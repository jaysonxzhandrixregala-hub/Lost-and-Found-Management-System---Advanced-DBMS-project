Public Class main_dash
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    'Private Sub Form3_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    create_btn.Left = (Me.ClientSize.Width - create_btn.Width) / 2
    '    create_btn.Top = (Me.ClientSize.Height - create_btn.Height) / 2

    '    read_btn.Left = (Me.ClientSize.Width - read_btn.Width) / 2
    '    read_btn.Top = (Me.ClientSize.Height - read_btn.Height) / 2

    '    update_btn.Left = (Me.ClientSize.Width - update_btn.Width) / 2
    '    update_btn.Top = (Me.ClientSize.Height - update_btn.Height) / 2

    '    del_btn.Left = (Me.ClientSize.Width - del_btn.Width) / 2
    '    del_btn.Top = (Me.ClientSize.Height - del_btn.Height) / 2
    'End Sub

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
        UpdateForm.Show()
        Me.Hide()
    End Sub

    Private Sub del_btn_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        DeletionForm.Show()
        Me.Hide()
    End Sub

    'logout
    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Exit()
    End Sub
End Class