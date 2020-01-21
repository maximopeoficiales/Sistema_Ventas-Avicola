Imports System.Data.SqlClient
Public Class FProveedor
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarProveedores() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_proveedores", cnn) 'mi procedimiento almacenado ya hecho'
            cmd.CommandType = CommandType.StoredProcedure 'tipo proc almacenado
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

    Public Function FnInsertarProveedor(ByVal dts As VProveedor) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_proveedor", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Cod_Proveedor", dts.gcod_proveedor)
            cmd.Parameters.AddWithValue("@Nombre_Proveedor", dts.gnombre_proveedor)
            cmd.Parameters.AddWithValue("@Direccion_Proveedor", dts.gdireccion_proveedor)
            cmd.Parameters.AddWithValue("@Telefono_Proveedor", dts.gtelefono_proveedor)

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

    Public Function FnActualizarProveedor(ByVal dts As VProveedor) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_proveedor", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Cod_Proveedor", dts.gcod_proveedor)
            cmd.Parameters.AddWithValue("@Nombre_Proveedor", dts.gnombre_proveedor)
            cmd.Parameters.AddWithValue("@Direccion_Proveedor", dts.gdireccion_proveedor)
            cmd.Parameters.AddWithValue("@Telefono_Proveedor", dts.gtelefono_proveedor)

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

    Public Function FnEliminarProveedor(cod_proveedor) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_proveedor", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Cod_Proveedor", cod_proveedor)
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
    Public Function FnObtenerMaxProovedores()
        Try
            FnConectado()
            cmd = New SqlCommand("SELECT count(*) FROM Proveedor", cnn)
            Dim nmax_proveedores = CInt(cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return nmax_proveedores
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
    Public Sub FnLlenarComboCodigoProveedor(ByRef combo As ComboBox)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter 'conjunto de comandos para rellenar un dataset'
        Dim datos As DataSet 'datos en memoria'
        Try
            FnConectado()
            da = New SqlDataAdapter("mostrar_proveedores", cnn)
            datos = New DataSet
            datos.Tables.Add("Proveedor") 'se agregaron los datos de la tabla proovedor'
            da.Fill(datos.Tables("Proveedor")) 'lo agrega a un tabla'
            combo.DataSource = datos.Tables("Proveedor") 'la informacion de la tabla se guarda en combobox'
            combo.DisplayMember = "Cod_Proveedor" 'Pero solo mostrara lo que escriba'
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo

        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Sub

End Class
