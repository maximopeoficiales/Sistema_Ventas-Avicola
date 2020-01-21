Public Class CVentas
    Dim dt As New DataTable
    Dim fecha_unica
    Dim fecha_rg1
    Dim fecha_rg2

    Dim indice
    Dim codigo_empleado
    Dim tipo_documento
    Dim numero_factura
    Dim nmax_documento_venta

    Public Sub calcular_total()
        Dim igv = 18 / 100
        Dim igv_calculado As Double = CDbl(RegistrarVentas.txt_subtotal.Text) * igv
        Dim subtotal As Double = (igv_calculado + CDbl(RegistrarVentas.txt_subtotal.Text))
        RegistrarVentas.label_total.Text = CStr(subtotal)
        RegistrarVentas.txt_igv.Text = CStr(igv_calculado)
    End Sub
    Public Sub agregar_producto()
        Dim precio_venta = (Val(RegistrarVentas.txt_precio.Text) * Val(RegistrarVentas.txt_cantidad.Text))
        With RegistrarVentas.list.Items.Add(RegistrarVentas.txt_codigo.Text)
            .SubItems.Add(RegistrarVentas.cb_productos.Text)
            .SubItems.Add(RegistrarVentas.txt_cantidad.Text)
            .SubItems.Add(RegistrarVentas.txt_precio.Text)
            .SubItems.Add(CStr(precio_venta))
        End With

    End Sub
    Public Sub calcular_precios()
        Dim subtotal As Double = 0
        For index = 0 To RegistrarVentas.list.Items.Count - 1
            subtotal += CDbl(RegistrarVentas.list.Items(index).SubItems(4).Text)
            'falta que calcule con decimal y no redondee'
        Next
        RegistrarVentas.txt_subtotal.Text = subtotal
    End Sub

    Public Sub obtener_fecha()
        If ConsultarVentas.rb_un_dia.Checked Then
            fecha_unica = ConsultarVentas.fecha_1.Value.Date.ToShortDateString()
            Try
                mostrar_lista_ventas_por_una_fecha(fecha_unica)
                ListaVentasFiltro.Show()
            Catch ex As Exception
                MessageBox.Show("No hay aun ventas registradas el dia de hoy", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try

        ElseIf ConsultarVentas.rb_rango_de_dia.Checked Then
            fecha_rg1 = ConsultarVentas.fecha_rango1.Value.Date.ToShortDateString()
            fecha_rg2 = ConsultarVentas.fecha_rango2.Value.Date.ToShortDateString()
            mostrar_lista_ventas_por_rango(fecha_rg1, fecha_rg2)
            ListaVentasFiltro.Show()
        End If
    End Sub

    Public Sub mostrar_lista_ventas_por_rango(fecha1 As String, fecha2 As String)

        '
        'Dim da As SqlDataAdapter
        Try
            Dim fun As New FConsultasAvanzadas
            dt = fun.FnVentaPorRangoDeFechas(fecha1, fecha2)
            If dt.Rows.Count > 0 Then
                ListaVentasFiltro.tabla_ventas.DataSource = dt
                ListaVentasFiltro.Show()
            Else
                ListaVentasFiltro.tabla_ventas.DataSource = Nothing
            End If


            'da = New SqlDataAdapter("mostrar_ventas_registradas_por_fecha", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@FECHA1", fecha_rg1)
            'da.SelectCommand.Parameters.AddWithValue("@FECHA2", fecha_rg2)
            'da.Fill(dt)
            ''Lista_ventas_registradas_rango.tabla_ventas.DataSource = dt

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_lista_ventas_por_una_fecha(fecha1 As String)
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        Try
            Dim fun As New FConsultasAvanzadas
            dt = fun.FnVentaPorFecha(fecha1)

            If dt.Rows.Count <> 0 Then
                ListaVentasFiltro.tabla_ventas.DataSource = dt
            Else
                ListaVentasFiltro.tabla_ventas.DataSource = Nothing
            End If

            'abrir()

            'da = New SqlDataAdapter("mostrar_ventas_registradas_por_una_sola_fecha", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@FECHA1", ConsultarVentas.fecha_unica)
            'da.Fill(dt)
            'tabla_ventas.DataSource = dt
            'cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub buscar_ventas_por_dni(lista As DataGridView, textbox As String)
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        Try
            'abrir()
            'da = New SqlDataAdapter("mostrar_ventas_registradas_por_dni", conexion)
            'da.SelectCommand.CommandType = 4
            'da.SelectCommand.Parameters.AddWithValue("@Documento_Cliente", txt_dni_compra.Text)
            'da.Fill(dt)
            'tabla_ventas.DataSource = dt
            'cerrar()

            Dim fun As New FConsultasAvanzadas
            dt = fun.FnVentaPorDni(textbox)
            If dt.Rows.Count > 0 Then
                lista.DataSource = dt
            Else
                lista.DataSource = Nothing
            End If

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_ventas_registradas()
        'Dim dt As New DataTable
        'Dim da As SqlDataAdapter
        Try

            Dim fun As New FConsultasAvanzadas
            dt = fun.FnMostrarVentas()
            If dt.Rows.Count <> 0 Then
                ListaVentasRegistradas.tabla_ventas.DataSource = dt
            Else
                ListaVentasRegistradas.tabla_ventas.DataSource = Nothing
            End If

            'da = New SqlDataAdapter("mostrar_ventas_registradas", conexion)
            'da.Fill(dt)
            'tabla_ventas.DataSource = dt

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub obtener_num_documento_venta()
        Try
            Dim func As New FDocumentoVenta
            nmax_documento_venta = func.FnObtenerNMaxDocumentoVenta()
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Public Sub obtener_cod_empleado()
    '    Try
    '        Dim func As New FEmpleado
    '        codigo_empleado = func.FnObtenerCodEmpleado(RegistrarVentas.label_empleado.Text)
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Public Sub registrar_documento_detalle()
        obtener_num_documento_venta()
        'obtener_cod_empleado()
        Try
            For index = 0 To RegistrarVentas.list.Items.Count - 1
                'abrir()
                'cmd = New SqlCommand("insertar_documento_detalle", conexion)
                'cmd.CommandType = 4
                'cmd.Parameters.AddWithValue("@Cod_Producto", list.Items(index).SubItems(0).Text)
                'cmd.Parameters.AddWithValue("@Cantidad", list.Items(index).SubItems(2).Text)
                'cmd.Parameters.AddWithValue("@Precio_Venta", list.Items(index).SubItems(4).Text)
                'cmd.Parameters.AddWithValue("@Cod_Empleado", codigo_empleado)
                'cmd.Parameters.AddWithValue("@Cod_Documento_Venta ", nmax_documento_venta)
                'cmd.ExecuteNonQuery()
                'cerrar()

                Dim funciones As New FDocumentoDetalle
                Dim logica As New VDocumento_detalle

                logica.gcod_producto = RegistrarVentas.list.Items(index).SubItems(0).Text
                logica.gcantidad = RegistrarVentas.list.Items(index).SubItems(2).Text
                logica.gprecio_venta = RegistrarVentas.list.Items(index).SubItems(4).Text
                logica.gcod_empleado = obtener_cod_empleado_activo()
                logica.gcod_documento_ventas = nmax_documento_venta
                funciones.FnInsertarDocumentoDetalle(logica)
            Next
            MsgBox("Registro de DOCUMENTO_Detalle Satisfactorio")
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub registrar_documento_venta()
        Dim subtotal = Convert.ToDecimal(RegistrarVentas.txt_subtotal.Text)
        Dim igv As Double = Convert.ToDecimal(RegistrarVentas.txt_igv.Text)
        Dim total As Double = Convert.ToDecimal(RegistrarVentas.label_total.Text)
        Try
            If RegistrarVentas.cb_tipo_documento.Text = "BOLETA" Then
                tipo_documento = "B"
            ElseIf RegistrarVentas.cb_tipo_documento.Text = "FACTURA" Then
                tipo_documento = "F"
            End If
            numero_factura = CStr(RegistrarVentas.label_n_factura.Text)
            Dim funciones As New FDocumentoVenta
            Dim logica As New VDocumento_Venta

            logica.gtipo = tipo_documento
            logica.gnumero_facturaboleta = numero_factura
            logica.gdocumento_cliente = RegistrarVentas.txt_dni.Text
            logica.gsubtotal = subtotal
            logica.gigv = igv
            logica.gtotal = total
            logica.gfecha_venta = Today

            If funciones.FnInsertarDocumentoVenta(logica) Then
                MsgBox("Registro de DOCUMENTO_VENTA Satisfactorio")
            End If
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_n_fuctura()
        Try
            Dim funciones As New FConsultasAvanzadas
            RegistrarVentas.label_n_factura.Text = CStr(funciones.FnObtenerNMaxFacturaMas1())

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub quitar_compra()
        Try
            indice = RegistrarVentas.list.FocusedItem.Index
            If indice <> -1 Then
                RegistrarVentas.list.Items.RemoveAt(indice)
            Else
                MsgBox("Por favor seleccione una compra para poder eliminar")
            End If
        Catch ex As Exception
            MsgBox("Seleccione una compra primero por favor")
        End Try

    End Sub

    Public Sub mostrar_imagenes()
        If RegistrarVentas.cb_productos.Text = "Pato" Then
            RegistrarVentas.imagen_producto.Image = SistemaVentas2.My.Resources.Resources.pato
        ElseIf RegistrarVentas.cb_productos.Text = "Gallina" Then
            RegistrarVentas.imagen_producto.Image = SistemaVentas2.My.Resources.Resources.gallina
        ElseIf RegistrarVentas.cb_productos.Text = "Huevo" Then
            RegistrarVentas.imagen_producto.Image = SistemaVentas2.My.Resources.Resources.huevo
        ElseIf RegistrarVentas.cb_productos.Text = "Pollo" Then
            RegistrarVentas.imagen_producto.Image = SistemaVentas2.My.Resources.Resources.pollo
        ElseIf RegistrarVentas.cb_productos.Text = "Pavo" Then
            RegistrarVentas.imagen_producto.Image = SistemaVentas2.My.Resources.Resources._2219786
        ElseIf RegistrarVentas.cb_productos.Text = "Pavita" Then
            RegistrarVentas.imagen_producto.Image = SistemaVentas2.My.Resources.Resources.pavita
        Else
            RegistrarVentas.imagen_producto.Image = SistemaVentas2.My.Resources.Resources._189665
        End If
    End Sub
    Public Sub mostrar_datos_productos()
        If RegistrarVentas.cb_productos.SelectedIndex Then
            RegistrarVentas.txt_cantidad.Text = ""
            Dim func As New FProducto
            func.FnMostrarCodigoPrecioProducto(RegistrarVentas.cb_productos, RegistrarVentas.txt_codigo, RegistrarVentas.txt_precio)
        End If
    End Sub

    Public Sub mostrar_clientes_load()
        Try
            Dim func As New FCliente
            func.FnLlenarComboNombresClientes(RegistrarVentas.cb_clientes)
        Catch ex As Exception : MessageBox.Show(ex.Message)
            MsgBox("el error esta aqui bro")
        End Try
    End Sub
    Public Sub mostrar_clientes()
        Try
            Dim func As New FCliente
            func.FnLlenarComboNombresClientes(RegistrarVentas.cb_clientes)
        Catch ex As Exception : MessageBox.Show(ex.Message)
            MsgBox("el error esta aqui bro")
        End Try
    End Sub
    Public Sub mostrar_productos()
        Try
            Dim func As New FProducto
            func.FnLlenarComboNombresProducto(RegistrarVentas.cb_productos)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cargarDatos()
        'parametros para que le list funcione bien'
        RegistrarVentas.list.GridLines = True
        RegistrarVentas.list.View = View.Details
        RegistrarVentas.list.FullRowSelect = True
        RegistrarVentas.txt_fecha.Text = Today
        mostrar_clientes()
        mostrar_clientes_load()
        mostrar_productos()
        RegistrarVentas.cb_clientes.DropDownStyle = ComboBoxStyle.DropDownList
        RegistrarVentas.cb_productos.DropDownStyle = ComboBoxStyle.DropDownList
        mostrar_n_fuctura()
        'RegistrarVentas.label_empleado.Text = panelprincipal2.label_usuario.Text

        'RegistrarVentas.label_empleado.Visible = False
    End Sub

    Public Sub llenarComboClient()
        If RegistrarVentas.cb_clientes.SelectedIndex Then
            RegistrarVentas.txt_cantidad.Text = ""
            Try
                Dim func As New FCliente
                func.FnLLenarDatosClienteTexbox(RegistrarVentas.cb_clientes, RegistrarVentas.txt_dni, RegistrarVentas.txt_telefono, RegistrarVentas.txt_direccion)
            Catch ex As Exception : MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub llenarComboProd()
        mostrar_datos_productos()
        mostrar_imagenes()
    End Sub

    Public Sub retirarProd()
        quitar_compra()
        calcular_total()
    End Sub

    Public Sub tipoDoc()
        If RegistrarVentas.cb_tipo_documento.Text = "FACTURA" Then
            RegistrarVentas.label_tdocumento.Text = "FAC-"
        End If

        If RegistrarVentas.cb_tipo_documento.Text = "BOLETA" Then
            RegistrarVentas.label_tdocumento.Text = "BOL-"
        End If
        'mostrar_n_fuctura()
    End Sub

    Public Sub agregarProd()
        If RegistrarVentas.txt_codigo.Text = "" Or RegistrarVentas.txt_cantidad.Text = "" Or RegistrarVentas.txt_precio.Text = "" Then
            MsgBox("Agregue un producto por favor")
        ElseIf RegistrarVentas.cb_tipo_documento.SelectedIndex = -1 Then
            MsgBox("Selecciona el tipo de documento")
        ElseIf Val(RegistrarVentas.txt_cantidad.Text) > 0 Then
            agregar_producto()
            calcular_precios()
            calcular_total()
        Else
            MsgBox("La cantidad del producto no puede ser < que 0")
        End If
    End Sub

    Public Sub limpiarCompras()
        RegistrarVentas.list.Items.Clear()
        RegistrarVentas.txt_cantidad.Text = ""
        RegistrarVentas.txt_subtotal.Text = ""
        RegistrarVentas.label_total.Text = "$ 0"
    End Sub

    Public Sub registrarVenta()
        Dim result As Integer = MessageBox.Show("Confirmacion de registro", "Mensaje Informativo", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            registrar_documento_venta()
            registrar_documento_detalle()
        End If
    End Sub

    Public Sub imprimir()

        If Convert.ToDecimal(Val(RegistrarVentas.txt_precio.Text)) > 0 Then
            If RegistrarVentas.cb_tipo_documento.Text = "FACTURA" Then
                Factura2.Show()
            ElseIf RegistrarVentas.cb_tipo_documento.Text = "BOLETA" Then
                Boleta.Show()
            End If
        Else
            MsgBox("Primero realiza una compra :)")
        End If
    End Sub

    Public Sub totalVentas(label As Label)
        Dim func As New FDocumentoVenta
        label.Text = func.FnObtenerTotalVentas.ToString
    End Sub

End Class
