Public Class VProveedor
    Private cod_proveedor, nombre_proveedor, direccion_proveedor, telefono_proveedor As String

    Public Property gcod_proveedor
        Get
            Return cod_proveedor
        End Get
        Set(value)
            cod_proveedor = value
        End Set
    End Property

    Public Property gnombre_proveedor
        Get
            Return nombre_proveedor
        End Get
        Set(value)
            nombre_proveedor = value
        End Set
    End Property
    Public Property gdireccion_proveedor
        Get
            Return direccion_proveedor
        End Get
        Set(value)
            direccion_proveedor = value
        End Set
    End Property

    Public Property gtelefono_proveedor
        Get
            Return telefono_proveedor
        End Get
        Set(value)
            telefono_proveedor = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal cod_proveedor As String, ByVal nombre_proveedor As String, ByVal direccion_proveedor As String, ByVal telefono_proveedor As String)
        Me.gcod_proveedor = cod_proveedor
        Me.gnombre_proveedor = nombre_proveedor
        Me.gdireccion_proveedor = direccion_proveedor
        Me.gtelefono_proveedor = telefono_proveedor
    End Sub
End Class
