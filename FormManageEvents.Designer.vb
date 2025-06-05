<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManageEvents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dgvEvent = New DataGridView()
        dtpTanggal = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        btnkembali = New Button()
        PictureBox1 = New PictureBox()
        CType(dgvEvent, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 87)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "ID Event"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 168)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama Event"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 248)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 342)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 3
        Label4.Text = "Harga"
        ' 
        ' dgvEvent
        ' 
        dgvEvent.BackgroundColor = Color.Khaki
        dgvEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEvent.Location = New Point(581, 73)
        dgvEvent.Margin = New Padding(4, 5, 4, 5)
        dgvEvent.Name = "dgvEvent"
        dgvEvent.RowHeadersWidth = 62
        dgvEvent.Size = New Size(457, 392)
        dgvEvent.TabIndex = 4
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(150, 248)
        dtpTanggal.Margin = New Padding(4, 5, 4, 5)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(284, 31)
        dtpTanggal.TabIndex = 5
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.Khaki
        txtID.Location = New Point(231, 73)
        txtID.Margin = New Padding(4, 5, 4, 5)
        txtID.Name = "txtID"
        txtID.Size = New Size(141, 31)
        txtID.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Khaki
        txtNama.Location = New Point(231, 155)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(141, 31)
        txtNama.TabIndex = 7
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.Khaki
        txtHarga.Location = New Point(231, 342)
        txtHarga.Margin = New Padding(4, 5, 4, 5)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(141, 31)
        txtHarga.TabIndex = 8
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Khaki
        btnTambah.Location = New Point(362, 506)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(107, 38)
        btnTambah.TabIndex = 9
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Khaki
        btnEdit.Location = New Point(536, 506)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(107, 38)
        btnEdit.TabIndex = 10
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Khaki
        btnHapus.Location = New Point(705, 506)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(107, 38)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnkembali
        ' 
        btnkembali.BackColor = Color.Gold
        btnkembali.Location = New Point(1023, 14)
        btnkembali.Margin = New Padding(4, 5, 4, 5)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(107, 38)
        btnkembali.TabIndex = 12
        btnkembali.Text = "Back"
        btnkembali.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2025_05_04_201311_removebg_preview
        PictureBox1.Location = New Point(-133, 571)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1440, 281)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' FormManageEvents
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(1143, 750)
        Controls.Add(PictureBox1)
        Controls.Add(btnkembali)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(txtHarga)
        Controls.Add(txtNama)
        Controls.Add(txtID)
        Controls.Add(dtpTanggal)
        Controls.Add(dgvEvent)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormManageEvents"
        Text = "FormManageEvents"
        CType(dgvEvent, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvEvent As DataGridView
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnkembali As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class