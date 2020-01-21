Public Class CProductos
    'Dim f = ModificarProductos
    Dim validacion As Boolean
    Dim dt As New DataTable
    Public Sub Validacion_Form()

        If ModificarProductos.cb_codigo_proovedor.Text = "" Or ModificarProductos.txt_cod_producto.Text = "" Or ModificarProductos.txt_nombre.Text = "" Or ModificarProductos.txt_precio.Text = "" Or ModificarProductos.txt_stock.Text = "" Then
            validacion = False
            MsgBox("Completa todos los campos")
        Else
            validacion = True
        End If
    End Sub
    Public Sub mostrarproductos()
        Try
            Dim fun As New FProducto
            dt = fun.FnMostrarProductos
            If dt.Rows.Count > 0 Then
                ListaProductos.tabla_productos.DataSource = dt 'igualo el origen de datos de mi tabla con dt
            Else
                ListaProductos.tabla_productos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub actualizar_producto()
        Validacion_Form()
        If validacion Then
            Try
                Dim func As New FProducto
                Dim logica As New VProductos
                logica.gcod_producto = ModificarProductos.txt_cod_producto.Text
                logica.gnombre_producto = ModificarProductos.txt_nombre.Text
                logica.gprecio_xkg = ModificarProductos.txt_precio.Text
                logica.gstock = ModificarProductos.txt_stock.Text
                logica.gcod_proovedor = ModificarProductos.cb_codigo_proovedor.Text
                If func.FnActualizarProducto(logica) Then
                    MsgBox("Actualizacion de datos exitosa")
                    mostrarproductos()
                End If
            Catch ex As Exception : MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Error al actualizar producto")
        End If
    End Sub

    Public Sub agregar_producto()
        Validacion_Form()
        If validacion Then
            Dim func As New FProducto
            Dim logica As New VProductos
            logica.gcod_producto = ModificarProductos.txt_cod_producto.Text
            logica.gcod_proovedor = ModificarProductos.cb_codigo_proovedor.Text
            logica.gnombre_producto = ModificarProductos.txt_nombre.Text
            logica.gprecio_xkg = ModificarProductos.txt_precio.Text
            logica.gstock = ModificarProductos.txt_stock.Text
            If func.FnInsertarProductos(logica) Then
                MsgBox("Insercion de datos exitosa")
                mostrarproductos()
            End If
        Else
            MsgBox("Error completo sus datos")
        End If
    End Sub

    Public Sub mostrar_datos_nombre()
        'falta crear este metodo en el fproducto
        Try
            Dim func As New FProducto
            func.FnRellenarTextBoxProductos(ModificarProductos.cb_productos, ModificarProductos.cb_codigo_proovedor, ModificarProductos.txt_cod_producto, ModificarProductos.txt_nombre, ModificarProductos.txt_precio, ModificarProductos.txt_stock)
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_productos_nombre()
        Try
            Dim func As New FProducto
            func.FnLlenarComboNombresProducto(ModificarProductos.cb_productos)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub mostrar_proovedores_codigo()
        Try
            Dim func As New FProveedor
            func.FnLlenarComboCodigoProveedor(ModificarProductos.cb_codigo_proovedor)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub validacion_img()
        Dim func As New FProducto
        Dim dt As DataTable = func.FnMostrarTopMenorCantidadProducto
        Dim producto_menor_stock As String = dt.Rows(0)(0).ToString
        ModificarProductos.label_producto.Text = "restantes de " + producto_menor_stock
        If producto_menor_stock = "Pato" Then
            ModificarProductos.imagen_producto_restante.Image = SistemaVentas2.My.Resources.Resources.pato
        ElseIf producto_menor_stock = "Gallina" Then
            ModificarProductos.imagen_producto_restante.Image = SistemaVentas2.My.Resources.Resources.gallina
        ElseIf producto_menor_stock = "Huevo" Then
            ModificarProductos.imagen_producto_restante.Image = SistemaVentas2.My.Resources.Resources.huevo
        ElseIf producto_menor_stock = "Pollo" Then
            ModificarProductos.imagen_producto_restante.Image = SistemaVentas2.My.Resources.Resources.pollo
        ElseIf producto_menor_stock = "Pavo" Then
            ModificarProductos.imagen_producto_restante.Image = SistemaVentas2.My.Resources.Resources._2219786
        ElseIf producto_menor_stock = "Pavita" Then
            ModificarProductos.imagen_producto_restante.Image = SistemaVentas2.My.Resources.Resources.pavita
        Else
            ModificarProductos.imagen_producto_restante.Image = SistemaVentas2.My.Resources.Resources._189665
        End If
    End Sub

    Public Sub menor_cantidad_productos()
        Try
            Dim func As New FProducto
            Dim dt As DataTable
            dt = func.FnMostrarTopMenorCantidadProducto
            ModificarProductos.label_producto_restante.Text = dt.Rows(0)(0).ToString
            validacion_img()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub MostrarCheckTabla(e As DataGridViewCellEventArgs)
        'Antes de hacer eso agregar la columna eliminar como checkbox'
        If e.ColumnIndex = ListaProductos.tabla_productos.Columns.Item("Eliminar").Index Then
            Dim check As DataGridViewCheckBoxCell = ListaProductos.tabla_productos.Rows(e.RowIndex).Cells("Eliminar")
            check.Value = Not check.Value
        End If
    End Sub
    Public Sub mostrar_productos_lista()
        Try
            Dim func As New FProducto
            ListaProductos.tabla_productos.DataSource = func.FnMostrarProductos
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub eliminar_productos()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los registros seleccionados", "Registro Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In ListaProductos.tabla_productos.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Dim Cod_Producto = row.Cells("Cod_Producto").Value
                    Dim func As New FProducto
                    Dim logicas As New VProductos
                    logicas.gcod_producto = Cod_Producto
                    func.FnEliminarProducto(logicas)
                    ListaProductos.tabla_productos.DataSource = func.FnMostrarProductos()
                End If
            Next
        End If
    End Sub

    'PARA EL FRAME

    Public Sub cargarProd()
        mostrar_proovedores_codigo()
        mostrar_productos_nombre()
        ModificarProductos.cb_productos.DropDownStyle = ComboBoxStyle.DropDownList
        ModificarProductos.cb_codigo_proovedor.DropDownStyle = ComboBoxStyle.DropDownList
        menor_cantidad_productos()
    End Sub

    Public Sub agregarProd()
        agregar_producto()
        menor_cantidad_productos()
        mostrar_productos_nombre() 'combo
    End Sub

    Public Sub actualizarProd()
        actualizar_producto()
        menor_cantidad_productos()
    End Sub

    Public Sub cargarProdList()
        mostrar_productos_lista()
        'opcion para que funcione el doble click'
        ListaProductos.tabla_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ListaProductos.tabla_productos.AllowUserToAddRows = False
        ListaProductos.tabla_productos.AllowUserToResizeRows = False
    End Sub

    Public Sub eliminarProd()
        eliminar_productos()
        mostrar_proovedores_codigo()
        mostrar_productos_nombre()
    End Sub
End Class
