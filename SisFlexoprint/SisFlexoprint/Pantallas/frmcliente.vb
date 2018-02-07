Imports System.ComponentModel

Public Class frmcliente

    Private dt As New DataTable
    Dim save_edit As New Integer

    Private Sub bloqueartext()
        txtnombre.BorderStyle = BorderStyle.None
        txtcedula.BorderStyle = BorderStyle.None
        txtdireccion.BorderStyle = BorderStyle.None
        txttelefono.BorderStyle = BorderStyle.None
        txtemail.BorderStyle = BorderStyle.None
        'txtfecha.BorderStyle = BorderStyle.None
        'txtedad.BorderStyle = BorderStyle.None

        txtnombre.ReadOnly = True
        txtcedula.ReadOnly = True
        txtdireccion.ReadOnly = True
        txttelefono.ReadOnly = True
        txtemail.ReadOnly = True
        'txtfecha.ReadOnly = True
        'txtedad.ReadOnly = True

        'txtfecha.BackColor = Color.White
        'txtedad.Visible = True
        'laedad.Visible = True
    End Sub

    Private Sub bloquearbtn()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btneditar.Enabled = False
        btnnuevo.Enabled = False
    End Sub

    Private Sub desbloqueartext()
        txtnombre.BorderStyle = BorderStyle.FixedSingle
        txtcedula.BorderStyle = BorderStyle.FixedSingle
        txtdireccion.BorderStyle = BorderStyle.FixedSingle
        txttelefono.BorderStyle = BorderStyle.FixedSingle
        txtemail.BorderStyle = BorderStyle.FixedSingle
        'txtfecha.BorderStyle = BorderStyle.FixedSingle
        'txtedad.BorderStyle = BorderStyle.FixedSingle

        txtnombre.ReadOnly = False
        txtcedula.ReadOnly = False
        txtdireccion.ReadOnly = False
        txttelefono.ReadOnly = False
        txtemail.ReadOnly = False
        'txtfecha.ReadOnly = False
        'txtedad.ReadOnly = False

        'txtedad.Visible = False
        'laedad.Visible = False
    End Sub

    Private Sub desbloquearbtn()
        btnguardar.Enabled = True
        btncancelar.Enabled = True
        btneliminar.Enabled = True
        btneditar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar()

            If dt.Rows.Count <> 0 Then
                dgvlistado.DataSource = dt
                txtbuscar.Enabled = True
                dgvlistado.ColumnHeadersVisible = True
                modificar_columnas()
            Else
                dgvlistado.DataSource = Nothing
                txtbuscar.Enabled = False
                dgvlistado.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub modificar_columnas()

        dgvlistado.CurrentRow.Selected = False

        'Ocultas
        dgvlistado.Columns("idcliente").Visible = False

        'Visibles
        dgvlistado.Columns("direccion").HeaderText = "Direccion"
        dgvlistado.Columns("email").HeaderText = "Correo"
        dgvlistado.Columns("cedula").HeaderText = "Cedula"

        dgvlistado.Columns("nombre").HeaderText = "Nombre"
        dgvlistado.Columns("nombre").Width = 150

        dgvlistado.Columns("telefono").HeaderText = "Teléfono"
        dgvlistado.Columns("telefono").Width = 80
        dgvlistado.Columns("telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgvlistado.DataSource = dv
                modificar_columnas()
            Else
                dgvlistado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txtnombre.Text = ""
        txtcedula.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtemail.Text = ""
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvlistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellClick
        Try
            limpiar()
            txtnombre.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
            txtcedula.Text = dgvlistado.SelectedCells.Item(5).Value.ToString
            txtdireccion.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
            txttelefono.Text = dgvlistado.SelectedCells.Item(3).Value.ToString
            txtemail.Text = dgvlistado.SelectedCells.Item(4).Value.ToString
            desbloquearbtn()
            bloqueartext()
            desbloquearbtn()
            btnguardar.Enabled = False
            btncancelar.Enabled = False
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("No se pueden obtener datos de los encabezados")
        End Try
    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        desbloqueartext()
        save_edit = 1
        desbloquearbtn()
        btneditar.Enabled = False
        btneliminar.Enabled = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If save_edit = 1 Then
            If Me.ValidateChildren = True And txtnombre.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim func As New fcliente

                    dts.gnombre = txtnombre.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gemail = txtemail.Text
                    dts.gcedula = txtcedula.Text

                    If func.ingresar(dts) Then
                        MessageBox.Show("Registro completado.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        bloqueartext()
                        bloquearbtn()
                        btnnuevo.Enabled = True
                    Else
                        MessageBox.Show("No se pudo completar el registro.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos incompletos. Llene los campos obligatorios.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf save_edit = 0 Then
            Dim result As DialogResult

            result = MessageBox.Show("¿Desea modificar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then

                If Me.ValidateChildren = True And txtnombre.Text <> "" Then
                    Try
                        Dim dts As New vcliente
                        Dim func As New fcliente

                        dts.gidcliente = dgvlistado.SelectedCells.Item(0).Value
                        dts.gnombre = txtnombre.Text
                        dts.gdireccion = txtdireccion.Text
                        dts.gtelefono = txttelefono.Text
                        dts.gemail = txtemail.Text
                        dts.gcedula = txtcedula.Text

                        If func.editar(dts) Then
                            MessageBox.Show("Edición completada.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                            bloqueartext()
                            bloquearbtn()
                            btnnuevo.Enabled = True
                        Else
                            MessageBox.Show("No se pudo completar la edición.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Datos incompletos. Llene los campos obligatorios.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        desbloqueartext()
        save_edit = 0
        desbloquearbtn()
        btnnuevo.Enabled = False
        btneliminar.Enabled = False
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        Dim result As DialogResult

        result = MessageBox.Show("¿Desea eliminar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim func As New fcliente

                    dts.gidcliente = dgvlistado.SelectedCells.Item(0).Value

                    If func.eliminar(dts) Then
                        MessageBox.Show("Eliminar completado.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        bloqueartext()
                        bloquearbtn()
                        btnnuevo.Enabled = True
                    Else
                        MessageBox.Show("No se pudo completar la eliminación.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos incompletos. Llene los campos obligatorios.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvlistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellDoubleClick
        If txtbandera.Text = "1" Then
            frmventas.txtidcliente.Text = dgvlistado.SelectedCells.Item(0).Value.ToString
            frmventas.txtnombrec.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
            txtbandera.Text = "0"
            frmventas.checkgenerico.Checked = False
            frmcontenedor.pnpantallas.Controls.Clear()
            frmventas.TopLevel = False
            frmventas.Visible = True
            frmcontenedor.pnpantallas.Controls.Add(frmventas)
            frmventas.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
    End Sub

    Private Sub ToolTip1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnnuevo, "Nuevo")
        ToolTip1.SetToolTip(btneditar, "Editar")
        ToolTip1.SetToolTip(btnguardar, "Guardar")
        ToolTip1.SetToolTip(btneliminar, "Eliminar")
        ToolTip1.SetToolTip(btncancelar, "Cancelar")
    End Sub


End Class