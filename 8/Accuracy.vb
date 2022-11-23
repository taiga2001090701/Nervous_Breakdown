Public Class Accuracy
    Public ac1, ac2, ac3, ac4, ac5, ac6 As ULong
    Public aa1, aa2, aa3, aa4, aa5, aa6 As ULong
    Dim c1, c2, c3, c4, c5, c6 As ULong
    Dim m As Game
    Dim ow As New OK
    Private Sub OK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = CType(Me.Owner, Game)
        aa1 = 0
        aa2 = 0
        aa3 = 0
        aa4 = 0
        aa5 = 0
        aa6 = 0
        ac1 = 0
        ac2 = 0
        ac3 = 0
        ac4 = 0
        ac5 = 0
        ac6 = 0
        Timer.Start()
        TimerX.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Left = m.Left - Width
        Top = m.Top
    End Sub

    Private Sub TimerX_Tick(sender As Object, e As EventArgs) Handles TimerX.Tick
        PB1.Maximum = aa1
        PB2.Maximum = aa2
        PB3.Maximum = aa3
        PB4.Maximum = aa4
        PB5.Maximum = aa5
        PB6.Maximum = aa6
        PB1.Value = ac1
        PB2.Value = ac2
        PB3.Value = ac3
        PB4.Value = ac4
        PB5.Value = ac5
        PB6.Value = ac6
        If Not aa1 = 0 Then
            c1 = ac1 / aa1 * 100
            PS1.Text = c1
        End If
        If Not aa2 = 0 Then
            c2 = ac2 / aa2 * 100
            PS2.Text = c2
        End If
        If Not aa3 = 0 Then
            c3 = ac3 / aa3 * 100
            PS3.Text = c3
        End If
        If Not aa4 = 0 Then
            c4 = ac4 / aa4 * 100
            PS4.Text = c4
        End If
        If Not aa5 = 0 Then
            c5 = ac5 / aa5 * 100
            PS5.Text = c5
        End If
        If Not aa6 = 0 Then
            c6 = ac6 / aa6 * 100
            PS6.Text = c6
        End If
    End Sub

    Private Sub Game_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If m.gs = 1 Then
            e.Cancel = True
        End If
    End Sub
End Class