<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxIDCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxApellidoCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxTelCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDirCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonBuscarCliente = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridViewVenta = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxEmailCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxCodProd = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonSacarProducto = New System.Windows.Forms.Button()
        Me.ButtonBuscarLab = New System.Windows.Forms.Button()
        Me.ButtonAgregarProducto = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ButtonVender = New System.Windows.Forms.Button()
        Me.ButtonImprimir = New System.Windows.Forms.Button()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE:"
        '
        'TextBoxNombreCliente
        '
        Me.TextBoxNombreCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombreCliente.Location = New System.Drawing.Point(28, 185)
        Me.TextBoxNombreCliente.Name = "TextBoxNombreCliente"
        Me.TextBoxNombreCliente.Size = New System.Drawing.Size(167, 26)
        Me.TextBoxNombreCliente.TabIndex = 7
        '
        'TextBoxIDCliente
        '
        Me.TextBoxIDCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDCliente.Location = New System.Drawing.Point(28, 130)
        Me.TextBoxIDCliente.Name = "TextBoxIDCliente"
        Me.TextBoxIDCliente.Size = New System.Drawing.Size(142, 26)
        Me.TextBoxIDCliente.TabIndex = 1
        '
        'TextBoxApellidoCliente
        '
        Me.TextBoxApellidoCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApellidoCliente.Location = New System.Drawing.Point(25, 245)
        Me.TextBoxApellidoCliente.Name = "TextBoxApellidoCliente"
        Me.TextBoxApellidoCliente.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxApellidoCliente.TabIndex = 8
        '
        'TextBoxTelCliente
        '
        Me.TextBoxTelCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelCliente.Location = New System.Drawing.Point(28, 296)
        Me.TextBoxTelCliente.Name = "TextBoxTelCliente"
        Me.TextBoxTelCliente.Size = New System.Drawing.Size(167, 26)
        Me.TextBoxTelCliente.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DOCUMENTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "APELLIDO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TELÉFONO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DIRECCIÓN:"
        '
        'TextBoxDirCliente
        '
        Me.TextBoxDirCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDirCliente.Location = New System.Drawing.Point(28, 349)
        Me.TextBoxDirCliente.Name = "TextBoxDirCliente"
        Me.TextBoxDirCliente.Size = New System.Drawing.Size(167, 26)
        Me.TextBoxDirCliente.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PRODUCTOS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(10, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CLIENTE:"
        '
        'ButtonBuscarCliente
        '
        Me.ButtonBuscarCliente.Location = New System.Drawing.Point(180, 133)
        Me.ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        Me.ButtonBuscarCliente.Size = New System.Drawing.Size(24, 20)
        Me.ButtonBuscarCliente.TabIndex = 2
        Me.ButtonBuscarCliente.Text = "..."
        Me.ButtonBuscarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBuscarCliente.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"C.C.", "C.E.", "T.I.", "NIT."})
        Me.ComboBox1.Location = New System.Drawing.Point(28, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "TIPO DE DOC:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Pink
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(180, 495)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(150, 32)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Pink
        Me.TextBox2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(345, 495)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(150, 32)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Pink
        Me.TextBox3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(510, 495)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(150, 32)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Pink
        Me.TextBox4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(675, 495)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(150, 32)
        Me.TextBox4.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(180, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "EXENTO:"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(345, 465)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 29)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "GRABADO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(510, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 29)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "IVA 19%:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(675, 465)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 29)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "TOTAL:"
        '
        'DataGridViewVenta
        '
        Me.DataGridViewVenta.AllowUserToAddRows = False
        Me.DataGridViewVenta.AllowUserToDeleteRows = False
        Me.DataGridViewVenta.AllowUserToResizeColumns = False
        Me.DataGridViewVenta.AllowUserToResizeRows = False
        Me.DataGridViewVenta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewVenta.Location = New System.Drawing.Point(15, 75)
        Me.DataGridViewVenta.Name = "DataGridViewVenta"
        Me.DataGridViewVenta.ReadOnly = True
        Me.DataGridViewVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVenta.Size = New System.Drawing.Size(810, 375)
        Me.DataGridViewVenta.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 20)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "EMAIL:"
        '
        'TextBoxEmailCliente
        '
        Me.TextBoxEmailCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmailCliente.Location = New System.Drawing.Point(28, 410)
        Me.TextBoxEmailCliente.Name = "TextBoxEmailCliente"
        Me.TextBoxEmailCliente.Size = New System.Drawing.Size(167, 26)
        Me.TextBoxEmailCliente.TabIndex = 11
        '
        'TextBoxCodProd
        '
        Me.TextBoxCodProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodProd.Location = New System.Drawing.Point(295, 25)
        Me.TextBoxCodProd.Name = "TextBoxCodProd"
        Me.TextBoxCodProd.ReadOnly = True
        Me.TextBoxCodProd.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxCodProd.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(125, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "CÓDIGO DEL PRODUCTO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmailCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxDirCliente)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxApellidoCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(835, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 450)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonSacarProducto)
        Me.GroupBox2.Controls.Add(Me.ButtonBuscarLab)
        Me.GroupBox2.Controls.Add(Me.ButtonAgregarProducto)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBoxCodProd)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(810, 70)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'ButtonSacarProducto
        '
        Me.ButtonSacarProducto.Enabled = False
        Me.ButtonSacarProducto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSacarProducto.Image = Global.Mercurio.My.Resources.Resources.SacarProducto
        Me.ButtonSacarProducto.Location = New System.Drawing.Point(665, 15)
        Me.ButtonSacarProducto.Name = "ButtonSacarProducto"
        Me.ButtonSacarProducto.Size = New System.Drawing.Size(130, 50)
        Me.ButtonSacarProducto.TabIndex = 33
        Me.ButtonSacarProducto.Text = "Sacar Producto"
        Me.ButtonSacarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSacarProducto.UseVisualStyleBackColor = True
        '
        'ButtonBuscarLab
        '
        Me.ButtonBuscarLab.Enabled = False
        Me.ButtonBuscarLab.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscarLab.Image = Global.Mercurio.My.Resources.Resources.Buscar2
        Me.ButtonBuscarLab.Location = New System.Drawing.Point(520, 15)
        Me.ButtonBuscarLab.Name = "ButtonBuscarLab"
        Me.ButtonBuscarLab.Size = New System.Drawing.Size(130, 50)
        Me.ButtonBuscarLab.TabIndex = 32
        Me.ButtonBuscarLab.Text = "Buscar por Laboratorio"
        Me.ButtonBuscarLab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonBuscarLab.UseVisualStyleBackColor = True
        '
        'ButtonAgregarProducto
        '
        Me.ButtonAgregarProducto.Enabled = False
        Me.ButtonAgregarProducto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregarProducto.Image = Global.Mercurio.My.Resources.Resources.Agregar
        Me.ButtonAgregarProducto.Location = New System.Drawing.Point(470, 20)
        Me.ButtonAgregarProducto.Name = "ButtonAgregarProducto"
        Me.ButtonAgregarProducto.Size = New System.Drawing.Size(40, 35)
        Me.ButtonAgregarProducto.TabIndex = 4
        Me.ButtonAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAgregarProducto.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 465)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 29)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "DESCUENTO:"
        Me.Label15.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Pink
        Me.TextBox5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(15, 495)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(150, 32)
        Me.TextBox5.TabIndex = 12
        Me.TextBox5.Visible = False
        '
        'ButtonVender
        '
        Me.ButtonVender.Enabled = False
        Me.ButtonVender.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVender.Image = Global.Mercurio.My.Resources.Resources.Cobrar
        Me.ButtonVender.Location = New System.Drawing.Point(835, 475)
        Me.ButtonVender.Name = "ButtonVender"
        Me.ButtonVender.Size = New System.Drawing.Size(105, 50)
        Me.ButtonVender.TabIndex = 5
        Me.ButtonVender.Text = "Totalizar"
        Me.ButtonVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonVender.UseVisualStyleBackColor = True
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.Enabled = False
        Me.ButtonImprimir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimir.Image = Global.Mercurio.My.Resources.Resources.print
        Me.ButtonImprimir.Location = New System.Drawing.Point(950, 475)
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.Size = New System.Drawing.Size(105, 50)
        Me.ButtonImprimir.TabIndex = 6
        Me.ButtonImprimir.Text = "Facturar"
        Me.ButtonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonImprimir.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1067, 538)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewVenta)
        Me.Controls.Add(Me.ButtonVender)
        Me.Controls.Add(Me.ButtonImprimir)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombreCliente As TextBox
    Friend WithEvents TextBoxIDCliente As TextBox
    Friend WithEvents TextBoxApellidoCliente As TextBox
    Friend WithEvents TextBoxTelCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDirCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonImprimir As Button
    Friend WithEvents ButtonVender As Button
    Friend WithEvents DataGridViewVenta As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxEmailCliente As TextBox
    Friend WithEvents TextBoxCodProd As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonAgregarProducto As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ButtonBuscarLab As Button
    Friend WithEvents ButtonSacarProducto As Button
End Class
