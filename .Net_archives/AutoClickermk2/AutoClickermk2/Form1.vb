Imports System.Threading
Public Class Form1
    Dim iv1 As Integer
    Dim times1 As Integer

    Public Const MOUSEEVENTF_LEFTDOWN = &H2

    Public Const MOUSEEVENTF_LEFTUP = &H4

    Private Const MOUSEEVENTF_RIGHTDOWN = &H8

    Private Const MOUSEEVENTF_RIGHTUP = &H10

    'Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)

    'Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

    'Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)

    'Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)



    'Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iv1 = TextBox2.Text
        times1 = TextBox1.Text
        Thread.Sleep(1000)
        Cursor.Position = New Point(200, 200)
        SendKeys.Send("%" + "{Tab}")
        Thread.Sleep(200)
        SendKeys.Send("{Escape}")
        Thread.Sleep(500)
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Thread.Sleep(45)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Thread.Sleep(2000)
        For w = 1 To times1
            Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            Thread.Sleep(iv1)
            Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Next
        Thread.Sleep(1000)
    End Sub
End Class