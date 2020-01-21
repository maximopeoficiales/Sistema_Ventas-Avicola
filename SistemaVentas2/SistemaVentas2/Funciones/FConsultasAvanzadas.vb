Imports System.Data.SqlClient
Public Class FConsultasAvanzadas
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnVentaPorFecha(fecha As String) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_ventas_registradas_por_una_sola_fecha")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@FECHA1", fecha)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) 'los resultados se guardan en da
                da.Fill(dt) 'lleno los datos en un datatable
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

    Public Function FnVentaPorRangoDeFechas(fecha1 As String, fecha2 As String) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_ventas_registradas_entre_fechas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@FECHA1", fecha1)
            cmd.Parameters.AddWithValue("@FECHA2", fecha2)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) 'los resultados se guardan en da
                da.Fill(dt) 'lleno los datos en un datatable
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

    Public Function FnMostrarVentas() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_ventas_registradas") 'mi procedimiento almacenado ya hecho'
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

    Public Function FnVentaPorDni(textbox As String) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_ventas_registradas_por_dni")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Documento_Cliente", textbox)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) 'los resultados se guardan en da
                da.Fill(dt) 'lleno los datos en un datatable
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

    'Obtener numero maximo de boleta mas uno para el registro de venta
    Public Function FnObtenerNMaxFacturaMas1()
        Try
            FnConectado()
            cmd = New SqlCommand("obtener_num_factura")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim nmaxfacturaMas1 = CInt(cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return nmaxfacturaMas1
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
