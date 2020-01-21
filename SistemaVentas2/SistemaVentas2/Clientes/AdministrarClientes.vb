Public Class AdministrarClientes
    Dim c As New CClientes
    Private Sub AdministrarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.cargarCliente()
    End Sub

    Private Sub btn_agregarcliente_Click(sender As Object, e As EventArgs) Handles btn_agregarcliente.Click
        c.agregarCliente()
    End Sub

    Private Sub tablaclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaclientes.CellContentClick
        c.FilaEliminarTabla(e)
    End Sub

    Private Sub tablaclientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaclientes.CellDoubleClick
        c.PasarDatosACajas()
    End Sub

    Private Sub btn_eliminarcliente_Click(sender As Object, e As EventArgs) Handles btn_eliminarcliente.Click
        c.eliminarCliente()
    End Sub

    Private Sub btn_actualizarcliente_Click(sender As Object, e As EventArgs) Handles btn_actualizarcliente.Click
        c.actualizarCliente()

    End Sub

    Private Sub btn_buscarclientes_Click(sender As Object, e As EventArgs) Handles btn_buscarclientes.Click
        c.buscar_clienteDNI()
    End Sub

    Private Sub btn_mostrar_clientes_Click(sender As Object, e As EventArgs) Handles btn_mostrar_clientes.Click
        c.mostrar_clientes()
    End Sub

    Private Sub cb_dni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dni.SelectedIndexChanged

    End Sub
End Class