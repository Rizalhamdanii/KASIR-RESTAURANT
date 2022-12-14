Imports MySql.Data.MySqlClient

Public Class Petugas
    Public kode_petugas As String
    Public nama_petugas As String
    Public Password_Petugas As String
    Public alamat_petugas As String
    Public telpon As String
    Public Function Save()
        Try
            Call OpenConn()
            Dim InputData As String = "Insert into tblpetugas values ('" & kode_petugas & "','" & nama_petugas & "','" & Password_Petugas & "','" & alamat_petugas & "','" & telpon & "')"
            Cmd = New MySqlCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update()
        Try
            Call OpenConn()
            Dim UpdateData As String = "Update tblpetugas set nama_petugas='" & nama_petugas & "', Password_Petugas='" & Password_Petugas & "', alamat_petugas='" & alamat_petugas & "', telpon='" & telpon & "' where kode_petugas='" & kode_petugas & "'"
            Cmd = New MySqlCommand(UpdateData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete()
        Try
            Call OpenConn()
            Dim DeleteData As String = "delete from tblpetugas where kode_petugas='" & kode_petugas & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Cari(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblpetugas where kode_petugas='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim petugas = New Petugas With {
            .kode_petugas = Rd.Item("kode_petugas"),
            .nama_petugas = Rd.Item("nama_petugas"),
            .Password_Petugas = Rd.Item("Password_Petugas"),
            .alamat_petugas = Rd.Item("alamat_petugas"),
            .telpon = Rd.Item("telpon")
            }
            Return petugas
        End If
    End Function
End Class
