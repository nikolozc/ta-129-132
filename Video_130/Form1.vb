Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TextBox1.Text.Length > 0 Then
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
        End If
    End Sub
End Class
