Imports System.Threading
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dir1 As String = "abcdefghijklmnopqrstuvwxyz"
        Dim di = 1
        Dim ii As String
        Dim iii As Integer
        Thread.Sleep(100)
        ii = Mid(dir1, iii + di, 1)
        TextBox1.Text = ii
        di += 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
