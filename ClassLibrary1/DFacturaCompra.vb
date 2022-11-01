Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DFacturaCompra
    'Heredo la clase conexión

    Inherits Conexion

    Public Function LlenarGridrReporteFacturasCompra(ByVal dateini As Date, ByVal datefin As Date) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("ReporteFacturasCompra")
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

    Public Function AgregarFacturaCompra(ByVal dat As EntFacturaCompra) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("AgregarFacturaCompra")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NF", dat.NumFactura)
        CMD.Parameters.AddWithValue("@NIT", dat.NIT)
        CMD.Parameters.AddWithValue("@E", dat.Exento)
        CMD.Parameters.AddWithValue("@Des", dat.Descuento)

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

    Public Function UltimoNumFacturaCompra() As Integer

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("UltimoNumFacturaCompra")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        If CMD.ExecuteNonQuery Then
            Using DT As New DataTable
                Using DA As New SqlDataAdapter(CMD)
                    DA.Fill(DT)
                    'Desconecto la Base de Datos
                    desconectar()
                    Return CUInt(DT.Rows(0).Item(0).ToString)

                End Using
            End Using
        Else
            'Desconecto la Base de Datos
            desconectar()
            Return Nothing
        End If

    End Function

End Class
