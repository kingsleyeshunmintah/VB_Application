<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AdminProfile
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
        AdminTest = New TextBox()
        AdminNameL = New Label()
        password = New TextBox()
        updateProfile = New Button()
        Label2 = New Label()
        NewAdminName = New TextBox()
        NewAdminPwd = New TextBox()
        AddNewAdmin = New Button()
        Label3 = New Label()
        NameToDelete = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(79, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 54)
        Label1.TabIndex = 0
        Label1.Text = "Admin Profile"
        ' 
        ' AdminTest
        ' 
        AdminTest.BorderStyle = BorderStyle.None
        AdminTest.Location = New Point(79, 243)
        AdminTest.Multiline = True
        AdminTest.Name = "AdminTest"
        AdminTest.Size = New Size(386, 67)
        AdminTest.TabIndex = 1
        ' 
        ' AdminNameL
        ' 
        AdminNameL.AutoSize = True
        AdminNameL.ForeColor = SystemColors.ButtonFace
        AdminNameL.Location = New Point(84, 205)
        AdminNameL.Name = "AdminNameL"
        AdminNameL.Size = New Size(91, 25)
        AdminNameL.TabIndex = 2
        AdminNameL.Text = "Username"
        ' 
        ' password
        ' 
        password.BorderStyle = BorderStyle.None
        password.Location = New Point(79, 372)
        password.Multiline = True
        password.Name = "password"
        password.Size = New Size(386, 67)
        password.TabIndex = 1
        ' 
        ' updateProfile
        ' 
        updateProfile.BackColor = Color.SpringGreen
        updateProfile.Font = New Font("Segoe UI", 13F)
        updateProfile.ForeColor = SystemColors.ActiveCaptionText
        updateProfile.Location = New Point(80, 481)
        updateProfile.Name = "updateProfile"
        updateProfile.Size = New Size(385, 76)
        updateProfile.TabIndex = 3
        updateProfile.Text = "Update"
        updateProfile.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(727, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 54)
        Label2.TabIndex = 0
        Label2.Text = "Add New Admin"
        ' 
        ' NewAdminName
        ' 
        NewAdminName.Location = New Point(686, 231)
        NewAdminName.Multiline = True
        NewAdminName.Name = "NewAdminName"
        NewAdminName.Size = New Size(398, 79)
        NewAdminName.TabIndex = 4
        ' 
        ' NewAdminPwd
        ' 
        NewAdminPwd.Location = New Point(686, 360)
        NewAdminPwd.Multiline = True
        NewAdminPwd.Name = "NewAdminPwd"
        NewAdminPwd.Size = New Size(398, 79)
        NewAdminPwd.TabIndex = 4
        ' 
        ' AddNewAdmin
        ' 
        AddNewAdmin.BackColor = Color.DodgerBlue
        AddNewAdmin.ForeColor = SystemColors.ButtonHighlight
        AddNewAdmin.Location = New Point(686, 490)
        AddNewAdmin.Name = "AddNewAdmin"
        AddNewAdmin.Size = New Size(398, 67)
        AddNewAdmin.TabIndex = 5
        AddNewAdmin.Text = "Add Admin"
        AddNewAdmin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(191, 609)
        Label3.Name = "Label3"
        Label3.Size = New Size(292, 54)
        Label3.TabIndex = 0
        Label3.Text = "Remove Admin"
        ' 
        ' NameToDelete
        ' 
        NameToDelete.Location = New Point(191, 752)
        NameToDelete.Multiline = True
        NameToDelete.Name = "NameToDelete"
        NameToDelete.Size = New Size(373, 77)
        NameToDelete.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(642, 752)
        Button1.Name = "Button1"
        Button1.Size = New Size(365, 78)
        Button1.TabIndex = 7
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(191, 696)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 25)
        Label4.TabIndex = 2
        Label4.Text = "Username"
        ' 
        ' UC_AdminProfile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        Controls.Add(Button1)
        Controls.Add(NameToDelete)
        Controls.Add(AddNewAdmin)
        Controls.Add(NewAdminPwd)
        Controls.Add(NewAdminName)
        Controls.Add(updateProfile)
        Controls.Add(Label4)
        Controls.Add(AdminNameL)
        Controls.Add(password)
        Controls.Add(AdminTest)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "UC_AdminProfile"
        Size = New Size(1209, 979)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AdminTest As TextBox
    Friend WithEvents AdminNameL As Label
    Friend WithEvents password As TextBox
    Friend WithEvents updateProfile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents NewAdminName As TextBox
    Friend WithEvents NewAdminPwd As TextBox
    Friend WithEvents AddNewAdmin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NameToDelete As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label

End Class
