Imports MySql.Data.MySqlClient

Public Class FrmRegister
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtUsername.Clear()
        txtfullname.Clear()
        txtpassword.Clear()
        txtconfirmpass.Clear()
        txtposition.Clear()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If txtfullname.Text = "" And txtpassword.Text = "" And txtconfirmpass.Text = "" And txtposition.Text = "" And txtUsername.Text = "" Then
            MessageBox.Show("Please Fill all fields")
        Else

            If txtpassword.Text = txtconfirmpass.Text Then
                conn.Open()

                Dim cm As New MySqlCommand("INSERT INTO tblUser(Username,Password,Fullname,Position) VALUES ('" & txtUsername.Text & "','" & txtpassword.Text & "','" & txtfullname.Text & "','" & txtposition.Text & "')", conn)
                cm.ExecuteNonQuery()
                MessageBox.Show("Registered Successfully")
                Me.Close()

                conn.close
            Else
                MessageBox.Show("Passwords not match")
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtconfirmpass.UseSystemPasswordChar = False
        Else
            txtconfirmpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
End Class