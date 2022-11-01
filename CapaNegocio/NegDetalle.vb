Imports CapaEntidades
Imports CapaDatos

Public Class NegDetalle

    'Instancio la Clase DDetalles, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim dd As New DDetalle1

    Public Function AgregarDetalle(ByVal dat As EntDetalle) As Boolean
        Return dd.AgregarDetalle(dat)
    End Function

    Public Function LlenarGridVentas(ByVal dat As EntDetalle) As DataTable
        Return dd.LlenarGridVentas(dat)
    End Function

    Public Function LlenarGridrReporteProductosVentas(ByVal dateini As Date, ByVal datefin As Date) As DataTable
        Return dd.LlenarGridrReporteProductosVentas(dateini, datefin)
    End Function

    Public Function EliminarDetalle(ByVal dat As EntDetalle) As Boolean
        Return dd.EliminarDetalle(dat)
    End Function

    Public Function EliminarDetallesFactura(ByVal dat As EntDetalle) As Boolean
        Return dd.EliminarDetallesFactura(dat)
    End Function

End Class
