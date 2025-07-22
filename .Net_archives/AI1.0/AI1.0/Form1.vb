Imports System.IO
Public Class Form1
    Dim k As String
    Dim file As System.IO.StreamWriter
    Dim rnd As New Random
    Dim kk = 0
    Dim kkk = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""

        Dim t As String
        Dim path As String = Application.StartupPath & "\sample.txt"
        Dim fileread As TextReader = New StreamReader(path)
        'there the placc
        kk = rnd.Next(1, 10)
        kkk = rnd.Next(10, path.Length)

        For i = kk To kkk
            t = fileread.ReadLine
            k += t.ToString + " "
        Next
        TextBox1.Text = k
        k = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        file = My.Computer.FileSystem.OpenTextFileWriter("worst.txt", True)
        file.WriteLine(TextBox2.Text)
        file.WriteLine(TextBox1.Text + vbNewLine)
        TextBox1.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        file = My.Computer.FileSystem.OpenTextFileWriter("bad.txt", True)
        file.WriteLine(TextBox2.Text)
        file.WriteLine(TextBox1.Text + vbNewLine)
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        file = My.Computer.FileSystem.OpenTextFileWriter("normal.txt", True)
        file.WriteLine(TextBox2.Text)
        file.WriteLine(TextBox1.Text + vbNewLine)
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        file = My.Computer.FileSystem.OpenTextFileWriter("good.txt", True)
        file.WriteLine(TextBox2.Text)
        file.WriteLine(TextBox1.Text + vbNewLine)
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        file = My.Computer.FileSystem.OpenTextFileWriter("best.txt", True)
        file.WriteLine(TextBox2.Text)
        file.WriteLine(TextBox1.Text + vbNewLine)
        TextBox1.Text = ""
    End Sub
End Class
