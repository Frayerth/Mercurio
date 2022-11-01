Imports CapaEntidades
Imports CapaNegocio

Public Class FormCompras

    Dim EProd As New EntProducto
    Dim NegProd As New NegProducto
    Dim EProvee As New EntProveedores
    Dim NProvee As New NegProveedores
    Dim DTProvee As New DataTable
    Dim EDC As New EntDetalleCompra
    Dim NDC As New NegDetalleCompra
    Dim Estado As Integer 'Para saber si está en 1. Crear nuevo Producto. 0 Ya existe
    Public Proveedor As Integer = 0 'Para saber la Form Proveedor si llena el combobox de FormCompras (1) o FormInventario (2)

    Private Sub solonumeros(ByVal key As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(key.KeyChar) Then
            key.Handled = False
        ElseIf Char.IsControl(key.KeyChar) Then
            key.Handled = False
        Else
            key.Handled = True
        End If
    End Sub

    Private Sub TextBoxCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCod.KeyPress, TextBox1.KeyPress
        solonumeros(e)

        'Pregunto por el comando Enter para realizar la búsqueda del producto, como con el botón Buscar
        If e.KeyChar = Chr(13) Then
            If TextBoxCod.Text <> "" Then
                BuscarProducto(TextBoxCod.Text)
            End If
        End If

    End Sub

    Private Sub TextBoxVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxVenta.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.TextBoxCod.ReadOnly = False
        Me.ButtonBuscar.Enabled = True
    End Sub

    Private Sub TextBoxCod_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCod.TextChanged
        LimpiarTextbox()
    End Sub

    Private Sub DesbloquearTxtbox()

        Me.TextBoxNom.ReadOnly = False
        Me.TextBoxPrecio.ReadOnly = False
        Me.TextBoxVenta.ReadOnly = False
        Me.TextBoxStock.ReadOnly = False
        Me.TextBoxCant.ReadOnly = False
        Me.ComboBox1.Enabled = True

    End Sub

    Public Sub BloquearTxtbox()

        Me.TextBoxCod.ReadOnly = True
        Me.TextBoxNom.ReadOnly = True
        Me.TextBoxPrecio.ReadOnly = True
        Me.TextBoxVenta.ReadOnly = True
        Me.TextBoxCant.ReadOnly = True
        Me.TextBoxStock.ReadOnly = True
        Me.ComboBox1.Enabled = False

    End Sub

    Public Sub LimpiarTextbox()

        Me.TextBoxVenta.Text = ""
        Me.TextBoxPrecio.Text = ""
        Me.TextBoxNom.Text = ""
        Me.TextBoxPrecio.Text = ""
        Me.TextBoxStock.Text = ""
        Me.TextBoxCant.Text = ""
        'Me.ComboBox1.SelectedIndex = 0

    End Sub

    Public Sub llenarcombobox()

        Me.ComboBox1.Items.Clear()
        DTProvee = NProvee.ListadeLaboratorios()

        'Lleno el ComboBox con cada dato de la datatable que es quien posee los datos de resultado de llamar al SQL
        'de la consulta de lista de proveedores llamada a través de la función ListadeLaboratorio de la clase de Negocio

        For Each Row As DataRow In DTProvee.Rows
            Me.ComboBox1.Items.Add(Row(0)) 'Row 0 contiene Razón Social, el 1 el NIT
        Next

        'Me.ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub BuscarProducto(ByRef str As String)

        Dim DTProvee2 As New DataTable
        Dim DT As New DataTable

        BloquearTxtbox()

        Try

            EProd.IDProducto = CDbl(str)
            DT = NegProd.BuscarProducto(EProd)

            Me.TextBoxNom.Text = DT.Rows(0)("NombreProd")
            Me.TextBoxPrecio.Text = DT.Rows(0)("PrecioCompra")
            Me.TextBoxVenta.Text = DT.Rows(0)("Precio")
            Me.TextBoxPrecio.ReadOnly = False
            Me.TextBoxVenta.ReadOnly = False
            Me.TextBoxStock.Text = DT.Rows(0)("Stock")

            EProvee.NIT = DT.Rows(0)("NIT")
            DTProvee2 = NProvee.BuscarProveedorconNIT(EProvee)

            Me.ComboBox1.SelectedItem = DTProvee2.Rows(0).Item(2)

            Me.TextBoxCant.ReadOnly = False
            Me.ComboBox1.Enabled = False

            Estado = 0 'Indico que existe el producto

        Catch ex As Exception

            Estado = 1 'Indico que no existe el producto
            MsgBox("El Producto que busca no existe")
            ButtonGuardar.Text = "Crear Producto"
            DesbloquearTxtbox()
            Me.TextBox1.ReadOnly = True
            'El Stock no debe existir al crear un nuevo producto.
            Me.TextBoxStock.ReadOnly = True
            Me.TextBoxStock.Text = 0
            Me.TextBoxCod.ReadOnly = False
            Me.ButtonAgrLab.Enabled = True

        End Try
    End Sub

    Private Sub LlenarGridCompra(ByVal dat As DataTable)

        'Definimos la fuente de datos para el Datagrid
        Me.DataGridViewCompra.DataSource = dat

        Me.DataGridViewCompra.Columns(0).HeaderText = "CÓDIGO"
        Me.DataGridViewCompra.Columns(1).HeaderText = "NOMBRE DEL PRODUCTO"
        Me.DataGridViewCompra.Columns(2).HeaderText = "LABORATORIO"
        Me.DataGridViewCompra.Columns(3).HeaderText = "PRECIO"
        Me.DataGridViewCompra.Columns(4).HeaderText = "STOCK"

        Me.DataGridViewCompra.Columns(0).Width = 120
        Me.DataGridViewCompra.Columns(1).Width = 280
        Me.DataGridViewCompra.Columns(2).Width = 200
        Me.DataGridViewCompra.Columns(3).Width = 100
        Me.DataGridViewCompra.Columns(4).Width = 67

    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        BuscarProducto(TextBoxCod.Text)
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        Dim ok As Boolean
        Dim s As String
        Dim Row() As DataRow

        'SIN CANTIDAD NO SE PUEDE HACER NADA.

        If TextBoxCant.Text <> "" Then

            'Valido que exista Código del Producto y nombre del Producto

            If Me.TextBoxCod.Text <> "" And Me.TextBoxNom.Text <> "" And Me.TextBoxPrecio.Text <> "" And Me.TextBoxVenta.Text <> "" Then

                'Primero agrego el producto si no existe

                If Estado = 1 Then

                    Me.ButtonBuscar.Enabled = False
                    Me.TextBox1.ReadOnly = True

                    EProd.IDProducto = CDbl(Me.TextBoxCod.Text)
                    EProd.NombreProd = Me.TextBoxNom.Text

                    'Importante esta asignación debido a que no lo necesito en el inventario pero si lo requiere el SQL
                    EProd.DetalleProd = ""

                    EProd.Precio = CDec(Me.TextBoxVenta.Text)
                    EProd.PrecioCompra = CDec(Me.TextBoxPrecio.Text)
                    EProd.Stock = CUInt(TextBoxCant.Text)

                    'Obtengo la Razón Social del Proveedor asociado al producto
                    s = Me.ComboBox1.SelectedItem.ToString
                    'OJO, IMPORTANTE, SI NO SELECCIONO NADA EN EL COMBOBOX, SELECTEDITEM.TOSTRING DEVUELVE "ComboBox"
                    If s = "ComboBox" Then
                        s = ComboBox1.Items(0).ToString()
                    End If
                    'Busco en la DataTable del Proveedor, que está llena debido a que para llenar el combobox se realiza la búsqueda de las
                    'Razones sociales y NIT de los proveedores, con la función SQL Select RazonSocial = 's' y guardo la fila seleccionada

                    Row = DTProvee.Select("RazonSocial='" & s & "'")

                    EProd.NIT = CDbl(Row(0).Item(1))

                    Try
                        ok = NegProd.AgregarProducto(EProd)

                        If ok = True Then
                            MsgBox("Producto ingresado exitosamente", MsgBoxStyle.Information)
                            ButtonGuardar.Text = "Guardar Producto"
                            BloquearTxtbox()
                            Estado = 0

                        Else
                            MsgBox("Error en los datos ingresados", MsgBoxStyle.Critical)
                        End If
                    Catch ex As Exception
                        'Excepción codificada
                        If ex.ToString.Contains("duplicate key") Then
                            MsgBox("El Producto ya existe", MsgBoxStyle.Exclamation)
                        Else
                            MsgBox(ex.Message)
                        End If
                    End Try


                ElseIf Estado = 0 Then

                    ButtonGuardar.Text = "Guardar"
                    Me.TextBox1.ReadOnly = False
                    Me.ButtonBuscar.Enabled = True
                    'Segundo agrego el detalle de la factura de compra

                    EDC.NumFactura = TextBox1.Text
                    EDC.Cantidad = CUInt(TextBoxCant.Text)
                    EDC.IDProducto = CDbl(TextBoxCod.Text)

                    If TextBoxPrecio.Text <> "" Or TextBoxVenta.Text <> "" Then

                        EDC.Precio = CDec(TextBoxPrecio.Text)
                        EProd.PrecioCompra = CDec(TextBoxPrecio.Text)
                        EProd.Precio = CDec(TextBoxVenta.Text)

                        'Actualizo el Stock y Precio de Compra del producto
                        EProd.Stock = CUInt(TextBoxStock.Text) + EDC.Cantidad
                        NegProd.ModificarProductoStock(EProd)

                        NDC.AgregarDetalleCompra(EDC)

                        LlenarGridCompra(NDC.LlenarGridCompra(EDC))

                        'Para que no se pueda modificar el Num de Factura así todos los productos quedan en esa factura
                        Me.TextBox1.ReadOnly = True

                        'Limpio y desbloqueo para poder seguir ingregar productos a esta factura de compra
                        LimpiarTextbox()
                        BloquearTxtbox()
                        Me.TextBoxCod.Text = ""
                        Me.TextBoxCod.ReadOnly = False
                        Me.ButtonFinalizar.Enabled = True

                    Else
                        MsgBox("Debe ingresar un Precio", MsgBoxStyle.Exclamation)
                    End If

                End If

            Else
                If Me.TextBoxCod.Text = "" Or Me.TextBoxNom.Text = "" Then
                    MsgBox("El Producto debe tener un Código y un Nombre", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Debe ingresar un Precio", MsgBoxStyle.Exclamation)
                End If
            End If


        Else
            MsgBox("Ingrese una cantidad de productos", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub ButtonFinalizar_Click(sender As Object, e As EventArgs) Handles ButtonFinalizar.Click

        'Datos para la Factura de Compra
        My.Forms.FormDescuento.EFC.NumFactura = EDC.NumFactura
        My.Forms.FormDescuento.EFC.NIT = EProvee.NIT

        My.Forms.FormDescuento.Show()

    End Sub

    Private Sub ButtonAgrLab_Click(sender As Object, e As EventArgs) Handles ButtonAgrLab.Click
        My.Forms.FormProveedor.Show()
        Proveedor = 1
    End Sub

    Private Sub FormCompras_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarcombobox()
        LimpiarTextbox()
    End Sub


End Class