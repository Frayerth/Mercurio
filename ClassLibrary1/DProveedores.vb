Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DProveedores

    'Heredo la clase conexión

    Inherits Conexion

    Public Function ListadeLaboratorios() As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("ListadeLaboratorios")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

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

    Public Function AgregarProveedor(ByVal dat As EntProveedores) As Boolean
        Dim Result As Boolean
        Dim Str As String = "AgregarProveedor"
        Result = AgregarRegistroProveedor(dat, Str)
        Return Result
    End Function

    Public Function ModificarProveedor(ByVal dat As EntProveedores) As Boolean
        Dim Result As Boolean
        Dim Str As String = "ModificarProveedor"
        Result = AgregarRegistroProveedor(dat, Str)
        Return Result
    End Function

    Public Function BuscarProveedor(ByVal dat As EntProveedores) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarProveedor")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@RZ", dat.RazonSocial)

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

    Public Function BuscarProveedorconNIT(ByVal dat As EntProveedores) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarProveedorNIT")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NIT", dat.NIT)

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

    Public Function AgregarRegistroProveedor(ByVal dat As EntProveedores, ByVal str As String) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand(str)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@NIT", dat.NIT)
        CMD.Parameters.AddWithValue("@DV", dat.DV)
        CMD.Parameters.AddWithValue("@RZ", dat.RazonSocial)
        CMD.Parameters.AddWithValue("@Dir", dat.DireccionProvee)
        CMD.Parameters.AddWithValue("@Tel", dat.TelefonoProvee)

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

    Public Function EliminarProveedor(ByVal dat As EntProveedores) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("EliminarProveedor")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@RZ", dat.RazonSocial)

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
