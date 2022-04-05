<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPacientes
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
        Me.components = New System.ComponentModel.Container()
        Me.TabPacientes = New System.Windows.Forms.TabControl()
        Me.TabDatosPersonales = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbEdoCivil = New System.Windows.Forms.ComboBox()
        Me.grpResidencia = New System.Windows.Forms.GroupBox()
        Me.txtDirreccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.cmbPueblo = New System.Windows.Forms.ComboBox()
        Me.lblPueblo = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblEdoCivil = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefonoLocal = New System.Windows.Forms.Label()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpMedidasPaciente = New System.Windows.Forms.GroupBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.grpContacto = New System.Windows.Forms.GroupBox()
        Me.txtTelefonoContacto = New System.Windows.Forms.TextBox()
        Me.lblTelefonoContacto = New System.Windows.Forms.Label()
        Me.txtNombresContacto = New System.Windows.Forms.TextBox()
        Me.txtApellidosContacto = New System.Windows.Forms.TextBox()
        Me.lblApellidosContacto = New System.Windows.Forms.Label()
        Me.lblNombresContacto = New System.Windows.Forms.Label()
        Me.grpPlanMedico = New System.Windows.Forms.GroupBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TabSignosVitales = New System.Windows.Forms.TabPage()
        Me.helpGrados = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.helpRespiracion = New System.Windows.Forms.Label()
        Me.txtRespiracion = New System.Windows.Forms.TextBox()
        Me.lblRespiracion = New System.Windows.Forms.Label()
        Me.helpPresion = New System.Windows.Forms.Label()
        Me.txtPresion = New System.Windows.Forms.TextBox()
        Me.lblPresion = New System.Windows.Forms.Label()
        Me.helpPulso = New System.Windows.Forms.Label()
        Me.txtPulso = New System.Windows.Forms.TextBox()
        Me.lblPulso = New System.Windows.Forms.Label()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.dtpProximaConsulta = New System.Windows.Forms.DateTimePicker()
        Me.lblProximaCOnsulta = New System.Windows.Forms.Label()
        Me.txtIndicaciones = New System.Windows.Forms.TextBox()
        Me.lblindicaciones = New System.Windows.Forms.Label()
        Me.txtValoracion = New System.Windows.Forms.TextBox()
        Me.lblValoracion = New System.Windows.Forms.Label()
        Me.txtSintomas = New System.Windows.Forms.TextBox()
        Me.lblSintomas = New System.Windows.Forms.Label()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.TabPacientes.SuspendLayout()
        Me.TabDatosPersonales.SuspendLayout()
        Me.grpResidencia.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpMedidasPaciente.SuspendLayout()
        Me.grpContacto.SuspendLayout()
        Me.grpPlanMedico.SuspendLayout()
        Me.TabSignosVitales.SuspendLayout()
        Me.tabConsulta.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPacientes
        '
        Me.TabPacientes.Controls.Add(Me.TabDatosPersonales)
        Me.TabPacientes.Controls.Add(Me.TabPage2)
        Me.TabPacientes.Controls.Add(Me.TabSignosVitales)
        Me.TabPacientes.Controls.Add(Me.tabConsulta)
        Me.TabPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPacientes.Location = New System.Drawing.Point(12, 49)
        Me.TabPacientes.Name = "TabPacientes"
        Me.TabPacientes.SelectedIndex = 0
        Me.TabPacientes.Size = New System.Drawing.Size(1030, 478)
        Me.TabPacientes.TabIndex = 0
        '
        'TabDatosPersonales
        '
        Me.TabDatosPersonales.Controls.Add(Me.Label8)
        Me.TabDatosPersonales.Controls.Add(Me.cmbEdoCivil)
        Me.TabDatosPersonales.Controls.Add(Me.grpResidencia)
        Me.TabDatosPersonales.Controls.Add(Me.txtOcupacion)
        Me.TabDatosPersonales.Controls.Add(Me.lblOcupacion)
        Me.TabDatosPersonales.Controls.Add(Me.lblEdoCivil)
        Me.TabDatosPersonales.Controls.Add(Me.txtCelular)
        Me.TabDatosPersonales.Controls.Add(Me.lblCelular)
        Me.TabDatosPersonales.Controls.Add(Me.C)
        Me.TabDatosPersonales.Controls.Add(Me.lblMail)
        Me.TabDatosPersonales.Controls.Add(Me.txtTelefono)
        Me.TabDatosPersonales.Controls.Add(Me.lblTelefonoLocal)
        Me.TabDatosPersonales.Controls.Add(Me.DtpFechaNacimiento)
        Me.TabDatosPersonales.Controls.Add(Me.lblNacimiento)
        Me.TabDatosPersonales.Controls.Add(Me.cmbSexo)
        Me.TabDatosPersonales.Controls.Add(Me.lblSexo)
        Me.TabDatosPersonales.Controls.Add(Me.txtApellidos)
        Me.TabDatosPersonales.Controls.Add(Me.lblApellidos)
        Me.TabDatosPersonales.Controls.Add(Me.txtNombres)
        Me.TabDatosPersonales.Controls.Add(Me.lblNombres)
        Me.TabDatosPersonales.Controls.Add(Me.txtIdentificacion)
        Me.TabDatosPersonales.Controls.Add(Me.lblIdentificacion)
        Me.TabDatosPersonales.Location = New System.Drawing.Point(4, 29)
        Me.TabDatosPersonales.Name = "TabDatosPersonales"
        Me.TabDatosPersonales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDatosPersonales.Size = New System.Drawing.Size(1022, 445)
        Me.TabDatosPersonales.TabIndex = 0
        Me.TabDatosPersonales.Text = "DatosPersonales"
        Me.TabDatosPersonales.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(168, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Introduzca la información y presione enter para buscar si existe"
        '
        'cmbEdoCivil
        '
        Me.cmbEdoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEdoCivil.FormattingEnabled = True
        Me.cmbEdoCivil.Location = New System.Drawing.Point(172, 183)
        Me.cmbEdoCivil.Name = "cmbEdoCivil"
        Me.cmbEdoCivil.Size = New System.Drawing.Size(271, 28)
        Me.cmbEdoCivil.TabIndex = 20
        '
        'grpResidencia
        '
        Me.grpResidencia.Controls.Add(Me.txtDirreccion)
        Me.grpResidencia.Controls.Add(Me.lblDireccion)
        Me.grpResidencia.Controls.Add(Me.cmbPueblo)
        Me.grpResidencia.Controls.Add(Me.lblPueblo)
        Me.grpResidencia.Controls.Add(Me.cmbEstado)
        Me.grpResidencia.Controls.Add(Me.lblEstado)
        Me.grpResidencia.Location = New System.Drawing.Point(6, 324)
        Me.grpResidencia.Name = "grpResidencia"
        Me.grpResidencia.Size = New System.Drawing.Size(1010, 117)
        Me.grpResidencia.TabIndex = 18
        Me.grpResidencia.TabStop = False
        Me.grpResidencia.Text = "Dirección de Residencia"
        '
        'txtDirreccion
        '
        Me.txtDirreccion.Location = New System.Drawing.Point(152, 76)
        Me.txtDirreccion.Name = "txtDirreccion"
        Me.txtDirreccion.Size = New System.Drawing.Size(847, 26)
        Me.txtDirreccion.TabIndex = 19
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(14, 77)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(138, 20)
        Me.lblDireccion.TabIndex = 18
        Me.lblDireccion.Text = "Dirección Exacta*:"
        '
        'cmbPueblo
        '
        Me.cmbPueblo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPueblo.FormattingEnabled = True
        Me.cmbPueblo.Location = New System.Drawing.Point(582, 34)
        Me.cmbPueblo.Name = "cmbPueblo"
        Me.cmbPueblo.Size = New System.Drawing.Size(417, 28)
        Me.cmbPueblo.TabIndex = 11
        '
        'lblPueblo
        '
        Me.lblPueblo.AutoSize = True
        Me.lblPueblo.Location = New System.Drawing.Point(470, 37)
        Me.lblPueblo.Name = "lblPueblo"
        Me.lblPueblo.Size = New System.Drawing.Size(68, 20)
        Me.lblPueblo.TabIndex = 10
        Me.lblPueblo.Text = "Pueblo*:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(90, 35)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(345, 28)
        Me.cmbEstado.TabIndex = 9
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(14, 37)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(70, 20)
        Me.lblEstado.TabIndex = 8
        Me.lblEstado.Text = "Estado*:"
        '
        'txtOcupacion
        '
        Me.txtOcupacion.Location = New System.Drawing.Point(608, 187)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(397, 26)
        Me.txtOcupacion.TabIndex = 17
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Location = New System.Drawing.Point(467, 188)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(95, 20)
        Me.lblOcupacion.TabIndex = 16
        Me.lblOcupacion.Text = "Ocupación*:"
        '
        'lblEdoCivil
        '
        Me.lblEdoCivil.AutoSize = True
        Me.lblEdoCivil.Location = New System.Drawing.Point(20, 186)
        Me.lblEdoCivil.Name = "lblEdoCivil"
        Me.lblEdoCivil.Size = New System.Drawing.Size(101, 20)
        Me.lblEdoCivil.TabIndex = 14
        Me.lblEdoCivil.Text = "Estado Civil*:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(608, 235)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(271, 26)
        Me.txtCelular.TabIndex = 13
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(467, 236)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(134, 20)
        Me.lblCelular.TabIndex = 12
        Me.lblCelular.Text = "Teléfono Celular*:"
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(170, 275)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(709, 26)
        Me.C.TabIndex = 11
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(18, 276)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(57, 20)
        Me.lblMail.TabIndex = 10
        Me.lblMail.Text = "E-Mail:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(172, 233)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(271, 26)
        Me.txtTelefono.TabIndex = 11
        '
        'lblTelefonoLocal
        '
        Me.lblTelefonoLocal.AutoSize = True
        Me.lblTelefonoLocal.Location = New System.Drawing.Point(20, 234)
        Me.lblTelefonoLocal.Name = "lblTelefonoLocal"
        Me.lblTelefonoLocal.Size = New System.Drawing.Size(123, 20)
        Me.lblTelefonoLocal.TabIndex = 10
        Me.lblTelefonoLocal.Text = "Teléfono Local*:"
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(606, 144)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(200, 26)
        Me.DtpFechaNacimiento.TabIndex = 9
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Location = New System.Drawing.Point(465, 150)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(147, 20)
        Me.lblNacimiento.TabIndex = 8
        Me.lblNacimiento.Text = "Fecha Nacimiento*:"
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(170, 142)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(271, 28)
        Me.cmbSexo.TabIndex = 7
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(18, 144)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(55, 20)
        Me.lblSexo.TabIndex = 6
        Me.lblSexo.Text = "Sexo*:"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(170, 101)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(835, 26)
        Me.txtApellidos.TabIndex = 5
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(18, 102)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(83, 20)
        Me.lblApellidos.TabIndex = 4
        Me.lblApellidos.Text = "Apellidos*:"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(170, 59)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(835, 26)
        Me.txtNombres.TabIndex = 3
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(18, 60)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(83, 20)
        Me.lblNombres.TabIndex = 2
        Me.lblNombres.Text = "Nombres*:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(170, 9)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(271, 26)
        Me.txtIdentificacion.TabIndex = 1
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(18, 10)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(151, 20)
        Me.lblIdentificacion.TabIndex = 0
        Me.lblIdentificacion.Text = "N° de Identificación*"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpMedidasPaciente)
        Me.TabPage2.Controls.Add(Me.grpContacto)
        Me.TabPage2.Controls.Add(Me.grpPlanMedico)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1022, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Plan Salud y Contacto emergencia"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpMedidasPaciente
        '
        Me.grpMedidasPaciente.Controls.Add(Me.txtPeso)
        Me.grpMedidasPaciente.Controls.Add(Me.txtAltura)
        Me.grpMedidasPaciente.Controls.Add(Me.lblAltura)
        Me.grpMedidasPaciente.Controls.Add(Me.lblPeso)
        Me.grpMedidasPaciente.Location = New System.Drawing.Point(3, 8)
        Me.grpMedidasPaciente.Name = "grpMedidasPaciente"
        Me.grpMedidasPaciente.Size = New System.Drawing.Size(1010, 79)
        Me.grpMedidasPaciente.TabIndex = 22
        Me.grpMedidasPaciente.TabStop = False
        Me.grpMedidasPaciente.Text = "Medidas del paciente"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(82, 37)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(228, 26)
        Me.txtPeso.TabIndex = 18
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(586, 37)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(188, 26)
        Me.txtAltura.TabIndex = 17
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(457, 40)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(55, 20)
        Me.lblAltura.TabIndex = 16
        Me.lblAltura.Text = "Altura:"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(14, 37)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(49, 20)
        Me.lblPeso.TabIndex = 8
        Me.lblPeso.Text = "Peso:"
        '
        'grpContacto
        '
        Me.grpContacto.Controls.Add(Me.txtTelefonoContacto)
        Me.grpContacto.Controls.Add(Me.lblTelefonoContacto)
        Me.grpContacto.Controls.Add(Me.txtNombresContacto)
        Me.grpContacto.Controls.Add(Me.txtApellidosContacto)
        Me.grpContacto.Controls.Add(Me.lblApellidosContacto)
        Me.grpContacto.Controls.Add(Me.lblNombresContacto)
        Me.grpContacto.Location = New System.Drawing.Point(3, 194)
        Me.grpContacto.Name = "grpContacto"
        Me.grpContacto.Size = New System.Drawing.Size(1010, 127)
        Me.grpContacto.TabIndex = 21
        Me.grpContacto.TabStop = False
        Me.grpContacto.Text = "Contacto Emergencia"
        '
        'txtTelefonoContacto
        '
        Me.txtTelefonoContacto.Location = New System.Drawing.Point(87, 78)
        Me.txtTelefonoContacto.Name = "txtTelefonoContacto"
        Me.txtTelefonoContacto.Size = New System.Drawing.Size(345, 26)
        Me.txtTelefonoContacto.TabIndex = 20
        '
        'lblTelefonoContacto
        '
        Me.lblTelefonoContacto.AutoSize = True
        Me.lblTelefonoContacto.Location = New System.Drawing.Point(14, 78)
        Me.lblTelefonoContacto.Name = "lblTelefonoContacto"
        Me.lblTelefonoContacto.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefonoContacto.TabIndex = 19
        Me.lblTelefonoContacto.Text = "Teléfono:"
        '
        'txtNombresContacto
        '
        Me.txtNombresContacto.Location = New System.Drawing.Point(87, 37)
        Me.txtNombresContacto.Name = "txtNombresContacto"
        Me.txtNombresContacto.Size = New System.Drawing.Size(345, 26)
        Me.txtNombresContacto.TabIndex = 18
        '
        'txtApellidosContacto
        '
        Me.txtApellidosContacto.Location = New System.Drawing.Point(586, 37)
        Me.txtApellidosContacto.Name = "txtApellidosContacto"
        Me.txtApellidosContacto.Size = New System.Drawing.Size(393, 26)
        Me.txtApellidosContacto.TabIndex = 17
        '
        'lblApellidosContacto
        '
        Me.lblApellidosContacto.AutoSize = True
        Me.lblApellidosContacto.Location = New System.Drawing.Point(457, 40)
        Me.lblApellidosContacto.Name = "lblApellidosContacto"
        Me.lblApellidosContacto.Size = New System.Drawing.Size(77, 20)
        Me.lblApellidosContacto.TabIndex = 16
        Me.lblApellidosContacto.Text = "Apellidos:"
        '
        'lblNombresContacto
        '
        Me.lblNombresContacto.AutoSize = True
        Me.lblNombresContacto.Location = New System.Drawing.Point(14, 37)
        Me.lblNombresContacto.Name = "lblNombresContacto"
        Me.lblNombresContacto.Size = New System.Drawing.Size(77, 20)
        Me.lblNombresContacto.TabIndex = 8
        Me.lblNombresContacto.Text = "Nombres:"
        '
        'grpPlanMedico
        '
        Me.grpPlanMedico.Controls.Add(Me.txtNumero)
        Me.grpPlanMedico.Controls.Add(Me.lblNumero)
        Me.grpPlanMedico.Controls.Add(Me.cmbNombre)
        Me.grpPlanMedico.Controls.Add(Me.lblNombre)
        Me.grpPlanMedico.Location = New System.Drawing.Point(1, 106)
        Me.grpPlanMedico.Name = "grpPlanMedico"
        Me.grpPlanMedico.Size = New System.Drawing.Size(1010, 79)
        Me.grpPlanMedico.TabIndex = 20
        Me.grpPlanMedico.TabStop = False
        Me.grpPlanMedico.Text = "Plan Médico"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(586, 37)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(393, 26)
        Me.txtNumero.TabIndex = 17
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(457, 40)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(69, 20)
        Me.lblNumero.TabIndex = 16
        Me.lblNumero.Text = "Número:"
        '
        'cmbNombre
        '
        Me.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(90, 35)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(345, 28)
        Me.cmbNombre.TabIndex = 9
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(14, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre:"
        '
        'TabSignosVitales
        '
        Me.TabSignosVitales.Controls.Add(Me.helpGrados)
        Me.TabSignosVitales.Controls.Add(Me.txtTemperatura)
        Me.TabSignosVitales.Controls.Add(Me.lblTemperatura)
        Me.TabSignosVitales.Controls.Add(Me.helpRespiracion)
        Me.TabSignosVitales.Controls.Add(Me.txtRespiracion)
        Me.TabSignosVitales.Controls.Add(Me.lblRespiracion)
        Me.TabSignosVitales.Controls.Add(Me.helpPresion)
        Me.TabSignosVitales.Controls.Add(Me.txtPresion)
        Me.TabSignosVitales.Controls.Add(Me.lblPresion)
        Me.TabSignosVitales.Controls.Add(Me.helpPulso)
        Me.TabSignosVitales.Controls.Add(Me.txtPulso)
        Me.TabSignosVitales.Controls.Add(Me.lblPulso)
        Me.TabSignosVitales.Location = New System.Drawing.Point(4, 29)
        Me.TabSignosVitales.Name = "TabSignosVitales"
        Me.TabSignosVitales.Size = New System.Drawing.Size(1022, 445)
        Me.TabSignosVitales.TabIndex = 2
        Me.TabSignosVitales.Text = "Signos Vitales"
        Me.TabSignosVitales.UseVisualStyleBackColor = True
        '
        'helpGrados
        '
        Me.helpGrados.AutoSize = True
        Me.helpGrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpGrados.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.helpGrados.Location = New System.Drawing.Point(570, 109)
        Me.helpGrados.Name = "helpGrados"
        Me.helpGrados.Size = New System.Drawing.Size(41, 13)
        Me.helpGrados.TabIndex = 32
        Me.helpGrados.Text = "Grados"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Location = New System.Drawing.Point(568, 80)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(228, 26)
        Me.txtTemperatura.TabIndex = 31
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Location = New System.Drawing.Point(419, 80)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(104, 20)
        Me.lblTemperatura.TabIndex = 30
        Me.lblTemperatura.Text = "Temperatura:"
        '
        'helpRespiracion
        '
        Me.helpRespiracion.AutoSize = True
        Me.helpRespiracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpRespiracion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.helpRespiracion.Location = New System.Drawing.Point(129, 109)
        Me.helpRespiracion.Name = "helpRespiracion"
        Me.helpRespiracion.Size = New System.Drawing.Size(126, 13)
        Me.helpRespiracion.TabIndex = 29
        Me.helpRespiracion.Text = "Respiraciones por minuto"
        '
        'txtRespiracion
        '
        Me.txtRespiracion.Location = New System.Drawing.Point(127, 80)
        Me.txtRespiracion.Name = "txtRespiracion"
        Me.txtRespiracion.Size = New System.Drawing.Size(228, 26)
        Me.txtRespiracion.TabIndex = 28
        '
        'lblRespiracion
        '
        Me.lblRespiracion.AutoSize = True
        Me.lblRespiracion.Location = New System.Drawing.Point(24, 80)
        Me.lblRespiracion.Name = "lblRespiracion"
        Me.lblRespiracion.Size = New System.Drawing.Size(97, 20)
        Me.lblRespiracion.TabIndex = 27
        Me.lblRespiracion.Text = "Respiración:"
        '
        'helpPresion
        '
        Me.helpPresion.AutoSize = True
        Me.helpPresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpPresion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.helpPresion.Location = New System.Drawing.Point(570, 51)
        Me.helpPresion.Name = "helpPresion"
        Me.helpPresion.Size = New System.Drawing.Size(38, 13)
        Me.helpPresion.TabIndex = 26
        Me.helpPresion.Text = "mm hg"
        '
        'txtPresion
        '
        Me.txtPresion.Location = New System.Drawing.Point(568, 22)
        Me.txtPresion.Name = "txtPresion"
        Me.txtPresion.Size = New System.Drawing.Size(228, 26)
        Me.txtPresion.TabIndex = 25
        '
        'lblPresion
        '
        Me.lblPresion.AutoSize = True
        Me.lblPresion.Location = New System.Drawing.Point(416, 22)
        Me.lblPresion.Name = "lblPresion"
        Me.lblPresion.Size = New System.Drawing.Size(117, 20)
        Me.lblPresion.TabIndex = 24
        Me.lblPresion.Text = "Presión Arteral:"
        '
        'helpPulso
        '
        Me.helpPulso.AutoSize = True
        Me.helpPulso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpPulso.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.helpPulso.Location = New System.Drawing.Point(129, 51)
        Me.helpPulso.Name = "helpPulso"
        Me.helpPulso.Size = New System.Drawing.Size(89, 13)
        Me.helpPulso.TabIndex = 23
        Me.helpPulso.Text = "latidos por minuto"
        '
        'txtPulso
        '
        Me.txtPulso.Location = New System.Drawing.Point(127, 22)
        Me.txtPulso.Name = "txtPulso"
        Me.txtPulso.Size = New System.Drawing.Size(228, 26)
        Me.txtPulso.TabIndex = 20
        '
        'lblPulso
        '
        Me.lblPulso.AutoSize = True
        Me.lblPulso.Location = New System.Drawing.Point(24, 22)
        Me.lblPulso.Name = "lblPulso"
        Me.lblPulso.Size = New System.Drawing.Size(52, 20)
        Me.lblPulso.TabIndex = 19
        Me.lblPulso.Text = "Pulso:"
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.dtpProximaConsulta)
        Me.tabConsulta.Controls.Add(Me.lblProximaCOnsulta)
        Me.tabConsulta.Controls.Add(Me.txtIndicaciones)
        Me.tabConsulta.Controls.Add(Me.lblindicaciones)
        Me.tabConsulta.Controls.Add(Me.txtValoracion)
        Me.tabConsulta.Controls.Add(Me.lblValoracion)
        Me.tabConsulta.Controls.Add(Me.txtSintomas)
        Me.tabConsulta.Controls.Add(Me.lblSintomas)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 29)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(1022, 445)
        Me.tabConsulta.TabIndex = 3
        Me.tabConsulta.Text = "Consulta"
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'dtpProximaConsulta
        '
        Me.dtpProximaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProximaConsulta.Location = New System.Drawing.Point(13, 373)
        Me.dtpProximaConsulta.Name = "dtpProximaConsulta"
        Me.dtpProximaConsulta.Size = New System.Drawing.Size(200, 26)
        Me.dtpProximaConsulta.TabIndex = 27
        '
        'lblProximaCOnsulta
        '
        Me.lblProximaCOnsulta.AutoSize = True
        Me.lblProximaCOnsulta.Location = New System.Drawing.Point(18, 350)
        Me.lblProximaCOnsulta.Name = "lblProximaCOnsulta"
        Me.lblProximaCOnsulta.Size = New System.Drawing.Size(185, 20)
        Me.lblProximaCOnsulta.TabIndex = 26
        Me.lblProximaCOnsulta.Text = "Fecha Próxima Consulta:"
        '
        'txtIndicaciones
        '
        Me.txtIndicaciones.Location = New System.Drawing.Point(13, 250)
        Me.txtIndicaciones.Multiline = True
        Me.txtIndicaciones.Name = "txtIndicaciones"
        Me.txtIndicaciones.Size = New System.Drawing.Size(996, 77)
        Me.txtIndicaciones.TabIndex = 25
        '
        'lblindicaciones
        '
        Me.lblindicaciones.AutoSize = True
        Me.lblindicaciones.Location = New System.Drawing.Point(8, 229)
        Me.lblindicaciones.Name = "lblindicaciones"
        Me.lblindicaciones.Size = New System.Drawing.Size(102, 20)
        Me.lblindicaciones.TabIndex = 24
        Me.lblindicaciones.Text = "Indicaciones:"
        '
        'txtValoracion
        '
        Me.txtValoracion.Location = New System.Drawing.Point(13, 133)
        Me.txtValoracion.Multiline = True
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Size = New System.Drawing.Size(996, 77)
        Me.txtValoracion.TabIndex = 23
        '
        'lblValoracion
        '
        Me.lblValoracion.AutoSize = True
        Me.lblValoracion.Location = New System.Drawing.Point(8, 112)
        Me.lblValoracion.Name = "lblValoracion"
        Me.lblValoracion.Size = New System.Drawing.Size(239, 20)
        Me.lblValoracion.TabIndex = 22
        Me.lblValoracion.Text = "Valoración Médica / Diagnóstico:"
        '
        'txtSintomas
        '
        Me.txtSintomas.Location = New System.Drawing.Point(11, 24)
        Me.txtSintomas.Multiline = True
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(996, 77)
        Me.txtSintomas.TabIndex = 21
        '
        'lblSintomas
        '
        Me.lblSintomas.AutoSize = True
        Me.lblSintomas.Location = New System.Drawing.Point(6, 3)
        Me.lblSintomas.Name = "lblSintomas"
        Me.lblSintomas.Size = New System.Drawing.Size(228, 20)
        Me.lblSintomas.TabIndex = 20
        Me.lblSintomas.Text = "Descripción de Sintomatología:"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Black
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1084, 43)
        Me.pnlTitulo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(390, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GESTIÓN DE PACIENTES"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(154, 558)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(221, 55)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DimGray
        Me.btnCancelar.Location = New System.Drawing.Point(644, 558)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(221, 55)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.Color.Red
        Me.lblMensaje.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Location = New System.Drawing.Point(35, 530)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(36, 18)
        Me.lblMensaje.TabIndex = 19
        Me.lblMensaje.Text = "......."
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 625)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.TabPacientes)
        Me.Name = "frmPacientes"
        Me.Text = "Pacientes"
        Me.TabPacientes.ResumeLayout(False)
        Me.TabDatosPersonales.ResumeLayout(False)
        Me.TabDatosPersonales.PerformLayout()
        Me.grpResidencia.ResumeLayout(False)
        Me.grpResidencia.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpMedidasPaciente.ResumeLayout(False)
        Me.grpMedidasPaciente.PerformLayout()
        Me.grpContacto.ResumeLayout(False)
        Me.grpContacto.PerformLayout()
        Me.grpPlanMedico.ResumeLayout(False)
        Me.grpPlanMedico.PerformLayout()
        Me.TabSignosVitales.ResumeLayout(False)
        Me.TabSignosVitales.PerformLayout()
        Me.tabConsulta.ResumeLayout(False)
        Me.tabConsulta.PerformLayout()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabPacientes As TabControl
    Friend WithEvents TabDatosPersonales As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents DtpFechaNacimiento As DateTimePicker
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblEdoCivil As Label
    Friend WithEvents grpResidencia As GroupBox
    Friend WithEvents cmbPueblo As ComboBox
    Friend WithEvents lblPueblo As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents txtDirreccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents cmbEdoCivil As ComboBox
    Friend WithEvents grpContacto As GroupBox
    Friend WithEvents txtTelefonoContacto As TextBox
    Friend WithEvents lblTelefonoContacto As Label
    Friend WithEvents txtNombresContacto As TextBox
    Friend WithEvents txtApellidosContacto As TextBox
    Friend WithEvents lblApellidosContacto As Label
    Friend WithEvents lblNombresContacto As Label
    Friend WithEvents grpPlanMedico As GroupBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents C As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefonoLocal As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents grpMedidasPaciente As GroupBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents TabSignosVitales As TabPage
    Friend WithEvents helpPresion As Label
    Friend WithEvents txtPresion As TextBox
    Friend WithEvents lblPresion As Label
    Friend WithEvents helpPulso As Label
    Friend WithEvents txtPulso As TextBox
    Friend WithEvents lblPulso As Label
    Friend WithEvents helpRespiracion As Label
    Friend WithEvents txtRespiracion As TextBox
    Friend WithEvents lblRespiracion As Label
    Friend WithEvents helpGrados As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents tabConsulta As TabPage
    Friend WithEvents txtSintomas As TextBox
    Friend WithEvents lblSintomas As Label
    Friend WithEvents txtValoracion As TextBox
    Friend WithEvents lblValoracion As Label
    Friend WithEvents txtIndicaciones As TextBox
    Friend WithEvents lblindicaciones As Label
    Friend WithEvents dtpProximaConsulta As DateTimePicker
    Friend WithEvents lblProximaCOnsulta As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblMensaje As Label
End Class
