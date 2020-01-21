Public Class ModificarProductos

    Dim c As New CProductos

    Private Sub ModificarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'c.mostrar_proovedores_codigo()
        'c.mostrar_productos_nombre()
        'cb_productos.DropDownStyle = ComboBoxStyle.DropDownList
        'cb_codigo_proovedor.DropDownStyle = ComboBoxStyle.DropDownList
        'c.menor_cantidad_productos()
        c.cargarProd()
    End Sub

    Private Sub btn_mostrar_lista_Click(sender As Object, e As EventArgs) Handles btn_mostrar_lista.Click
        ListaProductos.Show()
    End Sub

    Private Sub btn_buscar_productos_Click(sender As Object, e As EventArgs) Handles btn_buscar_productos.Click
        c.mostrar_datos_nombre()
    End Sub

    Private Sub btn_agregar_productos_Click(sender As Object, e As EventArgs) Handles btn_agregar_productos.Click
        'c.agregar_producto()
        'c.menor_cantidad_productos()
        'c.mostrar_productos_nombre() 'combo
        c.agregarProd()
    End Sub

    Private Sub btn_actualizar_producto_Click(sender As Object, e As EventArgs) Handles btn_actualizar_producto.Click
        'c.actualizar_producto()
        'c.menor_cantidad_productos()
        c.actualizarProd()
    End Sub
End Class