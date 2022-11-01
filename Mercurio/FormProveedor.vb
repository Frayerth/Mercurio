Imports CapaEntidades
Imports CapaNegocio

Public Class FormProveedor

    'Instancio las Clases Entsuario y NegUsuario, recordar que la Capa de Mercurio referencia a la Capa de 
    'Negocio y a la Caapa de Negocio y la Capa de Negocio referencia a la Capa de Datos

    Dim EP As New EntProveedores
    Dim NP As New NegProveedores
    Dim DT As New DataTable
    Dim Estado As Integer '1 para Agregar, 2 para modificar, 3 para eliminar Proveedor

    'Función que sólo permite que ingresen dígitos, se utilizará para validar el Doc. de Identidad
    Private Sub solonumeros(ByVal key As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(key.KeyChar) Then
            key.Handled = False
        ElseIf Char.IsControl(key.KeyChar) Then
            key.Handled = False
        Else
            key.Handled = True
        End If
    End Sub

    Private Sub Inicializar()

        Me.TextBoxLab.Text = ""
        Me.TextBoxNIT.Text = ""
        Me.TextBoxDV.Text = ""
        Me.TextBoxDir.Text = ""
        Me.TextBoxTel.Text = "0"

        Me.ListViewLaboratorios.Items.Clear()
        DT = NP.ListadeLaboratorios()

        'Lleno el listview con cada dato de la datatable que es quien posee los datos de resultado de llamar al SQL
        'de la consulta de lista de proveedores llamada a través de la función ListadeLaboratorio de la clase de Negocio

        For Each Row As DataRow In DT.Rows
            Dim Fila As New ListViewItem
            Fila = Me.ListViewLaboratorios.Items.Add(Row(0))
        Next

    End Sub

    Private Sub DesbloquearTextbox()
        Me.TextBoxLab.ReadOnly = False
        Me.TextBoxNIT.ReadOnly = False
        Me.TextBoxDV.ReadOnly = False
        Me.TextBoxDir.ReadOnly = False
        Me.TextBoxTel.ReadOnly = False
    End Sub

    Private Sub BloquearTextbox()
        Me.TextBoxLab.ReadOnly = True
        Me.TextBoxNIT.ReadOnly = True
        Me.TextBoxDV.ReadOnly = True
        Me.TextBoxDir.ReadOnly = True
        Me.TextBoxTel.ReadOnly = True
    End Sub

    Private Sub BuscarProvee(ByRef str As String)

        Try

            EP.RazonSocial = str
            DT = NP.BuscarProveedor(EP)

            Me.TextBoxNIT.Text = DT.Rows(0)("NIT")
            Me.TextBoxDV.Text = DT.Rows(0)("DV")
            Me.TextBoxDir.Text = DT.Rows(0)("DireccionProvee")
            Me.TextBoxTel.Text = DT.Rows(0)("TelefonoProvee")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBoxNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNIT.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBoxDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDV.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBoxTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTel.KeyPress
        solonumeros(e)
    End Sub

    Private Sub FormProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ListViewLaboratorios.View = View.Details
        Me.ListViewLaboratorios.Columns.Add("Laboratorios:", 190, HorizontalAlignment.Left)

        Inicializar()
        BloquearTextbox()

        Me.ToolTip1.SetToolTip(TextBoxNIT, "Si no conoce el NIT y DV, dejar estas dos casillas vacías")
        Me.ToolTip2.SetToolTip(CheckBoxNIT, "Si no conoce el NIT y DV, dejar estas dos casillas vacías")

        Me.ButtonAgrProvee.Visible = False
        Me.ButtonModProvee.Visible = False
        Me.ButtonElimProvee.Visible = False

    End Sub

    Private Sub ButtonCancelProvee_Click(sender As Object, e As EventArgs) Handles ButtonCancelProvee.Click
        Me.Close()
    End Sub

    Private Sub CheckBoxNIT_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNIT.CheckedChanged
        Dim Check As Boolean
        Check = Me.CheckBoxNIT.Checked()

        If Check Then
            Me.TextBoxNIT.Enabled = True
            Me.TextBoxDV.Enabled = True
        Else
            Me.TextBoxNIT.Enabled = False
            Me.TextBoxDV.Enabled = False
        End If

    End Sub

    Private Sub ButtonAgrProvee_Click(sender As Object, e As EventArgs) Handles ButtonAgrProvee.Click

        Dim ok As Boolean

        If Me.TextBoxLab.Text <> "" Then

            EP.RazonSocial = Me.TextBoxLab.Text
            EP.DireccionProvee = Me.TextBoxDir.Text

            'Valido que exista un número de Teléfono para evitar el error de conversión CDbl.

            If Me.TextBoxTel.Text <> "" Then
                EP.TelefonoProvee = CDbl(Me.TextBoxTel.Text)
            Else
                EP.TelefonoProvee = 0
            End If

            'Valido que exista un NIT y DV en caso de haber checkeado el CheckBox, sino se checkea asigno el valor de 0
            'al EP.NIT para que sea el SQL quien coloque un valor de NIT único ya que, es la llave de la tabla.

            If Me.CheckBoxNIT.Checked Then

                Try
                    If Me.TextBoxNIT.Text <> "" And Me.TextBoxDV.Text <> "" And CDbl(Me.TextBoxNIT.Text) > 0 And CDbl(Me.TextBoxNIT.Text) > 10000000 Then
                        EP.NIT = CDbl(Me.TextBoxNIT.Text)
                        EP.DV = CInt(Me.TextBoxDV.Text)

                        Try
                            ok = NP.AgregarProveedor(EP)
                            If ok = True Then
                                MsgBox("El nuevo Laboratorio se guardó con éxito", MsgBoxStyle.Information)
                                Inicializar()
                                'Actualizo el ComboBox de la Form Inventario o Compras para que aparezca el Lab agregado
                                If My.Forms.FormCompras.Proveedor = 1 Then
                                    My.Forms.FormCompras.llenarcombobox()
                                ElseIf My.Forms.FormInventario.Proveedor = 2 Then
                                    My.Forms.FormInventario.llenarcombobox()
                                End If

                            Else
                                MsgBox("Error en los datos ingresados", MsgBoxStyle.Critical)
                            End If
                        Catch ex As Exception
                            'Excepción codificada
                            If ex.ToString.Contains("duplicate key") Then
                                MsgBox("El Laboratorio ya existe", MsgBoxStyle.Exclamation)
                            Else
                                MsgBox(ex.Message)
                            End If
                        End Try

                    Else
                        MsgBox("Ingresa un valor de NIT o DV correcto", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    'Excepción codificada
                    If ex.ToString.Contains("System.InvalidCastException") Then
                        MsgBox("Valor de NIT no válido", MsgBoxStyle.Critical)
                    Else
                        MsgBox(ex.Message)
                    End If
                End Try

            Else

                'Sino checkeo, es decir, si no conozco el NIT

                EP.NIT = 0
                Try
                    ok = NP.AgregarProveedor(EP)
                    If ok = True Then
                        MsgBox("El nuevo Laboratorio se guardó con éxito", MsgBoxStyle.Information)
                        Inicializar()
                        'Actualizo el ComboBox de la Form Inventario o Compras para que aparezca el Lab agregado
                        If My.Forms.FormCompras.Proveedor = 1 Then
                            My.Forms.FormCompras.llenarcombobox()
                        ElseIf My.Forms.FormInventario.Proveedor = 2 Then
                            My.Forms.FormInventario.llenarcombobox()
                        End If
                    Else
                        MsgBox("Error en los datos ingresados", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    'Excepción codificada
                    If ex.ToString.Contains("duplicate key") Then
                        MsgBox("El usuario ya existe", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox(ex.Message)
                    End If
                End Try
            End If
        Else

            MsgBox("Ingresa un Laboratorio", MsgBoxStyle.Exclamation)

        End If

    End Sub

    Private Sub ButtonModProvee_Click(sender As Object, e As EventArgs) Handles ButtonModProvee.Click

        Dim ok As Boolean

        'Valido que ya se haya seleccionado un laboratorio para modificar

        If Me.TextBoxNIT.Text <> "" And Me.TextBoxLab.Text <> "" Then

            EP.RazonSocial = Me.TextBoxLab.Text
            EP.DireccionProvee = Me.TextBoxDir.Text
            EP.NIT = CDbl(Me.TextBoxNIT.Text)
            EP.DV = CInt(Me.TextBoxDV.Text)

            'Valido que exista un número de Teléfono para evitar el error de conversión CDbl.

            If Me.TextBoxTel.Text <> "" Then
                EP.TelefonoProvee = CDbl(Me.TextBoxTel.Text)
            Else
                EP.TelefonoProvee = 0
            End If

            Try
                ok = NP.ModificarProveedor(EP)
                If ok = True Then
                    MsgBox("Los datos del Laboratorio se modificaron con éxito", MsgBoxStyle.Information)
                    Inicializar()
                Else
                    MsgBox("Error en los datos ingresados", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                'Excepción codificada
                If ex.ToString.Contains("duplicate key") Then
                    MsgBox("El Laboratorio ya existe", MsgBoxStyle.Exclamation)
                Else
                    MsgBox(ex.Message)
                End If
            End Try

        Else
            MsgBox("Elija un Laboratorio para modificar", MsgBoxStyle.Exclamation)

        End If

    End Sub

    Private Sub ButtonElimProvee_Click(sender As Object, e As EventArgs) Handles ButtonElimProvee.Click

        Dim ok As Boolean

        'Valido que ya se haya seleccionado un laboratorio para eliminar

        If Me.TextBoxNIT.Text <> "" And Me.TextBoxLab.Text <> "" Then
            EP.RazonSocial = Me.TextBoxLab.Text
            Try
                ok = NP.EliminarProveedor(EP)
                If ok = True Then
                    MsgBox("El Laboratorio ha sido eliminado", MsgBoxStyle.Information)
                    Inicializar()
                    If My.Forms.FormCompras.Proveedor = 1 Then
                        My.Forms.FormCompras.llenarcombobox()
                    ElseIf My.Forms.FormInventario.Proveedor = 2 Then
                        My.Forms.FormInventario.llenarcombobox()
                    End If
                Else
                    MsgBox("Error al eliminar el Laboratorio", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                'Excepción codificada
                If ex.ToString.Contains("REFERENCE constraint ""FK_Producto_Proveedores""") Then
                    MsgBox("Este Proveedor tiene asociado varios productos, por lo tanto, para poder eliminarlo como Proveedor debe primero eliminar todos los productos asociados a este Proveedor", MsgBoxStyle.Critical)
                Else
                    MsgBox(ex.Message)
                End If
            End Try
        Else
            MsgBox("Elija un Laboratorio para eliminar", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click

        Estado = 1

        Inicializar()
        DesbloquearTextbox()

        Me.TextBoxNIT.Enabled = False
        Me.TextBoxDV.Enabled = False
        Me.ButtonAgrProvee.Visible = True
        Me.ButtonModProvee.Visible = False
        Me.ButtonElimProvee.Visible = False

    End Sub

    Private Sub ModificarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProveedorToolStripMenuItem.Click

        Estado = 2

        Inicializar()
        BloquearTextbox()

        Me.TextBoxNIT.Enabled = False
        Me.TextBoxDV.Enabled = False
        Me.ButtonAgrProvee.Visible = False
        Me.ButtonModProvee.Visible = True
        Me.ButtonElimProvee.Visible = False

    End Sub

    Private Sub EliminarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProveedorToolStripMenuItem.Click

        Estado = 3

        Inicializar()
        BloquearTextbox()

        Me.ButtonAgrProvee.Visible = False
        Me.ButtonModProvee.Visible = False
        Me.ButtonElimProvee.Visible = True

    End Sub

    Private Sub ListViewLaboratorios_DoubleClick(sender As Object, e As EventArgs) Handles ListViewLaboratorios.DoubleClick

        Dim str As String

        If Me.ListViewLaboratorios.SelectedItems.ToString <> "" And Estado = 2 Then
            str = Me.ListViewLaboratorios.FocusedItem.Text
            Me.TextBoxLab.Text = str
            BuscarProvee(str)
            Me.TextBoxDir.ReadOnly = False
            Me.TextBoxTel.ReadOnly = False
        ElseIf Me.ListViewLaboratorios.SelectedItems.ToString <> "" And Estado = 3 Then
            str = Me.ListViewLaboratorios.FocusedItem.Text
            Me.TextBoxLab.Text = str
            BuscarProvee(str)
        End If

    End Sub

End Class