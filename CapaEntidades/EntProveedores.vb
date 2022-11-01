Public Class EntProveedores

    Private _NIT As Double
    Private _DV As Integer
    Private _RAZONSOCIAL As String
    Private _DIRECCIONPROVEEDOR As String
    Private _TELEFONOPROVEEDOR As String


    Public Property NIT As Double
        Get
            Return _NIT
        End Get
        Set(value As Double)
            _NIT = value
        End Set
    End Property


    Public Property DV As Integer
        Get
            Return _DV
        End Get
        Set(value As Integer)
            _DV = value
        End Set
    End Property


    Public Property RazonSocial As String
        Get
            Return _RAZONSOCIAL
        End Get
        Set(value As String)
            _RAZONSOCIAL = value
        End Set
    End Property


    Public Property DireccionProvee As String
        Get
            Return _DIRECCIONPROVEEDOR
        End Get
        Set(value As String)
            _DIRECCIONPROVEEDOR = value
        End Set
    End Property


    Public Property TelefonoProvee As String
        Get
            Return _TELEFONOPROVEEDOR
        End Get
        Set(value As String)
            _TELEFONOPROVEEDOR = value
        End Set
    End Property

End Class
