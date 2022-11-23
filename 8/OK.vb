Public Class OK
    Dim m As Game
    Dim w1, w2 As ULong
    Private Sub OK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = CType(Me.Owner, Game)
        w1 = Width
        w2 = Height
        Timer.Start()
    End Sub

    Private Sub OK_GotFocus(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        m.Focus()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Left = m.Left + m.Width
        Top = m.Top
        Width = w1
        Height = w2
    End Sub

    Private Sub BC_Click(sender As Object, e As EventArgs) Handles BC.Click
        BC.Enabled = False
        m.BC()
        m.Focus()
        m.L.Focus()
    End Sub

    Private Sub Game_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If m.gs = 1 Then
            e.Cancel = True
        End If
    End Sub
End Class