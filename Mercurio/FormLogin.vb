Imports CapaEntidades
Imports CapaNegocio
Public Class FormLogin

    'Instancio las Clases Entsuario y NegUsuario, recordar que la Capa de Mercurio referencia a la Capa de 
    'Negocio y a la Caapa de Negocio y la Capa de Negocio referencia a la Capa de Datos

    Dim EU As New EntUsuario
    Dim NU As New NegUsuario
    Dim IPCorrecta As Boolean 'Vaiable para indicar si el IP almacenado en Config es el mismo de la DB.
    Public IP As String 'Variable para almacenar el IP almacenado en Config
    Public DB_en_Red As Boolean 'Variable par conocer si la DB está en Red o es una sola PC. Por defecto en Config es 0 (NO)

    Sub login()

        'Instancio DT como DataTable para ser utilizado luego en conocer si es Admin o no

        Dim DT As New DataTable
        Dim Nivel As String
        Static intento As Integer

        Try

            'Compruebo que los TextBox no estén vacios y valido la información escrita por el usuario
            If TextBoxContrasena.Text <> "" And TextBoxUsuario.Text <> "" Then

                'Si hay almenos 1 usuario registrado (fila > 0), busco en la fila Usuario, Valido si es
                'Admin u otro usuario.

                If DT.Rows.Count > 0 Then 'Por defecto la DB viene creada con 1 usuario que es el admin.

                    Me.Hide()
                    Nivel = DT.Rows(0)("Usuario")
                    MsgBox("Bienvenido a Mercurio " & Nivel)
                    FormPrincipal.Show()
                    My.Forms.FormPrincipal.EF.IDUsuario = DT.Rows(0)("IDUsuario") 'Para la Factura
                    My.Forms.FormPrincipal.EF.Usuario = DT.Rows(0)("Usuario") 'Para la Factura
                    If Nivel = "Admin" Then
                        My.Forms.FormPrincipal.AdministrarToolStripMenuItem.Enabled = True
                    Else
                        My.Forms.FormPrincipal.AdministrarToolStripMenuItem.Enabled = False
                    End If

                Else

                    'Controlar el número de intentos fallidos de autenticación de usuario

                    intento = intento + 1
                    MsgBox("Estimado Usuario, tiene " & (3 - intento) & " intentos")

                    If intento >= 3 Then
                        MsgBox("El sistema se cerrará, gracias", MsgBoxStyle.Critical, "SISTEMA")
                        Me.Close()
                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'Averigüo en Config si la DB estará en Red o es solo local. Config está sin formato ni extensión en Recursos de Mercurio.
            Dim Config_Bytes() As Byte = My.Resources.Config
            Dim Config_String As String = System.Text.Encoding.ASCII.GetString(Config_Bytes)

            'Creo una subcadena con la función Substring(), para saber si es 0 (Local) o 1 (Red). SubString recibe el 
            'índice y el tamaño de la sub cadena. Por defecto el inicio del texto en Config es: DB en red: 0.
            Dim Red_Si_No As String = Config_String.Substring(11, 1)

            If CInt(Red_Si_No) = 0 Then

                DB_en_Red = False 'Indico con 0 de que la DB es local, por lo tanto DB_en_Red es false.

            Else

                DB_en_Red = True 'Indico con 1 de que la DB es local, por lo tanto DB_en_Red es true.

                'Leo el contenido del archivo config que está sin formato ni extensión en Recursos de Mercurio.
                Dim IP_Bytes() As Byte = My.Resources.Config
                Dim IP_String As String = System.Text.Encoding.ASCII.GetString(IP_Bytes)

                'Buscar IP en el archivo config, aparecerá: IP: 192.168.0.0, por defecto Admin. Para ello creo una subcadena
                'con la función Substring(), recibe el ínidice inicial y el tamaño de la cadena a extraer.
                IP = IP_String.Substring(4, IP_String.Length - 4)

                'Dim Indice_espacio As Integer = IP_String.IndexOf("168.") 'Busca el índice donde se ubica 168. (es el 
                'Espacio o "enter"). El índice de donde inicia el nombre de usuario del aministrador es el 17, inicia en 0
                'UsAdministrador: "nombre usuario".

                'Creo una subcadena con la función Substring(), de los valores de la IP después de 192.168.
                Dim IP_DB As String = IP_String.Substring(12, IP_String.Length - 12)

                'Averigüo si existe el IP del servidor de la base de datos a conectar.
                If StrComp(IP_DB, "0.0") = 0 Then

                    'Indico que la IP almacenada en Config NO es la misma de la DB
                    IPCorrecta = False

                    MsgBox("La base de datos no se encuentra en el servidor configurado, ubicado en el " & IP_String &
                          " por favor, configure el IP del servidor")

                    'Deshabilito cualquier acción en Mercurio.
                    Me.TextBoxUsuario.Enabled = False
                    Me.TextBoxContrasena.Enabled = False
                    Me.ButtonLogin.Enabled = False

                Else

                    'Indico que la IP almacenada en Config es la misma de la DB
                    IPCorrecta = True

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        login()
    End Sub

    Private Sub TextBoxContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

End Class