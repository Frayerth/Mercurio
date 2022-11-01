Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DUsuario

    'Heredo la clase conexión

    Inherits Conexion

    Public Function ValidarLogin(ByVal dat As EntUsuario) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("VerificarUsuario")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@Usuario", dat.Usuario)
        CMD.Parameters.AddWithValue("@Contrasena", dat.Contrasena)

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


    Public Function AgregarUsuario(ByVal dat As EntUsuario) As Boolean
        Dim Result As Boolean
        Dim Str As String = "AgregarUsuario"
        Result = AgregarRegistro(dat, Str)
        Return Result
    End Function


    Public Function ModificarUsuario(ByVal dat As EntUsuario) As Boolean
        Dim Result As Boolean
        Dim Str As String = "ModificarUsuario"
        Result = AgregarRegistro(dat, Str)
        Return Result
    End Function


    Public Function EliminarUsuario(ByVal dat As EntUsuario) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("EliminarUsuario")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDUs", dat.IDUsuario)

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


    Public Function BuscarUsuario(ByVal dat As EntUsuario) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarUsuario")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDUs", dat.IDUsuario)

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


    Public Function AgregarRegistro(ByVal dat As EntUsuario, ByVal str As String) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand(str)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDUs", dat.IDUsuario)
        CMD.Parameters.AddWithValue("@NomUs", dat.NombreUsuario)
        CMD.Parameters.AddWithValue("@ApeUs", dat.ApellidoUsuario)
        CMD.Parameters.AddWithValue("@Us", dat.Usuario)
        CMD.Parameters.AddWithValue("@Cont", dat.Contrasena)

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
