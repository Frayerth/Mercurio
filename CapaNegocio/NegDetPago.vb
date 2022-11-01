Imports CapaEntidades
Imports CapaDatos

Public Class NegDetPago

    'Instancio la Clase DDetPago, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim ddp As New DDetPago

    Public Function AgregarDetPago(ByVal dat As EntDetPago) As Boolean
        Return ddp.AgregarDetPago(dat)
    End Function

    Public Function SumaFormasPago(ByVal dateini As Date, ByVal datefin As Date) As DataTable
        Return ddp.SumaFormasPago(dateini, datefin)
    End Function

End Class
