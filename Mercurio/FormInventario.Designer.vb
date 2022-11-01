<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInventario))
        Me.DataGridViewInventario = New System.Windows.Forms.DataGridView()
        Me.TextBoxCodProd = New System.Windows.Forms.TextBox()
        Me.TextBoxNomProd = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecioProd = New System.Windows.Forms.TextBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxLaboratorio = New System.Windows.Forms.ComboBox()
        Me.GroupBoxEdProdcut = New System.Windows.Forms.GroupBox()
        Me.RadioButtonLab = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNP = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCD = New System.Windows.Forms.RadioButton()
        Me.ButtonAgrLab = New System.Windows.Forms.Button()
        Me.ButtonCancelarProd = New System.Windows.Forms.Button()
        Me.ButtonGuardarProd = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonAgregProd = New System.Windows.Forms.Button()
        Me.ButtonBuscarProduct = New System.Windows.Forms.Button()
        Me.ButtonExportarExcel = New System.Windows.Forms.Button()
        Me.ButtonElimProd = New System.Windows.Forms.Button()
        CType(Me.DataGridViewInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxEdProdcut.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewInventario
        '
        Me.DataGridViewInventario.AllowUserToAddRows = False
        Me.DataGridViewInventario.AllowUserToDeleteRows = False
        Me.DataGridViewInventario.AllowUserToResizeColumns = False
        Me.DataGridViewInventario.AllowUserToResizeRows = False
        Me.DataGridViewInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInventario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewInventario.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewInventario.Location = New System.Drawing.Point(20, 117)
        Me.DataGridViewInventario.Name = "DataGridViewInventario"
        Me.DataGridViewInventario.ReadOnly = True
        Me.DataGridViewInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInventario.Size = New System.Drawing.Size(890, 431)
        Me.DataGridViewInventario.TabIndex = 20
        '
        'TextBoxCodProd
        '
        Me.TextBoxCodProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodProd.Location = New System.Drawing.Point(5, 55)
        Me.TextBoxCodProd.Name = "TextBoxCodProd"
        Me.TextBoxCodProd.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxCodProd.TabIndex = 4
        '
        'TextBoxNomProd
        '
        Me.TextBoxNomProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomProd.Location = New System.Drawing.Point(215, 55)
        Me.TextBoxNomProd.Name = "TextBoxNomProd"
        Me.TextBoxNomProd.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxNomProd.TabIndex = 5
        '
        'TextBoxPrecioProd
        '
        Me.TextBoxPrecioProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecioProd.Location = New System.Drawing.Point(850, 55)
        Me.TextBoxPrecioProd.Name = "TextBoxPrecioProd"
        Me.TextBoxPrecioProd.Size = New System.Drawing.Size(120, 26)
        Me.TextBoxPrecioProd.TabIndex = 9
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStock.Location = New System.Drawing.Point(700, 55)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(120, 26)
        Me.TextBoxStock.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CÓDIGO DEL PRODUCTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "NOMBRE DEL PRODUCTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(855, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "PRECIO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(705, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "STOCK:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(430, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "LABORATORIO:"
        '
        'ComboBoxLaboratorio
        '
        Me.ComboBoxLaboratorio.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxLaboratorio.FormattingEnabled = True
        Me.ComboBoxLaboratorio.Location = New System.Drawing.Point(425, 55)
        Me.ComboBoxLaboratorio.Name = "ComboBoxLaboratorio"
        Me.ComboBoxLaboratorio.Size = New System.Drawing.Size(175, 28)
        Me.ComboBoxLaboratorio.TabIndex = 6
        '
        'GroupBoxEdProdcut
        '
        Me.GroupBoxEdProdcut.Controls.Add(Me.RadioButtonLab)
        Me.GroupBoxEdProdcut.Controls.Add(Me.RadioButtonNP)
        Me.GroupBoxEdProdcut.Controls.Add(Me.RadioButtonCD)
        Me.GroupBoxEdProdcut.Controls.Add(Me.ButtonAgrLab)
        Me.GroupBoxEdProdcut.Controls.Add(Me.ComboBoxLaboratorio)
        Me.GroupBoxEdProdcut.Controls.Add(Me.Label5)
        Me.GroupBoxEdProdcut.Controls.Add(Me.Label4)
        Me.GroupBoxEdProdcut.Controls.Add(Me.Label3)
        Me.GroupBoxEdProdcut.Controls.Add(Me.Label2)
        Me.GroupBoxEdProdcut.Controls.Add(Me.Label1)
        Me.GroupBoxEdProdcut.Controls.Add(Me.TextBoxStock)
        Me.GroupBoxEdProdcut.Controls.Add(Me.TextBoxPrecioProd)
        Me.GroupBoxEdProdcut.Controls.Add(Me.TextBoxNomProd)
        Me.GroupBoxEdProdcut.Controls.Add(Me.TextBoxCodProd)
        Me.GroupBoxEdProdcut.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxEdProdcut.Location = New System.Drawing.Point(20, 5)
        Me.GroupBoxEdProdcut.Name = "GroupBoxEdProdcut"
        Me.GroupBoxEdProdcut.Size = New System.Drawing.Size(985, 95)
        Me.GroupBoxEdProdcut.TabIndex = 15
        Me.GroupBoxEdProdcut.TabStop = False
        Me.GroupBoxEdProdcut.Text = "Editar Producto"
        '
        'RadioButtonLab
        '
        Me.RadioButtonLab.AutoSize = True
        Me.RadioButtonLab.Location = New System.Drawing.Point(420, 30)
        Me.RadioButtonLab.Name = "RadioButtonLab"
        Me.RadioButtonLab.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonLab.TabIndex = 37
        Me.RadioButtonLab.TabStop = True
        Me.RadioButtonLab.UseVisualStyleBackColor = True
        '
        'RadioButtonNP
        '
        Me.RadioButtonNP.AutoSize = True
        Me.RadioButtonNP.Location = New System.Drawing.Point(215, 30)
        Me.RadioButtonNP.Name = "RadioButtonNP"
        Me.RadioButtonNP.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonNP.TabIndex = 36
        Me.RadioButtonNP.TabStop = True
        Me.RadioButtonNP.UseVisualStyleBackColor = True
        '
        'RadioButtonCD
        '
        Me.RadioButtonCD.AutoSize = True
        Me.RadioButtonCD.Location = New System.Drawing.Point(10, 30)
        Me.RadioButtonCD.Name = "RadioButtonCD"
        Me.RadioButtonCD.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonCD.TabIndex = 35
        Me.RadioButtonCD.TabStop = True
        Me.RadioButtonCD.UseVisualStyleBackColor = True
        '
        'ButtonAgrLab
        '
        Me.ButtonAgrLab.Image = CType(resources.GetObject("ButtonAgrLab.Image"), System.Drawing.Image)
        Me.ButtonAgrLab.Location = New System.Drawing.Point(615, 45)
        Me.ButtonAgrLab.Name = "ButtonAgrLab"
        Me.ButtonAgrLab.Size = New System.Drawing.Size(50, 40)
        Me.ButtonAgrLab.TabIndex = 7
        Me.ButtonAgrLab.UseVisualStyleBackColor = True
        '
        'ButtonCancelarProd
        '
        Me.ButtonCancelarProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelarProd.Image = CType(resources.GetObject("ButtonCancelarProd.Image"), System.Drawing.Image)
        Me.ButtonCancelarProd.Location = New System.Drawing.Point(925, 385)
        Me.ButtonCancelarProd.Name = "ButtonCancelarProd"
        Me.ButtonCancelarProd.Size = New System.Drawing.Size(115, 75)
        Me.ButtonCancelarProd.TabIndex = 23
        Me.ButtonCancelarProd.Text = "Cancelar"
        Me.ButtonCancelarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelarProd.UseVisualStyleBackColor = True
        '
        'ButtonGuardarProd
        '
        Me.ButtonGuardarProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarProd.Image = CType(resources.GetObject("ButtonGuardarProd.Image"), System.Drawing.Image)
        Me.ButtonGuardarProd.Location = New System.Drawing.Point(925, 295)
        Me.ButtonGuardarProd.Name = "ButtonGuardarProd"
        Me.ButtonGuardarProd.Size = New System.Drawing.Size(115, 70)
        Me.ButtonGuardarProd.TabIndex = 22
        Me.ButtonGuardarProd.Text = "Guardar"
        Me.ButtonGuardarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonGuardarProd.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditar.Image = CType(resources.GetObject("ButtonEditar.Image"), System.Drawing.Image)
        Me.ButtonEditar.Location = New System.Drawing.Point(925, 385)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(115, 70)
        Me.ButtonEditar.TabIndex = 13
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonAgregProd
        '
        Me.ButtonAgregProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregProd.Image = CType(resources.GetObject("ButtonAgregProd.Image"), System.Drawing.Image)
        Me.ButtonAgregProd.Location = New System.Drawing.Point(925, 295)
        Me.ButtonAgregProd.Name = "ButtonAgregProd"
        Me.ButtonAgregProd.Size = New System.Drawing.Size(115, 70)
        Me.ButtonAgregProd.TabIndex = 12
        Me.ButtonAgregProd.Text = " Agregar"
        Me.ButtonAgregProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAgregProd.UseVisualStyleBackColor = True
        '
        'ButtonBuscarProduct
        '
        Me.ButtonBuscarProduct.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscarProduct.Image = CType(resources.GetObject("ButtonBuscarProduct.Image"), System.Drawing.Image)
        Me.ButtonBuscarProduct.Location = New System.Drawing.Point(925, 115)
        Me.ButtonBuscarProduct.Name = "ButtonBuscarProduct"
        Me.ButtonBuscarProduct.Size = New System.Drawing.Size(115, 70)
        Me.ButtonBuscarProduct.TabIndex = 10
        Me.ButtonBuscarProduct.Text = " Buscar"
        Me.ButtonBuscarProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonBuscarProduct.UseVisualStyleBackColor = True
        '
        'ButtonExportarExcel
        '
        Me.ButtonExportarExcel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportarExcel.Image = CType(resources.GetObject("ButtonExportarExcel.Image"), System.Drawing.Image)
        Me.ButtonExportarExcel.Location = New System.Drawing.Point(925, 205)
        Me.ButtonExportarExcel.Name = "ButtonExportarExcel"
        Me.ButtonExportarExcel.Size = New System.Drawing.Size(115, 70)
        Me.ButtonExportarExcel.TabIndex = 11
        Me.ButtonExportarExcel.Text = "Exportar a Excel"
        Me.ButtonExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExportarExcel.UseVisualStyleBackColor = True
        '
        'ButtonElimProd
        '
        Me.ButtonElimProd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonElimProd.Image = CType(resources.GetObject("ButtonElimProd.Image"), System.Drawing.Image)
        Me.ButtonElimProd.Location = New System.Drawing.Point(925, 475)
        Me.ButtonElimProd.Name = "ButtonElimProd"
        Me.ButtonElimProd.Size = New System.Drawing.Size(115, 70)
        Me.ButtonElimProd.TabIndex = 14
        Me.ButtonElimProd.Text = " Eliminar"
        Me.ButtonElimProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonElimProd.UseVisualStyleBackColor = True
        '
        'FormInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1053, 557)
        Me.Controls.Add(Me.ButtonCancelarProd)
        Me.Controls.Add(Me.ButtonGuardarProd)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonAgregProd)
        Me.Controls.Add(Me.ButtonBuscarProduct)
        Me.Controls.Add(Me.ButtonExportarExcel)
        Me.Controls.Add(Me.ButtonElimProd)
        Me.Controls.Add(Me.DataGridViewInventario)
        Me.Controls.Add(Me.GroupBoxEdProdcut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DataGridViewInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxEdProdcut.ResumeLayout(False)
        Me.GroupBoxEdProdcut.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewInventario As DataGridView
    Friend WithEvents ButtonElimProd As Button
    Friend WithEvents TextBoxCodProd As TextBox
    Friend WithEvents TextBoxNomProd As TextBox
    Friend WithEvents TextBoxPrecioProd As TextBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxLaboratorio As ComboBox
    Friend WithEvents ButtonExportarExcel As Button
    Friend WithEvents ButtonAgrLab As Button
    Friend WithEvents ButtonBuscarProduct As Button
    Friend WithEvents GroupBoxEdProdcut As GroupBox
    Friend WithEvents ButtonAgregProd As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonGuardarProd As Button
    Friend WithEvents ButtonCancelarProd As Button
    Friend WithEvents RadioButtonNP As RadioButton
    Friend WithEvents RadioButtonCD As RadioButton
    Friend WithEvents RadioButtonLab As RadioButton
End Class
