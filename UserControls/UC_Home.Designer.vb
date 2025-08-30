<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Home
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
        Panel1 = New Panel()
        TCustomer = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Tproduct = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Tincome = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(64, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 54)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.Controls.Add(TCustomer)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(73, 125)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(388, 200)
        Panel1.TabIndex = 1
        ' 
        ' TCustomer
        ' 
        TCustomer.AutoSize = True
        TCustomer.Font = New Font("Segoe UI", 20F)
        TCustomer.Location = New Point(162, 112)
        TCustomer.Name = "TCustomer"
        TCustomer.Size = New Size(45, 54)
        TCustomer.TabIndex = 1
        TCustomer.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(76, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(231, 41)
        Label2.TabIndex = 0
        Label2.Text = "Total Customers"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.BurlyWood
        Panel2.Controls.Add(Tproduct)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(488, 125)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(269, 200)
        Panel2.TabIndex = 1
        ' 
        ' Tproduct
        ' 
        Tproduct.AutoSize = True
        Tproduct.Font = New Font("Segoe UI", 20F)
        Tproduct.Location = New Point(113, 112)
        Tproduct.Name = "Tproduct"
        Tproduct.Size = New Size(45, 54)
        Tproduct.TabIndex = 1
        Tproduct.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(26, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 41)
        Label3.TabIndex = 0
        Label3.Text = "Total Products"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkOrange
        Panel3.Controls.Add(Tincome)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(785, 125)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(388, 200)
        Panel3.TabIndex = 1
        ' 
        ' Tincome
        ' 
        Tincome.AutoSize = True
        Tincome.Font = New Font("Segoe UI", 20F)
        Tincome.Location = New Point(55, 124)
        Tincome.Name = "Tincome"
        Tincome.Size = New Size(45, 54)
        Tincome.TabIndex = 1
        Tincome.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(110, 46)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 41)
        Label4.TabIndex = 0
        Label4.Text = "Total Income"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(73, 407)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(881, 407)
        DataGridView1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.Location = New Point(73, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 54)
        Label5.TabIndex = 0
        Label5.Text = "Orders"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOrange
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.Location = New Point(73, 830)
        Button1.Name = "Button1"
        Button1.Size = New Size(245, 73)
        Button1.TabIndex = 3
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' UC_Home
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Name = "UC_Home"
        Size = New Size(1210, 986)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TCustomer As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tproduct As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Tincome As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button

End Class
