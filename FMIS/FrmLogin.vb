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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        conn.Open()
        Dim cm As New MySqlCommand("SELECT * from tbluser Where Username = '" & txtUsername.Text & "' and Password= '" & txtpassword.Text & "'", conn)
        Dim reader As MySqlDataReader = cm.ExecuteReader
        If reader.Read() Then
            MessageBox.Show("account found")
            conn.Close()
            nameofuser(txtUsername.Text, txtpassword.Text)
            Me.Close()

        Else
            conn.Close()
            MessageBox.Show("user not found")
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
End Class