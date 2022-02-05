Public Class Form1

    Private strPath As String
    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        FolderBrowserDialog1.ShowDialog()
        strPath = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        IO.File.WriteAllText(strPath + "\" + txtTitle.Text + ".txt", txtContents.Text)
    End Sub
End Class
