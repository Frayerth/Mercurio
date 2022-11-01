Imports CapaEntidades
Imports CapaDatos


Public Class NegProveedores

    'Instancio la Clase DProducto, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim dp As New DProveedores

    Public Function ListadeLaboratorios() As DataTable
        Return dp.ListadeLaboratorios()
    End Function

    Public Function AgregarProveedor(ByVal dat As EntProveedores) As Boolean
        Return dp.AgregarProveedor(dat)
    End Function

    Public Function BuscarProveedor(ByVal dat As EntProveedores) As DataTable
        Return dp.BuscarProveedor(dat)
    End Function

    Public Function BuscarProveedorconNIT(ByVal dat As EntProveedores) As DataTable
        Return dp.BuscarProveedorconNIT(dat)
    End Function

    Public Function ModificarProveedor(ByVal dat As EntProveedores) As Boolean
        Return dp.ModificarProveedor(dat)
    End Function

    Public Function EliminarProveedor(ByVal dat As EntProveedores) As Boolean
        Return dp.EliminarProveedor(dat)
    End Function

End Class
