Imports System.Data.SqlClient
Public Class CLogin
    Inherits FConexion
    Dim validacion
    Public usuario_activo As String
    Public tipo_usuario_activo As String
    Public Sub validar_form()
        If login.txt_usuario.Text = "" Or login.txt_contraseña.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")
        Else
            validacion = True
        End If
    End Sub
    Public Sub validar_sesion()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        validar_form()
        If validacion Then
            Try
                FnConectado()
                da = New SqlDataAdapter("validar_usuarios", cnn)
                'indetificar que es un proceso almacenado'
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@Usuario", login.txt_usuario.Text)
                da.SelectCommand.Parameters.AddWithValue("@Contrasena", login.txt_contraseña.Text)
                da.Fill(dt)
                Dim cod_empleado = dt.Rows(0)(0).ToString
                Dim tipo_usuario = dt.Rows(0)(1).ToString
                Dim nombre_completo = dt.Rows(0)(2).ToString
                Dim usuario = dt.Rows(0)(3).ToString
                Dim contraseña = dt.Rows(0)(4).ToString
                FnDesconectado()

                If usuario = login.txt_usuario.Text And contraseña = login.txt_contraseña.Text Then
                    Saludo.label_usuario.Text = nombre_completo
                    ingresar_usuario_activo(UCase(usuario), tipo_usuario, Val(cod_empleado))
                    login.Hide() 'oculta no cierra'
                        Saludo.ShowDialog() 'hace que tenga un pausa al ser un cuadro de dialogo'
                        Menu1.Show()


                End If
            Catch ex As Exception
                MsgBox("Error datos incorrectos")
            End Try
        End If
    End Sub
End Class
