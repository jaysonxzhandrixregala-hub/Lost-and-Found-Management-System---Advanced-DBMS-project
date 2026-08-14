Public Class registryForm
    Private Sub register_button_Click(sender As Object, e As EventArgs) Handles register_button.Click

    End Sub

    Private Sub loginlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginlink.LinkClicked
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub registryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class