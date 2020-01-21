Public Class ConsultarGanancias
    Dim c As New CGanancias
    Private Sub btn_mostrar_ganancias_seleccionable_Click(sender As Object, e As EventArgs) Handles btn_mostrar_ganancias_seleccionable.Click
        c.obtener_fecha()
    End Sub
End Class