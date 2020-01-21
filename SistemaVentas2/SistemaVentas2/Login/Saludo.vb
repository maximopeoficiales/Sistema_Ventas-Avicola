Public Class Saludo
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString
        '100% = 1 0.05 = 5%'
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05

        End If
        If CircularProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Saludo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircularProgressBar1.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'vada 30 milisegundos va quitando la opacidad'
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
            Menu1.Show()
        End If
    End Sub
End Class