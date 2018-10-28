Imports System.Data.OleDb
Public Class Input_Nilai
    Sub Combo1()
        Using Tampil As New OleDbCommand("Select * From Alternatif", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                ComboBox1.Items.Clear()
                While Data.Read
                    ComboBox1.Items.Add(Data("Kode_Alternatif"))
                End While
            End Using
        End Using
    End Sub
    Sub TampilData()
        Using Tampil As New OleDbCommand("Select * From QPenilaian", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                ListView1.Items.Clear()
                Dim c As Integer = 0
                Dim Nmr As Integer = 1

                If Data.HasRows = True Then
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
                        Nmr = Nmr + 1
                    End While
                End If
            End Using
        End Using
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
    End Sub
    Private Sub Input_Nilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Combo1()
        TampilData()
    End Sub
    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        Using Tampil As New OleDbCommand("Select * From Alternatif Where Kode_Alternatif='" & ComboBox1.Text & "'", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                While Data.Read
                    TextBox1.Text = Data("Alternatif")
                End While
            End Using
        End Using
    End Sub
    Private Sub ComboBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox8.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged

        If ComboBox8.Text = "33-35" Then
            TextBox8.Text = 1
        ElseIf ComboBox8.Text = "30-33" Then
            TextBox8.Text = 2
        ElseIf ComboBox8.Text = "27-29" Then
            TextBox8.Text = 3
        ElseIf ComboBox8.Text = "24-26" Then
            TextBox8.Text = 4
        End If
    End Sub
    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "SMP" Then
            TextBox2.Text = 1
        ElseIf ComboBox2.Text = "SMA" Then
            TextBox2.Text = 2
        ElseIf ComboBox2.Text = "D3" Then
            TextBox2.Text = 3
        ElseIf ComboBox2.Text = "S1" Then
            TextBox2.Text = 4
        End If
    End Sub
    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Cafe" Then
            TextBox3.Text = 1
        ElseIf ComboBox3.Text = "Restaurant" Then
            TextBox3.Text = 2
        ElseIf ComboBox3.Text = "Hotel ***" Then
            TextBox3.Text = 3
        ElseIf ComboBox3.Text = "Hotel ****" Then
            TextBox3.Text = 4
        End If
    End Sub
    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "Sangat Tidak Disiplin" Then
            TextBox4.Text = 1
        ElseIf ComboBox4.Text = "Tidak Disiplin" Then
            TextBox4.Text = 2
        ElseIf ComboBox4.Text = "Disiplin" Then
            TextBox4.Text = 3
        ElseIf ComboBox4.Text = "Sangat Disiplin" Then
            TextBox4.Text = 4
        End If
    End Sub
    Private Sub ComboBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox5.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.Text = "<70" Then
            TextBox5.Text = 1
        ElseIf ComboBox5.Text = "70-79" Then
            TextBox5.Text = 2
        ElseIf ComboBox5.Text = "80-89" Then
            TextBox5.Text = 3
        ElseIf ComboBox5.Text = "90-100" Then
            TextBox5.Text = 4
        End If
    End Sub
    Private Sub ComboBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox6.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "<70" Then
            TextBox6.Text = 1
        ElseIf ComboBox6.Text = "70-79" Then
            TextBox6.Text = 2
        ElseIf ComboBox6.Text = "80-89" Then
            TextBox6.Text = 3
        ElseIf ComboBox6.Text = "90-100" Then
            TextBox6.Text = 4
        End If
    End Sub
    Private Sub ComboBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox7.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.Text = "<70" Then
            TextBox7.Text = 1
        ElseIf ComboBox7.Text = "70-79" Then
            TextBox7.Text = 2
        ElseIf ComboBox7.Text = "80-89" Then
            TextBox7.Text = 3
        ElseIf ComboBox7.Text = "90-100" Then
            TextBox7.Text = 4
        End If
    End Sub
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Try
            ComboBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox4.Text = ListView1.SelectedItems(0).SubItems(4).Text
            TextBox5.Text = ListView1.SelectedItems(0).SubItems(5).Text
            TextBox6.Text = ListView1.SelectedItems(0).SubItems(6).Text
            TextBox7.Text = ListView1.SelectedItems(0).SubItems(7).Text
            TextBox8.Text = ListView1.SelectedItems(0).SubItems(8).Text

            If TextBox2.Text = 1 Then
                ComboBox2.Text = "SMP"
            ElseIf TextBox2.Text = 2 Then
                ComboBox2.Text = "SMA"
            ElseIf TextBox2.Text = 3 Then
                ComboBox2.Text = "D3"
            Else
                ComboBox2.Text = "S1"
            End If


            If TextBox3.Text = 1 Then
                ComboBox3.Text = "Cafe"
            ElseIf TextBox3.Text = 2 Then
                ComboBox3.Text = "Restaurant"
            ElseIf TextBox3.Text = 3 Then
                ComboBox3.Text = "Hotel ***"
            Else
                ComboBox3.Text = "Hotel ****"
            End If

            If TextBox4.Text = 1 Then
                ComboBox4.Text = "Sangat Tidak Disiplin"
            ElseIf TextBox4.Text = 2 Then
                ComboBox4.Text = "Tidak Disiplin"
            ElseIf TextBox4.Text = 3 Then
                ComboBox4.Text = "Disiplin"
            Else
                ComboBox4.Text = "Sangat Disiplin"
            End If

            If TextBox5.Text = 1 Then
                ComboBox5.Text = "<70"
            ElseIf TextBox5.Text = 2 Then
                ComboBox5.Text = "70-79"
            ElseIf TextBox5.Text = 3 Then
                ComboBox5.Text = "80-89"
            Else
                ComboBox5.Text = "90-100"
            End If

            If TextBox6.Text = 1 Then
                ComboBox6.Text = "<70"
            ElseIf TextBox6.Text = 2 Then
                ComboBox6.Text = "70-79"
            ElseIf TextBox6.Text = 3 Then
                ComboBox6.Text = "80-89"
            Else
                ComboBox6.Text = "90-100"
            End If

            If TextBox7.Text = 1 Then
                ComboBox7.Text = "<70"
            ElseIf TextBox7.Text = 2 Then
                ComboBox7.Text = "70-79"
            ElseIf TextBox7.Text = 3 Then
                ComboBox7.Text = "80-89"
            Else
                ComboBox7.Text = "90-100"
            End If

            If TextBox8.Text = 1 Then
                ComboBox8.Text = "33-35"
            ElseIf TextBox8.Text = 2 Then
                ComboBox8.Text = "30-33"
            ElseIf TextBox8.Text = 3 Then
                ComboBox8.Text = "27-29"
            Else
                ComboBox8.Text = "24-26"
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        ComboBox5.ResetText()
        ComboBox6.ResetText()
        ComboBox7.ResetText()
        ComboBox8.ResetText()

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then
            Try
                Using Simpan As New OleDbCommand("Insert Into Penilaian Values('" & ComboBox1.Text & "'," & Val(TextBox2.Text) & "," & Val(TextBox3.Text) & "," & Val(TextBox4.Text) & "," & Val(TextBox5.Text) & "," & Val(TextBox6.Text) & "," & Val(TextBox7.Text) & "," & Val(TextBox8.Text) & ")", Koneksikan.open)
                    Simpan.CommandType = CommandType.Text
                    Simpan.ExecuteNonQuery()
                    MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
                    Button4_Click(Nothing, Nothing)
                    TampilData()
                End Using
            Catch ex As Exception
                MsgBox("Kode Alternatif Sudah Digunakan", MsgBoxStyle.Critical, "Peringatan")
            End Try
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            Using Ubah As New OleDbCommand("Update Penilaian Set K1=" & Val(TextBox2.Text) & _
                                           ",K2=" & Val(TextBox3.Text) & _
                                           ",K3=" & Val(TextBox4.Text) & _
                                           ",K4=" & Val(TextBox5.Text) & _
                                           ",K5=" & Val(TextBox6.Text) & _
                                           ",K6=" & Val(TextBox7.Text) & _
                                           ",K7=" & Val(TextBox8.Text) & _
                                           " Where Kode_Alternatif='" & ComboBox1.Text & "'", Koneksikan.open)
                Ubah.CommandType = CommandType.Text
                Ubah.ExecuteNonQuery()
                MsgBox("Berhasil Mengubah Data", MsgBoxStyle.Information, "Pemberitahuan")
                Button4_Click(Nothing, Nothing)
                TampilData()
            End Using
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox1.Text <> "" Then
            Using Hapus As New OleDbCommand("Delete From Penilaian Where Kode_Alternatif='" & ComboBox1.Text & "'", Koneksikan.open)
                Hapus.CommandType = CommandType.Text
                Hapus.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus Data", MsgBoxStyle.Information, "Pemberitahuan")
                Button4_Click(Nothing, Nothing)
                TampilData()
            End Using
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dispose()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class