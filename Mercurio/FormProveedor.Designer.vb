<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProveedor))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxTel = New System.Windows.Forms.TextBox()
        Me.TextBoxDir = New System.Windows.Forms.TextBox()
        Me.TextBoxNIT = New System.Windows.Forms.TextBox()
        Me.TextBoxLab = New System.Windows.Forms.TextBox()
        Me.TextBoxDV = New System.Windows.Forms.TextBox()
        Me.ListViewLaboratorios = New System.Windows.Forms.ListView()
        Me.ButtonAgrProvee = New System.Windows.Forms.Button()
        Me.ButtonCancelProvee = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxNIT = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonModProvee = New System.Windows.Forms.Button()
        Me.ButtonElimProvee = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "TELÉFONO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "DIRECCIÓN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "NIT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "LABORATORIO:"
        '
        'TextBoxTel
        '
        Me.TextBoxTel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTel.Location = New System.Drawing.Point(135, 245)
        Me.TextBoxTel.Name = "TextBoxTel"
        Me.TextBoxTel.Size = New System.Drawing.Size(150, 26)
        Me.TextBoxTel.TabIndex = 28
        Me.TextBoxTel.Text = "0"
        '
        'TextBoxDir
        '
        Me.TextBoxDir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDir.Location = New System.Drawing.Point(135, 195)
        Me.TextBoxDir.Name = "TextBoxDir"
        Me.TextBoxDir.Size = New System.Drawing.Size(150, 26)
        Me.TextBoxDir.TabIndex = 27
        '
        'TextBoxNIT
        '
        Me.TextBoxNIT.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNIT.Location = New System.Drawing.Point(135, 145)
        Me.TextBoxNIT.Name = "TextBoxNIT"
        Me.TextBoxNIT.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxNIT.TabIndex = 25
        '
        'TextBoxLab
        '
        Me.TextBoxLab.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLab.Location = New System.Drawing.Point(135, 65)
        Me.TextBoxLab.Name = "TextBoxLab"
        Me.TextBoxLab.Size = New System.Drawing.Size(150, 26)
        Me.TextBoxLab.TabIndex = 23
        '
        'TextBoxDV
        '
        Me.TextBoxDV.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDV.Location = New System.Drawing.Point(245, 145)
        Me.TextBoxDV.Name = "TextBoxDV"
        Me.TextBoxDV.Size = New System.Drawing.Size(40, 26)
        Me.TextBoxDV.TabIndex = 26
        '
        'ListViewLaboratorios
        '
        Me.ListViewLaboratorios.Location = New System.Drawing.Point(305, 45)
        Me.ListViewLaboratorios.Name = "ListViewLaboratorios"
        Me.ListViewLaboratorios.Size = New System.Drawing.Size(195, 305)
        Me.ListViewLaboratorios.TabIndex = 35
        Me.ListViewLaboratorios.UseCompatibleStateImageBehavior = False
        Me.ListViewLaboratorios.View = System.Windows.Forms.View.Details
        '
        'ButtonAgrProvee
        '
        Me.ButtonAgrProvee.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgrProvee.Image = Global.Mercurio.My.Resources.Resources.Laboratorio
        Me.ButtonAgrProvee.Location = New System.Drawing.Point(25, 300)
        Me.ButtonAgrProvee.Name = "ButtonAgrProvee"
        Me.ButtonAgrProvee.Size = New System.Drawing.Size(110, 50)
        Me.ButtonAgrProvee.TabIndex = 29
        Me.ButtonAgrProvee.Text = "Guardar"
        Me.ButtonAgrProvee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAgrProvee.UseVisualStyleBackColor = True
        '
        'ButtonCancelProvee
        '
        Me.ButtonCancelProvee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonCancelProvee.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelProvee.Image = Global.Mercurio.My.Resources.Resources.cancel
        Me.ButtonCancelProvee.Location = New System.Drawing.Point(160, 300)
        Me.ButtonCancelProvee.Name = "ButtonCancelProvee"
        Me.ButtonCancelProvee.Size = New System.Drawing.Size(110, 50)
        Me.ButtonCancelProvee.TabIndex = 30
        Me.ButtonCancelProvee.Text = "Cancelar"
        Me.ButtonCancelProvee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelProvee.UseVisualStyleBackColor = True
        '
        'CheckBoxNIT
        '
        Me.CheckBoxNIT.AutoSize = True
        Me.CheckBoxNIT.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxNIT.Location = New System.Drawing.Point(135, 115)
        Me.CheckBoxNIT.Name = "CheckBoxNIT"
        Me.CheckBoxNIT.Size = New System.Drawing.Size(78, 24)
        Me.CheckBoxNIT.TabIndex = 24
        Me.CheckBoxNIT.Text = "Con NIT"
        Me.CheckBoxNIT.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Moccasin
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ModificarProveedorToolStripMenuItem, Me.EliminarProveedorToolStripMenuItem})
        Me.ProveedorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar Proveedor"
        '
        'ModificarProveedorToolStripMenuItem
        '
        Me.ModificarProveedorToolStripMenuItem.Name = "ModificarProveedorToolStripMenuItem"
        Me.ModificarProveedorToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ModificarProveedorToolStripMenuItem.Text = "Modificar Proveedor"
        '
        'EliminarProveedorToolStripMenuItem
        '
        Me.EliminarProveedorToolStripMenuItem.Name = "EliminarProveedorToolStripMenuItem"
        Me.EliminarProveedorToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EliminarProveedorToolStripMenuItem.Text = "Eliminar Proveedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(5, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 250)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'ButtonModProvee
        '
        Me.ButtonModProvee.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModProvee.Image = Global.Mercurio.My.Resources.Resources.saveas2
        Me.ButtonModProvee.Location = New System.Drawing.Point(25, 300)
        Me.ButtonModProvee.Name = "ButtonModProvee"
        Me.ButtonModProvee.Size = New System.Drawing.Size(110, 50)
        Me.ButtonModProvee.TabIndex = 38
        Me.ButtonModProvee.Text = "Modificar"
        Me.ButtonModProvee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonModProvee.UseVisualStyleBackColor = True
        '
        'ButtonElimProvee
        '
        Me.ButtonElimProvee.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonElimProvee.Image = Global.Mercurio.My.Resources.Resources.delete
        Me.ButtonElimProvee.Location = New System.Drawing.Point(25, 300)
        Me.ButtonElimProvee.Name = "ButtonElimProvee"
        Me.ButtonElimProvee.Size = New System.Drawing.Size(110, 50)
        Me.ButtonElimProvee.TabIndex = 39
        Me.ButtonElimProvee.Text = "Eliminar"
        Me.ButtonElimProvee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonElimProvee.UseVisualStyleBackColor = True
        '
        'FormProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(515, 370)
        Me.Controls.Add(Me.ButtonElimProvee)
        Me.Controls.Add(Me.ButtonModProvee)
        Me.Controls.Add(Me.CheckBoxNIT)
        Me.Controls.Add(Me.ListViewLaboratorios)
        Me.Controls.Add(Me.ButtonAgrProvee)
        Me.Controls.Add(Me.TextBoxDV)
        Me.Controls.Add(Me.ButtonCancelProvee)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxTel)
        Me.Controls.Add(Me.TextBoxDir)
        Me.Controls.Add(Me.TextBoxNIT)
        Me.Controls.Add(Me.TextBoxLab)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxTel As TextBox
    Friend WithEvents TextBoxDir As TextBox
    Friend WithEvents TextBoxNIT As TextBox
    Friend WithEvents ButtonCancelProvee As Button
    Friend WithEvents TextBoxDV As TextBox
    Friend WithEvents ButtonAgrProvee As Button
    Friend WithEvents ListViewLaboratorios As ListView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents CheckBoxNIT As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxLab As TextBox
    Friend WithEvents ButtonModProvee As Button
    Friend WithEvents ButtonElimProvee As Button
End Class
