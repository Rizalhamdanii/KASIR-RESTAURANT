<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbMakanan = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblJenisMakanan = New System.Windows.Forms.Label()
        Me.hdkghu = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbcustomer = New System.Windows.Forms.ComboBox()
        Me.LblKodeMakanan = New System.Windows.Forms.Label()
        Me.judul = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblNoTransaksi = New System.Windows.Forms.Label()
        Me.kodebuku = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.Label()
        Me.nopinjam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHargaMakanan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblHargaMinuman = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbMinuman = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblJenisMinuman = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblKodeMinuman = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblKodePetugas = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DgMakanan = New System.Windows.Forms.DataGridView()
        Me.BtnInputMakan = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.TmJam = New System.Windows.Forms.Timer(Me.components)
        Me.BtnInputMinum = New System.Windows.Forms.Button()
        Me.DgMinuman = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtJmlhMakan = New System.Windows.Forms.TextBox()
        Me.TxtTotMakan = New System.Windows.Forms.TextBox()
        Me.TxtTotMinum = New System.Windows.Forms.TextBox()
        Me.TxtJmlhMinum = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtSubTotMakan = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtSubTotMinum = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtTotalbayar = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtKembalian = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.DtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.DgTransaksi = New System.Windows.Forms.DataGridView()
        Me.txtno = New System.Windows.Forms.TextBox()
        CType(Me.DgMakanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgMinuman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbMakanan
        '
        Me.cbMakanan.BackColor = System.Drawing.Color.White
        Me.cbMakanan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMakanan.FormattingEnabled = True
        Me.cbMakanan.Location = New System.Drawing.Point(122, 184)
        Me.cbMakanan.Name = "cbMakanan"
        Me.cbMakanan.Size = New System.Drawing.Size(157, 23)
        Me.cbMakanan.TabIndex = 206
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.MintCream
        Me.Label16.Location = New System.Drawing.Point(105, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 15)
        Me.Label16.TabIndex = 205
        Me.Label16.Text = ":"
        '
        'LblJenisMakanan
        '
        Me.LblJenisMakanan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisMakanan.ForeColor = System.Drawing.Color.MintCream
        Me.LblJenisMakanan.Location = New System.Drawing.Point(122, 211)
        Me.LblJenisMakanan.Name = "LblJenisMakanan"
        Me.LblJenisMakanan.Size = New System.Drawing.Size(106, 13)
        Me.LblJenisMakanan.TabIndex = 204
        Me.LblJenisMakanan.Text = "LblJenisMakanan"
        '
        'hdkghu
        '
        Me.hdkghu.AutoSize = True
        Me.hdkghu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdkghu.ForeColor = System.Drawing.Color.MintCream
        Me.hdkghu.Location = New System.Drawing.Point(12, 211)
        Me.hdkghu.Name = "hdkghu"
        Me.hdkghu.Size = New System.Drawing.Size(37, 15)
        Me.hdkghu.TabIndex = 203
        Me.hdkghu.Text = "Jenis"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.MintCream
        Me.Label24.Location = New System.Drawing.Point(105, 187)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 15)
        Me.Label24.TabIndex = 199
        Me.Label24.Text = ":"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.MintCream
        Me.Label22.Location = New System.Drawing.Point(105, 126)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 15)
        Me.Label22.TabIndex = 197
        Me.Label22.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.MintCream
        Me.Label21.Location = New System.Drawing.Point(105, 101)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 15)
        Me.Label21.TabIndex = 196
        Me.Label21.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.MintCream
        Me.Label20.Location = New System.Drawing.Point(105, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 15)
        Me.Label20.TabIndex = 195
        Me.Label20.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MintCream
        Me.Label6.Location = New System.Drawing.Point(105, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 15)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MintCream
        Me.Label4.Location = New System.Drawing.Point(105, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 15)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = ":"
        '
        'cbcustomer
        '
        Me.cbcustomer.BackColor = System.Drawing.Color.White
        Me.cbcustomer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcustomer.FormattingEnabled = True
        Me.cbcustomer.Location = New System.Drawing.Point(125, 73)
        Me.cbcustomer.Name = "cbcustomer"
        Me.cbcustomer.Size = New System.Drawing.Size(103, 23)
        Me.cbcustomer.TabIndex = 192
        '
        'LblKodeMakanan
        '
        Me.LblKodeMakanan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKodeMakanan.ForeColor = System.Drawing.Color.MintCream
        Me.LblKodeMakanan.Location = New System.Drawing.Point(122, 164)
        Me.LblKodeMakanan.Name = "LblKodeMakanan"
        Me.LblKodeMakanan.Size = New System.Drawing.Size(106, 13)
        Me.LblKodeMakanan.TabIndex = 191
        Me.LblKodeMakanan.Text = "LblKodeMakanan"
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.ForeColor = System.Drawing.Color.MintCream
        Me.judul.Location = New System.Drawing.Point(12, 187)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(92, 15)
        Me.judul.TabIndex = 190
        Me.judul.Text = "Nama Makanan"
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlamat.ForeColor = System.Drawing.Color.MintCream
        Me.LblAlamat.Location = New System.Drawing.Point(122, 126)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(64, 15)
        Me.LblAlamat.TabIndex = 188
        Me.LblAlamat.Text = "LblAlamat"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.ForeColor = System.Drawing.Color.MintCream
        Me.LblNama.Location = New System.Drawing.Point(122, 101)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(56, 15)
        Me.LblNama.TabIndex = 187
        Me.LblNama.Text = "LblNama"
        '
        'LblNoTransaksi
        '
        Me.LblNoTransaksi.AutoSize = True
        Me.LblNoTransaksi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoTransaksi.ForeColor = System.Drawing.Color.MintCream
        Me.LblNoTransaksi.Location = New System.Drawing.Point(122, 49)
        Me.LblNoTransaksi.Name = "LblNoTransaksi"
        Me.LblNoTransaksi.Size = New System.Drawing.Size(96, 15)
        Me.LblNoTransaksi.TabIndex = 186
        Me.LblNoTransaksi.Text = "LblNoTransaksi"
        '
        'kodebuku
        '
        Me.kodebuku.AutoSize = True
        Me.kodebuku.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodebuku.ForeColor = System.Drawing.Color.MintCream
        Me.kodebuku.Location = New System.Drawing.Point(12, 164)
        Me.kodebuku.Name = "kodebuku"
        Me.kodebuku.Size = New System.Drawing.Size(88, 15)
        Me.kodebuku.TabIndex = 185
        Me.kodebuku.Text = "Kode Makanan"
        '
        'alamat
        '
        Me.alamat.AutoSize = True
        Me.alamat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.ForeColor = System.Drawing.Color.MintCream
        Me.alamat.Location = New System.Drawing.Point(12, 126)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(46, 15)
        Me.alamat.TabIndex = 183
        Me.alamat.Text = "Alamat"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.ForeColor = System.Drawing.Color.MintCream
        Me.nama.Location = New System.Drawing.Point(12, 101)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(38, 15)
        Me.nama.TabIndex = 182
        Me.nama.Text = "Nama"
        '
        'kode
        '
        Me.kode.AutoSize = True
        Me.kode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode.ForeColor = System.Drawing.Color.MintCream
        Me.kode.Location = New System.Drawing.Point(12, 76)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(91, 15)
        Me.kode.TabIndex = 181
        Me.kode.Text = "Kode Customer"
        '
        'nopinjam
        '
        Me.nopinjam.AutoSize = True
        Me.nopinjam.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nopinjam.ForeColor = System.Drawing.Color.MintCream
        Me.nopinjam.Location = New System.Drawing.Point(12, 49)
        Me.nopinjam.Name = "nopinjam"
        Me.nopinjam.Size = New System.Drawing.Size(71, 15)
        Me.nopinjam.TabIndex = 180
        Me.nopinjam.Text = "No Pesanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(105, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 15)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = ":"
        '
        'LblHargaMakanan
        '
        Me.LblHargaMakanan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHargaMakanan.ForeColor = System.Drawing.Color.MintCream
        Me.LblHargaMakanan.Location = New System.Drawing.Point(122, 229)
        Me.LblHargaMakanan.Name = "LblHargaMakanan"
        Me.LblHargaMakanan.Size = New System.Drawing.Size(114, 13)
        Me.LblHargaMakanan.TabIndex = 208
        Me.LblHargaMakanan.Text = "LblHargaMakanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(12, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(416, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 15)
        Me.Label2.TabIndex = 221
        Me.Label2.Text = ":"
        '
        'LblHargaMinuman
        '
        Me.LblHargaMinuman.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHargaMinuman.ForeColor = System.Drawing.Color.MintCream
        Me.LblHargaMinuman.Location = New System.Drawing.Point(433, 229)
        Me.LblHargaMinuman.Name = "LblHargaMinuman"
        Me.LblHargaMinuman.Size = New System.Drawing.Size(114, 13)
        Me.LblHargaMinuman.TabIndex = 220
        Me.LblHargaMinuman.Text = "LblHargaMinuman"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MintCream
        Me.Label7.Location = New System.Drawing.Point(323, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 219
        Me.Label7.Text = "Harga"
        '
        'CbMinuman
        '
        Me.CbMinuman.BackColor = System.Drawing.Color.White
        Me.CbMinuman.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMinuman.FormattingEnabled = True
        Me.CbMinuman.Location = New System.Drawing.Point(436, 184)
        Me.CbMinuman.Name = "CbMinuman"
        Me.CbMinuman.Size = New System.Drawing.Size(143, 23)
        Me.CbMinuman.TabIndex = 218
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MintCream
        Me.Label8.Location = New System.Drawing.Point(416, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 15)
        Me.Label8.TabIndex = 217
        Me.Label8.Text = ":"
        '
        'LblJenisMinuman
        '
        Me.LblJenisMinuman.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisMinuman.ForeColor = System.Drawing.Color.MintCream
        Me.LblJenisMinuman.Location = New System.Drawing.Point(433, 211)
        Me.LblJenisMinuman.Name = "LblJenisMinuman"
        Me.LblJenisMinuman.Size = New System.Drawing.Size(106, 13)
        Me.LblJenisMinuman.TabIndex = 216
        Me.LblJenisMinuman.Text = "LblJenisMinuman"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MintCream
        Me.Label10.Location = New System.Drawing.Point(323, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 215
        Me.Label10.Text = "Jenis"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MintCream
        Me.Label11.Location = New System.Drawing.Point(416, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 214
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.MintCream
        Me.Label12.Location = New System.Drawing.Point(416, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = ":"
        '
        'LblKodeMinuman
        '
        Me.LblKodeMinuman.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKodeMinuman.ForeColor = System.Drawing.Color.MintCream
        Me.LblKodeMinuman.Location = New System.Drawing.Point(433, 164)
        Me.LblKodeMinuman.Name = "LblKodeMinuman"
        Me.LblKodeMinuman.Size = New System.Drawing.Size(106, 13)
        Me.LblKodeMinuman.TabIndex = 212
        Me.LblKodeMinuman.Text = "LblKodeMinuman"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MintCream
        Me.Label14.Location = New System.Drawing.Point(323, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 15)
        Me.Label14.TabIndex = 211
        Me.Label14.Text = "Nama Makanan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.MintCream
        Me.Label15.Location = New System.Drawing.Point(323, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 15)
        Me.Label15.TabIndex = 210
        Me.Label15.Text = "Kode Makanan"
        '
        'LblKodePetugas
        '
        Me.LblKodePetugas.AutoSize = True
        Me.LblKodePetugas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKodePetugas.ForeColor = System.Drawing.Color.MintCream
        Me.LblKodePetugas.Location = New System.Drawing.Point(499, 103)
        Me.LblKodePetugas.Name = "LblKodePetugas"
        Me.LblKodePetugas.Size = New System.Drawing.Size(96, 15)
        Me.LblKodePetugas.TabIndex = 230
        Me.LblKodePetugas.Text = "LblKodePetugas"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.MintCream
        Me.Label26.Location = New System.Drawing.Point(482, 103)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 15)
        Me.Label26.TabIndex = 229
        Me.Label26.Text = ":"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.MintCream
        Me.Label31.Location = New System.Drawing.Point(387, 103)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(81, 15)
        Me.Label31.TabIndex = 228
        Me.Label31.Text = "Kode Petugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MintCream
        Me.Label5.Location = New System.Drawing.Point(482, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 15)
        Me.Label5.TabIndex = 227
        Me.Label5.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MintCream
        Me.Label9.Location = New System.Drawing.Point(482, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 15)
        Me.Label9.TabIndex = 226
        Me.Label9.Text = ":"
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.ForeColor = System.Drawing.Color.MintCream
        Me.lbljam.Location = New System.Drawing.Point(499, 76)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(51, 15)
        Me.lbljam.TabIndex = 225
        Me.lbljam.Text = "Lbl Jam"
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggal.ForeColor = System.Drawing.Color.MintCream
        Me.lbltanggal.Location = New System.Drawing.Point(475, 16)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(72, 15)
        Me.lbltanggal.TabIndex = 224
        Me.lbltanggal.Text = "Lbl Tanggal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MintCream
        Me.Label13.Location = New System.Drawing.Point(389, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 15)
        Me.Label13.TabIndex = 223
        Me.Label13.Text = "Jam"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.MintCream
        Me.Label17.Location = New System.Drawing.Point(387, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 15)
        Me.Label17.TabIndex = 222
        Me.Label17.Text = "Tanggal"
        '
        'DgMakanan
        '
        Me.DgMakanan.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgMakanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgMakanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgMakanan.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgMakanan.Location = New System.Drawing.Point(12, 298)
        Me.DgMakanan.Name = "DgMakanan"
        Me.DgMakanan.RowHeadersVisible = False
        Me.DgMakanan.Size = New System.Drawing.Size(275, 89)
        Me.DgMakanan.TabIndex = 231
        '
        'BtnInputMakan
        '
        Me.BtnInputMakan.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnInputMakan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputMakan.Location = New System.Drawing.Point(231, 266)
        Me.BtnInputMakan.Name = "BtnInputMakan"
        Me.BtnInputMakan.Size = New System.Drawing.Size(56, 30)
        Me.BtnInputMakan.TabIndex = 232
        Me.BtnInputMakan.Text = "INPUT"
        Me.BtnInputMakan.UseVisualStyleBackColor = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.Red
        Me.BtnKeluar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.ForeColor = System.Drawing.Color.White
        Me.BtnKeluar.Location = New System.Drawing.Point(588, 0)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(25, 25)
        Me.BtnKeluar.TabIndex = 233
        Me.BtnKeluar.Text = "X"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'TmJam
        '
        Me.TmJam.Enabled = True
        '
        'BtnInputMinum
        '
        Me.BtnInputMinum.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnInputMinum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputMinum.Location = New System.Drawing.Point(545, 266)
        Me.BtnInputMinum.Name = "BtnInputMinum"
        Me.BtnInputMinum.Size = New System.Drawing.Size(56, 30)
        Me.BtnInputMinum.TabIndex = 234
        Me.BtnInputMinum.Text = "INPUT"
        Me.BtnInputMinum.UseVisualStyleBackColor = False
        '
        'DgMinuman
        '
        Me.DgMinuman.AllowUserToAddRows = False
        Me.DgMinuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgMinuman.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgMinuman.Location = New System.Drawing.Point(326, 298)
        Me.DgMinuman.Name = "DgMinuman"
        Me.DgMinuman.RowHeadersVisible = False
        Me.DgMinuman.Size = New System.Drawing.Size(275, 89)
        Me.DgMinuman.TabIndex = 235
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.MintCream
        Me.Label18.Location = New System.Drawing.Point(176, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(261, 31)
        Me.Label18.TabIndex = 236
        Me.Label18.Text = "FORM TRANSAKSI"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.Color.Black
        Me.BtnSimpan.Location = New System.Drawing.Point(12, 430)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(69, 30)
        Me.BtnSimpan.TabIndex = 238
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.MintCream
        Me.Label19.Location = New System.Drawing.Point(105, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 15)
        Me.Label19.TabIndex = 245
        Me.Label19.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.MintCream
        Me.Label30.Location = New System.Drawing.Point(12, 251)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 15)
        Me.Label30.TabIndex = 240
        Me.Label30.Text = "Jumlah"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.MintCream
        Me.Label28.Location = New System.Drawing.Point(105, 248)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(11, 15)
        Me.Label28.TabIndex = 242
        Me.Label28.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.MintCream
        Me.Label27.Location = New System.Drawing.Point(12, 274)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 15)
        Me.Label27.TabIndex = 243
        Me.Label27.Text = "Total Harga"
        '
        'TxtJmlhMakan
        '
        Me.TxtJmlhMakan.Location = New System.Drawing.Point(122, 247)
        Me.TxtJmlhMakan.Name = "TxtJmlhMakan"
        Me.TxtJmlhMakan.Size = New System.Drawing.Size(64, 20)
        Me.TxtJmlhMakan.TabIndex = 246
        '
        'TxtTotMakan
        '
        Me.TxtTotMakan.Location = New System.Drawing.Point(122, 272)
        Me.TxtTotMakan.Name = "TxtTotMakan"
        Me.TxtTotMakan.Size = New System.Drawing.Size(79, 20)
        Me.TxtTotMakan.TabIndex = 247
        '
        'TxtTotMinum
        '
        Me.TxtTotMinum.Location = New System.Drawing.Point(436, 272)
        Me.TxtTotMinum.Name = "TxtTotMinum"
        Me.TxtTotMinum.Size = New System.Drawing.Size(79, 20)
        Me.TxtTotMinum.TabIndex = 253
        '
        'TxtJmlhMinum
        '
        Me.TxtJmlhMinum.Location = New System.Drawing.Point(436, 246)
        Me.TxtJmlhMinum.Name = "TxtJmlhMinum"
        Me.TxtJmlhMinum.Size = New System.Drawing.Size(64, 20)
        Me.TxtJmlhMinum.TabIndex = 252
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.MintCream
        Me.Label25.Location = New System.Drawing.Point(416, 274)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 15)
        Me.Label25.TabIndex = 251
        Me.Label25.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.MintCream
        Me.Label29.Location = New System.Drawing.Point(323, 274)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 15)
        Me.Label29.TabIndex = 250
        Me.Label29.Text = "Total Harga"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.MintCream
        Me.Label32.Location = New System.Drawing.Point(416, 248)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(11, 15)
        Me.Label32.TabIndex = 249
        Me.Label32.Text = ":"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.MintCream
        Me.Label33.Location = New System.Drawing.Point(323, 251)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 15)
        Me.Label33.TabIndex = 248
        Me.Label33.Text = "Jumlah"
        '
        'TxtSubTotMakan
        '
        Me.TxtSubTotMakan.Location = New System.Drawing.Point(208, 393)
        Me.TxtSubTotMakan.Name = "TxtSubTotMakan"
        Me.TxtSubTotMakan.Size = New System.Drawing.Size(79, 20)
        Me.TxtSubTotMakan.TabIndex = 256
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.MintCream
        Me.Label34.Location = New System.Drawing.Point(191, 395)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(11, 15)
        Me.Label34.TabIndex = 255
        Me.Label34.Text = ":"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.MintCream
        Me.Label35.Location = New System.Drawing.Point(87, 395)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(99, 15)
        Me.Label35.TabIndex = 254
        Me.Label35.Text = "SubTot Makanan"
        '
        'TxtSubTotMinum
        '
        Me.TxtSubTotMinum.Location = New System.Drawing.Point(522, 393)
        Me.TxtSubTotMinum.Name = "TxtSubTotMinum"
        Me.TxtSubTotMinum.Size = New System.Drawing.Size(79, 20)
        Me.TxtSubTotMinum.TabIndex = 259
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.MintCream
        Me.Label36.Location = New System.Drawing.Point(505, 395)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(11, 15)
        Me.Label36.TabIndex = 258
        Me.Label36.Text = ":"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.MintCream
        Me.Label37.Location = New System.Drawing.Point(401, 395)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(100, 15)
        Me.Label37.TabIndex = 257
        Me.Label37.Text = "SubTot Minuman"
        '
        'TxtTotalbayar
        '
        Me.TxtTotalbayar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalbayar.Location = New System.Drawing.Point(251, 437)
        Me.TxtTotalbayar.Name = "TxtTotalbayar"
        Me.TxtTotalbayar.Size = New System.Drawing.Size(111, 23)
        Me.TxtTotalbayar.TabIndex = 262
        Me.TxtTotalbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.MintCream
        Me.Label38.Location = New System.Drawing.Point(260, 419)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(93, 15)
        Me.Label38.TabIndex = 260
        Me.Label38.Text = "TOTAL BAYAR"
        '
        'TxtBayar
        '
        Me.TxtBayar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBayar.Location = New System.Drawing.Point(373, 437)
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(111, 23)
        Me.TxtBayar.TabIndex = 264
        Me.TxtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.MintCream
        Me.Label23.Location = New System.Drawing.Point(404, 419)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 15)
        Me.Label23.TabIndex = 263
        Me.Label23.Text = "BAYAR"
        '
        'TxtKembalian
        '
        Me.TxtKembalian.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKembalian.Location = New System.Drawing.Point(490, 437)
        Me.TxtKembalian.Name = "TxtKembalian"
        Me.TxtKembalian.Size = New System.Drawing.Size(111, 23)
        Me.TxtKembalian.TabIndex = 266
        Me.TxtKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.MintCream
        Me.Label39.Location = New System.Drawing.Point(506, 419)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(82, 15)
        Me.Label39.TabIndex = 265
        Me.Label39.Text = "KEMBALIAN"
        '
        'DtpTgl
        '
        Me.DtpTgl.CustomFormat = "dd/MM/yyyy"
        Me.DtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTgl.Location = New System.Drawing.Point(499, 49)
        Me.DtpTgl.Name = "DtpTgl"
        Me.DtpTgl.Size = New System.Drawing.Size(91, 20)
        Me.DtpTgl.TabIndex = 268
        '
        'DgTransaksi
        '
        Me.DgTransaksi.AllowUserToAddRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgTransaksi.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgTransaksi.Location = New System.Drawing.Point(12, 466)
        Me.DgTransaksi.Name = "DgTransaksi"
        Me.DgTransaksi.RowHeadersVisible = False
        Me.DgTransaksi.Size = New System.Drawing.Size(589, 102)
        Me.DgTransaksi.TabIndex = 269
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(253, 52)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(100, 20)
        Me.txtno.TabIndex = 270
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(613, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.DgTransaksi)
        Me.Controls.Add(Me.DtpTgl)
        Me.Controls.Add(Me.TxtKembalian)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.TxtBayar)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TxtTotalbayar)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.TxtSubTotMinum)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.TxtSubTotMakan)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.TxtTotMinum)
        Me.Controls.Add(Me.TxtJmlhMinum)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TxtTotMakan)
        Me.Controls.Add(Me.TxtJmlhMakan)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DgMinuman)
        Me.Controls.Add(Me.BtnInputMinum)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnInputMakan)
        Me.Controls.Add(Me.DgMakanan)
        Me.Controls.Add(Me.LblKodePetugas)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbljam)
        Me.Controls.Add(Me.lbltanggal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblHargaMinuman)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbMinuman)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblJenisMinuman)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LblKodeMinuman)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblHargaMakanan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbMakanan)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblJenisMakanan)
        Me.Controls.Add(Me.hdkghu)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbcustomer)
        Me.Controls.Add(Me.LblKodeMakanan)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblNoTransaksi)
        Me.Controls.Add(Me.kodebuku)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.nopinjam)
        Me.ForeColor = System.Drawing.Color.MintCream
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksi"
        CType(Me.DgMakanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgMinuman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbMakanan As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents LblJenisMakanan As Label
    Friend WithEvents hdkghu As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbcustomer As ComboBox
    Friend WithEvents LblKodeMakanan As Label
    Friend WithEvents judul As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblNoTransaksi As Label
    Friend WithEvents kodebuku As Label
    Friend WithEvents alamat As Label
    Friend WithEvents nama As Label
    Friend WithEvents kode As Label
    Friend WithEvents nopinjam As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblHargaMakanan As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblHargaMinuman As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CbMinuman As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LblJenisMinuman As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LblKodeMinuman As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblKodePetugas As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbljam As Label
    Friend WithEvents lbltanggal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DgMakanan As DataGridView
    Friend WithEvents BtnInputMakan As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents TmJam As Timer
    Friend WithEvents BtnInputMinum As Button
    Friend WithEvents DgMinuman As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtJmlhMakan As TextBox
    Friend WithEvents TxtTotMakan As TextBox
    Friend WithEvents TxtTotMinum As TextBox
    Friend WithEvents TxtJmlhMinum As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtSubTotMakan As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents TxtSubTotMinum As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents TxtTotalbayar As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TxtBayar As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtKembalian As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents DtpTgl As DateTimePicker
    Friend WithEvents DgTransaksi As DataGridView
    Friend WithEvents txtno As TextBox
End Class
