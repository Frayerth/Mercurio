Imports CapaEntidades
Imports CapaDatos

Public Class NegDetalleCompra

    'Instancio la Clase DDetalleCompra, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim ddc As New DDetalleCompra

    Public Function AgregarDetalleCompra(ByVal dat As EntDetalleCompra) As Boolean
        Return ddc.AgregarDetalleCompra(dat)
    End Function

    Public Function LlenarGridCompra(ByVal dat As EntDetalleCompra) As DataTable
        Return ddc.LlenarGridCompra(dat)
    End Function

    Public Function LlenarGridrReporteProductosCompra(ByVal dateini As Date, ByVal datefin As Date) As DataTable
        Return ddc.LlenarGridrReporteProductosCompra(dateini, datefin)
    End Function

End Class
