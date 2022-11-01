Imports System.Data.SqlClient
Imports CapaEntidades

Public Class DProducto

    'Heredo la clase conexión

    Inherits Conexion

    Public Function LlenarGrid(ByVal dat As EntProducto) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("MostrarProductos")
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

    Public Function BuscarProducto(ByVal dat As EntProducto) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarProducto")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.
        CMD.Parameters.AddWithValue("@IDPro", dat.IDProducto)

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

    Public Function BuscarProductoNombe(ByVal dat As EntProducto) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarProductoNombre")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.
        CMD.Parameters.AddWithValue("@valor", dat.NombreProd)

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

    Public Function BuscarProductoID(ByVal dat As EntProducto) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarProductoID")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@valor", dat.IDProducto)

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

    Public Function BuscarProductoLaboratorio(ByVal dat As EntProducto) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarProductoLaboratorio")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.
        CMD.Parameters.AddWithValue("@valor", dat.NIT)

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

    Public Function BuscarProductoSoloNombre(ByVal dat As EntProducto) As DataTable

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("BuscarProductoSoloNombre")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.
        CMD.Parameters.AddWithValue("@NP", dat.NombreProd)

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

    Public Function AgregarProducto(ByVal dat As EntProducto) As Boolean
        Dim Result As Boolean
        Dim Str As String = "AgregarProducto"
        Result = AgregarRegistroProducto(dat, Str)
        Return Result
    End Function

    Public Function ModificarProducto(ByVal dat As EntProducto) As Boolean
        Dim Result As Boolean
        Dim Str As String = "ModificarProducto"
        Result = AgregarRegistroProducto(dat, Str)
        Return Result
    End Function

    Public Function AgregarRegistroProducto(ByVal dat As EntProducto, ByVal str As String) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand(str)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDP", dat.IDProducto)
        CMD.Parameters.AddWithValue("@NP", dat.NombreProd)
        CMD.Parameters.AddWithValue("@DP", dat.DetalleProd)
        CMD.Parameters.AddWithValue("@P", dat.Precio)
        CMD.Parameters.AddWithValue("@S", dat.Stock)
        CMD.Parameters.AddWithValue("@NIT", dat.NIT)
        CMD.Parameters.AddWithValue("@PC", dat.PrecioCompra)

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

    Public Function ModificarProductoStock(ByVal dat As EntProducto) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("ModificarProductoSock")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDP", dat.IDProducto)
        CMD.Parameters.AddWithValue("@S", dat.Stock)
        CMD.Parameters.AddWithValue("@PC", dat.PrecioCompra)
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

    Public Function EliminarProducto(ByRef dat As EntProducto) As Boolean

        conectar()

        'Le paso al comando el procedimiento de consulta de SQL

        CMD = New SqlCommand("EliminarProducto")
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = DB

        'Enviando los parámetro a la Tabla en SQL por medio del procedimiento.

        CMD.Parameters.AddWithValue("@IDP", dat.IDProducto)

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
