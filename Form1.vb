Public Class frmPacientes
    Private Sub frmPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMensaje.Text = ""
        cmbSexo.Items.Add("Femenino")
        cmbSexo.Items.Add("Masculino")
    End Sub

    Function existenCamposVacios() As Boolean
        If txtIdentificacion.Text = "" Or txtNombres.Text = "" Or txtApellidos.Text = "" Or cmbSexo.Text = "" Or DtpFechaNacimiento.Text = "" Or cmbEdoCivil.Text = "" Or txtOcupacion.Text = "" Or txtTelefono.Text = "" Or txtCelular.Text = "" Or cmbEstado.Text = "" Or cmbPueblo.Text = "" Or txtDirreccion.Text = "" Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Private Sub DatosPersonales_Click(sender As Object, e As EventArgs) Handles TabDatosPersonales.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub txtIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles txtIdentificacion.TextChanged

    End Sub

    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged

    End Sub

    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^a-zA-Z()\b]") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        lblMensaje.Text = ""
        If existenCamposVacios() Then
            lblMensaje.Text = "Debe llenar todos los campos obligatorios marcados con *"
        End If


    End Sub

    Private Sub txtIdentificacion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdentificacion.Validating
        If String.IsNullOrEmpty(txtIdentificacion.Text.Trim) Then
            ErrorProvider1.SetError(txtIdentificacion, "Obligatorio")
        Else
            ErrorProvider1.SetError(txtIdentificacion, String.Empty)
        End If
    End Sub
End Class
