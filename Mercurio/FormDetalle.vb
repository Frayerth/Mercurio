Imports CapaEntidades
Imports CapaNegocio

Public Class FormDetalle

    Dim Eprod As New EntProducto
    Dim NegProd As New NegProducto
    Dim EProvee As New EntProveedores
    Dim NProvee As New NegProveedores
    Dim ED As New EntDetalle
    Dim ND As New NegDetalle
    'Dim EFac As New EntFactura
    'Dim NFac As New NegFactura
    Dim DTProvee As New DataTable
    Dim DTProd As New DataTable

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

    Public Sub LlenarTextBox(ByVal DT As DataTable) 

        Me.TextBoxProducto.Text = DT.Rows(0)("NombreProd")
        Me.TextBoxStock.Text = DT.Rows(0)("Stock")
        Me.TextBoxVUnitario.Text = Format(DT.Rows(0)("Precio"), "$ #,##0.00")

        EProvee.NIT = CDbl(DT.Rows(0)("NIT"))
        DTProvee = NProvee.BuscarProveedorconNIT(EProvee)

        Me.TextBoxLab.Text = DTProvee.Rows(0)("RazonSocial")

        DTProd = DT

    End Sub

    Private Sub FormDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CUInt(TextBoxStock.Text) <= 0 Then
            Me.ButtonAgreDeta.Enabled = False
            MsgBox("El Producto está agotado", MsgBoxStyle.Information)
            Me.TextBoxCantidad.ReadOnly = True
        Else
            Me.ButtonAgreDeta.Enabled = True
            Me.TextBoxCantidad.ReadOnly = False
        End If

    End Sub

    Private Sub ButtonCancelDeta_Click(sender As Object, e As EventArgs) Handles ButtonCancelDeta.Click
        Me.Close()
    End Sub

    Private Sub ButtonAgreDeta_Click(sender As Object, e As EventArgs) Handles ButtonAgreDeta.Click

        Dim ok As Boolean

        If TextBoxCantidad.Text <> "" Then
            'Stock actual menos la cantidad a vender (Actualización del Stock)
            Dim s As Integer = DTProd.Rows(0)("Stock") - CUInt(TextBoxCantidad.Text)

            If s < 0 Then
                Me.ButtonAgreDeta.Enabled = False
                MsgBox("Productos en Stock insuficientes", MsgBoxStyle.Information)
                Me.TextBoxCantidad.Text = ""
                Me.ButtonAgreDeta.Enabled = True
            Else
                Try
                    Eprod.Stock = s
                    Eprod.IDProducto = DTProd.Rows(0)("IDProducto")
                    'Para no perder los valores que tenía anteriormente
                    Eprod.Precio = DTProd.Rows(0)("Precio")
                    Eprod.PrecioCompra = DTProd.Rows(0)("PrecioCompra")
                    ok = NegProd.ModificarProductoStock(Eprod) 'Actualizo el Stock
                    If ok Then
                        'Agrego un Detalle
                        ED.IDProducto = Eprod.IDProducto
                        ED.Cantidad = CUInt(TextBoxCantidad.Text)
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