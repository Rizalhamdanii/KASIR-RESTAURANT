<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGIN = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTER = New System.Windows.Forms.ToolStripMenuItem()
        Me.PETUGAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUMAKANAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUMINUMAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOUMER = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSI = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MASTER, Me.TRANSAKSI, Me.LAPORAN})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGIN, Me.LOGOUT, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LOGIN
        '
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(180, 22)
        Me.LOGIN.Text = "LOGIN"
        '
        'LOGOUT
        '
        Me.LOGOUT.Name = "LOGOUT"
        Me.LOGOUT.Size = New System.Drawing.Size(180, 22)
        Me.LOGOUT.Text = "LOG OUT"
        '
        'MASTER
        '
        Me.MASTER.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PETUGAS, Me.MENUMAKANAN, Me.MENUMINUMAN, Me.CUSTOUMER})
        Me.MASTER.Name = "MASTER"
        Me.MASTER.Size = New System.Drawing.Size(71, 20)
        Me.MASTER.Text = "MASTER"
        '
        'PETUGAS
        '
        Me.PETUGAS.Name = "PETUGAS"
        Me.PETUGAS.Size = New System.Drawing.Size(177, 22)
        Me.PETUGAS.Text = "PETUGAS"
        '
        'MENUMAKANAN
        '
        Me.MENUMAKANAN.Name = "MENUMAKANAN"
        Me.MENUMAKANAN.Size = New System.Drawing.Size(177, 22)
        Me.MENUMAKANAN.Text = "MENU MAKANAN"
        '
        'MENUMINUMAN
        '
        Me.MENUMINUMAN.Name = "MENUMINUMAN"
        Me.MENUMINUMAN.Size = New System.Drawing.Size(177, 22)
        Me.MENUMINUMAN.Text = "MENU MINUMAN"
        '
        'CUSTOUMER
        '
        Me.CUSTOUMER.Name = "CUSTOUMER"
        Me.CUSTOUMER.Size = New System.Drawing.Size(177, 22)
        Me.CUSTOUMER.Text = "CUSTOUMER"
        '
        'TRANSAKSI
        '
        Me.TRANSAKSI.Name = "TRANSAKSI"
        Me.TRANSAKSI.Size = New System.Drawing.Size(92, 20)
        Me.TRANSAKSI.Text = "TRANSAKSI"
        '
        'LAPORAN
        '
        Me.LAPORAN.Name = "LAPORAN"
        Me.LAPORAN.Size = New System.Drawing.Size(81, 20)
        Me.LAPORAN.Text = "LAPORAN"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.KASIR_RESTAURANT.My.Resources.Resources.R
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGIN As ToolStripMenuItem
    Friend WithEvents LOGOUT As ToolStripMenuItem
    Friend WithEvents MASTER As ToolStripMenuItem
    Friend WithEvents PETUGAS As ToolStripMenuItem
    Friend WithEvents MENUMAKANAN As ToolStripMenuItem
    Friend WithEvents MENUMINUMAN As ToolStripMenuItem
    Friend WithEvents CUSTOUMER As ToolStripMenuItem
    Friend WithEvents TRANSAKSI As ToolStripMenuItem
    Friend WithEvents LAPORAN As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
