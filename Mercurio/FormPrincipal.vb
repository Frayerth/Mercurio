Imports CapaEntidades
Imports CapaNegocio

Public Class FormPrincipal

    Public EF As New EntFactura

    Public Sub Desbloqueotextbox()
        My.Forms.FormAgregarUsuario.TextBoxAgrNomUs.Enabled = True
        My.Forms.FormAgregarUsuario.TextBoxAgrApeUs.Enabled = True
        My.Forms.FormAgregarUsuario.TextBoxAgrUs.Enabled = True
        My.Forms.FormAgregarUsuario.TextBoxAgrContUs.Enabled = True
        My.Forms.FormAgregarUsuario.TextBoxConfiContr.Enabled = True
    End Sub

    Public Sub Bloqueotextbox()
        My.Forms.FormAgregarUsuario.TextBoxAgrNomUs.Enabled = False
        My.Forms.FormAgregarUsuario.TextBoxAgrApeUs.Enabled = False
        My.Forms.FormAgregarUsuario.TextBoxAgrUs.Enabled = False
        My.Forms.FormAgregarUsuario.TextBoxAgrContUs.Enabled = False
        My.Forms.FormAgregarUsuario.TextBoxConfiContr.Enabled = False
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        FormVentas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles BtnCompras.Click
        FormCompras.Show()
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click

        'Variable para indicar el tamaño del GropuBox
        Dim tamano As Size
        tamano.Width = 615
        tamano.Height = 95

        Me.Hide()
        FormInventario.Show()

        'Configuración de qué botones, textbox, checkbox y label se mostrarán en este nivel de acceso
        My.Forms.FormInventario.GroupBoxEdProdcut.Text = "Buscar Producto"
        My.Forms.FormInventario.GroupBoxEdProdcut.Size = tamano
        My.Forms.FormInventario.ButtonEditar.Visible = False
        My.Forms.FormInventario.ButtonAgregProd.Visible = False
        My.Forms.FormInventario.ButtonElimProd.Visible = False
        My.Forms.FormInventario.ButtonAgrLab.Visible = False
        My.Forms.FormInventario.TextBoxStock.Visible = False
        My.Forms.FormInventario.Label4.Visible = False
        My.Forms.FormInventario.TextBoxPrecioProd.Visible = False
        My.Forms.FormInventario.Label3.Visible = False
        My.Forms.FormInventario.RadioButtonCD.Visible = False
        My.Forms.FormInventario.RadioButtonNP.Visible = False
        My.Forms.FormInventario.RadioButtonLab.Visible = False

    End Sub

    Private Sub FormPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        My.Forms.FormLogin.TextBoxUsuario.Text = ""
        My.Forms.FormLogin.TextBoxContrasena.Text = ""
        FormLogin.Show()

    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Visible = False
        My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Visible = False
        My.Forms.FormAgregarUsuario.ButtonGuardarUsuario.Visible = True
        My.Forms.FormAgregarUsuario.ButtonBuscarUsuario.Visible = False
        Desbloqueotextbox()
        FormAgregarUsuario.Show()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Visible = False
        My.Forms.FormAgregarUsuario.ButtonGuardarUsuario.Visible = False
        My.Forms.FormAgregarUsuario.ButtonBuscarUsuario.Visible = True
        My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Visible = True
        My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Enabled = False
        Bloqueotextbox()
        FormAgregarUsuario.Show()
    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Visible = True
        My.Forms.FormAgregarUsuario.ButtonEliminarUsuario.Enabled = False
        My.Forms.FormAgregarUsuario.ButtonModificarUsuario.Visible = False
        My.Forms.FormAgregarUsuario.ButtonGuardarUsuario.Visible = False
        My.Forms.FormAgregarUsuario.ButtonBuscarUsuario.Visible = True
        Bloqueotextbox()
        FormAgregarUsuario.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FormAcercade.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        FormInventario.Show()
        My.Forms.FormInventario.ButtonEditar.Visible = True
        My.Forms.FormInventario.ButtonAgregProd.Visible = True
        My.Forms.FormInventario.ButtonElimProd.Visible = True
        My.Forms.FormInventario.RadioButtonCD.Visible = False
        My.Forms.FormInventario.RadioButtonNP.Visible = False
        My.Forms.FormInventario.RadioButtonLab.Visible = False
    End Sub

    Private Sub ModificarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClientesToolStripMenuItem.Click
        My.Forms.FormClientes.ButtonBuscarCliente.Visible = True
        My.Forms.FormClientes.Bloqueotextbox()
        FormClientes.Show()
    End Sub

    Private Sub NúmeroDeFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmeroDeFacturaToolStripMenuItem.Click
        My.Forms.FormNumFactura.Show()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Forms.FormVentas.EF.NumFactura = 0 'Para la factura
    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        My.Forms.FormReporte.TipoReporte = 1
        My.Forms.FormReporte.Show()
    End Sub

    Private Sub ReporteDeProdcutosVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProdcutosVendidosToolStripMenuItem.Click
        My.Forms.FormReporte.TipoReporte = 2
        My.Forms.FormReporte.Show()
    End Sub

    Private Sub ReporteDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeComprasToolStripMenuItem.Click
        My.Forms.FormReporte.TipoReporte = 3
        My.Forms.FormReporte.Show()
    End Sub

    Private Sub ReporteDeProductosCompradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProductosCompradosToolStripMenuItem.Click
        My.Forms.FormReporte.TipoReporte = 4
        My.Forms.FormReporte.Show()
    End Sub

End Class
