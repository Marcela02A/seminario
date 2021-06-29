<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.campo_nombre = New System.Windows.Forms.TextBox()
        Me.campo_apellido = New System.Windows.Forms.TextBox()
        Me.campo_correo = New System.Windows.Forms.TextBox()
        Me.campo_ccontraseña = New System.Windows.Forms.TextBox()
        Me.campo_documento = New System.Windows.Forms.TextBox()
        Me.campo_ccorreo = New System.Windows.Forms.TextBox()
        Me.campo_contraseña = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.combobox_rol = New System.Windows.Forms.ComboBox()
        Me.combobox_ciudad = New System.Windows.Forms.ComboBox()
        Me.campo_direccion = New System.Windows.Forms.TextBox()
        Me.combobox_documento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.check_terminos = New System.Windows.Forms.CheckBox()
        Me.check_info = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'campo_nombre
        '
        Me.campo_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.campo_nombre.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_nombre.Location = New System.Drawing.Point(242, 157)
        Me.campo_nombre.Name = "campo_nombre"
        Me.campo_nombre.Size = New System.Drawing.Size(232, 22)
        Me.campo_nombre.TabIndex = 2
        '
        'campo_apellido
        '
        Me.campo_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.campo_apellido.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_apellido.Location = New System.Drawing.Point(242, 216)
        Me.campo_apellido.Name = "campo_apellido"
        Me.campo_apellido.Size = New System.Drawing.Size(232, 22)
        Me.campo_apellido.TabIndex = 3
        '
        'campo_correo
        '
        Me.campo_correo.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_correo.Location = New System.Drawing.Point(242, 271)
        Me.campo_correo.Name = "campo_correo"
        Me.campo_correo.Size = New System.Drawing.Size(232, 22)
        Me.campo_correo.TabIndex = 4
        '
        'campo_ccontraseña
        '
        Me.campo_ccontraseña.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_ccontraseña.Location = New System.Drawing.Point(242, 446)
        Me.campo_ccontraseña.Name = "campo_ccontraseña"
        Me.campo_ccontraseña.Size = New System.Drawing.Size(232, 22)
        Me.campo_ccontraseña.TabIndex = 5
        '
        'campo_documento
        '
        Me.campo_documento.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_documento.Location = New System.Drawing.Point(686, 216)
        Me.campo_documento.Name = "campo_documento"
        Me.campo_documento.Size = New System.Drawing.Size(232, 22)
        Me.campo_documento.TabIndex = 6
        '
        'campo_ccorreo
        '
        Me.campo_ccorreo.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_ccorreo.Location = New System.Drawing.Point(686, 271)
        Me.campo_ccorreo.Name = "campo_ccorreo"
        Me.campo_ccorreo.Size = New System.Drawing.Size(232, 22)
        Me.campo_ccorreo.TabIndex = 7
        '
        'campo_contraseña
        '
        Me.campo_contraseña.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_contraseña.Location = New System.Drawing.Point(242, 386)
        Me.campo_contraseña.Name = "campo_contraseña"
        Me.campo_contraseña.Size = New System.Drawing.Size(232, 22)
        Me.campo_contraseña.TabIndex = 9
        Me.campo_contraseña.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(910, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 39)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Registrame"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'combobox_rol
        '
        Me.combobox_rol.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_rol.FormattingEnabled = True
        Me.combobox_rol.Items.AddRange(New Object() {"Cliente", "Proveedor", "Trabajador", "Diseñador"})
        Me.combobox_rol.Location = New System.Drawing.Point(242, 328)
        Me.combobox_rol.Name = "combobox_rol"
        Me.combobox_rol.Size = New System.Drawing.Size(232, 24)
        Me.combobox_rol.TabIndex = 11
        '
        'combobox_ciudad
        '
        Me.combobox_ciudad.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_ciudad.FormattingEnabled = True
        Me.combobox_ciudad.Items.AddRange(New Object() {"Bogota", "Cali", "Medellin"})
        Me.combobox_ciudad.Location = New System.Drawing.Point(686, 328)
        Me.combobox_ciudad.Name = "combobox_ciudad"
        Me.combobox_ciudad.Size = New System.Drawing.Size(232, 24)
        Me.combobox_ciudad.TabIndex = 13
        '
        'campo_direccion
        '
        Me.campo_direccion.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campo_direccion.Location = New System.Drawing.Point(686, 386)
        Me.campo_direccion.Name = "campo_direccion"
        Me.campo_direccion.Size = New System.Drawing.Size(232, 22)
        Me.campo_direccion.TabIndex = 14
        '
        'combobox_documento
        '
        Me.combobox_documento.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_documento.FormattingEnabled = True
        Me.combobox_documento.Items.AddRange(New Object() {"CC", "NIT"})
        Me.combobox_documento.Location = New System.Drawing.Point(686, 157)
        Me.combobox_documento.Name = "combobox_documento"
        Me.combobox_documento.Size = New System.Drawing.Size(232, 24)
        Me.combobox_documento.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Correo electronico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Rol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(238, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(238, 418)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Confirmacion de contraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(682, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 21)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tipo de documento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(682, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Numero de documento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(682, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 21)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Confirmacion de correo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(682, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 21)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(682, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 21)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Dirección"
        '
        'check_terminos
        '
        Me.check_terminos.AutoSize = True
        Me.check_terminos.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.check_terminos.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_terminos.Location = New System.Drawing.Point(686, 419)
        Me.check_terminos.Name = "check_terminos"
        Me.check_terminos.Size = New System.Drawing.Size(213, 22)
        Me.check_terminos.TabIndex = 27
        Me.check_terminos.Text = " Acepto terminos y condiciones"
        Me.check_terminos.UseVisualStyleBackColor = True
        '
        'check_info
        '
        Me.check_info.AutoSize = True
        Me.check_info.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_info.Location = New System.Drawing.Point(686, 446)
        Me.check_info.Name = "check_info"
        Me.check_info.Size = New System.Drawing.Size(211, 22)
        Me.check_info.TabIndex = 28
        Me.check_info.Text = "Recibir información por correo"
        Me.check_info.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(514, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 37)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Registro"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.check_info)
        Me.Controls.Add(Me.check_terminos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combobox_documento)
        Me.Controls.Add(Me.campo_direccion)
        Me.Controls.Add(Me.combobox_ciudad)
        Me.Controls.Add(Me.combobox_rol)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.campo_contraseña)
        Me.Controls.Add(Me.campo_ccorreo)
        Me.Controls.Add(Me.campo_documento)
        Me.Controls.Add(Me.campo_ccontraseña)
        Me.Controls.Add(Me.campo_correo)
        Me.Controls.Add(Me.campo_apellido)
        Me.Controls.Add(Me.campo_nombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents campo_nombre As TextBox
    Friend WithEvents campo_apellido As TextBox
    Friend WithEvents campo_correo As TextBox
    Friend WithEvents campo_ccontraseña As TextBox
    Friend WithEvents campo_documento As TextBox
    Friend WithEvents campo_ccorreo As TextBox
    Friend WithEvents campo_contraseña As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents combobox_rol As ComboBox
    Friend WithEvents combobox_ciudad As ComboBox
    Friend WithEvents campo_direccion As TextBox
    Friend WithEvents combobox_documento As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents check_terminos As CheckBox
    Friend WithEvents check_info As CheckBox
    Friend WithEvents Label12 As Label
End Class
