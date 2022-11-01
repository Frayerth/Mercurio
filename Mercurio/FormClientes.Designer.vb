<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscarCliente = New System.Windows.Forms.Button()
        Me.TextBoxAgrpeUs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAgrNomUs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEmailCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxAgrDirClient = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAgrTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxAgrIDUs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonModificarCliente = New System.Windows.Forms.Button()
        Me.ButtonEliminarCliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCancelarCliente = New System.Windows.Forms.Button()
        Me.ButtonGuardarCliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrpeUs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrNomUs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmailCliente)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrDirClient)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrTel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrIDUs)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 300)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"C.C.", "C.E.", "T.I.", "PAS.", "NIT."})
        Me.ComboBox1.Location = New System.Drawing.Point(125, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'ButtonBuscarCliente
        '
        Me.ButtonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonBuscarCliente.Location = New System.Drawing.Point(305, 60)
        Me.ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        Me.ButtonBuscarCliente.Size = New System.Drawing.Size(30, 28)
        Me.ButtonBuscarCliente.TabIndex = 3
        Me.ButtonBuscarCliente.Text = "..."
        Me.ButtonBuscarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBuscarCliente.UseVisualStyleBackColor = True
        Me.ButtonBuscarCliente.Visible = False
        '
        'TextBoxAgrpeUs
        '
        Me.TextBoxAgrpeUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrpeUs.Location = New System.Drawing.Point(125, 140)
        Me.TextBoxAgrpeUs.Name = "TextBoxAgrpeUs"
        Me.TextBoxAgrpeUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrpeUs.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Apellido:"
        '
        'TextBoxAgrNomUs
        '
        Me.TextBoxAgrNomUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrNomUs.Location = New System.Drawing.Point(125, 100)
        Me.TextBoxAgrNomUs.Name = "TextBoxAgrNomUs"
        Me.TextBoxAgrNomUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrNomUs.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre:"
        '
        'TextBoxEmailCliente
        '
        Me.TextBoxEmailCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmailCliente.Location = New System.Drawing.Point(125, 260)
        Me.TextBoxEmailCliente.Name = "TextBoxEmailCliente"
        Me.TextBoxEmailCliente.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxEmailCliente.TabIndex = 8
        '
        'TextBoxAgrDirClient
        '
        Me.TextBoxAgrDirClient.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrDirClient.Location = New System.Drawing.Point(125, 220)
        Me.TextBoxAgrDirClient.Name = "TextBoxAgrDirClient"
        Me.TextBoxAgrDirClient.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrDirClient.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "E-mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección:"
        '
        'TextBoxAgrTel
        '
        Me.TextBoxAgrTel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrTel.Location = New System.Drawing.Point(125, 180)
        Me.TextBoxAgrTel.Name = "TextBoxAgrTel"
        Me.TextBoxAgrTel.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrTel.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono:"
        '
        'TextBoxAgrIDUs
        '
        Me.TextBoxAgrIDUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrIDUs.Location = New System.Drawing.Point(125, 60)
        Me.TextBoxAgrIDUs.Name = "TextBoxAgrIDUs"
        Me.TextBoxAgrIDUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrIDUs.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tipo Documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. Documento:"
        '
        'ButtonModificarCliente
        '
        Me.ButtonModificarCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificarCliente.Image = Global.Mercurio.My.Resources.Resources.saveas2
        Me.ButtonModificarCliente.Location = New System.Drawing.Point(370, 180)
        Me.ButtonModificarCliente.Name = "ButtonModificarCliente"
        Me.ButtonModificarCliente.Size = New System.Drawing.Size(110, 45)
        Me.ButtonModificarCliente.TabIndex = 9
        Me.ButtonModificarCliente.Text = "Modificar"
        Me.ButtonModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonModificarCliente.UseVisualStyleBackColor = True
        Me.ButtonModificarCliente.Visible = False
        '
        'ButtonEliminarCliente
        '
        Me.ButtonEliminarCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminarCliente.Image = Global.Mercurio.My.Resources.Resources.delete
        Me.ButtonEliminarCliente.Location = New System.Drawing.Point(370, 180)
        Me.ButtonEliminarCliente.Name = "ButtonEliminarCliente"
        Me.ButtonEliminarCliente.Size = New System.Drawing.Size(110, 45)
        Me.ButtonEliminarCliente.TabIndex = 11
        Me.ButtonEliminarCliente.Text = "Eliminar"
        Me.ButtonEliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonEliminarCliente.UseVisualStyleBackColor = True
        Me.ButtonEliminarCliente.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mercurio.My.Resources.Resources.Clientes
        Me.PictureBox1.Location = New System.Drawing.Point(360, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'ButtonCancelarCliente
        '
        Me.ButtonCancelarCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelarCliente.Image = Global.Mercurio.My.Resources.Resources.cancel
        Me.ButtonCancelarCliente.Location = New System.Drawing.Point(370, 240)
        Me.ButtonCancelarCliente.Name = "ButtonCancelarCliente"
        Me.ButtonCancelarCliente.Size = New System.Drawing.Size(110, 45)
        Me.ButtonCancelarCliente.TabIndex = 12
        Me.ButtonCancelarCliente.Text = "Cancelar"
        Me.ButtonCancelarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelarCliente.UseVisualStyleBackColor = True
        '
        'ButtonGuardarCliente
        '
        Me.ButtonGuardarCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarCliente.Image = Global.Mercurio.My.Resources.Resources.save
        Me.ButtonGuardarCliente.Location = New System.Drawing.Point(370, 180)
        Me.ButtonGuardarCliente.Name = "ButtonGuardarCliente"
        Me.ButtonGuardarCliente.Size = New System.Drawing.Size(110, 45)
        Me.ButtonGuardarCliente.TabIndex = 10
        Me.ButtonGuardarCliente.Text = "Guardar"
        Me.ButtonGuardarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonGuardarCliente.UseVisualStyleBackColor = True
        Me.ButtonGuardarCliente.Visible = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(492, 313)
        Me.Controls.Add(Me.ButtonModificarCliente)
        Me.Controls.Add(Me.ButtonEliminarCliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCancelarCliente)
        Me.Controls.Add(Me.ButtonGuardarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormClientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonModificarCliente As Button
    Friend WithEvents ButtonEliminarCliente As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents TextBoxAgrpeUs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAgrNomUs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEmailCliente As TextBox
    Friend WithEvents TextBoxAgrDirClient As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAgrTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxAgrIDUs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonCancelarCliente As Button
    Friend WithEvents ButtonGuardarCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
End Class
