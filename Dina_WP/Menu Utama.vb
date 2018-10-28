Public Class Menu_Utama
    Private Sub BobotKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BobotKriteriaToolStripMenuItem.Click
        Bobot_Kriteria.Show()
    End Sub
    Private Sub AlternatifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlternatifToolStripMenuItem.Click
        Alternatif.Show()
    End Sub
    Private Sub InputNilaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputNilaiToolStripMenuItem.Click
        Input_Nilai.Show()
    End Sub
    Private Sub AnalisaPerhitunganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalisaPerhitunganToolStripMenuItem.Click
        Analisa_Perhitungan.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub 
    Private Sub HasilKeputusanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HasilKeputusanToolStripMenuItem.Click
        Hasil.Show()
    End Sub
End Class