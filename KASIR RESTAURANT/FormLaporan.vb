Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Public Class FormLaporan
    Dim cmd As MySqlCommand
    Dim Da As New MySqlDataAdapter
    Dim strSQL As String
    Sub RbRefresh()
        rbminggu.Checked = False
        rbbulan.Checked = False
        rbtahun.Checked = False
        btnkeluar.Text = "EXIT"
    End Sub
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim Lap As New ReportDocument
        Lap.Load("..\..\LpTransaksi.rpt")
        If rbminggu.Checked = True Then
            Lap.SetParameterValue("Dt1", dtpminggu.Text)
            Lap.SetParameterValue("Dt2", dtpminggu2.Text)
        ElseIf rbbulan.Checked = True Then
            LaporanTransaksi.CrystalReportViewer1.SelectionFormula = "Month({tbltransaksi1.tgl_transaksi})=" & cmbbulan.SelectedIndex & " and Year({tbltransaksi1.tgl_transaksi})=" & Format(dtpbulantahun.Value, "yyyy") & ""
        ElseIf rbtahun.Checked = True Then
            LaporanTransaksi.CrystalReportViewer1.SelectionFormula = "Year({tbltransaksi1.tgl_transaksi})=" & Format(dtptahun.Value, "yyyy") & ""
        End If

        LaporanTransaksi.CrystalReportViewer1.ReportSource = Lap
        LaporanTransaksi.ShowDialog()
        Call RbRefresh()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class