Imports System.Data.SqlClient
Public Class FConsultasAvanzadas
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnVentasPorDni(ByVal dts As VCliente) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_ventas_registradas_por_dni")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Documento_Cliente", dts.documento_cliente)

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

    Public Function FnVentasPorUnaFecha(fecha As String) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_ventas_registradas_por_una_sola_fecha")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@FECHA1", fecha)

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

    Public Function FnVentasPorUnaFecha(fecha1 As String, fecha2 As String) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_ventas_registradas_por_fecha")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@FECHA1", fecha1)
            cmd.Parameters.AddWithValue("@FECHA2", fecha2)

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






End Class