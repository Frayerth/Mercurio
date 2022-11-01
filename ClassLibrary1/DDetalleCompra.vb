Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DDetalleCompra

    'Heredo la clase conexión

    Inherits Conexion

    Public Function LlenarGridrReporteProductosCompra(ByVal dateini As Date, ByVal datefin As Date) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("ReporteProductosCompra")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB


        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@date1", dateini)
        CMD.Parameters.AddWithValue("@date2", datefin)

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

    Public Function AgregarDetalleCompra(ByVal dat As EntDetalleCompra) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("AgregarDetalleCompra")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NF", dat.NumFactura)
        CMD.Parameters.AddWithValue("@IDProd", dat.IDProducto)
        CMD.Parameters.AddWithValue("@C", dat.Cantidad)
        CMD.Parameters.AddWithValue("@P", dat.Precio)

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

    Public Function LlenarGridCompra(ByVal dat As EntDetalleCompra) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("MostrarDetalleCompra")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NF", dat.NumFactura)

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
