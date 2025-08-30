<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AddStock
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtProductName = New TextBox()
        txtProductPrice = New TextBox()
        txtProductQuantity = New TextBox()
        AddProduct = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ProductDataGridView = New DataGridView()
        Update = New Button()
        txtProductId = New TextBox()
        txtNewPrice = New TextBox()
        txtAdditionalQuantity = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Button1 = New Button()
        CType(ProductDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(91, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 54)
        Label1.TabIndex = 0
        Label1.Text = "Add Stock"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(91, 166)
        txtProductName.Multiline = True
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(443, 69)
        txtProductName.TabIndex = 1
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.Location = New Point(91, 308)
        txtProductPrice.Multiline = True
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(443, 69)
        txtProductPrice.TabIndex = 1
        ' 
        ' txtProductQuantity
        ' 
        txtProductQuantity.Location = New Point(91, 462)
        txtProductQuantity.Multiline = True
        txtProductQuantity.Name = "txtProductQuantity"
        txtProductQuantity.Size = New Size(443, 69)
        txtProductQuantity.TabIndex = 1
        ' 
        ' AddProduct
        ' 
        AddProduct.BackColor = Color.Chartreuse
        AddProduct.Font = New Font("Segoe UI", 15F)
        AddProduct.Location = New Point(611, 444)
        AddProduct.Name = "AddProduct"
        AddProduct.Size = New Size(529, 87)
        AddProduct.TabIndex = 2
        AddProduct.Text = "Add Product"
        AddProduct.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = SystemColors.ButtonShadow
        Label2.Location = New Point(91, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 28)
        Label2.TabIndex = 3
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(91, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 28)
        Label3.TabIndex = 3
        Label3.Text = "Product Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(91, 404)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 28)
        Label4.TabIndex = 3
        Label4.Text = "Product Qty"
        ' 
        ' ProductDataGridView
        ' 
        ProductDataGridView.BackgroundColor = SystemColors.ButtonHighlight
        ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ProductDataGridView.Location = New Point(611, 43)
        ProductDataGridView.Name = "ProductDataGridView"
        ProductDataGridView.RowHeadersWidth = 62
        ProductDataGridView.Size = New Size(529, 374)
        ProductDataGridView.TabIndex = 4
        ' 
        ' Update
        ' 
        Update.BackColor = Color.Lime
        Update.Location = New Point(91, 813)
        Update.Name = "Update"
        Update.Size = New Size(203, 78)
        Update.TabIndex = 5
        Update.Text = "Update Product"
        Update.UseVisualStyleBackColor = False
        ' 
        ' txtProductId
        ' 
        txtProductId.Location = New Point(91, 712)
        txtProductId.Multiline = True
        txtProductId.Name = "txtProductId"
        txtProductId.Size = New Size(320, 72)
        txtProductId.TabIndex = 6
        ' 
        ' txtNewPrice
        ' 
        txtNewPrice.Location = New Point(611, 661)
        txtNewPrice.Multiline = True
        txtNewPrice.Name = "txtNewPrice"
        txtNewPrice.Size = New Size(529, 77)
        txtNewPrice.TabIndex = 6
        ' 
        ' txtAdditionalQuantity
        ' 
        txtAdditionalQuantity.Location = New Point(611, 822)
        txtAdditionalQuantity.Multiline = True
        txtAdditionalQuantity.Name = "txtAdditionalQuantity"
        txtAdditionalQuantity.Size = New Size(529, 69)
        txtAdditionalQuantity.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(611, 769)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 28)
        Label5.TabIndex = 3
        Label5.Text = "Product Qty"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1127, 1330)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(529, 69)
        TextBox1.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(611, 628)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 28)
        Label6.TabIndex = 3
        Label6.Text = "Product Price"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(1128, 1289)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 28)
        Label7.TabIndex = 3
        Label7.Text = "Product Qty"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1647, 1775)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(529, 69)
        TextBox2.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(91, 661)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 28)
        Label8.TabIndex = 3
        Label8.Text = "Product ID"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20F)
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(91, 581)
        Label9.Name = "Label9"
        Label9.Size = New Size(302, 54)
        Label9.TabIndex = 0
        Label9.Text = "Update Product"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(318, 813)
        Button1.Name = "Button1"
        Button1.Size = New Size(216, 80)
        Button1.TabIndex = 7
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' UC_AddStock
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtAdditionalQuantity)
        Controls.Add(txtNewPrice)
        Controls.Add(txtProductId)
        Controls.Add(Label7)
        Controls.Add(Update)
        Controls.Add(Label5)
        Controls.Add(ProductDataGridView)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(AddProduct)
        Controls.Add(txtProductQuantity)
        Controls.Add(txtProductPrice)
        Controls.Add(txtProductName)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Name = "UC_AddStock"
        Size = New Size(1206, 983)
        CType(ProductDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents AddProduct As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents Update As Button
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents txtNewPrice As TextBox
    Friend WithEvents txtAdditionalQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button

End Class
