<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminDashboard
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
        Label1 = New Label()
        lblInfo = New Label()
        btnLogout = New Button()
        lblRole = New Label()
        MenuStrip1 = New MenuStrip()
        btnHome = New ToolStripMenuItem()
        btnManageEvent = New ToolStripMenuItem()
        btnViewReports = New ToolStripMenuItem()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Yellow
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(396, 114)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 65)
        Label1.TabIndex = 11
        Label1.Text = "You are Admin"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Location = New Point(561, 495)
        lblInfo.Margin = New Padding(4, 0, 4, 0)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(24, 25)
        lblInfo.TabIndex = 12
        lblInfo.Text = "..."
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Gold
        btnLogout.Location = New Point(981, 660)
        btnLogout.Margin = New Padding(4, 5, 4, 5)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(107, 38)
        btnLogout.TabIndex = 13
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(461, 353)
        lblRole.Margin = New Padding(4, 0, 4, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(231, 48)
        lblRole.TabIndex = 14
        lblRole.Text = "Daftar Event :"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnHome, btnManageEvent, btnViewReports})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(1143, 35)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnHome
        ' 
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(77, 29)
        btnHome.Text = "Home"
        ' 
        ' btnManageEvent
        ' 
        btnManageEvent.Name = "btnManageEvent"
        btnManageEvent.Size = New Size(148, 29)
        btnManageEvent.Text = "Manage Events"
        ' 
        ' btnViewReports
        ' 
        btnViewReports.Name = "btnViewReports"
        btnViewReports.Size = New Size(89, 29)
        btnViewReports.Text = "Reports"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Yellow
        PictureBox2.Image = My.Resources.Resources.Screenshot_2025_05_04_200342_removebg_preview
        PictureBox2.Location = New Point(-34, 404)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(504, 381)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Untitled_design__4_
        PictureBox3.Location = New Point(526, 215)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(86, 91)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' FormAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(1143, 750)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(lblRole)
        Controls.Add(btnLogout)
        Controls.Add(lblInfo)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormAdminDashboard"
        Text = "Admin Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnHome As ToolStripMenuItem
    Friend WithEvents btnViewReports As ToolStripMenuItem
    Friend WithEvents btnManageEvent As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
