
Public Class ListaVentasRegistradas
    Dim c As New CVentas
    'Dim cmd As New SqlCommand
    'Private Sub mostrar_ventas_registradas()
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try

    '        da = New SqlDataAdapter("mostrar_ventas_registradas", conexion)
    '        da.Fill(dt)
    '        tabla_ventas.DataSource = dt

    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Private Sub buscar_ventas_por_dni()
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try

    '        da = New SqlDataAdapter("mostrar_ventas_registradas_por_dni", conexion)
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@Documento_Cliente", txt_dni_compra.Text)
    '        da.Fill(dt)
    '        tabla_ventas.DataSource = dt

    '    Catch ex As Exception : MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Private Sub ListaVentasRegistradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.mostrar_ventas_registradas()
    End Sub
    Private Sub btn_buscar_dni_Click(sender As Object, e As EventArgs) Handles btn_buscar_dni.Click
        c.buscar_ventas_por_dni(tabla_ventas, txt_dni_compra.Text)
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        Me.Close()
    End Sub

    Private Sub txt_dni_compra_TextChanged(sender As Object, e As EventArgs) Handles txt_dni_compra.TextChanged
        c.buscar_ventas_por_dni(tabla_ventas, txt_dni_compra.Text)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class