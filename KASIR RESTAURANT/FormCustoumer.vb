Imports MySql.Data.MySqlClient
Public Class FormCustoumer
    Sub Tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblcustoumer", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblcustoumer")
        DgCustoumer.DataSource = Ds.Tables("tblcustoumer")
        DgCustoumer.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        BtnInput.Text = "INPUT"
        BtnInput.Enabled = True
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.Enabled = True
        BtnDelete.Text = "DELETE"
        BtnDelete.Enabled = True
        BtnLogOut.Text = "LOG OUT"

        TxtKode.Enabled = False
        TxtNamaCustoumer.Enabled = False
        TxtAlamat.Enabled = False

        TxtKode.Text = ""
        TxtNamaCustoumer.Text = ""
        TxtAlamat.Text = ""

    End Sub
    Sub Isi()
        TxtKode.Enabled = True
        TxtNamaCustoumer.Enabled = True
        TxtAlamat.Enabled = True
    End Sub
    Private Sub FormCustoumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If TxtKode.Text = "" Or TxtNamaCustoumer.Text = "" Or TxtAlamat.Text = "" Then
                MsgBox("Pastikan Semua File Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Insert into tblcustoumer values ('" & TxtKode.Text & "','" & TxtNamaCustoumer.Text & "','" & TxtAlamat.Text & "')"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Simpan !!!")
                    Call Tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblcustoumer where kode_custoumer='" & TxtKode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
            Else
                TxtNamaCustoumer.Text = Rd.Item("nama_custoumer")
                TxtAlamat.Text = Rd.Item("alamat_custoumer")
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
            If TxtKode.Text = "" Or TxtNamaCustoumer.Text = "" Or TxtAlamat.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "Update tblcustoumer set nama_custoumer='" & TxtNamaCustoumer.Text & "', alamat_custoumer='" & TxtAlamat.Text & "' where kode_custoumer='" & TxtKode.Text & "'"
                    Cmd = New MySqlCommand(UpdateData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
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
            If TxtKode.Text = "" Or TxtNamaCustoumer.Text = "" Or TxtAlamat.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim DeleteData As String = "Delete from tblcustoumer where kode_custoumer='" & TxtKode.Text & "'"
                    Cmd = New MySqlCommand(DeleteData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub
End Class