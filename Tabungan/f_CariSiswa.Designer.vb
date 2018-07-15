<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_CariSiswa
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.btnCari = New System.Windows.Forms.Button
        Me.RB_NIS = New System.Windows.Forms.RadioButton
        Me.RB_Nama = New System.Windows.Forms.RadioButton
        Me.RB_Kelas = New System.Windows.Forms.RadioButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnKeluar = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Siswa"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(147, 84)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(292, 29)
        Me.txtCari.TabIndex = 1
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(459, 84)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 29)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'RB_NIS
        '
        Me.RB_NIS.AutoSize = True
        Me.RB_NIS.Location = New System.Drawing.Point(147, 132)
        Me.RB_NIS.Name = "RB_NIS"
        Me.RB_NIS.Size = New System.Drawing.Size(64, 17)
        Me.RB_NIS.TabIndex = 3
        Me.RB_NIS.TabStop = True
        Me.RB_NIS.Text = "Cari NIS"
        Me.RB_NIS.UseVisualStyleBackColor = True
        '
        'RB_Nama
        '
        Me.RB_Nama.AutoSize = True
        Me.RB_Nama.Location = New System.Drawing.Point(249, 132)
        Me.RB_Nama.Name = "RB_Nama"
        Me.RB_Nama.Size = New System.Drawing.Size(74, 17)
        Me.RB_Nama.TabIndex = 4
        Me.RB_Nama.TabStop = True
        Me.RB_Nama.Text = "Cari Nama"
        Me.RB_Nama.UseVisualStyleBackColor = True
        '
        'RB_Kelas
        '
        Me.RB_Kelas.AutoSize = True
        Me.RB_Kelas.Location = New System.Drawing.Point(345, 132)
        Me.RB_Kelas.Name = "RB_Kelas"
        Me.RB_Kelas.Size = New System.Drawing.Size(72, 17)
        Me.RB_Kelas.TabIndex = 5
        Me.RB_Kelas.TabStop = True
        Me.RB_Kelas.Text = "Cari Kelas"
        Me.RB_Kelas.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 195)
        Me.DataGridView1.TabIndex = 6
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(563, 359)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(89, 42)
        Me.btnKeluar.TabIndex = 7
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'f_CariSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(664, 410)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RB_Kelas)
        Me.Controls.Add(Me.RB_Nama)
        Me.Controls.Add(Me.RB_NIS)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "f_CariSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Siswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents RB_NIS As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Nama As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Kelas As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
