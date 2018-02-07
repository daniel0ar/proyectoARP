Public Class frmusuario
    Private Sub cambiar(password As String, nuevo As String)
        Try
            Dim dts As New vusuario
            Dim func As New fusuario

            dts.gidusuario = 1
            dts.gusuario = "admin"
            dts.gpassword = password

            If func.validar_usuario(dts) = True Then
                dts.gpassword = nuevo
                func.editar(dts)
                MessageBox.Show("Contraseña cambiada.", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmcontenedor.pnpantallas.Controls.Clear()
                frmventas.TopLevel = False
                frmventas.Visible = True
                frmcontenedor.pnpantallas.Controls.Add(frmventas)
            Else
                MsgBox("Credencial incorrecta", MsgBoxStyle.Information, "Configuración")
                txtactual.Clear()
                txtnueva.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If txtnueva.Text = "" Or txtactual.Text = "" Then
            MessageBox.Show("Ingrese su contraseña", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cambiar(txtactual.Text, txtnueva.Text)
        End If
    End Sub

    Private Sub txtnueva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnueva.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtnueva.Text = "" Or txtactual.Text = "" Then
                MessageBox.Show("Ingrese su contraseña.", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cambiar(txtactual.Text, txtnueva.Text)
            End If
        End If
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        frmcontenedor.pnpantallas.Controls.Clear()
        frmventas.TopLevel = False
        frmventas.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmventas)
        frmventas.Show()
    End Sub
End Class