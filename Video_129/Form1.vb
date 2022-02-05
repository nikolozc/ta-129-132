Public Class Form1
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Title = "Dialog Title"
        OpenFileDialog1.ShowDialog()
        lblFile.Text = OpenFileDialog1.FileName
    End Sub
End Class
