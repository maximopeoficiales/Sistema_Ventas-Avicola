Imports System.Data
Imports System.Data.SqlClient
Imports System
Public Class ConsultarVentas
    Dim c As New CVentas

    'Private Sub obtener_fecha()
    '    If rb_un_dia.Checked Then
    '        fecha_unica = fecha_1.Value.Date.ToShortDateString()
    '        Try
    '            mostrar_lista_ventas_por_una_fecha()
    '        Catch ex As Exception
    '            MessageBox.Show("No hay aun ventas registradas el dia de hoy", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    '        End Try

    '    ElseIf rb_rango_de_dia.Checked Then
    '        fecha_rg1 = fecha_rango1.Value.Date.ToShortDateString()
    '        fecha_rg2 = fecha_rango2.Value.Date.ToShortDateString()
    '        mostrar_lista_ventas_por_rango()
    '    End If
    'End Sub
    'Private Sub mostrar_lista_ventas_por_rango()

    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try


    '        da = New SqlDataAdapter("mostrar_ventas_registradas_por_fecha", conexion)
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@FECHA1", fecha_rg1)
    '        da.SelectCommand.Parameters.AddWithValue("@FECHA2", fecha_rg2)
    '        da.Fill(dt)
    '        'Lista_ventas_registradas_rango.tabla_ventas.DataSource = dt

    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Private Sub mostrar_lista_ventas_por_una_fecha()
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try


    '        da = New SqlDataAdapter("mostrar_ventas_registradas_por_una_sola_fecha", conexion)
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@FECHA1", fecha_unica)
    '        da.Fill(dt)
    '        'Lista_ventas_registradas_rango.tabla_ventas.DataSource = dt

    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub btn_mostrar_ventas_Click(sender As Object, e As EventArgs) Handles btn_mostrar_ventas_seleccionable.Click
        c.obtener_fecha()
    End Sub

    Private Sub btn_listar_todo_Click(sender As Object, e As EventArgs) Handles btn_listar_todo.Click
        ListaVentasRegistradas.Show()
    End Sub

    Private Sub ConsultarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.totalVentas(label_ventas_totales)
    End Sub
End Class