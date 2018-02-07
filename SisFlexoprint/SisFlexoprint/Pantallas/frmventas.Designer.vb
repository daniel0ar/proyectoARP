<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmventas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.btagregare = New System.Windows.Forms.Button()
        Me.txtprecios = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btbuscars = New System.Windows.Forms.Button()
        Me.btbuscare = New System.Windows.Forms.Button()
        Me.txtcantidads = New System.Windows.Forms.NumericUpDown()
        Me.txtempleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtetiqueta = New System.Windows.Forms.TextBox()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.checkgenerico = New System.Windows.Forms.CheckBox()
        Me.btbuscarc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnombrec = New System.Windows.Forms.TextBox()
        Me.piccliente = New System.Windows.Forms.PictureBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.txtidetiqueta = New System.Windows.Forms.TextBox()
        Me.dgvservicios = New System.Windows.Forms.DataGridView()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.pandatossec.SuspendLayout()
        CType(Me.txtcantidads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.piccliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvservicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.btagregare)
        Me.pandatossec.Controls.Add(Me.txtprecios)
        Me.pandatossec.Controls.Add(Me.Label10)
        Me.pandatossec.Controls.Add(Me.btbuscars)
        Me.pandatossec.Controls.Add(Me.btbuscare)
        Me.pandatossec.Controls.Add(Me.txtcantidads)
        Me.pandatossec.Controls.Add(Me.txtempleado)
        Me.pandatossec.Controls.Add(Me.Label3)
        Me.pandatossec.Controls.Add(Me.Label2)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtetiqueta)
        Me.pandatossec.Location = New System.Drawing.Point(583, 60)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(381, 127)
        Me.pandatossec.TabIndex = 18
        '
        'btagregare
        '
        Me.btagregare.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregare.Location = New System.Drawing.Point(308, 82)
        Me.btagregare.Name = "btagregare"
        Me.btagregare.Size = New System.Drawing.Size(54, 25)
        Me.btagregare.TabIndex = 20
        Me.btagregare.Text = "Add"
        Me.btagregare.UseVisualStyleBackColor = True
        '
        'txtprecios
        '
        Me.txtprecios.BackColor = System.Drawing.Color.White
        Me.txtprecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecios.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecios.ForeColor = System.Drawing.Color.Black
        Me.txtprecios.Location = New System.Drawing.Point(265, 82)
        Me.txtprecios.Name = "txtprecios"
        Me.txtprecios.Size = New System.Drawing.Size(37, 25)
        Me.txtprecios.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(214, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Precio"
        '
        'btbuscars
        '
        Me.btbuscars.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscars.Location = New System.Drawing.Point(337, 51)
        Me.btbuscars.Name = "btbuscars"
        Me.btbuscars.Size = New System.Drawing.Size(25, 25)
        Me.btbuscars.TabIndex = 17
        Me.btbuscars.Text = "..."
        Me.btbuscars.UseVisualStyleBackColor = True
        '
        'btbuscare
        '
        Me.btbuscare.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscare.Location = New System.Drawing.Point(337, 20)
        Me.btbuscare.Name = "btbuscare"
        Me.btbuscare.Size = New System.Drawing.Size(25, 25)
        Me.btbuscare.TabIndex = 16
        Me.btbuscare.Text = "..."
        Me.btbuscare.UseVisualStyleBackColor = True
        '
        'txtcantidads
        '
        Me.txtcantidads.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidads.Location = New System.Drawing.Point(85, 82)
        Me.txtcantidads.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtcantidads.Name = "txtcantidads"
        Me.txtcantidads.Size = New System.Drawing.Size(40, 25)
        Me.txtcantidads.TabIndex = 15
        Me.txtcantidads.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtempleado
        '
        Me.txtempleado.BackColor = System.Drawing.Color.White
        Me.txtempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtempleado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleado.ForeColor = System.Drawing.Color.Black
        Me.txtempleado.Location = New System.Drawing.Point(91, 20)
        Me.txtempleado.MaxLength = 10
        Me.txtempleado.Name = "txtempleado"
        Me.txtempleado.Size = New System.Drawing.Size(240, 25)
        Me.txtempleado.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Etiqueta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empleado"
        '
        'txtetiqueta
        '
        Me.txtetiqueta.BackColor = System.Drawing.Color.White
        Me.txtetiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtetiqueta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtetiqueta.ForeColor = System.Drawing.Color.Black
        Me.txtetiqueta.Location = New System.Drawing.Point(91, 51)
        Me.txtetiqueta.Name = "txtetiqueta"
        Me.txtetiqueta.Size = New System.Drawing.Size(240, 25)
        Me.txtetiqueta.TabIndex = 5
        '
        'pandatosprin
        '
        Me.pandatosprin.BackColor = System.Drawing.Color.White
        Me.pandatosprin.Controls.Add(Me.Label8)
        Me.pandatosprin.Controls.Add(Me.dtpfecha)
        Me.pandatosprin.Controls.Add(Me.checkgenerico)
        Me.pandatosprin.Controls.Add(Me.btbuscarc)
        Me.pandatosprin.Controls.Add(Me.Label7)
        Me.pandatosprin.Controls.Add(Me.txtnombrec)
        Me.pandatosprin.Controls.Add(Me.piccliente)
        Me.pandatosprin.Location = New System.Drawing.Point(60, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 144)
        Me.pandatosprin.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(17, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fecha"
        '
        'dtpfecha
        '
        Me.dtpfecha.CustomFormat = ""
        Me.dtpfecha.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(66, 99)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpfecha.Size = New System.Drawing.Size(164, 25)
        Me.dtpfecha.TabIndex = 11
        '
        'checkgenerico
        '
        Me.checkgenerico.AutoSize = True
        Me.checkgenerico.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkgenerico.Location = New System.Drawing.Point(359, 16)
        Me.checkgenerico.Name = "checkgenerico"
        Me.checkgenerico.Size = New System.Drawing.Size(80, 21)
        Me.checkgenerico.TabIndex = 10
        Me.checkgenerico.Text = "Genérico"
        Me.checkgenerico.UseVisualStyleBackColor = True
        '
        'btbuscarc
        '
        Me.btbuscarc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscarc.Location = New System.Drawing.Point(418, 37)
        Me.btbuscarc.Name = "btbuscarc"
        Me.btbuscarc.Size = New System.Drawing.Size(25, 25)
        Me.btbuscarc.TabIndex = 9
        Me.btbuscarc.Text = "..."
        Me.btbuscarc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(17, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cliente"
        '
        'txtnombrec
        '
        Me.txtnombrec.BackColor = System.Drawing.Color.White
        Me.txtnombrec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombrec.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrec.ForeColor = System.Drawing.Color.Black
        Me.txtnombrec.Location = New System.Drawing.Point(20, 37)
        Me.txtnombrec.Name = "txtnombrec"
        Me.txtnombrec.Size = New System.Drawing.Size(392, 25)
        Me.txtnombrec.TabIndex = 2
        '
        'piccliente
        '
        Me.piccliente.Location = New System.Drawing.Point(30, 20)
        Me.piccliente.Name = "piccliente"
        Me.piccliente.Size = New System.Drawing.Size(0, 0)
        Me.piccliente.TabIndex = 0
        Me.piccliente.TabStop = False
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.White
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.Color.Black
        Me.txtbuscar.Location = New System.Drawing.Point(94, 234)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(429, 25)
        Me.txtbuscar.TabIndex = 0
        '
        'dgvlistado
        '
        Me.dgvlistado.AllowUserToAddRows = False
        Me.dgvlistado.AllowUserToDeleteRows = False
        Me.dgvlistado.AllowUserToResizeColumns = False
        Me.dgvlistado.AllowUserToResizeRows = False
        Me.dgvlistado.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgvlistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistado.Location = New System.Drawing.Point(60, 265)
        Me.dgvlistado.Name = "dgvlistado"
        Me.dgvlistado.ReadOnly = True
        Me.dgvlistado.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvlistado.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlistado.Size = New System.Drawing.Size(463, 296)
        Me.dgvlistado.TabIndex = 1
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(423, 34)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidcliente.TabIndex = 24
        Me.txtidcliente.Visible = False
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(652, 34)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(100, 20)
        Me.txtidempleado.TabIndex = 25
        Me.txtidempleado.Visible = False
        '
        'txtidetiqueta
        '
        Me.txtidetiqueta.Location = New System.Drawing.Point(758, 34)
        Me.txtidetiqueta.Name = "txtidetiqueta"
        Me.txtidetiqueta.Size = New System.Drawing.Size(100, 20)
        Me.txtidetiqueta.TabIndex = 26
        Me.txtidetiqueta.Visible = False
        '
        'dgvservicios
        '
        Me.dgvservicios.AllowUserToAddRows = False
        Me.dgvservicios.AllowUserToDeleteRows = False
        Me.dgvservicios.AllowUserToResizeColumns = False
        Me.dgvservicios.AllowUserToResizeRows = False
        Me.dgvservicios.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgvservicios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvservicios.Location = New System.Drawing.Point(583, 265)
        Me.dgvservicios.Name = "dgvservicios"
        Me.dgvservicios.ReadOnly = True
        Me.dgvservicios.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvservicios.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvservicios.Size = New System.Drawing.Size(381, 159)
        Me.dgvservicios.TabIndex = 29
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(298, 34)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 32
        Me.txtidventa.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label12.Location = New System.Drawing.Point(52, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 47)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Venta"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Transparent
        Me.btncancelar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.cancelar
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btncancelar.Location = New System.Drawing.Point(834, 476)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(66, 66)
        Me.btncancelar.TabIndex = 41
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.guardar
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnguardar.Location = New System.Drawing.Point(740, 476)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(66, 66)
        Me.btnguardar.TabIndex = 40
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnnuevo.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.nuevo
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.ForeColor = System.Drawing.Color.Transparent
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(642, 476)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(66, 66)
        Me.btnnuevo.TabIndex = 38
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'frmventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.back1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.txtidetiqueta)
        Me.Controls.Add(Me.txtidempleado)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.pandatosprin)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvlistado)
        Me.Controls.Add(Me.dgvservicios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmventas"
        Me.pandatossec.ResumeLayout(False)
        Me.pandatossec.PerformLayout()
        CType(Me.txtcantidads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatosprin.ResumeLayout(False)
        Me.pandatosprin.PerformLayout()
        CType(Me.piccliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvservicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pandatossec As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtetiqueta As TextBox
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents checkgenerico As CheckBox
    Friend WithEvents btbuscarc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnombrec As TextBox
    Friend WithEvents piccliente As PictureBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtempleado As TextBox
    Friend WithEvents btagregare As Button
    Friend WithEvents txtprecios As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btbuscars As Button
    Friend WithEvents btbuscare As Button
    Friend WithEvents txtcantidads As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents txtidetiqueta As TextBox
    Friend WithEvents dgvservicios As DataGridView
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
End Class
