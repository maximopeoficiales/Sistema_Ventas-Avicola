Imports System.Data
Imports System.Data.SqlClient
Imports System

Public Class RegistrarVentas
    Dim c As New CVentas
    'Dim indice
    'Dim codigo_empleado
    'Dim tipo_documento
    'Dim numero_factura
    'Dim cmd As New SqlCommand
    'Dim nmax_documento_venta
    'Private Sub obtener_num_documento_venta()
    '    Try
    '        Dim func As New FConsultasAvanzadas
    '        nmax_documento_venta = func.FnObtenerNMaxFacturaMas1()
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Private Sub obtener_cod_empleado()
    '    Try
    '        Dim func As New FEmpleado
    '        codigo_empleado = func.FnObtenerCodEmpleado(label_empleado.Text)
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub registrar_documento_detalle()
    '    obtener_num_documento_venta()
    '    obtener_cod_empleado()
    '    Try
    '        For index = 0 To list.Items.Count - 1
    '            'abrir()
    '            'cmd = New SqlCommand("insertar_documento_detalle", conexion)
    '            'cmd.CommandType = 4
    '            'cmd.Parameters.AddWithValue("@Cod_Producto", list.Items(index).SubItems(0).Text)
    '            'cmd.Parameters.AddWithValue("@Cantidad", list.Items(index).SubItems(2).Text)
    '            'cmd.Parameters.AddWithValue("@Precio_Venta", list.Items(index).SubItems(4).Text)
    '            'cmd.Parameters.AddWithValue("@Cod_Empleado", codigo_empleado)
    '            'cmd.Parameters.AddWithValue("@Cod_Documento_Venta ", nmax_documento_venta)
    '            'cmd.ExecuteNonQuery()
    '            'cerrar()

    '            Dim funciones As New FDocumentoDetalle
    '            Dim logica As New VDocumento_detalle

    '            logica.gcod_producto = list.Items(index).SubItems(0).Text
    '            logica.gcantidad = list.Items(index).SubItems(2).Text
    '            logica.gprecio_venta = list.Items(index).SubItems(4).Text
    '            logica.gcod_empleado = codigo_empleado
    '            logica.gcod_documento_ventas = nmax_documento_venta

    '        Next
    '        MsgBox("Registro de DOCUMENTO_Detalle Satisfactorio")
    '    Catch ex As Exception : MsgBox(ex.Message)
    '    End Try

    'End Sub

    'Private Sub registrar_documento_venta()
    '    Dim subtotal = Convert.ToDecimal(txt_subtotal.Text)
    '    Dim igv As Double = Convert.ToDecimal(txt_igv.Text)
    '    Dim total As Double = Convert.ToDecimal(label_total.Text)
    '    Try
    '        If cb_tipo_documento.Text = "BOLETA" Then
    '            tipo_documento = "B"
    '        ElseIf cb_tipo_documento.Text = "FACTURA" Then
    '            tipo_documento = "F"
    '        End If
    '        numero_factura = CStr(label_n_factura.Text)
    '        Dim funciones As New FDocumentoVenta
    '        Dim logica As New VDocumento_Venta

    '        logica.gtipo = tipo_documento
    '        logica.gnumero_facturaboleta = numero_factura
    '        logica.gdocumento_cliente = txt_dni.Text
    '        logica.gsubtotal = subtotal
    '        logica.gigv = igv
    '        logica.gtotal = total
    '        logica.gfecha_venta = Today

    '        If funciones.FnInsertarDocumentoVenta(logica) Then
    '            MsgBox("Registro de DOCUMENTO_VENTA Satisfactorio")
    '        End If
    '    Catch ex As Exception : MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub mostrar_n_fuctura()
    '    Try
    '        Dim funciones As New FConsultasAvanzadas
    '        label_n_factura = funciones.FnObtenerNMaxFacturaMas1()

    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub calcular_total()
    '    Dim igv = 18 / 100
    '    Dim igv_calculado As Double = CDbl(txt_subtotal.Text) * igv
    '    Dim subtotal As Double = (igv_calculado + CDbl(txt_subtotal.Text))
    '    label_total.Text = CStr(subtotal)
    '    txt_igv.Text = CStr(igv_calculado)
    'End Sub
    'Private Sub agregar_producto()
    '    Dim precio_venta = (Val(txt_precio.Text) * Val(txt_cantidad.Text))
    '    With list.Items.Add(txt_codigo.Text)
    '        .SubItems.Add(cb_productos.Text)
    '        .SubItems.Add(txt_cantidad.Text)
    '        .SubItems.Add(txt_precio.Text)
    '        .SubItems.Add(CStr(precio_venta))
    '    End With

    'End Sub
    'Private Sub calcular_precios()
    '    Dim subtotal As Double = 0
    '    For index = 0 To list.Items.Count - 1
    '        subtotal += CDbl(list.Items(index).SubItems(4).Text)
    '        'falta que calcule con decimal y no redondee'
    '    Next
    '    txt_subtotal.Text = subtotal
    'End Sub
    'Private Sub quitar_compra()
    '    Try
    '        indice = list.FocusedItem.Index
    '        If indice <> -1 Then
    '            list.Items.RemoveAt(indice)
    '        Else
    '            MsgBox("Por favor seleccione una compra para poder eliminar")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Seleccione una compra primero por favor")
    '    End Try

    'End Sub
    'Private Sub mostrar_imagenes()
    '    If cb_productos.Text = "Pato" Then
    '        imagen_producto.Image = SistemaVentas2.My.Resources.Resources.pato
    '    ElseIf cb_productos.Text = "Gallina" Then
    '        imagen_producto.Image = SistemaVentas2.My.Resources.Resources.gallina
    '    ElseIf cb_productos.Text = "Huevo" Then
    '        imagen_producto.Image = SistemaVentas2.My.Resources.Resources.huevo
    '    ElseIf cb_productos.Text = "Pollo" Then
    '        imagen_producto.Image = SistemaVentas2.My.Resources.Resources.pollo
    '    ElseIf cb_productos.Text = "Pavo" Then
    '        imagen_producto.Image = SistemaVentas2.My.Resources.Resources._2219786
    '    ElseIf cb_productos.Text = "Pavita" Then
    '        imagen_producto.Image = SistemaVentas2.My.Resources.Resources.pavita
    '    Else
    '        imagen_producto.Image = SistemaVentas2.My.Resources.Resources._189665
    '    End If
    'End Sub
    'Private Sub mostrar_datos_productos()
    '    If cb_productos.SelectedIndex Then
    '        txt_cantidad.Text = ""
    '        Dim func As New FProducto
    '        func.FnMostrarCodigoPrecioProducto(cb_productos, txt_codigo, txt_precio)
    '    End If
    'End Sub
    'Private Sub mostrar_clientes_load()
    '    'Try
    '    '    abrir()
    '    '    cmd = New SqlCommand("SELECT *FROM Cliente WHERE Nombre_Cliente=" + "'" + cb_clientes.Text + "'", conexion)
    '    '    Dim reader As SqlDataReader = cmd.ExecuteReader()
    '    '    If reader.Read() Then
    '    '        txt_dni.Text = CStr(reader("Documento_Cliente"))
    '    '        txt_telefono.Text = CStr(reader("Telefono_Cliente"))
    '    '        txt_direccion.Text = CStr(reader("Direccion_Cliente"))
    '    '    End If
    '    '    cerrar()
    '    'Catch ex As Exception : MsgBox(ex.Message)
    '    'End Try
    'End Sub
    'Public Sub mostrar_clientes()
    '    Try
    '        Dim func As New FCliente
    '        func.FnLlenarComboNombresClientes(cb_clientes)
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Private Sub mostrar_productos()
    '    Try
    '        Dim func As New FProducto
    '        func.FnLlenarComboNombresProducto(cb_productos)
    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Private Sub RegistrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'parametros para que le list funcione bien'
        'list.GridLines = True
        'list.View = View.Details
        'list.FullRowSelect = True
        'txt_fecha.Text = Today
        'mostrar_clientes()
        'mostrar_clientes_load()
        'mostrar_productos()
        'cb_clientes.DropDownStyle = ComboBoxStyle.DropDownList
        'cb_productos.DropDownStyle = ComboBoxStyle.DropDownList
        'mostrar_n_fuctura()
        'label_empleado.Text = panelprincipal2.label_usuario.Text
        'label_empleado.Visible = False
        c.cargarDatos()
    End Sub

    Private Sub cb_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_clientes.SelectedIndexChanged
        'If cb_clientes.SelectedIndex Then
        '    txt_cantidad.Text = ""
        '    Try
        '        Dim func As New FProducto
        '        func.FnMostrarCodigoPrecioProducto(cb_productos, txt_codigo, txt_precio)
        '    Catch ex As Exception : MsgBox(ex.Message)
        '    End Try
        'End If
        c.llenarComboClient()

    End Sub

    Private Sub cb_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_productos.SelectedIndexChanged
        'mostrar_datos_productos()
        'mostrar_imagenes()
        c.llenarComboProd()

    End Sub
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_eliminar_compras.Click
        'quitar_compra()
        'calcular_total()
        c.retirarProd()
    End Sub

    Private Sub cb_tipo_documento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo_documento.SelectedIndexChanged
        'If cb_tipo_documento.Text = "FACTURA" Then
        '    label_tdocumento.Text = "FAC-"
        'End If

        'If cb_tipo_documento.Text = "BOLETA" Then
        '    label_tdocumento.Text = "BOL-"
        'End If
        'mostrar_n_fuctura()
        c.tipoDoc()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'If txt_codigo.Text = "" Or txt_cantidad.Text = "" Or txt_precio.Text = "" Then
        '    MsgBox("Agregue un producto por favor")
        'ElseIf cb_tipo_documento.SelectedIndex = -1 Then
        '    MsgBox("Selecciona el tipo de documento")
        'ElseIf Val(txt_cantidad.Text) > 0 Then
        '    agregar_producto()
        '    calcular_precios()
        '    calcular_total()
        'Else
        '    MsgBox("La cantidad del producto no puede ser < que 0")
        'End If
        c.agregarProd()
    End Sub

    Private Sub btn_limpiar_compras_Click(sender As Object, e As EventArgs) Handles btn_limpiar_compras.Click
        'list.Items.Clear()
        'txt_cantidad.Text = ""
        'txt_subtotal.Text = ""
        'label_total.Text = "$ 0"
        c.limpiarCompras()
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click

        'Dim result As Integer = MessageBox.Show("Confirmacion de registro", "Mensaje Informativo", MessageBoxButtons.YesNo)
        'If result = DialogResult.No Then
        '    MessageBox.Show("No pressed")
        'ElseIf result = DialogResult.Yes Then
        '    MessageBox.Show("Yes pressed")
        '    registrar_documento_venta()
        '    registrar_documento_detalle()
        'End If

        c.registrarVenta()
        c.totalVentas(ConsultarVentas.label_ventas_totales)
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If Convert.ToDecimal(Val(txt_precio.Text)) > 0 Then
            If cb_tipo_documento.Text = "FACTURA" Then
                Factura2.Show()
            ElseIf cb_tipo_documento.Text = "BOLETA" Then
                Boleta.Show()
            End If
        Else
            MsgBox("Primero realiza una compra :)")
        End If
    End Sub
End Class