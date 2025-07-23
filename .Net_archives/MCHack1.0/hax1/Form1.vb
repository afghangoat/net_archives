Public Class Form1
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Threading.Thread.Sleep(220)
        mouse_event(&H2)
        mouse_event(&H4)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
