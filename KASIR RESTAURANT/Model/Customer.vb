Imports MySql.Data.MySqlClient
Public Class Customer
    Public kode_customer As String
    Public nama_customer As String
    Public alamat_customer As String
    Public Shared Function Select_KdCustomer(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblcustoumer where kode_custoumer='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim customer = New Customer With {
            .nama_customer = Rd.Item("nama_custoumer"),
            .alamat_customer = Rd.Item("alamat_custoumer")
            }
            Return customer
        End If
    End Function
End Class
