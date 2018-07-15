Imports System.Data.OleDb
Imports System.Data.Odbc

Public Class f_Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Koneksi()
        CMD = New OleDbCommand("select * from pengguna where Username='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False
            f_MenuUtama.Show()
            f_MenuUtama.ToolStripStatusLabel1.Text = RD.GetString(1)
            f_MenuUtama.ToolStripStatusLabel2.Text = RD.GetString(3)
            If f_MenuUtama.ToolStripStatusLabel2.Text = "ADMINISTRATOR" Then
                f_MenuUtama.MasterToolStripMenuItem.Enabled = True
                f_MenuUtama.PetugasToolStripMenuItem.Enabled = True
            Else
                f_MenuUtama.MasterToolStripMenuItem.Enabled = False
                f_MenuUtama.PetugasToolStripMenuItem.Enabled = False
            End If
        Else
            MsgBox("Login Tidak Berhasil, Periksan Kembali Username dan Password", MsgBoxStyle.Exclamation, "Peringatan")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
