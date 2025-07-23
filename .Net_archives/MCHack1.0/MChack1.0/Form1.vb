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



    'Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Thread.Sleep(1000)
        Label1.Text = "ON"
        Cursor.Position = New Point(200, 200)
        SendKeys.Send("%" + "{Tab}")
        Thread.Sleep(200)
        SendKeys.Send("{Escape}")
        Thread.Sleep(500)
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Thread.Sleep(45)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Thread.Sleep(2000)
        For w = 1 To 1000
            Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            Thread.Sleep(45)
            Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Next
        Thread.Sleep(1000)
        Label1.Text = "OFF"
        Thread.Sleep(10)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        Dim s As Integer
        s = 1
        For w = 1 To 9
            SendKeys.Send(s)
            For j = 1 To 64
                Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                Thread.Sleep(45)
                Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Next
            s += 1
        Next
        Thread.Sleep(1000)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c As Integer
        Thread.Sleep(1000)
        SendKeys.Send("%" + "{Tab}")
        Thread.Sleep(200)
        SendKeys.Send("{Escape}")
        Thread.Sleep(500)
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Thread.Sleep(45)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Thread.Sleep(1000)
        For c = 1 To TextBox1.Text
            SendKeys.Send("t")
            Thread.Sleep(350)
            SendKeys.Send("{Ā}")
            SendKeys.Send("{ā}")
            SendKeys.Send("{Ă}")
            SendKeys.Send("{ă}")
            SendKeys.Send("{Ą}")
            SendKeys.Send("{ą}")
            SendKeys.Send("{Ć}")
            SendKeys.Send("{ć}")
            SendKeys.Send("{Ĉ}")
            SendKeys.Send("{ĉ}")
            SendKeys.Send("{Ċ}")
            SendKeys.Send("{ċ}")
            SendKeys.Send("{Č}")
            SendKeys.Send("{č}")
            SendKeys.Send("{Ď}")
            SendKeys.Send("{ď}")
            SendKeys.Send("{Đ}")
            SendKeys.Send("{đ}")
            SendKeys.Send("{Ē}")
            SendKeys.Send("{ē}")
            SendKeys.Send("{Ĕ}")
            SendKeys.Send("{ĕ}")
            SendKeys.Send("{Ė}")
            SendKeys.Send("{ė}")
            SendKeys.Send("{Ę}")
            SendKeys.Send("{ę}")
            SendKeys.Send("{Ě}")
            SendKeys.Send("{ě}")
            SendKeys.Send("{Ĝ}")
            SendKeys.Send("{ĝ}")
            SendKeys.Send("{Ğ}")
            Thread.Sleep(350)
            SendKeys.Send("{Enter}")
        Next

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Thread.Sleep(1000)
        Cursor.Position = New Point(200, 200)
        SendKeys.Send("%" + "{Tab}")
        Thread.Sleep(200)
        SendKeys.Send("{Escape}")
        Thread.Sleep(500)
        SendKeys.Send("t")
        Thread.Sleep(500)
        SendKeys.Send("{/}")
        SendKeys.Send("{r}")
        SendKeys.Send("{e}")
        SendKeys.Send("{g}")
        SendKeys.Send("{i}")
        SendKeys.Send("{s}")
        SendKeys.Send("{t}")
        SendKeys.Send("{e}")
        SendKeys.Send("{r}")
        SendKeys.Send("{ }")
        SendKeys.Send(TextBox2.Text)
        Thread.Sleep(1000)
        SendKeys.Send("{Enter}")
        Thread.Sleep(1000)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim i = 0
        Dim k = 0
        Dim j = 0
        If e.KeyCode = Keys.B Then
            Thread.Sleep(1000)
            Thread.Sleep(500)
            SendKeys.Send("t")
            Thread.Sleep(500)
            SendKeys.Send("{/}")
            SendKeys.Send("{r}")
            SendKeys.Send("{e}")
            SendKeys.Send("{g}")
            SendKeys.Send("{i}")
            SendKeys.Send("{s}")
            SendKeys.Send("{t}")
            SendKeys.Send("{e}")
            SendKeys.Send("{r}")
            SendKeys.Send("{ }")
            SendKeys.Send(TextBox2.Text)
            Thread.Sleep(1000)
            SendKeys.Send("{Enter}")
            Thread.Sleep(1000)
        ElseIf e.KeyCode = Keys.I Then
            i += 1
            If i = 1 Then
                Do Until i = 1
                    Thread.Sleep(1000)
                    SendKeys.Send("{ }")
                Loop
            Else
                i = 0

            End If
        ElseIf e.KeyCode = Keys.K Then
            k += 1
            If k = 1 Then
                Do Until k = 1
                    Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                    Thread.Sleep(45)
                    Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                Loop
            Else
                k = 0
            End If
        ElseIf e.KeyCode = Keys.L Then
            Dim s As Integer
            s = 1
            For w = 1 To 9
                SendKeys.Send(s)
                For j = 1 To 64
                    Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                    Thread.Sleep(45)
                    Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
                Next
                s += 1
            Next
            Thread.Sleep(1000)
        ElseIf e.KeyCode = Keys.J Then
            Thread.Sleep(1000)
            Dim w As Integer
            For w = 1 To TextBox1.Text
                SendKeys.Send("t")
                Thread.Sleep(350)
                SendKeys.Send("{Ā}")
                SendKeys.Send("{ā}")
                SendKeys.Send("{Ă}")
                SendKeys.Send("{ă}")
                SendKeys.Send("{Ą}")
                SendKeys.Send("{ą}")
                SendKeys.Send("{Ć}")
                SendKeys.Send("{ć}")
                SendKeys.Send("{Ĉ}")
                SendKeys.Send("{ĉ}")
                SendKeys.Send("{Ċ}")
                SendKeys.Send("{ċ}")
                SendKeys.Send("{Č}")
                SendKeys.Send("{č}")
                SendKeys.Send("{Ď}")
                SendKeys.Send("{ď}")
                SendKeys.Send("{Đ}")
                SendKeys.Send("{đ}")
                SendKeys.Send("{Ē}")
                SendKeys.Send("{ē}")
                SendKeys.Send("{Ĕ}")
                SendKeys.Send("{ĕ}")
                SendKeys.Send("{Ė}")
                SendKeys.Send("{ė}")
                SendKeys.Send("{Ę}")
                SendKeys.Send("{ę}")
                SendKeys.Send("{Ě}")
                SendKeys.Send("{ě}")
                SendKeys.Send("{Ĝ}")
                SendKeys.Send("{ĝ}")
                SendKeys.Send("{Ğ}")
                Thread.Sleep(350)
                SendKeys.Send("{Enter}")
            Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Thread.Sleep(1000)
        For aa = 1 To 25
            SendKeys.Send("{w}")
            Thread.Sleep(350)

            SendKeys.Send("{a}")
            Thread.Sleep(350)

            SendKeys.Send("{s}")
            Thread.Sleep(350)

            SendKeys.Send("{d}")
            Thread.Sleep(350)

            SendKeys.Send("{ }")
            Thread.Sleep(350)
        Next


    End Sub
    'Private Declare Function RegisterHotKey Lib "user32" _
    '    (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    'Private Declare Function GetAsyncStateLib(Const) Lib "user32.dll" (ByVal vKey As Integer) As Short
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hotkey As Boolean
        hotkey = GetAsyncKeyState(Keys.L)
        Dim hotkey1 As Boolean
        hotkey1 = GetAsyncKeyState(Keys.K)
        If hotkey = True Then
            Thread.Sleep(1000)
            Label1.Text = "ON"
            Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            Thread.Sleep(45)
            Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Thread.Sleep(2000)
            For w = 1 To 1000
                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                Thread.Sleep(45)
                Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Next
            Thread.Sleep(1000)
            Label1.Text = "OFF"
            Thread.Sleep(10)
        End If
        If hotkey1 Then
            Thread.Sleep(500)
            Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            Thread.Sleep(45)
            Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Thread.Sleep(2000)
            Dim s As Integer
            s = 1
            For w = 1 To 9
                SendKeys.Send(s)
                For j = 1 To 64
                    Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                    Thread.Sleep(45)
                    Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
                Next
                s += 1
            Next
            Thread.Sleep(1000)
        End If
    End Sub

    Private Function GetAsyncKeyState(k As Keys) As Boolean
        Throw New NotImplementedException()
    End Function
End Class
