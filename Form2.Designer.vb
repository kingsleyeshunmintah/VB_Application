<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        SplitContainer1 = New SplitContainer()
        Panel1 = New Panel()
        AdminName = New Label()
        AnalysBtn = New PictureBox()
        OrdBtn = New PictureBox()
        AdminPBtn = New PictureBox()
        DashBtn = New PictureBox()
        AddStkBtn = New PictureBox()
        LogBtn = New PictureBox()
        PictureBox1 = New PictureBox()
        LogoutBtn = New Label()
        ProfileBtn = New Label()
        analysisBtn = New Label()
        addStockBtn = New Label()
        ordersBtn = New Label()
        dashboardBtn = New Label()
        PanelContainer = New Panel()
        UC_AdminProfile1 = New UC_AdminProfile()
        Panel2 = New Panel()
        Label2 = New Label()
        menuBtn = New PictureBox()
        Label1 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(AnalysBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(OrdBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(AdminPBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(DashBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(AddStkBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(LogBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelContainer.SuspendLayout()
        Panel2.SuspendLayout()
        CType(menuBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(PanelContainer)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(1592, 1019)
        SplitContainer1.SplitterDistance = 390
        SplitContainer1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(AdminName)
        Panel1.Controls.Add(AnalysBtn)
        Panel1.Controls.Add(OrdBtn)
        Panel1.Controls.Add(AdminPBtn)
        Panel1.Controls.Add(DashBtn)
        Panel1.Controls.Add(AddStkBtn)
        Panel1.Controls.Add(LogBtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(ProfileBtn)
        Panel1.Controls.Add(analysisBtn)
        Panel1.Controls.Add(addStockBtn)
        Panel1.Controls.Add(ordersBtn)
        Panel1.Controls.Add(dashboardBtn)
        Panel1.Location = New Point(-6, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(390, 1019)
        Panel1.TabIndex = 0
        ' 
        ' AdminName
        ' 
        AdminName.AutoSize = True
        AdminName.ForeColor = SystemColors.ButtonHighlight
        AdminName.Location = New Point(147, 174)
        AdminName.Name = "AdminName"
        AdminName.Size = New Size(129, 25)
        AdminName.TabIndex = 9
        AdminName.Text = "Eshun Kingsley"
        ' 
        ' AnalysBtn
        ' 
        AnalysBtn.Image = CType(resources.GetObject("AnalysBtn.Image"), Image)
        AnalysBtn.Location = New Point(50, 555)
        AnalysBtn.Name = "AnalysBtn"
        AnalysBtn.Size = New Size(59, 54)
        AnalysBtn.SizeMode = PictureBoxSizeMode.StretchImage
        AnalysBtn.TabIndex = 8
        AnalysBtn.TabStop = False
        ' 
        ' OrdBtn
        ' 
        OrdBtn.Image = CType(resources.GetObject("OrdBtn.Image"), Image)
        OrdBtn.Location = New Point(48, 377)
        OrdBtn.Name = "OrdBtn"
        OrdBtn.Size = New Size(51, 53)
        OrdBtn.SizeMode = PictureBoxSizeMode.StretchImage
        OrdBtn.TabIndex = 7
        OrdBtn.TabStop = False
        ' 
        ' AdminPBtn
        ' 
        AdminPBtn.Image = CType(resources.GetObject("AdminPBtn.Image"), Image)
        AdminPBtn.Location = New Point(50, 650)
        AdminPBtn.Name = "AdminPBtn"
        AdminPBtn.Size = New Size(59, 62)
        AdminPBtn.SizeMode = PictureBoxSizeMode.StretchImage
        AdminPBtn.TabIndex = 6
        AdminPBtn.TabStop = False
        ' 
        ' DashBtn
        ' 
        DashBtn.Image = CType(resources.GetObject("DashBtn.Image"), Image)
        DashBtn.Location = New Point(50, 263)
        DashBtn.Name = "DashBtn"
        DashBtn.Size = New Size(45, 55)
        DashBtn.SizeMode = PictureBoxSizeMode.StretchImage
        DashBtn.TabIndex = 5
        DashBtn.TabStop = False
        ' 
        ' AddStkBtn
        ' 
        AddStkBtn.Image = CType(resources.GetObject("AddStkBtn.Image"), Image)
        AddStkBtn.Location = New Point(51, 467)
        AddStkBtn.Name = "AddStkBtn"
        AddStkBtn.Size = New Size(48, 48)
        AddStkBtn.SizeMode = PictureBoxSizeMode.StretchImage
        AddStkBtn.TabIndex = 4
        AddStkBtn.TabStop = False
        ' 
        ' LogBtn
        ' 
        LogBtn.Image = CType(resources.GetObject("LogBtn.Image"), Image)
        LogBtn.Location = New Point(50, 902)
        LogBtn.Name = "LogBtn"
        LogBtn.Size = New Size(44, 52)
        LogBtn.SizeMode = PictureBoxSizeMode.StretchImage
        LogBtn.TabIndex = 3
        LogBtn.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(156, 64)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(106, 89)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.AutoSize = True
        LogoutBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoutBtn.ForeColor = SystemColors.ButtonFace
        LogoutBtn.Location = New Point(135, 912)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(109, 32)
        LogoutBtn.TabIndex = 1
        LogoutBtn.Text = "LOGOUT"
        ' 
        ' ProfileBtn
        ' 
        ProfileBtn.AutoSize = True
        ProfileBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfileBtn.ForeColor = SystemColors.ButtonFace
        ProfileBtn.Location = New Point(135, 668)
        ProfileBtn.Name = "ProfileBtn"
        ProfileBtn.Size = New Size(200, 32)
        ProfileBtn.TabIndex = 1
        ProfileBtn.Text = "ADMIN PROFILE"
        ' 
        ' analysisBtn
        ' 
        analysisBtn.AutoSize = True
        analysisBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        analysisBtn.ForeColor = SystemColors.ButtonFace
        analysisBtn.Location = New Point(135, 566)
        analysisBtn.Name = "analysisBtn"
        analysisBtn.Size = New Size(148, 32)
        analysisBtn.TabIndex = 1
        analysisBtn.Text = "System Info"
        ' 
        ' addStockBtn
        ' 
        addStockBtn.AutoSize = True
        addStockBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addStockBtn.ForeColor = SystemColors.ButtonFace
        addStockBtn.Location = New Point(135, 470)
        addStockBtn.Name = "addStockBtn"
        addStockBtn.Size = New Size(149, 32)
        addStockBtn.TabIndex = 1
        addStockBtn.Text = "ADD STOCK"
        ' 
        ' ordersBtn
        ' 
        ordersBtn.AutoSize = True
        ordersBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ordersBtn.ForeColor = SystemColors.ButtonFace
        ordersBtn.Location = New Point(135, 382)
        ordersBtn.Name = "ordersBtn"
        ordersBtn.Size = New Size(169, 32)
        ordersBtn.TabIndex = 1
        ordersBtn.Text = "PURCHASING"
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.AutoSize = True
        dashboardBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardBtn.ForeColor = SystemColors.ButtonFace
        dashboardBtn.Location = New Point(135, 273)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(164, 32)
        dashboardBtn.TabIndex = 1
        dashboardBtn.Text = "DASHBOARD"
        ' 
        ' PanelContainer
        ' 
        PanelContainer.Controls.Add(UC_AdminProfile1)
        PanelContainer.Location = New Point(3, 103)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(1200, 913)
        PanelContainer.TabIndex = 1
        ' 
        ' UC_AdminProfile1
        ' 
        UC_AdminProfile1.BackColor = Color.DarkSlateGray
        UC_AdminProfile1.Location = New Point(3, 0)
        UC_AdminProfile1.Name = "UC_AdminProfile1"
        UC_AdminProfile1.Size = New Size(1180, 904)
        UC_AdminProfile1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.AppWorkspace
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(menuBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(-4, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1199, 97)
        Panel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.OrangeRed
        Label2.Location = New Point(211, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 41)
        Label2.TabIndex = 0
        Label2.Text = "Stock"
        ' 
        ' menuBtn
        ' 
        menuBtn.Image = CType(resources.GetObject("menuBtn.Image"), Image)
        menuBtn.Location = New Point(28, 25)
        menuBtn.Name = "menuBtn"
        menuBtn.Size = New Size(45, 55)
        menuBtn.SizeMode = PictureBoxSizeMode.StretchImage
        menuBtn.TabIndex = 5
        menuBtn.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 15F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(118, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 41)
        Label1.TabIndex = 0
        Label1.Text = "Mega"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1592, 1019)
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mega Stock"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(AnalysBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(OrdBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(AdminPBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(DashBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(AddStkBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(LogBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelContainer.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(menuBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dashboardBtn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ordersBtn As Label
    Friend WithEvents ProfileBtn As Label
    Friend WithEvents analysisBtn As Label
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents addStockBtn As Label
    Friend WithEvents LogBtn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents menuBtn As PictureBox
    Friend WithEvents AddStkBtn As PictureBox
    Friend WithEvents AdminPBtn As PictureBox
    Friend WithEvents OrdBtn As PictureBox
    Friend WithEvents DashBtn As PictureBox
    Friend WithEvents AdminName As Label
    Friend WithEvents AnalysBtn As PictureBox
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents UC_AdminProfile1 As UC_AdminProfile
End Class
