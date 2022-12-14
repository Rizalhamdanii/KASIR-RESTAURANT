<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.rbbulan = New System.Windows.Forms.RadioButton()
        Me.rbminggu = New System.Windows.Forms.RadioButton()
        Me.rbtahun = New System.Windows.Forms.RadioButton()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.dtpminggu = New System.Windows.Forms.DateTimePicker()
        Me.dtpbulantahun = New System.Windows.Forms.DateTimePicker()
        Me.dtptahun = New System.Windows.Forms.DateTimePicker()
        Me.cmbbulan = New System.Windows.Forms.ComboBox()
        Me.dtpminggu2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rbbulan
        '
        Me.rbbulan.AutoSize = True
        Me.rbbulan.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbbulan.Location = New System.Drawing.Point(42, 181)
        Me.rbbulan.Name = "rbbulan"
        Me.rbbulan.Size = New System.Drawing.Size(78, 19)
        Me.rbbulan.TabIndex = 1
        Me.rbbulan.TabStop = True
        Me.rbbulan.Text = "Per &Bulan"
        Me.rbbulan.UseVisualStyleBackColor = True
        '
        'rbminggu
        '
        Me.rbminggu.AutoSize = True
        Me.rbminggu.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbminggu.Location = New System.Drawing.Point(42, 131)
        Me.rbminggu.Name = "rbminggu"
        Me.rbminggu.Size = New System.Drawing.Size(87, 19)
        Me.rbminggu.TabIndex = 2
        Me.rbminggu.TabStop = True
        Me.rbminggu.Text = "Per &Minggu"
        Me.rbminggu.UseVisualStyleBackColor = True
        '
        'rbtahun
        '
        Me.rbtahun.AutoSize = True
        Me.rbtahun.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtahun.Location = New System.Drawing.Point(42, 224)
        Me.rbtahun.Name = "rbtahun"
        Me.rbtahun.Size = New System.Drawing.Size(80, 19)
        Me.rbtahun.TabIndex = 3
        Me.rbtahun.TabStop = True
        Me.rbtahun.Text = "Per &Tahun"
        Me.rbtahun.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(87, 318)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(90, 33)
        Me.btnkeluar.TabIndex = 5
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(233, 318)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(90, 33)
        Me.btnprint.TabIndex = 6
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'dtpminggu
        '
        Me.dtpminggu.CustomFormat = "dd\MM\yyyy"
        Me.dtpminggu.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpminggu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpminggu.Location = New System.Drawing.Point(134, 131)
        Me.dtpminggu.Name = "dtpminggu"
        Me.dtpminggu.Size = New System.Drawing.Size(101, 21)
        Me.dtpminggu.TabIndex = 8
        '
        'dtpbulantahun
        '
        Me.dtpbulantahun.CustomFormat = "yyyy"
        Me.dtpbulantahun.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbulantahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpbulantahun.Location = New System.Drawing.Point(274, 177)
        Me.dtpbulantahun.Name = "dtpbulantahun"
        Me.dtpbulantahun.Size = New System.Drawing.Size(101, 21)
        Me.dtpbulantahun.TabIndex = 9
        '
        'dtptahun
        '
        Me.dtptahun.CustomFormat = "yyyy"
        Me.dtptahun.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptahun.Location = New System.Drawing.Point(134, 224)
        Me.dtptahun.Name = "dtptahun"
        Me.dtptahun.ShowUpDown = True
        Me.dtptahun.Size = New System.Drawing.Size(101, 21)
        Me.dtptahun.TabIndex = 10
        '
        'cmbbulan
        '
        Me.cmbbulan.AutoCompleteCustomSource.AddRange(New String() {"--PILIH--", "JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"})
        Me.cmbbulan.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbulan.FormattingEnabled = True
        Me.cmbbulan.Items.AddRange(New Object() {"--Select Month--", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cmbbulan.Location = New System.Drawing.Point(134, 177)
        Me.cmbbulan.Name = "cmbbulan"
        Me.cmbbulan.Size = New System.Drawing.Size(121, 23)
        Me.cmbbulan.TabIndex = 11
        '
        'dtpminggu2
        '
        Me.dtpminggu2.CustomFormat = "dd\MM\yyyy"
        Me.dtpminggu2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpminggu2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpminggu2.Location = New System.Drawing.Point(274, 131)
        Me.dtpminggu2.Name = "dtpminggu2"
        Me.dtpminggu2.Size = New System.Drawing.Size(101, 21)
        Me.dtpminggu2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "S/D"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "LAPORAN RESTAURAN"
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpminggu2)
        Me.Controls.Add(Me.cmbbulan)
        Me.Controls.Add(Me.dtptahun)
        Me.Controls.Add(Me.dtpbulantahun)
        Me.Controls.Add(Me.dtpminggu)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.rbtahun)
        Me.Controls.Add(Me.rbminggu)
        Me.Controls.Add(Me.rbbulan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbbulan As RadioButton
    Friend WithEvents rbminggu As RadioButton
    Friend WithEvents rbtahun As RadioButton
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents dtpminggu As DateTimePicker
    Friend WithEvents dtpbulantahun As DateTimePicker
    Friend WithEvents dtptahun As DateTimePicker
    Friend WithEvents cmbbulan As ComboBox
    Friend WithEvents dtpminggu2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
