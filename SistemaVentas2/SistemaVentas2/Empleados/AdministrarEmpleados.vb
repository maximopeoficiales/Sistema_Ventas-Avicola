
Public Class AdministrarEmpleados
    Dim c As New CEmpleados
    Private Sub btn_listar_emp_Click(sender As Object, e As EventArgs) Handles btn_listar_emp.Click
        ListaEmpleados.Show()
    End Sub

    Private Sub btn_agregar_emp_Click(sender As Object, e As EventArgs) Handles btn_agregar_emp.Click
        c.agregarEmp()
    End Sub

    Private Sub btn_actualizar_emp_Click(sender As Object, e As EventArgs) Handles btn_actualizar_emp.Click
        c.actualizarEmp()
    End Sub

    Private Sub AdministrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.Contar_Empleado()
    End Sub


    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        c.mostrarPass(txt_contraseña, check, uncheck)
    End Sub

    Private Sub uncheck_Click(sender As Object, e As EventArgs) Handles uncheck.Click
        c.noMostrarPass(txt_contraseña, check, uncheck)
    End Sub

    Private Sub check1_Click(sender As Object, e As EventArgs) Handles check1.Click
        c.mostrarPass(txt_nueva_contraseña, check1, uncheck1)
    End Sub

    Private Sub uncheck1_Click(sender As Object, e As EventArgs) Handles uncheck1.Click
        c.noMostrarPass(txt_nueva_contraseña, check1, uncheck1)
    End Sub


End Class