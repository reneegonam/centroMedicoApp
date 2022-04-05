Public Class Index
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click


        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        btnRestore.Visible = True
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Me.WindowState = FormWindowState.Normal

        btnMaximizar.Visible = True
        btnRestore.Visible = False
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub lblMedicos_Click(sender As Object, e As EventArgs) Handles lblMedicos.Click
        frmMedico.Show()

    End Sub

    Private Sub lblMedicos_MouseHover(sender As Object, e As EventArgs) Handles lblMedicos.MouseHover
        lblMedicos.ForeColor = Color.Blue




    End Sub

    Private Sub lblMedicos_MouseLeave(sender As Object, e As EventArgs) Handles lblMedicos.MouseLeave
        lblMedicos.ForeColor = Color.White
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub panel2_Paint(sender As Object, e As PaintEventArgs) Handles panel2.Paint

    End Sub

    Private Sub Index_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


    End Sub

    Private Sub lblPacientes_Click(sender As Object, e As EventArgs) Handles lblPacientes.Click
        AbrirFormEnPanel(Of frmPacientes)()
    End Sub

    Private Sub lblCitas_Click(sender As Object, e As EventArgs) Handles lblCitas.Click
        frmCitas.Show()

    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub lblPacientes_MouseHover(sender As Object, e As EventArgs) Handles lblPacientes.MouseHover
        lblPacientes.ForeColor = Color.Blue
    End Sub

    Private Sub lblPacientes_MouseLeave(sender As Object, e As EventArgs) Handles lblPacientes.MouseLeave
        lblPacientes.ForeColor = Color.White
    End Sub

    Private Sub lblCitas_MouseHover(sender As Object, e As EventArgs) Handles lblCitas.MouseHover
        lblCitas.ForeColor = Color.Blue
    End Sub

    Private Sub lblCitas_MouseLeave(sender As Object, e As EventArgs) Handles lblCitas.MouseLeave
        lblCitas.ForeColor = Color.White
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim resp As Int16
        resp = MessageBox.Show("¿Confirma que desea salir del sistema?", "Salir", MessageBoxButtons.YesNo)
        If resp = vbYes Then
            Close()
        End If
    End Sub

    Private Sub lblReportes_MouseHover(sender As Object, e As EventArgs) Handles lblReportes.MouseHover
        lblReportes.ForeColor = Color.Blue
    End Sub

    Private Sub lblReportes_MouseLeave(sender As Object, e As EventArgs) Handles lblReportes.MouseLeave
        lblReportes.ForeColor = Color.White
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs)

    End Sub
#Region "Redimensionay y arrastrar"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 30

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.panel2.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.White, sizeGripRectangle)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Index_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region


    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()

        Dim Formulario As Form
        Formulario = panel2.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'

        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            panel2.Controls.Add(Formulario)
            panel2.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

End Class