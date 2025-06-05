Public Class FormBuyerDashboard
    Private Sub FormBuyerDushboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim formLogin As New FormLogin()
        formLogin.Show()
        Me.Close()
    End Sub
End Class