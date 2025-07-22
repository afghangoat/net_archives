Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While True
            Cursor.Position = New Point(TextBox1.Text)
        End While


    End Sub
End Class
