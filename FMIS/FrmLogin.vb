Imports MySql.Data.MySqlClient
Public Class FrmLogin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim loginchecker As Integer
        loginchecker = 0
        checklogin(loginchecker)
        Me.Close()
    End Sub
    Private Sub checklogin(checker As Integer)

        If checker = 0 Then
            Me.Close()
            Form1.Close()
        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Hide()
        LinkLabel1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "admin" And txtpassword.Text = "admin" Then
            Label3.Show()
            LinkLabel1.Show()
        Else
            conn.Open()
            Dim cm As New MySqlCommand("SELECT * from tbluser Where Username = '" & txtUsername.Text & "' and Password= '" & txtpassword.Text & "'", conn)
            Dim reader As MySqlDataReader = cm.ExecuteReader
            If reader.Read() Then
                MessageBox.Show("account found")
                conn.Close()
                nameofuser(txtUsername.Text, txtpassword.Text)
                Form1.btnlogout.Show()
                Form1.btndashboard.Show()
                Form1.btnbackup.Show()
                Form1.btnnewtransaction.Show()
                Form1.btnprintdocument.Show()
                Form1.btnreports.Show()
                Form1.btnvalidation.Show()
                Me.Close()

            Else
                conn.Close()
                MessageBox.Show("user not found")
            End If
        End If




    End Sub
    Private Sub nameofuser(username As String, password As String)
        conn.Open()
        Dim cm As New MySqlCommand("SELECT Fullname from tbluser Where Username = '" & username & "' and Password= '" & password & "'", conn)
        Dim reader As MySqlDataReader = cm.ExecuteReader
        If reader.Read Then
            Form1.Label1.Text = reader("Fullname")
            Form1.Label1.Show()
            Form1.Label2.Show()
        End If

        conn.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        FrmRegister.Show()
        FrmRegister.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Hide()
        FrmGuest.Show()

    End Sub
End Class