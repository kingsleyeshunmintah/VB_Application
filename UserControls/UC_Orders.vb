Imports MySql.Data.MySqlClient

Public Class UC_Orders
    Private customerToken As String

    ' Add customer info
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                customerToken = Guid.NewGuid().ToString()

                Dim customerName As String = TextBox1.Text
                Dim customerPhone As String = TextBox2.Text

                Dim query As String = "INSERT INTO customers (customer_token, customer_name, customer_phone) VALUES (@CustomerToken, @CustomerName, @CustomerPhone)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CustomerToken", customerToken)
                    cmd.Parameters.AddWithValue("@CustomerName", customerName)
                    cmd.Parameters.AddWithValue("@CustomerPhone", customerPhone)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Customer info added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Add product for this order
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(customerToken) Then
            MessageBox.Show("Please add customer info first.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim productName As String = ComboBox1.Text
                Dim productQuantity As Integer = Integer.Parse(TextBox5.Text)

                ' Get product price and current quantity
                Dim priceQuery As String = "SELECT product_price, product_quantity FROM products WHERE product_name = @ProductName"
                Dim productPrice As Decimal = 0
                Dim currentQuantity As Integer = 0

                Using priceCmd As New MySqlCommand(priceQuery, connection)
                    priceCmd.Parameters.AddWithValue("@ProductName", productName)
                    Using reader As MySqlDataReader = priceCmd.ExecuteReader()
                        If reader.Read() Then
                            productPrice = Convert.ToDecimal(reader("product_price"))
                            currentQuantity = Convert.ToInt32(reader("product_quantity"))
                        End If
                    End Using
                End Using

                ' Check if the quantity being added is not greater than the quantity in the database
                If productQuantity > currentQuantity Then
                    MessageBox.Show("Insufficient stock quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Subtract the quantity from the existing stock
                Dim updateQuery As String = "UPDATE products SET product_quantity = product_quantity - @ProductQuantity WHERE product_name = @ProductName"
                Using updateCmd As New MySqlCommand(updateQuery, connection)
                    updateCmd.Parameters.AddWithValue("@ProductQuantity", productQuantity)
                    updateCmd.Parameters.AddWithValue("@ProductName", productName)
                    updateCmd.ExecuteNonQuery()
                End Using

                Dim totalPrice As Decimal = productPrice * productQuantity

                Dim query As String = "
                INSERT INTO orders 
                (customer_token, product_name, product_quantity, product_price, total_price) 
                VALUES 
                (@CustomerToken, @ProductName, @ProductQuantity, @ProductPrice, @TotalPrice)
            "

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CustomerToken", customerToken)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@ProductQuantity", productQuantity)
                    cmd.Parameters.AddWithValue("@ProductPrice", productPrice)
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice)

                    cmd.ExecuteNonQuery()
                End Using

                LoadOrders()
                CalculateTotal()

                MessageBox.Show("Product added to list successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Load orders joined with customer details
    Private Sub LoadOrders()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "
                    SELECT o.id, c.customer_name, c.customer_phone, o.product_name, o.product_quantity
                    FROM orders o
                    INNER JOIN customers c ON o.customer_token = c.customer_token
                    ORDER BY o.id DESC
                "

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table

            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Load products into ComboBox1
    Private Sub LoadProducts()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT product_name FROM products"
                Dim cmd As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ComboBox1.Items.Add(reader("product_name").ToString())
                End While

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub UC_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
        LoadProducts()
        CalculateTotal()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Order confirmed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub CalculateTotal()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"
        Dim total As Decimal = 0

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT SUM(total_price) FROM orders WHERE customer_token = @CustomerToken"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CustomerToken", customerToken)

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        total = Convert.ToDecimal(result)
                    End If
                End Using

                TotalPriceLable.Text = "Total: ₵" & total.ToString("F2")

            Catch ex As MySqlException
                MessageBox.Show("Error calculating total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
