<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPacientes
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
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblEspecialidadMedica = New System.Windows.Forms.Label()
        Me.lblNombresMedico = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.DarkCyan
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(949, 43)
        Me.pnlTitulo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(242, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(545, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LISTADO DE PACIENTES CITADOS HOY"
        '
        'dgvPacientes
        '
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(12, 95)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.Size = New System.Drawing.Size(925, 315)
        Me.dgvPacientes.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DimGray
        Me.btnCancelar.Location = New System.Drawing.Point(351, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(221, 55)
        Me.btnCancelar.TabIndex = 53
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblEspecialidadMedica
        '
        Me.lblEspecialidadMedica.AutoSize = True
        Me.lblEspecialidadMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidadMedica.Location = New System.Drawing.Point(38, 46)
        Me.lblEspecialidadMedica.Name = "lblEspecialidadMedica"
        Me.lblEspecialidadMedica.Size = New System.Drawing.Size(99, 20)
        Me.lblEspecialidadMedica.TabIndex = 54
        Me.lblEspecialidadMedica.Text = "Especialidad"
        '
        'lblNombresMedico
        '
        Me.lblNombresMedico.AutoSize = True
        Me.lblNombresMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresMedico.Location = New System.Drawing.Point(38, 72)
        Me.lblNombresMedico.Name = "lblNombresMedico"
        Me.lblNombresMedico.Size = New System.Drawing.Size(60, 20)
        Me.lblNombresMedico.TabIndex = 55
        Me.lblNombresMedico.Text = "Médico"
        '
        'frmListaPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 489)
        Me.Controls.Add(Me.lblNombresMedico)
        Me.Controls.Add(Me.lblEspecialidadMedica)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "frmListaPacientes"
        Me.Text = "frmListaPacientes"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblEspecialidadMedica As Label
    Friend WithEvents lblNombresMedico As Label
End Class
