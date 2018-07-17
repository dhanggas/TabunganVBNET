Public Class f_AmbilRange

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        f_ReportAmbilDate.ReportAmbilDate1.SetParameterValue("awal", DTAwal.Text)
        f_ReportAmbilDate.ReportAmbilDate1.SetParameterValue("akhir", DTAkhir.Text)
        f_ReportAmbilDate.Show()
        Me.Dispose()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub
End Class