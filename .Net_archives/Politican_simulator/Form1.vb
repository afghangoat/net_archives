Public Class Form1
    Dim money = 7000000
    Dim happines = 100
    Dim population = 10000000
    Dim wage = 11
    Dim stopit = 50
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "Minden jó!" + vbNewLine
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If money < 1 Or happines < 1 Or population < 2 Then
            MsgBox("Véged! a pénz elfogyott az emberek lázonganak vagy már mind elment!")
            Me.Close()
        End If
        If TextBox1.Text = "plakátok kihelyezése" Then
            money -= 1250000
            happines += 5
            population -= 9000
            Label2.Text = population
            Label4.Text = happines
            Label6.Text = money
            TextBox1.Text = ""
            RichTextBox1.Text += "Kihelyeztük A plakátokat. Bevették!" + vbNewLine
        ElseIf TextBox1.Text = "eus pénz felvevése" Then
            If wage > 0 Then
                money += 2000000
                happines -= 15
                population -= 70000
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Felvettük de a nép nem kapott semmit ezért kicsit elégedetlenek." + vbNewLine
                wage -= 1
            Else
                population -= 25000
                Label2.Text = population
                TextBox1.Text = ""
                RichTextBox1.Text += "Nem adtak mert még nagyon sokat kell visszafizenünk." + vbNewLine
            End If
        ElseIf TextBox1.Text = "családi pótlék bevezetése" Then
            money -= 500000
            happines += 8
            population += 75000
            Label2.Text = population
            Label4.Text = happines
            Label6.Text = money
            TextBox1.Text = ""
            RichTextBox1.Text += "A nép elégedett de sok pénzt kellett elpazarolni." + vbNewLine
        ElseIf TextBox1.Text = "soros terv" Then
            money += 100000
            population -= 1000
            Label2.Text = population
            Label4.Text = happines
            Label6.Text = money
            TextBox1.Text = ""
            RichTextBox1.Text += "Bekamuztuk hogy soros ide hívja a migránsokat. Ilyen hülyék az emberek?" + vbNewLine
        ElseIf TextBox1.Text = "adó" Then
            money += 50000
            happines -= 1
            population -= 500
            Label2.Text = population
            Label4.Text = happines
            Label6.Text = money
            TextBox1.Text = ""
            RichTextBox1.Text += "Megjött az adó." + vbNewLine
        ElseIf TextBox1.Text = "stop brüsszel" Then
            If stopit > 0 Then
                money += 10000
                happines += 5
                population -= 10000
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Legalább rágódik valamin a nép." + vbNewLine
                stopit -= 1
            Else
                money -= 1000
                happines -= 10
                population -= 25000
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Baj van! Nem vették be!!!" + vbNewLine
            End If
        ElseIf TextBox1.Text = "stop soros" Then
            If stopit > 0 Then
                money += 5000
                happines -= 5
                population += 1000
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Legalább rágódik valamin a nép." + vbNewLine
                stopit -= 1
            Else
                money -= 10000
                happines -= 10
                population -= 25000
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Baj van! Nem vették be!!!" + vbNewLine
            End If
        ElseIf TextBox1.Text = "kerítés építése" Then
            If stopit > 0 Then
                money -= 500000
                happines += 22
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Megépítettük... a nép pénzéből." + vbNewLine
                stopit -= 7
            Else
                money -= 750000
                happines -= 25
                population -= 25000
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Fellázadtak az emberek!Nem kerítést hanem kórházat akarnak. Ki kellett fizetni a tüntetők perét." + vbNewLine
            End If
        ElseIf TextBox1.Text = "stadion építése" Then
            If stopit > 0 Then
                money -= 80000
                happines += 5
                population += 1000
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "Az új stadionra nagyon sok túrista jön. a nép is boldogabb" + vbNewLine
                stopit -= 1
            Else
                money -= 10000
                happines -= 15
                Label2.Text = population
                Label4.Text = happines
                Label6.Text = money
                TextBox1.Text = ""
                RichTextBox1.Text += "a nép úgyérzi átt lett baszva!" + vbNewLine
            End If
        ElseIf TextBox1.Text = "stop brüsszel" Then
            MsgBox("NINCS ilyen opció!!!")
            TextBox1.Text = ""
        End If
    End Sub
End Class
