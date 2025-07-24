Public Class Form1
    Dim KoTimer As New PointToScreen()
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        While 1 = 1
            DesktopLocation = New Point(KoTimer.Next(1, 1000), KoTimer.Next(1, 500))
        End While
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Class PointToScreen(Of)

    End Class
End Class
