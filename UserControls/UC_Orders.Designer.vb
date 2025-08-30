<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Orders
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox5 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Button3 = New Button()
        Label6 = New Label()
        TotalPriceLable = New Label()
        ComboBox1 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(62, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(432, 54)
        Label1.TabIndex = 0
        Label1.Text = "Orders And Purchasing"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(80, 218)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(397, 64)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(80, 339)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(397, 64)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(690, 162)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(397, 64)
        TextBox5.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(80, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 2
        Label2.Text = "Customer Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(80, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 25)
        Label3.TabIndex = 2
        Label3.Text = "Customer Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(682, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 25)
        Label4.TabIndex = 2
        Label4.Text = "Product Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(682, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 25)
        Label5.TabIndex = 2
        Label5.Text = "Quantity"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Goldenrod
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.Location = New Point(80, 427)
        Button1.Name = "Button1"
        Button1.Size = New Size(397, 71)
        Button1.TabIndex = 3
        Button1.Text = "Create Customer Info"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Goldenrod
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.Location = New Point(689, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(397, 71)
        Button2.TabIndex = 3
        Button2.Text = "Add To List"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(80, 588)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1018, 325)
        DataGridView1.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Lime
        Button3.Font = New Font("Segoe UI", 10F)
        Button3.Location = New Point(690, 427)
        Button3.Name = "Button3"
        Button3.Size = New Size(397, 71)
        Button3.TabIndex = 3
        Button3.Text = "Confirm"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(689, 362)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 41)
        Label6.TabIndex = 5
        Label6.Text = "Total : "
        ' 
        ' TotalPriceLable
        ' 
        TotalPriceLable.AutoSize = True
        TotalPriceLable.Font = New Font("Segoe UI", 15F)
        TotalPriceLable.ForeColor = SystemColors.ButtonHighlight
        TotalPriceLable.Location = New Point(799, 362)
        TotalPriceLable.Name = "TotalPriceLable"
        TotalPriceLable.Size = New Size(73, 41)
        TotalPriceLable.TabIndex = 5
        TotalPriceLable.Text = "0.00"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(690, 73)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(396, 33)
        ComboBox1.TabIndex = 6
        ' 
        ' UC_Orders
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        Controls.Add(ComboBox1)
        Controls.Add(TotalPriceLable)
        Controls.Add(Label6)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "UC_Orders"
        Size = New Size(1211, 976)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalPriceLable As Label
    Friend WithEvents ComboBox1 As ComboBox

End Class
