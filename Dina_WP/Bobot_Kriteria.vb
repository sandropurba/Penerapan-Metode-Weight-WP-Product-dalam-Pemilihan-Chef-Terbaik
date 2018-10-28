Imports System.Data.OleDb
Public Class Bobot_Kriteria
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using Hapus As New OleDbCommand("Delete From Kriteria", Koneksikan.open)
            Hapus.CommandType = CommandType.Text
            Hapus.ExecuteNonQuery()
        End Using
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Pemberitahuan")
        Using Simpan As New OleDbCommand("Insert Into Kriteria Values(" & TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & ")", Koneksikan.open)
            Simpan.CommandType = CommandType.Text
            Simpan.ExecuteNonQuery()
        End Using
    End Sub
    Private Sub Bobot_Kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using Tampil As New OleDbCommand("Select * From Kriteria", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                While Data.Read
                    Dim NB As String = ""
                    For j = 1 To Len(Data("K1"))
                        If Microsoft.VisualBasic.Mid(Data("K1"), j, 1) = "," Then
                            NB = NB + "."
                        Else
                            NB = NB + Microsoft.VisualBasic.Mid(Data("K1"), j, 1)
                        End If
                    Next j
                    TextBox1.Text = NB

                    NB = ""
                    For j = 1 To Len(Data("K2"))
                        If Microsoft.VisualBasic.Mid(Data("K2"), j, 1) = "," Then
                            NB = NB + "."
                        Else
                            NB = NB + Microsoft.VisualBasic.Mid(Data("K2"), j, 1)
                        End If
                    Next j
                    TextBox2.Text = NB

                    NB = ""
                    For j = 1 To Len(Data("K3"))
                        If Microsoft.VisualBasic.Mid(Data("K3"), j, 1) = "," Then
                            NB = NB + "."
                        Else
                            NB = NB + Microsoft.VisualBasic.Mid(Data("K3"), j, 1)
                        End If
                    Next j
                    TextBox3.Text = NB

                    NB = ""
                    For j = 1 To Len(Data("K4"))
                        If Microsoft.VisualBasic.Mid(Data("K4"), j, 1) = "," Then
                            NB = NB + "."
                        Else
                            NB = NB + Microsoft.VisualBasic.Mid(Data("K4"), j, 1)
                        End If
                    Next j
                    TextBox4.Text = NB

                    NB = ""
                    For j = 1 To Len(Data("K5"))
                        If Microsoft.VisualBasic.Mid(Data("K5"), j, 1) = "," Then
                            NB = NB + "."
                        Else
                            NB = NB + Microsoft.VisualBasic.Mid(Data("K5"), j, 1)
                        End If
                    Next j
                    TextBox5.Text = NB

                    NB = ""
                    For j = 1 To Len(Data("K6"))
                        If Microsoft.VisualBasic.Mid(Data("K6"), j, 1) = "," Then
                            NB = NB + "."
                        Else
                            NB = NB + Microsoft.VisualBasic.Mid(Data("K6"), j, 1)
                        End If
                    Next j
                    TextBox6.Text = NB

                    NB = ""
                    For j = 1 To Len(Data("K7"))
                        If Microsoft.VisualBasic.Mid(Data("K7"), j, 1) = "," Then
                            NB = NB + "."
                        Else
                            NB = NB + Microsoft.VisualBasic.Mid(Data("K7"), j, 1)
                        End If
                    Next j
                    TextBox7.Text = NB
                End While
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class