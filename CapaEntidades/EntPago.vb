Public Class EntPago

    Private _IDPAGO As Integer
    Private _NOMBRECLIENTE As String
    Private _APELLIDOCLIENTE As String
    Private _OTROSDETALLES As String
    Private _MONTO As Decimal

    Public Property IDPago As Integer
        Get
            Return _IDPAGO
        End Get
        Set(value As Integer)
            _IDPAGO = value
        End Set
    End Property

    Public Property NombreClient As String
        Get
            Return _NOMBRECLIENTE
        End Get
        Set(value As String)
            _NOMBRECLIENTE = value
        End Set
    End Property

    Public Property ApellidoClient As String
        Get
            Return _APELLIDOCLIENTE
        End Get
        Set(value As String)
            _APELLIDOCLIENTE = value
        End Set
    End Property

    Public Property OtrosDetalles As String
        Get
            Return _OTROSDETALLES
        End Get
        Set(value As String)
            _OTROSDETALLES = value
        End Set
    End Property

    Public Property Monto As Decimal
        Get
            Return _MONTO
        End Get
        Set(value As Decimal)
            _MONTO = value
        End Set
    End Property

End Class
