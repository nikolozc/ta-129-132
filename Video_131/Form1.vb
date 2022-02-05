Public Class Form1
    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        Dim myFont As New FontDialog
        myFont.ShowDialog()
        TextBox1.Font = myFont.Font
    End Sub
End Class
