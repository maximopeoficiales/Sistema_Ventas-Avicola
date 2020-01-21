Public Class VEmpleados
    Private cod_empleado As Integer
    Private tipo As String
    Private nombre As String
    Private usuario As String
    Private contrasena As String

    Public Property gcod_empleado
        Get
            Return cod_empleado
        End Get
        Set(value)
            cod_empleado = value
        End Set
    End Property

    Public Property gtipo
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property
    Public Property gnombre
        Get
            Return nombre

        End Get
        Set(value)
            nombre = value
        End Set
    End Property
    Public Property gusuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property
    Public Property gcontrasena
        Get
            Return contrasena
        End Get
        Set(value)
            contrasena = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(cod_empleado As Integer, tipo As String, nombre As String, usuario As String, contrasena As String)
        Me.gcod_empleado = cod_empleado
        Me.gtipo = tipo
        Me.gnombre = nombre
        Me.gusuario = usuario
        Me.gcontrasena = contrasena
    End Sub
End Class
