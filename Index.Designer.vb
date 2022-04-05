<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Index
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnRestore = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pnlMenuVertical = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblReportes = New System.Windows.Forms.Label()
        Me.lblCitas = New System.Windows.Forms.Label()
        Me.lblPacientes = New System.Windows.Forms.Label()
        Me.lblMedicos = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenuVertical.SuspendLayout()
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel1.Controls.Add(Me.btnMaximizar)
        Me.panel1.Controls.Add(Me.btnMinimizar)
        Me.panel1.Controls.Add(Me.btnRestore)
        Me.panel1.Controls.Add(Me.btnExit)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1300, 23)
        Me.panel1.TabIndex = 1
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = Global.centroMedicoApp.My.Resources.Resources.maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1232, 4)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(24, 15)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.centroMedicoApp.My.Resources.Resources.minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1208, 5)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(17, 15)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.Image = Global.centroMedicoApp.My.Resources.Resources.restore
        Me.btnRestore.Location = New System.Drawing.Point(1231, 3)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(24, 15)
        Me.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.TabStop = False
        Me.btnRestore.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = Global.centroMedicoApp.My.Resources.Resources.close
        Me.btnExit.Location = New System.Drawing.Point(1264, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(15, 15)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 0
        Me.btnExit.TabStop = False
        Me.btnExit.Tag = "rtrtrr"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(226, 20)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Gestión de Consultorio Médico"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.panel2.Controls.Add(Me.PictureBox6)
        Me.panel2.Controls.Add(Me.pnlMenuVertical)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 23)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1300, 577)
        Me.panel2.TabIndex = 3
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(536, 137)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(265, 248)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'pnlMenuVertical
        '
        Me.pnlMenuVertical.BackColor = System.Drawing.Color.Black
        Me.pnlMenuVertical.Controls.Add(Me.btnCerrarSesion)
        Me.pnlMenuVertical.Controls.Add(Me.pictureBox4)
        Me.pnlMenuVertical.Controls.Add(Me.pictureBox5)
        Me.pnlMenuVertical.Controls.Add(Me.pictureBox3)
        Me.pnlMenuVertical.Controls.Add(Me.pictureBox2)
        Me.pnlMenuVertical.Controls.Add(Me.lblReportes)
        Me.pnlMenuVertical.Controls.Add(Me.lblCitas)
        Me.pnlMenuVertical.Controls.Add(Me.lblPacientes)
        Me.pnlMenuVertical.Controls.Add(Me.lblMedicos)
        Me.pnlMenuVertical.Controls.Add(Me.pictureBox1)
        Me.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuVertical.Name = "pnlMenuVertical"
        Me.pnlMenuVertical.Size = New System.Drawing.Size(200, 577)
        Me.pnlMenuVertical.TabIndex = 2
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrarSesion.Image = Global.centroMedicoApp.My.Resources.Resources.cerrarSesion2
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 506)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(200, 71)
        Me.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrarSesion.TabIndex = 13
        Me.btnCerrarSesion.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pictureBox4.Location = New System.Drawing.Point(12, 292)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(8, 15)
        Me.pictureBox4.TabIndex = 10
        Me.pictureBox4.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pictureBox5.Location = New System.Drawing.Point(12, 265)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(8, 15)
        Me.pictureBox5.TabIndex = 9
        Me.pictureBox5.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pictureBox3.Location = New System.Drawing.Point(12, 237)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(8, 15)
        Me.pictureBox3.TabIndex = 8
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pictureBox2.Location = New System.Drawing.Point(12, 209)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(8, 15)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'lblReportes
        '
        Me.lblReportes.AutoSize = True
        Me.lblReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReportes.Location = New System.Drawing.Point(21, 289)
        Me.lblReportes.Name = "lblReportes"
        Me.lblReportes.Size = New System.Drawing.Size(75, 20)
        Me.lblReportes.TabIndex = 6
        Me.lblReportes.Text = "Reportes"
        '
        'lblCitas
        '
        Me.lblCitas.AutoSize = True
        Me.lblCitas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCitas.Location = New System.Drawing.Point(21, 262)
        Me.lblCitas.Name = "lblCitas"
        Me.lblCitas.Size = New System.Drawing.Size(45, 20)
        Me.lblCitas.TabIndex = 5
        Me.lblCitas.Text = "Citas"
        '
        'lblPacientes
        '
        Me.lblPacientes.AutoSize = True
        Me.lblPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPacientes.Location = New System.Drawing.Point(21, 209)
        Me.lblPacientes.Name = "lblPacientes"
        Me.lblPacientes.Size = New System.Drawing.Size(79, 20)
        Me.lblPacientes.TabIndex = 4
        Me.lblPacientes.Text = "Pacientes"
        '
        'lblMedicos
        '
        Me.lblMedicos.AutoSize = True
        Me.lblMedicos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMedicos.Location = New System.Drawing.Point(21, 237)
        Me.lblMedicos.Name = "lblMedicos"
        Me.lblMedicos.Size = New System.Drawing.Size(68, 20)
        Me.lblMedicos.TabIndex = 3
        Me.lblMedicos.Text = "Médicos"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(25, 6)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(146, 137)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 600)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Index"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenuVertical.ResumeLayout(False)
        Me.pnlMenuVertical.PerformLayout()
        CType(Me.btnCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents label1 As Label
    Private WithEvents btnRestore As PictureBox
    Private WithEvents btnMinimizar As PictureBox
    Private WithEvents btnExit As PictureBox
    Private WithEvents btnMaximizar As PictureBox
    Private WithEvents panel2 As Panel
    Private WithEvents pnlMenuVertical As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents lblReportes As Label
    Private WithEvents lblCitas As Label
    Private WithEvents lblPacientes As Label
    Private WithEvents lblMedicos As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnCerrarSesion As PictureBox
    Private WithEvents PictureBox6 As PictureBox
End Class
