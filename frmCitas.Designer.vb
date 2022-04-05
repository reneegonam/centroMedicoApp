<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCitas
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
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMédico = New System.Windows.Forms.ComboBox()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.txtMotivoConsulta = New System.Windows.Forms.TextBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.DtpFechaCita = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpHoraCita = New System.Windows.Forms.DateTimePicker()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.DarkCyan
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(899, 43)
        Me.pnlTitulo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(266, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "REGISTRO DE CITAS MÉDICAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(163, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Introduzca la información y presione enter para buscar si existe"
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(165, 147)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(708, 26)
        Me.txtApellidos.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Apellidos:"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(165, 105)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(708, 26)
        Me.txtNombres.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Nombres:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.Location = New System.Drawing.Point(165, 57)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(271, 26)
        Me.txtIdentificacion.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "N° de Identificación"
        '
        'cmbMédico
        '
        Me.cmbMédico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMédico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMédico.FormattingEnabled = True
        Me.cmbMédico.Location = New System.Drawing.Point(164, 247)
        Me.cmbMédico.Name = "cmbMédico"
        Me.cmbMédico.Size = New System.Drawing.Size(709, 28)
        Me.cmbMédico.TabIndex = 42
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedico.Location = New System.Drawing.Point(14, 249)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(97, 20)
        Me.lblMedico.TabIndex = 41
        Me.lblMedico.Text = "Elija Médico:"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(165, 203)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(709, 28)
        Me.cmbEspecialidad.TabIndex = 44
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidad.Location = New System.Drawing.Point(15, 205)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(136, 20)
        Me.lblEspecialidad.TabIndex = 43
        Me.lblEspecialidad.Text = "Elija Especialidad:"
        '
        'txtMotivoConsulta
        '
        Me.txtMotivoConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoConsulta.Location = New System.Drawing.Point(165, 295)
        Me.txtMotivoConsulta.Name = "txtMotivoConsulta"
        Me.txtMotivoConsulta.Size = New System.Drawing.Size(708, 26)
        Me.txtMotivoConsulta.TabIndex = 46
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Location = New System.Drawing.Point(13, 298)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(122, 20)
        Me.lblMotivo.TabIndex = 45
        Me.lblMotivo.Text = "Motivo Consulta"
        '
        'DtpFechaCita
        '
        Me.DtpFechaCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCita.Location = New System.Drawing.Point(167, 345)
        Me.DtpFechaCita.Name = "DtpFechaCita"
        Me.DtpFechaCita.Size = New System.Drawing.Size(200, 26)
        Me.DtpFechaCita.TabIndex = 48
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(15, 351)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(91, 20)
        Me.lblFecha.TabIndex = 47
        Me.lblFecha.Text = "Elija Fecha:"
        '
        'dtpHoraCita
        '
        Me.dtpHoraCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraCita.Location = New System.Drawing.Point(614, 345)
        Me.dtpHoraCita.Name = "dtpHoraCita"
        Me.dtpHoraCita.Size = New System.Drawing.Size(200, 26)
        Me.dtpHoraCita.TabIndex = 50
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(462, 351)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(81, 20)
        Me.lblHora.TabIndex = 49
        Me.lblHora.Text = "Elija Hora:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DimGray
        Me.btnCancelar.Location = New System.Drawing.Point(584, 399)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(221, 55)
        Me.btnCancelar.TabIndex = 52
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(94, 399)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(221, 55)
        Me.btnGuardar.TabIndex = 51
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 464)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dtpHoraCita)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.DtpFechaCita)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtMotivoConsulta)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.cmbEspecialidad)
        Me.Controls.Add(Me.lblEspecialidad)
        Me.Controls.Add(Me.cmbMédico)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "frmCitas"
        Me.Text = "frmCitas"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMédico As ComboBox
    Friend WithEvents lblMedico As Label
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents txtMotivoConsulta As TextBox
    Friend WithEvents lblMotivo As Label
    Friend WithEvents DtpFechaCita As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpHoraCita As DateTimePicker
    Friend WithEvents lblHora As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
