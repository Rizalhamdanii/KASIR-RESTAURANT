Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub Terbuka()
        MenuUtama.LOGIN.Enabled = False
        MenuUtama.LOGOUT.Enabled = True
        MenuUtama.MASTER.Enabled = True
        MenuUtama.TRANSAKSI.Enabled = True
        MenuUtama.LAPORAN.Enabled = True
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtKode.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Kode Petugas Atau Password Tidak Boleh Kosong !!!")
            TxtPass.Focus()
        Else
            Call OpenConn()
            Cmd = New MySqlCommand("select * from tblpetugas where kode_petugas = '" & TxtKode.Text & "' and password_petugas ='" & TxtPass.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Hide()
                Call Terbuka()
                'FormTransaksi.ShowDialog()

            Else
                MsgBox("Kode Petugas Atau password SALAH !!!")
            End If
        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtPass.PasswordChar = ""
        Else
            TxtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged

    End Sub
End Class
