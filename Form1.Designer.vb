<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        username = New TextBox()
        PictureBox1 = New PictureBox()
        password = New TextBox()
        Submit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Nexa Heavy", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.AliceBlue
        Label1.Location = New Point(180, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(318, 52)
        Label1.TabIndex = 0
        Label1.Text = "MEGA STOCKS"
        ' 
        ' username
        ' 
        username.Location = New Point(106, 287)
        username.Multiline = True
        username.Name = "username"
        username.Size = New Size(450, 63)
        username.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(106, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(450, 152)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' password
        ' 
        password.Location = New Point(106, 398)
        password.Multiline = True
        password.Name = "password"
        password.Size = New Size(450, 63)
        password.TabIndex = 2
        ' 
        ' Submit
        ' 
        Submit.BackColor = Color.DarkGreen
        Submit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Submit.ForeColor = SystemColors.Control
        Submit.Location = New Point(111, 495)
        Submit.Name = "Submit"
        Submit.Size = New Size(205, 62)
        Submit.TabIndex = 3
        Submit.Text = "Login"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(106, 367)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(106, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 4
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(424, 513)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 28)
        Label4.TabIndex = 4
        Label4.Text = "Cancel"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ControlText
        ClientSize = New Size(675, 624)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Submit)
        Controls.Add(PictureBox1)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mega Stocks : Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents password As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
