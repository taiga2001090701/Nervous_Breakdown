Public Class Game
    Public Property Angle As Integer
    Public pn, gs As Byte
    Public p, p1, p2, p3, p4, p5, p6 As Byte
    Public sn, c As Byte
    Public w As String
    Public b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, b20, b21, b22, b23, b24, b25, b26, b27, b28, b29, b30, b31, b32, b33, b34, b35, b36, b37, b38, b39, b40, b41, b42, b43, b44, b45, b46, b47, b48, b49, b50, b51, b52 As String
    Public s1, s2, n1, n2 As String
    Public t As ULong
    Public i, s, sa As Integer
    Public r As New Random
    Public t1, t2, t3, t4 As ULong
    Public an1, an2, an3, an4, an5, an6, an7, an8, an9, an10, an11, an12, an13, an14, an15, an16, an17, an18, an19, an20, an21, an22, an23, an24, an25, an26, an27, an28, an29, an30, an31, an32, an33, an34, an35, an36, an37, an38, an39, an40, an41, an42, an43, an44, an45, an46, an47, an48, an49, an50, an51, an52 As String
    Private sw As New Status
    Private ow As New OK
    Private aw As New Accuracy
    Dim q As DialogResult
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gs = 1
        L.Focus()
        ow.Owner = Me
        sw.Owner = Me
        aw.Owner = Me
        ow.Visible = False
        sw.Visible = False
        aw.Visible = False
        ow.Show(Me)
        If pn = 1 Then
            sw.LP2.Hide()
            sw.LP3.Hide()
            sw.LP4.Hide()
            sw.LP5.Hide()
            sw.LP6.Hide()
            sw.C2.Hide()
            sw.C3.Hide()
            sw.C4.Hide()
            sw.C5.Hide()
            sw.C6.Hide()
            aw.LP2.Hide()
            aw.LP3.Hide()
            aw.LP4.Hide()
            aw.LP5.Hide()
            aw.LP6.Hide()
            aw.PB2.Hide()
            aw.PB3.Hide()
            aw.PB4.Hide()
            aw.PB5.Hide()
            aw.PB6.Hide()
            aw.PS2.Hide()
            aw.PS3.Hide()
            aw.PS4.Hide()
            aw.PS5.Hide()
            aw.PS6.Hide()
            aw.PE2.Hide()
            aw.PE3.Hide()
            aw.PE4.Hide()
            aw.PE5.Hide()
            aw.PE6.Hide()
        ElseIf pn = 2 Then
            sw.LP3.Hide()
            sw.LP4.Hide()
            sw.LP5.Hide()
            sw.LP6.Hide()
            sw.C3.Hide()
            sw.C4.Hide()
            sw.C5.Hide()
            sw.C6.Hide()
            aw.LP3.Hide()
            aw.LP4.Hide()
            aw.LP5.Hide()
            aw.LP6.Hide()
            aw.PB3.Hide()
            aw.PB4.Hide()
            aw.PB5.Hide()
            aw.PB6.Hide()
            aw.PS3.Hide()
            aw.PS4.Hide()
            aw.PS5.Hide()
            aw.PS6.Hide()
            aw.PE3.Hide()
            aw.PE4.Hide()
            aw.PE5.Hide()
            aw.PE6.Hide()
        ElseIf pn = 3 Then
            sw.LP4.Hide()
            sw.LP5.Hide()
            sw.LP6.Hide()
            sw.C4.Hide()
            sw.C5.Hide()
            sw.C6.Hide()
            aw.LP4.Hide()
            aw.LP5.Hide()
            aw.LP6.Hide()
            aw.PB4.Hide()
            aw.PB5.Hide()
            aw.PB6.Hide()
            aw.PS4.Hide()
            aw.PS5.Hide()
            aw.PS6.Hide()
            aw.PE4.Hide()
            aw.PE5.Hide()
            aw.PE6.Hide()
        ElseIf pn = 4 Then
            sw.LP5.Hide()
            sw.LP6.Hide()
            sw.C5.Hide()
            sw.C6.Hide()
            aw.LP5.Hide()
            aw.LP6.Hide()
            aw.PB5.Hide()
            aw.PB6.Hide()
            aw.PS5.Hide()
            aw.PS6.Hide()
            aw.PE5.Hide()
            aw.PE6.Hide()
        ElseIf pn = 5 Then
            sw.LP6.Hide()
            sw.C6.Hide()
            aw.LP6.Hide()
            aw.PB6.Hide()
            aw.PS6.Hide()
            aw.PE6.Hide()
        ElseIf pn = 6 Then
        End If
        FS()
        s = 1
        Do While s <= 52
            sa = s
            Do While sa = s
                i = r.Next(1, 53)
                If i = 1 And b1 = "" Then
                    If s = 1 Then
                        b1 = "♥1"
                    ElseIf s = 2 Then
                        b1 = "♥2"
                    ElseIf s = 3 Then
                        b1 = "♥3"
                    ElseIf s = 3 Then
                        b1 = "♥3"
                    ElseIf s = 4 Then
                        b1 = "♥4"
                    ElseIf s = 4 Then
                        b1 = "♥4"
                    ElseIf s = 5 Then
                        b1 = "♥5"
                    ElseIf s = 5 Then
                        b1 = "♥5"
                    ElseIf s = 6 Then
                        b1 = "♥6"
                    ElseIf s = 6 Then
                        b1 = "♥6"
                    ElseIf s = 7 Then
                        b1 = "♥7"
                    ElseIf s = 7 Then
                        b1 = "♥7"
                    ElseIf s = 8 Then
                        b1 = "♥8"
                    ElseIf s = 8 Then
                        b1 = "♥8"
                    ElseIf s = 9 Then
                        b1 = "♥9"
                    ElseIf s = 9 Then
                        b1 = "♥9"
                    ElseIf s = 10 Then
                        b1 = "♥10"
                    ElseIf s = 10 Then
                        b1 = "♥10"
                    ElseIf s = 11 Then
                        b1 = "♥11"
                    ElseIf s = 11 Then
                        b1 = "♥11"
                    ElseIf s = 12 Then
                        b1 = "♥12"
                    ElseIf s = 12 Then
                        b1 = "♥12"
                    ElseIf s = 13 Then
                        b1 = "♥13"
                    ElseIf s = 13 Then
                        b1 = "♥13"
                    ElseIf s = 14 Then
                        b1 = "♦1"
                    ElseIf s = 15 Then
                        b1 = "♦2"
                    ElseIf s = 16 Then
                        b1 = "♦3"
                    ElseIf s = 17 Then
                        b1 = "♦4"
                    ElseIf s = 18 Then
                        b1 = "♦5"
                    ElseIf s = 19 Then
                        b1 = "♦6"
                    ElseIf s = 20 Then
                        b1 = "♦7"
                    ElseIf s = 21 Then
                        b1 = "♦8"
                    ElseIf s = 22 Then
                        b1 = "♦9"
                    ElseIf s = 23 Then
                        b1 = "♦10"
                    ElseIf s = 24 Then
                        b1 = "♦11"
                    ElseIf s = 25 Then
                        b1 = "♦12"
                    ElseIf s = 26 Then
                        b1 = "♦13"
                    ElseIf s = 27 Then
                        b1 = "♤1"
                    ElseIf s = 28 Then
                        b1 = "♤2"
                    ElseIf s = 29 Then
                        b1 = "♤3"
                    ElseIf s = 30 Then
                        b1 = "♤4"
                    ElseIf s = 31 Then
                        b1 = "♤5"
                    ElseIf s = 32 Then
                        b1 = "♤6"
                    ElseIf s = 33 Then
                        b1 = "♤7"
                    ElseIf s = 34 Then
                        b1 = "♤8"
                    ElseIf s = 35 Then
                        b1 = "♤9"
                    ElseIf s = 36 Then
                        b1 = "♤10"
                    ElseIf s = 37 Then
                        b1 = "♤11"
                    ElseIf s = 38 Then
                        b1 = "♤12"
                    ElseIf s = 39 Then
                        b1 = "♤13"
                    ElseIf s = 40 Then
                        b1 = "♧1"
                    ElseIf s = 41 Then
                        b1 = "♧2"
                    ElseIf s = 42 Then
                        b1 = "♧3"
                    ElseIf s = 43 Then
                        b1 = "♧4"
                    ElseIf s = 44 Then
                        b1 = "♧5"
                    ElseIf s = 45 Then
                        b1 = "♧6"
                    ElseIf s = 46 Then
                        b1 = "♧7"
                    ElseIf s = 47 Then
                        b1 = "♧8"
                    ElseIf s = 48 Then
                        b1 = "♧9"
                    ElseIf s = 49 Then
                        b1 = "♧10"
                    ElseIf s = 50 Then
                        b1 = "♧11"
                    ElseIf s = 51 Then
                        b1 = "♧12"
                    ElseIf s = 52 Then
                        b1 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 2 And b2 = "" Then
                    If s = 1 Then
                        b2 = "♥1"
                    ElseIf s = 2 Then
                        b2 = "♥2"
                    ElseIf s = 3 Then
                        b2 = "♥3"
                    ElseIf s = 3 Then
                        b2 = "♥3"
                    ElseIf s = 4 Then
                        b2 = "♥4"
                    ElseIf s = 4 Then
                        b2 = "♥4"
                    ElseIf s = 5 Then
                        b2 = "♥5"
                    ElseIf s = 5 Then
                        b2 = "♥5"
                    ElseIf s = 6 Then
                        b2 = "♥6"
                    ElseIf s = 6 Then
                        b2 = "♥6"
                    ElseIf s = 7 Then
                        b2 = "♥7"
                    ElseIf s = 7 Then
                        b2 = "♥7"
                    ElseIf s = 8 Then
                        b2 = "♥8"
                    ElseIf s = 8 Then
                        b2 = "♥8"
                    ElseIf s = 9 Then
                        b2 = "♥9"
                    ElseIf s = 9 Then
                        b2 = "♥9"
                    ElseIf s = 10 Then
                        b2 = "♥10"
                    ElseIf s = 10 Then
                        b2 = "♥10"
                    ElseIf s = 11 Then
                        b2 = "♥11"
                    ElseIf s = 11 Then
                        b2 = "♥11"
                    ElseIf s = 12 Then
                        b2 = "♥12"
                    ElseIf s = 12 Then
                        b2 = "♥12"
                    ElseIf s = 13 Then
                        b2 = "♥13"
                    ElseIf s = 13 Then
                        b2 = "♥13"
                    ElseIf s = 14 Then
                        b2 = "♦1"
                    ElseIf s = 15 Then
                        b2 = "♦2"
                    ElseIf s = 16 Then
                        b2 = "♦3"
                    ElseIf s = 17 Then
                        b2 = "♦4"
                    ElseIf s = 18 Then
                        b2 = "♦5"
                    ElseIf s = 19 Then
                        b2 = "♦6"
                    ElseIf s = 20 Then
                        b2 = "♦7"
                    ElseIf s = 21 Then
                        b2 = "♦8"
                    ElseIf s = 22 Then
                        b2 = "♦9"
                    ElseIf s = 23 Then
                        b2 = "♦10"
                    ElseIf s = 24 Then
                        b2 = "♦11"
                    ElseIf s = 25 Then
                        b2 = "♦12"
                    ElseIf s = 26 Then
                        b2 = "♦13"
                    ElseIf s = 27 Then
                        b2 = "♤1"
                    ElseIf s = 28 Then
                        b2 = "♤2"
                    ElseIf s = 29 Then
                        b2 = "♤3"
                    ElseIf s = 30 Then
                        b2 = "♤4"
                    ElseIf s = 31 Then
                        b2 = "♤5"
                    ElseIf s = 32 Then
                        b2 = "♤6"
                    ElseIf s = 33 Then
                        b2 = "♤7"
                    ElseIf s = 34 Then
                        b2 = "♤8"
                    ElseIf s = 35 Then
                        b2 = "♤9"
                    ElseIf s = 36 Then
                        b2 = "♤10"
                    ElseIf s = 37 Then
                        b2 = "♤11"
                    ElseIf s = 38 Then
                        b2 = "♤12"
                    ElseIf s = 39 Then
                        b2 = "♤13"
                    ElseIf s = 40 Then
                        b2 = "♧1"
                    ElseIf s = 41 Then
                        b2 = "♧2"
                    ElseIf s = 42 Then
                        b2 = "♧3"
                    ElseIf s = 43 Then
                        b2 = "♧4"
                    ElseIf s = 44 Then
                        b2 = "♧5"
                    ElseIf s = 45 Then
                        b2 = "♧6"
                    ElseIf s = 46 Then
                        b2 = "♧7"
                    ElseIf s = 47 Then
                        b2 = "♧8"
                    ElseIf s = 48 Then
                        b2 = "♧9"
                    ElseIf s = 49 Then
                        b2 = "♧10"
                    ElseIf s = 50 Then
                        b2 = "♧11"
                    ElseIf s = 51 Then
                        b2 = "♧12"
                    ElseIf s = 52 Then
                        b2 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 3 And b3 = "" Then
                    If s = 1 Then
                        b3 = "♥1"
                    ElseIf s = 2 Then
                        b3 = "♥2"
                    ElseIf s = 3 Then
                        b3 = "♥3"
                    ElseIf s = 3 Then
                        b3 = "♥3"
                    ElseIf s = 4 Then
                        b3 = "♥4"
                    ElseIf s = 4 Then
                        b3 = "♥4"
                    ElseIf s = 5 Then
                        b3 = "♥5"
                    ElseIf s = 5 Then
                        b3 = "♥5"
                    ElseIf s = 6 Then
                        b3 = "♥6"
                    ElseIf s = 6 Then
                        b3 = "♥6"
                    ElseIf s = 7 Then
                        b3 = "♥7"
                    ElseIf s = 7 Then
                        b3 = "♥7"
                    ElseIf s = 8 Then
                        b3 = "♥8"
                    ElseIf s = 8 Then
                        b3 = "♥8"
                    ElseIf s = 9 Then
                        b3 = "♥9"
                    ElseIf s = 9 Then
                        b3 = "♥9"
                    ElseIf s = 10 Then
                        b3 = "♥10"
                    ElseIf s = 10 Then
                        b3 = "♥10"
                    ElseIf s = 11 Then
                        b3 = "♥11"
                    ElseIf s = 11 Then
                        b3 = "♥11"
                    ElseIf s = 12 Then
                        b3 = "♥12"
                    ElseIf s = 12 Then
                        b3 = "♥12"
                    ElseIf s = 13 Then
                        b3 = "♥13"
                    ElseIf s = 13 Then
                        b3 = "♥13"
                    ElseIf s = 14 Then
                        b3 = "♦1"
                    ElseIf s = 15 Then
                        b3 = "♦2"
                    ElseIf s = 16 Then
                        b3 = "♦3"
                    ElseIf s = 17 Then
                        b3 = "♦4"
                    ElseIf s = 18 Then
                        b3 = "♦5"
                    ElseIf s = 19 Then
                        b3 = "♦6"
                    ElseIf s = 20 Then
                        b3 = "♦7"
                    ElseIf s = 21 Then
                        b3 = "♦8"
                    ElseIf s = 22 Then
                        b3 = "♦9"
                    ElseIf s = 23 Then
                        b3 = "♦10"
                    ElseIf s = 24 Then
                        b3 = "♦11"
                    ElseIf s = 25 Then
                        b3 = "♦12"
                    ElseIf s = 26 Then
                        b3 = "♦13"
                    ElseIf s = 27 Then
                        b3 = "♤1"
                    ElseIf s = 28 Then
                        b3 = "♤2"
                    ElseIf s = 29 Then
                        b3 = "♤3"
                    ElseIf s = 30 Then
                        b3 = "♤4"
                    ElseIf s = 31 Then
                        b3 = "♤5"
                    ElseIf s = 32 Then
                        b3 = "♤6"
                    ElseIf s = 33 Then
                        b3 = "♤7"
                    ElseIf s = 34 Then
                        b3 = "♤8"
                    ElseIf s = 35 Then
                        b3 = "♤9"
                    ElseIf s = 36 Then
                        b3 = "♤10"
                    ElseIf s = 37 Then
                        b3 = "♤11"
                    ElseIf s = 38 Then
                        b3 = "♤12"
                    ElseIf s = 39 Then
                        b3 = "♤13"
                    ElseIf s = 40 Then
                        b3 = "♧1"
                    ElseIf s = 41 Then
                        b3 = "♧2"
                    ElseIf s = 42 Then
                        b3 = "♧3"
                    ElseIf s = 43 Then
                        b3 = "♧4"
                    ElseIf s = 44 Then
                        b3 = "♧5"
                    ElseIf s = 45 Then
                        b3 = "♧6"
                    ElseIf s = 46 Then
                        b3 = "♧7"
                    ElseIf s = 47 Then
                        b3 = "♧8"
                    ElseIf s = 48 Then
                        b3 = "♧9"
                    ElseIf s = 49 Then
                        b3 = "♧10"
                    ElseIf s = 50 Then
                        b3 = "♧11"
                    ElseIf s = 51 Then
                        b3 = "♧12"
                    ElseIf s = 52 Then
                        b3 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 4 And b4 = "" Then
                    If s = 1 Then
                        b4 = "♥1"
                    ElseIf s = 2 Then
                        b4 = "♥2"
                    ElseIf s = 3 Then
                        b4 = "♥3"
                    ElseIf s = 3 Then
                        b4 = "♥3"
                    ElseIf s = 4 Then
                        b4 = "♥4"
                    ElseIf s = 4 Then
                        b4 = "♥4"
                    ElseIf s = 5 Then
                        b4 = "♥5"
                    ElseIf s = 5 Then
                        b4 = "♥5"
                    ElseIf s = 6 Then
                        b4 = "♥6"
                    ElseIf s = 6 Then
                        b4 = "♥6"
                    ElseIf s = 7 Then
                        b4 = "♥7"
                    ElseIf s = 7 Then
                        b4 = "♥7"
                    ElseIf s = 8 Then
                        b4 = "♥8"
                    ElseIf s = 8 Then
                        b4 = "♥8"
                    ElseIf s = 9 Then
                        b4 = "♥9"
                    ElseIf s = 9 Then
                        b4 = "♥9"
                    ElseIf s = 10 Then
                        b4 = "♥10"
                    ElseIf s = 10 Then
                        b4 = "♥10"
                    ElseIf s = 11 Then
                        b4 = "♥11"
                    ElseIf s = 11 Then
                        b4 = "♥11"
                    ElseIf s = 12 Then
                        b4 = "♥12"
                    ElseIf s = 12 Then
                        b4 = "♥12"
                    ElseIf s = 13 Then
                        b4 = "♥13"
                    ElseIf s = 13 Then
                        b4 = "♥13"
                    ElseIf s = 14 Then
                        b4 = "♦1"
                    ElseIf s = 15 Then
                        b4 = "♦2"
                    ElseIf s = 16 Then
                        b4 = "♦3"
                    ElseIf s = 17 Then
                        b4 = "♦4"
                    ElseIf s = 18 Then
                        b4 = "♦5"
                    ElseIf s = 19 Then
                        b4 = "♦6"
                    ElseIf s = 20 Then
                        b4 = "♦7"
                    ElseIf s = 21 Then
                        b4 = "♦8"
                    ElseIf s = 22 Then
                        b4 = "♦9"
                    ElseIf s = 23 Then
                        b4 = "♦10"
                    ElseIf s = 24 Then
                        b4 = "♦11"
                    ElseIf s = 25 Then
                        b4 = "♦12"
                    ElseIf s = 26 Then
                        b4 = "♦13"
                    ElseIf s = 27 Then
                        b4 = "♤1"
                    ElseIf s = 28 Then
                        b4 = "♤2"
                    ElseIf s = 29 Then
                        b4 = "♤3"
                    ElseIf s = 30 Then
                        b4 = "♤4"
                    ElseIf s = 31 Then
                        b4 = "♤5"
                    ElseIf s = 32 Then
                        b4 = "♤6"
                    ElseIf s = 33 Then
                        b4 = "♤7"
                    ElseIf s = 34 Then
                        b4 = "♤8"
                    ElseIf s = 35 Then
                        b4 = "♤9"
                    ElseIf s = 36 Then
                        b4 = "♤10"
                    ElseIf s = 37 Then
                        b4 = "♤11"
                    ElseIf s = 38 Then
                        b4 = "♤12"
                    ElseIf s = 39 Then
                        b4 = "♤13"
                    ElseIf s = 40 Then
                        b4 = "♧1"
                    ElseIf s = 41 Then
                        b4 = "♧2"
                    ElseIf s = 42 Then
                        b4 = "♧3"
                    ElseIf s = 43 Then
                        b4 = "♧4"
                    ElseIf s = 44 Then
                        b4 = "♧5"
                    ElseIf s = 45 Then
                        b4 = "♧6"
                    ElseIf s = 46 Then
                        b4 = "♧7"
                    ElseIf s = 47 Then
                        b4 = "♧8"
                    ElseIf s = 48 Then
                        b4 = "♧9"
                    ElseIf s = 49 Then
                        b4 = "♧10"
                    ElseIf s = 50 Then
                        b4 = "♧11"
                    ElseIf s = 51 Then
                        b4 = "♧12"
                    ElseIf s = 52 Then
                        b4 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 5 And b5 = "" Then
                    If s = 1 Then
                        b5 = "♥1"
                    ElseIf s = 2 Then
                        b5 = "♥2"
                    ElseIf s = 3 Then
                        b5 = "♥3"
                    ElseIf s = 3 Then
                        b5 = "♥3"
                    ElseIf s = 4 Then
                        b5 = "♥4"
                    ElseIf s = 4 Then
                        b5 = "♥4"
                    ElseIf s = 5 Then
                        b5 = "♥5"
                    ElseIf s = 5 Then
                        b5 = "♥5"
                    ElseIf s = 6 Then
                        b5 = "♥6"
                    ElseIf s = 6 Then
                        b5 = "♥6"
                    ElseIf s = 7 Then
                        b5 = "♥7"
                    ElseIf s = 7 Then
                        b5 = "♥7"
                    ElseIf s = 8 Then
                        b5 = "♥8"
                    ElseIf s = 8 Then
                        b5 = "♥8"
                    ElseIf s = 9 Then
                        b5 = "♥9"
                    ElseIf s = 9 Then
                        b5 = "♥9"
                    ElseIf s = 10 Then
                        b5 = "♥10"
                    ElseIf s = 10 Then
                        b5 = "♥10"
                    ElseIf s = 11 Then
                        b5 = "♥11"
                    ElseIf s = 11 Then
                        b5 = "♥11"
                    ElseIf s = 12 Then
                        b5 = "♥12"
                    ElseIf s = 12 Then
                        b5 = "♥12"
                    ElseIf s = 13 Then
                        b5 = "♥13"
                    ElseIf s = 13 Then
                        b5 = "♥13"
                    ElseIf s = 14 Then
                        b5 = "♦1"
                    ElseIf s = 15 Then
                        b5 = "♦2"
                    ElseIf s = 16 Then
                        b5 = "♦3"
                    ElseIf s = 17 Then
                        b5 = "♦4"
                    ElseIf s = 18 Then
                        b5 = "♦5"
                    ElseIf s = 19 Then
                        b5 = "♦6"
                    ElseIf s = 20 Then
                        b5 = "♦7"
                    ElseIf s = 21 Then
                        b5 = "♦8"
                    ElseIf s = 22 Then
                        b5 = "♦9"
                    ElseIf s = 23 Then
                        b5 = "♦10"
                    ElseIf s = 24 Then
                        b5 = "♦11"
                    ElseIf s = 25 Then
                        b5 = "♦12"
                    ElseIf s = 26 Then
                        b5 = "♦13"
                    ElseIf s = 27 Then
                        b5 = "♤1"
                    ElseIf s = 28 Then
                        b5 = "♤2"
                    ElseIf s = 29 Then
                        b5 = "♤3"
                    ElseIf s = 30 Then
                        b5 = "♤4"
                    ElseIf s = 31 Then
                        b5 = "♤5"
                    ElseIf s = 32 Then
                        b5 = "♤6"
                    ElseIf s = 33 Then
                        b5 = "♤7"
                    ElseIf s = 34 Then
                        b5 = "♤8"
                    ElseIf s = 35 Then
                        b5 = "♤9"
                    ElseIf s = 36 Then
                        b5 = "♤10"
                    ElseIf s = 37 Then
                        b5 = "♤11"
                    ElseIf s = 38 Then
                        b5 = "♤12"
                    ElseIf s = 39 Then
                        b5 = "♤13"
                    ElseIf s = 40 Then
                        b5 = "♧1"
                    ElseIf s = 41 Then
                        b5 = "♧2"
                    ElseIf s = 42 Then
                        b5 = "♧3"
                    ElseIf s = 43 Then
                        b5 = "♧4"
                    ElseIf s = 44 Then
                        b5 = "♧5"
                    ElseIf s = 45 Then
                        b5 = "♧6"
                    ElseIf s = 46 Then
                        b5 = "♧7"
                    ElseIf s = 47 Then
                        b5 = "♧8"
                    ElseIf s = 48 Then
                        b5 = "♧9"
                    ElseIf s = 49 Then
                        b5 = "♧10"
                    ElseIf s = 50 Then
                        b5 = "♧11"
                    ElseIf s = 51 Then
                        b5 = "♧12"
                    ElseIf s = 52 Then
                        b5 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 6 And b6 = "" Then
                    If s = 1 Then
                        b6 = "♥1"
                    ElseIf s = 2 Then
                        b6 = "♥2"
                    ElseIf s = 3 Then
                        b6 = "♥3"
                    ElseIf s = 3 Then
                        b6 = "♥3"
                    ElseIf s = 4 Then
                        b6 = "♥4"
                    ElseIf s = 4 Then
                        b6 = "♥4"
                    ElseIf s = 5 Then
                        b6 = "♥5"
                    ElseIf s = 5 Then
                        b6 = "♥5"
                    ElseIf s = 6 Then
                        b6 = "♥6"
                    ElseIf s = 6 Then
                        b6 = "♥6"
                    ElseIf s = 7 Then
                        b6 = "♥7"
                    ElseIf s = 7 Then
                        b6 = "♥7"
                    ElseIf s = 8 Then
                        b6 = "♥8"
                    ElseIf s = 8 Then
                        b6 = "♥8"
                    ElseIf s = 9 Then
                        b6 = "♥9"
                    ElseIf s = 9 Then
                        b6 = "♥9"
                    ElseIf s = 10 Then
                        b6 = "♥10"
                    ElseIf s = 10 Then
                        b6 = "♥10"
                    ElseIf s = 11 Then
                        b6 = "♥11"
                    ElseIf s = 11 Then
                        b6 = "♥11"
                    ElseIf s = 12 Then
                        b6 = "♥12"
                    ElseIf s = 12 Then
                        b6 = "♥12"
                    ElseIf s = 13 Then
                        b6 = "♥13"
                    ElseIf s = 13 Then
                        b6 = "♥13"
                    ElseIf s = 14 Then
                        b6 = "♦1"
                    ElseIf s = 15 Then
                        b6 = "♦2"
                    ElseIf s = 16 Then
                        b6 = "♦3"
                    ElseIf s = 17 Then
                        b6 = "♦4"
                    ElseIf s = 18 Then
                        b6 = "♦5"
                    ElseIf s = 19 Then
                        b6 = "♦6"
                    ElseIf s = 20 Then
                        b6 = "♦7"
                    ElseIf s = 21 Then
                        b6 = "♦8"
                    ElseIf s = 22 Then
                        b6 = "♦9"
                    ElseIf s = 23 Then
                        b6 = "♦10"
                    ElseIf s = 24 Then
                        b6 = "♦11"
                    ElseIf s = 25 Then
                        b6 = "♦12"
                    ElseIf s = 26 Then
                        b6 = "♦13"
                    ElseIf s = 27 Then
                        b6 = "♤1"
                    ElseIf s = 28 Then
                        b6 = "♤2"
                    ElseIf s = 29 Then
                        b6 = "♤3"
                    ElseIf s = 30 Then
                        b6 = "♤4"
                    ElseIf s = 31 Then
                        b6 = "♤5"
                    ElseIf s = 32 Then
                        b6 = "♤6"
                    ElseIf s = 33 Then
                        b6 = "♤7"
                    ElseIf s = 34 Then
                        b6 = "♤8"
                    ElseIf s = 35 Then
                        b6 = "♤9"
                    ElseIf s = 36 Then
                        b6 = "♤10"
                    ElseIf s = 37 Then
                        b6 = "♤11"
                    ElseIf s = 38 Then
                        b6 = "♤12"
                    ElseIf s = 39 Then
                        b6 = "♤13"
                    ElseIf s = 40 Then
                        b6 = "♧1"
                    ElseIf s = 41 Then
                        b6 = "♧2"
                    ElseIf s = 42 Then
                        b6 = "♧3"
                    ElseIf s = 43 Then
                        b6 = "♧4"
                    ElseIf s = 44 Then
                        b6 = "♧5"
                    ElseIf s = 45 Then
                        b6 = "♧6"
                    ElseIf s = 46 Then
                        b6 = "♧7"
                    ElseIf s = 47 Then
                        b6 = "♧8"
                    ElseIf s = 48 Then
                        b6 = "♧9"
                    ElseIf s = 49 Then
                        b6 = "♧10"
                    ElseIf s = 50 Then
                        b6 = "♧11"
                    ElseIf s = 51 Then
                        b6 = "♧12"
                    ElseIf s = 52 Then
                        b6 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 7 And b7 = "" Then
                    If s = 1 Then
                        b7 = "♥1"
                    ElseIf s = 2 Then
                        b7 = "♥2"
                    ElseIf s = 3 Then
                        b7 = "♥3"
                    ElseIf s = 3 Then
                        b7 = "♥3"
                    ElseIf s = 4 Then
                        b7 = "♥4"
                    ElseIf s = 4 Then
                        b7 = "♥4"
                    ElseIf s = 5 Then
                        b7 = "♥5"
                    ElseIf s = 5 Then
                        b7 = "♥5"
                    ElseIf s = 6 Then
                        b7 = "♥6"
                    ElseIf s = 6 Then
                        b7 = "♥6"
                    ElseIf s = 7 Then
                        b7 = "♥7"
                    ElseIf s = 7 Then
                        b7 = "♥7"
                    ElseIf s = 8 Then
                        b7 = "♥8"
                    ElseIf s = 8 Then
                        b7 = "♥8"
                    ElseIf s = 9 Then
                        b7 = "♥9"
                    ElseIf s = 9 Then
                        b7 = "♥9"
                    ElseIf s = 10 Then
                        b7 = "♥10"
                    ElseIf s = 10 Then
                        b7 = "♥10"
                    ElseIf s = 11 Then
                        b7 = "♥11"
                    ElseIf s = 11 Then
                        b7 = "♥11"
                    ElseIf s = 12 Then
                        b7 = "♥12"
                    ElseIf s = 12 Then
                        b7 = "♥12"
                    ElseIf s = 13 Then
                        b7 = "♥13"
                    ElseIf s = 13 Then
                        b7 = "♥13"
                    ElseIf s = 14 Then
                        b7 = "♦1"
                    ElseIf s = 15 Then
                        b7 = "♦2"
                    ElseIf s = 16 Then
                        b7 = "♦3"
                    ElseIf s = 17 Then
                        b7 = "♦4"
                    ElseIf s = 18 Then
                        b7 = "♦5"
                    ElseIf s = 19 Then
                        b7 = "♦6"
                    ElseIf s = 20 Then
                        b7 = "♦7"
                    ElseIf s = 21 Then
                        b7 = "♦8"
                    ElseIf s = 22 Then
                        b7 = "♦9"
                    ElseIf s = 23 Then
                        b7 = "♦10"
                    ElseIf s = 24 Then
                        b7 = "♦11"
                    ElseIf s = 25 Then
                        b7 = "♦12"
                    ElseIf s = 26 Then
                        b7 = "♦13"
                    ElseIf s = 27 Then
                        b7 = "♤1"
                    ElseIf s = 28 Then
                        b7 = "♤2"
                    ElseIf s = 29 Then
                        b7 = "♤3"
                    ElseIf s = 30 Then
                        b7 = "♤4"
                    ElseIf s = 31 Then
                        b7 = "♤5"
                    ElseIf s = 32 Then
                        b7 = "♤6"
                    ElseIf s = 33 Then
                        b7 = "♤7"
                    ElseIf s = 34 Then
                        b7 = "♤8"
                    ElseIf s = 35 Then
                        b7 = "♤9"
                    ElseIf s = 36 Then
                        b7 = "♤10"
                    ElseIf s = 37 Then
                        b7 = "♤11"
                    ElseIf s = 38 Then
                        b7 = "♤12"
                    ElseIf s = 39 Then
                        b7 = "♤13"
                    ElseIf s = 40 Then
                        b7 = "♧1"
                    ElseIf s = 41 Then
                        b7 = "♧2"
                    ElseIf s = 42 Then
                        b7 = "♧3"
                    ElseIf s = 43 Then
                        b7 = "♧4"
                    ElseIf s = 44 Then
                        b7 = "♧5"
                    ElseIf s = 45 Then
                        b7 = "♧6"
                    ElseIf s = 46 Then
                        b7 = "♧7"
                    ElseIf s = 47 Then
                        b7 = "♧8"
                    ElseIf s = 48 Then
                        b7 = "♧9"
                    ElseIf s = 49 Then
                        b7 = "♧10"
                    ElseIf s = 50 Then
                        b7 = "♧11"
                    ElseIf s = 51 Then
                        b7 = "♧12"
                    ElseIf s = 52 Then
                        b7 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 8 And b8 = "" Then
                    If s = 1 Then
                        b8 = "♥1"
                    ElseIf s = 2 Then
                        b8 = "♥2"
                    ElseIf s = 3 Then
                        b8 = "♥3"
                    ElseIf s = 3 Then
                        b8 = "♥3"
                    ElseIf s = 4 Then
                        b8 = "♥4"
                    ElseIf s = 4 Then
                        b8 = "♥4"
                    ElseIf s = 5 Then
                        b8 = "♥5"
                    ElseIf s = 5 Then
                        b8 = "♥5"
                    ElseIf s = 6 Then
                        b8 = "♥6"
                    ElseIf s = 6 Then
                        b8 = "♥6"
                    ElseIf s = 7 Then
                        b8 = "♥7"
                    ElseIf s = 7 Then
                        b8 = "♥7"
                    ElseIf s = 8 Then
                        b8 = "♥8"
                    ElseIf s = 8 Then
                        b8 = "♥8"
                    ElseIf s = 9 Then
                        b8 = "♥9"
                    ElseIf s = 9 Then
                        b8 = "♥9"
                    ElseIf s = 10 Then
                        b8 = "♥10"
                    ElseIf s = 10 Then
                        b8 = "♥10"
                    ElseIf s = 11 Then
                        b8 = "♥11"
                    ElseIf s = 11 Then
                        b8 = "♥11"
                    ElseIf s = 12 Then
                        b8 = "♥12"
                    ElseIf s = 12 Then
                        b8 = "♥12"
                    ElseIf s = 13 Then
                        b8 = "♥13"
                    ElseIf s = 13 Then
                        b8 = "♥13"
                    ElseIf s = 14 Then
                        b8 = "♦1"
                    ElseIf s = 15 Then
                        b8 = "♦2"
                    ElseIf s = 16 Then
                        b8 = "♦3"
                    ElseIf s = 17 Then
                        b8 = "♦4"
                    ElseIf s = 18 Then
                        b8 = "♦5"
                    ElseIf s = 19 Then
                        b8 = "♦6"
                    ElseIf s = 20 Then
                        b8 = "♦7"
                    ElseIf s = 21 Then
                        b8 = "♦8"
                    ElseIf s = 22 Then
                        b8 = "♦9"
                    ElseIf s = 23 Then
                        b8 = "♦10"
                    ElseIf s = 24 Then
                        b8 = "♦11"
                    ElseIf s = 25 Then
                        b8 = "♦12"
                    ElseIf s = 26 Then
                        b8 = "♦13"
                    ElseIf s = 27 Then
                        b8 = "♤1"
                    ElseIf s = 28 Then
                        b8 = "♤2"
                    ElseIf s = 29 Then
                        b8 = "♤3"
                    ElseIf s = 30 Then
                        b8 = "♤4"
                    ElseIf s = 31 Then
                        b8 = "♤5"
                    ElseIf s = 32 Then
                        b8 = "♤6"
                    ElseIf s = 33 Then
                        b8 = "♤7"
                    ElseIf s = 34 Then
                        b8 = "♤8"
                    ElseIf s = 35 Then
                        b8 = "♤9"
                    ElseIf s = 36 Then
                        b8 = "♤10"
                    ElseIf s = 37 Then
                        b8 = "♤11"
                    ElseIf s = 38 Then
                        b8 = "♤12"
                    ElseIf s = 39 Then
                        b8 = "♤13"
                    ElseIf s = 40 Then
                        b8 = "♧1"
                    ElseIf s = 41 Then
                        b8 = "♧2"
                    ElseIf s = 42 Then
                        b8 = "♧3"
                    ElseIf s = 43 Then
                        b8 = "♧4"
                    ElseIf s = 44 Then
                        b8 = "♧5"
                    ElseIf s = 45 Then
                        b8 = "♧6"
                    ElseIf s = 46 Then
                        b8 = "♧7"
                    ElseIf s = 47 Then
                        b8 = "♧8"
                    ElseIf s = 48 Then
                        b8 = "♧9"
                    ElseIf s = 49 Then
                        b8 = "♧10"
                    ElseIf s = 50 Then
                        b8 = "♧11"
                    ElseIf s = 51 Then
                        b8 = "♧12"
                    ElseIf s = 52 Then
                        b8 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 9 And b9 = "" Then
                    If s = 1 Then
                        b9 = "♥1"
                    ElseIf s = 2 Then
                        b9 = "♥2"
                    ElseIf s = 3 Then
                        b9 = "♥3"
                    ElseIf s = 3 Then
                        b9 = "♥3"
                    ElseIf s = 4 Then
                        b9 = "♥4"
                    ElseIf s = 4 Then
                        b9 = "♥4"
                    ElseIf s = 5 Then
                        b9 = "♥5"
                    ElseIf s = 5 Then
                        b9 = "♥5"
                    ElseIf s = 6 Then
                        b9 = "♥6"
                    ElseIf s = 6 Then
                        b9 = "♥6"
                    ElseIf s = 7 Then
                        b9 = "♥7"
                    ElseIf s = 7 Then
                        b9 = "♥7"
                    ElseIf s = 8 Then
                        b9 = "♥8"
                    ElseIf s = 8 Then
                        b9 = "♥8"
                    ElseIf s = 9 Then
                        b9 = "♥9"
                    ElseIf s = 9 Then
                        b9 = "♥9"
                    ElseIf s = 10 Then
                        b9 = "♥10"
                    ElseIf s = 10 Then
                        b9 = "♥10"
                    ElseIf s = 11 Then
                        b9 = "♥11"
                    ElseIf s = 11 Then
                        b9 = "♥11"
                    ElseIf s = 12 Then
                        b9 = "♥12"
                    ElseIf s = 12 Then
                        b9 = "♥12"
                    ElseIf s = 13 Then
                        b9 = "♥13"
                    ElseIf s = 13 Then
                        b9 = "♥13"
                    ElseIf s = 14 Then
                        b9 = "♦1"
                    ElseIf s = 15 Then
                        b9 = "♦2"
                    ElseIf s = 16 Then
                        b9 = "♦3"
                    ElseIf s = 17 Then
                        b9 = "♦4"
                    ElseIf s = 18 Then
                        b9 = "♦5"
                    ElseIf s = 19 Then
                        b9 = "♦6"
                    ElseIf s = 20 Then
                        b9 = "♦7"
                    ElseIf s = 21 Then
                        b9 = "♦8"
                    ElseIf s = 22 Then
                        b9 = "♦9"
                    ElseIf s = 23 Then
                        b9 = "♦10"
                    ElseIf s = 24 Then
                        b9 = "♦11"
                    ElseIf s = 25 Then
                        b9 = "♦12"
                    ElseIf s = 26 Then
                        b9 = "♦13"
                    ElseIf s = 27 Then
                        b9 = "♤1"
                    ElseIf s = 28 Then
                        b9 = "♤2"
                    ElseIf s = 29 Then
                        b9 = "♤3"
                    ElseIf s = 30 Then
                        b9 = "♤4"
                    ElseIf s = 31 Then
                        b9 = "♤5"
                    ElseIf s = 32 Then
                        b9 = "♤6"
                    ElseIf s = 33 Then
                        b9 = "♤7"
                    ElseIf s = 34 Then
                        b9 = "♤8"
                    ElseIf s = 35 Then
                        b9 = "♤9"
                    ElseIf s = 36 Then
                        b9 = "♤10"
                    ElseIf s = 37 Then
                        b9 = "♤11"
                    ElseIf s = 38 Then
                        b9 = "♤12"
                    ElseIf s = 39 Then
                        b9 = "♤13"
                    ElseIf s = 40 Then
                        b9 = "♧1"
                    ElseIf s = 41 Then
                        b9 = "♧2"
                    ElseIf s = 42 Then
                        b9 = "♧3"
                    ElseIf s = 43 Then
                        b9 = "♧4"
                    ElseIf s = 44 Then
                        b9 = "♧5"
                    ElseIf s = 45 Then
                        b9 = "♧6"
                    ElseIf s = 46 Then
                        b9 = "♧7"
                    ElseIf s = 47 Then
                        b9 = "♧8"
                    ElseIf s = 48 Then
                        b9 = "♧9"
                    ElseIf s = 49 Then
                        b9 = "♧10"
                    ElseIf s = 50 Then
                        b9 = "♧11"
                    ElseIf s = 51 Then
                        b9 = "♧12"
                    ElseIf s = 52 Then
                        b9 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 10 And b10 = "" Then
                    If s = 1 Then
                        b10 = "♥1"
                    ElseIf s = 2 Then
                        b10 = "♥2"
                    ElseIf s = 3 Then
                        b10 = "♥3"
                    ElseIf s = 3 Then
                        b10 = "♥3"
                    ElseIf s = 4 Then
                        b10 = "♥4"
                    ElseIf s = 4 Then
                        b10 = "♥4"
                    ElseIf s = 5 Then
                        b10 = "♥5"
                    ElseIf s = 5 Then
                        b10 = "♥5"
                    ElseIf s = 6 Then
                        b10 = "♥6"
                    ElseIf s = 6 Then
                        b10 = "♥6"
                    ElseIf s = 7 Then
                        b10 = "♥7"
                    ElseIf s = 7 Then
                        b10 = "♥7"
                    ElseIf s = 8 Then
                        b10 = "♥8"
                    ElseIf s = 8 Then
                        b10 = "♥8"
                    ElseIf s = 9 Then
                        b10 = "♥9"
                    ElseIf s = 9 Then
                        b10 = "♥9"
                    ElseIf s = 10 Then
                        b10 = "♥10"
                    ElseIf s = 10 Then
                        b10 = "♥10"
                    ElseIf s = 11 Then
                        b10 = "♥11"
                    ElseIf s = 11 Then
                        b10 = "♥11"
                    ElseIf s = 12 Then
                        b10 = "♥12"
                    ElseIf s = 12 Then
                        b10 = "♥12"
                    ElseIf s = 13 Then
                        b10 = "♥13"
                    ElseIf s = 13 Then
                        b10 = "♥13"
                    ElseIf s = 14 Then
                        b10 = "♦1"
                    ElseIf s = 15 Then
                        b10 = "♦2"
                    ElseIf s = 16 Then
                        b10 = "♦3"
                    ElseIf s = 17 Then
                        b10 = "♦4"
                    ElseIf s = 18 Then
                        b10 = "♦5"
                    ElseIf s = 19 Then
                        b10 = "♦6"
                    ElseIf s = 20 Then
                        b10 = "♦7"
                    ElseIf s = 21 Then
                        b10 = "♦8"
                    ElseIf s = 22 Then
                        b10 = "♦9"
                    ElseIf s = 23 Then
                        b10 = "♦10"
                    ElseIf s = 24 Then
                        b10 = "♦11"
                    ElseIf s = 25 Then
                        b10 = "♦12"
                    ElseIf s = 26 Then
                        b10 = "♦13"
                    ElseIf s = 27 Then
                        b10 = "♤1"
                    ElseIf s = 28 Then
                        b10 = "♤2"
                    ElseIf s = 29 Then
                        b10 = "♤3"
                    ElseIf s = 30 Then
                        b10 = "♤4"
                    ElseIf s = 31 Then
                        b10 = "♤5"
                    ElseIf s = 32 Then
                        b10 = "♤6"
                    ElseIf s = 33 Then
                        b10 = "♤7"
                    ElseIf s = 34 Then
                        b10 = "♤8"
                    ElseIf s = 35 Then
                        b10 = "♤9"
                    ElseIf s = 36 Then
                        b10 = "♤10"
                    ElseIf s = 37 Then
                        b10 = "♤11"
                    ElseIf s = 38 Then
                        b10 = "♤12"
                    ElseIf s = 39 Then
                        b10 = "♤13"
                    ElseIf s = 40 Then
                        b10 = "♧1"
                    ElseIf s = 41 Then
                        b10 = "♧2"
                    ElseIf s = 42 Then
                        b10 = "♧3"
                    ElseIf s = 43 Then
                        b10 = "♧4"
                    ElseIf s = 44 Then
                        b10 = "♧5"
                    ElseIf s = 45 Then
                        b10 = "♧6"
                    ElseIf s = 46 Then
                        b10 = "♧7"
                    ElseIf s = 47 Then
                        b10 = "♧8"
                    ElseIf s = 48 Then
                        b10 = "♧9"
                    ElseIf s = 49 Then
                        b10 = "♧10"
                    ElseIf s = 50 Then
                        b10 = "♧11"
                    ElseIf s = 51 Then
                        b10 = "♧12"
                    ElseIf s = 52 Then
                        b10 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 11 And b11 = "" Then
                    If s = 1 Then
                        b11 = "♥1"
                    ElseIf s = 2 Then
                        b11 = "♥2"
                    ElseIf s = 3 Then
                        b11 = "♥3"
                    ElseIf s = 3 Then
                        b11 = "♥3"
                    ElseIf s = 4 Then
                        b11 = "♥4"
                    ElseIf s = 4 Then
                        b11 = "♥4"
                    ElseIf s = 5 Then
                        b11 = "♥5"
                    ElseIf s = 5 Then
                        b11 = "♥5"
                    ElseIf s = 6 Then
                        b11 = "♥6"
                    ElseIf s = 6 Then
                        b11 = "♥6"
                    ElseIf s = 7 Then
                        b11 = "♥7"
                    ElseIf s = 7 Then
                        b11 = "♥7"
                    ElseIf s = 8 Then
                        b11 = "♥8"
                    ElseIf s = 8 Then
                        b11 = "♥8"
                    ElseIf s = 9 Then
                        b11 = "♥9"
                    ElseIf s = 9 Then
                        b11 = "♥9"
                    ElseIf s = 10 Then
                        b11 = "♥10"
                    ElseIf s = 10 Then
                        b11 = "♥10"
                    ElseIf s = 11 Then
                        b11 = "♥11"
                    ElseIf s = 11 Then
                        b11 = "♥11"
                    ElseIf s = 12 Then
                        b11 = "♥12"
                    ElseIf s = 12 Then
                        b11 = "♥12"
                    ElseIf s = 13 Then
                        b11 = "♥13"
                    ElseIf s = 13 Then
                        b11 = "♥13"
                    ElseIf s = 14 Then
                        b11 = "♦1"
                    ElseIf s = 15 Then
                        b11 = "♦2"
                    ElseIf s = 16 Then
                        b11 = "♦3"
                    ElseIf s = 17 Then
                        b11 = "♦4"
                    ElseIf s = 18 Then
                        b11 = "♦5"
                    ElseIf s = 19 Then
                        b11 = "♦6"
                    ElseIf s = 20 Then
                        b11 = "♦7"
                    ElseIf s = 21 Then
                        b11 = "♦8"
                    ElseIf s = 22 Then
                        b11 = "♦9"
                    ElseIf s = 23 Then
                        b11 = "♦10"
                    ElseIf s = 24 Then
                        b11 = "♦11"
                    ElseIf s = 25 Then
                        b11 = "♦12"
                    ElseIf s = 26 Then
                        b11 = "♦13"
                    ElseIf s = 27 Then
                        b11 = "♤1"
                    ElseIf s = 28 Then
                        b11 = "♤2"
                    ElseIf s = 29 Then
                        b11 = "♤3"
                    ElseIf s = 30 Then
                        b11 = "♤4"
                    ElseIf s = 31 Then
                        b11 = "♤5"
                    ElseIf s = 32 Then
                        b11 = "♤6"
                    ElseIf s = 33 Then
                        b11 = "♤7"
                    ElseIf s = 34 Then
                        b11 = "♤8"
                    ElseIf s = 35 Then
                        b11 = "♤9"
                    ElseIf s = 36 Then
                        b11 = "♤10"
                    ElseIf s = 37 Then
                        b11 = "♤11"
                    ElseIf s = 38 Then
                        b11 = "♤12"
                    ElseIf s = 39 Then
                        b11 = "♤13"
                    ElseIf s = 40 Then
                        b11 = "♧1"
                    ElseIf s = 41 Then
                        b11 = "♧2"
                    ElseIf s = 42 Then
                        b11 = "♧3"
                    ElseIf s = 43 Then
                        b11 = "♧4"
                    ElseIf s = 44 Then
                        b11 = "♧5"
                    ElseIf s = 45 Then
                        b11 = "♧6"
                    ElseIf s = 46 Then
                        b11 = "♧7"
                    ElseIf s = 47 Then
                        b11 = "♧8"
                    ElseIf s = 48 Then
                        b11 = "♧9"
                    ElseIf s = 49 Then
                        b11 = "♧10"
                    ElseIf s = 50 Then
                        b11 = "♧11"
                    ElseIf s = 51 Then
                        b11 = "♧12"
                    ElseIf s = 52 Then
                        b11 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 12 And b12 = "" Then
                    If s = 1 Then
                        b12 = "♥1"
                    ElseIf s = 2 Then
                        b12 = "♥2"
                    ElseIf s = 3 Then
                        b12 = "♥3"
                    ElseIf s = 3 Then
                        b12 = "♥3"
                    ElseIf s = 4 Then
                        b12 = "♥4"
                    ElseIf s = 4 Then
                        b12 = "♥4"
                    ElseIf s = 5 Then
                        b12 = "♥5"
                    ElseIf s = 5 Then
                        b12 = "♥5"
                    ElseIf s = 6 Then
                        b12 = "♥6"
                    ElseIf s = 6 Then
                        b12 = "♥6"
                    ElseIf s = 7 Then
                        b12 = "♥7"
                    ElseIf s = 7 Then
                        b12 = "♥7"
                    ElseIf s = 8 Then
                        b12 = "♥8"
                    ElseIf s = 8 Then
                        b12 = "♥8"
                    ElseIf s = 9 Then
                        b12 = "♥9"
                    ElseIf s = 9 Then
                        b12 = "♥9"
                    ElseIf s = 10 Then
                        b12 = "♥10"
                    ElseIf s = 10 Then
                        b12 = "♥10"
                    ElseIf s = 11 Then
                        b12 = "♥11"
                    ElseIf s = 11 Then
                        b12 = "♥11"
                    ElseIf s = 12 Then
                        b12 = "♥12"
                    ElseIf s = 12 Then
                        b12 = "♥12"
                    ElseIf s = 13 Then
                        b12 = "♥13"
                    ElseIf s = 13 Then
                        b12 = "♥13"
                    ElseIf s = 14 Then
                        b12 = "♦1"
                    ElseIf s = 15 Then
                        b12 = "♦2"
                    ElseIf s = 16 Then
                        b12 = "♦3"
                    ElseIf s = 17 Then
                        b12 = "♦4"
                    ElseIf s = 18 Then
                        b12 = "♦5"
                    ElseIf s = 19 Then
                        b12 = "♦6"
                    ElseIf s = 20 Then
                        b12 = "♦7"
                    ElseIf s = 21 Then
                        b12 = "♦8"
                    ElseIf s = 22 Then
                        b12 = "♦9"
                    ElseIf s = 23 Then
                        b12 = "♦10"
                    ElseIf s = 24 Then
                        b12 = "♦11"
                    ElseIf s = 25 Then
                        b12 = "♦12"
                    ElseIf s = 26 Then
                        b12 = "♦13"
                    ElseIf s = 27 Then
                        b12 = "♤1"
                    ElseIf s = 28 Then
                        b12 = "♤2"
                    ElseIf s = 29 Then
                        b12 = "♤3"
                    ElseIf s = 30 Then
                        b12 = "♤4"
                    ElseIf s = 31 Then
                        b12 = "♤5"
                    ElseIf s = 32 Then
                        b12 = "♤6"
                    ElseIf s = 33 Then
                        b12 = "♤7"
                    ElseIf s = 34 Then
                        b12 = "♤8"
                    ElseIf s = 35 Then
                        b12 = "♤9"
                    ElseIf s = 36 Then
                        b12 = "♤10"
                    ElseIf s = 37 Then
                        b12 = "♤11"
                    ElseIf s = 38 Then
                        b12 = "♤12"
                    ElseIf s = 39 Then
                        b12 = "♤13"
                    ElseIf s = 40 Then
                        b12 = "♧1"
                    ElseIf s = 41 Then
                        b12 = "♧2"
                    ElseIf s = 42 Then
                        b12 = "♧3"
                    ElseIf s = 43 Then
                        b12 = "♧4"
                    ElseIf s = 44 Then
                        b12 = "♧5"
                    ElseIf s = 45 Then
                        b12 = "♧6"
                    ElseIf s = 46 Then
                        b12 = "♧7"
                    ElseIf s = 47 Then
                        b12 = "♧8"
                    ElseIf s = 48 Then
                        b12 = "♧9"
                    ElseIf s = 49 Then
                        b12 = "♧10"
                    ElseIf s = 50 Then
                        b12 = "♧11"
                    ElseIf s = 51 Then
                        b12 = "♧12"
                    ElseIf s = 52 Then
                        b12 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 13 And b13 = "" Then
                    If s = 1 Then
                        b13 = "♥1"
                    ElseIf s = 2 Then
                        b13 = "♥2"
                    ElseIf s = 3 Then
                        b13 = "♥3"
                    ElseIf s = 3 Then
                        b13 = "♥3"
                    ElseIf s = 4 Then
                        b13 = "♥4"
                    ElseIf s = 4 Then
                        b13 = "♥4"
                    ElseIf s = 5 Then
                        b13 = "♥5"
                    ElseIf s = 5 Then
                        b13 = "♥5"
                    ElseIf s = 6 Then
                        b13 = "♥6"
                    ElseIf s = 6 Then
                        b13 = "♥6"
                    ElseIf s = 7 Then
                        b13 = "♥7"
                    ElseIf s = 7 Then
                        b13 = "♥7"
                    ElseIf s = 8 Then
                        b13 = "♥8"
                    ElseIf s = 8 Then
                        b13 = "♥8"
                    ElseIf s = 9 Then
                        b13 = "♥9"
                    ElseIf s = 9 Then
                        b13 = "♥9"
                    ElseIf s = 10 Then
                        b13 = "♥10"
                    ElseIf s = 10 Then
                        b13 = "♥10"
                    ElseIf s = 11 Then
                        b13 = "♥11"
                    ElseIf s = 11 Then
                        b13 = "♥11"
                    ElseIf s = 12 Then
                        b13 = "♥12"
                    ElseIf s = 12 Then
                        b13 = "♥12"
                    ElseIf s = 13 Then
                        b13 = "♥13"
                    ElseIf s = 13 Then
                        b13 = "♥13"
                    ElseIf s = 14 Then
                        b13 = "♦1"
                    ElseIf s = 15 Then
                        b13 = "♦2"
                    ElseIf s = 16 Then
                        b13 = "♦3"
                    ElseIf s = 17 Then
                        b13 = "♦4"
                    ElseIf s = 18 Then
                        b13 = "♦5"
                    ElseIf s = 19 Then
                        b13 = "♦6"
                    ElseIf s = 20 Then
                        b13 = "♦7"
                    ElseIf s = 21 Then
                        b13 = "♦8"
                    ElseIf s = 22 Then
                        b13 = "♦9"
                    ElseIf s = 23 Then
                        b13 = "♦10"
                    ElseIf s = 24 Then
                        b13 = "♦11"
                    ElseIf s = 25 Then
                        b13 = "♦12"
                    ElseIf s = 26 Then
                        b13 = "♦13"
                    ElseIf s = 27 Then
                        b13 = "♤1"
                    ElseIf s = 28 Then
                        b13 = "♤2"
                    ElseIf s = 29 Then
                        b13 = "♤3"
                    ElseIf s = 30 Then
                        b13 = "♤4"
                    ElseIf s = 31 Then
                        b13 = "♤5"
                    ElseIf s = 32 Then
                        b13 = "♤6"
                    ElseIf s = 33 Then
                        b13 = "♤7"
                    ElseIf s = 34 Then
                        b13 = "♤8"
                    ElseIf s = 35 Then
                        b13 = "♤9"
                    ElseIf s = 36 Then
                        b13 = "♤10"
                    ElseIf s = 37 Then
                        b13 = "♤11"
                    ElseIf s = 38 Then
                        b13 = "♤12"
                    ElseIf s = 39 Then
                        b13 = "♤13"
                    ElseIf s = 40 Then
                        b13 = "♧1"
                    ElseIf s = 41 Then
                        b13 = "♧2"
                    ElseIf s = 42 Then
                        b13 = "♧3"
                    ElseIf s = 43 Then
                        b13 = "♧4"
                    ElseIf s = 44 Then
                        b13 = "♧5"
                    ElseIf s = 45 Then
                        b13 = "♧6"
                    ElseIf s = 46 Then
                        b13 = "♧7"
                    ElseIf s = 47 Then
                        b13 = "♧8"
                    ElseIf s = 48 Then
                        b13 = "♧9"
                    ElseIf s = 49 Then
                        b13 = "♧10"
                    ElseIf s = 50 Then
                        b13 = "♧11"
                    ElseIf s = 51 Then
                        b13 = "♧12"
                    ElseIf s = 52 Then
                        b13 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 14 And b14 = "" Then
                    If s = 1 Then
                        b14 = "♥1"
                    ElseIf s = 2 Then
                        b14 = "♥2"
                    ElseIf s = 3 Then
                        b14 = "♥3"
                    ElseIf s = 3 Then
                        b14 = "♥3"
                    ElseIf s = 4 Then
                        b14 = "♥4"
                    ElseIf s = 4 Then
                        b14 = "♥4"
                    ElseIf s = 5 Then
                        b14 = "♥5"
                    ElseIf s = 5 Then
                        b14 = "♥5"
                    ElseIf s = 6 Then
                        b14 = "♥6"
                    ElseIf s = 6 Then
                        b14 = "♥6"
                    ElseIf s = 7 Then
                        b14 = "♥7"
                    ElseIf s = 7 Then
                        b14 = "♥7"
                    ElseIf s = 8 Then
                        b14 = "♥8"
                    ElseIf s = 8 Then
                        b14 = "♥8"
                    ElseIf s = 9 Then
                        b14 = "♥9"
                    ElseIf s = 9 Then
                        b14 = "♥9"
                    ElseIf s = 10 Then
                        b14 = "♥10"
                    ElseIf s = 10 Then
                        b14 = "♥10"
                    ElseIf s = 11 Then
                        b14 = "♥11"
                    ElseIf s = 11 Then
                        b14 = "♥11"
                    ElseIf s = 12 Then
                        b14 = "♥12"
                    ElseIf s = 12 Then
                        b14 = "♥12"
                    ElseIf s = 13 Then
                        b14 = "♥13"
                    ElseIf s = 13 Then
                        b14 = "♥13"
                    ElseIf s = 14 Then
                        b14 = "♦1"
                    ElseIf s = 15 Then
                        b14 = "♦2"
                    ElseIf s = 16 Then
                        b14 = "♦3"
                    ElseIf s = 17 Then
                        b14 = "♦4"
                    ElseIf s = 18 Then
                        b14 = "♦5"
                    ElseIf s = 19 Then
                        b14 = "♦6"
                    ElseIf s = 20 Then
                        b14 = "♦7"
                    ElseIf s = 21 Then
                        b14 = "♦8"
                    ElseIf s = 22 Then
                        b14 = "♦9"
                    ElseIf s = 23 Then
                        b14 = "♦10"
                    ElseIf s = 24 Then
                        b14 = "♦11"
                    ElseIf s = 25 Then
                        b14 = "♦12"
                    ElseIf s = 26 Then
                        b14 = "♦13"
                    ElseIf s = 27 Then
                        b14 = "♤1"
                    ElseIf s = 28 Then
                        b14 = "♤2"
                    ElseIf s = 29 Then
                        b14 = "♤3"
                    ElseIf s = 30 Then
                        b14 = "♤4"
                    ElseIf s = 31 Then
                        b14 = "♤5"
                    ElseIf s = 32 Then
                        b14 = "♤6"
                    ElseIf s = 33 Then
                        b14 = "♤7"
                    ElseIf s = 34 Then
                        b14 = "♤8"
                    ElseIf s = 35 Then
                        b14 = "♤9"
                    ElseIf s = 36 Then
                        b14 = "♤10"
                    ElseIf s = 37 Then
                        b14 = "♤11"
                    ElseIf s = 38 Then
                        b14 = "♤12"
                    ElseIf s = 39 Then
                        b14 = "♤13"
                    ElseIf s = 40 Then
                        b14 = "♧1"
                    ElseIf s = 41 Then
                        b14 = "♧2"
                    ElseIf s = 42 Then
                        b14 = "♧3"
                    ElseIf s = 43 Then
                        b14 = "♧4"
                    ElseIf s = 44 Then
                        b14 = "♧5"
                    ElseIf s = 45 Then
                        b14 = "♧6"
                    ElseIf s = 46 Then
                        b14 = "♧7"
                    ElseIf s = 47 Then
                        b14 = "♧8"
                    ElseIf s = 48 Then
                        b14 = "♧9"
                    ElseIf s = 49 Then
                        b14 = "♧10"
                    ElseIf s = 50 Then
                        b14 = "♧11"
                    ElseIf s = 51 Then
                        b14 = "♧12"
                    ElseIf s = 52 Then
                        b14 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 15 And b15 = "" Then
                    If s = 1 Then
                        b15 = "♥1"
                    ElseIf s = 2 Then
                        b15 = "♥2"
                    ElseIf s = 3 Then
                        b15 = "♥3"
                    ElseIf s = 3 Then
                        b15 = "♥3"
                    ElseIf s = 4 Then
                        b15 = "♥4"
                    ElseIf s = 4 Then
                        b15 = "♥4"
                    ElseIf s = 5 Then
                        b15 = "♥5"
                    ElseIf s = 5 Then
                        b15 = "♥5"
                    ElseIf s = 6 Then
                        b15 = "♥6"
                    ElseIf s = 6 Then
                        b15 = "♥6"
                    ElseIf s = 7 Then
                        b15 = "♥7"
                    ElseIf s = 7 Then
                        b15 = "♥7"
                    ElseIf s = 8 Then
                        b15 = "♥8"
                    ElseIf s = 8 Then
                        b15 = "♥8"
                    ElseIf s = 9 Then
                        b15 = "♥9"
                    ElseIf s = 9 Then
                        b15 = "♥9"
                    ElseIf s = 10 Then
                        b15 = "♥10"
                    ElseIf s = 10 Then
                        b15 = "♥10"
                    ElseIf s = 11 Then
                        b15 = "♥11"
                    ElseIf s = 11 Then
                        b15 = "♥11"
                    ElseIf s = 12 Then
                        b15 = "♥12"
                    ElseIf s = 12 Then
                        b15 = "♥12"
                    ElseIf s = 13 Then
                        b15 = "♥13"
                    ElseIf s = 13 Then
                        b15 = "♥13"
                    ElseIf s = 14 Then
                        b15 = "♦1"
                    ElseIf s = 15 Then
                        b15 = "♦2"
                    ElseIf s = 16 Then
                        b15 = "♦3"
                    ElseIf s = 17 Then
                        b15 = "♦4"
                    ElseIf s = 18 Then
                        b15 = "♦5"
                    ElseIf s = 19 Then
                        b15 = "♦6"
                    ElseIf s = 20 Then
                        b15 = "♦7"
                    ElseIf s = 21 Then
                        b15 = "♦8"
                    ElseIf s = 22 Then
                        b15 = "♦9"
                    ElseIf s = 23 Then
                        b15 = "♦10"
                    ElseIf s = 24 Then
                        b15 = "♦11"
                    ElseIf s = 25 Then
                        b15 = "♦12"
                    ElseIf s = 26 Then
                        b15 = "♦13"
                    ElseIf s = 27 Then
                        b15 = "♤1"
                    ElseIf s = 28 Then
                        b15 = "♤2"
                    ElseIf s = 29 Then
                        b15 = "♤3"
                    ElseIf s = 30 Then
                        b15 = "♤4"
                    ElseIf s = 31 Then
                        b15 = "♤5"
                    ElseIf s = 32 Then
                        b15 = "♤6"
                    ElseIf s = 33 Then
                        b15 = "♤7"
                    ElseIf s = 34 Then
                        b15 = "♤8"
                    ElseIf s = 35 Then
                        b15 = "♤9"
                    ElseIf s = 36 Then
                        b15 = "♤10"
                    ElseIf s = 37 Then
                        b15 = "♤11"
                    ElseIf s = 38 Then
                        b15 = "♤12"
                    ElseIf s = 39 Then
                        b15 = "♤13"
                    ElseIf s = 40 Then
                        b15 = "♧1"
                    ElseIf s = 41 Then
                        b15 = "♧2"
                    ElseIf s = 42 Then
                        b15 = "♧3"
                    ElseIf s = 43 Then
                        b15 = "♧4"
                    ElseIf s = 44 Then
                        b15 = "♧5"
                    ElseIf s = 45 Then
                        b15 = "♧6"
                    ElseIf s = 46 Then
                        b15 = "♧7"
                    ElseIf s = 47 Then
                        b15 = "♧8"
                    ElseIf s = 48 Then
                        b15 = "♧9"
                    ElseIf s = 49 Then
                        b15 = "♧10"
                    ElseIf s = 50 Then
                        b15 = "♧11"
                    ElseIf s = 51 Then
                        b15 = "♧12"
                    ElseIf s = 52 Then
                        b15 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 16 And b16 = "" Then
                    If s = 1 Then
                        b16 = "♥1"
                    ElseIf s = 2 Then
                        b16 = "♥2"
                    ElseIf s = 3 Then
                        b16 = "♥3"
                    ElseIf s = 3 Then
                        b16 = "♥3"
                    ElseIf s = 4 Then
                        b16 = "♥4"
                    ElseIf s = 4 Then
                        b16 = "♥4"
                    ElseIf s = 5 Then
                        b16 = "♥5"
                    ElseIf s = 5 Then
                        b16 = "♥5"
                    ElseIf s = 6 Then
                        b16 = "♥6"
                    ElseIf s = 6 Then
                        b16 = "♥6"
                    ElseIf s = 7 Then
                        b16 = "♥7"
                    ElseIf s = 7 Then
                        b16 = "♥7"
                    ElseIf s = 8 Then
                        b16 = "♥8"
                    ElseIf s = 8 Then
                        b16 = "♥8"
                    ElseIf s = 9 Then
                        b16 = "♥9"
                    ElseIf s = 9 Then
                        b16 = "♥9"
                    ElseIf s = 10 Then
                        b16 = "♥10"
                    ElseIf s = 10 Then
                        b16 = "♥10"
                    ElseIf s = 11 Then
                        b16 = "♥11"
                    ElseIf s = 11 Then
                        b16 = "♥11"
                    ElseIf s = 12 Then
                        b16 = "♥12"
                    ElseIf s = 12 Then
                        b16 = "♥12"
                    ElseIf s = 13 Then
                        b16 = "♥13"
                    ElseIf s = 13 Then
                        b16 = "♥13"
                    ElseIf s = 14 Then
                        b16 = "♦1"
                    ElseIf s = 15 Then
                        b16 = "♦2"
                    ElseIf s = 16 Then
                        b16 = "♦3"
                    ElseIf s = 17 Then
                        b16 = "♦4"
                    ElseIf s = 18 Then
                        b16 = "♦5"
                    ElseIf s = 19 Then
                        b16 = "♦6"
                    ElseIf s = 20 Then
                        b16 = "♦7"
                    ElseIf s = 21 Then
                        b16 = "♦8"
                    ElseIf s = 22 Then
                        b16 = "♦9"
                    ElseIf s = 23 Then
                        b16 = "♦10"
                    ElseIf s = 24 Then
                        b16 = "♦11"
                    ElseIf s = 25 Then
                        b16 = "♦12"
                    ElseIf s = 26 Then
                        b16 = "♦13"
                    ElseIf s = 27 Then
                        b16 = "♤1"
                    ElseIf s = 28 Then
                        b16 = "♤2"
                    ElseIf s = 29 Then
                        b16 = "♤3"
                    ElseIf s = 30 Then
                        b16 = "♤4"
                    ElseIf s = 31 Then
                        b16 = "♤5"
                    ElseIf s = 32 Then
                        b16 = "♤6"
                    ElseIf s = 33 Then
                        b16 = "♤7"
                    ElseIf s = 34 Then
                        b16 = "♤8"
                    ElseIf s = 35 Then
                        b16 = "♤9"
                    ElseIf s = 36 Then
                        b16 = "♤10"
                    ElseIf s = 37 Then
                        b16 = "♤11"
                    ElseIf s = 38 Then
                        b16 = "♤12"
                    ElseIf s = 39 Then
                        b16 = "♤13"
                    ElseIf s = 40 Then
                        b16 = "♧1"
                    ElseIf s = 41 Then
                        b16 = "♧2"
                    ElseIf s = 42 Then
                        b16 = "♧3"
                    ElseIf s = 43 Then
                        b16 = "♧4"
                    ElseIf s = 44 Then
                        b16 = "♧5"
                    ElseIf s = 45 Then
                        b16 = "♧6"
                    ElseIf s = 46 Then
                        b16 = "♧7"
                    ElseIf s = 47 Then
                        b16 = "♧8"
                    ElseIf s = 48 Then
                        b16 = "♧9"
                    ElseIf s = 49 Then
                        b16 = "♧10"
                    ElseIf s = 50 Then
                        b16 = "♧11"
                    ElseIf s = 51 Then
                        b16 = "♧12"
                    ElseIf s = 52 Then
                        b16 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 17 And b17 = "" Then
                    If s = 1 Then
                        b17 = "♥1"
                    ElseIf s = 2 Then
                        b17 = "♥2"
                    ElseIf s = 3 Then
                        b17 = "♥3"
                    ElseIf s = 3 Then
                        b17 = "♥3"
                    ElseIf s = 4 Then
                        b17 = "♥4"
                    ElseIf s = 4 Then
                        b17 = "♥4"
                    ElseIf s = 5 Then
                        b17 = "♥5"
                    ElseIf s = 5 Then
                        b17 = "♥5"
                    ElseIf s = 6 Then
                        b17 = "♥6"
                    ElseIf s = 6 Then
                        b17 = "♥6"
                    ElseIf s = 7 Then
                        b17 = "♥7"
                    ElseIf s = 7 Then
                        b17 = "♥7"
                    ElseIf s = 8 Then
                        b17 = "♥8"
                    ElseIf s = 8 Then
                        b17 = "♥8"
                    ElseIf s = 9 Then
                        b17 = "♥9"
                    ElseIf s = 9 Then
                        b17 = "♥9"
                    ElseIf s = 10 Then
                        b17 = "♥10"
                    ElseIf s = 10 Then
                        b17 = "♥10"
                    ElseIf s = 11 Then
                        b17 = "♥11"
                    ElseIf s = 11 Then
                        b17 = "♥11"
                    ElseIf s = 12 Then
                        b17 = "♥12"
                    ElseIf s = 12 Then
                        b17 = "♥12"
                    ElseIf s = 13 Then
                        b17 = "♥13"
                    ElseIf s = 13 Then
                        b17 = "♥13"
                    ElseIf s = 14 Then
                        b17 = "♦1"
                    ElseIf s = 15 Then
                        b17 = "♦2"
                    ElseIf s = 16 Then
                        b17 = "♦3"
                    ElseIf s = 17 Then
                        b17 = "♦4"
                    ElseIf s = 18 Then
                        b17 = "♦5"
                    ElseIf s = 19 Then
                        b17 = "♦6"
                    ElseIf s = 20 Then
                        b17 = "♦7"
                    ElseIf s = 21 Then
                        b17 = "♦8"
                    ElseIf s = 22 Then
                        b17 = "♦9"
                    ElseIf s = 23 Then
                        b17 = "♦10"
                    ElseIf s = 24 Then
                        b17 = "♦11"
                    ElseIf s = 25 Then
                        b17 = "♦12"
                    ElseIf s = 26 Then
                        b17 = "♦13"
                    ElseIf s = 27 Then
                        b17 = "♤1"
                    ElseIf s = 28 Then
                        b17 = "♤2"
                    ElseIf s = 29 Then
                        b17 = "♤3"
                    ElseIf s = 30 Then
                        b17 = "♤4"
                    ElseIf s = 31 Then
                        b17 = "♤5"
                    ElseIf s = 32 Then
                        b17 = "♤6"
                    ElseIf s = 33 Then
                        b17 = "♤7"
                    ElseIf s = 34 Then
                        b17 = "♤8"
                    ElseIf s = 35 Then
                        b17 = "♤9"
                    ElseIf s = 36 Then
                        b17 = "♤10"
                    ElseIf s = 37 Then
                        b17 = "♤11"
                    ElseIf s = 38 Then
                        b17 = "♤12"
                    ElseIf s = 39 Then
                        b17 = "♤13"
                    ElseIf s = 40 Then
                        b17 = "♧1"
                    ElseIf s = 41 Then
                        b17 = "♧2"
                    ElseIf s = 42 Then
                        b17 = "♧3"
                    ElseIf s = 43 Then
                        b17 = "♧4"
                    ElseIf s = 44 Then
                        b17 = "♧5"
                    ElseIf s = 45 Then
                        b17 = "♧6"
                    ElseIf s = 46 Then
                        b17 = "♧7"
                    ElseIf s = 47 Then
                        b17 = "♧8"
                    ElseIf s = 48 Then
                        b17 = "♧9"
                    ElseIf s = 49 Then
                        b17 = "♧10"
                    ElseIf s = 50 Then
                        b17 = "♧11"
                    ElseIf s = 51 Then
                        b17 = "♧12"
                    ElseIf s = 52 Then
                        b17 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 18 And b18 = "" Then
                    If s = 1 Then
                        b18 = "♥1"
                    ElseIf s = 2 Then
                        b18 = "♥2"
                    ElseIf s = 3 Then
                        b18 = "♥3"
                    ElseIf s = 3 Then
                        b18 = "♥3"
                    ElseIf s = 4 Then
                        b18 = "♥4"
                    ElseIf s = 4 Then
                        b18 = "♥4"
                    ElseIf s = 5 Then
                        b18 = "♥5"
                    ElseIf s = 5 Then
                        b18 = "♥5"
                    ElseIf s = 6 Then
                        b18 = "♥6"
                    ElseIf s = 6 Then
                        b18 = "♥6"
                    ElseIf s = 7 Then
                        b18 = "♥7"
                    ElseIf s = 7 Then
                        b18 = "♥7"
                    ElseIf s = 8 Then
                        b18 = "♥8"
                    ElseIf s = 8 Then
                        b18 = "♥8"
                    ElseIf s = 9 Then
                        b18 = "♥9"
                    ElseIf s = 9 Then
                        b18 = "♥9"
                    ElseIf s = 10 Then
                        b18 = "♥10"
                    ElseIf s = 10 Then
                        b18 = "♥10"
                    ElseIf s = 11 Then
                        b18 = "♥11"
                    ElseIf s = 11 Then
                        b18 = "♥11"
                    ElseIf s = 12 Then
                        b18 = "♥12"
                    ElseIf s = 12 Then
                        b18 = "♥12"
                    ElseIf s = 13 Then
                        b18 = "♥13"
                    ElseIf s = 13 Then
                        b18 = "♥13"
                    ElseIf s = 14 Then
                        b18 = "♦1"
                    ElseIf s = 15 Then
                        b18 = "♦2"
                    ElseIf s = 16 Then
                        b18 = "♦3"
                    ElseIf s = 17 Then
                        b18 = "♦4"
                    ElseIf s = 18 Then
                        b18 = "♦5"
                    ElseIf s = 19 Then
                        b18 = "♦6"
                    ElseIf s = 20 Then
                        b18 = "♦7"
                    ElseIf s = 21 Then
                        b18 = "♦8"
                    ElseIf s = 22 Then
                        b18 = "♦9"
                    ElseIf s = 23 Then
                        b18 = "♦10"
                    ElseIf s = 24 Then
                        b18 = "♦11"
                    ElseIf s = 25 Then
                        b18 = "♦12"
                    ElseIf s = 26 Then
                        b18 = "♦13"
                    ElseIf s = 27 Then
                        b18 = "♤1"
                    ElseIf s = 28 Then
                        b18 = "♤2"
                    ElseIf s = 29 Then
                        b18 = "♤3"
                    ElseIf s = 30 Then
                        b18 = "♤4"
                    ElseIf s = 31 Then
                        b18 = "♤5"
                    ElseIf s = 32 Then
                        b18 = "♤6"
                    ElseIf s = 33 Then
                        b18 = "♤7"
                    ElseIf s = 34 Then
                        b18 = "♤8"
                    ElseIf s = 35 Then
                        b18 = "♤9"
                    ElseIf s = 36 Then
                        b18 = "♤10"
                    ElseIf s = 37 Then
                        b18 = "♤11"
                    ElseIf s = 38 Then
                        b18 = "♤12"
                    ElseIf s = 39 Then
                        b18 = "♤13"
                    ElseIf s = 40 Then
                        b18 = "♧1"
                    ElseIf s = 41 Then
                        b18 = "♧2"
                    ElseIf s = 42 Then
                        b18 = "♧3"
                    ElseIf s = 43 Then
                        b18 = "♧4"
                    ElseIf s = 44 Then
                        b18 = "♧5"
                    ElseIf s = 45 Then
                        b18 = "♧6"
                    ElseIf s = 46 Then
                        b18 = "♧7"
                    ElseIf s = 47 Then
                        b18 = "♧8"
                    ElseIf s = 48 Then
                        b18 = "♧9"
                    ElseIf s = 49 Then
                        b18 = "♧10"
                    ElseIf s = 50 Then
                        b18 = "♧11"
                    ElseIf s = 51 Then
                        b18 = "♧12"
                    ElseIf s = 52 Then
                        b18 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 19 And b19 = "" Then
                    If s = 1 Then
                        b19 = "♥1"
                    ElseIf s = 2 Then
                        b19 = "♥2"
                    ElseIf s = 3 Then
                        b19 = "♥3"
                    ElseIf s = 3 Then
                        b19 = "♥3"
                    ElseIf s = 4 Then
                        b19 = "♥4"
                    ElseIf s = 4 Then
                        b19 = "♥4"
                    ElseIf s = 5 Then
                        b19 = "♥5"
                    ElseIf s = 5 Then
                        b19 = "♥5"
                    ElseIf s = 6 Then
                        b19 = "♥6"
                    ElseIf s = 6 Then
                        b19 = "♥6"
                    ElseIf s = 7 Then
                        b19 = "♥7"
                    ElseIf s = 7 Then
                        b19 = "♥7"
                    ElseIf s = 8 Then
                        b19 = "♥8"
                    ElseIf s = 8 Then
                        b19 = "♥8"
                    ElseIf s = 9 Then
                        b19 = "♥9"
                    ElseIf s = 9 Then
                        b19 = "♥9"
                    ElseIf s = 10 Then
                        b19 = "♥10"
                    ElseIf s = 10 Then
                        b19 = "♥10"
                    ElseIf s = 11 Then
                        b19 = "♥11"
                    ElseIf s = 11 Then
                        b19 = "♥11"
                    ElseIf s = 12 Then
                        b19 = "♥12"
                    ElseIf s = 12 Then
                        b19 = "♥12"
                    ElseIf s = 13 Then
                        b19 = "♥13"
                    ElseIf s = 13 Then
                        b19 = "♥13"
                    ElseIf s = 14 Then
                        b19 = "♦1"
                    ElseIf s = 15 Then
                        b19 = "♦2"
                    ElseIf s = 16 Then
                        b19 = "♦3"
                    ElseIf s = 17 Then
                        b19 = "♦4"
                    ElseIf s = 18 Then
                        b19 = "♦5"
                    ElseIf s = 19 Then
                        b19 = "♦6"
                    ElseIf s = 20 Then
                        b19 = "♦7"
                    ElseIf s = 21 Then
                        b19 = "♦8"
                    ElseIf s = 22 Then
                        b19 = "♦9"
                    ElseIf s = 23 Then
                        b19 = "♦10"
                    ElseIf s = 24 Then
                        b19 = "♦11"
                    ElseIf s = 25 Then
                        b19 = "♦12"
                    ElseIf s = 26 Then
                        b19 = "♦13"
                    ElseIf s = 27 Then
                        b19 = "♤1"
                    ElseIf s = 28 Then
                        b19 = "♤2"
                    ElseIf s = 29 Then
                        b19 = "♤3"
                    ElseIf s = 30 Then
                        b19 = "♤4"
                    ElseIf s = 31 Then
                        b19 = "♤5"
                    ElseIf s = 32 Then
                        b19 = "♤6"
                    ElseIf s = 33 Then
                        b19 = "♤7"
                    ElseIf s = 34 Then
                        b19 = "♤8"
                    ElseIf s = 35 Then
                        b19 = "♤9"
                    ElseIf s = 36 Then
                        b19 = "♤10"
                    ElseIf s = 37 Then
                        b19 = "♤11"
                    ElseIf s = 38 Then
                        b19 = "♤12"
                    ElseIf s = 39 Then
                        b19 = "♤13"
                    ElseIf s = 40 Then
                        b19 = "♧1"
                    ElseIf s = 41 Then
                        b19 = "♧2"
                    ElseIf s = 42 Then
                        b19 = "♧3"
                    ElseIf s = 43 Then
                        b19 = "♧4"
                    ElseIf s = 44 Then
                        b19 = "♧5"
                    ElseIf s = 45 Then
                        b19 = "♧6"
                    ElseIf s = 46 Then
                        b19 = "♧7"
                    ElseIf s = 47 Then
                        b19 = "♧8"
                    ElseIf s = 48 Then
                        b19 = "♧9"
                    ElseIf s = 49 Then
                        b19 = "♧10"
                    ElseIf s = 50 Then
                        b19 = "♧11"
                    ElseIf s = 51 Then
                        b19 = "♧12"
                    ElseIf s = 52 Then
                        b19 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 20 And b20 = "" Then
                    If s = 1 Then
                        b20 = "♥1"
                    ElseIf s = 2 Then
                        b20 = "♥2"
                    ElseIf s = 3 Then
                        b20 = "♥3"
                    ElseIf s = 3 Then
                        b20 = "♥3"
                    ElseIf s = 4 Then
                        b20 = "♥4"
                    ElseIf s = 4 Then
                        b20 = "♥4"
                    ElseIf s = 5 Then
                        b20 = "♥5"
                    ElseIf s = 5 Then
                        b20 = "♥5"
                    ElseIf s = 6 Then
                        b20 = "♥6"
                    ElseIf s = 6 Then
                        b20 = "♥6"
                    ElseIf s = 7 Then
                        b20 = "♥7"
                    ElseIf s = 7 Then
                        b20 = "♥7"
                    ElseIf s = 8 Then
                        b20 = "♥8"
                    ElseIf s = 8 Then
                        b20 = "♥8"
                    ElseIf s = 9 Then
                        b20 = "♥9"
                    ElseIf s = 9 Then
                        b20 = "♥9"
                    ElseIf s = 10 Then
                        b20 = "♥10"
                    ElseIf s = 10 Then
                        b20 = "♥10"
                    ElseIf s = 11 Then
                        b20 = "♥11"
                    ElseIf s = 11 Then
                        b20 = "♥11"
                    ElseIf s = 12 Then
                        b20 = "♥12"
                    ElseIf s = 12 Then
                        b20 = "♥12"
                    ElseIf s = 13 Then
                        b20 = "♥13"
                    ElseIf s = 13 Then
                        b20 = "♥13"
                    ElseIf s = 14 Then
                        b20 = "♦1"
                    ElseIf s = 15 Then
                        b20 = "♦2"
                    ElseIf s = 16 Then
                        b20 = "♦3"
                    ElseIf s = 17 Then
                        b20 = "♦4"
                    ElseIf s = 18 Then
                        b20 = "♦5"
                    ElseIf s = 19 Then
                        b20 = "♦6"
                    ElseIf s = 20 Then
                        b20 = "♦7"
                    ElseIf s = 21 Then
                        b20 = "♦8"
                    ElseIf s = 22 Then
                        b20 = "♦9"
                    ElseIf s = 23 Then
                        b20 = "♦10"
                    ElseIf s = 24 Then
                        b20 = "♦11"
                    ElseIf s = 25 Then
                        b20 = "♦12"
                    ElseIf s = 26 Then
                        b20 = "♦13"
                    ElseIf s = 27 Then
                        b20 = "♤1"
                    ElseIf s = 28 Then
                        b20 = "♤2"
                    ElseIf s = 29 Then
                        b20 = "♤3"
                    ElseIf s = 30 Then
                        b20 = "♤4"
                    ElseIf s = 31 Then
                        b20 = "♤5"
                    ElseIf s = 32 Then
                        b20 = "♤6"
                    ElseIf s = 33 Then
                        b20 = "♤7"
                    ElseIf s = 34 Then
                        b20 = "♤8"
                    ElseIf s = 35 Then
                        b20 = "♤9"
                    ElseIf s = 36 Then
                        b20 = "♤10"
                    ElseIf s = 37 Then
                        b20 = "♤11"
                    ElseIf s = 38 Then
                        b20 = "♤12"
                    ElseIf s = 39 Then
                        b20 = "♤13"
                    ElseIf s = 40 Then
                        b20 = "♧1"
                    ElseIf s = 41 Then
                        b20 = "♧2"
                    ElseIf s = 42 Then
                        b20 = "♧3"
                    ElseIf s = 43 Then
                        b20 = "♧4"
                    ElseIf s = 44 Then
                        b20 = "♧5"
                    ElseIf s = 45 Then
                        b20 = "♧6"
                    ElseIf s = 46 Then
                        b20 = "♧7"
                    ElseIf s = 47 Then
                        b20 = "♧8"
                    ElseIf s = 48 Then
                        b20 = "♧9"
                    ElseIf s = 49 Then
                        b20 = "♧10"
                    ElseIf s = 50 Then
                        b20 = "♧11"
                    ElseIf s = 51 Then
                        b20 = "♧12"
                    ElseIf s = 52 Then
                        b20 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 21 And b21 = "" Then
                    If s = 1 Then
                        b21 = "♥1"
                    ElseIf s = 2 Then
                        b21 = "♥2"
                    ElseIf s = 3 Then
                        b21 = "♥3"
                    ElseIf s = 3 Then
                        b21 = "♥3"
                    ElseIf s = 4 Then
                        b21 = "♥4"
                    ElseIf s = 4 Then
                        b21 = "♥4"
                    ElseIf s = 5 Then
                        b21 = "♥5"
                    ElseIf s = 5 Then
                        b21 = "♥5"
                    ElseIf s = 6 Then
                        b21 = "♥6"
                    ElseIf s = 6 Then
                        b21 = "♥6"
                    ElseIf s = 7 Then
                        b21 = "♥7"
                    ElseIf s = 7 Then
                        b21 = "♥7"
                    ElseIf s = 8 Then
                        b21 = "♥8"
                    ElseIf s = 8 Then
                        b21 = "♥8"
                    ElseIf s = 9 Then
                        b21 = "♥9"
                    ElseIf s = 9 Then
                        b21 = "♥9"
                    ElseIf s = 10 Then
                        b21 = "♥10"
                    ElseIf s = 10 Then
                        b21 = "♥10"
                    ElseIf s = 11 Then
                        b21 = "♥11"
                    ElseIf s = 11 Then
                        b21 = "♥11"
                    ElseIf s = 12 Then
                        b21 = "♥12"
                    ElseIf s = 12 Then
                        b21 = "♥12"
                    ElseIf s = 13 Then
                        b21 = "♥13"
                    ElseIf s = 13 Then
                        b21 = "♥13"
                    ElseIf s = 14 Then
                        b21 = "♦1"
                    ElseIf s = 15 Then
                        b21 = "♦2"
                    ElseIf s = 16 Then
                        b21 = "♦3"
                    ElseIf s = 17 Then
                        b21 = "♦4"
                    ElseIf s = 18 Then
                        b21 = "♦5"
                    ElseIf s = 19 Then
                        b21 = "♦6"
                    ElseIf s = 20 Then
                        b21 = "♦7"
                    ElseIf s = 21 Then
                        b21 = "♦8"
                    ElseIf s = 22 Then
                        b21 = "♦9"
                    ElseIf s = 23 Then
                        b21 = "♦10"
                    ElseIf s = 24 Then
                        b21 = "♦11"
                    ElseIf s = 25 Then
                        b21 = "♦12"
                    ElseIf s = 26 Then
                        b21 = "♦13"
                    ElseIf s = 27 Then
                        b21 = "♤1"
                    ElseIf s = 28 Then
                        b21 = "♤2"
                    ElseIf s = 29 Then
                        b21 = "♤3"
                    ElseIf s = 30 Then
                        b21 = "♤4"
                    ElseIf s = 31 Then
                        b21 = "♤5"
                    ElseIf s = 32 Then
                        b21 = "♤6"
                    ElseIf s = 33 Then
                        b21 = "♤7"
                    ElseIf s = 34 Then
                        b21 = "♤8"
                    ElseIf s = 35 Then
                        b21 = "♤9"
                    ElseIf s = 36 Then
                        b21 = "♤10"
                    ElseIf s = 37 Then
                        b21 = "♤11"
                    ElseIf s = 38 Then
                        b21 = "♤12"
                    ElseIf s = 39 Then
                        b21 = "♤13"
                    ElseIf s = 40 Then
                        b21 = "♧1"
                    ElseIf s = 41 Then
                        b21 = "♧2"
                    ElseIf s = 42 Then
                        b21 = "♧3"
                    ElseIf s = 43 Then
                        b21 = "♧4"
                    ElseIf s = 44 Then
                        b21 = "♧5"
                    ElseIf s = 45 Then
                        b21 = "♧6"
                    ElseIf s = 46 Then
                        b21 = "♧7"
                    ElseIf s = 47 Then
                        b21 = "♧8"
                    ElseIf s = 48 Then
                        b21 = "♧9"
                    ElseIf s = 49 Then
                        b21 = "♧10"
                    ElseIf s = 50 Then
                        b21 = "♧11"
                    ElseIf s = 51 Then
                        b21 = "♧12"
                    ElseIf s = 52 Then
                        b21 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 22 And b22 = "" Then
                    If s = 1 Then
                        b22 = "♥1"
                    ElseIf s = 2 Then
                        b22 = "♥2"
                    ElseIf s = 3 Then
                        b22 = "♥3"
                    ElseIf s = 3 Then
                        b22 = "♥3"
                    ElseIf s = 4 Then
                        b22 = "♥4"
                    ElseIf s = 4 Then
                        b22 = "♥4"
                    ElseIf s = 5 Then
                        b22 = "♥5"
                    ElseIf s = 5 Then
                        b22 = "♥5"
                    ElseIf s = 6 Then
                        b22 = "♥6"
                    ElseIf s = 6 Then
                        b22 = "♥6"
                    ElseIf s = 7 Then
                        b22 = "♥7"
                    ElseIf s = 7 Then
                        b22 = "♥7"
                    ElseIf s = 8 Then
                        b22 = "♥8"
                    ElseIf s = 8 Then
                        b22 = "♥8"
                    ElseIf s = 9 Then
                        b22 = "♥9"
                    ElseIf s = 9 Then
                        b22 = "♥9"
                    ElseIf s = 10 Then
                        b22 = "♥10"
                    ElseIf s = 10 Then
                        b22 = "♥10"
                    ElseIf s = 11 Then
                        b22 = "♥11"
                    ElseIf s = 11 Then
                        b22 = "♥11"
                    ElseIf s = 12 Then
                        b22 = "♥12"
                    ElseIf s = 12 Then
                        b22 = "♥12"
                    ElseIf s = 13 Then
                        b22 = "♥13"
                    ElseIf s = 13 Then
                        b22 = "♥13"
                    ElseIf s = 14 Then
                        b22 = "♦1"
                    ElseIf s = 15 Then
                        b22 = "♦2"
                    ElseIf s = 16 Then
                        b22 = "♦3"
                    ElseIf s = 17 Then
                        b22 = "♦4"
                    ElseIf s = 18 Then
                        b22 = "♦5"
                    ElseIf s = 19 Then
                        b22 = "♦6"
                    ElseIf s = 20 Then
                        b22 = "♦7"
                    ElseIf s = 21 Then
                        b22 = "♦8"
                    ElseIf s = 22 Then
                        b22 = "♦9"
                    ElseIf s = 23 Then
                        b22 = "♦10"
                    ElseIf s = 24 Then
                        b22 = "♦11"
                    ElseIf s = 25 Then
                        b22 = "♦12"
                    ElseIf s = 26 Then
                        b22 = "♦13"
                    ElseIf s = 27 Then
                        b22 = "♤1"
                    ElseIf s = 28 Then
                        b22 = "♤2"
                    ElseIf s = 29 Then
                        b22 = "♤3"
                    ElseIf s = 30 Then
                        b22 = "♤4"
                    ElseIf s = 31 Then
                        b22 = "♤5"
                    ElseIf s = 32 Then
                        b22 = "♤6"
                    ElseIf s = 33 Then
                        b22 = "♤7"
                    ElseIf s = 34 Then
                        b22 = "♤8"
                    ElseIf s = 35 Then
                        b22 = "♤9"
                    ElseIf s = 36 Then
                        b22 = "♤10"
                    ElseIf s = 37 Then
                        b22 = "♤11"
                    ElseIf s = 38 Then
                        b22 = "♤12"
                    ElseIf s = 39 Then
                        b22 = "♤13"
                    ElseIf s = 40 Then
                        b22 = "♧1"
                    ElseIf s = 41 Then
                        b22 = "♧2"
                    ElseIf s = 42 Then
                        b22 = "♧3"
                    ElseIf s = 43 Then
                        b22 = "♧4"
                    ElseIf s = 44 Then
                        b22 = "♧5"
                    ElseIf s = 45 Then
                        b22 = "♧6"
                    ElseIf s = 46 Then
                        b22 = "♧7"
                    ElseIf s = 47 Then
                        b22 = "♧8"
                    ElseIf s = 48 Then
                        b22 = "♧9"
                    ElseIf s = 49 Then
                        b22 = "♧10"
                    ElseIf s = 50 Then
                        b22 = "♧11"
                    ElseIf s = 51 Then
                        b22 = "♧12"
                    ElseIf s = 52 Then
                        b22 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 23 And b23 = "" Then
                    If s = 1 Then
                        b23 = "♥1"
                    ElseIf s = 2 Then
                        b23 = "♥2"
                    ElseIf s = 3 Then
                        b23 = "♥3"
                    ElseIf s = 3 Then
                        b23 = "♥3"
                    ElseIf s = 4 Then
                        b23 = "♥4"
                    ElseIf s = 4 Then
                        b23 = "♥4"
                    ElseIf s = 5 Then
                        b23 = "♥5"
                    ElseIf s = 5 Then
                        b23 = "♥5"
                    ElseIf s = 6 Then
                        b23 = "♥6"
                    ElseIf s = 6 Then
                        b23 = "♥6"
                    ElseIf s = 7 Then
                        b23 = "♥7"
                    ElseIf s = 7 Then
                        b23 = "♥7"
                    ElseIf s = 8 Then
                        b23 = "♥8"
                    ElseIf s = 8 Then
                        b23 = "♥8"
                    ElseIf s = 9 Then
                        b23 = "♥9"
                    ElseIf s = 9 Then
                        b23 = "♥9"
                    ElseIf s = 10 Then
                        b23 = "♥10"
                    ElseIf s = 10 Then
                        b23 = "♥10"
                    ElseIf s = 11 Then
                        b23 = "♥11"
                    ElseIf s = 11 Then
                        b23 = "♥11"
                    ElseIf s = 12 Then
                        b23 = "♥12"
                    ElseIf s = 12 Then
                        b23 = "♥12"
                    ElseIf s = 13 Then
                        b23 = "♥13"
                    ElseIf s = 13 Then
                        b23 = "♥13"
                    ElseIf s = 14 Then
                        b23 = "♦1"
                    ElseIf s = 15 Then
                        b23 = "♦2"
                    ElseIf s = 16 Then
                        b23 = "♦3"
                    ElseIf s = 17 Then
                        b23 = "♦4"
                    ElseIf s = 18 Then
                        b23 = "♦5"
                    ElseIf s = 19 Then
                        b23 = "♦6"
                    ElseIf s = 20 Then
                        b23 = "♦7"
                    ElseIf s = 21 Then
                        b23 = "♦8"
                    ElseIf s = 22 Then
                        b23 = "♦9"
                    ElseIf s = 23 Then
                        b23 = "♦10"
                    ElseIf s = 24 Then
                        b23 = "♦11"
                    ElseIf s = 25 Then
                        b23 = "♦12"
                    ElseIf s = 26 Then
                        b23 = "♦13"
                    ElseIf s = 27 Then
                        b23 = "♤1"
                    ElseIf s = 28 Then
                        b23 = "♤2"
                    ElseIf s = 29 Then
                        b23 = "♤3"
                    ElseIf s = 30 Then
                        b23 = "♤4"
                    ElseIf s = 31 Then
                        b23 = "♤5"
                    ElseIf s = 32 Then
                        b23 = "♤6"
                    ElseIf s = 33 Then
                        b23 = "♤7"
                    ElseIf s = 34 Then
                        b23 = "♤8"
                    ElseIf s = 35 Then
                        b23 = "♤9"
                    ElseIf s = 36 Then
                        b23 = "♤10"
                    ElseIf s = 37 Then
                        b23 = "♤11"
                    ElseIf s = 38 Then
                        b23 = "♤12"
                    ElseIf s = 39 Then
                        b23 = "♤13"
                    ElseIf s = 40 Then
                        b23 = "♧1"
                    ElseIf s = 41 Then
                        b23 = "♧2"
                    ElseIf s = 42 Then
                        b23 = "♧3"
                    ElseIf s = 43 Then
                        b23 = "♧4"
                    ElseIf s = 44 Then
                        b23 = "♧5"
                    ElseIf s = 45 Then
                        b23 = "♧6"
                    ElseIf s = 46 Then
                        b23 = "♧7"
                    ElseIf s = 47 Then
                        b23 = "♧8"
                    ElseIf s = 48 Then
                        b23 = "♧9"
                    ElseIf s = 49 Then
                        b23 = "♧10"
                    ElseIf s = 50 Then
                        b23 = "♧11"
                    ElseIf s = 51 Then
                        b23 = "♧12"
                    ElseIf s = 52 Then
                        b23 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 24 And b24 = "" Then
                    If s = 1 Then
                        b24 = "♥1"
                    ElseIf s = 2 Then
                        b24 = "♥2"
                    ElseIf s = 3 Then
                        b24 = "♥3"
                    ElseIf s = 3 Then
                        b24 = "♥3"
                    ElseIf s = 4 Then
                        b24 = "♥4"
                    ElseIf s = 4 Then
                        b24 = "♥4"
                    ElseIf s = 5 Then
                        b24 = "♥5"
                    ElseIf s = 5 Then
                        b24 = "♥5"
                    ElseIf s = 6 Then
                        b24 = "♥6"
                    ElseIf s = 6 Then
                        b24 = "♥6"
                    ElseIf s = 7 Then
                        b24 = "♥7"
                    ElseIf s = 7 Then
                        b24 = "♥7"
                    ElseIf s = 8 Then
                        b24 = "♥8"
                    ElseIf s = 8 Then
                        b24 = "♥8"
                    ElseIf s = 9 Then
                        b24 = "♥9"
                    ElseIf s = 9 Then
                        b24 = "♥9"
                    ElseIf s = 10 Then
                        b24 = "♥10"
                    ElseIf s = 10 Then
                        b24 = "♥10"
                    ElseIf s = 11 Then
                        b24 = "♥11"
                    ElseIf s = 11 Then
                        b24 = "♥11"
                    ElseIf s = 12 Then
                        b24 = "♥12"
                    ElseIf s = 12 Then
                        b24 = "♥12"
                    ElseIf s = 13 Then
                        b24 = "♥13"
                    ElseIf s = 13 Then
                        b24 = "♥13"
                    ElseIf s = 14 Then
                        b24 = "♦1"
                    ElseIf s = 15 Then
                        b24 = "♦2"
                    ElseIf s = 16 Then
                        b24 = "♦3"
                    ElseIf s = 17 Then
                        b24 = "♦4"
                    ElseIf s = 18 Then
                        b24 = "♦5"
                    ElseIf s = 19 Then
                        b24 = "♦6"
                    ElseIf s = 20 Then
                        b24 = "♦7"
                    ElseIf s = 21 Then
                        b24 = "♦8"
                    ElseIf s = 22 Then
                        b24 = "♦9"
                    ElseIf s = 23 Then
                        b24 = "♦10"
                    ElseIf s = 24 Then
                        b24 = "♦11"
                    ElseIf s = 25 Then
                        b24 = "♦12"
                    ElseIf s = 26 Then
                        b24 = "♦13"
                    ElseIf s = 27 Then
                        b24 = "♤1"
                    ElseIf s = 28 Then
                        b24 = "♤2"
                    ElseIf s = 29 Then
                        b24 = "♤3"
                    ElseIf s = 30 Then
                        b24 = "♤4"
                    ElseIf s = 31 Then
                        b24 = "♤5"
                    ElseIf s = 32 Then
                        b24 = "♤6"
                    ElseIf s = 33 Then
                        b24 = "♤7"
                    ElseIf s = 34 Then
                        b24 = "♤8"
                    ElseIf s = 35 Then
                        b24 = "♤9"
                    ElseIf s = 36 Then
                        b24 = "♤10"
                    ElseIf s = 37 Then
                        b24 = "♤11"
                    ElseIf s = 38 Then
                        b24 = "♤12"
                    ElseIf s = 39 Then
                        b24 = "♤13"
                    ElseIf s = 40 Then
                        b24 = "♧1"
                    ElseIf s = 41 Then
                        b24 = "♧2"
                    ElseIf s = 42 Then
                        b24 = "♧3"
                    ElseIf s = 43 Then
                        b24 = "♧4"
                    ElseIf s = 44 Then
                        b24 = "♧5"
                    ElseIf s = 45 Then
                        b24 = "♧6"
                    ElseIf s = 46 Then
                        b24 = "♧7"
                    ElseIf s = 47 Then
                        b24 = "♧8"
                    ElseIf s = 48 Then
                        b24 = "♧9"
                    ElseIf s = 49 Then
                        b24 = "♧10"
                    ElseIf s = 50 Then
                        b24 = "♧11"
                    ElseIf s = 51 Then
                        b24 = "♧12"
                    ElseIf s = 52 Then
                        b24 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 25 And b25 = "" Then
                    If s = 1 Then
                        b25 = "♥1"
                    ElseIf s = 2 Then
                        b25 = "♥2"
                    ElseIf s = 3 Then
                        b25 = "♥3"
                    ElseIf s = 3 Then
                        b25 = "♥3"
                    ElseIf s = 4 Then
                        b25 = "♥4"
                    ElseIf s = 4 Then
                        b25 = "♥4"
                    ElseIf s = 5 Then
                        b25 = "♥5"
                    ElseIf s = 5 Then
                        b25 = "♥5"
                    ElseIf s = 6 Then
                        b25 = "♥6"
                    ElseIf s = 6 Then
                        b25 = "♥6"
                    ElseIf s = 7 Then
                        b25 = "♥7"
                    ElseIf s = 7 Then
                        b25 = "♥7"
                    ElseIf s = 8 Then
                        b25 = "♥8"
                    ElseIf s = 8 Then
                        b25 = "♥8"
                    ElseIf s = 9 Then
                        b25 = "♥9"
                    ElseIf s = 9 Then
                        b25 = "♥9"
                    ElseIf s = 10 Then
                        b25 = "♥10"
                    ElseIf s = 10 Then
                        b25 = "♥10"
                    ElseIf s = 11 Then
                        b25 = "♥11"
                    ElseIf s = 11 Then
                        b25 = "♥11"
                    ElseIf s = 12 Then
                        b25 = "♥12"
                    ElseIf s = 12 Then
                        b25 = "♥12"
                    ElseIf s = 13 Then
                        b25 = "♥13"
                    ElseIf s = 13 Then
                        b25 = "♥13"
                    ElseIf s = 14 Then
                        b25 = "♦1"
                    ElseIf s = 15 Then
                        b25 = "♦2"
                    ElseIf s = 16 Then
                        b25 = "♦3"
                    ElseIf s = 17 Then
                        b25 = "♦4"
                    ElseIf s = 18 Then
                        b25 = "♦5"
                    ElseIf s = 19 Then
                        b25 = "♦6"
                    ElseIf s = 20 Then
                        b25 = "♦7"
                    ElseIf s = 21 Then
                        b25 = "♦8"
                    ElseIf s = 22 Then
                        b25 = "♦9"
                    ElseIf s = 23 Then
                        b25 = "♦10"
                    ElseIf s = 24 Then
                        b25 = "♦11"
                    ElseIf s = 25 Then
                        b25 = "♦12"
                    ElseIf s = 26 Then
                        b25 = "♦13"
                    ElseIf s = 27 Then
                        b25 = "♤1"
                    ElseIf s = 28 Then
                        b25 = "♤2"
                    ElseIf s = 29 Then
                        b25 = "♤3"
                    ElseIf s = 30 Then
                        b25 = "♤4"
                    ElseIf s = 31 Then
                        b25 = "♤5"
                    ElseIf s = 32 Then
                        b25 = "♤6"
                    ElseIf s = 33 Then
                        b25 = "♤7"
                    ElseIf s = 34 Then
                        b25 = "♤8"
                    ElseIf s = 35 Then
                        b25 = "♤9"
                    ElseIf s = 36 Then
                        b25 = "♤10"
                    ElseIf s = 37 Then
                        b25 = "♤11"
                    ElseIf s = 38 Then
                        b25 = "♤12"
                    ElseIf s = 39 Then
                        b25 = "♤13"
                    ElseIf s = 40 Then
                        b25 = "♧1"
                    ElseIf s = 41 Then
                        b25 = "♧2"
                    ElseIf s = 42 Then
                        b25 = "♧3"
                    ElseIf s = 43 Then
                        b25 = "♧4"
                    ElseIf s = 44 Then
                        b25 = "♧5"
                    ElseIf s = 45 Then
                        b25 = "♧6"
                    ElseIf s = 46 Then
                        b25 = "♧7"
                    ElseIf s = 47 Then
                        b25 = "♧8"
                    ElseIf s = 48 Then
                        b25 = "♧9"
                    ElseIf s = 49 Then
                        b25 = "♧10"
                    ElseIf s = 50 Then
                        b25 = "♧11"
                    ElseIf s = 51 Then
                        b25 = "♧12"
                    ElseIf s = 52 Then
                        b25 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 26 And b26 = "" Then
                    If s = 1 Then
                        b26 = "♥1"
                    ElseIf s = 2 Then
                        b26 = "♥2"
                    ElseIf s = 3 Then
                        b26 = "♥3"
                    ElseIf s = 3 Then
                        b26 = "♥3"
                    ElseIf s = 4 Then
                        b26 = "♥4"
                    ElseIf s = 4 Then
                        b26 = "♥4"
                    ElseIf s = 5 Then
                        b26 = "♥5"
                    ElseIf s = 5 Then
                        b26 = "♥5"
                    ElseIf s = 6 Then
                        b26 = "♥6"
                    ElseIf s = 6 Then
                        b26 = "♥6"
                    ElseIf s = 7 Then
                        b26 = "♥7"
                    ElseIf s = 7 Then
                        b26 = "♥7"
                    ElseIf s = 8 Then
                        b26 = "♥8"
                    ElseIf s = 8 Then
                        b26 = "♥8"
                    ElseIf s = 9 Then
                        b26 = "♥9"
                    ElseIf s = 9 Then
                        b26 = "♥9"
                    ElseIf s = 10 Then
                        b26 = "♥10"
                    ElseIf s = 10 Then
                        b26 = "♥10"
                    ElseIf s = 11 Then
                        b26 = "♥11"
                    ElseIf s = 11 Then
                        b26 = "♥11"
                    ElseIf s = 12 Then
                        b26 = "♥12"
                    ElseIf s = 12 Then
                        b26 = "♥12"
                    ElseIf s = 13 Then
                        b26 = "♥13"
                    ElseIf s = 13 Then
                        b26 = "♥13"
                    ElseIf s = 14 Then
                        b26 = "♦1"
                    ElseIf s = 15 Then
                        b26 = "♦2"
                    ElseIf s = 16 Then
                        b26 = "♦3"
                    ElseIf s = 17 Then
                        b26 = "♦4"
                    ElseIf s = 18 Then
                        b26 = "♦5"
                    ElseIf s = 19 Then
                        b26 = "♦6"
                    ElseIf s = 20 Then
                        b26 = "♦7"
                    ElseIf s = 21 Then
                        b26 = "♦8"
                    ElseIf s = 22 Then
                        b26 = "♦9"
                    ElseIf s = 23 Then
                        b26 = "♦10"
                    ElseIf s = 24 Then
                        b26 = "♦11"
                    ElseIf s = 25 Then
                        b26 = "♦12"
                    ElseIf s = 26 Then
                        b26 = "♦13"
                    ElseIf s = 27 Then
                        b26 = "♤1"
                    ElseIf s = 28 Then
                        b26 = "♤2"
                    ElseIf s = 29 Then
                        b26 = "♤3"
                    ElseIf s = 30 Then
                        b26 = "♤4"
                    ElseIf s = 31 Then
                        b26 = "♤5"
                    ElseIf s = 32 Then
                        b26 = "♤6"
                    ElseIf s = 33 Then
                        b26 = "♤7"
                    ElseIf s = 34 Then
                        b26 = "♤8"
                    ElseIf s = 35 Then
                        b26 = "♤9"
                    ElseIf s = 36 Then
                        b26 = "♤10"
                    ElseIf s = 37 Then
                        b26 = "♤11"
                    ElseIf s = 38 Then
                        b26 = "♤12"
                    ElseIf s = 39 Then
                        b26 = "♤13"
                    ElseIf s = 40 Then
                        b26 = "♧1"
                    ElseIf s = 41 Then
                        b26 = "♧2"
                    ElseIf s = 42 Then
                        b26 = "♧3"
                    ElseIf s = 43 Then
                        b26 = "♧4"
                    ElseIf s = 44 Then
                        b26 = "♧5"
                    ElseIf s = 45 Then
                        b26 = "♧6"
                    ElseIf s = 46 Then
                        b26 = "♧7"
                    ElseIf s = 47 Then
                        b26 = "♧8"
                    ElseIf s = 48 Then
                        b26 = "♧9"
                    ElseIf s = 49 Then
                        b26 = "♧10"
                    ElseIf s = 50 Then
                        b26 = "♧11"
                    ElseIf s = 51 Then
                        b26 = "♧12"
                    ElseIf s = 52 Then
                        b26 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 27 And b27 = "" Then
                    If s = 1 Then
                        b27 = "♥1"
                    ElseIf s = 2 Then
                        b27 = "♥2"
                    ElseIf s = 3 Then
                        b27 = "♥3"
                    ElseIf s = 3 Then
                        b27 = "♥3"
                    ElseIf s = 4 Then
                        b27 = "♥4"
                    ElseIf s = 4 Then
                        b27 = "♥4"
                    ElseIf s = 5 Then
                        b27 = "♥5"
                    ElseIf s = 5 Then
                        b27 = "♥5"
                    ElseIf s = 6 Then
                        b27 = "♥6"
                    ElseIf s = 6 Then
                        b27 = "♥6"
                    ElseIf s = 7 Then
                        b27 = "♥7"
                    ElseIf s = 7 Then
                        b27 = "♥7"
                    ElseIf s = 8 Then
                        b27 = "♥8"
                    ElseIf s = 8 Then
                        b27 = "♥8"
                    ElseIf s = 9 Then
                        b27 = "♥9"
                    ElseIf s = 9 Then
                        b27 = "♥9"
                    ElseIf s = 10 Then
                        b27 = "♥10"
                    ElseIf s = 10 Then
                        b27 = "♥10"
                    ElseIf s = 11 Then
                        b27 = "♥11"
                    ElseIf s = 11 Then
                        b27 = "♥11"
                    ElseIf s = 12 Then
                        b27 = "♥12"
                    ElseIf s = 12 Then
                        b27 = "♥12"
                    ElseIf s = 13 Then
                        b27 = "♥13"
                    ElseIf s = 13 Then
                        b27 = "♥13"
                    ElseIf s = 14 Then
                        b27 = "♦1"
                    ElseIf s = 15 Then
                        b27 = "♦2"
                    ElseIf s = 16 Then
                        b27 = "♦3"
                    ElseIf s = 17 Then
                        b27 = "♦4"
                    ElseIf s = 18 Then
                        b27 = "♦5"
                    ElseIf s = 19 Then
                        b27 = "♦6"
                    ElseIf s = 20 Then
                        b27 = "♦7"
                    ElseIf s = 21 Then
                        b27 = "♦8"
                    ElseIf s = 22 Then
                        b27 = "♦9"
                    ElseIf s = 23 Then
                        b27 = "♦10"
                    ElseIf s = 24 Then
                        b27 = "♦11"
                    ElseIf s = 25 Then
                        b27 = "♦12"
                    ElseIf s = 26 Then
                        b27 = "♦13"
                    ElseIf s = 27 Then
                        b27 = "♤1"
                    ElseIf s = 28 Then
                        b27 = "♤2"
                    ElseIf s = 29 Then
                        b27 = "♤3"
                    ElseIf s = 30 Then
                        b27 = "♤4"
                    ElseIf s = 31 Then
                        b27 = "♤5"
                    ElseIf s = 32 Then
                        b27 = "♤6"
                    ElseIf s = 33 Then
                        b27 = "♤7"
                    ElseIf s = 34 Then
                        b27 = "♤8"
                    ElseIf s = 35 Then
                        b27 = "♤9"
                    ElseIf s = 36 Then
                        b27 = "♤10"
                    ElseIf s = 37 Then
                        b27 = "♤11"
                    ElseIf s = 38 Then
                        b27 = "♤12"
                    ElseIf s = 39 Then
                        b27 = "♤13"
                    ElseIf s = 40 Then
                        b27 = "♧1"
                    ElseIf s = 41 Then
                        b27 = "♧2"
                    ElseIf s = 42 Then
                        b27 = "♧3"
                    ElseIf s = 43 Then
                        b27 = "♧4"
                    ElseIf s = 44 Then
                        b27 = "♧5"
                    ElseIf s = 45 Then
                        b27 = "♧6"
                    ElseIf s = 46 Then
                        b27 = "♧7"
                    ElseIf s = 47 Then
                        b27 = "♧8"
                    ElseIf s = 48 Then
                        b27 = "♧9"
                    ElseIf s = 49 Then
                        b27 = "♧10"
                    ElseIf s = 50 Then
                        b27 = "♧11"
                    ElseIf s = 51 Then
                        b27 = "♧12"
                    ElseIf s = 52 Then
                        b27 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 28 And b28 = "" Then
                    If s = 1 Then
                        b28 = "♥1"
                    ElseIf s = 2 Then
                        b28 = "♥2"
                    ElseIf s = 3 Then
                        b28 = "♥3"
                    ElseIf s = 3 Then
                        b28 = "♥3"
                    ElseIf s = 4 Then
                        b28 = "♥4"
                    ElseIf s = 4 Then
                        b28 = "♥4"
                    ElseIf s = 5 Then
                        b28 = "♥5"
                    ElseIf s = 5 Then
                        b28 = "♥5"
                    ElseIf s = 6 Then
                        b28 = "♥6"
                    ElseIf s = 6 Then
                        b28 = "♥6"
                    ElseIf s = 7 Then
                        b28 = "♥7"
                    ElseIf s = 7 Then
                        b28 = "♥7"
                    ElseIf s = 8 Then
                        b28 = "♥8"
                    ElseIf s = 8 Then
                        b28 = "♥8"
                    ElseIf s = 9 Then
                        b28 = "♥9"
                    ElseIf s = 9 Then
                        b28 = "♥9"
                    ElseIf s = 10 Then
                        b28 = "♥10"
                    ElseIf s = 10 Then
                        b28 = "♥10"
                    ElseIf s = 11 Then
                        b28 = "♥11"
                    ElseIf s = 11 Then
                        b28 = "♥11"
                    ElseIf s = 12 Then
                        b28 = "♥12"
                    ElseIf s = 12 Then
                        b28 = "♥12"
                    ElseIf s = 13 Then
                        b28 = "♥13"
                    ElseIf s = 13 Then
                        b28 = "♥13"
                    ElseIf s = 14 Then
                        b28 = "♦1"
                    ElseIf s = 15 Then
                        b28 = "♦2"
                    ElseIf s = 16 Then
                        b28 = "♦3"
                    ElseIf s = 17 Then
                        b28 = "♦4"
                    ElseIf s = 18 Then
                        b28 = "♦5"
                    ElseIf s = 19 Then
                        b28 = "♦6"
                    ElseIf s = 20 Then
                        b28 = "♦7"
                    ElseIf s = 21 Then
                        b28 = "♦8"
                    ElseIf s = 22 Then
                        b28 = "♦9"
                    ElseIf s = 23 Then
                        b28 = "♦10"
                    ElseIf s = 24 Then
                        b28 = "♦11"
                    ElseIf s = 25 Then
                        b28 = "♦12"
                    ElseIf s = 26 Then
                        b28 = "♦13"
                    ElseIf s = 27 Then
                        b28 = "♤1"
                    ElseIf s = 28 Then
                        b28 = "♤2"
                    ElseIf s = 29 Then
                        b28 = "♤3"
                    ElseIf s = 30 Then
                        b28 = "♤4"
                    ElseIf s = 31 Then
                        b28 = "♤5"
                    ElseIf s = 32 Then
                        b28 = "♤6"
                    ElseIf s = 33 Then
                        b28 = "♤7"
                    ElseIf s = 34 Then
                        b28 = "♤8"
                    ElseIf s = 35 Then
                        b28 = "♤9"
                    ElseIf s = 36 Then
                        b28 = "♤10"
                    ElseIf s = 37 Then
                        b28 = "♤11"
                    ElseIf s = 38 Then
                        b28 = "♤12"
                    ElseIf s = 39 Then
                        b28 = "♤13"
                    ElseIf s = 40 Then
                        b28 = "♧1"
                    ElseIf s = 41 Then
                        b28 = "♧2"
                    ElseIf s = 42 Then
                        b28 = "♧3"
                    ElseIf s = 43 Then
                        b28 = "♧4"
                    ElseIf s = 44 Then
                        b28 = "♧5"
                    ElseIf s = 45 Then
                        b28 = "♧6"
                    ElseIf s = 46 Then
                        b28 = "♧7"
                    ElseIf s = 47 Then
                        b28 = "♧8"
                    ElseIf s = 48 Then
                        b28 = "♧9"
                    ElseIf s = 49 Then
                        b28 = "♧10"
                    ElseIf s = 50 Then
                        b28 = "♧11"
                    ElseIf s = 51 Then
                        b28 = "♧12"
                    ElseIf s = 52 Then
                        b28 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 29 And b29 = "" Then
                    If s = 1 Then
                        b29 = "♥1"
                    ElseIf s = 2 Then
                        b29 = "♥2"
                    ElseIf s = 3 Then
                        b29 = "♥3"
                    ElseIf s = 3 Then
                        b29 = "♥3"
                    ElseIf s = 4 Then
                        b29 = "♥4"
                    ElseIf s = 4 Then
                        b29 = "♥4"
                    ElseIf s = 5 Then
                        b29 = "♥5"
                    ElseIf s = 5 Then
                        b29 = "♥5"
                    ElseIf s = 6 Then
                        b29 = "♥6"
                    ElseIf s = 6 Then
                        b29 = "♥6"
                    ElseIf s = 7 Then
                        b29 = "♥7"
                    ElseIf s = 7 Then
                        b29 = "♥7"
                    ElseIf s = 8 Then
                        b29 = "♥8"
                    ElseIf s = 8 Then
                        b29 = "♥8"
                    ElseIf s = 9 Then
                        b29 = "♥9"
                    ElseIf s = 9 Then
                        b29 = "♥9"
                    ElseIf s = 10 Then
                        b29 = "♥10"
                    ElseIf s = 10 Then
                        b29 = "♥10"
                    ElseIf s = 11 Then
                        b29 = "♥11"
                    ElseIf s = 11 Then
                        b29 = "♥11"
                    ElseIf s = 12 Then
                        b29 = "♥12"
                    ElseIf s = 12 Then
                        b29 = "♥12"
                    ElseIf s = 13 Then
                        b29 = "♥13"
                    ElseIf s = 13 Then
                        b29 = "♥13"
                    ElseIf s = 14 Then
                        b29 = "♦1"
                    ElseIf s = 15 Then
                        b29 = "♦2"
                    ElseIf s = 16 Then
                        b29 = "♦3"
                    ElseIf s = 17 Then
                        b29 = "♦4"
                    ElseIf s = 18 Then
                        b29 = "♦5"
                    ElseIf s = 19 Then
                        b29 = "♦6"
                    ElseIf s = 20 Then
                        b29 = "♦7"
                    ElseIf s = 21 Then
                        b29 = "♦8"
                    ElseIf s = 22 Then
                        b29 = "♦9"
                    ElseIf s = 23 Then
                        b29 = "♦10"
                    ElseIf s = 24 Then
                        b29 = "♦11"
                    ElseIf s = 25 Then
                        b29 = "♦12"
                    ElseIf s = 26 Then
                        b29 = "♦13"
                    ElseIf s = 27 Then
                        b29 = "♤1"
                    ElseIf s = 28 Then
                        b29 = "♤2"
                    ElseIf s = 29 Then
                        b29 = "♤3"
                    ElseIf s = 30 Then
                        b29 = "♤4"
                    ElseIf s = 31 Then
                        b29 = "♤5"
                    ElseIf s = 32 Then
                        b29 = "♤6"
                    ElseIf s = 33 Then
                        b29 = "♤7"
                    ElseIf s = 34 Then
                        b29 = "♤8"
                    ElseIf s = 35 Then
                        b29 = "♤9"
                    ElseIf s = 36 Then
                        b29 = "♤10"
                    ElseIf s = 37 Then
                        b29 = "♤11"
                    ElseIf s = 38 Then
                        b29 = "♤12"
                    ElseIf s = 39 Then
                        b29 = "♤13"
                    ElseIf s = 40 Then
                        b29 = "♧1"
                    ElseIf s = 41 Then
                        b29 = "♧2"
                    ElseIf s = 42 Then
                        b29 = "♧3"
                    ElseIf s = 43 Then
                        b29 = "♧4"
                    ElseIf s = 44 Then
                        b29 = "♧5"
                    ElseIf s = 45 Then
                        b29 = "♧6"
                    ElseIf s = 46 Then
                        b29 = "♧7"
                    ElseIf s = 47 Then
                        b29 = "♧8"
                    ElseIf s = 48 Then
                        b29 = "♧9"
                    ElseIf s = 49 Then
                        b29 = "♧10"
                    ElseIf s = 50 Then
                        b29 = "♧11"
                    ElseIf s = 51 Then
                        b29 = "♧12"
                    ElseIf s = 52 Then
                        b29 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 30 And b30 = "" Then
                    If s = 1 Then
                        b30 = "♥1"
                    ElseIf s = 2 Then
                        b30 = "♥2"
                    ElseIf s = 3 Then
                        b30 = "♥3"
                    ElseIf s = 3 Then
                        b30 = "♥3"
                    ElseIf s = 4 Then
                        b30 = "♥4"
                    ElseIf s = 4 Then
                        b30 = "♥4"
                    ElseIf s = 5 Then
                        b30 = "♥5"
                    ElseIf s = 5 Then
                        b30 = "♥5"
                    ElseIf s = 6 Then
                        b30 = "♥6"
                    ElseIf s = 6 Then
                        b30 = "♥6"
                    ElseIf s = 7 Then
                        b30 = "♥7"
                    ElseIf s = 7 Then
                        b30 = "♥7"
                    ElseIf s = 8 Then
                        b30 = "♥8"
                    ElseIf s = 8 Then
                        b30 = "♥8"
                    ElseIf s = 9 Then
                        b30 = "♥9"
                    ElseIf s = 9 Then
                        b30 = "♥9"
                    ElseIf s = 10 Then
                        b30 = "♥10"
                    ElseIf s = 10 Then
                        b30 = "♥10"
                    ElseIf s = 11 Then
                        b30 = "♥11"
                    ElseIf s = 11 Then
                        b30 = "♥11"
                    ElseIf s = 12 Then
                        b30 = "♥12"
                    ElseIf s = 12 Then
                        b30 = "♥12"
                    ElseIf s = 13 Then
                        b30 = "♥13"
                    ElseIf s = 13 Then
                        b30 = "♥13"
                    ElseIf s = 14 Then
                        b30 = "♦1"
                    ElseIf s = 15 Then
                        b30 = "♦2"
                    ElseIf s = 16 Then
                        b30 = "♦3"
                    ElseIf s = 17 Then
                        b30 = "♦4"
                    ElseIf s = 18 Then
                        b30 = "♦5"
                    ElseIf s = 19 Then
                        b30 = "♦6"
                    ElseIf s = 20 Then
                        b30 = "♦7"
                    ElseIf s = 21 Then
                        b30 = "♦8"
                    ElseIf s = 22 Then
                        b30 = "♦9"
                    ElseIf s = 23 Then
                        b30 = "♦10"
                    ElseIf s = 24 Then
                        b30 = "♦11"
                    ElseIf s = 25 Then
                        b30 = "♦12"
                    ElseIf s = 26 Then
                        b30 = "♦13"
                    ElseIf s = 27 Then
                        b30 = "♤1"
                    ElseIf s = 28 Then
                        b30 = "♤2"
                    ElseIf s = 29 Then
                        b30 = "♤3"
                    ElseIf s = 30 Then
                        b30 = "♤4"
                    ElseIf s = 31 Then
                        b30 = "♤5"
                    ElseIf s = 32 Then
                        b30 = "♤6"
                    ElseIf s = 33 Then
                        b30 = "♤7"
                    ElseIf s = 34 Then
                        b30 = "♤8"
                    ElseIf s = 35 Then
                        b30 = "♤9"
                    ElseIf s = 36 Then
                        b30 = "♤10"
                    ElseIf s = 37 Then
                        b30 = "♤11"
                    ElseIf s = 38 Then
                        b30 = "♤12"
                    ElseIf s = 39 Then
                        b30 = "♤13"
                    ElseIf s = 40 Then
                        b30 = "♧1"
                    ElseIf s = 41 Then
                        b30 = "♧2"
                    ElseIf s = 42 Then
                        b30 = "♧3"
                    ElseIf s = 43 Then
                        b30 = "♧4"
                    ElseIf s = 44 Then
                        b30 = "♧5"
                    ElseIf s = 45 Then
                        b30 = "♧6"
                    ElseIf s = 46 Then
                        b30 = "♧7"
                    ElseIf s = 47 Then
                        b30 = "♧8"
                    ElseIf s = 48 Then
                        b30 = "♧9"
                    ElseIf s = 49 Then
                        b30 = "♧10"
                    ElseIf s = 50 Then
                        b30 = "♧11"
                    ElseIf s = 51 Then
                        b30 = "♧12"
                    ElseIf s = 52 Then
                        b30 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 31 And b31 = "" Then
                    If s = 1 Then
                        b31 = "♥1"
                    ElseIf s = 2 Then
                        b31 = "♥2"
                    ElseIf s = 3 Then
                        b31 = "♥3"
                    ElseIf s = 3 Then
                        b31 = "♥3"
                    ElseIf s = 4 Then
                        b31 = "♥4"
                    ElseIf s = 4 Then
                        b31 = "♥4"
                    ElseIf s = 5 Then
                        b31 = "♥5"
                    ElseIf s = 5 Then
                        b31 = "♥5"
                    ElseIf s = 6 Then
                        b31 = "♥6"
                    ElseIf s = 6 Then
                        b31 = "♥6"
                    ElseIf s = 7 Then
                        b31 = "♥7"
                    ElseIf s = 7 Then
                        b31 = "♥7"
                    ElseIf s = 8 Then
                        b31 = "♥8"
                    ElseIf s = 8 Then
                        b31 = "♥8"
                    ElseIf s = 9 Then
                        b31 = "♥9"
                    ElseIf s = 9 Then
                        b31 = "♥9"
                    ElseIf s = 10 Then
                        b31 = "♥10"
                    ElseIf s = 10 Then
                        b31 = "♥10"
                    ElseIf s = 11 Then
                        b31 = "♥11"
                    ElseIf s = 11 Then
                        b31 = "♥11"
                    ElseIf s = 12 Then
                        b31 = "♥12"
                    ElseIf s = 12 Then
                        b31 = "♥12"
                    ElseIf s = 13 Then
                        b31 = "♥13"
                    ElseIf s = 13 Then
                        b31 = "♥13"
                    ElseIf s = 14 Then
                        b31 = "♦1"
                    ElseIf s = 15 Then
                        b31 = "♦2"
                    ElseIf s = 16 Then
                        b31 = "♦3"
                    ElseIf s = 17 Then
                        b31 = "♦4"
                    ElseIf s = 18 Then
                        b31 = "♦5"
                    ElseIf s = 19 Then
                        b31 = "♦6"
                    ElseIf s = 20 Then
                        b31 = "♦7"
                    ElseIf s = 21 Then
                        b31 = "♦8"
                    ElseIf s = 22 Then
                        b31 = "♦9"
                    ElseIf s = 23 Then
                        b31 = "♦10"
                    ElseIf s = 24 Then
                        b31 = "♦11"
                    ElseIf s = 25 Then
                        b31 = "♦12"
                    ElseIf s = 26 Then
                        b31 = "♦13"
                    ElseIf s = 27 Then
                        b31 = "♤1"
                    ElseIf s = 28 Then
                        b31 = "♤2"
                    ElseIf s = 29 Then
                        b31 = "♤3"
                    ElseIf s = 30 Then
                        b31 = "♤4"
                    ElseIf s = 31 Then
                        b31 = "♤5"
                    ElseIf s = 32 Then
                        b31 = "♤6"
                    ElseIf s = 33 Then
                        b31 = "♤7"
                    ElseIf s = 34 Then
                        b31 = "♤8"
                    ElseIf s = 35 Then
                        b31 = "♤9"
                    ElseIf s = 36 Then
                        b31 = "♤10"
                    ElseIf s = 37 Then
                        b31 = "♤11"
                    ElseIf s = 38 Then
                        b31 = "♤12"
                    ElseIf s = 39 Then
                        b31 = "♤13"
                    ElseIf s = 40 Then
                        b31 = "♧1"
                    ElseIf s = 41 Then
                        b31 = "♧2"
                    ElseIf s = 42 Then
                        b31 = "♧3"
                    ElseIf s = 43 Then
                        b31 = "♧4"
                    ElseIf s = 44 Then
                        b31 = "♧5"
                    ElseIf s = 45 Then
                        b31 = "♧6"
                    ElseIf s = 46 Then
                        b31 = "♧7"
                    ElseIf s = 47 Then
                        b31 = "♧8"
                    ElseIf s = 48 Then
                        b31 = "♧9"
                    ElseIf s = 49 Then
                        b31 = "♧10"
                    ElseIf s = 50 Then
                        b31 = "♧11"
                    ElseIf s = 51 Then
                        b31 = "♧12"
                    ElseIf s = 52 Then
                        b31 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 32 And b32 = "" Then
                    If s = 1 Then
                        b32 = "♥1"
                    ElseIf s = 2 Then
                        b32 = "♥2"
                    ElseIf s = 3 Then
                        b32 = "♥3"
                    ElseIf s = 3 Then
                        b32 = "♥3"
                    ElseIf s = 4 Then
                        b32 = "♥4"
                    ElseIf s = 4 Then
                        b32 = "♥4"
                    ElseIf s = 5 Then
                        b32 = "♥5"
                    ElseIf s = 5 Then
                        b32 = "♥5"
                    ElseIf s = 6 Then
                        b32 = "♥6"
                    ElseIf s = 6 Then
                        b32 = "♥6"
                    ElseIf s = 7 Then
                        b32 = "♥7"
                    ElseIf s = 7 Then
                        b32 = "♥7"
                    ElseIf s = 8 Then
                        b32 = "♥8"
                    ElseIf s = 8 Then
                        b32 = "♥8"
                    ElseIf s = 9 Then
                        b32 = "♥9"
                    ElseIf s = 9 Then
                        b32 = "♥9"
                    ElseIf s = 10 Then
                        b32 = "♥10"
                    ElseIf s = 10 Then
                        b32 = "♥10"
                    ElseIf s = 11 Then
                        b32 = "♥11"
                    ElseIf s = 11 Then
                        b32 = "♥11"
                    ElseIf s = 12 Then
                        b32 = "♥12"
                    ElseIf s = 12 Then
                        b32 = "♥12"
                    ElseIf s = 13 Then
                        b32 = "♥13"
                    ElseIf s = 13 Then
                        b32 = "♥13"
                    ElseIf s = 14 Then
                        b32 = "♦1"
                    ElseIf s = 15 Then
                        b32 = "♦2"
                    ElseIf s = 16 Then
                        b32 = "♦3"
                    ElseIf s = 17 Then
                        b32 = "♦4"
                    ElseIf s = 18 Then
                        b32 = "♦5"
                    ElseIf s = 19 Then
                        b32 = "♦6"
                    ElseIf s = 20 Then
                        b32 = "♦7"
                    ElseIf s = 21 Then
                        b32 = "♦8"
                    ElseIf s = 22 Then
                        b32 = "♦9"
                    ElseIf s = 23 Then
                        b32 = "♦10"
                    ElseIf s = 24 Then
                        b32 = "♦11"
                    ElseIf s = 25 Then
                        b32 = "♦12"
                    ElseIf s = 26 Then
                        b32 = "♦13"
                    ElseIf s = 27 Then
                        b32 = "♤1"
                    ElseIf s = 28 Then
                        b32 = "♤2"
                    ElseIf s = 29 Then
                        b32 = "♤3"
                    ElseIf s = 30 Then
                        b32 = "♤4"
                    ElseIf s = 31 Then
                        b32 = "♤5"
                    ElseIf s = 32 Then
                        b32 = "♤6"
                    ElseIf s = 33 Then
                        b32 = "♤7"
                    ElseIf s = 34 Then
                        b32 = "♤8"
                    ElseIf s = 35 Then
                        b32 = "♤9"
                    ElseIf s = 36 Then
                        b32 = "♤10"
                    ElseIf s = 37 Then
                        b32 = "♤11"
                    ElseIf s = 38 Then
                        b32 = "♤12"
                    ElseIf s = 39 Then
                        b32 = "♤13"
                    ElseIf s = 40 Then
                        b32 = "♧1"
                    ElseIf s = 41 Then
                        b32 = "♧2"
                    ElseIf s = 42 Then
                        b32 = "♧3"
                    ElseIf s = 43 Then
                        b32 = "♧4"
                    ElseIf s = 44 Then
                        b32 = "♧5"
                    ElseIf s = 45 Then
                        b32 = "♧6"
                    ElseIf s = 46 Then
                        b32 = "♧7"
                    ElseIf s = 47 Then
                        b32 = "♧8"
                    ElseIf s = 48 Then
                        b32 = "♧9"
                    ElseIf s = 49 Then
                        b32 = "♧10"
                    ElseIf s = 50 Then
                        b32 = "♧11"
                    ElseIf s = 51 Then
                        b32 = "♧12"
                    ElseIf s = 52 Then
                        b32 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 33 And b33 = "" Then
                    If s = 1 Then
                        b33 = "♥1"
                    ElseIf s = 2 Then
                        b33 = "♥2"
                    ElseIf s = 3 Then
                        b33 = "♥3"
                    ElseIf s = 3 Then
                        b33 = "♥3"
                    ElseIf s = 4 Then
                        b33 = "♥4"
                    ElseIf s = 4 Then
                        b33 = "♥4"
                    ElseIf s = 5 Then
                        b33 = "♥5"
                    ElseIf s = 5 Then
                        b33 = "♥5"
                    ElseIf s = 6 Then
                        b33 = "♥6"
                    ElseIf s = 6 Then
                        b33 = "♥6"
                    ElseIf s = 7 Then
                        b33 = "♥7"
                    ElseIf s = 7 Then
                        b33 = "♥7"
                    ElseIf s = 8 Then
                        b33 = "♥8"
                    ElseIf s = 8 Then
                        b33 = "♥8"
                    ElseIf s = 9 Then
                        b33 = "♥9"
                    ElseIf s = 9 Then
                        b33 = "♥9"
                    ElseIf s = 10 Then
                        b33 = "♥10"
                    ElseIf s = 10 Then
                        b33 = "♥10"
                    ElseIf s = 11 Then
                        b33 = "♥11"
                    ElseIf s = 11 Then
                        b33 = "♥11"
                    ElseIf s = 12 Then
                        b33 = "♥12"
                    ElseIf s = 12 Then
                        b33 = "♥12"
                    ElseIf s = 13 Then
                        b33 = "♥13"
                    ElseIf s = 13 Then
                        b33 = "♥13"
                    ElseIf s = 14 Then
                        b33 = "♦1"
                    ElseIf s = 15 Then
                        b33 = "♦2"
                    ElseIf s = 16 Then
                        b33 = "♦3"
                    ElseIf s = 17 Then
                        b33 = "♦4"
                    ElseIf s = 18 Then
                        b33 = "♦5"
                    ElseIf s = 19 Then
                        b33 = "♦6"
                    ElseIf s = 20 Then
                        b33 = "♦7"
                    ElseIf s = 21 Then
                        b33 = "♦8"
                    ElseIf s = 22 Then
                        b33 = "♦9"
                    ElseIf s = 23 Then
                        b33 = "♦10"
                    ElseIf s = 24 Then
                        b33 = "♦11"
                    ElseIf s = 25 Then
                        b33 = "♦12"
                    ElseIf s = 26 Then
                        b33 = "♦13"
                    ElseIf s = 27 Then
                        b33 = "♤1"
                    ElseIf s = 28 Then
                        b33 = "♤2"
                    ElseIf s = 29 Then
                        b33 = "♤3"
                    ElseIf s = 30 Then
                        b33 = "♤4"
                    ElseIf s = 31 Then
                        b33 = "♤5"
                    ElseIf s = 32 Then
                        b33 = "♤6"
                    ElseIf s = 33 Then
                        b33 = "♤7"
                    ElseIf s = 34 Then
                        b33 = "♤8"
                    ElseIf s = 35 Then
                        b33 = "♤9"
                    ElseIf s = 36 Then
                        b33 = "♤10"
                    ElseIf s = 37 Then
                        b33 = "♤11"
                    ElseIf s = 38 Then
                        b33 = "♤12"
                    ElseIf s = 39 Then
                        b33 = "♤13"
                    ElseIf s = 40 Then
                        b33 = "♧1"
                    ElseIf s = 41 Then
                        b33 = "♧2"
                    ElseIf s = 42 Then
                        b33 = "♧3"
                    ElseIf s = 43 Then
                        b33 = "♧4"
                    ElseIf s = 44 Then
                        b33 = "♧5"
                    ElseIf s = 45 Then
                        b33 = "♧6"
                    ElseIf s = 46 Then
                        b33 = "♧7"
                    ElseIf s = 47 Then
                        b33 = "♧8"
                    ElseIf s = 48 Then
                        b33 = "♧9"
                    ElseIf s = 49 Then
                        b33 = "♧10"
                    ElseIf s = 50 Then
                        b33 = "♧11"
                    ElseIf s = 51 Then
                        b33 = "♧12"
                    ElseIf s = 52 Then
                        b33 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 34 And b34 = "" Then
                    If s = 1 Then
                        b34 = "♥1"
                    ElseIf s = 2 Then
                        b34 = "♥2"
                    ElseIf s = 3 Then
                        b34 = "♥3"
                    ElseIf s = 3 Then
                        b34 = "♥3"
                    ElseIf s = 4 Then
                        b34 = "♥4"
                    ElseIf s = 4 Then
                        b34 = "♥4"
                    ElseIf s = 5 Then
                        b34 = "♥5"
                    ElseIf s = 5 Then
                        b34 = "♥5"
                    ElseIf s = 6 Then
                        b34 = "♥6"
                    ElseIf s = 6 Then
                        b34 = "♥6"
                    ElseIf s = 7 Then
                        b34 = "♥7"
                    ElseIf s = 7 Then
                        b34 = "♥7"
                    ElseIf s = 8 Then
                        b34 = "♥8"
                    ElseIf s = 8 Then
                        b34 = "♥8"
                    ElseIf s = 9 Then
                        b34 = "♥9"
                    ElseIf s = 9 Then
                        b34 = "♥9"
                    ElseIf s = 10 Then
                        b34 = "♥10"
                    ElseIf s = 10 Then
                        b34 = "♥10"
                    ElseIf s = 11 Then
                        b34 = "♥11"
                    ElseIf s = 11 Then
                        b34 = "♥11"
                    ElseIf s = 12 Then
                        b34 = "♥12"
                    ElseIf s = 12 Then
                        b34 = "♥12"
                    ElseIf s = 13 Then
                        b34 = "♥13"
                    ElseIf s = 13 Then
                        b34 = "♥13"
                    ElseIf s = 14 Then
                        b34 = "♦1"
                    ElseIf s = 15 Then
                        b34 = "♦2"
                    ElseIf s = 16 Then
                        b34 = "♦3"
                    ElseIf s = 17 Then
                        b34 = "♦4"
                    ElseIf s = 18 Then
                        b34 = "♦5"
                    ElseIf s = 19 Then
                        b34 = "♦6"
                    ElseIf s = 20 Then
                        b34 = "♦7"
                    ElseIf s = 21 Then
                        b34 = "♦8"
                    ElseIf s = 22 Then
                        b34 = "♦9"
                    ElseIf s = 23 Then
                        b34 = "♦10"
                    ElseIf s = 24 Then
                        b34 = "♦11"
                    ElseIf s = 25 Then
                        b34 = "♦12"
                    ElseIf s = 26 Then
                        b34 = "♦13"
                    ElseIf s = 27 Then
                        b34 = "♤1"
                    ElseIf s = 28 Then
                        b34 = "♤2"
                    ElseIf s = 29 Then
                        b34 = "♤3"
                    ElseIf s = 30 Then
                        b34 = "♤4"
                    ElseIf s = 31 Then
                        b34 = "♤5"
                    ElseIf s = 32 Then
                        b34 = "♤6"
                    ElseIf s = 33 Then
                        b34 = "♤7"
                    ElseIf s = 34 Then
                        b34 = "♤8"
                    ElseIf s = 35 Then
                        b34 = "♤9"
                    ElseIf s = 36 Then
                        b34 = "♤10"
                    ElseIf s = 37 Then
                        b34 = "♤11"
                    ElseIf s = 38 Then
                        b34 = "♤12"
                    ElseIf s = 39 Then
                        b34 = "♤13"
                    ElseIf s = 40 Then
                        b34 = "♧1"
                    ElseIf s = 41 Then
                        b34 = "♧2"
                    ElseIf s = 42 Then
                        b34 = "♧3"
                    ElseIf s = 43 Then
                        b34 = "♧4"
                    ElseIf s = 44 Then
                        b34 = "♧5"
                    ElseIf s = 45 Then
                        b34 = "♧6"
                    ElseIf s = 46 Then
                        b34 = "♧7"
                    ElseIf s = 47 Then
                        b34 = "♧8"
                    ElseIf s = 48 Then
                        b34 = "♧9"
                    ElseIf s = 49 Then
                        b34 = "♧10"
                    ElseIf s = 50 Then
                        b34 = "♧11"
                    ElseIf s = 51 Then
                        b34 = "♧12"
                    ElseIf s = 52 Then
                        b34 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 35 And b35 = "" Then
                    If s = 1 Then
                        b35 = "♥1"
                    ElseIf s = 2 Then
                        b35 = "♥2"
                    ElseIf s = 3 Then
                        b35 = "♥3"
                    ElseIf s = 3 Then
                        b35 = "♥3"
                    ElseIf s = 4 Then
                        b35 = "♥4"
                    ElseIf s = 4 Then
                        b35 = "♥4"
                    ElseIf s = 5 Then
                        b35 = "♥5"
                    ElseIf s = 5 Then
                        b35 = "♥5"
                    ElseIf s = 6 Then
                        b35 = "♥6"
                    ElseIf s = 6 Then
                        b35 = "♥6"
                    ElseIf s = 7 Then
                        b35 = "♥7"
                    ElseIf s = 7 Then
                        b35 = "♥7"
                    ElseIf s = 8 Then
                        b35 = "♥8"
                    ElseIf s = 8 Then
                        b35 = "♥8"
                    ElseIf s = 9 Then
                        b35 = "♥9"
                    ElseIf s = 9 Then
                        b35 = "♥9"
                    ElseIf s = 10 Then
                        b35 = "♥10"
                    ElseIf s = 10 Then
                        b35 = "♥10"
                    ElseIf s = 11 Then
                        b35 = "♥11"
                    ElseIf s = 11 Then
                        b35 = "♥11"
                    ElseIf s = 12 Then
                        b35 = "♥12"
                    ElseIf s = 12 Then
                        b35 = "♥12"
                    ElseIf s = 13 Then
                        b35 = "♥13"
                    ElseIf s = 13 Then
                        b35 = "♥13"
                    ElseIf s = 14 Then
                        b35 = "♦1"
                    ElseIf s = 15 Then
                        b35 = "♦2"
                    ElseIf s = 16 Then
                        b35 = "♦3"
                    ElseIf s = 17 Then
                        b35 = "♦4"
                    ElseIf s = 18 Then
                        b35 = "♦5"
                    ElseIf s = 19 Then
                        b35 = "♦6"
                    ElseIf s = 20 Then
                        b35 = "♦7"
                    ElseIf s = 21 Then
                        b35 = "♦8"
                    ElseIf s = 22 Then
                        b35 = "♦9"
                    ElseIf s = 23 Then
                        b35 = "♦10"
                    ElseIf s = 24 Then
                        b35 = "♦11"
                    ElseIf s = 25 Then
                        b35 = "♦12"
                    ElseIf s = 26 Then
                        b35 = "♦13"
                    ElseIf s = 27 Then
                        b35 = "♤1"
                    ElseIf s = 28 Then
                        b35 = "♤2"
                    ElseIf s = 29 Then
                        b35 = "♤3"
                    ElseIf s = 30 Then
                        b35 = "♤4"
                    ElseIf s = 31 Then
                        b35 = "♤5"
                    ElseIf s = 32 Then
                        b35 = "♤6"
                    ElseIf s = 33 Then
                        b35 = "♤7"
                    ElseIf s = 34 Then
                        b35 = "♤8"
                    ElseIf s = 35 Then
                        b35 = "♤9"
                    ElseIf s = 36 Then
                        b35 = "♤10"
                    ElseIf s = 37 Then
                        b35 = "♤11"
                    ElseIf s = 38 Then
                        b35 = "♤12"
                    ElseIf s = 39 Then
                        b35 = "♤13"
                    ElseIf s = 40 Then
                        b35 = "♧1"
                    ElseIf s = 41 Then
                        b35 = "♧2"
                    ElseIf s = 42 Then
                        b35 = "♧3"
                    ElseIf s = 43 Then
                        b35 = "♧4"
                    ElseIf s = 44 Then
                        b35 = "♧5"
                    ElseIf s = 45 Then
                        b35 = "♧6"
                    ElseIf s = 46 Then
                        b35 = "♧7"
                    ElseIf s = 47 Then
                        b35 = "♧8"
                    ElseIf s = 48 Then
                        b35 = "♧9"
                    ElseIf s = 49 Then
                        b35 = "♧10"
                    ElseIf s = 50 Then
                        b35 = "♧11"
                    ElseIf s = 51 Then
                        b35 = "♧12"
                    ElseIf s = 52 Then
                        b35 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 36 And b36 = "" Then
                    If s = 1 Then
                        b36 = "♥1"
                    ElseIf s = 2 Then
                        b36 = "♥2"
                    ElseIf s = 3 Then
                        b36 = "♥3"
                    ElseIf s = 3 Then
                        b36 = "♥3"
                    ElseIf s = 4 Then
                        b36 = "♥4"
                    ElseIf s = 4 Then
                        b36 = "♥4"
                    ElseIf s = 5 Then
                        b36 = "♥5"
                    ElseIf s = 5 Then
                        b36 = "♥5"
                    ElseIf s = 6 Then
                        b36 = "♥6"
                    ElseIf s = 6 Then
                        b36 = "♥6"
                    ElseIf s = 7 Then
                        b36 = "♥7"
                    ElseIf s = 7 Then
                        b36 = "♥7"
                    ElseIf s = 8 Then
                        b36 = "♥8"
                    ElseIf s = 8 Then
                        b36 = "♥8"
                    ElseIf s = 9 Then
                        b36 = "♥9"
                    ElseIf s = 9 Then
                        b36 = "♥9"
                    ElseIf s = 10 Then
                        b36 = "♥10"
                    ElseIf s = 10 Then
                        b36 = "♥10"
                    ElseIf s = 11 Then
                        b36 = "♥11"
                    ElseIf s = 11 Then
                        b36 = "♥11"
                    ElseIf s = 12 Then
                        b36 = "♥12"
                    ElseIf s = 12 Then
                        b36 = "♥12"
                    ElseIf s = 13 Then
                        b36 = "♥13"
                    ElseIf s = 13 Then
                        b36 = "♥13"
                    ElseIf s = 14 Then
                        b36 = "♦1"
                    ElseIf s = 15 Then
                        b36 = "♦2"
                    ElseIf s = 16 Then
                        b36 = "♦3"
                    ElseIf s = 17 Then
                        b36 = "♦4"
                    ElseIf s = 18 Then
                        b36 = "♦5"
                    ElseIf s = 19 Then
                        b36 = "♦6"
                    ElseIf s = 20 Then
                        b36 = "♦7"
                    ElseIf s = 21 Then
                        b36 = "♦8"
                    ElseIf s = 22 Then
                        b36 = "♦9"
                    ElseIf s = 23 Then
                        b36 = "♦10"
                    ElseIf s = 24 Then
                        b36 = "♦11"
                    ElseIf s = 25 Then
                        b36 = "♦12"
                    ElseIf s = 26 Then
                        b36 = "♦13"
                    ElseIf s = 27 Then
                        b36 = "♤1"
                    ElseIf s = 28 Then
                        b36 = "♤2"
                    ElseIf s = 29 Then
                        b36 = "♤3"
                    ElseIf s = 30 Then
                        b36 = "♤4"
                    ElseIf s = 31 Then
                        b36 = "♤5"
                    ElseIf s = 32 Then
                        b36 = "♤6"
                    ElseIf s = 33 Then
                        b36 = "♤7"
                    ElseIf s = 34 Then
                        b36 = "♤8"
                    ElseIf s = 35 Then
                        b36 = "♤9"
                    ElseIf s = 36 Then
                        b36 = "♤10"
                    ElseIf s = 37 Then
                        b36 = "♤11"
                    ElseIf s = 38 Then
                        b36 = "♤12"
                    ElseIf s = 39 Then
                        b36 = "♤13"
                    ElseIf s = 40 Then
                        b36 = "♧1"
                    ElseIf s = 41 Then
                        b36 = "♧2"
                    ElseIf s = 42 Then
                        b36 = "♧3"
                    ElseIf s = 43 Then
                        b36 = "♧4"
                    ElseIf s = 44 Then
                        b36 = "♧5"
                    ElseIf s = 45 Then
                        b36 = "♧6"
                    ElseIf s = 46 Then
                        b36 = "♧7"
                    ElseIf s = 47 Then
                        b36 = "♧8"
                    ElseIf s = 48 Then
                        b36 = "♧9"
                    ElseIf s = 49 Then
                        b36 = "♧10"
                    ElseIf s = 50 Then
                        b36 = "♧11"
                    ElseIf s = 51 Then
                        b36 = "♧12"
                    ElseIf s = 52 Then
                        b36 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 37 And b37 = "" Then
                    If s = 1 Then
                        b37 = "♥1"
                    ElseIf s = 2 Then
                        b37 = "♥2"
                    ElseIf s = 3 Then
                        b37 = "♥3"
                    ElseIf s = 3 Then
                        b37 = "♥3"
                    ElseIf s = 4 Then
                        b37 = "♥4"
                    ElseIf s = 4 Then
                        b37 = "♥4"
                    ElseIf s = 5 Then
                        b37 = "♥5"
                    ElseIf s = 5 Then
                        b37 = "♥5"
                    ElseIf s = 6 Then
                        b37 = "♥6"
                    ElseIf s = 6 Then
                        b37 = "♥6"
                    ElseIf s = 7 Then
                        b37 = "♥7"
                    ElseIf s = 7 Then
                        b37 = "♥7"
                    ElseIf s = 8 Then
                        b37 = "♥8"
                    ElseIf s = 8 Then
                        b37 = "♥8"
                    ElseIf s = 9 Then
                        b37 = "♥9"
                    ElseIf s = 9 Then
                        b37 = "♥9"
                    ElseIf s = 10 Then
                        b37 = "♥10"
                    ElseIf s = 10 Then
                        b37 = "♥10"
                    ElseIf s = 11 Then
                        b37 = "♥11"
                    ElseIf s = 11 Then
                        b37 = "♥11"
                    ElseIf s = 12 Then
                        b37 = "♥12"
                    ElseIf s = 12 Then
                        b37 = "♥12"
                    ElseIf s = 13 Then
                        b37 = "♥13"
                    ElseIf s = 13 Then
                        b37 = "♥13"
                    ElseIf s = 14 Then
                        b37 = "♦1"
                    ElseIf s = 15 Then
                        b37 = "♦2"
                    ElseIf s = 16 Then
                        b37 = "♦3"
                    ElseIf s = 17 Then
                        b37 = "♦4"
                    ElseIf s = 18 Then
                        b37 = "♦5"
                    ElseIf s = 19 Then
                        b37 = "♦6"
                    ElseIf s = 20 Then
                        b37 = "♦7"
                    ElseIf s = 21 Then
                        b37 = "♦8"
                    ElseIf s = 22 Then
                        b37 = "♦9"
                    ElseIf s = 23 Then
                        b37 = "♦10"
                    ElseIf s = 24 Then
                        b37 = "♦11"
                    ElseIf s = 25 Then
                        b37 = "♦12"
                    ElseIf s = 26 Then
                        b37 = "♦13"
                    ElseIf s = 27 Then
                        b37 = "♤1"
                    ElseIf s = 28 Then
                        b37 = "♤2"
                    ElseIf s = 29 Then
                        b37 = "♤3"
                    ElseIf s = 30 Then
                        b37 = "♤4"
                    ElseIf s = 31 Then
                        b37 = "♤5"
                    ElseIf s = 32 Then
                        b37 = "♤6"
                    ElseIf s = 33 Then
                        b37 = "♤7"
                    ElseIf s = 34 Then
                        b37 = "♤8"
                    ElseIf s = 35 Then
                        b37 = "♤9"
                    ElseIf s = 36 Then
                        b37 = "♤10"
                    ElseIf s = 37 Then
                        b37 = "♤11"
                    ElseIf s = 38 Then
                        b37 = "♤12"
                    ElseIf s = 39 Then
                        b37 = "♤13"
                    ElseIf s = 40 Then
                        b37 = "♧1"
                    ElseIf s = 41 Then
                        b37 = "♧2"
                    ElseIf s = 42 Then
                        b37 = "♧3"
                    ElseIf s = 43 Then
                        b37 = "♧4"
                    ElseIf s = 44 Then
                        b37 = "♧5"
                    ElseIf s = 45 Then
                        b37 = "♧6"
                    ElseIf s = 46 Then
                        b37 = "♧7"
                    ElseIf s = 47 Then
                        b37 = "♧8"
                    ElseIf s = 48 Then
                        b37 = "♧9"
                    ElseIf s = 49 Then
                        b37 = "♧10"
                    ElseIf s = 50 Then
                        b37 = "♧11"
                    ElseIf s = 51 Then
                        b37 = "♧12"
                    ElseIf s = 52 Then
                        b37 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 38 And b38 = "" Then
                    If s = 1 Then
                        b38 = "♥1"
                    ElseIf s = 2 Then
                        b38 = "♥2"
                    ElseIf s = 3 Then
                        b38 = "♥3"
                    ElseIf s = 3 Then
                        b38 = "♥3"
                    ElseIf s = 4 Then
                        b38 = "♥4"
                    ElseIf s = 4 Then
                        b38 = "♥4"
                    ElseIf s = 5 Then
                        b38 = "♥5"
                    ElseIf s = 5 Then
                        b38 = "♥5"
                    ElseIf s = 6 Then
                        b38 = "♥6"
                    ElseIf s = 6 Then
                        b38 = "♥6"
                    ElseIf s = 7 Then
                        b38 = "♥7"
                    ElseIf s = 7 Then
                        b38 = "♥7"
                    ElseIf s = 8 Then
                        b38 = "♥8"
                    ElseIf s = 8 Then
                        b38 = "♥8"
                    ElseIf s = 9 Then
                        b38 = "♥9"
                    ElseIf s = 9 Then
                        b38 = "♥9"
                    ElseIf s = 10 Then
                        b38 = "♥10"
                    ElseIf s = 10 Then
                        b38 = "♥10"
                    ElseIf s = 11 Then
                        b38 = "♥11"
                    ElseIf s = 11 Then
                        b38 = "♥11"
                    ElseIf s = 12 Then
                        b38 = "♥12"
                    ElseIf s = 12 Then
                        b38 = "♥12"
                    ElseIf s = 13 Then
                        b38 = "♥13"
                    ElseIf s = 13 Then
                        b38 = "♥13"
                    ElseIf s = 14 Then
                        b38 = "♦1"
                    ElseIf s = 15 Then
                        b38 = "♦2"
                    ElseIf s = 16 Then
                        b38 = "♦3"
                    ElseIf s = 17 Then
                        b38 = "♦4"
                    ElseIf s = 18 Then
                        b38 = "♦5"
                    ElseIf s = 19 Then
                        b38 = "♦6"
                    ElseIf s = 20 Then
                        b38 = "♦7"
                    ElseIf s = 21 Then
                        b38 = "♦8"
                    ElseIf s = 22 Then
                        b38 = "♦9"
                    ElseIf s = 23 Then
                        b38 = "♦10"
                    ElseIf s = 24 Then
                        b38 = "♦11"
                    ElseIf s = 25 Then
                        b38 = "♦12"
                    ElseIf s = 26 Then
                        b38 = "♦13"
                    ElseIf s = 27 Then
                        b38 = "♤1"
                    ElseIf s = 28 Then
                        b38 = "♤2"
                    ElseIf s = 29 Then
                        b38 = "♤3"
                    ElseIf s = 30 Then
                        b38 = "♤4"
                    ElseIf s = 31 Then
                        b38 = "♤5"
                    ElseIf s = 32 Then
                        b38 = "♤6"
                    ElseIf s = 33 Then
                        b38 = "♤7"
                    ElseIf s = 34 Then
                        b38 = "♤8"
                    ElseIf s = 35 Then
                        b38 = "♤9"
                    ElseIf s = 36 Then
                        b38 = "♤10"
                    ElseIf s = 37 Then
                        b38 = "♤11"
                    ElseIf s = 38 Then
                        b38 = "♤12"
                    ElseIf s = 39 Then
                        b38 = "♤13"
                    ElseIf s = 40 Then
                        b38 = "♧1"
                    ElseIf s = 41 Then
                        b38 = "♧2"
                    ElseIf s = 42 Then
                        b38 = "♧3"
                    ElseIf s = 43 Then
                        b38 = "♧4"
                    ElseIf s = 44 Then
                        b38 = "♧5"
                    ElseIf s = 45 Then
                        b38 = "♧6"
                    ElseIf s = 46 Then
                        b38 = "♧7"
                    ElseIf s = 47 Then
                        b38 = "♧8"
                    ElseIf s = 48 Then
                        b38 = "♧9"
                    ElseIf s = 49 Then
                        b38 = "♧10"
                    ElseIf s = 50 Then
                        b38 = "♧11"
                    ElseIf s = 51 Then
                        b38 = "♧12"
                    ElseIf s = 52 Then
                        b38 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 39 And b39 = "" Then
                    If s = 1 Then
                        b39 = "♥1"
                    ElseIf s = 2 Then
                        b39 = "♥2"
                    ElseIf s = 3 Then
                        b39 = "♥3"
                    ElseIf s = 3 Then
                        b39 = "♥3"
                    ElseIf s = 4 Then
                        b39 = "♥4"
                    ElseIf s = 4 Then
                        b39 = "♥4"
                    ElseIf s = 5 Then
                        b39 = "♥5"
                    ElseIf s = 5 Then
                        b39 = "♥5"
                    ElseIf s = 6 Then
                        b39 = "♥6"
                    ElseIf s = 6 Then
                        b39 = "♥6"
                    ElseIf s = 7 Then
                        b39 = "♥7"
                    ElseIf s = 7 Then
                        b39 = "♥7"
                    ElseIf s = 8 Then
                        b39 = "♥8"
                    ElseIf s = 8 Then
                        b39 = "♥8"
                    ElseIf s = 9 Then
                        b39 = "♥9"
                    ElseIf s = 9 Then
                        b39 = "♥9"
                    ElseIf s = 10 Then
                        b39 = "♥10"
                    ElseIf s = 10 Then
                        b39 = "♥10"
                    ElseIf s = 11 Then
                        b39 = "♥11"
                    ElseIf s = 11 Then
                        b39 = "♥11"
                    ElseIf s = 12 Then
                        b39 = "♥12"
                    ElseIf s = 12 Then
                        b39 = "♥12"
                    ElseIf s = 13 Then
                        b39 = "♥13"
                    ElseIf s = 13 Then
                        b39 = "♥13"
                    ElseIf s = 14 Then
                        b39 = "♦1"
                    ElseIf s = 15 Then
                        b39 = "♦2"
                    ElseIf s = 16 Then
                        b39 = "♦3"
                    ElseIf s = 17 Then
                        b39 = "♦4"
                    ElseIf s = 18 Then
                        b39 = "♦5"
                    ElseIf s = 19 Then
                        b39 = "♦6"
                    ElseIf s = 20 Then
                        b39 = "♦7"
                    ElseIf s = 21 Then
                        b39 = "♦8"
                    ElseIf s = 22 Then
                        b39 = "♦9"
                    ElseIf s = 23 Then
                        b39 = "♦10"
                    ElseIf s = 24 Then
                        b39 = "♦11"
                    ElseIf s = 25 Then
                        b39 = "♦12"
                    ElseIf s = 26 Then
                        b39 = "♦13"
                    ElseIf s = 27 Then
                        b39 = "♤1"
                    ElseIf s = 28 Then
                        b39 = "♤2"
                    ElseIf s = 29 Then
                        b39 = "♤3"
                    ElseIf s = 30 Then
                        b39 = "♤4"
                    ElseIf s = 31 Then
                        b39 = "♤5"
                    ElseIf s = 32 Then
                        b39 = "♤6"
                    ElseIf s = 33 Then
                        b39 = "♤7"
                    ElseIf s = 34 Then
                        b39 = "♤8"
                    ElseIf s = 35 Then
                        b39 = "♤9"
                    ElseIf s = 36 Then
                        b39 = "♤10"
                    ElseIf s = 37 Then
                        b39 = "♤11"
                    ElseIf s = 38 Then
                        b39 = "♤12"
                    ElseIf s = 39 Then
                        b39 = "♤13"
                    ElseIf s = 40 Then
                        b39 = "♧1"
                    ElseIf s = 41 Then
                        b39 = "♧2"
                    ElseIf s = 42 Then
                        b39 = "♧3"
                    ElseIf s = 43 Then
                        b39 = "♧4"
                    ElseIf s = 44 Then
                        b39 = "♧5"
                    ElseIf s = 45 Then
                        b39 = "♧6"
                    ElseIf s = 46 Then
                        b39 = "♧7"
                    ElseIf s = 47 Then
                        b39 = "♧8"
                    ElseIf s = 48 Then
                        b39 = "♧9"
                    ElseIf s = 49 Then
                        b39 = "♧10"
                    ElseIf s = 50 Then
                        b39 = "♧11"
                    ElseIf s = 51 Then
                        b39 = "♧12"
                    ElseIf s = 52 Then
                        b39 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 40 And b40 = "" Then
                    If s = 1 Then
                        b40 = "♥1"
                    ElseIf s = 2 Then
                        b40 = "♥2"
                    ElseIf s = 3 Then
                        b40 = "♥3"
                    ElseIf s = 3 Then
                        b40 = "♥3"
                    ElseIf s = 4 Then
                        b40 = "♥4"
                    ElseIf s = 4 Then
                        b40 = "♥4"
                    ElseIf s = 5 Then
                        b40 = "♥5"
                    ElseIf s = 5 Then
                        b40 = "♥5"
                    ElseIf s = 6 Then
                        b40 = "♥6"
                    ElseIf s = 6 Then
                        b40 = "♥6"
                    ElseIf s = 7 Then
                        b40 = "♥7"
                    ElseIf s = 7 Then
                        b40 = "♥7"
                    ElseIf s = 8 Then
                        b40 = "♥8"
                    ElseIf s = 8 Then
                        b40 = "♥8"
                    ElseIf s = 9 Then
                        b40 = "♥9"
                    ElseIf s = 9 Then
                        b40 = "♥9"
                    ElseIf s = 10 Then
                        b40 = "♥10"
                    ElseIf s = 10 Then
                        b40 = "♥10"
                    ElseIf s = 11 Then
                        b40 = "♥11"
                    ElseIf s = 11 Then
                        b40 = "♥11"
                    ElseIf s = 12 Then
                        b40 = "♥12"
                    ElseIf s = 12 Then
                        b40 = "♥12"
                    ElseIf s = 13 Then
                        b40 = "♥13"
                    ElseIf s = 13 Then
                        b40 = "♥13"
                    ElseIf s = 14 Then
                        b40 = "♦1"
                    ElseIf s = 15 Then
                        b40 = "♦2"
                    ElseIf s = 16 Then
                        b40 = "♦3"
                    ElseIf s = 17 Then
                        b40 = "♦4"
                    ElseIf s = 18 Then
                        b40 = "♦5"
                    ElseIf s = 19 Then
                        b40 = "♦6"
                    ElseIf s = 20 Then
                        b40 = "♦7"
                    ElseIf s = 21 Then
                        b40 = "♦8"
                    ElseIf s = 22 Then
                        b40 = "♦9"
                    ElseIf s = 23 Then
                        b40 = "♦10"
                    ElseIf s = 24 Then
                        b40 = "♦11"
                    ElseIf s = 25 Then
                        b40 = "♦12"
                    ElseIf s = 26 Then
                        b40 = "♦13"
                    ElseIf s = 27 Then
                        b40 = "♤1"
                    ElseIf s = 28 Then
                        b40 = "♤2"
                    ElseIf s = 29 Then
                        b40 = "♤3"
                    ElseIf s = 30 Then
                        b40 = "♤4"
                    ElseIf s = 31 Then
                        b40 = "♤5"
                    ElseIf s = 32 Then
                        b40 = "♤6"
                    ElseIf s = 33 Then
                        b40 = "♤7"
                    ElseIf s = 34 Then
                        b40 = "♤8"
                    ElseIf s = 35 Then
                        b40 = "♤9"
                    ElseIf s = 36 Then
                        b40 = "♤10"
                    ElseIf s = 37 Then
                        b40 = "♤11"
                    ElseIf s = 38 Then
                        b40 = "♤12"
                    ElseIf s = 39 Then
                        b40 = "♤13"
                    ElseIf s = 40 Then
                        b40 = "♧1"
                    ElseIf s = 41 Then
                        b40 = "♧2"
                    ElseIf s = 42 Then
                        b40 = "♧3"
                    ElseIf s = 43 Then
                        b40 = "♧4"
                    ElseIf s = 44 Then
                        b40 = "♧5"
                    ElseIf s = 45 Then
                        b40 = "♧6"
                    ElseIf s = 46 Then
                        b40 = "♧7"
                    ElseIf s = 47 Then
                        b40 = "♧8"
                    ElseIf s = 48 Then
                        b40 = "♧9"
                    ElseIf s = 49 Then
                        b40 = "♧10"
                    ElseIf s = 50 Then
                        b40 = "♧11"
                    ElseIf s = 51 Then
                        b40 = "♧12"
                    ElseIf s = 52 Then
                        b40 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 41 And b41 = "" Then
                    If s = 1 Then
                        b41 = "♥1"
                    ElseIf s = 2 Then
                        b41 = "♥2"
                    ElseIf s = 3 Then
                        b41 = "♥3"
                    ElseIf s = 3 Then
                        b41 = "♥3"
                    ElseIf s = 4 Then
                        b41 = "♥4"
                    ElseIf s = 4 Then
                        b41 = "♥4"
                    ElseIf s = 5 Then
                        b41 = "♥5"
                    ElseIf s = 5 Then
                        b41 = "♥5"
                    ElseIf s = 6 Then
                        b41 = "♥6"
                    ElseIf s = 6 Then
                        b41 = "♥6"
                    ElseIf s = 7 Then
                        b41 = "♥7"
                    ElseIf s = 7 Then
                        b41 = "♥7"
                    ElseIf s = 8 Then
                        b41 = "♥8"
                    ElseIf s = 8 Then
                        b41 = "♥8"
                    ElseIf s = 9 Then
                        b41 = "♥9"
                    ElseIf s = 9 Then
                        b41 = "♥9"
                    ElseIf s = 10 Then
                        b41 = "♥10"
                    ElseIf s = 10 Then
                        b41 = "♥10"
                    ElseIf s = 11 Then
                        b41 = "♥11"
                    ElseIf s = 11 Then
                        b41 = "♥11"
                    ElseIf s = 12 Then
                        b41 = "♥12"
                    ElseIf s = 12 Then
                        b41 = "♥12"
                    ElseIf s = 13 Then
                        b41 = "♥13"
                    ElseIf s = 13 Then
                        b41 = "♥13"
                    ElseIf s = 14 Then
                        b41 = "♦1"
                    ElseIf s = 15 Then
                        b41 = "♦2"
                    ElseIf s = 16 Then
                        b41 = "♦3"
                    ElseIf s = 17 Then
                        b41 = "♦4"
                    ElseIf s = 18 Then
                        b41 = "♦5"
                    ElseIf s = 19 Then
                        b41 = "♦6"
                    ElseIf s = 20 Then
                        b41 = "♦7"
                    ElseIf s = 21 Then
                        b41 = "♦8"
                    ElseIf s = 22 Then
                        b41 = "♦9"
                    ElseIf s = 23 Then
                        b41 = "♦10"
                    ElseIf s = 24 Then
                        b41 = "♦11"
                    ElseIf s = 25 Then
                        b41 = "♦12"
                    ElseIf s = 26 Then
                        b41 = "♦13"
                    ElseIf s = 27 Then
                        b41 = "♤1"
                    ElseIf s = 28 Then
                        b41 = "♤2"
                    ElseIf s = 29 Then
                        b41 = "♤3"
                    ElseIf s = 30 Then
                        b41 = "♤4"
                    ElseIf s = 31 Then
                        b41 = "♤5"
                    ElseIf s = 32 Then
                        b41 = "♤6"
                    ElseIf s = 33 Then
                        b41 = "♤7"
                    ElseIf s = 34 Then
                        b41 = "♤8"
                    ElseIf s = 35 Then
                        b41 = "♤9"
                    ElseIf s = 36 Then
                        b41 = "♤10"
                    ElseIf s = 37 Then
                        b41 = "♤11"
                    ElseIf s = 38 Then
                        b41 = "♤12"
                    ElseIf s = 39 Then
                        b41 = "♤13"
                    ElseIf s = 40 Then
                        b41 = "♧1"
                    ElseIf s = 41 Then
                        b41 = "♧2"
                    ElseIf s = 42 Then
                        b41 = "♧3"
                    ElseIf s = 43 Then
                        b41 = "♧4"
                    ElseIf s = 44 Then
                        b41 = "♧5"
                    ElseIf s = 45 Then
                        b41 = "♧6"
                    ElseIf s = 46 Then
                        b41 = "♧7"
                    ElseIf s = 47 Then
                        b41 = "♧8"
                    ElseIf s = 48 Then
                        b41 = "♧9"
                    ElseIf s = 49 Then
                        b41 = "♧10"
                    ElseIf s = 50 Then
                        b41 = "♧11"
                    ElseIf s = 51 Then
                        b41 = "♧12"
                    ElseIf s = 52 Then
                        b41 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 42 And b42 = "" Then
                    If s = 1 Then
                        b42 = "♥1"
                    ElseIf s = 2 Then
                        b42 = "♥2"
                    ElseIf s = 3 Then
                        b42 = "♥3"
                    ElseIf s = 3 Then
                        b42 = "♥3"
                    ElseIf s = 4 Then
                        b42 = "♥4"
                    ElseIf s = 4 Then
                        b42 = "♥4"
                    ElseIf s = 5 Then
                        b42 = "♥5"
                    ElseIf s = 5 Then
                        b42 = "♥5"
                    ElseIf s = 6 Then
                        b42 = "♥6"
                    ElseIf s = 6 Then
                        b42 = "♥6"
                    ElseIf s = 7 Then
                        b42 = "♥7"
                    ElseIf s = 7 Then
                        b42 = "♥7"
                    ElseIf s = 8 Then
                        b42 = "♥8"
                    ElseIf s = 8 Then
                        b42 = "♥8"
                    ElseIf s = 9 Then
                        b42 = "♥9"
                    ElseIf s = 9 Then
                        b42 = "♥9"
                    ElseIf s = 10 Then
                        b42 = "♥10"
                    ElseIf s = 10 Then
                        b42 = "♥10"
                    ElseIf s = 11 Then
                        b42 = "♥11"
                    ElseIf s = 11 Then
                        b42 = "♥11"
                    ElseIf s = 12 Then
                        b42 = "♥12"
                    ElseIf s = 12 Then
                        b42 = "♥12"
                    ElseIf s = 13 Then
                        b42 = "♥13"
                    ElseIf s = 13 Then
                        b42 = "♥13"
                    ElseIf s = 14 Then
                        b42 = "♦1"
                    ElseIf s = 15 Then
                        b42 = "♦2"
                    ElseIf s = 16 Then
                        b42 = "♦3"
                    ElseIf s = 17 Then
                        b42 = "♦4"
                    ElseIf s = 18 Then
                        b42 = "♦5"
                    ElseIf s = 19 Then
                        b42 = "♦6"
                    ElseIf s = 20 Then
                        b42 = "♦7"
                    ElseIf s = 21 Then
                        b42 = "♦8"
                    ElseIf s = 22 Then
                        b42 = "♦9"
                    ElseIf s = 23 Then
                        b42 = "♦10"
                    ElseIf s = 24 Then
                        b42 = "♦11"
                    ElseIf s = 25 Then
                        b42 = "♦12"
                    ElseIf s = 26 Then
                        b42 = "♦13"
                    ElseIf s = 27 Then
                        b42 = "♤1"
                    ElseIf s = 28 Then
                        b42 = "♤2"
                    ElseIf s = 29 Then
                        b42 = "♤3"
                    ElseIf s = 30 Then
                        b42 = "♤4"
                    ElseIf s = 31 Then
                        b42 = "♤5"
                    ElseIf s = 32 Then
                        b42 = "♤6"
                    ElseIf s = 33 Then
                        b42 = "♤7"
                    ElseIf s = 34 Then
                        b42 = "♤8"
                    ElseIf s = 35 Then
                        b42 = "♤9"
                    ElseIf s = 36 Then
                        b42 = "♤10"
                    ElseIf s = 37 Then
                        b42 = "♤11"
                    ElseIf s = 38 Then
                        b42 = "♤12"
                    ElseIf s = 39 Then
                        b42 = "♤13"
                    ElseIf s = 40 Then
                        b42 = "♧1"
                    ElseIf s = 41 Then
                        b42 = "♧2"
                    ElseIf s = 42 Then
                        b42 = "♧3"
                    ElseIf s = 43 Then
                        b42 = "♧4"
                    ElseIf s = 44 Then
                        b42 = "♧5"
                    ElseIf s = 45 Then
                        b42 = "♧6"
                    ElseIf s = 46 Then
                        b42 = "♧7"
                    ElseIf s = 47 Then
                        b42 = "♧8"
                    ElseIf s = 48 Then
                        b42 = "♧9"
                    ElseIf s = 49 Then
                        b42 = "♧10"
                    ElseIf s = 50 Then
                        b42 = "♧11"
                    ElseIf s = 51 Then
                        b42 = "♧12"
                    ElseIf s = 52 Then
                        b42 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 43 And b43 = "" Then
                    If s = 1 Then
                        b43 = "♥1"
                    ElseIf s = 2 Then
                        b43 = "♥2"
                    ElseIf s = 3 Then
                        b43 = "♥3"
                    ElseIf s = 3 Then
                        b43 = "♥3"
                    ElseIf s = 4 Then
                        b43 = "♥4"
                    ElseIf s = 4 Then
                        b43 = "♥4"
                    ElseIf s = 5 Then
                        b43 = "♥5"
                    ElseIf s = 5 Then
                        b43 = "♥5"
                    ElseIf s = 6 Then
                        b43 = "♥6"
                    ElseIf s = 6 Then
                        b43 = "♥6"
                    ElseIf s = 7 Then
                        b43 = "♥7"
                    ElseIf s = 7 Then
                        b43 = "♥7"
                    ElseIf s = 8 Then
                        b43 = "♥8"
                    ElseIf s = 8 Then
                        b43 = "♥8"
                    ElseIf s = 9 Then
                        b43 = "♥9"
                    ElseIf s = 9 Then
                        b43 = "♥9"
                    ElseIf s = 10 Then
                        b43 = "♥10"
                    ElseIf s = 10 Then
                        b43 = "♥10"
                    ElseIf s = 11 Then
                        b43 = "♥11"
                    ElseIf s = 11 Then
                        b43 = "♥11"
                    ElseIf s = 12 Then
                        b43 = "♥12"
                    ElseIf s = 12 Then
                        b43 = "♥12"
                    ElseIf s = 13 Then
                        b43 = "♥13"
                    ElseIf s = 13 Then
                        b43 = "♥13"
                    ElseIf s = 14 Then
                        b43 = "♦1"
                    ElseIf s = 15 Then
                        b43 = "♦2"
                    ElseIf s = 16 Then
                        b43 = "♦3"
                    ElseIf s = 17 Then
                        b43 = "♦4"
                    ElseIf s = 18 Then
                        b43 = "♦5"
                    ElseIf s = 19 Then
                        b43 = "♦6"
                    ElseIf s = 20 Then
                        b43 = "♦7"
                    ElseIf s = 21 Then
                        b43 = "♦8"
                    ElseIf s = 22 Then
                        b43 = "♦9"
                    ElseIf s = 23 Then
                        b43 = "♦10"
                    ElseIf s = 24 Then
                        b43 = "♦11"
                    ElseIf s = 25 Then
                        b43 = "♦12"
                    ElseIf s = 26 Then
                        b43 = "♦13"
                    ElseIf s = 27 Then
                        b43 = "♤1"
                    ElseIf s = 28 Then
                        b43 = "♤2"
                    ElseIf s = 29 Then
                        b43 = "♤3"
                    ElseIf s = 30 Then
                        b43 = "♤4"
                    ElseIf s = 31 Then
                        b43 = "♤5"
                    ElseIf s = 32 Then
                        b43 = "♤6"
                    ElseIf s = 33 Then
                        b43 = "♤7"
                    ElseIf s = 34 Then
                        b43 = "♤8"
                    ElseIf s = 35 Then
                        b43 = "♤9"
                    ElseIf s = 36 Then
                        b43 = "♤10"
                    ElseIf s = 37 Then
                        b43 = "♤11"
                    ElseIf s = 38 Then
                        b43 = "♤12"
                    ElseIf s = 39 Then
                        b43 = "♤13"
                    ElseIf s = 40 Then
                        b43 = "♧1"
                    ElseIf s = 41 Then
                        b43 = "♧2"
                    ElseIf s = 42 Then
                        b43 = "♧3"
                    ElseIf s = 43 Then
                        b43 = "♧4"
                    ElseIf s = 44 Then
                        b43 = "♧5"
                    ElseIf s = 45 Then
                        b43 = "♧6"
                    ElseIf s = 46 Then
                        b43 = "♧7"
                    ElseIf s = 47 Then
                        b43 = "♧8"
                    ElseIf s = 48 Then
                        b43 = "♧9"
                    ElseIf s = 49 Then
                        b43 = "♧10"
                    ElseIf s = 50 Then
                        b43 = "♧11"
                    ElseIf s = 51 Then
                        b43 = "♧12"
                    ElseIf s = 52 Then
                        b43 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 44 And b44 = "" Then
                    If s = 1 Then
                        b44 = "♥1"
                    ElseIf s = 2 Then
                        b44 = "♥2"
                    ElseIf s = 3 Then
                        b44 = "♥3"
                    ElseIf s = 3 Then
                        b44 = "♥3"
                    ElseIf s = 4 Then
                        b44 = "♥4"
                    ElseIf s = 4 Then
                        b44 = "♥4"
                    ElseIf s = 5 Then
                        b44 = "♥5"
                    ElseIf s = 5 Then
                        b44 = "♥5"
                    ElseIf s = 6 Then
                        b44 = "♥6"
                    ElseIf s = 6 Then
                        b44 = "♥6"
                    ElseIf s = 7 Then
                        b44 = "♥7"
                    ElseIf s = 7 Then
                        b44 = "♥7"
                    ElseIf s = 8 Then
                        b44 = "♥8"
                    ElseIf s = 8 Then
                        b44 = "♥8"
                    ElseIf s = 9 Then
                        b44 = "♥9"
                    ElseIf s = 9 Then
                        b44 = "♥9"
                    ElseIf s = 10 Then
                        b44 = "♥10"
                    ElseIf s = 10 Then
                        b44 = "♥10"
                    ElseIf s = 11 Then
                        b44 = "♥11"
                    ElseIf s = 11 Then
                        b44 = "♥11"
                    ElseIf s = 12 Then
                        b44 = "♥12"
                    ElseIf s = 12 Then
                        b44 = "♥12"
                    ElseIf s = 13 Then
                        b44 = "♥13"
                    ElseIf s = 13 Then
                        b44 = "♥13"
                    ElseIf s = 14 Then
                        b44 = "♦1"
                    ElseIf s = 15 Then
                        b44 = "♦2"
                    ElseIf s = 16 Then
                        b44 = "♦3"
                    ElseIf s = 17 Then
                        b44 = "♦4"
                    ElseIf s = 18 Then
                        b44 = "♦5"
                    ElseIf s = 19 Then
                        b44 = "♦6"
                    ElseIf s = 20 Then
                        b44 = "♦7"
                    ElseIf s = 21 Then
                        b44 = "♦8"
                    ElseIf s = 22 Then
                        b44 = "♦9"
                    ElseIf s = 23 Then
                        b44 = "♦10"
                    ElseIf s = 24 Then
                        b44 = "♦11"
                    ElseIf s = 25 Then
                        b44 = "♦12"
                    ElseIf s = 26 Then
                        b44 = "♦13"
                    ElseIf s = 27 Then
                        b44 = "♤1"
                    ElseIf s = 28 Then
                        b44 = "♤2"
                    ElseIf s = 29 Then
                        b44 = "♤3"
                    ElseIf s = 30 Then
                        b44 = "♤4"
                    ElseIf s = 31 Then
                        b44 = "♤5"
                    ElseIf s = 32 Then
                        b44 = "♤6"
                    ElseIf s = 33 Then
                        b44 = "♤7"
                    ElseIf s = 34 Then
                        b44 = "♤8"
                    ElseIf s = 35 Then
                        b44 = "♤9"
                    ElseIf s = 36 Then
                        b44 = "♤10"
                    ElseIf s = 37 Then
                        b44 = "♤11"
                    ElseIf s = 38 Then
                        b44 = "♤12"
                    ElseIf s = 39 Then
                        b44 = "♤13"
                    ElseIf s = 40 Then
                        b44 = "♧1"
                    ElseIf s = 41 Then
                        b44 = "♧2"
                    ElseIf s = 42 Then
                        b44 = "♧3"
                    ElseIf s = 43 Then
                        b44 = "♧4"
                    ElseIf s = 44 Then
                        b44 = "♧5"
                    ElseIf s = 45 Then
                        b44 = "♧6"
                    ElseIf s = 46 Then
                        b44 = "♧7"
                    ElseIf s = 47 Then
                        b44 = "♧8"
                    ElseIf s = 48 Then
                        b44 = "♧9"
                    ElseIf s = 49 Then
                        b44 = "♧10"
                    ElseIf s = 50 Then
                        b44 = "♧11"
                    ElseIf s = 51 Then
                        b44 = "♧12"
                    ElseIf s = 52 Then
                        b44 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 45 And b45 = "" Then
                    If s = 1 Then
                        b45 = "♥1"
                    ElseIf s = 2 Then
                        b45 = "♥2"
                    ElseIf s = 3 Then
                        b45 = "♥3"
                    ElseIf s = 3 Then
                        b45 = "♥3"
                    ElseIf s = 4 Then
                        b45 = "♥4"
                    ElseIf s = 4 Then
                        b45 = "♥4"
                    ElseIf s = 5 Then
                        b45 = "♥5"
                    ElseIf s = 5 Then
                        b45 = "♥5"
                    ElseIf s = 6 Then
                        b45 = "♥6"
                    ElseIf s = 6 Then
                        b45 = "♥6"
                    ElseIf s = 7 Then
                        b45 = "♥7"
                    ElseIf s = 7 Then
                        b45 = "♥7"
                    ElseIf s = 8 Then
                        b45 = "♥8"
                    ElseIf s = 8 Then
                        b45 = "♥8"
                    ElseIf s = 9 Then
                        b45 = "♥9"
                    ElseIf s = 9 Then
                        b45 = "♥9"
                    ElseIf s = 10 Then
                        b45 = "♥10"
                    ElseIf s = 10 Then
                        b45 = "♥10"
                    ElseIf s = 11 Then
                        b45 = "♥11"
                    ElseIf s = 11 Then
                        b45 = "♥11"
                    ElseIf s = 12 Then
                        b45 = "♥12"
                    ElseIf s = 12 Then
                        b45 = "♥12"
                    ElseIf s = 13 Then
                        b45 = "♥13"
                    ElseIf s = 13 Then
                        b45 = "♥13"
                    ElseIf s = 14 Then
                        b45 = "♦1"
                    ElseIf s = 15 Then
                        b45 = "♦2"
                    ElseIf s = 16 Then
                        b45 = "♦3"
                    ElseIf s = 17 Then
                        b45 = "♦4"
                    ElseIf s = 18 Then
                        b45 = "♦5"
                    ElseIf s = 19 Then
                        b45 = "♦6"
                    ElseIf s = 20 Then
                        b45 = "♦7"
                    ElseIf s = 21 Then
                        b45 = "♦8"
                    ElseIf s = 22 Then
                        b45 = "♦9"
                    ElseIf s = 23 Then
                        b45 = "♦10"
                    ElseIf s = 24 Then
                        b45 = "♦11"
                    ElseIf s = 25 Then
                        b45 = "♦12"
                    ElseIf s = 26 Then
                        b45 = "♦13"
                    ElseIf s = 27 Then
                        b45 = "♤1"
                    ElseIf s = 28 Then
                        b45 = "♤2"
                    ElseIf s = 29 Then
                        b45 = "♤3"
                    ElseIf s = 30 Then
                        b45 = "♤4"
                    ElseIf s = 31 Then
                        b45 = "♤5"
                    ElseIf s = 32 Then
                        b45 = "♤6"
                    ElseIf s = 33 Then
                        b45 = "♤7"
                    ElseIf s = 34 Then
                        b45 = "♤8"
                    ElseIf s = 35 Then
                        b45 = "♤9"
                    ElseIf s = 36 Then
                        b45 = "♤10"
                    ElseIf s = 37 Then
                        b45 = "♤11"
                    ElseIf s = 38 Then
                        b45 = "♤12"
                    ElseIf s = 39 Then
                        b45 = "♤13"
                    ElseIf s = 40 Then
                        b45 = "♧1"
                    ElseIf s = 41 Then
                        b45 = "♧2"
                    ElseIf s = 42 Then
                        b45 = "♧3"
                    ElseIf s = 43 Then
                        b45 = "♧4"
                    ElseIf s = 44 Then
                        b45 = "♧5"
                    ElseIf s = 45 Then
                        b45 = "♧6"
                    ElseIf s = 46 Then
                        b45 = "♧7"
                    ElseIf s = 47 Then
                        b45 = "♧8"
                    ElseIf s = 48 Then
                        b45 = "♧9"
                    ElseIf s = 49 Then
                        b45 = "♧10"
                    ElseIf s = 50 Then
                        b45 = "♧11"
                    ElseIf s = 51 Then
                        b45 = "♧12"
                    ElseIf s = 52 Then
                        b45 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 46 And b46 = "" Then
                    If s = 1 Then
                        b46 = "♥1"
                    ElseIf s = 2 Then
                        b46 = "♥2"
                    ElseIf s = 3 Then
                        b46 = "♥3"
                    ElseIf s = 3 Then
                        b46 = "♥3"
                    ElseIf s = 4 Then
                        b46 = "♥4"
                    ElseIf s = 4 Then
                        b46 = "♥4"
                    ElseIf s = 5 Then
                        b46 = "♥5"
                    ElseIf s = 5 Then
                        b46 = "♥5"
                    ElseIf s = 6 Then
                        b46 = "♥6"
                    ElseIf s = 6 Then
                        b46 = "♥6"
                    ElseIf s = 7 Then
                        b46 = "♥7"
                    ElseIf s = 7 Then
                        b46 = "♥7"
                    ElseIf s = 8 Then
                        b46 = "♥8"
                    ElseIf s = 8 Then
                        b46 = "♥8"
                    ElseIf s = 9 Then
                        b46 = "♥9"
                    ElseIf s = 9 Then
                        b46 = "♥9"
                    ElseIf s = 10 Then
                        b46 = "♥10"
                    ElseIf s = 10 Then
                        b46 = "♥10"
                    ElseIf s = 11 Then
                        b46 = "♥11"
                    ElseIf s = 11 Then
                        b46 = "♥11"
                    ElseIf s = 12 Then
                        b46 = "♥12"
                    ElseIf s = 12 Then
                        b46 = "♥12"
                    ElseIf s = 13 Then
                        b46 = "♥13"
                    ElseIf s = 13 Then
                        b46 = "♥13"
                    ElseIf s = 14 Then
                        b46 = "♦1"
                    ElseIf s = 15 Then
                        b46 = "♦2"
                    ElseIf s = 16 Then
                        b46 = "♦3"
                    ElseIf s = 17 Then
                        b46 = "♦4"
                    ElseIf s = 18 Then
                        b46 = "♦5"
                    ElseIf s = 19 Then
                        b46 = "♦6"
                    ElseIf s = 20 Then
                        b46 = "♦7"
                    ElseIf s = 21 Then
                        b46 = "♦8"
                    ElseIf s = 22 Then
                        b46 = "♦9"
                    ElseIf s = 23 Then
                        b46 = "♦10"
                    ElseIf s = 24 Then
                        b46 = "♦11"
                    ElseIf s = 25 Then
                        b46 = "♦12"
                    ElseIf s = 26 Then
                        b46 = "♦13"
                    ElseIf s = 27 Then
                        b46 = "♤1"
                    ElseIf s = 28 Then
                        b46 = "♤2"
                    ElseIf s = 29 Then
                        b46 = "♤3"
                    ElseIf s = 30 Then
                        b46 = "♤4"
                    ElseIf s = 31 Then
                        b46 = "♤5"
                    ElseIf s = 32 Then
                        b46 = "♤6"
                    ElseIf s = 33 Then
                        b46 = "♤7"
                    ElseIf s = 34 Then
                        b46 = "♤8"
                    ElseIf s = 35 Then
                        b46 = "♤9"
                    ElseIf s = 36 Then
                        b46 = "♤10"
                    ElseIf s = 37 Then
                        b46 = "♤11"
                    ElseIf s = 38 Then
                        b46 = "♤12"
                    ElseIf s = 39 Then
                        b46 = "♤13"
                    ElseIf s = 40 Then
                        b46 = "♧1"
                    ElseIf s = 41 Then
                        b46 = "♧2"
                    ElseIf s = 42 Then
                        b46 = "♧3"
                    ElseIf s = 43 Then
                        b46 = "♧4"
                    ElseIf s = 44 Then
                        b46 = "♧5"
                    ElseIf s = 45 Then
                        b46 = "♧6"
                    ElseIf s = 46 Then
                        b46 = "♧7"
                    ElseIf s = 47 Then
                        b46 = "♧8"
                    ElseIf s = 48 Then
                        b46 = "♧9"
                    ElseIf s = 49 Then
                        b46 = "♧10"
                    ElseIf s = 50 Then
                        b46 = "♧11"
                    ElseIf s = 51 Then
                        b46 = "♧12"
                    ElseIf s = 52 Then
                        b46 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 47 And b47 = "" Then
                    If s = 1 Then
                        b47 = "♥1"
                    ElseIf s = 2 Then
                        b47 = "♥2"
                    ElseIf s = 3 Then
                        b47 = "♥3"
                    ElseIf s = 3 Then
                        b47 = "♥3"
                    ElseIf s = 4 Then
                        b47 = "♥4"
                    ElseIf s = 4 Then
                        b47 = "♥4"
                    ElseIf s = 5 Then
                        b47 = "♥5"
                    ElseIf s = 5 Then
                        b47 = "♥5"
                    ElseIf s = 6 Then
                        b47 = "♥6"
                    ElseIf s = 6 Then
                        b47 = "♥6"
                    ElseIf s = 7 Then
                        b47 = "♥7"
                    ElseIf s = 7 Then
                        b47 = "♥7"
                    ElseIf s = 8 Then
                        b47 = "♥8"
                    ElseIf s = 8 Then
                        b47 = "♥8"
                    ElseIf s = 9 Then
                        b47 = "♥9"
                    ElseIf s = 9 Then
                        b47 = "♥9"
                    ElseIf s = 10 Then
                        b47 = "♥10"
                    ElseIf s = 10 Then
                        b47 = "♥10"
                    ElseIf s = 11 Then
                        b47 = "♥11"
                    ElseIf s = 11 Then
                        b47 = "♥11"
                    ElseIf s = 12 Then
                        b47 = "♥12"
                    ElseIf s = 12 Then
                        b47 = "♥12"
                    ElseIf s = 13 Then
                        b47 = "♥13"
                    ElseIf s = 13 Then
                        b47 = "♥13"
                    ElseIf s = 14 Then
                        b47 = "♦1"
                    ElseIf s = 15 Then
                        b47 = "♦2"
                    ElseIf s = 16 Then
                        b47 = "♦3"
                    ElseIf s = 17 Then
                        b47 = "♦4"
                    ElseIf s = 18 Then
                        b47 = "♦5"
                    ElseIf s = 19 Then
                        b47 = "♦6"
                    ElseIf s = 20 Then
                        b47 = "♦7"
                    ElseIf s = 21 Then
                        b47 = "♦8"
                    ElseIf s = 22 Then
                        b47 = "♦9"
                    ElseIf s = 23 Then
                        b47 = "♦10"
                    ElseIf s = 24 Then
                        b47 = "♦11"
                    ElseIf s = 25 Then
                        b47 = "♦12"
                    ElseIf s = 26 Then
                        b47 = "♦13"
                    ElseIf s = 27 Then
                        b47 = "♤1"
                    ElseIf s = 28 Then
                        b47 = "♤2"
                    ElseIf s = 29 Then
                        b47 = "♤3"
                    ElseIf s = 30 Then
                        b47 = "♤4"
                    ElseIf s = 31 Then
                        b47 = "♤5"
                    ElseIf s = 32 Then
                        b47 = "♤6"
                    ElseIf s = 33 Then
                        b47 = "♤7"
                    ElseIf s = 34 Then
                        b47 = "♤8"
                    ElseIf s = 35 Then
                        b47 = "♤9"
                    ElseIf s = 36 Then
                        b47 = "♤10"
                    ElseIf s = 37 Then
                        b47 = "♤11"
                    ElseIf s = 38 Then
                        b47 = "♤12"
                    ElseIf s = 39 Then
                        b47 = "♤13"
                    ElseIf s = 40 Then
                        b47 = "♧1"
                    ElseIf s = 41 Then
                        b47 = "♧2"
                    ElseIf s = 42 Then
                        b47 = "♧3"
                    ElseIf s = 43 Then
                        b47 = "♧4"
                    ElseIf s = 44 Then
                        b47 = "♧5"
                    ElseIf s = 45 Then
                        b47 = "♧6"
                    ElseIf s = 46 Then
                        b47 = "♧7"
                    ElseIf s = 47 Then
                        b47 = "♧8"
                    ElseIf s = 48 Then
                        b47 = "♧9"
                    ElseIf s = 49 Then
                        b47 = "♧10"
                    ElseIf s = 50 Then
                        b47 = "♧11"
                    ElseIf s = 51 Then
                        b47 = "♧12"
                    ElseIf s = 52 Then
                        b47 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 48 And b48 = "" Then
                    If s = 1 Then
                        b48 = "♥1"
                    ElseIf s = 2 Then
                        b48 = "♥2"
                    ElseIf s = 3 Then
                        b48 = "♥3"
                    ElseIf s = 3 Then
                        b48 = "♥3"
                    ElseIf s = 4 Then
                        b48 = "♥4"
                    ElseIf s = 4 Then
                        b48 = "♥4"
                    ElseIf s = 5 Then
                        b48 = "♥5"
                    ElseIf s = 5 Then
                        b48 = "♥5"
                    ElseIf s = 6 Then
                        b48 = "♥6"
                    ElseIf s = 6 Then
                        b48 = "♥6"
                    ElseIf s = 7 Then
                        b48 = "♥7"
                    ElseIf s = 7 Then
                        b48 = "♥7"
                    ElseIf s = 8 Then
                        b48 = "♥8"
                    ElseIf s = 8 Then
                        b48 = "♥8"
                    ElseIf s = 9 Then
                        b48 = "♥9"
                    ElseIf s = 9 Then
                        b48 = "♥9"
                    ElseIf s = 10 Then
                        b48 = "♥10"
                    ElseIf s = 10 Then
                        b48 = "♥10"
                    ElseIf s = 11 Then
                        b48 = "♥11"
                    ElseIf s = 11 Then
                        b48 = "♥11"
                    ElseIf s = 12 Then
                        b48 = "♥12"
                    ElseIf s = 12 Then
                        b48 = "♥12"
                    ElseIf s = 13 Then
                        b48 = "♥13"
                    ElseIf s = 13 Then
                        b48 = "♥13"
                    ElseIf s = 14 Then
                        b48 = "♦1"
                    ElseIf s = 15 Then
                        b48 = "♦2"
                    ElseIf s = 16 Then
                        b48 = "♦3"
                    ElseIf s = 17 Then
                        b48 = "♦4"
                    ElseIf s = 18 Then
                        b48 = "♦5"
                    ElseIf s = 19 Then
                        b48 = "♦6"
                    ElseIf s = 20 Then
                        b48 = "♦7"
                    ElseIf s = 21 Then
                        b48 = "♦8"
                    ElseIf s = 22 Then
                        b48 = "♦9"
                    ElseIf s = 23 Then
                        b48 = "♦10"
                    ElseIf s = 24 Then
                        b48 = "♦11"
                    ElseIf s = 25 Then
                        b48 = "♦12"
                    ElseIf s = 26 Then
                        b48 = "♦13"
                    ElseIf s = 27 Then
                        b48 = "♤1"
                    ElseIf s = 28 Then
                        b48 = "♤2"
                    ElseIf s = 29 Then
                        b48 = "♤3"
                    ElseIf s = 30 Then
                        b48 = "♤4"
                    ElseIf s = 31 Then
                        b48 = "♤5"
                    ElseIf s = 32 Then
                        b48 = "♤6"
                    ElseIf s = 33 Then
                        b48 = "♤7"
                    ElseIf s = 34 Then
                        b48 = "♤8"
                    ElseIf s = 35 Then
                        b48 = "♤9"
                    ElseIf s = 36 Then
                        b48 = "♤10"
                    ElseIf s = 37 Then
                        b48 = "♤11"
                    ElseIf s = 38 Then
                        b48 = "♤12"
                    ElseIf s = 39 Then
                        b48 = "♤13"
                    ElseIf s = 40 Then
                        b48 = "♧1"
                    ElseIf s = 41 Then
                        b48 = "♧2"
                    ElseIf s = 42 Then
                        b48 = "♧3"
                    ElseIf s = 43 Then
                        b48 = "♧4"
                    ElseIf s = 44 Then
                        b48 = "♧5"
                    ElseIf s = 45 Then
                        b48 = "♧6"
                    ElseIf s = 46 Then
                        b48 = "♧7"
                    ElseIf s = 47 Then
                        b48 = "♧8"
                    ElseIf s = 48 Then
                        b48 = "♧9"
                    ElseIf s = 49 Then
                        b48 = "♧10"
                    ElseIf s = 50 Then
                        b48 = "♧11"
                    ElseIf s = 51 Then
                        b48 = "♧12"
                    ElseIf s = 52 Then
                        b48 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 49 And b49 = "" Then
                    If s = 1 Then
                        b49 = "♥1"
                    ElseIf s = 2 Then
                        b49 = "♥2"
                    ElseIf s = 3 Then
                        b49 = "♥3"
                    ElseIf s = 3 Then
                        b49 = "♥3"
                    ElseIf s = 4 Then
                        b49 = "♥4"
                    ElseIf s = 4 Then
                        b49 = "♥4"
                    ElseIf s = 5 Then
                        b49 = "♥5"
                    ElseIf s = 5 Then
                        b49 = "♥5"
                    ElseIf s = 6 Then
                        b49 = "♥6"
                    ElseIf s = 6 Then
                        b49 = "♥6"
                    ElseIf s = 7 Then
                        b49 = "♥7"
                    ElseIf s = 7 Then
                        b49 = "♥7"
                    ElseIf s = 8 Then
                        b49 = "♥8"
                    ElseIf s = 8 Then
                        b49 = "♥8"
                    ElseIf s = 9 Then
                        b49 = "♥9"
                    ElseIf s = 9 Then
                        b49 = "♥9"
                    ElseIf s = 10 Then
                        b49 = "♥10"
                    ElseIf s = 10 Then
                        b49 = "♥10"
                    ElseIf s = 11 Then
                        b49 = "♥11"
                    ElseIf s = 11 Then
                        b49 = "♥11"
                    ElseIf s = 12 Then
                        b49 = "♥12"
                    ElseIf s = 12 Then
                        b49 = "♥12"
                    ElseIf s = 13 Then
                        b49 = "♥13"
                    ElseIf s = 13 Then
                        b49 = "♥13"
                    ElseIf s = 14 Then
                        b49 = "♦1"
                    ElseIf s = 15 Then
                        b49 = "♦2"
                    ElseIf s = 16 Then
                        b49 = "♦3"
                    ElseIf s = 17 Then
                        b49 = "♦4"
                    ElseIf s = 18 Then
                        b49 = "♦5"
                    ElseIf s = 19 Then
                        b49 = "♦6"
                    ElseIf s = 20 Then
                        b49 = "♦7"
                    ElseIf s = 21 Then
                        b49 = "♦8"
                    ElseIf s = 22 Then
                        b49 = "♦9"
                    ElseIf s = 23 Then
                        b49 = "♦10"
                    ElseIf s = 24 Then
                        b49 = "♦11"
                    ElseIf s = 25 Then
                        b49 = "♦12"
                    ElseIf s = 26 Then
                        b49 = "♦13"
                    ElseIf s = 27 Then
                        b49 = "♤1"
                    ElseIf s = 28 Then
                        b49 = "♤2"
                    ElseIf s = 29 Then
                        b49 = "♤3"
                    ElseIf s = 30 Then
                        b49 = "♤4"
                    ElseIf s = 31 Then
                        b49 = "♤5"
                    ElseIf s = 32 Then
                        b49 = "♤6"
                    ElseIf s = 33 Then
                        b49 = "♤7"
                    ElseIf s = 34 Then
                        b49 = "♤8"
                    ElseIf s = 35 Then
                        b49 = "♤9"
                    ElseIf s = 36 Then
                        b49 = "♤10"
                    ElseIf s = 37 Then
                        b49 = "♤11"
                    ElseIf s = 38 Then
                        b49 = "♤12"
                    ElseIf s = 39 Then
                        b49 = "♤13"
                    ElseIf s = 40 Then
                        b49 = "♧1"
                    ElseIf s = 41 Then
                        b49 = "♧2"
                    ElseIf s = 42 Then
                        b49 = "♧3"
                    ElseIf s = 43 Then
                        b49 = "♧4"
                    ElseIf s = 44 Then
                        b49 = "♧5"
                    ElseIf s = 45 Then
                        b49 = "♧6"
                    ElseIf s = 46 Then
                        b49 = "♧7"
                    ElseIf s = 47 Then
                        b49 = "♧8"
                    ElseIf s = 48 Then
                        b49 = "♧9"
                    ElseIf s = 49 Then
                        b49 = "♧10"
                    ElseIf s = 50 Then
                        b49 = "♧11"
                    ElseIf s = 51 Then
                        b49 = "♧12"
                    ElseIf s = 52 Then
                        b49 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 50 And b50 = "" Then
                    If s = 1 Then
                        b50 = "♥1"
                    ElseIf s = 2 Then
                        b50 = "♥2"
                    ElseIf s = 3 Then
                        b50 = "♥3"
                    ElseIf s = 3 Then
                        b50 = "♥3"
                    ElseIf s = 4 Then
                        b50 = "♥4"
                    ElseIf s = 4 Then
                        b50 = "♥4"
                    ElseIf s = 5 Then
                        b50 = "♥5"
                    ElseIf s = 5 Then
                        b50 = "♥5"
                    ElseIf s = 6 Then
                        b50 = "♥6"
                    ElseIf s = 6 Then
                        b50 = "♥6"
                    ElseIf s = 7 Then
                        b50 = "♥7"
                    ElseIf s = 7 Then
                        b50 = "♥7"
                    ElseIf s = 8 Then
                        b50 = "♥8"
                    ElseIf s = 8 Then
                        b50 = "♥8"
                    ElseIf s = 9 Then
                        b50 = "♥9"
                    ElseIf s = 9 Then
                        b50 = "♥9"
                    ElseIf s = 10 Then
                        b50 = "♥10"
                    ElseIf s = 10 Then
                        b50 = "♥10"
                    ElseIf s = 11 Then
                        b50 = "♥11"
                    ElseIf s = 11 Then
                        b50 = "♥11"
                    ElseIf s = 12 Then
                        b50 = "♥12"
                    ElseIf s = 12 Then
                        b50 = "♥12"
                    ElseIf s = 13 Then
                        b50 = "♥13"
                    ElseIf s = 13 Then
                        b50 = "♥13"
                    ElseIf s = 14 Then
                        b50 = "♦1"
                    ElseIf s = 15 Then
                        b50 = "♦2"
                    ElseIf s = 16 Then
                        b50 = "♦3"
                    ElseIf s = 17 Then
                        b50 = "♦4"
                    ElseIf s = 18 Then
                        b50 = "♦5"
                    ElseIf s = 19 Then
                        b50 = "♦6"
                    ElseIf s = 20 Then
                        b50 = "♦7"
                    ElseIf s = 21 Then
                        b50 = "♦8"
                    ElseIf s = 22 Then
                        b50 = "♦9"
                    ElseIf s = 23 Then
                        b50 = "♦10"
                    ElseIf s = 24 Then
                        b50 = "♦11"
                    ElseIf s = 25 Then
                        b50 = "♦12"
                    ElseIf s = 26 Then
                        b50 = "♦13"
                    ElseIf s = 27 Then
                        b50 = "♤1"
                    ElseIf s = 28 Then
                        b50 = "♤2"
                    ElseIf s = 29 Then
                        b50 = "♤3"
                    ElseIf s = 30 Then
                        b50 = "♤4"
                    ElseIf s = 31 Then
                        b50 = "♤5"
                    ElseIf s = 32 Then
                        b50 = "♤6"
                    ElseIf s = 33 Then
                        b50 = "♤7"
                    ElseIf s = 34 Then
                        b50 = "♤8"
                    ElseIf s = 35 Then
                        b50 = "♤9"
                    ElseIf s = 36 Then
                        b50 = "♤10"
                    ElseIf s = 37 Then
                        b50 = "♤11"
                    ElseIf s = 38 Then
                        b50 = "♤12"
                    ElseIf s = 39 Then
                        b50 = "♤13"
                    ElseIf s = 40 Then
                        b50 = "♧1"
                    ElseIf s = 41 Then
                        b50 = "♧2"
                    ElseIf s = 42 Then
                        b50 = "♧3"
                    ElseIf s = 43 Then
                        b50 = "♧4"
                    ElseIf s = 44 Then
                        b50 = "♧5"
                    ElseIf s = 45 Then
                        b50 = "♧6"
                    ElseIf s = 46 Then
                        b50 = "♧7"
                    ElseIf s = 47 Then
                        b50 = "♧8"
                    ElseIf s = 48 Then
                        b50 = "♧9"
                    ElseIf s = 49 Then
                        b50 = "♧10"
                    ElseIf s = 50 Then
                        b50 = "♧11"
                    ElseIf s = 51 Then
                        b50 = "♧12"
                    ElseIf s = 52 Then
                        b50 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 51 And b51 = "" Then
                    If s = 1 Then
                        b51 = "♥1"
                    ElseIf s = 2 Then
                        b51 = "♥2"
                    ElseIf s = 3 Then
                        b51 = "♥3"
                    ElseIf s = 3 Then
                        b51 = "♥3"
                    ElseIf s = 4 Then
                        b51 = "♥4"
                    ElseIf s = 4 Then
                        b51 = "♥4"
                    ElseIf s = 5 Then
                        b51 = "♥5"
                    ElseIf s = 5 Then
                        b51 = "♥5"
                    ElseIf s = 6 Then
                        b51 = "♥6"
                    ElseIf s = 6 Then
                        b51 = "♥6"
                    ElseIf s = 7 Then
                        b51 = "♥7"
                    ElseIf s = 7 Then
                        b51 = "♥7"
                    ElseIf s = 8 Then
                        b51 = "♥8"
                    ElseIf s = 8 Then
                        b51 = "♥8"
                    ElseIf s = 9 Then
                        b51 = "♥9"
                    ElseIf s = 9 Then
                        b51 = "♥9"
                    ElseIf s = 10 Then
                        b51 = "♥10"
                    ElseIf s = 10 Then
                        b51 = "♥10"
                    ElseIf s = 11 Then
                        b51 = "♥11"
                    ElseIf s = 11 Then
                        b51 = "♥11"
                    ElseIf s = 12 Then
                        b51 = "♥12"
                    ElseIf s = 12 Then
                        b51 = "♥12"
                    ElseIf s = 13 Then
                        b51 = "♥13"
                    ElseIf s = 13 Then
                        b51 = "♥13"
                    ElseIf s = 14 Then
                        b51 = "♦1"
                    ElseIf s = 15 Then
                        b51 = "♦2"
                    ElseIf s = 16 Then
                        b51 = "♦3"
                    ElseIf s = 17 Then
                        b51 = "♦4"
                    ElseIf s = 18 Then
                        b51 = "♦5"
                    ElseIf s = 19 Then
                        b51 = "♦6"
                    ElseIf s = 20 Then
                        b51 = "♦7"
                    ElseIf s = 21 Then
                        b51 = "♦8"
                    ElseIf s = 22 Then
                        b51 = "♦9"
                    ElseIf s = 23 Then
                        b51 = "♦10"
                    ElseIf s = 24 Then
                        b51 = "♦11"
                    ElseIf s = 25 Then
                        b51 = "♦12"
                    ElseIf s = 26 Then
                        b51 = "♦13"
                    ElseIf s = 27 Then
                        b51 = "♤1"
                    ElseIf s = 28 Then
                        b51 = "♤2"
                    ElseIf s = 29 Then
                        b51 = "♤3"
                    ElseIf s = 30 Then
                        b51 = "♤4"
                    ElseIf s = 31 Then
                        b51 = "♤5"
                    ElseIf s = 32 Then
                        b51 = "♤6"
                    ElseIf s = 33 Then
                        b51 = "♤7"
                    ElseIf s = 34 Then
                        b51 = "♤8"
                    ElseIf s = 35 Then
                        b51 = "♤9"
                    ElseIf s = 36 Then
                        b51 = "♤10"
                    ElseIf s = 37 Then
                        b51 = "♤11"
                    ElseIf s = 38 Then
                        b51 = "♤12"
                    ElseIf s = 39 Then
                        b51 = "♤13"
                    ElseIf s = 40 Then
                        b51 = "♧1"
                    ElseIf s = 41 Then
                        b51 = "♧2"
                    ElseIf s = 42 Then
                        b51 = "♧3"
                    ElseIf s = 43 Then
                        b51 = "♧4"
                    ElseIf s = 44 Then
                        b51 = "♧5"
                    ElseIf s = 45 Then
                        b51 = "♧6"
                    ElseIf s = 46 Then
                        b51 = "♧7"
                    ElseIf s = 47 Then
                        b51 = "♧8"
                    ElseIf s = 48 Then
                        b51 = "♧9"
                    ElseIf s = 49 Then
                        b51 = "♧10"
                    ElseIf s = 50 Then
                        b51 = "♧11"
                    ElseIf s = 51 Then
                        b51 = "♧12"
                    ElseIf s = 52 Then
                        b51 = "♧13"
                    End If
                    s = s + 1
                End If
                If i = 52 And b52 = "" Then
                    If s = 1 Then
                        b52 = "♥1"
                    ElseIf s = 2 Then
                        b52 = "♥2"
                    ElseIf s = 3 Then
                        b52 = "♥3"
                    ElseIf s = 3 Then
                        b52 = "♥3"
                    ElseIf s = 4 Then
                        b52 = "♥4"
                    ElseIf s = 4 Then
                        b52 = "♥4"
                    ElseIf s = 5 Then
                        b52 = "♥5"
                    ElseIf s = 5 Then
                        b52 = "♥5"
                    ElseIf s = 6 Then
                        b52 = "♥6"
                    ElseIf s = 6 Then
                        b52 = "♥6"
                    ElseIf s = 7 Then
                        b52 = "♥7"
                    ElseIf s = 7 Then
                        b52 = "♥7"
                    ElseIf s = 8 Then
                        b52 = "♥8"
                    ElseIf s = 8 Then
                        b52 = "♥8"
                    ElseIf s = 9 Then
                        b52 = "♥9"
                    ElseIf s = 9 Then
                        b52 = "♥9"
                    ElseIf s = 10 Then
                        b52 = "♥10"
                    ElseIf s = 10 Then
                        b52 = "♥10"
                    ElseIf s = 11 Then
                        b52 = "♥11"
                    ElseIf s = 11 Then
                        b52 = "♥11"
                    ElseIf s = 12 Then
                        b52 = "♥12"
                    ElseIf s = 12 Then
                        b52 = "♥12"
                    ElseIf s = 13 Then
                        b52 = "♥13"
                    ElseIf s = 13 Then
                        b52 = "♥13"
                    ElseIf s = 14 Then
                        b52 = "♦1"
                    ElseIf s = 15 Then
                        b52 = "♦2"
                    ElseIf s = 16 Then
                        b52 = "♦3"
                    ElseIf s = 17 Then
                        b52 = "♦4"
                    ElseIf s = 18 Then
                        b52 = "♦5"
                    ElseIf s = 19 Then
                        b52 = "♦6"
                    ElseIf s = 20 Then
                        b52 = "♦7"
                    ElseIf s = 21 Then
                        b52 = "♦8"
                    ElseIf s = 22 Then
                        b52 = "♦9"
                    ElseIf s = 23 Then
                        b52 = "♦10"
                    ElseIf s = 24 Then
                        b52 = "♦11"
                    ElseIf s = 25 Then
                        b52 = "♦12"
                    ElseIf s = 26 Then
                        b52 = "♦13"
                    ElseIf s = 27 Then
                        b52 = "♤1"
                    ElseIf s = 28 Then
                        b52 = "♤2"
                    ElseIf s = 29 Then
                        b52 = "♤3"
                    ElseIf s = 30 Then
                        b52 = "♤4"
                    ElseIf s = 31 Then
                        b52 = "♤5"
                    ElseIf s = 32 Then
                        b52 = "♤6"
                    ElseIf s = 33 Then
                        b52 = "♤7"
                    ElseIf s = 34 Then
                        b52 = "♤8"
                    ElseIf s = 35 Then
                        b52 = "♤9"
                    ElseIf s = 36 Then
                        b52 = "♤10"
                    ElseIf s = 37 Then
                        b52 = "♤11"
                    ElseIf s = 38 Then
                        b52 = "♤12"
                    ElseIf s = 39 Then
                        b52 = "♤13"
                    ElseIf s = 40 Then
                        b52 = "♧1"
                    ElseIf s = 41 Then
                        b52 = "♧2"
                    ElseIf s = 42 Then
                        b52 = "♧3"
                    ElseIf s = 43 Then
                        b52 = "♧4"
                    ElseIf s = 44 Then
                        b52 = "♧5"
                    ElseIf s = 45 Then
                        b52 = "♧6"
                    ElseIf s = 46 Then
                        b52 = "♧7"
                    ElseIf s = 47 Then
                        b52 = "♧8"
                    ElseIf s = 48 Then
                        b52 = "♧9"
                    ElseIf s = 49 Then
                        b52 = "♧10"
                    ElseIf s = 50 Then
                        b52 = "♧11"
                    ElseIf s = 51 Then
                        b52 = "♧12"
                    ElseIf s = 52 Then
                        b52 = "♧13"
                    End If
                    s = s + 1
                End If
            Loop
        Loop
        SS()
        CA()
        TF.Start()
        If pn > 1 Then
            L.Text = "Player 1"
        Else
            L.Text = "0:0:0"
        End If
        If pn = 1 Then
            TimerX.Start()
        End If
    End Sub

    Private Sub Game_Click(sender As Object, e As EventArgs) Handles Me.Click
        If ow.BC.Enabled = True Then
            ow.BC.Focus()
        End If
    End Sub

    Private Sub TF_Tick(sender As Object, e As EventArgs) Handles TF.Tick
        TF.Stop()
        q = MessageBox.Show("「Status」ウィンドウを有効にしますか？", "神経衰弱", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If q = DialogResult.Yes Then
            sw.Show(Me)
        End If
        q = MessageBox.Show("「Accuracy」ウィンドウを有効にしますか？", "神経衰弱", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If q = DialogResult.Yes Then
            aw.Show(Me)
        End If
        Focus()
    End Sub

    Private Sub TimerX_Tick(sender As Object, e As EventArgs) Handles TimerX.Tick
        TimerX.Stop()
        TS()
    End Sub

    Sub TS()
        MsgBox("所要時間を計測します", MsgBoxStyle.OkOnly, "Stop Watch")
        Timer.Interval = 1000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        t = t + 1
        t1 = t \ 3600
        t2 = (t - t1 * 3600) \ 60
        t3 = (t - (t1 * 3600 + t2 * 60))
        L.Text = t1 & ":" & t2 & ":" & t3
    End Sub

    Sub FS()
        p = 1
        t = 0
        c = 26
        sn = 1
        p1 = 0
        p2 = 0
        p3 = 0
        p4 = 0
        p5 = 0
        p6 = 0
        s1 = ""
        s2 = ""
        b1 = ""
        b2 = ""
        b3 = ""
        b4 = ""
        b5 = ""
        b6 = ""
        b7 = ""
        b8 = ""
        b9 = ""
        b10 = ""
        b11 = ""
        b12 = ""
        b13 = ""
        b14 = ""
        b15 = ""
        b16 = ""
        b17 = ""
        b18 = ""
        b19 = ""
        b20 = ""
        b21 = ""
        b22 = ""
        b23 = ""
        b24 = ""
        b25 = ""
        b26 = ""
        b27 = ""
        b28 = ""
        b29 = ""
        b30 = ""
        b31 = ""
        b32 = ""
        b33 = ""
        b34 = ""
        b35 = ""
        b36 = ""
        b37 = ""
        b38 = ""
        b39 = ""
        b40 = ""
        b41 = ""
        b42 = ""
        b43 = ""
        b44 = ""
        b45 = ""
        b46 = ""
        b47 = ""
        b48 = ""
        b49 = ""
        b50 = ""
        b51 = ""
        b52 = ""
    End Sub

    Sub SS()
        If b1 = "♥1" Or b1 = "♥2" Or b1 = "♥3" Or b1 = "♥4" Or b1 = "♥5" Or b1 = "♥6" Or b1 = "♥7" Or b1 = "♥8" Or b1 = "♥9" Or b1 = "♥10" Or b1 = "♥11" Or b1 = "♥12" Or b1 = "♥13" Or b1 = "♦1" Or b1 = "♦2" Or b1 = "♦3" Or b1 = "♦4" Or b1 = "♦5" Or b1 = "♦6" Or b1 = "♦7" Or b1 = "♦8" Or b1 = "♦9" Or b1 = "♦10" Or b1 = "♦11" Or b1 = "♦12" Or b1 = "♦13" Then
            A1.ForeColor = Color.Red
        End If
        If b2 = "♥1" Or b2 = "♥2" Or b2 = "♥3" Or b2 = "♥4" Or b2 = "♥5" Or b2 = "♥6" Or b2 = "♥7" Or b2 = "♥8" Or b2 = "♥9" Or b2 = "♥10" Or b2 = "♥11" Or b2 = "♥12" Or b2 = "♥13" Or b2 = "♦1" Or b2 = "♦2" Or b2 = "♦3" Or b2 = "♦4" Or b2 = "♦5" Or b2 = "♦6" Or b2 = "♦7" Or b2 = "♦8" Or b2 = "♦9" Or b2 = "♦10" Or b2 = "♦11" Or b2 = "♦12" Or b2 = "♦13" Then
            A2.ForeColor = Color.Red
        End If
        If b3 = "♥1" Or b3 = "♥2" Or b3 = "♥3" Or b3 = "♥4" Or b3 = "♥5" Or b3 = "♥6" Or b3 = "♥7" Or b3 = "♥8" Or b3 = "♥9" Or b3 = "♥10" Or b3 = "♥11" Or b3 = "♥12" Or b3 = "♥13" Or b3 = "♦1" Or b3 = "♦2" Or b3 = "♦3" Or b3 = "♦4" Or b3 = "♦5" Or b3 = "♦6" Or b3 = "♦7" Or b3 = "♦8" Or b3 = "♦9" Or b3 = "♦10" Or b3 = "♦11" Or b3 = "♦12" Or b3 = "♦13" Then
            A3.ForeColor = Color.Red
        End If
        If b4 = "♥1" Or b4 = "♥2" Or b4 = "♥3" Or b4 = "♥4" Or b4 = "♥5" Or b4 = "♥6" Or b4 = "♥7" Or b4 = "♥8" Or b4 = "♥9" Or b4 = "♥10" Or b4 = "♥11" Or b4 = "♥12" Or b4 = "♥13" Or b4 = "♦1" Or b4 = "♦2" Or b4 = "♦3" Or b4 = "♦4" Or b4 = "♦5" Or b4 = "♦6" Or b4 = "♦7" Or b4 = "♦8" Or b4 = "♦9" Or b4 = "♦10" Or b4 = "♦11" Or b4 = "♦12" Or b4 = "♦13" Then
            A4.ForeColor = Color.Red
        End If
        If b5 = "♥1" Or b5 = "♥2" Or b5 = "♥3" Or b5 = "♥4" Or b5 = "♥5" Or b5 = "♥6" Or b5 = "♥7" Or b5 = "♥8" Or b5 = "♥9" Or b5 = "♥10" Or b5 = "♥11" Or b5 = "♥12" Or b5 = "♥13" Or b5 = "♦1" Or b5 = "♦2" Or b5 = "♦3" Or b5 = "♦4" Or b5 = "♦5" Or b5 = "♦6" Or b5 = "♦7" Or b5 = "♦8" Or b5 = "♦9" Or b5 = "♦10" Or b5 = "♦11" Or b5 = "♦12" Or b5 = "♦13" Then
            A5.ForeColor = Color.Red
        End If
        If b6 = "♥1" Or b6 = "♥2" Or b6 = "♥3" Or b6 = "♥4" Or b6 = "♥5" Or b6 = "♥6" Or b6 = "♥7" Or b6 = "♥8" Or b6 = "♥9" Or b6 = "♥10" Or b6 = "♥11" Or b6 = "♥12" Or b6 = "♥13" Or b6 = "♦1" Or b6 = "♦2" Or b6 = "♦3" Or b6 = "♦4" Or b6 = "♦5" Or b6 = "♦6" Or b6 = "♦7" Or b6 = "♦8" Or b6 = "♦9" Or b6 = "♦10" Or b6 = "♦11" Or b6 = "♦12" Or b6 = "♦13" Then
            A6.ForeColor = Color.Red
        End If
        If b7 = "♥1" Or b7 = "♥2" Or b7 = "♥3" Or b7 = "♥4" Or b7 = "♥5" Or b7 = "♥6" Or b7 = "♥7" Or b7 = "♥8" Or b7 = "♥9" Or b7 = "♥10" Or b7 = "♥11" Or b7 = "♥12" Or b7 = "♥13" Or b7 = "♦1" Or b7 = "♦2" Or b7 = "♦3" Or b7 = "♦4" Or b7 = "♦5" Or b7 = "♦6" Or b7 = "♦7" Or b7 = "♦8" Or b7 = "♦9" Or b7 = "♦10" Or b7 = "♦11" Or b7 = "♦12" Or b7 = "♦13" Then
            A7.ForeColor = Color.Red
        End If
        If b8 = "♥1" Or b8 = "♥2" Or b8 = "♥3" Or b8 = "♥4" Or b8 = "♥5" Or b8 = "♥6" Or b8 = "♥7" Or b8 = "♥8" Or b8 = "♥9" Or b8 = "♥10" Or b8 = "♥11" Or b8 = "♥12" Or b8 = "♥13" Or b8 = "♦1" Or b8 = "♦2" Or b8 = "♦3" Or b8 = "♦4" Or b8 = "♦5" Or b8 = "♦6" Or b8 = "♦7" Or b8 = "♦8" Or b8 = "♦9" Or b8 = "♦10" Or b8 = "♦11" Or b8 = "♦12" Or b8 = "♦13" Then
            A8.ForeColor = Color.Red
        End If
        If b9 = "♥1" Or b9 = "♥2" Or b9 = "♥3" Or b9 = "♥4" Or b9 = "♥5" Or b9 = "♥6" Or b9 = "♥7" Or b9 = "♥8" Or b9 = "♥9" Or b9 = "♥10" Or b9 = "♥11" Or b9 = "♥12" Or b9 = "♥13" Or b9 = "♦1" Or b9 = "♦2" Or b9 = "♦3" Or b9 = "♦4" Or b9 = "♦5" Or b9 = "♦6" Or b9 = "♦7" Or b9 = "♦8" Or b9 = "♦9" Or b9 = "♦10" Or b9 = "♦11" Or b9 = "♦12" Or b9 = "♦13" Then
            A9.ForeColor = Color.Red
        End If
        If b10 = "♥1" Or b10 = "♥2" Or b10 = "♥3" Or b10 = "♥4" Or b10 = "♥5" Or b10 = "♥6" Or b10 = "♥7" Or b10 = "♥8" Or b10 = "♥9" Or b10 = "♥10" Or b10 = "♥11" Or b10 = "♥12" Or b10 = "♥13" Or b10 = "♦1" Or b10 = "♦2" Or b10 = "♦3" Or b10 = "♦4" Or b10 = "♦5" Or b10 = "♦6" Or b10 = "♦7" Or b10 = "♦8" Or b10 = "♦9" Or b10 = "♦10" Or b10 = "♦11" Or b10 = "♦12" Or b10 = "♦13" Then
            A10.ForeColor = Color.Red
        End If
        If b11 = "♥1" Or b11 = "♥2" Or b11 = "♥3" Or b11 = "♥4" Or b11 = "♥5" Or b11 = "♥6" Or b11 = "♥7" Or b11 = "♥8" Or b11 = "♥9" Or b11 = "♥10" Or b11 = "♥11" Or b11 = "♥12" Or b11 = "♥13" Or b11 = "♦1" Or b11 = "♦2" Or b11 = "♦3" Or b11 = "♦4" Or b11 = "♦5" Or b11 = "♦6" Or b11 = "♦7" Or b11 = "♦8" Or b11 = "♦9" Or b11 = "♦10" Or b11 = "♦11" Or b11 = "♦12" Or b11 = "♦13" Then
            A11.ForeColor = Color.Red
        End If
        If b12 = "♥1" Or b12 = "♥2" Or b12 = "♥3" Or b12 = "♥4" Or b12 = "♥5" Or b12 = "♥6" Or b12 = "♥7" Or b12 = "♥8" Or b12 = "♥9" Or b12 = "♥10" Or b12 = "♥11" Or b12 = "♥12" Or b12 = "♥13" Or b12 = "♦1" Or b12 = "♦2" Or b12 = "♦3" Or b12 = "♦4" Or b12 = "♦5" Or b12 = "♦6" Or b12 = "♦7" Or b12 = "♦8" Or b12 = "♦9" Or b12 = "♦10" Or b12 = "♦11" Or b12 = "♦12" Or b12 = "♦13" Then
            A12.ForeColor = Color.Red
        End If
        If b13 = "♥1" Or b13 = "♥2" Or b13 = "♥3" Or b13 = "♥4" Or b13 = "♥5" Or b13 = "♥6" Or b13 = "♥7" Or b13 = "♥8" Or b13 = "♥9" Or b13 = "♥10" Or b13 = "♥11" Or b13 = "♥12" Or b13 = "♥13" Or b13 = "♦1" Or b13 = "♦2" Or b13 = "♦3" Or b13 = "♦4" Or b13 = "♦5" Or b13 = "♦6" Or b13 = "♦7" Or b13 = "♦8" Or b13 = "♦9" Or b13 = "♦10" Or b13 = "♦11" Or b13 = "♦12" Or b13 = "♦13" Then
            A13.ForeColor = Color.Red
        End If
        If b14 = "♥1" Or b14 = "♥2" Or b14 = "♥3" Or b14 = "♥4" Or b14 = "♥5" Or b14 = "♥6" Or b14 = "♥7" Or b14 = "♥8" Or b14 = "♥9" Or b14 = "♥10" Or b14 = "♥11" Or b14 = "♥12" Or b14 = "♥13" Or b14 = "♦1" Or b14 = "♦2" Or b14 = "♦3" Or b14 = "♦4" Or b14 = "♦5" Or b14 = "♦6" Or b14 = "♦7" Or b14 = "♦8" Or b14 = "♦9" Or b14 = "♦10" Or b14 = "♦11" Or b14 = "♦12" Or b14 = "♦13" Then
            A14.ForeColor = Color.Red
        End If
        If b15 = "♥1" Or b15 = "♥2" Or b15 = "♥3" Or b15 = "♥4" Or b15 = "♥5" Or b15 = "♥6" Or b15 = "♥7" Or b15 = "♥8" Or b15 = "♥9" Or b15 = "♥10" Or b15 = "♥11" Or b15 = "♥12" Or b15 = "♥13" Or b15 = "♦1" Or b15 = "♦2" Or b15 = "♦3" Or b15 = "♦4" Or b15 = "♦5" Or b15 = "♦6" Or b15 = "♦7" Or b15 = "♦8" Or b15 = "♦9" Or b15 = "♦10" Or b15 = "♦11" Or b15 = "♦12" Or b15 = "♦13" Then
            A15.ForeColor = Color.Red
        End If
        If b16 = "♥1" Or b16 = "♥2" Or b16 = "♥3" Or b16 = "♥4" Or b16 = "♥5" Or b16 = "♥6" Or b16 = "♥7" Or b16 = "♥8" Or b16 = "♥9" Or b16 = "♥10" Or b16 = "♥11" Or b16 = "♥12" Or b16 = "♥13" Or b16 = "♦1" Or b16 = "♦2" Or b16 = "♦3" Or b16 = "♦4" Or b16 = "♦5" Or b16 = "♦6" Or b16 = "♦7" Or b16 = "♦8" Or b16 = "♦9" Or b16 = "♦10" Or b16 = "♦11" Or b16 = "♦12" Or b16 = "♦13" Then
            A16.ForeColor = Color.Red
        End If
        If b17 = "♥1" Or b17 = "♥2" Or b17 = "♥3" Or b17 = "♥4" Or b17 = "♥5" Or b17 = "♥6" Or b17 = "♥7" Or b17 = "♥8" Or b17 = "♥9" Or b17 = "♥10" Or b17 = "♥11" Or b17 = "♥12" Or b17 = "♥13" Or b17 = "♦1" Or b17 = "♦2" Or b17 = "♦3" Or b17 = "♦4" Or b17 = "♦5" Or b17 = "♦6" Or b17 = "♦7" Or b17 = "♦8" Or b17 = "♦9" Or b17 = "♦10" Or b17 = "♦11" Or b17 = "♦12" Or b17 = "♦13" Then
            A17.ForeColor = Color.Red
        End If
        If b18 = "♥1" Or b18 = "♥2" Or b18 = "♥3" Or b18 = "♥4" Or b18 = "♥5" Or b18 = "♥6" Or b18 = "♥7" Or b18 = "♥8" Or b18 = "♥9" Or b18 = "♥10" Or b18 = "♥11" Or b18 = "♥12" Or b18 = "♥13" Or b18 = "♦1" Or b18 = "♦2" Or b18 = "♦3" Or b18 = "♦4" Or b18 = "♦5" Or b18 = "♦6" Or b18 = "♦7" Or b18 = "♦8" Or b18 = "♦9" Or b18 = "♦10" Or b18 = "♦11" Or b18 = "♦12" Or b18 = "♦13" Then
            A18.ForeColor = Color.Red
        End If
        If b19 = "♥1" Or b19 = "♥2" Or b19 = "♥3" Or b19 = "♥4" Or b19 = "♥5" Or b19 = "♥6" Or b19 = "♥7" Or b19 = "♥8" Or b19 = "♥9" Or b19 = "♥10" Or b19 = "♥11" Or b19 = "♥12" Or b19 = "♥13" Or b19 = "♦1" Or b19 = "♦2" Or b19 = "♦3" Or b19 = "♦4" Or b19 = "♦5" Or b19 = "♦6" Or b19 = "♦7" Or b19 = "♦8" Or b19 = "♦9" Or b19 = "♦10" Or b19 = "♦11" Or b19 = "♦12" Or b19 = "♦13" Then
            A19.ForeColor = Color.Red
        End If
        If b20 = "♥1" Or b20 = "♥2" Or b20 = "♥3" Or b20 = "♥4" Or b20 = "♥5" Or b20 = "♥6" Or b20 = "♥7" Or b20 = "♥8" Or b20 = "♥9" Or b20 = "♥10" Or b20 = "♥11" Or b20 = "♥12" Or b20 = "♥13" Or b20 = "♦1" Or b20 = "♦2" Or b20 = "♦3" Or b20 = "♦4" Or b20 = "♦5" Or b20 = "♦6" Or b20 = "♦7" Or b20 = "♦8" Or b20 = "♦9" Or b20 = "♦10" Or b20 = "♦11" Or b20 = "♦12" Or b20 = "♦13" Then
            A20.ForeColor = Color.Red
        End If
        If b21 = "♥1" Or b21 = "♥2" Or b21 = "♥3" Or b21 = "♥4" Or b21 = "♥5" Or b21 = "♥6" Or b21 = "♥7" Or b21 = "♥8" Or b21 = "♥9" Or b21 = "♥10" Or b21 = "♥11" Or b21 = "♥12" Or b21 = "♥13" Or b21 = "♦1" Or b21 = "♦2" Or b21 = "♦3" Or b21 = "♦4" Or b21 = "♦5" Or b21 = "♦6" Or b21 = "♦7" Or b21 = "♦8" Or b21 = "♦9" Or b21 = "♦10" Or b21 = "♦11" Or b21 = "♦12" Or b21 = "♦13" Then
            A21.ForeColor = Color.Red
        End If
        If b22 = "♥1" Or b22 = "♥2" Or b22 = "♥3" Or b22 = "♥4" Or b22 = "♥5" Or b22 = "♥6" Or b22 = "♥7" Or b22 = "♥8" Or b22 = "♥9" Or b22 = "♥10" Or b22 = "♥11" Or b22 = "♥12" Or b22 = "♥13" Or b22 = "♦1" Or b22 = "♦2" Or b22 = "♦3" Or b22 = "♦4" Or b22 = "♦5" Or b22 = "♦6" Or b22 = "♦7" Or b22 = "♦8" Or b22 = "♦9" Or b22 = "♦10" Or b22 = "♦11" Or b22 = "♦12" Or b22 = "♦13" Then
            A22.ForeColor = Color.Red
        End If
        If b23 = "♥1" Or b23 = "♥2" Or b23 = "♥3" Or b23 = "♥4" Or b23 = "♥5" Or b23 = "♥6" Or b23 = "♥7" Or b23 = "♥8" Or b23 = "♥9" Or b23 = "♥10" Or b23 = "♥11" Or b23 = "♥12" Or b23 = "♥13" Or b23 = "♦1" Or b23 = "♦2" Or b23 = "♦3" Or b23 = "♦4" Or b23 = "♦5" Or b23 = "♦6" Or b23 = "♦7" Or b23 = "♦8" Or b23 = "♦9" Or b23 = "♦10" Or b23 = "♦11" Or b23 = "♦12" Or b23 = "♦13" Then
            A23.ForeColor = Color.Red
        End If
        If b24 = "♥1" Or b24 = "♥2" Or b24 = "♥3" Or b24 = "♥4" Or b24 = "♥5" Or b24 = "♥6" Or b24 = "♥7" Or b24 = "♥8" Or b24 = "♥9" Or b24 = "♥10" Or b24 = "♥11" Or b24 = "♥12" Or b24 = "♥13" Or b24 = "♦1" Or b24 = "♦2" Or b24 = "♦3" Or b24 = "♦4" Or b24 = "♦5" Or b24 = "♦6" Or b24 = "♦7" Or b24 = "♦8" Or b24 = "♦9" Or b24 = "♦10" Or b24 = "♦11" Or b24 = "♦12" Or b24 = "♦13" Then
            A24.ForeColor = Color.Red
        End If
        If b25 = "♥1" Or b25 = "♥2" Or b25 = "♥3" Or b25 = "♥4" Or b25 = "♥5" Or b25 = "♥6" Or b25 = "♥7" Or b25 = "♥8" Or b25 = "♥9" Or b25 = "♥10" Or b25 = "♥11" Or b25 = "♥12" Or b25 = "♥13" Or b25 = "♦1" Or b25 = "♦2" Or b25 = "♦3" Or b25 = "♦4" Or b25 = "♦5" Or b25 = "♦6" Or b25 = "♦7" Or b25 = "♦8" Or b25 = "♦9" Or b25 = "♦10" Or b25 = "♦11" Or b25 = "♦12" Or b25 = "♦13" Then
            A25.ForeColor = Color.Red
        End If
        If b26 = "♥1" Or b26 = "♥2" Or b26 = "♥3" Or b26 = "♥4" Or b26 = "♥5" Or b26 = "♥6" Or b26 = "♥7" Or b26 = "♥8" Or b26 = "♥9" Or b26 = "♥10" Or b26 = "♥11" Or b26 = "♥12" Or b26 = "♥13" Or b26 = "♦1" Or b26 = "♦2" Or b26 = "♦3" Or b26 = "♦4" Or b26 = "♦5" Or b26 = "♦6" Or b26 = "♦7" Or b26 = "♦8" Or b26 = "♦9" Or b26 = "♦10" Or b26 = "♦11" Or b26 = "♦12" Or b26 = "♦13" Then
            A26.ForeColor = Color.Red
        End If
        If b27 = "♥1" Or b27 = "♥2" Or b27 = "♥3" Or b27 = "♥4" Or b27 = "♥5" Or b27 = "♥6" Or b27 = "♥7" Or b27 = "♥8" Or b27 = "♥9" Or b27 = "♥10" Or b27 = "♥11" Or b27 = "♥12" Or b27 = "♥13" Or b27 = "♦1" Or b27 = "♦2" Or b27 = "♦3" Or b27 = "♦4" Or b27 = "♦5" Or b27 = "♦6" Or b27 = "♦7" Or b27 = "♦8" Or b27 = "♦9" Or b27 = "♦10" Or b27 = "♦11" Or b27 = "♦12" Or b27 = "♦13" Then
            A27.ForeColor = Color.Red
        End If
        If b28 = "♥1" Or b28 = "♥2" Or b28 = "♥3" Or b28 = "♥4" Or b28 = "♥5" Or b28 = "♥6" Or b28 = "♥7" Or b28 = "♥8" Or b28 = "♥9" Or b28 = "♥10" Or b28 = "♥11" Or b28 = "♥12" Or b28 = "♥13" Or b28 = "♦1" Or b28 = "♦2" Or b28 = "♦3" Or b28 = "♦4" Or b28 = "♦5" Or b28 = "♦6" Or b28 = "♦7" Or b28 = "♦8" Or b28 = "♦9" Or b28 = "♦10" Or b28 = "♦11" Or b28 = "♦12" Or b28 = "♦13" Then
            A28.ForeColor = Color.Red
        End If
        If b29 = "♥1" Or b29 = "♥2" Or b29 = "♥3" Or b29 = "♥4" Or b29 = "♥5" Or b29 = "♥6" Or b29 = "♥7" Or b29 = "♥8" Or b29 = "♥9" Or b29 = "♥10" Or b29 = "♥11" Or b29 = "♥12" Or b29 = "♥13" Or b29 = "♦1" Or b29 = "♦2" Or b29 = "♦3" Or b29 = "♦4" Or b29 = "♦5" Or b29 = "♦6" Or b29 = "♦7" Or b29 = "♦8" Or b29 = "♦9" Or b29 = "♦10" Or b29 = "♦11" Or b29 = "♦12" Or b29 = "♦13" Then
            A29.ForeColor = Color.Red
        End If
        If b30 = "♥1" Or b30 = "♥2" Or b30 = "♥3" Or b30 = "♥4" Or b30 = "♥5" Or b30 = "♥6" Or b30 = "♥7" Or b30 = "♥8" Or b30 = "♥9" Or b30 = "♥10" Or b30 = "♥11" Or b30 = "♥12" Or b30 = "♥13" Or b30 = "♦1" Or b30 = "♦2" Or b30 = "♦3" Or b30 = "♦4" Or b30 = "♦5" Or b30 = "♦6" Or b30 = "♦7" Or b30 = "♦8" Or b30 = "♦9" Or b30 = "♦10" Or b30 = "♦11" Or b30 = "♦12" Or b30 = "♦13" Then
            A30.ForeColor = Color.Red
        End If
        If b31 = "♥1" Or b31 = "♥2" Or b31 = "♥3" Or b31 = "♥4" Or b31 = "♥5" Or b31 = "♥6" Or b31 = "♥7" Or b31 = "♥8" Or b31 = "♥9" Or b31 = "♥10" Or b31 = "♥11" Or b31 = "♥12" Or b31 = "♥13" Or b31 = "♦1" Or b31 = "♦2" Or b31 = "♦3" Or b31 = "♦4" Or b31 = "♦5" Or b31 = "♦6" Or b31 = "♦7" Or b31 = "♦8" Or b31 = "♦9" Or b31 = "♦10" Or b31 = "♦11" Or b31 = "♦12" Or b31 = "♦13" Then
            A31.ForeColor = Color.Red
        End If
        If b32 = "♥1" Or b32 = "♥2" Or b32 = "♥3" Or b32 = "♥4" Or b32 = "♥5" Or b32 = "♥6" Or b32 = "♥7" Or b32 = "♥8" Or b32 = "♥9" Or b32 = "♥10" Or b32 = "♥11" Or b32 = "♥12" Or b32 = "♥13" Or b32 = "♦1" Or b32 = "♦2" Or b32 = "♦3" Or b32 = "♦4" Or b32 = "♦5" Or b32 = "♦6" Or b32 = "♦7" Or b32 = "♦8" Or b32 = "♦9" Or b32 = "♦10" Or b32 = "♦11" Or b32 = "♦12" Or b32 = "♦13" Then
            A32.ForeColor = Color.Red
        End If
        If b33 = "♥1" Or b33 = "♥2" Or b33 = "♥3" Or b33 = "♥4" Or b33 = "♥5" Or b33 = "♥6" Or b33 = "♥7" Or b33 = "♥8" Or b33 = "♥9" Or b33 = "♥10" Or b33 = "♥11" Or b33 = "♥12" Or b33 = "♥13" Or b33 = "♦1" Or b33 = "♦2" Or b33 = "♦3" Or b33 = "♦4" Or b33 = "♦5" Or b33 = "♦6" Or b33 = "♦7" Or b33 = "♦8" Or b33 = "♦9" Or b33 = "♦10" Or b33 = "♦11" Or b33 = "♦12" Or b33 = "♦13" Then
            A33.ForeColor = Color.Red
        End If
        If b34 = "♥1" Or b34 = "♥2" Or b34 = "♥3" Or b34 = "♥4" Or b34 = "♥5" Or b34 = "♥6" Or b34 = "♥7" Or b34 = "♥8" Or b34 = "♥9" Or b34 = "♥10" Or b34 = "♥11" Or b34 = "♥12" Or b34 = "♥13" Or b34 = "♦1" Or b34 = "♦2" Or b34 = "♦3" Or b34 = "♦4" Or b34 = "♦5" Or b34 = "♦6" Or b34 = "♦7" Or b34 = "♦8" Or b34 = "♦9" Or b34 = "♦10" Or b34 = "♦11" Or b34 = "♦12" Or b34 = "♦13" Then
            A34.ForeColor = Color.Red
        End If
        If b35 = "♥1" Or b35 = "♥2" Or b35 = "♥3" Or b35 = "♥4" Or b35 = "♥5" Or b35 = "♥6" Or b35 = "♥7" Or b35 = "♥8" Or b35 = "♥9" Or b35 = "♥10" Or b35 = "♥11" Or b35 = "♥12" Or b35 = "♥13" Or b35 = "♦1" Or b35 = "♦2" Or b35 = "♦3" Or b35 = "♦4" Or b35 = "♦5" Or b35 = "♦6" Or b35 = "♦7" Or b35 = "♦8" Or b35 = "♦9" Or b35 = "♦10" Or b35 = "♦11" Or b35 = "♦12" Or b35 = "♦13" Then
            A35.ForeColor = Color.Red
        End If
        If b36 = "♥1" Or b36 = "♥2" Or b36 = "♥3" Or b36 = "♥4" Or b36 = "♥5" Or b36 = "♥6" Or b36 = "♥7" Or b36 = "♥8" Or b36 = "♥9" Or b36 = "♥10" Or b36 = "♥11" Or b36 = "♥12" Or b36 = "♥13" Or b36 = "♦1" Or b36 = "♦2" Or b36 = "♦3" Or b36 = "♦4" Or b36 = "♦5" Or b36 = "♦6" Or b36 = "♦7" Or b36 = "♦8" Or b36 = "♦9" Or b36 = "♦10" Or b36 = "♦11" Or b36 = "♦12" Or b36 = "♦13" Then
            A36.ForeColor = Color.Red
        End If
        If b37 = "♥1" Or b37 = "♥2" Or b37 = "♥3" Or b37 = "♥4" Or b37 = "♥5" Or b37 = "♥6" Or b37 = "♥7" Or b37 = "♥8" Or b37 = "♥9" Or b37 = "♥10" Or b37 = "♥11" Or b37 = "♥12" Or b37 = "♥13" Or b37 = "♦1" Or b37 = "♦2" Or b37 = "♦3" Or b37 = "♦4" Or b37 = "♦5" Or b37 = "♦6" Or b37 = "♦7" Or b37 = "♦8" Or b37 = "♦9" Or b37 = "♦10" Or b37 = "♦11" Or b37 = "♦12" Or b37 = "♦13" Then
            A37.ForeColor = Color.Red
        End If
        If b38 = "♥1" Or b38 = "♥2" Or b38 = "♥3" Or b38 = "♥4" Or b38 = "♥5" Or b38 = "♥6" Or b38 = "♥7" Or b38 = "♥8" Or b38 = "♥9" Or b38 = "♥10" Or b38 = "♥11" Or b38 = "♥12" Or b38 = "♥13" Or b38 = "♦1" Or b38 = "♦2" Or b38 = "♦3" Or b38 = "♦4" Or b38 = "♦5" Or b38 = "♦6" Or b38 = "♦7" Or b38 = "♦8" Or b38 = "♦9" Or b38 = "♦10" Or b38 = "♦11" Or b38 = "♦12" Or b38 = "♦13" Then
            A38.ForeColor = Color.Red
        End If
        If b39 = "♥1" Or b39 = "♥2" Or b39 = "♥3" Or b39 = "♥4" Or b39 = "♥5" Or b39 = "♥6" Or b39 = "♥7" Or b39 = "♥8" Or b39 = "♥9" Or b39 = "♥10" Or b39 = "♥11" Or b39 = "♥12" Or b39 = "♥13" Or b39 = "♦1" Or b39 = "♦2" Or b39 = "♦3" Or b39 = "♦4" Or b39 = "♦5" Or b39 = "♦6" Or b39 = "♦7" Or b39 = "♦8" Or b39 = "♦9" Or b39 = "♦10" Or b39 = "♦11" Or b39 = "♦12" Or b39 = "♦13" Then
            A39.ForeColor = Color.Red
        End If
        If b40 = "♥1" Or b40 = "♥2" Or b40 = "♥3" Or b40 = "♥4" Or b40 = "♥5" Or b40 = "♥6" Or b40 = "♥7" Or b40 = "♥8" Or b40 = "♥9" Or b40 = "♥10" Or b40 = "♥11" Or b40 = "♥12" Or b40 = "♥13" Or b40 = "♦1" Or b40 = "♦2" Or b40 = "♦3" Or b40 = "♦4" Or b40 = "♦5" Or b40 = "♦6" Or b40 = "♦7" Or b40 = "♦8" Or b40 = "♦9" Or b40 = "♦10" Or b40 = "♦11" Or b40 = "♦12" Or b40 = "♦13" Then
            A40.ForeColor = Color.Red
        End If
        If b41 = "♥1" Or b41 = "♥2" Or b41 = "♥3" Or b41 = "♥4" Or b41 = "♥5" Or b41 = "♥6" Or b41 = "♥7" Or b41 = "♥8" Or b41 = "♥9" Or b41 = "♥10" Or b41 = "♥11" Or b41 = "♥12" Or b41 = "♥13" Or b41 = "♦1" Or b41 = "♦2" Or b41 = "♦3" Or b41 = "♦4" Or b41 = "♦5" Or b41 = "♦6" Or b41 = "♦7" Or b41 = "♦8" Or b41 = "♦9" Or b41 = "♦10" Or b41 = "♦11" Or b41 = "♦12" Or b41 = "♦13" Then
            A41.ForeColor = Color.Red
        End If
        If b42 = "♥1" Or b42 = "♥2" Or b42 = "♥3" Or b42 = "♥4" Or b42 = "♥5" Or b42 = "♥6" Or b42 = "♥7" Or b42 = "♥8" Or b42 = "♥9" Or b42 = "♥10" Or b42 = "♥11" Or b42 = "♥12" Or b42 = "♥13" Or b42 = "♦1" Or b42 = "♦2" Or b42 = "♦3" Or b42 = "♦4" Or b42 = "♦5" Or b42 = "♦6" Or b42 = "♦7" Or b42 = "♦8" Or b42 = "♦9" Or b42 = "♦10" Or b42 = "♦11" Or b42 = "♦12" Or b42 = "♦13" Then
            A42.ForeColor = Color.Red
        End If
        If b43 = "♥1" Or b43 = "♥2" Or b43 = "♥3" Or b43 = "♥4" Or b43 = "♥5" Or b43 = "♥6" Or b43 = "♥7" Or b43 = "♥8" Or b43 = "♥9" Or b43 = "♥10" Or b43 = "♥11" Or b43 = "♥12" Or b43 = "♥13" Or b43 = "♦1" Or b43 = "♦2" Or b43 = "♦3" Or b43 = "♦4" Or b43 = "♦5" Or b43 = "♦6" Or b43 = "♦7" Or b43 = "♦8" Or b43 = "♦9" Or b43 = "♦10" Or b43 = "♦11" Or b43 = "♦12" Or b43 = "♦13" Then
            A43.ForeColor = Color.Red
        End If
        If b44 = "♥1" Or b44 = "♥2" Or b44 = "♥3" Or b44 = "♥4" Or b44 = "♥5" Or b44 = "♥6" Or b44 = "♥7" Or b44 = "♥8" Or b44 = "♥9" Or b44 = "♥10" Or b44 = "♥11" Or b44 = "♥12" Or b44 = "♥13" Or b44 = "♦1" Or b44 = "♦2" Or b44 = "♦3" Or b44 = "♦4" Or b44 = "♦5" Or b44 = "♦6" Or b44 = "♦7" Or b44 = "♦8" Or b44 = "♦9" Or b44 = "♦10" Or b44 = "♦11" Or b44 = "♦12" Or b44 = "♦13" Then
            A44.ForeColor = Color.Red
        End If
        If b45 = "♥1" Or b45 = "♥2" Or b45 = "♥3" Or b45 = "♥4" Or b45 = "♥5" Or b45 = "♥6" Or b45 = "♥7" Or b45 = "♥8" Or b45 = "♥9" Or b45 = "♥10" Or b45 = "♥11" Or b45 = "♥12" Or b45 = "♥13" Or b45 = "♦1" Or b45 = "♦2" Or b45 = "♦3" Or b45 = "♦4" Or b45 = "♦5" Or b45 = "♦6" Or b45 = "♦7" Or b45 = "♦8" Or b45 = "♦9" Or b45 = "♦10" Or b45 = "♦11" Or b45 = "♦12" Or b45 = "♦13" Then
            A45.ForeColor = Color.Red
        End If
        If b46 = "♥1" Or b46 = "♥2" Or b46 = "♥3" Or b46 = "♥4" Or b46 = "♥5" Or b46 = "♥6" Or b46 = "♥7" Or b46 = "♥8" Or b46 = "♥9" Or b46 = "♥10" Or b46 = "♥11" Or b46 = "♥12" Or b46 = "♥13" Or b46 = "♦1" Or b46 = "♦2" Or b46 = "♦3" Or b46 = "♦4" Or b46 = "♦5" Or b46 = "♦6" Or b46 = "♦7" Or b46 = "♦8" Or b46 = "♦9" Or b46 = "♦10" Or b46 = "♦11" Or b46 = "♦12" Or b46 = "♦13" Then
            A46.ForeColor = Color.Red
        End If
        If b47 = "♥1" Or b47 = "♥2" Or b47 = "♥3" Or b47 = "♥4" Or b47 = "♥5" Or b47 = "♥6" Or b47 = "♥7" Or b47 = "♥8" Or b47 = "♥9" Or b47 = "♥10" Or b47 = "♥11" Or b47 = "♥12" Or b47 = "♥13" Or b47 = "♦1" Or b47 = "♦2" Or b47 = "♦3" Or b47 = "♦4" Or b47 = "♦5" Or b47 = "♦6" Or b47 = "♦7" Or b47 = "♦8" Or b47 = "♦9" Or b47 = "♦10" Or b47 = "♦11" Or b47 = "♦12" Or b47 = "♦13" Then
            A47.ForeColor = Color.Red
        End If
        If b48 = "♥1" Or b48 = "♥2" Or b48 = "♥3" Or b48 = "♥4" Or b48 = "♥5" Or b48 = "♥6" Or b48 = "♥7" Or b48 = "♥8" Or b48 = "♥9" Or b48 = "♥10" Or b48 = "♥11" Or b48 = "♥12" Or b48 = "♥13" Or b48 = "♦1" Or b48 = "♦2" Or b48 = "♦3" Or b48 = "♦4" Or b48 = "♦5" Or b48 = "♦6" Or b48 = "♦7" Or b48 = "♦8" Or b48 = "♦9" Or b48 = "♦10" Or b48 = "♦11" Or b48 = "♦12" Or b48 = "♦13" Then
            A48.ForeColor = Color.Red
        End If
        If b49 = "♥1" Or b49 = "♥2" Or b49 = "♥3" Or b49 = "♥4" Or b49 = "♥5" Or b49 = "♥6" Or b49 = "♥7" Or b49 = "♥8" Or b49 = "♥9" Or b49 = "♥10" Or b49 = "♥11" Or b49 = "♥12" Or b49 = "♥13" Or b49 = "♦1" Or b49 = "♦2" Or b49 = "♦3" Or b49 = "♦4" Or b49 = "♦5" Or b49 = "♦6" Or b49 = "♦7" Or b49 = "♦8" Or b49 = "♦9" Or b49 = "♦10" Or b49 = "♦11" Or b49 = "♦12" Or b49 = "♦13" Then
            A49.ForeColor = Color.Red
        End If
        If b50 = "♥1" Or b50 = "♥2" Or b50 = "♥3" Or b50 = "♥4" Or b50 = "♥5" Or b50 = "♥6" Or b50 = "♥7" Or b50 = "♥8" Or b50 = "♥9" Or b50 = "♥10" Or b50 = "♥11" Or b50 = "♥12" Or b50 = "♥13" Or b50 = "♦1" Or b50 = "♦2" Or b50 = "♦3" Or b50 = "♦4" Or b50 = "♦5" Or b50 = "♦6" Or b50 = "♦7" Or b50 = "♦8" Or b50 = "♦9" Or b50 = "♦10" Or b50 = "♦11" Or b50 = "♦12" Or b50 = "♦13" Then
            A50.ForeColor = Color.Red
        End If
        If b51 = "♥1" Or b51 = "♥2" Or b51 = "♥3" Or b51 = "♥4" Or b51 = "♥5" Or b51 = "♥6" Or b51 = "♥7" Or b51 = "♥8" Or b51 = "♥9" Or b51 = "♥10" Or b51 = "♥11" Or b51 = "♥12" Or b51 = "♥13" Or b51 = "♦1" Or b51 = "♦2" Or b51 = "♦3" Or b51 = "♦4" Or b51 = "♦5" Or b51 = "♦6" Or b51 = "♦7" Or b51 = "♦8" Or b51 = "♦9" Or b51 = "♦10" Or b51 = "♦11" Or b51 = "♦12" Or b51 = "♦13" Then
            A51.ForeColor = Color.Red
        End If
        If b52 = "♥1" Or b52 = "♥2" Or b52 = "♥3" Or b52 = "♥4" Or b52 = "♥5" Or b52 = "♥6" Or b52 = "♥7" Or b52 = "♥8" Or b52 = "♥9" Or b52 = "♥10" Or b52 = "♥11" Or b52 = "♥12" Or b52 = "♥13" Or b52 = "♦1" Or b52 = "♦2" Or b52 = "♦3" Or b52 = "♦4" Or b52 = "♦5" Or b52 = "♦6" Or b52 = "♦7" Or b52 = "♦8" Or b52 = "♦9" Or b52 = "♦10" Or b52 = "♦11" Or b52 = "♦12" Or b52 = "♦13" Then
            A52.ForeColor = Color.Red
        End If
    End Sub

    'Check
    Sub CA()
        'an1.Angle = r.Next(1, 360)
        'a1.RenderTransform = an1
        'an2.Angle = r.Next(1, 360)
        'a2.RenderTransform = an2
        'an3.Angle = r.Next(1, 360)
        'a3.RenderTransform = an3
        'an4.Angle = r.Next(1, 360)
        'a4.RenderTransform = an4
        'an5.Angle = r.Next(1, 360)
        'a5.RenderTransform = an5
        'an6.Angle = r.Next(1, 360)
        'a6.RenderTransform = an6
        'an7.Angle = r.Next(1, 360)
        'a7.RenderTransform = an7
        'an8.Angle = r.Next(1, 360)
        'a8.RenderTransform = an8
        'an9.Angle = r.Next(1, 360)
        'a9.RenderTransform = an9
        'an10.Angle = r.Next(1, 360)
        'a10.RenderTransform = an10
        'an11.Angle = r.Next(1, 360)
        'a11.RenderTransform = an11
        'an12.Angle = r.Next(1, 360)
        'a12.RenderTransform = an12
        'an13.Angle = r.Next(1, 360)
        'a13.RenderTransform = an13
        'an14.Angle = r.Next(1, 360)
        'a14.RenderTransform = an14
        'an15.Angle = r.Next(1, 360)
        'a15.RenderTransform = an15
        'an16.Angle = r.Next(1, 360)
        'a16.RenderTransform = an16
        'an17.Angle = r.Next(1, 360)
        'a17.RenderTransform = an17
        'an18.Angle = r.Next(1, 360)
        'a18.RenderTransform = an18
        'an19.Angle = r.Next(1, 360)
        'a19.RenderTransform = an19
        'an20.Angle = r.Next(1, 360)
        'a20.RenderTransform = an20
        'an21.Angle = r.Next(1, 360)
        'a21.RenderTransform = an21
        'an22.Angle = r.Next(1, 360)
        'a22.RenderTransform = an22
        'an23.Angle = r.Next(1, 360)
        'a23.RenderTransform = an23
        'an24.Angle = r.Next(1, 360)
        'a24.RenderTransform = an24
        'an25.Angle = r.Next(1, 360)
        'a25.RenderTransform = an25
        'an26.Angle = r.Next(1, 360)
        'a26.RenderTransform = an26
        'an27.Angle = r.Next(1, 360)
        'a27.RenderTransform = an27
        'an28.Angle = r.Next(1, 360)
        'a28.RenderTransform = an28
        'an29.Angle = r.Next(1, 360)
        'a29.RenderTransform = an29
        'an30.Angle = r.Next(1, 360)
        'a30.RenderTransform = an30
        'an31.Angle = r.Next(1, 360)
        'a31.RenderTransform = an31
        'an32.Angle = r.Next(1, 360)
        'a32.RenderTransform = an32
        'an33.Angle = r.Next(1, 360)
        'a33.RenderTransform = an33
        'an34.Angle = r.Next(1, 360)
        'a34.RenderTransform = an34
        'an35.Angle = r.Next(1, 360)
        'a35.RenderTransform = an35
        'an36.Angle = r.Next(1, 360)
        'a36.RenderTransform = an36
        'an37.Angle = r.Next(1, 360)
        'a37.RenderTransform = an37
        'an38.Angle = r.Next(1, 360)
        'a38.RenderTransform = an38
        'an39.Angle = r.Next(1, 360)
        'a39.RenderTransform = an39
        'an40.Angle = r.Next(1, 360)
        'a40.RenderTransform = an40
        'an41.Angle = r.Next(1, 360)
        'a41.RenderTransform = an41
        'an42.Angle = r.Next(1, 360)
        'a42.RenderTransform = an42
        'an43.Angle = r.Next(1, 360)
        'a43.RenderTransform = an43
        'an44.Angle = r.Next(1, 360)
        'a44.RenderTransform = an44
        'an45.Angle = r.Next(1, 360)
        'a45.RenderTransform = an45
        'an46.Angle = r.Next(1, 360)
        'a46.RenderTransform = an46
        'an47.Angle = r.Next(1, 360)
        'a47.RenderTransform = an47
        'an48.Angle = r.Next(1, 360)
        'a48.RenderTransform = an48
        'an49.Angle = r.Next(1, 360)
        'a49.RenderTransform = an49
        'an50.Angle = r.Next(1, 360)
        'a50.RenderTransform = an50
        'an51.Angle = r.Next(1, 360)
        'a51.RenderTransform = an51
        'an52.Angle = r.Next(1, 360)
        'a52.RenderTransform = an52
    End Sub

    Sub PC()
        If pn = 2 Then
            If p = 1 Then
                p = 2
                L.Text = "Player 2"
            ElseIf p = 2 Then
                p = 1
                L.Text = "Player 1"
            End If
        ElseIf pn = 3 Then
            If p = 1 Then
                p = 2
                L.Text = "Player 2"
            ElseIf p = 2 Then
                p = 3
                L.Text = "Player 3"
            ElseIf p = 3 Then
                p = 1
                L.Text = "Player 1"
            End If
        ElseIf pn = 4 Then
            If p = 1 Then
                p = 2
                L.Text = "Player 2"
            ElseIf p = 2 Then
                p = 3
                L.Text = "Player 3"
            ElseIf p = 3 Then
                p = 4
                L.Text = "Player 4"
            ElseIf p = 4 Then
                p = 1
                L.Text = "Player 1"
            End If
        ElseIf pn = 5 Then
            If p = 1 Then
                p = 2
                L.Text = "Player 2"
            ElseIf p = 2 Then
                p = 3
                L.Text = "Player 3"
            ElseIf p = 3 Then
                p = 4
                L.Text = "Player 4"
            ElseIf p = 4 Then
                p = 5
                L.Text = "Player 5"
            ElseIf p = 5 Then
                p = 1
                L.Text = "Player 1"
            End If
        ElseIf pn = 6 Then
            If p = 1 Then
                p = 2
                L.Text = "Player 2"
            ElseIf p = 2 Then
                p = 3
                L.Text = "Player 3"
            ElseIf p = 3 Then
                p = 4
                L.Text = "Player 4"
            ElseIf p = 4 Then
                p = 5
                L.Text = "Player 5"
            ElseIf p = 5 Then
                p = 6
                L.Text = "Player 6"
            ElseIf p = 6 Then
                p = 1
                L.Text = "Player 1"
            End If
        End If
    End Sub

    Sub SC()
        If sn = 1 Then
            LS1.Text = s1
            If s1 = "♥1" Or s1 = "♥2" Or s1 = "♥3" Or s1 = "♥4" Or s1 = "♥5" Or s1 = "♥6" Or s1 = "♥7" Or s1 = "♥8" Or s1 = "♥9" Or s1 = "♥10" Or s1 = "♥11" Or s1 = "♥12" Or s1 = "♥13" Or s1 = "♦1" Or s1 = "♦2" Or s1 = "♦3" Or s1 = "♦4" Or s1 = "♦5" Or s1 = "♦6" Or s1 = "♦7" Or s1 = "♦8" Or s1 = "♦9" Or s1 = "♦10" Or s1 = "♦11" Or s1 = "♦12" Or s1 = "♦13" Then
                LS1.ForeColor = Color.Red
            Else
                LS1.ForeColor = Color.Black
            End If
            sn = 2
        ElseIf sn = 2 Then
            LS2.Text = s2
            If s2 = "♥1" Or s2 = "♥2" Or s2 = "♥3" Or s2 = "♥4" Or s2 = "♥5" Or s2 = "♥6" Or s2 = "♥7" Or s2 = "♥8" Or s2 = "♥9" Or s2 = "♥10" Or s2 = "♥11" Or s2 = "♥12" Or s2 = "♥13" Or s2 = "♦1" Or s2 = "♦2" Or s2 = "♦3" Or s2 = "♦4" Or s2 = "♦5" Or s2 = "♦6" Or s2 = "♦7" Or s2 = "♦8" Or s2 = "♦9" Or s2 = "♦10" Or s2 = "♦11" Or s2 = "♦12" Or s2 = "♦13" Then
                LS2.ForeColor = Color.Red
            Else
                LS2.ForeColor = Color.Black
            End If
            sn = 1
        End If
    End Sub

    Sub AC()
        A1.Text = ""
        A2.Text = ""
        A3.Text = ""
        A4.Text = ""
        A5.Text = ""
        A6.Text = ""
        A7.Text = ""
        A8.Text = ""
        A9.Text = ""
        A10.Text = ""
        A11.Text = ""
        A12.Text = ""
        A13.Text = ""
        A14.Text = ""
        A15.Text = ""
        A16.Text = ""
        A17.Text = ""
        A18.Text = ""
        A19.Text = ""
        A20.Text = ""
        A21.Text = ""
        A22.Text = ""
        A23.Text = ""
        A24.Text = ""
        A25.Text = ""
        A26.Text = ""
        A27.Text = ""
        A28.Text = ""
        A29.Text = ""
        A30.Text = ""
        A31.Text = ""
        A32.Text = ""
        A33.Text = ""
        A34.Text = ""
        A35.Text = ""
        A36.Text = ""
        A37.Text = ""
        A38.Text = ""
        A39.Text = ""
        A40.Text = ""
        A41.Text = ""
        A42.Text = ""
        A43.Text = ""
        A44.Text = ""
        A45.Text = ""
        A46.Text = ""
        A47.Text = ""
        A48.Text = ""
        A49.Text = ""
        A50.Text = ""
        A51.Text = ""
        A52.Text = ""
    End Sub

    Sub TC()
        If n1 = n2 Then
            CO()
            ow.BC.Enabled = True
            ow.Focus()
            ow.BC.Focus()
        Else
            CO()
            ow.BC.Enabled = True
            ow.Focus()
            ow.BC.Focus()
        End If
    End Sub

    Sub EN()
        A1.Enabled = True
        A2.Enabled = True
        A3.Enabled = True
        A4.Enabled = True
        A5.Enabled = True
        A6.Enabled = True
        A7.Enabled = True
        A8.Enabled = True
        A9.Enabled = True
        A10.Enabled = True
        A11.Enabled = True
        A12.Enabled = True
        A13.Enabled = True
        A14.Enabled = True
        A15.Enabled = True
        A16.Enabled = True
        A17.Enabled = True
        A18.Enabled = True
        A19.Enabled = True
        A20.Enabled = True
        A21.Enabled = True
        A22.Enabled = True
        A23.Enabled = True
        A24.Enabled = True
        A25.Enabled = True
        A26.Enabled = True
        A27.Enabled = True
        A28.Enabled = True
        A29.Enabled = True
        A30.Enabled = True
        A31.Enabled = True
        A32.Enabled = True
        A33.Enabled = True
        A34.Enabled = True
        A35.Enabled = True
        A36.Enabled = True
        A37.Enabled = True
        A38.Enabled = True
        A39.Enabled = True
        A40.Enabled = True
        A41.Enabled = True
        A42.Enabled = True
        A43.Enabled = True
        A44.Enabled = True
        A45.Enabled = True
        A46.Enabled = True
        A47.Enabled = True
        A48.Enabled = True
        A49.Enabled = True
        A50.Enabled = True
        A51.Enabled = True
        A52.Enabled = True
    End Sub

    Sub CO()
        A1.Enabled = False
        A2.Enabled = False
        A3.Enabled = False
        A4.Enabled = False
        A5.Enabled = False
        A6.Enabled = False
        A7.Enabled = False
        A8.Enabled = False
        A9.Enabled = False
        A10.Enabled = False
        A11.Enabled = False
        A12.Enabled = False
        A13.Enabled = False
        A14.Enabled = False
        A15.Enabled = False
        A16.Enabled = False
        A17.Enabled = False
        A18.Enabled = False
        A19.Enabled = False
        A20.Enabled = False
        A21.Enabled = False
        A22.Enabled = False
        A23.Enabled = False
        A24.Enabled = False
        A25.Enabled = False
        A26.Enabled = False
        A27.Enabled = False
        A28.Enabled = False
        A29.Enabled = False
        A30.Enabled = False
        A31.Enabled = False
        A32.Enabled = False
        A33.Enabled = False
        A34.Enabled = False
        A35.Enabled = False
        A36.Enabled = False
        A37.Enabled = False
        A38.Enabled = False
        A39.Enabled = False
        A40.Enabled = False
        A41.Enabled = False
        A42.Enabled = False
        A43.Enabled = False
        A44.Enabled = False
        A45.Enabled = False
        A46.Enabled = False
        A47.Enabled = False
        A48.Enabled = False
        A49.Enabled = False
        A50.Enabled = False
        A51.Enabled = False
        A52.Enabled = False
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        If sn = 1 Then
            A1.Enabled = False
            A1.Text = b1
            s1 = b1
            If b1 = "♥1" Or b1 = "♦1" Or b1 = "♧1" Or b1 = "♤1" Then
                n1 = 1
            ElseIf b1 = "♥2" Or b1 = "♦2" Or b1 = "♧2" Or b1 = "♤2" Then
                n1 = 2
            ElseIf b1 = "♥3" Or b1 = "♦3" Or b1 = "♧3" Or b1 = "♤3" Then
                n1 = 3
            ElseIf b1 = "♥4" Or b1 = "♦4" Or b1 = "♧4" Or b1 = "♤4" Then
                n1 = 4
            ElseIf b1 = "♥5" Or b1 = "♦5" Or b1 = "♧5" Or b1 = "♤5" Then
                n1 = 5
            ElseIf b1 = "♥6" Or b1 = "♦6" Or b1 = "♧6" Or b1 = "♤6" Then
                n1 = 6
            ElseIf b1 = "♥7" Or b1 = "♦7" Or b1 = "♧7" Or b1 = "♤7" Then
                n1 = 7
            ElseIf b1 = "♥8" Or b1 = "♦8" Or b1 = "♧8" Or b1 = "♤8" Then
                n1 = 8
            ElseIf b1 = "♥9" Or b1 = "♦9" Or b1 = "♧9" Or b1 = "♤9" Then
                n1 = 9
            ElseIf b1 = "♥10" Or b1 = "♦10" Or b1 = "♧10" Or b1 = "♤10" Then
                n1 = 10
            ElseIf b1 = "♥11" Or b1 = "♦11" Or b1 = "♧11" Or b1 = "♤11" Then
                n1 = 11
            ElseIf b1 = "♥12" Or b1 = "♦12" Or b1 = "♧12" Or b1 = "♤12" Then
                n1 = 12
            ElseIf b1 = "♥13" Or b1 = "♦13" Or b1 = "♧13" Or b1 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A1.Text = b1
            s2 = b1
            If b1 = "♥1" Or b1 = "♦1" Or b1 = "♧1" Or b1 = "♤1" Then
                n2 = 1
            ElseIf b1 = "♥2" Or b1 = "♦2" Or b1 = "♧2" Or b1 = "♤2" Then
                n2 = 2
            ElseIf b1 = "♥3" Or b1 = "♦3" Or b1 = "♧3" Or b1 = "♤3" Then
                n2 = 3
            ElseIf b1 = "♥4" Or b1 = "♦4" Or b1 = "♧4" Or b1 = "♤4" Then
                n2 = 4
            ElseIf b1 = "♥5" Or b1 = "♦5" Or b1 = "♧5" Or b1 = "♤5" Then
                n2 = 5
            ElseIf b1 = "♥6" Or b1 = "♦6" Or b1 = "♧6" Or b1 = "♤6" Then
                n2 = 6
            ElseIf b1 = "♥7" Or b1 = "♦7" Or b1 = "♧7" Or b1 = "♤7" Then
                n2 = 7
            ElseIf b1 = "♥8" Or b1 = "♦8" Or b1 = "♧8" Or b1 = "♤8" Then
                n2 = 8
            ElseIf b1 = "♥9" Or b1 = "♦9" Or b1 = "♧9" Or b1 = "♤9" Then
                n2 = 9
            ElseIf b1 = "♥10" Or b1 = "♦10" Or b1 = "♧10" Or b1 = "♤10" Then
                n2 = 10
            ElseIf b1 = "♥11" Or b1 = "♦11" Or b1 = "♧11" Or b1 = "♤11" Then
                n2 = 11
            ElseIf b1 = "♥12" Or b1 = "♦12" Or b1 = "♧12" Or b1 = "♤12" Then
                n2 = 12
            ElseIf b1 = "♥13" Or b1 = "♦13" Or b1 = "♧13" Or b1 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        If sn = 1 Then
            A2.Enabled = False
            A2.Text = b2
            s1 = b2
            If b2 = "♥1" Or b2 = "♦1" Or b2 = "♧1" Or b2 = "♤1" Then
                n1 = 1
            ElseIf b2 = "♥2" Or b2 = "♦2" Or b2 = "♧2" Or b2 = "♤2" Then
                n1 = 2
            ElseIf b2 = "♥3" Or b2 = "♦3" Or b2 = "♧3" Or b2 = "♤3" Then
                n1 = 3
            ElseIf b2 = "♥4" Or b2 = "♦4" Or b2 = "♧4" Or b2 = "♤4" Then
                n1 = 4
            ElseIf b2 = "♥5" Or b2 = "♦5" Or b2 = "♧5" Or b2 = "♤5" Then
                n1 = 5
            ElseIf b2 = "♥6" Or b2 = "♦6" Or b2 = "♧6" Or b2 = "♤6" Then
                n1 = 6
            ElseIf b2 = "♥7" Or b2 = "♦7" Or b2 = "♧7" Or b2 = "♤7" Then
                n1 = 7
            ElseIf b2 = "♥8" Or b2 = "♦8" Or b2 = "♧8" Or b2 = "♤8" Then
                n1 = 8
            ElseIf b2 = "♥9" Or b2 = "♦9" Or b2 = "♧9" Or b2 = "♤9" Then
                n1 = 9
            ElseIf b2 = "♥10" Or b2 = "♦10" Or b2 = "♧10" Or b2 = "♤10" Then
                n1 = 10
            ElseIf b2 = "♥11" Or b2 = "♦11" Or b2 = "♧11" Or b2 = "♤11" Then
                n1 = 11
            ElseIf b2 = "♥12" Or b2 = "♦12" Or b2 = "♧12" Or b2 = "♤12" Then
                n1 = 12
            ElseIf b2 = "♥13" Or b2 = "♦13" Or b2 = "♧13" Or b2 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A2.Text = b2
            s2 = b2
            If b2 = "♥1" Or b2 = "♦1" Or b2 = "♧1" Or b2 = "♤1" Then
                n2 = 1
            ElseIf b2 = "♥2" Or b2 = "♦2" Or b2 = "♧2" Or b2 = "♤2" Then
                n2 = 2
            ElseIf b2 = "♥3" Or b2 = "♦3" Or b2 = "♧3" Or b2 = "♤3" Then
                n2 = 3
            ElseIf b2 = "♥4" Or b2 = "♦4" Or b2 = "♧4" Or b2 = "♤4" Then
                n2 = 4
            ElseIf b2 = "♥5" Or b2 = "♦5" Or b2 = "♧5" Or b2 = "♤5" Then
                n2 = 5
            ElseIf b2 = "♥6" Or b2 = "♦6" Or b2 = "♧6" Or b2 = "♤6" Then
                n2 = 6
            ElseIf b2 = "♥7" Or b2 = "♦7" Or b2 = "♧7" Or b2 = "♤7" Then
                n2 = 7
            ElseIf b2 = "♥8" Or b2 = "♦8" Or b2 = "♧8" Or b2 = "♤8" Then
                n2 = 8
            ElseIf b2 = "♥9" Or b2 = "♦9" Or b2 = "♧9" Or b2 = "♤9" Then
                n2 = 9
            ElseIf b2 = "♥10" Or b2 = "♦10" Or b2 = "♧10" Or b2 = "♤10" Then
                n2 = 10
            ElseIf b2 = "♥11" Or b2 = "♦11" Or b2 = "♧11" Or b2 = "♤11" Then
                n2 = 11
            ElseIf b2 = "♥12" Or b2 = "♦12" Or b2 = "♧12" Or b2 = "♤12" Then
                n2 = 12
            ElseIf b2 = "♥13" Or b2 = "♦13" Or b2 = "♧13" Or b2 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        If sn = 1 Then
            A3.Enabled = False
            A3.Text = b3
            s1 = b3
            If b3 = "♥1" Or b3 = "♦1" Or b3 = "♧1" Or b3 = "♤1" Then
                n1 = 1
            ElseIf b3 = "♥2" Or b3 = "♦2" Or b3 = "♧2" Or b3 = "♤2" Then
                n1 = 2
            ElseIf b3 = "♥3" Or b3 = "♦3" Or b3 = "♧3" Or b3 = "♤3" Then
                n1 = 3
            ElseIf b3 = "♥4" Or b3 = "♦4" Or b3 = "♧4" Or b3 = "♤4" Then
                n1 = 4
            ElseIf b3 = "♥5" Or b3 = "♦5" Or b3 = "♧5" Or b3 = "♤5" Then
                n1 = 5
            ElseIf b3 = "♥6" Or b3 = "♦6" Or b3 = "♧6" Or b3 = "♤6" Then
                n1 = 6
            ElseIf b3 = "♥7" Or b3 = "♦7" Or b3 = "♧7" Or b3 = "♤7" Then
                n1 = 7
            ElseIf b3 = "♥8" Or b3 = "♦8" Or b3 = "♧8" Or b3 = "♤8" Then
                n1 = 8
            ElseIf b3 = "♥9" Or b3 = "♦9" Or b3 = "♧9" Or b3 = "♤9" Then
                n1 = 9
            ElseIf b3 = "♥10" Or b3 = "♦10" Or b3 = "♧10" Or b3 = "♤10" Then
                n1 = 10
            ElseIf b3 = "♥11" Or b3 = "♦11" Or b3 = "♧11" Or b3 = "♤11" Then
                n1 = 11
            ElseIf b3 = "♥12" Or b3 = "♦12" Or b3 = "♧12" Or b3 = "♤12" Then
                n1 = 12
            ElseIf b3 = "♥13" Or b3 = "♦13" Or b3 = "♧13" Or b3 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A3.Text = b3
            s2 = b3
            If b3 = "♥1" Or b3 = "♦1" Or b3 = "♧1" Or b3 = "♤1" Then
                n2 = 1
            ElseIf b3 = "♥2" Or b3 = "♦2" Or b3 = "♧2" Or b3 = "♤2" Then
                n2 = 2
            ElseIf b3 = "♥3" Or b3 = "♦3" Or b3 = "♧3" Or b3 = "♤3" Then
                n2 = 3
            ElseIf b3 = "♥4" Or b3 = "♦4" Or b3 = "♧4" Or b3 = "♤4" Then
                n2 = 4
            ElseIf b3 = "♥5" Or b3 = "♦5" Or b3 = "♧5" Or b3 = "♤5" Then
                n2 = 5
            ElseIf b3 = "♥6" Or b3 = "♦6" Or b3 = "♧6" Or b3 = "♤6" Then
                n2 = 6
            ElseIf b3 = "♥7" Or b3 = "♦7" Or b3 = "♧7" Or b3 = "♤7" Then
                n2 = 7
            ElseIf b3 = "♥8" Or b3 = "♦8" Or b3 = "♧8" Or b3 = "♤8" Then
                n2 = 8
            ElseIf b3 = "♥9" Or b3 = "♦9" Or b3 = "♧9" Or b3 = "♤9" Then
                n2 = 9
            ElseIf b3 = "♥10" Or b3 = "♦10" Or b3 = "♧10" Or b3 = "♤10" Then
                n2 = 10
            ElseIf b3 = "♥11" Or b3 = "♦11" Or b3 = "♧11" Or b3 = "♤11" Then
                n2 = 11
            ElseIf b3 = "♥12" Or b3 = "♦12" Or b3 = "♧12" Or b3 = "♤12" Then
                n2 = 12
            ElseIf b3 = "♥13" Or b3 = "♦13" Or b3 = "♧13" Or b3 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
        If sn = 1 Then
            A4.Enabled = False
            A4.Text = b4
            s1 = b4
            If b4 = "♥1" Or b4 = "♦1" Or b4 = "♧1" Or b4 = "♤1" Then
                n1 = 1
            ElseIf b4 = "♥2" Or b4 = "♦2" Or b4 = "♧2" Or b4 = "♤2" Then
                n1 = 2
            ElseIf b4 = "♥3" Or b4 = "♦3" Or b4 = "♧3" Or b4 = "♤3" Then
                n1 = 3
            ElseIf b4 = "♥4" Or b4 = "♦4" Or b4 = "♧4" Or b4 = "♤4" Then
                n1 = 4
            ElseIf b4 = "♥5" Or b4 = "♦5" Or b4 = "♧5" Or b4 = "♤5" Then
                n1 = 5
            ElseIf b4 = "♥6" Or b4 = "♦6" Or b4 = "♧6" Or b4 = "♤6" Then
                n1 = 6
            ElseIf b4 = "♥7" Or b4 = "♦7" Or b4 = "♧7" Or b4 = "♤7" Then
                n1 = 7
            ElseIf b4 = "♥8" Or b4 = "♦8" Or b4 = "♧8" Or b4 = "♤8" Then
                n1 = 8
            ElseIf b4 = "♥9" Or b4 = "♦9" Or b4 = "♧9" Or b4 = "♤9" Then
                n1 = 9
            ElseIf b4 = "♥10" Or b4 = "♦10" Or b4 = "♧10" Or b4 = "♤10" Then
                n1 = 10
            ElseIf b4 = "♥11" Or b4 = "♦11" Or b4 = "♧11" Or b4 = "♤11" Then
                n1 = 11
            ElseIf b4 = "♥12" Or b4 = "♦12" Or b4 = "♧12" Or b4 = "♤12" Then
                n1 = 12
            ElseIf b4 = "♥13" Or b4 = "♦13" Or b4 = "♧13" Or b4 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A4.Text = b4
            s2 = b4
            If b4 = "♥1" Or b4 = "♦1" Or b4 = "♧1" Or b4 = "♤1" Then
                n2 = 1
            ElseIf b4 = "♥2" Or b4 = "♦2" Or b4 = "♧2" Or b4 = "♤2" Then
                n2 = 2
            ElseIf b4 = "♥3" Or b4 = "♦3" Or b4 = "♧3" Or b4 = "♤3" Then
                n2 = 3
            ElseIf b4 = "♥4" Or b4 = "♦4" Or b4 = "♧4" Or b4 = "♤4" Then
                n2 = 4
            ElseIf b4 = "♥5" Or b4 = "♦5" Or b4 = "♧5" Or b4 = "♤5" Then
                n2 = 5
            ElseIf b4 = "♥6" Or b4 = "♦6" Or b4 = "♧6" Or b4 = "♤6" Then
                n2 = 6
            ElseIf b4 = "♥7" Or b4 = "♦7" Or b4 = "♧7" Or b4 = "♤7" Then
                n2 = 7
            ElseIf b4 = "♥8" Or b4 = "♦8" Or b4 = "♧8" Or b4 = "♤8" Then
                n2 = 8
            ElseIf b4 = "♥9" Or b4 = "♦9" Or b4 = "♧9" Or b4 = "♤9" Then
                n2 = 9
            ElseIf b4 = "♥10" Or b4 = "♦10" Or b4 = "♧10" Or b4 = "♤10" Then
                n2 = 10
            ElseIf b4 = "♥11" Or b4 = "♦11" Or b4 = "♧11" Or b4 = "♤11" Then
                n2 = 11
            ElseIf b4 = "♥12" Or b4 = "♦12" Or b4 = "♧12" Or b4 = "♤12" Then
                n2 = 12
            ElseIf b4 = "♥13" Or b4 = "♦13" Or b4 = "♧13" Or b4 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
        If sn = 1 Then
            A5.Enabled = False
            A5.Text = b5
            s1 = b5
            If b5 = "♥1" Or b5 = "♦1" Or b5 = "♧1" Or b5 = "♤1" Then
                n1 = 1
            ElseIf b5 = "♥2" Or b5 = "♦2" Or b5 = "♧2" Or b5 = "♤2" Then
                n1 = 2
            ElseIf b5 = "♥3" Or b5 = "♦3" Or b5 = "♧3" Or b5 = "♤3" Then
                n1 = 3
            ElseIf b5 = "♥4" Or b5 = "♦4" Or b5 = "♧4" Or b5 = "♤4" Then
                n1 = 4
            ElseIf b5 = "♥5" Or b5 = "♦5" Or b5 = "♧5" Or b5 = "♤5" Then
                n1 = 5
            ElseIf b5 = "♥6" Or b5 = "♦6" Or b5 = "♧6" Or b5 = "♤6" Then
                n1 = 6
            ElseIf b5 = "♥7" Or b5 = "♦7" Or b5 = "♧7" Or b5 = "♤7" Then
                n1 = 7
            ElseIf b5 = "♥8" Or b5 = "♦8" Or b5 = "♧8" Or b5 = "♤8" Then
                n1 = 8
            ElseIf b5 = "♥9" Or b5 = "♦9" Or b5 = "♧9" Or b5 = "♤9" Then
                n1 = 9
            ElseIf b5 = "♥10" Or b5 = "♦10" Or b5 = "♧10" Or b5 = "♤10" Then
                n1 = 10
            ElseIf b5 = "♥11" Or b5 = "♦11" Or b5 = "♧11" Or b5 = "♤11" Then
                n1 = 11
            ElseIf b5 = "♥12" Or b5 = "♦12" Or b5 = "♧12" Or b5 = "♤12" Then
                n1 = 12
            ElseIf b5 = "♥13" Or b5 = "♦13" Or b5 = "♧13" Or b5 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A5.Text = b5
            s2 = b5
            If b5 = "♥1" Or b5 = "♦1" Or b5 = "♧1" Or b5 = "♤1" Then
                n2 = 1
            ElseIf b5 = "♥2" Or b5 = "♦2" Or b5 = "♧2" Or b5 = "♤2" Then
                n2 = 2
            ElseIf b5 = "♥3" Or b5 = "♦3" Or b5 = "♧3" Or b5 = "♤3" Then
                n2 = 3
            ElseIf b5 = "♥4" Or b5 = "♦4" Or b5 = "♧4" Or b5 = "♤4" Then
                n2 = 4
            ElseIf b5 = "♥5" Or b5 = "♦5" Or b5 = "♧5" Or b5 = "♤5" Then
                n2 = 5
            ElseIf b5 = "♥6" Or b5 = "♦6" Or b5 = "♧6" Or b5 = "♤6" Then
                n2 = 6
            ElseIf b5 = "♥7" Or b5 = "♦7" Or b5 = "♧7" Or b5 = "♤7" Then
                n2 = 7
            ElseIf b5 = "♥8" Or b5 = "♦8" Or b5 = "♧8" Or b5 = "♤8" Then
                n2 = 8
            ElseIf b5 = "♥9" Or b5 = "♦9" Or b5 = "♧9" Or b5 = "♤9" Then
                n2 = 9
            ElseIf b5 = "♥10" Or b5 = "♦10" Or b5 = "♧10" Or b5 = "♤10" Then
                n2 = 10
            ElseIf b5 = "♥11" Or b5 = "♦11" Or b5 = "♧11" Or b5 = "♤11" Then
                n2 = 11
            ElseIf b5 = "♥12" Or b5 = "♦12" Or b5 = "♧12" Or b5 = "♤12" Then
                n2 = 12
            ElseIf b5 = "♥13" Or b5 = "♦13" Or b5 = "♧13" Or b5 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click
        If sn = 1 Then
            A6.Enabled = False
            A6.Text = b6
            s1 = b6
            If b6 = "♥1" Or b6 = "♦1" Or b6 = "♧1" Or b6 = "♤1" Then
                n1 = 1
            ElseIf b6 = "♥2" Or b6 = "♦2" Or b6 = "♧2" Or b6 = "♤2" Then
                n1 = 2
            ElseIf b6 = "♥3" Or b6 = "♦3" Or b6 = "♧3" Or b6 = "♤3" Then
                n1 = 3
            ElseIf b6 = "♥4" Or b6 = "♦4" Or b6 = "♧4" Or b6 = "♤4" Then
                n1 = 4
            ElseIf b6 = "♥5" Or b6 = "♦5" Or b6 = "♧5" Or b6 = "♤5" Then
                n1 = 5
            ElseIf b6 = "♥6" Or b6 = "♦6" Or b6 = "♧6" Or b6 = "♤6" Then
                n1 = 6
            ElseIf b6 = "♥7" Or b6 = "♦7" Or b6 = "♧7" Or b6 = "♤7" Then
                n1 = 7
            ElseIf b6 = "♥8" Or b6 = "♦8" Or b6 = "♧8" Or b6 = "♤8" Then
                n1 = 8
            ElseIf b6 = "♥9" Or b6 = "♦9" Or b6 = "♧9" Or b6 = "♤9" Then
                n1 = 9
            ElseIf b6 = "♥10" Or b6 = "♦10" Or b6 = "♧10" Or b6 = "♤10" Then
                n1 = 10
            ElseIf b6 = "♥11" Or b6 = "♦11" Or b6 = "♧11" Or b6 = "♤11" Then
                n1 = 11
            ElseIf b6 = "♥12" Or b6 = "♦12" Or b6 = "♧12" Or b6 = "♤12" Then
                n1 = 12
            ElseIf b6 = "♥13" Or b6 = "♦13" Or b6 = "♧13" Or b6 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A6.Text = b6
            s2 = b6
            If b6 = "♥1" Or b6 = "♦1" Or b6 = "♧1" Or b6 = "♤1" Then
                n2 = 1
            ElseIf b6 = "♥2" Or b6 = "♦2" Or b6 = "♧2" Or b6 = "♤2" Then
                n2 = 2
            ElseIf b6 = "♥3" Or b6 = "♦3" Or b6 = "♧3" Or b6 = "♤3" Then
                n2 = 3
            ElseIf b6 = "♥4" Or b6 = "♦4" Or b6 = "♧4" Or b6 = "♤4" Then
                n2 = 4
            ElseIf b6 = "♥5" Or b6 = "♦5" Or b6 = "♧5" Or b6 = "♤5" Then
                n2 = 5
            ElseIf b6 = "♥6" Or b6 = "♦6" Or b6 = "♧6" Or b6 = "♤6" Then
                n2 = 6
            ElseIf b6 = "♥7" Or b6 = "♦7" Or b6 = "♧7" Or b6 = "♤7" Then
                n2 = 7
            ElseIf b6 = "♥8" Or b6 = "♦8" Or b6 = "♧8" Or b6 = "♤8" Then
                n2 = 8
            ElseIf b6 = "♥9" Or b6 = "♦9" Or b6 = "♧9" Or b6 = "♤9" Then
                n2 = 9
            ElseIf b6 = "♥10" Or b6 = "♦10" Or b6 = "♧10" Or b6 = "♤10" Then
                n2 = 10
            ElseIf b6 = "♥11" Or b6 = "♦11" Or b6 = "♧11" Or b6 = "♤11" Then
                n2 = 11
            ElseIf b6 = "♥12" Or b6 = "♦12" Or b6 = "♧12" Or b6 = "♤12" Then
                n2 = 12
            ElseIf b6 = "♥13" Or b6 = "♦13" Or b6 = "♧13" Or b6 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.Click
        If sn = 1 Then
            A7.Enabled = False
            A7.Text = b7
            s1 = b7
            If b7 = "♥1" Or b7 = "♦1" Or b7 = "♧1" Or b7 = "♤1" Then
                n1 = 1
            ElseIf b7 = "♥2" Or b7 = "♦2" Or b7 = "♧2" Or b7 = "♤2" Then
                n1 = 2
            ElseIf b7 = "♥3" Or b7 = "♦3" Or b7 = "♧3" Or b7 = "♤3" Then
                n1 = 3
            ElseIf b7 = "♥4" Or b7 = "♦4" Or b7 = "♧4" Or b7 = "♤4" Then
                n1 = 4
            ElseIf b7 = "♥5" Or b7 = "♦5" Or b7 = "♧5" Or b7 = "♤5" Then
                n1 = 5
            ElseIf b7 = "♥6" Or b7 = "♦6" Or b7 = "♧6" Or b7 = "♤6" Then
                n1 = 6
            ElseIf b7 = "♥7" Or b7 = "♦7" Or b7 = "♧7" Or b7 = "♤7" Then
                n1 = 7
            ElseIf b7 = "♥8" Or b7 = "♦8" Or b7 = "♧8" Or b7 = "♤8" Then
                n1 = 8
            ElseIf b7 = "♥9" Or b7 = "♦9" Or b7 = "♧9" Or b7 = "♤9" Then
                n1 = 9
            ElseIf b7 = "♥10" Or b7 = "♦10" Or b7 = "♧10" Or b7 = "♤10" Then
                n1 = 10
            ElseIf b7 = "♥11" Or b7 = "♦11" Or b7 = "♧11" Or b7 = "♤11" Then
                n1 = 11
            ElseIf b7 = "♥12" Or b7 = "♦12" Or b7 = "♧12" Or b7 = "♤12" Then
                n1 = 12
            ElseIf b7 = "♥13" Or b7 = "♦13" Or b7 = "♧13" Or b7 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A7.Text = b7
            s2 = b7
            If b7 = "♥1" Or b7 = "♦1" Or b7 = "♧1" Or b7 = "♤1" Then
                n2 = 1
            ElseIf b7 = "♥2" Or b7 = "♦2" Or b7 = "♧2" Or b7 = "♤2" Then
                n2 = 2
            ElseIf b7 = "♥3" Or b7 = "♦3" Or b7 = "♧3" Or b7 = "♤3" Then
                n2 = 3
            ElseIf b7 = "♥4" Or b7 = "♦4" Or b7 = "♧4" Or b7 = "♤4" Then
                n2 = 4
            ElseIf b7 = "♥5" Or b7 = "♦5" Or b7 = "♧5" Or b7 = "♤5" Then
                n2 = 5
            ElseIf b7 = "♥6" Or b7 = "♦6" Or b7 = "♧6" Or b7 = "♤6" Then
                n2 = 6
            ElseIf b7 = "♥7" Or b7 = "♦7" Or b7 = "♧7" Or b7 = "♤7" Then
                n2 = 7
            ElseIf b7 = "♥8" Or b7 = "♦8" Or b7 = "♧8" Or b7 = "♤8" Then
                n2 = 8
            ElseIf b7 = "♥9" Or b7 = "♦9" Or b7 = "♧9" Or b7 = "♤9" Then
                n2 = 9
            ElseIf b7 = "♥10" Or b7 = "♦10" Or b7 = "♧10" Or b7 = "♤10" Then
                n2 = 10
            ElseIf b7 = "♥11" Or b7 = "♦11" Or b7 = "♧11" Or b7 = "♤11" Then
                n2 = 11
            ElseIf b7 = "♥12" Or b7 = "♦12" Or b7 = "♧12" Or b7 = "♤12" Then
                n2 = 12
            ElseIf b7 = "♥13" Or b7 = "♦13" Or b7 = "♧13" Or b7 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.Click
        If sn = 1 Then
            A8.Enabled = False
            A8.Text = b8
            s1 = b8
            If b8 = "♥1" Or b8 = "♦1" Or b8 = "♧1" Or b8 = "♤1" Then
                n1 = 1
            ElseIf b8 = "♥2" Or b8 = "♦2" Or b8 = "♧2" Or b8 = "♤2" Then
                n1 = 2
            ElseIf b8 = "♥3" Or b8 = "♦3" Or b8 = "♧3" Or b8 = "♤3" Then
                n1 = 3
            ElseIf b8 = "♥4" Or b8 = "♦4" Or b8 = "♧4" Or b8 = "♤4" Then
                n1 = 4
            ElseIf b8 = "♥5" Or b8 = "♦5" Or b8 = "♧5" Or b8 = "♤5" Then
                n1 = 5
            ElseIf b8 = "♥6" Or b8 = "♦6" Or b8 = "♧6" Or b8 = "♤6" Then
                n1 = 6
            ElseIf b8 = "♥7" Or b8 = "♦7" Or b8 = "♧7" Or b8 = "♤7" Then
                n1 = 7
            ElseIf b8 = "♥8" Or b8 = "♦8" Or b8 = "♧8" Or b8 = "♤8" Then
                n1 = 8
            ElseIf b8 = "♥9" Or b8 = "♦9" Or b8 = "♧9" Or b8 = "♤9" Then
                n1 = 9
            ElseIf b8 = "♥10" Or b8 = "♦10" Or b8 = "♧10" Or b8 = "♤10" Then
                n1 = 10
            ElseIf b8 = "♥11" Or b8 = "♦11" Or b8 = "♧11" Or b8 = "♤11" Then
                n1 = 11
            ElseIf b8 = "♥12" Or b8 = "♦12" Or b8 = "♧12" Or b8 = "♤12" Then
                n1 = 12
            ElseIf b8 = "♥13" Or b8 = "♦13" Or b8 = "♧13" Or b8 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A8.Text = b8
            s2 = b8
            If b8 = "♥1" Or b8 = "♦1" Or b8 = "♧1" Or b8 = "♤1" Then
                n2 = 1
            ElseIf b8 = "♥2" Or b8 = "♦2" Or b8 = "♧2" Or b8 = "♤2" Then
                n2 = 2
            ElseIf b8 = "♥3" Or b8 = "♦3" Or b8 = "♧3" Or b8 = "♤3" Then
                n2 = 3
            ElseIf b8 = "♥4" Or b8 = "♦4" Or b8 = "♧4" Or b8 = "♤4" Then
                n2 = 4
            ElseIf b8 = "♥5" Or b8 = "♦5" Or b8 = "♧5" Or b8 = "♤5" Then
                n2 = 5
            ElseIf b8 = "♥6" Or b8 = "♦6" Or b8 = "♧6" Or b8 = "♤6" Then
                n2 = 6
            ElseIf b8 = "♥7" Or b8 = "♦7" Or b8 = "♧7" Or b8 = "♤7" Then
                n2 = 7
            ElseIf b8 = "♥8" Or b8 = "♦8" Or b8 = "♧8" Or b8 = "♤8" Then
                n2 = 8
            ElseIf b8 = "♥9" Or b8 = "♦9" Or b8 = "♧9" Or b8 = "♤9" Then
                n2 = 9
            ElseIf b8 = "♥10" Or b8 = "♦10" Or b8 = "♧10" Or b8 = "♤10" Then
                n2 = 10
            ElseIf b8 = "♥11" Or b8 = "♦11" Or b8 = "♧11" Or b8 = "♤11" Then
                n2 = 11
            ElseIf b8 = "♥12" Or b8 = "♦12" Or b8 = "♧12" Or b8 = "♤12" Then
                n2 = 12
            ElseIf b8 = "♥13" Or b8 = "♦13" Or b8 = "♧13" Or b8 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A9_Click(sender As Object, e As EventArgs) Handles A9.Click
        If sn = 1 Then
            A9.Enabled = False
            A9.Text = b9
            s1 = b9
            If b9 = "♥1" Or b9 = "♦1" Or b9 = "♧1" Or b9 = "♤1" Then
                n1 = 1
            ElseIf b9 = "♥2" Or b9 = "♦2" Or b9 = "♧2" Or b9 = "♤2" Then
                n1 = 2
            ElseIf b9 = "♥3" Or b9 = "♦3" Or b9 = "♧3" Or b9 = "♤3" Then
                n1 = 3
            ElseIf b9 = "♥4" Or b9 = "♦4" Or b9 = "♧4" Or b9 = "♤4" Then
                n1 = 4
            ElseIf b9 = "♥5" Or b9 = "♦5" Or b9 = "♧5" Or b9 = "♤5" Then
                n1 = 5
            ElseIf b9 = "♥6" Or b9 = "♦6" Or b9 = "♧6" Or b9 = "♤6" Then
                n1 = 6
            ElseIf b9 = "♥7" Or b9 = "♦7" Or b9 = "♧7" Or b9 = "♤7" Then
                n1 = 7
            ElseIf b9 = "♥8" Or b9 = "♦8" Or b9 = "♧8" Or b9 = "♤8" Then
                n1 = 8
            ElseIf b9 = "♥9" Or b9 = "♦9" Or b9 = "♧9" Or b9 = "♤9" Then
                n1 = 9
            ElseIf b9 = "♥10" Or b9 = "♦10" Or b9 = "♧10" Or b9 = "♤10" Then
                n1 = 10
            ElseIf b9 = "♥11" Or b9 = "♦11" Or b9 = "♧11" Or b9 = "♤11" Then
                n1 = 11
            ElseIf b9 = "♥12" Or b9 = "♦12" Or b9 = "♧12" Or b9 = "♤12" Then
                n1 = 12
            ElseIf b9 = "♥13" Or b9 = "♦13" Or b9 = "♧13" Or b9 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A9.Text = b9
            s2 = b9
            If b9 = "♥1" Or b9 = "♦1" Or b9 = "♧1" Or b9 = "♤1" Then
                n2 = 1
            ElseIf b9 = "♥2" Or b9 = "♦2" Or b9 = "♧2" Or b9 = "♤2" Then
                n2 = 2
            ElseIf b9 = "♥3" Or b9 = "♦3" Or b9 = "♧3" Or b9 = "♤3" Then
                n2 = 3
            ElseIf b9 = "♥4" Or b9 = "♦4" Or b9 = "♧4" Or b9 = "♤4" Then
                n2 = 4
            ElseIf b9 = "♥5" Or b9 = "♦5" Or b9 = "♧5" Or b9 = "♤5" Then
                n2 = 5
            ElseIf b9 = "♥6" Or b9 = "♦6" Or b9 = "♧6" Or b9 = "♤6" Then
                n2 = 6
            ElseIf b9 = "♥7" Or b9 = "♦7" Or b9 = "♧7" Or b9 = "♤7" Then
                n2 = 7
            ElseIf b9 = "♥8" Or b9 = "♦8" Or b9 = "♧8" Or b9 = "♤8" Then
                n2 = 8
            ElseIf b9 = "♥9" Or b9 = "♦9" Or b9 = "♧9" Or b9 = "♤9" Then
                n2 = 9
            ElseIf b9 = "♥10" Or b9 = "♦10" Or b9 = "♧10" Or b9 = "♤10" Then
                n2 = 10
            ElseIf b9 = "♥11" Or b9 = "♦11" Or b9 = "♧11" Or b9 = "♤11" Then
                n2 = 11
            ElseIf b9 = "♥12" Or b9 = "♦12" Or b9 = "♧12" Or b9 = "♤12" Then
                n2 = 12
            ElseIf b9 = "♥13" Or b9 = "♦13" Or b9 = "♧13" Or b9 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A10_Click(sender As Object, e As EventArgs) Handles A10.Click
        If sn = 1 Then
            A10.Enabled = False
            A10.Text = b10
            s1 = b10
            If b10 = "♥1" Or b10 = "♦1" Or b10 = "♧1" Or b10 = "♤1" Then
                n1 = 1
            ElseIf b10 = "♥2" Or b10 = "♦2" Or b10 = "♧2" Or b10 = "♤2" Then
                n1 = 2
            ElseIf b10 = "♥3" Or b10 = "♦3" Or b10 = "♧3" Or b10 = "♤3" Then
                n1 = 3
            ElseIf b10 = "♥4" Or b10 = "♦4" Or b10 = "♧4" Or b10 = "♤4" Then
                n1 = 4
            ElseIf b10 = "♥5" Or b10 = "♦5" Or b10 = "♧5" Or b10 = "♤5" Then
                n1 = 5
            ElseIf b10 = "♥6" Or b10 = "♦6" Or b10 = "♧6" Or b10 = "♤6" Then
                n1 = 6
            ElseIf b10 = "♥7" Or b10 = "♦7" Or b10 = "♧7" Or b10 = "♤7" Then
                n1 = 7
            ElseIf b10 = "♥8" Or b10 = "♦8" Or b10 = "♧8" Or b10 = "♤8" Then
                n1 = 8
            ElseIf b10 = "♥9" Or b10 = "♦9" Or b10 = "♧9" Or b10 = "♤9" Then
                n1 = 9
            ElseIf b10 = "♥10" Or b10 = "♦10" Or b10 = "♧10" Or b10 = "♤10" Then
                n1 = 10
            ElseIf b10 = "♥11" Or b10 = "♦11" Or b10 = "♧11" Or b10 = "♤11" Then
                n1 = 11
            ElseIf b10 = "♥12" Or b10 = "♦12" Or b10 = "♧12" Or b10 = "♤12" Then
                n1 = 12
            ElseIf b10 = "♥13" Or b10 = "♦13" Or b10 = "♧13" Or b10 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A10.Text = b10
            s2 = b10
            If b10 = "♥1" Or b10 = "♦1" Or b10 = "♧1" Or b10 = "♤1" Then
                n2 = 1
            ElseIf b10 = "♥2" Or b10 = "♦2" Or b10 = "♧2" Or b10 = "♤2" Then
                n2 = 2
            ElseIf b10 = "♥3" Or b10 = "♦3" Or b10 = "♧3" Or b10 = "♤3" Then
                n2 = 3
            ElseIf b10 = "♥4" Or b10 = "♦4" Or b10 = "♧4" Or b10 = "♤4" Then
                n2 = 4
            ElseIf b10 = "♥5" Or b10 = "♦5" Or b10 = "♧5" Or b10 = "♤5" Then
                n2 = 5
            ElseIf b10 = "♥6" Or b10 = "♦6" Or b10 = "♧6" Or b10 = "♤6" Then
                n2 = 6
            ElseIf b10 = "♥7" Or b10 = "♦7" Or b10 = "♧7" Or b10 = "♤7" Then
                n2 = 7
            ElseIf b10 = "♥8" Or b10 = "♦8" Or b10 = "♧8" Or b10 = "♤8" Then
                n2 = 8
            ElseIf b10 = "♥9" Or b10 = "♦9" Or b10 = "♧9" Or b10 = "♤9" Then
                n2 = 9
            ElseIf b10 = "♥10" Or b10 = "♦10" Or b10 = "♧10" Or b10 = "♤10" Then
                n2 = 10
            ElseIf b10 = "♥11" Or b10 = "♦11" Or b10 = "♧11" Or b10 = "♤11" Then
                n2 = 11
            ElseIf b10 = "♥12" Or b10 = "♦12" Or b10 = "♧12" Or b10 = "♤12" Then
                n2 = 12
            ElseIf b10 = "♥13" Or b10 = "♦13" Or b10 = "♧13" Or b10 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A11_Click(sender As Object, e As EventArgs) Handles A11.Click
        If sn = 1 Then
            A11.Enabled = False
            A11.Text = b11
            s1 = b11
            If b11 = "♥1" Or b11 = "♦1" Or b11 = "♧1" Or b11 = "♤1" Then
                n1 = 1
            ElseIf b11 = "♥2" Or b11 = "♦2" Or b11 = "♧2" Or b11 = "♤2" Then
                n1 = 2
            ElseIf b11 = "♥3" Or b11 = "♦3" Or b11 = "♧3" Or b11 = "♤3" Then
                n1 = 3
            ElseIf b11 = "♥4" Or b11 = "♦4" Or b11 = "♧4" Or b11 = "♤4" Then
                n1 = 4
            ElseIf b11 = "♥5" Or b11 = "♦5" Or b11 = "♧5" Or b11 = "♤5" Then
                n1 = 5
            ElseIf b11 = "♥6" Or b11 = "♦6" Or b11 = "♧6" Or b11 = "♤6" Then
                n1 = 6
            ElseIf b11 = "♥7" Or b11 = "♦7" Or b11 = "♧7" Or b11 = "♤7" Then
                n1 = 7
            ElseIf b11 = "♥8" Or b11 = "♦8" Or b11 = "♧8" Or b11 = "♤8" Then
                n1 = 8
            ElseIf b11 = "♥9" Or b11 = "♦9" Or b11 = "♧9" Or b11 = "♤9" Then
                n1 = 9
            ElseIf b11 = "♥10" Or b11 = "♦10" Or b11 = "♧10" Or b11 = "♤10" Then
                n1 = 10
            ElseIf b11 = "♥11" Or b11 = "♦11" Or b11 = "♧11" Or b11 = "♤11" Then
                n1 = 11
            ElseIf b11 = "♥12" Or b11 = "♦12" Or b11 = "♧12" Or b11 = "♤12" Then
                n1 = 12
            ElseIf b11 = "♥13" Or b11 = "♦13" Or b11 = "♧13" Or b11 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A11.Text = b11
            s2 = b11
            If b11 = "♥1" Or b11 = "♦1" Or b11 = "♧1" Or b11 = "♤1" Then
                n2 = 1
            ElseIf b11 = "♥2" Or b11 = "♦2" Or b11 = "♧2" Or b11 = "♤2" Then
                n2 = 2
            ElseIf b11 = "♥3" Or b11 = "♦3" Or b11 = "♧3" Or b11 = "♤3" Then
                n2 = 3
            ElseIf b11 = "♥4" Or b11 = "♦4" Or b11 = "♧4" Or b11 = "♤4" Then
                n2 = 4
            ElseIf b11 = "♥5" Or b11 = "♦5" Or b11 = "♧5" Or b11 = "♤5" Then
                n2 = 5
            ElseIf b11 = "♥6" Or b11 = "♦6" Or b11 = "♧6" Or b11 = "♤6" Then
                n2 = 6
            ElseIf b11 = "♥7" Or b11 = "♦7" Or b11 = "♧7" Or b11 = "♤7" Then
                n2 = 7
            ElseIf b11 = "♥8" Or b11 = "♦8" Or b11 = "♧8" Or b11 = "♤8" Then
                n2 = 8
            ElseIf b11 = "♥9" Or b11 = "♦9" Or b11 = "♧9" Or b11 = "♤9" Then
                n2 = 9
            ElseIf b11 = "♥10" Or b11 = "♦10" Or b11 = "♧10" Or b11 = "♤10" Then
                n2 = 10
            ElseIf b11 = "♥11" Or b11 = "♦11" Or b11 = "♧11" Or b11 = "♤11" Then
                n2 = 11
            ElseIf b11 = "♥12" Or b11 = "♦12" Or b11 = "♧12" Or b11 = "♤12" Then
                n2 = 12
            ElseIf b11 = "♥13" Or b11 = "♦13" Or b11 = "♧13" Or b11 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A12_Click(sender As Object, e As EventArgs) Handles A12.Click
        If sn = 1 Then
            A12.Enabled = False
            A12.Text = b12
            s1 = b12
            If b12 = "♥1" Or b12 = "♦1" Or b12 = "♧1" Or b12 = "♤1" Then
                n1 = 1
            ElseIf b12 = "♥2" Or b12 = "♦2" Or b12 = "♧2" Or b12 = "♤2" Then
                n1 = 2
            ElseIf b12 = "♥3" Or b12 = "♦3" Or b12 = "♧3" Or b12 = "♤3" Then
                n1 = 3
            ElseIf b12 = "♥4" Or b12 = "♦4" Or b12 = "♧4" Or b12 = "♤4" Then
                n1 = 4
            ElseIf b12 = "♥5" Or b12 = "♦5" Or b12 = "♧5" Or b12 = "♤5" Then
                n1 = 5
            ElseIf b12 = "♥6" Or b12 = "♦6" Or b12 = "♧6" Or b12 = "♤6" Then
                n1 = 6
            ElseIf b12 = "♥7" Or b12 = "♦7" Or b12 = "♧7" Or b12 = "♤7" Then
                n1 = 7
            ElseIf b12 = "♥8" Or b12 = "♦8" Or b12 = "♧8" Or b12 = "♤8" Then
                n1 = 8
            ElseIf b12 = "♥9" Or b12 = "♦9" Or b12 = "♧9" Or b12 = "♤9" Then
                n1 = 9
            ElseIf b12 = "♥10" Or b12 = "♦10" Or b12 = "♧10" Or b12 = "♤10" Then
                n1 = 10
            ElseIf b12 = "♥11" Or b12 = "♦11" Or b12 = "♧11" Or b12 = "♤11" Then
                n1 = 11
            ElseIf b12 = "♥12" Or b12 = "♦12" Or b12 = "♧12" Or b12 = "♤12" Then
                n1 = 12
            ElseIf b12 = "♥13" Or b12 = "♦13" Or b12 = "♧13" Or b12 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A12.Text = b12
            s2 = b12
            If b12 = "♥1" Or b12 = "♦1" Or b12 = "♧1" Or b12 = "♤1" Then
                n2 = 1
            ElseIf b12 = "♥2" Or b12 = "♦2" Or b12 = "♧2" Or b12 = "♤2" Then
                n2 = 2
            ElseIf b12 = "♥3" Or b12 = "♦3" Or b12 = "♧3" Or b12 = "♤3" Then
                n2 = 3
            ElseIf b12 = "♥4" Or b12 = "♦4" Or b12 = "♧4" Or b12 = "♤4" Then
                n2 = 4
            ElseIf b12 = "♥5" Or b12 = "♦5" Or b12 = "♧5" Or b12 = "♤5" Then
                n2 = 5
            ElseIf b12 = "♥6" Or b12 = "♦6" Or b12 = "♧6" Or b12 = "♤6" Then
                n2 = 6
            ElseIf b12 = "♥7" Or b12 = "♦7" Or b12 = "♧7" Or b12 = "♤7" Then
                n2 = 7
            ElseIf b12 = "♥8" Or b12 = "♦8" Or b12 = "♧8" Or b12 = "♤8" Then
                n2 = 8
            ElseIf b12 = "♥9" Or b12 = "♦9" Or b12 = "♧9" Or b12 = "♤9" Then
                n2 = 9
            ElseIf b12 = "♥10" Or b12 = "♦10" Or b12 = "♧10" Or b12 = "♤10" Then
                n2 = 10
            ElseIf b12 = "♥11" Or b12 = "♦11" Or b12 = "♧11" Or b12 = "♤11" Then
                n2 = 11
            ElseIf b12 = "♥12" Or b12 = "♦12" Or b12 = "♧12" Or b12 = "♤12" Then
                n2 = 12
            ElseIf b12 = "♥13" Or b12 = "♦13" Or b12 = "♧13" Or b12 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A13_Click(sender As Object, e As EventArgs) Handles A13.Click
        If sn = 1 Then
            A13.Enabled = False
            A13.Text = b13
            s1 = b13
            If b13 = "♥1" Or b13 = "♦1" Or b13 = "♧1" Or b13 = "♤1" Then
                n1 = 1
            ElseIf b13 = "♥2" Or b13 = "♦2" Or b13 = "♧2" Or b13 = "♤2" Then
                n1 = 2
            ElseIf b13 = "♥3" Or b13 = "♦3" Or b13 = "♧3" Or b13 = "♤3" Then
                n1 = 3
            ElseIf b13 = "♥4" Or b13 = "♦4" Or b13 = "♧4" Or b13 = "♤4" Then
                n1 = 4
            ElseIf b13 = "♥5" Or b13 = "♦5" Or b13 = "♧5" Or b13 = "♤5" Then
                n1 = 5
            ElseIf b13 = "♥6" Or b13 = "♦6" Or b13 = "♧6" Or b13 = "♤6" Then
                n1 = 6
            ElseIf b13 = "♥7" Or b13 = "♦7" Or b13 = "♧7" Or b13 = "♤7" Then
                n1 = 7
            ElseIf b13 = "♥8" Or b13 = "♦8" Or b13 = "♧8" Or b13 = "♤8" Then
                n1 = 8
            ElseIf b13 = "♥9" Or b13 = "♦9" Or b13 = "♧9" Or b13 = "♤9" Then
                n1 = 9
            ElseIf b13 = "♥10" Or b13 = "♦10" Or b13 = "♧10" Or b13 = "♤10" Then
                n1 = 10
            ElseIf b13 = "♥11" Or b13 = "♦11" Or b13 = "♧11" Or b13 = "♤11" Then
                n1 = 11
            ElseIf b13 = "♥12" Or b13 = "♦12" Or b13 = "♧12" Or b13 = "♤12" Then
                n1 = 12
            ElseIf b13 = "♥13" Or b13 = "♦13" Or b13 = "♧13" Or b13 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A13.Text = b13
            s2 = b13
            If b13 = "♥1" Or b13 = "♦1" Or b13 = "♧1" Or b13 = "♤1" Then
                n2 = 1
            ElseIf b13 = "♥2" Or b13 = "♦2" Or b13 = "♧2" Or b13 = "♤2" Then
                n2 = 2
            ElseIf b13 = "♥3" Or b13 = "♦3" Or b13 = "♧3" Or b13 = "♤3" Then
                n2 = 3
            ElseIf b13 = "♥4" Or b13 = "♦4" Or b13 = "♧4" Or b13 = "♤4" Then
                n2 = 4
            ElseIf b13 = "♥5" Or b13 = "♦5" Or b13 = "♧5" Or b13 = "♤5" Then
                n2 = 5
            ElseIf b13 = "♥6" Or b13 = "♦6" Or b13 = "♧6" Or b13 = "♤6" Then
                n2 = 6
            ElseIf b13 = "♥7" Or b13 = "♦7" Or b13 = "♧7" Or b13 = "♤7" Then
                n2 = 7
            ElseIf b13 = "♥8" Or b13 = "♦8" Or b13 = "♧8" Or b13 = "♤8" Then
                n2 = 8
            ElseIf b13 = "♥9" Or b13 = "♦9" Or b13 = "♧9" Or b13 = "♤9" Then
                n2 = 9
            ElseIf b13 = "♥10" Or b13 = "♦10" Or b13 = "♧10" Or b13 = "♤10" Then
                n2 = 10
            ElseIf b13 = "♥11" Or b13 = "♦11" Or b13 = "♧11" Or b13 = "♤11" Then
                n2 = 11
            ElseIf b13 = "♥12" Or b13 = "♦12" Or b13 = "♧12" Or b13 = "♤12" Then
                n2 = 12
            ElseIf b13 = "♥13" Or b13 = "♦13" Or b13 = "♧13" Or b13 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A14_Click(sender As Object, e As EventArgs) Handles A14.Click
        If sn = 1 Then
            A14.Enabled = False
            A14.Text = b14
            s1 = b14
            If b14 = "♥1" Or b14 = "♦1" Or b14 = "♧1" Or b14 = "♤1" Then
                n1 = 1
            ElseIf b14 = "♥2" Or b14 = "♦2" Or b14 = "♧2" Or b14 = "♤2" Then
                n1 = 2
            ElseIf b14 = "♥3" Or b14 = "♦3" Or b14 = "♧3" Or b14 = "♤3" Then
                n1 = 3
            ElseIf b14 = "♥4" Or b14 = "♦4" Or b14 = "♧4" Or b14 = "♤4" Then
                n1 = 4
            ElseIf b14 = "♥5" Or b14 = "♦5" Or b14 = "♧5" Or b14 = "♤5" Then
                n1 = 5
            ElseIf b14 = "♥6" Or b14 = "♦6" Or b14 = "♧6" Or b14 = "♤6" Then
                n1 = 6
            ElseIf b14 = "♥7" Or b14 = "♦7" Or b14 = "♧7" Or b14 = "♤7" Then
                n1 = 7
            ElseIf b14 = "♥8" Or b14 = "♦8" Or b14 = "♧8" Or b14 = "♤8" Then
                n1 = 8
            ElseIf b14 = "♥9" Or b14 = "♦9" Or b14 = "♧9" Or b14 = "♤9" Then
                n1 = 9
            ElseIf b14 = "♥10" Or b14 = "♦10" Or b14 = "♧10" Or b14 = "♤10" Then
                n1 = 10
            ElseIf b14 = "♥11" Or b14 = "♦11" Or b14 = "♧11" Or b14 = "♤11" Then
                n1 = 11
            ElseIf b14 = "♥12" Or b14 = "♦12" Or b14 = "♧12" Or b14 = "♤12" Then
                n1 = 12
            ElseIf b14 = "♥13" Or b14 = "♦13" Or b14 = "♧13" Or b14 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A14.Text = b14
            s2 = b14
            If b14 = "♥1" Or b14 = "♦1" Or b14 = "♧1" Or b14 = "♤1" Then
                n2 = 1
            ElseIf b14 = "♥2" Or b14 = "♦2" Or b14 = "♧2" Or b14 = "♤2" Then
                n2 = 2
            ElseIf b14 = "♥3" Or b14 = "♦3" Or b14 = "♧3" Or b14 = "♤3" Then
                n2 = 3
            ElseIf b14 = "♥4" Or b14 = "♦4" Or b14 = "♧4" Or b14 = "♤4" Then
                n2 = 4
            ElseIf b14 = "♥5" Or b14 = "♦5" Or b14 = "♧5" Or b14 = "♤5" Then
                n2 = 5
            ElseIf b14 = "♥6" Or b14 = "♦6" Or b14 = "♧6" Or b14 = "♤6" Then
                n2 = 6
            ElseIf b14 = "♥7" Or b14 = "♦7" Or b14 = "♧7" Or b14 = "♤7" Then
                n2 = 7
            ElseIf b14 = "♥8" Or b14 = "♦8" Or b14 = "♧8" Or b14 = "♤8" Then
                n2 = 8
            ElseIf b14 = "♥9" Or b14 = "♦9" Or b14 = "♧9" Or b14 = "♤9" Then
                n2 = 9
            ElseIf b14 = "♥10" Or b14 = "♦10" Or b14 = "♧10" Or b14 = "♤10" Then
                n2 = 10
            ElseIf b14 = "♥11" Or b14 = "♦11" Or b14 = "♧11" Or b14 = "♤11" Then
                n2 = 11
            ElseIf b14 = "♥12" Or b14 = "♦12" Or b14 = "♧12" Or b14 = "♤12" Then
                n2 = 12
            ElseIf b14 = "♥13" Or b14 = "♦13" Or b14 = "♧13" Or b14 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A15_Click(sender As Object, e As EventArgs) Handles A15.Click
        If sn = 1 Then
            A15.Enabled = False
            A15.Text = b15
            s1 = b15
            If b15 = "♥1" Or b15 = "♦1" Or b15 = "♧1" Or b15 = "♤1" Then
                n1 = 1
            ElseIf b15 = "♥2" Or b15 = "♦2" Or b15 = "♧2" Or b15 = "♤2" Then
                n1 = 2
            ElseIf b15 = "♥3" Or b15 = "♦3" Or b15 = "♧3" Or b15 = "♤3" Then
                n1 = 3
            ElseIf b15 = "♥4" Or b15 = "♦4" Or b15 = "♧4" Or b15 = "♤4" Then
                n1 = 4
            ElseIf b15 = "♥5" Or b15 = "♦5" Or b15 = "♧5" Or b15 = "♤5" Then
                n1 = 5
            ElseIf b15 = "♥6" Or b15 = "♦6" Or b15 = "♧6" Or b15 = "♤6" Then
                n1 = 6
            ElseIf b15 = "♥7" Or b15 = "♦7" Or b15 = "♧7" Or b15 = "♤7" Then
                n1 = 7
            ElseIf b15 = "♥8" Or b15 = "♦8" Or b15 = "♧8" Or b15 = "♤8" Then
                n1 = 8
            ElseIf b15 = "♥9" Or b15 = "♦9" Or b15 = "♧9" Or b15 = "♤9" Then
                n1 = 9
            ElseIf b15 = "♥10" Or b15 = "♦10" Or b15 = "♧10" Or b15 = "♤10" Then
                n1 = 10
            ElseIf b15 = "♥11" Or b15 = "♦11" Or b15 = "♧11" Or b15 = "♤11" Then
                n1 = 11
            ElseIf b15 = "♥12" Or b15 = "♦12" Or b15 = "♧12" Or b15 = "♤12" Then
                n1 = 12
            ElseIf b15 = "♥13" Or b15 = "♦13" Or b15 = "♧13" Or b15 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A15.Text = b15
            s2 = b15
            If b15 = "♥1" Or b15 = "♦1" Or b15 = "♧1" Or b15 = "♤1" Then
                n2 = 1
            ElseIf b15 = "♥2" Or b15 = "♦2" Or b15 = "♧2" Or b15 = "♤2" Then
                n2 = 2
            ElseIf b15 = "♥3" Or b15 = "♦3" Or b15 = "♧3" Or b15 = "♤3" Then
                n2 = 3
            ElseIf b15 = "♥4" Or b15 = "♦4" Or b15 = "♧4" Or b15 = "♤4" Then
                n2 = 4
            ElseIf b15 = "♥5" Or b15 = "♦5" Or b15 = "♧5" Or b15 = "♤5" Then
                n2 = 5
            ElseIf b15 = "♥6" Or b15 = "♦6" Or b15 = "♧6" Or b15 = "♤6" Then
                n2 = 6
            ElseIf b15 = "♥7" Or b15 = "♦7" Or b15 = "♧7" Or b15 = "♤7" Then
                n2 = 7
            ElseIf b15 = "♥8" Or b15 = "♦8" Or b15 = "♧8" Or b15 = "♤8" Then
                n2 = 8
            ElseIf b15 = "♥9" Or b15 = "♦9" Or b15 = "♧9" Or b15 = "♤9" Then
                n2 = 9
            ElseIf b15 = "♥10" Or b15 = "♦10" Or b15 = "♧10" Or b15 = "♤10" Then
                n2 = 10
            ElseIf b15 = "♥11" Or b15 = "♦11" Or b15 = "♧11" Or b15 = "♤11" Then
                n2 = 11
            ElseIf b15 = "♥12" Or b15 = "♦12" Or b15 = "♧12" Or b15 = "♤12" Then
                n2 = 12
            ElseIf b15 = "♥13" Or b15 = "♦13" Or b15 = "♧13" Or b15 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A16_Click(sender As Object, e As EventArgs) Handles A16.Click
        If sn = 1 Then
            A16.Enabled = False
            A16.Text = b16
            s1 = b16
            If b16 = "♥1" Or b16 = "♦1" Or b16 = "♧1" Or b16 = "♤1" Then
                n1 = 1
            ElseIf b16 = "♥2" Or b16 = "♦2" Or b16 = "♧2" Or b16 = "♤2" Then
                n1 = 2
            ElseIf b16 = "♥3" Or b16 = "♦3" Or b16 = "♧3" Or b16 = "♤3" Then
                n1 = 3
            ElseIf b16 = "♥4" Or b16 = "♦4" Or b16 = "♧4" Or b16 = "♤4" Then
                n1 = 4
            ElseIf b16 = "♥5" Or b16 = "♦5" Or b16 = "♧5" Or b16 = "♤5" Then
                n1 = 5
            ElseIf b16 = "♥6" Or b16 = "♦6" Or b16 = "♧6" Or b16 = "♤6" Then
                n1 = 6
            ElseIf b16 = "♥7" Or b16 = "♦7" Or b16 = "♧7" Or b16 = "♤7" Then
                n1 = 7
            ElseIf b16 = "♥8" Or b16 = "♦8" Or b16 = "♧8" Or b16 = "♤8" Then
                n1 = 8
            ElseIf b16 = "♥9" Or b16 = "♦9" Or b16 = "♧9" Or b16 = "♤9" Then
                n1 = 9
            ElseIf b16 = "♥10" Or b16 = "♦10" Or b16 = "♧10" Or b16 = "♤10" Then
                n1 = 10
            ElseIf b16 = "♥11" Or b16 = "♦11" Or b16 = "♧11" Or b16 = "♤11" Then
                n1 = 11
            ElseIf b16 = "♥12" Or b16 = "♦12" Or b16 = "♧12" Or b16 = "♤12" Then
                n1 = 12
            ElseIf b16 = "♥13" Or b16 = "♦13" Or b16 = "♧13" Or b16 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A16.Text = b16
            s2 = b16
            If b16 = "♥1" Or b16 = "♦1" Or b16 = "♧1" Or b16 = "♤1" Then
                n2 = 1
            ElseIf b16 = "♥2" Or b16 = "♦2" Or b16 = "♧2" Or b16 = "♤2" Then
                n2 = 2
            ElseIf b16 = "♥3" Or b16 = "♦3" Or b16 = "♧3" Or b16 = "♤3" Then
                n2 = 3
            ElseIf b16 = "♥4" Or b16 = "♦4" Or b16 = "♧4" Or b16 = "♤4" Then
                n2 = 4
            ElseIf b16 = "♥5" Or b16 = "♦5" Or b16 = "♧5" Or b16 = "♤5" Then
                n2 = 5
            ElseIf b16 = "♥6" Or b16 = "♦6" Or b16 = "♧6" Or b16 = "♤6" Then
                n2 = 6
            ElseIf b16 = "♥7" Or b16 = "♦7" Or b16 = "♧7" Or b16 = "♤7" Then
                n2 = 7
            ElseIf b16 = "♥8" Or b16 = "♦8" Or b16 = "♧8" Or b16 = "♤8" Then
                n2 = 8
            ElseIf b16 = "♥9" Or b16 = "♦9" Or b16 = "♧9" Or b16 = "♤9" Then
                n2 = 9
            ElseIf b16 = "♥10" Or b16 = "♦10" Or b16 = "♧10" Or b16 = "♤10" Then
                n2 = 10
            ElseIf b16 = "♥11" Or b16 = "♦11" Or b16 = "♧11" Or b16 = "♤11" Then
                n2 = 11
            ElseIf b16 = "♥12" Or b16 = "♦12" Or b16 = "♧12" Or b16 = "♤12" Then
                n2 = 12
            ElseIf b16 = "♥13" Or b16 = "♦13" Or b16 = "♧13" Or b16 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A17_Click(sender As Object, e As EventArgs) Handles A17.Click
        If sn = 1 Then
            A17.Enabled = False
            A17.Text = b17
            s1 = b17
            If b17 = "♥1" Or b17 = "♦1" Or b17 = "♧1" Or b17 = "♤1" Then
                n1 = 1
            ElseIf b17 = "♥2" Or b17 = "♦2" Or b17 = "♧2" Or b17 = "♤2" Then
                n1 = 2
            ElseIf b17 = "♥3" Or b17 = "♦3" Or b17 = "♧3" Or b17 = "♤3" Then
                n1 = 3
            ElseIf b17 = "♥4" Or b17 = "♦4" Or b17 = "♧4" Or b17 = "♤4" Then
                n1 = 4
            ElseIf b17 = "♥5" Or b17 = "♦5" Or b17 = "♧5" Or b17 = "♤5" Then
                n1 = 5
            ElseIf b17 = "♥6" Or b17 = "♦6" Or b17 = "♧6" Or b17 = "♤6" Then
                n1 = 6
            ElseIf b17 = "♥7" Or b17 = "♦7" Or b17 = "♧7" Or b17 = "♤7" Then
                n1 = 7
            ElseIf b17 = "♥8" Or b17 = "♦8" Or b17 = "♧8" Or b17 = "♤8" Then
                n1 = 8
            ElseIf b17 = "♥9" Or b17 = "♦9" Or b17 = "♧9" Or b17 = "♤9" Then
                n1 = 9
            ElseIf b17 = "♥10" Or b17 = "♦10" Or b17 = "♧10" Or b17 = "♤10" Then
                n1 = 10
            ElseIf b17 = "♥11" Or b17 = "♦11" Or b17 = "♧11" Or b17 = "♤11" Then
                n1 = 11
            ElseIf b17 = "♥12" Or b17 = "♦12" Or b17 = "♧12" Or b17 = "♤12" Then
                n1 = 12
            ElseIf b17 = "♥13" Or b17 = "♦13" Or b17 = "♧13" Or b17 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A17.Text = b17
            s2 = b17
            If b17 = "♥1" Or b17 = "♦1" Or b17 = "♧1" Or b17 = "♤1" Then
                n2 = 1
            ElseIf b17 = "♥2" Or b17 = "♦2" Or b17 = "♧2" Or b17 = "♤2" Then
                n2 = 2
            ElseIf b17 = "♥3" Or b17 = "♦3" Or b17 = "♧3" Or b17 = "♤3" Then
                n2 = 3
            ElseIf b17 = "♥4" Or b17 = "♦4" Or b17 = "♧4" Or b17 = "♤4" Then
                n2 = 4
            ElseIf b17 = "♥5" Or b17 = "♦5" Or b17 = "♧5" Or b17 = "♤5" Then
                n2 = 5
            ElseIf b17 = "♥6" Or b17 = "♦6" Or b17 = "♧6" Or b17 = "♤6" Then
                n2 = 6
            ElseIf b17 = "♥7" Or b17 = "♦7" Or b17 = "♧7" Or b17 = "♤7" Then
                n2 = 7
            ElseIf b17 = "♥8" Or b17 = "♦8" Or b17 = "♧8" Or b17 = "♤8" Then
                n2 = 8
            ElseIf b17 = "♥9" Or b17 = "♦9" Or b17 = "♧9" Or b17 = "♤9" Then
                n2 = 9
            ElseIf b17 = "♥10" Or b17 = "♦10" Or b17 = "♧10" Or b17 = "♤10" Then
                n2 = 10
            ElseIf b17 = "♥11" Or b17 = "♦11" Or b17 = "♧11" Or b17 = "♤11" Then
                n2 = 11
            ElseIf b17 = "♥12" Or b17 = "♦12" Or b17 = "♧12" Or b17 = "♤12" Then
                n2 = 12
            ElseIf b17 = "♥13" Or b17 = "♦13" Or b17 = "♧13" Or b17 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A18_Click(sender As Object, e As EventArgs) Handles A18.Click
        If sn = 1 Then
            A18.Enabled = False
            A18.Text = b18
            s1 = b18
            If b18 = "♥1" Or b18 = "♦1" Or b18 = "♧1" Or b18 = "♤1" Then
                n1 = 1
            ElseIf b18 = "♥2" Or b18 = "♦2" Or b18 = "♧2" Or b18 = "♤2" Then
                n1 = 2
            ElseIf b18 = "♥3" Or b18 = "♦3" Or b18 = "♧3" Or b18 = "♤3" Then
                n1 = 3
            ElseIf b18 = "♥4" Or b18 = "♦4" Or b18 = "♧4" Or b18 = "♤4" Then
                n1 = 4
            ElseIf b18 = "♥5" Or b18 = "♦5" Or b18 = "♧5" Or b18 = "♤5" Then
                n1 = 5
            ElseIf b18 = "♥6" Or b18 = "♦6" Or b18 = "♧6" Or b18 = "♤6" Then
                n1 = 6
            ElseIf b18 = "♥7" Or b18 = "♦7" Or b18 = "♧7" Or b18 = "♤7" Then
                n1 = 7
            ElseIf b18 = "♥8" Or b18 = "♦8" Or b18 = "♧8" Or b18 = "♤8" Then
                n1 = 8
            ElseIf b18 = "♥9" Or b18 = "♦9" Or b18 = "♧9" Or b18 = "♤9" Then
                n1 = 9
            ElseIf b18 = "♥10" Or b18 = "♦10" Or b18 = "♧10" Or b18 = "♤10" Then
                n1 = 10
            ElseIf b18 = "♥11" Or b18 = "♦11" Or b18 = "♧11" Or b18 = "♤11" Then
                n1 = 11
            ElseIf b18 = "♥12" Or b18 = "♦12" Or b18 = "♧12" Or b18 = "♤12" Then
                n1 = 12
            ElseIf b18 = "♥13" Or b18 = "♦13" Or b18 = "♧13" Or b18 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A18.Text = b18
            s2 = b18
            If b18 = "♥1" Or b18 = "♦1" Or b18 = "♧1" Or b18 = "♤1" Then
                n2 = 1
            ElseIf b18 = "♥2" Or b18 = "♦2" Or b18 = "♧2" Or b18 = "♤2" Then
                n2 = 2
            ElseIf b18 = "♥3" Or b18 = "♦3" Or b18 = "♧3" Or b18 = "♤3" Then
                n2 = 3
            ElseIf b18 = "♥4" Or b18 = "♦4" Or b18 = "♧4" Or b18 = "♤4" Then
                n2 = 4
            ElseIf b18 = "♥5" Or b18 = "♦5" Or b18 = "♧5" Or b18 = "♤5" Then
                n2 = 5
            ElseIf b18 = "♥6" Or b18 = "♦6" Or b18 = "♧6" Or b18 = "♤6" Then
                n2 = 6
            ElseIf b18 = "♥7" Or b18 = "♦7" Or b18 = "♧7" Or b18 = "♤7" Then
                n2 = 7
            ElseIf b18 = "♥8" Or b18 = "♦8" Or b18 = "♧8" Or b18 = "♤8" Then
                n2 = 8
            ElseIf b18 = "♥9" Or b18 = "♦9" Or b18 = "♧9" Or b18 = "♤9" Then
                n2 = 9
            ElseIf b18 = "♥10" Or b18 = "♦10" Or b18 = "♧10" Or b18 = "♤10" Then
                n2 = 10
            ElseIf b18 = "♥11" Or b18 = "♦11" Or b18 = "♧11" Or b18 = "♤11" Then
                n2 = 11
            ElseIf b18 = "♥12" Or b18 = "♦12" Or b18 = "♧12" Or b18 = "♤12" Then
                n2 = 12
            ElseIf b18 = "♥13" Or b18 = "♦13" Or b18 = "♧13" Or b18 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A19_Click(sender As Object, e As EventArgs) Handles A19.Click
        If sn = 1 Then
            A19.Enabled = False
            A19.Text = b19
            s1 = b19
            If b19 = "♥1" Or b19 = "♦1" Or b19 = "♧1" Or b19 = "♤1" Then
                n1 = 1
            ElseIf b19 = "♥2" Or b19 = "♦2" Or b19 = "♧2" Or b19 = "♤2" Then
                n1 = 2
            ElseIf b19 = "♥3" Or b19 = "♦3" Or b19 = "♧3" Or b19 = "♤3" Then
                n1 = 3
            ElseIf b19 = "♥4" Or b19 = "♦4" Or b19 = "♧4" Or b19 = "♤4" Then
                n1 = 4
            ElseIf b19 = "♥5" Or b19 = "♦5" Or b19 = "♧5" Or b19 = "♤5" Then
                n1 = 5
            ElseIf b19 = "♥6" Or b19 = "♦6" Or b19 = "♧6" Or b19 = "♤6" Then
                n1 = 6
            ElseIf b19 = "♥7" Or b19 = "♦7" Or b19 = "♧7" Or b19 = "♤7" Then
                n1 = 7
            ElseIf b19 = "♥8" Or b19 = "♦8" Or b19 = "♧8" Or b19 = "♤8" Then
                n1 = 8
            ElseIf b19 = "♥9" Or b19 = "♦9" Or b19 = "♧9" Or b19 = "♤9" Then
                n1 = 9
            ElseIf b19 = "♥10" Or b19 = "♦10" Or b19 = "♧10" Or b19 = "♤10" Then
                n1 = 10
            ElseIf b19 = "♥11" Or b19 = "♦11" Or b19 = "♧11" Or b19 = "♤11" Then
                n1 = 11
            ElseIf b19 = "♥12" Or b19 = "♦12" Or b19 = "♧12" Or b19 = "♤12" Then
                n1 = 12
            ElseIf b19 = "♥13" Or b19 = "♦13" Or b19 = "♧13" Or b19 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A19.Text = b19
            s2 = b19
            If b19 = "♥1" Or b19 = "♦1" Or b19 = "♧1" Or b19 = "♤1" Then
                n2 = 1
            ElseIf b19 = "♥2" Or b19 = "♦2" Or b19 = "♧2" Or b19 = "♤2" Then
                n2 = 2
            ElseIf b19 = "♥3" Or b19 = "♦3" Or b19 = "♧3" Or b19 = "♤3" Then
                n2 = 3
            ElseIf b19 = "♥4" Or b19 = "♦4" Or b19 = "♧4" Or b19 = "♤4" Then
                n2 = 4
            ElseIf b19 = "♥5" Or b19 = "♦5" Or b19 = "♧5" Or b19 = "♤5" Then
                n2 = 5
            ElseIf b19 = "♥6" Or b19 = "♦6" Or b19 = "♧6" Or b19 = "♤6" Then
                n2 = 6
            ElseIf b19 = "♥7" Or b19 = "♦7" Or b19 = "♧7" Or b19 = "♤7" Then
                n2 = 7
            ElseIf b19 = "♥8" Or b19 = "♦8" Or b19 = "♧8" Or b19 = "♤8" Then
                n2 = 8
            ElseIf b19 = "♥9" Or b19 = "♦9" Or b19 = "♧9" Or b19 = "♤9" Then
                n2 = 9
            ElseIf b19 = "♥10" Or b19 = "♦10" Or b19 = "♧10" Or b19 = "♤10" Then
                n2 = 10
            ElseIf b19 = "♥11" Or b19 = "♦11" Or b19 = "♧11" Or b19 = "♤11" Then
                n2 = 11
            ElseIf b19 = "♥12" Or b19 = "♦12" Or b19 = "♧12" Or b19 = "♤12" Then
                n2 = 12
            ElseIf b19 = "♥13" Or b19 = "♦13" Or b19 = "♧13" Or b19 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A20_Click(sender As Object, e As EventArgs) Handles A20.Click
        If sn = 1 Then
            A20.Enabled = False
            A20.Text = b20
            s1 = b20
            If b20 = "♥1" Or b20 = "♦1" Or b20 = "♧1" Or b20 = "♤1" Then
                n1 = 1
            ElseIf b20 = "♥2" Or b20 = "♦2" Or b20 = "♧2" Or b20 = "♤2" Then
                n1 = 2
            ElseIf b20 = "♥3" Or b20 = "♦3" Or b20 = "♧3" Or b20 = "♤3" Then
                n1 = 3
            ElseIf b20 = "♥4" Or b20 = "♦4" Or b20 = "♧4" Or b20 = "♤4" Then
                n1 = 4
            ElseIf b20 = "♥5" Or b20 = "♦5" Or b20 = "♧5" Or b20 = "♤5" Then
                n1 = 5
            ElseIf b20 = "♥6" Or b20 = "♦6" Or b20 = "♧6" Or b20 = "♤6" Then
                n1 = 6
            ElseIf b20 = "♥7" Or b20 = "♦7" Or b20 = "♧7" Or b20 = "♤7" Then
                n1 = 7
            ElseIf b20 = "♥8" Or b20 = "♦8" Or b20 = "♧8" Or b20 = "♤8" Then
                n1 = 8
            ElseIf b20 = "♥9" Or b20 = "♦9" Or b20 = "♧9" Or b20 = "♤9" Then
                n1 = 9
            ElseIf b20 = "♥10" Or b20 = "♦10" Or b20 = "♧10" Or b20 = "♤10" Then
                n1 = 10
            ElseIf b20 = "♥11" Or b20 = "♦11" Or b20 = "♧11" Or b20 = "♤11" Then
                n1 = 11
            ElseIf b20 = "♥12" Or b20 = "♦12" Or b20 = "♧12" Or b20 = "♤12" Then
                n1 = 12
            ElseIf b20 = "♥13" Or b20 = "♦13" Or b20 = "♧13" Or b20 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A20.Text = b20
            s2 = b20
            If b20 = "♥1" Or b20 = "♦1" Or b20 = "♧1" Or b20 = "♤1" Then
                n2 = 1
            ElseIf b20 = "♥2" Or b20 = "♦2" Or b20 = "♧2" Or b20 = "♤2" Then
                n2 = 2
            ElseIf b20 = "♥3" Or b20 = "♦3" Or b20 = "♧3" Or b20 = "♤3" Then
                n2 = 3
            ElseIf b20 = "♥4" Or b20 = "♦4" Or b20 = "♧4" Or b20 = "♤4" Then
                n2 = 4
            ElseIf b20 = "♥5" Or b20 = "♦5" Or b20 = "♧5" Or b20 = "♤5" Then
                n2 = 5
            ElseIf b20 = "♥6" Or b20 = "♦6" Or b20 = "♧6" Or b20 = "♤6" Then
                n2 = 6
            ElseIf b20 = "♥7" Or b20 = "♦7" Or b20 = "♧7" Or b20 = "♤7" Then
                n2 = 7
            ElseIf b20 = "♥8" Or b20 = "♦8" Or b20 = "♧8" Or b20 = "♤8" Then
                n2 = 8
            ElseIf b20 = "♥9" Or b20 = "♦9" Or b20 = "♧9" Or b20 = "♤9" Then
                n2 = 9
            ElseIf b20 = "♥10" Or b20 = "♦10" Or b20 = "♧10" Or b20 = "♤10" Then
                n2 = 10
            ElseIf b20 = "♥11" Or b20 = "♦11" Or b20 = "♧11" Or b20 = "♤11" Then
                n2 = 11
            ElseIf b20 = "♥12" Or b20 = "♦12" Or b20 = "♧12" Or b20 = "♤12" Then
                n2 = 12
            ElseIf b20 = "♥13" Or b20 = "♦13" Or b20 = "♧13" Or b20 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A21_Click(sender As Object, e As EventArgs) Handles A21.Click
        If sn = 1 Then
            A21.Enabled = False
            A21.Text = b21
            s1 = b21
            If b21 = "♥1" Or b21 = "♦1" Or b21 = "♧1" Or b21 = "♤1" Then
                n1 = 1
            ElseIf b21 = "♥2" Or b21 = "♦2" Or b21 = "♧2" Or b21 = "♤2" Then
                n1 = 2
            ElseIf b21 = "♥3" Or b21 = "♦3" Or b21 = "♧3" Or b21 = "♤3" Then
                n1 = 3
            ElseIf b21 = "♥4" Or b21 = "♦4" Or b21 = "♧4" Or b21 = "♤4" Then
                n1 = 4
            ElseIf b21 = "♥5" Or b21 = "♦5" Or b21 = "♧5" Or b21 = "♤5" Then
                n1 = 5
            ElseIf b21 = "♥6" Or b21 = "♦6" Or b21 = "♧6" Or b21 = "♤6" Then
                n1 = 6
            ElseIf b21 = "♥7" Or b21 = "♦7" Or b21 = "♧7" Or b21 = "♤7" Then
                n1 = 7
            ElseIf b21 = "♥8" Or b21 = "♦8" Or b21 = "♧8" Or b21 = "♤8" Then
                n1 = 8
            ElseIf b21 = "♥9" Or b21 = "♦9" Or b21 = "♧9" Or b21 = "♤9" Then
                n1 = 9
            ElseIf b21 = "♥10" Or b21 = "♦10" Or b21 = "♧10" Or b21 = "♤10" Then
                n1 = 10
            ElseIf b21 = "♥11" Or b21 = "♦11" Or b21 = "♧11" Or b21 = "♤11" Then
                n1 = 11
            ElseIf b21 = "♥12" Or b21 = "♦12" Or b21 = "♧12" Or b21 = "♤12" Then
                n1 = 12
            ElseIf b21 = "♥13" Or b21 = "♦13" Or b21 = "♧13" Or b21 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A21.Text = b21
            s2 = b21
            If b21 = "♥1" Or b21 = "♦1" Or b21 = "♧1" Or b21 = "♤1" Then
                n2 = 1
            ElseIf b21 = "♥2" Or b21 = "♦2" Or b21 = "♧2" Or b21 = "♤2" Then
                n2 = 2
            ElseIf b21 = "♥3" Or b21 = "♦3" Or b21 = "♧3" Or b21 = "♤3" Then
                n2 = 3
            ElseIf b21 = "♥4" Or b21 = "♦4" Or b21 = "♧4" Or b21 = "♤4" Then
                n2 = 4
            ElseIf b21 = "♥5" Or b21 = "♦5" Or b21 = "♧5" Or b21 = "♤5" Then
                n2 = 5
            ElseIf b21 = "♥6" Or b21 = "♦6" Or b21 = "♧6" Or b21 = "♤6" Then
                n2 = 6
            ElseIf b21 = "♥7" Or b21 = "♦7" Or b21 = "♧7" Or b21 = "♤7" Then
                n2 = 7
            ElseIf b21 = "♥8" Or b21 = "♦8" Or b21 = "♧8" Or b21 = "♤8" Then
                n2 = 8
            ElseIf b21 = "♥9" Or b21 = "♦9" Or b21 = "♧9" Or b21 = "♤9" Then
                n2 = 9
            ElseIf b21 = "♥10" Or b21 = "♦10" Or b21 = "♧10" Or b21 = "♤10" Then
                n2 = 10
            ElseIf b21 = "♥11" Or b21 = "♦11" Or b21 = "♧11" Or b21 = "♤11" Then
                n2 = 11
            ElseIf b21 = "♥12" Or b21 = "♦12" Or b21 = "♧12" Or b21 = "♤12" Then
                n2 = 12
            ElseIf b21 = "♥13" Or b21 = "♦13" Or b21 = "♧13" Or b21 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A22_Click(sender As Object, e As EventArgs) Handles A22.Click
        If sn = 1 Then
            A22.Enabled = False
            A22.Text = b22
            s1 = b22
            If b22 = "♥1" Or b22 = "♦1" Or b22 = "♧1" Or b22 = "♤1" Then
                n1 = 1
            ElseIf b22 = "♥2" Or b22 = "♦2" Or b22 = "♧2" Or b22 = "♤2" Then
                n1 = 2
            ElseIf b22 = "♥3" Or b22 = "♦3" Or b22 = "♧3" Or b22 = "♤3" Then
                n1 = 3
            ElseIf b22 = "♥4" Or b22 = "♦4" Or b22 = "♧4" Or b22 = "♤4" Then
                n1 = 4
            ElseIf b22 = "♥5" Or b22 = "♦5" Or b22 = "♧5" Or b22 = "♤5" Then
                n1 = 5
            ElseIf b22 = "♥6" Or b22 = "♦6" Or b22 = "♧6" Or b22 = "♤6" Then
                n1 = 6
            ElseIf b22 = "♥7" Or b22 = "♦7" Or b22 = "♧7" Or b22 = "♤7" Then
                n1 = 7
            ElseIf b22 = "♥8" Or b22 = "♦8" Or b22 = "♧8" Or b22 = "♤8" Then
                n1 = 8
            ElseIf b22 = "♥9" Or b22 = "♦9" Or b22 = "♧9" Or b22 = "♤9" Then
                n1 = 9
            ElseIf b22 = "♥10" Or b22 = "♦10" Or b22 = "♧10" Or b22 = "♤10" Then
                n1 = 10
            ElseIf b22 = "♥11" Or b22 = "♦11" Or b22 = "♧11" Or b22 = "♤11" Then
                n1 = 11
            ElseIf b22 = "♥12" Or b22 = "♦12" Or b22 = "♧12" Or b22 = "♤12" Then
                n1 = 12
            ElseIf b22 = "♥13" Or b22 = "♦13" Or b22 = "♧13" Or b22 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A22.Text = b22
            s2 = b22
            If b22 = "♥1" Or b22 = "♦1" Or b22 = "♧1" Or b22 = "♤1" Then
                n2 = 1
            ElseIf b22 = "♥2" Or b22 = "♦2" Or b22 = "♧2" Or b22 = "♤2" Then
                n2 = 2
            ElseIf b22 = "♥3" Or b22 = "♦3" Or b22 = "♧3" Or b22 = "♤3" Then
                n2 = 3
            ElseIf b22 = "♥4" Or b22 = "♦4" Or b22 = "♧4" Or b22 = "♤4" Then
                n2 = 4
            ElseIf b22 = "♥5" Or b22 = "♦5" Or b22 = "♧5" Or b22 = "♤5" Then
                n2 = 5
            ElseIf b22 = "♥6" Or b22 = "♦6" Or b22 = "♧6" Or b22 = "♤6" Then
                n2 = 6
            ElseIf b22 = "♥7" Or b22 = "♦7" Or b22 = "♧7" Or b22 = "♤7" Then
                n2 = 7
            ElseIf b22 = "♥8" Or b22 = "♦8" Or b22 = "♧8" Or b22 = "♤8" Then
                n2 = 8
            ElseIf b22 = "♥9" Or b22 = "♦9" Or b22 = "♧9" Or b22 = "♤9" Then
                n2 = 9
            ElseIf b22 = "♥10" Or b22 = "♦10" Or b22 = "♧10" Or b22 = "♤10" Then
                n2 = 10
            ElseIf b22 = "♥11" Or b22 = "♦11" Or b22 = "♧11" Or b22 = "♤11" Then
                n2 = 11
            ElseIf b22 = "♥12" Or b22 = "♦12" Or b22 = "♧12" Or b22 = "♤12" Then
                n2 = 12
            ElseIf b22 = "♥13" Or b22 = "♦13" Or b22 = "♧13" Or b22 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A23_Click(sender As Object, e As EventArgs) Handles A23.Click
        If sn = 1 Then
            A23.Enabled = False
            A23.Text = b23
            s1 = b23
            If b23 = "♥1" Or b23 = "♦1" Or b23 = "♧1" Or b23 = "♤1" Then
                n1 = 1
            ElseIf b23 = "♥2" Or b23 = "♦2" Or b23 = "♧2" Or b23 = "♤2" Then
                n1 = 2
            ElseIf b23 = "♥3" Or b23 = "♦3" Or b23 = "♧3" Or b23 = "♤3" Then
                n1 = 3
            ElseIf b23 = "♥4" Or b23 = "♦4" Or b23 = "♧4" Or b23 = "♤4" Then
                n1 = 4
            ElseIf b23 = "♥5" Or b23 = "♦5" Or b23 = "♧5" Or b23 = "♤5" Then
                n1 = 5
            ElseIf b23 = "♥6" Or b23 = "♦6" Or b23 = "♧6" Or b23 = "♤6" Then
                n1 = 6
            ElseIf b23 = "♥7" Or b23 = "♦7" Or b23 = "♧7" Or b23 = "♤7" Then
                n1 = 7
            ElseIf b23 = "♥8" Or b23 = "♦8" Or b23 = "♧8" Or b23 = "♤8" Then
                n1 = 8
            ElseIf b23 = "♥9" Or b23 = "♦9" Or b23 = "♧9" Or b23 = "♤9" Then
                n1 = 9
            ElseIf b23 = "♥10" Or b23 = "♦10" Or b23 = "♧10" Or b23 = "♤10" Then
                n1 = 10
            ElseIf b23 = "♥11" Or b23 = "♦11" Or b23 = "♧11" Or b23 = "♤11" Then
                n1 = 11
            ElseIf b23 = "♥12" Or b23 = "♦12" Or b23 = "♧12" Or b23 = "♤12" Then
                n1 = 12
            ElseIf b23 = "♥13" Or b23 = "♦13" Or b23 = "♧13" Or b23 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A23.Text = b23
            s2 = b23
            If b23 = "♥1" Or b23 = "♦1" Or b23 = "♧1" Or b23 = "♤1" Then
                n2 = 1
            ElseIf b23 = "♥2" Or b23 = "♦2" Or b23 = "♧2" Or b23 = "♤2" Then
                n2 = 2
            ElseIf b23 = "♥3" Or b23 = "♦3" Or b23 = "♧3" Or b23 = "♤3" Then
                n2 = 3
            ElseIf b23 = "♥4" Or b23 = "♦4" Or b23 = "♧4" Or b23 = "♤4" Then
                n2 = 4
            ElseIf b23 = "♥5" Or b23 = "♦5" Or b23 = "♧5" Or b23 = "♤5" Then
                n2 = 5
            ElseIf b23 = "♥6" Or b23 = "♦6" Or b23 = "♧6" Or b23 = "♤6" Then
                n2 = 6
            ElseIf b23 = "♥7" Or b23 = "♦7" Or b23 = "♧7" Or b23 = "♤7" Then
                n2 = 7
            ElseIf b23 = "♥8" Or b23 = "♦8" Or b23 = "♧8" Or b23 = "♤8" Then
                n2 = 8
            ElseIf b23 = "♥9" Or b23 = "♦9" Or b23 = "♧9" Or b23 = "♤9" Then
                n2 = 9
            ElseIf b23 = "♥10" Or b23 = "♦10" Or b23 = "♧10" Or b23 = "♤10" Then
                n2 = 10
            ElseIf b23 = "♥11" Or b23 = "♦11" Or b23 = "♧11" Or b23 = "♤11" Then
                n2 = 11
            ElseIf b23 = "♥12" Or b23 = "♦12" Or b23 = "♧12" Or b23 = "♤12" Then
                n2 = 12
            ElseIf b23 = "♥13" Or b23 = "♦13" Or b23 = "♧13" Or b23 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A24_Click(sender As Object, e As EventArgs) Handles A24.Click
        If sn = 1 Then
            A24.Enabled = False
            A24.Text = b24
            s1 = b24
            If b24 = "♥1" Or b24 = "♦1" Or b24 = "♧1" Or b24 = "♤1" Then
                n1 = 1
            ElseIf b24 = "♥2" Or b24 = "♦2" Or b24 = "♧2" Or b24 = "♤2" Then
                n1 = 2
            ElseIf b24 = "♥3" Or b24 = "♦3" Or b24 = "♧3" Or b24 = "♤3" Then
                n1 = 3
            ElseIf b24 = "♥4" Or b24 = "♦4" Or b24 = "♧4" Or b24 = "♤4" Then
                n1 = 4
            ElseIf b24 = "♥5" Or b24 = "♦5" Or b24 = "♧5" Or b24 = "♤5" Then
                n1 = 5
            ElseIf b24 = "♥6" Or b24 = "♦6" Or b24 = "♧6" Or b24 = "♤6" Then
                n1 = 6
            ElseIf b24 = "♥7" Or b24 = "♦7" Or b24 = "♧7" Or b24 = "♤7" Then
                n1 = 7
            ElseIf b24 = "♥8" Or b24 = "♦8" Or b24 = "♧8" Or b24 = "♤8" Then
                n1 = 8
            ElseIf b24 = "♥9" Or b24 = "♦9" Or b24 = "♧9" Or b24 = "♤9" Then
                n1 = 9
            ElseIf b24 = "♥10" Or b24 = "♦10" Or b24 = "♧10" Or b24 = "♤10" Then
                n1 = 10
            ElseIf b24 = "♥11" Or b24 = "♦11" Or b24 = "♧11" Or b24 = "♤11" Then
                n1 = 11
            ElseIf b24 = "♥12" Or b24 = "♦12" Or b24 = "♧12" Or b24 = "♤12" Then
                n1 = 12
            ElseIf b24 = "♥13" Or b24 = "♦13" Or b24 = "♧13" Or b24 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A24.Text = b24
            s2 = b24
            If b24 = "♥1" Or b24 = "♦1" Or b24 = "♧1" Or b24 = "♤1" Then
                n2 = 1
            ElseIf b24 = "♥2" Or b24 = "♦2" Or b24 = "♧2" Or b24 = "♤2" Then
                n2 = 2
            ElseIf b24 = "♥3" Or b24 = "♦3" Or b24 = "♧3" Or b24 = "♤3" Then
                n2 = 3
            ElseIf b24 = "♥4" Or b24 = "♦4" Or b24 = "♧4" Or b24 = "♤4" Then
                n2 = 4
            ElseIf b24 = "♥5" Or b24 = "♦5" Or b24 = "♧5" Or b24 = "♤5" Then
                n2 = 5
            ElseIf b24 = "♥6" Or b24 = "♦6" Or b24 = "♧6" Or b24 = "♤6" Then
                n2 = 6
            ElseIf b24 = "♥7" Or b24 = "♦7" Or b24 = "♧7" Or b24 = "♤7" Then
                n2 = 7
            ElseIf b24 = "♥8" Or b24 = "♦8" Or b24 = "♧8" Or b24 = "♤8" Then
                n2 = 8
            ElseIf b24 = "♥9" Or b24 = "♦9" Or b24 = "♧9" Or b24 = "♤9" Then
                n2 = 9
            ElseIf b24 = "♥10" Or b24 = "♦10" Or b24 = "♧10" Or b24 = "♤10" Then
                n2 = 10
            ElseIf b24 = "♥11" Or b24 = "♦11" Or b24 = "♧11" Or b24 = "♤11" Then
                n2 = 11
            ElseIf b24 = "♥12" Or b24 = "♦12" Or b24 = "♧12" Or b24 = "♤12" Then
                n2 = 12
            ElseIf b24 = "♥13" Or b24 = "♦13" Or b24 = "♧13" Or b24 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A25_Click(sender As Object, e As EventArgs) Handles A25.Click
        If sn = 1 Then
            A25.Enabled = False
            A25.Text = b25
            s1 = b25
            If b25 = "♥1" Or b25 = "♦1" Or b25 = "♧1" Or b25 = "♤1" Then
                n1 = 1
            ElseIf b25 = "♥2" Or b25 = "♦2" Or b25 = "♧2" Or b25 = "♤2" Then
                n1 = 2
            ElseIf b25 = "♥3" Or b25 = "♦3" Or b25 = "♧3" Or b25 = "♤3" Then
                n1 = 3
            ElseIf b25 = "♥4" Or b25 = "♦4" Or b25 = "♧4" Or b25 = "♤4" Then
                n1 = 4
            ElseIf b25 = "♥5" Or b25 = "♦5" Or b25 = "♧5" Or b25 = "♤5" Then
                n1 = 5
            ElseIf b25 = "♥6" Or b25 = "♦6" Or b25 = "♧6" Or b25 = "♤6" Then
                n1 = 6
            ElseIf b25 = "♥7" Or b25 = "♦7" Or b25 = "♧7" Or b25 = "♤7" Then
                n1 = 7
            ElseIf b25 = "♥8" Or b25 = "♦8" Or b25 = "♧8" Or b25 = "♤8" Then
                n1 = 8
            ElseIf b25 = "♥9" Or b25 = "♦9" Or b25 = "♧9" Or b25 = "♤9" Then
                n1 = 9
            ElseIf b25 = "♥10" Or b25 = "♦10" Or b25 = "♧10" Or b25 = "♤10" Then
                n1 = 10
            ElseIf b25 = "♥11" Or b25 = "♦11" Or b25 = "♧11" Or b25 = "♤11" Then
                n1 = 11
            ElseIf b25 = "♥12" Or b25 = "♦12" Or b25 = "♧12" Or b25 = "♤12" Then
                n1 = 12
            ElseIf b25 = "♥13" Or b25 = "♦13" Or b25 = "♧13" Or b25 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A25.Text = b25
            s2 = b25
            If b25 = "♥1" Or b25 = "♦1" Or b25 = "♧1" Or b25 = "♤1" Then
                n2 = 1
            ElseIf b25 = "♥2" Or b25 = "♦2" Or b25 = "♧2" Or b25 = "♤2" Then
                n2 = 2
            ElseIf b25 = "♥3" Or b25 = "♦3" Or b25 = "♧3" Or b25 = "♤3" Then
                n2 = 3
            ElseIf b25 = "♥4" Or b25 = "♦4" Or b25 = "♧4" Or b25 = "♤4" Then
                n2 = 4
            ElseIf b25 = "♥5" Or b25 = "♦5" Or b25 = "♧5" Or b25 = "♤5" Then
                n2 = 5
            ElseIf b25 = "♥6" Or b25 = "♦6" Or b25 = "♧6" Or b25 = "♤6" Then
                n2 = 6
            ElseIf b25 = "♥7" Or b25 = "♦7" Or b25 = "♧7" Or b25 = "♤7" Then
                n2 = 7
            ElseIf b25 = "♥8" Or b25 = "♦8" Or b25 = "♧8" Or b25 = "♤8" Then
                n2 = 8
            ElseIf b25 = "♥9" Or b25 = "♦9" Or b25 = "♧9" Or b25 = "♤9" Then
                n2 = 9
            ElseIf b25 = "♥10" Or b25 = "♦10" Or b25 = "♧10" Or b25 = "♤10" Then
                n2 = 10
            ElseIf b25 = "♥11" Or b25 = "♦11" Or b25 = "♧11" Or b25 = "♤11" Then
                n2 = 11
            ElseIf b25 = "♥12" Or b25 = "♦12" Or b25 = "♧12" Or b25 = "♤12" Then
                n2 = 12
            ElseIf b25 = "♥13" Or b25 = "♦13" Or b25 = "♧13" Or b25 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A26_Click(sender As Object, e As EventArgs) Handles A26.Click
        If sn = 1 Then
            A26.Enabled = False
            A26.Text = b26
            s1 = b26
            If b26 = "♥1" Or b26 = "♦1" Or b26 = "♧1" Or b26 = "♤1" Then
                n1 = 1
            ElseIf b26 = "♥2" Or b26 = "♦2" Or b26 = "♧2" Or b26 = "♤2" Then
                n1 = 2
            ElseIf b26 = "♥3" Or b26 = "♦3" Or b26 = "♧3" Or b26 = "♤3" Then
                n1 = 3
            ElseIf b26 = "♥4" Or b26 = "♦4" Or b26 = "♧4" Or b26 = "♤4" Then
                n1 = 4
            ElseIf b26 = "♥5" Or b26 = "♦5" Or b26 = "♧5" Or b26 = "♤5" Then
                n1 = 5
            ElseIf b26 = "♥6" Or b26 = "♦6" Or b26 = "♧6" Or b26 = "♤6" Then
                n1 = 6
            ElseIf b26 = "♥7" Or b26 = "♦7" Or b26 = "♧7" Or b26 = "♤7" Then
                n1 = 7
            ElseIf b26 = "♥8" Or b26 = "♦8" Or b26 = "♧8" Or b26 = "♤8" Then
                n1 = 8
            ElseIf b26 = "♥9" Or b26 = "♦9" Or b26 = "♧9" Or b26 = "♤9" Then
                n1 = 9
            ElseIf b26 = "♥10" Or b26 = "♦10" Or b26 = "♧10" Or b26 = "♤10" Then
                n1 = 10
            ElseIf b26 = "♥11" Or b26 = "♦11" Or b26 = "♧11" Or b26 = "♤11" Then
                n1 = 11
            ElseIf b26 = "♥12" Or b26 = "♦12" Or b26 = "♧12" Or b26 = "♤12" Then
                n1 = 12
            ElseIf b26 = "♥13" Or b26 = "♦13" Or b26 = "♧13" Or b26 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A26.Text = b26
            s2 = b26
            If b26 = "♥1" Or b26 = "♦1" Or b26 = "♧1" Or b26 = "♤1" Then
                n2 = 1
            ElseIf b26 = "♥2" Or b26 = "♦2" Or b26 = "♧2" Or b26 = "♤2" Then
                n2 = 2
            ElseIf b26 = "♥3" Or b26 = "♦3" Or b26 = "♧3" Or b26 = "♤3" Then
                n2 = 3
            ElseIf b26 = "♥4" Or b26 = "♦4" Or b26 = "♧4" Or b26 = "♤4" Then
                n2 = 4
            ElseIf b26 = "♥5" Or b26 = "♦5" Or b26 = "♧5" Or b26 = "♤5" Then
                n2 = 5
            ElseIf b26 = "♥6" Or b26 = "♦6" Or b26 = "♧6" Or b26 = "♤6" Then
                n2 = 6
            ElseIf b26 = "♥7" Or b26 = "♦7" Or b26 = "♧7" Or b26 = "♤7" Then
                n2 = 7
            ElseIf b26 = "♥8" Or b26 = "♦8" Or b26 = "♧8" Or b26 = "♤8" Then
                n2 = 8
            ElseIf b26 = "♥9" Or b26 = "♦9" Or b26 = "♧9" Or b26 = "♤9" Then
                n2 = 9
            ElseIf b26 = "♥10" Or b26 = "♦10" Or b26 = "♧10" Or b26 = "♤10" Then
                n2 = 10
            ElseIf b26 = "♥11" Or b26 = "♦11" Or b26 = "♧11" Or b26 = "♤11" Then
                n2 = 11
            ElseIf b26 = "♥12" Or b26 = "♦12" Or b26 = "♧12" Or b26 = "♤12" Then
                n2 = 12
            ElseIf b26 = "♥13" Or b26 = "♦13" Or b26 = "♧13" Or b26 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A27_Click(sender As Object, e As EventArgs) Handles A27.Click
        If sn = 1 Then
            A27.Enabled = False
            A27.Text = b27
            s1 = b27
            If b27 = "♥1" Or b27 = "♦1" Or b27 = "♧1" Or b27 = "♤1" Then
                n1 = 1
            ElseIf b27 = "♥2" Or b27 = "♦2" Or b27 = "♧2" Or b27 = "♤2" Then
                n1 = 2
            ElseIf b27 = "♥3" Or b27 = "♦3" Or b27 = "♧3" Or b27 = "♤3" Then
                n1 = 3
            ElseIf b27 = "♥4" Or b27 = "♦4" Or b27 = "♧4" Or b27 = "♤4" Then
                n1 = 4
            ElseIf b27 = "♥5" Or b27 = "♦5" Or b27 = "♧5" Or b27 = "♤5" Then
                n1 = 5
            ElseIf b27 = "♥6" Or b27 = "♦6" Or b27 = "♧6" Or b27 = "♤6" Then
                n1 = 6
            ElseIf b27 = "♥7" Or b27 = "♦7" Or b27 = "♧7" Or b27 = "♤7" Then
                n1 = 7
            ElseIf b27 = "♥8" Or b27 = "♦8" Or b27 = "♧8" Or b27 = "♤8" Then
                n1 = 8
            ElseIf b27 = "♥9" Or b27 = "♦9" Or b27 = "♧9" Or b27 = "♤9" Then
                n1 = 9
            ElseIf b27 = "♥10" Or b27 = "♦10" Or b27 = "♧10" Or b27 = "♤10" Then
                n1 = 10
            ElseIf b27 = "♥11" Or b27 = "♦11" Or b27 = "♧11" Or b27 = "♤11" Then
                n1 = 11
            ElseIf b27 = "♥12" Or b27 = "♦12" Or b27 = "♧12" Or b27 = "♤12" Then
                n1 = 12
            ElseIf b27 = "♥13" Or b27 = "♦13" Or b27 = "♧13" Or b27 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A27.Text = b27
            s2 = b27
            If b27 = "♥1" Or b27 = "♦1" Or b27 = "♧1" Or b27 = "♤1" Then
                n2 = 1
            ElseIf b27 = "♥2" Or b27 = "♦2" Or b27 = "♧2" Or b27 = "♤2" Then
                n2 = 2
            ElseIf b27 = "♥3" Or b27 = "♦3" Or b27 = "♧3" Or b27 = "♤3" Then
                n2 = 3
            ElseIf b27 = "♥4" Or b27 = "♦4" Or b27 = "♧4" Or b27 = "♤4" Then
                n2 = 4
            ElseIf b27 = "♥5" Or b27 = "♦5" Or b27 = "♧5" Or b27 = "♤5" Then
                n2 = 5
            ElseIf b27 = "♥6" Or b27 = "♦6" Or b27 = "♧6" Or b27 = "♤6" Then
                n2 = 6
            ElseIf b27 = "♥7" Or b27 = "♦7" Or b27 = "♧7" Or b27 = "♤7" Then
                n2 = 7
            ElseIf b27 = "♥8" Or b27 = "♦8" Or b27 = "♧8" Or b27 = "♤8" Then
                n2 = 8
            ElseIf b27 = "♥9" Or b27 = "♦9" Or b27 = "♧9" Or b27 = "♤9" Then
                n2 = 9
            ElseIf b27 = "♥10" Or b27 = "♦10" Or b27 = "♧10" Or b27 = "♤10" Then
                n2 = 10
            ElseIf b27 = "♥11" Or b27 = "♦11" Or b27 = "♧11" Or b27 = "♤11" Then
                n2 = 11
            ElseIf b27 = "♥12" Or b27 = "♦12" Or b27 = "♧12" Or b27 = "♤12" Then
                n2 = 12
            ElseIf b27 = "♥13" Or b27 = "♦13" Or b27 = "♧13" Or b27 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A28_Click(sender As Object, e As EventArgs) Handles A28.Click
        If sn = 1 Then
            A28.Enabled = False
            A28.Text = b28
            s1 = b28
            If b28 = "♥1" Or b28 = "♦1" Or b28 = "♧1" Or b28 = "♤1" Then
                n1 = 1
            ElseIf b28 = "♥2" Or b28 = "♦2" Or b28 = "♧2" Or b28 = "♤2" Then
                n1 = 2
            ElseIf b28 = "♥3" Or b28 = "♦3" Or b28 = "♧3" Or b28 = "♤3" Then
                n1 = 3
            ElseIf b28 = "♥4" Or b28 = "♦4" Or b28 = "♧4" Or b28 = "♤4" Then
                n1 = 4
            ElseIf b28 = "♥5" Or b28 = "♦5" Or b28 = "♧5" Or b28 = "♤5" Then
                n1 = 5
            ElseIf b28 = "♥6" Or b28 = "♦6" Or b28 = "♧6" Or b28 = "♤6" Then
                n1 = 6
            ElseIf b28 = "♥7" Or b28 = "♦7" Or b28 = "♧7" Or b28 = "♤7" Then
                n1 = 7
            ElseIf b28 = "♥8" Or b28 = "♦8" Or b28 = "♧8" Or b28 = "♤8" Then
                n1 = 8
            ElseIf b28 = "♥9" Or b28 = "♦9" Or b28 = "♧9" Or b28 = "♤9" Then
                n1 = 9
            ElseIf b28 = "♥10" Or b28 = "♦10" Or b28 = "♧10" Or b28 = "♤10" Then
                n1 = 10
            ElseIf b28 = "♥11" Or b28 = "♦11" Or b28 = "♧11" Or b28 = "♤11" Then
                n1 = 11
            ElseIf b28 = "♥12" Or b28 = "♦12" Or b28 = "♧12" Or b28 = "♤12" Then
                n1 = 12
            ElseIf b28 = "♥13" Or b28 = "♦13" Or b28 = "♧13" Or b28 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A28.Text = b28
            s2 = b28
            If b28 = "♥1" Or b28 = "♦1" Or b28 = "♧1" Or b28 = "♤1" Then
                n2 = 1
            ElseIf b28 = "♥2" Or b28 = "♦2" Or b28 = "♧2" Or b28 = "♤2" Then
                n2 = 2
            ElseIf b28 = "♥3" Or b28 = "♦3" Or b28 = "♧3" Or b28 = "♤3" Then
                n2 = 3
            ElseIf b28 = "♥4" Or b28 = "♦4" Or b28 = "♧4" Or b28 = "♤4" Then
                n2 = 4
            ElseIf b28 = "♥5" Or b28 = "♦5" Or b28 = "♧5" Or b28 = "♤5" Then
                n2 = 5
            ElseIf b28 = "♥6" Or b28 = "♦6" Or b28 = "♧6" Or b28 = "♤6" Then
                n2 = 6
            ElseIf b28 = "♥7" Or b28 = "♦7" Or b28 = "♧7" Or b28 = "♤7" Then
                n2 = 7
            ElseIf b28 = "♥8" Or b28 = "♦8" Or b28 = "♧8" Or b28 = "♤8" Then
                n2 = 8
            ElseIf b28 = "♥9" Or b28 = "♦9" Or b28 = "♧9" Or b28 = "♤9" Then
                n2 = 9
            ElseIf b28 = "♥10" Or b28 = "♦10" Or b28 = "♧10" Or b28 = "♤10" Then
                n2 = 10
            ElseIf b28 = "♥11" Or b28 = "♦11" Or b28 = "♧11" Or b28 = "♤11" Then
                n2 = 11
            ElseIf b28 = "♥12" Or b28 = "♦12" Or b28 = "♧12" Or b28 = "♤12" Then
                n2 = 12
            ElseIf b28 = "♥13" Or b28 = "♦13" Or b28 = "♧13" Or b28 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A29_Click(sender As Object, e As EventArgs) Handles A29.Click
        If sn = 1 Then
            A29.Enabled = False
            A29.Text = b29
            s1 = b29
            If b29 = "♥1" Or b29 = "♦1" Or b29 = "♧1" Or b29 = "♤1" Then
                n1 = 1
            ElseIf b29 = "♥2" Or b29 = "♦2" Or b29 = "♧2" Or b29 = "♤2" Then
                n1 = 2
            ElseIf b29 = "♥3" Or b29 = "♦3" Or b29 = "♧3" Or b29 = "♤3" Then
                n1 = 3
            ElseIf b29 = "♥4" Or b29 = "♦4" Or b29 = "♧4" Or b29 = "♤4" Then
                n1 = 4
            ElseIf b29 = "♥5" Or b29 = "♦5" Or b29 = "♧5" Or b29 = "♤5" Then
                n1 = 5
            ElseIf b29 = "♥6" Or b29 = "♦6" Or b29 = "♧6" Or b29 = "♤6" Then
                n1 = 6
            ElseIf b29 = "♥7" Or b29 = "♦7" Or b29 = "♧7" Or b29 = "♤7" Then
                n1 = 7
            ElseIf b29 = "♥8" Or b29 = "♦8" Or b29 = "♧8" Or b29 = "♤8" Then
                n1 = 8
            ElseIf b29 = "♥9" Or b29 = "♦9" Or b29 = "♧9" Or b29 = "♤9" Then
                n1 = 9
            ElseIf b29 = "♥10" Or b29 = "♦10" Or b29 = "♧10" Or b29 = "♤10" Then
                n1 = 10
            ElseIf b29 = "♥11" Or b29 = "♦11" Or b29 = "♧11" Or b29 = "♤11" Then
                n1 = 11
            ElseIf b29 = "♥12" Or b29 = "♦12" Or b29 = "♧12" Or b29 = "♤12" Then
                n1 = 12
            ElseIf b29 = "♥13" Or b29 = "♦13" Or b29 = "♧13" Or b29 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A29.Text = b29
            s2 = b29
            If b29 = "♥1" Or b29 = "♦1" Or b29 = "♧1" Or b29 = "♤1" Then
                n2 = 1
            ElseIf b29 = "♥2" Or b29 = "♦2" Or b29 = "♧2" Or b29 = "♤2" Then
                n2 = 2
            ElseIf b29 = "♥3" Or b29 = "♦3" Or b29 = "♧3" Or b29 = "♤3" Then
                n2 = 3
            ElseIf b29 = "♥4" Or b29 = "♦4" Or b29 = "♧4" Or b29 = "♤4" Then
                n2 = 4
            ElseIf b29 = "♥5" Or b29 = "♦5" Or b29 = "♧5" Or b29 = "♤5" Then
                n2 = 5
            ElseIf b29 = "♥6" Or b29 = "♦6" Or b29 = "♧6" Or b29 = "♤6" Then
                n2 = 6
            ElseIf b29 = "♥7" Or b29 = "♦7" Or b29 = "♧7" Or b29 = "♤7" Then
                n2 = 7
            ElseIf b29 = "♥8" Or b29 = "♦8" Or b29 = "♧8" Or b29 = "♤8" Then
                n2 = 8
            ElseIf b29 = "♥9" Or b29 = "♦9" Or b29 = "♧9" Or b29 = "♤9" Then
                n2 = 9
            ElseIf b29 = "♥10" Or b29 = "♦10" Or b29 = "♧10" Or b29 = "♤10" Then
                n2 = 10
            ElseIf b29 = "♥11" Or b29 = "♦11" Or b29 = "♧11" Or b29 = "♤11" Then
                n2 = 11
            ElseIf b29 = "♥12" Or b29 = "♦12" Or b29 = "♧12" Or b29 = "♤12" Then
                n2 = 12
            ElseIf b29 = "♥13" Or b29 = "♦13" Or b29 = "♧13" Or b29 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A30_Click(sender As Object, e As EventArgs) Handles A30.Click
        If sn = 1 Then
            A30.Enabled = False
            A30.Text = b30
            s1 = b30
            If b30 = "♥1" Or b30 = "♦1" Or b30 = "♧1" Or b30 = "♤1" Then
                n1 = 1
            ElseIf b30 = "♥2" Or b30 = "♦2" Or b30 = "♧2" Or b30 = "♤2" Then
                n1 = 2
            ElseIf b30 = "♥3" Or b30 = "♦3" Or b30 = "♧3" Or b30 = "♤3" Then
                n1 = 3
            ElseIf b30 = "♥4" Or b30 = "♦4" Or b30 = "♧4" Or b30 = "♤4" Then
                n1 = 4
            ElseIf b30 = "♥5" Or b30 = "♦5" Or b30 = "♧5" Or b30 = "♤5" Then
                n1 = 5
            ElseIf b30 = "♥6" Or b30 = "♦6" Or b30 = "♧6" Or b30 = "♤6" Then
                n1 = 6
            ElseIf b30 = "♥7" Or b30 = "♦7" Or b30 = "♧7" Or b30 = "♤7" Then
                n1 = 7
            ElseIf b30 = "♥8" Or b30 = "♦8" Or b30 = "♧8" Or b30 = "♤8" Then
                n1 = 8
            ElseIf b30 = "♥9" Or b30 = "♦9" Or b30 = "♧9" Or b30 = "♤9" Then
                n1 = 9
            ElseIf b30 = "♥10" Or b30 = "♦10" Or b30 = "♧10" Or b30 = "♤10" Then
                n1 = 10
            ElseIf b30 = "♥11" Or b30 = "♦11" Or b30 = "♧11" Or b30 = "♤11" Then
                n1 = 11
            ElseIf b30 = "♥12" Or b30 = "♦12" Or b30 = "♧12" Or b30 = "♤12" Then
                n1 = 12
            ElseIf b30 = "♥13" Or b30 = "♦13" Or b30 = "♧13" Or b30 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A30.Text = b30
            s2 = b30
            If b30 = "♥1" Or b30 = "♦1" Or b30 = "♧1" Or b30 = "♤1" Then
                n2 = 1
            ElseIf b30 = "♥2" Or b30 = "♦2" Or b30 = "♧2" Or b30 = "♤2" Then
                n2 = 2
            ElseIf b30 = "♥3" Or b30 = "♦3" Or b30 = "♧3" Or b30 = "♤3" Then
                n2 = 3
            ElseIf b30 = "♥4" Or b30 = "♦4" Or b30 = "♧4" Or b30 = "♤4" Then
                n2 = 4
            ElseIf b30 = "♥5" Or b30 = "♦5" Or b30 = "♧5" Or b30 = "♤5" Then
                n2 = 5
            ElseIf b30 = "♥6" Or b30 = "♦6" Or b30 = "♧6" Or b30 = "♤6" Then
                n2 = 6
            ElseIf b30 = "♥7" Or b30 = "♦7" Or b30 = "♧7" Or b30 = "♤7" Then
                n2 = 7
            ElseIf b30 = "♥8" Or b30 = "♦8" Or b30 = "♧8" Or b30 = "♤8" Then
                n2 = 8
            ElseIf b30 = "♥9" Or b30 = "♦9" Or b30 = "♧9" Or b30 = "♤9" Then
                n2 = 9
            ElseIf b30 = "♥10" Or b30 = "♦10" Or b30 = "♧10" Or b30 = "♤10" Then
                n2 = 10
            ElseIf b30 = "♥11" Or b30 = "♦11" Or b30 = "♧11" Or b30 = "♤11" Then
                n2 = 11
            ElseIf b30 = "♥12" Or b30 = "♦12" Or b30 = "♧12" Or b30 = "♤12" Then
                n2 = 12
            ElseIf b30 = "♥13" Or b30 = "♦13" Or b30 = "♧13" Or b30 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A31_Click(sender As Object, e As EventArgs) Handles A31.Click
        If sn = 1 Then
            A31.Enabled = False
            A31.Text = b31
            s1 = b31
            If b31 = "♥1" Or b31 = "♦1" Or b31 = "♧1" Or b31 = "♤1" Then
                n1 = 1
            ElseIf b31 = "♥2" Or b31 = "♦2" Or b31 = "♧2" Or b31 = "♤2" Then
                n1 = 2
            ElseIf b31 = "♥3" Or b31 = "♦3" Or b31 = "♧3" Or b31 = "♤3" Then
                n1 = 3
            ElseIf b31 = "♥4" Or b31 = "♦4" Or b31 = "♧4" Or b31 = "♤4" Then
                n1 = 4
            ElseIf b31 = "♥5" Or b31 = "♦5" Or b31 = "♧5" Or b31 = "♤5" Then
                n1 = 5
            ElseIf b31 = "♥6" Or b31 = "♦6" Or b31 = "♧6" Or b31 = "♤6" Then
                n1 = 6
            ElseIf b31 = "♥7" Or b31 = "♦7" Or b31 = "♧7" Or b31 = "♤7" Then
                n1 = 7
            ElseIf b31 = "♥8" Or b31 = "♦8" Or b31 = "♧8" Or b31 = "♤8" Then
                n1 = 8
            ElseIf b31 = "♥9" Or b31 = "♦9" Or b31 = "♧9" Or b31 = "♤9" Then
                n1 = 9
            ElseIf b31 = "♥10" Or b31 = "♦10" Or b31 = "♧10" Or b31 = "♤10" Then
                n1 = 10
            ElseIf b31 = "♥11" Or b31 = "♦11" Or b31 = "♧11" Or b31 = "♤11" Then
                n1 = 11
            ElseIf b31 = "♥12" Or b31 = "♦12" Or b31 = "♧12" Or b31 = "♤12" Then
                n1 = 12
            ElseIf b31 = "♥13" Or b31 = "♦13" Or b31 = "♧13" Or b31 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A31.Text = b31
            s2 = b31
            If b31 = "♥1" Or b31 = "♦1" Or b31 = "♧1" Or b31 = "♤1" Then
                n2 = 1
            ElseIf b31 = "♥2" Or b31 = "♦2" Or b31 = "♧2" Or b31 = "♤2" Then
                n2 = 2
            ElseIf b31 = "♥3" Or b31 = "♦3" Or b31 = "♧3" Or b31 = "♤3" Then
                n2 = 3
            ElseIf b31 = "♥4" Or b31 = "♦4" Or b31 = "♧4" Or b31 = "♤4" Then
                n2 = 4
            ElseIf b31 = "♥5" Or b31 = "♦5" Or b31 = "♧5" Or b31 = "♤5" Then
                n2 = 5
            ElseIf b31 = "♥6" Or b31 = "♦6" Or b31 = "♧6" Or b31 = "♤6" Then
                n2 = 6
            ElseIf b31 = "♥7" Or b31 = "♦7" Or b31 = "♧7" Or b31 = "♤7" Then
                n2 = 7
            ElseIf b31 = "♥8" Or b31 = "♦8" Or b31 = "♧8" Or b31 = "♤8" Then
                n2 = 8
            ElseIf b31 = "♥9" Or b31 = "♦9" Or b31 = "♧9" Or b31 = "♤9" Then
                n2 = 9
            ElseIf b31 = "♥10" Or b31 = "♦10" Or b31 = "♧10" Or b31 = "♤10" Then
                n2 = 10
            ElseIf b31 = "♥11" Or b31 = "♦11" Or b31 = "♧11" Or b31 = "♤11" Then
                n2 = 11
            ElseIf b31 = "♥12" Or b31 = "♦12" Or b31 = "♧12" Or b31 = "♤12" Then
                n2 = 12
            ElseIf b31 = "♥13" Or b31 = "♦13" Or b31 = "♧13" Or b31 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A32_Click(sender As Object, e As EventArgs) Handles A32.Click
        If sn = 1 Then
            A32.Enabled = False
            A32.Text = b32
            s1 = b32
            If b32 = "♥1" Or b32 = "♦1" Or b32 = "♧1" Or b32 = "♤1" Then
                n1 = 1
            ElseIf b32 = "♥2" Or b32 = "♦2" Or b32 = "♧2" Or b32 = "♤2" Then
                n1 = 2
            ElseIf b32 = "♥3" Or b32 = "♦3" Or b32 = "♧3" Or b32 = "♤3" Then
                n1 = 3
            ElseIf b32 = "♥4" Or b32 = "♦4" Or b32 = "♧4" Or b32 = "♤4" Then
                n1 = 4
            ElseIf b32 = "♥5" Or b32 = "♦5" Or b32 = "♧5" Or b32 = "♤5" Then
                n1 = 5
            ElseIf b32 = "♥6" Or b32 = "♦6" Or b32 = "♧6" Or b32 = "♤6" Then
                n1 = 6
            ElseIf b32 = "♥7" Or b32 = "♦7" Or b32 = "♧7" Or b32 = "♤7" Then
                n1 = 7
            ElseIf b32 = "♥8" Or b32 = "♦8" Or b32 = "♧8" Or b32 = "♤8" Then
                n1 = 8
            ElseIf b32 = "♥9" Or b32 = "♦9" Or b32 = "♧9" Or b32 = "♤9" Then
                n1 = 9
            ElseIf b32 = "♥10" Or b32 = "♦10" Or b32 = "♧10" Or b32 = "♤10" Then
                n1 = 10
            ElseIf b32 = "♥11" Or b32 = "♦11" Or b32 = "♧11" Or b32 = "♤11" Then
                n1 = 11
            ElseIf b32 = "♥12" Or b32 = "♦12" Or b32 = "♧12" Or b32 = "♤12" Then
                n1 = 12
            ElseIf b32 = "♥13" Or b32 = "♦13" Or b32 = "♧13" Or b32 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A32.Text = b32
            s2 = b32
            If b32 = "♥1" Or b32 = "♦1" Or b32 = "♧1" Or b32 = "♤1" Then
                n2 = 1
            ElseIf b32 = "♥2" Or b32 = "♦2" Or b32 = "♧2" Or b32 = "♤2" Then
                n2 = 2
            ElseIf b32 = "♥3" Or b32 = "♦3" Or b32 = "♧3" Or b32 = "♤3" Then
                n2 = 3
            ElseIf b32 = "♥4" Or b32 = "♦4" Or b32 = "♧4" Or b32 = "♤4" Then
                n2 = 4
            ElseIf b32 = "♥5" Or b32 = "♦5" Or b32 = "♧5" Or b32 = "♤5" Then
                n2 = 5
            ElseIf b32 = "♥6" Or b32 = "♦6" Or b32 = "♧6" Or b32 = "♤6" Then
                n2 = 6
            ElseIf b32 = "♥7" Or b32 = "♦7" Or b32 = "♧7" Or b32 = "♤7" Then
                n2 = 7
            ElseIf b32 = "♥8" Or b32 = "♦8" Or b32 = "♧8" Or b32 = "♤8" Then
                n2 = 8
            ElseIf b32 = "♥9" Or b32 = "♦9" Or b32 = "♧9" Or b32 = "♤9" Then
                n2 = 9
            ElseIf b32 = "♥10" Or b32 = "♦10" Or b32 = "♧10" Or b32 = "♤10" Then
                n2 = 10
            ElseIf b32 = "♥11" Or b32 = "♦11" Or b32 = "♧11" Or b32 = "♤11" Then
                n2 = 11
            ElseIf b32 = "♥12" Or b32 = "♦12" Or b32 = "♧12" Or b32 = "♤12" Then
                n2 = 12
            ElseIf b32 = "♥13" Or b32 = "♦13" Or b32 = "♧13" Or b32 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A33_Click(sender As Object, e As EventArgs) Handles A33.Click
        If sn = 1 Then
            A33.Enabled = False
            A33.Text = b33
            s1 = b33
            If b33 = "♥1" Or b33 = "♦1" Or b33 = "♧1" Or b33 = "♤1" Then
                n1 = 1
            ElseIf b33 = "♥2" Or b33 = "♦2" Or b33 = "♧2" Or b33 = "♤2" Then
                n1 = 2
            ElseIf b33 = "♥3" Or b33 = "♦3" Or b33 = "♧3" Or b33 = "♤3" Then
                n1 = 3
            ElseIf b33 = "♥4" Or b33 = "♦4" Or b33 = "♧4" Or b33 = "♤4" Then
                n1 = 4
            ElseIf b33 = "♥5" Or b33 = "♦5" Or b33 = "♧5" Or b33 = "♤5" Then
                n1 = 5
            ElseIf b33 = "♥6" Or b33 = "♦6" Or b33 = "♧6" Or b33 = "♤6" Then
                n1 = 6
            ElseIf b33 = "♥7" Or b33 = "♦7" Or b33 = "♧7" Or b33 = "♤7" Then
                n1 = 7
            ElseIf b33 = "♥8" Or b33 = "♦8" Or b33 = "♧8" Or b33 = "♤8" Then
                n1 = 8
            ElseIf b33 = "♥9" Or b33 = "♦9" Or b33 = "♧9" Or b33 = "♤9" Then
                n1 = 9
            ElseIf b33 = "♥10" Or b33 = "♦10" Or b33 = "♧10" Or b33 = "♤10" Then
                n1 = 10
            ElseIf b33 = "♥11" Or b33 = "♦11" Or b33 = "♧11" Or b33 = "♤11" Then
                n1 = 11
            ElseIf b33 = "♥12" Or b33 = "♦12" Or b33 = "♧12" Or b33 = "♤12" Then
                n1 = 12
            ElseIf b33 = "♥13" Or b33 = "♦13" Or b33 = "♧13" Or b33 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A33.Text = b33
            s2 = b33
            If b33 = "♥1" Or b33 = "♦1" Or b33 = "♧1" Or b33 = "♤1" Then
                n2 = 1
            ElseIf b33 = "♥2" Or b33 = "♦2" Or b33 = "♧2" Or b33 = "♤2" Then
                n2 = 2
            ElseIf b33 = "♥3" Or b33 = "♦3" Or b33 = "♧3" Or b33 = "♤3" Then
                n2 = 3
            ElseIf b33 = "♥4" Or b33 = "♦4" Or b33 = "♧4" Or b33 = "♤4" Then
                n2 = 4
            ElseIf b33 = "♥5" Or b33 = "♦5" Or b33 = "♧5" Or b33 = "♤5" Then
                n2 = 5
            ElseIf b33 = "♥6" Or b33 = "♦6" Or b33 = "♧6" Or b33 = "♤6" Then
                n2 = 6
            ElseIf b33 = "♥7" Or b33 = "♦7" Or b33 = "♧7" Or b33 = "♤7" Then
                n2 = 7
            ElseIf b33 = "♥8" Or b33 = "♦8" Or b33 = "♧8" Or b33 = "♤8" Then
                n2 = 8
            ElseIf b33 = "♥9" Or b33 = "♦9" Or b33 = "♧9" Or b33 = "♤9" Then
                n2 = 9
            ElseIf b33 = "♥10" Or b33 = "♦10" Or b33 = "♧10" Or b33 = "♤10" Then
                n2 = 10
            ElseIf b33 = "♥11" Or b33 = "♦11" Or b33 = "♧11" Or b33 = "♤11" Then
                n2 = 11
            ElseIf b33 = "♥12" Or b33 = "♦12" Or b33 = "♧12" Or b33 = "♤12" Then
                n2 = 12
            ElseIf b33 = "♥13" Or b33 = "♦13" Or b33 = "♧13" Or b33 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A34_Click(sender As Object, e As EventArgs) Handles A34.Click
        If sn = 1 Then
            A34.Enabled = False
            A34.Text = b34
            s1 = b34
            If b34 = "♥1" Or b34 = "♦1" Or b34 = "♧1" Or b34 = "♤1" Then
                n1 = 1
            ElseIf b34 = "♥2" Or b34 = "♦2" Or b34 = "♧2" Or b34 = "♤2" Then
                n1 = 2
            ElseIf b34 = "♥3" Or b34 = "♦3" Or b34 = "♧3" Or b34 = "♤3" Then
                n1 = 3
            ElseIf b34 = "♥4" Or b34 = "♦4" Or b34 = "♧4" Or b34 = "♤4" Then
                n1 = 4
            ElseIf b34 = "♥5" Or b34 = "♦5" Or b34 = "♧5" Or b34 = "♤5" Then
                n1 = 5
            ElseIf b34 = "♥6" Or b34 = "♦6" Or b34 = "♧6" Or b34 = "♤6" Then
                n1 = 6
            ElseIf b34 = "♥7" Or b34 = "♦7" Or b34 = "♧7" Or b34 = "♤7" Then
                n1 = 7
            ElseIf b34 = "♥8" Or b34 = "♦8" Or b34 = "♧8" Or b34 = "♤8" Then
                n1 = 8
            ElseIf b34 = "♥9" Or b34 = "♦9" Or b34 = "♧9" Or b34 = "♤9" Then
                n1 = 9
            ElseIf b34 = "♥10" Or b34 = "♦10" Or b34 = "♧10" Or b34 = "♤10" Then
                n1 = 10
            ElseIf b34 = "♥11" Or b34 = "♦11" Or b34 = "♧11" Or b34 = "♤11" Then
                n1 = 11
            ElseIf b34 = "♥12" Or b34 = "♦12" Or b34 = "♧12" Or b34 = "♤12" Then
                n1 = 12
            ElseIf b34 = "♥13" Or b34 = "♦13" Or b34 = "♧13" Or b34 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A34.Text = b34
            s2 = b34
            If b34 = "♥1" Or b34 = "♦1" Or b34 = "♧1" Or b34 = "♤1" Then
                n2 = 1
            ElseIf b34 = "♥2" Or b34 = "♦2" Or b34 = "♧2" Or b34 = "♤2" Then
                n2 = 2
            ElseIf b34 = "♥3" Or b34 = "♦3" Or b34 = "♧3" Or b34 = "♤3" Then
                n2 = 3
            ElseIf b34 = "♥4" Or b34 = "♦4" Or b34 = "♧4" Or b34 = "♤4" Then
                n2 = 4
            ElseIf b34 = "♥5" Or b34 = "♦5" Or b34 = "♧5" Or b34 = "♤5" Then
                n2 = 5
            ElseIf b34 = "♥6" Or b34 = "♦6" Or b34 = "♧6" Or b34 = "♤6" Then
                n2 = 6
            ElseIf b34 = "♥7" Or b34 = "♦7" Or b34 = "♧7" Or b34 = "♤7" Then
                n2 = 7
            ElseIf b34 = "♥8" Or b34 = "♦8" Or b34 = "♧8" Or b34 = "♤8" Then
                n2 = 8
            ElseIf b34 = "♥9" Or b34 = "♦9" Or b34 = "♧9" Or b34 = "♤9" Then
                n2 = 9
            ElseIf b34 = "♥10" Or b34 = "♦10" Or b34 = "♧10" Or b34 = "♤10" Then
                n2 = 10
            ElseIf b34 = "♥11" Or b34 = "♦11" Or b34 = "♧11" Or b34 = "♤11" Then
                n2 = 11
            ElseIf b34 = "♥12" Or b34 = "♦12" Or b34 = "♧12" Or b34 = "♤12" Then
                n2 = 12
            ElseIf b34 = "♥13" Or b34 = "♦13" Or b34 = "♧13" Or b34 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A35_Click(sender As Object, e As EventArgs) Handles A35.Click
        If sn = 1 Then
            A35.Enabled = False
            A35.Text = b35
            s1 = b35
            If b35 = "♥1" Or b35 = "♦1" Or b35 = "♧1" Or b35 = "♤1" Then
                n1 = 1
            ElseIf b35 = "♥2" Or b35 = "♦2" Or b35 = "♧2" Or b35 = "♤2" Then
                n1 = 2
            ElseIf b35 = "♥3" Or b35 = "♦3" Or b35 = "♧3" Or b35 = "♤3" Then
                n1 = 3
            ElseIf b35 = "♥4" Or b35 = "♦4" Or b35 = "♧4" Or b35 = "♤4" Then
                n1 = 4
            ElseIf b35 = "♥5" Or b35 = "♦5" Or b35 = "♧5" Or b35 = "♤5" Then
                n1 = 5
            ElseIf b35 = "♥6" Or b35 = "♦6" Or b35 = "♧6" Or b35 = "♤6" Then
                n1 = 6
            ElseIf b35 = "♥7" Or b35 = "♦7" Or b35 = "♧7" Or b35 = "♤7" Then
                n1 = 7
            ElseIf b35 = "♥8" Or b35 = "♦8" Or b35 = "♧8" Or b35 = "♤8" Then
                n1 = 8
            ElseIf b35 = "♥9" Or b35 = "♦9" Or b35 = "♧9" Or b35 = "♤9" Then
                n1 = 9
            ElseIf b35 = "♥10" Or b35 = "♦10" Or b35 = "♧10" Or b35 = "♤10" Then
                n1 = 10
            ElseIf b35 = "♥11" Or b35 = "♦11" Or b35 = "♧11" Or b35 = "♤11" Then
                n1 = 11
            ElseIf b35 = "♥12" Or b35 = "♦12" Or b35 = "♧12" Or b35 = "♤12" Then
                n1 = 12
            ElseIf b35 = "♥13" Or b35 = "♦13" Or b35 = "♧13" Or b35 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A35.Text = b35
            s2 = b35
            If b35 = "♥1" Or b35 = "♦1" Or b35 = "♧1" Or b35 = "♤1" Then
                n2 = 1
            ElseIf b35 = "♥2" Or b35 = "♦2" Or b35 = "♧2" Or b35 = "♤2" Then
                n2 = 2
            ElseIf b35 = "♥3" Or b35 = "♦3" Or b35 = "♧3" Or b35 = "♤3" Then
                n2 = 3
            ElseIf b35 = "♥4" Or b35 = "♦4" Or b35 = "♧4" Or b35 = "♤4" Then
                n2 = 4
            ElseIf b35 = "♥5" Or b35 = "♦5" Or b35 = "♧5" Or b35 = "♤5" Then
                n2 = 5
            ElseIf b35 = "♥6" Or b35 = "♦6" Or b35 = "♧6" Or b35 = "♤6" Then
                n2 = 6
            ElseIf b35 = "♥7" Or b35 = "♦7" Or b35 = "♧7" Or b35 = "♤7" Then
                n2 = 7
            ElseIf b35 = "♥8" Or b35 = "♦8" Or b35 = "♧8" Or b35 = "♤8" Then
                n2 = 8
            ElseIf b35 = "♥9" Or b35 = "♦9" Or b35 = "♧9" Or b35 = "♤9" Then
                n2 = 9
            ElseIf b35 = "♥10" Or b35 = "♦10" Or b35 = "♧10" Or b35 = "♤10" Then
                n2 = 10
            ElseIf b35 = "♥11" Or b35 = "♦11" Or b35 = "♧11" Or b35 = "♤11" Then
                n2 = 11
            ElseIf b35 = "♥12" Or b35 = "♦12" Or b35 = "♧12" Or b35 = "♤12" Then
                n2 = 12
            ElseIf b35 = "♥13" Or b35 = "♦13" Or b35 = "♧13" Or b35 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A36_Click(sender As Object, e As EventArgs) Handles A36.Click
        If sn = 1 Then
            A36.Enabled = False
            A36.Text = b36
            s1 = b36
            If b36 = "♥1" Or b36 = "♦1" Or b36 = "♧1" Or b36 = "♤1" Then
                n1 = 1
            ElseIf b36 = "♥2" Or b36 = "♦2" Or b36 = "♧2" Or b36 = "♤2" Then
                n1 = 2
            ElseIf b36 = "♥3" Or b36 = "♦3" Or b36 = "♧3" Or b36 = "♤3" Then
                n1 = 3
            ElseIf b36 = "♥4" Or b36 = "♦4" Or b36 = "♧4" Or b36 = "♤4" Then
                n1 = 4
            ElseIf b36 = "♥5" Or b36 = "♦5" Or b36 = "♧5" Or b36 = "♤5" Then
                n1 = 5
            ElseIf b36 = "♥6" Or b36 = "♦6" Or b36 = "♧6" Or b36 = "♤6" Then
                n1 = 6
            ElseIf b36 = "♥7" Or b36 = "♦7" Or b36 = "♧7" Or b36 = "♤7" Then
                n1 = 7
            ElseIf b36 = "♥8" Or b36 = "♦8" Or b36 = "♧8" Or b36 = "♤8" Then
                n1 = 8
            ElseIf b36 = "♥9" Or b36 = "♦9" Or b36 = "♧9" Or b36 = "♤9" Then
                n1 = 9
            ElseIf b36 = "♥10" Or b36 = "♦10" Or b36 = "♧10" Or b36 = "♤10" Then
                n1 = 10
            ElseIf b36 = "♥11" Or b36 = "♦11" Or b36 = "♧11" Or b36 = "♤11" Then
                n1 = 11
            ElseIf b36 = "♥12" Or b36 = "♦12" Or b36 = "♧12" Or b36 = "♤12" Then
                n1 = 12
            ElseIf b36 = "♥13" Or b36 = "♦13" Or b36 = "♧13" Or b36 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A36.Text = b36
            s2 = b36
            If b36 = "♥1" Or b36 = "♦1" Or b36 = "♧1" Or b36 = "♤1" Then
                n2 = 1
            ElseIf b36 = "♥2" Or b36 = "♦2" Or b36 = "♧2" Or b36 = "♤2" Then
                n2 = 2
            ElseIf b36 = "♥3" Or b36 = "♦3" Or b36 = "♧3" Or b36 = "♤3" Then
                n2 = 3
            ElseIf b36 = "♥4" Or b36 = "♦4" Or b36 = "♧4" Or b36 = "♤4" Then
                n2 = 4
            ElseIf b36 = "♥5" Or b36 = "♦5" Or b36 = "♧5" Or b36 = "♤5" Then
                n2 = 5
            ElseIf b36 = "♥6" Or b36 = "♦6" Or b36 = "♧6" Or b36 = "♤6" Then
                n2 = 6
            ElseIf b36 = "♥7" Or b36 = "♦7" Or b36 = "♧7" Or b36 = "♤7" Then
                n2 = 7
            ElseIf b36 = "♥8" Or b36 = "♦8" Or b36 = "♧8" Or b36 = "♤8" Then
                n2 = 8
            ElseIf b36 = "♥9" Or b36 = "♦9" Or b36 = "♧9" Or b36 = "♤9" Then
                n2 = 9
            ElseIf b36 = "♥10" Or b36 = "♦10" Or b36 = "♧10" Or b36 = "♤10" Then
                n2 = 10
            ElseIf b36 = "♥11" Or b36 = "♦11" Or b36 = "♧11" Or b36 = "♤11" Then
                n2 = 11
            ElseIf b36 = "♥12" Or b36 = "♦12" Or b36 = "♧12" Or b36 = "♤12" Then
                n2 = 12
            ElseIf b36 = "♥13" Or b36 = "♦13" Or b36 = "♧13" Or b36 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A37_Click(sender As Object, e As EventArgs) Handles A37.Click
        If sn = 1 Then
            A37.Enabled = False
            A37.Text = b37
            s1 = b37
            If b37 = "♥1" Or b37 = "♦1" Or b37 = "♧1" Or b37 = "♤1" Then
                n1 = 1
            ElseIf b37 = "♥2" Or b37 = "♦2" Or b37 = "♧2" Or b37 = "♤2" Then
                n1 = 2
            ElseIf b37 = "♥3" Or b37 = "♦3" Or b37 = "♧3" Or b37 = "♤3" Then
                n1 = 3
            ElseIf b37 = "♥4" Or b37 = "♦4" Or b37 = "♧4" Or b37 = "♤4" Then
                n1 = 4
            ElseIf b37 = "♥5" Or b37 = "♦5" Or b37 = "♧5" Or b37 = "♤5" Then
                n1 = 5
            ElseIf b37 = "♥6" Or b37 = "♦6" Or b37 = "♧6" Or b37 = "♤6" Then
                n1 = 6
            ElseIf b37 = "♥7" Or b37 = "♦7" Or b37 = "♧7" Or b37 = "♤7" Then
                n1 = 7
            ElseIf b37 = "♥8" Or b37 = "♦8" Or b37 = "♧8" Or b37 = "♤8" Then
                n1 = 8
            ElseIf b37 = "♥9" Or b37 = "♦9" Or b37 = "♧9" Or b37 = "♤9" Then
                n1 = 9
            ElseIf b37 = "♥10" Or b37 = "♦10" Or b37 = "♧10" Or b37 = "♤10" Then
                n1 = 10
            ElseIf b37 = "♥11" Or b37 = "♦11" Or b37 = "♧11" Or b37 = "♤11" Then
                n1 = 11
            ElseIf b37 = "♥12" Or b37 = "♦12" Or b37 = "♧12" Or b37 = "♤12" Then
                n1 = 12
            ElseIf b37 = "♥13" Or b37 = "♦13" Or b37 = "♧13" Or b37 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A37.Text = b37
            s2 = b37
            If b37 = "♥1" Or b37 = "♦1" Or b37 = "♧1" Or b37 = "♤1" Then
                n2 = 1
            ElseIf b37 = "♥2" Or b37 = "♦2" Or b37 = "♧2" Or b37 = "♤2" Then
                n2 = 2
            ElseIf b37 = "♥3" Or b37 = "♦3" Or b37 = "♧3" Or b37 = "♤3" Then
                n2 = 3
            ElseIf b37 = "♥4" Or b37 = "♦4" Or b37 = "♧4" Or b37 = "♤4" Then
                n2 = 4
            ElseIf b37 = "♥5" Or b37 = "♦5" Or b37 = "♧5" Or b37 = "♤5" Then
                n2 = 5
            ElseIf b37 = "♥6" Or b37 = "♦6" Or b37 = "♧6" Or b37 = "♤6" Then
                n2 = 6
            ElseIf b37 = "♥7" Or b37 = "♦7" Or b37 = "♧7" Or b37 = "♤7" Then
                n2 = 7
            ElseIf b37 = "♥8" Or b37 = "♦8" Or b37 = "♧8" Or b37 = "♤8" Then
                n2 = 8
            ElseIf b37 = "♥9" Or b37 = "♦9" Or b37 = "♧9" Or b37 = "♤9" Then
                n2 = 9
            ElseIf b37 = "♥10" Or b37 = "♦10" Or b37 = "♧10" Or b37 = "♤10" Then
                n2 = 10
            ElseIf b37 = "♥11" Or b37 = "♦11" Or b37 = "♧11" Or b37 = "♤11" Then
                n2 = 11
            ElseIf b37 = "♥12" Or b37 = "♦12" Or b37 = "♧12" Or b37 = "♤12" Then
                n2 = 12
            ElseIf b37 = "♥13" Or b37 = "♦13" Or b37 = "♧13" Or b37 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A38_Click(sender As Object, e As EventArgs) Handles A38.Click
        If sn = 1 Then
            A38.Enabled = False
            A38.Text = b38
            s1 = b38
            If b38 = "♥1" Or b38 = "♦1" Or b38 = "♧1" Or b38 = "♤1" Then
                n1 = 1
            ElseIf b38 = "♥2" Or b38 = "♦2" Or b38 = "♧2" Or b38 = "♤2" Then
                n1 = 2
            ElseIf b38 = "♥3" Or b38 = "♦3" Or b38 = "♧3" Or b38 = "♤3" Then
                n1 = 3
            ElseIf b38 = "♥4" Or b38 = "♦4" Or b38 = "♧4" Or b38 = "♤4" Then
                n1 = 4
            ElseIf b38 = "♥5" Or b38 = "♦5" Or b38 = "♧5" Or b38 = "♤5" Then
                n1 = 5
            ElseIf b38 = "♥6" Or b38 = "♦6" Or b38 = "♧6" Or b38 = "♤6" Then
                n1 = 6
            ElseIf b38 = "♥7" Or b38 = "♦7" Or b38 = "♧7" Or b38 = "♤7" Then
                n1 = 7
            ElseIf b38 = "♥8" Or b38 = "♦8" Or b38 = "♧8" Or b38 = "♤8" Then
                n1 = 8
            ElseIf b38 = "♥9" Or b38 = "♦9" Or b38 = "♧9" Or b38 = "♤9" Then
                n1 = 9
            ElseIf b38 = "♥10" Or b38 = "♦10" Or b38 = "♧10" Or b38 = "♤10" Then
                n1 = 10
            ElseIf b38 = "♥11" Or b38 = "♦11" Or b38 = "♧11" Or b38 = "♤11" Then
                n1 = 11
            ElseIf b38 = "♥12" Or b38 = "♦12" Or b38 = "♧12" Or b38 = "♤12" Then
                n1 = 12
            ElseIf b38 = "♥13" Or b38 = "♦13" Or b38 = "♧13" Or b38 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A38.Text = b38
            s2 = b38
            If b38 = "♥1" Or b38 = "♦1" Or b38 = "♧1" Or b38 = "♤1" Then
                n2 = 1
            ElseIf b38 = "♥2" Or b38 = "♦2" Or b38 = "♧2" Or b38 = "♤2" Then
                n2 = 2
            ElseIf b38 = "♥3" Or b38 = "♦3" Or b38 = "♧3" Or b38 = "♤3" Then
                n2 = 3
            ElseIf b38 = "♥4" Or b38 = "♦4" Or b38 = "♧4" Or b38 = "♤4" Then
                n2 = 4
            ElseIf b38 = "♥5" Or b38 = "♦5" Or b38 = "♧5" Or b38 = "♤5" Then
                n2 = 5
            ElseIf b38 = "♥6" Or b38 = "♦6" Or b38 = "♧6" Or b38 = "♤6" Then
                n2 = 6
            ElseIf b38 = "♥7" Or b38 = "♦7" Or b38 = "♧7" Or b38 = "♤7" Then
                n2 = 7
            ElseIf b38 = "♥8" Or b38 = "♦8" Or b38 = "♧8" Or b38 = "♤8" Then
                n2 = 8
            ElseIf b38 = "♥9" Or b38 = "♦9" Or b38 = "♧9" Or b38 = "♤9" Then
                n2 = 9
            ElseIf b38 = "♥10" Or b38 = "♦10" Or b38 = "♧10" Or b38 = "♤10" Then
                n2 = 10
            ElseIf b38 = "♥11" Or b38 = "♦11" Or b38 = "♧11" Or b38 = "♤11" Then
                n2 = 11
            ElseIf b38 = "♥12" Or b38 = "♦12" Or b38 = "♧12" Or b38 = "♤12" Then
                n2 = 12
            ElseIf b38 = "♥13" Or b38 = "♦13" Or b38 = "♧13" Or b38 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A39_Click(sender As Object, e As EventArgs) Handles A39.Click
        If sn = 1 Then
            A39.Enabled = False
            A39.Text = b39
            s1 = b39
            If b39 = "♥1" Or b39 = "♦1" Or b39 = "♧1" Or b39 = "♤1" Then
                n1 = 1
            ElseIf b39 = "♥2" Or b39 = "♦2" Or b39 = "♧2" Or b39 = "♤2" Then
                n1 = 2
            ElseIf b39 = "♥3" Or b39 = "♦3" Or b39 = "♧3" Or b39 = "♤3" Then
                n1 = 3
            ElseIf b39 = "♥4" Or b39 = "♦4" Or b39 = "♧4" Or b39 = "♤4" Then
                n1 = 4
            ElseIf b39 = "♥5" Or b39 = "♦5" Or b39 = "♧5" Or b39 = "♤5" Then
                n1 = 5
            ElseIf b39 = "♥6" Or b39 = "♦6" Or b39 = "♧6" Or b39 = "♤6" Then
                n1 = 6
            ElseIf b39 = "♥7" Or b39 = "♦7" Or b39 = "♧7" Or b39 = "♤7" Then
                n1 = 7
            ElseIf b39 = "♥8" Or b39 = "♦8" Or b39 = "♧8" Or b39 = "♤8" Then
                n1 = 8
            ElseIf b39 = "♥9" Or b39 = "♦9" Or b39 = "♧9" Or b39 = "♤9" Then
                n1 = 9
            ElseIf b39 = "♥10" Or b39 = "♦10" Or b39 = "♧10" Or b39 = "♤10" Then
                n1 = 10
            ElseIf b39 = "♥11" Or b39 = "♦11" Or b39 = "♧11" Or b39 = "♤11" Then
                n1 = 11
            ElseIf b39 = "♥12" Or b39 = "♦12" Or b39 = "♧12" Or b39 = "♤12" Then
                n1 = 12
            ElseIf b39 = "♥13" Or b39 = "♦13" Or b39 = "♧13" Or b39 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A39.Text = b39
            s2 = b39
            If b39 = "♥1" Or b39 = "♦1" Or b39 = "♧1" Or b39 = "♤1" Then
                n2 = 1
            ElseIf b39 = "♥2" Or b39 = "♦2" Or b39 = "♧2" Or b39 = "♤2" Then
                n2 = 2
            ElseIf b39 = "♥3" Or b39 = "♦3" Or b39 = "♧3" Or b39 = "♤3" Then
                n2 = 3
            ElseIf b39 = "♥4" Or b39 = "♦4" Or b39 = "♧4" Or b39 = "♤4" Then
                n2 = 4
            ElseIf b39 = "♥5" Or b39 = "♦5" Or b39 = "♧5" Or b39 = "♤5" Then
                n2 = 5
            ElseIf b39 = "♥6" Or b39 = "♦6" Or b39 = "♧6" Or b39 = "♤6" Then
                n2 = 6
            ElseIf b39 = "♥7" Or b39 = "♦7" Or b39 = "♧7" Or b39 = "♤7" Then
                n2 = 7
            ElseIf b39 = "♥8" Or b39 = "♦8" Or b39 = "♧8" Or b39 = "♤8" Then
                n2 = 8
            ElseIf b39 = "♥9" Or b39 = "♦9" Or b39 = "♧9" Or b39 = "♤9" Then
                n2 = 9
            ElseIf b39 = "♥10" Or b39 = "♦10" Or b39 = "♧10" Or b39 = "♤10" Then
                n2 = 10
            ElseIf b39 = "♥11" Or b39 = "♦11" Or b39 = "♧11" Or b39 = "♤11" Then
                n2 = 11
            ElseIf b39 = "♥12" Or b39 = "♦12" Or b39 = "♧12" Or b39 = "♤12" Then
                n2 = 12
            ElseIf b39 = "♥13" Or b39 = "♦13" Or b39 = "♧13" Or b39 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A40_Click(sender As Object, e As EventArgs) Handles A40.Click
        If sn = 1 Then
            A40.Enabled = False
            A40.Text = b40
            s1 = b40
            If b40 = "♥1" Or b40 = "♦1" Or b40 = "♧1" Or b40 = "♤1" Then
                n1 = 1
            ElseIf b40 = "♥2" Or b40 = "♦2" Or b40 = "♧2" Or b40 = "♤2" Then
                n1 = 2
            ElseIf b40 = "♥3" Or b40 = "♦3" Or b40 = "♧3" Or b40 = "♤3" Then
                n1 = 3
            ElseIf b40 = "♥4" Or b40 = "♦4" Or b40 = "♧4" Or b40 = "♤4" Then
                n1 = 4
            ElseIf b40 = "♥5" Or b40 = "♦5" Or b40 = "♧5" Or b40 = "♤5" Then
                n1 = 5
            ElseIf b40 = "♥6" Or b40 = "♦6" Or b40 = "♧6" Or b40 = "♤6" Then
                n1 = 6
            ElseIf b40 = "♥7" Or b40 = "♦7" Or b40 = "♧7" Or b40 = "♤7" Then
                n1 = 7
            ElseIf b40 = "♥8" Or b40 = "♦8" Or b40 = "♧8" Or b40 = "♤8" Then
                n1 = 8
            ElseIf b40 = "♥9" Or b40 = "♦9" Or b40 = "♧9" Or b40 = "♤9" Then
                n1 = 9
            ElseIf b40 = "♥10" Or b40 = "♦10" Or b40 = "♧10" Or b40 = "♤10" Then
                n1 = 10
            ElseIf b40 = "♥11" Or b40 = "♦11" Or b40 = "♧11" Or b40 = "♤11" Then
                n1 = 11
            ElseIf b40 = "♥12" Or b40 = "♦12" Or b40 = "♧12" Or b40 = "♤12" Then
                n1 = 12
            ElseIf b40 = "♥13" Or b40 = "♦13" Or b40 = "♧13" Or b40 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A40.Text = b40
            s2 = b40
            If b40 = "♥1" Or b40 = "♦1" Or b40 = "♧1" Or b40 = "♤1" Then
                n2 = 1
            ElseIf b40 = "♥2" Or b40 = "♦2" Or b40 = "♧2" Or b40 = "♤2" Then
                n2 = 2
            ElseIf b40 = "♥3" Or b40 = "♦3" Or b40 = "♧3" Or b40 = "♤3" Then
                n2 = 3
            ElseIf b40 = "♥4" Or b40 = "♦4" Or b40 = "♧4" Or b40 = "♤4" Then
                n2 = 4
            ElseIf b40 = "♥5" Or b40 = "♦5" Or b40 = "♧5" Or b40 = "♤5" Then
                n2 = 5
            ElseIf b40 = "♥6" Or b40 = "♦6" Or b40 = "♧6" Or b40 = "♤6" Then
                n2 = 6
            ElseIf b40 = "♥7" Or b40 = "♦7" Or b40 = "♧7" Or b40 = "♤7" Then
                n2 = 7
            ElseIf b40 = "♥8" Or b40 = "♦8" Or b40 = "♧8" Or b40 = "♤8" Then
                n2 = 8
            ElseIf b40 = "♥9" Or b40 = "♦9" Or b40 = "♧9" Or b40 = "♤9" Then
                n2 = 9
            ElseIf b40 = "♥10" Or b40 = "♦10" Or b40 = "♧10" Or b40 = "♤10" Then
                n2 = 10
            ElseIf b40 = "♥11" Or b40 = "♦11" Or b40 = "♧11" Or b40 = "♤11" Then
                n2 = 11
            ElseIf b40 = "♥12" Or b40 = "♦12" Or b40 = "♧12" Or b40 = "♤12" Then
                n2 = 12
            ElseIf b40 = "♥13" Or b40 = "♦13" Or b40 = "♧13" Or b40 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A41_Click(sender As Object, e As EventArgs) Handles A41.Click
        If sn = 1 Then
            A41.Enabled = False
            A41.Text = b41
            s1 = b41
            If b41 = "♥1" Or b41 = "♦1" Or b41 = "♧1" Or b41 = "♤1" Then
                n1 = 1
            ElseIf b41 = "♥2" Or b41 = "♦2" Or b41 = "♧2" Or b41 = "♤2" Then
                n1 = 2
            ElseIf b41 = "♥3" Or b41 = "♦3" Or b41 = "♧3" Or b41 = "♤3" Then
                n1 = 3
            ElseIf b41 = "♥4" Or b41 = "♦4" Or b41 = "♧4" Or b41 = "♤4" Then
                n1 = 4
            ElseIf b41 = "♥5" Or b41 = "♦5" Or b41 = "♧5" Or b41 = "♤5" Then
                n1 = 5
            ElseIf b41 = "♥6" Or b41 = "♦6" Or b41 = "♧6" Or b41 = "♤6" Then
                n1 = 6
            ElseIf b41 = "♥7" Or b41 = "♦7" Or b41 = "♧7" Or b41 = "♤7" Then
                n1 = 7
            ElseIf b41 = "♥8" Or b41 = "♦8" Or b41 = "♧8" Or b41 = "♤8" Then
                n1 = 8
            ElseIf b41 = "♥9" Or b41 = "♦9" Or b41 = "♧9" Or b41 = "♤9" Then
                n1 = 9
            ElseIf b41 = "♥10" Or b41 = "♦10" Or b41 = "♧10" Or b41 = "♤10" Then
                n1 = 10
            ElseIf b41 = "♥11" Or b41 = "♦11" Or b41 = "♧11" Or b41 = "♤11" Then
                n1 = 11
            ElseIf b41 = "♥12" Or b41 = "♦12" Or b41 = "♧12" Or b41 = "♤12" Then
                n1 = 12
            ElseIf b41 = "♥13" Or b41 = "♦13" Or b41 = "♧13" Or b41 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A41.Text = b41
            s2 = b41
            If b41 = "♥1" Or b41 = "♦1" Or b41 = "♧1" Or b41 = "♤1" Then
                n2 = 1
            ElseIf b41 = "♥2" Or b41 = "♦2" Or b41 = "♧2" Or b41 = "♤2" Then
                n2 = 2
            ElseIf b41 = "♥3" Or b41 = "♦3" Or b41 = "♧3" Or b41 = "♤3" Then
                n2 = 3
            ElseIf b41 = "♥4" Or b41 = "♦4" Or b41 = "♧4" Or b41 = "♤4" Then
                n2 = 4
            ElseIf b41 = "♥5" Or b41 = "♦5" Or b41 = "♧5" Or b41 = "♤5" Then
                n2 = 5
            ElseIf b41 = "♥6" Or b41 = "♦6" Or b41 = "♧6" Or b41 = "♤6" Then
                n2 = 6
            ElseIf b41 = "♥7" Or b41 = "♦7" Or b41 = "♧7" Or b41 = "♤7" Then
                n2 = 7
            ElseIf b41 = "♥8" Or b41 = "♦8" Or b41 = "♧8" Or b41 = "♤8" Then
                n2 = 8
            ElseIf b41 = "♥9" Or b41 = "♦9" Or b41 = "♧9" Or b41 = "♤9" Then
                n2 = 9
            ElseIf b41 = "♥10" Or b41 = "♦10" Or b41 = "♧10" Or b41 = "♤10" Then
                n2 = 10
            ElseIf b41 = "♥11" Or b41 = "♦11" Or b41 = "♧11" Or b41 = "♤11" Then
                n2 = 11
            ElseIf b41 = "♥12" Or b41 = "♦12" Or b41 = "♧12" Or b41 = "♤12" Then
                n2 = 12
            ElseIf b41 = "♥13" Or b41 = "♦13" Or b41 = "♧13" Or b41 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A42_Click(sender As Object, e As EventArgs) Handles A42.Click
        If sn = 1 Then
            A42.Enabled = False
            A42.Text = b42
            s1 = b42
            If b42 = "♥1" Or b42 = "♦1" Or b42 = "♧1" Or b42 = "♤1" Then
                n1 = 1
            ElseIf b42 = "♥2" Or b42 = "♦2" Or b42 = "♧2" Or b42 = "♤2" Then
                n1 = 2
            ElseIf b42 = "♥3" Or b42 = "♦3" Or b42 = "♧3" Or b42 = "♤3" Then
                n1 = 3
            ElseIf b42 = "♥4" Or b42 = "♦4" Or b42 = "♧4" Or b42 = "♤4" Then
                n1 = 4
            ElseIf b42 = "♥5" Or b42 = "♦5" Or b42 = "♧5" Or b42 = "♤5" Then
                n1 = 5
            ElseIf b42 = "♥6" Or b42 = "♦6" Or b42 = "♧6" Or b42 = "♤6" Then
                n1 = 6
            ElseIf b42 = "♥7" Or b42 = "♦7" Or b42 = "♧7" Or b42 = "♤7" Then
                n1 = 7
            ElseIf b42 = "♥8" Or b42 = "♦8" Or b42 = "♧8" Or b42 = "♤8" Then
                n1 = 8
            ElseIf b42 = "♥9" Or b42 = "♦9" Or b42 = "♧9" Or b42 = "♤9" Then
                n1 = 9
            ElseIf b42 = "♥10" Or b42 = "♦10" Or b42 = "♧10" Or b42 = "♤10" Then
                n1 = 10
            ElseIf b42 = "♥11" Or b42 = "♦11" Or b42 = "♧11" Or b42 = "♤11" Then
                n1 = 11
            ElseIf b42 = "♥12" Or b42 = "♦12" Or b42 = "♧12" Or b42 = "♤12" Then
                n1 = 12
            ElseIf b42 = "♥13" Or b42 = "♦13" Or b42 = "♧13" Or b42 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A42.Text = b42
            s2 = b42
            If b42 = "♥1" Or b42 = "♦1" Or b42 = "♧1" Or b42 = "♤1" Then
                n2 = 1
            ElseIf b42 = "♥2" Or b42 = "♦2" Or b42 = "♧2" Or b42 = "♤2" Then
                n2 = 2
            ElseIf b42 = "♥3" Or b42 = "♦3" Or b42 = "♧3" Or b42 = "♤3" Then
                n2 = 3
            ElseIf b42 = "♥4" Or b42 = "♦4" Or b42 = "♧4" Or b42 = "♤4" Then
                n2 = 4
            ElseIf b42 = "♥5" Or b42 = "♦5" Or b42 = "♧5" Or b42 = "♤5" Then
                n2 = 5
            ElseIf b42 = "♥6" Or b42 = "♦6" Or b42 = "♧6" Or b42 = "♤6" Then
                n2 = 6
            ElseIf b42 = "♥7" Or b42 = "♦7" Or b42 = "♧7" Or b42 = "♤7" Then
                n2 = 7
            ElseIf b42 = "♥8" Or b42 = "♦8" Or b42 = "♧8" Or b42 = "♤8" Then
                n2 = 8
            ElseIf b42 = "♥9" Or b42 = "♦9" Or b42 = "♧9" Or b42 = "♤9" Then
                n2 = 9
            ElseIf b42 = "♥10" Or b42 = "♦10" Or b42 = "♧10" Or b42 = "♤10" Then
                n2 = 10
            ElseIf b42 = "♥11" Or b42 = "♦11" Or b42 = "♧11" Or b42 = "♤11" Then
                n2 = 11
            ElseIf b42 = "♥12" Or b42 = "♦12" Or b42 = "♧12" Or b42 = "♤12" Then
                n2 = 12
            ElseIf b42 = "♥13" Or b42 = "♦13" Or b42 = "♧13" Or b42 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A43_Click(sender As Object, e As EventArgs) Handles A43.Click
        If sn = 1 Then
            A43.Enabled = False
            A43.Text = b43
            s1 = b43
            If b43 = "♥1" Or b43 = "♦1" Or b43 = "♧1" Or b43 = "♤1" Then
                n1 = 1
            ElseIf b43 = "♥2" Or b43 = "♦2" Or b43 = "♧2" Or b43 = "♤2" Then
                n1 = 2
            ElseIf b43 = "♥3" Or b43 = "♦3" Or b43 = "♧3" Or b43 = "♤3" Then
                n1 = 3
            ElseIf b43 = "♥4" Or b43 = "♦4" Or b43 = "♧4" Or b43 = "♤4" Then
                n1 = 4
            ElseIf b43 = "♥5" Or b43 = "♦5" Or b43 = "♧5" Or b43 = "♤5" Then
                n1 = 5
            ElseIf b43 = "♥6" Or b43 = "♦6" Or b43 = "♧6" Or b43 = "♤6" Then
                n1 = 6
            ElseIf b43 = "♥7" Or b43 = "♦7" Or b43 = "♧7" Or b43 = "♤7" Then
                n1 = 7
            ElseIf b43 = "♥8" Or b43 = "♦8" Or b43 = "♧8" Or b43 = "♤8" Then
                n1 = 8
            ElseIf b43 = "♥9" Or b43 = "♦9" Or b43 = "♧9" Or b43 = "♤9" Then
                n1 = 9
            ElseIf b43 = "♥10" Or b43 = "♦10" Or b43 = "♧10" Or b43 = "♤10" Then
                n1 = 10
            ElseIf b43 = "♥11" Or b43 = "♦11" Or b43 = "♧11" Or b43 = "♤11" Then
                n1 = 11
            ElseIf b43 = "♥12" Or b43 = "♦12" Or b43 = "♧12" Or b43 = "♤12" Then
                n1 = 12
            ElseIf b43 = "♥13" Or b43 = "♦13" Or b43 = "♧13" Or b43 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A43.Text = b43
            s2 = b43
            If b43 = "♥1" Or b43 = "♦1" Or b43 = "♧1" Or b43 = "♤1" Then
                n2 = 1
            ElseIf b43 = "♥2" Or b43 = "♦2" Or b43 = "♧2" Or b43 = "♤2" Then
                n2 = 2
            ElseIf b43 = "♥3" Or b43 = "♦3" Or b43 = "♧3" Or b43 = "♤3" Then
                n2 = 3
            ElseIf b43 = "♥4" Or b43 = "♦4" Or b43 = "♧4" Or b43 = "♤4" Then
                n2 = 4
            ElseIf b43 = "♥5" Or b43 = "♦5" Or b43 = "♧5" Or b43 = "♤5" Then
                n2 = 5
            ElseIf b43 = "♥6" Or b43 = "♦6" Or b43 = "♧6" Or b43 = "♤6" Then
                n2 = 6
            ElseIf b43 = "♥7" Or b43 = "♦7" Or b43 = "♧7" Or b43 = "♤7" Then
                n2 = 7
            ElseIf b43 = "♥8" Or b43 = "♦8" Or b43 = "♧8" Or b43 = "♤8" Then
                n2 = 8
            ElseIf b43 = "♥9" Or b43 = "♦9" Or b43 = "♧9" Or b43 = "♤9" Then
                n2 = 9
            ElseIf b43 = "♥10" Or b43 = "♦10" Or b43 = "♧10" Or b43 = "♤10" Then
                n2 = 10
            ElseIf b43 = "♥11" Or b43 = "♦11" Or b43 = "♧11" Or b43 = "♤11" Then
                n2 = 11
            ElseIf b43 = "♥12" Or b43 = "♦12" Or b43 = "♧12" Or b43 = "♤12" Then
                n2 = 12
            ElseIf b43 = "♥13" Or b43 = "♦13" Or b43 = "♧13" Or b43 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A44_Click(sender As Object, e As EventArgs) Handles A44.Click
        If sn = 1 Then
            A44.Enabled = False
            A44.Text = b44
            s1 = b44
            If b44 = "♥1" Or b44 = "♦1" Or b44 = "♧1" Or b44 = "♤1" Then
                n1 = 1
            ElseIf b44 = "♥2" Or b44 = "♦2" Or b44 = "♧2" Or b44 = "♤2" Then
                n1 = 2
            ElseIf b44 = "♥3" Or b44 = "♦3" Or b44 = "♧3" Or b44 = "♤3" Then
                n1 = 3
            ElseIf b44 = "♥4" Or b44 = "♦4" Or b44 = "♧4" Or b44 = "♤4" Then
                n1 = 4
            ElseIf b44 = "♥5" Or b44 = "♦5" Or b44 = "♧5" Or b44 = "♤5" Then
                n1 = 5
            ElseIf b44 = "♥6" Or b44 = "♦6" Or b44 = "♧6" Or b44 = "♤6" Then
                n1 = 6
            ElseIf b44 = "♥7" Or b44 = "♦7" Or b44 = "♧7" Or b44 = "♤7" Then
                n1 = 7
            ElseIf b44 = "♥8" Or b44 = "♦8" Or b44 = "♧8" Or b44 = "♤8" Then
                n1 = 8
            ElseIf b44 = "♥9" Or b44 = "♦9" Or b44 = "♧9" Or b44 = "♤9" Then
                n1 = 9
            ElseIf b44 = "♥10" Or b44 = "♦10" Or b44 = "♧10" Or b44 = "♤10" Then
                n1 = 10
            ElseIf b44 = "♥11" Or b44 = "♦11" Or b44 = "♧11" Or b44 = "♤11" Then
                n1 = 11
            ElseIf b44 = "♥12" Or b44 = "♦12" Or b44 = "♧12" Or b44 = "♤12" Then
                n1 = 12
            ElseIf b44 = "♥13" Or b44 = "♦13" Or b44 = "♧13" Or b44 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A44.Text = b44
            s2 = b44
            If b44 = "♥1" Or b44 = "♦1" Or b44 = "♧1" Or b44 = "♤1" Then
                n2 = 1
            ElseIf b44 = "♥2" Or b44 = "♦2" Or b44 = "♧2" Or b44 = "♤2" Then
                n2 = 2
            ElseIf b44 = "♥3" Or b44 = "♦3" Or b44 = "♧3" Or b44 = "♤3" Then
                n2 = 3
            ElseIf b44 = "♥4" Or b44 = "♦4" Or b44 = "♧4" Or b44 = "♤4" Then
                n2 = 4
            ElseIf b44 = "♥5" Or b44 = "♦5" Or b44 = "♧5" Or b44 = "♤5" Then
                n2 = 5
            ElseIf b44 = "♥6" Or b44 = "♦6" Or b44 = "♧6" Or b44 = "♤6" Then
                n2 = 6
            ElseIf b44 = "♥7" Or b44 = "♦7" Or b44 = "♧7" Or b44 = "♤7" Then
                n2 = 7
            ElseIf b44 = "♥8" Or b44 = "♦8" Or b44 = "♧8" Or b44 = "♤8" Then
                n2 = 8
            ElseIf b44 = "♥9" Or b44 = "♦9" Or b44 = "♧9" Or b44 = "♤9" Then
                n2 = 9
            ElseIf b44 = "♥10" Or b44 = "♦10" Or b44 = "♧10" Or b44 = "♤10" Then
                n2 = 10
            ElseIf b44 = "♥11" Or b44 = "♦11" Or b44 = "♧11" Or b44 = "♤11" Then
                n2 = 11
            ElseIf b44 = "♥12" Or b44 = "♦12" Or b44 = "♧12" Or b44 = "♤12" Then
                n2 = 12
            ElseIf b44 = "♥13" Or b44 = "♦13" Or b44 = "♧13" Or b44 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A45_Click(sender As Object, e As EventArgs) Handles A45.Click
        If sn = 1 Then
            A45.Enabled = False
            A45.Text = b45
            s1 = b45
            If b45 = "♥1" Or b45 = "♦1" Or b45 = "♧1" Or b45 = "♤1" Then
                n1 = 1
            ElseIf b45 = "♥2" Or b45 = "♦2" Or b45 = "♧2" Or b45 = "♤2" Then
                n1 = 2
            ElseIf b45 = "♥3" Or b45 = "♦3" Or b45 = "♧3" Or b45 = "♤3" Then
                n1 = 3
            ElseIf b45 = "♥4" Or b45 = "♦4" Or b45 = "♧4" Or b45 = "♤4" Then
                n1 = 4
            ElseIf b45 = "♥5" Or b45 = "♦5" Or b45 = "♧5" Or b45 = "♤5" Then
                n1 = 5
            ElseIf b45 = "♥6" Or b45 = "♦6" Or b45 = "♧6" Or b45 = "♤6" Then
                n1 = 6
            ElseIf b45 = "♥7" Or b45 = "♦7" Or b45 = "♧7" Or b45 = "♤7" Then
                n1 = 7
            ElseIf b45 = "♥8" Or b45 = "♦8" Or b45 = "♧8" Or b45 = "♤8" Then
                n1 = 8
            ElseIf b45 = "♥9" Or b45 = "♦9" Or b45 = "♧9" Or b45 = "♤9" Then
                n1 = 9
            ElseIf b45 = "♥10" Or b45 = "♦10" Or b45 = "♧10" Or b45 = "♤10" Then
                n1 = 10
            ElseIf b45 = "♥11" Or b45 = "♦11" Or b45 = "♧11" Or b45 = "♤11" Then
                n1 = 11
            ElseIf b45 = "♥12" Or b45 = "♦12" Or b45 = "♧12" Or b45 = "♤12" Then
                n1 = 12
            ElseIf b45 = "♥13" Or b45 = "♦13" Or b45 = "♧13" Or b45 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A45.Text = b45
            s2 = b45
            If b45 = "♥1" Or b45 = "♦1" Or b45 = "♧1" Or b45 = "♤1" Then
                n2 = 1
            ElseIf b45 = "♥2" Or b45 = "♦2" Or b45 = "♧2" Or b45 = "♤2" Then
                n2 = 2
            ElseIf b45 = "♥3" Or b45 = "♦3" Or b45 = "♧3" Or b45 = "♤3" Then
                n2 = 3
            ElseIf b45 = "♥4" Or b45 = "♦4" Or b45 = "♧4" Or b45 = "♤4" Then
                n2 = 4
            ElseIf b45 = "♥5" Or b45 = "♦5" Or b45 = "♧5" Or b45 = "♤5" Then
                n2 = 5
            ElseIf b45 = "♥6" Or b45 = "♦6" Or b45 = "♧6" Or b45 = "♤6" Then
                n2 = 6
            ElseIf b45 = "♥7" Or b45 = "♦7" Or b45 = "♧7" Or b45 = "♤7" Then
                n2 = 7
            ElseIf b45 = "♥8" Or b45 = "♦8" Or b45 = "♧8" Or b45 = "♤8" Then
                n2 = 8
            ElseIf b45 = "♥9" Or b45 = "♦9" Or b45 = "♧9" Or b45 = "♤9" Then
                n2 = 9
            ElseIf b45 = "♥10" Or b45 = "♦10" Or b45 = "♧10" Or b45 = "♤10" Then
                n2 = 10
            ElseIf b45 = "♥11" Or b45 = "♦11" Or b45 = "♧11" Or b45 = "♤11" Then
                n2 = 11
            ElseIf b45 = "♥12" Or b45 = "♦12" Or b45 = "♧12" Or b45 = "♤12" Then
                n2 = 12
            ElseIf b45 = "♥13" Or b45 = "♦13" Or b45 = "♧13" Or b45 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A46_Click(sender As Object, e As EventArgs) Handles A46.Click
        If sn = 1 Then
            A46.Enabled = False
            A46.Text = b46
            s1 = b46
            If b46 = "♥1" Or b46 = "♦1" Or b46 = "♧1" Or b46 = "♤1" Then
                n1 = 1
            ElseIf b46 = "♥2" Or b46 = "♦2" Or b46 = "♧2" Or b46 = "♤2" Then
                n1 = 2
            ElseIf b46 = "♥3" Or b46 = "♦3" Or b46 = "♧3" Or b46 = "♤3" Then
                n1 = 3
            ElseIf b46 = "♥4" Or b46 = "♦4" Or b46 = "♧4" Or b46 = "♤4" Then
                n1 = 4
            ElseIf b46 = "♥5" Or b46 = "♦5" Or b46 = "♧5" Or b46 = "♤5" Then
                n1 = 5
            ElseIf b46 = "♥6" Or b46 = "♦6" Or b46 = "♧6" Or b46 = "♤6" Then
                n1 = 6
            ElseIf b46 = "♥7" Or b46 = "♦7" Or b46 = "♧7" Or b46 = "♤7" Then
                n1 = 7
            ElseIf b46 = "♥8" Or b46 = "♦8" Or b46 = "♧8" Or b46 = "♤8" Then
                n1 = 8
            ElseIf b46 = "♥9" Or b46 = "♦9" Or b46 = "♧9" Or b46 = "♤9" Then
                n1 = 9
            ElseIf b46 = "♥10" Or b46 = "♦10" Or b46 = "♧10" Or b46 = "♤10" Then
                n1 = 10
            ElseIf b46 = "♥11" Or b46 = "♦11" Or b46 = "♧11" Or b46 = "♤11" Then
                n1 = 11
            ElseIf b46 = "♥12" Or b46 = "♦12" Or b46 = "♧12" Or b46 = "♤12" Then
                n1 = 12
            ElseIf b46 = "♥13" Or b46 = "♦13" Or b46 = "♧13" Or b46 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A46.Text = b46
            s2 = b46
            If b46 = "♥1" Or b46 = "♦1" Or b46 = "♧1" Or b46 = "♤1" Then
                n2 = 1
            ElseIf b46 = "♥2" Or b46 = "♦2" Or b46 = "♧2" Or b46 = "♤2" Then
                n2 = 2
            ElseIf b46 = "♥3" Or b46 = "♦3" Or b46 = "♧3" Or b46 = "♤3" Then
                n2 = 3
            ElseIf b46 = "♥4" Or b46 = "♦4" Or b46 = "♧4" Or b46 = "♤4" Then
                n2 = 4
            ElseIf b46 = "♥5" Or b46 = "♦5" Or b46 = "♧5" Or b46 = "♤5" Then
                n2 = 5
            ElseIf b46 = "♥6" Or b46 = "♦6" Or b46 = "♧6" Or b46 = "♤6" Then
                n2 = 6
            ElseIf b46 = "♥7" Or b46 = "♦7" Or b46 = "♧7" Or b46 = "♤7" Then
                n2 = 7
            ElseIf b46 = "♥8" Or b46 = "♦8" Or b46 = "♧8" Or b46 = "♤8" Then
                n2 = 8
            ElseIf b46 = "♥9" Or b46 = "♦9" Or b46 = "♧9" Or b46 = "♤9" Then
                n2 = 9
            ElseIf b46 = "♥10" Or b46 = "♦10" Or b46 = "♧10" Or b46 = "♤10" Then
                n2 = 10
            ElseIf b46 = "♥11" Or b46 = "♦11" Or b46 = "♧11" Or b46 = "♤11" Then
                n2 = 11
            ElseIf b46 = "♥12" Or b46 = "♦12" Or b46 = "♧12" Or b46 = "♤12" Then
                n2 = 12
            ElseIf b46 = "♥13" Or b46 = "♦13" Or b46 = "♧13" Or b46 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A47_Click(sender As Object, e As EventArgs) Handles A47.Click
        If sn = 1 Then
            A47.Enabled = False
            A47.Text = b47
            s1 = b47
            If b47 = "♥1" Or b47 = "♦1" Or b47 = "♧1" Or b47 = "♤1" Then
                n1 = 1
            ElseIf b47 = "♥2" Or b47 = "♦2" Or b47 = "♧2" Or b47 = "♤2" Then
                n1 = 2
            ElseIf b47 = "♥3" Or b47 = "♦3" Or b47 = "♧3" Or b47 = "♤3" Then
                n1 = 3
            ElseIf b47 = "♥4" Or b47 = "♦4" Or b47 = "♧4" Or b47 = "♤4" Then
                n1 = 4
            ElseIf b47 = "♥5" Or b47 = "♦5" Or b47 = "♧5" Or b47 = "♤5" Then
                n1 = 5
            ElseIf b47 = "♥6" Or b47 = "♦6" Or b47 = "♧6" Or b47 = "♤6" Then
                n1 = 6
            ElseIf b47 = "♥7" Or b47 = "♦7" Or b47 = "♧7" Or b47 = "♤7" Then
                n1 = 7
            ElseIf b47 = "♥8" Or b47 = "♦8" Or b47 = "♧8" Or b47 = "♤8" Then
                n1 = 8
            ElseIf b47 = "♥9" Or b47 = "♦9" Or b47 = "♧9" Or b47 = "♤9" Then
                n1 = 9
            ElseIf b47 = "♥10" Or b47 = "♦10" Or b47 = "♧10" Or b47 = "♤10" Then
                n1 = 10
            ElseIf b47 = "♥11" Or b47 = "♦11" Or b47 = "♧11" Or b47 = "♤11" Then
                n1 = 11
            ElseIf b47 = "♥12" Or b47 = "♦12" Or b47 = "♧12" Or b47 = "♤12" Then
                n1 = 12
            ElseIf b47 = "♥13" Or b47 = "♦13" Or b47 = "♧13" Or b47 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A47.Text = b47
            s2 = b47
            If b47 = "♥1" Or b47 = "♦1" Or b47 = "♧1" Or b47 = "♤1" Then
                n2 = 1
            ElseIf b47 = "♥2" Or b47 = "♦2" Or b47 = "♧2" Or b47 = "♤2" Then
                n2 = 2
            ElseIf b47 = "♥3" Or b47 = "♦3" Or b47 = "♧3" Or b47 = "♤3" Then
                n2 = 3
            ElseIf b47 = "♥4" Or b47 = "♦4" Or b47 = "♧4" Or b47 = "♤4" Then
                n2 = 4
            ElseIf b47 = "♥5" Or b47 = "♦5" Or b47 = "♧5" Or b47 = "♤5" Then
                n2 = 5
            ElseIf b47 = "♥6" Or b47 = "♦6" Or b47 = "♧6" Or b47 = "♤6" Then
                n2 = 6
            ElseIf b47 = "♥7" Or b47 = "♦7" Or b47 = "♧7" Or b47 = "♤7" Then
                n2 = 7
            ElseIf b47 = "♥8" Or b47 = "♦8" Or b47 = "♧8" Or b47 = "♤8" Then
                n2 = 8
            ElseIf b47 = "♥9" Or b47 = "♦9" Or b47 = "♧9" Or b47 = "♤9" Then
                n2 = 9
            ElseIf b47 = "♥10" Or b47 = "♦10" Or b47 = "♧10" Or b47 = "♤10" Then
                n2 = 10
            ElseIf b47 = "♥11" Or b47 = "♦11" Or b47 = "♧11" Or b47 = "♤11" Then
                n2 = 11
            ElseIf b47 = "♥12" Or b47 = "♦12" Or b47 = "♧12" Or b47 = "♤12" Then
                n2 = 12
            ElseIf b47 = "♥13" Or b47 = "♦13" Or b47 = "♧13" Or b47 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A48_Click(sender As Object, e As EventArgs) Handles A48.Click
        If sn = 1 Then
            A48.Enabled = False
            A48.Text = b48
            s1 = b48
            If b48 = "♥1" Or b48 = "♦1" Or b48 = "♧1" Or b48 = "♤1" Then
                n1 = 1
            ElseIf b48 = "♥2" Or b48 = "♦2" Or b48 = "♧2" Or b48 = "♤2" Then
                n1 = 2
            ElseIf b48 = "♥3" Or b48 = "♦3" Or b48 = "♧3" Or b48 = "♤3" Then
                n1 = 3
            ElseIf b48 = "♥4" Or b48 = "♦4" Or b48 = "♧4" Or b48 = "♤4" Then
                n1 = 4
            ElseIf b48 = "♥5" Or b48 = "♦5" Or b48 = "♧5" Or b48 = "♤5" Then
                n1 = 5
            ElseIf b48 = "♥6" Or b48 = "♦6" Or b48 = "♧6" Or b48 = "♤6" Then
                n1 = 6
            ElseIf b48 = "♥7" Or b48 = "♦7" Or b48 = "♧7" Or b48 = "♤7" Then
                n1 = 7
            ElseIf b48 = "♥8" Or b48 = "♦8" Or b48 = "♧8" Or b48 = "♤8" Then
                n1 = 8
            ElseIf b48 = "♥9" Or b48 = "♦9" Or b48 = "♧9" Or b48 = "♤9" Then
                n1 = 9
            ElseIf b48 = "♥10" Or b48 = "♦10" Or b48 = "♧10" Or b48 = "♤10" Then
                n1 = 10
            ElseIf b48 = "♥11" Or b48 = "♦11" Or b48 = "♧11" Or b48 = "♤11" Then
                n1 = 11
            ElseIf b48 = "♥12" Or b48 = "♦12" Or b48 = "♧12" Or b48 = "♤12" Then
                n1 = 12
            ElseIf b48 = "♥13" Or b48 = "♦13" Or b48 = "♧13" Or b48 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A48.Text = b48
            s2 = b48
            If b48 = "♥1" Or b48 = "♦1" Or b48 = "♧1" Or b48 = "♤1" Then
                n2 = 1
            ElseIf b48 = "♥2" Or b48 = "♦2" Or b48 = "♧2" Or b48 = "♤2" Then
                n2 = 2
            ElseIf b48 = "♥3" Or b48 = "♦3" Or b48 = "♧3" Or b48 = "♤3" Then
                n2 = 3
            ElseIf b48 = "♥4" Or b48 = "♦4" Or b48 = "♧4" Or b48 = "♤4" Then
                n2 = 4
            ElseIf b48 = "♥5" Or b48 = "♦5" Or b48 = "♧5" Or b48 = "♤5" Then
                n2 = 5
            ElseIf b48 = "♥6" Or b48 = "♦6" Or b48 = "♧6" Or b48 = "♤6" Then
                n2 = 6
            ElseIf b48 = "♥7" Or b48 = "♦7" Or b48 = "♧7" Or b48 = "♤7" Then
                n2 = 7
            ElseIf b48 = "♥8" Or b48 = "♦8" Or b48 = "♧8" Or b48 = "♤8" Then
                n2 = 8
            ElseIf b48 = "♥9" Or b48 = "♦9" Or b48 = "♧9" Or b48 = "♤9" Then
                n2 = 9
            ElseIf b48 = "♥10" Or b48 = "♦10" Or b48 = "♧10" Or b48 = "♤10" Then
                n2 = 10
            ElseIf b48 = "♥11" Or b48 = "♦11" Or b48 = "♧11" Or b48 = "♤11" Then
                n2 = 11
            ElseIf b48 = "♥12" Or b48 = "♦12" Or b48 = "♧12" Or b48 = "♤12" Then
                n2 = 12
            ElseIf b48 = "♥13" Or b48 = "♦13" Or b48 = "♧13" Or b48 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A49_Click(sender As Object, e As EventArgs) Handles A49.Click
        If sn = 1 Then
            A49.Enabled = False
            A49.Text = b49
            s1 = b49
            If b49 = "♥1" Or b49 = "♦1" Or b49 = "♧1" Or b49 = "♤1" Then
                n1 = 1
            ElseIf b49 = "♥2" Or b49 = "♦2" Or b49 = "♧2" Or b49 = "♤2" Then
                n1 = 2
            ElseIf b49 = "♥3" Or b49 = "♦3" Or b49 = "♧3" Or b49 = "♤3" Then
                n1 = 3
            ElseIf b49 = "♥4" Or b49 = "♦4" Or b49 = "♧4" Or b49 = "♤4" Then
                n1 = 4
            ElseIf b49 = "♥5" Or b49 = "♦5" Or b49 = "♧5" Or b49 = "♤5" Then
                n1 = 5
            ElseIf b49 = "♥6" Or b49 = "♦6" Or b49 = "♧6" Or b49 = "♤6" Then
                n1 = 6
            ElseIf b49 = "♥7" Or b49 = "♦7" Or b49 = "♧7" Or b49 = "♤7" Then
                n1 = 7
            ElseIf b49 = "♥8" Or b49 = "♦8" Or b49 = "♧8" Or b49 = "♤8" Then
                n1 = 8
            ElseIf b49 = "♥9" Or b49 = "♦9" Or b49 = "♧9" Or b49 = "♤9" Then
                n1 = 9
            ElseIf b49 = "♥10" Or b49 = "♦10" Or b49 = "♧10" Or b49 = "♤10" Then
                n1 = 10
            ElseIf b49 = "♥11" Or b49 = "♦11" Or b49 = "♧11" Or b49 = "♤11" Then
                n1 = 11
            ElseIf b49 = "♥12" Or b49 = "♦12" Or b49 = "♧12" Or b49 = "♤12" Then
                n1 = 12
            ElseIf b49 = "♥13" Or b49 = "♦13" Or b49 = "♧13" Or b49 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A49.Text = b49
            s2 = b49
            If b49 = "♥1" Or b49 = "♦1" Or b49 = "♧1" Or b49 = "♤1" Then
                n2 = 1
            ElseIf b49 = "♥2" Or b49 = "♦2" Or b49 = "♧2" Or b49 = "♤2" Then
                n2 = 2
            ElseIf b49 = "♥3" Or b49 = "♦3" Or b49 = "♧3" Or b49 = "♤3" Then
                n2 = 3
            ElseIf b49 = "♥4" Or b49 = "♦4" Or b49 = "♧4" Or b49 = "♤4" Then
                n2 = 4
            ElseIf b49 = "♥5" Or b49 = "♦5" Or b49 = "♧5" Or b49 = "♤5" Then
                n2 = 5
            ElseIf b49 = "♥6" Or b49 = "♦6" Or b49 = "♧6" Or b49 = "♤6" Then
                n2 = 6
            ElseIf b49 = "♥7" Or b49 = "♦7" Or b49 = "♧7" Or b49 = "♤7" Then
                n2 = 7
            ElseIf b49 = "♥8" Or b49 = "♦8" Or b49 = "♧8" Or b49 = "♤8" Then
                n2 = 8
            ElseIf b49 = "♥9" Or b49 = "♦9" Or b49 = "♧9" Or b49 = "♤9" Then
                n2 = 9
            ElseIf b49 = "♥10" Or b49 = "♦10" Or b49 = "♧10" Or b49 = "♤10" Then
                n2 = 10
            ElseIf b49 = "♥11" Or b49 = "♦11" Or b49 = "♧11" Or b49 = "♤11" Then
                n2 = 11
            ElseIf b49 = "♥12" Or b49 = "♦12" Or b49 = "♧12" Or b49 = "♤12" Then
                n2 = 12
            ElseIf b49 = "♥13" Or b49 = "♦13" Or b49 = "♧13" Or b49 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A50_Click(sender As Object, e As EventArgs) Handles A50.Click
        If sn = 1 Then
            A50.Enabled = False
            A50.Text = b50
            s1 = b50
            If b50 = "♥1" Or b50 = "♦1" Or b50 = "♧1" Or b50 = "♤1" Then
                n1 = 1
            ElseIf b50 = "♥2" Or b50 = "♦2" Or b50 = "♧2" Or b50 = "♤2" Then
                n1 = 2
            ElseIf b50 = "♥3" Or b50 = "♦3" Or b50 = "♧3" Or b50 = "♤3" Then
                n1 = 3
            ElseIf b50 = "♥4" Or b50 = "♦4" Or b50 = "♧4" Or b50 = "♤4" Then
                n1 = 4
            ElseIf b50 = "♥5" Or b50 = "♦5" Or b50 = "♧5" Or b50 = "♤5" Then
                n1 = 5
            ElseIf b50 = "♥6" Or b50 = "♦6" Or b50 = "♧6" Or b50 = "♤6" Then
                n1 = 6
            ElseIf b50 = "♥7" Or b50 = "♦7" Or b50 = "♧7" Or b50 = "♤7" Then
                n1 = 7
            ElseIf b50 = "♥8" Or b50 = "♦8" Or b50 = "♧8" Or b50 = "♤8" Then
                n1 = 8
            ElseIf b50 = "♥9" Or b50 = "♦9" Or b50 = "♧9" Or b50 = "♤9" Then
                n1 = 9
            ElseIf b50 = "♥10" Or b50 = "♦10" Or b50 = "♧10" Or b50 = "♤10" Then
                n1 = 10
            ElseIf b50 = "♥11" Or b50 = "♦11" Or b50 = "♧11" Or b50 = "♤11" Then
                n1 = 11
            ElseIf b50 = "♥12" Or b50 = "♦12" Or b50 = "♧12" Or b50 = "♤12" Then
                n1 = 12
            ElseIf b50 = "♥13" Or b50 = "♦13" Or b50 = "♧13" Or b50 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A50.Text = b50
            s2 = b50
            If b50 = "♥1" Or b50 = "♦1" Or b50 = "♧1" Or b50 = "♤1" Then
                n2 = 1
            ElseIf b50 = "♥2" Or b50 = "♦2" Or b50 = "♧2" Or b50 = "♤2" Then
                n2 = 2
            ElseIf b50 = "♥3" Or b50 = "♦3" Or b50 = "♧3" Or b50 = "♤3" Then
                n2 = 3
            ElseIf b50 = "♥4" Or b50 = "♦4" Or b50 = "♧4" Or b50 = "♤4" Then
                n2 = 4
            ElseIf b50 = "♥5" Or b50 = "♦5" Or b50 = "♧5" Or b50 = "♤5" Then
                n2 = 5
            ElseIf b50 = "♥6" Or b50 = "♦6" Or b50 = "♧6" Or b50 = "♤6" Then
                n2 = 6
            ElseIf b50 = "♥7" Or b50 = "♦7" Or b50 = "♧7" Or b50 = "♤7" Then
                n2 = 7
            ElseIf b50 = "♥8" Or b50 = "♦8" Or b50 = "♧8" Or b50 = "♤8" Then
                n2 = 8
            ElseIf b50 = "♥9" Or b50 = "♦9" Or b50 = "♧9" Or b50 = "♤9" Then
                n2 = 9
            ElseIf b50 = "♥10" Or b50 = "♦10" Or b50 = "♧10" Or b50 = "♤10" Then
                n2 = 10
            ElseIf b50 = "♥11" Or b50 = "♦11" Or b50 = "♧11" Or b50 = "♤11" Then
                n2 = 11
            ElseIf b50 = "♥12" Or b50 = "♦12" Or b50 = "♧12" Or b50 = "♤12" Then
                n2 = 12
            ElseIf b50 = "♥13" Or b50 = "♦13" Or b50 = "♧13" Or b50 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A51_Click(sender As Object, e As EventArgs) Handles A51.Click
        If sn = 1 Then
            A51.Enabled = False
            A51.Text = b51
            s1 = b51
            If b51 = "♥1" Or b51 = "♦1" Or b51 = "♧1" Or b51 = "♤1" Then
                n1 = 1
            ElseIf b51 = "♥2" Or b51 = "♦2" Or b51 = "♧2" Or b51 = "♤2" Then
                n1 = 2
            ElseIf b51 = "♥3" Or b51 = "♦3" Or b51 = "♧3" Or b51 = "♤3" Then
                n1 = 3
            ElseIf b51 = "♥4" Or b51 = "♦4" Or b51 = "♧4" Or b51 = "♤4" Then
                n1 = 4
            ElseIf b51 = "♥5" Or b51 = "♦5" Or b51 = "♧5" Or b51 = "♤5" Then
                n1 = 5
            ElseIf b51 = "♥6" Or b51 = "♦6" Or b51 = "♧6" Or b51 = "♤6" Then
                n1 = 6
            ElseIf b51 = "♥7" Or b51 = "♦7" Or b51 = "♧7" Or b51 = "♤7" Then
                n1 = 7
            ElseIf b51 = "♥8" Or b51 = "♦8" Or b51 = "♧8" Or b51 = "♤8" Then
                n1 = 8
            ElseIf b51 = "♥9" Or b51 = "♦9" Or b51 = "♧9" Or b51 = "♤9" Then
                n1 = 9
            ElseIf b51 = "♥10" Or b51 = "♦10" Or b51 = "♧10" Or b51 = "♤10" Then
                n1 = 10
            ElseIf b51 = "♥11" Or b51 = "♦11" Or b51 = "♧11" Or b51 = "♤11" Then
                n1 = 11
            ElseIf b51 = "♥12" Or b51 = "♦12" Or b51 = "♧12" Or b51 = "♤12" Then
                n1 = 12
            ElseIf b51 = "♥13" Or b51 = "♦13" Or b51 = "♧13" Or b51 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A51.Text = b51
            s2 = b51
            If b51 = "♥1" Or b51 = "♦1" Or b51 = "♧1" Or b51 = "♤1" Then
                n2 = 1
            ElseIf b51 = "♥2" Or b51 = "♦2" Or b51 = "♧2" Or b51 = "♤2" Then
                n2 = 2
            ElseIf b51 = "♥3" Or b51 = "♦3" Or b51 = "♧3" Or b51 = "♤3" Then
                n2 = 3
            ElseIf b51 = "♥4" Or b51 = "♦4" Or b51 = "♧4" Or b51 = "♤4" Then
                n2 = 4
            ElseIf b51 = "♥5" Or b51 = "♦5" Or b51 = "♧5" Or b51 = "♤5" Then
                n2 = 5
            ElseIf b51 = "♥6" Or b51 = "♦6" Or b51 = "♧6" Or b51 = "♤6" Then
                n2 = 6
            ElseIf b51 = "♥7" Or b51 = "♦7" Or b51 = "♧7" Or b51 = "♤7" Then
                n2 = 7
            ElseIf b51 = "♥8" Or b51 = "♦8" Or b51 = "♧8" Or b51 = "♤8" Then
                n2 = 8
            ElseIf b51 = "♥9" Or b51 = "♦9" Or b51 = "♧9" Or b51 = "♤9" Then
                n2 = 9
            ElseIf b51 = "♥10" Or b51 = "♦10" Or b51 = "♧10" Or b51 = "♤10" Then
                n2 = 10
            ElseIf b51 = "♥11" Or b51 = "♦11" Or b51 = "♧11" Or b51 = "♤11" Then
                n2 = 11
            ElseIf b51 = "♥12" Or b51 = "♦12" Or b51 = "♧12" Or b51 = "♤12" Then
                n2 = 12
            ElseIf b51 = "♥13" Or b51 = "♦13" Or b51 = "♧13" Or b51 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Private Sub A52_Click(sender As Object, e As EventArgs) Handles A52.Click
        If sn = 1 Then
            A52.Enabled = False
            A52.Text = b52
            s1 = b52
            If b52 = "♥1" Or b52 = "♦1" Or b52 = "♧1" Or b52 = "♤1" Then
                n1 = 1
            ElseIf b52 = "♥2" Or b52 = "♦2" Or b52 = "♧2" Or b52 = "♤2" Then
                n1 = 2
            ElseIf b52 = "♥3" Or b52 = "♦3" Or b52 = "♧3" Or b52 = "♤3" Then
                n1 = 3
            ElseIf b52 = "♥4" Or b52 = "♦4" Or b52 = "♧4" Or b52 = "♤4" Then
                n1 = 4
            ElseIf b52 = "♥5" Or b52 = "♦5" Or b52 = "♧5" Or b52 = "♤5" Then
                n1 = 5
            ElseIf b52 = "♥6" Or b52 = "♦6" Or b52 = "♧6" Or b52 = "♤6" Then
                n1 = 6
            ElseIf b52 = "♥7" Or b52 = "♦7" Or b52 = "♧7" Or b52 = "♤7" Then
                n1 = 7
            ElseIf b52 = "♥8" Or b52 = "♦8" Or b52 = "♧8" Or b52 = "♤8" Then
                n1 = 8
            ElseIf b52 = "♥9" Or b52 = "♦9" Or b52 = "♧9" Or b52 = "♤9" Then
                n1 = 9
            ElseIf b52 = "♥10" Or b52 = "♦10" Or b52 = "♧10" Or b52 = "♤10" Then
                n1 = 10
            ElseIf b52 = "♥11" Or b52 = "♦11" Or b52 = "♧11" Or b52 = "♤11" Then
                n1 = 11
            ElseIf b52 = "♥12" Or b52 = "♦12" Or b52 = "♧12" Or b52 = "♤12" Then
                n1 = 12
            ElseIf b52 = "♥13" Or b52 = "♦13" Or b52 = "♧13" Or b52 = "♤13" Then
                n1 = 13
            End If
            SC()
        ElseIf sn = 2 Then
            A52.Text = b52
            s2 = b52
            If b52 = "♥1" Or b52 = "♦1" Or b52 = "♧1" Or b52 = "♤1" Then
                n2 = 1
            ElseIf b52 = "♥2" Or b52 = "♦2" Or b52 = "♧2" Or b52 = "♤2" Then
                n2 = 2
            ElseIf b52 = "♥3" Or b52 = "♦3" Or b52 = "♧3" Or b52 = "♤3" Then
                n2 = 3
            ElseIf b52 = "♥4" Or b52 = "♦4" Or b52 = "♧4" Or b52 = "♤4" Then
                n2 = 4
            ElseIf b52 = "♥5" Or b52 = "♦5" Or b52 = "♧5" Or b52 = "♤5" Then
                n2 = 5
            ElseIf b52 = "♥6" Or b52 = "♦6" Or b52 = "♧6" Or b52 = "♤6" Then
                n2 = 6
            ElseIf b52 = "♥7" Or b52 = "♦7" Or b52 = "♧7" Or b52 = "♤7" Then
                n2 = 7
            ElseIf b52 = "♥8" Or b52 = "♦8" Or b52 = "♧8" Or b52 = "♤8" Then
                n2 = 8
            ElseIf b52 = "♥9" Or b52 = "♦9" Or b52 = "♧9" Or b52 = "♤9" Then
                n2 = 9
            ElseIf b52 = "♥10" Or b52 = "♦10" Or b52 = "♧10" Or b52 = "♤10" Then
                n2 = 10
            ElseIf b52 = "♥11" Or b52 = "♦11" Or b52 = "♧11" Or b52 = "♤11" Then
                n2 = 11
            ElseIf b52 = "♥12" Or b52 = "♦12" Or b52 = "♧12" Or b52 = "♤12" Then
                n2 = 12
            ElseIf b52 = "♥13" Or b52 = "♦13" Or b52 = "♧13" Or b52 = "♤13" Then
                n2 = 13
            End If
            SC()
            TC()
        End If
    End Sub

    Sub BC()
        If n1 = n2 Then
            LS1.Text = ""
            LS2.Text = ""
            EN()
            If p = 1 Then
                p1 = p1 + 1
                sw.C1.Text = p1
                aw.aa1 = aw.aa1 + 1
                aw.ac1 = aw.ac1 + 1
            ElseIf p = 2 Then
                p2 = p2 + 1
                sw.C2.Text = p2
                aw.aa2 = aw.aa2 + 1
                aw.ac2 = aw.ac2 + 1
            ElseIf p = 3 Then
                p3 = p3 + 1
                sw.C3.Text = p3
                aw.aa3 = aw.aa3 + 1
                aw.ac3 = aw.ac3 + 1
            ElseIf p = 4 Then
                p4 = p4 + 1
                sw.C4.Text = p4
                aw.aa4 = aw.aa4 + 1
                aw.ac4 = aw.ac4 + 1
            ElseIf p = 5 Then
                p5 = p5 + 1
                sw.C5.Text = p5
                aw.aa5 = aw.aa5 + 1
                aw.ac5 = aw.ac5 + 1
            ElseIf p = 6 Then
                p6 = p6 + 1
                sw.C6.Text = p6
                aw.aa6 = aw.aa6 + 1
                aw.ac6 = aw.ac6 + 1
            End If
            c = c - 1
            If A1.Text = s1 Or A1.Text = s2 Then
                A1.Hide()
            End If
            If A2.Text = s1 Or A2.Text = s2 Then
                A2.Hide()
            End If
            If A3.Text = s1 Or A3.Text = s2 Then
                A3.Hide()
            End If
            If A4.Text = s1 Or A4.Text = s2 Then
                A4.Hide()
            End If
            If A5.Text = s1 Or A5.Text = s2 Then
                A5.Hide()
            End If
            If A6.Text = s1 Or A6.Text = s2 Then
                A6.Hide()
            End If
            If A7.Text = s1 Or A7.Text = s2 Then
                A7.Hide()
            End If
            If A8.Text = s1 Or A8.Text = s2 Then
                A8.Hide()
            End If
            If A9.Text = s1 Or A9.Text = s2 Then
                A9.Hide()
            End If
            If A10.Text = s1 Or A10.Text = s2 Then
                A10.Hide()
            End If
            If A11.Text = s1 Or A11.Text = s2 Then
                A11.Hide()
            End If
            If A12.Text = s1 Or A12.Text = s2 Then
                A12.Hide()
            End If
            If A13.Text = s1 Or A13.Text = s2 Then
                A13.Hide()
            End If
            If A14.Text = s1 Or A14.Text = s2 Then
                A14.Hide()
            End If
            If A15.Text = s1 Or A15.Text = s2 Then
                A15.Hide()
            End If
            If A16.Text = s1 Or A16.Text = s2 Then
                A16.Hide()
            End If
            If A17.Text = s1 Or A17.Text = s2 Then
                A17.Hide()
            End If
            If A18.Text = s1 Or A18.Text = s2 Then
                A18.Hide()
            End If
            If A19.Text = s1 Or A19.Text = s2 Then
                A19.Hide()
            End If
            If A20.Text = s1 Or A20.Text = s2 Then
                A20.Hide()
            End If
            If A21.Text = s1 Or A21.Text = s2 Then
                A21.Hide()
            End If
            If A22.Text = s1 Or A22.Text = s2 Then
                A22.Hide()
            End If
            If A23.Text = s1 Or A23.Text = s2 Then
                A23.Hide()
            End If
            If A24.Text = s1 Or A24.Text = s2 Then
                A24.Hide()
            End If
            If A25.Text = s1 Or A25.Text = s2 Then
                A25.Hide()
            End If
            If A26.Text = s1 Or A26.Text = s2 Then
                A26.Hide()
            End If
            If A27.Text = s1 Or A27.Text = s2 Then
                A27.Hide()
            End If
            If A28.Text = s1 Or A28.Text = s2 Then
                A28.Hide()
            End If
            If A29.Text = s1 Or A29.Text = s2 Then
                A29.Hide()
            End If
            If A30.Text = s1 Or A30.Text = s2 Then
                A30.Hide()
            End If
            If A31.Text = s1 Or A31.Text = s2 Then
                A31.Hide()
            End If
            If A32.Text = s1 Or A32.Text = s2 Then
                A32.Hide()
            End If
            If A33.Text = s1 Or A33.Text = s2 Then
                A33.Hide()
            End If
            If A34.Text = s1 Or A34.Text = s2 Then
                A34.Hide()
            End If
            If A35.Text = s1 Or A35.Text = s2 Then
                A35.Hide()
            End If
            If A36.Text = s1 Or A36.Text = s2 Then
                A36.Hide()
            End If
            If A37.Text = s1 Or A37.Text = s2 Then
                A37.Hide()
            End If
            If A38.Text = s1 Or A38.Text = s2 Then
                A38.Hide()
            End If
            If A39.Text = s1 Or A39.Text = s2 Then
                A39.Hide()
            End If
            If A40.Text = s1 Or A40.Text = s2 Then
                A40.Hide()
            End If
            If A41.Text = s1 Or A41.Text = s2 Then
                A41.Hide()
            End If
            If A42.Text = s1 Or A42.Text = s2 Then
                A42.Hide()
            End If
            If A43.Text = s1 Or A43.Text = s2 Then
                A43.Hide()
            End If
            If A44.Text = s1 Or A44.Text = s2 Then
                A44.Hide()
            End If
            If A45.Text = s1 Or A45.Text = s2 Then
                A45.Hide()
            End If
            If A46.Text = s1 Or A46.Text = s2 Then
                A46.Hide()
            End If
            If A47.Text = s1 Or A47.Text = s2 Then
                A47.Hide()
            End If
            If A48.Text = s1 Or A48.Text = s2 Then
                A48.Hide()
            End If
            If A49.Text = s1 Or A49.Text = s2 Then
                A49.Hide()
            End If
            If A50.Text = s1 Or A50.Text = s2 Then
                A50.Hide()
            End If
            If A51.Text = s1 Or A51.Text = s2 Then
                A51.Hide()
            End If
            If A52.Text = s1 Or A52.Text = s2 Then
                A52.Hide()
            End If
            AC()
            If c = 0 Then
                Timer.Stop()
                If pn > 1 Then
                    w = ""
                    If p1 > p2 And p1 > p3 And p1 > p4 And p1 > p5 And p1 > p6 Then
                        w = "1"
                    End If
                    If p2 > p1 And p2 > p3 And p2 > p4 And p2 > p5 And p2 > p6 Then
                        If w = "" Then
                            w = "2"
                        Else
                            w = " & 2"
                        End If
                    End If
                    If p3 > p1 And p3 > p2 And p3 > p4 And p3 > p5 And p3 > p6 Then
                        If w = "" Then
                            w = "3"
                        Else
                            w = " & 3"
                        End If
                    End If
                    If p4 > p1 And p4 > p2 And p4 > p3 And p4 > p5 And p4 > p6 Then
                        If w = "" Then
                            w = "4"
                        Else
                            w = " & 4"
                        End If
                    End If
                    If p5 > p1 And p5 > p2 And p5 > p3 And p5 > p4 And p5 > p6 Then
                        If w = "" Then
                            w = "5"
                        Else
                            w = " & 5"
                        End If
                    End If
                    If p6 > p1 And p6 > p2 And p6 > p3 And p6 > p4 And p6 > p5 Then
                        If w = "" Then
                            w = "6"
                        Else
                            w = " & 6"
                        End If
                    End If
                    MsgBox("勝者　Player " & w, MsgBoxStyle.OkOnly, "Result")
                    gs = 0
                    sw.Dispose()
                    ow.Dispose()
                    aw.Dispose()
                    Close()
                Else
                    MsgBox("所要時間　" & t1 & "時間 " & t2 & "分 " & t3 & "秒", MsgBoxStyle.OkOnly, "Result")
                    gs = 0
                    sw.Dispose()
                    ow.Dispose()
                    aw.Dispose()
                    Close()
                End If
            End If
        Else
            LS1.Text = ""
            LS2.Text = ""
            EN()
            If p = 1 Then
                aw.aa1 = aw.aa1 + 1
            ElseIf p = 2 Then
                aw.aa2 = aw.aa2 + 1
            ElseIf p = 3 Then
                aw.aa3 = aw.aa3 + 1
            ElseIf p = 4 Then
                aw.aa4 = aw.aa4 + 1
            ElseIf p = 5 Then
                aw.aa5 = aw.aa5 + 1
            ElseIf p = 6 Then
                aw.aa6 = aw.aa6 + 1
            End If
            AC()
            PC()
        End If
    End Sub
End Class