Public Class EntClientes

    Private _IDCLIENTE As Integer
    Private _TIPOID As String
    Private _NOMBRECLIENTE As String
    Private _APELLIDOCLIENTE As String
    Private _TELEFONOCLIENTE As Integer
    Private _DIRECCIONCLIENTE As String
    Private _EMAIL As String

    Public Property IDCliente As Integer
        Get
            Return _IDCLIENTE
        End Get
        Set(value As Integer)
            _IDCLIENTE = value
        End Set
    End Property

    Public Property TipoID As String
        Get
            Return _TIPOID
        End Get
        Set(value As String)
            _TIPOID = value
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

    Public Property TelefonoClient As Integer
        Get
            Return _TELEFONOCLIENTE
        End Get
        Set(value As Integer)
            _TELEFONOCLIENTE = value
        End Set
    End Property

    Public Property DireccionCient As String
        Get
            Return _DIRECCIONCLIENTE
        End Get
        Set(value As String)
            _DIRECCIONCLIENTE = value
        End Set
    End Property

    Public Property EmailClient As String
        Get
            Return _EMAIL
        End Get
        Set(value As String)
            _EMAIL = value
        End Set
    End Property

End Class
