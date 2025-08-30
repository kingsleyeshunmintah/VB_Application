Imports MySql.Data.MySqlClient

Public Class UC_AddStock
    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        ' Connection string to connect to the XAMPP MySQL database
        Dim connectionString = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Step 2: Retrieve form values
                Dim productName = txtProductName.Text
                Dim productPrice = Decimal.Parse(txtProductPrice.Text)
                Dim productQuantity = Integer.Parse(txtProductQuantity.Text)

                ' Step 3: Construct an SQL INSERT statement
                Dim query = "INSERT INTO products (product_name, product_price, product_quantity) VALUES (@ProductName, @ProductPrice, @ProductQuantity)"

                ' Step 4: Execute the SQL statement
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@ProductPrice", productPrice)
                    cmd.Parameters.AddWithValue("@ProductQuantity", productQuantity)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub LoadProducts()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=inventory_mega"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM products"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                ProductDataGridView.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub UC_AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the products when the UserControl loads
        LoadProducts()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        ' Connection string to connect to the XAMPP MySQL database
        Dim connectionString = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Step 2: Retrieve form values
                Dim productId = Integer.Parse(txtProductId.Text)
                Dim newPrice = Decimal.Parse(txtNewPrice.Text)
                Dim additionalQuantity = Integer.Parse(txtAdditionalQuantity.Text)

                ' Step 3: Construct an SQL UPDATE statement
                Dim query = "UPDATE products SET product_price = @NewPrice, product_quantity = product_quantity + @AdditionalQuantity WHERE id = @ProductId"

                ' Step 4: Execute the SQL statement
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ProductId", productId)
                    cmd.Parameters.AddWithValue("@NewPrice", newPrice)
                    cmd.Parameters.AddWithValue("@AdditionalQuantity", additionalQuantity)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadProducts() ' Refresh the product list
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Connection string to connect to the XAMPP MySQL database
        Dim connectionString = "server=localhost;userid=root;password=;database=inventory_mega"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Step 2: Retrieve form values
                Dim productId = Integer.Parse(txtProductId.Text)

                ' Step 3: Construct an SQL DELETE statement
                Dim query = "DELETE FROM products WHERE id = @ProductId"

                ' Step 4: Execute the SQL statement
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ProductId", productId)

                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to delete product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

                LoadProducts() ' Refresh the product list
            Catch ex As MySqlException
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class

