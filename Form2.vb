Public Class Dashboard
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(username As String)
        InitializeComponent()
        AdminName.Text = username
    End Sub

    Private Sub AddUserControl(UserControl)

        UserControl.Dock = DockStyle.Fill
        PanelContainer.Controls.Clear()
        PanelContainer.Controls.Add(UserControl)
        UserControl.BringToFront()
    End Sub


    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Dim uc As New UC_Home()
        AddUserControl(uc)

    End Sub

    Private Sub DashBtn_Click(sender As Object, e As EventArgs) Handles DashBtn.Click
        Dim uc As New UC_Home()
        AddUserControl(uc)
    End Sub

    Private Sub ordersBtn_Click(sender As Object, e As EventArgs) Handles ordersBtn.Click
        Dim uc As New UC_Orders()
        AddUserControl(uc)
    End Sub

    Private Sub OrdBtn_Click(sender As Object, e As EventArgs) Handles OrdBtn.Click
        Dim uc As New UC_Orders()
        AddUserControl(uc)
    End Sub

    Private Sub addStockBtn_Click(sender As Object, e As EventArgs) Handles addStockBtn.Click
        Dim uc As New UC_AddStock()
        AddUserControl(uc)
    End Sub

    Private Sub AddStkBtn_Click(sender As Object, e As EventArgs) Handles AddStkBtn.Click
        Dim uc As New UC_AddStock()
        AddUserControl(uc)
    End Sub

    Private Sub analysisBtn_Click(sender As Object, e As EventArgs) Handles analysisBtn.Click
        Dim uc As New UC_Analysis()
        AddUserControl(uc)
    End Sub

    Private Sub AnalysBtn_Click(sender As Object, e As EventArgs) Handles AnalysBtn.Click
        Dim uc As New UC_Analysis()
        AddUserControl(uc)
    End Sub

    Private Sub AdminPBtn_Click(sender As Object, e As EventArgs) Handles AdminPBtn.Click
        Dim uc As New UC_AdminProfile()
        AddUserControl(uc)
    End Sub

    Private Sub ProfileBtn_Click(sender As Object, e As EventArgs) Handles ProfileBtn.Click
        Dim uc As New UC_AdminProfile()
        AddUserControl(uc)

    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub LogBtn_Click(sender As Object, e As EventArgs) Handles LogBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub menuBtn_Click(sender As Object, e As EventArgs) Handles menuBtn.Click

        If Panel1.Width = 390 Then
            Panel1.Width = 110

        Else
            Panel1.Width = 390

        End If

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim uc As New UC_AdminProfile()
        AddUserControl(uc)
    End Sub


End Class