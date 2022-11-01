<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.Banner = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmeroDeFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProdcutosVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProductosCompradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.BtnVentas.FlatAppearance.BorderSize = 2
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.Location = New System.Drawing.Point(87, 208)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(123, 57)
        Me.BtnVentas.TabIndex = 0
        Me.BtnVentas.Text = "VENTAS"
        Me.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'BtnCompras
        '
        Me.BtnCompras.BackColor = System.Drawing.Color.Moccasin
        Me.BtnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompras.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.BtnCompras.FlatAppearance.BorderSize = 2
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.Image = CType(resources.GetObject("BtnCompras.Image"), System.Drawing.Image)
        Me.BtnCompras.Location = New System.Drawing.Point(297, 208)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(129, 57)
        Me.BtnCompras.TabIndex = 1
        Me.BtnCompras.Text = "COMPRAS"
        Me.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCompras.UseVisualStyleBackColor = False
        '
        'BtnInventario
        '
        Me.BtnInventario.BackColor = System.Drawing.Color.Moccasin
        Me.BtnInventario.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.BtnInventario.FlatAppearance.BorderSize = 2
        Me.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventario.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.Image = CType(resources.GetObject("BtnInventario.Image"), System.Drawing.Image)
        Me.BtnInventario.Location = New System.Drawing.Point(506, 208)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(134, 57)
        Me.BtnInventario.TabIndex = 2
        Me.BtnInventario.Text = "INVENTARIO"
        Me.BtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInventario.UseVisualStyleBackColor = False
        '
        'Banner
        '
        Me.Banner.ErrorImage = Nothing
        Me.Banner.Image = CType(resources.GetObject("Banner.Image"), System.Drawing.Image)
        Me.Banner.InitialImage = Nothing
        Me.Banner.Location = New System.Drawing.Point(225, 45)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(278, 123)
        Me.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Banner.TabIndex = 3
        Me.Banner.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MistyRose
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(715, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ModificarClientesToolStripMenuItem, Me.NúmeroDeFacturaToolStripMenuItem})
        Me.AdministrarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.ModificarUsuarioToolStripMenuItem, Me.EliminarUsuarioToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Agregar Usuario"
        '
        'ModificarUsuarioToolStripMenuItem
        '
        Me.ModificarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.ModificarUsuarioToolStripMenuItem.Name = "ModificarUsuarioToolStripMenuItem"
        Me.ModificarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ModificarUsuarioToolStripMenuItem.Text = "Modificar Usuario"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.InventarioToolStripMenuItem.Text = "Modificar Inventario"
        '
        'ModificarClientesToolStripMenuItem
        '
        Me.ModificarClientesToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.ModificarClientesToolStripMenuItem.Name = "ModificarClientesToolStripMenuItem"
        Me.ModificarClientesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ModificarClientesToolStripMenuItem.Text = "Modificar Clientes"
        '
        'NúmeroDeFacturaToolStripMenuItem
        '
        Me.NúmeroDeFacturaToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.NúmeroDeFacturaToolStripMenuItem.Name = "NúmeroDeFacturaToolStripMenuItem"
        Me.NúmeroDeFacturaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.NúmeroDeFacturaToolStripMenuItem.Text = "Número de Factura"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeVentasToolStripMenuItem, Me.ReporteDeProdcutosVendidosToolStripMenuItem, Me.ReporteDeComprasToolStripMenuItem, Me.ReporteDeProductosCompradosToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'ReporteDeVentasToolStripMenuItem
        '
        Me.ReporteDeVentasToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem"
        Me.ReporteDeVentasToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.ReporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas"
        '
        'ReporteDeProdcutosVendidosToolStripMenuItem
        '
        Me.ReporteDeProdcutosVendidosToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.ReporteDeProdcutosVendidosToolStripMenuItem.Name = "ReporteDeProdcutosVendidosToolStripMenuItem"
        Me.ReporteDeProdcutosVendidosToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.ReporteDeProdcutosVendidosToolStripMenuItem.Text = "Reporte de Productos Vendidos"
        '
        'ReporteDeComprasToolStripMenuItem
        '
        Me.ReporteDeComprasToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.ReporteDeComprasToolStripMenuItem.Name = "ReporteDeComprasToolStripMenuItem"
        Me.ReporteDeComprasToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.ReporteDeComprasToolStripMenuItem.Text = "Reporte de Compras"
        '
        'ReporteDeProductosCompradosToolStripMenuItem
        '
        Me.ReporteDeProductosCompradosToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.ReporteDeProductosCompradosToolStripMenuItem.Name = "ReporteDeProductosCompradosToolStripMenuItem"
        Me.ReporteDeProductosCompradosToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.ReporteDeProductosCompradosToolStripMenuItem.Text = "Reporte de Productos Comprados"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Mercurio.My.Resources.Resources.W5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(715, 281)
        Me.Controls.Add(Me.Banner)
        Me.Controls.Add(Me.BtnInventario)
        Me.Controls.Add(Me.BtnCompras)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mercurio - QE"
        CType(Me.Banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnCompras As Button
    Friend WithEvents BtnInventario As Button
    Friend WithEvents Banner As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmeroDeFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeProdcutosVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeProductosCompradosToolStripMenuItem As ToolStripMenuItem
End Class
