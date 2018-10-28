Imports System.Data.OleDb
Public Class Analisa_Perhitungan
    Dim PK1, PK2, PK3, PK4, PK5, PK6, PK7 As Double

    Sub DataPenilaian()
        Using Tampil As New OleDbCommand("Select * From QPenilaian", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                ListView1.Items.Clear()
                Dim c As Integer = 0
                While Data.Read
                    ListView1.Items.Add(Data("Kode_Alternatif"))
                    ListView1.Items(c).SubItems.Add(Data("Alternatif"))
                    ListView1.Items(c).SubItems.Add(Data("K1"))
                    ListView1.Items(c).SubItems.Add(Data("K2"))
                    ListView1.Items(c).SubItems.Add(Data("K3"))
                    ListView1.Items(c).SubItems.Add(Data("K4"))
                    ListView1.Items(c).SubItems.Add(Data("K5"))
                    ListView1.Items(c).SubItems.Add(Data("K6"))
                    ListView1.Items(c).SubItems.Add(Data("K7"))

                    c = c + 1
                End While
            End Using
        End Using
    End Sub

    Sub BobotKriteria()
        ListView2.Items.Clear()
        ListView2.Items.Add("K1")
        ListView2.Items.Add("K2")
        ListView2.Items.Add("K3")
        ListView2.Items.Add("K4")
        ListView2.Items.Add("K5")
        ListView2.Items.Add("K6")
        ListView2.Items.Add("K7")

        Dim K1, K2, K3, K4, K5, K6, K7 As Double
        Using Tampil As New OleDbCommand("Select * From Kriteria", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                While Data.Read
                    K1 = Data("K1")
                    K2 = Data("K2")
                    K3 = Data("K3")
                    K4 = Data("K4")
                    K5 = Data("K5")
                    K6 = Data("K6")
                    K7 = Data("K7")

                End While
            End Using
        End Using
        ListView2.Items(0).SubItems.Add(K1)
        ListView2.Items(1).SubItems.Add(K2)
        ListView2.Items(2).SubItems.Add(K3)
        ListView2.Items(3).SubItems.Add(K4)
        ListView2.Items(4).SubItems.Add(K5)
        ListView2.Items(5).SubItems.Add(K6)
        ListView2.Items(6).SubItems.Add(K7)

        PK1 = K1 / (K1 + K2 + K3 + K4 + K5 + K6 + K7)
        PK2 = K2 / (K1 + K2 + K3 + K4 + K5 + K6 + K7)
        PK3 = K3 / (K1 + K2 + K3 + K4 + K5 + K6 + K7)
        PK4 = K4 / (K1 + K2 + K3 + K4 + K5 + K6 + K7)
        PK5 = K5 / (K1 + K2 + K3 + K4 + K5 + K6 + K7)
        PK6 = K6 / (K1 + K2 + K3 + K4 + K5 + K6 + K7)
        PK7 = K7 / (K1 + K2 + K3 + K4 + K5 + K6 + K7)

        ListView2.Items(0).SubItems.Add(Microsoft.VisualBasic.Left(PK1, 4))
        ListView2.Items(1).SubItems.Add(Microsoft.VisualBasic.Left(PK2, 4))
        ListView2.Items(2).SubItems.Add(Microsoft.VisualBasic.Left(PK3, 4))
        ListView2.Items(3).SubItems.Add(Microsoft.VisualBasic.Left(PK4, 4))
        ListView2.Items(4).SubItems.Add(Microsoft.VisualBasic.Left(PK5, 4))
        ListView2.Items(5).SubItems.Add(Microsoft.VisualBasic.Left(PK6, 4))
        ListView2.Items(6).SubItems.Add(Microsoft.VisualBasic.Left(PK7, 5))

        For i = 1 To ListView2.Items.Count
            Dim NB As String = ""
            For j = 1 To Len(ListView2.Items(i - 1).SubItems(1).Text)
                If Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1)
                End If
            Next j
            ListView2.Items(i - 1).SubItems(1).Text = NB
        Next i

        For i = 1 To ListView2.Items.Count
            Dim NB As String = ""
            For j = 1 To Len(ListView2.Items(i - 1).SubItems(1).Text)
                If Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView2.Items(i - 1).SubItems(1).Text, j, 1)
                End If
            Next j
            ListView2.Items(i - 1).SubItems(1).Text = NB
        Next i

    End Sub
    Private Sub Analisa_Perhitungan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Koneksikan.open()
        DataPenilaian()
        BobotKriteria()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Nilai Vektor S
        Dim n = ListView1.Items.Count
        Dim Vektor_S(n) As Double
        Dim Total_Vektor_S As Double = 0

        For i = 1 To ListView1.Items.Count
            ListView3.Items.Add(ListView1.Items(i - 1).SubItems(0).Text)
            Vektor_S(i) = (ListView1.Items(i - 1).SubItems(2).Text ^ (PK1)) * (ListView1.Items(i - 1).SubItems(3).Text ^ _
                                                                               (PK2)) * (ListView1.Items(i - 1).SubItems(4).Text ^ _
                                                                                         (PK3)) * (ListView1.Items(i - 1).SubItems(5).Text ^ _
                                                                                                   (PK4)) * (ListView1.Items(i - 1).SubItems(6).Text ^ (PK5)) * (ListView1.Items(i - 1).SubItems(7).Text ^ (PK6)) * (ListView1.Items(i - 1).SubItems(8).Text ^ (PK7))
            Total_Vektor_S = Total_Vektor_S + Vektor_S(i)
            ListView3.Items(i - 1).SubItems.Add(Microsoft.VisualBasic.Left(Vektor_S(i), 6))
            Dim NB As String = ""
            For j = 1 To Len(ListView3.Items(i - 1).SubItems(1).Text)
                If Microsoft.VisualBasic.Mid(ListView3.Items(i - 1).SubItems(1).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView3.Items(i - 1).SubItems(1).Text, j, 1)
                End If
            Next j
            ListView3.Items(i - 1).SubItems(1).Text = NB
        Next i

        'Nilai Vektor V
        Dim Vektor_V(n) As Double
        For i = 1 To ListView1.Items.Count
            ListView4.Items.Add(ListView1.Items(i - 1).SubItems(0).Text)
            ListView4.Items(i - 1).SubItems.Add(ListView1.Items(i - 1).SubItems(1).Text)
            Vektor_V(i) = Vektor_S(i) / Total_Vektor_S
            ListView4.Items(i - 1).SubItems.Add(Vektor_V(i))
            ListView4.Items(i - 1).SubItems.Add("-")
        Next i
        For i = 1 To ListView1.Items.Count
            Dim Max As Double = 0
            For j = 1 To ListView1.Items.Count
                If Max < ListView4.Items(j - 1).SubItems(2).Text And ListView4.Items(j - 1).SubItems(3).Text = "-" Then
                    Max = ListView4.Items(j - 1).SubItems(2).Text
                End If
            Next j
            For j = 1 To ListView1.Items.Count
                If Max = ListView4.Items(j - 1).SubItems(2).Text Then
                    ListView4.Items(j - 1).SubItems(3).Text = "Rangking " & i.ToString
                End If
            Next j
        Next i

        For i = 1 To ListView1.Items.Count
            Dim NB As String = ""
            For j = 1 To Len(ListView4.Items(i - 1).SubItems(2).Text)
                If Microsoft.VisualBasic.Mid(ListView4.Items(i - 1).SubItems(2).Text, j, 1) = "," Then
                    NB = NB + "."
                Else
                    NB = NB + Microsoft.VisualBasic.Mid(ListView4.Items(i - 1).SubItems(2).Text, j, 1)
                End If
            Next j
            ListView4.Items(i - 1).SubItems(2).Text = Microsoft.VisualBasic.Left(NB, 6)
        Next i

        'HAPUS DULU
        Using Hapus As New OleDbCommand("Delete From Hasil", Koneksikan.open)
            Hapus.CommandType = CommandType.Text
            Hapus.ExecuteNonQuery()
        End Using
        MsgBox("Analisa Selesai", MsgBoxStyle.Information, "Pemberitahuan")

        'BARU SIMPAN
        For i = 1 To ListView1.Items.Count
            Using Simpan As New OleDbCommand("Insert Into Hasil Values('" & ListView4.Items(i - 1).SubItems(0).Text & "','" & ListView4.Items(i - 1).SubItems(1).Text & "'," & ListView4.Items(i - 1).SubItems(2).Text & ",'" & ListView4.Items(i - 1).SubItems(3).Text & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
            End Using
        Next i
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dispose()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using Tampil As New OleDbCommand("Select * From Hasil Order by Nilai_Akhir Desc", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                ListView4.Items.Clear()
                Dim c As Integer = 0
                While Data.Read
                    ListView4.Items.Add(Data("Kode_Alternatif"))
                    ListView4.Items(c).SubItems.Add(Data("Alternatif"))
                    ListView4.Items(c).SubItems.Add(Data("Nilai_Akhir"))
                    ListView4.Items(c).SubItems.Add(Data("Keterangan"))
                    c = c + 1
                End While
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Using Tampil As New OleDbCommand("Select * From Laporan Order by Nilai_Akhir Desc", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                ListView4.Items.Clear()
                Dim c As Integer = 0
                While Data.Read
                    ListView4.Items.Add(Data("Kode_Alternatif"))
                    ListView4.Items(c).SubItems.Add(Data("Alternatif"))
                    ListView4.Items(c).SubItems.Add(Data("Nilai_Akhir"))
                    ListView4.Items(c).SubItems.Add(Data("Keterangan"))
                    c = c + 1
                End While
            End Using
        End Using
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
End Class