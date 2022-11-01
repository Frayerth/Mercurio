Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DClientes

    'Heredo la clase conexión

    Inherits Conexion


    Public Function AgregarCliente(ByVal dat As EntClientes) As Boolean
        Dim Result As Boolean
        Dim Str As String = "Agregarcliente"
        Result = AgregarRegistro(dat, Str)
        Return Result
    End Function


    Public Function ModificarCliente(ByVal dat As EntClientes) As Boolean
        Dim Result As Boolean
        Dim Str As String = "ModificarCliente"
        Result = AgregarRegistro(dat, Str)
        Return Result
    End Function


    Public Function EliminarCliente(ByVal dat As EntClientes) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("EliminarCliente")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDUs", dat.IDCliente)

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


    Public Function BuscarCliente(ByVal dat As EntClientes) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarCliente")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDUs", dat.IDCliente)

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


    Public Function AgregarRegistro(ByVal dat As EntClientes, ByVal str As String) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand(str)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@TID", dat.TipoID)
        CMD.Parameters.AddWithValue("@IDCl", dat.IDCliente)
        CMD.Parameters.AddWithValue("@NomCl", dat.NombreClient)
        CMD.Parameters.AddWithValue("@ApeCl", dat.ApellidoClient)
        CMD.Parameters.AddWithValue("@TelCl", dat.TelefonoClient)
        CMD.Parameters.AddWithValue("@DirCl", dat.DireccionCient)
        CMD.Parameters.AddWithValue("@EmailCl", dat.EmailClient)

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
