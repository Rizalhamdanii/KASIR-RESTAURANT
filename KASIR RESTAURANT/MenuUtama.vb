Public Class MenuUtama
    Sub Terkunci()
        LOGIN.Enabled = True
        LOGOUT.Enabled = False
        MASTER.Enabled = False
        TRANSAKSI.Enabled = False
        LAPORAN.Enabled = False
    End Sub
    Private Sub MENUMAKANAN_Click(sender As Object, e As EventArgs) Handles MENUMAKANAN.Click
        FormMakanan.ShowDialog()
    End Sub

    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Call Terkunci()
    End Sub

    Private Sub MENUMINUMAN_Click(sender As Object, e As EventArgs) Handles MENUMINUMAN.Click
        FormMinuman.ShowDialog()
    End Sub

    Private Sub CUSTOUMER_Click(sender As Object, e As EventArgs) Handles CUSTOUMER.Click
        FormCustoumer.ShowDialog()
    End Sub

    Private Sub TRANSAKSI_Click(sender As Object, e As EventArgs) Handles TRANSAKSI.Click
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub PETUGAS_Click(sender As Object, e As EventArgs) Handles PETUGAS.Click
        FormPetugas.ShowDialog()
    End Sub

    Private Sub LAPORAN_Click(sender As Object, e As EventArgs) Handles LAPORAN.Click
        FormLaporan.ShowDialog()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub
End Class