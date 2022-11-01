Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DPago

    'Heredo la clase conexión

    Inherits Conexion

    Public Function AgregarPago(ByVal dat As EntPago) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("AgregarPago")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDP", dat.IDPago)
        CMD.Parameters.AddWithValue("@NC", dat.NombreClient)
        CMD.Parameters.AddWithValue("@OD", dat.OtrosDetalles)
        CMD.Parameters.AddWithValue("@M", dat.Monto)

        'Si se ejecuta el procedimiento, true sino false

        If CMD.ExecuteNonQuery Then

            'Desconecto la Base de Datos
            desconectar()
            Return True

        Else

            'Desconecto la Base de Datos
            desconectar()
            Return False

        End If

    End Function


End Class
