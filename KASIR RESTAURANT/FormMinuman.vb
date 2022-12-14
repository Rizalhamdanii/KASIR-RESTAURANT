Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class FormMinuman
    Sub Tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblminuman", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblminuman")
        DgMinuman.DataSource = Ds.Tables("tblminuman")
        DgMinuman.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        BtnInput.Text = "INPUT"
        BtnInput.Enabled = True
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.Enabled = True
        BtnDelete.Text = "DELETE"
        BtnDelete.Enabled = True
        BtnLogOut.Text = "LOG OUT"

        TxtKode.Enabled = False
        TxtNamaMinuman.Enabled = False
        TxtHarga.Enabled = False
        TxtJenis.Enabled = False

        TxtKode.Text = ""
        TxtNamaMinuman.Text = ""
        TxtJenis.Text = ""
        TxtHarga.Text = ""

    End Sub
    Sub Isi()
        TxtKode.Enabled = True
        TxtNamaMinuman.Enabled = True
        TxtJenis.Enabled = True
        TxtHarga.Enabled = True
    End Sub
    Private Sub FormMinuman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilkan()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        If BtnLogOut.Text = "LOG OUT" Then
            Me.Close()
        Else
            Call Tampilkan()
        End If
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
            If TxtKode.Text = "" Or TxtNamaMinuman.Text = "" Or TxtJenis.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim minuman = New Minuman With {
                .kode_minuman = TxtKode.Text,
                .nama_minuman = TxtNamaMinuman.Text,
                .jenis_minuman = TxtJenis.Text,
                .harga_minuman = TxtHarga.Text
                }
                Dim Simpan = minuman.save()
                If (Simpan) Then
                    MsgBox("Data Berhasil Di simpan !!!")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub
    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Minuman.Cari(TxtKode.Text)
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
            Else
                TxtNamaMinuman.Text = hasil.nama_minuman
                TxtJenis.Text = hasil.jenis_minuman
                TxtHarga.Text = hasil.harga_minuman

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
            If TxtKode.Text = "" Or TxtNamaMinuman.Text = "" Or TxtJenis.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim minuman = New Minuman With {
            .kode_minuman = TxtKode.Text,
            .nama_minuman = TxtNamaMinuman.Text,
            .jenis_minuman = TxtJenis.Text,
            .harga_minuman = TxtHarga.Text
            }
                Dim ubah = minuman.Ubah()
                If (ubah) Then
                    MsgBox("Data Berhasil Di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")

                End If
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
            If TxtKode.Text = "" Or TxtNamaMinuman.Text = "" Or TxtJenis.Text = "" Or TxtHarga.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim minuman = New Minuman With {
                .kode_minuman = TxtKode.Text
                }
                Dim hapus = minuman.Hapus()
                If (hapus) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
            End If
    End Sub
End Class