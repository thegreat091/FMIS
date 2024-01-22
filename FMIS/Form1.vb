Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Label2.Hide()
        Label1.Hide()
        btnlogout.Hide()
        FrmLogin.ShowDialog()

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click

    End Sub
End Class
