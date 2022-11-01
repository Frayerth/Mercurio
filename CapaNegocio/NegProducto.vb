Imports CapaEntidades
Imports CapaDatos

Public Class NegProducto

    'Instancio la Clase DProducto, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim dp As New DProducto


    Public Function LlenarGrid(ByVal dat As EntProducto) As DataTable
        Return dp.LlenarGrid(dat)
    End Function

    Public Function BuscarProducto(ByVal dat As EntProducto) As DataTable
        Return dp.BuscarProducto(dat)
    End Function

    Public Function AgregarProducto(ByVal dat As EntProducto) As Boolean
        Return dp.AgregarProducto(dat)
    End Function

    Public Function BuscarProductoNombe(ByVal dat As EntProducto) As DataTable
        Return dp.BuscarProductoNombe(dat)
    End Function

    Public Function BuscarProductoID(ByVal dat As EntProducto) As DataTable
        Return dp.BuscarProductoID(dat)
    End Function

    Public Function BuscarProductoLaboratorio(ByVal dat As EntProducto) As DataTable
        Return dp.BuscarProductoLaboratorio(dat)
    End Function

    Public Function BuscarProductoSoloNombre(ByVal dat As EntProducto) As DataTable
        Return dp.BuscarProductoSoloNombre(dat)
    End Function

    Public Function ModificarProducto(ByVal dat As EntProducto) As Boolean
        Return dp.ModificarProducto(dat)
    End Function

    Public Function ModificarProductoStock(ByVal dat As EntProducto) As Boolean
        Return dp.ModificarProductoStock(dat)
    End Function

    Public Function EliminarProducto(ByRef dat As EntProducto) As Boolean
        Return dp.EliminarProducto(dat)
    End Function

End Class
