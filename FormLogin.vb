Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Buyer")
        cmbRole.SelectedIndex = 0

        txtPassword.UseSystemPasswordChar = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = cmbRole.SelectedItem.ToString()

        If role = "Admin" And username = "admin" And password = "admin123" Then
            MsgBox("Login sebagai Admin sukses!")
            FormAdminDashboard.Show()
            Me.Hide()
        ElseIf role = "Buyer" And username = "buyer" And password = "buyer123" Then
            MsgBox("Login sebagai Buyer sukses!")
            FormBuyerDashboard.Show()
            Me.Hide()
        Else
            lblInfo.Text = "Username / Password salah, silahkan coba lagi!"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Application.Exit()
    End Sub


End Class
