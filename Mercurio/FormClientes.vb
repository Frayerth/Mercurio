Imports CapaEntidades
Imports CapaNegocio

Public Class FormClientes

    'Instancio las Clases EntCliente y NegCliente, recordar que la Capa de Mercurio referencia a la Capa de 
    'Negocio y a la Caapa de Negocio y la Capa de Negocio referencia a la Capa de Datos

    Dim EC As New EntClientes
    Dim NC As New NegCliente

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

    Private Sub LimpiarTextbox()
        Me.TextBoxAgrIDUs.Text = ""
        Me.TextBoxAgrNomUs.Text = ""
        Me.TextBoxAgrpeUs.Text = ""
        Me.TextBoxAgrTel.Text = ""
        Me.TextBoxAgrDirClient.Text = ""
        Me.TextBoxEmailCliente.Text = ""
    End Sub

    Private Sub Desbloqueotextbox()

        Me.TextBoxAgrIDUs.Enabled = True
        Me.TextBoxAgrNomUs.Enabled = True
        Me.TextBoxAgrpeUs.Enabled = True
        Me.TextBoxAgrTel.Enabled = True
        Me.TextBoxAgrDirClient.Enabled = True
        Me.TextBoxEmailCliente.Enabled = True
        ComboBox1.Enabled = True

    End Sub

    Public Sub Bloqueotextbox()

        Me.ComboBox1.Enabled = False
        Me.TextBoxAgrNomUs.Enabled = False
        Me.TextBoxAgrpeUs.Enabled = False
        Me.TextBoxAgrTel.Enabled = False
        Me.TextBoxAgrDirClient.Enabled = False
        Me.TextBoxEmailCliente.Enabled = False

    End Sub

    Private Sub TextBoxAgrIDUs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAgrIDUs.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBoxAgrTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAgrTel.KeyPress
        solonumeros(e)
    End Sub

    Private Sub ButtonGuardarCliente_Click(sender As Object, e As EventArgs) Handles ButtonGuardarCliente.Click

        Dim ok As Boolean

        If TextBoxAgrNomUs.Text <> "" And TextBoxAgrpeUs.Text <> "" And TextBoxAgrIDUs.Text <> "" Then

            EC.IDCliente = CUInt(TextBoxAgrIDUs.Text) 'Convertir Texto a Int Unsigned
            EC.TipoID = ComboBox1.SelectedItem.ToString
            EC.NombreClient = TextBoxAgrNomUs.Text
            EC.ApellidoClient = TextBoxAgrpeUs.Text
            EC.DireccionCient = TextBoxAgrDirClient.Text
            EC.EmailClient = TextBoxEmailCliente.Text

            'Valido para que no haya error al convertir string to Integer
            If TextBoxAgrTel.Text <> "" Then
                EC.TelefonoClient = CUInt(TextBoxAgrTel.Text)
            Else
                EC.TelefonoClient = 0
            End If

            Try
                ok = NC.AgregarCliente(EC)
                If ok = True Then
                    MsgBox("El nuevo Cliente se guardó con éxito")
                    My.Forms.FormVentas.LimpiarTextbox()
                    My.Forms.FormVentas.TextBoxIDCliente.Text = TextBoxAgrIDUs.Text
                    My.Forms.FormVentas.EF.IDCliente = EC.IDCliente 'Para la Factura
                    My.Forms.FormVentas.TextBoxCodProd.ReadOnly = False
                    Me.Close()
                Else
                    MsgBox("Error en los datos ingresados")
                End If
            Catch ex As Exception
                'Excepción codificada
                If ex.ToString.Contains("duplicate key") Then
                    MsgBox("El Cliente ya existe")
                Else
                    MsgBox(ex.Message)
                End If
            End Try

        Else
            MsgBox("Debe llenar todos los datos del formulario")

        End If

    End Sub

    Private Sub ButtonCancelarCliente_Click(sender As Object, e As EventArgs) Handles ButtonCancelarCliente.Click
        My.Forms.FormVentas.LimpiarTextbox()
        Me.Close()
    End Sub

    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click

        'Instancio DT como DataTable para almacenar los datos de los usuarios ya registrados

        Dim DT As New DataTable
        Dim s As String = ""

        Try

            'Compruebo que no esté vacio el campo de ID del usuario

            If Me.TextBoxAgrIDUs.Text <> "" Then
                EC.IDCliente = CUInt(Me.TextBoxAgrIDUs.Text) 'Convertir Texto a Int Unsigned
                DT = NC.BuscarCliente(EC)

                'Si hay al menos 1 usuario registrado (fila > 0), Row busca la fila Usuario.

                If DT.Rows.Count = 1 Then

                    Me.TextBoxAgrNomUs.Text = DT.Rows(0)("NombreClient")
                    Me.TextBoxAgrpeUs.Text = DT.Rows(0)("ApellidoClient")
                    Me.TextBoxAgrTel.Text = DT.Rows(0)("TelefonoClient")
                    Me.TextBoxAgrDirClient.Text = DT.Rows(0)("DireccionCient")
                    Me.TextBoxEmailCliente.Text = DT.Rows(0)("EmailClient")
                    s = DT.Rows(0)("TipoID")

                    'Me.ComboBox1.SelectedIndex = s

                    Desbloqueotextbox()
                    Me.ButtonModificarCliente.Visible = True
                    Me.ButtonGuardarCliente.Visible = False

                    Me.TextBoxAgrIDUs.ReadOnly = True

                ElseIf DT.Rows.Count > 1 Then

                    MsgBox("Error, usuario duplicado")

                    Me.ButtonModificarCliente.Visible = False
                    Me.ButtonGuardarCliente.Visible = False

                Else

                    MsgBox("El Cliente no se encuentra registrado")
                    Me.ButtonGuardarCliente.Visible = True
                    Me.ButtonModificarCliente.Visible = False
                    Me.ComboBox1.SelectedIndex = 0
                    Desbloqueotextbox()

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonModificarCliente_Click(sender As Object, e As EventArgs) Handles ButtonModificarCliente.Click

        Dim ok As Boolean

        If TextBoxAgrNomUs.Text <> "" And TextBoxAgrpeUs.Text <> "" And TextBoxAgrIDUs.Text <> "" Then

            EC.IDCliente = CUInt(TextBoxAgrIDUs.Text) 'Convertir Texto a Int Unsigned
            EC.TipoID = ComboBox1.SelectedItem.ToString
            EC.NombreClient = TextBoxAgrNomUs.Text
            EC.ApellidoClient = TextBoxAgrpeUs.Text
            EC.DireccionCient = TextBoxAgrDirClient.Text
            EC.EmailClient = TextBoxEmailCliente.Text

            'Valido para que no haya error al convertir string to Integer
            If TextBoxAgrTel.Text <> "" Then
                EC.TelefonoClient = CUInt(TextBoxAgrTel.Text)
            Else
                EC.TelefonoClient = 0
            End If

            Try
                ok = NC.ModificarCliente(EC)
                If ok = True Then
                    MsgBox("Los datos del cliente se modificaron con éxito")
                    Me.Close()
                Else
                    MsgBox("Error en los datos ingresados")
                End If
            Catch ex As Exception
                'Excepción codificada
                If ex.ToString.Contains("duplicate key") Then
                    MsgBox("El Cliente ya existe")
                Else
                    MsgBox(ex.Message)
                End If
            End Try

        Else
            MsgBox("Debe llenar todos los datos del formulario")

        End If
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Focus()
    End Sub

End Class