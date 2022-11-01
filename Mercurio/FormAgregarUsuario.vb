Imports CapaEntidades
Imports CapaNegocio

Public Class FormAgregarUsuario

    'Instancio las Clases Entsuario y NegUsuario, recordar que la Capa de Mercurio referencia a la Capa de 
    'Negocio y a la Caapa de Negocio y la Capa de Negocio referencia a la Capa de Datos

    Dim EU As New EntUsuario
    Dim NU As New NegUsuario

    'Función que sólo permite que ingresen dígitos, se utilizará para validar el Doc. de Identidad
    Public Sub solonumeros(ByVal key As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(key.KeyChar) Then
            key.Handled = False
        ElseIf Char.IsControl(key.KeyChar) Then
            key.Handled = False
        Else
            key.Handled = True
        End If
    End Sub

    Public Sub LimpiarTextbox()
        My.Forms.FormAgregarUsuario.TextBoxAgrNomUs.Text = ""
        My.Forms.FormAgregarUsuario.TextBoxAgrApeUs.Text = ""
        My.Forms.FormAgregarUsuario.TextBoxAgrUs.Text = ""
        My.Forms.FormAgregarUsuario.TextBoxAgrContUs.Text = ""
        My.Forms.FormAgregarUsuario.TextBoxConfiContr.Text = ""
    End Sub

    Private Sub TextBoxAgrIDUs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAgrIDUs.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBoxAgrIDUs_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAgrIDUs.TextChanged

        If My.Forms.FormAgregarUsuario.ButtonGuardarUsuario.Visible Then
            My.Forms.FormPrincipal.Desbloqueotextbox()
        Else
            LimpiarTextbox()
            My.Forms.FormPrincipal.Bloqueotextbox()

            'Valido si estoy en Modificar Usuario o Elminar Usuario

            If My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Visible Then
                ButtonModificarUsuario.Enabled = False
            ElseIf My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Visible Then
                ButtonEliminarUsuario.Enabled = False
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancelarUsuario.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGuardarUsuario.Click

        Dim VerifCont As Integer
        Dim ok As Boolean

        If TextBoxAgrNomUs.Text <> "" And TextBoxAgrApeUs.Text <> "" And TextBoxAgrIDUs.Text <> "" And TextBoxAgrUs.Text <> "" And TextBoxAgrContUs.Text <> "" And TextBoxConfiContr.Text <> "" Then


            'Si la Contraseña y la Confirmación de la contraseña son iguales, then

            VerifCont = StrComp(TextBoxAgrContUs.Text, TextBoxConfiContr.Text)

            If VerifCont = 0 Then

                EU.IDUsuario = CUInt(TextBoxAgrIDUs.Text) 'Convertir Texto a Int Unsigned
                EU.NombreUsuario = TextBoxAgrNomUs.Text
                EU.ApellidoUsuario = TextBoxAgrApeUs.Text
                EU.Usuario = TextBoxAgrUs.Text
                EU.Contrasena = TextBoxAgrContUs.Text

                Try
                    ok = NU.AgregarUsuario(EU)
                    If ok = True Then
                        MsgBox("El nuevo usuario se guardó con éxito")
                        Me.Close()
                    Else
                        MsgBox("Error en los datos ingresados")
                    End If
                Catch ex As Exception
                    'Excepción codificada
                    If ex.ToString.Contains("duplicate key") Then
                        MsgBox("El usuario ya existe")
                    Else
                        MsgBox(ex.Message)
                    End If
                End Try

            Else
                MsgBox("Las contraseñas no son iguales")

            End If

        Else
            MsgBox("Debe llenar todos los datos del formulario")

        End If

    End Sub

    Private Sub ButtonModificarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonModificarUsuario.Click

        Dim VerifCont As Integer
        Dim ok As Boolean

        If TextBoxAgrNomUs.Text <> "" And TextBoxAgrApeUs.Text <> "" And TextBoxAgrUs.Text <> "" And TextBoxAgrContUs.Text <> "" And TextBoxConfiContr.Text <> "" Then


            'Si la Contraseña y la Confirmación de la contraseña son iguales, then

            VerifCont = StrComp(TextBoxAgrContUs.Text, TextBoxConfiContr.Text)

            If VerifCont = 0 Then

                EU.NombreUsuario = TextBoxAgrNomUs.Text
                EU.ApellidoUsuario = TextBoxAgrApeUs.Text
                EU.Usuario = TextBoxAgrUs.Text
                EU.Contrasena = TextBoxAgrContUs.Text

                Try
                    ok = NU.ModificarUsuario(EU)
                    If ok = True Then
                        MsgBox("Los datos del usuario se modificaron con éxito")
                        Me.Close()
                    Else
                        MsgBox("Error en los datos ingresados")
                    End If
                Catch ex As Exception
                    'Excepción codificada
                    If ex.ToString.Contains("duplicate key") Then
                        MsgBox("El usuario ya existe")
                    Else
                        MsgBox(ex.Message)
                    End If
                End Try

            Else
                MsgBox("Las contraseñas no son iguales")

            End If

        Else
            MsgBox("Debe llenar todos los datos del formulario")

        End If
    End Sub

    Private Sub ButtonEliminarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonEliminarUsuario.Click

        Dim ok As Boolean

        If TextBoxAgrIDUs.Text <> "" Then

            EU.IDUsuario = CUInt(TextBoxAgrIDUs.Text) 'Convertir Texto a Int Unsigned
            Try

                'Evito que se pueda eliminar el Admin

                If EU.IDUsuario = 1 Then
                    MsgBox("El Administrador no se puede eliminar, escoga otro usuario")
                Else
                    ok = NU.EliminarUsuario(EU)
                    If ok = True Then
                        MsgBox("El usuario ha sido eliminado", MsgBoxStyle.Information)
                        Me.Close()
                    Else
                        MsgBox("Error en los datos ingresados", MsgBoxStyle.Critical)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("El usuario no existe", MsgBoxStyle.Exclamation)

        End If


    End Sub

    Private Sub ButtonBuscarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonBuscarUsuario.Click

        'Instancio DT como DataTable para almacenar los datos de los usuarios ya registrados

        Dim DT As New DataTable
        Dim VerifAdmin As Integer

        Try

            'Compruebo que no esté vacio el campo de ID del usuario

            If TextBoxAgrIDUs.Text <> "" Then
                EU.IDUsuario = CUInt(TextBoxAgrIDUs.Text) 'Convertir Texto a Int Unsigned
                DT = NU.BuscarUsuario(EU)

                'Si hay almenos 1 usuario registrado (fila > 0), Row busca la fila Usuario, Valido si es
                'Admin u otro usuario

                If DT.Rows.Count = 1 Then

                    TextBoxAgrNomUs.Text = DT.Rows(0)("NombreUsuario")
                    TextBoxAgrApeUs.Text = DT.Rows(0)("ApellidoUsuario")
                    TextBoxAgrUs.Text = DT.Rows(0)("Usuario")
                    TextBoxAgrContUs.Text = DT.Rows(0)("Contrasena")
                    TextBoxConfiContr.Text = DT.Rows(0)("Contrasena")


                    'Valido si estoy en Modificar Usuario o Elminar Usuario

                    If My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Visible Then
                        My.Forms.FormPrincipal.Desbloqueotextbox()
                        ButtonModificarUsuario.Enabled = True

                        'Restringo a que Admin sólo sea modificado la contraseña

                        VerifAdmin = StrComp(DT.Rows(0)("Usuario"), "Admin")
                        If VerifAdmin = 0 Then
                            TextBoxAgrNomUs.Enabled = False
                            TextBoxAgrApeUs.Enabled = False
                            TextBoxAgrUs.Enabled = False
                        End If

                    ElseIf My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Visible Then
                        ButtonEliminarUsuario.Enabled = True
                    End If


                ElseIf DT.Rows.Count > 1 Then

                    MsgBox("Error, usuario duplicado")

                    'Valido si estoy en Modificar Usuario o Elminar Usuario

                    If My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Visible Then
                        ButtonModificarUsuario.Enabled = False
                    ElseIf My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Visible Then
                        ButtonEliminarUsuario.Enabled = False
                    End If

                Else

                    MsgBox("El usuario no existe")

                    'Valido si estoy en Modificar Usuario o Elminar Usuario

                    If My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Visible Then
                        ButtonModificarUsuario.Enabled = False
                    ElseIf My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Visible Then
                        ButtonEliminarUsuario.Enabled = False
                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class