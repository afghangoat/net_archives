Imports System.Threading

Public Class Form1
    Public Const MOUSEEVENTF_LEFTDOWN = &H2

    Public Const MOUSEEVENTF_LEFTUP = &H4

    Private Const MOUSEEVENTF_RIGHTDOWN = &H8

    Private Const MOUSEEVENTF_RIGHTUP = &H10

    'Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)

    'Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

    'Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)

    'Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)

    'Cursor.Position = New Point(200, 200)

    'Thread.Sleep(1000)

    'alt+tab SendKeys.Send("%" + "{Tab}")

    'SendKeys.Send("{Escape}")


    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As System.IO.StreamWriter
        Dim filereader As New System.IO.StreamReader("C:\Users\Gabci\Desktop\Homescript\hometemp.txt")
        Cursor.Position = New Point(1000, 410)
        Thread.Sleep(5000)
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Thread.Sleep(200)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Thread.Sleep(1250)
        Cursor.Position = New Point(200, 295)
        Thread.Sleep(1000)
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Thread.Sleep(200)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Thread.Sleep(2500)
        Cursor.Position = New Point(1000, 500)
        Thread.Sleep(800)
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Thread.Sleep(200)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Thread.Sleep(2000)
        Thread.Sleep(5000)
        file = My.Computer.FileSystem.OpenTextFileWriter("homework.txt", True)
        file.WriteLine("-A házi feladat-  |" + filereader.ReadToEnd)
        file.Close()
        filereader.Close()
        Thread.Sleep(5000)
        Me.Close()


    End Sub
    Function Save()
        SaveFileDialog1.Title = "Homescriptsave"
        SaveFileDialog1.CheckFileExists = True
        SaveFileDialog1.CheckPathExists = True
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog1.ShowDialog()
        Return True
    End Function
End Class
