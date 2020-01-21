Public Class CProveedores

    Dim validacion
    Dim dt As New DataTable

    Public Sub validar_form()
        If AdministrarProvedores.txt_codigo_prov.Text = "" Or AdministrarProvedores.txt_nombre.Text = "" Or AdministrarProvedores.txt_direccion.Text = "" Or AdministrarProvedores.txt_telefono.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")
        Else
            validacion = True
        End If
    End Sub

    Public Sub mostrar_proovedores()
        Try
            Dim fun As New FProveedor
            dt = fun.FnMostrarProveedores
            If dt.Rows.Count > 0 Then
                AdministrarProvedores.tabla_proovedores.DataSource = dt 'igualo el origen de datos de mi tabla con dt
            Else
                AdministrarProvedores.tabla_proovedores.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub PasarDatosACajas()
        Try
            AdministrarProvedores.txt_codigo_prov.Text = AdministrarProvedores.tabla_proovedores.SelectedCells.Item(1).Value
            AdministrarProvedores.txt_nombre.Text = AdministrarProvedores.tabla_proovedores.SelectedCells.Item(2).Value
            AdministrarProvedores.txt_direccion.Text = AdministrarProvedores.tabla_proovedores.SelectedCells.Item(3).Value
            AdministrarProvedores.txt_telefono.Text = AdministrarProvedores.tabla_proovedores.SelectedCells.Item(4).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub MostrarChecktable(e As DataGridViewCellEventArgs)
        'Antes de hacer eso agregar la columna eliminar como checkbox'
        If e.ColumnIndex = AdministrarProvedores.tabla_proovedores.Columns.Item("Eliminar").Index Then
            Dim check As DataGridViewCheckBoxCell = AdministrarProvedores.tabla_proovedores.Rows(e.RowIndex).Cells("Eliminar")
            check.Value = Not check.Value
        End If
    End Sub

    Public Sub actualizar_proveedor()
        validar_form()
        If validacion Then
            Try

                Dim funciones As New FProveedor
                Dim logica As New VProveedor()
                logica.gcod_proveedor = AdministrarProvedores.txt_codigo_prov.Text
                logica.gnombre_proveedor = AdministrarProvedores.txt_nombre.Text
                logica.gdireccion_proveedor = AdministrarProvedores.txt_direccion.Text
                logica.gtelefono_proveedor = AdministrarProvedores.txt_telefono.Text
                If funciones.FnActualizarProveedor(logica) Then 'llamo a mi funcion creada en la  fclientes
                    MsgBox("Actualizacion completa")
                    mostrar_proovedores()
                End If

            Catch ex As Exception : MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub eliminar_proveedor()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los proveedores seleccionados", "Cliente Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In AdministrarProvedores.tabla_proovedores.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Try
                        'dni_cliente es la fila donde obtendra el dato'
                        Dim cod_proveedor = row.Cells("Cod_proveedor").Value
                        Dim funciones As New FProveedor
                        If funciones.FnEliminarProveedor(cod_proveedor) Then
                            MsgBox("Se elimino correctamente")
                            mostrar_proovedores()
                        End If
                    Catch ex As Exception
                        MsgBox("No se puede porque tiene relacion con algun documento")
                    End Try
                End If
            Next
        End If
    End Sub

    Public Sub registrar_proovedores()
        validar_form()
        If validacion Then
            Try
                Dim funciones As New FProveedor
                Dim logica As New VProveedor()
                logica.gcod_proveedor = AdministrarProvedores.txt_codigo_prov.Text
                logica.gnombre_proveedor = AdministrarProvedores.txt_nombre.Text
                logica.gdireccion_proveedor = AdministrarProvedores.txt_direccion.Text
                logica.gtelefono_proveedor = AdministrarProvedores.txt_telefono.Text

                If funciones.FnInsertarProveedor(logica) Then 'llamo a mi funcion creada en la  fclientes
                    MsgBox("insertado completo")
                    mostrar_proovedores()
                End If
            Catch ex As Exception : MsgBox(ex.Message)
                MsgBox("Error al registrar proovedor")
            End Try
        Else
            MsgBox("Error al completar sus datos,Vuelva a intentarlo")
        End If
    End Sub

    'PARA EL FRAME
    Public Sub cargarProv()
        AdministrarProvedores.tabla_proovedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        AdministrarProvedores.tabla_proovedores.AllowUserToAddRows = False
        AdministrarProvedores.tabla_proovedores.AllowUserToResizeRows = False
        mostrar_proovedores()
    End Sub

End Class
