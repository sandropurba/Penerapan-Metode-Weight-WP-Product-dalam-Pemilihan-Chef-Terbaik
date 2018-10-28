Imports System.Data.OleDb
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using Login As New OleDbCommand("Select * From Login Where Username='" & TextBox1.Text & "'", Koneksikan.open)
            Using Data As OleDbDataReader = Login.ExecuteReader
                If Data.HasRows Then
                    While Data.Read
                        If Data("Password") = TextBox2.Text Then
                            Menu_Utama.Show()
                            Me.Hide()
                        Else
                            MsgBox("Password Salah!", MsgBoxStyle.Critical, "Peringatan!")
                        End If
                    End While
                Else
                    MsgBox("Username Salah!", MsgBoxStyle.Critical, "Peringatan!")
                End If
            End Using
        End Using
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
