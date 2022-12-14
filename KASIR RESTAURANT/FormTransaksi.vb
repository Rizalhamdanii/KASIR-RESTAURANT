Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Runtime.InteropServices
Imports Mysqlx.XDevAPI.Relational

Public Class FormTransaksi
    Sub BuatKolom()
        Call Kosong()
        Call NoOtomatis()
        DgMakanan.Columns.Clear()
        DgMakanan.Columns.Add("jmlh", "Jumlah")
        DgMakanan.Columns.Add("no", "No Transaksi")
        DgMakanan.Columns.Add("kode", "Kode Makanan")
        DgMakanan.Columns.Add("nama", "Nama Makanan")
        DgMakanan.Columns.Add("total", "Total Harga")

        DgMinuman.Columns.Clear()
        DgMinuman.Columns.Add("jmlh", "Jumlah")
        DgMinuman.Columns.Add("no", "No Transaksi")
        DgMinuman.Columns.Add("kode", "Kode Minuman")
        DgMinuman.Columns.Add("nama", "Nama Minuman")
        DgMinuman.Columns.Add("total", "Total Harga")

        LblKodePetugas.Text = FormLogin.TxtKode.Text

        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tbltransaksi", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbltransaksi")
        DgTransaksi.DataSource = Ds.Tables("tbltransaksi")

    End Sub
    Sub Kosong()
        cbcustomer.Text = ""
        LblNama.Text = ""
        LblAlamat.Text = ""
        LblKodeMakanan.Text = ""
        cbMakanan.Text = ""
        LblJenisMakanan.Text = ""
        LblHargaMakanan.Text = ""
        TxtJmlhMakan.Text = ""
        TxtTotMakan.Text = ""
        LblKodeMinuman.Text = ""
        CbMinuman.Text = ""
        LblJenisMinuman.Text = ""
        LblHargaMinuman.Text = ""
        TxtJmlhMinum.Text = ""
        TxtTotMinum.Text = ""
        TxtSubTotMakan.Text = ""
        TxtSubTotMinum.Text = ""
        TxtTotalbayar.Text = ""
        TxtBayar.Text = ""
        TxtKembalian.Text = ""
    End Sub
    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select no_transaksi from tbltransaksi order by no_transaksi desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            txtno.Text = "TR" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("no_transaksi"), 3, 6) = Format(Today, "yyMMdd") Then
                txtno.Text = "TR" + Format(Microsoft.VisualBasic.Right(Rd.Item("no_transaksi"), 8) + 1, "00")
            Else
                txtno.Text = "TR" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BuatKolom()
        Call MunculKodeCustomer()
        Call MunculNamaMakanan()
        Call MunculNamaMinuman()
        lbltanggal.Text = Today
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
    Sub MunculKodeCustomer()
        Call OpenConn()
        cbcustomer.Items.Clear()
        Cmd = New MySqlCommand("select * from tblcustoumer", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cbcustomer.Items.Add(Rd.Item(0))
        Loop
    End Sub
    Sub MunculNamaMakanan()
        Call OpenConn()
        cbMakanan.Items.Clear()
        Cmd = New MySqlCommand("select * from tblmakanan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cbMakanan.Items.Add(Rd.Item(1))
        Loop
    End Sub
    Sub MunculNamaMinuman()
        Call OpenConn()
        CbMinuman.Items.Clear()
        Cmd = New MySqlCommand("select * from tblminuman", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            CbMinuman.Items.Add(Rd.Item(1))
        Loop
    End Sub

    Private Sub cbcustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcustomer.SelectedIndexChanged
        Call OpenConn()
        Dim hasil = Customer.Select_KdCustomer(cbcustomer.Text)
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            LblNama.Text = hasil.nama_customer
            LblAlamat.Text = hasil.alamat_customer
        End If
    End Sub

    Private Sub cbMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMakanan.SelectedIndexChanged
        Dim hasil = Makanan.Select_KdMakanan(cbMakanan.Text)
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            LblKodeMakanan.Text = hasil.kode_makanan
            cbMakanan.Text = hasil.nama_makanan
            LblJenisMakanan.Text = hasil.jenis_makanan
            LblHargaMakanan.Text = hasil.harga_makanan
        End If
        TxtJmlhMakan.Focus()
    End Sub

    Private Sub TxtJmlhMakan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJmlhMakan.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTotMakan.Text = Val(TxtJmlhMakan.Text) * Val(LblHargaMakanan.Text)
            TxtTotMakan.Text = TxtTotMakan.Text
        End If
    End Sub

    Private Sub CbMinuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMinuman.SelectedIndexChanged
        Dim hasil = Minuman.Select_KdMinuman(CbMinuman.Text)
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            LblKodeMinuman.Text = hasil.kode_minuman
            CbMinuman.Text = hasil.nama_minuman
            LblJenisMinuman.Text = hasil.jenis_minuman
            LblHargaMinuman.Text = hasil.harga_minuman
            TxtJmlhMinum.Focus()
        End If
    End Sub

    Private Sub TxtJmlhMinum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJmlhMinum.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTotMinum.Text = Val(TxtJmlhMinum.Text) * Val(LblHargaMinuman.Text)
            TxtTotMinum.Text = TxtTotMinum.Text
        End If
    End Sub

    Private Sub BtnInputMakan_Click(sender As Object, e As EventArgs) Handles BtnInputMakan.Click
        DgMakanan.Rows.Add(New String() {TxtJmlhMakan.Text, txtno.Text, LblKodeMakanan.Text, cbMakanan.Text, TxtTotMakan.Text})
        LblKodeMakanan.Text = ""
        cbMakanan.Text = ""
        LblJenisMakanan.Text = ""
        LblHargaMakanan.Text = ""
        TxtJmlhMakan.Text = ""
        TxtTotMakan.Text = ""
        Dim sum As Decimal = 0
        For i = 0 To DgMakanan.Rows.Count - 1
            sum += DgMakanan.Rows(i).Cells(4).Value
        Next
        TxtSubTotMakan.Text = sum

        TxtTotalbayar.Text = Val(TxtSubTotMakan.Text) + Val(TxtSubTotMinum.Text)
        TxtTotalbayar.Text = TxtTotalbayar.Text



    End Sub

    Private Sub BtnInputMinum_Click(sender As Object, e As EventArgs) Handles BtnInputMinum.Click


        DgMinuman.Rows.Add(New String() {TxtJmlhMinum.Text, txtno.Text, LblKodeMinuman.Text, CbMinuman.Text, TxtTotMinum.Text})

        LblKodeMinuman.Text = ""
        CbMinuman.Text = ""
        LblJenisMinuman.Text = ""
        LblHargaMinuman.Text = ""
        TxtJmlhMinum.Text = ""
        TxtTotMinum.Text = ""
        Dim sum As Decimal = 0
        For i = 0 To DgMinuman.Rows.Count - 1
            sum += DgMinuman.Rows(i).Cells(4).Value
        Next
        TxtSubTotMinum.Text = sum

        TxtTotalbayar.Text = Val(TxtSubTotMakan.Text) + Val(TxtSubTotMinum.Text)
        TxtTotalbayar.Text = TxtTotalbayar.Text




    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If cbcustomer.Text = "" Then
            MsgBox("Pastikan Semua Filed Terisi")
        Else
            Try
                Call OpenConn()
                Dim transaksi = New Transaksi_All()
                transaksi.no_transaksi = txtno.Text
                transaksi.tgl_transaksi = Format(DtpTgl.Value, "yyyy-MM-dd")
                transaksi.kode_custumer = cbcustomer.Text
                transaksi.kode_petugas = LblKodePetugas.Text
                transaksi.subtotal_makanan = TxtSubTotMakan.Text
                transaksi.subtotal_minuman = TxtSubTotMinum.Text
                transaksi.total_bayar = TxtTotalbayar.Text
                transaksi.SaveDBtransaksi()
                For i As Integer = 0 To DgMakanan.Rows.Count - 1
                    Transaksi_All.InputDataDetailmakanan(DgMakanan.Rows(i).Cells(0).Value, DgMakanan.Rows(i).Cells(1).Value, DgMakanan.Rows(i).Cells(2).Value, DgMakanan.Rows(i).Cells(3).Value)
                Next
                For Baris As Integer = 0 To DgMinuman.Rows.Count - 1
                    Transaksi_All.InputDataDetailminuman(DgMinuman.Rows(Baris).Cells(0).Value, DgMinuman.Rows(Baris).Cells(1).Value, DgMinuman.Rows(Baris).Cells(2).Value, DgMinuman.Rows(Baris).Cells(3).Value)
                    Transaksi_All.InputDetailTransaksi(cbcustomer.Text, TxtBayar.Text, TxtKembalian.Text)
                Next



                MsgBox("Data Berhasil di Simpan !!!")
                Call BuatKolom()
            Catch ex As Exception
                MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
            End Try
        End If
    End Sub

    Private Sub TmJam_Tick(sender As Object, e As EventArgs) Handles TmJam.Tick
        lbljam.Text = TimeOfDay
    End Sub

    Private Sub TxtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtBayar.Text) < Val(TxtTotalbayar.Text) Then
                MsgBox("Pembayaran Kurang")
                TxtBayar.Focus()
            ElseIf Val(TxtBayar.Text) = Val(TxtTotalbayar.Text) Then
                TxtKembalian.Text = 0
                BtnSimpan.Focus()
            Else
                TxtKembalian.Text = Val(TxtBayar.Text) - Val(TxtTotalbayar.Text)
                TxtKembalian.Text = TxtKembalian.Text
                BtnSimpan.Focus()
            End If
        End If
    End Sub
End Class