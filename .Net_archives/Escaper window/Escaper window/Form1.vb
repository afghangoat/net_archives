
Imports System.Threading
Public Class Form1
    Dim x = 1000
    Dim y = 500
    Dim x1 As Integer
    Dim y1 As Integer
    Dim pos2 As New Point(1000, 500)
    '            String stringResult = point1.ToString()
    '            DesktopLocation = New Point(KoTimer.Next(1, 1000), KoTimer.Next(1, 500))
    '            Cursor.Position = New Point(KoTimer.Next(1, 1000), KoTimer.Next(1, 500))
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesktopLocation = pos2
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y1 = Cursor.Position.Y
        x1 = Cursor.Position.X
        x = DesktopLocation.X
        y = DesktopLocation.Y
        If y1 <= (y + 100) Then
            DesktopLocation = New Point((DesktopLocation.X), (DesktopLocation.Y + 10))
        Else
            DesktopLocation = New Point((DesktopLocation.X), (DesktopLocation.Y - 10))
        End If
        If x1 <= (x + 100) Then
            DesktopLocation = New Point((DesktopLocation.X + 20), (DesktopLocation.Y))
        Else
            DesktopLocation = New Point((DesktopLocation.X - 20), (DesktopLocation.Y))
        End If
        If 0 >= x Or 0 >= y Then
            DesktopLocation = pos2
        End If
        If 2240 <= x Or 1200 <= y Then
            DesktopLocation = pos2
        End If
    End Sub

End Class



