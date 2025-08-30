Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports Windows.Win32.System

Public Class UC_Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateDashboard()
    End Sub

    Private Sub UpdateDashboard()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Get total customers
            Dim totalCustomersQuery As String = "SELECT COUNT(DISTINCT customer_token) FROM Orders"
            Dim totalCustomersCommand As New MySqlCommand(totalCustomersQuery, connection)
            Dim totalCustomers As Integer = Convert.ToInt32(totalCustomersCommand.ExecuteScalar())
            TCustomer.Text = totalCustomers.ToString()

            ' Get total products
            Dim totalProductsQuery As String = "SELECT COUNT(DISTINCT id) FROM Orders"
            Dim totalProductsCommand As New MySqlCommand(totalProductsQuery, connection)
            Dim totalProducts As Integer = Convert.ToInt32(totalProductsCommand.ExecuteScalar())
            Tproduct.Text = totalProducts.ToString()

            ' Get total income
            Dim totalIncomeQuery As String = "SELECT SUM(total_price) FROM Orders"
            Dim totalIncomeCommand As New MySqlCommand(totalIncomeQuery, connection)
            Dim totalIncome As Decimal = Convert.ToDecimal(totalIncomeCommand.ExecuteScalar())
            Dim ghanaCulture As CultureInfo = New CultureInfo("en-GH")
            Tincome.Text = totalIncome.ToString("C", ghanaCulture)

            ' Populate GridView
            Dim ordersQuery As String = "SELECT * FROM Orders"
            Dim ordersAdapter As New MySqlDataAdapter(ordersQuery, connection)
            Dim ordersTable As New DataTable()
            ordersAdapter.Fill(ordersTable)
            DataGridView1.DataSource = ordersTable
        End Using
    End Sub
End Class
