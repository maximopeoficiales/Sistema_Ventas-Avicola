Imports System.Data.SqlClient
Public Class FProducto
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarProductos() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_productos") 'mi procedimiento almacenado ya hecho'
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

    Public Function FnInsertarProductos(ByVal dts As VProductos) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_producto", dts.gcod_producto)
            cmd.Parameters.AddWithValue("@Nombre_producto", dts.gnombre_producto)
            cmd.Parameters.AddWithValue("@Precio_xkg", CDbl(dts.gprecio_xkg))
            cmd.Parameters.AddWithValue("@Stock", CDbl(dts.gstock))
            cmd.Parameters.AddWithValue("@Cod_Proveedor", dts.gcod_proovedor)

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

    Public Function FnActualizarProducto(ByVal dts As VProductos) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cod_producto", (dts.gcod_producto))
            cmd.Parameters.AddWithValue("@Nombre_producto", dts.gnombre_producto)
            cmd.Parameters.AddWithValue("@Precio_xkg", CDbl(dts.gprecio_xkg))
            cmd.Parameters.AddWithValue("@Stock", CDbl(dts.gstock))
            cmd.Parameters.AddWithValue("@Cod_Proveedor", dts.gcod_proovedor)

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

    Public Function FnEliminarProducto(ByVal dts As VProductos) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cod_producto", dts.gcod_producto)

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

    Public Function FnBuscarPorNombre(ByVal dts As VProductos) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("buscar_xnombres_productos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nombre_producto", dts.gnombre_producto)

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

    Public Function FnMostrarTopMenorCantidadProducto() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("TopMenorCantidadProductos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
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

    Public Function FnMostrarElProductoDeMenorStock() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("menor_cantidad_productos_stock") 'mi procedimiento almacenado ya hecho'
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


    Public Sub FnLlenarComboNombresProducto(ByRef combo As ComboBox)
        Dim da As SqlDataAdapter 'conjunto de comandos para rellenar un dataset'
        Dim datos As DataSet 'datos en memoria'
        Try
            FnConectado()
            da = New SqlDataAdapter("nombres_productos", cnn)
            datos = New DataSet
            da.Fill(datos) 'lleno los datos
            combo.DataSource = datos.Tables(0)
            combo.DisplayMember = "Nombre_Producto"
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo

        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Sub

    Public Sub FnRellenarTextBoxProductos(cb_productos As ComboBox, codigo_proovedor As ComboBox, cod_producto As TextBox, nombre As TextBox, precio As TextBox, stock As TextBox)
        Try
            FnConectado()
            cmd = New SqlCommand("buscar_xnombres_productos", cnn)
            'indica que va ser con comandos'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Nombre_Producto", cb_productos.Text)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                codigo_proovedor.Text = CStr(reader("Cod_Proveedor"))
                cod_producto.Text = CStr(reader("Cod_Producto"))
                nombre.Text = CStr(reader("Nombre_producto"))
                precio.Text = CStr(reader("Precio_xkg"))
                stock.Text = CStr(reader("Stock"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try

    End Sub

    Public Sub FnMostrarCodigoPrecioProducto(cb_productos As ComboBox, txt_codigo As TextBox,txt_precio As TextBox)
        Try
            FnConectado()
            cmd = New SqlCommand("SELECT *FROM Productos WHERE Nombre_Producto=" + "'" + cb_productos.Text + "'", cnn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txt_codigo.Text = CStr(reader("Cod_Producto"))
                txt_precio.Text = CStr(reader("Precio_xkg"))
            End If
            FnDesconectado()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
        txt_codigo.ReadOnly = True
        txt_precio.ReadOnly = True
    End Sub

End Class
