Imports MySql.Data.MySqlClient
Public Class FormPetugas
    Sub Tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblpetugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpetugas")
        dgvpetugas.DataSource = Ds.Tables("tblpetugas")
        dgvpetugas.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        btninput.Text = "INPUT"
        btninput.Enabled = True
        btnupdate.Text = "UPDATE"
        btnupdate.Enabled = True
        btndelete.Text = "DELETE"
        btndelete.Enabled = True
        btnlogout.Text = "LOG OUT"

        txtkode.Enabled = False
        txtuser.Enabled = False
        txtpass.Enabled = False
        txtalamat.Enabled = False
        txtnohp.Enabled = False

        txtkode.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtalamat.Text = ""
        txtnohp.Text = ""

    End Sub
    Sub Isi()
        txtkode.Enabled = True
        txtuser.Enabled = True
        txtpass.Enabled = True
        txtalamat.Enabled = True
        txtnohp.Enabled = True

    End Sub

    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilkan()
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If btninput.Text = "INPUT" Then
            btninput.Text = "SIMPAN"
            btnupdate.Enabled = False
            btndelete.Enabled = False
            btnlogout.Text = "&CANCEL"
            Call Isi()
            txtkode.Focus()

        Else
            If txtkode.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or txtalamat.Text = "" Or txtnohp.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else

                Dim petugas = New Petugas With {
                    .kode_petugas = txtkode.Text,
                    .nama_petugas = txtuser.Text,
                    .Password_Petugas = txtpass.Text,
                    .alamat_petugas = txtalamat.Text,
                    .telpon = txtnohp.Text
                }
                Dim Simpan = petugas.Save()
                If (Simpan) Then
                    MsgBox("Data Berhasil di Simpan !!!")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "UPDATE" Then
            btnupdate.Text = "UBAH"
            btninput.Enabled = False
            btndelete.Enabled = False
            btnlogout.Text = "&CANCEL"
            Call Isi()
            txtkode.Focus()
        Else
            If txtkode.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or txtalamat.Text = "" Or txtnohp.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim petugas = New Petugas With {
                    .kode_petugas = txtkode.Text,
                    .nama_petugas = txtuser.Text,
                    .Password_Petugas = txtpass.Text,
                    .alamat_petugas = txtalamat.Text,
                    .telpon = txtnohp.Text
                }
                Dim update = petugas.Update()
                If (update) Then
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Petugas.Cari(txtkode.Text)
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
            Else
                txtuser.Text = hasil.nama_petugas
                txtpass.Text = hasil.Password_Petugas
                txtalamat.Text = hasil.alamat_petugas
                txtnohp.Text = hasil.telpon
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If btndelete.Text = "DELETE" Then
            btndelete.Text = "HAPUS"
            btninput.Enabled = False
            btnupdate.Enabled = False
            btnlogout.Text = "&CANCEL"
            Call Isi()
            txtkode.Focus()
        Else
            If txtkode.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or txtalamat.Text = "" Or txtnohp.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Dim petugas = New Petugas With {
                    .kode_petugas = txtkode.Text
                }
                Dim delete = petugas.Delete
                If (delete) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If

            End If
        End If
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If btnlogout.Text = "LOG OUT" Then
            Me.Close()
        Else
            Call Tampilkan()
        End If
    End Sub
End Class