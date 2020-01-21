Public Class ListaProductos
    Dim c As New CProductos
    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'c.mostrar_productos_lista()
        ''opcion para que funcione el doble click'
        'tabla_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'tabla_productos.AllowUserToAddRows = False
        'tabla_productos.AllowUserToResizeRows = False
        c.cargarProdList()
    End Sub

    Private Sub tabla_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_productos.CellContentClick
        c.MostrarCheckTabla(e)
    End Sub

    Private Sub btn_eliminar_producto_Click(sender As Object, e As EventArgs) Handles btn_eliminar_producto.Click
        c.eliminarProd()
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        Me.Hide()
        ModificarProductos.Show()
        c.mostrar_proovedores_codigo()
        c.mostrar_productos_nombre()
    End Sub
End Class