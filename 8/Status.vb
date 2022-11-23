Public Class Status
    Dim o As Game
    Dim s As New OK
    Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        o = CType(Me.Owner, Game)
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Left = o.Left + o.Width + s.Width
        Top = o.Top
    End Sub

    Private Sub Game_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If o.gs = 1 Then
            e.Cancel = True
        End If
    End Sub
End Class