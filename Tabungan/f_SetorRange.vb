Public Class f_SetorRange

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click

        f_ReportSetorDate.ReportSetorDate3.SetParameterValue("awal", DTAwal.Text)
        f_ReportSetorDate.ReportSetorDate3.SetParameterValue("akhir", DTAkhir.Text)
        f_ReportSetorDate.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub
End Class