Imports CapaEntidades
Imports CapaNegocio

Public Class FormNumFactura
    Dim s As Integer

    Public Sub solonumeros(ByVal key As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Button1.Enabled = True
    End Sub

    Private Sub FormNumFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Busco el valor máximo de número de factura ya registrado
        s = My.Forms.FormVentas.NF.UltimoNumFactura()
        Me.Label1.Text += " " & s

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Actualizo el número de la factura
        If CUInt(Me.TextBox1.Text) > s Then
            s = CUInt(Me.TextBox1.Text)
            My.Forms.FormVentas.EF.NumFactura = s 'Para la Factura
            Me.Close()
        Else
            MsgBox("El número de la Factura que desea agregar no puede ser menor al número de Factura máximo registrado", MsgBoxStyle.Critical)
            Me.TextBox1.Text = ""
        End If

    End Sub

End Class