Imports System.Data.SqlClient
Public Class FGanancias
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand
    Public Function FObtenerGananciasUnaFecha(fecha1 As String) As Decimal
        Try
            FnConectado()
            cmd = New SqlCommand("ver_ganancias")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            Dim text = cmd.ExecuteScalar()
            If cmd.ExecuteNonQuery Then
                Return text
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

    Public Function FObtenerGananciasRango(fecha1 As String, fecha2 As String) As Decimal
        Try
            FnConectado()
            cmd = New SqlCommand("ver_ganancias_rango")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
            Dim text = (cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return text
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
