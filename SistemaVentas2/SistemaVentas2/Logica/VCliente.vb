Public Class VCliente

    Dim documento_cliente, nombre_cliente, telefono_cliente, direccion_cliente As String

    Public Property gdocumento_cliente
        Get
            Return documento_cliente
        End Get
        Set(value)
            documento_cliente = value
        End Set
    End Property

    Public Property gnombre_cliente
        Get
            Return nombre_cliente
        End Get
        Set(value)
            nombre_cliente = value
        End Set
    End Property

    Public Property gtelefono_cliente
        Get
            Return telefono_cliente
        End Get
        Set(value)
            telefono_cliente = value
        End Set
    End Property

    Public Property gdireccion_cliente
        Get
            Return direccion_cliente
        End Get
        Set(value)
            direccion_cliente = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal documento_cliente As String, ByVal nombre_cliente As String, ByVal telefono_cliente As String, ByVal direccion_cliente As String)

        Me.gdocumento_cliente = documento_cliente
        Me.gnombre_cliente = nombre_cliente
        Me.gtelefono_cliente = telefono_cliente
        Me.gdireccion_cliente = direccion_cliente

    End Sub




End Class
