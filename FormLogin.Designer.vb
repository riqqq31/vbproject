<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        lblUser = New Label()
        lblPass = New Label()
        lblRole = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbRole = New ComboBox()
        lblInfo = New Label()
        btnLogin = New Button()
        Label1 = New Label()
        btnCancel = New Button()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 14.25F)
        lblUser.Location = New Point(273, 209)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(106, 25)
        lblUser.TabIndex = 0
        lblUser.Text = "Username :"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI", 14.25F)
        lblPass.Location = New Point(273, 259)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(100, 25)
        lblPass.TabIndex = 1
        lblPass.Text = "Password :"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 14.25F)
        lblRole.Location = New Point(273, 312)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(48, 25)
        lblRole.TabIndex = 2
        lblRole.Text = "Role"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Khaki
        txtUsername.Font = New Font("Segoe UI", 14.25F)
        txtUsername.Location = New Point(407, 209)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(140, 33)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Khaki
        txtPassword.Font = New Font("Segoe UI", 14.25F)
        txtPassword.Location = New Point(407, 259)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(140, 33)
        txtPassword.TabIndex = 2
        ' 
        ' cmbRole
        ' 
        cmbRole.BackColor = Color.Khaki
        cmbRole.Font = New Font("Segoe UI", 14.25F)
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(407, 309)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(140, 33)
        cmbRole.TabIndex = 3
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(280, 341)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(24, 25)
        lblInfo.TabIndex = 6
        lblInfo.Text = "..."
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Khaki
        btnLogin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(291, 391)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(95, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Sign in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(185, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(424, 45)
        Label1.TabIndex = 0
        Label1.Text = "Event Management System"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gold
        btnCancel.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(423, 391)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(95, 35)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(601, 427)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 15)
        Label2.TabIndex = 10
        Label2.Text = "Copyright © 2025 Kelompok 9"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Untitled_design__2_1
        PictureBox3.Location = New Point(343, 74)
        PictureBox3.Margin = New Padding(2, 2, 2, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(135, 115)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Untitled_design__3_1
        PictureBox1.Location = New Point(232, 259)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Untitled_design__2_1
        PictureBox2.Location = New Point(232, 209)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(Label2)
        Controls.Add(btnCancel)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(lblInfo)
        Controls.Add(cmbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblRole)
        Controls.Add(lblPass)
        Controls.Add(lblUser)
        Name = "FormLogin"
        Text = "Login"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
