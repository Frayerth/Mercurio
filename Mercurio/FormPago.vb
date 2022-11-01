Imports CapaEntidades
Imports CapaNegocio

Public Class FormPago

    Dim EDP As New EntDetPago
    Dim NDP As New NegDetPago
    Dim Efec As Decimal
    Dim Tarj As Decimal
    Dim Cred As Decimal

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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        solonumeros(e)
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

        Efec = CDec(TextBox1.Text)
        TextBox1.Text = Format(Efec, "$ #,##0.00")

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave

        Tarj = CDec(TextBox2.Text)
        TextBox2.Text = Format(Tarj, "$ #,##0.00")

    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        Cred = CDec(TextBox3.Text)
        TextBox3.Text = Format(Cred, "$ #,##0.00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton2.Checked = True Then

            EDP.Efectivo = Efec
            EDP.Tarjeta = Tarj
            EDP.Crédito = Cred

        ElseIf RadioButton1.Checked = True Then

            EDP.Efectivo = CDec(My.Forms.FormVentas.TextBox4.Text)
            EDP.Tarjeta = 0
            EDP.Crédito = 0

        End If

        'Compruebo que se pague el Total exactamente

        If EDP.Efectivo + EDP.Tarjeta + EDP.Crédito = CDec(My.Forms.FormVentas.TextBox4.Text) Then

            Try
                EDP.NumFactura = My.Forms.FormVentas.NumFactura
                NDP.AgregarDetPago(EDP)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            My.Forms.FormVentas.ExisteFactura = 2
            Me.Close()

        Else

            MsgBox("La suma de las forma de pagos debe ser igual al total de la factura a cancelar", MsgBoxStyle.Exclamation)

        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Me.TextBox1.ReadOnly = False
        Me.TextBox2.ReadOnly = False
        Me.TextBox3.ReadOnly = False
        Me.Button1.Enabled = True

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Me.TextBox1.ReadOnly = True
        Me.TextBox2.ReadOnly = True
        Me.TextBox3.ReadOnly = True
        Me.Button1.Enabled = True

    End Sub


End Class