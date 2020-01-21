Imports System.Data.SqlClient
Public Class FDocumentoVenta
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnInsertarDocumentoVenta(ByVal dts As VDocumento_Venta) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_documento_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Tipo", dts.gtipo)
            cmd.Parameters.AddWithValue("@Numero_FacturaBoleta", Val(dts.gnumero_facturaboleta))
            cmd.Parameters.AddWithValue("@Documento_Cliente", dts.gdocumento_cliente)
            cmd.Parameters.AddWithValue("@Subtotal", CDbl(dts.gsubtotal))
            cmd.Parameters.AddWithValue("@IGV", CDbl(dts.gigv))
            cmd.Parameters.AddWithValue("@Total", CDbl(dts.gtotal))
            cmd.Parameters.AddWithValue("@Fecha_Venta", dts.gfecha_venta)

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
    'ejemplo de obtencion de un solo dato'
    Public Function FnObtenerNMaxDocumentoVenta()
        Try
            FnConectado()
            cmd = New SqlCommand("obtener_nmax_documento_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim nmax_documento_venta = CStr(cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return nmax_documento_venta
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

    Public Function FnObtenerTotalVentas()
        Try
            FnConectado()
            cmd = New SqlCommand("SELECT COUNT(*) FROM Documento_Venta")
            cmd.Connection = cnn
            Dim nventas = CStr(cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return nventas
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
