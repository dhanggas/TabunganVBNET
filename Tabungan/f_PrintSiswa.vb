Public Class f_PrintSiswa

    Private Sub f_PrintSiswa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Report1 As New ReportSiswa

        Report1.SetParameterValue("KataKunci", f_DataSiswa.txtNIS.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class