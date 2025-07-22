Public Class Form1
    Dim SUM As String
    Dim NUM As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NUM = (TextBox6.Text + TextBox7.Text + TextBox8.Text + TextBox9.Text + TextBox10.Text)
        SUM = ((5 * TextBox6.Text) + (4 * TextBox7.Text) + (3 * TextBox8.Text) + (2 * TextBox9.Text) + (1 * TextBox10.Text)) / NUM
        Label4.Text = SUM
    End Sub
End Class
