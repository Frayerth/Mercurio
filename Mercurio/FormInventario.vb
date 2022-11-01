Imports CapaEntidades
Imports CapaNegocio

Public Class FormInventario

    Dim EProduct As New EntProducto
    Dim EProvee As New EntProveedores
    Dim NProduct As New NegProducto
    Dim NProvee As New NegProveedores
    Dim DT As New DataTable
    Dim DTProvee As New DataTable
    Dim Estado As Integer 'Variables para conocer si estoy en guardar, agregar o eliminar. 1 Agregar. 2 Editar. 3 Eliminar. 4 Buscar
    Public Proveedor As Integer = 0 'Para saber la Form Proveedor si llena el combobox de FormCompras (1) o FormInventario (2)

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

    Private Sub LimpiarTextbox()

        Me.TextBoxCodProd.Text = ""
        Me.TextBoxNomProd.Text = ""
        Me.TextBoxPrecioProd.Text = ""
        Me.TextBoxStock.Text = ""

    End Sub

    Private Sub Inicializar()

        LimpiarTextbox()
        BloquearTextbox()
        llenarcombobox()
        Me.ButtonGuardarProd.Visible = False
        Me.ButtonCancelarProd.Visible = False

    End Sub

    Public Sub llenarcombobox()

        Me.ComboBoxLaboratorio.Items.Clear()
        DTProvee = NProvee.ListadeLaboratorios()

        'Lleno el ComboBox con cada dato de la datatable que es quien posee los datos de resultado de llamar al SQL
        'de la consulta de lista de proveedores llamada a través de la función ListadeLaboratorio de la clase de Negocio

        For Each Row As DataRow In DTProvee.Rows
            Me.ComboBoxLaboratorio.Items.Add(Row(0)) 'Row 0 contiene Razón Social, el 1 el NIT
        Next

        Me.ComboBoxLaboratorio.SelectedIndex = 0

    End Sub

    Private Sub DesbloquearTextbox()

        Me.TextBoxNomProd.ReadOnly = False
        Me.TextBoxPrecioProd.ReadOnly = False
        Me.TextBoxStock.ReadOnly = False
        Me.ComboBoxLaboratorio.Enabled = True

    End Sub

    Private Sub BloquearTextbox()

        Me.TextBoxCodProd.ReadOnly = True
        Me.TextBoxNomProd.ReadOnly = True
        Me.TextBoxPrecioProd.ReadOnly = True
        Me.TextBoxStock.ReadOnly = True
        Me.ComboBoxLaboratorio.Enabled = False

    End Sub

    Private Sub CondiBloquearButton()

        Me.ButtonBuscarProduct.Enabled = False
        Me.ButtonExportarExcel.Enabled = False
        Me.ButtonEditar.Visible = False
        Me.ButtonAgregProd.Visible = False
        Me.ButtonElimProd.Visible = False
        Me.ButtonGuardarProd.Visible = True
        Me.ButtonCancelarProd.Visible = True

    End Sub

    Private Sub CondiDesbloquearButton()

        Me.ButtonBuscarProduct.Enabled = True
        Me.ButtonExportarExcel.Enabled = True
        Me.ButtonExportarExcel.Visible = True
        Me.ButtonEditar.Visible = True
        Me.ButtonAgregProd.Visible = True
        Me.ButtonElimProd.Visible = True
        Me.ButtonGuardarProd.Visible = False
        Me.ButtonCancelarProd.Visible = False

    End Sub

    Private Sub bloquearradiobutton()
        Me.RadioButtonCD.Visible = False
        Me.RadioButtonNP.Visible = False
        Me.RadioButtonLab.Visible = False
    End Sub

    Private Sub BuscarProducto(ByRef str As String)

        Try

            EProduct.IDProducto = CDbl(str)
            DT = NProduct.BuscarProducto(EProduct)
            Dim Row() As DataRow
            Dim s As String

            Me.TextBoxCodProd.Text = DT.Rows(0)("IDProducto")
            Me.TextBoxNomProd.Text = DT.Rows(0)("NombreProd")
            Me.TextBoxStock.Text = DT.Rows(0)("Stock")
            Me.TextBoxPrecioProd.Text = Format(DT.Rows(0)("Precio"), "$ #,##0.00")

            'ESTA FUNCIÓN FUE MEJORADA CON LA LLAMADA AL CMD BUSCARPRODUCTONIT
            'Obtengo el NIT del Proveedor asociado al producto
            s = DT.Rows(0)("NIT")
            'Busco en la DataTable del Proveedor, que está llena debido a que para llenar el combobox se realiza la búsqueda de las
            'Razones sociales y NIT de los proveedores, con la función SQL Select NIT = 's' y guardo la fila seleccionada
            Row = DTProvee.Select("NIT='" & s & "'")
            'Le paso al ComboBox el item que debe seleccionar
            Me.ComboBoxLaboratorio.SelectedItem = Row(0).Item(0)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    'Función para exportar datos del DataGridViewInventario a Excel
    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)

        'Variable para indicar el título del Reporte y fecha de creación
        Dim titulo As String = "Reporte de inventario: " + Now.Date()

        Dim xlApp As Object = CreateObject("Excel.Application")

        'crear una nueva hoja de calculo 
        Dim xlWB As Object = xlApp.WorkBooks.add 'Creando el Libro
        Dim xlWS As Object = xlWB.WorkSheets(1)  'Creando la hoja de cálculo

        'Configurando Excel

        With xlWS

            'Encabezado.  

            .Range("A1:E1").Merge()
            .Range("A1:E1").Value = "REPORTE DE INVENTARIO"
            .Range("A1:E1").Font.Bold = True
            .Range("A1:E1").Font.Size = 16

            'Texto despues del encabezado.   

            .Range("A2:E2").Merge()
            .Range("A2:E2").Value = titulo
            .Range("A2:E2").Font.Bold = True
            .Range("A2:E2").Font.Size = 10

            'Espacio.

            .Range("A3:E3").Merge()
            .Range("A3:E3").Value = ""
            .Range("A3:E3").Font.Bold = True
            .Range("A3:E3").Font.Size = 10

            'Estilo a titulos de la tabla.

            .Range("A4:E4").Font.Bold = True

            'Establecer tipo de letra al rango determinado.

            .Range("A1:E1000").Font.Name = "Arial"

        End With

        Try
            'exportamos el encabezado de las columnas
            For c As Integer = 0 To DataGridViewInventario.Columns.Count - 1
                xlWS.cells(4, c + 1).value = DataGridViewInventario.Columns(c).HeaderText
            Next

            'exportamos las celdas
            For r As Integer = 0 To DataGridViewInventario.RowCount - 1
                For c As Integer = 0 To DataGridViewInventario.Columns.Count - 1
                    xlWS.cells(r + 5, c + 1).value = DataGridViewInventario.Item(c, r).Value
                Next
            Next

            'guardamos la hoja de calculo en la ruta especificada 
            xlWB.saveas(pth)
            xlWS = Nothing
            xlWB = Nothing
            xlApp.quit()
            xlApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try



    End Sub

    Private Sub TextBoxCodProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCodProd.KeyPress

        solonumeros(e)

        'Pregunto por el comando Enter para realizar la búsqueda del producto, como con el botón Buscar
        If e.KeyChar = Chr(13) Then
            If TextBoxCodProd.Text <> "" And Estado = 4 Then 'Estoy en buscar??????
                Try

                    EProduct.IDProducto = CDbl(Me.TextBoxCodProd.Text)
                    Me.DataGridViewInventario.DataSource = NProduct.BuscarProductoID(EProduct) 'Actualizo el DataGridView

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
            End If
        End If

    End Sub

    Private Sub TextBoxPrecioProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrecioProd.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStock.KeyPress
        solonumeros(e)
    End Sub

    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Definimos la fuente de datos para el Datagrid

        Me.DataGridViewInventario.DataSource = NProduct.LlenarGrid(EProduct)

        Me.DataGridViewInventario.Columns(0).HeaderText = "CÓDIGO"
        Me.DataGridViewInventario.Columns(1).HeaderText = "NOMBRE DEL PRODUCTO"
        Me.DataGridViewInventario.Columns(2).HeaderText = "LABORATORIO"
        Me.DataGridViewInventario.Columns(3).HeaderText = "PRECIO"
        Me.DataGridViewInventario.Columns(4).HeaderText = "STOCK"

        Me.DataGridViewInventario.Columns(0).Width = 120
        Me.DataGridViewInventario.Columns(1).Width = 280
        Me.DataGridViewInventario.Columns(2).Width = 280
        Me.DataGridViewInventario.Columns(3).Width = 100
        Me.DataGridViewInventario.Columns(4).Width = 67

        Inicializar()

    End Sub

    Private Sub FormInventario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPrincipal.Show()
    End Sub

    Private Sub ButtonBuscarProduct_Click(sender As Object, e As EventArgs) Handles ButtonBuscarProduct.Click

        Estado = 4

        Me.RadioButtonCD.Visible = True
        Me.RadioButtonNP.Visible = True
        Me.RadioButtonLab.Visible = True
        Me.ButtonAgregProd.Visible = False
        Me.ButtonExportarExcel.Visible = False

    End Sub

    Private Sub ButtonExportarExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportarExcel.Click

        bloquearradiobutton()

        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Exportar_Excel(DataGridViewInventario, save.FileName)
        End If

    End Sub

    Private Sub ButtonAgregProd_Click(sender As Object, e As EventArgs) Handles ButtonAgregProd.Click

        bloquearradiobutton()

        MsgBox("Se recomienda que sólo se modifique el Inventario cuando se carguen los productos a Mercurio por primera vez. Cualquier cambio posterior en el Inventario podrá alterar los resultados de los reportes", MsgBoxStyle.Exclamation)
        Estado = 1
        LimpiarTextbox()
        DesbloquearTextbox()
        Me.TextBoxCodProd.ReadOnly = False 'Permito la edición en el TextBox del Código del Producto (Código de barras)
        CondiBloquearButton()

    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click

        bloquearradiobutton()

        'Valido que ya se haya seleccionado un laboratorio para modificar

        If Me.TextBoxCodProd.Text <> "" And Me.TextBoxNomProd.Text <> "" Then

            MsgBox("Se recomienda que sólo se modifique el Inventario cuando se carguen los productos a Mercurio por primera vez. Cualquier cambio posterior en el Inventario podrá alterar los resultados de los reportes", MsgBoxStyle.Exclamation)
            Estado = 2
            DesbloquearTextbox()
            CondiBloquearButton()

        Else
            MsgBox("Elija un Producto para modificar", MsgBoxStyle.Exclamation)

        End If

    End Sub

    Private Sub ButtonElimProd_Click(sender As Object, e As EventArgs) Handles ButtonElimProd.Click

        bloquearradiobutton()

        'Valido que ya se haya seleccionado un laboratorio para modificar

        If Me.TextBoxCodProd.Text <> "" And Me.TextBoxNomProd.Text <> "" Then

            MsgBox("Se recomienda que sólo se modifique el Inventario cuando se carguen los productos a Mercurio por primera vez. Cualquier cambio posterior en el Inventario podrá alterar los resultados de los reportes", MsgBoxStyle.Exclamation)
            Estado = 3
            Me.ButtonGuardarProd.Text = "Eliminar"
            Me.ButtonGuardarProd.Image = Mercurio.My.Resources.delete
            CondiBloquearButton()

        Else
            MsgBox("Elija un Producto para Eliminar", MsgBoxStyle.Exclamation)

        End If

    End Sub

    Private Sub ButtonAgrLab_Click(sender As Object, e As EventArgs) Handles ButtonAgrLab.Click
        bloquearradiobutton()
        Proveedor = 2
        FormProveedor.Show()
    End Sub

    Private Sub DataGridViewInventario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewInventario.CellDoubleClick

        Dim str As String

        'Verifico que esté en administrador preguntando si se ve el botón editar.

        If Me.ButtonEditar.Visible Then
            'Almaceno en str el valor de la celda Código de la fila seleccionada con el doble clic
            str = Me.DataGridViewInventario.CurrentRow.Cells.Item(0).Value.ToString
            Me.TextBoxCodProd.Text = str
            BuscarProducto(str)
        End If

    End Sub

    Private Sub ButtonGuardarProd_Click(sender As Object, e As EventArgs) Handles ButtonGuardarProd.Click

        Dim ok As Boolean
        Dim val1 As Boolean 'Variables utilizada para validar si se ha ingresado el valor de Stock
        Dim val2 As Boolean 'Variables utilizada para validar si se ha ingresado el valor de Precio
        Dim msj As String 'Mensaje de se agregó o guadó correctamente el producto
        Dim Row() As DataRow
        Dim s As String

        If Estado = 1 Or Estado = 2 Then 'Estoy en Agregar o Editar??

            'Vuelvo a valir Código del Producto y Producto porque este mismo botón me sirve para agregar y modificar producto

            If Me.TextBoxCodProd.Text <> "" And Me.TextBoxNomProd.Text <> "" Then

                EProduct.IDProducto = CDbl(Me.TextBoxCodProd.Text)
                EProduct.NombreProd = Me.TextBoxNomProd.Text
                'Importante esta asignación debido a que no lo necesito en el inventario pero si lo requiere el SQL
                EProduct.DetalleProd = ""

                'Valido que exista un Precio y Stock para evitar los errores de conversión.

                If Me.TextBoxPrecioProd.Text <> "" Then
                    EProduct.Precio = CDec(Me.TextBoxPrecioProd.Text)
                    val1 = True
                Else
                    MsgBox("Debe ingresar un Precio", MsgBoxStyle.Exclamation)
                    val1 = False
                End If
                If Me.TextBoxStock.Text <> "" Then
                    EProduct.Stock = CInt(Me.TextBoxStock.Text)
                    val2 = True
                Else
                    MsgBox("Debe ingresar una cantidad de productos", MsgBoxStyle.Exclamation)
                    val2 = False
                End If

                'Obtengo la Razón Social del Proveedor asociado al producto
                s = Me.ComboBoxLaboratorio.SelectedItem.ToString
                'Busco en la DataTable del Proveedor, que está llena debido a que para llenar el combobox se realiza la búsqueda de las
                'Razones sociales y NIT de los proveedores, con la función SQL Select RazonSocial = 's' y guardo la fila seleccionada
                Row = DTProvee.Select("RazonSocial='" & s & "'")

                EProduct.NIT = CDbl(Row(0).Item(1))
                EProduct.PrecioCompra = 0

                If val1 And val2 Then
                    Try
                        If Estado = 1 Then
                            ok = NProduct.AgregarProducto(EProduct)
                            msj = "Los datos del Producto se agregaron con éxito"
                        ElseIf Estado = 2 Then
                            ok = NProduct.ModificarProducto(EProduct)
                            msj = "Los datos del Producto se modificaron con éxito"
                        End If

                        If ok = True Then

                            MsgBox(msj, MsgBoxStyle.Information)
                            Inicializar()
                            CondiDesbloquearButton()
                            Me.DataGridViewInventario.DataSource = NProduct.LlenarGrid(EProduct) ' Actualizo el DataGridView

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
                End If

            Else
                MsgBox("El Producto debe tener un Código y un Nombre", MsgBoxStyle.Exclamation)
            End If

        ElseIf Estado = 3 Then 'Estoy en Eliminar??????

            EProduct.IDProducto = CDbl(Me.TextBoxCodProd.Text)

            Try
                ok = NProduct.EliminarProducto(EProduct)
                If ok = True Then
                    MsgBox("El Producto ha sido eliminado", MsgBoxStyle.Information)
                    Inicializar()
                    CondiDesbloquearButton()
                    Me.DataGridViewInventario.DataSource = NProduct.LlenarGrid(EProduct) ' Actualizo el DataGridView
                    Me.ButtonGuardarProd.Text = "Guardar"
                    Me.ButtonGuardarProd.Image = Mercurio.My.Resources.save
                Else
                    MsgBox("Error al eliminar el producto", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub ButtonCancelarProd_Click(sender As Object, e As EventArgs) Handles ButtonCancelarProd.Click
        Inicializar()
        CondiDesbloquearButton()
        If Estado = 3 Then
            Me.ButtonGuardarProd.Text = "Guardar"
            Me.ButtonGuardarProd.Image = Mercurio.My.Resources.save
        End If
    End Sub

    Private Sub RadioButtonCD_Click(sender As Object, e As EventArgs) Handles RadioButtonCD.Click
        Me.TextBoxCodProd.ReadOnly = False
        Me.TextBoxNomProd.ReadOnly = True
        Me.ComboBoxLaboratorio.Enabled = False
    End Sub

    Private Sub RadioButtonLab_Click(sender As Object, e As EventArgs) Handles RadioButtonLab.Click
        Me.ComboBoxLaboratorio.Enabled = True
        Me.TextBoxNomProd.ReadOnly = True
        Me.TextBoxCodProd.ReadOnly = True
    End Sub

    Private Sub RadioButtonNP_Click(sender As Object, e As EventArgs) Handles RadioButtonNP.Click
        Me.TextBoxNomProd.ReadOnly = False
        Me.TextBoxCodProd.ReadOnly = True
        Me.ComboBoxLaboratorio.Enabled = False
    End Sub

    Private Sub TextBoxNomProd_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNomProd.TextChanged

        If Estado = 4 Then 'Estoy en buscar??????

            Try

                EProduct.NombreProd = Me.TextBoxNomProd.Text
                Me.DataGridViewInventario.DataSource = NProduct.BuscarProductoNombe(EProduct) ' Actualizo el DataGridView

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If

    End Sub

    Private Sub ComboBoxLaboratorio_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxLaboratorio.SelectedValueChanged

        If Estado = 4 Then 'Estoy en buscar??????

            Try

                Dim s As String
                Dim Row() As DataRow
                'Dim Row() As DataRow
                ''Obtengo la Razón Social del Proveedor asociado al producto
                s = Me.ComboBoxLaboratorio.SelectedItem.ToString
                'Label6.Text = s
                'Busco en la DataTable del Proveedor, que está llena debido a que para llenar el combobox se realiza la búsqueda de las
                'Razones sociales y NIT de los proveedores, con la función SQL Select RazonSocial = 's' y guardo la fila seleccionada
                Row = DTProvee.Select("RazonSocial='" & s & "'")

                EProduct.NIT = CDbl(Row(0).Item(1))

                Me.DataGridViewInventario.DataSource = NProduct.BuscarProductoLaboratorio(EProduct) ' Actualizo el DataGridView

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If

    End Sub

End Class