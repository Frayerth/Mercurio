Public Class EntProducto

    Private _IDPRODUCTO As Double
    Private _NOMBREPRODUCTO As String
    Private _DETALLEPRODUCTO As String
    Private _PRECIO As Decimal
    Private _STOCK As Integer
    Private _NIT As Double
    Private _PRECIOCOMPRA As Decimal


    Public Property IDProducto As Double
        Get
            Return _IDPRODUCTO
        End Get
        Set(value As Double)
            _IDPRODUCTO = value
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


    Public Property DetalleProd As String
        Get
            Return _DETALLEPRODUCTO
        End Get
        Set(value As String)
            _DETALLEPRODUCTO = value
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


    Public Property Stock As Integer
        Get
            Return _STOCK
        End Get
        Set(value As Integer)
            _STOCK = value
        End Set
    End Property


    Public Property NIT As Double
        Get
            Return _NIT
        End Get
        Set(value As Double)
            _NIT = value
        End Set
    End Property


    Public Property PrecioCompra As Decimal
        Get
            Return _PRECIOCOMPRA
        End Get
        Set(value As Decimal)
            _PRECIOCOMPRA = value
        End Set
    End Property

End Class
