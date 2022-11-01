Imports CapaEntidades
Imports CapaNegocio

Public Class FormBusProdLab

    'Instancio las Clases Entsuario y NegUsuario, recordar que la Capa de Mercurio referencia a la Capa de 
    'Negocio y a la Caapa de Negocio y la Capa de Negocio referencia a la Capa de Datos

    Dim EProvee As New EntProveedores
    Dim NProvee As New NegProveedores
    Dim NProd As New NegProducto
    Dim EProd As New EntProducto
    Dim DTProd As New DataTable
    Dim DTProvee As New DataTable
    Dim ED As New EntDetalle
    Dim ND As New NegDetalle

    Public Sub solonumeros(ByVal key As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(key.KeyChar) Then
            key.Handled = False
        ElseIf Char.IsControl(key.KeyChar) Then
            key.Handled = False
        Else
            key.Handled = True
        End If
    End Sub

    Private Sub TextBoxCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantidad.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Inicializar()

        LimpiarTextbox()

        Me.ListViewProd.Items.Clear()
        Me.ListViewLab.Items.Clear()
        DTProvee = NProvee.ListadeLaboratorios()

        'Lleno el listview con cada dato de la datatable que es quien posee los datos de resultado de llamar al SQL
        'de la consulta de lista de proveedores llamada a través de la función ListadeLaboratorio de la clase de Negocio

        For Each Row As DataRow In DTProvee.Rows
            Dim Fila As New ListViewItem
            Fila = Me.ListViewLab.Items.Add(Row(0))
        Next

    End Sub

    Private Sub LimpiarTextbox()
        Me.TextBoxProducto.Text = ""
        Me.TextBoxLab.Text = ""
        Me.TextBoxVUnitario.Text = ""
        Me.TextBoxCantidad.Text = ""
        Me.TextBoxStock.Text = ""
    End Sub

    Private Function BuscarProductos(ByRef str As String) As DataTable

        Dim DT As DataTable

        Try

            EProvee.RazonSocial = str
            DT = NProvee.BuscarProveedor(EProvee)
            EProd.NIT = DT(0)("NIT")
            DT = NProd.BuscarProductoLaboratorio(EProd)
            Return DT

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Private Sub FormBusProdLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Inicializar()

        Me.ListViewLab.View = View.Details
        Me.ListViewLab.Columns.Add("Laboratorios:", 190, HorizontalAlignment.Left)

        Me.ListViewProd.View = View.Details
        Me.ListViewProd.Columns.Add("Productos:", 190, HorizontalAlignment.Left)

    End Sub

    Private Sub ButtonCancelDeta_Click(sender As Object, e As EventArgs) Handles ButtonCancelDeta.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim str As String

        If Me.ListViewLab.SelectedItems.ToString <> "" Then
            str = Me.ListViewLab.FocusedItem.Text
            Me.TextBoxLab.Text = str

            DTProd = BuscarProductos(str)
            Me.ListViewProd.Items.Clear()

            'Lleno el listview con cada dato de la datatable que es quien posee los datos de resultado de llamar al SQL
            'de la consulta de lista de proveedores llamada a través de la función ListadeLaboratorio de la clase de Negocio

            For Each Row As DataRow In DTProd.Rows
                Dim Fila As New ListViewItem
                Fila = Me.ListViewProd.Items.Add(Row(1))
            Next

        End If

    End Sub

    Private Sub ListViewLab_DoubleClick(sender As Object, e As EventArgs) Handles ListViewLab.DoubleClick

        Dim str As String

        If Me.ListViewLab.SelectedItems.ToString <> "" Then
            str = Me.ListViewLab.FocusedItem.Text
            LimpiarTextbox()
            Me.TextBoxLab.Text = str

            DTProd = BuscarProductos(str)
            Me.ListViewProd.Items.Clear()

            'Lleno el listview con cada dato de la datatable que es quien posee los datos de resultado de llamar al SQL
            'de la consulta de lista de proveedores llamada a través de la función ListadeLaboratorio de la clase de Negocio

            For Each Row As DataRow In DTProd.Rows
                Dim Fila As New ListViewItem
                Fila = Me.ListViewProd.Items.Add(Row(1))
            Next

        End If

    End Sub

    Private Sub ListViewProd_DoubleClick(sender As Object, e As EventArgs) Handles ListViewProd.DoubleClick

        Dim str As String
        Dim rows As DataRow()
        Dim DT As New DataTable

        If Me.ListViewLab.SelectedItems.ToString <> "" Then

            'Buscamos los datos del producto seleccionado
            str = Me.ListViewProd.FocusedItem.Text
            'DTProd quedó lleno en el ListViewLab DoubleClick con los Productos del Laboratorio seleccionado
            rows = DTProd.Select("NombreProd = '" & str + "'") 'Seleccionamos la fila con el comando select igual que en SQL Server

            Me.TextBoxProducto.Text = rows(0)("NombreProd")
            Me.TextBoxVUnitario.Text = Format(rows(0)("Precio"), "$ #,##0.00")
            Me.TextBoxStock.Text = rows(0)("Stock")

            EProd.IDProducto = rows(0)("IDProducto") 'Para agregar el Detalle

            'Para no perder los valores que tenía anteriormente cuando actualice el Stock
            DT = NProd.BuscarProducto(EProd)
            EProd.Precio = DT(0)("Precio")
            EProd.PrecioCompra = DT(0)("PrecioCompra")

            If CUInt(TextBoxStock.Text) <= 0 Then
                Me.ButtonAgreDeta.Enabled = False
                MsgBox("El Producto está agotado", MsgBoxStyle.Information)
                Me.TextBoxCantidad.ReadOnly = True
            Else
                Me.ButtonAgreDeta.Enabled = True
                Me.TextBoxCantidad.ReadOnly = False
            End If

        End If

    End Sub

    Private Sub ButtonAgreDeta_Click(sender As Object, e As EventArgs) Handles ButtonAgreDeta.Click

        Dim ok As Boolean

        If TextBoxCantidad.Text <> "" Then
            'Stock actual menos la cantidad a vender (Actualización del Stock)
            Dim s As Integer = CUInt(Me.TextBoxStock.Text) - CUInt(Me.TextBoxCantidad.Text)

            If s < 0 Then
                Me.ButtonAgreDeta.Enabled = False
                MsgBox("Productos en Stock insuficientes", MsgBoxStyle.Information)
                Me.TextBoxCantidad.Text = ""
                Me.ButtonAgreDeta.Enabled = True
            Else
                Try
                    EProd.Stock = s
                    ok = NProd.ModificarProductoStock(EProd) 'Actualizo el Stock
                    If ok Then
                        'Agrego un Detalle
                        ED.IDProducto = EProd.IDProducto
                        ED.Cantidad = CUInt(TextBoxCantidad.Text)
                        'En la Consulta SQL Server se toma el número de factura de la última factura + 1
                        ND.AgregarDetalle(ED)
                        ED.NumFactura = My.Forms.FormVentas.NumFactura
                        My.Forms.FormVentas.DataGridViewVenta.DataSource = ND.LlenarGridVentas(ED)
                    End If
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            MsgBox("Debe ingresar una cantidad")
        End If

    End Sub

End Class