Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DDetPago

    'Heredo la clase conexión

    Inherits Conexion

    Public Function AgregarDetPago(ByVal dat As EntDetPago) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("AgregarDetPag")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NF", dat.NumFactura)
        CMD.Parameters.AddWithValue("@E", dat.Efectivo)
        CMD.Parameters.AddWithValue("@C", dat.Crédito)
        CMD.Parameters.AddWithValue("@T", dat.Tarjeta)

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

    Public Function SumaFormasPago(ByVal dateini As Date, ByVal datefin As Date) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("SumaFormasPago")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@date1", dateini)
        CMD.Parameters.AddWithValue("@date2", datefin)

        'Si se ejecuta el procedimiento, creo una DataTable vacío y adapto los datos del procedimiento 
        'en SQL a datos de Visual Studio y lo lleno en el DataTable

        If CMD.ExecuteNonQuery Then
            Using DT As New DataTable
                Using DA As New SqlDataAdapter(CMD)
                    DA.Fill(DT)
                    'Desconecto la Base de Datos
                    desconectar()
                    Return DT
                End Using
            End Using
        Else
            'Desconecto la Base de Datos
            desconectar()
            Return Nothing
        End If

    End Function

End Class
