Imports System.Text

Public Class Form1

    Dim obfuscatedCode As New StringBuilder
    Dim alphaChars As String = "abcdefghijklmnopqrstuvwxyz"
    Dim random As New Random

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    End Sub

    Private Function GenerateRandomString(length As Integer) As String
        Randomize()
        Dim i As Integer
        Dim temp As String
        For x As Integer = 0 To length
            i = CInt(Math.Floor((alphaChars.Length - 1 + 1) * Rnd())) + 1
            temp &= Mid(alphaChars, i, 1)
        Next
        Return temp
    End Function

    Private Function SaveFile() As Boolean
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(SaveFileDialog1.FileName, obfuscatedCode.ToString)
            Return True
        Else
            Return False

        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            ObfuscateCode1()
        ElseIf RadioButton2.Checked = True Then
            ObfuscateCode2()
        ElseIf RadioButton3.Checked = True Then
            ObfuscateCode3()
        End If
    End Sub

    Private Sub ObfuscateCode3()
        TextBox1.ReadOnly = True

        obfuscatedCode.Clear()

        Dim unicodeHeader() As Byte = New Byte() {&HFF, &HFE, &HD, &HA}
        Dim obfuscatedCodeByteArray() As Byte = New Byte() {}

        obfuscatedCodeByteArray = System.Text.Encoding.ASCII.GetBytes("cls" + vbNewLine + TextBox1.Text)

        Dim concatenadedByteArray() As Byte = New Byte(unicodeHeader.Length + obfuscatedCodeByteArray.Length) {}

        unicodeHeader.CopyTo(concatenadedByteArray, 0)
        obfuscatedCodeByteArray.CopyTo(concatenadedByteArray, unicodeHeader.Length)

        TextBox1.ReadOnly = False

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllBytes(SaveFileDialog1.FileName, concatenadedByteArray)
        Else
            Return

        End If
    End Sub

    Private Sub ObfuscateCode2()
        TextBox1.ReadOnly = True

        obfuscatedCode.Clear()
        Dim randomVariableName As String = ""

        For loopCounter = 1 To Len(TextBox1.Text)
            randomVariableName = GenerateRandomString(6)
            obfuscatedCode.Append("%" & randomVariableName & "%" & Mid(TextBox1.Text, loopCounter, 1))
        Next
        TextBox1.ReadOnly = False
        SaveFile()
    End Sub

    Private Sub ObfuscateCode1()
        TextBox1.ReadOnly = True

        obfuscatedCode.Clear()

        obfuscatedCode.Append("@echo off" & vbNewLine)
        Dim alphaCharsDefinitions(26) As String
        Dim loopCounter As Integer
        For loopCounter = 0 To 25
            alphaCharsDefinitions(loopCounter) = GenerateRandomString(6)
            obfuscatedCode.Append("set " & alphaCharsDefinitions(loopCounter) & "=" & Mid(alphaChars, loopCounter + 1, 1) & vbNewLine)
        Next

        For loopCounter = 1 To Len(TextBox1.Text)
            Select Case Mid(TextBox1.Text, loopCounter, 1)
                Case "a"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(0) & "%")
                Case "b"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(1) & "%")
                Case "c"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(2) & "%")
                Case "d"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(3) & "%")
                Case "e"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(4) & "%")
                Case "f"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(5) & "%")
                Case "g"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(6) & "%")
                Case "h"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(7) & "%")
                Case "i"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(8) & "%")
                Case "j"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(9) & "%")
                Case "k"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(10) & "%")
                Case "l"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(11) & "%")
                Case "m"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(12) & "%")
                Case "n"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(13) & "%")
                Case "o"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(14) & "%")
                Case "p"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(15) & "%")
                Case "q"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(16) & "%")
                Case "r"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(17) & "%")
                Case "s"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(18) & "%")
                Case "t"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(19) & "%")
                Case "u"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(20) & "%")
                Case "v"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(21) & "%")
                Case "w"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(22) & "%")
                Case "x"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(23) & "%")
                Case "y"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(24) & "%")
                Case "z"
                    obfuscatedCode.Append("%" & alphaCharsDefinitions(25) & "%")
                Case Else
                    obfuscatedCode.Append(Mid(TextBox1.Text, loopCounter, 1))
            End Select
        Next

        TextBox1.ReadOnly = False
        SaveFile()
    End Sub
End Class
