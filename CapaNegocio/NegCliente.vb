Imports CapaEntidades
Imports CapaDatos

Public Class NegCliente

    'Instancio la Clase DClientes, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim dc As New DClientes

    Public Function AgregarCliente(ByVal dat As EntClientes) As Boolean
        Return dc.AgregarCliente(dat)
    End Function

    Public Function ModificarCliente(ByVal dat As EntClientes) As Boolean
        Return dc.ModificarCliente(dat)
    End Function

    Public Function BuscarCliente(ByVal dat As EntClientes) As DataTable
        Return dc.BuscarCliente(dat)
    End Function

    Public Function EliminarCliente(ByVal dat As EntClientes) As Boolean
        Return dc.EliminarCliente(dat)
    End Function

End Class
