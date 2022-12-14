Imports MySql.Data.MySqlClient

Public Class Makanan
    Public kode_makanan As String
    Public nama_makanan As String
    Public jenis_makanan As String
    Public harga_makanan As String
    Public Function Save()
        Try
            Call OpenConn()
            Dim InputData As String = "Insert into tblmakanan values ('" & kode_makanan & "','" & nama_makanan & "','" & jenis_makanan & "','" & harga_makanan & "')"
            Cmd = New MySqlCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Ubah()
        Try
            Call OpenConn()
            Dim UpdateData As String = "Update tblmakanan set nama_makanan='" & nama_makanan & "', jenis_makanan='" & jenis_makanan & "', harga_makanan='" & harga_makanan & "' where kode_makanan='" & kode_makanan & "'"
            Cmd = New MySqlCommand(UpdateData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Hapus()
        Try
            Call OpenConn()
            Dim DeleteData As String = "delete from tblmakanan where kode_makanan='" & kode_makanan & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Cari(Keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblmakanan where kode_makanan='" & Keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim makanan = New Makanan With {
            .kode_makanan = Rd.Item("kode_makanan"),
            .nama_makanan = Rd.Item("nama_makanan"),
            .jenis_makanan = Rd.Item("jenis_makanan"),
            .harga_makanan = Rd.Item("harga_makanan")
            }
            Return makanan
        End If
    End Function
    Public Shared Function Select_KdMakanan(Keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblmakanan where nama_makanan='" & Keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim makanan = New Makanan With {
            .kode_makanan = Rd.Item("kode_makanan"),
            .nama_makanan = Rd.Item("nama_makanan"),
            .jenis_makanan = Rd.Item("jenis_makanan"),
            .harga_makanan = Rd.Item("harga_makanan")
            }
            Return makanan
        End If
    End Function
End Class
