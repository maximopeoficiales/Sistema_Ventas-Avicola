Imports System.Data.SqlClient
Public Class FEmpleado
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarEmpleadosDueno() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_empleados_dueno") 'mi procedimiento almacenado ya hecho'
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

    'mostrar empleados sin contrasena'
    Public Function FnMostrarEmpleadosVendedor() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_empleados_vendedor") 'mi procedimiento almacenado ya hecho'
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

    Public Function FnInsertarEmpleado(ByVal dts As VEmpleados) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Tipo", dts.gtipo)
            cmd.Parameters.AddWithValue("@Nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@Usuario", dts.gusuario)
            cmd.Parameters.AddWithValue("@Contrasena", dts.gcontrasena)

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

    Public Function FnActualizarEmpleado(ByVal dts As VEmpleados) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_empleado", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@cod_empleado", CInt(dts.gcod_empleado))
            cmd.Parameters.AddWithValue("@Tipo", dts.gtipo)
            cmd.Parameters.AddWithValue("@Nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@Usuario", dts.gusuario)
            cmd.Parameters.AddWithValue("@Contrasena", dts.gcontrasena)

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

    Public Function FnEliminarEmpleado(ByVal dts As VEmpleados) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_empleado", Val(dts.gcod_empleado))
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

    'obtener codigo de empleado'
    Public Function FnObtenerCodEmpleado(usuario_empleado As String)
        Try
            FnConectado()
            cmd = New SqlCommand("SELECT cod_empleado FROM Empleados where Usuario = '" + usuario_empleado + "';")
            cmd.Connection = cnn
            Dim cod_empleado = CInt(cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return cod_empleado
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

    Public Function FnObtenerNumeroEmpleados()
        Try
            FnConectado()
            cmd = New SqlCommand("SELECT count(*) FROM Empleados")
            cmd.Connection = cnn
            Dim numero_empleados = CStr(cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return numero_empleados
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
End Class
