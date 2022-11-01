<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarUsuario))
        Me.TextBoxAgrIDUs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAgrUs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxAgrContUs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBuscarUsuario = New System.Windows.Forms.Button()
        Me.TextBoxAgrApeUs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAgrNomUs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxConfiContr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonModificarUsuario = New System.Windows.Forms.Button()
        Me.ButtonEliminarUsuario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCancelarUsuario = New System.Windows.Forms.Button()
        Me.ButtonGuardarUsuario = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxAgrIDUs
        '
        Me.TextBoxAgrIDUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrIDUs.Location = New System.Drawing.Point(125, 10)
        Me.TextBoxAgrIDUs.Name = "TextBoxAgrIDUs"
        Me.TextBoxAgrIDUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrIDUs.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. Documento:"
        '
        'TextBoxAgrUs
        '
        Me.TextBoxAgrUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrUs.Location = New System.Drawing.Point(125, 130)
        Me.TextBoxAgrUs.Name = "TextBoxAgrUs"
        Me.TextBoxAgrUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrUs.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuario:"
        '
        'TextBoxAgrContUs
        '
        Me.TextBoxAgrContUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrContUs.Location = New System.Drawing.Point(125, 170)
        Me.TextBoxAgrContUs.Name = "TextBoxAgrContUs"
        Me.TextBoxAgrContUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrContUs.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contraseña:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonBuscarUsuario)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrApeUs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrNomUs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxConfiContr)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrContUs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrUs)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgrIDUs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 255)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'ButtonBuscarUsuario
        '
        Me.ButtonBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonBuscarUsuario.Location = New System.Drawing.Point(305, 10)
        Me.ButtonBuscarUsuario.Name = "ButtonBuscarUsuario"
        Me.ButtonBuscarUsuario.Size = New System.Drawing.Size(30, 28)
        Me.ButtonBuscarUsuario.TabIndex = 6
        Me.ButtonBuscarUsuario.Text = "..."
        Me.ButtonBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBuscarUsuario.UseVisualStyleBackColor = True
        '
        'TextBoxAgrApeUs
        '
        Me.TextBoxAgrApeUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrApeUs.Location = New System.Drawing.Point(125, 90)
        Me.TextBoxAgrApeUs.Name = "TextBoxAgrApeUs"
        Me.TextBoxAgrApeUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrApeUs.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Apellido:"
        '
        'TextBoxAgrNomUs
        '
        Me.TextBoxAgrNomUs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgrNomUs.Location = New System.Drawing.Point(125, 50)
        Me.TextBoxAgrNomUs.Name = "TextBoxAgrNomUs"
        Me.TextBoxAgrNomUs.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxAgrNomUs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre:"
        '
        'TextBoxConfiContr
        '
        Me.TextBoxConfiContr.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConfiContr.Location = New System.Drawing.Point(125, 210)
        Me.TextBoxConfiContr.Name = "TextBoxConfiContr"
        Me.TextBoxConfiContr.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxConfiContr.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Confirmar "
        '
        'ButtonModificarUsuario
        '
        Me.ButtonModificarUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificarUsuario.Image = Global.Mercurio.My.Resources.Resources.saveas2
        Me.ButtonModificarUsuario.Location = New System.Drawing.Point(365, 170)
        Me.ButtonModificarUsuario.Name = "ButtonModificarUsuario"
        Me.ButtonModificarUsuario.Size = New System.Drawing.Size(110, 45)
        Me.ButtonModificarUsuario.TabIndex = 12
        Me.ButtonModificarUsuario.Text = "Modificar"
        Me.ButtonModificarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonModificarUsuario.UseVisualStyleBackColor = True
        '
        'ButtonEliminarUsuario
        '
        Me.ButtonEliminarUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminarUsuario.Image = Global.Mercurio.My.Resources.Resources.delete
        Me.ButtonEliminarUsuario.Location = New System.Drawing.Point(365, 170)
        Me.ButtonEliminarUsuario.Name = "ButtonEliminarUsuario"
        Me.ButtonEliminarUsuario.Size = New System.Drawing.Size(110, 45)
        Me.ButtonEliminarUsuario.TabIndex = 14
        Me.ButtonEliminarUsuario.Text = "Eliminar"
        Me.ButtonEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonEliminarUsuario.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mercurio.My.Resources.Resources.Usuario
        Me.PictureBox1.Location = New System.Drawing.Point(360, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ButtonCancelarUsuario
        '
        Me.ButtonCancelarUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelarUsuario.Image = Global.Mercurio.My.Resources.Resources.cancel
        Me.ButtonCancelarUsuario.Location = New System.Drawing.Point(365, 220)
        Me.ButtonCancelarUsuario.Name = "ButtonCancelarUsuario"
        Me.ButtonCancelarUsuario.Size = New System.Drawing.Size(110, 45)
        Me.ButtonCancelarUsuario.TabIndex = 15
        Me.ButtonCancelarUsuario.Text = "Cancelar"
        Me.ButtonCancelarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCancelarUsuario.UseVisualStyleBackColor = True
        '
        'ButtonGuardarUsuario
        '
        Me.ButtonGuardarUsuario.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarUsuario.Image = Global.Mercurio.My.Resources.Resources.save
        Me.ButtonGuardarUsuario.Location = New System.Drawing.Point(365, 170)
        Me.ButtonGuardarUsuario.Name = "ButtonGuardarUsuario"
        Me.ButtonGuardarUsuario.Size = New System.Drawing.Size(110, 45)
        Me.ButtonGuardarUsuario.TabIndex = 13
        Me.ButtonGuardarUsuario.Text = "Guardar"
        Me.ButtonGuardarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonGuardarUsuario.UseVisualStyleBackColor = True
        '
        'FormAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(494, 271)
        Me.Controls.Add(Me.ButtonModificarUsuario)
        Me.Controls.Add(Me.ButtonEliminarUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCancelarUsuario)
        Me.Controls.Add(Me.ButtonGuardarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAgregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAgregarUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxAgrIDUs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxAgrUs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxAgrContUs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonGuardarUsuario As Button
    Friend WithEvents ButtonCancelarUsuario As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxConfiContr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAgrApeUs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAgrNomUs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEliminarUsuario As Button
    Friend WithEvents ButtonModificarUsuario As Button
    Friend WithEvents ButtonBuscarUsuario As Button
End Class
