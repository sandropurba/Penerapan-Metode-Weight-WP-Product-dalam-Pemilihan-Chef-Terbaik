Public Class Hasil
    Private Sub Hasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ReportEng As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim ReportPath As String = Application.StartupPath & "\Report11.rpt"
        ReportEng.Load(ReportPath)
        CrystalReportViewer1.ReportSource = ReportEng
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.Show()
    End Sub
End Class