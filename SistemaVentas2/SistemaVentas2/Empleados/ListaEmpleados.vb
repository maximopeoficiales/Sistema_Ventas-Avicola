
Public Class ListaEmpleados
    Dim c As New CEmpleados
    Private Sub ListaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.listaDeEmpleados()

    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        Me.Close()
        AdministrarEmpleados.Show()

    End Sub

    Private Sub tabla_empleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_empleados.CellDoubleClick
        c.ObtenerDatosATextBox()
    End Sub

    Private Sub tabla_empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_empleados.CellContentClick
        c.ActivarCheckTable(e)
    End Sub

    Private Sub btn_eliminar_emp_Click(sender As Object, e As EventArgs) Handles btn_eliminar_emp.Click
        c.eliminarEmp()
    End Sub
End Class