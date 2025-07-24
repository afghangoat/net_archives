Imports System.Threading
Public Class I1
    Dim x = 1000
    Dim y = 500
    Dim rnd1 As New Random
    Dim rnd2 As New Random
    Dim int1 = rnd1.Next(-5, 5)
    Dim int2 = rnd2.Next(-10, 10)
    Dim FileNum As Integer = FreeFile()
    Dim TempS As String = ""
    Dim TempL As String
    Dim file As System.IO.StreamWriter
    Dim fn = 1

    Private Sub I1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        BackColor = Color.Coral
        TransparencyKey = BackColor
        DesktopLocation = New Point(0, 0)
        write()
        Timer1.Start()
        unerror()
        Label1.Visible = True


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub
    Function unerror()

        FileOpen(FileNum, "memz.ill", OpenMode.Input)
        Do Until EOF(FileNum)
            TempL = LineInput(FileNum)
            TempS += TempL + vbCrLf
        Loop
        FileClose(FileNum)
        Label1.Text = TempS
        Return True
    End Function
    Function write()
        file = My.Computer.FileSystem.OpenTextFileWriter("memz.ill", True)
        file.WriteLine("Hello!" + vbNewLine)
        file.WriteLine("I will help your pc work for you.")
        file.Close()

        Return True
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For a = 1 To 40
            y += int1
            x += int2
            If y >= 500 Then
                y -= 5
            End If
            If y <= 0 Then
                y += 5
            End If
            If x >= 1000 Then
                x -= 10
            End If
            If x <= 0 Then
                x += 10
            End If
            DesktopLocation = New Point(x, y)
            Thread.Sleep(100)
        Next
        int1 = rnd1.Next(-5, 5)
        int2 = rnd2.Next(-10, 10)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
