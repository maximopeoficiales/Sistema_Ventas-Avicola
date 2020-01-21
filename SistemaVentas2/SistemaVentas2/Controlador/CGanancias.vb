Public Class CGanancias
    Dim fecha_unica
    Dim fecha_rg1
    Dim fecha_rg2
    Public Sub obtener_fecha()
        If ConsultarGanancias.r1ganancia.Checked Then
            fecha_unica = ConsultarGanancias.fecha_dia.Value.Date.ToShortDateString()
            Try
                mostrarGananciaUnaFecha(fecha_unica)
            Catch ex As Exception
                MessageBox.Show("No hay aun ventas registradas el dia de hoy", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try

        ElseIf ConsultarGanancias.r2ganancia.Checked Then
            fecha_rg1 = ConsultarGanancias.fecha_rango1.Value.Date.ToShortDateString()
            fecha_rg2 = ConsultarGanancias.fecha_rango2.Value.Date.ToShortDateString()
            mostrarGananciaRangoFechas(fecha_rg1, fecha_rg2)
        End If
    End Sub

    Public Sub mostrarGananciaUnaFecha(fecha As String)
        Try
            Dim func As New FGanancias
            ConsultarGanancias.label_ganancias.Text = func.FObtenerGananciasUnaFecha(fecha).ToString
            MsgBox(ConsultarGanancias.label_ganancias.Text)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub mostrarGananciaRangoFechas(fecha1 As String, fecha2 As String)
        Try
            Dim func As New FGanancias
            ConsultarGanancias.label_ganancias.Text = func.FObtenerGananciasRango(fecha1, fecha2).ToString
            MsgBox(ConsultarGanancias.label_ganancias.Text)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
