Public Class EntFactura

    Private _NUMFACTURA As Integer
    Private _FECHA As Date
    Private _IDCLIENTE As Integer
    Private _IDUSUARIO As Integer
    Private _USUARIO As String
    Private _IDPAGO As Integer
    Private _EXENTO As Decimal
    Private _GRABADO As Decimal
    Private _IVA As Decimal
    Private _TOTAL As Decimal
    Private _DESCUENTO As Decimal

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

    Public Property IDCliente As Integer
        Get
            Return _IDCLIENTE
        End Get
        Set(value As Integer)
            _IDCLIENTE = value
        End Set
    End Property

    Public Property IDUsuario As Integer
        Get
            Return _IDUSUARIO
        End Get
        Set(value As Integer)
            _IDUSUARIO = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _USUARIO
        End Get
        Set(value As String)
            _USUARIO = value
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
