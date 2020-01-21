Public Class CClientes
    Dim validacion
    Dim dt As New DataTable
    Public Sub FilaEliminarTabla(e As DataGridViewCellEventArgs)
        'Antes de hacer eso agregar la columna eliminar como checkbox'
        If e.ColumnIndex = AdministrarClientes.tablaclientes.Columns.Item("Eliminar").Index Then
            Dim check As DataGridViewCheckBoxCell = AdministrarClientes.tablaclientes.Rows(e.RowIndex).Cells("Eliminar")
            check.Value = Not check.Value
        End If
    End Sub
    Public Sub PasarDatosACajas()
        Try
            AdministrarClientes.txt_dni.Text = AdministrarClientes.tablaclientes.SelectedCells.Item(1).Value
            AdministrarClientes.txt_nombre.Text = AdministrarClientes.tablaclientes.SelectedCells.Item(2).Value
            AdministrarClientes.txt_telefono.Text = AdministrarClientes.tablaclientes.SelectedCells.Item(3).Value
            AdministrarClientes.txt_direccion.Text = AdministrarClientes.tablaclientes.SelectedCells.Item(4).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub validar_form()
        If AdministrarClientes.txt_dni.Text = "" Or AdministrarClientes.txt_nombre.Text = "" Or AdministrarClientes.txt_telefono.Text = "" Or AdministrarClientes.txt_direccion.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")
        Else
            validacion = True
        End If
    End Sub
    Public Sub actualizar_cliente()
        validar_form()
        If validacion Then
            Try
                Dim funciones As New FCliente
                Dim logica As New VCliente
                logica.gdocumento_cliente = AdministrarClientes.txt_dni.Text
                logica.gnombre_cliente = AdministrarClientes.txt_nombre.Text
                logica.gtelefono_cliente = AdministrarClientes.txt_telefono.Text
                logica.gdireccion_cliente = AdministrarClientes.txt_direccion.Text
                If funciones.FnActualizarClientes(logica) Then 'llamo a mi funcion creada en la  fclientes
                    MsgBox("Actulizacion de datos completo")
                    mostrar_clientes()
                End If
            Catch ex As Exception : MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Public Sub eliminar_cliente()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los cliente seleccionados", "Cliente Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In AdministrarClientes.tablaclientes.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Try
                        'dni_cliente es la fila donde obtendra el dato'
                        Dim dni_cliente = row.Cells("Documento_Cliente").Value
                        Dim funciones As New FCliente
                        Dim logica As New VCliente
                        logica.gdocumento_cliente = dni_cliente
                        If funciones.FnEliminarClientes(logica) Then 'llamo a mi funcion creada en la  fclientes
                            MsgBox("Se elimino correctamente")
                            mostrar_clientes()
                        End If
                    Catch ex As Exception
                        MsgBox("No se puede porque tiene relacion con algun documento")

                    End Try
                End If
            Next
        End If
    End Sub

    Public Sub mostrar_clientes()
        Try
            Dim fun As New FCliente
            dt = fun.FnMostrarClientes
            If dt.Rows.Count > 0 Then
                AdministrarClientes.tablaclientes.DataSource = dt 'igualo el origen de datos de mi tabla con dt
            Else
                AdministrarClientes.tablaclientes.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub insertar_clientes()
        validar_form()
        If validacion Then
            Dim funciones As New FCliente
            Dim logica As New VCliente
            logica.gdocumento_cliente = AdministrarClientes.txt_dni.Text
            logica.gnombre_cliente = AdministrarClientes.txt_nombre.Text
            logica.gtelefono_cliente = AdministrarClientes.txt_telefono.Text
            logica.gdireccion_cliente = AdministrarClientes.txt_direccion.Text
            If funciones.FnInsertarClientes(logica) Then 'llamo a mi funcion creada en la  fclientes
                MsgBox("insertado completo")
                mostrar_clientes()

            End If
        Else
            MsgBox("Error al completar sus datos,Vuelva a intentarlo")
        End If
    End Sub

    Public Sub mostrar_clientes_dni()
        Try
            Dim func As New FCliente
            func.FnLlenarComboDNIClientes(AdministrarClientes.cb_dni)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub buscar_clienteDNI()
        Try
            Dim fun As New FCliente '
            Dim logica As New VCliente
            logica.gdocumento_cliente = AdministrarClientes.cb_dni.Text
            dt = fun.FnBuscarClienteDNIMostrar(logica)
            AdministrarClientes.tablaclientes.DataSource = dt 'igualo el origen de datos de mi tabla con dt
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    'PARA EL FRAME
    Public Sub cargarCliente()
        'propiedades para mostrar datos'
        AdministrarClientes.tablaclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        AdministrarClientes.tablaclientes.AllowUserToAddRows = False
        AdministrarClientes.tablaclientes.AllowUserToResizeRows = False
        mostrar_clientes()
        mostrar_clientes_dni()
    End Sub

    Public Sub agregarCliente()
        insertar_clientes()
        mostrar_clientes_dni()
        'RegistrarVentas.mostrar_clientes()
    End Sub

    Public Sub eliminarCliente()
        eliminar_cliente()
        mostrar_clientes_dni()
    End Sub

    Public Sub actualizarCliente()
        actualizar_cliente()
        mostrar_clientes_dni()
    End Sub

End Class
