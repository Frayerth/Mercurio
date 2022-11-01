<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusProdLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBusProdLab))
        Me.ListViewProd = New System.Windows.Forms.ListView()
        Me.ListViewLab = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxVUnitario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxLab = New System.Windows.Forms.TextBox()
        Me.ButtonAgreDeta = New System.Windows.Forms.Button()
        Me.ButtonCancelDeta = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewProd
        '
        Me.ListViewProd.Location = New System.Drawing.Point(255, 10)
        Me.ListViewProd.Name = "ListViewProd"
        Me.ListViewProd.Size = New System.Drawing.Size(195, 320)
        Me.ListViewProd.TabIndex = 51
        Me.ListViewProd.UseCompatibleStateImageBehavior = False
        Me.ListViewProd.View = System.Windows.Forms.View.Details
        '
        'ListViewLab
        '
        Me.ListViewLab.Location = New System.Drawing.Point(20, 10)
        Me.ListViewLab.Name = "ListViewLab"
        Me.ListViewLab.Size = New System.Drawing.Size(195, 320)
        Me.ListViewLab.TabIndex = 55
        Me.ListViewLab.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxVUnitario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxStock)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxCantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxProducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxLab)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(460, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 250)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "V. UNITARIO:"
        '
        'TextBoxVUnitario
        '
        Me.TextBoxVUnitario.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVUnitario.Location = New System.Drawing.Point(125, 115)
        Me.TextBoxVUnitario.Name = "TextBoxVUnitario"
        Me.TextBoxVUnitario.ReadOnly = True
        Me.TextBoxVUnitario.Size = New System.Drawing.Size(120, 26)
        Me.TextBoxVUnitario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "STOCK:"
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStock.Location = New System.Drawing.Point(125, 205)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.ReadOnly = True
        Me.TextBoxStock.Size = New System.Drawing.Size(120, 26)
        Me.TextBoxStock.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "CANTIDAD:"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCantidad.Location = New System.Drawing.Point(125, 160)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.ReadOnly = True
        Me.TextBoxCantidad.Size = New System.Drawing.Size(120, 26)
        Me.TextBoxCantidad.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "PRODUCTO:"
        '
        'TextBoxProducto
        '
        Me.TextBoxProducto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProducto.Location = New System.Drawing.Point(125, 25)
        Me.TextBoxProducto.Name = "TextBoxProducto"
        Me.TextBoxProducto.ReadOnly = True
        Me.TextBoxProducto.Size = New System.Drawing.Size(290, 26)
        Me.TextBoxProducto.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "LABORATORIO:"
        '
        'TextBoxLab
        '
        Me.TextBoxLab.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLab.Location = New System.Drawing.Point(125, 70)
        Me.TextBoxLab.Name = "TextBoxLab"
        Me.TextBoxLab.ReadOnly = True
        Me.TextBoxLab.Size = New System.Drawing.Size(290, 26)
        Me.TextBoxLab.TabIndex = 2
        '
        'ButtonAgreDeta
        '
        Me.ButtonAgreDeta.Enabled = False
        Me.ButtonAgreDeta.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgreDeta.Image = Global.Mercurio.My.Resources.Resources.AgregarProducto
        Me.ButtonAgreDeta.Location = New System.Drawing.Point(570, 275)
        Me.ButtonAgreDeta.Name = "ButtonAgreDeta"
        Me.ButtonAgreDeta.Size = New System.Drawing.Size(110, 50)
        Me.ButtonAgreDeta.TabIndex = 58
        Me.ButtonAgreDeta.Text = "Agregar"
        Me.ButtonAgreDeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAgreDeta.UseVisualStyleBackColor = True
        '
        'ButtonCancelDeta
        '
        Me.ButtonCancelDeta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonCancelDeta.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelDeta.Image = Global.Mercurio.My.Resources.Resources.cancel
        Me.ButtonCancelDeta.Location = New System.Drawing.Point(705, 275)
        Me.ButtonCancelDeta.Name = "ButtonCancelDeta"
        Me.ButtonCancelDeta.Size = New System.Drawing.Size(110, 50)
        Me.ButtonCancelDeta.TabIndex = 59
        Me.ButtonCancelDeta.Text = "Cancelar"
        Me.ButtonCancelDeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelDeta.UseVisualStyleBackColor = True
        '
        'FormBusProdLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(896, 339)
        Me.Controls.Add(Me.ButtonAgreDeta)
        Me.Controls.Add(Me.ButtonCancelDeta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListViewLab)
        Me.Controls.Add(Me.ListViewProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBusProdLab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewProd As ListView
    Friend WithEvents ListViewLab As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxVUnitario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxLab As TextBox
    Friend WithEvents ButtonAgreDeta As Button
    Friend WithEvents ButtonCancelDeta As Button
End Class
