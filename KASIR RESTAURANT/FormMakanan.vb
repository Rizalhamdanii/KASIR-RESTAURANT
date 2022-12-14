Imports MySql.Data.MySqlClient
Public Class FormMakanan
    Sub Tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblmakanan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblmakanan")
        DgMakanan.DataSource = Ds.Tables("tblmakanan")
        DgMakanan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        BtnInput.Text = "INPUT"
        BtnInput.Enabled = True
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.Enabled = True
        BtnDelete.Text = "DELETE"
        BtnDelete.Enabled = True
        BtnLogOut.Text = "LOG OUT"

        TxtKode.Enabled = False
        TxtNamaMakanan.Enabled = False
        TxtHarga.Enabled = False
        TxtJenis.Enabled = False

        TxtKode.Text = ""
        TxtNamaMakanan.Text = ""
        TxtJenis.Text = ""
        TxtHarga.Text = ""

    End Sub
    Sub Isi()
        TxtKode.Enabled = True
        TxtNamaMakanan.Enabled = True
        TxtJenis.Enabled = True
        TxtHarga.Enabled = True
    End Sub

    Private Sub FormMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilkan()
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If BtnInput.Text = "INPUT" Then
            BtnInput.Text = "SIMPAN"
            BtnUpdate.Enabled = False
            BtnDelete.Enabled = False
            BtnLogOut.Text = "&CANCEL"
            Call Isi()
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtNamaMakanan.Text = "" Or TxtJenis.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim makanan = New Makanan With {
                    .kode_makanan = TxtKode.Text,
                    .nama_makanan = TxtNamaMakanan.Text,
                    .jenis_makanan = TxtJenis.Text,
                    .harga_makanan = TxtHarga.Text
                }
                Dim simpan = makanan.Save()
                If (simpan) Then
                    MsgBox("Data Berhasil di Simpan !!!")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If

            End If
            End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If BtnUpdate.Text = "UPDATE" Then
            BtnUpdate.Text = "UBAH"
            BtnInput.Enabled = False
            BtnDelete.Enabled = False
            BtnLogOut.Text = "&CANCEL"
            Call Isi()
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtNamaMakanan.Text = "" Or TxtJenis.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim makanan = New Makanan With {
                .kode_makanan = TxtKode.Text,
                .nama_makanan = TxtNamaMakanan.Text,
                .jenis_makanan = TxtJenis.Text,
                .harga_makanan = TxtHarga.Text
                }
                Dim ubah = makanan.Ubah()
                If (ubah) Then
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Makanan.Cari(TxtKode.Text)
            If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
                TxtNamaMakanan.Text = hasil.nama_makanan
                TxtJenis.Text = hasil.jenis_makanan
                TxtHarga.Text = hasil.harga_makanan
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If BtnDelete.Text = "DELETE" Then
            BtnDelete.Text = "HAPUS"
            BtnInput.Enabled = False
            BtnUpdate.Enabled = False
            BtnLogOut.Text = "&CANCEL"
            Call Isi()
            TxtKode.Focus()
        Else
            If TxtKode.Text = "" Or TxtNamaMakanan.Text = "" Or TxtJenis.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim makanan = New Makanan With {
                .kode_makanan = TxtKode.Text
                }
                Dim hapus = makanan.Hapus()
                If (hapus) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        If BtnLogOut.Text = "LOG OUT" Then
            Me.Close()
        Else
            Call Tampilkan()
        End If
    End Sub
End Class