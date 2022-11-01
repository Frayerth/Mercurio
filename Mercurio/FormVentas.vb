Imports CapaEntidades
Imports CapaNegocio
Imports LibPrintTicket

Public Class FormVentas

    'Instancio las Clases EntCliente y NegCliente, recordar que la Capa de Mercurio referencia a la Capa de 
    'Negocio y a la Caapa de Negocio y la Capa de Negocio referencia a la Capa de Datos

    Dim EC As New EntClientes
    Dim NC As New NegCliente
    Dim ED As New EntDetalle
    Dim ND As New NegDetalle
    Public EF As New EntFactura
    Public NF As New NegFactura
    Dim Eprod As New EntProducto
    Dim NegProd As New NegProducto
    Public NumFactura As Integer
    Public ExisteFactura As Integer = 0 '1 sí existe una factura creada pero no se facturó. 2 Ya se facturó
    Dim ticket As New Ticket()

    Private Function Sumasubtotal() As Double

        Dim total As Double = 0
        Dim iTotal As Integer = Me.DataGridViewVenta.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
        'Definimos la variable i para controlar el ciclo for
        Dim i As Integer
        'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
        For i = 0 To iTotal - 1
            'Double.parse()<---es para convertir a double el valor que se encuentre entre lso parentesis
            'me.datagridview1(4,i).value <----toma todos los valores de la columna 4... 4 es el numero de columna y i es el numero de fila asi toma todos los 
            'valores de esa columna, recuerda que las columnas inician en 0... asi que la 4 enrealidad sera la 5 visualmente
            total = total + Double.Parse(Me.DataGridViewVenta(4, i).Value)
        Next
        'Mostramos el total en la caja de texto TxtTotal, en este caso la caja de texto tiene definido un formato como se mostrara el resultado, como dinero..
        Return total

    End Function

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

        Me.TextBoxNombreCliente.Text = ""
        Me.TextBoxApellidoCliente.Text = ""
        Me.TextBoxTelCliente.Text = ""
        Me.TextBoxDirCliente.Text = ""
        Me.TextBoxEmailCliente.Text = ""
        Me.ComboBox1.SelectedIndex = 0

    End Sub

    Public Sub Desbloqueotextbox()

        Me.TextBoxNombreCliente.Enabled = True
        Me.TextBoxApellidoCliente.Enabled = True
        Me.TextBoxTelCliente.Enabled = True
        Me.TextBoxDirCliente.Enabled = True
        Me.TextBoxEmailCliente.Enabled = True

    End Sub

    Public Sub Bloqueotextbox()

        Me.TextBoxIDCliente.Enabled = False
        Me.TextBoxNombreCliente.Enabled = False
        Me.TextBoxApellidoCliente.Enabled = False
        Me.TextBoxTelCliente.Enabled = False
        Me.TextBoxDirCliente.Enabled = False
        Me.TextBoxEmailCliente.Enabled = False

    End Sub

    Private Sub TextBoxIDCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxIDCliente.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBoxTelCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelCliente.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBoxCodProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCodProd.KeyPress

        solonumeros(e)

        'Pregunto por el comando Enter para realizar la búsqueda del producto, como con el botón Buscar
        If e.KeyChar = Chr(13) Then
            If TextBoxCodProd.Text <> "" Then
                BuscarProducto(TextBoxCodProd.Text)
            End If
        End If

    End Sub

    Private Sub TextBoxCodProd_Enter(sender As Object, e As EventArgs) Handles TextBoxCodProd.Enter
        If TextBoxCodProd.Text <> "" Then
            BuscarProducto(TextBoxCodProd.Text)
        End If
    End Sub

    Private Sub TextBoxIDCliente_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIDCliente.TextChanged
        LimpiarTextbox()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.TextBoxIDCliente.Enabled = True
        Me.ButtonBuscarCliente.Visible = True
    End Sub

    Private Sub BuscarProducto(ByRef str As String)

        Dim DT As New DataTable

        Try

            Eprod.IDProducto = CDbl(str)
            DT = NegProd.BuscarProducto(Eprod)

            My.Forms.FormDetalle.LlenarTextBox(DT)
            My.Forms.FormDetalle.Show()

            Me.ButtonSacarProducto.Enabled = True

        Catch ex As Exception

            MsgBox("El Producto que busca no existe")

        End Try

    End Sub

    Public Sub CrearFactura()

        'IDUsuario, Usuario, ya están asignadas en FormLogin, NumFactura en FormClientes o FormLogin 
        'IDCliente en FormVentas. El Exento y Descuento se actualizan cuando se Finaliza la operación.

        EF.IDUsuario = My.Forms.FormPrincipal.EF.IDUsuario
        EF.Usuario = My.Forms.FormPrincipal.EF.Usuario

        EF.Descuento = 0
        EF.Exento = 0

        Try

            NF.AgregarFactura(EF)

            ExisteFactura = 1 'Indicamos que se creó la factura

            NumFactura = NF.UltimoNumFactura

            'Definimos la fuente de datos para el Datagrid

            ED.NumFactura = NumFactura

            Me.DataGridViewVenta.DataSource = ND.LlenarGridVentas(ED)

            Me.DataGridViewVenta.Columns(0).HeaderText = "NOMBRE DEL PRODUCTO"
            Me.DataGridViewVenta.Columns(1).HeaderText = "LABORATORIO"
            Me.DataGridViewVenta.Columns(2).HeaderText = "VAL. UNITARIO"
            Me.DataGridViewVenta.Columns(3).HeaderText = "CANTIDAD"
            Me.DataGridViewVenta.Columns(4).HeaderText = "SUBTOTAL"

            ' Referenciamos la columna
            Dim column1 As DataGridViewColumn = DataGridViewVenta.Columns(2)
            Dim column2 As DataGridViewColumn = DataGridViewVenta.Columns(4)
            ' Asignamos el formato de moneda con dos decimales
            column1.DefaultCellStyle.Format = "C2"
            column2.DefaultCellStyle.Format = "C2"

            Me.DataGridViewVenta.Columns(0).Width = 250
            Me.DataGridViewVenta.Columns(1).Width = 240
            Me.DataGridViewVenta.Columns(2).Width = 100
            Me.DataGridViewVenta.Columns(3).Width = 77
            Me.DataGridViewVenta.Columns(4).Width = 100

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ButtonBuscarCliente.Visible = False
        Bloqueotextbox()

        Me.ComboBox1.Focus()

    End Sub

    Private Sub FormVentas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPrincipal.Show()
    End Sub

    Private Sub ButtonImprimir_Click(sender As Object, e As EventArgs) Handles ButtonImprimir.Click

        ExisteFactura = 2 'Ya se facturó

        Dim Prod As String = ""
        Dim Cant As String = ""
        Dim ST As Double = 0


        ticket.AddHeaderLine("Mercurio V.1.0")
        ticket.AddHeaderLine("DERMO ESTÉTICA FACIAL Y CORPORAL")
        ticket.AddHeaderLine("NIT. 36.290.194")
        ticket.AddHeaderLine("Cra 5 # 11 - 10 B. Sucre - Pitalito")
        ticket.AddHeaderLine("Atendido por: " & EF.Usuario)
        ticket.AddHeaderLine("Factura No.: " & CStr(EF.NumFactura))

        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())

        Dim iTotal As Integer = Me.DataGridViewVenta.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            Prod = Me.DataGridViewVenta(0, i).Value.ToString
            Cant = Me.DataGridViewVenta(3, i).Value.ToString
            ST = Double.Parse(Me.DataGridViewVenta(4, i).Value.ToString)

            ticket.AddItem(Cant, Prod, Format(ST, "$ #,##0.00"))

        Next

        ticket.AddTotal("EXENTO:", "" & TextBox1.Text)
        ticket.AddTotal("DESCUENTO:", "" & TextBox5.Text)
        ticket.AddTotal("", "")
        ticket.AddTotal("GRABADO:", "" & TextBox2.Text)
        ticket.AddTotal("IVA", "" & TextBox3.Text)
        ticket.AddTotal("TOTAL", "" & TextBox4.Text)
        ticket.AddTotal("", "")

        ticket.AddFooterLine("¡Gracias por su compra!")
        ticket.AddFooterLine("")
        ticket.AddFooterLine("")
        ticket.AddFooterLine("Impreso por: Quality Engineering")
        ticket.AddFooterLine("NIT. 900845311-7 q-e.com.co")

        ticket.PrintTicket("THERMAL Receipt Printer") 'Nombre de la impresora de tickets
        'ticket.PrintTicket("THERMAL Receipt Printer") 'Nombre de la impresora de tickets

        Me.Close()

    End Sub

    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click

        'Instancio DT como DataTable para almacenar los datos de los usuarios ya registrados

        Dim DT As New DataTable
        Static st As Integer = 1 'Para creación de la factura

        Try

            'Compruebo que no esté vacio el campo de ID del usuario

            If Me.TextBoxIDCliente.Text <> "" Then
                EC.IDCliente = CUInt(Me.TextBoxIDCliente.Text) 'Convertir Texto a Int Unsigned
                DT = NC.BuscarCliente(EC)

                'Si hay al menos 1 usuario registrado (fila > 0), Row busca la fila Usuario.

                If DT.Rows.Count = 1 Then

                    Me.TextBoxNombreCliente.Text = DT.Rows(0)("NombreClient")
                    Me.TextBoxApellidoCliente.Text = DT.Rows(0)("ApellidoClient")
                    Me.TextBoxTelCliente.Text = DT.Rows(0)("TelefonoClient")
                    Me.TextBoxDirCliente.Text = DT.Rows(0)("DireccionCient")
                    Me.TextBoxEmailCliente.Text = DT.Rows(0)("EmailClient")
                    Me.ComboBox1.SelectedValue = DT.Rows(0)("TipoID")
                    EF.IDCliente = EC.IDCliente 'Para la factura
                    Me.TextBoxCodProd.ReadOnly = False
                    Me.ButtonAgregarProducto.Enabled = True
                    Me.ButtonBuscarLab.Enabled = True

                    If st = 1 Then
                        Me.CrearFactura()
                    End If

                    st = st + 1 'Para no crear más facturas cada vez que Busco el cliente

                ElseIf DT.Rows.Count > 1 Then

                    MsgBox("Error, usuario duplicado")

                Else

                    MsgBox("El Cliente no se encuentra registrado")
                    My.Forms.FormClientes.TextBoxAgrIDUs.Text = Me.TextBoxIDCliente.Text
                    My.Forms.FormClientes.TextBoxAgrIDUs.ReadOnly = True
                    My.Forms.FormClientes.ButtonBuscarCliente.Visible = False
                    My.Forms.FormClientes.ButtonGuardarCliente.Visible = True
                    My.Forms.FormClientes.ButtonModificarCliente.Visible = False
                    My.Forms.FormClientes.ComboBox1.SelectedIndex = Me.ComboBox1.SelectedIndex
                    My.Forms.FormClientes.ComboBox1.Enabled = False
                    My.Forms.FormClientes.Show()

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonAgregarProducto_Click(sender As Object, e As EventArgs) Handles ButtonAgregarProducto.Click

        If TextBoxCodProd.Text <> "" Then
            BuscarProducto(TextBoxCodProd.Text)
        End If

    End Sub

    Private Sub ButtonVender_Click(sender As Object, e As EventArgs) Handles ButtonVender.Click

        Dim response As MsgBoxResult
        Dim subtotal As Double
        Dim grabado As Double
        Dim iva As Double
        Dim total As Double

        If ButtonVender.Text = "Totalizar" Then

            'Valido si la factura poseerá descuento o exento
            response = MsgBox("¿Factura con Descuento o Exento?", MsgBoxStyle.YesNo)

            If response = MsgBoxResult.Yes Then

                Me.Label9.Visible = True
                Me.Label15.Visible = True
                Me.TextBox1.Visible = True
                Me.TextBox5.Visible = True
                Me.TextBox1.ReadOnly = False
                Me.TextBox5.ReadOnly = False
                ButtonVender.Text = "Calcular"

            Else 'No tendrá Exento ni descuento

                Me.Label9.Visible = False
                Me.Label15.Visible = False
                Me.TextBox1.Visible = False
                Me.TextBox5.Visible = False
                Me.TextBox1.ReadOnly = True
                Me.TextBox5.ReadOnly = True
                Me.TextBox1.Text = "0"
                Me.TextBox5.Text = "0"

                subtotal = Sumasubtotal()
                'Grabado = (Subtotal) / 1.19 
                grabado = (subtotal) / 1.19
                TextBox2.Text = Format(grabado, "$ #,##0.00")
                'IVA = Grabado * 19 %
                iva = grabado * 0.19
                TextBox3.Text = Format(iva, "$ #,##0.00")
                'Total = Grabado + IVA
                total = grabado + iva
                TextBox4.Text = Format(total, "$ #,##0.00")

                ButtonVender.Text = "Totalizar"
                ButtonVender.Enabled = False
                ButtonImprimir.Enabled = True

                EF.Exento = 0 'Para la factura
                EF.Descuento = 0 'Para la factura
                EF.NumFactura = NumFactura
                EF.Grabado = grabado

                NF.ModificarFactura(EF)
                My.Forms.FormPago.Show()

            End If

        Else

            If Me.TextBox1.Text <> "" And Me.TextBox5.Text <> "" Then

                Me.TextBox1.Text = Format(CDbl(TextBox1.Text), "$ #,##0.00")
                Me.TextBox5.Text = Format(CDbl(TextBox5.Text), "$ #,##0.00")

                EF.Exento = CDbl(TextBox1.Text) 'Para la factura
                EF.Descuento = CDbl(TextBox5.Text) 'Para la factura

                subtotal = Sumasubtotal()
                'Grabado = (Subtotal - Exento - Descuento) / 1.19 
                grabado = (subtotal - CDbl(TextBox1.Text) - CDbl(TextBox5.Text)) / 1.19
                TextBox2.Text = Format(grabado, "$ #,##0.00")
                'IVA = Grabado * 19 %
                iva = grabado * 0.19
                TextBox3.Text = Format(iva, "$ #,##0.00")
                'Total = Exento + Grabado + IVA
                total = CDbl(TextBox1.Text) + grabado + iva
                TextBox4.Text = Format(total, "$ #,##0.00")

                ButtonVender.Text = "Totalizar"
                ButtonVender.Enabled = False
                ButtonImprimir.Enabled = True

                EF.NumFactura = NumFactura
                EF.Grabado = grabado

                NF.ModificarFactura(EF)
                My.Forms.FormPago.Show()

            Else
                MsgBox("Ingrese un valor válido de Exento y Descuento")
            End If

        End If
    End Sub

    Private Sub ButtonBuscarLab_Click(sender As Object, e As EventArgs) Handles ButtonBuscarLab.Click
        My.Forms.FormBusProdLab.Show()
    End Sub

    Private Sub DataGridViewVenta_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridViewVenta.RowsAdded
        ButtonVender.Enabled = True
    End Sub

    Private Sub ButtonSacarProducto_Click(sender As Object, e As EventArgs) Handles ButtonSacarProducto.Click

        Dim ok As Boolean

        If DataGridViewVenta.CurrentRow.Selected = True Then

            'Almaceno en str el valor de la celda Nombre del Producto de la fila seleccionada
            ED.NombreProd = Me.DataGridViewVenta.CurrentRow.Cells.Item(0).Value.ToString()
            ED.NumFactura = NumFactura
            Eprod.NombreProd = ED.NombreProd 'Para la búsqueda del producto

            'Almaceno en Cantidad el valor de la celda Cantidad del Producto de la fila seleccionada para actualizar Stock
            Dim Cantidad As Integer = CUInt(Me.DataGridViewVenta.CurrentRow.Cells.Item(3).Value.ToString())

            Try

                ok = ND.EliminarDetalle(ED)
                If ok = True Then
                    MsgBox("El producto ha sido retirado de la factura", MsgBoxStyle.Information)
                    Me.DataGridViewVenta.DataSource = ND.LlenarGridVentas(ED)

                    'Busco con el nombre del Producto el Producto para modificar el Stock

                    Dim DTP As New DataTable
                    DTP = NegProd.BuscarProductoSoloNombre(Eprod)

                    Eprod.Stock = DTP.Rows(0)("Stock") + Cantidad
                    Eprod.PrecioCompra = DTP.Rows(0)("PrecioCompra")
                    Eprod.Precio = DTP.Rows(0)("Precio")
                    Eprod.IDProducto = DTP.Rows(0)("IDProducto")
                    ok = NegProd.ModificarProductoStock(Eprod) 'Actualizo el Stock

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Debe seleccionar un producto para ser retirado de la factura")
        End If

    End Sub

    Private Sub FormVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Cant As Integer
        Dim NomProd As String
        Dim DTP As New DataTable

        If ExisteFactura = 1 Then

            Dim iTotal As Integer = Me.DataGridViewVenta.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
            Dim i As Integer
            For i = 0 To iTotal - 1
                Cant = CUInt(Me.DataGridViewVenta.Rows(i).Cells.Item(3).Value.ToString())
                NomProd = Me.DataGridViewVenta.Rows(i).Cells.Item(0).Value.ToString()
                Eprod.NombreProd = NomProd
                DTP = NegProd.BuscarProductoSoloNombre(Eprod)
                Eprod.Stock = DTP.Rows(0)("Stock") + Cant
                Eprod.Precio = DTP.Rows(0)("Precio")
                Eprod.PrecioCompra = DTP.Rows(0)("PrecioCompra")
                Eprod.IDProducto = DTP.Rows(0)("IDProducto")
                NegProd.ModificarProductoStock(Eprod) 'Actualizo el Stock
            Next


            'Elimino los detalles y facturas creadas que no se facturaron

            ED.NumFactura = NumFactura
            ND.EliminarDetallesFactura(ED)
            EF.NumFactura = NumFactura
            NF.EliminarFactura(EF)



        End If

    End Sub


End Class