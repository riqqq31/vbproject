Public Class FormManageEvents
    Dim dtEvent As New DataTable
    Dim eventIDs() As String = dtEvent.AsEnumerable().Select(Function(row) row("ID Event").ToString()).ToArray()


    Private Sub FormManageEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup tabel
        dtEvent.Columns.Add("ID Event")
        dtEvent.Columns.Add("Nama Event")
        dtEvent.Columns.Add("Tanggal")
        dtEvent.Columns.Add("Harga")

        dgvEvent.DataSource = dtEvent
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim harga As Decimal
        Dim idEvent As Integer

        ' Validasi ID hanya berupa angka
        If Not Integer.TryParse(txtID.Text, idEvent) Then
            MessageBox.Show("ID Event harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi Nama Event tidak boleh kosong
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama Event tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi harga harus angka
        If Decimal.TryParse(txtHarga.Text, harga) AndAlso Not IsEventIDExists(txtID.Text) Then
            dtEvent.Rows.Add(idEvent.ToString(), txtNama.Text, dtpTanggal.Value.ToShortDateString(), String.Format("Rp {0:N}", harga))
            MessageBox.Show("Event telah berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanInput()
        Else
            MessageBox.Show("Pastikan harga berupa angka dan ID Event unik!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim harga As Decimal
        Dim idEvent As Integer
        Dim cleanedHarga As String = txtHarga.Text.Replace("Rp", "").Trim()

        ' Validasi ID harus angka
        If Not Integer.TryParse(txtID.Text, idEvent) Then
            MessageBox.Show("ID Event harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi Nama Event tidak boleh kosong
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama Event tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi harga harus angka
        If Decimal.TryParse(cleanedHarga, harga) AndAlso dgvEvent.CurrentRow IsNot Nothing Then
            dgvEvent.CurrentRow.Cells(0).Value = idEvent.ToString()
            dgvEvent.CurrentRow.Cells(1).Value = txtNama.Text
            dgvEvent.CurrentRow.Cells(2).Value = dtpTanggal.Value.ToShortDateString()
            dgvEvent.CurrentRow.Cells(3).Value = String.Format("Rp {0:N}", harga)
            MessageBox.Show("Event telah berhasil diedit!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanInput()
        Else
            MessageBox.Show("Pastikan harga berupa angka valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvEvent.CurrentRow IsNot Nothing Then
            dgvEvent.Rows.Remove(dgvEvent.CurrentRow)
            MessageBox.Show("Event telah berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanInput()
        Else
            MessageBox.Show("Pilih event yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvEvent_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEvent.SelectionChanged
        If dgvEvent.CurrentRow IsNot Nothing AndAlso dgvEvent.CurrentRow.Index >= 0 Then
            txtID.Text = dgvEvent.CurrentRow.Cells(0).Value.ToString()
            txtNama.Text = dgvEvent.CurrentRow.Cells(1).Value.ToString()

            ' Validasi apakah tanggal tidak kosong
            If dgvEvent.CurrentRow.Cells(2).Value IsNot DBNull.Value Then
                dtpTanggal.Value = Convert.ToDateTime(dgvEvent.CurrentRow.Cells(2).Value)
            Else
                dtpTanggal.Value = DateTime.Now
            End If

            ' Format harga ke dalam satuan Rupiah
            txtHarga.Text = dgvEvent.CurrentRow.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        FormAdminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BersihkanInput()
        txtID.Clear()
        txtNama.Clear()
        txtHarga.Clear()
        dtpTanggal.Value = DateTime.Now
    End Sub

    Private Function IsEventIDExists(id As String) As Boolean
        For Each row As DataRow In dtEvent.Rows
            If row("ID Event").ToString() = id Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
