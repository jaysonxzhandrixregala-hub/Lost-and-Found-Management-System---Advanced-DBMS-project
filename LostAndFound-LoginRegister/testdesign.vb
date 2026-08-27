Imports System.Drawing
Imports System.Windows.Forms

Public Class testdesign

    ' Variables enabling window dragging for frameless border
    Private isDragging As Boolean = False
    Private dragCursorPoint As Point
    Private dragFormPoint As Point

    Private Sub testdesign_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, pnlCard.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            dragCursorPoint = Cursor.Position
            dragFormPoint = Me.Location
        End If
    End Sub

    Private Sub testdesign_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, pnlCard.MouseMove
        If isDragging Then
            Dim diff As Point = Point.Subtract(Cursor.Position, New Size(dragCursorPoint))
            Me.Location = Point.Add(dragFormPoint, New Size(diff))
        End If
    End Sub

    Private Sub testdesign_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, pnlCard.MouseUp
        isDragging = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class