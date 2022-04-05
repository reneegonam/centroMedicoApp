<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedico
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
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Black
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(899, 43)
        Me.pnlTitulo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(301, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "REGISTRO DE MÉDICO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(163, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Introduzca la información y presione enter para buscar si existe"
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(601, 193)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(200, 26)
        Me.DtpFechaNacimiento.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(460, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Fecha Nacimiento:"
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(165, 191)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(271, 28)
        Me.cmbSexo.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Sexo:"
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(165, 148)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(708, 26)
        Me.txtApellidos.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Apellidos:"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(165, 106)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(708, 26)
        Me.txtNombres.TabIndex = 26
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.White
        Me.lblNombres.Location = New System.Drawing.Point(13, 109)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(77, 20)
        Me.lblNombres.TabIndex = 25
        Me.lblNombres.Text = "Nombres:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.Location = New System.Drawing.Point(165, 58)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(271, 26)
        Me.txtIdentificacion.TabIndex = 24
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacion.ForeColor = System.Drawing.Color.White
        Me.lblIdentificacion.Location = New System.Drawing.Point(13, 59)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(145, 20)
        Me.lblIdentificacion.TabIndex = 23
        Me.lblIdentificacion.Text = "N° de Identificación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1010, 117)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dirección de Residencia"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(706, 26)
        Me.TextBox1.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(14, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Dirección Exacta:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(537, 34)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(327, 28)
        Me.ComboBox2.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(470, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Pueblo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(156, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 28)
        Me.ComboBox1.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Estado:"
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidad.ForeColor = System.Drawing.Color.White
        Me.lblEspecialidad.Location = New System.Drawing.Point(14, 408)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(103, 20)
        Me.lblEspecialidad.TabIndex = 37
        Me.lblEspecialidad.Text = "Especialidad:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(166, 360)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(278, 26)
        Me.txtTelefono.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Teléfono 1:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(483, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Teléfono 2:"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(595, 360)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(278, 26)
        Me.txtCelular.TabIndex = 36
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(165, 405)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(436, 28)
        Me.cmbEspecialidad.TabIndex = 38
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(596, 452)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(221, 55)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(106, 452)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(221, 55)
        Me.btnGuardar.TabIndex = 39
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 517)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbEspecialidad)
        Me.Controls.Add(Me.lblEspecialidad)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpFechaNacimiento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "frmMedico"
        Me.Text = "frmMedico"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DtpFechaNacimiento As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
