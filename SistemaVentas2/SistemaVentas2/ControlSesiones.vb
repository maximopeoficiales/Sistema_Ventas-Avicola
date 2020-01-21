
Imports System.Data.SqlClient
Imports System.Configuration
Module ControlSesiones
    Dim usuario_activo As String
    Dim tipo_usuario_activo As String
    Dim cod_empleado_activo As Integer

    'metodos para la sesion'
    Sub ingresar_usuario_activo(usuario As String, tipo_usuario As String, cod_empleado As Integer)
        usuario_activo = usuario
        tipo_usuario_activo = tipo_usuario
        cod_empleado_activo = cod_empleado
    End Sub
    Function obtener_usuario_activo()
        Return usuario_activo
    End Function

    Function obtener_tipo_usuario_activo()
        Return tipo_usuario_activo
    End Function
    Function obtener_cod_empleado_activo()
        Return cod_empleado_activo
    End Function
End Module
