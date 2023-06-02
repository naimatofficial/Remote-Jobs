Public Class Form1
    Private Sub LoginBtn_Click_1(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If emailTxt.Text <> String.Empty Or passTxt.Text <> String.Empty Then
            Dim email = emailTxt.Text
            Dim password = passTxt.Text

            MessageBox.Show("Logged In...", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("email or password is not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
