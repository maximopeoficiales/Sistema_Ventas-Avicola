Public Class Menu1
    Dim c As New CMenu1
    Private Sub btn_registrar_venta_Click(sender As Object, e As EventArgs) Handles btn_registrar_venta.Click
        c.abrirform(RegistrarVentas)
    End Sub

    Private Sub btn_Ventas_Click(sender As Object, e As EventArgs) Handles btn_Ventas.Click
        c.abrirform(ConsultarVentas)
    End Sub

    Private Sub btn_consultar_productos_Click(sender As Object, e As EventArgs) Handles btn_consultar_productos.Click
        c.abrirform(ModificarProductos)
    End Sub

    Private Sub btn_modificar_cliente_Click(sender As Object, e As EventArgs) Handles btn_modificar_cliente.Click
        c.abrirform(AdministrarClientes)
    End Sub

    Private Sub btn_Productos_Click(sender As Object, e As EventArgs) Handles btn_Productos.Click
        c.abrirform(ModificarProductos)
    End Sub

    Private Sub btn_Clientes_Click(sender As Object, e As EventArgs) Handles btn_Clientes.Click
        c.abrirform(AdministrarClientes)
    End Sub

    Private Sub btn_Empleados_Click(sender As Object, e As EventArgs) Handles btn_Empleados.Click
        c.abrirform(AdministrarEmpleados)
    End Sub

    Private Sub btn_Ganancias_Click(sender As Object, e As EventArgs) Handles btn_Ganancias1.Click
        c.abrirform(ConsultarGanancias)
    End Sub


    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        c.SalirSession()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles imglogo.Click
        c.abrirform(panelprincipal2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_proovedores.Click

        c.abrirform(AdministrarProvedores)
    End Sub
    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_usuario.Text = ControlSesiones.obtener_usuario_activo()
        If obtener_tipo_usuario_activo() = "Vendedor" Then
            btn_Empleados.Visible = False
            btn_Ganancias1.Visible = False
            btn_proovedores.Visible = False
        End If

    End Sub
End Class