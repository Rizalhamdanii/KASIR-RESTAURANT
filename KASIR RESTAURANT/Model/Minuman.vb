Imports MySql.Data.MySqlClient

Public Class Minuman
    Public kode_minuman As String
    Public nama_minuman As String
    Public jenis_minuman As String
    Public harga_minuman As String
    Public Function save()
        Try
            Call OpenConn()
            Dim InputData As String = "Insert into tblminuman values ('" & kode_minuman & "','" & nama_minuman & "','" & jenis_minuman & "','" & harga_minuman & "')"
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
            Dim UpdateData As String = "Update tblminuman set nama_minuman='" & nama_minuman & "', jenis_minuman='" & jenis_minuman & "', harga_minuman='" & harga_minuman & "' where kode_minuman='" & kode_minuman & "'"
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
            Dim DeleteData As String = "delete from tblminuman where kode_minuman='" & kode_minuman & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Cari(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblminuman where kode_minuman='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim minuman = New Minuman With {
            .kode_minuman = Rd.Item("kode_minuman"),
            .nama_minuman = Rd.Item("nama_minuman"),
            .jenis_minuman = Rd.Item("jenis_minuman"),
            .harga_minuman = Rd.Item("harga_minuman")
            }
            Return minuman
        End If
    End Function
    Public Shared Function Select_KdMinuman(Keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblminuman where nama_minuman='" & Keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim minuman = New Minuman With {
            .kode_minuman = Rd.Item("kode_minuman"),
            .nama_minuman = Rd.Item("nama_minuman"),
            .jenis_minuman = Rd.Item("jenis_minuman"),
            .harga_minuman = Rd.Item("harga_minuman")
            }
            Return minuman
        End If
    End Function
End Class
