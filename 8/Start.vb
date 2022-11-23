Public Class Start
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim f As New Game
        f.pn = 1
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Dim f As New Game
        f.pn = 2
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Dim f As New Game
        f.pn = 3
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Dim f As New Game
        f.pn = 4
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Dim f As New Game
        f.pn = 5
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Dim f As New Game
        f.pn = 6
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
End Class