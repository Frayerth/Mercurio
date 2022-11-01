Imports CapaEntidades
Imports CapaNegocio

Public Class FormDescuento

    Public EFC As New EntFacturaCompra
    Public NFC As New NegFacturaCompra

    Private Sub solonumeros(ByVal key As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(key.KeyChar) Then
            key.Handled = False
        ElseIf Char.IsControl(key.KeyChar) Then
            key.Handled = False
        Else
            key.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.TextBox1.Text = "" Then
            EFC.Descuento = 0
        Else
            EFC.Descuento = CDec(Me.TextBox1.Text)
        End If

        'Creo la Factura de Compra
        EFC.Exento = 0
        NFC.AgregarFacturaCompra(EFC)

        My.Forms.FormCompras.LimpiarTextbox()
        My.Forms.FormCompras.TextBoxCod.Text = ""
        My.Forms.FormCompras.TextBox1.Text = ""
        My.Forms.FormCompras.BloquearTxtbox()
        'My.Forms.FormCompras.DataGridViewCompra.c
        Me.Close()
        My.Forms.FormCompras.Close()

    End Sub

End Class