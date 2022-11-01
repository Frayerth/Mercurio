Public Class EntFacturaCompra

    Private _NUMFACTURA As String
    Private _FECHA As Date
    Private _NIT As Double
    Private _EXENTO As Decimal
    Private _GRABADO As Decimal
    Private _IVA As Decimal
    Private _TOTAL As Decimal
    Private _DESCUENTO As Decimal

    Public Property NumFactura As String
        Get
            Return _NUMFACTURA
        End Get
        Set(value As String)
            _NUMFACTURA = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _FECHA
        End Get
        Set(value As Date)
            _FECHA = value
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

    Public Property Exento As Decimal
        Get
            Return _EXENTO
        End Get
        Set(value As Decimal)
            _EXENTO = value
        End Set
    End Property

    Public Property Grabado As Decimal
        Get
            Return _GRABADO
        End Get
        Set(value As Decimal)
            _GRABADO = value
        End Set
    End Property

    Public Property IVA As Decimal
        Get
            Return _IVA
        End Get
        Set(value As Decimal)
            _IVA = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _TOTAL
        End Get
        Set(value As Decimal)
            _TOTAL = value
        End Set
    End Property

    Public Property Descuento As Decimal
        Get
            Return _DESCUENTO
        End Get
        Set(value As Decimal)
            _DESCUENTO = value
        End Set
    End Property
End Class
