Imports System.IO

Public Class frmNotepad
    Private Sub frmNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using fo As New OpenFileDialog
            fo.Multiselect = False
            fo.RestoreDirectory = True
            fo.Filter = "Text Files|*.txt"
            fo.FilterIndex = 1
            fo.ShowDialog()
            If (Not fo.FileName = Nothing) Then
                TextBox1.Text = File.ReadAllText(fo.FileName)
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using fs As New SaveFileDialog
            fs.RestoreDirectory = True
            fs.Filter = "Text Files|*.txt"
            fs.FilterIndex = 1
            fs.ShowDialog()
            If Not (fs.FileName = Nothing) Then File.WriteAllText(fs.FileName, TextBox1.Text)
        End Using
    End Sub
End Class
