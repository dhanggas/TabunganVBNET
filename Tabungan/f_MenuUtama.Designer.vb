<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LihatPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesTabunganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetoranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PengambilanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanSetoranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanPengambilanTanggalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.STBar = New System.Windows.Forms.StatusStrip
        Me.Panel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Jam = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip1.SuspendLayout()
        Me.STBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PetugasToolStripMenuItem, Me.MasterToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahPenggunaToolStripMenuItem, Me.GantiPasswordToolStripMenuItem, Me.LihatPenggunaToolStripMenuItem})
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PetugasToolStripMenuItem.Text = "Pengguna"
        '
        'TambahPenggunaToolStripMenuItem
        '
        Me.TambahPenggunaToolStripMenuItem.Name = "TambahPenggunaToolStripMenuItem"
        Me.TambahPenggunaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TambahPenggunaToolStripMenuItem.Text = "Tambah Pengguna"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'LihatPenggunaToolStripMenuItem
        '
        Me.LihatPenggunaToolStripMenuItem.Name = "LihatPenggunaToolStripMenuItem"
        Me.LihatPenggunaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LihatPenggunaToolStripMenuItem.Text = "Lihat Pengguna"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSiswaToolStripMenuItem, Me.ProsesTabunganToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DataSiswaToolStripMenuItem
        '
        Me.DataSiswaToolStripMenuItem.Name = "DataSiswaToolStripMenuItem"
        Me.DataSiswaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DataSiswaToolStripMenuItem.Text = "Data Siswa"
        '
        'ProsesTabunganToolStripMenuItem
        '
        Me.ProsesTabunganToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetoranToolStripMenuItem, Me.PengambilanToolStripMenuItem})
        Me.ProsesTabunganToolStripMenuItem.Name = "ProsesTabunganToolStripMenuItem"
        Me.ProsesTabunganToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ProsesTabunganToolStripMenuItem.Text = "Proses Tabungan"
        '
        'SetoranToolStripMenuItem
        '
        Me.SetoranToolStripMenuItem.Name = "SetoranToolStripMenuItem"
        Me.SetoranToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SetoranToolStripMenuItem.Text = "Setoran"
        '
        'PengambilanToolStripMenuItem
        '
        Me.PengambilanToolStripMenuItem.Name = "PengambilanToolStripMenuItem"
        Me.PengambilanToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PengambilanToolStripMenuItem.Text = "Pengambilan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanSetoranToolStripMenuItem, Me.LaporanPengambilanTanggalToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanSetoranToolStripMenuItem
        '
        Me.LaporanSetoranToolStripMenuItem.Name = "LaporanSetoranToolStripMenuItem"
        Me.LaporanSetoranToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.LaporanSetoranToolStripMenuItem.Text = "Laporan Setoran/Tanggal"
        '
        'LaporanPengambilanTanggalToolStripMenuItem
        '
        Me.LaporanPengambilanTanggalToolStripMenuItem.Name = "LaporanPengambilanTanggalToolStripMenuItem"
        Me.LaporanPengambilanTanggalToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.LaporanPengambilanTanggalToolStripMenuItem.Text = "Laporan Pengambilan/Tanggal"
        '
        'STBar
        '
        Me.STBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Panel1, Me.Panel2, Me.Panel3, Me.Jam, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.STBar.Location = New System.Drawing.Point(0, 671)
        Me.STBar.Name = "STBar"
        Me.STBar.Size = New System.Drawing.Size(1110, 22)
        Me.STBar.TabIndex = 4
        Me.STBar.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 17)
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 17)
        '
        'Panel3
        '
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(0, 17)
        '
        'Jam
        '
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1110, 24)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'f_MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1110, 693)
        Me.Controls.Add(Me.STBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "f_MenuUtama"
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.STBar.ResumeLayout(False)
        Me.STBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesTabunganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetoranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengambilanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanSetoranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPengambilanTanggalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STBar As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Jam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TambahPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip

End Class
