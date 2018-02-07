<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmservicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.btbuscars = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btagregarc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigoColor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdiametro = New System.Windows.Forms.TextBox()
        Me.txtmediday = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmedidax = New System.Windows.Forms.TextBox()
        Me.txtarte = New System.Windows.Forms.TextBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtidcolor = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.txtidetiqueta = New System.Windows.Forms.TextBox()
        Me.dgvcolores = New System.Windows.Forms.DataGridView()
        Me.txtbandera = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pandatossec.SuspendLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcolores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.btbuscars)
        Me.pandatossec.Controls.Add(Me.txtprecio)
        Me.pandatossec.Controls.Add(Me.Label7)
        Me.pandatossec.Controls.Add(Me.btagregarc)
        Me.pandatossec.Controls.Add(Me.Label6)
        Me.pandatossec.Controls.Add(Me.Label2)
        Me.pandatossec.Controls.Add(Me.txtcodigoColor)
        Me.pandatossec.Controls.Add(Me.Label4)
        Me.pandatossec.Controls.Add(Me.txtdiametro)
        Me.pandatossec.Controls.Add(Me.txtmediday)
        Me.pandatossec.Controls.Add(Me.Label3)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtmedidax)
        Me.pandatossec.Controls.Add(Me.txtarte)
        Me.pandatossec.Location = New System.Drawing.Point(499, 239)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(463, 246)
        Me.pandatossec.TabIndex = 11
        '
        'btbuscars
        '
        Me.btbuscars.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscars.Location = New System.Drawing.Point(156, 169)
        Me.btbuscars.Name = "btbuscars"
        Me.btbuscars.Size = New System.Drawing.Size(25, 25)
        Me.btbuscars.TabIndex = 42
        Me.btbuscars.Text = "..."
        Me.btbuscars.UseVisualStyleBackColor = True
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        Me.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.txtprecio.ForeColor = System.Drawing.Color.Black
        Me.txtprecio.Location = New System.Drawing.Point(156, 200)
        Me.txtprecio.MaxLength = 10
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(287, 25)
        Me.txtprecio.TabIndex = 3
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(17, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Precio"
        '
        'btagregarc
        '
        Me.btagregarc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregarc.Location = New System.Drawing.Point(389, 169)
        Me.btagregarc.Name = "btagregarc"
        Me.btagregarc.Size = New System.Drawing.Size(54, 25)
        Me.btagregarc.TabIndex = 41
        Me.btagregarc.Text = "Add"
        Me.btagregarc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(19, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(18, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Diámetro"
        '
        'txtcodigoColor
        '
        Me.txtcodigoColor.Location = New System.Drawing.Point(187, 173)
        Me.txtcodigoColor.Name = "txtcodigoColor"
        Me.txtcodigoColor.Size = New System.Drawing.Size(196, 20)
        Me.txtcodigoColor.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(18, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Medida Y"
        '
        'txtdiametro
        '
        Me.txtdiametro.BackColor = System.Drawing.Color.White
        Me.txtdiametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiametro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiametro.ForeColor = System.Drawing.Color.Black
        Me.txtdiametro.Location = New System.Drawing.Point(157, 138)
        Me.txtdiametro.MaxLength = 10
        Me.txtdiametro.Name = "txtdiametro"
        Me.txtdiametro.Size = New System.Drawing.Size(287, 25)
        Me.txtdiametro.TabIndex = 11
        '
        'txtmediday
        '
        Me.txtmediday.BackColor = System.Drawing.Color.White
        Me.txtmediday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmediday.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmediday.ForeColor = System.Drawing.Color.Black
        Me.txtmediday.Location = New System.Drawing.Point(157, 107)
        Me.txtmediday.MaxLength = 60
        Me.txtmediday.Name = "txtmediday"
        Me.txtmediday.Size = New System.Drawing.Size(287, 25)
        Me.txtmediday.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Medida X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Descripcion"
        '
        'txtmedidax
        '
        Me.txtmedidax.BackColor = System.Drawing.Color.White
        Me.txtmedidax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmedidax.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedidax.ForeColor = System.Drawing.Color.Black
        Me.txtmedidax.Location = New System.Drawing.Point(156, 76)
        Me.txtmedidax.MaxLength = 10
        Me.txtmedidax.Name = "txtmedidax"
        Me.txtmedidax.Size = New System.Drawing.Size(287, 25)
        Me.txtmedidax.TabIndex = 5
        '
        'txtarte
        '
        Me.txtarte.BackColor = System.Drawing.Color.White
        Me.txtarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtarte.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarte.ForeColor = System.Drawing.Color.Black
        Me.txtarte.Location = New System.Drawing.Point(156, 18)
        Me.txtarte.MaxLength = 60
        Me.txtarte.Multiline = True
        Me.txtarte.Name = "txtarte"
        Me.txtarte.Size = New System.Drawing.Size(287, 52)
        Me.txtarte.TabIndex = 4
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
        Me.dgvlistado.Location = New System.Drawing.Point(60, 91)
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
        Me.dgvlistado.Size = New System.Drawing.Size(381, 278)
        Me.dgvlistado.TabIndex = 1
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.White
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.Color.Black
        Me.txtbuscar.Location = New System.Drawing.Point(94, 60)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(347, 25)
        Me.txtbuscar.TabIndex = 0
        '
        'pandatosprin
        '
        Me.pandatosprin.BackColor = System.Drawing.Color.White
        Me.pandatosprin.Controls.Add(Me.txtnombrecliente)
        Me.pandatosprin.Controls.Add(Me.lblcliente)
        Me.pandatosprin.Controls.Add(Me.txtnombre)
        Me.pandatosprin.Controls.Add(Me.lblprecio)
        Me.pandatosprin.Location = New System.Drawing.Point(501, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 134)
        Me.pandatosprin.TabIndex = 10
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.BackColor = System.Drawing.Color.White
        Me.txtnombrecliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombrecliente.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrecliente.ForeColor = System.Drawing.Color.Black
        Me.txtnombrecliente.Location = New System.Drawing.Point(152, 71)
        Me.txtnombrecliente.MaxLength = 40
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(289, 43)
        Me.txtnombrecliente.TabIndex = 12
        Me.txtnombrecliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblcliente.Location = New System.Drawing.Point(15, 73)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(102, 37)
        Me.lblcliente.TabIndex = 11
        Me.lblcliente.Text = "Cliente"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(154, 15)
        Me.txtnombre.MaxLength = 40
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(289, 43)
        Me.txtnombre.TabIndex = 10
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblprecio.Location = New System.Drawing.Point(15, 15)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(118, 37)
        Me.lblprecio.TabIndex = 9
        Me.lblprecio.Text = "Nombre"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label5.Location = New System.Drawing.Point(52, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 47)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Etiqueta"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Transparent
        Me.btncancelar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.cancelar
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btncancelar.Location = New System.Drawing.Point(899, 502)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(66, 66)
        Me.btncancelar.TabIndex = 36
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.guardar
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnguardar.Location = New System.Drawing.Point(699, 502)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(66, 66)
        Me.btnguardar.TabIndex = 35
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.Transparent
        Me.btneditar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.editar
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.ForeColor = System.Drawing.Color.Transparent
        Me.btneditar.Location = New System.Drawing.Point(599, 502)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(66, 66)
        Me.btneditar.TabIndex = 34
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.Transparent
        Me.btneliminar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.eliminar
        Me.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btneliminar.Location = New System.Drawing.Point(799, 502)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(66, 66)
        Me.btneliminar.TabIndex = 37
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnnuevo.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.nuevo
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.ForeColor = System.Drawing.Color.Transparent
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(499, 502)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(66, 66)
        Me.btnnuevo.TabIndex = 33
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.busqueda
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(58, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'txtidcolor
        '
        Me.txtidcolor.Location = New System.Drawing.Point(501, 213)
        Me.txtidcolor.Name = "txtidcolor"
        Me.txtidcolor.Size = New System.Drawing.Size(100, 20)
        Me.txtidcolor.TabIndex = 39
        Me.txtidcolor.Visible = False
        '
        'txtidetiqueta
        '
        Me.txtidetiqueta.Location = New System.Drawing.Point(627, 33)
        Me.txtidetiqueta.Name = "txtidetiqueta"
        Me.txtidetiqueta.Size = New System.Drawing.Size(100, 20)
        Me.txtidetiqueta.TabIndex = 40
        Me.txtidetiqueta.Visible = False
        '
        'dgvcolores
        '
        Me.dgvcolores.AllowUserToAddRows = False
        Me.dgvcolores.AllowUserToDeleteRows = False
        Me.dgvcolores.AllowUserToResizeColumns = False
        Me.dgvcolores.AllowUserToResizeRows = False
        Me.dgvcolores.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgvcolores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvcolores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcolores.Location = New System.Drawing.Point(60, 426)
        Me.dgvcolores.Name = "dgvcolores"
        Me.dgvcolores.ReadOnly = True
        Me.dgvcolores.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvcolores.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcolores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcolores.Size = New System.Drawing.Size(381, 180)
        Me.dgvcolores.TabIndex = 41
        '
        'txtbandera
        '
        Me.txtbandera.Location = New System.Drawing.Point(501, 34)
        Me.txtbandera.Name = "txtbandera"
        Me.txtbandera.Size = New System.Drawing.Size(100, 20)
        Me.txtbandera.TabIndex = 17
        Me.txtbandera.Text = "0"
        Me.txtbandera.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(53, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 37)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Colores"
        '
        'frmservicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.back1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvcolores)
        Me.Controls.Add(Me.txtidetiqueta)
        Me.Controls.Add(Me.txtidcolor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbandera)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.dgvlistado)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.pandatosprin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmservicio"
        Me.Text = "frmproducto"
        Me.pandatossec.ResumeLayout(False)
        Me.pandatossec.PerformLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatosprin.ResumeLayout(False)
        Me.pandatosprin.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcolores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pandatossec As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmedidax As TextBox
    Friend WithEvents txtarte As TextBox
    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents lblprecio As Label
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdiametro As TextBox
    Friend WithEvents txtmediday As TextBox
    Friend WithEvents txtidcolor As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents txtcodigoColor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btagregarc As Button
    Friend WithEvents btbuscars As Button
    Friend WithEvents txtidetiqueta As TextBox
    Friend WithEvents dgvcolores As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lblcliente As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtbandera As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnombrecliente As TextBox
End Class
