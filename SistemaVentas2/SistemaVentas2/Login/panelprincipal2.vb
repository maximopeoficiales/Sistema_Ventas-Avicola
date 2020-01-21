Public Class panelprincipal2
    Dim c As New CMenu1
    Private Sub btn_consultar_productos_Click(sender As Object, e As EventArgs) Handles btn_consultar_productos.Click
        c.abrirform(ModificarProductos)
    End Sub

    Private Sub btn_registrar_venta_Click(sender As Object, e As EventArgs) Handles btn_registrar_venta.Click

        c.abrirform(RegistrarVentas)
    End Sub

    Private Sub btn_modificar_cliente_Click(sender As Object, e As EventArgs) Handles btn_modificar_cliente.Click
        c.abrirform(AdministrarClientes)
    End Sub

    Private Sub panelprincipal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_usuario.Text = obtener_usuario_activo()
    End Sub
End Class