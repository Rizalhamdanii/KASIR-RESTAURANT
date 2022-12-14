Imports Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class Transaksi_All
    Public no_transaksi As String
    Public tgl_transaksi As String
    Public kode_custumer As String
    Public kode_petugas As String
    Public subtotal_makanan As String
    Public subtotal_minuman As String
    Public total_bayar As String
    Sub SaveDBtransaksi()
        Call OpenConn()
        Dim InputDataTransaksi As String = "Insert into tbltransaksi values ('" & no_transaksi & "','" & tgl_transaksi & "','" & kode_custumer & "','" & kode_petugas & "', '" & subtotal_makanan & "','" & subtotal_minuman & "', '" & total_bayar & "')"
        Cmd = New MySqlCommand(InputDataTransaksi, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub InputDataDetailmakanan(ByVal Jumlah As String, ByVal Nomer As String, ByVal Kode As String, ByVal Nama As String)
        Call OpenConn()
        Dim InputDataDetailmakanan As String = "Insert into tbldetail_transaksimakanan values ('" & Jumlah & "', '" & Nomer & "','" & Kode & "', '" & Nama & "')"
        Cmd = New MySqlCommand(InputDataDetailmakanan, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub InputDataDetailminuman(ByVal Jumlah As String, ByVal Nomer As String, ByVal Kode As String, ByVal Nama As String)
        Call OpenConn()
        Dim InputDataDetailminuman As String = "Insert into tbldetail_transaksiminuman values ('" & Jumlah & "','" & Nomer & "','" & Kode & "','" & Nama & "')"
        Cmd = New MySqlCommand(InputDataDetailminuman, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
    Public Shared Sub InputDetailTransaksi(ByVal Customer As String, ByVal Bayar As String, ByVal Kembalian As String)
        Call OpenConn()
        Dim InputDetailTransaksi As String = "Insert into tbldetail_transaksi values ('" & Customer & "', '" & Bayar & "','" & Kembalian & "')"
        Cmd = New MySqlCommand(InputDetailTransaksi, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
