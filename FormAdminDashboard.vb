Public Class FormAdminDashboard
    Private Sub btnManageEvent_Click(sender As Object, e As EventArgs) Handles btnManageEvent.Click
        ' Membuka form manajemen event
        Dim formManageEvent As New FormManageEvents()
        formManageEvent.Show()
    End Sub

    Private Sub btnViewReports_Click(sender As Object, e As EventArgs) Handles btnViewReports.Click
        ' Membuka form laporan
        Dim formReports As New FormReports()
        formReports.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Kembali ke form login
        Dim formLogin As New FormLogin()
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub FormAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
