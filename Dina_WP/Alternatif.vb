Imports System.Data.OleDb
Public Class Alternatif
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Using Simpan As New OleDbCommand("Insert Into Alternatif Values('" & TextBox1.Text & "','" & TextBox2.Text & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
                Button4_Click(Nothing, Nothing)
                Alternatif_Load(Nothing, Nothing)
            End Using
        Catch ex As Exception
            MsgBox("Kode Alternatif Sudah Digunakan", MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub Alternatif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using Tampil As New OleDbCommand("Select * From Alternatif", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                ListView1.Items.Clear()
                Dim c As Integer = 0
                While Data.Read
                    ListView1.Items.Add(Data("Kode_Alternatif"))
                    ListView1.Items(c).SubItems.Add(Data("Alternatif"))
                    c = c + 1
                End While
            End Using
        End Using
        
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Try
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            Using Ubah As New OleDbCommand("Update Alternatif Set Alternatif='" & TextBox2.Text & "' Where Kode_Alternatif='" & TextBox1.Text & "'", Koneksikan.open)
                Ubah.CommandType = CommandType.Text
                Ubah.ExecuteNonQuery()
                MsgBox("Berhasil Mengubah Data", MsgBoxStyle.Information, "Pemberitahuan")
                Button4_Click(Nothing, Nothing)
                Alternatif_Load(Nothing, Nothing)
            End Using
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" Then
            Using Hapus As New OleDbCommand("Delete From Alternatif Where Kode_Alternatif='" & TextBox1.Text & "'", Koneksikan.open)
                Hapus.CommandType = CommandType.Text
                Hapus.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus Data", MsgBoxStyle.Information, "Pemberitahuan")
                Button4_Click(Nothing, Nothing)
                Alternatif_Load(Nothing, Nothing)
            End Using
        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class