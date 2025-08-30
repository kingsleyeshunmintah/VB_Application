Imports MySql.Data.MySqlClient

Public Class UC_AdminProfile
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(username As String)
        InitializeComponent()
        AdminTest.Text = username

        AdminTest.ReadOnly = True

    End Sub

    Private Sub updateProfile_Click(sender As Object, e As EventArgs) Handles updateProfile.Click

        Dim Uid As String = AdminTest.Text
        Dim Pwd As String = password.Text

        ' Connection string to connect to the XAMPP MySQL database
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE admin SET password = @password WHERE name = @username"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", Uid)
                    cmd.Parameters.AddWithValue("@password", Pwd)
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Profile updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to update profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub

    Private Sub AddNewAdmin_Click(sender As Object, e As EventArgs) Handles AddNewAdmin.Click
        Dim newUsername As String = NewAdminName.Text
        Dim newPassword As String = NewAdminPwd.Text

        ' Connection string to connect to the XAMPP MySQL database
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO admin (name, password) VALUES (@username, @password)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", newUsername)
                    cmd.Parameters.AddWithValue("@password", newPassword)
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("New admin added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to add new admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminNameToDelete As String = NameToDelete.Text

        ' Connection string to connect to the XAMPP MySQL database
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM admin WHERE name = @username"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", adminNameToDelete)
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Admin deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to delete admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class
