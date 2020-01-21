Public Class VDocumento_detalle

    Dim cod_documento_detalle As Integer
    Dim cod_producto As String
    Dim cantidad As Double
    Dim precio_venta As Double
    Dim cod_empleado As Integer
    Dim cod_documento_ventas As Integer

    Public Property gcod_documento_detalle
        Get
            Return cod_documento_detalle
        End Get
        Set(value)
            cod_documento_detalle = value
        End Set
    End Property

    Public Property gcod_producto
        Get
            Return cod_producto
        End Get
        Set(value)
            cod_producto = value
        End Set
    End Property

    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property

    Public Property gprecio_venta
        Get
            Return precio_venta
        End Get
        Set(value)
            precio_venta = value
        End Set
    End Property

    Public Property gcod_empleado
        Get
            Return cod_empleado
        End Get
        Set(value)
            cod_empleado = value
        End Set
    End Property

    Public Property gcod_documento_ventas
        Get
            Return cod_documento_ventas
        End Get
        Set(value)
            cod_documento_ventas = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal cod_documento_detalle As Integer, ByVal cod_producto As String, ByVal cantidad As Double, ByVal precio_venta As Double, ByVal cod_empleado As Integer, ByVal cod_documento_ventas As Integer)
        gcod_documento_detalle = cod_documento_detalle
        gcod_producto = cod_producto
        gcantidad = cantidad
        gprecio_venta = precio_venta
        gcod_empleado = cod_empleado
        gcod_documento_ventas = cod_documento_ventas
    End Sub

End Class
