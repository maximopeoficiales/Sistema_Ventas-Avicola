Public Class ListaVentasFiltro
    Dim c As New CVentas
    Private Sub btn_buscar_dni_Click(sender As Object, e As EventArgs) Handles btn_buscar_dni.Click
        c.buscar_ventas_por_dni(tabla_ventas, txt_dni_compra.Text)
    End Sub

    Private Sub txt_dni_compra_TextChanged(sender As Object, e As EventArgs) Handles txt_dni_compra.TextChanged
        c.buscar_ventas_por_dni(tabla_ventas, txt_dni_compra.Text)
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        Me.Close()
    End Sub

    Private Sub ListaVentasFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.obtener_fecha()
    End Sub
End Class