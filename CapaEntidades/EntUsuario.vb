Public Class EntUsuario

    Private _IDUSUARIO As Integer
    Private _NOMBREUSUARIO As String
    Private _APELLIDOUSUARIO As String
    Private _USUARIO As String
    Private _CONTRASENA As String

    Public Property IDUsuario As Integer
        Get
            Return _IDUSUARIO
        End Get
        Set(value As Integer)
            _IDUSUARIO = value
        End Set
    End Property


    Public Property NombreUsuario As String
        Get
            Return _NOMBREUSUARIO
        End Get
        Set(value As String)
            _NOMBREUSUARIO = value
        End Set
    End Property


    Public Property ApellidoUsuario As String
        Get
            Return _APELLIDOUSUARIO
        End Get
        Set(value As String)
            _APELLIDOUSUARIO = value
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


    Public Property Contrasena As String
        Get
            Return _CONTRASENA
        End Get
        Set(value As String)
            _CONTRASENA = value
        End Set
    End Property

End Class
