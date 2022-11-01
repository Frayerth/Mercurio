Imports CapaEntidades
Imports CapaDatos

Public Class NegFactura

    'Instancio la Clase DFactura, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim df As New DFactura

    Public Function AgregarFactura(ByVal dat As EntFactura) As Boolean
        Return df.AgregarFactura(dat)
    End Function

    Public Function UltimoNumFactura() As Integer
        Return df.UltimoNumFactura()
    End Function

    Public Function LlenarGridrReporteFacturasVentas(ByVal dateini As Date, ByVal datefin As Date) As DataTable
        Return df.LlenarGridrReporteFacturasVentas(dateini, datefin)
    End Function

    Public Function SumaEDGIT(ByVal dateini As Date, ByVal datefin As Date) As DataTable
        Return df.SumaEDGIT(dateini, datefin)
    End Function

    Public Function EliminarFactura(ByVal dat As EntFactura) As Boolean
        Return df.EliminarFactura(dat)
    End Function

    Public Function ModificarFactura(ByVal dat As EntFactura) As Boolean
        Return df.ModificarFactura(dat)
    End Function

End Class
