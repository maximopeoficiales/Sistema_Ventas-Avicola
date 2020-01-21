Public Class VProductos
    Private cod_producto As String
    Private nombre_producto As String
    Private precio_xkg As Double
    Private stock As Double
    Private cod_proovedor As String

    Public Property gcod_producto
        Get
            Return cod_producto
        End Get
        Set(value)
            cod_producto = value
        End Set
    End Property

    Public Property gnombre_producto
        Get
            Return nombre_producto
        End Get
        Set(value)
            nombre_producto = value
        End Set
    End Property

    Public Property gprecio_xkg
        Get
            Return precio_xkg
        End Get
        Set(value)
            precio_xkg = value
        End Set
    End Property
    Public Property gstock
        Get
            Return stock
        End Get
        Set(value)
            stock = value
        End Set
    End Property
    Public Property gcod_proovedor
        Get
            Return cod_proovedor
        End Get
        Set(value)
            cod_proovedor = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(cod_producto As String, nombre_producto As String, precio_xkg As Double, stock As Double, cod_proovedor As String)
        Me.gcod_producto = cod_producto
        Me.gnombre_producto = nombre_producto
        Me.gprecio_xkg = precio_xkg
        Me.gstock = stock
        Me.gcod_proovedor = cod_proovedor
    End Sub
End Class
