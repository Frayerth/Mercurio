Public Class EntDetPago

    Private _IDDETPAGO As Integer
    Private _NUMFACTURA As Integer
    Private _IDPAGO As Integer
    Private _FECHA As Date
    Private _EFECTIVO As Decimal
    Private _CREDITO As Decimal
    Private _TARJETA As Decimal

    Public Property IDDetPago As Integer
        Get
            Return _IDDETPAGO
        End Get
        Set(value As Integer)
            _IDDETPAGO = value
        End Set
    End Property

    Public Property NumFactura As Integer
        Get
            Return _NUMFACTURA
        End Get
        Set(value As Integer)
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

    Public Property IDPago As Integer
        Get
            Return _IDPAGO
        End Get
        Set(value As Integer)
            _IDPAGO = value
        End Set
    End Property

    Public Property Efectivo As Decimal
        Get
            Return _EFECTIVO
        End Get
        Set(value As Decimal)
            _EFECTIVO = value
        End Set
    End Property

    Public Property Crédito As Decimal
        Get
            Return _CREDITO
        End Get
        Set(value As Decimal)
            _CREDITO = value
        End Set
    End Property

    Public Property Tarjeta As Decimal
        Get
            Return _TARJETA
        End Get
        Set(value As Decimal)
            _TARJETA = value
        End Set
    End Property

End Class
