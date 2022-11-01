Imports CapaEntidades
Imports CapaDatos

Public Class NegUsuario

    'Instancio la Clase DUsuario, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim du As New DUsuario

    Public Function ValidarLogin(ByVal dat As EntUsuario) As DataTable
        Return du.ValidarLogin(dat)
    End Function

    Public Function AgregarUsuario(ByVal dat As EntUsuario) As Boolean
        Return du.AgregarUsuario(dat)
    End Function

    Public Function ModificarUsuario(ByVal dat As EntUsuario) As Boolean
        Return du.ModificarUsuario(dat)
    End Function

    Public Function BuscarUsuario(ByVal dat As EntUsuario) As DataTable
        Return du.BuscarUsuario(dat)
    End Function

    Public Function EliminarUsuario(ByVal dat As EntUsuario) As Boolean
        Return du.EliminarUsuario(dat)
    End Function

End Class
