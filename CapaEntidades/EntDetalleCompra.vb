Public Class EntDetalleCompra

    Private _IDDETALLE As Double
    Private _IDPRODUCTO As Double
    Private _NUMFACTURA As String
    Private _NOMBREPRODUCTO As String
    Private _CANTIDAD As Integer
    Private _PRECIO As Decimal
    Private _SUBTOTAL As Decimal

    Public Property IDDetalle As Double
        Get
            Return _IDDETALLE
        End Get
        Set(value As Double)
            _IDDETALLE = value
        End Set
    End Property

    Public Property IDProducto As Double
        Get
            Return _IDPRODUCTO
        End Get
        Set(value As Double)
            _IDPRODUCTO = value
        End Set
    End Property

    Public Property NumFactura As String
        Get
            Return _NUMFACTURA
        End Get
        Set(value As String)
            _NUMFACTURA = value
        End Set
    End Property

    Public Property NombreProd As String
        Get
            Return _NOMBREPRODUCTO
        End Get
        Set(value As String)
            _NOMBREPRODUCTO = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _CANTIDAD
        End Get
        Set(value As Integer)
            _CANTIDAD = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _PRECIO
        End Get
        Set(value As Decimal)
            _PRECIO = value
        End Set
    End Property

    Public Property Subtotal As Decimal
        Get
            Return _SUBTOTAL
        End Get
        Set(value As Decimal)
            _SUBTOTAL = value
        End Set
    End Property

End Class
