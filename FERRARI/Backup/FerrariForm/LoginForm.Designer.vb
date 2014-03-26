<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtContrasena = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ok = New System.Windows.Forms.Button
        Me.cancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtContrasena)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(80, 45)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 3
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(80, 19)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'ok
        '
        Me.ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ok.Location = New System.Drawing.Point(35, 99)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 1
        Me.ok.Text = "&Aceptar"
        Me.ok.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelar.Location = New System.Drawing.Point(124, 99)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cancelar.TabIndex = 2
        Me.cancelar.Text = "&Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AcceptButton = Me.ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelar
        Me.ClientSize = New System.Drawing.Size(240, 133)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticacion de Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents cancelar As System.Windows.Forms.Button
End Class
