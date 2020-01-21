Public Class Barra_cargando
    Dim x As Integer
    Dim xa As Integer = 100
    Private Sub Barra_cargando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.ForeColor = Color.AliceBlue

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If x < 100 Then
            x = x + 5
            ProgressBar1.Value = x

            label_porcentaje.Text = CStr(x) + "%"
            If ProgressBar1.Value = 100 Then

                Me.Hide()
                login.Show()
            End If

        End If



    End Sub

    
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class