Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DFactura

    'Heredo la clase conexión

    Inherits Conexion

    Public Function AgregarFactura(ByVal dat As EntFactura) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("AgregarFactura")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NF", dat.NumFactura)
        CMD.Parameters.AddWithValue("@IDC", dat.IDCliente)
        CMD.Parameters.AddWithValue("@IDU", dat.IDUsuario)
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

    Public Function UltimoNumFactura() As Integer
        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("UltimoNumFactura")
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

    Public Function LlenarGridrReporteFacturasVentas(ByVal dateini As Date, ByVal datefin As Date) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("ReporteFacturasVentas")
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

    Public Function SumaEDGIT(ByVal dateini As Date, ByVal datefin As Date) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("SumaEDGIT")
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

    Public Function EliminarFactura(ByVal dat As EntFactura) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("EliminarFactura")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NF", dat.NumFactura)

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

    Public Function ModificarFactura(ByVal dat As EntFactura) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("ModificarFacturaGrabado")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NF", dat.NumFactura)
        CMD.Parameters.AddWithValue("@G", dat.Grabado)
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

End Class
