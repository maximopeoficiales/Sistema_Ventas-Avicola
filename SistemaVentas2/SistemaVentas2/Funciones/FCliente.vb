Imports System.Data.SqlClient

Public Class FCliente
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarClientes() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_clientes") 'mi procedimiento almacenado ya hecho'
            cmd.CommandType = CommandType.StoredProcedure 'tipo proc almacenado
            cmd.Connection = cnn 'cnn ya tiene la conexion
            'si tiene resultado el comando
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) 'los resultados se guardan en da
                da.Fill(dt) 'lleno los datos en un datatable
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo
            Return Nothing
        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Function

    Public Function FnInsertarClientes(ByVal dts As VCliente) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Documento_Cliente", dts.gdocumento_cliente)
            cmd.Parameters.AddWithValue("@Nombre_Cliente", dts.gnombre_cliente)
            cmd.Parameters.AddWithValue("@Telefono_Cliente", dts.gtelefono_cliente)
            cmd.Parameters.AddWithValue("@Direccion_Cliente", dts.gdireccion_cliente)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Ya existe un usuario con ese nombre")
            Return False
        Finally
            FnDesconectado()
        End Try
    End Function

    Public Function FnActualizarClientes(ByVal dts As VCliente) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Documento_Cliente", dts.gdocumento_cliente)
            cmd.Parameters.AddWithValue("@Nombre_Cliente", dts.gnombre_cliente)
            cmd.Parameters.AddWithValue("@Telefono_Cliente", dts.gtelefono_cliente)
            cmd.Parameters.AddWithValue("@Direccion_Cliente", dts.gdireccion_cliente)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()
        End Try
    End Function

    Public Function FnEliminarClientes(ByVal dts As VCliente) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Documento_Cliente", dts.gdocumento_cliente)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se puede borrar este cliente tiene compras hechas")
            Return False
        Finally
            FnDesconectado()
        End Try
    End Function

    Public Function FnBuscarClienteDNIMostrar(ByVal dts As VCliente) As DataTable
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            FnConectado()
            da = New SqlDataAdapter("SELECT *FROM Cliente WHERE Documento_Cliente=" + "'" + dts.gdocumento_cliente + "'", cnn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            FnDesconectado()
        End Try
    End Function

    Public Sub FnLlenarComboNombresClientes(ByRef combo As ComboBox)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter 'conjunto de comandos para rellenar un dataset'
        Dim datos As DataSet 'datos en memoria'
        Try
            FnConectado()
            da = New SqlDataAdapter("mostrar_clientes", cnn)
            datos = New DataSet
            datos.Tables.Add("Cliente") 'se agregaron los datos de la tabla proovedor'
            da.Fill(datos.Tables("Cliente")) 'lo agrega a un tabla'
            combo.DataSource = datos.Tables("Cliente") 'la informacion de la tabla se guarda en combobox'
            combo.DisplayMember = "Nombre_Cliente" 'Pero solo mostrara los nombres'
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo

        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Sub

    Public Sub FnLlenarComboDNIClientes(ByRef combo As ComboBox)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter 'conjunto de comandos para rellenar un dataset'
        Dim datos As DataSet 'datos en memoria'
        Try
            FnConectado()
            da = New SqlDataAdapter("mostrar_clientes", cnn)
            datos = New DataSet
            datos.Tables.Add("Cliente") 'se agregaron los datos de la tabla proovedor'
            da.Fill(datos.Tables("Cliente")) 'lo agrega a un tabla'
            combo.DataSource = datos.Tables("Cliente") 'la informacion de la tabla se guarda en combobox'
            combo.DisplayMember = "Documento_Cliente" 'Pero solo mostrara los nombres'
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo

        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Sub
    Public Sub FnLLenarDatosClienteTexbox(cb_clientes As ComboBox, txt_dni As TextBox, txt_telefono As TextBox, txt_direccion As TextBox)
        Try
            FnConectado()
            cmd = New SqlCommand("SELECT * FROM Cliente WHERE Nombre_Cliente=" + "'" + cb_clientes.Text + "'", cnn)
            'indica que va ser con comandos'
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txt_dni.Text = CStr(reader("Documento_Cliente"))
                txt_telefono.Text = CStr(reader("Telefono_Cliente"))
                txt_direccion.Text = CStr(reader("Direccion_Cliente"))
            End If
            FnDesconectado()
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
End Class
