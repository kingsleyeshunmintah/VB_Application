Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
'Imports MySqlConnector
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged, password.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        'Dim Uid As String = username.Text
        'Dim Pwd As String = password.Text
        'If Uid = "admin" And Pwd = "admin" Then
        '    Dashboard.Show()
        '    Me.Hide()
        'Else
        '    MessageBox.Show("Invalid Login info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        Dim Uid As String = username.Text
        Dim Pwd As String = password.Text

        ' Connection string to connect to the XAMPP MySQL database
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM admin WHERE name = @username AND password = @password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", Uid)
                    cmd.Parameters.AddWithValue("@password", Pwd)
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If result > 0 Then
                        Dim dashboard As New Dashboard(Uid)
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Login info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


    End Sub
End Class
