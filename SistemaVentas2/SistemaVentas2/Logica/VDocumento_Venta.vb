Public Class VDocumento_Venta
    Private cod_documento_venta, numero_facturaboleta As Integer
    Private tipo, documento_cliente As String
    Private fecha_venta As Date
    Private subtotal, igv, total As Double
    'alv :v'
    Public Property gcod_documento_venta
        Get
            Return cod_documento_venta
        End Get
        Set(value)
            cod_documento_venta = value
        End Set
    End Property

    Public Property gnumero_facturaboleta
        Get
            Return numero_facturaboleta
        End Get
        Set(value)
            numero_facturaboleta = value
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

    Public Property gfecha_venta
        Get
            Return fecha_venta
        End Get
        Set(value)
            fecha_venta = value
        End Set
    End Property

    Public Property gsubtotal
        Get
            Return subtotal
        End Get
        Set(value)
            subtotal = value
        End Set
    End Property

    Public Property gigv
        Get
            Return igv
        End Get
        Set(value)
            igv = value
        End Set
    End Property

    Public Property gdocumento_cliente
        Get
            Return documento_cliente
        End Get
        Set(value)
            documento_cliente = value
        End Set
    End Property

    Public Property gtotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(cod_documento_venta As Integer, numero_facturaboleta As Integer, tipo As String, documento_cliente As String, fecha_venta As String, subtotal As Double, igv As Double, total As Double)
        Me.gcod_documento_venta = cod_documento_venta
        Me.gnumero_facturaboleta = numero_facturaboleta
        Me.gtipo = tipo
        Me.gdocumento_cliente = documento_cliente
        Me.gfecha_venta = fecha_venta
        Me.gsubtotal = subtotal
        Me.gigv = igv
        Me.gtotal = total
    End Sub




    'VBRO ESE ERA DOCUMENTO DETALLE XDDDDDDDDDDDDDDDD SIGUE HACIENDO ESTE' 

End Class
