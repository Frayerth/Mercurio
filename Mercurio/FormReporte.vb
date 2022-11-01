Imports CapaEntidades
Imports CapaNegocio

Public Class FormReporte

    Dim NF As New NegFactura
    Dim ND As New NegDetalle
    Dim NFC As New NegFacturaCompra
    Dim NDC As New NegDetalleCompra
    Dim NDP As New NegDetPago
    Dim FechaIni As Date
    Dim FechaFin As Date
    Public TipoReporte As Integer = 0 '1. Reporte de Factura de Ventas 2. Reporte de Productos de Ventas 
    '3. Reporte de Factura de Compras 4. Reporte de Productos de Compra
    Dim str As String

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

            .Range("A1:J1").Merge()
            .Range("A1:J1").Value = str
            .Range("A1:J1").Font.Bold = True
            .Range("A1:J1").Font.Size = 16

            'Texto despues del encabezado.   

            .Range("A2:J2").Merge()
            .Range("A2:J2").Value = titulo
            .Range("A2:J2").Font.Bold = True
            .Range("A2:J2").Font.Size = 10

            'Espacio.

            .Range("A3:J3").Merge()
            .Range("A3:J3").Value = ""
            .Range("A3:J3").Font.Bold = True
            .Range("A3:J3").Font.Size = 10

            'Estilo a titulos de la tabla.

            .Range("A4:J4").Font.Bold = True

            'Establecer tipo de letra al rango determinado.

            .Range("A1:J1000").Font.Name = "Arial"

        End With

        Try
            'exportamos el encabezado de las columnas
            For c As Integer = 0 To DataGridViewReporte.Columns.Count - 1
                xlWS.cells(4, c + 1).value = DataGridViewReporte.Columns(c).HeaderText
            Next

            'exportamos las celdas
            For r As Integer = 0 To DataGridViewReporte.RowCount - 1
                For c As Integer = 0 To DataGridViewReporte.Columns.Count - 1
                    xlWS.cells(r + 5, c + 1).value = DataGridViewReporte.Item(c, r).Value
                Next
            Next

            If TipoReporte = 1 Then

                With xlWS

                    Dim s As String
                    Dim count As Integer = DataGridViewReporte.RowCount + 5
                    s = "A" & count & ":J" & count

                    'Espacio.

                    .Range(s).Merge()
                    .Range(s).Value = ""
                    .Range(s).Font.Bold = True
                    .Range(s).Font.Size = 10

                    'Estilo a titulos de la tabla.

                    count = count + 1
                    s = "A" & count & ":G" & (count + 7)

                    .Range(s).Font.Bold = True

                    .cells(count, 1).Value = "EFECTIVO:"
                    .cells(count + 1, 1).Value = "TARJETA:"
                    .cells(count + 2, 1).Value = "CRÉDITO:"
                    .cells(count, 5).Value = "EXENTO:"
                    .cells(count + 1, 5).Value = "DESCUENTO:"
                    .cells(count + 2, 5).Value = "GRABADO:"
                    .cells(count + 3, 5).Value = "IVA:"
                    .cells(count + 4, 5).Value = "TOTAL:"
                    .cells(count, 3).Value = Me.TextBox3.Text
                    .cells(count + 1, 3).Value = Me.TextBox4.Text
                    .cells(count + 2, 3).Value = Me.TextBox5.Text
                    .cells(count, 7).Value = Me.TextBoxExento.Text
                    .cells(count + 1, 7).Value = Me.TextBoxDescuento.Text
                    .cells(count + 2, 7).Value = Me.TextBoxGrabado.Text
                    .cells(count + 3, 7).Value = Me.TextBoxIVA.Text
                    .cells(count + 4, 7).Value = Me.TextBoxTotal.Text

                End With

            End If

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

    Private Function Suma(ByVal Col As Integer) As String

        Dim total As Double = 0
        Dim iTotal As Integer = Me.DataGridViewReporte.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
        'Definimos la variable i para controlar el ciclo for
        Dim i As Integer
        'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
        For i = 0 To iTotal - 1
            'Double.parse()<---es para convertir a double el valor que se encuentre entre lso parentesis
            'me.datagridview1(4,i).value <----toma todos los valores de la columna 4... 4 es el numero de columna y i es el numero de fila asi toma todos los 
            'valores de esa columna, recuerda que las columnas inician en 0... asi que la 4 enrealidad sera la 5 visualmente
            total = total + Double.Parse(Me.DataGridViewReporte(Col, i).Value)
        Next
        'Mostramos el total en la caja de texto TxtTotal, en este caso la caja de texto tiene definido un formato como se mostrara el resultado, como dinero..
        Return Format(total, "$ #,##0.00")

    End Function

    Private Function SumaDescuento() As String

        Dim total As Double = 0
        Dim iTotal As Integer = Me.DataGridViewReporte.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
        'Definimos la variable i para controlar el ciclo for
        Dim i As Integer
        'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
        For i = 0 To iTotal - 1
            'Double.parse()<---es para convertir a double el valor que se encuentre entre lso parentesis
            'me.datagridview1(4,i).value <----toma todos los valores de la columna 4... 4 es el numero de columna y i es el numero de fila asi toma todos los 
            'valores de esa columna, recuerda que las columnas inician en 0... asi que la 4 enrealidad sera la 5 visualmente
            total = total + Double.Parse(Me.DataGridViewReporte(5, i).Value)
        Next
        'Mostramos el total en la caja de texto TxtTotal, en este caso la caja de texto tiene definido un formato como se mostrara el resultado, como dinero..
        Return Format(total, "$ #,##0.00")

    End Function

    Private Sub VisibleTextbox()

        Me.TextBoxExento.Visible = True
        Me.TextBoxDescuento.Visible = True
        Me.TextBoxGrabado.Visible = True
        Me.TextBoxIVA.Visible = True
        Me.TextBoxTotal.Visible = True
        Me.Label9.Visible = True
        Me.Label3.Visible = True
        Me.Label10.Visible = True
        Me.Label11.Visible = True
        Me.Label12.Visible = True

        If str = "REPORTE DE VENTAS" Then
            Me.TextBox3.Visible = True
            Me.TextBox4.Visible = True
            Me.TextBox5.Visible = True
            Me.Label4.Visible = True
            Me.Label5.Visible = True
            Me.Label6.Visible = True
            Me.TextBox6.Visible = True
            Me.TextBox7.Visible = True
            Me.Label7.Visible = True
            Me.Label8.Visible = True
            Me.ComboBox1.Visible = True
            Me.ComboBox2.Visible = True

        End If

    End Sub

    Private Sub ConfigDataGrid(TP As Integer)

        If TP = 1 Then

            Me.DataGridViewReporte.Columns(0).HeaderText = "NÚMERO DE LA FACTURA"
            Me.DataGridViewReporte.Columns(1).HeaderText = "FECHA"
            Me.DataGridViewReporte.Columns(2).HeaderText = "USUARIO"
            Me.DataGridViewReporte.Columns(3).HeaderText = "PRODUCTO"
            Me.DataGridViewReporte.Columns(4).HeaderText = "PRECIO"
            Me.DataGridViewReporte.Columns(5).HeaderText = "CANTIDAD"
            Me.DataGridViewReporte.Columns(6).HeaderText = "SUBTOTAL"

            Me.DataGridViewReporte.Columns(0).Width = 100
            Me.DataGridViewReporte.Columns(1).Width = 100
            Me.DataGridViewReporte.Columns(2).Width = 100
            Me.DataGridViewReporte.Columns(3).Width = 340
            Me.DataGridViewReporte.Columns(4).Width = 100
            Me.DataGridViewReporte.Columns(5).Width = 100
            Me.DataGridViewReporte.Columns(6).Width = 200

        ElseIf TP = 2 Then

            Me.DataGridViewReporte.Columns(0).HeaderText = "NÚMERO DE LA FACTURA"
            Me.DataGridViewReporte.Columns(1).HeaderText = "FECHA"
            Me.DataGridViewReporte.Columns(2).HeaderText = "ID PRODUCTO"
            Me.DataGridViewReporte.Columns(3).HeaderText = "PRODUCTO"
            Me.DataGridViewReporte.Columns(4).HeaderText = "CANTIDAD"


            Me.DataGridViewReporte.Columns(0).Width = 150
            Me.DataGridViewReporte.Columns(1).Width = 150
            Me.DataGridViewReporte.Columns(2).Width = 200
            Me.DataGridViewReporte.Columns(3).Width = 400
            Me.DataGridViewReporte.Columns(4).Width = 140

        ElseIf TP = 3 Then

            Me.DataGridViewReporte.Columns(0).HeaderText = "NÚMERO DE LA FACTURA"
            Me.DataGridViewReporte.Columns(1).HeaderText = "FECHA"
            Me.DataGridViewReporte.Columns(2).HeaderText = "NIT"
            Me.DataGridViewReporte.Columns(3).HeaderText = "RAZÓN SOCIAL"
            Me.DataGridViewReporte.Columns(4).HeaderText = "DESCUENTO"
            Me.DataGridViewReporte.Columns(5).HeaderText = "GRABADO"
            Me.DataGridViewReporte.Columns(6).HeaderText = "IVA"
            Me.DataGridViewReporte.Columns(7).HeaderText = "TOTAL"

            Me.DataGridViewReporte.Columns(0).Width = 100
            Me.DataGridViewReporte.Columns(1).Width = 100
            Me.DataGridViewReporte.Columns(2).Width = 140
            Me.DataGridViewReporte.Columns(3).Width = 300
            Me.DataGridViewReporte.Columns(4).Width = 100
            Me.DataGridViewReporte.Columns(5).Width = 100
            Me.DataGridViewReporte.Columns(6).Width = 100
            Me.DataGridViewReporte.Columns(7).Width = 100

        ElseIf TP = 4 Then

            Me.DataGridViewReporte.Columns(0).HeaderText = "NÚMERO DE LA FACTURA"
            Me.DataGridViewReporte.Columns(1).HeaderText = "FECHA"
            Me.DataGridViewReporte.Columns(2).HeaderText = "ID PRODUCTO"
            Me.DataGridViewReporte.Columns(3).HeaderText = "PRODUCTO"
            Me.DataGridViewReporte.Columns(4).HeaderText = "CANTIDAD"


            Me.DataGridViewReporte.Columns(0).Width = 150
            Me.DataGridViewReporte.Columns(1).Width = 150
            Me.DataGridViewReporte.Columns(2).Width = 200
            Me.DataGridViewReporte.Columns(3).Width = 400
            Me.DataGridViewReporte.Columns(4).Width = 140

        End If

    End Sub

    Private Sub FormReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If TipoReporte = 1 Then
            str = "REPORTE DE VENTAS"
            Me.Text = "Reporte de Ventas"
            Me.VisibleTextbox()
        ElseIf TipoReporte = 2 Then
            str = "REPORTE DE PRODUCTOS VENDIDOS"
            Me.Text = "Reporte de Productos Vendidos"
        ElseIf TipoReporte = 3 Then
            Me.VisibleTextbox()
            str = "REPORTE DE COMPRAS"
            Me.Text = "Reporte de Compras"
        ElseIf TipoReporte = 4 Then
            str = "REPORTE DE PRODUCTOS COMPRADOS"
            Me.Text = "Reporte de Productos Comprados"
        End If

        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox2.SelectedIndex = 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Exportar_Excel(DataGridViewReporte, save.FileName)
        End If

    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click

        'Para Validar que FechaIni y FechaFin tengan un valor Date correcto
        Dim dateok As Boolean
        Dim DTTemp As New DataTable 'DataTable temporal para verificar sin las consultas vienen con algo o sino no llenar el DataGrid

        If Me.RadioButton2.Checked Then

            Try
                FechaIni = CDate(TextBox1.Text)
                FechaFin = CDate(TextBox2.Text)
                dateok = True

            Catch ex As Exception
                dateok = False
                'Excepción codificada
                If ex.ToString.Contains("en el tipo 'Date'") Then
                    MsgBox("Formato de Fecha incorrecto.", MsgBoxStyle.Exclamation)
                Else
                    MsgBox(ex.Message)
                End If
            End Try

        ElseIf Me.RadioButton1.Checked And TipoReporte = 1 Then

            FechaIni = Date.Now.Date
            FechaFin = Date.Now.Date

            Try
                'Obtengo si es a.m. o p.m.
                Dim meridianocb1 As String = Me.ComboBox1.SelectedItem.ToString
                'OJO, IMPORTANTE, SI NO SELECCIONO NADA EN EL COMBOBOX, SELECTEDITEM.TOSTRING DEVUELVE "ComboBox"
                If meridianocb1 = "ComboBox" Then
                    meridianocb1 = Me.ComboBox1.Items(0).ToString()
                End If

                'Obtengo si es a.m. o p.m.
                Dim meridianocb2 As String = Me.ComboBox1.SelectedItem.ToString
                'OJO, IMPORTANTE, SI NO SELECCIONO NADA EN EL COMBOBOX, SELECTEDITEM.TOSTRING DEVUELVE "ComboBox"
                If meridianocb2 = "ComboBox" Then
                    meridianocb2 = Me.ComboBox2.Items(1).ToString()
                End If

                Dim fechai As String = FechaIni.ToShortDateString & " " & TextBox6.Text & " " & meridianocb1
                FechaIni = CDate(fechai)
                Dim fechaf As String = FechaFin.ToShortDateString & " " & TextBox7.Text & " " & meridianocb2
                FechaFin = CDate(fechaf)

                dateok = True

            Catch ex As Exception
                dateok = False
                'Excepción codificada
                If ex.ToString.Contains("en el tipo 'Date'") Then
                    MsgBox("Formato de Hora incorrecto.", MsgBoxStyle.Exclamation)
                Else
                    MsgBox(ex.Message)
                End If
            End Try

        End If

        'Valido que FechaIni y FechaFin tengan un valor Date correcto
        If dateok = True Then

            If TipoReporte = 1 Then

                Dim DTTempFact As New DataTable
                Dim DT1 As New DataTable

                DTTemp = NF.LlenarGridrReporteFacturasVentas(FechaIni, FechaFin)

                If DTTemp.Rows.Count > 0 Then 'Valido que exitan facturas para mostrar

                    Me.DataGridViewReporte.DataSource = DTTemp
                    'Le paso a las sumas de Exento, Descuento, Grabado, IVA y Total del llamado a SQL
                    DT1 = NF.SumaEDGIT(FechaIni, FechaFin)
                    Me.TextBoxExento.Text = Format(DT1.Rows(0)(0), "$ #,##0.00")
                    Me.TextBoxDescuento.Text = Format(DT1.Rows(0)(1), "$ #,##0.00")
                    Me.TextBoxGrabado.Text = Format(DT1.Rows(0)(2), "$ #,##0.00")
                    Me.TextBoxIVA.Text = Format(DT1.Rows(0)(3), "$ #,##0.00")
                    Me.TextBoxTotal.Text = Format(DT1.Rows(0)(4), "$ #,##0.00")

                    'Calculo la suma de los pagos en efectivo, tarjeta o crédito
                    Dim DT2 As New DataTable
                    DT2 = NDP.SumaFormasPago(FechaIni, FechaFin)
                    Me.TextBox3.Text = Format(DT2.Rows(0)("Column1"), "$ #,##0.00")
                    Me.TextBox4.Text = Format(DT2.Rows(0)("Column2"), "$ #,##0.00")
                    Me.TextBox5.Text = Format(DT2.Rows(0)("Column3"), "$ #,##0.00")
                    ConfigDataGrid(TipoReporte)

                Else
                    MsgBox("Aún no existen facturas de venta", MsgBoxStyle.Information)
                End If

            ElseIf TipoReporte = 2 Then

                DTTemp = ND.LlenarGridrReporteProductosVentas(FechaIni, FechaFin)

                If DTTemp.Rows.Count > 0 Then 'Valido que existan productos vendidos para mostrar
                    Me.DataGridViewReporte.DataSource = DTTemp
                    ConfigDataGrid(TipoReporte)
                Else
                    MsgBox("Aún no existen productos vendidos", MsgBoxStyle.Information)
                End If

            ElseIf TipoReporte = 3 Then

                DTTemp = NFC.LlenarGridrReporteFacturasCompra(FechaIni, FechaFin)

                If DTTemp.Rows.Count > 0 Then 'Valido que existan facturas de compra para mostrar
                    Me.DataGridViewReporte.DataSource = DTTemp
                    'Le paso a la función SUMA el número de la columna a sumar
                    Me.TextBoxExento.Text = "0"
                    Me.TextBoxDescuento.Text = Me.Suma(4)
                    Me.TextBoxGrabado.Text = Me.Suma(5)
                    Me.TextBoxIVA.Text = Me.Suma(6)
                    Me.TextBoxTotal.Text = Me.Suma(7)
                    ConfigDataGrid(TipoReporte)
                Else
                    MsgBox("Aún no existen facturas de compra para mostrar", MsgBoxStyle.Information)
                End If

            ElseIf TipoReporte = 4 Then

                DTTemp = NDC.LlenarGridrReporteProductosCompra(FechaIni, FechaFin)

                If DTTemp.Rows.Count > 0 Then 'Valido que existan facturas de compra para mostrar
                    Me.DataGridViewReporte.DataSource = DTTemp
                    ConfigDataGrid(TipoReporte)
                Else
                    MsgBox("Aún no existen productos comprados para mostrar", MsgBoxStyle.Information)
                End If

            End If

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Me.TextBox6.ReadOnly = False
        Me.TextBox7.ReadOnly = False
        Me.ComboBox1.Enabled = True
        Me.ComboBox2.Enabled = True

        FechaIni = Date.Now.Date
        FechaFin = FechaIni.AddDays(1)

        Me.ButtonBuscar.Enabled = True
        Me.Button1.Enabled = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Me.TextBox1.ReadOnly = False
        Me.TextBox2.ReadOnly = False

        Me.ButtonBuscar.Enabled = True
        Me.Button1.Enabled = True

    End Sub

End Class