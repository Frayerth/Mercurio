Imports System.Data.SqlClient


Public Class Conexion

    'Creo las instancias a SqlConecction y SqlCommand

    Public Shared DB As New SqlConnection
    Public CMD As New SqlCommand


    Public Shared Function conectar()
        Try

            'Conecto a la base de datos

            DB = New SqlConnection(My.Settings.Conexion)
            DB.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function


    Public Shared Function desconectar()
        Try
            If DB.State = ConnectionState.Open Then
                DB.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

End Class
