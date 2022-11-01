Imports CapaEntidades
Imports CapaDatos

Public Class NegFacturaCompra

    'Instancio la Clase DFacturaCompra, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim dfc As New DFacturaCompra

    Public Function AgregarFacturaCompra(ByVal dat As EntFacturaCompra) As Boolean
        Return dfc.AgregarFacturaCompra(dat)
    End Function

    Public Function UltimoNumFacturaCompra() As Integer
        Return dfc.UltimoNumFacturaCompra()
    End Function

    Public Function LlenarGridrReporteFacturasCompra(ByVal dateini As Date, ByVal datefin As Date) As DataTable
        Return dfc.LlenarGridrReporteFacturasCompra(dateini, datefin)
    End Function

End Class
