Imports System.Data.SqlClient
Public Class AdministrarProvedores
    
    Dim c As New CProveedores

    Private Sub btn_agregar_prov_Click(sender As Object, e As EventArgs) Handles btn_agregar_prov.Click
        c.registrar_proovedores()
    End Sub

    Private Sub AdministrarProvedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.cargarProv()
    End Sub

    Private Sub btn_eliminar_prov_Click(sender As Object, e As EventArgs) Handles btn_eliminar_prov.Click
        c.eliminar_proveedor()
    End Sub

    Private Sub tabla_proovedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_proovedores.CellContentClick
        c.MostrarChecktable(e)
    End Sub

    Private Sub btn_actualizar_prov_Click(sender As Object, e As EventArgs) Handles btn_actualizar_prov.Click
        c.actualizar_proveedor()
    End Sub

    Private Sub tabla_proovedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_proovedores.CellDoubleClick
        c.PasarDatosACajas()
    End Sub
End Class