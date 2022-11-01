Imports CapaEntidades
Imports CapaDatos

Public Class NegPago

    'Instancio la Clase DPago, recordar que la Capa de Mercurio no referencia la Capa de Datos
    'La Capa Negocio es quien referencia a los Datos

    Dim dd As New DPago

    Public Function AgregarPago(ByVal dat As EntPago) As Boolean
        Return dd.AgregarPago(dat)
    End Function

End Class
