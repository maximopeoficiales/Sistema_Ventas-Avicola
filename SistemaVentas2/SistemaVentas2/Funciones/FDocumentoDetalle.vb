Imports System.Data.SqlClient
Public Class FDocumentoDetalle
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnInsertarDocumentoDetalle(ByVal dts As VDocumento_detalle) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_documento_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cod_Producto", dts.gcod_producto)
            cmd.Parameters.AddWithValue("@Cantidad", CDbl(dts.gcantidad))
            cmd.Parameters.AddWithValue("@Precio_Venta", CDbl(dts.gprecio_venta))
            cmd.Parameters.AddWithValue("@Cod_Empleado", Val(dts.gcod_empleado))
            cmd.Parameters.AddWithValue("@Cod_Documento_Venta", Val(dts.gcod_documento_ventas))

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
