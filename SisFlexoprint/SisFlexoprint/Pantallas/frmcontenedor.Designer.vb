<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcontenedor
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
        Me.pnbotones = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btconfiguracion = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btventas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btempleados = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btclientes = New System.Windows.Forms.Button()
        Me.pnbotones2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btcerrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btproductos = New System.Windows.Forms.Button()
        Me.btminimizar = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.pnpantallas = New System.Windows.Forms.Panel()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.pnlogin = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btingresar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.pnbotones.SuspendLayout()
        Me.pnbotones2.SuspendLayout()
        Me.pnpantallas.SuspendLayout()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnbotones
        '
        Me.pnbotones.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnbotones.Controls.Add(Me.Label4)
        Me.pnbotones.Controls.Add(Me.btconfiguracion)
        Me.pnbotones.Controls.Add(Me.Label5)
        Me.pnbotones.Controls.Add(Me.btventas)
        Me.pnbotones.Controls.Add(Me.Label1)
        Me.pnbotones.Controls.Add(Me.btempleados)
        Me.pnbotones.Controls.Add(Me.Label3)
        Me.pnbotones.Controls.Add(Me.btclientes)
        Me.pnbotones.Location = New System.Drawing.Point(0, 0)
        Me.pnbotones.Name = "pnbotones"
        Me.pnbotones.Size = New System.Drawing.Size(80, 621)
        Me.pnbotones.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 582)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Settings"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Visible = False
        '
        'btconfiguracion
        '
        Me.btconfiguracion.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btconfiguracion.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.Configuración
        Me.btconfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btconfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btconfiguracion.FlatAppearance.BorderSize = 0
        Me.btconfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btconfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btconfiguracion.Location = New System.Drawing.Point(15, 529)
        Me.btconfiguracion.Name = "btconfiguracion"
        Me.btconfiguracion.Size = New System.Drawing.Size(50, 50)
        Me.btconfiguracion.TabIndex = 43
        Me.btconfiguracion.UseVisualStyleBackColor = False
        Me.btconfiguracion.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Ventas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btventas
        '
        Me.btventas.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btventas.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.ventas
        Me.btventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btventas.FlatAppearance.BorderSize = 0
        Me.btventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btventas.Location = New System.Drawing.Point(15, 29)
        Me.btventas.Name = "btventas"
        Me.btventas.Size = New System.Drawing.Size(50, 50)
        Me.btventas.TabIndex = 39
        Me.btventas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Empleados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btempleados
        '
        Me.btempleados.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btempleados.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.empleados
        Me.btempleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btempleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btempleados.FlatAppearance.BorderSize = 0
        Me.btempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btempleados.Location = New System.Drawing.Point(15, 183)
        Me.btempleados.Name = "btempleados"
        Me.btempleados.Size = New System.Drawing.Size(50, 50)
        Me.btempleados.TabIndex = 2
        Me.btempleados.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btclientes
        '
        Me.btclientes.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btclientes.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.clientes
        Me.btclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btclientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btclientes.FlatAppearance.BorderSize = 0
        Me.btclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btclientes.Location = New System.Drawing.Point(15, 106)
        Me.btclientes.Name = "btclientes"
        Me.btclientes.Size = New System.Drawing.Size(50, 50)
        Me.btclientes.TabIndex = 1
        Me.btclientes.UseVisualStyleBackColor = False
        '
        'pnbotones2
        '
        Me.pnbotones2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnbotones2.Controls.Add(Me.Label7)
        Me.pnbotones2.Controls.Add(Me.btcerrar)
        Me.pnbotones2.Controls.Add(Me.Label6)
        Me.pnbotones2.Controls.Add(Me.btproductos)
        Me.pnbotones2.Location = New System.Drawing.Point(1104, 0)
        Me.pnbotones2.Name = "pnbotones2"
        Me.pnbotones2.Size = New System.Drawing.Size(80, 621)
        Me.pnbotones2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 581)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 40)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Cerrar Sesión"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btcerrar
        '
        Me.btcerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btcerrar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.LeftArrow
        Me.btcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btcerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btcerrar.FlatAppearance.BorderSize = 0
        Me.btcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcerrar.Location = New System.Drawing.Point(15, 529)
        Me.btcerrar.Name = "btcerrar"
        Me.btcerrar.Size = New System.Drawing.Size(50, 50)
        Me.btcerrar.TabIndex = 45
        Me.btcerrar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Etiquetas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btproductos
        '
        Me.btproductos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btproductos.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.eiquetas
        Me.btproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btproductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btproductos.FlatAppearance.BorderSize = 0
        Me.btproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btproductos.Location = New System.Drawing.Point(15, 29)
        Me.btproductos.Name = "btproductos"
        Me.btproductos.Size = New System.Drawing.Size(50, 50)
        Me.btproductos.TabIndex = 39
        Me.btproductos.UseVisualStyleBackColor = False
        '
        'btminimizar
        '
        Me.btminimizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btminimizar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.Minimizar
        Me.btminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btminimizar.FlatAppearance.BorderSize = 0
        Me.btminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btminimizar.Location = New System.Drawing.Point(1148, 3)
        Me.btminimizar.Name = "btminimizar"
        Me.btminimizar.Size = New System.Drawing.Size(15, 15)
        Me.btminimizar.TabIndex = 43
        Me.btminimizar.UseVisualStyleBackColor = False
        '
        'btexit
        '
        Me.btexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btexit.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.Salir
        Me.btexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btexit.FlatAppearance.BorderSize = 0
        Me.btexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btexit.Location = New System.Drawing.Point(1166, 3)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(15, 15)
        Me.btexit.TabIndex = 42
        Me.btexit.UseVisualStyleBackColor = False
        '
        'pnpantallas
        '
        Me.pnpantallas.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.back1
        Me.pnpantallas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnpantallas.Controls.Add(Me.pblogo)
        Me.pnpantallas.Location = New System.Drawing.Point(80, 0)
        Me.pnpantallas.Name = "pnpantallas"
        Me.pnpantallas.Size = New System.Drawing.Size(1024, 621)
        Me.pnpantallas.TabIndex = 45
        '
        'pblogo
        '
        Me.pblogo.BackColor = System.Drawing.Color.Transparent
        Me.pblogo.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.logoFlexo
        Me.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pblogo.Location = New System.Drawing.Point(398, 28)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(201, 205)
        Me.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblogo.TabIndex = 44
        Me.pblogo.TabStop = False
        '
        'pnlogin
        '
        Me.pnlogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlogin.Controls.Add(Me.Label8)
        Me.pnlogin.Controls.Add(Me.Label2)
        Me.pnlogin.Controls.Add(Me.btsalir)
        Me.pnlogin.Controls.Add(Me.btingresar)
        Me.pnlogin.Controls.Add(Me.Label9)
        Me.pnlogin.Controls.Add(Me.Label10)
        Me.pnlogin.Controls.Add(Me.txtpassword)
        Me.pnlogin.Controls.Add(Me.txtuser)
        Me.pnlogin.Location = New System.Drawing.Point(392, 245)
        Me.pnlogin.Name = "pnlogin"
        Me.pnlogin.Size = New System.Drawing.Size(400, 201)
        Me.pnlogin.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(153, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Iniciar Sesión"
        '
        'btingresar
        '
        Me.btingresar.BackColor = System.Drawing.Color.Transparent
        Me.btingresar.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.login
        Me.btingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btingresar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btingresar.Location = New System.Drawing.Point(167, 92)
        Me.btingresar.Name = "btingresar"
        Me.btingresar.Size = New System.Drawing.Size(66, 59)
        Me.btingresar.TabIndex = 3
        Me.btingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btingresar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(17, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(17, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Usuario"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(100, 51)
        Me.txtpassword.MaxLength = 10
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtpassword.Size = New System.Drawing.Size(280, 25)
        Me.txtpassword.TabIndex = 2
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.White
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Black
        Me.txtuser.Location = New System.Drawing.Point(100, 20)
        Me.txtuser.MaxLength = 40
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(280, 25)
        Me.txtuser.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(235, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Empleado"
        Me.Label8.Visible = False
        '
        'btsalir
        '
        Me.btsalir.BackColor = System.Drawing.Color.Transparent
        Me.btsalir.BackgroundImage = Global.SisFlexoprint.My.Resources.Resources.empleado
        Me.btsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btsalir.Enabled = False
        Me.btsalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalir.Location = New System.Drawing.Point(239, 85)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(66, 66)
        Me.btsalir.TabIndex = 4
        Me.btsalir.UseVisualStyleBackColor = False
        Me.btsalir.Visible = False
        '
        'frmcontenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 621)
        Me.Controls.Add(Me.btminimizar)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.pnlogin)
        Me.Controls.Add(Me.pnbotones)
        Me.Controls.Add(Me.pnbotones2)
        Me.Controls.Add(Me.pnpantallas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcontenedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "z"
        Me.pnbotones.ResumeLayout(False)
        Me.pnbotones.PerformLayout()
        Me.pnbotones2.ResumeLayout(False)
        Me.pnbotones2.PerformLayout()
        Me.pnpantallas.ResumeLayout(False)
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlogin.ResumeLayout(False)
        Me.pnlogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnbotones As Panel
    Friend WithEvents btclientes As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btempleados As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btventas As Button
    Friend WithEvents pnbotones2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btproductos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btconfiguracion As Button
    Friend WithEvents btexit As Button
    Friend WithEvents btminimizar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btcerrar As Button
    Friend WithEvents pblogo As PictureBox
    Friend WithEvents pnpantallas As Panel
    Friend WithEvents pnlogin As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btingresar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btsalir As Button
End Class
