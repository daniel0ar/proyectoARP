<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusuario
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
        Me.pnlogin = New System.Windows.Forms.Panel()
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnueva = New System.Windows.Forms.TextBox()
        Me.txtactual = New System.Windows.Forms.TextBox()
        Me.pnlogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlogin
        '
        Me.pnlogin.BackColor = System.Drawing.Color.White
        Me.pnlogin.Controls.Add(Me.btcancelar)
        Me.pnlogin.Controls.Add(Me.btguardar)
        Me.pnlogin.Controls.Add(Me.Label9)
        Me.pnlogin.Controls.Add(Me.Label10)
        Me.pnlogin.Controls.Add(Me.txtnueva)
        Me.pnlogin.Controls.Add(Me.txtactual)
        Me.pnlogin.Location = New System.Drawing.Point(312, 245)
        Me.pnlogin.Name = "pnlogin"
        Me.pnlogin.Size = New System.Drawing.Size(400, 131)
        Me.pnlogin.TabIndex = 5
        '
        'btcancelar
        '
        Me.btcancelar.Location = New System.Drawing.Point(245, 88)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(135, 23)
        Me.btcancelar.TabIndex = 3
        Me.btcancelar.Text = "Cancelar"
        Me.btcancelar.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(100, 88)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(135, 23)
        Me.btguardar.TabIndex = 2
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(17, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nueva contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(17, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Contraseña actual"
        '
        'txtnueva
        '
        Me.txtnueva.BackColor = System.Drawing.Color.White
        Me.txtnueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnueva.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnueva.ForeColor = System.Drawing.Color.Black
        Me.txtnueva.Location = New System.Drawing.Point(141, 51)
        Me.txtnueva.MaxLength = 10
        Me.txtnueva.Name = "txtnueva"
        Me.txtnueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtnueva.Size = New System.Drawing.Size(239, 25)
        Me.txtnueva.TabIndex = 1
        '
        'txtactual
        '
        Me.txtactual.BackColor = System.Drawing.Color.White
        Me.txtactual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtactual.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtactual.ForeColor = System.Drawing.Color.Black
        Me.txtactual.Location = New System.Drawing.Point(141, 20)
        Me.txtactual.MaxLength = 10
        Me.txtactual.Name = "txtactual"
        Me.txtactual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtactual.Size = New System.Drawing.Size(239, 25)
        Me.txtactual.TabIndex = 0
        '
        'frmusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.pnlogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmusuario"
        Me.pnlogin.ResumeLayout(False)
        Me.pnlogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlogin As Panel
    Friend WithEvents btcancelar As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnueva As TextBox
    Friend WithEvents txtactual As TextBox
End Class
