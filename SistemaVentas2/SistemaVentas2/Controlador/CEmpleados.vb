Public Class CEmpleados
    Dim validacion = False
    Dim dt As New DataTable
    Public Sub Contar_Empleado()
        Dim fun As New FEmpleado
        AdministrarEmpleados.label_cantidad_emp.Text = fun.FnObtenerNumeroEmpleados
    End Sub
    Public Sub mostrarempleados()
        Try
            Dim fun As New FEmpleado
            dt = fun.FnMostrarEmpleadosDueno
            If dt.Rows.Count > 0 Then
                ListaEmpleados.tabla_empleados.DataSource = dt
            Else
                ListaEmpleados.tabla_empleados.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub Validacion_Form()

        If AdministrarEmpleados.txt_nombre.Text = "" Or AdministrarEmpleados.txt_usuario.Text = "" Or AdministrarEmpleados.txt_contraseña.Text = "" Or AdministrarEmpleados.txt_nueva_contraseña.Text = "" Then
            validacion = False
            MsgBox("Completa todos los campos")
            'validacion de contraseñas iguales'
        ElseIf AdministrarEmpleados.txt_contraseña.Text = AdministrarEmpleados.txt_nueva_contraseña.Text Then
            validacion = True
        Else
            validacion = False
            MsgBox("Las contraseñas deben ser iguales Por favor")
        End If
    End Sub

    Public Sub validacion_actualizar()
        If AdministrarEmpleados.txt_nombre.Text = "" Or AdministrarEmpleados.txt_usuario.Text = "" Or AdministrarEmpleados.txt_contraseña.Text = "" Or AdministrarEmpleados.txt_nueva_contraseña.Text = "" Then
            validacion = False
            MsgBox("Completa todos los campos")
        Else
            validacion = True
        End If
    End Sub

    Public Sub Registrar_Empleado()
        Validacion_Form()
        If validacion Then
            Try
                Dim funciones As New FEmpleado
                Dim logica As New VEmpleados
                logica.gtipo = AdministrarEmpleados.cb_tipo_empleado.Text
                logica.gnombre = AdministrarEmpleados.txt_nombre.Text
                logica.gusuario = AdministrarEmpleados.txt_usuario.Text
                logica.gcontrasena = AdministrarEmpleados.txt_contraseña.Text

                If funciones.FnInsertarEmpleado(logica) Then
                    MsgBox("Usuario Registrado")
                    mostrarempleados()
                End If

                MsgBox("Registro de Usuario Satisfactorio")
            Catch ex As Exception : MsgBox(ex.Message)

            End Try
        Else
            MsgBox("Error completo sus datos")

        End If

    End Sub

    Public Sub Actualizar_Empleado()
        validacion_actualizar()
        If validacion Then
            Try

                Dim funciones As New FEmpleado
                Dim logica As New VEmpleados

                logica.gcod_empleado = AdministrarEmpleados.cod_empleado_txt.Text
                logica.gtipo = AdministrarEmpleados.cb_tipo_empleado.Text
                logica.gnombre = AdministrarEmpleados.txt_nombre.Text
                logica.gusuario = AdministrarEmpleados.txt_usuario.Text
                logica.gcontrasena = AdministrarEmpleados.txt_nueva_contraseña.Text

                If funciones.FnActualizarEmpleado(logica) Then 'llamo a mi funcion creada en fempleado
                    MsgBox("Actulizacion de datos completo")
                    mostrarempleados()
                End If


            Catch ex As Exception : MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Public Sub ObtenerDatosATextBox()
        Try
            AdministrarEmpleados.cod_empleado_txt.Text = ListaEmpleados.tabla_empleados.SelectedCells.Item(1).Value
            AdministrarEmpleados.cb_tipo_empleado.Text = ListaEmpleados.tabla_empleados.SelectedCells.Item(2).Value
            AdministrarEmpleados.txt_nombre.Text = ListaEmpleados.tabla_empleados.SelectedCells.Item(3).Value
            AdministrarEmpleados.txt_usuario.Text = ListaEmpleados.tabla_empleados.SelectedCells.Item(4).Value

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub ActivarCheckTable(e As DataGridViewCellEventArgs)
        'Antes de hacer eso agregar la columna eliminar como checkbox'
        If e.ColumnIndex = ListaEmpleados.tabla_empleados.Columns.Item("Eliminar").Index Then
            Dim check As DataGridViewCheckBoxCell = ListaEmpleados.tabla_empleados.Rows(e.RowIndex).Cells("Eliminar")
            check.Value = Not check.Value
        End If
    End Sub

    Public Sub Eliminar_Empleados()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los registros seleccionados", "Registro Eliminado",
                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In ListaEmpleados.tabla_empleados.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Try
                        Dim usuario = row.Cells("cod_empleado").Value
                        Dim funciones As New FEmpleado
                        Dim logica As New VEmpleados
                        logica.gcod_empleado = usuario
                        If funciones.FnEliminarEmpleado(logica) Then 'llamo a mi funcion creada en la  fclientes
                            MsgBox("Se elimino correctamente")
                            ListaEmpleados.tabla_empleados.DataSource = funciones.FnMostrarEmpleadosDueno
                        End If
                    Catch ex As Exception
                        MsgBox("No se puede porque tiene relacion con algun documento")
                    End Try
                End If
            Next
        End If

    End Sub

    'PARA EL FRAME
    Public Sub LimpiarCampos()
        AdministrarEmpleados.txt_usuario.Text = ""
        AdministrarEmpleados.txt_nombre.Text = ""
    End Sub

    Public Sub agregarEmp()
        Registrar_Empleado()
        Contar_Empleado()
    End Sub

    Public Sub actualizarEmp()
        Actualizar_Empleado()
    End Sub

    Public Sub mostrarPass(textbox As TextBox, check As PictureBox, uncheck As PictureBox)
        textbox.PasswordChar = ""
        check.Hide()
        uncheck.Show()
    End Sub

    Public Sub noMostrarPass(textbox As TextBox, check As PictureBox, uncheck As PictureBox)
        textbox.PasswordChar = "*"
        uncheck.Hide()
        check.Show()
    End Sub

    Public Sub listaDeEmpleados()
        mostrarempleados()
        'opcion para que funcione el doble click'
        ListaEmpleados.tabla_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ListaEmpleados.tabla_empleados.AllowUserToAddRows = False
        ListaEmpleados.tabla_empleados.AllowUserToResizeRows = False
    End Sub

    Public Sub eliminarEmp()
        Eliminar_Empleados()
        LimpiarCampos()
        mostrarempleados()
        Contar_Empleado()
    End Sub

End Class
